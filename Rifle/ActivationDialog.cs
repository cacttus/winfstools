using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rifle
{
    public partial class ActivationDialog : Form, IActivationForm
    {
        public bool ApplicationIsActivated = false;
        
        private Activator _objActivator;

        public ActivationDialog(Activator objActivator)
        {
            _objActivator = objActivator;
            InitializeComponent();
            this.CenterToScreen();
            _txtSerialNumber.Text = _objActivator.GetUserSerial();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.FulminationInteractive.com/rifle_automat");
        }
        private void _btnOk_Click(object sender, EventArgs e)
        {
            TryActivate();
        }
        private void _txtLicenseKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TryActivate();
            }
        }
        private void Activation_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitOrGoToApp();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ExitOrGoToApp();
        }


        private bool _blnIsClosed = false;
        private void ExitOrGoToApp()
        {
            
            if (!_objActivator.IsActivated || !_objActivator.IsValidated)
                Application.Exit();
            else if (!_blnIsClosed)
            {
                _blnIsClosed = true;//avoid recursively calling form_close
                Close();
            }
        }
        private void TryActivate()
        {
            if(!_objActivator.Activate( 
                _objActivator.ChunkedKeyToSerialKey(_txtSerialNumber.Text),
                _objActivator.ChunkedKeyToSerialKey(_txtLicenseKey.Text)
                ))
            {
               _lblActivationMessage.Show();
            }
            else
            {
               _lblActivationMessage.Show();
               _lblActivationMessage.ForeColor = Color.Green;
               _lblActivationMessage.Text = "Activation Successful.  Click Ok to continue.";
               _btnActivate.Hide();
            }
        }

        private void ActivationDialog_Load(object sender, EventArgs e)
        {

        }


    }
}
