using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace DeltaSearch
{
    public partial class About : MetroForm
    {
        public About()
        {
            InitializeComponent();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Text += Globals.ProgramName + "\r\n";
            textBox2.Text += "Author: " + Globals.ProgramAuthor + "\r\n";
            textBox2.Text += "Version: " + Assembly.GetExecutingAssembly().GetName().Version + "\r\n";
            textBox2.Text += "Build Date: " + Assembly.GetExecutingAssembly().GetLinkerTime() + "\r\n";
        }

        private void textbox2_Click(object sender, EventArgs e)
        {

        }
    }
}
