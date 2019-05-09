using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing;

namespace DirPoll
{
    public enum FsItemState
    {
        None,
        Changed,
        Removed,
        Added,
        FolderContentsChanged
    }
    public enum FsItemType
    {
        Folder, File, Root
    }
    public enum PrintMode
    {
        Normal,
        TreeString
    }

    public class Settings
    {
        [JsonIgnore]
        public string SettingsFileLocation = "";

        [JsonProperty]
        public string Version = "0.02";
        [JsonProperty]
        public List<string> PollDirs = new List<string>() { "./" };
        [JsonProperty]
        public int PollInterval = 100;
        [JsonProperty]
        public string ShellCommand = "";
        [JsonProperty]
        public bool PollFiles = true;
        [JsonProperty]
        public bool PollDirectories = true;
        [JsonProperty]
        public int ConsoleFontSize = 8;
        [JsonProperty]
        public int TabSize = 6;
        [JsonProperty]
        public bool ShowLongBranches = true;
        [JsonProperty]
        public int NumTopFiles = 5;

        [JsonProperty]
        public string FileNameRegEx = ".*";
        [JsonProperty]
        public string FoldeNameRegEx = ".*";

        [JsonProperty]
        public bool ShowAddedFiles = true;
        [JsonProperty]
        public bool ShowChangedFiles = true;
        [JsonProperty]
        public bool ShowDeletedFiles = true;

        [JsonProperty]
        public bool ShowAddedFolders = true;
        [JsonProperty]
        public bool ShowChangedFolders = true;
        [JsonProperty]
        public bool ShowDeletedFolders = true;

        [JsonProperty]
        public bool ShowStatusBar = false;

        public void SetDefault()
        {
            //PollDirs
        }

        public static bool SaveJson(string loc)
        {
            try
            {
                string output = JsonConvert.SerializeObject(Globals.Settings);
                System.IO.File.WriteAllText(loc, output);

                Globals.Settings.SettingsFileLocation = loc;
                return true;
            }
            catch (Exception ex)
            {
                Globals.LogError("Failed to save XML File: " + ex.ToString());
            }
            return false;
        }
        public static bool LoadJson(string loc)
        {
            try
            {
                string text = System.IO.File.ReadAllText(loc);
                Globals.Settings = JsonConvert.DeserializeObject<Settings>(text);

                Globals.Settings.SettingsFileLocation = loc;
                return true;
            }
            catch (Exception ex)
            {
                Globals.LogError("Failed to save XML File: " + ex.ToString());
            }
            return false;
        }
    }

    public class PrintSettings
    {
        public bool OmitUnchanged = false;
        public int TabSize = 6;
        public StringBuilder StringBuilder = new StringBuilder();
        public PrintSettings()
        {
            StringBuilder.Append(Environment.NewLine);
            TabSize = Globals.Settings.TabSize;
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
    public class FsItem
    {
        public DateTime LastModifyTime { get; set; }
        public DateTime? NewModifyTime { get; set; }//This is just teh cached modify time of the current FS so we don't need to poll it agin
        public FsItemType ItemType { get; set; } = FsItemType.Folder;
        public string FullPath; // Should be the FULL path to the item
        public string FileOrDir;
        public FsItem Parent { get; set; } = null;
        public List<FsItem> Files = new List<FsItem>();
        public List<FsItem> Folders = new List<FsItem>();
        public List<FsItem> Children = new List<FsItem>();
        public Int32 Hash { get; private set; } = 0;
        public FsItemState FsItemState { get; set; } = FsItemState.None;

        public int WriteCount = 0;

        public static string AddedMarker = "(+)";
        public static string ChangedMarker = "(~)";
        public static string RemovedMarker = "(-)";
        public static string FolderContentsChangedMarker = "";

        public bool HasChanges()
        {
            foreach (FsItem child in Children)
            {
                if (child.FsItemState != FsItemState.None)
                {
                    return true;
                }
                if (child.HasChanges())
                {
                    return true;
                }
            }
            return false;
        }

        static string BottomFolder(string path)
        {
            path = path.TrimEnd('/', '\\');
            int a = path.LastIndexOf('/');
            int b = path.LastIndexOf('\\');
            if (b > a)
            {
                a = b;
            }
            a++;//remove the first /
            if (a != -1 && a < path.Length)
            {
                return path.Substring(a);
            }
            return path;
        }

        public FsItem(string path, FsItem parent, bool isDir, bool IsRoot = false)
        {
            Parent = parent;

            if (IsRoot)
            {
                //Special path is root *Root
                FullPath = path;
                ItemType = FsItemType.Root;
            }
            else
            {
                FullPath = System.IO.Path.GetFullPath(path);
                ItemType = isDir ? FsItemType.Folder : FsItemType.File;
                //Hash = path.GetHashCode();
                LastModifyTime = System.IO.File.GetLastWriteTime(FullPath);
                Hash = FullPath.GetHashCode();

                if (isDir)
                {
                    FileOrDir = BottomFolder(FullPath).Trim(); ;
                    LastModifyTime = Directory.GetLastWriteTime(path);
                }
                else
                {
                    FileOrDir = System.IO.Path.GetFileName(FullPath).Trim(); ;
                    LastModifyTime = File.GetLastWriteTime(path);
                }
            }

        }

        public bool IsFolder()
        {
            return ItemType == FsItemType.Folder;
        }

        private string ItemString()
        {
            string app = IsFolder() ? "/" : "";

            if (FsItemState == FsItemState.Added)
            {
                return AddedMarker + app + FileOrDir + Environment.NewLine;
            }
            else if (FsItemState == FsItemState.Changed)
            {
                return ChangedMarker + app + FileOrDir + Environment.NewLine;
            }
            else if (FsItemState == FsItemState.Removed)
            {
                return RemovedMarker + app + FileOrDir + Environment.NewLine;
            }
            else if (FsItemState == FsItemState.FolderContentsChanged)
            {
                return FolderContentsChangedMarker + app + FileOrDir + Environment.NewLine;
            }
            else if (FsItemState == FsItemState.None)
            {
                return "" + app + FileOrDir + Environment.NewLine;
            }
            else
            {
                throw new Exception("Failed to ultimate.");
            }
            return "";
        }
        public void PropogateChangesToParentFolders()
        {


        }
        public void BuildString(PrintSettings settings, int level = 0)
        {
            string tabs = "";// new string(new sbyte()[], 0,0, Globals.ISO8859_1);
            string app = new string(Globals.VPipe, 1);// new string(Globals.VPipe, 0,1, Globals.ISO8859_1);

            for (int i = 0; i < level; ++i)
            {
                string ap = "";
                if (Globals.Settings.ShowLongBranches)
                {
                    ap = app;
                }
                else
                {
                    ap = ((i == level - 1) ? app : "");
                }


                tabs += ap + new string(i == level - 1 ? Globals.HPipe : ' ', settings.TabSize);
            }

            foreach (FsItem item in Children)
            {
                if (item.FsItemState == FsItemState.None && settings.OmitUnchanged)
                {

                }
                else
                {
                    string str = tabs + item.ItemString();
                    settings.StringBuilder.Append(str);
                }

                item.BuildString(settings, level + 1);
            }
        }


        public string ToString(PrintSettings settings = null)
        {
            if (settings == null)
            {
                settings = new PrintSettings();
            }
            BuildString(settings, 0);
            return settings.StringBuilder.ToString();
        }

        public void CleanAndSync(bool recursive)
        {
            //Synchronizes the tree with the FS.

            //Remove Deleted files and clears the tree state
            List<FsItem> removed = new List<FsItem>();
            foreach (FsItem item in Children)
            {
                if (item.FsItemState == FsItemState.Removed)
                {
                    removed.Add(item);
                }
                item.CleanAndSync(true);
            }
            foreach (FsItem r in removed)
            {
                RemoveChild(r);
            }

            //Update modified time.
            if (NewModifyTime != null)
            {
                LastModifyTime = NewModifyTime.Value;
                NewModifyTime = null;
            }

            //Reset the state.
            FsItemState = FsItemState.None;
        }
        public void RemoveChild(FsItem r)
        {
            Children.Remove(r);
            if (r.IsFolder())
            {
                Folders.Remove(r);
            }
            else
            {
                Files.Remove(r);
            }
            r.Parent = null;
        }
        public FsItem AddChildNode(FsItem item)
        {
            System.Diagnostics.Debug.Assert(item.Parent == null);
            item.Parent = this;

            if (item.IsFolder())
            {
                Folders.Add(item);
            }
            else
            {
                Files.Add(item);
            }
            Children.Add(item);

            return item;
        }

        public FsItem FindChild(FsItem h_no_parent, bool recursive = false)
        {
            System.Diagnostics.Debug.Assert(h_no_parent.Parent == null);

            foreach (FsItem f in Files)
            {
                if (f.Hash == h_no_parent.Hash)
                {
                    return f;
                }
            }
            foreach (FsItem f in Folders)
            {
                if (f.Hash == h_no_parent.Hash)
                {
                    return f;
                }
            }
            return null;
        }

        public bool UpdateFolderContentsChanged()
        {
            //Update folder branches where files have been changed
            bool bRet = false;
            foreach (FsItem c in Children)
            {
                if (c.FsItemState != FsItemState.None)
                {
                    bRet = true;
                }
                bRet = bRet || c.UpdateFolderContentsChanged();
            }

            if (IsFolder() && bRet)
            {
                FsItemState = FsItemState.FolderContentsChanged;
            }

            return bRet;

        }

        public void Build(ref PollResults results)
        {
            //get list of new items
            List<FsItem> items = GetNewItems();

            //comapre items with our tree
            CheckForNewOrChangedFiles(ref results, items);
            CheckRemoved(ref results, items);

            //Recursive through directory tree.
            foreach (FsItem item in Folders)
            {
                if (item.FsItemState == FsItemState.None
                    || item.FsItemState == FsItemState.Changed
                    || item.FsItemState == FsItemState.Added)
                {
                    item.Build(ref results);
                }
            }

            //Update the scan progress.
            results.ScannedFileCountLastScan += items.Count;

            int cur = results.ScannedFileCountLastScan;
            int tot = results.TotalFileCount;

            Globals.MainForm.BeginInvoke(new Action(() =>
            {
                Globals.MainForm.StatsForm.CurrentScanPct = (double)cur / (double)tot;
                Globals.MainForm.StatsForm.Update();
            }));

            results.NewFileCountLastScan += Children.Where(x => x.FsItemState == FsItemState.Added).ToList().Count;
        }

        private void CheckForNewOrChangedFiles(ref PollResults results, List<FsItem> items)
        {
            //Compare our tree with the FS items.
            foreach (FsItem item in items)
            {
                if ((!item.IsFolder() && Globals.Settings.PollFiles) || (item.IsFolder() && Globals.Settings.PollDirectories))
                {
                    if (FsItemState == FsItemState.Added)
                    {
                        //We are a new Dir
                        //Simply add everything to the new parent.
                        AddChildNode(item);
                        item.FsItemState = FsItemState.Added;
                        results.NumAdded++;
                    }
                    else
                    {
                        FsItem child = FindChild(item, false);
                        if (child != null)
                        {
                            //item is there.
                            //*We will ignore changes to folders (whcih in windows, shows only parent folder changed if contents changed).
                            //Instead we show the whole parent branch as modified if a file gets changed
                            if (child.IsFolder() == false)
                            {
                                if (item.LastModifyTime > child.LastModifyTime)
                                {
                                    child.FsItemState = FsItemState.Changed;
                                    child.NewModifyTime = item.LastModifyTime;
                                    results.NumChanged++;
                                    child.WriteCount++;
                                }

                                CheckHotFile(child, ref results);
                            }

                        }
                        else
                        {
                            AddChildNode(item);
                            item.FsItemState = FsItemState.Added;
                            results.NumAdded++;
                        }
                    }

                }
            }

        }

        private List<FsItem> GetNewItems()
        {
            List<FsItem> items = new List<FsItem>();
            if (ItemType == FsItemType.Root)
            {
                foreach (string dir in Globals.Settings.PollDirs)
                {
                    items.Add(new FsItem(dir, null, true));
                }
            }
            else
            {
                //isNewDir - while walking the tree we have come across a new direcotyr that we don't have in our cache.
                string[] dirs_s = System.IO.Directory.GetDirectories(FullPath);
                string[] files_s = System.IO.Directory.GetFiles(FullPath);
                //Format paths to be full paths.
                foreach (string d in dirs_s)
                {
                    items.Add(new FsItem(d, null, true));
                }
                foreach (string f in files_s)
                {
                    items.Add(new FsItem(f, null, false));
                }
            }
            return items;
        }

        private void CheckRemoved(ref PollResults results, List<FsItem> items)
        {
            //Check Removed Items
            foreach (FsItem c in Children)
            {
                FsItem found = items.Where(x => x.Hash == c.Hash).FirstOrDefault();
                if (found == null)
                {
                    //Item was removed
                    c.FsItemState = FsItemState.Removed;
                    results.NumDeleted++;
                }
            }
        }

        private void CheckHotFile(FsItem child, ref PollResults results)
        {
            //Cache the top changed files
            if (child.WriteCount > 0)
            {
                if (results.TopFileChanges.Count == 0 || child.WriteCount > results.TopFileChanges[results.TopFileChanges.Count - 1].WriteCount)
                {
                    results.TopFileChanges.Add(child);

                    if (results.TopFileChanges.Count > Globals.Settings.NumTopFiles)
                    {
                        results.TopFileChanges.RemoveRange(Globals.Settings.NumTopFiles,
                            results.TopFileChanges.Count - Globals.Settings.NumTopFiles);
                    }

                }
            }
        }
    }
    public class PollResults
    {
        public int TotalFileCount = 0;
        public bool Changed = false;
        public int ScannedFileCountLastScan = 0;
        public int NewFileCountLastScan = 0;

        public List<FsItem> TopFileChanges = new List<FsItem>();


        public int NumAdded = 0;
        public int NumDeleted = 0;
        public int NumChanged = 0;
    }
    public static class Globals
    {
        //public static Encoding ISO8859_1 = Encoding.GetEncoding("iso-8859-1");
        public static char VPipe = '|';// ISO8859_1.GetString(new byte[] { 179 });
        //public static string TPipe = ISO8859_1.GetString(new byte[] { 195 });
        public static char HPipe = '-';// ISO8859_1.GetString(new byte[] { 196 });
                                       //  public static string VerticalPipe = Encoding.GetEncoding("437").GetString(new byte[] { 179 });

        public static string Version = "0.02";

        public static int FileCountInAllRoots()
        {
            int count = 0;
            foreach (string d in Globals.Settings.PollDirs)
            {
                FileCount(d, ref count);
            }
            return count;
        }
        private static void FileCount(string dirRoot, ref int count)
        {
            count += System.IO.Directory.GetFiles(dirRoot).Length;
            string[] dirs = System.IO.Directory.GetDirectories(dirRoot);
            count += dirs.Length;

            foreach (string d in dirs)
            {
                FileCount(d, ref count);
            }
        }

        public static string AppName = "DirScan";
        public static bool PathEquals(int a_hash, int b_hash)
        {
            return a_hash == b_hash;

            ////https://stackoverflow.com/questions/7344978/verifying-path-equality-with-net
            ////this was too slow.
            ////string A = System.IO.Path.GetFullPath(a);
            ////string B = System.IO.Path.GetFullPath(b);
            //return string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        }

        public static MainForm MainForm { get; set; }
        public static Settings Settings { get; set; } = new Settings();
        public static MetroThemeStyle MetroThemeStyle { get; set; } = MetroThemeStyle.Dark;
        public static void LogError(string str)
        {

            MainForm.LogError(str);
        }
        public static void ShowErrorMessage(IWin32Window owner, string er)
        {
            MetroFramework.MetroMessageBox.Show(owner, er, "Error");

        }

        public static string[] GetValidOpenSaveUserFile(bool bSave, string saveFilter,
            string loadFilter, string defaultext, string initialdir,
            bool multiple = false, string defaultName = "")
        {
            int num = 0;
            FileDialog fileDialog;
            string str;
            if (!bSave)
            {
                fileDialog = (OpenFileDialog)new OpenFileDialog();
                str = loadFilter;
                (fileDialog as OpenFileDialog).Multiselect = multiple;
            }
            else
            {
                fileDialog = new SaveFileDialog();
                str = saveFilter;
            }
            string fullPath = Path.GetFullPath(initialdir);
            fileDialog.InitialDirectory = fullPath;
            fileDialog.DefaultExt = defaultext;
            fileDialog.Filter = str;
            fileDialog.FilterIndex = num;
            if (string.IsNullOrEmpty(defaultName) == false)
            {
                fileDialog.FileName = defaultName + defaultext;
            }
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return fileDialog.FileNames;
            }
            if (!bSave && !File.Exists(fileDialog.FileName))
            {
                return new string[0];
            }
            return fileDialog.FileNames;
        }
        public static int ToInt(string s, int def)
        {
            int x = 0;
            if (Int32.TryParse(s, out x))
            {
                return x;
            }
            else
            {
                Globals.LogError("Could not parse '" + s + "'");
            }
            return def;
        }
        public static void SelectCboItem(System.Windows.Forms.ComboBox cb, string s, int defIndex)
        {
            for (int i = 0; i < cb.Items.Count; ++i)
            {
                if ((cb.Items[i] as string).Equals(s))
                {
                    cb.SelectedIndex = i;
                    return;
                }
            }
            if (cb.Items.Count > 0)
            {
                if (defIndex < cb.Items.Count)
                {
                    cb.SelectedIndex = defIndex;
                }

            }
        }

    }
    public class MouseDownFilter : IMessageFilter
    {
        public event EventHandler FormClicked;
        private int WM_LBUTTONDOWN = 0x201;
        private Form form = null;

        [DllImport("user32.dll")]
        public static extern bool IsChild(IntPtr hWndParent, IntPtr hWnd);

        public MouseDownFilter(Form f)
        {
            form = f;
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN)
            {
                if (Form.ActiveForm != null && Form.ActiveForm.Equals(form))
                {
                    OnFormClicked();
                }
            }
            return false;
        }

        protected void OnFormClicked()
        {
            if (FormClicked != null)
            {
                FormClicked(form, EventArgs.Empty);
            }
        }
    }


}
