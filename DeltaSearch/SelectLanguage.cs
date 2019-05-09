using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace DeltaSearch
{
    public partial class SelectLanguage : MetroForm
    {
        public SelectLanguage()
        {
            InitializeComponent();
        }

        private void SelectLanguage_Load(object sender, EventArgs e)
        {
            _lvLanguage.Items.Add(new ListViewItem());
        }

        private void _lvLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        public DialogResult DialogResult = DialogResult.Cancel;

        private void _btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
