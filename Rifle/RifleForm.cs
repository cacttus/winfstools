using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rifle
{
    public class RifleForm : Form
    {
        private Dictionary<Control, ToolTip> _objTooltips = new Dictionary<Control, ToolTip>();
        private RifleManager _objRifleManager;
        protected RifleManager GetManager(){ return _objRifleManager; }

        public RifleForm() {  }// ** For designer only, do not call

        public RifleForm(RifleManager objManager)
        {
            _objRifleManager = objManager;
        }

        protected virtual void SetAllTooltips() { }

        protected virtual void LoadingDisableInput() { }
        protected virtual void LoadingEnableInput() { }

        private string FormatTooltipText(string text, int lineChars = 60)
        {
            string ret;
            string tmpLine;
            List<string> words;

            ret = string.Empty;
            tmpLine = string.Empty;
            words = text.Split(' ').ToList();

            while (words.Count > 0)
            {
                tmpLine += words[0] + " ";
                words.RemoveAt(0);
                if (tmpLine.Length >= lineChars)
                {
                    ret += tmpLine;
                    ret += Environment.NewLine;
                    tmpLine = string.Empty;
                }
            }
            ret += tmpLine;

            ret = ret.Trim();

            return ret;
        }
        protected void SetTooltip(List<System.Windows.Forms.Control> aobjControls, string strText)
        {
            foreach (System.Windows.Forms.Control cont in aobjControls)
                SetTooltip(cont, strText);
        }
        protected void SetTooltip(System.Windows.Forms.Control aobjControl, string strText)
        {
            strText = FormatTooltipText(strText);

            ToolTip outValue;
            if (!_objTooltips.TryGetValue(aobjControl, out outValue))
            {
                outValue = new ToolTip();
                _objTooltips.Add(aobjControl, outValue);
            }

            outValue.AutoPopDelay = 30000;
            outValue.InitialDelay = 100;
            outValue.ReshowDelay = 500;
            outValue.ShowAlways = false;
            outValue.SetToolTip(aobjControl, strText);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // RifleForm
            // 
            this.ClientSize = new System.Drawing.Size(271, 237);
            this.Name = "RifleForm";
            this.Load += new System.EventHandler(this.RifleForm_Load);
            this.ResumeLayout(false);

        }

        private void RifleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
