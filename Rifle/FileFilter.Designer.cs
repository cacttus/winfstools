namespace Rifle
{
    partial class FileFilterForm
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
            this._btnManageFileTypes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._nudMinHeight = new System.Windows.Forms.NumericUpDown();
            this._nudMaxHeight = new System.Windows.Forms.NumericUpDown();
            this._nudMaxWidth = new System.Windows.Forms.NumericUpDown();
            this._nudMinWidth = new System.Windows.Forms.NumericUpDown();
            this._lblMinWidth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._chkMaxWidth = new System.Windows.Forms.CheckBox();
            this._chkMaxHeight = new System.Windows.Forms.CheckBox();
            this._chkMinHeight = new System.Windows.Forms.CheckBox();
            this._chkMinWidth = new System.Windows.Forms.CheckBox();
            this._cboFileType = new System.Windows.Forms.ComboBox();
            this._grpFileActions = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._optMoveFile = new System.Windows.Forms.RadioButton();
            this._optSkipFile = new System.Windows.Forms.RadioButton();
            this._optDeleteFile = new System.Windows.Forms.RadioButton();
            this._btnFilter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudMinHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudMaxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudMaxWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudMinWidth)).BeginInit();
            this._grpFileActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnManageFileTypes
            // 
            this._btnManageFileTypes.Location = new System.Drawing.Point(191, 36);
            this._btnManageFileTypes.Name = "_btnManageFileTypes";
            this._btnManageFileTypes.Size = new System.Drawing.Size(105, 23);
            this._btnManageFileTypes.TabIndex = 11;
            this._btnManageFileTypes.Text = "Manage File Types";
            this._btnManageFileTypes.UseVisualStyleBackColor = true;
            this._btnManageFileTypes.Click += new System.EventHandler(this._btnManageFileTypes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "For the following file type...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._nudMinHeight);
            this.groupBox1.Controls.Add(this._nudMaxHeight);
            this.groupBox1.Controls.Add(this._nudMaxWidth);
            this.groupBox1.Controls.Add(this._nudMinWidth);
            this.groupBox1.Controls.Add(this._lblMinWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this._chkMaxWidth);
            this.groupBox1.Controls.Add(this._chkMaxHeight);
            this.groupBox1.Controls.Add(this._chkMinHeight);
            this.groupBox1.Controls.Add(this._chkMinWidth);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 147);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by the following criteria...";
            // 
            // _nudMinHeight
            // 
            this._nudMinHeight.Location = new System.Drawing.Point(181, 51);
            this._nudMinHeight.Name = "_nudMinHeight";
            this._nudMinHeight.Size = new System.Drawing.Size(76, 20);
            this._nudMinHeight.TabIndex = 6;
            // 
            // _nudMaxHeight
            // 
            this._nudMaxHeight.Location = new System.Drawing.Point(181, 110);
            this._nudMaxHeight.Name = "_nudMaxHeight";
            this._nudMaxHeight.Size = new System.Drawing.Size(76, 20);
            this._nudMaxHeight.TabIndex = 6;
            this._nudMaxHeight.ValueChanged += new System.EventHandler(this._nudMinWidth_ValueChanged);
            // 
            // _nudMaxWidth
            // 
            this._nudMaxWidth.Location = new System.Drawing.Point(38, 110);
            this._nudMaxWidth.Name = "_nudMaxWidth";
            this._nudMaxWidth.Size = new System.Drawing.Size(76, 20);
            this._nudMaxWidth.TabIndex = 6;
            this._nudMaxWidth.ValueChanged += new System.EventHandler(this._nudMinWidth_ValueChanged);
            // 
            // _nudMinWidth
            // 
            this._nudMinWidth.Location = new System.Drawing.Point(38, 53);
            this._nudMinWidth.Name = "_nudMinWidth";
            this._nudMinWidth.Size = new System.Drawing.Size(76, 20);
            this._nudMinWidth.TabIndex = 6;
            this._nudMinWidth.ValueChanged += new System.EventHandler(this._nudMinWidth_ValueChanged);
            // 
            // _lblMinWidth
            // 
            this._lblMinWidth.AutoSize = true;
            this._lblMinWidth.Location = new System.Drawing.Point(35, 36);
            this._lblMinWidth.Name = "_lblMinWidth";
            this._lblMinWidth.Size = new System.Drawing.Size(79, 13);
            this._lblMinWidth.TabIndex = 1;
            this._lblMinWidth.Text = "Minimum Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maximum Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minimum Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maximum Height";
            // 
            // _chkMaxWidth
            // 
            this._chkMaxWidth.AutoSize = true;
            this._chkMaxWidth.Location = new System.Drawing.Point(13, 110);
            this._chkMaxWidth.Name = "_chkMaxWidth";
            this._chkMaxWidth.Size = new System.Drawing.Size(15, 14);
            this._chkMaxWidth.TabIndex = 5;
            this._chkMaxWidth.UseVisualStyleBackColor = true;
            // 
            // _chkMaxHeight
            // 
            this._chkMaxHeight.AutoSize = true;
            this._chkMaxHeight.Location = new System.Drawing.Point(160, 110);
            this._chkMaxHeight.Name = "_chkMaxHeight";
            this._chkMaxHeight.Size = new System.Drawing.Size(15, 14);
            this._chkMaxHeight.TabIndex = 5;
            this._chkMaxHeight.UseVisualStyleBackColor = true;
            // 
            // _chkMinHeight
            // 
            this._chkMinHeight.AutoSize = true;
            this._chkMinHeight.Location = new System.Drawing.Point(160, 53);
            this._chkMinHeight.Name = "_chkMinHeight";
            this._chkMinHeight.Size = new System.Drawing.Size(15, 14);
            this._chkMinHeight.TabIndex = 5;
            this._chkMinHeight.UseVisualStyleBackColor = true;
            // 
            // _chkMinWidth
            // 
            this._chkMinWidth.AutoSize = true;
            this._chkMinWidth.Location = new System.Drawing.Point(13, 53);
            this._chkMinWidth.Name = "_chkMinWidth";
            this._chkMinWidth.Size = new System.Drawing.Size(15, 14);
            this._chkMinWidth.TabIndex = 5;
            this._chkMinWidth.UseVisualStyleBackColor = true;
            // 
            // _cboFileType
            // 
            this._cboFileType.FormattingEnabled = true;
            this._cboFileType.Location = new System.Drawing.Point(35, 38);
            this._cboFileType.Name = "_cboFileType";
            this._cboFileType.Size = new System.Drawing.Size(128, 21);
            this._cboFileType.TabIndex = 8;
            // 
            // _grpFileActions
            // 
            this._grpFileActions.Controls.Add(this.button1);
            this._grpFileActions.Controls.Add(this.textBox1);
            this._grpFileActions.Controls.Add(this._optMoveFile);
            this._grpFileActions.Controls.Add(this._optSkipFile);
            this._grpFileActions.Controls.Add(this._optDeleteFile);
            this._grpFileActions.Location = new System.Drawing.Point(15, 261);
            this._grpFileActions.Name = "_grpFileActions";
            this._grpFileActions.Size = new System.Drawing.Size(295, 146);
            this._grpFileActions.TabIndex = 7;
            this._grpFileActions.TabStop = false;
            this._grpFileActions.Text = "When a file does not meet the criteria...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 3;
            // 
            // _optMoveFile
            // 
            this._optMoveFile.AutoSize = true;
            this._optMoveFile.Location = new System.Drawing.Point(7, 68);
            this._optMoveFile.Name = "_optMoveFile";
            this._optMoveFile.Size = new System.Drawing.Size(119, 17);
            this._optMoveFile.TabIndex = 2;
            this._optMoveFile.TabStop = true;
            this._optMoveFile.Text = "Move File To Folder";
            this._optMoveFile.UseVisualStyleBackColor = true;
            // 
            // _optSkipFile
            // 
            this._optSkipFile.AutoSize = true;
            this._optSkipFile.Location = new System.Drawing.Point(7, 22);
            this._optSkipFile.Name = "_optSkipFile";
            this._optSkipFile.Size = new System.Drawing.Size(65, 17);
            this._optSkipFile.TabIndex = 1;
            this._optSkipFile.TabStop = true;
            this._optSkipFile.Text = "Skip File";
            this._optSkipFile.UseVisualStyleBackColor = true;
            // 
            // _optDeleteFile
            // 
            this._optDeleteFile.AutoSize = true;
            this._optDeleteFile.Location = new System.Drawing.Point(7, 45);
            this._optDeleteFile.Name = "_optDeleteFile";
            this._optDeleteFile.Size = new System.Drawing.Size(75, 17);
            this._optDeleteFile.TabIndex = 0;
            this._optDeleteFile.TabStop = true;
            this._optDeleteFile.Text = "Delete File";
            this._optDeleteFile.UseVisualStyleBackColor = true;
            // 
            // _btnFilter
            // 
            this._btnFilter.Location = new System.Drawing.Point(113, 413);
            this._btnFilter.Name = "_btnFilter";
            this._btnFilter.Size = new System.Drawing.Size(89, 33);
            this._btnFilter.TabIndex = 0;
            this._btnFilter.Text = "Filter";
            this._btnFilter.UseVisualStyleBackColor = true;
            // 
            // FileFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 466);
            this.Controls.Add(this._btnManageFileTypes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._cboFileType);
            this.Controls.Add(this._grpFileActions);
            this.Controls.Add(this._btnFilter);
            this.Name = "FileFilterForm";
            this.Text = "FileFilter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileFilterForm_FormClosing);
            this.Load += new System.EventHandler(this.FileFilter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudMinHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudMaxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudMaxWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudMinWidth)).EndInit();
            this._grpFileActions.ResumeLayout(false);
            this._grpFileActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnFilter;
        private System.Windows.Forms.Label _lblMinWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox _chkMinWidth;
        private System.Windows.Forms.CheckBox _chkMaxWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox _grpFileActions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton _optMoveFile;
        private System.Windows.Forms.RadioButton _optSkipFile;
        private System.Windows.Forms.RadioButton _optDeleteFile;
        private System.Windows.Forms.CheckBox _chkMinHeight;
        private System.Windows.Forms.CheckBox _chkMaxHeight;
        private System.Windows.Forms.ComboBox _cboFileType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown _nudMinHeight;
        private System.Windows.Forms.NumericUpDown _nudMinWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnManageFileTypes;
        private System.Windows.Forms.NumericUpDown _nudMaxHeight;
        private System.Windows.Forms.NumericUpDown _nudMaxWidth;
    }
}