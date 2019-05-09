namespace DirPoll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._btnClear = new MetroFramework.Controls.MetroButton();
            this._btnPrintTree = new MetroFramework.Controls.MetroButton();
            this._mnuOpenDir = new MetroFramework.Controls.MetroButton();
            this._txtOutput = new System.Windows.Forms.RichTextBox();
            this._btnOpen = new MetroFramework.Controls.MetroButton();
            this._btnStart = new MetroFramework.Controls.MetroButton();
            this._btnSave = new MetroFramework.Controls.MetroButton();
            this._btnAbout = new MetroFramework.Controls.MetroButton();
            this._btnSettings = new MetroFramework.Controls.MetroButton();
            this._btnStats = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // _btnClear
            // 
            this._btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnClear.Location = new System.Drawing.Point(567, 422);
            this._btnClear.Name = "_btnClear";
            this._btnClear.Size = new System.Drawing.Size(75, 23);
            this._btnClear.TabIndex = 1;
            this._btnClear.Text = "Clear";
            this._btnClear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnClear.UseSelectable = true;
            this._btnClear.Click += new System.EventHandler(this._btnClear_Click);
            // 
            // _btnPrintTree
            // 
            this._btnPrintTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnPrintTree.Location = new System.Drawing.Point(648, 422);
            this._btnPrintTree.Name = "_btnPrintTree";
            this._btnPrintTree.Size = new System.Drawing.Size(75, 23);
            this._btnPrintTree.TabIndex = 1;
            this._btnPrintTree.Text = "Print Tree";
            this._btnPrintTree.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnPrintTree.UseSelectable = true;
            this._btnPrintTree.Click += new System.EventHandler(this._btnPrintTree_Click);
            // 
            // _mnuOpenDir
            // 
            this._mnuOpenDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._mnuOpenDir.Location = new System.Drawing.Point(23, 422);
            this._mnuOpenDir.Name = "_mnuOpenDir";
            this._mnuOpenDir.Size = new System.Drawing.Size(114, 23);
            this._mnuOpenDir.TabIndex = 1;
            this._mnuOpenDir.Text = "Containing Folder";
            this._mnuOpenDir.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._mnuOpenDir.UseSelectable = true;
            this._mnuOpenDir.Click += new System.EventHandler(this._mnuOpenDir_Click);
            // 
            // _txtOutput
            // 
            this._txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this._txtOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this._txtOutput.Location = new System.Drawing.Point(23, 56);
            this._txtOutput.Name = "_txtOutput";
            this._txtOutput.Size = new System.Drawing.Size(700, 360);
            this._txtOutput.TabIndex = 45;
            this._txtOutput.Text = "Welcome To Dirscan\n";
            // 
            // _btnOpen
            // 
            this._btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this._btnOpen.BackgroundImage = global::DirPoll.Properties.Resources.appbar_folder_open;
            this._btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnOpen.Location = new System.Drawing.Point(222, 20);
            this._btnOpen.Name = "_btnOpen";
            this._btnOpen.Size = new System.Drawing.Size(30, 30);
            this._btnOpen.TabIndex = 46;
            this._btnOpen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnOpen.UseSelectable = true;
            this._btnOpen.Click += new System.EventHandler(this._btnOpen_Click);
            // 
            // _btnStart
            // 
            this._btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this._btnStart.BackgroundImage = global::DirPoll.Properties.Resources.appbar_control_play;
            this._btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnStart.Location = new System.Drawing.Point(130, 20);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(30, 30);
            this._btnStart.TabIndex = 46;
            this._btnStart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnStart.UseSelectable = true;
            this._btnStart.Click += new System.EventHandler(this._btnStart_Click);
            // 
            // _btnSave
            // 
            this._btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this._btnSave.BackgroundImage = global::DirPoll.Properties.Resources.appbar_save;
            this._btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnSave.Location = new System.Drawing.Point(176, 20);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(30, 30);
            this._btnSave.TabIndex = 46;
            this._btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnSave.UseSelectable = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnAbout
            // 
            this._btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this._btnAbout.BackgroundImage = global::DirPoll.Properties.Resources.appbar_question;
            this._btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnAbout.Location = new System.Drawing.Point(447, 20);
            this._btnAbout.Name = "_btnAbout";
            this._btnAbout.Size = new System.Drawing.Size(30, 30);
            this._btnAbout.TabIndex = 46;
            this._btnAbout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnAbout.UseSelectable = true;
            this._btnAbout.Click += new System.EventHandler(this._btnAbout_Click);
            // 
            // _btnSettings
            // 
            this._btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this._btnSettings.BackgroundImage = global::DirPoll.Properties.Resources.appbar_settings;
            this._btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnSettings.Location = new System.Drawing.Point(401, 20);
            this._btnSettings.Name = "_btnSettings";
            this._btnSettings.Size = new System.Drawing.Size(30, 30);
            this._btnSettings.TabIndex = 46;
            this._btnSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnSettings.UseSelectable = true;
            this._btnSettings.Click += new System.EventHandler(this._btnSettings_Click);
            // 
            // _btnStats
            // 
            this._btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this._btnStats.BackgroundImage = global::DirPoll.Properties.Resources.appbar_text_align_justify;
            this._btnStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnStats.Location = new System.Drawing.Point(268, 20);
            this._btnStats.Name = "_btnStats";
            this._btnStats.Size = new System.Drawing.Size(30, 30);
            this._btnStats.TabIndex = 46;
            this._btnStats.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnStats.UseSelectable = true;
            this._btnStats.Click += new System.EventHandler(this._btnStats_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(746, 468);
            this.Controls.Add(this._btnStats);
            this.Controls.Add(this._btnSettings);
            this.Controls.Add(this._btnAbout);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnStart);
            this.Controls.Add(this._btnOpen);
            this.Controls.Add(this._txtOutput);
            this.Controls.Add(this._btnPrintTree);
            this.Controls.Add(this._mnuOpenDir);
            this.Controls.Add(this._btnClear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Dir//Scan";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }
        private MetroFramework.Controls.MetroButton _btnClear;
        private MetroFramework.Controls.MetroButton _btnPrintTree;
        private MetroFramework.Controls.MetroButton _mnuOpenDir;
        private System.Windows.Forms.RichTextBox _txtOutput;
        private MetroFramework.Controls.MetroButton _btnOpen;
        private MetroFramework.Controls.MetroButton _btnStart;
        private MetroFramework.Controls.MetroButton _btnSave;
        private MetroFramework.Controls.MetroButton _btnAbout;
        private MetroFramework.Controls.MetroButton _btnSettings;
        private MetroFramework.Controls.MetroButton _btnStats;

        #endregion
        //private MetroFramework.Controls.MetroTile _btnAbout;
        //private MetroFramework.Controls.MetroTile _btnExit;
        //private MetroFramework.Controls.MetroTile _btnStart;
        //private MetroFramework.Controls.MetroTile _btnSettings;
        //private MetroFramework.Controls.MetroTile _btnOpen;
        //private MetroFramework.Controls.MetroTile _btnSave;
        //private MetroFramework.Controls.MetroButton _btnClear;
        //private MetroFramework.Controls.MetroButton _btnPrintTree;
        //private System.Windows.Forms.TextBox _txtOutput;
        //private MetroFramework.Controls.MetroLabel _lblStatus;
        //private MetroFramework.Controls.MetroLabel _lblScanCount;
    }
}

