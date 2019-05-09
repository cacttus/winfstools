using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifle
{
    public class FileCache
    {
        private int _intGatherTimeout = 200000;

        private List<string> _lstCachedFileList = null;//DO NOT USE - use FileCache instead
        private Object _objFileCacheLockObject = new Object();
        private List<string> Files
        {
            get { lock (_objFileCacheLockObject) return _lstCachedFileList; }
            set { lock (_objFileCacheLockObject) _lstCachedFileList = value; }
        }

        private RifleManager _objRifleManager;
        private string _strSearchPath;
        private int _intMaxFiles;
        public bool RecursiveSearch;//atomics auto-lock and thread safe.       

        private Action _objCompletionAction;

        public string SearchPath
        {
            get { return _strSearchPath; }
            set
            {
                _strSearchPath = value;
                Reload();
            }
        }
        public ImageSizeFilter Minimax {get;set; }

        public int GetGatherTimeout() { return _intGatherTimeout; }

        public FileCache(RifleManager objManager,
            string strSearchPath,
            int intMaxFiles,
            int intTimeout,
            bool blnRecursiveSearch,
            ImageSizeFilter minimax = null
            )
        {
            _intMaxFiles = intMaxFiles;
            _strSearchPath = strSearchPath;
            _objRifleManager = objManager;
            _intGatherTimeout = intTimeout;
            Minimax = minimax;
            RecursiveSearch = blnRecursiveSearch;
        }
        public void RemoveFile(int index)
        {
            Files.RemoveAt(index);
        }
        public void Reload(bool blnWaitForCompletion = false, Action objCompletionAction = null)
        {
            _objCompletionAction = objCompletionAction;
            //FileCache = null;
            BeginGatherFiles();

            if (blnWaitForCompletion)
                _objRifleManager.WaitForProgramIdle();
        }
        public List<string> GetFiles()
        {
            return Files;
        }
        public int GetFileCount()
        {
            if (GetFiles() == null)
                return 0;
            return GetFiles().Count;
        }
        private List<string> BeginGatherFiles()
        {
            //if (Files != null) // Allow us to return 0 file cache
            //    return Files;

            if (!System.IO.Directory.Exists(_strSearchPath))
            {
                _objRifleManager.ShowStatus("Path " + _strSearchPath + " does not exist.");
                return new List<string>();
            }

            _objRifleManager.ShowStatus("Gathering Files...");
            _objRifleManager.ProgramStatus = ProgramStatus.GatheringFiles;

            List<string> lstExtensions = _objRifleManager.FileTypeManagerForm.GetFileTypes();

            // ** Invoke task async.
            System.Threading.Tasks.Task objTask = new System.Threading.Tasks.Task(((Action)(() =>
            {

                List<string> lstReturn = new List<string>();

                System.IO.Directory.SetCurrentDirectory(_strSearchPath);

                GatherFiles_r(lstReturn, _intMaxFiles, lstExtensions);
                
                //Filter width /height
                CheckWidthHeight(lstReturn, Minimax);

                Files = lstReturn;

                //Invoke control on main thread to re-enable everything
                _objRifleManager.GetDummyControl().BeginInvoke(((Action)(() =>
                {
                    _objRifleManager.ShowStatus("Done.");
                    _objRifleManager.ProgramStatus = ProgramStatus.Ok;
                    if(_objCompletionAction!=null)
                        _objCompletionAction();
                })));


            })));
            objTask.Start();

            return new List<string>();
        }
        private void GatherFiles_r(List<string> lstFiles, int intFileLimit, List<string> lstExtensions)
        {
            try
            {
                string curDir = System.IO.Directory.GetCurrentDirectory();
                List<string> files = System.IO.Directory.GetFiles(curDir).ToList();

                //Filter the image extension
                List<string> filtered = files.Where(x =>
                    System.IO.Path.GetExtension(x).Length > 0 ?
                    lstExtensions.Contains(
                        System.IO.Path.GetExtension(x).Substring(1)
                    ) : false
                ).ToList();


                //Add files.`
                

                //Too intense - causes problems
                _objRifleManager.ShowStatus("Gathering Files..." + lstFiles.Count);

                if (RecursiveSearch == true)
                {
                    string[] dirs = System.IO.Directory.GetDirectories(curDir);
                    foreach (string d in dirs)
                    {
                        System.IO.Directory.SetCurrentDirectory(d);

                        if (lstFiles.Count < intFileLimit)
                            GatherFiles_r(lstFiles, intFileLimit, lstExtensions);

                        System.IO.Directory.SetCurrentDirectory(curDir);
                    }
                }
            }
            catch (Exception ex)
            {
                _objRifleManager.ShowStatus(ex.ToString());
            }
        }
        private void CheckWidthHeight(List<string> lstFiles, ImageSizeFilter minimax) {
            //Filter the image width /ehgiht
            List<string> filtered2 = new List<string>();
            if(minimax != null ) {
                int iFiltered = 0;
                foreach (string strPath in lstFiles)
                {
                    iFiltered ++;
                    _objRifleManager.ShowStatus("Filtering W/H..." + iFiltered + "/" + lstFiles.Count);
                    try {
                        using (FileStream stream = new FileStream(strPath, FileMode.Open, FileAccess.Read))
                        {
                            //False 2nd 3rd parameter to avoid loading file into memer\
                            //http://stackoverflow.com/questions/552467/how-do-i-reliably-get-an-image-dimensions-in-net-without-loading-the-image
                            Image img = Image.FromStream(stream, false, false);
                            if(img.Width > minimax.MinWidth && img.Width < minimax.MaxWidth &&
                                img.Height > minimax.MinHeight && img.Height < minimax.MaxHeight)
                            {
                                filtered2.Add(strPath);
                            }
                        }
                    }
                    catch (Exception ex) {
                        //Swallow
                        int n;
                        n=0;
                    }
                }
            }
            lstFiles.Clear();
            lstFiles.AddRange(filtered2);
        }


    }
}
