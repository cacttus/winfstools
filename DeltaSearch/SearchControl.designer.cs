namespace DeltaSearch
{
    partial class SearchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this._chkFilenameRegex = new System.Windows.Forms.CheckBox();
            this._chkFilenameCaseSensitive = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this._chkMatchWholeFile = new MetroFramework.Controls.MetroToggle();
            this._chkSearchPdf = new MetroFramework.Controls.MetroToggle();
            this._chkSearchChm = new MetroFramework.Controls.MetroToggle();
            this._chkSearchDoc = new MetroFramework.Controls.MetroToggle();
            this._nudSizeLesser = new System.Windows.Forms.NumericUpDown();
            this._nudSizeGreater = new System.Windows.Forms.NumericUpDown();
            this._chkSizeLesser = new System.Windows.Forms.CheckBox();
            this._chkSizeGreater = new System.Windows.Forms.CheckBox();
            this._chkFileContentsCaseSensitive = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._dgvFileSearchResults = new MetroFramework.Controls.MetroGrid();
            this._colFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colDateModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colFileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._txtSearchResultsDetails = new MetroFramework.Controls.MetroTextBox();
            this._chkFileContentsRegex = new System.Windows.Forms.CheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this._btnSearch = new MetroFramework.Controls.MetroButton();
            this._cboSearchPaths_Dummy = new MetroFramework.Controls.MetroComboBox();
            this._btnAddMultiplePaths = new System.Windows.Forms.Button();
            this._btnAddSearchPath = new System.Windows.Forms.Button();
            this._txtFileContents_Dummy = new MetroFramework.Controls.MetroComboBox();
            this._txtFileName_Dummy = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudSizeLesser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudSizeGreater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvFileSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // _chkFilenameRegex
            // 
            this._chkFilenameRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._chkFilenameRegex.Appearance = System.Windows.Forms.Appearance.Button;
            this._chkFilenameRegex.Checked = true;
            this._chkFilenameRegex.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkFilenameRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkFilenameRegex.Location = new System.Drawing.Point(682, 9);
            this._chkFilenameRegex.Name = "_chkFilenameRegex";
            this._chkFilenameRegex.Size = new System.Drawing.Size(25, 25);
            this._chkFilenameRegex.TabIndex = 1;
            this._chkFilenameRegex.Text = ".*";
            this._chkFilenameRegex.UseVisualStyleBackColor = true;
            // 
            // _chkFilenameCaseSensitive
            // 
            this._chkFilenameCaseSensitive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._chkFilenameCaseSensitive.Appearance = System.Windows.Forms.Appearance.Button;
            this._chkFilenameCaseSensitive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkFilenameCaseSensitive.Location = new System.Drawing.Point(714, 9);
            this._chkFilenameCaseSensitive.Name = "_chkFilenameCaseSensitive";
            this._chkFilenameCaseSensitive.Size = new System.Drawing.Size(31, 25);
            this._chkFilenameCaseSensitive.TabIndex = 2;
            this._chkFilenameCaseSensitive.Text = "aA";
            this._chkFilenameCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this._chkMatchWholeFile);
            this.groupBox1.Controls.Add(this._chkSearchPdf);
            this.groupBox1.Controls.Add(this._chkSearchChm);
            this.groupBox1.Controls.Add(this._chkSearchDoc);
            this.groupBox1.Controls.Add(this._nudSizeLesser);
            this.groupBox1.Controls.Add(this._nudSizeGreater);
            this.groupBox1.Controls.Add(this._chkSizeLesser);
            this.groupBox1.Controls.Add(this._chkSizeGreater);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(96, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 110);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Options";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(11, 76);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 10004;
            this.metroLabel5.Text = "Size (kB)";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(145, 46);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(111, 19);
            this.metroLabel6.TabIndex = 10004;
            this.metroLabel6.Text = "Match Whole File";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(11, 21);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(33, 19);
            this.metroLabel7.TabIndex = 10004;
            this.metroLabel7.Text = "PDF";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(6, 45);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(39, 19);
            this.metroLabel8.TabIndex = 10004;
            this.metroLabel8.Text = "CHM";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(118, 22);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(138, 19);
            this.metroLabel4.TabIndex = 10004;
            this.metroLabel4.Text = "MS Word (.doc/.docx)";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _chkMatchWholeFile
            // 
            this._chkMatchWholeFile.AutoSize = true;
            this._chkMatchWholeFile.DisplayStatus = false;
            this._chkMatchWholeFile.Location = new System.Drawing.Point(262, 45);
            this._chkMatchWholeFile.Name = "_chkMatchWholeFile";
            this._chkMatchWholeFile.Size = new System.Drawing.Size(50, 20);
            this._chkMatchWholeFile.TabIndex = 10003;
            this._chkMatchWholeFile.Text = "Off";
            this._chkMatchWholeFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkMatchWholeFile.UseSelectable = true;
            // 
            // _chkSearchPdf
            // 
            this._chkSearchPdf.AutoSize = true;
            this._chkSearchPdf.DisplayStatus = false;
            this._chkSearchPdf.Location = new System.Drawing.Point(51, 21);
            this._chkSearchPdf.Name = "_chkSearchPdf";
            this._chkSearchPdf.Size = new System.Drawing.Size(50, 20);
            this._chkSearchPdf.TabIndex = 10003;
            this._chkSearchPdf.Text = "Off";
            this._chkSearchPdf.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkSearchPdf.UseSelectable = true;
            // 
            // _chkSearchChm
            // 
            this._chkSearchChm.AutoSize = true;
            this._chkSearchChm.DisplayStatus = false;
            this._chkSearchChm.Location = new System.Drawing.Point(51, 45);
            this._chkSearchChm.Name = "_chkSearchChm";
            this._chkSearchChm.Size = new System.Drawing.Size(50, 20);
            this._chkSearchChm.TabIndex = 10003;
            this._chkSearchChm.Text = "Off";
            this._chkSearchChm.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkSearchChm.UseSelectable = true;
            // 
            // _chkSearchDoc
            // 
            this._chkSearchDoc.AutoSize = true;
            this._chkSearchDoc.DisplayStatus = false;
            this._chkSearchDoc.Location = new System.Drawing.Point(262, 22);
            this._chkSearchDoc.Name = "_chkSearchDoc";
            this._chkSearchDoc.Size = new System.Drawing.Size(50, 20);
            this._chkSearchDoc.TabIndex = 10003;
            this._chkSearchDoc.Text = "Off";
            this._chkSearchDoc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._chkSearchDoc.UseSelectable = true;
            // 
            // _nudSizeLesser
            // 
            this._nudSizeLesser.Enabled = false;
            this._nudSizeLesser.Location = new System.Drawing.Point(226, 73);
            this._nudSizeLesser.Name = "_nudSizeLesser";
            this._nudSizeLesser.Size = new System.Drawing.Size(75, 22);
            this._nudSizeLesser.TabIndex = 16;
            // 
            // _nudSizeGreater
            // 
            this._nudSizeGreater.Enabled = false;
            this._nudSizeGreater.Location = new System.Drawing.Point(105, 74);
            this._nudSizeGreater.Name = "_nudSizeGreater";
            this._nudSizeGreater.Size = new System.Drawing.Size(75, 22);
            this._nudSizeGreater.TabIndex = 14;
            // 
            // _chkSizeLesser
            // 
            this._chkSizeLesser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._chkSizeLesser.Appearance = System.Windows.Forms.Appearance.Button;
            this._chkSizeLesser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkSizeLesser.Location = new System.Drawing.Point(196, 74);
            this._chkSizeLesser.Name = "_chkSizeLesser";
            this._chkSizeLesser.Size = new System.Drawing.Size(24, 22);
            this._chkSizeLesser.TabIndex = 15;
            this._chkSizeLesser.Text = "<";
            this._chkSizeLesser.UseVisualStyleBackColor = true;
            this._chkSizeLesser.CheckedChanged += new System.EventHandler(this._chkSizeLesser_CheckedChanged);
            // 
            // _chkSizeGreater
            // 
            this._chkSizeGreater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._chkSizeGreater.Appearance = System.Windows.Forms.Appearance.Button;
            this._chkSizeGreater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkSizeGreater.Location = new System.Drawing.Point(75, 74);
            this._chkSizeGreater.Name = "_chkSizeGreater";
            this._chkSizeGreater.Size = new System.Drawing.Size(24, 22);
            this._chkSizeGreater.TabIndex = 13;
            this._chkSizeGreater.Text = ">";
            this._chkSizeGreater.UseVisualStyleBackColor = true;
            this._chkSizeGreater.CheckedChanged += new System.EventHandler(this._chkSizeGreater_CheckedChanged);
            // 
            // _chkFileContentsCaseSensitive
            // 
            this._chkFileContentsCaseSensitive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._chkFileContentsCaseSensitive.Appearance = System.Windows.Forms.Appearance.Button;
            this._chkFileContentsCaseSensitive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkFileContentsCaseSensitive.Location = new System.Drawing.Point(713, 44);
            this._chkFileContentsCaseSensitive.Name = "_chkFileContentsCaseSensitive";
            this._chkFileContentsCaseSensitive.Size = new System.Drawing.Size(32, 24);
            this._chkFileContentsCaseSensitive.TabIndex = 5;
            this._chkFileContentsCaseSensitive.Text = "aA";
            this._chkFileContentsCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 271);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._dgvFileSearchResults);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._txtSearchResultsDetails);
            this.splitContainer1.Size = new System.Drawing.Size(791, 342);
            this.splitContainer1.SplitterDistance = 525;
            this.splitContainer1.TabIndex = 24;
            // 
            // _dgvFileSearchResults
            // 
            this._dgvFileSearchResults.AllowUserToAddRows = false;
            this._dgvFileSearchResults.AllowUserToResizeRows = false;
            this._dgvFileSearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dgvFileSearchResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this._dgvFileSearchResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dgvFileSearchResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._dgvFileSearchResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvFileSearchResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._dgvFileSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._dgvFileSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._colFile,
            this._colDateModified,
            this._colFileType,
            this._colSize});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dgvFileSearchResults.DefaultCellStyle = dataGridViewCellStyle2;
            this._dgvFileSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dgvFileSearchResults.EnableHeadersVisualStyles = false;
            this._dgvFileSearchResults.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._dgvFileSearchResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this._dgvFileSearchResults.Location = new System.Drawing.Point(0, 0);
            this._dgvFileSearchResults.Name = "_dgvFileSearchResults";
            this._dgvFileSearchResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvFileSearchResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._dgvFileSearchResults.RowHeadersVisible = false;
            this._dgvFileSearchResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._dgvFileSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvFileSearchResults.Size = new System.Drawing.Size(525, 342);
            this._dgvFileSearchResults.TabIndex = 10004;
            this._dgvFileSearchResults.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._dgvFileSearchResults.SelectionChanged += new System.EventHandler(this._dgvFileSearchResults_SelectionChanged_1);
            // 
            // _colFile
            // 
            this._colFile.HeaderText = "File";
            this._colFile.Name = "_colFile";
            // 
            // _colDateModified
            // 
            this._colDateModified.HeaderText = "Modified";
            this._colDateModified.Name = "_colDateModified";
            // 
            // _colFileType
            // 
            this._colFileType.HeaderText = "File Type";
            this._colFileType.Name = "_colFileType";
            // 
            // _colSize
            // 
            this._colSize.HeaderText = "Size (kB)";
            this._colSize.Name = "_colSize";
            // 
            // _txtSearchResultsDetails
            // 
            // 
            // 
            // 
            this._txtSearchResultsDetails.CustomButton.Image = null;
            this._txtSearchResultsDetails.CustomButton.Location = new System.Drawing.Point(-78, 2);
            this._txtSearchResultsDetails.CustomButton.Name = "";
            this._txtSearchResultsDetails.CustomButton.Size = new System.Drawing.Size(337, 337);
            this._txtSearchResultsDetails.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtSearchResultsDetails.CustomButton.TabIndex = 1;
            this._txtSearchResultsDetails.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtSearchResultsDetails.CustomButton.UseSelectable = true;
            this._txtSearchResultsDetails.CustomButton.Visible = false;
            this._txtSearchResultsDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtSearchResultsDetails.Lines = new string[0];
            this._txtSearchResultsDetails.Location = new System.Drawing.Point(0, 0);
            this._txtSearchResultsDetails.MaxLength = 32767;
            this._txtSearchResultsDetails.Multiline = true;
            this._txtSearchResultsDetails.Name = "_txtSearchResultsDetails";
            this._txtSearchResultsDetails.PasswordChar = '\0';
            this._txtSearchResultsDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._txtSearchResultsDetails.SelectedText = "";
            this._txtSearchResultsDetails.SelectionLength = 0;
            this._txtSearchResultsDetails.SelectionStart = 0;
            this._txtSearchResultsDetails.ShortcutsEnabled = true;
            this._txtSearchResultsDetails.Size = new System.Drawing.Size(262, 342);
            this._txtSearchResultsDetails.TabIndex = 0;
            this._txtSearchResultsDetails.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtSearchResultsDetails.UseSelectable = true;
            this._txtSearchResultsDetails.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtSearchResultsDetails.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _chkFileContentsRegex
            // 
            this._chkFileContentsRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._chkFileContentsRegex.Appearance = System.Windows.Forms.Appearance.Button;
            this._chkFileContentsRegex.Checked = true;
            this._chkFileContentsRegex.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkFileContentsRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkFileContentsRegex.Location = new System.Drawing.Point(682, 44);
            this._chkFileContentsRegex.Name = "_chkFileContentsRegex";
            this._chkFileContentsRegex.Size = new System.Drawing.Size(25, 25);
            this._chkFileContentsRegex.TabIndex = 4;
            this._chkFileContentsRegex.Text = ".*";
            this._chkFileContentsRegex.UseVisualStyleBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 10000;
            this.metroLabel1.Text = "Directory";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 44);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 19);
            this.metroLabel2.TabIndex = 10000;
            this.metroLabel2.Text = "Contents";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(8, 15);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 10000;
            this.metroLabel3.Text = "Filename";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(25, 249);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(91, 19);
            this.metroLabel9.TabIndex = 10000;
            this.metroLabel9.Text = "Search Results";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _btnSearch
            // 
            this._btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSearch.Location = new System.Drawing.Point(582, 123);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(88, 33);
            this._btnSearch.TabIndex = 9;
            this._btnSearch.Text = "Search";
            this._btnSearch.UseSelectable = true;
            this._btnSearch.Click += new System.EventHandler(this._btnSearch_Click);
            // 
            // _cboSearchPaths_Dummy
            // 
            this._cboSearchPaths_Dummy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cboSearchPaths_Dummy.FormattingEnabled = true;
            this._cboSearchPaths_Dummy.ItemHeight = 23;
            this._cboSearchPaths_Dummy.Location = new System.Drawing.Point(74, 79);
            this._cboSearchPaths_Dummy.Name = "_cboSearchPaths_Dummy";
            this._cboSearchPaths_Dummy.Size = new System.Drawing.Size(596, 29);
            this._cboSearchPaths_Dummy.TabIndex = 6;
            this._cboSearchPaths_Dummy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._cboSearchPaths_Dummy.UseSelectable = true;
            // 
            // _btnAddMultiplePaths
            // 
            this._btnAddMultiplePaths.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAddMultiplePaths.BackgroundImage = global::DeltaSearch.Properties.Resources.multiple_folders;
            this._btnAddMultiplePaths.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnAddMultiplePaths.Location = new System.Drawing.Point(713, 79);
            this._btnAddMultiplePaths.Name = "_btnAddMultiplePaths";
            this._btnAddMultiplePaths.Size = new System.Drawing.Size(33, 30);
            this._btnAddMultiplePaths.TabIndex = 8;
            this._btnAddMultiplePaths.UseVisualStyleBackColor = true;
            this._btnAddMultiplePaths.Click += new System.EventHandler(this._btnAddMultiplePaths_Click);
            // 
            // _btnAddSearchPath
            // 
            this._btnAddSearchPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAddSearchPath.BackgroundImage = global::DeltaSearch.Properties.Resources.folders;
            this._btnAddSearchPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnAddSearchPath.Location = new System.Drawing.Point(676, 80);
            this._btnAddSearchPath.Name = "_btnAddSearchPath";
            this._btnAddSearchPath.Size = new System.Drawing.Size(31, 29);
            this._btnAddSearchPath.TabIndex = 7;
            this._btnAddSearchPath.UseVisualStyleBackColor = true;
            this._btnAddSearchPath.Click += new System.EventHandler(this._btnAddSearchPath_Click);
            // 
            // _txtFileContents_Dummy
            // 
            this._txtFileContents_Dummy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtFileContents_Dummy.FormattingEnabled = true;
            this._txtFileContents_Dummy.ItemHeight = 23;
            this._txtFileContents_Dummy.Location = new System.Drawing.Point(74, 43);
            this._txtFileContents_Dummy.Name = "_txtFileContents_Dummy";
            this._txtFileContents_Dummy.Size = new System.Drawing.Size(596, 29);
            this._txtFileContents_Dummy.TabIndex = 10001;
            this._txtFileContents_Dummy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtFileContents_Dummy.UseSelectable = true;
            // 
            // _txtFileName_Dummy
            // 
            this._txtFileName_Dummy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtFileName_Dummy.FormattingEnabled = true;
            this._txtFileName_Dummy.ItemHeight = 23;
            this._txtFileName_Dummy.Location = new System.Drawing.Point(74, 9);
            this._txtFileName_Dummy.Name = "_txtFileName_Dummy";
            this._txtFileName_Dummy.Size = new System.Drawing.Size(596, 29);
            this._txtFileName_Dummy.TabIndex = 10001;
            this._txtFileName_Dummy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtFileName_Dummy.UseSelectable = true;
            // 
            // SearchControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this._txtFileName_Dummy);
            this.Controls.Add(this._txtFileContents_Dummy);
            this.Controls.Add(this._btnSearch);
            this.Controls.Add(this._cboSearchPaths_Dummy);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this._btnAddMultiplePaths);
            this.Controls.Add(this._btnAddSearchPath);
            this.Controls.Add(this._chkFilenameRegex);
            this.Controls.Add(this._chkFilenameCaseSensitive);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._chkFileContentsCaseSensitive);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this._chkFileContentsRegex);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(794, 616);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SearchControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudSizeLesser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudSizeGreater)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dgvFileSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _btnAddSearchPath;
        private System.Windows.Forms.CheckBox _chkFilenameRegex;
        private System.Windows.Forms.CheckBox _chkFilenameCaseSensitive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown _nudSizeLesser;
        private System.Windows.Forms.NumericUpDown _nudSizeGreater;
        private System.Windows.Forms.CheckBox _chkFileContentsCaseSensitive;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox _chkFileContentsRegex;
        private System.Windows.Forms.CheckBox _chkSizeLesser;
        private System.Windows.Forms.CheckBox _chkSizeGreater;
        private System.Windows.Forms.Button _btnAddMultiplePaths;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroToggle _chkMatchWholeFile;
        private MetroFramework.Controls.MetroToggle _chkSearchPdf;
        private MetroFramework.Controls.MetroToggle _chkSearchChm;
        private MetroFramework.Controls.MetroToggle _chkSearchDoc;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton _btnSearch;
        private MetroFramework.Controls.MetroGrid _dgvFileSearchResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colDateModified;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colFileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn _colSize;
        private MetroFramework.Controls.MetroTextBox _txtSearchResultsDetails;
        private MetroFramework.Controls.MetroComboBox _cboSearchPaths_Dummy;
        private MetroFramework.Controls.MetroComboBox _txtFileContents_Dummy;
        private MetroFramework.Controls.MetroComboBox _txtFileName_Dummy;
    }
}
