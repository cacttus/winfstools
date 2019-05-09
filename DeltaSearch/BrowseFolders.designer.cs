namespace DeltaSearch
{
    partial class BrowseFolders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseFolders));
            this._tvDirectory = new System.Windows.Forms.TreeView();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _tvDirectory
            // 
            this._tvDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tvDirectory.CheckBoxes = true;
            this._tvDirectory.Location = new System.Drawing.Point(12, 12);
            this._tvDirectory.Name = "_tvDirectory";
            this._tvDirectory.Size = new System.Drawing.Size(289, 381);
            this._tvDirectory.TabIndex = 0;
            this._tvDirectory.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this._tvDirectory_BeforeExpand);
            this._tvDirectory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this._tvDirectory_AfterSelect);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnCancel.BackgroundImage = global::DeltaSearch.Properties.Resources.x_image;
            this._btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCancel.Location = new System.Drawing.Point(175, 399);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(41, 39);
            this._btnCancel.TabIndex = 1;
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _btnOk
            // 
            this._btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnOk.BackgroundImage = global::DeltaSearch.Properties.Resources.check;
            this._btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnOk.Location = new System.Drawing.Point(100, 399);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(40, 39);
            this._btnOk.TabIndex = 2;
            this._btnOk.UseVisualStyleBackColor = true;
            this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
            // 
            // BrowseFolders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOk);
            this.Controls.Add(this._tvDirectory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrowseFolders";
            this.Text = "Add Multiple Folders";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.BrowseFolders_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView _tvDirectory;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnOk;
    }
}