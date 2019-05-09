using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rifle
{
    public enum ProgramStatus : int
    {
        Ok,
        GatheringFiles
    }
    /// <summary>
    /// Manages all form instances.  Centerpoint for
    /// appliation control.
    /// </summary>
    public class RifleManager
    {
        public FileCache FileCache;

        public MainForm MainForm;
        public FileTypeManagerForm FileTypeManagerForm;
        public FileFilterForm FileFilterForm;
        public ProgramStatus ProgramStatus = ProgramStatus.Ok; // Automatically atomic. No lock required.

        private static System.Windows.Forms.Control _objDummyControl; // Must be shared
        public System.Windows.Forms.Control GetDummyControl() { return _objDummyControl; }

        private const string _cProgramName = "Rifle";

        private Object _objShowStatusLockObject = new Object();

        public RifleManager()
        {
        }
        public string GetProgramName()
        {
            return _cProgramName;
        }
        public void Initialize()
        {
            _objDummyControl = new System.Windows.Forms.Control();
    
            CreateForms();
            MainForm.Controls.Add(_objDummyControl);
            CreateFileCache();
            System.Windows.Forms.Application.DoEvents();
            ReloadFileCache();

            ShowStatus("Rifle Automation");
        }
        public void ShowStatus(string strText)
        {
            try
            {
                // This lock object is critical.  both places.  otherwise this method is slow asf.
             //   if (!System.Threading.Monitor.TryEnter(_objShowStatusLockObject))
             //       return;

                //TODO: should use a dummy control
                GetDummyControl().BeginInvoke(((Action)(() =>
                {
                //    if (!System.Threading.Monitor.TryEnter(_objShowStatusLockObject))
               //         return;
                    MainForm.SetStatus(strText);
                //    System.Threading.Monitor.Exit(_objShowStatusLockObject);
                })));
            }
            catch (Exception ex)
            {
                //TODO: log.
            }

        }
        public void CreateFileCache()
        {
            FileCache = new FileCache(this,
                MainForm.GetSearchPath(),
                MainForm.GetMaxFiles(),
                MainForm.GetTimeout(),
                MainForm.GetRecursiveSearch(),
                MainForm.GetMinMaxSize()
                );
        }
        public void ReloadFileCache(bool blnWaitForCompletion = false)
        {
            FileCache.Reload(blnWaitForCompletion);
        }
        public void CreateForms()
        {
            MainForm = new MainForm(this);
            FileTypeManagerForm = new FileTypeManagerForm(this);
            FileFilterForm = new FileFilterForm(this);
        }
        public void WaitForProgramIdle()
        {
            RifleUtils.WaitForTrue(() => { return ProgramStatus == ProgramStatus.Ok; }, FileCache.GetGatherTimeout());
        }
    }
}
