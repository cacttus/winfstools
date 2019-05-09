using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Collections.Specialized;
using System.Security.Cryptography;
namespace Rifle
{
    /// <summary>
    /// Base class for activating.  This is an instance class.
    /// Create an instance and call Activate()
    /// </summary>
    public class Activator
    {
        public bool IsValidated = false;
        public bool IsActivated = false;
        public bool IsError = false;
        public string ErrorLog = "";

        private System.Random _objRandom = new System.Random(System.Environment.TickCount);
        private ActivatorConfiguration _objActivatorConfiguration;
        private List<Control> _objHiddenControlList = new List<Control>();
        
        #region Public:Methods

        public Activator(ActivatorConfiguration aobjConfig)
        {
            _objActivatorConfiguration = aobjConfig;
        }
        public void DeleteRegKeys()
        {
            Microsoft.Win32.RegistryKey appKey = System.Windows.Forms.Application.UserAppDataRegistry;
            string serialRegKey = _objActivatorConfiguration.SerialRegKeyName;
            string activationRegKey = _objActivatorConfiguration.ActivationRegKeyName;

            if (!String.IsNullOrEmpty((string)appKey.GetValue(serialRegKey)))
                appKey.DeleteValue(serialRegKey);
            if (!String.IsNullOrEmpty((string)appKey.GetValue(activationRegKey)))
                appKey.DeleteValue(activationRegKey);
        }

        public bool CheckActivation()
        {
            string key1 = "", key2 = "";
            try
            {
                int n = 0;
                if(n!=0)
                    DeleteRegKeys();
                if (_objActivatorConfiguration.AlwaysGenerateSerial)
                {
                    //always make a serial - this will invalidate the reg key if the user changes MAC or PC name
                    key1 = GetSerial();
                }
                else
                {
                    key1 = (string)System.Windows.Forms.Application.UserAppDataRegistry.GetValue(_objActivatorConfiguration.SerialRegKeyName);
                    if (String.IsNullOrEmpty(key1))
                        return false;
                }

                key2 = (string)System.Windows.Forms.Application.UserAppDataRegistry.GetValue(_objActivatorConfiguration.ActivationRegKeyName);
                if (String.IsNullOrEmpty(key2))
                    return false;
            }
            catch (Exception ex)
            {
                //TODO: log shit
                IsError = true;
                ErrorLog += ex.ToString();
            }
            //**Don't validate here.  User is already validated via reg keys.
            //if (!Validate(key1, key2))
            //    return false;
            this.IsValidated = this.IsActivated = true;
            return true;
        }
        public bool Activate(string serial, string key)
        {
            IsError = false;
            ErrorLog = "";

            // check that our config is okay.
            _objActivatorConfiguration.Validate();

            if (!Validate(serial, key))
                return false;

            //We are validated.
            //Set the reg keys.
            if (_objActivatorConfiguration.AlwaysGenerateSerial == false)
                System.Windows.Forms.Application.UserAppDataRegistry.SetValue(_objActivatorConfiguration.SerialRegKeyName, serial, Microsoft.Win32.RegistryValueKind.String);
            System.Windows.Forms.Application.UserAppDataRegistry.SetValue(_objActivatorConfiguration.ActivationRegKeyName, key, Microsoft.Win32.RegistryValueKind.String);

            IsActivated = true;
            return true;
        }
        public void ForceActivation(Form objForm)
        {
            HideAllControls(objForm);

            //Utility method to force the appliation to activate by showing a modal popup.
            if (CheckActivation() == true)
            {
                if (IsActivated && IsValidated)
                {
                    ShowAllControls(objForm);
                    return;
                }
            }

            ShowActivationDialog();
            if (IsActivated && IsValidated)
                ShowAllControls(objForm);
        }
        
        public string GetUserSerial()
        {
            string strHash = GetSerial();
            strHash = SerialKeyToChunkedKey(strHash);
            return strHash;
        }
        public string SerialKeyToChunkedKey(string strKeyValue)
        {
            // Util method to get a "friendly" key in groups of 5 with a dash.

            string strRet = "";
            for (int n = 0; n < strKeyValue.Length; n++)
            {
                strRet += strKeyValue[n];
                if ((n + 1) % _objActivatorConfiguration.KeyChunkLength == 0)
                    strRet += _objActivatorConfiguration.KeyChunkDelimiter;
            }
            strRet = strRet.Trim(_objActivatorConfiguration.KeyChunkDelimiter);
            strRet = strRet.Trim();
            return strRet;
        }
        public string ChunkedKeyToSerialKey(string strKeyValue)
        {
            // Util method to convert the "friendly" key to a serial string.
            string strNewValue = strKeyValue;
            strNewValue = strNewValue.Replace(_objActivatorConfiguration.KeyChunkDelimiter.ToString(), String.Empty);
            strNewValue = strNewValue.Replace(" ", String.Empty);
            strNewValue = strNewValue.Replace("\t", String.Empty);
            strNewValue = strNewValue.Replace("\r", String.Empty);
            strNewValue = strNewValue.Replace("\n", String.Empty);
            strNewValue = strNewValue.Trim();
            return strNewValue;
        }

        #endregion

        #region Private:Methods

        private bool Validate(string serial, string key)
        {
            string strHash;
            string strKey = key;

            if (String.IsNullOrEmpty(strKey))
                return false;
            if (strKey.Length < _objActivatorConfiguration.MaxKeyLength)//avoid substr problem
                return false;

            if (_objActivatorConfiguration.WebAuthorizeUrl != "")
            {
                // - If the web URL is not null then we are going out to the web to authorize.
                // If we can't connect (no internet connection) we are still going to block user
                // from the app.

                strHash = WebAuthorize(key, serial);
                if (!string.Equals(strHash, _objActivatorConfiguration.TrueReturnValue))
                    return false;
            }
            else
            {
                  strHash = EncryptionUtils.CalculateSHA256Hash(serial);

                  if (strHash.Length < _objActivatorConfiguration.MaxKeyLength)
                      return false;

                  strHash = strHash.Substring(0, _objActivatorConfiguration.MaxKeyLength);// Only use 35 characters - this avoids the user having to type a ton of shit.
                  strKey = strKey.Substring(0, _objActivatorConfiguration.MaxKeyLength);

                  if (!string.Equals(strHash, strKey))
                      return false;

                
            }
            IsValidated = true;
            IsActivated = true;

            return true;
        }


        private string GetSerial()
        {
            string seed = GetSerialSeed();
            string strHash = EncryptionUtils.CalculateSHA256Hash(seed);
            strHash = strHash.Substring(0, _objActivatorConfiguration.MaxKeyLength); // Only use 35 characters - this avoids the user having to type a ton of shit.
            return strHash;
        }
        private string GetSerialSeed()
        {
            string strSeed = "";
            strSeed += System.Environment.MachineName;
            strSeed += GetMacAddress();
            strSeed += _objActivatorConfiguration.UniqueAppIdentifier;
            return strSeed;
        }
        private string GenerateStringKey(int length)
        {
            return System.Text.Encoding.GetEncoding("iso-8859-1").GetString(GenerateByteKey(length));
        }
        private byte[] GenerateByteKey(int length)
        {
            byte[] ret;
            ret = new byte[length];

            for (int n = 0; n < length; n++)
            {
                ret[n] = (byte)(_objRandom.Next() % 256);
                Console.Write(ret[n] + ",");

            }
            return ret;
        }

        private string BytesToIso8859_1(byte[] input)
        {
            string ret = Encoding.GetEncoding("iso-8859-1").GetString(input, 0, input.Length);
            return ret;
        }
        private string WebAuthorize(string productKey, string productSerial)
        {
            string strRet = string.Empty;
            Encoding objIso8859 = System.Text.Encoding.GetEncoding("iso-8859-1");

            try
            {
                using (WebClient wb = new WebClient())
                {

                    //string aesKey = GenerateStringKey(128);
                    // string aesIv = GenerateStringKey(16);
                   // string aesKey = "tg?G?5?TS???x???uP\b}>???3/??(";
                    string aesKey = objIso8859.GetString(_objActivatorConfiguration.ByteKey);
                    string aesIv = GenerateStringKey(16);// "123456789abcdefg";

                    byte[] aesKeyBytes = objIso8859.GetBytes(aesKey);
                    byte[] aesIvBytes = objIso8859.GetBytes(aesIv);

                    int keyLen = aesKey.Length;
                    int ivLen = aesIv.Length;

                    int activationType = (int)_objActivatorConfiguration.ActivationMethod;
                    string strMessage = productKey + "|" + productSerial + "|" + activationType.ToString();

                    //string padStr = PadStringPkcs7(, 128);
                    //int pslen = padStr.Length;

                    byte[] encryptedData = EncryptionUtils.EncryptAes(strMessage, aesKeyBytes, aesIvBytes);

                    encryptedData = EncryptionUtils.PadBytesPkcs7(encryptedData, 128);
                    
                    //**Keep this here - we attempt to decrypt in order to make sure our encryption did not fail.
                    string strTest = EncryptionUtils.DecryptAes(encryptedData, aesKeyBytes, aesIvBytes);

                    NameValueCollection data = new NameValueCollection();
                    data[_objActivatorConfiguration.PostDataKey] = aesIv + BytesToIso8859_1(encryptedData);

                    // **** Send Values
                    //Critical - we must send in UTF-8
                    wb.Encoding = Encoding.UTF8;
                    byte[] responseBytes = wb.UploadValues(_objActivatorConfiguration.WebAuthorizeUrl, "POST", data);

                    /// ***** Decrypt returned message.
                    string strFinal="";
                    strRet = System.Text.Encoding.UTF8.GetString(responseBytes);
                    if (strRet.Length > 2)
                    {
                        strRet = strRet.Substring(0, strRet.Length - 2);
                        int retLen = strRet.Length;

                        // Cut IV from start of string, and response from the end.
                        aesIvBytes = objIso8859.GetBytes(strRet.Substring(0, 16));
                        responseBytes = objIso8859.GetBytes(strRet.Substring(16));

                        // This should be handled on the server side.  Try it here again anyway.
                        responseBytes = EncryptionUtils.PadBytesPkcs7(responseBytes, 128);

                        strFinal = EncryptionUtils.DecryptAes(responseBytes, aesKeyBytes, aesIvBytes);
                    }
                    strRet = strFinal;
                }
            }
            catch (Exception ex)
            {
                IsError = true;
                ErrorLog += ex.ToString();
            }

            return strRet;
        }


        private void HideAllControls(Form objForm)
        {
            foreach (Control c in objForm.Controls)
            {
                _objHiddenControlList.Add(c);
                c.Hide();
            }
        }
        private void ShowAllControls(Form objForm)
        {
            foreach (Control c in _objHiddenControlList)
            {
                c.Show();
            }
            _objHiddenControlList.Clear();
        }
        private void ShowActivationDialog()
        {
            Form x;

            if(this._objActivatorConfiguration.ActivationMethod == ActivationMethod.EmailSerial)
                x = new ActivationDialogEmail(this);
            else
                x = new ActivationDialog(this);

            x.ShowDialog();
        }
        private string GetMacAddress()
        {
            const int MIN_MAC_ADDR_LENGTH = 12;
            string macAddress = string.Empty;
            long maxSpeed = -1;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                string tempMac = nic.GetPhysicalAddress().ToString();
                if (nic.Speed > maxSpeed &&
                    !string.IsNullOrEmpty(tempMac) &&
                    tempMac.Length >= MIN_MAC_ADDR_LENGTH)
                {
                    maxSpeed = nic.Speed;
                    macAddress = tempMac;
                }
            }

            return macAddress;
        }
        #endregion

    }
}
