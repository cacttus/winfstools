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
    public partial class FileFilterForm : RifleForm
    {
        public FileFilterForm(RifleManager objManager) : base(objManager)
        {
            InitializeComponent();
        }
        protected override void SetAllTooltips() 
        {
        }
        protected override void LoadingDisableInput()
        {
        }
        protected override void LoadingEnableInput()
        {
        }
        private void FileFilter_Load(object sender, EventArgs e)
        {
        }
        private void _nudMinWidth_ValueChanged(object sender, EventArgs e)
        {

        }
        private void FileFilterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
              this.Hide();
              e.Cancel = true; // this cancels the close event.
        }

        private void _btnManageFileTypes_Click(object sender, EventArgs e)
        {
            GetManager().FileTypeManagerForm.ShowDialog();
        }
    }
}
