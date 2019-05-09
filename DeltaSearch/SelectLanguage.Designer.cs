namespace DeltaSearch
{
    partial class SelectLanguage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectLanguage));
            this._lvLanguage = new System.Windows.Forms.ListView();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lvLanguage
            // 
            this._lvLanguage.Location = new System.Drawing.Point(13, 13);
            this._lvLanguage.Name = "_lvLanguage";
            this._lvLanguage.Size = new System.Drawing.Size(177, 148);
            this._lvLanguage.TabIndex = 1;
            this._lvLanguage.UseCompatibleStateImageBehavior = false;
            this._lvLanguage.SelectedIndexChanged += new System.EventHandler(this._lvLanguage_SelectedIndexChanged);
            // 
            // _btnCancel
            // 
            this._btnCancel.BackgroundImage = global::DeltaSearch.Properties.Resources.x_image;
            this._btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCancel.Location = new System.Drawing.Point(118, 167);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(41, 39);
            this._btnCancel.TabIndex = 0;
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _btnOk
            // 
            this._btnOk.BackgroundImage = global::DeltaSearch.Properties.Resources.check;
            this._btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnOk.Location = new System.Drawing.Point(43, 167);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(40, 39);
            this._btnOk.TabIndex = 0;
            this._btnOk.UseVisualStyleBackColor = true;
            this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
            // 
            // SelectLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 215);
            this.Controls.Add(this._lvLanguage);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectLanguage";
            this.ShowIcon = false;
            this.Text = "Select Language";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SelectLanguage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _btnOk;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.ListView _lvLanguage;
    }
}