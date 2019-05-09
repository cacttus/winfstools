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
    public partial class FileTypeManagerForm : RifleForm
    {
        public FileTypeManagerForm(RifleManager objManager) : base(objManager)
        {
            InitializeComponent();
            SetFileTypesSel();
        }

        protected override void LoadingDisableInput()
        {
        }
        protected override void LoadingEnableInput()
        {
        }
        protected override void SetAllTooltips()
        {
            SetTooltip(_btnAdd, "Add a file type to the list.");
            SetTooltip(_btnRemove, "Remove the selected file type from the list.");
            SetTooltip(new List<Control> { _lstFileTypes, _lblFileTypes },
                "File types to cycle through.  Add new file types by typing into the text box below and clicking '+'.");
        }


        public List<string> GetFileTypes()
        {
            List<string> lstReturn = new List<string>();

            foreach (string str in _lstFileTypes.Items)
                lstReturn.Add(str);
            return lstReturn;
        }

        private void SetFileTypesSel()
        {
            if (_lstFileTypes.Items.Count > 0)
                _lstFileTypes.SelectedIndex = 0;
        }


        private void _btnImages_Click(object sender, EventArgs e)
        {
            _lstFileTypes.Items.Clear();
            _lstFileTypes.Items.Add("jpg");
            _lstFileTypes.Items.Add("png");
            _lstFileTypes.Items.Add("tga");
            _lstFileTypes.Items.Add("tiff");
            _lstFileTypes.Items.Add("bmp");
            GetManager().FileCache.Reload();
        }
        private void _btnVideos_Click(object sender, EventArgs e)
        {
            _lstFileTypes.Items.Clear();
            _lstFileTypes.Items.Add("avi");
            _lstFileTypes.Items.Add("gif");
            _lstFileTypes.Items.Add("mp4");
            _lstFileTypes.Items.Add("webm");
            _lstFileTypes.Items.Add("wmv");
            GetManager().FileCache.Reload();
        }
        private void _btnAdd_Click(object sender, EventArgs e)
        {
            string strValue = _txtAddExtension.Text.Trim();
            if (strValue != string.Empty)
            {
                //Remove . from ext
                if (strValue[0] == '.')
                    strValue = strValue.Substring(1);

                _lstFileTypes.Items.Add(strValue);
                GetManager().FileCache.Reload();
            }
            _txtAddExtension.Text = "";
            SetFileTypesSel();
        }
        private void _btnRemove_Click(object sender, EventArgs e)
        {
            if (_lstFileTypes.SelectedIndex != -1)
            {
                _lstFileTypes.Items.Remove(_lstFileTypes.Items[_lstFileTypes.SelectedIndex]);
                GetManager().FileCache.Reload();
            }
            SetFileTypesSel();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Hide();
        }




    }
}
