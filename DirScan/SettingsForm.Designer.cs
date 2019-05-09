namespace DirPoll
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this._btnOk = new MetroFramework.Controls.MetroTile();
            this._btnCancel = new MetroFramework.Controls.MetroTile();
            this._txtPollDirectory = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this._lblPollFrequency = new MetroFramework.Controls.MetroLabel();
            this._txtShellCommand = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this._txtPollFrequency = new MetroFramework.Controls.MetroTextBox();
            this._chkPollFiles = new MetroFramework.Controls.MetroCheckBox();
            this._chkPollDirs = new MetroFramework.Controls.MetroCheckBox();
            this._btnSelectPollLocation = new MetroFramework.Controls.MetroButton();
            this._txtFileRegex = new MetroFramework.Controls.MetroTextBox();
            this._txtDirRegex = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this._btnAddPollLocation = new MetroFramework.Controls.MetroButton();
            this._btnRemovePollLocation = new MetroFramework.Controls.MetroButton();
            this._grdPollLocations = new MetroFramework.Controls.MetroGrid();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._lblError = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this._cboFontSize = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this._chkChangedFiles = new MetroFramework.Controls.MetroCheckBox();
            this._chkAddedFiles = new MetroFramework.Controls.MetroCheckBox();
            this._chkDeletedFiles = new MetroFramework.Controls.MetroCheckBox();
            this._chkChangedFolders = new MetroFramework.Controls.MetroCheckBox();
            this._chkAddedFolders = new MetroFramework.Controls.MetroCheckBox();
            this._chkDeletedFolders = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this._chkShowStatusBar = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this._indentSpaces = new MetroFramework.Controls.MetroTextBox();
            this._chkShowLongBranches = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._grdPollLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnOk
            // 
            this._btnOk.ActiveControl = null;
            this._btnOk.Location = new System.Drawing.Point(172, 571);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(69, 40);
            this._btnOk.TabIndex = 0;
            this._btnOk.Text = "OK";
            this._btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnOk.UseSelectable = true;
            this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.ActiveControl = null;
            this._btnCancel.Location = new System.Drawing.Point(276, 571);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(69, 40);
            this._btnCancel.TabIndex = 0;
            this._btnCancel.Text = "CANCEL";
            this._btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnCancel.UseSelectable = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _txtPollDirectory
            // 
            // 
            // 
            // 
            this._txtPollDirectory.CustomButton.Image = null;
            this._txtPollDirectory.CustomButton.Location = new System.Drawing.Point(258, 1);
            this._txtPollDirectory.CustomButton.Name = "";
            this._txtPollDirectory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtPollDirectory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtPollDirectory.CustomButton.TabIndex = 1;
            this._txtPollDirectory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtPollDirectory.CustomButton.UseSelectable = true;
            this._txtPollDirectory.CustomButton.Visible = false;
            this._txtPollDirectory.Lines = new string[0];
            this._txtPollDirectory.Location = new System.Drawing.Point(55, 171);
            this._txtPollDirectory.MaxLength = 32767;
            this._txtPollDirectory.Name = "_txtPollDirectory";
            this._txtPollDirectory.PasswordChar = '\0';
            this._txtPollDirectory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtPollDirectory.SelectedText = "";
            this._txtPollDirectory.SelectionLength = 0;
            this._txtPollDirectory.SelectionStart = 0;
            this._txtPollDirectory.ShortcutsEnabled = true;
            this._txtPollDirectory.Size = new System.Drawing.Size(280, 23);
            this._txtPollDirectory.TabIndex = 1;
            this._txtPollDirectory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtPollDirectory.UseSelectable = true;
            this._txtPollDirectory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtPollDirectory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "POLL LOCATIONS";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblPollFrequency
            // 
            this._lblPollFrequency.AutoSize = true;
            this._lblPollFrequency.Location = new System.Drawing.Point(23, 300);
            this._lblPollFrequency.Name = "_lblPollFrequency";
            this._lblPollFrequency.Size = new System.Drawing.Size(151, 19);
            this._lblPollFrequency.TabIndex = 2;
            this._lblPollFrequency.Text = "POLL FREQUENCY (MS)";
            this._lblPollFrequency.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _txtShellCommand
            // 
            // 
            // 
            // 
            this._txtShellCommand.CustomButton.Image = null;
            this._txtShellCommand.CustomButton.Location = new System.Drawing.Point(281, 1);
            this._txtShellCommand.CustomButton.Name = "";
            this._txtShellCommand.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtShellCommand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtShellCommand.CustomButton.TabIndex = 1;
            this._txtShellCommand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtShellCommand.CustomButton.UseSelectable = true;
            this._txtShellCommand.CustomButton.Visible = false;
            this._txtShellCommand.Lines = new string[0];
            this._txtShellCommand.Location = new System.Drawing.Point(185, 331);
            this._txtShellCommand.MaxLength = 32767;
            this._txtShellCommand.Name = "_txtShellCommand";
            this._txtShellCommand.PasswordChar = '\0';
            this._txtShellCommand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtShellCommand.SelectedText = "";
            this._txtShellCommand.SelectionLength = 0;
            this._txtShellCommand.SelectionStart = 0;
            this._txtShellCommand.ShortcutsEnabled = true;
            this._txtShellCommand.Size = new System.Drawing.Size(303, 23);
            this._txtShellCommand.TabIndex = 1;
            this._txtShellCommand.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtShellCommand.UseSelectable = true;
            this._txtShellCommand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtShellCommand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 331);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(155, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "EXEC SHELL COMMAND";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _txtPollFrequency
            // 
            // 
            // 
            // 
            this._txtPollFrequency.CustomButton.Image = null;
            this._txtPollFrequency.CustomButton.Location = new System.Drawing.Point(83, 1);
            this._txtPollFrequency.CustomButton.Name = "";
            this._txtPollFrequency.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtPollFrequency.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtPollFrequency.CustomButton.TabIndex = 1;
            this._txtPollFrequency.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtPollFrequency.CustomButton.UseSelectable = true;
            this._txtPollFrequency.CustomButton.Visible = false;
            this._txtPollFrequency.Lines = new string[] {
        "100"};
            this._txtPollFrequency.Location = new System.Drawing.Point(180, 296);
            this._txtPollFrequency.MaxLength = 32767;
            this._txtPollFrequency.Name = "_txtPollFrequency";
            this._txtPollFrequency.PasswordChar = '\0';
            this._txtPollFrequency.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtPollFrequency.SelectedText = "";
            this._txtPollFrequency.SelectionLength = 0;
            this._txtPollFrequency.SelectionStart = 0;
            this._txtPollFrequency.ShortcutsEnabled = true;
            this._txtPollFrequency.Size = new System.Drawing.Size(105, 23);
            this._txtPollFrequency.TabIndex = 1;
            this._txtPollFrequency.Text = "100";
            this._txtPollFrequency.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtPollFrequency.UseSelectable = true;
            this._txtPollFrequency.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtPollFrequency.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._txtPollFrequency.TextChanged += new System.EventHandler(this._txtPollFrequency_TextChanged);
            this._txtPollFrequency.Click += new System.EventHandler(this._txtPollFrequency_Click);
            this._txtPollFrequency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtPollFrequency_KeyPress);
            this._txtPollFrequency.Validating += new System.ComponentModel.CancelEventHandler(this._txtPollFrequency_Validating);
            // 
            // _chkPollFiles
            // 
            this._chkPollFiles.AutoSize = true;
            this._chkPollFiles.Checked = true;
            this._chkPollFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkPollFiles.Location = new System.Drawing.Point(23, 250);
            this._chkPollFiles.Name = "_chkPollFiles";
            this._chkPollFiles.Size = new System.Drawing.Size(81, 15);
            this._chkPollFiles.TabIndex = 3;
            this._chkPollFiles.Text = "POLL FILES";
            this._chkPollFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkPollFiles.UseSelectable = true;
            this._chkPollFiles.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // _chkPollDirs
            // 
            this._chkPollDirs.AutoSize = true;
            this._chkPollDirs.Checked = true;
            this._chkPollDirs.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkPollDirs.Location = new System.Drawing.Point(23, 224);
            this._chkPollDirs.Name = "_chkPollDirs";
            this._chkPollDirs.Size = new System.Drawing.Size(123, 15);
            this._chkPollDirs.TabIndex = 3;
            this._chkPollDirs.Text = "POLL DIRECTORIES";
            this._chkPollDirs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkPollDirs.UseSelectable = true;
            this._chkPollDirs.CheckedChanged += new System.EventHandler(this._chkPollDirs_CheckedChanged);
            // 
            // _btnSelectPollLocation
            // 
            this._btnSelectPollLocation.Location = new System.Drawing.Point(24, 171);
            this._btnSelectPollLocation.Name = "_btnSelectPollLocation";
            this._btnSelectPollLocation.Size = new System.Drawing.Size(28, 23);
            this._btnSelectPollLocation.TabIndex = 7;
            this._btnSelectPollLocation.Text = "...";
            this._btnSelectPollLocation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnSelectPollLocation.UseSelectable = true;
            this._btnSelectPollLocation.Click += new System.EventHandler(this._btnSelectPollLocation_Click);
            // 
            // _txtFileRegex
            // 
            // 
            // 
            // 
            this._txtFileRegex.CustomButton.Image = null;
            this._txtFileRegex.CustomButton.Location = new System.Drawing.Point(254, 1);
            this._txtFileRegex.CustomButton.Name = "";
            this._txtFileRegex.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtFileRegex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtFileRegex.CustomButton.TabIndex = 1;
            this._txtFileRegex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtFileRegex.CustomButton.UseSelectable = true;
            this._txtFileRegex.CustomButton.Visible = false;
            this._txtFileRegex.Lines = new string[] {
        ".*"};
            this._txtFileRegex.Location = new System.Drawing.Point(172, 246);
            this._txtFileRegex.MaxLength = 32767;
            this._txtFileRegex.Name = "_txtFileRegex";
            this._txtFileRegex.PasswordChar = '\0';
            this._txtFileRegex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtFileRegex.SelectedText = "";
            this._txtFileRegex.SelectionLength = 0;
            this._txtFileRegex.SelectionStart = 0;
            this._txtFileRegex.ShortcutsEnabled = true;
            this._txtFileRegex.Size = new System.Drawing.Size(276, 23);
            this._txtFileRegex.TabIndex = 8;
            this._txtFileRegex.Text = ".*";
            this._txtFileRegex.UseSelectable = true;
            this._txtFileRegex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtFileRegex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _txtDirRegex
            // 
            // 
            // 
            // 
            this._txtDirRegex.CustomButton.Image = null;
            this._txtDirRegex.CustomButton.Location = new System.Drawing.Point(254, 1);
            this._txtDirRegex.CustomButton.Name = "";
            this._txtDirRegex.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtDirRegex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtDirRegex.CustomButton.TabIndex = 1;
            this._txtDirRegex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtDirRegex.CustomButton.UseSelectable = true;
            this._txtDirRegex.CustomButton.Visible = false;
            this._txtDirRegex.Lines = new string[] {
        ".*"};
            this._txtDirRegex.Location = new System.Drawing.Point(212, 218);
            this._txtDirRegex.MaxLength = 32767;
            this._txtDirRegex.Name = "_txtDirRegex";
            this._txtDirRegex.PasswordChar = '\0';
            this._txtDirRegex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtDirRegex.SelectedText = "";
            this._txtDirRegex.SelectionLength = 0;
            this._txtDirRegex.SelectionStart = 0;
            this._txtDirRegex.ShortcutsEnabled = true;
            this._txtDirRegex.Size = new System.Drawing.Size(276, 23);
            this._txtDirRegex.TabIndex = 8;
            this._txtDirRegex.Text = ".*";
            this._txtDirRegex.UseSelectable = true;
            this._txtDirRegex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtDirRegex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(121, 250);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "RegEx";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(161, 224);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "RegEx";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _btnAddPollLocation
            // 
            this._btnAddPollLocation.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this._btnAddPollLocation.Location = new System.Drawing.Point(342, 171);
            this._btnAddPollLocation.Name = "_btnAddPollLocation";
            this._btnAddPollLocation.Size = new System.Drawing.Size(39, 23);
            this._btnAddPollLocation.TabIndex = 0;
            this._btnAddPollLocation.Text = "Add";
            this._btnAddPollLocation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnAddPollLocation.UseSelectable = true;
            this._btnAddPollLocation.Click += new System.EventHandler(this._btnAddPollLocation_Click);
            // 
            // _btnRemovePollLocation
            // 
            this._btnRemovePollLocation.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this._btnRemovePollLocation.Location = new System.Drawing.Point(387, 171);
            this._btnRemovePollLocation.Name = "_btnRemovePollLocation";
            this._btnRemovePollLocation.Size = new System.Drawing.Size(56, 23);
            this._btnRemovePollLocation.TabIndex = 0;
            this._btnRemovePollLocation.Text = "Remove";
            this._btnRemovePollLocation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnRemovePollLocation.UseSelectable = true;
            this._btnRemovePollLocation.Click += new System.EventHandler(this._btnRemovePollLocation_Click);
            // 
            // _grdPollLocations
            // 
            this._grdPollLocations.AllowUserToResizeRows = false;
            this._grdPollLocations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._grdPollLocations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this._grdPollLocations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._grdPollLocations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._grdPollLocations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._grdPollLocations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._grdPollLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grdPollLocations.ColumnHeadersVisible = false;
            this._grdPollLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Path});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grdPollLocations.DefaultCellStyle = dataGridViewCellStyle2;
            this._grdPollLocations.EnableHeadersVisualStyles = false;
            this._grdPollLocations.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._grdPollLocations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this._grdPollLocations.Location = new System.Drawing.Point(15, 90);
            this._grdPollLocations.Name = "_grdPollLocations";
            this._grdPollLocations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._grdPollLocations.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._grdPollLocations.RowHeadersVisible = false;
            this._grdPollLocations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._grdPollLocations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grdPollLocations.Size = new System.Drawing.Size(473, 75);
            this._grdPollLocations.TabIndex = 10;
            this._grdPollLocations.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._grdPollLocations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._grdPollLocations_CellContentClick);
            this._grdPollLocations.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this._grdPollLocations_CellValidating);
            this._grdPollLocations.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this._grdPollLocations_CellValueChanged);
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            // 
            // _lblError
            // 
            this._lblError.AutoSize = true;
            this._lblError.ForeColor = System.Drawing.Color.Red;
            this._lblError.Location = new System.Drawing.Point(24, 362);
            this._lblError.Name = "_lblError";
            this._lblError.Size = new System.Drawing.Size(0, 0);
            this._lblError.TabIndex = 11;
            this._lblError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._lblError.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(28, 408);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(138, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "CONSOLE FONT SIZE";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _cboFontSize
            // 
            this._cboFontSize.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this._cboFontSize.FormattingEnabled = true;
            this._cboFontSize.ItemHeight = 19;
            this._cboFontSize.Items.AddRange(new object[] {
            "6",
            "8",
            "12",
            "14",
            "16",
            "20",
            "22",
            "24",
            "28",
            "32",
            "36",
            "40"});
            this._cboFontSize.Location = new System.Drawing.Point(172, 408);
            this._cboFontSize.Name = "_cboFontSize";
            this._cboFontSize.Size = new System.Drawing.Size(56, 25);
            this._cboFontSize.TabIndex = 12;
            this._cboFontSize.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._cboFontSize.UseSelectable = true;
            this._cboFontSize.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(10, 380);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "DISPLAY";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _chkChangedFiles
            // 
            this._chkChangedFiles.AutoSize = true;
            this._chkChangedFiles.Checked = true;
            this._chkChangedFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkChangedFiles.Location = new System.Drawing.Point(163, 482);
            this._chkChangedFiles.Name = "_chkChangedFiles";
            this._chkChangedFiles.Size = new System.Drawing.Size(109, 15);
            this._chkChangedFiles.TabIndex = 3;
            this._chkChangedFiles.Text = "CHANGED FILES";
            this._chkChangedFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkChangedFiles.UseSelectable = true;
            this._chkChangedFiles.CheckedChanged += new System.EventHandler(this._chkPollDirs_CheckedChanged);
            // 
            // _chkAddedFiles
            // 
            this._chkAddedFiles.AutoSize = true;
            this._chkAddedFiles.Checked = true;
            this._chkAddedFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkAddedFiles.Location = new System.Drawing.Point(45, 482);
            this._chkAddedFiles.Name = "_chkAddedFiles";
            this._chkAddedFiles.Size = new System.Drawing.Size(91, 15);
            this._chkAddedFiles.TabIndex = 3;
            this._chkAddedFiles.Text = "ADDED FILES";
            this._chkAddedFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkAddedFiles.UseSelectable = true;
            this._chkAddedFiles.CheckedChanged += new System.EventHandler(this._chkPollDirs_CheckedChanged);
            // 
            // _chkDeletedFiles
            // 
            this._chkDeletedFiles.AutoSize = true;
            this._chkDeletedFiles.Checked = true;
            this._chkDeletedFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkDeletedFiles.Location = new System.Drawing.Point(309, 482);
            this._chkDeletedFiles.Name = "_chkDeletedFiles";
            this._chkDeletedFiles.Size = new System.Drawing.Size(100, 15);
            this._chkDeletedFiles.TabIndex = 3;
            this._chkDeletedFiles.Text = "DELETED FILES";
            this._chkDeletedFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkDeletedFiles.UseSelectable = true;
            this._chkDeletedFiles.CheckedChanged += new System.EventHandler(this._chkPollDirs_CheckedChanged);
            // 
            // _chkChangedFolders
            // 
            this._chkChangedFolders.AutoSize = true;
            this._chkChangedFolders.Checked = true;
            this._chkChangedFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkChangedFolders.Location = new System.Drawing.Point(163, 461);
            this._chkChangedFolders.Name = "_chkChangedFolders";
            this._chkChangedFolders.Size = new System.Drawing.Size(130, 15);
            this._chkChangedFolders.TabIndex = 3;
            this._chkChangedFolders.Text = "CHANGED FOLDERS";
            this._chkChangedFolders.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkChangedFolders.UseSelectable = true;
            this._chkChangedFolders.CheckedChanged += new System.EventHandler(this._chkPollDirs_CheckedChanged);
            // 
            // _chkAddedFolders
            // 
            this._chkAddedFolders.AutoSize = true;
            this._chkAddedFolders.Checked = true;
            this._chkAddedFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkAddedFolders.Location = new System.Drawing.Point(45, 461);
            this._chkAddedFolders.Name = "_chkAddedFolders";
            this._chkAddedFolders.Size = new System.Drawing.Size(112, 15);
            this._chkAddedFolders.TabIndex = 3;
            this._chkAddedFolders.Text = "ADDED FOLDERS";
            this._chkAddedFolders.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkAddedFolders.UseSelectable = true;
            this._chkAddedFolders.CheckedChanged += new System.EventHandler(this._chkPollDirs_CheckedChanged);
            // 
            // _chkDeletedFolders
            // 
            this._chkDeletedFolders.AutoSize = true;
            this._chkDeletedFolders.Checked = true;
            this._chkDeletedFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkDeletedFolders.Location = new System.Drawing.Point(309, 461);
            this._chkDeletedFolders.Name = "_chkDeletedFolders";
            this._chkDeletedFolders.Size = new System.Drawing.Size(121, 15);
            this._chkDeletedFolders.TabIndex = 3;
            this._chkDeletedFolders.Text = "DELETED FOLDERS";
            this._chkDeletedFolders.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkDeletedFolders.UseSelectable = true;
            this._chkDeletedFolders.CheckedChanged += new System.EventHandler(this._chkPollDirs_CheckedChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(28, 439);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(125, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "CONSOLE OUTPUT";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(28, 510);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(40, 19);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "MISC";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _chkShowStatusBar
            // 
            this._chkShowStatusBar.AutoSize = true;
            this._chkShowStatusBar.Location = new System.Drawing.Point(44, 532);
            this._chkShowStatusBar.Name = "_chkShowStatusBar";
            this._chkShowStatusBar.Size = new System.Drawing.Size(126, 15);
            this._chkShowStatusBar.TabIndex = 3;
            this._chkShowStatusBar.Text = "SHOW STATUS BAR";
            this._chkShowStatusBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkShowStatusBar.UseSelectable = true;
            this._chkShowStatusBar.CheckedChanged += new System.EventHandler(this._chkPollDirs_CheckedChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(265, 408);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(116, 19);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "# INDENT SPACES";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _indentSpaces
            // 
            // 
            // 
            // 
            this._indentSpaces.CustomButton.Image = null;
            this._indentSpaces.CustomButton.Location = new System.Drawing.Point(25, 1);
            this._indentSpaces.CustomButton.Name = "";
            this._indentSpaces.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._indentSpaces.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._indentSpaces.CustomButton.TabIndex = 1;
            this._indentSpaces.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._indentSpaces.CustomButton.UseSelectable = true;
            this._indentSpaces.CustomButton.Visible = false;
            this._indentSpaces.Lines = new string[] {
        "6"};
            this._indentSpaces.Location = new System.Drawing.Point(383, 408);
            this._indentSpaces.MaxLength = 32767;
            this._indentSpaces.Name = "_indentSpaces";
            this._indentSpaces.PasswordChar = '\0';
            this._indentSpaces.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._indentSpaces.SelectedText = "";
            this._indentSpaces.SelectionLength = 0;
            this._indentSpaces.SelectionStart = 0;
            this._indentSpaces.ShortcutsEnabled = true;
            this._indentSpaces.Size = new System.Drawing.Size(47, 23);
            this._indentSpaces.TabIndex = 13;
            this._indentSpaces.Text = "6";
            this._indentSpaces.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._indentSpaces.UseSelectable = true;
            this._indentSpaces.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._indentSpaces.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._indentSpaces.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._indentSpaces_KeyPress);
            // 
            // _chkShowLongBranches
            // 
            this._chkShowLongBranches.AutoSize = true;
            this._chkShowLongBranches.Checked = true;
            this._chkShowLongBranches.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkShowLongBranches.Location = new System.Drawing.Point(180, 532);
            this._chkShowLongBranches.Name = "_chkShowLongBranches";
            this._chkShowLongBranches.Size = new System.Drawing.Size(156, 15);
            this._chkShowLongBranches.TabIndex = 3;
            this._chkShowLongBranches.Text = "SHOW LONG BRANCHES";
            this._chkShowLongBranches.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkShowLongBranches.UseSelectable = true;
            this._chkShowLongBranches.CheckedChanged += new System.EventHandler(this._chkPollDirs_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 647);
            this.Controls.Add(this._indentSpaces);
            this.Controls.Add(this._cboFontSize);
            this.Controls.Add(this._lblError);
            this.Controls.Add(this._grdPollLocations);
            this.Controls.Add(this._btnRemovePollLocation);
            this.Controls.Add(this._btnAddPollLocation);
            this.Controls.Add(this._txtDirRegex);
            this.Controls.Add(this._txtFileRegex);
            this.Controls.Add(this._btnSelectPollLocation);
            this.Controls.Add(this._chkDeletedFolders);
            this.Controls.Add(this._chkDeletedFiles);
            this.Controls.Add(this._chkAddedFolders);
            this.Controls.Add(this._chkAddedFiles);
            this.Controls.Add(this._chkChangedFolders);
            this.Controls.Add(this._chkShowLongBranches);
            this.Controls.Add(this._chkShowStatusBar);
            this.Controls.Add(this._chkChangedFiles);
            this.Controls.Add(this._chkPollDirs);
            this.Controls.Add(this._chkPollFiles);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this._lblPollFrequency);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this._txtShellCommand);
            this.Controls.Add(this._txtPollFrequency);
            this.Controls.Add(this._txtPollDirectory);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._grdPollLocations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile _btnOk;
        private MetroFramework.Controls.MetroTile _btnCancel;
        private MetroFramework.Controls.MetroTextBox _txtPollDirectory;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel _lblPollFrequency;
        private MetroFramework.Controls.MetroTextBox _txtShellCommand;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox _txtPollFrequency;
        private MetroFramework.Controls.MetroCheckBox _chkPollFiles;
        private MetroFramework.Controls.MetroCheckBox _chkPollDirs;
        private MetroFramework.Controls.MetroButton _btnSelectPollLocation;
        private MetroFramework.Controls.MetroTextBox _txtFileRegex;
        private MetroFramework.Controls.MetroTextBox _txtDirRegex;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton _btnAddPollLocation;
        private MetroFramework.Controls.MetroButton _btnRemovePollLocation;
        private MetroFramework.Controls.MetroGrid _grdPollLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private MetroFramework.Controls.MetroLabel _lblError;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox _cboFontSize;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroCheckBox _chkChangedFiles;
        private MetroFramework.Controls.MetroCheckBox _chkAddedFiles;
        private MetroFramework.Controls.MetroCheckBox _chkDeletedFiles;
        private MetroFramework.Controls.MetroCheckBox _chkChangedFolders;
        private MetroFramework.Controls.MetroCheckBox _chkAddedFolders;
        private MetroFramework.Controls.MetroCheckBox _chkDeletedFolders;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroCheckBox _chkShowStatusBar;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox _indentSpaces;
        private MetroFramework.Controls.MetroCheckBox _chkShowLongBranches;
    }
}