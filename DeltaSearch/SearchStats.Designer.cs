namespace DeltaSearch
{
    partial class SearchStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchStats));
            this._btnCancel = new System.Windows.Forms.Button();
            this._txtStats = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._btnCancel.BackgroundImage = global::DeltaSearch.Properties.Resources.x_image;
            this._btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCancel.Location = new System.Drawing.Point(131, 285);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(41, 39);
            this._btnCancel.TabIndex = 1;
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _txtStats
            // 
            this._txtStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this._txtStats.CustomButton.Image = null;
            this._txtStats.CustomButton.Location = new System.Drawing.Point(53, 1);
            this._txtStats.CustomButton.Name = "";
            this._txtStats.CustomButton.Size = new System.Drawing.Size(213, 213);
            this._txtStats.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtStats.CustomButton.TabIndex = 1;
            this._txtStats.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtStats.CustomButton.UseSelectable = true;
            this._txtStats.CustomButton.Visible = false;
            this._txtStats.Lines = new string[] {
        "metroTextBox1"};
            this._txtStats.Location = new System.Drawing.Point(23, 64);
            this._txtStats.MaxLength = 32767;
            this._txtStats.Multiline = true;
            this._txtStats.Name = "_txtStats";
            this._txtStats.PasswordChar = '\0';
            this._txtStats.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtStats.SelectedText = "";
            this._txtStats.SelectionLength = 0;
            this._txtStats.SelectionStart = 0;
            this._txtStats.ShortcutsEnabled = true;
            this._txtStats.Size = new System.Drawing.Size(267, 215);
            this._txtStats.TabIndex = 2;
            this._txtStats.Text = "metroTextBox1";
            this._txtStats.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtStats.UseSelectable = true;
            this._txtStats.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtStats.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SearchStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 336);
            this.Controls.Add(this._txtStats);
            this.Controls.Add(this._btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchStats";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SearchStats";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SearchStats_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnCancel;
        private MetroFramework.Controls.MetroTextBox _txtStats;
    }
}