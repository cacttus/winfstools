using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace DirPoll
{
    public partial class MainForm : MetroForm
    {
        FsItem Root = null;//Note: The root of the dirtree is not actually a dir.
        System.Windows.Forms.Timer _objTimer = null;
        Task PollTask = null;
        CancellationTokenSource PollTaskSource = null;
        object MainThreadLock = new object();
        private int _iScans = 0;

        private Color MenuButtonEnableColor;
        private Color MenuButtonDisableColor = Color.FromArgb(212, 212, 212);

        public StatsForm StatsForm { get; } = new StatsForm();

        public object UiThreadLockObject { get; set; } = new object();

        public MainForm()
        {
            InitializeComponent();
            Globals.MainForm = this;
            Globals.Settings.SetDefault();
            Theme = Globals.MetroThemeStyle;

            MenuButtonEnableColor = _btnStart.BackColor;

            UpdateStats(false, true);

        }

        #region Public Methods
        public void LogError(string str)
        {
            Print("Error!: " + str);
        }
        #endregion

        #region UI
        private void MainForm_Load(object sender, EventArgs e)
        {
            //_txtOutput.Font = new Font(new FontFamily("Courier New"),
            //    10, FontStyle.Regular);
            UpdateFormView();

        }

        private void _btnClear_Click(object sender, EventArgs e)
        {
            _txtOutput.Clear();
        }

        private void _btnPrintTree_Click(object sender, EventArgs e)
        {
            if (Root == null)
            {
                Print("Tree was not built yet (error).");
            }
            else
            {
                string strin = Environment.NewLine;
                strin += Root.FullPath + Environment.NewLine;//Should be "*root"
                PrintTree();
            }
        }

        private void _btnStart_Click(object sender, EventArgs e)
        {
            if (_objTimer == null)
            {
                UpdateFormView();
                string s = "Started Polling:\r\n";
                foreach (string d in Globals.Settings.PollDirs)
                {
                    s += "  " + d + " (" + System.IO.Path.GetFullPath(d) + ")\r\n";
                }
                Print(s);
                _objTimer = new System.Windows.Forms.Timer();
                _objTimer.Interval = Globals.Settings.PollInterval;
                _objTimer.Start();
                _objTimer.Tick += (object x, EventArgs y) =>
                {
                    PollForChanges();
                };
                _btnStart.BackgroundImage = new Bitmap(DirPoll.Properties.Resources.appbar_control_pause);

                _btnSettings.Enabled = false;
                _btnSettings.BackColor = Color.FromArgb(212, 212, 212);
                EnableMenuButton(_btnSettings, false);
            }
            else
            {
                _objTimer?.Stop();
                _objTimer = null;
                _btnStart.BackgroundImage = new Bitmap(DirPoll.Properties.Resources.appbar_control_play);
                EnableMenuButton(_btnSettings, true);

            }
        }

        private void EnableMenuButton(MetroFramework.Controls.MetroButton b, bool enable)
        {

            b.Enabled = enable;
            if (b.Enabled)
            {
                b.BackColor = MenuButtonEnableColor;
            }
            else
            {
                b.BackColor = MenuButtonDisableColor;
            }
        }

        private void _btnAbout_Click(object sender, EventArgs e)
        {
            AboutForm ab = new AboutForm();
            ab.Show();
        }

        private void _btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog(this);
            UpdateFormView();
        }

        private void UpdateFormView()
        {
            //Updates UI, builds tree, adn makes a good state.
            _txtOutput.Font = new Font(new FontFamily("Consolas"), Globals.Settings.ConsoleFontSize, FontStyle.Regular);
            BuildFileTree(true);

        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            string[] files = Globals.GetValidOpenSaveUserFile(true,
                 ".json|*.json", ".json|*.json", Globals.Settings.SettingsFileLocation, "./");

            if (files.Length == 1)
            {
                if (Settings.SaveJson(files[0]))
                {
                    SetStatus("Saved to " + files[0]);
                }
            }
        }

        private void _btnOpen_Click(object sender, EventArgs e)
        {
            string[] files = Globals.GetValidOpenSaveUserFile(false, ".json|*.json", ".json|*.json", "", "./");

            if (files.Length == 1)
            {
                if (Settings.LoadJson(files[0]))
                {
                    SetStatus("Loaded from " + files[0]);
                    UpdateFormView();
                }
            }
        }

        private void _txtOutput_Enter(object sender, EventArgs e)
        {
            ActiveControl = _btnSave;
        }

        private void _mnuOpenDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = Environment.CurrentDirectory,
                UseShellExecute = true,
                Verb = "open"
            });

        }

        private void _btnStats_Click(object sender, EventArgs e)
        {
            StatsForm.Show();
            StatsForm.Location = new Point(this.Left + this.Width, this.Top);
        }

        #endregion

        #region Private Methods

        private void BuildFileTree(bool buildOnly)
        {
            PollResults results = new PollResults();
            if (Root == null)
            {
                Root = new FsItem("*Root", null, true, true);
            }

            try
            {
                
                //Scan for changes and update tree
                SetStatus("Scanning..");
                Stopwatch s = new Stopwatch();
                s.Start();
                results.TotalFileCount = Globals.FileCountInAllRoots();
                Root.Build(ref results);
                Root.UpdateFolderContentsChanged();
                s.Stop();
                SetStatus("Scan complete.");

                //Do work to show what's changed.
                BeginInvoke(new Action(() =>
                {
                    StatsForm.LastScanTimeMs = s.ElapsedMilliseconds;
                    StatsForm.AverageScanTimeMs = (StatsForm.AverageScanTimeMs + StatsForm.LastScanTimeMs) / 2;
                    StatsForm.NumberOfScans++;
                    StatsForm.FileCount = results.ScannedFileCountLastScan;
                    StatsForm.NewCount = results.NewFileCountLastScan;

                    StatsForm.AvgAddedPerScan = (StatsForm.AvgAddedPerScan + results.NumAdded) / 2;
                    StatsForm.AvgDeletedPerScan = (StatsForm.AvgDeletedPerScan + results.NumDeleted) / 2;
                    StatsForm.AvgChangedPerScan = (StatsForm.AvgChangedPerScan + results.NumChanged) / 2;

                    StatsForm.TopFileWriteList = results.TopFileChanges;

                    UpdateStats();
                }));
                if (buildOnly == false)
                {
                    if (Root.HasChanges())
                    {
                        PrintResults();
                        ExecShellCommand();
                    }
                }

                //MUST clean tree after building to remove changed files.
                Root.CleanAndSync(true);
            }
            catch (Exception ex)
            {
                Globals.LogError(ex.ToString());
            }

        }
        private void UpdateStats(bool statusOnly = false, bool force = false)
        {
            if (StatsForm.Visible == true || force)
            {
                //TODO:
                StatsForm.Update(statusOnly);
            }
        }

        private void PrintResults()
        {
            string s = Root.ToString(new PrintSettings() { OmitUnchanged = true });
            Print(s, PrintMode.TreeString);
        }

        private void ExecShellCommand()
        {
            if (string.IsNullOrEmpty(Globals.Settings.ShellCommand) == false)
            {
                try
                {
                    //Exec script
                    Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = Globals.Settings.ShellCommand,
                        UseShellExecute = true,
                        Verb = "open"
                    });
                }
                catch (Exception ex)
                {
                    Print("Error executing shell command: " + Environment.NewLine + "Command: "
                        + Globals.Settings.ShellCommand + Environment.NewLine + " ex= " + ex.ToString());
                }
            }
        }

        private void PollForChanges()
        {
            if (PollTask == null || PollTask.IsCompleted == true)
            {
                PollTaskSource = new CancellationTokenSource();
                Task t = new Task(() =>
                {
                    BuildFileTree(false);
                }, PollTaskSource.Token);

                t.Start();
            }
        }

        private void Print(string s)
        {
            Print(s, _txtOutput.ForeColor, PrintMode.Normal);
        }

        private void Print(string s, PrintMode mode = PrintMode.Normal)
        {
            Print(s, null, mode);
        }

        private void Print(string s, Color? c = null, PrintMode mode = PrintMode.Normal)
        {
            string str = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt") + "> " + s + "\r\n";

            _txtOutput.BeginInvoke((new Action(() =>
            {
                if (mode == PrintMode.Normal)
                {
                    _txtOutput.AppendText(str, c == null ? _txtOutput.ForeColor : c.Value);

                }
                else if (mode == PrintMode.TreeString)
                {
                    FormatTreeStringToConsole(s);
                }

                _txtOutput.SelectionStart = _txtOutput.TextLength;
                _txtOutput.ScrollToCaret();

            })));
        }

        void PrintTree()
        {
            string tree = Root.ToString(new PrintSettings() { OmitUnchanged = false, TabSize = Globals.Settings.TabSize });

            FormatTreeStringToConsole(tree);
        }

        private void FormatTreeStringToConsole(string tree)
        {
            string[] lines = tree.Split(new char[] { '\n' });
            Color c = _txtOutput.ForeColor;
            foreach (string line in lines)
            {
                string lineBeg = "";
                string highlightText = "";
                int idx = -1;

                if ((idx = line.IndexOf(FsItem.AddedMarker)) != -1)
                {
                    lineBeg = line.Substring(0, idx);
                    highlightText = line.Substring(idx);
                    c = Color.FromArgb(255, 84, 252, 65);
                }
                else if ((idx = line.IndexOf(FsItem.RemovedMarker)) != -1)
                {
                    lineBeg = line.Substring(0, idx);
                    highlightText = line.Substring(idx);
                    c = Color.FromArgb(255, 255, 32, 32);
                }
                else if ((idx = line.IndexOf(FsItem.ChangedMarker)) != -1)
                {
                    lineBeg = line.Substring(0, idx);
                    highlightText = line.Substring(idx);
                    c = Color.FromArgb(255, 252, 249, 141);
                }
                else if ((idx = line.IndexOf(FsItem.FolderContentsChangedMarker)) != -1)
                {
                    lineBeg = line.Substring(0, idx);
                    highlightText = line.Substring(idx);
                    c = Color.FromArgb(255, 253, 187, 128);
                }
                else
                {
                    lineBeg = line;
                }

                string lineMod = line.Trim() + Environment.NewLine;

                _txtOutput.AppendText(lineBeg, _txtOutput.ForeColor);
                if (!string.IsNullOrEmpty(highlightText))
                {
                    _txtOutput.AppendText(highlightText, c);
                }
            }
        }

        private void SetStatus(string stat)
        {
            this.BeginInvoke(new Action(() =>
            {
                StatsForm.Status = stat;
                UpdateStats(true);
            }));
        }

        #endregion


    }
}
