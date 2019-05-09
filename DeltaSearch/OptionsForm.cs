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
    public partial class OptionsForm : MetroForm
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {

        }

        private void _btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _btnClearPreferences_Click(object sender, EventArgs e)
        {
            try
            {
                //Delete prefs file, then load 'blank file' from all the tabs.
                string set = Globals.GetSettingsFilePath();
                System.IO.File.Delete(set);

                foreach(TabPage tp in Globals.MainForm.TabPages)
                {
                    foreach(Control c in tp.Controls)
                    {
                        if(c is SearchControl)
                        {
                            (c as SearchControl).ResetPrefs();
                            break;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Globals.LogError(ex.ToString());
            }

        }
    }
}
