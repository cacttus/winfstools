namespace DirPoll
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this._btnClose = new MetroFramework.Controls.MetroTile();
            this._txtText = new MetroFramework.Controls.MetroTextBox();
            this._txtHelp = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this._lblVersion = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // _btnClose
            // 
            this._btnClose.ActiveControl = null;
            this._btnClose.Location = new System.Drawing.Point(357, 489);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(84, 39);
            this._btnClose.TabIndex = 0;
            this._btnClose.Text = "CLOSE";
            this._btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._btnClose.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._btnClose.UseSelectable = true;
            this._btnClose.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // _txtText
            // 
            // 
            // 
            // 
            this._txtText.CustomButton.Image = null;
            this._txtText.CustomButton.Location = new System.Drawing.Point(337, 1);
            this._txtText.CustomButton.Name = "";
            this._txtText.CustomButton.Size = new System.Drawing.Size(93, 93);
            this._txtText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtText.CustomButton.TabIndex = 1;
            this._txtText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtText.CustomButton.UseSelectable = true;
            this._txtText.CustomButton.Visible = false;
            this._txtText.Lines = new string[] {
        "DirPoll"};
            this._txtText.Location = new System.Drawing.Point(10, 388);
            this._txtText.MaxLength = 32767;
            this._txtText.Multiline = true;
            this._txtText.Name = "_txtText";
            this._txtText.PasswordChar = '\0';
            this._txtText.ReadOnly = true;
            this._txtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtText.SelectedText = "";
            this._txtText.SelectionLength = 0;
            this._txtText.SelectionStart = 0;
            this._txtText.ShortcutsEnabled = true;
            this._txtText.Size = new System.Drawing.Size(431, 95);
            this._txtText.TabIndex = 1;
            this._txtText.Text = "DirPoll";
            this._txtText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtText.UseSelectable = true;
            this._txtText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._txtText.Click += new System.EventHandler(this._txtText_Click);
            this._txtText.Enter += new System.EventHandler(this._txtHelp_Enter);
            // 
            // _txtHelp
            // 
            // 
            // 
            // 
            this._txtHelp.CustomButton.Image = null;
            this._txtHelp.CustomButton.Location = new System.Drawing.Point(167, 2);
            this._txtHelp.CustomButton.Name = "";
            this._txtHelp.CustomButton.Size = new System.Drawing.Size(261, 261);
            this._txtHelp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtHelp.CustomButton.TabIndex = 1;
            this._txtHelp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtHelp.CustomButton.UseSelectable = true;
            this._txtHelp.CustomButton.Visible = false;
            this._txtHelp.Lines = new string[] {
        "DirPoll"};
            this._txtHelp.Location = new System.Drawing.Point(10, 82);
            this._txtHelp.MaxLength = 32767;
            this._txtHelp.Multiline = true;
            this._txtHelp.Name = "_txtHelp";
            this._txtHelp.PasswordChar = '\0';
            this._txtHelp.ReadOnly = true;
            this._txtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._txtHelp.SelectedText = "";
            this._txtHelp.SelectionLength = 0;
            this._txtHelp.SelectionStart = 0;
            this._txtHelp.ShortcutsEnabled = true;
            this._txtHelp.Size = new System.Drawing.Size(431, 266);
            this._txtHelp.TabIndex = 1;
            this._txtHelp.Text = "DirPoll";
            this._txtHelp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtHelp.UseSelectable = true;
            this._txtHelp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtHelp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._txtHelp.Click += new System.EventHandler(this._txtText_Click);
            this._txtHelp.Enter += new System.EventHandler(this._txtHelp_Enter);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Help";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 366);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "About";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _lblVersion
            // 
            this._lblVersion.AutoSize = true;
            this._lblVersion.Location = new System.Drawing.Point(402, 34);
            this._lblVersion.Name = "_lblVersion";
            this._lblVersion.Size = new System.Drawing.Size(39, 19);
            this._lblVersion.TabIndex = 48;
            this._lblVersion.Text = "v0.00";
            this._lblVersion.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 540);
            this.Controls.Add(this._lblVersion);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this._txtHelp);
            this.Controls.Add(this._txtText);
            this.Controls.Add(this._btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Help && About";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile _btnClose;
        private MetroFramework.Controls.MetroTextBox _txtText;
        private MetroFramework.Controls.MetroTextBox _txtHelp;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel _lblVersion;
    }
}