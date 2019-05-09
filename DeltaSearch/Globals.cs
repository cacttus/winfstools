using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DeltaSearch
{
    public static class Globals
    {
        public static string ProgramName = "DeltaSearch";
        public static string ProgramVersion = "1.0.0.1";
        public static string ProgramAuthor = "Derek Page";

        public static MainForm MainForm { get; private set; }
        public static void SetMainForm(MainForm mf) { MainForm = mf; }
        public static void LogInfo(string x) { }
        public static void LogError(string x) { }
        public static void LogWarn(string x) { }
        public static string GetSettingsFilePath()
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string CHMSearchPath = Path.Combine(appdata, "CHMSearch");
            string CHMSearchPrefs = Path.Combine(CHMSearchPath, "Prefs.txt");
            return CHMSearchPrefs;
        }
        public static DateTime GetLinkerTime(this Assembly assembly, TimeZoneInfo target = null)
        {
            var filePath = assembly.Location;
            const int c_PeHeaderOffset = 60;
            const int c_LinkerTimestampOffset = 8;

            var buffer = new byte[2048];

            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                stream.Read(buffer, 0, 2048);

            var offset = BitConverter.ToInt32(buffer, c_PeHeaderOffset);
            var secondsSince1970 = BitConverter.ToInt32(buffer, offset + c_LinkerTimestampOffset);
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            var linkTimeUtc = epoch.AddSeconds(secondsSince1970);

            var tz = target ?? TimeZoneInfo.Local;
            var localTime = TimeZoneInfo.ConvertTimeFromUtc(linkTimeUtc, tz);

            return localTime;
        }
        public static string GetSha256Hash(SHA256 shaHash, string input)
        {
            https://stackoverflow.com/questions/38043954/generate-unique-hash-code-based-on-string
            // Convert the input string to a byte array and compute the hash.
            byte[] data = shaHash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        public static int ParseInt(string st, int def)
        {
            int n = 0;
            if (Int32.TryParse(st, out n))
            {
                return n;
            }
            return def;
        }
        public static bool ParseBool(string st, bool def)
        {
            bool n = false;
            if (Boolean.TryParse(st, out n))
            {
                return n;
            }
            return def;
        }
        public static double ParseDouble(string st, double def)
        {
            double n = 0.0;
            if (Double.TryParse(st, out n))
            {
                return n;
            }
            return def;
        }
        public static void SwapControl(Control ctlToReplace, Control newCtl)
        {
            newCtl.Bounds = ctlToReplace.Bounds;
            Control parent = ctlToReplace.Parent;
            newCtl.Anchor = ctlToReplace.Anchor;
            newCtl.Dock = ctlToReplace.Dock;
            parent.Controls.Remove(ctlToReplace);
            parent.Controls.Add(newCtl);
        }

    }
}
