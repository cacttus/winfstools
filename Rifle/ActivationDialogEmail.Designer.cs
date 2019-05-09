namespace Rifle
{
    partial class ActivationDialogEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivationDialogEmail));
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this._btnActivate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._txtLicenseKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._txtSerialNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._btnOkExit = new System.Windows.Forms.Button();
            this._lblActivationMessage = new System.Windows.Forms.Label();
            this._lblErrors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "If you purchased a copy of Rifle and have not\r\n received a serial number please c" +
    "ontact support at";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(62, 298);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(227, 16);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Support@FulminationInteractive.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "To purchase a full copy of Rifle please click the link below";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(123, 344);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(127, 16);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Purchase A License";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // _btnActivate
            // 
            this._btnActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnActivate.Location = new System.Drawing.Point(142, 163);
            this._btnActivate.Name = "_btnActivate";
            this._btnActivate.Size = new System.Drawing.Size(75, 25);
            this._btnActivate.TabIndex = 5;
            this._btnActivate.Text = "Activate";
            this._btnActivate.UseVisualStyleBackColor = true;
            this._btnActivate.Click += new System.EventHandler(this._btnOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Please enter your email address and \r\nserial number in the boxes below and click " +
    "\'Activate\'.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _txtLicenseKey
            // 
            this._txtLicenseKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtLicenseKey.Location = new System.Drawing.Point(63, 135);
            this._txtLicenseKey.Name = "_txtLicenseKey";
            this._txtLicenseKey.Size = new System.Drawing.Size(262, 20);
            this._txtLicenseKey.TabIndex = 6;
            this._txtLicenseKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtLicenseKey_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Serial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(138, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Activation";
            // 
            // _txtSerialNumber
            // 
            this._txtSerialNumber.Location = new System.Drawing.Point(63, 109);
            this._txtSerialNumber.Name = "_txtSerialNumber";
            this._txtSerialNumber.Size = new System.Drawing.Size(262, 20);
            this._txtSerialNumber.TabIndex = 8;
            this._txtSerialNumber.TextChanged += new System.EventHandler(this._txtSerialNumber_TextChanged);
            this._txtSerialNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtLicenseKey_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email:";
            // 
            // _btnOkExit
            // 
            this._btnOkExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnOkExit.Location = new System.Drawing.Point(149, 366);
            this._btnOkExit.Name = "_btnOkExit";
            this._btnOkExit.Size = new System.Drawing.Size(75, 23);
            this._btnOkExit.TabIndex = 10;
            this._btnOkExit.Text = "Ok";
            this._btnOkExit.UseVisualStyleBackColor = true;
            this._btnOkExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // _lblActivationMessage
            // 
            this._lblActivationMessage.AutoSize = true;
            this._lblActivationMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblActivationMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(6)))), ((int)(((byte)(3)))));
            this._lblActivationMessage.Location = new System.Drawing.Point(1, 200);
            this._lblActivationMessage.Name = "_lblActivationMessage";
            this._lblActivationMessage.Size = new System.Drawing.Size(366, 36);
            this._lblActivationMessage.TabIndex = 11;
            this._lblActivationMessage.Text = "Activation Failed.  Please check your email address\r\nand serial number and and tr" +
    "y again.";
            this._lblActivationMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lblActivationMessage.Visible = false;
            // 
            // _lblErrors
            // 
            this._lblErrors.AutoSize = true;
            this._lblErrors.ForeColor = System.Drawing.Color.Red;
            this._lblErrors.Location = new System.Drawing.Point(308, 377);
            this._lblErrors.Name = "_lblErrors";
            this._lblErrors.Size = new System.Drawing.Size(34, 13);
            this._lblErrors.TabIndex = 12;
            this._lblErrors.Text = "Errors";
            this._lblErrors.Visible = false;
            // 
            // ActivationDialogEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 402);
            this.Controls.Add(this._lblErrors);
            this.Controls.Add(this._lblActivationMessage);
            this.Controls.Add(this._btnOkExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtSerialNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtLicenseKey);
            this.Controls.Add(this._btnActivate);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActivationDialogEmail";
            this.Text = "Rifle - Activation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Activation_FormClosing);
            this.Load += new System.EventHandler(this.ActivationDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button _btnActivate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtLicenseKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtSerialNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnOkExit;
        private System.Windows.Forms.Label _lblActivationMessage;
        private System.Windows.Forms.Label _lblErrors;
        //private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
       // private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}