using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using MetroFramework.Controls;
using MetroFramework;
using System.Diagnostics;
using System.Security.Cryptography;

namespace DeltaSearch
{
    public partial class SearchControl : MetroUserControl
    {
        public SearchControl()
        {
            InitializeComponent();
        }

        //These are cached for speed.
        List<string> _lstFileNameSearchTokens = null;
        List<string> _lstFileContentsSearchTokens = null;
        string _strFileContentsSearch;
        List<string> _lstFilesToSearch = new List<string>();
        List<Thread> _lstIndexThreads = new List<Thread>();
        List<DistributedThread> _lstSearchThreads = new List<DistributedThread>();
        List<SearchDir> SearchDirs;
        List<string> _lstErrors;
        TimeSpan IndexTime;
        List<string> _lstSearchPaths = new List<string>();
        List<SearchFile> MatchedFiles = new List<SearchFile>();
        HashSet<string> _searchedDirs;
        private List<string> _lstIndexedPaths;

        AhoCorasick.Trie _objFileContentsSearchTrie = null;

        // Thread IndexThread = null;

        long _nFoundFiles = 0;
        long _nTotalLines = 0;
        object _nFoundFiles_Lock = new object();
        bool _blnSearching = false;

        #region UI Methods

        DateTime SearchBaseStartTime;
        DateTime SearchStartTime;
        DateTime SearchStopTime;
        TimeSpan SearchTotalTime;

        MetroTextCombo _cboFileName, _cboFileContents, _cboSearchPaths;
        SHA256 static_sha = null;

        private void SearchControl_Load(object sender, EventArgs e)
        {
            _dgvFileSearchResults.Rows.Clear();

            _cboFileName = new MetroTextCombo();
            _cboFileContents = new MetroTextCombo();
            _cboSearchPaths = new MetroTextCombo();
            Globals.SwapControl(_txtFileName_Dummy, _cboFileName);
            Globals.SwapControl(_txtFileContents_Dummy, _cboFileContents);
            Globals.SwapControl(_cboSearchPaths_Dummy, _cboSearchPaths);

            static_sha = SHA256.Create();
            foreach (Control c in _txtSearchResultsDetails.Controls)
            {
                int n = 0;
                n++;
                if(c is System.Windows.Forms.TextBox)
                {
                    (c as System.Windows.Forms.TextBox).WordWrap = false;
                }
            }

            MakeSettings();

            ResetPrefs();
            LoadPrefs();
        }


        private void _btnSearch_Click(object sender, EventArgs e)
        {
            if (_blnSearching == false)
            {
                StartSearch();
            }
            else
            {
                StopSearch();
            }
        }
        private void _btnAddSearchPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d = new FolderBrowserDialog();

            if (d.ShowDialog() == DialogResult.OK)
            {
                string full = Path.GetFullPath(d.SelectedPath);

                //Add to selected path
                string delim = "";
                if (_cboSearchPaths.Text.Trim().Length > 0)
                {
                    delim = ";";
                }
                _cboSearchPaths.Text += delim + full;
            }
        }
        private void _btnSizeGreater_Click(object sender, EventArgs e)
        {

        }
        private void _chkSizeGreater_CheckedChanged(object sender, EventArgs e)
        {
            _nudSizeGreater.Enabled = _chkSizeGreater.Checked;
        }

        private void _chkSizeLesser_CheckedChanged(object sender, EventArgs e)
        {
            _nudSizeLesser.Enabled = _chkSizeLesser.Checked;
        }

        private void _btnAddMultiplePaths_Click(object sender, EventArgs e)
        {
            BrowseFolders br = new BrowseFolders();
            br.ShowDialog();
            if (br.DialogResult == DialogResult.OK)
            {
                List<string> paths = br.GetFolders();
                for (int i = 0; i < paths.Count; ++i)
                {
                    paths[i] = Path.GetFullPath(paths[i]);
                }

                string paths_delim = paths.Aggregate((x, y) => x + ";" + y);
                if (!GetSearchPaths().Contains(paths_delim))
                {
                    _cboSearchPaths.Items.Add(paths_delim);
                    _cboSearchPaths.Text = paths_delim;
                }
            }
        }

        private void _txtSearchPaths_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                StartSearch();
            }
        }
        private void _txtFileContentsSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                StartSearch();
            }
        }
        private void _txtFileNameSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                StartSearch();
            }
        }

        #endregion

        #region Private Methods

        List<bool> _lstControlEnableState = new List<bool>();
        private void EnableDisableSearchControls(bool enable)
        {
            List<Control> disableWhileSearching = new List<Control>
            {
                _cboFileName,
                _cboFileContents,
                _btnAddSearchPath,
                _chkFileContentsCaseSensitive,
                _chkFileContentsRegex,
                _chkFilenameCaseSensitive,
                _chkFilenameRegex,
                _chkMatchWholeFile,
                _chkSearchChm,
                _chkSearchDoc,
                _chkSearchPdf,
                _nudSizeGreater,
                _nudSizeLesser,
                _chkSizeGreater,
                _chkSizeLesser,
            };
            if (enable == false)
            {
                _lstControlEnableState = new List<bool>();
                foreach (Control x in disableWhileSearching)
                {
                    _lstControlEnableState.Add(x.Enabled);
                    x.Enabled = true;
                }
            }
            else
            {
                int i = 0;
                foreach (Control x in disableWhileSearching)
                {
                    x.Enabled = _lstControlEnableState[i];
                    i++;
                }
            }
        }


        private void StartSearch()
        {

            try
            {
                BeginSearch_SetState();
                ValidateSearchOptions();

                if (_lstErrors != null && _lstErrors.Count > 0)
                {
                    string strError = "There were errors indexing files, search cannot continue.\r\n" + _lstErrors.Aggregate((x, y) => x + "\r\n" + y);
                    ShowError(strError);
                    StopSearch();
                }
                else
                {
                    SavePrefs();
                    _blnSearching = true;
                    SetStatus("Indexing");
                    Thread indexThread = new Thread(() =>
                    {
                        IndexFiles();
                    });
                    indexThread.Start();
                    _lstIndexThreads.Add(indexThread);

                    SetStatus("Indexed " + SearchDirs.Sum(x => { return x.TotalNumSubFiles; }) + " files.");
                }
            }
            catch (System.Exception ex)
            {
                ShowError(ex.ToString());
            }
        }

        private static string FileContents_Pref = "FileContents";
        private static string FileName_Pref = "FileName";
        private static string SearchPaths_Pref = "SearchPaths";

        private static string SearchPDF_Pref = "SearchPDF";
        private static string SearchWord_Pref = "SearchWORD";
        private static string SearchCHM_Pref = "SearchCHM";

        private static string FileContentsRegex_Pref = "FileContentsRegex_Pref";
        private static string FilenameCaseSensitive_Pref = "FilenameCaseSensitive_Pref";
        private static string FilenameRegex_Pref = "FilenameRegex_Pref";
        private static string MatchWholeFile_Pref = "MatchWholeFile_Pref";
        private static string SizeGreater_Pref = "SizeGreater_Pref";
        private static string SizeLesser_Pref = "SizeLesser_Pref";
        private static string SizeGreaterVal_Pref = "SizeGreaterVal_Pref";
        private static string SizeLesserVal_Pref = "SizeLesserValPref";


        Settings Settings = null;

        private void MakeSettings()
        {
            Settings = new Settings((Settings sett, string key, string val) =>
            {
                if (sett.KeyComp(key, FileContents_Pref))
                {
                    Settings.LoadCombo(val, _cboFileContents);
                }
                else if (sett.KeyComp(key, FileName_Pref))
                {
                    Settings.LoadCombo(val, _cboFileName);
                }
                else if (sett.KeyComp(key, SearchPaths_Pref))
                {
                    Settings.LoadCombo(val, _cboSearchPaths);
                }
                else if (sett.KeyComp(key, SearchPDF_Pref))
                {
                    _chkSearchPdf.Checked = Globals.ParseBool(val, false);
                }
                else if (sett.KeyComp(key, SearchWord_Pref))
                {
                    _chkSearchDoc.Checked = Globals.ParseBool(val, false);
                }
                else if (sett.KeyComp(key, SearchCHM_Pref))
                {
                    _chkSearchChm.Checked = Globals.ParseBool(val, false);
                }
                else if (sett.KeyComp(key, FileContentsRegex_Pref))
                {
                    _chkFileContentsRegex.Checked = Globals.ParseBool(val, false);
                }
                else if (sett.KeyComp(key, FilenameCaseSensitive_Pref))
                {
                    _chkFileContentsCaseSensitive.Checked = Globals.ParseBool(val, false);
                }
                else if (sett.KeyComp(key, FilenameRegex_Pref))
                {
                    _chkFilenameRegex.Checked = Globals.ParseBool(val, false);
                }
                else if (sett.KeyComp(key, MatchWholeFile_Pref))
                {
                    _chkMatchWholeFile.Checked = Globals.ParseBool(val, false);
                }
                else if (sett.KeyComp(key, SizeGreater_Pref))
                {
                    _chkSizeGreater.Checked = Globals.ParseBool(val, false);
                }
                else if (sett.KeyComp(key, SizeLesser_Pref))
                {
                    _chkSizeLesser.Checked = Globals.ParseBool(val, false);
                }
                else if (sett.KeyComp(key, SizeGreaterVal_Pref))
                {
                    _nudSizeGreater.Value = (decimal)Globals.ParseDouble(val, 0.0);
                }

                else if (sett.KeyComp(key, SizeLesserVal_Pref))
                {
                    _nudSizeLesser.Value = (decimal)Globals.ParseDouble(val, 0.0);
                }

                return true;
            }, (Settings sett) =>
            {
                StringBuilder sb = new StringBuilder();
                sett.WriteValue(ref sb, FileContents_Pref, CboValue(_cboFileContents));
                sett.WriteValue(ref sb, FileName_Pref, CboValue(_cboFileName));
                sett.WriteValue(ref sb, SearchPaths_Pref, CboValue(_cboSearchPaths));

                sett.WriteValue(ref sb, SearchPDF_Pref, _chkSearchPdf.Checked.ToString());
                sett.WriteValue(ref sb, SearchWord_Pref, _chkSearchDoc.Checked.ToString());
                sett.WriteValue(ref sb, SearchCHM_Pref, _chkSearchChm.Checked.ToString());

                sett.WriteValue(ref sb, FileContentsRegex_Pref, _chkFileContentsRegex.Checked.ToString());
                sett.WriteValue(ref sb, FilenameCaseSensitive_Pref, _chkFilenameCaseSensitive.Checked.ToString());
                sett.WriteValue(ref sb, FilenameRegex_Pref, _chkFilenameRegex.Checked.ToString());
                sett.WriteValue(ref sb, MatchWholeFile_Pref, _chkMatchWholeFile.Checked.ToString());
                sett.WriteValue(ref sb, SizeGreater_Pref, _chkSizeGreater.Checked.ToString());
                sett.WriteValue(ref sb, SizeLesser_Pref, _chkSizeLesser.Checked.ToString());
                sett.WriteValue(ref sb, SizeGreaterVal_Pref, _nudSizeGreater.Value.ToString());
                sett.WriteValue(ref sb, SizeLesserVal_Pref, _nudSizeLesser.Value.ToString());

                return sb;
            });
        }
        private string CboValue(MetroTextCombo c)
        {
            string ret = "";
            string delim = "";
            foreach (string x in c.Items)
            {
                ret += delim + x;
                delim = "*&*";
            }
            return ret;
        }
        private void SavePrefs()
        {
            _cboSearchPaths.CacheSelectedValue();
            _cboFileName.CacheSelectedValue();
            _cboFileContents.CacheSelectedValue();
            Settings.SaveData();
        }
        private void LoadPrefs()
        {
            Settings.LoadData();
        }
        public void ResetPrefs()
        {
            _cboSearchPaths.Items.Clear();
            _cboFileName.Items.Clear();
            _cboFileContents.Items.Clear();
            _chkSearchChm.Checked = false;
            _chkSearchDoc.Checked = false;
            _chkSearchPdf.Checked = false;
            _chkFileContentsRegex.Checked = false;
            _chkFilenameCaseSensitive.Checked = false;
            _chkFilenameRegex.Checked = false;
            _chkMatchWholeFile.Checked = false;
            _chkSizeGreater.Checked = false;
            _chkSizeLesser.Checked = false;
            _nudSizeGreater.Value = 0;
            _nudSizeLesser.Value = 0;

        }

        private void BeginSearch_SetState()
        {
            KillThreads();
            _lstIndexThreads = new List<Thread>();
            _lstSearchThreads = new List<DistributedThread>();
            _lstFileNameSearchTokens = null;
            _lstFileContentsSearchTokens = null;
            _strFileContentsSearch = "";
            _lstFilesToSearch = new List<string>();
            _lstErrors = new List<string>();
            SearchDirs = new List<SearchDir>();
            MatchedFiles = new List<SearchFile>();
            _lstSearchPaths = GetSearchPaths();

            _dgvFileSearchResults.Rows.Clear();

            SearchTotalTime = new TimeSpan(0);
            _nFoundFiles = 0;
            _lstIndexedPaths = new List<string>();
            SearchStartTime = SearchBaseStartTime = DateTime.Now;
            EnableDisableSearchControls(false);
            SetStatus("Search Started");
            _btnSearch.Text = "Stop";
        }
        private void KillThreads()
        {
            if (_lstIndexThreads != null)
            {
                foreach (Thread th in _lstIndexThreads)
                {
                    th.Abort();
                }
                _lstIndexThreads = new List<Thread>();
            }
            if (_lstSearchThreads != null)
            {
                foreach (DistributedThread th in _lstSearchThreads)
                {
                    th.ManagedThread.Abort();
                }
                _lstSearchThreads = new List<DistributedThread>();
            }

        }
        private void StopSearch()
        {
            KillThreads();

            _btnSearch.Text = "Search";
            SearchStopTime = DateTime.Now;
            EnableDisableSearchControls(true);

            _blnSearching = false;

            SearchTotalTime += SearchStopTime - SearchStartTime;
            string total = ToShortForm(SearchTotalTime);
            string started = SearchBaseStartTime.ToString("dd/MM/yyyy hh:mm:ss.fff");
            SetStatus("Search took " + total + " (Started " + started + ")");
        }

        public static string ToShortForm(TimeSpan t)
        {
            string shortForm = "";
            if (t.Hours > 0)
            {
                shortForm += string.Format("{0}h", t.Hours.ToString());
            }
            if (t.Minutes > 0)
            {
                shortForm += string.Format("{0}m", t.Minutes.ToString());
            }
            if (t.Seconds > 0)
            {
                shortForm += string.Format("{0}s", t.Seconds.ToString());
            }
            if (t.Milliseconds > 0)
            {
                shortForm += string.Format("{0}ms", t.Milliseconds.ToString());
            }
            return shortForm;
        }

        private void SetStatus(string status)
        {
            BeginInvoke((Action)(() =>
            {
                Globals.MainForm.SetStatus(status);
            }));
        }
        private void ShowError(string e)
        {
            Globals.MainForm.BeginInvoke((Action)(() =>
            {
                SetStatus(e);
                MessageBox.Show(e, "Error", MessageBoxButtons.OK);
            }));
        }
        private void ValidateSearchOptions()
        {
            SetStatus("Validating Search Parameters");

            if (_lstSearchPaths.Count == 0)
            {
                _lstErrors.Add("Please add one or more paths to search.");
            }
            else
            {
                foreach (string p in _lstSearchPaths)
                {
                    if (!Directory.Exists(p))
                    {
                        _lstErrors.Add("The directory '" + p + "' does not exist.");
                    }
                }
            }

            //Reset the trie
            _objFileContentsSearchTrie = null;

            //Begin by caching search tokens if needed
            if (_chkFileContentsRegex.Checked)
            {
                _lstFileContentsSearchTokens = null;
                try
                {
                    Regex.Match("", _cboFileContents.Text);
                }
                catch (ArgumentException)
                {
                    _lstErrors.Add("File contents regex is not a valid regular expression.");
                }
            }
            else
            {
                _strFileContentsSearch = _cboFileContents.Text;
                _lstFileContentsSearchTokens = _cboFileContents.Text.Split(' ').ToList();
                if (_chkFileContentsCaseSensitive.Checked)
                {
                    _lstFileContentsSearchTokens.ConvertAll(x => x.ToLower()); ;
                }


                // build file contents search tree
                _objFileContentsSearchTrie = new AhoCorasick.Trie();
                int iWord = 0;
                foreach (string word in _lstFileContentsSearchTokens)
                {
                    iWord++;
                    if (_chkFileContentsCaseSensitive.Checked)
                    {
                        _objFileContentsSearchTrie.Add(word);
                    }
                    else
                    {
                        _objFileContentsSearchTrie.Add(word.ToLower());
                    }
                }
                _objFileContentsSearchTrie.Build();
               
            }
            if (_chkFilenameRegex.Checked)
            {
                _lstFileNameSearchTokens = null;
                try
                {
                    Regex.Match("", _cboFileName.Text);
                }
                catch (ArgumentException)
                {
                    _lstErrors.Add("File name regex is not a valid regular expression.");
                }
            }
            else
            {
                _lstFileNameSearchTokens = _cboFileName.Text.Split(' ').ToList();

                if (_chkFilenameCaseSensitive.Checked)
                {
                    _lstFileNameSearchTokens.ConvertAll(x => x.ToLower()); ;
                }
            }
        }
        private void IndexFiles()
        {
            SearchDirs = new List<SearchDir>();

            object objLock = new object();
            // setup done, do search
            foreach (string path in _lstSearchPaths)
            {
                Thread indexThread = new Thread(() =>
                {
                    SearchDir dir = IndexFiles(path, null);
                    lock (objLock)
                    {
                        SearchDirs.Add(dir);
                    }

                    AfterIndexPath(path);
                });
                lock (_lstIndexThreads)
                {
                    _lstIndexThreads.Add(indexThread);
                }
                indexThread.Start();
            }
        }
        private List<string> GetSearchPaths()
        {
            //Must be called on UI thread only
            List<string> paths = new List<string>();
            lock (_cboSearchPaths)
            {
                paths = _cboSearchPaths.Text.Trim().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            return paths;
        }

        private void AfterIndexPath(string path)
        {
            lock (_lstIndexedPaths)
            {
                _lstIndexedPaths.Add(path);
                if (_lstSearchPaths.Count == _lstIndexedPaths.Count)
                {
                    DistributeSearchWorkload();
                }
            }
        }
        private void DistributeSearchWorkload()
        {
            //Indexing complete.
            //Calc distribution;;TODO

            //SearchGetSearchDirMinimumChunk()
            if (SearchDirs == null || SearchDirs.Count != 1)
            {
                //testing.
                ShowError("No search paths specified.  Please specify one or more search paths (separated by ';').");
            }
            else
            {
                long totalSize = SearchDirs.Sum((x) => x.SearchSizeBytes);
                long nBytesProc = totalSize / Environment.ProcessorCount;

                _searchedDirs = new HashSet<string>();
                DistributeSearchToCore(SearchDirs[0], 0);
                IndexTime = (DateTime.Now - SearchBaseStartTime);
            }
        }
        private void DistributeSearchToCore(SearchDir sd, int iProcessor)
        {
            //Toss the File search across virtual threads.
            DistributedThread t = new DistributedThread(() =>
            {
                PerformSearch(sd, _chkFileContentsRegex.Checked, _chkFileContentsCaseSensitive.Checked, _chkMatchWholeFile.Checked);

                SearchCoreComplete(iProcessor);
            });
            t.ProcessorAffinity = iProcessor;
            lock (_lstSearchThreads)
            {
                _lstSearchThreads.Add(t);
            }
            //thread.ManagedThread.Name = "ThreadOnCPU2";
            t.Start();
        }
        private void SearchCoreComplete(int proc)
        {
            BeginInvoke((Action)(() =>
            {
                StopSearch();
            }));
        }

        private void PerformSearch(SearchDir sd, bool regex, bool caseSensitive, bool wholefile)
        {
            bool bHasNotBeenSearched = false;
            lock (_searchedDirs)
            {
                if (_searchedDirs.Contains(sd.Name) == false)
                {
                    bHasNotBeenSearched = true;
                    _searchedDirs.Add(sd.Name);
                }
            }

            if (bHasNotBeenSearched)
            {
                //Note: The searchfiles here are already matched to the file filter. (not all files in dir)
                //List<string> toDecompile = new List<string>();
                foreach (SearchFile sf in sd.Files)
                {
                    //This is really a bottleneck
                    SetStatus(sf.Name);

                    string ext = Path.GetExtension(sf.Name);
                    string extl = ext.ToLower();
                    if (extl == ".chm" && _chkSearchChm.Checked)
                    {
                        LookThroughCHM(sf, regex, caseSensitive, wholefile);
                    }
                    else if ((extl == ".doc" || extl == ".docx") && _chkSearchDoc.Checked)
                    {

                    }
                    else if (extl == ".pdf" && _chkSearchPdf.Checked)
                    {
                    }
                    else
                    {
                        LookThroughFile(sf, caseSensitive, regex, wholefile);
                    }
                }

                //Recursive
                foreach (SearchDir d in sd.Dirs)
                {
                    PerformSearch(d, regex, caseSensitive, wholefile);
                }

            }
        }
        private void LookThroughFile(SearchFile sf, bool caseSensitive, bool regex, bool wholefile)
        {
            if (String.IsNullOrEmpty(_strFileContentsSearch))
            {
                //No contents, user just wants to locate files.  Easy out.
                AddMatch(sf);
            }
            else
            {
                using (StreamReader sr = File.OpenText(sf.Name))
                {
                    string s = sr.ReadToEnd();

                    //If we are not matching the whole file then split the file up by \n newlines.
                    string[] lines = null;
                    if (wholefile == true)
                    {
                        lines = new string[1] { s };
                    }
                    else
                    {
                        lines = s.Split('\n');
                    }

                    int iLine = 1;
                    foreach (string line in lines)
                    {
                        if (regex)
                        {
                            RegexSearch(sf, line, iLine, caseSensitive);
                        }
                        else
                        {
                            NonRegexSearch(sf, line, iLine, caseSensitive);
                        }
                        iLine++;
                    }

                    sr.Close();
                }
            }

        }
        private void LookThroughCHM(SearchFile sf, bool regex, bool cs, bool wholefile)
        {
            try
            {
                string outDir = DecompileCHM(sf.Name);

                SearchDir sd = IndexFiles(outDir, sf.Name);
                PerformSearch(sd, regex, cs, wholefile);

                //Delete decompiled CHM so we don't eat up disk space.
                Directory.Delete(outDir, true);
            }
            catch (Exception ex)
            {
                Globals.LogError(ex.ToString());
            }
        }
        private string DecompileCHM(string chm_file_name)
        {
            //Calls hh.exe to decompile a chm file to /TEMP
            //I wish I knew a faster way to do this.
            //c:\windows\hh.exe -decompile c:\test c:\depends.chm
            string out_dir = "";
            string root = Environment.GetEnvironmentVariable("SystemRoot");
            //Environment.GetEnvironmentVariable("windir");
            if (Directory.Exists(root))
            {
                string hh = Path.Combine(root, "hh.exe");
                if (File.Exists(hh))
                {
                    out_dir = Globals.GetSha256Hash(static_sha, chm_file_name);
                    out_dir = System.IO.Path.Combine(Path.GetTempPath(), out_dir);

                    if (!System.IO.Directory.Exists(out_dir))
                    {
                        //System.IO.Directory.Delete(out_dir, true);
                        System.IO.Directory.CreateDirectory(out_dir);
                    }

                    //Decompile CHM file.
                    ProcessStartInfo start = new ProcessStartInfo();
                    //No Quotes on paths.  hh.exe can't use quotes.  Dumb
                    start.Arguments = " -decompile " + out_dir + " " + chm_file_name;
                    start.FileName = hh;
                    start.WorkingDirectory = out_dir;
                    start.UseShellExecute = true;
                    start.CreateNoWindow = true;
                    start.WindowStyle = ProcessWindowStyle.Hidden;
                    int exitCode;

                    // Run the external process & wait for it to finish
                    using (Process proc = Process.Start(start))
                    {
                        proc.WaitForExit();

                        // Retrieve the app's exit code
                        exitCode = proc.ExitCode;
                    }

                }
            }

            return out_dir;
        }
        private void AddMatch(SearchFile sf)
        {
            BeginInvoke((Action)(() =>
            {
                string file_name = sf.UncompiledFile == null ? sf.Name : sf.UncompiledFile;

                MatchedFiles.Add(sf);
                FileInfo fi = new FileInfo(file_name);
                string filetype = NativeMethods.GetShellFileType(file_name);
                string moddat = sf.LastModified.ToString("yyyy-mm-dd hh:mm:ss.fff");
                DataGridViewRow r = new DataGridViewRow();
                r.Tag = sf;
                r.CreateCells(_dgvFileSearchResults, new object[] {
                    file_name,
                    moddat,
                    filetype,
                    string.Format("{0:0.00}", (float)sf.Length / 1024.0f)
                });
                _dgvFileSearchResults.Rows.Add(r);

            }));
        }
        private void RegexSearch(SearchFile sf, string line, int iLine, bool caseSensitive)
        {
            bool matched = false;
            if (sf.MatchedLines == null)
            {
                sf.MatchedLines = new List<SearchLine>();
            }
            if (Regex.Match(line, _strFileContentsSearch, caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase).Success)
            {
                sf.MatchedLines.Add(new SearchLine(iLine, line));
                matched = true;
            }
            if (matched)
            {
                AddMatch(sf);
            }
        }
        object MatchedFiles_Lock = new object();
        private void NonRegexSearch(SearchFile sf, string line, int iLine, bool caseSensitive)
        {
            //Find.
            bool bFound = false;
            lock (MatchedFiles_Lock)
            {
                IEnumerable<string> ret = _objFileContentsSearchTrie.Find(caseSensitive ? line : line.ToLower());
                if (ret.Any())
                {
                    if (sf.MatchedLines == null)
                    {
                        sf.MatchedLines = new List<SearchLine>();
                    }
                    sf.MatchedLines.Add(new SearchLine(iLine, line));
                    bFound = true;
                }
            }
            if (bFound)
            {
                AddMatch(sf);
            }
        }

        private SearchDir IndexFiles(string parent, string strUncompiledFile=null)
        {
            //strDecompiledFile = if we are indexing a decompiled CHM or other file, in which case we index everything.
            //Index files and count all bytes.
            SearchDir newDir = new SearchDir(parent);
            try
            {
                string[] dirs = Directory.GetDirectories(parent);

                foreach (string filename in Directory.GetFiles(parent))
                {
                    string baseName = System.IO.Path.GetFileName(filename);
                    if ((strUncompiledFile!=null) || MatchText(baseName, _lstFileNameSearchTokens, _cboFileName.Text, _chkFilenameRegex.Checked))
                    {
                        FileInfo fi = new FileInfo(filename);
                        newDir.Files.Add(new SearchFile(filename, fi.Length, fi.LastWriteTime, strUncompiledFile));
                        newDir.SearchSizeBytes += newDir.Files[newDir.Files.Count - 1].Length;
                    }
                }

                lock (_nFoundFiles_Lock)
                {
                    _nFoundFiles += newDir.Files.Count;
                    if (strUncompiledFile == null)
                    {
                        SetStatus("Found " + _nFoundFiles);
                    }
                }

                foreach (string dir in dirs)
                {
                    SearchDir t = IndexFiles(dir, strUncompiledFile);
                    newDir.SearchSizeBytes += t.SearchSizeBytes;
                    newDir.Dirs.Add(t);
                    newDir.TotalNumSubFiles += t.Files.Count + t.TotalNumSubFiles;
                }
            }
            catch (Exception ex)
            {
                Globals.LogWarn("Failed to index files in '" + parent + "': " + ex.ToString());
                //Dir may not be authorized.
            }


            return newDir;
        }

        private void _dgvFileSearchResults_SelectionChanged_1(object sender, EventArgs e)
        {
            if (_dgvFileSearchResults.SelectedRows.Count == 1)
            {
                DataGridViewRow r = _dgvFileSearchResults.SelectedRows[0];

                string st = "";
                SearchFile sf = r.Tag as SearchFile;
                if (sf.MatchedLines != null)
                {
                    foreach(SearchLine sl in sf.MatchedLines)
                    {
                        st += sl.LineNumber + ": " + sl.Text + "\r\n";
                    }
                }
                _txtSearchResultsDetails.Text = st;

            }

        }

        private bool MatchText(string textToMatch, List<string> tokens, string pattern, bool regex)
        {
            //This makes no sense, we should be using the file contents match algorithm
            if (regex)
            {
                Match m = Regex.Match(textToMatch, pattern, RegexOptions.IgnoreCase);

                if (m.Success)
                {
                    return true;
                }
            }
            else
            {
                //Simple query
                foreach (string str in tokens)
                {
                    if (textToMatch.Contains(str))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public string GetStats()
        {
            string stat = "";
            stat += "Index Time: " + ToShortForm(IndexTime) + "\r\n";
            stat += "Search Time: " + ToShortForm(SearchTotalTime) + "\r\n";
            stat += "Total files Indexed: " + _nFoundFiles + "\r\n";
            return stat;
        }

        #endregion


    }
}
