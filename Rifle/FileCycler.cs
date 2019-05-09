using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifle
{
    public enum CycleMode
    {
        Random, 
        Ordered
    }
    public class FileCycler
    {
        //Cycles files.  shows next file and updates cache as necessary.  Also manages cycle history

        System.Random objRandom = null;
        RifleManager _objRifleManager;

        private int _intHistoryIndex = -1;
        private int _intMaxFileHistory = 100;

        private List<string> _lstFileHistory = new List<string>();

        public CycleMode CycleMode = CycleMode.Random;
        public bool Repeat = true;

        public FileCycler(RifleManager objManager)
        {
            _objRifleManager = objManager;
        }

        public string GetNextFilePath(bool blnUseHistory = false)
        {
            string strPath;
            List<string> lstFiles;

            strPath = string.Empty;
            lstFiles = GetFileCache().GetFiles();
            if (lstFiles.Count == 0)
            {
                GetFileCache().Reload(true);
                lstFiles = GetFileCache().GetFiles();
            }

            strPath = SelectFilePath(lstFiles, blnUseHistory);

            return strPath;
        }
        #region Private: MEthods

        private FileCache GetFileCache()
        {
            return _objRifleManager.FileCache;
        }

        private string SelectFilePath(List<string> lstFiles, bool blnUseHistory = false)
        {
            string strPath;

            strPath = string.Empty;

            if (lstFiles.Count == 0)
                return String.Empty;

            if (blnUseHistory)
                strPath = CycleHistory();
            else
            {
                _intHistoryIndex = -1;//Reset history.

                if (CycleMode == CycleMode.Random)
                    strPath = CycleRandom(lstFiles);
                else if (CycleMode == CycleMode.Ordered)
                    strPath = CycleOrdered(lstFiles);
                else
                    throw new NotImplementedException();
            }

            return strPath;
        }
        private string CycleHistory()
        {
            string strPath;

            if (_intHistoryIndex == -1)
            {
                if (_lstFileHistory.Count > 1)
                    _intHistoryIndex = _lstFileHistory.Count - 2;//** count-1 is the current file path - so we need to go back one more
                else
                    _intHistoryIndex = _lstFileHistory.Count - 1;
            }
            strPath = _lstFileHistory[_intHistoryIndex];

            if (_intHistoryIndex < _lstFileHistory.Count - 1)
                _intHistoryIndex--;

            return strPath;
        }
        private string CycleOrdered(List<string> lstFiles)
        {
            string strPath = "";

            strPath = lstFiles[0];

            //This sort of violates liskov.  should use a ref parameter or some other.
            GetFileCache().RemoveFile(0);

            AddFileHistory(strPath);

            return strPath;
        }
        private string CycleRandom(List<string> lstFiles)
        {
            int intRandomValue;
            string strPath = "";

            if (objRandom == null)
                objRandom = new System.Random(System.Environment.TickCount);
            intRandomValue = objRandom.Next(0, lstFiles.Count);//Dear MS: either make the whole thing inclusive or exclusive.  Dont' make one bound exclusive.

            if (intRandomValue < 0)
                return strPath; //TODO: error here

            strPath = lstFiles[intRandomValue];

            if (!Repeat)
            {
                //This sort of violates liskov.  should use a ref parameter or some other.
                GetFileCache().RemoveFile(intRandomValue);
            }

            AddFileHistory(strPath);

            return strPath;
        }
        private void AddFileHistory(string strFilePath)
        {
            if (strFilePath == "")
                return;

            _lstFileHistory.Add(strFilePath);
            if (_lstFileHistory.Count > _intMaxFileHistory)
                _lstFileHistory.RemoveAt(0);
        }

        #endregion

    }
}
