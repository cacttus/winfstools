using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace DeltaSearch
{
    public partial class BrowseFolders : MetroForm
    {
        public BrowseFolders()
        {
            InitializeComponent();
        }

        private void BrowseFolders_Load(object sender, EventArgs e)
        {
            _tvDirectory.ImageList = new ImageList();
            Icon icon = NativeMethods.GetFolderIcon(NativeMethods.IconSize.Small, NativeMethods.FolderType.Closed);
            _tvDirectory.ImageList.Images.Add(icon);

            LoadFoldersInTreeView();
        }
        private void _tvDirectory_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node != null)
            {
                _tvDirectory.BeginUpdate();
                foreach(TreeNode sub in e.Node.Nodes)
                {
                    PeekNextLevel(sub);
                }
                _tvDirectory.EndUpdate();
            }
        }
        void LoadFoldersInTreeView()
        {
            _tvDirectory.BeginUpdate();
            _tvDirectory.Nodes.Add("My Computer");

            string[] drives = Environment.GetLogicalDrives();
            foreach(string drive in drives)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(drive);
                TreeNode node = MakeNode(dirInfo);
                PeekNextLevel(node);
                _tvDirectory.Nodes[0].Nodes.Add(node);
            }
            _tvDirectory.EndUpdate();
        }
        TreeNode MakeNode(DirectoryInfo inf)
        {
            TreeNode node = new TreeNode();
            node.Tag = inf.FullName;
            node.Text = inf.Name;
            try
            {
               // int imageIndex = 0;
                //Icon icon = Icon.ExtractAssociatedIcon(inf.FullName);
                //string hash = icon.GetHashCode().ToString();
                //if (!_tvDirectory.ImageList.Images.ContainsKey(hash))
                //{
                //    _tvDirectory.ImageList.Images.Add(hash, icon);
                //    imageIndex = _tvDirectory.ImageList.Images.Count;
                //}
                //else
                //{
                //    imageIndex = _tvDirectory.ImageList.Images.IndexOfKey(hash);
                //}
                node.ImageIndex = 0;
            }
            catch(Exception ex)
            {

            }
            return node;
        }
        void PeekNextLevel(TreeNode parent)
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo((string)parent.Tag);
                DirectoryInfo[] infs = d.GetDirectories();
                foreach (DirectoryInfo inf in infs)
                {
                    TreeNode node = MakeNode(inf);
                    parent.Nodes.Add(node);
                }
            }
            catch(Exception ex)
            {

            }
        }
        void GetFiles(DirectoryInfo d, TreeNode node)
        {
            FileInfo[] subfileInfo = d.GetFiles("*.*");
            if (subfileInfo.Length > 0)
            {
                for (int j = 0; j < subfileInfo.Length; j++)
                {
                    node.Nodes.Add(subfileInfo[j].Name);
                }
            }
        }
        private void _btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void _btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public List<string> GetFolders()
        {
            List<string> ret = new List<string>();
            GetFolders(_tvDirectory.Nodes[0], ret);
            return ret;
        }
        private void GetFolders(TreeNode parent, List<string> ret)
        {
            if (parent.Checked)
            {
                ret.Add((string)parent.Tag);
            }
            foreach (TreeNode n in parent.Nodes)
            {
                GetFolders(n, ret);
            }
        }

        private void _tvDirectory_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
