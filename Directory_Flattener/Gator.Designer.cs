namespace Flattenator
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
            this._btnFlatten = new System.Windows.Forms.Button();
            this._lstFileTypes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._txtFileTypeToAdd = new System.Windows.Forms.TextBox();
            this._btnRemove = new System.Windows.Forms.Button();
            this._btnAdd = new System.Windows.Forms.Button();
            this._optCodeFiles = new System.Windows.Forms.RadioButton();
            this._optAllFiles = new System.Windows.Forms.RadioButton();
            this._optVideoFiles = new System.Windows.Forms.RadioButton();
            this._optImageFiles = new System.Windows.Forms.RadioButton();
            this._chkSearchRoot = new System.Windows.Forms.CheckBox();
            this._grpOptions = new System.Windows.Forms.GroupBox();
            this._chkDeleteFiles = new System.Windows.Forms.CheckBox();
            this._txtFilenameRegularExpression = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this._chkDeleteEmptyFolders = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._optFolderFileIndex = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this._optIndexOnly = new System.Windows.Forms.RadioButton();
            this._txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._lblRenameCount = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this._grpOptions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnFlatten
            // 
            this._btnFlatten.BackColor = System.Drawing.Color.Lime;
            this._btnFlatten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnFlatten.Location = new System.Drawing.Point(61, 415);
            this._btnFlatten.Name = "_btnFlatten";
            this._btnFlatten.Size = new System.Drawing.Size(136, 47);
            this._btnFlatten.TabIndex = 18;
            this._btnFlatten.Text = "Flatten";
            this._btnFlatten.UseVisualStyleBackColor = false;
            this._btnFlatten.Click += new System.EventHandler(this.button1_Click);
            // 
            // _lstFileTypes
            // 
            this._lstFileTypes.FormattingEnabled = true;
            this._lstFileTypes.Location = new System.Drawing.Point(108, 19);
            this._lstFileTypes.Name = "_lstFileTypes";
            this._lstFileTypes.Size = new System.Drawing.Size(109, 69);
            this._lstFileTypes.TabIndex = 10;
            this._lstFileTypes.SelectedIndexChanged += new System.EventHandler(this._lstFileTypes_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._txtFileTypeToAdd);
            this.groupBox1.Controls.Add(this._btnRemove);
            this.groupBox1.Controls.Add(this._btnAdd);
            this.groupBox1.Controls.Add(this._optCodeFiles);
            this.groupBox1.Controls.Add(this._lstFileTypes);
            this.groupBox1.Controls.Add(this._optAllFiles);
            this.groupBox1.Controls.Add(this._optVideoFiles);
            this.groupBox1.Controls.Add(this._optImageFiles);
            this.groupBox1.Location = new System.Drawing.Point(13, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 159);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Types To Move";
            // 
            // _txtFileTypeToAdd
            // 
            this._txtFileTypeToAdd.Location = new System.Drawing.Point(108, 94);
            this._txtFileTypeToAdd.Name = "_txtFileTypeToAdd";
            this._txtFileTypeToAdd.Size = new System.Drawing.Size(109, 20);
            this._txtFileTypeToAdd.TabIndex = 11;
            this._txtFileTypeToAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtFileTypeToAdd_KeyDown);
            // 
            // _btnRemove
            // 
            this._btnRemove.Location = new System.Drawing.Point(158, 121);
            this._btnRemove.Name = "_btnRemove";
            this._btnRemove.Size = new System.Drawing.Size(59, 23);
            this._btnRemove.TabIndex = 13;
            this._btnRemove.Text = "Remove";
            this._btnRemove.UseVisualStyleBackColor = true;
            this._btnRemove.Click += new System.EventHandler(this._btnRemove_Click);
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(108, 121);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(43, 23);
            this._btnAdd.TabIndex = 12;
            this._btnAdd.Text = "Add";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _optCodeFiles
            // 
            this._optCodeFiles.AutoSize = true;
            this._optCodeFiles.Location = new System.Drawing.Point(8, 88);
            this._optCodeFiles.Name = "_optCodeFiles";
            this._optCodeFiles.Size = new System.Drawing.Size(50, 17);
            this._optCodeFiles.TabIndex = 9;
            this._optCodeFiles.TabStop = true;
            this._optCodeFiles.Text = "Code";
            this._optCodeFiles.UseVisualStyleBackColor = true;
            this._optCodeFiles.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // _optAllFiles
            // 
            this._optAllFiles.AutoSize = true;
            this._optAllFiles.Location = new System.Drawing.Point(9, 19);
            this._optAllFiles.Name = "_optAllFiles";
            this._optAllFiles.Size = new System.Drawing.Size(36, 17);
            this._optAllFiles.TabIndex = 6;
            this._optAllFiles.TabStop = true;
            this._optAllFiles.Text = "All";
            this._optAllFiles.UseVisualStyleBackColor = true;
            this._optAllFiles.CheckedChanged += new System.EventHandler(this._optAllFiles_CheckedChanged);
            // 
            // _optVideoFiles
            // 
            this._optVideoFiles.AutoSize = true;
            this._optVideoFiles.Location = new System.Drawing.Point(9, 65);
            this._optVideoFiles.Name = "_optVideoFiles";
            this._optVideoFiles.Size = new System.Drawing.Size(57, 17);
            this._optVideoFiles.TabIndex = 8;
            this._optVideoFiles.TabStop = true;
            this._optVideoFiles.Text = "Videos";
            this._optVideoFiles.UseVisualStyleBackColor = true;
            this._optVideoFiles.CheckedChanged += new System.EventHandler(this._optVideoFiles_CheckedChanged);
            // 
            // _optImageFiles
            // 
            this._optImageFiles.AutoSize = true;
            this._optImageFiles.Location = new System.Drawing.Point(9, 42);
            this._optImageFiles.Name = "_optImageFiles";
            this._optImageFiles.Size = new System.Drawing.Size(59, 17);
            this._optImageFiles.TabIndex = 7;
            this._optImageFiles.TabStop = true;
            this._optImageFiles.Text = "Images";
            this._optImageFiles.UseVisualStyleBackColor = true;
            this._optImageFiles.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // _chkSearchRoot
            // 
            this._chkSearchRoot.AutoSize = true;
            this._chkSearchRoot.Location = new System.Drawing.Point(9, 19);
            this._chkSearchRoot.Name = "_chkSearchRoot";
            this._chkSearchRoot.Size = new System.Drawing.Size(86, 17);
            this._chkSearchRoot.TabIndex = 15;
            this._chkSearchRoot.Text = "Search Root";
            this._chkSearchRoot.UseVisualStyleBackColor = true;
            this._chkSearchRoot.CheckedChanged += new System.EventHandler(this._chkSearchRoot_CheckedChanged);
            // 
            // _grpOptions
            // 
            this._grpOptions.Controls.Add(this._chkDeleteFiles);
            this._grpOptions.Controls.Add(this._chkSearchRoot);
            this._grpOptions.Controls.Add(this._txtFilenameRegularExpression);
            this._grpOptions.Controls.Add(this.label1);
            this._grpOptions.Controls.Add(this.linkLabel1);
            this._grpOptions.Controls.Add(this._chkDeleteEmptyFolders);
            this._grpOptions.Location = new System.Drawing.Point(13, 310);
            this._grpOptions.Name = "_grpOptions";
            this._grpOptions.Size = new System.Drawing.Size(234, 95);
            this._grpOptions.TabIndex = 14;
            this._grpOptions.TabStop = false;
            this._grpOptions.Text = "Options";
            // 
            // _chkDeleteFiles
            // 
            this._chkDeleteFiles.AutoSize = true;
            this._chkDeleteFiles.Location = new System.Drawing.Point(9, 42);
            this._chkDeleteFiles.Name = "_chkDeleteFiles";
            this._chkDeleteFiles.Size = new System.Drawing.Size(117, 17);
            this._chkDeleteFiles.TabIndex = 16;
            this._chkDeleteFiles.Text = "Delete Moved Files";
            this._chkDeleteFiles.UseVisualStyleBackColor = true;
            // 
            // _txtFilenameRegularExpression
            // 
            this._txtFilenameRegularExpression.Enabled = false;
            this._txtFilenameRegularExpression.Location = new System.Drawing.Point(7, 162);
            this._txtFilenameRegularExpression.Name = "_txtFilenameRegularExpression";
            this._txtFilenameRegularExpression.Size = new System.Drawing.Size(210, 20);
            this._txtFilenameRegularExpression.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(6, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filename Regular Expression";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.Location = new System.Drawing.Point(6, 115);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Advanced...";
            // 
            // _chkDeleteEmptyFolders
            // 
            this._chkDeleteEmptyFolders.AutoSize = true;
            this._chkDeleteEmptyFolders.Location = new System.Drawing.Point(9, 65);
            this._chkDeleteEmptyFolders.Name = "_chkDeleteEmptyFolders";
            this._chkDeleteEmptyFolders.Size = new System.Drawing.Size(126, 17);
            this._chkDeleteEmptyFolders.TabIndex = 17;
            this._chkDeleteEmptyFolders.Text = "Delete Empty Folders";
            this._chkDeleteEmptyFolders.UseVisualStyleBackColor = true;
            this._chkDeleteEmptyFolders.CheckedChanged += new System.EventHandler(this._chkDeleteEmptyFolders_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._optFolderFileIndex);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this._optIndexOnly);
            this.groupBox2.Location = new System.Drawing.Point(13, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Collision Naming";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // _optFolderFileIndex
            // 
            this._optFolderFileIndex.AutoSize = true;
            this._optFolderFileIndex.Location = new System.Drawing.Point(7, 68);
            this._optFolderFileIndex.Name = "_optFolderFileIndex";
            this._optFolderFileIndex.Size = new System.Drawing.Size(164, 17);
            this._optFolderFileIndex.TabIndex = 4;
            this._optFolderFileIndex.Text = "FolderName_FileName_Index";
            this._optFolderFileIndex.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 21);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(133, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "CurrentFilename_Index";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // _optIndexOnly
            // 
            this._optIndexOnly.AutoSize = true;
            this._optIndexOnly.Location = new System.Drawing.Point(9, 44);
            this._optIndexOnly.Name = "_optIndexOnly";
            this._optIndexOnly.Size = new System.Drawing.Size(139, 17);
            this._optIndexOnly.TabIndex = 3;
            this._optIndexOnly.Text = "FileIndex (file index only)";
            this._optIndexOnly.UseVisualStyleBackColor = true;
            // 
            // _txtOutput
            // 
            this._txtOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._txtOutput.Location = new System.Drawing.Point(0, 484);
            this._txtOutput.Multiline = true;
            this._txtOutput.Name = "_txtOutput";
            this._txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtOutput.Size = new System.Drawing.Size(261, 122);
            this._txtOutput.TabIndex = 999;
            this._txtOutput.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9999;
            this.label2.Text = "Output";
            // 
            // _lblRenameCount
            // 
            this._lblRenameCount.AutoSize = true;
            this._lblRenameCount.Location = new System.Drawing.Point(86, 507);
            this._lblRenameCount.Name = "_lblRenameCount";
            this._lblRenameCount.Size = new System.Drawing.Size(0, 13);
            this._lblRenameCount.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(261, 24);
            this.menuStrip1.TabIndex = 12;
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
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.licenseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.licenseToolStripMenuItem.Text = "License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 606);
            this.Controls.Add(this._lblRenameCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtOutput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this._grpOptions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnFlatten);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Directory Flattener";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this._grpOptions.ResumeLayout(false);
            this._grpOptions.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnFlatten;
        private System.Windows.Forms.ListBox _lstFileTypes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton _optCodeFiles;
        private System.Windows.Forms.RadioButton _optVideoFiles;
        private System.Windows.Forms.RadioButton _optImageFiles;
        private System.Windows.Forms.Button _btnRemove;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.GroupBox _grpOptions;
        private System.Windows.Forms.TextBox _txtFilenameRegularExpression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox _chkDeleteEmptyFolders;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton _optIndexOnly;
        private System.Windows.Forms.CheckBox _chkDeleteFiles;
        private System.Windows.Forms.TextBox _txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _lblRenameCount;
        private System.Windows.Forms.CheckBox _chkSearchRoot;
        private System.Windows.Forms.RadioButton _optFolderFileIndex;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.RadioButton _optAllFiles;
        private System.Windows.Forms.TextBox _txtFileTypeToAdd;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

