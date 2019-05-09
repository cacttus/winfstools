using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeltaSearch
{
    public partial class MetroTextCombo : UserControl
    {
        public MetroTextCombo()
        {
            InitializeComponent();
        }

        public ComboBox.ObjectCollection Items { get { return _cboCombobox.Items; } }
        public override string Text { get { return _txtTextBox.Text; } set { _txtTextBox.Text = value; } }

        public void CacheSelectedValue()
        {
            string trimmed = _txtTextBox.Text.Trim();

            if (trimmed.Length > 0)
            {
                if (!_cboCombobox.Items.Contains(trimmed))
                {
                    _cboCombobox.Items.Add(trimmed);
                }
            }
        }

        private void _cboCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cboCombobox.SelectedIndex >= 0)
            {
                _txtTextBox.Text = _cboCombobox.Items[_cboCombobox.SelectedIndex].ToString();
            }
            else
            {
                _txtTextBox.Text = "";
            }
        }

        private void _txtTextBox_Click(object sender, EventArgs e)
        {

        }

        private void _txtTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
