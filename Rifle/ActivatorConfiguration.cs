using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rifle
{
    public enum ActivationMethod
    {
        //**Important: make sure the order of this aligns with the PHP activation method!   
        EmailSerial = 1,    // user sends email / serial to server
        SerialLicense = 2   // user sends serial / license to server.
    }
    public class ActivatorConfiguration
    {
        #region Public: Properties

        public bool AlwaysGenerateSerial     = false;// if AlwaysGenerateSerial is true then the computer will NOT store the computer MAC and computer NAME in the registry.  if the MAC or NAME  changes the product will deactivate if the user changes his MAC or PC name.
        public string UniqueAppIdentifier    = ""; //  Set Manually
        
        // Activation Method
        public ActivationMethod ActivationMethod = ActivationMethod.EmailSerial;

        // Serial Key Generation
        public int  KeyChunkLength           = 5;  // Key chunk length e.g. 00000-00000-
        public int  MaxKeyLength             = 35; // Maximum size of a key - must be a multiple of KeyChunkLength
        public char KeyChunkDelimiter        = '-';
     
        // Web Authorization
        public string WebAuthorizeUrl        = ""; //Note: If not specified we run a sha-256 client validation.
        public string TrueReturnValue        = "0jvs93nfe9sjnd97"; // the identifier of "true" in the returned string.  Looks like a hash, but its just an ID.
        public string FalseReturnValue       = "y03mgf98sdjds03d"; // the "false" identifier
        public string PostDataKey            = "0a3c4daf92dbc9c801f958c398"; // key in the post data array that holds encrypted info.

        //Registry Keys
        public string ActivationRegKeyName   = "a89x0c0c89f4c4dg5hd0129sds184c3s718s";
        public string SerialRegKeyName       = "bc981f9smf09gmf802b6b2734s0fm887cns7";
       

        //Encryption Key ** Sensitive Info **
        public byte[] ByteKey = new byte[] {
                                                61 ,85 ,223,34 ,
                                                11 ,28 ,128,93 ,
                                                221,150,230,83 ,
                                                182,217,156,97 
                                            };

        #endregion

        public ActivatorConfiguration(string astrUniqueAppIdentifier, 
                                      string astrWebAuthorizeUrl = "", 
                                      bool ablnAlwaysGenerateSerial = false
                                     )
        {
            UniqueAppIdentifier = astrUniqueAppIdentifier;
            WebAuthorizeUrl = astrWebAuthorizeUrl;
            AlwaysGenerateSerial = ablnAlwaysGenerateSerial;
        }
        public void Validate()
        {
            // Make sure configuration is vlaid.

            if (MaxKeyLength % KeyChunkLength != 0)
                throw new Exception("Serial Key Length is not a multiple of key chunk length.");

            if (ByteKey.Length != 16)
                throw new Exception("Encryption key was not the correct size.");

        }

    }
}
