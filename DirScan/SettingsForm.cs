using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace DirPoll
{
    public partial class SettingsForm : MetroForm
    {
        public SettingsForm()
        {
            InitializeComponent();

            MouseDownFilter mouseFilter = new MouseDownFilter(this);
            mouseFilter.FormClicked += (x, y) =>
            {
                SetLabel("");

            };
            Application.AddMessageFilter(mouseFilter);

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void _btnOk_Click(object sender, EventArgs e)
        {
            SaveData();
            Close();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _txtPollFrequency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void SaveData()
        {
            Globals.Settings.PollDirs = new List<string>();
            foreach (DataGridViewRow row in _grdPollLocations.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    String data = row.Cells[0].Value as string;
                    Globals.Settings.PollDirs.Add(data);
                }
            }

            Globals.Settings.PollDirectories = _chkPollDirs.Checked;
            Globals.Settings.PollFiles = _chkPollFiles.Checked;

            Globals.Settings.PollInterval = Globals.ToInt(_txtPollFrequency.Text, 100);

            Globals.Settings.ShellCommand = _txtShellCommand.Text;
            Globals.Settings.ConsoleFontSize = Globals.ToInt(_cboFontSize.SelectedItem as string, 100);

            Globals.Settings.ShowAddedFiles = _chkAddedFiles.Checked;
            Globals.Settings.ShowChangedFiles = _chkChangedFiles.Checked;
            Globals.Settings.ShowDeletedFiles = _chkDeletedFiles.Checked;

            Globals.Settings.ShowAddedFolders = _chkAddedFolders.Checked;
            Globals.Settings.ShowChangedFolders = _chkChangedFolders.Checked;
            Globals.Settings.ShowDeletedFolders = _chkDeletedFolders.Checked;

            Globals.Settings.FileNameRegEx = _txtFileRegex.Text;
            Globals.Settings.FoldeNameRegEx = _txtDirRegex.Text;
            Globals.Settings.ShowStatusBar = _chkShowStatusBar.Checked;

            Globals.Settings.TabSize = Globals.ToInt(_indentSpaces.Text, 6);
            Globals.Settings.ShowLongBranches = _chkShowLongBranches.Checked;
        }

        private void LoadData()
        {
            foreach (string dir in Globals.Settings.PollDirs)
            {
                _grdPollLocations.Rows.Add(dir);
            }
            _chkPollDirs.Checked = Globals.Settings.PollDirectories;
            _chkPollFiles.Checked = Globals.Settings.PollFiles;
            _txtPollFrequency.Text = Globals.Settings.PollInterval.ToString();
            _txtShellCommand.Text = Globals.Settings.ShellCommand;
            Globals.SelectCboItem(_cboFontSize, Globals.Settings.ConsoleFontSize.ToString(), 1);

            _chkAddedFiles.Checked = Globals.Settings.ShowAddedFiles;
            _chkChangedFiles.Checked = Globals.Settings.ShowChangedFiles;
            _chkDeletedFiles.Checked = Globals.Settings.ShowDeletedFiles;

            _chkAddedFolders.Checked = Globals.Settings.ShowAddedFolders;
            _chkChangedFolders.Checked = Globals.Settings.ShowChangedFolders;
            _chkDeletedFolders.Checked = Globals.Settings.ShowDeletedFolders;
            _chkShowStatusBar.Checked = Globals.Settings.ShowStatusBar;
            _indentSpaces.Text = Globals.Settings.TabSize.ToString();
            _chkShowLongBranches.Checked = Globals.Settings.ShowLongBranches;

        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            _txtFileRegex.Enabled = _chkPollFiles.Checked;
        }

        private void _chkPollDirs_CheckedChanged(object sender, EventArgs e)
        {
            _txtDirRegex.Enabled = _chkPollDirs.Checked;
        }

        private void _btnAddPollLocation_Click(object sender, EventArgs e)
        {
            string dir = _txtPollDirectory.Text;
            try
            {
                string fullpath = System.IO.Path.GetFullPath(dir);
                if (!System.IO.Directory.Exists(fullpath))
                {
                    Globals.ShowErrorMessage(this, "Directory '" + fullpath + "' does not exist.");
                }
                else
                {
                    //Do not add fullpath. Dir may be relative.
                    _grdPollLocations.Rows.Add(dir);
                    _txtPollDirectory.Text = "";
                }
            }
            catch (Exception ex)
            {
                Globals.ShowErrorMessage(this, "Directory '" + dir + "' is invalid.");
            }

        }

        private void _btnSelectPollLocation_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog df = new FolderBrowserDialog();
            if (df.ShowDialog() == DialogResult.OK)
            {
                _txtPollDirectory.Text = df.SelectedPath;
            }
        }

        private void _btnRemovePollLocation_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = _grdPollLocations.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    _grdPollLocations.Rows.RemoveAt(_grdPollLocations.SelectedRows[0].Index);
                }
            }

        }

        private void _grdPollLocations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _grdPollLocations_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ValidatePaths();
        }
        private void ValidatePaths()
        {
            List<DataGridViewRow> toRemove = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in _grdPollLocations.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string newValue = row.Cells[0].Value as string;
                    try
                    {
                        string s = System.IO.Path.GetFullPath(newValue as string);
                        if (!System.IO.Directory.Exists(s))
                        {
                            SetLabel(_lblError.Text = "Invalid or nonexistent directory, " + s);
                            toRemove.Add(row);
                        }
                    }
                    catch (Exception ex)
                    {
                        SetLabel("Invalid or nonexistent directory, " + newValue);
                        toRemove.Add(row);
                    }
                }
            }
            foreach (DataGridViewRow r in toRemove)
            {
                _grdPollLocations.Rows.Remove(r);

            }

        }
        private void SetLabel(string x)
        {
            _lblError.Text = x;
        }

        private void _grdPollLocations_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var oldValue = _grdPollLocations[e.ColumnIndex, e.RowIndex].Value;
            var newValue = e.FormattedValue;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _txtPollFrequency_Click(object sender, EventArgs e)
        {

        }

        private void _txtPollFrequency_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void _txtPollFrequency_Validating(object sender, CancelEventArgs e)
        {
                int minFreq = 10;
            int iFreq = 0;
            if (Int32.TryParse(_txtPollFrequency.Text, out iFreq))
            {

                if (iFreq < minFreq)
                {
                    this.SetLabel("Poll Frequency must be above "+minFreq+"ms");
                    _txtPollFrequency.Text = minFreq.ToString();
                }

            }
        }

        private void _indentSpaces_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                int i = 0;
                if(Int32.TryParse(_indentSpaces.Text, out i))
                {
                    if(i>50) { _indentSpaces.Text = (50).ToString(); }
                    if(i<1) { _indentSpaces.Text = (1).ToString(); }
                }
            }
            catch(Exception ex)
            {
                Globals.LogError(ex.ToString());
            }

        }
    }
}
