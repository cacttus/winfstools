using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using MetroFramework.Forms;

namespace DeltaSearch
{
    public partial class MainForm : MetroForm
    {
        public void SetStatus(string stat)
        {
            _lblStatus.Text = stat;
        }

        public TabControl.TabPageCollection TabPages { get {
                return _tabMainTabControl.TabPages;

            } }

        TabPage _tabAdd;
        public MainForm()
        {
            InitializeComponent();
            Globals.SetMainForm(this);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _tabAdd = new TabPage();
            _tabAdd.Text = "    +";

            _tabMainTabControl.TabPages.Add(_tabAdd);

            AddSearchTab();
        }

        void AddSearchTab()
        {
            TabPage tp = new TabPage();
            ContextMenu cm = new ContextMenu();
            MenuItem mi = new MenuItem("Close", (x, e) => {
                _tabMainTabControl.TabPages.Remove(tp);
            });
            cm.MenuItems.Add(mi);
            tp.ContextMenu = cm;

            _tabMainTabControl.TabPages.Remove(_tabAdd);
            {
                SearchControl sc = new SearchControl();
                sc.Dock = DockStyle.Fill;
                tp.Controls.Add(sc);
                tp.Text = "Search " + _tabMainTabControl.TabPages.Count + "      ";
                _tabMainTabControl.TabPages.Add(tp);
            }
            _tabMainTabControl.TabPages.Add(_tabAdd);

            //Rectangle rc = _tabMainTabControl.GetTabRect(_tabMainTabControl.TabPages.Count-1);
            //Button bt = new Button();
            //bt.SetBounds(50, 50, 40, 40);//, 12,12);
            //bt.BringToFront();
            //bt.BackColor = Color.Red;
            //bt.Text = "Hellos W";
            //bt.Visible = true;
            //tp.Controls.Add(bt);

            _tabMainTabControl.SelectedTab = tp;
        }
        private void _tabMainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_tabMainTabControl.SelectedTab == _tabAdd)
            {
                AddSearchTab();
            }
        }
        private void _btnSelectLanguage_Click(object sender, EventArgs e)
        {
            SelectLanguage x = new SelectLanguage();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {

            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void searchStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStats st = new SearchStats();
            string stat = "";
            TabPage t = _tabMainTabControl.SelectedTab;
            foreach(Control c in t.Controls)
            {
                if(c is SearchControl)
                {
                    SearchControl sc = c as SearchControl;
                    stat = sc.GetStats();
                    break;
                }
            }
            st.SetText(stat);
            st.ShowDialog();
        }

        //private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        //{

        //}

        //private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        //{

        //}

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void _tabAdd_Click(object sender, EventArgs e)
        {

        }

       // Rectangle closebutton = new Rectangle(-15, 4, 12, 12);

        //private void _tabMainTabControl_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    // thansk https://stackoverflow.com/questions/3183352/close-button-in-tabcontrol/36070187

        //    TabPage tab = _tabMainTabControl.TabPages[e.Index];
        //    if(tab == _tabAdd)
        //    {
        //        int pad = 3;
        //        int yadj = 3;
        //        int total_h = e.Bounds.Height - (pad*2);
        //        var bmp = new Bitmap(DeltaSearch.Properties.Resources.plus_image);
        //        e.Graphics.DrawImage(bmp, new Rectangle(
        //            e.Bounds.Left + e.Bounds.Width / 2 - total_h / 2,
        //            pad + yadj,
        //            total_h,
        //            total_h));
        //    }
        //    else
        //    {

        //        Rectangle imgRect = new Rectangle(e.Bounds.Right + closebutton.X,
        //            e.Bounds.Top + closebutton.Y,
        //            closebutton.Width,
        //            closebutton.Height);

        //        //Hover State - make butto niber
        //        if (imgRect.Contains(mouse))
        //        {
        //            int siz = 2;

        //            imgRect = new Rectangle(e.Bounds.Right + closebutton.X - siz,
        //                e.Bounds.Top + closebutton.Y - siz,
        //                closebutton.Width + siz,
        //                closebutton.Height + siz);
        //        }

        //        var bmp = new Bitmap(DeltaSearch.Properties.Resources.x_image);
        //        e.Graphics.DrawImage(bmp, imgRect);
        //        e.Graphics.DrawString(_tabMainTabControl.TabPages[e.Index].Text,
        //            e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
        //    }

        //    e.DrawFocusRectangle();
        //}

        //private void _tabMainTabControl_MouseDown(object sender, MouseEventArgs e)
        //{
        //    // thansk https://stackoverflow.com/questions/3183352/close-button-in-tabcontrol/36070187
        //    //Looping through the controls.
        //    for (int i = 0; i < _tabMainTabControl.TabPages.Count; i++)
        //    {
        //        Rectangle r = _tabMainTabControl.GetTabRect(i);
        //        //Getting the position of the "x" mark.
        //        Rectangle closeButton = new Rectangle(r.X + closebutton.X, 
        //            r.Y + closebutton.Y, 
        //            closebutton.Width, 
        //            closebutton.Height);
        //        if (closeButton.Contains(e.Location))
        //        {
        //            if (MessageBox.Show("Close Tab?", "Confirm", 
        //                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //            {
        //                _tabMainTabControl.TabPages.RemoveAt(i);
        //                break;
        //            }
        //        }
        //    }

        //}
        Point mouse;
        private void _tabMainTabControl_MouseMove(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void _tabMainTabControl_MouseClick(object sender, MouseEventArgs e)
        {

            for (int i = 0; i < _tabMainTabControl.TabPages.Count; i++)
            {
                Rectangle r = _tabMainTabControl.GetTabRect(i);

                if (r.Contains(e.Location))
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        TabPage tp = _tabMainTabControl.TabPages[i];
                        
                        if(tp.Visible == true)
                        {
                            if (tp.ContextMenu != null)
                            {
                                tp.ContextMenu.Show(tp,new Point(e.Location.X, e.Location.Y - r.Height));
                            }
                        }

                    }

                }
            }

        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm f = new OptionsForm();
            f.ShowDialog();
        }
    }
}
