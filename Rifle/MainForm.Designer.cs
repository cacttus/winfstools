namespace Rifle
{
    partial class MainForm
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._btnNext = new System.Windows.Forms.Button();
            this._txtPath = new System.Windows.Forms.TextBox();
            this._lblSearchInFolder = new System.Windows.Forms.Label();
            this._chkClosePrevious = new System.Windows.Forms.CheckBox();
            this._grpOptions = new System.Windows.Forms.GroupBox();
            this._btnUpdateSearch = new System.Windows.Forms.Button();
            this._chkFilterWidthHeight = new System.Windows.Forms.CheckBox();
            this._lblFilterHeight = new System.Windows.Forms.Label();
            this._lblFilterWidth = new System.Windows.Forms.Label();
            this._nudMaxHeight = new System.Windows.Forms.NumericUpDown();
            this._nudMinHeight = new System.Windows.Forms.NumericUpDown();
            this._nudMaxWidth = new System.Windows.Forms.NumericUpDown();
            this._nudMinWidth = new System.Windows.Forms.NumericUpDown();
            this._btnActivate = new System.Windows.Forms.Button();
            this._chkRandom = new System.Windows.Forms.CheckBox();
            this._chkForceKill = new System.Windows.Forms.CheckBox();
            this._chkIgnoreBadFiles = new System.Windows.Forms.CheckBox();
            this._lblArguments = new System.Windows.Forms.Label();
            this._txtArguments = new System.Windows.Forms.TextBox();
            this._lblFileGatherTimeout = new System.Windows.Forms.Label();
            this._nudMaxFiles = new System.Windows.Forms.NumericUpDown();
            this._nudFileGatherTimeout = new System.Windows.Forms.NumericUpDown();
            this._chkMaximizeWindow = new System.Windows.Forms.CheckBox();
            this._chkShowStopWatch = new System.Windows.Forms.CheckBox();
            this._lblMaxFiles = new System.Windows.Forms.Label();
            this._chkShiftFocus = new System.Windows.Forms.CheckBox();
            this._chkRepeat = new System.Windows.Forms.CheckBox();
            this._chkSearchFolders = new System.Windows.Forms.CheckBox();
            this._btnArtDefaults = new System.Windows.Forms.Button();
            this._btnPrev = new System.Windows.Forms.Button();
            this._lblFileCount = new System.Windows.Forms.Label();
            this._lblFilesRemaining = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._lblFilePath = new System.Windows.Forms.Label();
            this._chkShowOptions = new System.Windows.Forms.CheckBox();
            this._btnSelectFolder = new System.Windows.Forms.Button();
            this._objStatusStrip = new System.Windows.Forms.StatusStrip();
            this._lblStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._btnStartWatch = new System.Windows.Forms.Button();
            this._btnResetWatch = new System.Windows.Forms.Button();
            this._btnPauseWatch = new System.Windows.Forms.Button();
            this._grpStopWatch = new System.Windows.Forms.GroupBox();
            this._chkResetWatchAtEnd = new System.Windows.Forms.CheckBox();
            this._chkWatchCycle = new System.Windows.Forms.CheckBox();
            this._lblStopWatchTime = new System.Windows.Forms.Label();
            this._nudSeconds = new System.Windows.Forms.NumericUpDown();
            this._nudHours = new System.Windows.Forms.NumericUpDown();
            this._nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuFileFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.manageFileTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this._grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudMaxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudMinHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudMaxWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudMinWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudMaxFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudFileGatherTimeout)).BeginInit();
            this.groupBox2.SuspendLayout();
            this._objStatusStrip.SuspendLayout();
            this._grpStopWatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudMinutes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnNext
            // 
            this._btnNext.Location = new System.Drawing.Point(253, 75);
            this._btnNext.Name = "_btnNext";
            this._btnNext.Size = new System.Drawing.Size(75, 22);
            this._btnNext.TabIndex = 0;
            this._btnNext.Text = "Next >";
            this._btnNext.UseVisualStyleBackColor = true;
            this._btnNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // _txtPath
            // 
            this._txtPath.Location = new System.Drawing.Point(12, 46);
            this._txtPath.Name = "_txtPath";
            this._txtPath.Size = new System.Drawing.Size(303, 20);
            this._txtPath.TabIndex = 1;
            this._txtPath.TextChanged += new System.EventHandler(this._txtPath_TextChanged);
            // 
            // _lblSearchInFolder
            // 
            this._lblSearchInFolder.AutoSize = true;
            this._lblSearchInFolder.Location = new System.Drawing.Point(9, 30);
            this._lblSearchInFolder.Name = "_lblSearchInFolder";
            this._lblSearchInFolder.Size = new System.Drawing.Size(88, 13);
            this._lblSearchInFolder.TabIndex = 2;
            this._lblSearchInFolder.Text = "Search In Folder:";
            // 
            // _chkClosePrevious
            // 
            this._chkClosePrevious.AutoSize = true;
            this._chkClosePrevious.Checked = true;
            this._chkClosePrevious.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkClosePrevious.Location = new System.Drawing.Point(11, 29);
            this._chkClosePrevious.Name = "_chkClosePrevious";
            this._chkClosePrevious.Size = new System.Drawing.Size(96, 17);
            this._chkClosePrevious.TabIndex = 3;
            this._chkClosePrevious.Text = "Close Previous";
            this._chkClosePrevious.UseVisualStyleBackColor = true;
            this._chkClosePrevious.CheckedChanged += new System.EventHandler(this._chkClosePrevious_CheckedChanged);
            // 
            // _grpOptions
            // 
            this._grpOptions.Controls.Add(this._btnUpdateSearch);
            this._grpOptions.Controls.Add(this._chkFilterWidthHeight);
            this._grpOptions.Controls.Add(this._lblFilterHeight);
            this._grpOptions.Controls.Add(this._lblFilterWidth);
            this._grpOptions.Controls.Add(this._nudMaxHeight);
            this._grpOptions.Controls.Add(this._nudMinHeight);
            this._grpOptions.Controls.Add(this._nudMaxWidth);
            this._grpOptions.Controls.Add(this._nudMinWidth);
            this._grpOptions.Controls.Add(this._btnActivate);
            this._grpOptions.Controls.Add(this._chkRandom);
            this._grpOptions.Controls.Add(this._chkForceKill);
            this._grpOptions.Controls.Add(this._chkIgnoreBadFiles);
            this._grpOptions.Controls.Add(this._lblArguments);
            this._grpOptions.Controls.Add(this._txtArguments);
            this._grpOptions.Controls.Add(this._lblFileGatherTimeout);
            this._grpOptions.Controls.Add(this._nudMaxFiles);
            this._grpOptions.Controls.Add(this._nudFileGatherTimeout);
            this._grpOptions.Controls.Add(this._chkMaximizeWindow);
            this._grpOptions.Controls.Add(this._chkShowStopWatch);
            this._grpOptions.Controls.Add(this._lblMaxFiles);
            this._grpOptions.Controls.Add(this._chkShiftFocus);
            this._grpOptions.Controls.Add(this._chkRepeat);
            this._grpOptions.Controls.Add(this._chkSearchFolders);
            this._grpOptions.Controls.Add(this._chkClosePrevious);
            this._grpOptions.Location = new System.Drawing.Point(12, 191);
            this._grpOptions.Name = "_grpOptions";
            this._grpOptions.Size = new System.Drawing.Size(321, 306);
            this._grpOptions.TabIndex = 6;
            this._grpOptions.TabStop = false;
            this._grpOptions.Text = "Options";
            // 
            // _btnUpdateSearch
            // 
            this._btnUpdateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnUpdateSearch.Location = new System.Drawing.Point(16, 206);
            this._btnUpdateSearch.Name = "_btnUpdateSearch";
            this._btnUpdateSearch.Size = new System.Drawing.Size(149, 36);
            this._btnUpdateSearch.TabIndex = 33;
            this._btnUpdateSearch.Text = "Update Search";
            this._btnUpdateSearch.UseVisualStyleBackColor = true;
            this._btnUpdateSearch.Click += new System.EventHandler(this._btnUpdateSearch_Click);
            // 
            // _chkFilterWidthHeight
            // 
            this._chkFilterWidthHeight.AutoSize = true;
            this._chkFilterWidthHeight.Location = new System.Drawing.Point(11, 138);
            this._chkFilterWidthHeight.Name = "_chkFilterWidthHeight";
            this._chkFilterWidthHeight.Size = new System.Drawing.Size(135, 17);
            this._chkFilterWidthHeight.TabIndex = 32;
            this._chkFilterWidthHeight.Text = "Filter by Width / Height";
            this._chkFilterWidthHeight.UseVisualStyleBackColor = true;
            this._chkFilterWidthHeight.CheckedChanged += new System.EventHandler(this._chkFilterWidthHeight_CheckedChanged);
            // 
            // _lblFilterHeight
            // 
            this._lblFilterHeight.AutoSize = true;
            this._lblFilterHeight.Enabled = false;
            this._lblFilterHeight.Location = new System.Drawing.Point(185, 158);
            this._lblFilterHeight.Name = "_lblFilterHeight";
            this._lblFilterHeight.Size = new System.Drawing.Size(38, 13);
            this._lblFilterHeight.TabIndex = 31;
            this._lblFilterHeight.Text = "Height";
            // 
            // _lblFilterWidth
            // 
            this._lblFilterWidth.AutoSize = true;
            this._lblFilterWidth.Enabled = false;
            this._lblFilterWidth.Location = new System.Drawing.Point(28, 158);
            this._lblFilterWidth.Name = "_lblFilterWidth";
            this._lblFilterWidth.Size = new System.Drawing.Size(35, 13);
            this._lblFilterWidth.TabIndex = 30;
            this._lblFilterWidth.Text = "Width";
            // 
            // _nudMaxHeight
            // 
            this._nudMaxHeight.Enabled = false;
            this._nudMaxHeight.Location = new System.Drawing.Point(254, 174);
            this._nudMaxHeight.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this._nudMaxHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudMaxHeight.Name = "_nudMaxHeight";
            this._nudMaxHeight.Size = new System.Drawing.Size(62, 20);
            this._nudMaxHeight.TabIndex = 29;
            this._nudMaxHeight.Value = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this._nudMaxHeight.ValueChanged += new System.EventHandler(this._nudMaxHeight_ValueChanged);
            // 
            // _nudMinHeight
            // 
            this._nudMinHeight.Enabled = false;
            this._nudMinHeight.Location = new System.Drawing.Point(186, 174);
            this._nudMinHeight.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this._nudMinHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudMinHeight.Name = "_nudMinHeight";
            this._nudMinHeight.Size = new System.Drawing.Size(62, 20);
            this._nudMinHeight.TabIndex = 28;
            this._nudMinHeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this._nudMinHeight.ValueChanged += new System.EventHandler(this._nudMinHeight_ValueChanged);
            // 
            // _nudMaxWidth
            // 
            this._nudMaxWidth.Enabled = false;
            this._nudMaxWidth.Location = new System.Drawing.Point(97, 174);
            this._nudMaxWidth.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this._nudMaxWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudMaxWidth.Name = "_nudMaxWidth";
            this._nudMaxWidth.Size = new System.Drawing.Size(62, 20);
            this._nudMaxWidth.TabIndex = 27;
            this._nudMaxWidth.Value = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this._nudMaxWidth.ValueChanged += new System.EventHandler(this._nudMaxWidth_ValueChanged);
            // 
            // _nudMinWidth
            // 
            this._nudMinWidth.Enabled = false;
            this._nudMinWidth.Location = new System.Drawing.Point(29, 174);
            this._nudMinWidth.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this._nudMinWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudMinWidth.Name = "_nudMinWidth";
            this._nudMinWidth.Size = new System.Drawing.Size(62, 20);
            this._nudMinWidth.TabIndex = 26;
            this._nudMinWidth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this._nudMinWidth.ValueChanged += new System.EventHandler(this._nudMinWidth_ValueChanged);
            // 
            // _btnActivate
            // 
            this._btnActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnActivate.ForeColor = System.Drawing.Color.Red;
            this._btnActivate.Location = new System.Drawing.Point(207, 210);
            this._btnActivate.Name = "_btnActivate";
            this._btnActivate.Size = new System.Drawing.Size(81, 26);
            this._btnActivate.TabIndex = 25;
            this._btnActivate.Text = "Activate";
            this._btnActivate.UseVisualStyleBackColor = true;
            this._btnActivate.Click += new System.EventHandler(this._btnActivate_Click);
            // 
            // _chkRandom
            // 
            this._chkRandom.AutoSize = true;
            this._chkRandom.Checked = true;
            this._chkRandom.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkRandom.Location = new System.Drawing.Point(219, 30);
            this._chkRandom.Name = "_chkRandom";
            this._chkRandom.Size = new System.Drawing.Size(66, 17);
            this._chkRandom.TabIndex = 25;
            this._chkRandom.Text = "Random";
            this._chkRandom.UseVisualStyleBackColor = true;
            this._chkRandom.CheckedChanged += new System.EventHandler(this._chkRandom_CheckedChanged);
            // 
            // _chkForceKill
            // 
            this._chkForceKill.AutoSize = true;
            this._chkForceKill.Location = new System.Drawing.Point(18, 52);
            this._chkForceKill.Name = "_chkForceKill";
            this._chkForceKill.Size = new System.Drawing.Size(69, 17);
            this._chkForceKill.TabIndex = 24;
            this._chkForceKill.Text = "Force Kill";
            this._chkForceKill.UseVisualStyleBackColor = true;
            this._chkForceKill.CheckedChanged += new System.EventHandler(this._chkForceKill_CheckedChanged);
            // 
            // _chkIgnoreBadFiles
            // 
            this._chkIgnoreBadFiles.AutoSize = true;
            this._chkIgnoreBadFiles.Checked = true;
            this._chkIgnoreBadFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkIgnoreBadFiles.Location = new System.Drawing.Point(114, 76);
            this._chkIgnoreBadFiles.Name = "_chkIgnoreBadFiles";
            this._chkIgnoreBadFiles.Size = new System.Drawing.Size(102, 17);
            this._chkIgnoreBadFiles.TabIndex = 23;
            this._chkIgnoreBadFiles.Text = "Ignore Bad Files";
            this._chkIgnoreBadFiles.UseVisualStyleBackColor = true;
            // 
            // _lblArguments
            // 
            this._lblArguments.AutoSize = true;
            this._lblArguments.Location = new System.Drawing.Point(13, 255);
            this._lblArguments.Name = "_lblArguments";
            this._lblArguments.Size = new System.Drawing.Size(111, 13);
            this._lblArguments.TabIndex = 22;
            this._lblArguments.Text = "Arguments / Switches";
            // 
            // _txtArguments
            // 
            this._txtArguments.Location = new System.Drawing.Point(11, 271);
            this._txtArguments.Name = "_txtArguments";
            this._txtArguments.Size = new System.Drawing.Size(302, 20);
            this._txtArguments.TabIndex = 21;
            this._txtArguments.Text = "/fs";
            this._txtArguments.TextChanged += new System.EventHandler(this._txtArguments_TextChanged);
            // 
            // _lblFileGatherTimeout
            // 
            this._lblFileGatherTimeout.AutoSize = true;
            this._lblFileGatherTimeout.Location = new System.Drawing.Point(141, 96);
            this._lblFileGatherTimeout.Name = "_lblFileGatherTimeout";
            this._lblFileGatherTimeout.Size = new System.Drawing.Size(121, 13);
            this._lblFileGatherTimeout.TabIndex = 20;
            this._lblFileGatherTimeout.Text = "File Gather Timeout (ms)";
            // 
            // _nudMaxFiles
            // 
            this._nudMaxFiles.Location = new System.Drawing.Point(13, 112);
            this._nudMaxFiles.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this._nudMaxFiles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudMaxFiles.Name = "_nudMaxFiles";
            this._nudMaxFiles.Size = new System.Drawing.Size(108, 20);
            this._nudMaxFiles.TabIndex = 19;
            this._nudMaxFiles.Value = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            // 
            // _nudFileGatherTimeout
            // 
            this._nudFileGatherTimeout.Location = new System.Drawing.Point(143, 112);
            this._nudFileGatherTimeout.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this._nudFileGatherTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudFileGatherTimeout.Name = "_nudFileGatherTimeout";
            this._nudFileGatherTimeout.Size = new System.Drawing.Size(68, 20);
            this._nudFileGatherTimeout.TabIndex = 19;
            this._nudFileGatherTimeout.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // _chkMaximizeWindow
            // 
            this._chkMaximizeWindow.AutoSize = true;
            this._chkMaximizeWindow.Location = new System.Drawing.Point(11, 76);
            this._chkMaximizeWindow.Name = "_chkMaximizeWindow";
            this._chkMaximizeWindow.Size = new System.Drawing.Size(94, 17);
            this._chkMaximizeWindow.TabIndex = 18;
            this._chkMaximizeWindow.Text = "Auto-Maximize";
            this._chkMaximizeWindow.UseVisualStyleBackColor = true;
            // 
            // _chkShowStopWatch
            // 
            this._chkShowStopWatch.AutoSize = true;
            this._chkShowStopWatch.Checked = true;
            this._chkShowStopWatch.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkShowStopWatch.Location = new System.Drawing.Point(114, 53);
            this._chkShowStopWatch.Name = "_chkShowStopWatch";
            this._chkShowStopWatch.Size = new System.Drawing.Size(107, 17);
            this._chkShowStopWatch.TabIndex = 17;
            this._chkShowStopWatch.Text = "Show Stopwatch";
            this._chkShowStopWatch.UseVisualStyleBackColor = true;
            this._chkShowStopWatch.CheckedChanged += new System.EventHandler(this._chkShowStopWatch_CheckedChanged);
            // 
            // _lblMaxFiles
            // 
            this._lblMaxFiles.AutoSize = true;
            this._lblMaxFiles.Location = new System.Drawing.Point(8, 96);
            this._lblMaxFiles.Name = "_lblMaxFiles";
            this._lblMaxFiles.Size = new System.Drawing.Size(51, 13);
            this._lblMaxFiles.TabIndex = 14;
            this._lblMaxFiles.Text = "Max Files";
            // 
            // _chkShiftFocus
            // 
            this._chkShiftFocus.AutoSize = true;
            this._chkShiftFocus.Location = new System.Drawing.Point(219, 76);
            this._chkShiftFocus.Name = "_chkShiftFocus";
            this._chkShiftFocus.Size = new System.Drawing.Size(79, 17);
            this._chkShiftFocus.TabIndex = 12;
            this._chkShiftFocus.Text = "Shift Focus";
            this._chkShiftFocus.UseVisualStyleBackColor = true;
            // 
            // _chkRepeat
            // 
            this._chkRepeat.AutoSize = true;
            this._chkRepeat.Location = new System.Drawing.Point(227, 52);
            this._chkRepeat.Name = "_chkRepeat";
            this._chkRepeat.Size = new System.Drawing.Size(61, 17);
            this._chkRepeat.TabIndex = 11;
            this._chkRepeat.Text = "Repeat";
            this._chkRepeat.UseVisualStyleBackColor = true;
            // 
            // _chkSearchFolders
            // 
            this._chkSearchFolders.AutoSize = true;
            this._chkSearchFolders.Checked = true;
            this._chkSearchFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkSearchFolders.Location = new System.Drawing.Point(114, 29);
            this._chkSearchFolders.Name = "_chkSearchFolders";
            this._chkSearchFolders.Size = new System.Drawing.Size(97, 17);
            this._chkSearchFolders.TabIndex = 10;
            this._chkSearchFolders.Text = "Search Folders";
            this._chkSearchFolders.UseVisualStyleBackColor = true;
            this._chkSearchFolders.CheckedChanged += new System.EventHandler(this._chkSearchFolders_CheckedChanged);
            // 
            // _btnArtDefaults
            // 
            this._btnArtDefaults.Location = new System.Drawing.Point(329, 75);
            this._btnArtDefaults.Name = "_btnArtDefaults";
            this._btnArtDefaults.Size = new System.Drawing.Size(11, 10);
            this._btnArtDefaults.TabIndex = 24;
            this._btnArtDefaults.UseVisualStyleBackColor = true;
            this._btnArtDefaults.Click += new System.EventHandler(this._btnArtDefaults_Click);
            // 
            // _btnPrev
            // 
            this._btnPrev.Location = new System.Drawing.Point(12, 75);
            this._btnPrev.Name = "_btnPrev";
            this._btnPrev.Size = new System.Drawing.Size(75, 22);
            this._btnPrev.TabIndex = 7;
            this._btnPrev.Text = "< Prev";
            this._btnPrev.UseVisualStyleBackColor = true;
            this._btnPrev.Click += new System.EventHandler(this._btnPrev_Click);
            // 
            // _lblFileCount
            // 
            this._lblFileCount.AutoSize = true;
            this._lblFileCount.Location = new System.Drawing.Point(15, 43);
            this._lblFileCount.Name = "_lblFileCount";
            this._lblFileCount.Size = new System.Drawing.Size(66, 13);
            this._lblFileCount.TabIndex = 8;
            this._lblFileCount.Text = "**file count**";
            // 
            // _lblFilesRemaining
            // 
            this._lblFilesRemaining.AutoSize = true;
            this._lblFilesRemaining.Location = new System.Drawing.Point(184, 43);
            this._lblFilesRemaining.Name = "_lblFilesRemaining";
            this._lblFilesRemaining.Size = new System.Drawing.Size(75, 13);
            this._lblFilesRemaining.TabIndex = 9;
            this._lblFilesRemaining.Text = "**files remain**";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._lblFilePath);
            this.groupBox2.Controls.Add(this._lblFileCount);
            this.groupBox2.Controls.Add(this._lblFilesRemaining);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 72);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stats";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // _lblFilePath
            // 
            this._lblFilePath.AutoSize = true;
            this._lblFilePath.Location = new System.Drawing.Point(18, 20);
            this._lblFilePath.Name = "_lblFilePath";
            this._lblFilePath.Size = new System.Drawing.Size(60, 13);
            this._lblFilePath.TabIndex = 10;
            this._lblFilePath.Text = "**file path**";
            this._lblFilePath.Click += new System.EventHandler(this._lblFilePath_Click);
            // 
            // _chkShowOptions
            // 
            this._chkShowOptions.Appearance = System.Windows.Forms.Appearance.Button;
            this._chkShowOptions.AutoSize = true;
            this._chkShowOptions.Location = new System.Drawing.Point(142, 75);
            this._chkShowOptions.Name = "_chkShowOptions";
            this._chkShowOptions.Size = new System.Drawing.Size(53, 23);
            this._chkShowOptions.TabIndex = 11;
            this._chkShowOptions.Text = "Options";
            this._chkShowOptions.UseVisualStyleBackColor = true;
            this._chkShowOptions.CheckedChanged += new System.EventHandler(this._chkShowOptions_CheckedChanged);
            // 
            // _btnSelectFolder
            // 
            this._btnSelectFolder.Location = new System.Drawing.Point(315, 45);
            this._btnSelectFolder.Name = "_btnSelectFolder";
            this._btnSelectFolder.Size = new System.Drawing.Size(25, 20);
            this._btnSelectFolder.TabIndex = 12;
            this._btnSelectFolder.Text = "...";
            this._btnSelectFolder.UseVisualStyleBackColor = true;
            this._btnSelectFolder.Click += new System.EventHandler(this._btnSelectFolder_Click_1);
            // 
            // _objStatusStrip
            // 
            this._objStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._lblStatusLabel});
            this._objStatusStrip.Location = new System.Drawing.Point(0, 714);
            this._objStatusStrip.Name = "_objStatusStrip";
            this._objStatusStrip.Size = new System.Drawing.Size(340, 22);
            this._objStatusStrip.TabIndex = 13;
            this._objStatusStrip.Text = "statusStrip1";
            // 
            // _lblStatusLabel
            // 
            this._lblStatusLabel.Name = "_lblStatusLabel";
            this._lblStatusLabel.Size = new System.Drawing.Size(58, 17);
            this._lblStatusLabel.Text = "**status**";
            // 
            // _btnStartWatch
            // 
            this._btnStartWatch.Location = new System.Drawing.Point(76, 114);
            this._btnStartWatch.Name = "_btnStartWatch";
            this._btnStartWatch.Size = new System.Drawing.Size(48, 23);
            this._btnStartWatch.TabIndex = 0;
            this._btnStartWatch.Text = "Start";
            this._btnStartWatch.UseVisualStyleBackColor = true;
            this._btnStartWatch.Click += new System.EventHandler(this._btnStartWatch_Click);
            // 
            // _btnResetWatch
            // 
            this._btnResetWatch.Location = new System.Drawing.Point(184, 114);
            this._btnResetWatch.Name = "_btnResetWatch";
            this._btnResetWatch.Size = new System.Drawing.Size(48, 23);
            this._btnResetWatch.TabIndex = 1;
            this._btnResetWatch.Text = "Reset";
            this._btnResetWatch.UseVisualStyleBackColor = true;
            this._btnResetWatch.Click += new System.EventHandler(this._btnResetWatch_Click);
            // 
            // _btnPauseWatch
            // 
            this._btnPauseWatch.Location = new System.Drawing.Point(130, 114);
            this._btnPauseWatch.Name = "_btnPauseWatch";
            this._btnPauseWatch.Size = new System.Drawing.Size(48, 23);
            this._btnPauseWatch.TabIndex = 2;
            this._btnPauseWatch.Text = "Pause";
            this._btnPauseWatch.UseVisualStyleBackColor = true;
            this._btnPauseWatch.Click += new System.EventHandler(this._btnPauseWatch_Click);
            // 
            // _grpStopWatch
            // 
            this._grpStopWatch.Controls.Add(this._chkResetWatchAtEnd);
            this._grpStopWatch.Controls.Add(this._chkWatchCycle);
            this._grpStopWatch.Controls.Add(this._lblStopWatchTime);
            this._grpStopWatch.Controls.Add(this._nudSeconds);
            this._grpStopWatch.Controls.Add(this._nudHours);
            this._grpStopWatch.Controls.Add(this._nudMinutes);
            this._grpStopWatch.Controls.Add(this.label4);
            this._grpStopWatch.Controls.Add(this.label5);
            this._grpStopWatch.Controls.Add(this.label1);
            this._grpStopWatch.Controls.Add(this._btnPauseWatch);
            this._grpStopWatch.Controls.Add(this._btnResetWatch);
            this._grpStopWatch.Controls.Add(this._btnStartWatch);
            this._grpStopWatch.Location = new System.Drawing.Point(12, 519);
            this._grpStopWatch.Name = "_grpStopWatch";
            this._grpStopWatch.Size = new System.Drawing.Size(319, 193);
            this._grpStopWatch.TabIndex = 14;
            this._grpStopWatch.TabStop = false;
            this._grpStopWatch.Text = "Stopwatch";
            // 
            // _chkResetWatchAtEnd
            // 
            this._chkResetWatchAtEnd.AutoSize = true;
            this._chkResetWatchAtEnd.Checked = true;
            this._chkResetWatchAtEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkResetWatchAtEnd.Location = new System.Drawing.Point(144, 152);
            this._chkResetWatchAtEnd.Name = "_chkResetWatchAtEnd";
            this._chkResetWatchAtEnd.Size = new System.Drawing.Size(171, 17);
            this._chkResetWatchAtEnd.TabIndex = 12;
            this._chkResetWatchAtEnd.Text = "Reset Timer When Timer Ends";
            this._chkResetWatchAtEnd.UseVisualStyleBackColor = true;
            // 
            // _chkWatchCycle
            // 
            this._chkWatchCycle.AutoSize = true;
            this._chkWatchCycle.Checked = true;
            this._chkWatchCycle.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkWatchCycle.Location = new System.Drawing.Point(6, 152);
            this._chkWatchCycle.Name = "_chkWatchCycle";
            this._chkWatchCycle.Size = new System.Drawing.Size(132, 17);
            this._chkWatchCycle.TabIndex = 11;
            this._chkWatchCycle.Text = "Cycle when timer ends";
            this._chkWatchCycle.UseVisualStyleBackColor = true;
            // 
            // _lblStopWatchTime
            // 
            this._lblStopWatchTime.AutoSize = true;
            this._lblStopWatchTime.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblStopWatchTime.Location = new System.Drawing.Point(37, 11);
            this._lblStopWatchTime.Name = "_lblStopWatchTime";
            this._lblStopWatchTime.Size = new System.Drawing.Size(125, 65);
            this._lblStopWatchTime.TabIndex = 10;
            this._lblStopWatchTime.Text = "0:00";
            // 
            // _nudSeconds
            // 
            this._nudSeconds.Location = new System.Drawing.Point(249, 79);
            this._nudSeconds.Name = "_nudSeconds";
            this._nudSeconds.Size = new System.Drawing.Size(36, 20);
            this._nudSeconds.TabIndex = 9;
            this._nudSeconds.ValueChanged += new System.EventHandler(this._nudSeconds_ValueChanged);
            // 
            // _nudHours
            // 
            this._nudHours.Location = new System.Drawing.Point(73, 79);
            this._nudHours.Name = "_nudHours";
            this._nudHours.Size = new System.Drawing.Size(36, 20);
            this._nudHours.TabIndex = 8;
            this._nudHours.ValueChanged += new System.EventHandler(this._nudHours_ValueChanged);
            // 
            // _nudMinutes
            // 
            this._nudMinutes.Location = new System.Drawing.Point(165, 79);
            this._nudMinutes.Name = "_nudMinutes";
            this._nudMinutes.Size = new System.Drawing.Size(36, 20);
            this._nudMinutes.TabIndex = 7;
            this._nudMinutes.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this._nudMinutes.ValueChanged += new System.EventHandler(this._nudMinutes_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seconds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Minutes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(340, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mnuFileFilter,
            this.manageFileTypesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // _mnuFileFilter
            // 
            this._mnuFileFilter.Enabled = false;
            this._mnuFileFilter.Name = "_mnuFileFilter";
            this._mnuFileFilter.Size = new System.Drawing.Size(171, 22);
            this._mnuFileFilter.Text = "File Filter";
            this._mnuFileFilter.Click += new System.EventHandler(this._mnuFileFilter_Click);
            // 
            // manageFileTypesToolStripMenuItem
            // 
            this.manageFileTypesToolStripMenuItem.Name = "manageFileTypesToolStripMenuItem";
            this.manageFileTypesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.manageFileTypesToolStripMenuItem.Text = "Manage File Types";
            this.manageFileTypesToolStripMenuItem.Click += new System.EventHandler(this.manageFileTypesToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "v0.8";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 736);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._btnArtDefaults);
            this.Controls.Add(this._grpStopWatch);
            this.Controls.Add(this._objStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this._btnSelectFolder);
            this.Controls.Add(this._chkShowOptions);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this._btnPrev);
            this.Controls.Add(this._grpOptions);
            this.Controls.Add(this._lblSearchInFolder);
            this.Controls.Add(this._txtPath);
            this.Controls.Add(this._btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Rifle Automation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this._grpOptions.ResumeLayout(false);
            this._grpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudMaxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudMinHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudMaxWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudMinWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudMaxFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudFileGatherTimeout)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this._objStatusStrip.ResumeLayout(false);
            this._objStatusStrip.PerformLayout();
            this._grpStopWatch.ResumeLayout(false);
            this._grpStopWatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudMinutes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnNext;
        private System.Windows.Forms.TextBox _txtPath;
        private System.Windows.Forms.Label _lblSearchInFolder;
        private System.Windows.Forms.CheckBox _chkClosePrevious;
        private System.Windows.Forms.GroupBox _grpOptions;
      //  private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
      //  private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button _btnPrev;
        private System.Windows.Forms.Label _lblFileCount;
        private System.Windows.Forms.CheckBox _chkSearchFolders;
        private System.Windows.Forms.CheckBox _chkRepeat;
        private System.Windows.Forms.Label _lblFilesRemaining;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox _chkShiftFocus;
        private System.Windows.Forms.Label _lblFilePath;
        private System.Windows.Forms.CheckBox _chkShowOptions;
        private System.Windows.Forms.Button _btnSelectFolder;
        private System.Windows.Forms.StatusStrip _objStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel _lblStatusLabel;
        private System.Windows.Forms.Label _lblMaxFiles;
        private System.Windows.Forms.CheckBox _chkShowStopWatch;
        private System.Windows.Forms.Button _btnStartWatch;
        private System.Windows.Forms.Button _btnResetWatch;
        private System.Windows.Forms.Button _btnPauseWatch;
        private System.Windows.Forms.GroupBox _grpStopWatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown _nudSeconds;
        private System.Windows.Forms.NumericUpDown _nudHours;
        private System.Windows.Forms.NumericUpDown _nudMinutes;
        private System.Windows.Forms.Label _lblStopWatchTime;
        private System.Windows.Forms.CheckBox _chkWatchCycle;
        private System.Windows.Forms.CheckBox _chkResetWatchAtEnd;
        private System.Windows.Forms.CheckBox _chkMaximizeWindow;
        private System.Windows.Forms.Label _lblFileGatherTimeout;
        private System.Windows.Forms.NumericUpDown _nudFileGatherTimeout;
      //  private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label _lblArguments;
        private System.Windows.Forms.TextBox _txtArguments;
      //  private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.CheckBox _chkIgnoreBadFiles;
        private System.Windows.Forms.Button _btnArtDefaults;
        private System.Windows.Forms.CheckBox _chkForceKill;
        private System.Windows.Forms.CheckBox _chkRandom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _mnuFileFilter;
        private System.Windows.Forms.Button _btnActivate;
        private System.Windows.Forms.ToolStripMenuItem manageFileTypesToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown _nudMaxFiles;
        private System.Windows.Forms.CheckBox _chkFilterWidthHeight;
        private System.Windows.Forms.Label _lblFilterHeight;
        private System.Windows.Forms.Label _lblFilterWidth;
        private System.Windows.Forms.NumericUpDown _nudMaxHeight;
        private System.Windows.Forms.NumericUpDown _nudMinHeight;
        private System.Windows.Forms.NumericUpDown _nudMaxWidth;
        private System.Windows.Forms.NumericUpDown _nudMinWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnUpdateSearch;
    }
}

