namespace DirPoll
{
    partial class StatsForm
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
            this._lblMemory = new MetroFramework.Controls.MetroLabel();
            this._lblScannedItemCount = new MetroFramework.Controls.MetroLabel();
            this._lblScanCount = new MetroFramework.Controls.MetroLabel();
            this._lblFileAccesses = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this._grdTopFileChanges = new MetroFramework.Controls.MetroGrid();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WriteCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this._lblDeletedPerSecond = new MetroFramework.Controls.MetroLabel();
            this._lblChangedPerSecond = new MetroFramework.Controls.MetroLabel();
            this._lblAddedPerSecond = new MetroFramework.Controls.MetroLabel();
            this._lblStatus = new MetroFramework.Controls.MetroLabel();
            this._lblAverageScanTime = new MetroFramework.Controls.MetroLabel();
            this._lblNewFiles = new MetroFramework.Controls.MetroLabel();
            this._lblLastScanTime = new MetroFramework.Controls.MetroLabel();
            this._pgbCurrentScan = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this._lblCurrentScanPct = new MetroFramework.Controls.MetroLabel();
            this._lblDeletedPerScan = new MetroFramework.Controls.MetroLabel();
            this._lblChangedPerScan = new MetroFramework.Controls.MetroLabel();
            this._lblAddedPerScan = new MetroFramework.Controls.MetroLabel();
            this._cboNumTopFiles = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this._grdTopFileChanges)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblMemory
            // 
            this._lblMemory.AutoSize = true;
            this._lblMemory.Location = new System.Drawing.Point(24, 384);
            this._lblMemory.Name = "_lblMemory";
            this._lblMemory.Size = new System.Drawing.Size(40, 19);
            this._lblMemory.TabIndex = 4;
            this._lblMemory.Text = "Mem";
            this._lblMemory.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblScannedItemCount
            // 
            this._lblScannedItemCount.AutoSize = true;
            this._lblScannedItemCount.Location = new System.Drawing.Point(23, 322);
            this._lblScannedItemCount.Name = "_lblScannedItemCount";
            this._lblScannedItemCount.Size = new System.Drawing.Size(92, 19);
            this._lblScannedItemCount.TabIndex = 5;
            this._lblScannedItemCount.Text = "Items last scan";
            this._lblScannedItemCount.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblScanCount
            // 
            this._lblScanCount.AutoSize = true;
            this._lblScanCount.Location = new System.Drawing.Point(22, 284);
            this._lblScanCount.Name = "_lblScanCount";
            this._lblScanCount.Size = new System.Drawing.Size(41, 19);
            this._lblScanCount.TabIndex = 6;
            this._lblScanCount.Text = "Scans";
            this._lblScanCount.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblFileAccesses
            // 
            this._lblFileAccesses.AutoSize = true;
            this._lblFileAccesses.Location = new System.Drawing.Point(20, 30);
            this._lblFileAccesses.Name = "_lblFileAccesses";
            this._lblFileAccesses.Size = new System.Drawing.Size(89, 19);
            this._lblFileAccesses.TabIndex = 8;
            this._lblFileAccesses.Text = "File Access / s";
            this._lblFileAccesses.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 118);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(167, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Files With The Most Writes:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _grdTopFileChanges
            // 
            this._grdTopFileChanges.AllowUserToAddRows = false;
            this._grdTopFileChanges.AllowUserToDeleteRows = false;
            this._grdTopFileChanges.AllowUserToOrderColumns = true;
            this._grdTopFileChanges.AllowUserToResizeRows = false;
            this._grdTopFileChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._grdTopFileChanges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._grdTopFileChanges.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this._grdTopFileChanges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._grdTopFileChanges.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._grdTopFileChanges.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._grdTopFileChanges.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._grdTopFileChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grdTopFileChanges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Path,
            this.WriteCount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grdTopFileChanges.DefaultCellStyle = dataGridViewCellStyle2;
            this._grdTopFileChanges.EnableHeadersVisualStyles = false;
            this._grdTopFileChanges.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._grdTopFileChanges.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this._grdTopFileChanges.Location = new System.Drawing.Point(22, 143);
            this._grdTopFileChanges.Name = "_grdTopFileChanges";
            this._grdTopFileChanges.ReadOnly = true;
            this._grdTopFileChanges.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._grdTopFileChanges.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._grdTopFileChanges.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._grdTopFileChanges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._grdTopFileChanges.ShowEditingIcon = false;
            this._grdTopFileChanges.Size = new System.Drawing.Size(538, 75);
            this._grdTopFileChanges.TabIndex = 99;
            this._grdTopFileChanges.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._grdTopFileChanges.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._grdTopFileChanges_CellContentClick);
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            // 
            // WriteCount
            // 
            this.WriteCount.HeaderText = "Write Count";
            this.WriteCount.Name = "WriteCount";
            this.WriteCount.ReadOnly = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(121, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "FILE SYSTEM STATS";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(8, 221);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(101, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "DIRSCAN STATS";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblDeletedPerSecond
            // 
            this._lblDeletedPerSecond.AutoSize = true;
            this._lblDeletedPerSecond.Location = new System.Drawing.Point(20, 49);
            this._lblDeletedPerSecond.Name = "_lblDeletedPerSecond";
            this._lblDeletedPerSecond.Size = new System.Drawing.Size(153, 19);
            this._lblDeletedPerSecond.TabIndex = 8;
            this._lblDeletedPerSecond.Text = "Deleted Files Per Second";
            this._lblDeletedPerSecond.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblChangedPerSecond
            // 
            this._lblChangedPerSecond.AutoSize = true;
            this._lblChangedPerSecond.Location = new System.Drawing.Point(20, 68);
            this._lblChangedPerSecond.Name = "_lblChangedPerSecond";
            this._lblChangedPerSecond.Size = new System.Drawing.Size(161, 19);
            this._lblChangedPerSecond.TabIndex = 12;
            this._lblChangedPerSecond.Text = "Changed Files Per Second";
            this._lblChangedPerSecond.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblAddedPerSecond
            // 
            this._lblAddedPerSecond.AutoSize = true;
            this._lblAddedPerSecond.Location = new System.Drawing.Point(20, 87);
            this._lblAddedPerSecond.Name = "_lblAddedPerSecond";
            this._lblAddedPerSecond.Size = new System.Drawing.Size(148, 19);
            this._lblAddedPerSecond.TabIndex = 12;
            this._lblAddedPerSecond.Text = "Added Files Per Second";
            this._lblAddedPerSecond.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblStatus
            // 
            this._lblStatus.AutoSize = true;
            this._lblStatus.Location = new System.Drawing.Point(24, 414);
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(517, 19);
            this._lblStatus.TabIndex = 13;
            this._lblStatus.Text = "Status..........................................................................." +
    "................................................................................" +
    "...";
            this._lblStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblAverageScanTime
            // 
            this._lblAverageScanTime.AutoSize = true;
            this._lblAverageScanTime.Location = new System.Drawing.Point(23, 365);
            this._lblAverageScanTime.Name = "_lblAverageScanTime";
            this._lblAverageScanTime.Size = new System.Drawing.Size(122, 19);
            this._lblAverageScanTime.TabIndex = 14;
            this._lblAverageScanTime.Text = "Average Scan Time";
            this._lblAverageScanTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblNewFiles
            // 
            this._lblNewFiles.AutoSize = true;
            this._lblNewFiles.Location = new System.Drawing.Point(23, 303);
            this._lblNewFiles.Name = "_lblNewFiles";
            this._lblNewFiles.Size = new System.Drawing.Size(110, 19);
            this._lblNewFiles.TabIndex = 6;
            this._lblNewFiles.Text = "new files last scan";
            this._lblNewFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblLastScanTime
            // 
            this._lblLastScanTime.AutoSize = true;
            this._lblLastScanTime.Location = new System.Drawing.Point(24, 346);
            this._lblLastScanTime.Name = "_lblLastScanTime";
            this._lblLastScanTime.Size = new System.Drawing.Size(91, 19);
            this._lblLastScanTime.TabIndex = 15;
            this._lblLastScanTime.Text = "LastScan Time";
            this._lblLastScanTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _pgbCurrentScan
            // 
            this._pgbCurrentScan.Location = new System.Drawing.Point(30, 265);
            this._pgbCurrentScan.Name = "_pgbCurrentScan";
            this._pgbCurrentScan.Size = new System.Drawing.Size(85, 10);
            this._pgbCurrentScan.TabIndex = 47;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(22, 243);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(87, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Current Scan:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblCurrentScanPct
            // 
            this._lblCurrentScanPct.AutoSize = true;
            this._lblCurrentScanPct.Location = new System.Drawing.Point(115, 256);
            this._lblCurrentScanPct.Name = "_lblCurrentScanPct";
            this._lblCurrentScanPct.Size = new System.Drawing.Size(87, 19);
            this._lblCurrentScanPct.TabIndex = 6;
            this._lblCurrentScanPct.Text = "Current Scan:";
            this._lblCurrentScanPct.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblDeletedPerScan
            // 
            this._lblDeletedPerScan.AutoSize = true;
            this._lblDeletedPerScan.Location = new System.Drawing.Point(351, 49);
            this._lblDeletedPerScan.Name = "_lblDeletedPerScan";
            this._lblDeletedPerScan.Size = new System.Drawing.Size(144, 19);
            this._lblDeletedPerScan.TabIndex = 8;
            this._lblDeletedPerScan.Text = "Deleted Files Per SScan";
            this._lblDeletedPerScan.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblChangedPerScan
            // 
            this._lblChangedPerScan.AutoSize = true;
            this._lblChangedPerScan.Location = new System.Drawing.Point(351, 68);
            this._lblChangedPerScan.Name = "_lblChangedPerScan";
            this._lblChangedPerScan.Size = new System.Drawing.Size(145, 19);
            this._lblChangedPerScan.TabIndex = 12;
            this._lblChangedPerScan.Text = "Changed Files Per Scan";
            this._lblChangedPerScan.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblAddedPerScan
            // 
            this._lblAddedPerScan.AutoSize = true;
            this._lblAddedPerScan.Location = new System.Drawing.Point(351, 87);
            this._lblAddedPerScan.Name = "_lblAddedPerScan";
            this._lblAddedPerScan.Size = new System.Drawing.Size(132, 19);
            this._lblAddedPerScan.TabIndex = 12;
            this._lblAddedPerScan.Text = "Added Files Per Scan";
            this._lblAddedPerScan.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _cboNumTopFiles
            // 
            this._cboNumTopFiles.FormattingEnabled = true;
            this._cboNumTopFiles.ItemHeight = 23;
            this._cboNumTopFiles.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "20",
            "30",
            "50",
            "100"});
            this._cboNumTopFiles.Location = new System.Drawing.Point(298, 108);
            this._cboNumTopFiles.Name = "_cboNumTopFiles";
            this._cboNumTopFiles.Size = new System.Drawing.Size(70, 29);
            this._cboNumTopFiles.TabIndex = 48;
            this._cboNumTopFiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._cboNumTopFiles.UseSelectable = true;
            this._cboNumTopFiles.SelectedIndexChanged += new System.EventHandler(this._cboNumTopFiles_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(252, 118);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(40, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Show";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 455);
            this.Controls.Add(this._cboNumTopFiles);
            this.Controls.Add(this._lblCurrentScanPct);
            this.Controls.Add(this._pgbCurrentScan);
            this.Controls.Add(this._lblLastScanTime);
            this.Controls.Add(this._lblAverageScanTime);
            this.Controls.Add(this._lblStatus);
            this.Controls.Add(this._lblAddedPerScan);
            this.Controls.Add(this._lblAddedPerSecond);
            this.Controls.Add(this._lblChangedPerScan);
            this.Controls.Add(this._lblChangedPerSecond);
            this.Controls.Add(this._grdTopFileChanges);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this._lblDeletedPerScan);
            this.Controls.Add(this._lblDeletedPerSecond);
            this.Controls.Add(this._lblFileAccesses);
            this.Controls.Add(this._lblMemory);
            this.Controls.Add(this._lblScannedItemCount);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this._lblNewFiles);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this._lblScanCount);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatsForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShowInTaskbar = false;
            this.Text = "Stats";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatsForm_FormClosing);
            this.Load += new System.EventHandler(this.StatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._grdTopFileChanges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel _lblMemory;
        private MetroFramework.Controls.MetroLabel _lblScannedItemCount;
        private MetroFramework.Controls.MetroLabel _lblScanCount;
        private MetroFramework.Controls.MetroLabel _lblFileAccesses;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid _grdTopFileChanges;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel _lblDeletedPerSecond;
        private MetroFramework.Controls.MetroLabel _lblChangedPerSecond;
        private MetroFramework.Controls.MetroLabel _lblAddedPerSecond;
        private MetroFramework.Controls.MetroLabel _lblStatus;
        private MetroFramework.Controls.MetroLabel _lblAverageScanTime;
        private MetroFramework.Controls.MetroLabel _lblNewFiles;
        private MetroFramework.Controls.MetroLabel _lblLastScanTime;
        private MetroFramework.Controls.MetroProgressBar _pgbCurrentScan;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel _lblCurrentScanPct;
        private MetroFramework.Controls.MetroLabel _lblDeletedPerScan;
        private MetroFramework.Controls.MetroLabel _lblChangedPerScan;
        private MetroFramework.Controls.MetroLabel _lblAddedPerScan;
        private MetroFramework.Controls.MetroComboBox _cboNumTopFiles;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn WriteCount;
    }
}