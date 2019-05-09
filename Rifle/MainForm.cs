using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rifle
{
    public partial class MainForm : RifleForm
    {
        #region Private: Members

        private System.Diagnostics.Process _objProcess = null;
        private List<System.Diagnostics.Process> _lstDeadProcesses = new List<System.Diagnostics.Process>();
        private Object _objDeadProcessesLockObject = new Object();
        private List<System.Diagnostics.Process> DeadProcesses
        {
            get { lock (_objDeadProcessesLockObject) return _lstDeadProcesses; }
            set { lock (_objDeadProcessesLockObject) _lstDeadProcesses = value; }
        }
        private FileCycler _objFileCycler;

        #endregion

        #region Public: Methods

        public MainForm(RifleManager objManager)
            : base(objManager)
        {
            InitializeComponent();
            _objFileCycler = new FileCycler(objManager);
            // reset to remove eye sore.
            _lblFileCount.Text = "";
            _lblFilePath.Text = "";
        }

        public string GetSearchPath() { return _txtPath.Text; }
        public int GetMaxFiles() { return (int)_nudMaxFiles.Value; }
        public int GetTimeout() { return (int)_nudFileGatherTimeout.Value; }
        public void SetStatus(string status) { _lblStatusLabel.Text = status; }
        public bool GetRecursiveSearch() { return _chkSearchFolders.Checked; }
        public ImageSizeFilter GetMinMaxSize() { 

            if(_chkFilterWidthHeight.Checked == false )
                return null;

            ImageSizeFilter filt = new ImageSizeFilter();
            filt.MinWidth  = (int)_nudMinWidth .Value;
            filt.MaxWidth  = (int)_nudMaxWidth .Value;
            filt.MinHeight = (int)_nudMinHeight.Value;
            filt.MaxHeight = (int)_nudMaxHeight.Value;
            return filt;
        }

        #endregion

        #region OVERRIDE METHODS
        protected override void SetAllTooltips()
        {
            SetTooltip(_chkClosePrevious, "If checked the previous program that started will be killed when the next file is loaded (recommended).");
            SetTooltip(_chkSearchFolders, "If checked all folders under the '" + _lblSearchInFolder.Text + "' directory will be searched.  To modify max search results set the Max Files option below.");
            SetTooltip(_chkRepeat, "If checked Files can be repeated.  If Not checked the program will cycle through all files randomly without repeating.  Once all files have been cycled it will repeat the process.");
            SetTooltip(_chkShiftFocus, "If not checked (recommended) " + GetManager().GetProgramName() + " will attempt to keep focus so you can cycle through images with left and right arrows.");
            SetTooltip(new List<Control> { _nudMaxFiles, _lblMaxFiles },
                "The maximum number of files the program can cycle through.  Setting this too high will cause the program to stall until it finds all files.");

            SetTooltip(_chkMaximizeWindow, "If checked the image / program that opens will be maximized every time.");
            SetTooltip(_chkShowStopWatch, "Show the stop watch utility.");
            SetTooltip(_chkWatchCycle, "(recommended) Shows the next image/video/program when the stopwatch ends.");
            SetTooltip(_chkResetWatchAtEnd, "Reset the stopwatch every time it ends.");
            SetTooltip(new List<Control> { _nudFileGatherTimeout, _lblFileGatherTimeout },
                "The maximum time in milliseconds that rifle can wait to search for files.");

            SetTooltip(new List<Control> { _txtArguments, _lblArguments },
                "Arguments or Switches that are passed to the executed application each time, separated by spaces.  For example to run IrfanView in fullscreen add /fs to this line.");
            SetTooltip(_chkForceKill, "[Advanced] If checked Rifle will kill the opened program abruptly rather than asking it to exit.");
            SetTooltip(_chkRandom, "If checked files will be executed at random, otherwise files will be executed in the order that Rifle discovers them.");
        }
        #endregion


        protected override void LoadingDisableInput()
        {
            _btnNext.Enabled = false;
            _btnPrev.Enabled = false;
        }
        protected override void LoadingEnableInput()
        {
            _btnNext.Enabled = true;
            _btnPrev.Enabled = true;
            UpdateFileCount();
            UpdateFilesRemaining();
        }

        #region Private: UI Callbacks

        private void Form1_Load(object sender, EventArgs e)
        {
       //     handleActivation();
            _txtPath.Text = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            _lblFilePath.Text = String.Empty;

            UpdateFilesRemaining();
            ExpandOrCollapseOptions();
            SetAllTooltips();
            ResetStopWatch();
            _grpStopWatch.Visible = _chkShowStopWatch.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExecuteNextGoodFile();
        }
        private void _btnPrev_Click(object sender, EventArgs e)
        {
            ExecuteNextGoodFile(true);
        }

        private void _chkSearchFolders_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void ReloadCache()
        {
            GetManager().FileCache.Minimax = GetMinMaxSize();
            GetManager().FileCache.RecursiveSearch = _chkSearchFolders.Checked;
            GetManager().ReloadFileCache();
            GetManager().WaitForProgramIdle();
            UpdateFileCount();
        }

        private void _chkShowOptions_CheckedChanged(object sender, EventArgs e)
        {
            ExpandOrCollapseOptions();
        }
        private void _btnSelectFolder_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog ofd;
            ofd = new System.Windows.Forms.FolderBrowserDialog();
            ofd.ShowDialog();
            if (System.IO.Directory.Exists(ofd.SelectedPath))
                _txtPath.Text = ofd.SelectedPath;

            ReloadCache();
        }
        private void _chkClosePrevious_CheckedChanged(object sender, EventArgs e)
        {
            _chkForceKill.Enabled = _chkClosePrevious.Checked;
        }
        private void _chkForceKill_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void _chkRandom_CheckedChanged(object sender, EventArgs e)
        {
            _chkRepeat.Enabled = _chkRandom.Checked;
        }
        private void _btnActivate_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region Private: Methods
        private void ExecuteNextGoodFile(bool blnUseHistory = false)
        {
            while (true)
            {
                try
                {
                    ExecuteNextFile(blnUseHistory);
                    UpdateFilesRemaining();
                }
                catch (Exception ex)
                {
                    GetManager().ShowStatus("Error processing file: " + ex.ToString());
                    if (_chkIgnoreBadFiles.Checked)
                    {
                        System.Windows.Forms.Application.DoEvents();
                        continue;
                    }
                }
                return;
            }
        }
        public void ExecuteNextFile(bool blnUseHistory = false)
        {
            string strPath;

            if (_chkClosePrevious.Checked)
                ClosePreviousProcess();

            try
            {
                strPath = _objFileCycler.GetNextFilePath(blnUseHistory);

                if (strPath != String.Empty)
                {

                    //start proces making sure it is started, or exited.
                    _objProcess = RifleUtils.StartProcessSafe(strPath, true, 2000, _chkMaximizeWindow.Checked, _txtArguments.Text);

                    if (_chkShiftFocus.Checked == false)
                        RifleUtils.ForceWindowFocus(this);

                    SetCurrentFilePathInfo(strPath);

                }
            }
            catch (Exception ex)
            {
            }
        }
        private void ClosePreviousProcess()
        {
            if (_objProcess == null)
                return;

            try
            {
                System.Diagnostics.Process dead = _objProcess;
                DeadProcesses.Add(dead);
                _objProcess = null;

                //Async kill all dead processes
                System.Threading.Tasks.Task.Run(((Action)(() =>
                {

                    List<System.Diagnostics.Process> killed = new List<System.Diagnostics.Process>();

                    foreach (System.Diagnostics.Process dp in DeadProcesses)
                    {
                        //Insetad of Process.Killl we try to close the window
                        if (!dp.HasExited)
                        {
                            if (_chkForceKill.Checked)
                                dp.Kill();
                            else
                                dp.CloseMainWindow();
                        }
                        killed.Add(dp);
                    }

                    foreach (System.Diagnostics.Process dp in killed)
                        DeadProcesses.Remove(dp);

                })));


            }
            catch (Exception ex)
            {
                //TODO: log error
            }
        }

        private void UpdateFilesRemaining()
        {
            RifleManager mgr = GetManager();
            FileCache cache = mgr.FileCache;
            _lblFilesRemaining.Text = cache.GetFileCount() + " remaining.";
        }
        private void UpdateFileCount()
        {
            int fileCount = GetManager().FileCache.GetFileCount();
            _lblFileCount.Text = fileCount.ToString() + " file" + (fileCount != 1 ? "s" : "");
        }

        private void SetCurrentFilePathInfo(string text)
        {
            _lblFilePath.Text = text;
            SetTooltip(_lblFilePath, text + " --Click to copy");
        }

        #endregion

        #region Protected: Methods
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                ExecuteNextGoodFile(true);
                return true;
            }
            if (keyData == Keys.Right)
            {
                ExecuteNextGoodFile();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region Private: Options Pane
        private void ExpandOrCollapseOptions()
        {
            if (_chkShowOptions.Checked)
                ExpandOptions();
            else
                CollapseOptions();
        }
        private void SetFormHeightRelativeToControl(Control objControl, int intPad = 30)
        {

            this.ClientSize = new Size(
                this.ClientSize.Width,
                objControl.Location.Y + objControl.Height + intPad
            );
        }
        private void ExpandOptions()
        {
            if (_grpStopWatch.Visible)
                SetFormHeightRelativeToControl(_grpStopWatch);
            else
                SetFormHeightRelativeToControl(_grpOptions);

            _objStatusStrip.Show();
        }
        private void CollapseOptions()
        {
            SetFormHeightRelativeToControl(_chkShowOptions, 30 - _objStatusStrip.Height);
            _objStatusStrip.Hide();
        }
        private void _lblFilePath_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(_lblFilePath.Text);
        }
        #endregion

        private void _chkShowStopWatch_CheckedChanged(object sender, EventArgs e)
        {
            _grpStopWatch.Visible = _chkShowStopWatch.Checked;
            ExpandOptions();
        }

        #region Stop Watch
        //TODO: class
        System.Windows.Forms.Timer _objViewUpdateTimer;
        System.Diagnostics.Stopwatch _objStopwatch;


        private long UserTimeToMilliseconds()
        {
            return
            (long)_nudHours.Value * 60 * 60 * 1000 +
            (long)_nudMinutes.Value * 60 * 1000 +
            (long)_nudSeconds.Value * 1000;
        }
        private long GetStopWatchDelta()
        {
            return UserTimeToMilliseconds() - _objStopwatch.ElapsedMilliseconds;
        }
        private string GetStopWatchTimeString()
        {
            if (_objStopwatch == null)
                return "";
            long delta = GetStopWatchDelta();
            return GetMilliTimeString(delta);
        }
        private string GetMilliTimeString(long aintMilliseconds)
        {
            long remainder = aintMilliseconds;

            long hours = remainder / (1000 * 60 * 60);
            remainder = remainder % (1000 * 60 * 60);

            long minutes = remainder / (1000 * 60);
            remainder = remainder % (1000 * 60);

            long seconds = remainder / 1000;
            remainder = remainder % (1000);

            long millis = remainder;

            return ((_nudHours.Value > 0) ? (hours.ToString("D2") + ":") : "") +
                    ((_nudHours.Value > 0) || (_nudMinutes.Value > 0) ? (minutes.ToString("D2") + ":") : "") +
                    ((_nudHours.Value > 0) || (_nudMinutes.Value > 0) || (_nudSeconds.Value > 0) ? (seconds.ToString("D2") + ":") : "") +
                    (millis.ToString("D3"))
                    ;
        }
        private void ResetStopWatch()
        {
            _objStopwatch = new System.Diagnostics.Stopwatch();

            _lblStopWatchTime.ForeColor = Color.Black;
            _lblStopWatchTime.Text = GetStopWatchTimeString();

            _objViewUpdateTimer = new System.Windows.Forms.Timer();
            _objViewUpdateTimer.Interval = 1;
            _objViewUpdateTimer.Tick += _objViewUpdateTimer_Tick;
        }

        void _objViewUpdateTimer_Tick(object sender, EventArgs e)
        {
            _lblStopWatchTime.Text = GetStopWatchTimeString();
            if (GetStopWatchDelta() <= 0)
            {
                _objStopwatch.Stop();
                _lblStopWatchTime.Text = GetStopWatchTimeString();
                _objViewUpdateTimer.Stop();

                if (_chkResetWatchAtEnd.Checked)
                {
                    ResetStopWatch();
                    StartStopWatch();
                }
                else
                {
                    _lblStopWatchTime.ForeColor = Color.Red;
                }

                if (_chkWatchCycle.Checked)
                    ExecuteNextGoodFile();
            }
        }
        private void StartStopWatch()
        {
            _objStopwatch.Start();
            _objViewUpdateTimer.Start();
        }
        private void PauseStopWatch()
        {
            _objStopwatch.Stop();
            _objViewUpdateTimer.Stop();
        }
        private void _btnStartWatch_Click(object sender, EventArgs e)
        {
            StartStopWatch();
            ExecuteNextGoodFile();
        }
        private void _btnPauseWatch_Click(object sender, EventArgs e)
        {
            PauseStopWatch();
        }
        private void _btnResetWatch_Click(object sender, EventArgs e)
        {
            ResetStopWatch();
        }
        private void _nudSeconds_ValueChanged(object sender, EventArgs e)
        {
            ResetStopWatch();
        }
        private void _nudMinutes_ValueChanged(object sender, EventArgs e)
        {
            ResetStopWatch();
        }
        private void _nudHours_ValueChanged(object sender, EventArgs e)
        {
            ResetStopWatch();
        }
        #endregion

        #region Presets

        private void _btnArtDefaults_Click(object sender, EventArgs e)
        {
            _chkFilterWidthHeight.Checked = true;
            _nudMinHeight.Value = 600;
            _nudMaxHeight.Value = 9999999;
            _nudMinWidth.Value = 600;
            _nudMaxWidth.Value = 9999999;
            _txtPath.Text = @"d:\Reference Art";
            _txtArguments.Text = "/fs";
            _chkShowStopWatch.Checked = true;
            _chkSearchFolders.Checked = true;
            ReloadCache();

            _nudMinutes.Value = (decimal)2;
            _nudHours.Value = (decimal)0;
            _nudSeconds.Value = (decimal)0;
            StartStopWatch();
        }

        #endregion

        #region ActivationDialog / Security


        string _strAuthUrl = "https://www.fulminationinteractive.com/auth/auth.php";
        //string _strAuthUrlTest = "http://localhost/fulminationinteractive.com/auth/auth.php";
        private void handleActivation()
        {
            ActivatorConfiguration objActivatorConfig = new ActivatorConfiguration(
                                System.Reflection.Assembly.GetEntryAssembly().FullName,
                                _strAuthUrl,//RifleUtils.IsDebugEnabled ? _strAuthUrlTest : _strAuthUrl,
                                false);
            // Forces activation by showing a modal popup or else
            // the app dies.
            Activator ac = new Activator(objActivatorConfig);
            ac.ForceActivation(this);

            //FUTURE: for trial version
            _btnActivate.Hide();
        }

        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _txtPath_TextChanged(object sender, EventArgs e)
        {
            GetManager().FileCache.SearchPath = _txtPath.Text;
            
        }

        private void _mnuFileFilter_Click(object sender, EventArgs e)
        {
            GetManager().FileFilterForm.Show();
        }

        private void manageFileTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetManager().FileTypeManagerForm.Show();
        }

        private void _chkFilterWidthHeight_CheckedChanged(object sender, EventArgs e)
        {
            _nudMinWidth.Enabled =
            _nudMinHeight.Enabled = 
            _nudMaxWidth.Enabled = 
            _nudMaxHeight.Enabled =
            _lblFilterWidth.Enabled = 
            _lblFilterHeight.Enabled = _chkFilterWidthHeight.Checked;
        }
        private void _nudMinWidth_ValueChanged(object sender, EventArgs e)
        {
        }
        private void _nudMaxWidth_ValueChanged(object sender, EventArgs e)
        {
        }
        private void _nudMinHeight_ValueChanged(object sender, EventArgs e)
        {
        }
        private void _nudMaxHeight_ValueChanged(object sender, EventArgs e)
        {
        }
        private void _btnUpdateSearch_Click(object sender, EventArgs e)
        {
            ReloadCache();
        }

        private void _txtArguments_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
