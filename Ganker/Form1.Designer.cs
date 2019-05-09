namespace WebLoader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this._txtBaseUrl = new System.Windows.Forms.TextBox();
            this._btnStart = new System.Windows.Forms.Button();
            this._txtOutputPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtTestFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._btnTestDownload = new System.Windows.Forms.Button();
            this._txtOutput = new System.Windows.Forms.TextBox();
            this._nudMaxFilelen = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this._nudHitDelay = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this._nudHitDelayRandom = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this._nudMaxDiskSpace = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this._pgbMaxDiskSpace = new System.Windows.Forms.ProgressBar();
            this._chk8Ch = new System.Windows.Forms.CheckBox();
            this._chkWebm = new System.Windows.Forms.CheckBox();
            this._chkMp4 = new System.Windows.Forms.CheckBox();
            this._chkGif = new System.Windows.Forms.CheckBox();
            this._chkJpg = new System.Windows.Forms.CheckBox();
            this._chkPng = new System.Windows.Forms.CheckBox();
            this._gbFileTypes = new System.Windows.Forms.GroupBox();
            this._gbSettings = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this._nudMaxDownloads = new System.Windows.Forms.NumericUpDown();
            this._gbFunction = new System.Windows.Forms.GroupBox();
            this._btnKillAll = new System.Windows.Forms.Button();
            this._lsbDownloads = new System.Windows.Forms.ListBox();
            this._lblCurrent = new System.Windows.Forms.Label();
            this._lsbPendingDownloads = new System.Windows.Forms.ListBox();
            this._lblPending = new System.Windows.Forms.Label();
            this._gbDownloads = new System.Windows.Forms.GroupBox();
            this._btnKillAllPending = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._btnShowOutput = new System.Windows.Forms.Button();
            this._chkVerbose = new System.Windows.Forms.CheckBox();
            this._lsbCompletedDownloads = new System.Windows.Forms.ListBox();
            this._btnClearCompleted = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this._btnShowOptions = new System.Windows.Forms.Button();
            this._chkRenderHtml = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._nudMaxFilelen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudHitDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudHitDelayRandom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudMaxDiskSpace)).BeginInit();
            this._gbFileTypes.SuspendLayout();
            this._gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudMaxDownloads)).BeginInit();
            this._gbFunction.SuspendLayout();
            this._gbDownloads.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL to search...";
            // 
            // _txtBaseUrl
            // 
            this._txtBaseUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtBaseUrl.Location = new System.Drawing.Point(15, 53);
            this._txtBaseUrl.Name = "_txtBaseUrl";
            this._txtBaseUrl.Size = new System.Drawing.Size(544, 20);
            this._txtBaseUrl.TabIndex = 1;
            this._txtBaseUrl.Text = "https://www.google.com/search?q=potato&site=imghp&source=lnms&tbm=isch&sa=X";
            this._txtBaseUrl.TextChanged += new System.EventHandler(this._txtBaseUrl_TextChanged);
            // 
            // _btnStart
            // 
            this._btnStart.BackColor = System.Drawing.Color.Lime;
            this._btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnStart.Location = new System.Drawing.Point(135, 135);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(291, 63);
            this._btnStart.TabIndex = 3;
            this._btnStart.Text = "Start";
            this._btnStart.UseVisualStyleBackColor = false;
            this._btnStart.Click += new System.EventHandler(this._btnStart_Click);
            // 
            // _txtOutputPath
            // 
            this._txtOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtOutputPath.Location = new System.Drawing.Point(15, 100);
            this._txtOutputPath.Name = "_txtOutputPath";
            this._txtOutputPath.Size = new System.Drawing.Size(544, 20);
            this._txtOutputPath.TabIndex = 2;
            this._txtOutputPath.Text = "C:\\WEBL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dump Files Here:";
            // 
            // _txtTestFile
            // 
            this._txtTestFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._txtTestFile.Location = new System.Drawing.Point(371, 524);
            this._txtTestFile.Name = "_txtTestFile";
            this._txtTestFile.Size = new System.Drawing.Size(104, 20);
            this._txtTestFile.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quick Download";
            // 
            // _btnTestDownload
            // 
            this._btnTestDownload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._btnTestDownload.Location = new System.Drawing.Point(478, 524);
            this._btnTestDownload.Name = "_btnTestDownload";
            this._btnTestDownload.Size = new System.Drawing.Size(75, 21);
            this._btnTestDownload.TabIndex = 7;
            this._btnTestDownload.Text = "Download";
            this._btnTestDownload.UseVisualStyleBackColor = true;
            this._btnTestDownload.Click += new System.EventHandler(this._btnTestDownload_Click);
            // 
            // _txtOutput
            // 
            this._txtOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._txtOutput.Location = new System.Drawing.Point(0, 551);
            this._txtOutput.Multiline = true;
            this._txtOutput.Name = "_txtOutput";
            this._txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtOutput.Size = new System.Drawing.Size(571, 118);
            this._txtOutput.TabIndex = 8;
            // 
            // _nudMaxFilelen
            // 
            this._nudMaxFilelen.Location = new System.Drawing.Point(13, 41);
            this._nudMaxFilelen.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._nudMaxFilelen.Name = "_nudMaxFilelen";
            this._nudMaxFilelen.Size = new System.Drawing.Size(103, 20);
            this._nudMaxFilelen.TabIndex = 19;
            this._nudMaxFilelen.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max downloadable file size (MB)";
            // 
            // _nudHitDelay
            // 
            this._nudHitDelay.Location = new System.Drawing.Point(196, 41);
            this._nudHitDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this._nudHitDelay.Name = "_nudHitDelay";
            this._nudHitDelay.Size = new System.Drawing.Size(88, 20);
            this._nudHitDelay.TabIndex = 20;
            this._nudHitDelay.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Link hit delay - (ms)";
            // 
            // _nudHitDelayRandom
            // 
            this._nudHitDelayRandom.Location = new System.Drawing.Point(196, 92);
            this._nudHitDelayRandom.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this._nudHitDelayRandom.Name = "_nudHitDelayRandom";
            this._nudHitDelayRandom.Size = new System.Drawing.Size(88, 20);
            this._nudHitDelayRandom.TabIndex = 22;
            this._nudHitDelayRandom.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Link hit Random delay (ms)";
            // 
            // _nudMaxDiskSpace
            // 
            this._nudMaxDiskSpace.Location = new System.Drawing.Point(13, 95);
            this._nudMaxDiskSpace.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this._nudMaxDiskSpace.Name = "_nudMaxDiskSpace";
            this._nudMaxDiskSpace.Size = new System.Drawing.Size(107, 20);
            this._nudMaxDiskSpace.TabIndex = 21;
            this._nudMaxDiskSpace.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Max Disk Space (MB)";
            // 
            // _pgbMaxDiskSpace
            // 
            this._pgbMaxDiskSpace.Location = new System.Drawing.Point(13, 121);
            this._pgbMaxDiskSpace.Name = "_pgbMaxDiskSpace";
            this._pgbMaxDiskSpace.Size = new System.Drawing.Size(107, 10);
            this._pgbMaxDiskSpace.Step = 1;
            this._pgbMaxDiskSpace.TabIndex = 13;
            // 
            // _chk8Ch
            // 
            this._chk8Ch.AutoSize = true;
            this._chk8Ch.Location = new System.Drawing.Point(6, 19);
            this._chk8Ch.Name = "_chk8Ch";
            this._chk8Ch.Size = new System.Drawing.Size(85, 17);
            this._chk8Ch.TabIndex = 18;
            this._chk8Ch.Text = "Robot Mode";
            this._chk8Ch.UseVisualStyleBackColor = true;
            // 
            // _chkWebm
            // 
            this._chkWebm.AutoSize = true;
            this._chkWebm.Checked = true;
            this._chkWebm.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkWebm.Location = new System.Drawing.Point(10, 19);
            this._chkWebm.Name = "_chkWebm";
            this._chkWebm.Size = new System.Drawing.Size(58, 17);
            this._chkWebm.TabIndex = 13;
            this._chkWebm.Text = "webm";
            this._chkWebm.UseVisualStyleBackColor = true;
            this._chkWebm.CheckedChanged += new System.EventHandler(this._chkWebm_CheckedChanged);
            // 
            // _chkMp4
            // 
            this._chkMp4.AutoSize = true;
            this._chkMp4.Checked = true;
            this._chkMp4.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkMp4.Location = new System.Drawing.Point(71, 19);
            this._chkMp4.Name = "_chkMp4";
            this._chkMp4.Size = new System.Drawing.Size(49, 17);
            this._chkMp4.TabIndex = 14;
            this._chkMp4.Text = "mp4";
            this._chkMp4.UseVisualStyleBackColor = true;
            this._chkMp4.CheckedChanged += new System.EventHandler(this._chkMp4_CheckedChanged);
            // 
            // _chkGif
            // 
            this._chkGif.AutoSize = true;
            this._chkGif.Location = new System.Drawing.Point(120, 19);
            this._chkGif.Name = "_chkGif";
            this._chkGif.Size = new System.Drawing.Size(40, 17);
            this._chkGif.TabIndex = 15;
            this._chkGif.Text = "gif";
            this._chkGif.UseVisualStyleBackColor = true;
            // 
            // _chkJpg
            // 
            this._chkJpg.AutoSize = true;
            this._chkJpg.Location = new System.Drawing.Point(10, 42);
            this._chkJpg.Name = "_chkJpg";
            this._chkJpg.Size = new System.Drawing.Size(73, 17);
            this._chkJpg.TabIndex = 16;
            this._chkJpg.Text = "jpg/jpeg";
            this._chkJpg.UseVisualStyleBackColor = true;
            // 
            // _chkPng
            // 
            this._chkPng.AutoSize = true;
            this._chkPng.Location = new System.Drawing.Point(120, 42);
            this._chkPng.Name = "_chkPng";
            this._chkPng.Size = new System.Drawing.Size(47, 17);
            this._chkPng.TabIndex = 17;
            this._chkPng.Text = "png";
            this._chkPng.UseVisualStyleBackColor = true;
            // 
            // _gbFileTypes
            // 
            this._gbFileTypes.Controls.Add(this._chkWebm);
            this._gbFileTypes.Controls.Add(this._chkMp4);
            this._gbFileTypes.Controls.Add(this._chkPng);
            this._gbFileTypes.Controls.Add(this._chkGif);
            this._gbFileTypes.Controls.Add(this._chkJpg);
            this._gbFileTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._gbFileTypes.Location = new System.Drawing.Point(15, 231);
            this._gbFileTypes.Name = "_gbFileTypes";
            this._gbFileTypes.Size = new System.Drawing.Size(174, 86);
            this._gbFileTypes.TabIndex = 5;
            this._gbFileTypes.TabStop = false;
            this._gbFileTypes.Tag = "";
            this._gbFileTypes.Text = "File Types";
            // 
            // _gbSettings
            // 
            this._gbSettings.Controls.Add(this.label8);
            this._gbSettings.Controls.Add(this._nudMaxDownloads);
            this._gbSettings.Controls.Add(this.label5);
            this._gbSettings.Controls.Add(this._nudHitDelay);
            this._gbSettings.Controls.Add(this._nudHitDelayRandom);
            this._gbSettings.Controls.Add(this.label4);
            this._gbSettings.Controls.Add(this._nudMaxFilelen);
            this._gbSettings.Controls.Add(this._pgbMaxDiskSpace);
            this._gbSettings.Controls.Add(this.label6);
            this._gbSettings.Controls.Add(this.label7);
            this._gbSettings.Controls.Add(this._nudMaxDiskSpace);
            this._gbSettings.Location = new System.Drawing.Point(15, 323);
            this._gbSettings.Name = "_gbSettings";
            this._gbSettings.Size = new System.Drawing.Size(332, 196);
            this._gbSettings.TabIndex = 8;
            this._gbSettings.TabStop = false;
            this._gbSettings.Text = "Settings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Max Concurrent Downloads";
            // 
            // _nudMaxDownloads
            // 
            this._nudMaxDownloads.Location = new System.Drawing.Point(196, 137);
            this._nudMaxDownloads.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._nudMaxDownloads.Name = "_nudMaxDownloads";
            this._nudMaxDownloads.Size = new System.Drawing.Size(63, 20);
            this._nudMaxDownloads.TabIndex = 23;
            this._nudMaxDownloads.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // _gbFunction
            // 
            this._gbFunction.Controls.Add(this._chkRenderHtml);
            this._gbFunction.Controls.Add(this._chk8Ch);
            this._gbFunction.Location = new System.Drawing.Point(195, 231);
            this._gbFunction.Name = "_gbFunction";
            this._gbFunction.Size = new System.Drawing.Size(152, 86);
            this._gbFunction.TabIndex = 6;
            this._gbFunction.TabStop = false;
            this._gbFunction.Text = "Function";
            // 
            // _btnKillAll
            // 
            this._btnKillAll.BackColor = System.Drawing.Color.Red;
            this._btnKillAll.Location = new System.Drawing.Point(6, 168);
            this._btnKillAll.Name = "_btnKillAll";
            this._btnKillAll.Size = new System.Drawing.Size(103, 22);
            this._btnKillAll.TabIndex = 10;
            this._btnKillAll.Text = "Kill All";
            this._btnKillAll.UseVisualStyleBackColor = false;
            this._btnKillAll.Click += new System.EventHandler(this._btnKillAll_Click);
            // 
            // _lsbDownloads
            // 
            this._lsbDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lsbDownloads.FormattingEnabled = true;
            this._lsbDownloads.Location = new System.Drawing.Point(7, 119);
            this._lsbDownloads.Name = "_lsbDownloads";
            this._lsbDownloads.Size = new System.Drawing.Size(175, 43);
            this._lsbDownloads.TabIndex = 20;
            this._lsbDownloads.SelectedIndexChanged += new System.EventHandler(this._lsbDownloads_SelectedIndexChanged);
            // 
            // _lblCurrent
            // 
            this._lblCurrent.AutoSize = true;
            this._lblCurrent.Location = new System.Drawing.Point(6, 103);
            this._lblCurrent.Name = "_lblCurrent";
            this._lblCurrent.Size = new System.Drawing.Size(41, 13);
            this._lblCurrent.TabIndex = 21;
            this._lblCurrent.Text = "Current";
            this._lblCurrent.Click += new System.EventHandler(this.label9_Click);
            // 
            // _lsbPendingDownloads
            // 
            this._lsbPendingDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lsbPendingDownloads.FormattingEnabled = true;
            this._lsbPendingDownloads.Location = new System.Drawing.Point(6, 32);
            this._lsbPendingDownloads.Name = "_lsbPendingDownloads";
            this._lsbPendingDownloads.Size = new System.Drawing.Size(175, 43);
            this._lsbPendingDownloads.TabIndex = 20;
            this._lsbPendingDownloads.SelectedIndexChanged += new System.EventHandler(this._lsbPendingDownloads_SelectedIndexChanged);
            // 
            // _lblPending
            // 
            this._lblPending.AutoSize = true;
            this._lblPending.Location = new System.Drawing.Point(6, 16);
            this._lblPending.Name = "_lblPending";
            this._lblPending.Size = new System.Drawing.Size(49, 13);
            this._lblPending.TabIndex = 21;
            this._lblPending.Text = "Pending ";
            this._lblPending.Click += new System.EventHandler(this.label10_Click);
            // 
            // _gbDownloads
            // 
            this._gbDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gbDownloads.Controls.Add(this._btnKillAllPending);
            this._gbDownloads.Controls.Add(this._btnClearCompleted);
            this._gbDownloads.Controls.Add(this._btnKillAll);
            this._gbDownloads.Controls.Add(this._lblPending);
            this._gbDownloads.Controls.Add(this._lsbPendingDownloads);
            this._gbDownloads.Controls.Add(this._lsbCompletedDownloads);
            this._gbDownloads.Controls.Add(this._lsbDownloads);
            this._gbDownloads.Controls.Add(this.label9);
            this._gbDownloads.Controls.Add(this._lblCurrent);
            this._gbDownloads.Location = new System.Drawing.Point(369, 231);
            this._gbDownloads.Name = "_gbDownloads";
            this._gbDownloads.Size = new System.Drawing.Size(190, 288);
            this._gbDownloads.TabIndex = 7;
            this._gbDownloads.TabStop = false;
            this._gbDownloads.Text = "Downloads";
            // 
            // _btnKillAllPending
            // 
            this._btnKillAllPending.BackColor = System.Drawing.Color.Red;
            this._btnKillAllPending.Location = new System.Drawing.Point(7, 78);
            this._btnKillAllPending.Name = "_btnKillAllPending";
            this._btnKillAllPending.Size = new System.Drawing.Size(103, 22);
            this._btnKillAllPending.TabIndex = 9;
            this._btnKillAllPending.Text = "Kill All";
            this._btnKillAllPending.UseVisualStyleBackColor = false;
            this._btnKillAllPending.Click += new System.EventHandler(this._btnKillAllPending_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.exitToolStripMenuItem.Text = "Menu";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // _btnShowOutput
            // 
            this._btnShowOutput.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._btnShowOutput.Location = new System.Drawing.Point(0, 526);
            this._btnShowOutput.Name = "_btnShowOutput";
            this._btnShowOutput.Size = new System.Drawing.Size(75, 23);
            this._btnShowOutput.TabIndex = 12;
            this._btnShowOutput.Text = "Output";
            this._btnShowOutput.UseVisualStyleBackColor = true;
            this._btnShowOutput.Click += new System.EventHandler(this._btnShowOutput_Click);
            // 
            // _chkVerbose
            // 
            this._chkVerbose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._chkVerbose.AutoSize = true;
            this._chkVerbose.Location = new System.Drawing.Point(81, 532);
            this._chkVerbose.Name = "_chkVerbose";
            this._chkVerbose.Size = new System.Drawing.Size(65, 17);
            this._chkVerbose.TabIndex = 26;
            this._chkVerbose.Text = "Verbose";
            this._chkVerbose.UseVisualStyleBackColor = true;
            // 
            // _lsbCompletedDownloads
            // 
            this._lsbCompletedDownloads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lsbCompletedDownloads.FormattingEnabled = true;
            this._lsbCompletedDownloads.Location = new System.Drawing.Point(7, 213);
            this._lsbCompletedDownloads.Name = "_lsbCompletedDownloads";
            this._lsbCompletedDownloads.Size = new System.Drawing.Size(175, 43);
            this._lsbCompletedDownloads.TabIndex = 20;
            this._lsbCompletedDownloads.SelectedIndexChanged += new System.EventHandler(this._lsbDownloads_SelectedIndexChanged);
            // 
            // _btnClearCompleted
            // 
            this._btnClearCompleted.BackColor = System.Drawing.Color.Gray;
            this._btnClearCompleted.Location = new System.Drawing.Point(7, 260);
            this._btnClearCompleted.Name = "_btnClearCompleted";
            this._btnClearCompleted.Size = new System.Drawing.Size(103, 22);
            this._btnClearCompleted.TabIndex = 11;
            this._btnClearCompleted.Text = "Clear";
            this._btnClearCompleted.UseVisualStyleBackColor = false;
            this._btnClearCompleted.Click += new System.EventHandler(this._btnClearCompleted_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Complete";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // _btnShowOptions
            // 
            this._btnShowOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._btnShowOptions.Location = new System.Drawing.Point(452, 170);
            this._btnShowOptions.Name = "_btnShowOptions";
            this._btnShowOptions.Size = new System.Drawing.Size(88, 28);
            this._btnShowOptions.TabIndex = 4;
            this._btnShowOptions.Text = "Show Options";
            this._btnShowOptions.UseVisualStyleBackColor = false;
            this._btnShowOptions.Click += new System.EventHandler(this._btnShowOptions_Click);
            // 
            // _chkRenderHtml
            // 
            this._chkRenderHtml.AutoSize = true;
            this._chkRenderHtml.Enabled = false;
            this._chkRenderHtml.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._chkRenderHtml.Location = new System.Drawing.Point(6, 42);
            this._chkRenderHtml.Name = "_chkRenderHtml";
            this._chkRenderHtml.Size = new System.Drawing.Size(94, 17);
            this._chkRenderHtml.TabIndex = 18;
            this._chkRenderHtml.Text = "Render HTML";
            this._chkRenderHtml.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 669);
            this.Controls.Add(this._btnShowOptions);
            this.Controls.Add(this._chkVerbose);
            this.Controls.Add(this._btnShowOutput);
            this.Controls.Add(this._gbDownloads);
            this.Controls.Add(this._gbFunction);
            this.Controls.Add(this._gbSettings);
            this.Controls.Add(this._gbFileTypes);
            this.Controls.Add(this._txtOutput);
            this.Controls.Add(this._btnTestDownload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtTestFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtOutputPath);
            this.Controls.Add(this._btnStart);
            this.Controls.Add(this._txtBaseUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ganker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._nudMaxFilelen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudHitDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudHitDelayRandom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudMaxDiskSpace)).EndInit();
            this._gbFileTypes.ResumeLayout(false);
            this._gbFileTypes.PerformLayout();
            this._gbSettings.ResumeLayout(false);
            this._gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudMaxDownloads)).EndInit();
            this._gbFunction.ResumeLayout(false);
            this._gbFunction.PerformLayout();
            this._gbDownloads.ResumeLayout(false);
            this._gbDownloads.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtBaseUrl;
        private System.Windows.Forms.Button _btnStart;
        private System.Windows.Forms.TextBox _txtOutputPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtTestFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _btnTestDownload;
        private System.Windows.Forms.TextBox _txtOutput;
        private System.Windows.Forms.NumericUpDown _nudMaxFilelen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown _nudHitDelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown _nudHitDelayRandom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown _nudMaxDiskSpace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar _pgbMaxDiskSpace;
        private System.Windows.Forms.CheckBox _chk8Ch;
        private System.Windows.Forms.CheckBox _chkWebm;
        private System.Windows.Forms.CheckBox _chkMp4;
        private System.Windows.Forms.CheckBox _chkGif;
        private System.Windows.Forms.CheckBox _chkJpg;
        private System.Windows.Forms.CheckBox _chkPng;
        private System.Windows.Forms.GroupBox _gbFileTypes;
        private System.Windows.Forms.GroupBox _gbSettings;
        private System.Windows.Forms.GroupBox _gbFunction;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown _nudMaxDownloads;
        private System.Windows.Forms.Button _btnKillAll;
        private System.Windows.Forms.ListBox _lsbDownloads;
        private System.Windows.Forms.Label _lblCurrent;
        private System.Windows.Forms.ListBox _lsbPendingDownloads;
        private System.Windows.Forms.Label _lblPending;
        private System.Windows.Forms.GroupBox _gbDownloads;
        private System.Windows.Forms.Button _btnKillAllPending;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button _btnShowOutput;
        private System.Windows.Forms.CheckBox _chkVerbose;
        private System.Windows.Forms.Button _btnClearCompleted;
        private System.Windows.Forms.ListBox _lsbCompletedDownloads;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button _btnShowOptions;
        private System.Windows.Forms.CheckBox _chkRenderHtml;
    }
}

