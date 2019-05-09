using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifle
{
    public class RifleUtils
    {
        // Debug Enabled.
        public static bool IsDebugEnabled = true;

        public static void WaitForTrue(Func<bool> myFunc, int intTimeoutMilliseconds = 1000)
        {
            int tA, tB;
            tA = System.Environment.TickCount;
            tB = System.Environment.TickCount;
            while (((tB - tA) < intTimeoutMilliseconds) && !(myFunc()))
                System.Windows.Forms.Application.DoEvents();
        }

        public static void ForceWindowFocus(System.Windows.Forms.Form objForm, int intTimeoutMilliseconds = 1000)
        {
            int tA, tB;
            tA = System.Environment.TickCount;
            tB = System.Environment.TickCount;

            IntPtr ip = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;

            while (((tB - tA) < intTimeoutMilliseconds) && Native.GetForegroundWindow() == ip) {

                objForm.TopMost = true;
                objForm.TopMost = false;
                objForm.Activate();
                //Native.SwitchToThisWindow(ip, true);
                // Native.SetForegroundWindow(ip);
                System.Windows.Forms.Application.DoEvents();
            }

        }
        public static string GetAssociatedExecutable(string fileType)
        {
            uint pcchOut = 0;

            Native.AssocQueryString(Native.AssocF.Verify, Native.AssocStr.Executable, fileType, null, null, ref pcchOut);
            
            StringBuilder pszOut = new StringBuilder((int)pcchOut);
            Native.AssocQueryString(Native.AssocF.Verify, Native.AssocStr.Executable, fileType, null, pszOut, ref pcchOut);
            
            return pszOut.ToString();
        }
        public static System.Diagnostics.Process StartProcessSafe(
            string strPath,
            bool blnWaitForStart = true,
            int intMaxWaitTimeMilliseconds = 2000,
            bool blnMaximized = false,
            string strArguments = ""
            )
        {
            string strExt = System.IO.Path.GetExtension(strPath);

            if (String.IsNullOrEmpty(strExt))
                throw new Exception("File extension was not present.");

            System.Diagnostics.Process objProcess;
            objProcess = new System.Diagnostics.Process();

            //If we are using arguments then use the actual executable and use the user's file as an argument
         //   if (strArguments != string.Empty) 
          //  {

            objProcess.StartInfo.FileName = GetAssociatedExecutable(strExt); //not the full application path
                
            strPath += " " + strArguments.Trim();
            objProcess.StartInfo.Arguments = strPath;
            //}
            //else
            //{
            //    objProcess.StartInfo.FileName = strPath; //not the full application path
            //}
            if (blnMaximized)
                objProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized;
            else
                objProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;

            objProcess.Start();

            // Wait for process to start
            if (blnWaitForStart) {
                int tA = System.Environment.TickCount;
                int tB = System.Environment.TickCount;
                while ((tB - tA < intMaxWaitTimeMilliseconds) && !objProcess.HasExited) {
                    System.Diagnostics.Process process = null;
                    tB = System.Environment.TickCount;
                    try {
                        process = System.Diagnostics.Process.GetProcessById(objProcess.Id);
                    }
                    catch (Exception ex) {
                        //Continue catching exception until process is available
                    }

                    if (process != null)
                        break;

                    System.Windows.Forms.Application.DoEvents();
                }
            }
            return objProcess;
        }









    }
}
