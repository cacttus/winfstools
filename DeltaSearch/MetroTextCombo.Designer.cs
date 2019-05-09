namespace DeltaSearch
{
    partial class MetroTextCombo
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
            this._txtTextBox = new MetroFramework.Controls.MetroTextBox();
            this._cboCombobox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // _txtTextBox
            // 
            this._txtTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this._txtTextBox.CustomButton.Image = null;
            this._txtTextBox.CustomButton.Location = new System.Drawing.Point(23, 1);
            this._txtTextBox.CustomButton.Name = "";
            this._txtTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._txtTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._txtTextBox.CustomButton.TabIndex = 1;
            this._txtTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._txtTextBox.CustomButton.UseSelectable = true;
            this._txtTextBox.CustomButton.Visible = false;
            this._txtTextBox.Lines = new string[0];
            this._txtTextBox.Location = new System.Drawing.Point(3, 4);
            this._txtTextBox.MaxLength = 32767;
            this._txtTextBox.Name = "_txtTextBox";
            this._txtTextBox.PasswordChar = '\0';
            this._txtTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._txtTextBox.SelectedText = "";
            this._txtTextBox.SelectionLength = 0;
            this._txtTextBox.SelectionStart = 0;
            this._txtTextBox.ShortcutsEnabled = true;
            this._txtTextBox.Size = new System.Drawing.Size(45, 23);
            this._txtTextBox.TabIndex = 7;
            this._txtTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._txtTextBox.UseSelectable = true;
            this._txtTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._txtTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._txtTextBox.Click += new System.EventHandler(this._txtTextBox_Click);
            this._txtTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtTextBox_KeyPress);
            // 
            // _cboCombobox
            // 
            this._cboCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cboCombobox.FormattingEnabled = true;
            this._cboCombobox.ItemHeight = 23;
            this._cboCombobox.Location = new System.Drawing.Point(1, 1);
            this._cboCombobox.Name = "_cboCombobox";
            this._cboCombobox.Size = new System.Drawing.Size(74, 29);
            this._cboCombobox.TabIndex = 8;
            this._cboCombobox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._cboCombobox.UseSelectable = true;
            this._cboCombobox.SelectedIndexChanged += new System.EventHandler(this._cboCombobox_SelectedIndexChanged);
            // 
            // MetroTextCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._txtTextBox);
            this.Controls.Add(this._cboCombobox);
            this.Name = "MetroTextCombo";
            this.Size = new System.Drawing.Size(76, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox _txtTextBox;
        private MetroFramework.Controls.MetroComboBox _cboCombobox;
    }
}
