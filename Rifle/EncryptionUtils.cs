using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.IO;

namespace Rifle
{
    public class EncryptionUtils
    {
        private const int _cintAesBlockSize = 128;
        private const CipherMode _cCipherMode = CipherMode.CBC;
       
        public static byte[] PadBytesPkcs7(byte[] bytes, int blockSizeInBits = 128)
        {
            // Ok so for AES you have to pad your crap to the nearest 128 bits.  All Input data are 128 bit aligned.
            List<byte> ret = bytes.ToList();
            int intByteCount = (blockSizeInBits / 8); // bytes from bits

            if (ret.Count % intByteCount == 0)
                return ret.ToArray(); // - No padding required.

            int intPadCount = intByteCount - (ret.Count % intByteCount); // Get remainder we need to pad

            // ** Pad string to correct byte count.
            for (int n = 0; n < intPadCount; ++n)
            {
                ret.Add((byte)intPadCount);
            }

            return ret.ToArray();
        }
        public static string CalculateSHA256Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            System.Security.Cryptography.SHA256 sh2 = System.Security.Cryptography.SHA256.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = sh2.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString().ToUpper().Trim();
        }
        public static byte[] EncryptAes(string plainText, byte[] Key, byte[] IV)
        {
            if (_cintAesBlockSize % 8 != 0)
                throw new Exception("Invalid AES block size.");
            if (Key.Length != _cintAesBlockSize / 8)
                throw new Exception("Invalid key size.");
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new Exception("plainText");
            if (Key == null || Key.Length <= 0)
                throw new Exception("Key");
            if (IV == null || IV.Length <= 0)
                throw new Exception("IV");

            byte[] encrypted;

            // Create an RijndaelManaged object
            // with the specified key and IV.
            Aes objAes = Aes.Create();
            objAes.BlockSize = _cintAesBlockSize;
            objAes.Key = Key;
            objAes.IV = IV;
            objAes.Mode = _cCipherMode;

            // rijAlg.Mode = _cCipherMode;
            //rijAlg.BlockSize = _cintAesBlockSize;

            // Create a decrytor to perform the stream transform.
            ICryptoTransform encryptor = objAes.CreateEncryptor(objAes.Key, objAes.IV);

            // Create the streams used for encryption.
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {

                        //Write all data to the stream.
                        swEncrypt.Write(plainText);
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }
        public static string DecryptAes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            if (_cintAesBlockSize % 8 != 0)
                throw new Exception("Invalid AES block size.");
            if (Key.Length != _cintAesBlockSize / 8)
                throw new Exception("Invalid key size.");
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an RijndaelManaged object
            // with the specified key and IV.
            Aes objAes = Aes.Create();

            objAes.BlockSize = _cintAesBlockSize;
            objAes.Key = Key;
            objAes.IV = IV;
            objAes.Mode = _cCipherMode;

            // Create a decrytor to perform the stream transform.
            ICryptoTransform decryptor = objAes.CreateDecryptor(objAes.Key, objAes.IV);

            // Create the streams used for decryption.
            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {

                        // Read the decrypted bytes from the decrypting stream
                        // and place them in a string.
                        plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }

            return plaintext;
        }
    }
}
