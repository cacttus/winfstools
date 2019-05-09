namespace Rifle
{
    partial class FileTypeManagerForm
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
            this._btnVideos = new System.Windows.Forms.Button();
            this._btnImages = new System.Windows.Forms.Button();
            this._btnRemove = new System.Windows.Forms.Button();
            this._btnAdd = new System.Windows.Forms.Button();
            this._txtAddExtension = new System.Windows.Forms.TextBox();
            this._lstFileTypes = new System.Windows.Forms.ListBox();
            this._lblFileTypes = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnVideos
            // 
            this._btnVideos.Location = new System.Drawing.Point(120, 63);
            this._btnVideos.Name = "_btnVideos";
            this._btnVideos.Size = new System.Drawing.Size(51, 24);
            this._btnVideos.TabIndex = 23;
            this._btnVideos.Text = "Videos";
            this._btnVideos.UseVisualStyleBackColor = true;
            this._btnVideos.Click += new System.EventHandler(this._btnVideos_Click);
            // 
            // _btnImages
            // 
            this._btnImages.Location = new System.Drawing.Point(120, 33);
            this._btnImages.Name = "_btnImages";
            this._btnImages.Size = new System.Drawing.Size(51, 24);
            this._btnImages.TabIndex = 22;
            this._btnImages.Text = "Images";
            this._btnImages.UseVisualStyleBackColor = true;
            this._btnImages.Click += new System.EventHandler(this._btnImages_Click);
            // 
            // _btnRemove
            // 
            this._btnRemove.Location = new System.Drawing.Point(57, 150);
            this._btnRemove.Name = "_btnRemove";
            this._btnRemove.Size = new System.Drawing.Size(44, 25);
            this._btnRemove.TabIndex = 21;
            this._btnRemove.Text = "-";
            this._btnRemove.UseVisualStyleBackColor = true;
            this._btnRemove.Click += new System.EventHandler(this._btnRemove_Click);
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(12, 150);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(39, 25);
            this._btnAdd.TabIndex = 20;
            this._btnAdd.Text = "+";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _txtAddExtension
            // 
            this._txtAddExtension.Location = new System.Drawing.Point(12, 124);
            this._txtAddExtension.Name = "_txtAddExtension";
            this._txtAddExtension.Size = new System.Drawing.Size(89, 20);
            this._txtAddExtension.TabIndex = 19;
            // 
            // _lstFileTypes
            // 
            this._lstFileTypes.FormattingEnabled = true;
            this._lstFileTypes.Items.AddRange(new object[] {
            "jpg",
            "png",
            "tiff",
            "tga",
            "bmp"});
            this._lstFileTypes.Location = new System.Drawing.Point(12, 33);
            this._lstFileTypes.Name = "_lstFileTypes";
            this._lstFileTypes.Size = new System.Drawing.Size(89, 82);
            this._lstFileTypes.TabIndex = 17;
            // 
            // _lblFileTypes
            // 
            this._lblFileTypes.AutoSize = true;
            this._lblFileTypes.Location = new System.Drawing.Point(12, 13);
            this._lblFileTypes.Name = "_lblFileTypes";
            this._lblFileTypes.Size = new System.Drawing.Size(55, 13);
            this._lblFileTypes.TabIndex = 18;
            this._lblFileTypes.Text = "File Types";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(15, 210);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 24;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(136, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FileTypeManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 253);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this._btnVideos);
            this.Controls.Add(this._btnImages);
            this.Controls.Add(this._btnRemove);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._txtAddExtension);
            this.Controls.Add(this._lstFileTypes);
            this.Controls.Add(this._lblFileTypes);
            this.Name = "FileTypeManagerForm";
            this.Text = "FileTypeManagerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnVideos;
        private System.Windows.Forms.Button _btnImages;
        private System.Windows.Forms.Button _btnRemove;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.TextBox _txtAddExtension;
        private System.Windows.Forms.ListBox _lstFileTypes;
        private System.Windows.Forms.Label _lblFileTypes;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}