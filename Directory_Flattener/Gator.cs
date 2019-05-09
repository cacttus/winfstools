using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flattenator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private string GetGatorRoot() {
            return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        }
        private void Flatten_r(string rootDir, ref int globalIndex, ref int moveCount)
        {
            try
            {
                string curDir = System.IO.Directory.GetCurrentDirectory();
                List<string> files = System.IO.Directory.GetFiles(curDir).ToList();

                ;
                if(_optAllFiles.Checked == true) {
                }
                else {
                      List<string> filtered = files.Where(x =>
                        System.IO.Path.GetExtension(x).Length > 0 ?
                        _lstFileTypes.Items.Contains(
                            System.IO.Path.GetExtension(x)
                        ) : false
                    ).ToList();
                    files = filtered;
                }
                //lstFiles.AddRange(filtered);

                //Too intense - causes problems
                if (!System.IO.Path.Equals(curDir, rootDir) ||
                    _chkSearchRoot.Checked)
                {
                    foreach (string oldFileName in files)
                    {
                        string strFn = System.IO.Path.GetFileName(oldFileName);
                        if (rootDir[rootDir.Length - 1] == '/' || rootDir[rootDir.Length - 1] == '\\')
                            rootDir = rootDir.Substring(0, rootDir.Length - 2);

                        string newPath = System.IO.Path.Combine(rootDir, strFn);
                        try
                        {
                            //Rename file. Loop until we can rename it.
                            if(System.IO.File.Exists(newPath) || _optIndexOnly.Checked || _optFolderFileIndex.Checked)
                            {
                                do
                                {
                                    //string newFn = System.IO.Path.GetFileName(newPath);
                                    string newFnName = "";
                                    if(_optFolderFileIndex.Checked)
                                    {
                                        int a = curDir.LastIndexOf('\\');
                                        int b = curDir.LastIndexOf('/');
                                        int c = a > b ? a : b;
                                        c += 1;

                                        if (c > 0)
                                        {
                                            string tempDir = curDir.Substring(c, curDir.Length - c);
                                            newFnName += tempDir + "_";
                                        }
                                    }

                                    if (_optIndexOnly.Checked)
                                    {
                                        newFnName += globalIndex.ToString();
                                        newFnName += System.IO.Path.GetExtension(newPath);
                                    }
                                    else
                                    {
                                        newFnName += System.IO.Path.GetFileNameWithoutExtension(newPath);
                                        newFnName += "_" + globalIndex.ToString();
                                        newFnName += System.IO.Path.GetExtension(newPath);
                                    }
                                    string newPathName = System.IO.Path.GetDirectoryName(newPath);
                                    newPath = System.IO.Path.Combine(newPathName, newFnName);

                                    globalIndex++;
                                    if (globalIndex > 2000000000)
                                        throw new Exception("Tried to rename file but FAILED MISERABLY.");
                                }
                                while (System.IO.File.Exists(newPath));
                            }

                            System.IO.File.Copy(oldFileName, newPath);

                            moveCount++;
                            _lblRenameCount.Text = moveCount.ToString();

                        }
                        catch (Exception ex)
                        {
                            _txtOutput.Text += ex.ToString() + "\r\n";

                        }

                        if (_chkDeleteFiles.Checked)
                        {
                            try
                            {
                                System.IO.File.Delete(oldFileName);
                            }
                            catch (Exception ex)
                            {
                                _txtOutput.Text += ex.ToString() + "\r\n";
                            }
                        }

                    }
                }


                string[] dirs = System.IO.Directory.GetDirectories(curDir);
                foreach (string childDir in dirs)
                {
                    System.IO.Directory.SetCurrentDirectory(childDir);

                    Flatten_r(rootDir, ref globalIndex, ref moveCount);

                    System.IO.Directory.SetCurrentDirectory(curDir);


                    if (_chkDeleteEmptyFolders.Checked)
                    {
                        files = System.IO.Directory.GetFiles(childDir).ToList();
                        if (files.Count == 0)
                        {
                            System.IO.Directory.Delete(childDir);
                        }
                    }

                }
                
            }
            catch (Exception ex)
            {
                _txtOutput.Text += ex.ToString() + "\r\n";
                
            }
        }
        bool bShownMessage = false;
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Gator is about to flatten ALL files in '" + GetGatorRoot() +
                "' Are you SURE Gator.exe is located IN the directory you wish to flatten?", "WARNING", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if(dr == DialogResult.Yes) {
                bShownMessage = true;
                string dir = GetGatorRoot();
                int globalId = 0;
                int moveCount = 0;
                Flatten_r(GetGatorRoot(), ref globalId, ref moveCount);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            _lstFileTypes.Items.Clear();
            _lstFileTypes.Items.Add(".cpp");
            _lstFileTypes.Items.Add(".c");
            _lstFileTypes.Items.Add(".cxx");
            _lstFileTypes.Items.Add(".h");
            _lstFileTypes.Items.Add(".hpp");
            _lstFileTypes.Items.Add(".hxx");
            _lstFileTypes.Items.Add(".js");
            _lstFileTypes.Items.Add(".jsp");
            _lstFileTypes.Items.Add(".ear");
            _lstFileTypes.Items.Add(".jar");
            _lstFileTypes.Items.Add(".cs");
            _lstFileTypes.Items.Add(".vb");
            _lstFileTypes.Items.Add(".py");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _lstFileTypes.Items.Clear();
            _lstFileTypes.Items.Add(".jpg");
            _lstFileTypes.Items.Add(".png");
            _lstFileTypes.Items.Add(".bmp");
            _lstFileTypes.Items.Add(".jpeg");
            _lstFileTypes.Items.Add(".tiff");
            _lstFileTypes.Items.Add(".tga");
            _lstFileTypes.Items.Add(".targa");
            _lstFileTypes.Items.Add(".png");
            _lstFileTypes.Items.Add(".gif");
        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            AddFileType();

        }

        private void _btnRemove_Click(object sender, EventArgs e)
        {
            if(_lstFileTypes.SelectedIndex >=0 ) {
            _lstFileTypes.Items.Remove(_lstFileTypes.SelectedIndex);
            }
        }

        private void _lstFileTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _optCustom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void _optVideoFiles_CheckedChanged(object sender, EventArgs e)
        {
            _lstFileTypes.Items.Clear();
            _lstFileTypes.Items.Add(".wmv");
            _lstFileTypes.Items.Add(".avi");
            _lstFileTypes.Items.Add(".mpeg");
            _lstFileTypes.Items.Add(".mpeg4");
            _lstFileTypes.Items.Add(".webm");

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void _chkDeleteEmptyFolders_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Gator.Help hh = new Gator.Help();
            hh.Show();
            
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gator.License lc = new Gator.License();
            lc.ShowDialog();
        }

        private void _chkSearchRoot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void _optAllFiles_CheckedChanged(object sender, EventArgs e)
        {
            _lstFileTypes.Items.Clear();
            _lstFileTypes.Items.Add("*ALL");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gator.About ab = new Gator.About();
            ab.ShowDialog();
        }

        private void _txtFileTypeToAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) {
                AddFileType();
            }
        }
        void AddFileType() {
            if(!_lstFileTypes.Items.Contains(_txtFileTypeToAdd.Text)) {
                if(_txtFileTypeToAdd.Text.StartsWith(".")) {
                    _lstFileTypes.Items.Add(_txtFileTypeToAdd.Text);
                    _txtFileTypeToAdd.Text = "";
                }
                else {
                    MessageBox.Show("File extension must begin with a dot '.'");
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) {
                Close();
            }
        }
    }
}
