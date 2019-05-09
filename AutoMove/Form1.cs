using System;

using System.Windows.Forms;

namespace AutoMove
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        System.Windows.Threading.DispatcherTimer _tmrFilePoller;

        private void NotifyCreateDir(string dir)
        {
            //Show dialog to user to create a directory

            DialogResult dialogResult;

            dialogResult = System.Windows.Forms.MessageBox.Show(
                "Create Directory?",
                "The directory " + _txtMoveDir.Text + " not exist, would you like to create it?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    System.IO.Directory.CreateDirectory(dir);
                }
                catch (Exception ex)
                {
                    Log("Couldn not create directory " + dir + "\r\n" + ex.ToString());
                }
            }
        }

        private string ValidatePoll()
        {
            //Returns String.Empty if validation succeeded
            string strMsg = "";


            if (!System.IO.Directory.Exists(_txtMoveDir.Text))
                strMsg += "Directory " + _txtMoveDir.Text + " does not exist.";
            if (!System.IO.Directory.Exists(_txtWatchDir.Text))
                strMsg += "Directory " + _txtWatchDir.Text + " does not exist.";

            return strMsg;
        }
        private void _btnStartPolling_Click(object sender, EventArgs e)
        {
            if (_tmrFilePoller != null && _tmrFilePoller.IsEnabled)
            {
                EndPoll();
            }
            else
            {
                string res = ValidatePoll();
                if (res == String.Empty)
                    BeginPoll();
                else
                {
                    Log("Polling could not start. \r\n " + res);
                }
            }
        }

        private void BeginPoll()
        {
            _tmrFilePoller = new System.Windows.Threading.DispatcherTimer();
            _tmrFilePoller.Tick += new EventHandler(_tmrFilePoller_Tick);
            _tmrFilePoller.Interval = new TimeSpan(0, 0, 0, 0, (int)_nudPollInterval.Value);
            _tmrFilePoller.Start();
            _btnStartPolling.Text = "Stop";
            _txtMoveDir.Enabled = false;
            _txtWatchDir.Enabled = false;
        }
        private void EndPoll()
        {
            _tmrFilePoller.Stop();
            _txtMoveDir.Enabled = true;
            _txtWatchDir.Enabled = true;
            _btnStartPolling.Text = "Start";
        }

        private void _tmrFilePoller_Tick(object sender, EventArgs e)
        {
            MoveFiles();
        }
        private void MoveFiles()
        {
            string[] files = System.IO.Directory.GetFiles(_txtWatchDir.Text);
            Log("Moving " + files.Length + " files...");
            _pgbProgress.Value = 0;
            for (int iFile = 0; iFile < files.Length; iFile++)
            {
                string filePath = files[iFile];

                try
                {
                    string srcName, dstName;
                    srcName = filePath;
                    dstName = System.IO.Path.Combine(_txtMoveDir.Text, System.IO.Path.GetFileName(filePath));

                    //Skip moving unchanged files.
                    if (System.IO.File.Exists(dstName))
                    {
                        if (_chkOnlyMoveIfChanged.Checked)
                        {
                            DateTime ftime = System.IO.File.GetLastWriteTime(srcName);
                            DateTime ftime2 = System.IO.File.GetLastWriteTime(dstName);
                            if (ftime == ftime2)
                                continue;
                        }

                        //Rename file if specified.
                        if (_optRename.Checked)
                        {
                            dstName = RenameExistingFile(dstName);
                        }
                        else if (_optOverwrite.Checked)
                        {
                            //Do nothing.
                        }
                        else
                            throw new Exception("Error: No option selected for handling duplicate files.");
                    }

                    System.IO.File.Copy(srcName, dstName);
                    Log("Copied " + srcName + " to " + dstName);
                    if (_chkDeleteSourceFile.Checked)
                    {
                        System.IO.File.Delete(srcName);
                        Log("Deleted " + srcName);
                    }
                }
                catch (Exception ex)
                {
                    Log("Error: Could not move file " + filePath + "\r\n" + ex.ToString());
                }

                _pgbProgress.Value = (int)(((double)iFile / (double)files.Length) * 100.0);
            }
            _pgbProgress.Value = 0;

        }
        int iLine = 0;
        private void Log(string msg)
        {
            _txtOutput.AppendText("[" + iLine.ToString() + "] " + msg + "\r\n");
            _txtOutput.SelectionStart = _txtOutput.Text.Length + 1; // add some logic if length is 0
            iLine++;
        }

        private void _btnSelectWatchDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.ShowDialog();
            _txtWatchDir.Text = fbd.SelectedPath;
        }

        private void _btnSelectMoveDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.ShowDialog();
            _txtMoveDir.Text = fbd.SelectedPath;
        }

        private void _txtWatchDir_TextChanged(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(_txtWatchDir.Text) && _txtWatchDir.Text.Length > 0)
                NotifyCreateDir(_txtWatchDir.Text);
        }

        private void _txtMoveDir_TextChanged(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(_txtMoveDir.Text) && _txtMoveDir.Text.Length > 0)
                NotifyCreateDir(_txtMoveDir.Text);
        }
        private string RenameExistingFile(string dstName)
        {
            string newName = "";
            for (int i = 0; i < 100; ++i)
            {
                string path = System.IO.Path.GetDirectoryName(dstName);
                string fn = System.IO.Path.GetFileNameWithoutExtension(dstName);
                string ext = System.IO.Path.GetExtension(dstName);
                newName = System.IO.Path.Combine(path, fn) + "_" + i.ToString() + ext;
                if (!System.IO.File.Exists(newName))
                    break;
            }
            if (System.IO.File.Exists(newName))
                throw new Exception("Failed to copy " + dstName + " File could not be renamed.");
            else
                return newName;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void _nudPollInterval_ValueChanged(object sender, EventArgs e)
        {
            EndPoll();
            BeginPoll();
        }

        private void _chkMoveChanged_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
