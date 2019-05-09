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
    public partial class SearchStats : MetroForm
    {
        public SearchStats()
        {
            InitializeComponent();
        }

        private void SearchStats_Load(object sender, EventArgs e)
        {

        }
        public void SetText(string txt)
        {
            _txtStats.Text = txt;
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
