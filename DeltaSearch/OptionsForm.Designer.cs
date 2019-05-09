﻿namespace DeltaSearch
{
    partial class OptionsForm
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
            this._btnClose = new MetroFramework.Controls.MetroButton();
            this._btnClearPreferences = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // _btnClose
            // 
            this._btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._btnClose.Location = new System.Drawing.Point(99, 158);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 23);
            this._btnClose.TabIndex = 0;
            this._btnClose.Text = "Close";
            this._btnClose.UseSelectable = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // _btnClearPreferences
            // 
            this._btnClearPreferences.Location = new System.Drawing.Point(69, 78);
            this._btnClearPreferences.Name = "_btnClearPreferences";
            this._btnClearPreferences.Size = new System.Drawing.Size(135, 23);
            this._btnClearPreferences.TabIndex = 1;
            this._btnClearPreferences.Text = "Clear Preferences";
            this._btnClearPreferences.UseSelectable = true;
            this._btnClearPreferences.Click += new System.EventHandler(this._btnClearPreferences_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 204);
            this.Controls.Add(this._btnClearPreferences);
            this.Controls.Add(this._btnClose);
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton _btnClose;
        private MetroFramework.Controls.MetroButton _btnClearPreferences;
    }
}