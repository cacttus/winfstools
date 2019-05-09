namespace AutoMove
{
    partial class frmMain
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
            this._btnStartPolling = new System.Windows.Forms.Button();
            this._txtWatchDir = new System.Windows.Forms.TextBox();
            this._txtMoveDir = new System.Windows.Forms.TextBox();
            this._btnSelectMoveDir = new System.Windows.Forms.Button();
            this._btnSelectWatchDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._nudPollInterval = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._optRename = new System.Windows.Forms.RadioButton();
            this._optOverwrite = new System.Windows.Forms.RadioButton();
            this._chkDeleteSourceFile = new System.Windows.Forms.CheckBox();
            this._pgbProgress = new System.Windows.Forms.ProgressBar();
            this._chkOnlyMoveIfChanged = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._nudPollInterval)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnStartPolling
            // 
            this._btnStartPolling.Location = new System.Drawing.Point(50, 339);
            this._btnStartPolling.Name = "_btnStartPolling";
            this._btnStartPolling.Size = new System.Drawing.Size(188, 40);
            this._btnStartPolling.TabIndex = 0;
            this._btnStartPolling.Text = "Start Polling";
            this._btnStartPolling.UseVisualStyleBackColor = true;
            this._btnStartPolling.Click += new System.EventHandler(this._btnStartPolling_Click);
            // 
            // _txtWatchDir
            // 
            this._txtWatchDir.Location = new System.Drawing.Point(49, 29);
            this._txtWatchDir.Name = "_txtWatchDir";
            this._txtWatchDir.Size = new System.Drawing.Size(220, 22);
            this._txtWatchDir.TabIndex = 1;
            this._txtWatchDir.Text = "D:\\eMule0.50a\\incoming";
            this._txtWatchDir.TextChanged += new System.EventHandler(this._txtWatchDir_TextChanged);
            // 
            // _txtMoveDir
            // 
            this._txtMoveDir.Location = new System.Drawing.Point(49, 86);
            this._txtMoveDir.Name = "_txtMoveDir";
            this._txtMoveDir.Size = new System.Drawing.Size(220, 22);
            this._txtMoveDir.TabIndex = 2;
            this._txtMoveDir.Text = "D:\\Moved";
            this._txtMoveDir.TextChanged += new System.EventHandler(this._txtMoveDir_TextChanged);
            // 
            // _btnSelectMoveDir
            // 
            this._btnSelectMoveDir.Location = new System.Drawing.Point(15, 86);
            this._btnSelectMoveDir.Name = "_btnSelectMoveDir";
            this._btnSelectMoveDir.Size = new System.Drawing.Size(28, 23);
            this._btnSelectMoveDir.TabIndex = 3;
            this._btnSelectMoveDir.Text = "...";
            this._btnSelectMoveDir.UseVisualStyleBackColor = true;
            this._btnSelectMoveDir.Click += new System.EventHandler(this._btnSelectMoveDir_Click);
            // 
            // _btnSelectWatchDir
            // 
            this._btnSelectWatchDir.Location = new System.Drawing.Point(15, 29);
            this._btnSelectWatchDir.Name = "_btnSelectWatchDir";
            this._btnSelectWatchDir.Size = new System.Drawing.Size(28, 23);
            this._btnSelectWatchDir.TabIndex = 3;
            this._btnSelectWatchDir.Text = "...";
            this._btnSelectWatchDir.UseVisualStyleBackColor = true;
            this._btnSelectWatchDir.Click += new System.EventHandler(this._btnSelectWatchDir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Move Files To Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Watch Directory For Files";
            // 
            // _txtOutput
            // 
            this._txtOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._txtOutput.Location = new System.Drawing.Point(0, 398);
            this._txtOutput.Multiline = true;
            this._txtOutput.Name = "_txtOutput";
            this._txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtOutput.Size = new System.Drawing.Size(308, 108);
            this._txtOutput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Poll Interval (ms)";
            // 
            // _nudPollInterval
            // 
            this._nudPollInterval.Location = new System.Drawing.Point(165, 306);
            this._nudPollInterval.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this._nudPollInterval.Name = "_nudPollInterval";
            this._nudPollInterval.Size = new System.Drawing.Size(71, 22);
            this._nudPollInterval.TabIndex = 7;
            this._nudPollInterval.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this._nudPollInterval.ValueChanged += new System.EventHandler(this._nudPollInterval_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._optRename);
            this.groupBox1.Controls.Add(this._optOverwrite);
            this.groupBox1.Location = new System.Drawing.Point(70, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 79);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conflict Resolution";
            // 
            // _optRename
            // 
            this._optRename.AutoSize = true;
            this._optRename.Checked = true;
            this._optRename.Location = new System.Drawing.Point(6, 48);
            this._optRename.Name = "_optRename";
            this._optRename.Size = new System.Drawing.Size(82, 21);
            this._optRename.TabIndex = 10;
            this._optRename.TabStop = true;
            this._optRename.Text = "Rename";
            this._optRename.UseVisualStyleBackColor = true;
            // 
            // _optOverwrite
            // 
            this._optOverwrite.AutoSize = true;
            this._optOverwrite.Location = new System.Drawing.Point(6, 21);
            this._optOverwrite.Name = "_optOverwrite";
            this._optOverwrite.Size = new System.Drawing.Size(89, 21);
            this._optOverwrite.TabIndex = 9;
            this._optOverwrite.Text = "Overwrite";
            this._optOverwrite.UseVisualStyleBackColor = true;
            // 
            // _chkDeleteSourceFile
            // 
            this._chkDeleteSourceFile.AutoSize = true;
            this._chkDeleteSourceFile.Checked = true;
            this._chkDeleteSourceFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkDeleteSourceFile.Location = new System.Drawing.Point(50, 247);
            this._chkDeleteSourceFile.Name = "_chkDeleteSourceFile";
            this._chkDeleteSourceFile.Size = new System.Drawing.Size(146, 21);
            this._chkDeleteSourceFile.TabIndex = 9;
            this._chkDeleteSourceFile.Text = "Delete Source File";
            this._chkDeleteSourceFile.UseVisualStyleBackColor = true;
            // 
            // _pgbProgress
            // 
            this._pgbProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._pgbProgress.Location = new System.Drawing.Point(0, 506);
            this._pgbProgress.Name = "_pgbProgress";
            this._pgbProgress.Size = new System.Drawing.Size(308, 23);
            this._pgbProgress.TabIndex = 10;
            // 
            // _chkOnlyMoveIfChanged
            // 
            this._chkOnlyMoveIfChanged.AutoSize = true;
            this._chkOnlyMoveIfChanged.Checked = true;
            this._chkOnlyMoveIfChanged.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkOnlyMoveIfChanged.Location = new System.Drawing.Point(50, 265);
            this._chkOnlyMoveIfChanged.Name = "_chkOnlyMoveIfChanged";
            this._chkOnlyMoveIfChanged.Size = new System.Drawing.Size(222, 21);
            this._chkOnlyMoveIfChanged.TabIndex = 9;
            this._chkOnlyMoveIfChanged.Text = "Only Copy if File Has Changed";
            this._chkOnlyMoveIfChanged.UseVisualStyleBackColor = true;
            this._chkOnlyMoveIfChanged.CheckedChanged += new System.EventHandler(this._chkMoveChanged_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 529);
            this.Controls.Add(this._chkOnlyMoveIfChanged);
            this.Controls.Add(this._chkDeleteSourceFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._nudPollInterval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnSelectWatchDir);
            this.Controls.Add(this._btnSelectMoveDir);
            this.Controls.Add(this._txtMoveDir);
            this.Controls.Add(this._txtWatchDir);
            this.Controls.Add(this._btnStartPolling);
            this.Controls.Add(this._pgbProgress);
            this.Name = "frmMain";
            this.Text = "Auto Move (Automatic File Mover)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this._nudPollInterval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnStartPolling;
        private System.Windows.Forms.TextBox _txtWatchDir;
        private System.Windows.Forms.TextBox _txtMoveDir;
        private System.Windows.Forms.Button _btnSelectMoveDir;
        private System.Windows.Forms.Button _btnSelectWatchDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _nudPollInterval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton _optRename;
        private System.Windows.Forms.RadioButton _optOverwrite;
        private System.Windows.Forms.CheckBox _chkDeleteSourceFile;
        private System.Windows.Forms.ProgressBar _pgbProgress;
        private System.Windows.Forms.CheckBox _chkOnlyMoveIfChanged;
    }
}

