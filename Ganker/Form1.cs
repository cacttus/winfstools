using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebLoader
{
    public partial class Form1 : Form
    {
        System.Windows.Threading.DispatcherTimer _objGetHtmlTimer = null;
        System.Windows.Threading.DispatcherTimer _objUpdateDownloadTimer = null;
        object _objListBoxLock = new object();
        System.Threading.CancellationTokenSource _objUpdaterToken;

        List<string> _lstCurrentDownloads = new List<string>();
        List<string> _lstPendingDownloads = new List<string>();
        List<string> _lstCompletedDownloads = new List<string>();

        //List<Task> _lstCurrentDownloadTasks = new List<Task>();
       // List<System.Threading.CancellationTokenSource> _lstCancelTokens = new List<System.Threading.CancellationTokenSource>();
        string _sCurLink = "";
        string _sPrevLink = "";
        bool _bAlreadyNavigated = false;
        System.Threading.Tasks.Task _objGetHtmlTask = null;
        System.Threading.CancellationTokenSource _objGetHtmlCancelToken = null;
        Dictionary<string,float> _downloadProgress = new Dictionary<string, float>();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {


            //Upend the connection limits.
            System.Net.ServicePointManager.DefaultConnectionLimit = 10000;

            ToggleHideOptions(true);
            //_txtOutput.Visible = false;
           // Height -= _txtOutput.Height;

            _objUpdaterToken = new System.Threading.CancellationTokenSource();

            _objUpdaterToken.Token.ThrowIfCancellationRequested();
            _objUpdateDownloadTimer = new System.Windows.Threading.DispatcherTimer();
            _objUpdateDownloadTimer.Interval = new TimeSpan(0, 0, 0, 0, 500); // 100 Milliseconds 
            _objUpdateDownloadTimer.Tick += new EventHandler(UpdateDownloads);
            _objUpdateDownloadTimer.Start();
        }
        private void _btnStart_Click(object sender, EventArgs e)
        {
            CreateOutputDirectory();
            if(_btnStart.Text == "Start") {

                _sCurLink = "";//Reset current link

                StartTimer(true);
            }
            else if(_btnStart.Text == "Stop") {
                if(_objGetHtmlCancelToken!=null && _objGetHtmlTask.IsCompleted ==false) {
                   _objGetHtmlCancelToken.Cancel();
                }
                StopTimer();
                //KillAllDownloads();
                //KillAllPending();

            }
        }
        private void RestartTimer(bool immediate = false) {
            //Restart on SAME thread.
            int iDelay;
            if(immediate) {
                iDelay = 100;
            }
            else {
                iDelay = GetNextDelay();
            }
            _objGetHtmlTimer = new System.Windows.Threading.DispatcherTimer();
            _objGetHtmlTimer.Interval = new TimeSpan(0, 0, 0, 0, iDelay); // 100 Milliseconds 
            _objGetHtmlTimer.Tick += new EventHandler(GetHtmlUpdateTick);
            _objGetHtmlTimer.Start();
        }
        private void StartTimer(bool immediate = false) {
            WriteOutput("Starting..");
            RestartTimer(immediate);
            _btnStart.BeginInvoke((Action)(() => {
                _btnStart.BackColor = Color.Red;
                _btnStart.Text = "Stop";
            }));
            WriteOutput("Started.");
        }
        private void StopTimer() {
            lock(_objListBoxLock)
            {
                WriteOutput("Stopping..");
                _objGetHtmlTimer.Stop();
                _btnStart.BeginInvoke((Action)(() => {
                    _btnStart.BackColor = Color.Green;
                    _btnStart.Text = "Start";
                }));

                WriteOutput("Stopped.");
            }
        }
        private void CreateOutputDirectory() {
            System.IO.Directory.CreateDirectory(_txtOutputPath.Text);
        }
        private int GetNextDelay() {
            System.Random rnd = new Random();

            int ret =  (int)_nudHitDelay.Value + rnd.Next() % (int)_nudHitDelayRandom.Value;

            return ret;
        }
        private void GetHtmlUpdateTick(Object o, EventArgs e) {
            _objGetHtmlTimer.Stop();

            if(_objGetHtmlTask == null || _objGetHtmlTask.IsCompleted == true) {
                RestartTimer(true);

                _objGetHtmlCancelToken = new System.Threading.CancellationTokenSource();
                _objGetHtmlTask = new System.Threading.Tasks.Task((Action)(() =>{
                    _objGetHtmlCancelToken.Token.ThrowIfCancellationRequested();

                    List<string> links = GetLinks();
                    if(_chkVerbose.Checked == true) {
                        WriteOutput("Got " + links.Count + " links.");
                    }

                    long iMaxDiskBytes = (long)_nudMaxDiskSpace.Value * 1000 * 1000;
                    _bAlreadyNavigated = false;

                    List<string> mexts = GetDownloadableMediaExtensions();

                    foreach(string strLink in links) {
                        string strLinkFmt = FormatLink(strLink);
                        string strLinkLL = strLinkFmt.ToLower();
                        string ext = System.IO.Path.GetExtension(strLinkLL);

                        if(CheckDirSize()==false) {
                            return;//Return + do not start timer again.
                        }

                        if(ext == ".htm" || ext == ".html")
                        {
                            //Html link
                            //Navigate
                            Navigate(strLinkLL);
                        }
                        else {
                            foreach(string mext in mexts)
                            {
                                if(ext == mext)
                                {
                                    string fn_final = FormatLinkToFile(strLinkFmt);

                                    if(!System.IO.File.Exists(fn_final))
                                    {
                                        lock(_objListBoxLock)
                                        {
                                            if(!_lstPendingDownloads.Contains(strLinkFmt))
                                            {
                                                if(!_lstCurrentDownloads.Contains(strLinkFmt))
                                                {
                                                    _lstPendingDownloads.Add(strLinkFmt);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }), _objGetHtmlCancelToken.Token);
                _objGetHtmlTask.Start();
            }
            else {
                //Start the timer again to run almost immediatly to poll if this task is complete..
                RestartTimer(false);
            }
        }
        private string FormatLink(string link) {
            //Double slash is a relative Protocol - so use HTTP for the heck of it
            if(link.StartsWith("//")) {
                link = link.Substring(2,link.Length-2);
                link = "http://" + link;
            }
            else if(link.StartsWith("/")) {
                link = GetTopLevelDomain() + link;
            }
            return link;
        }
        private void Navigate(string strLink) {
            if(_bAlreadyNavigated==false) {

                if(_chk8Ch.Checked==true) {
                    if(_sCurLink.Contains("/res/")) {
                        //Navigate back
                        _sCurLink = _sPrevLink;
                        _sPrevLink = "";
                        _bAlreadyNavigated =true;
                    }
                    else if(strLink.Contains("/res/")) {
                        _sPrevLink = _sCurLink;
                        _sCurLink = strLink;
                        _bAlreadyNavigated =true;
                    }
                }
            }
        }
        private bool CheckDirSize() {
            long iMaxDiskBytes = (long)_nudMaxDiskSpace.Value * 1000 * 1000;
            long curMb = GetDirSizeBytes();

            double fpt = (double)curMb / (double)(iMaxDiskBytes);
            int pgbValue = (int)((double)_pgbMaxDiskSpace.Minimum + (double)(_pgbMaxDiskSpace.Maximum - _pgbMaxDiskSpace.Minimum) * fpt);
            pgbValue = Math.Max(_pgbMaxDiskSpace.Minimum,Math.Min(_pgbMaxDiskSpace.Maximum, pgbValue));
            _pgbMaxDiskSpace.BeginInvoke((Action)(() => {
                _pgbMaxDiskSpace.Value = pgbValue;
            }));
            if(curMb > iMaxDiskBytes) {
                WriteOutput("Directory exceeded size of " + (int)_nudMaxDiskSpace.Value + "MB.  Stopping poll.");
                StopTimer();
                return false;
            }
 
            return true;   
        }
        private long GetDirSizeBytes() {
            long iLen = 0;
            if(System.IO.Directory.Exists(_txtOutputPath.Text)) {
                string[] files = System.IO.Directory.GetFiles(_txtOutputPath.Text);
                foreach (string file in files) {
                    iLen += new System.IO.FileInfo(file).Length;
                }
            }
            return iLen;
        }
        private string GetHtml(string url) {
            try {
                using (WebClient client = new WebClient())
                {
                    FormatLink(url);

                    try
                    {
                        Uri myUri = new UriBuilder(url).Uri;
                        return client.DownloadString(myUri);
                    }
                    catch (UriFormatException ex)
                    {
                        WriteOutput("ERROR: could not validate URL " + url + " : " + ex.Message);
                        return "";
                    }
                }
            }
            catch (WebException ex) {
                if(ex.Status == WebExceptionStatus.ProtocolError) {
                    WriteOutput("The link 404'd. Not found.");
                }
                else {
                    WriteOutput("Web Exception while getting HTML: " + ex.ToString());
                }
            }
            catch (Exception ex) {
                WriteOutput("Exception while getting HTML: " + ex.ToString());
            }
            return "";
        }
        private string GetTopLevelDomain() {
            Uri myUri = new UriBuilder(_txtBaseUrl.Text).Uri;
            return myUri.Host;
        }
        private List<string> GetLinks() {
            //Get all links on page.
            if(_sCurLink=="") {
                _sCurLink = _txtBaseUrl.Text;
            }

            string htm = GetHtml(_sCurLink);

            List<string> ret = new List<string>();

            //https://media.8ch.net/file_store/9515dd129b6a7b925dd4136e5dd2395f4d6c4f01bba188fba83aa7e5d385265a.jpg

            //string pattern = "href\\s*=\\s*(\\\"|\\\')[a-zA-Z0-9\\-\\+\\=\\~\\/\\:\\.]+(\\\"|\\\')";
            string pattern = "href\\s*=\\s*(\\\"|\\\')[a-zA-Z0-9_\\-\\+\\=\\~\\/\\:\\.]+(\\\"|\\\')";

            System.Text.RegularExpressions.MatchCollection matches =  System.Text.RegularExpressions.Regex.Matches(htm, pattern);

            foreach (System.Text.RegularExpressions.Match match in matches) {

                //Parse the html from it
                int ind;
                
                ind = match.Value.IndexOf('\"');
                if(ind>0) {
                    int ind2 = match.Value.IndexOf('\"', ind+1);
                    if(ind2 > ind) {
                        ret.Add(match.Value.Substring(ind+1, ind2-ind -1));
                    }
                }

                ind = match.Value.IndexOf('\'');
                if(ind>0) {
                    int ind2 = match.Value.IndexOf('\'', ind+1);
                    if(ind2 > ind) {
                        ret.Add(match.Value.Substring(ind+1, ind2-ind -1));
                    }
                }

            } 

            return ret;
        }
        private void DownloadFileAsync(string link) {
            DownloadFileLink(link);

            lock(_objListBoxLock)
            {
                //_lstCurrentDownloadTasks.Add(objTask);
                //_lstCancelTokens.Add(token);
                _lstCurrentDownloads.Add(link);
            }
        }
        private void DownloadFileLink(string link) {

            try {
                string fn_final = FormatLinkToFile(link);

                if(System.IO.File.Exists(fn_final)) {
                    return;
                }

                using (var client = new WebClient())
                {
                    client.DownloadFileCompleted += DownloadFileCompleted;
                    client.DownloadProgressChanged += DownloadProgressChanged;
                    client.DownloadFileAsync(new Uri(link), fn_final, (object)link);
                }
            }
            catch(WebException wex) {
                if(wex.Status == WebExceptionStatus.Timeout) {
                    WriteOutput("The operation timed out while downloading " + link);
                }
            }
            catch(Exception ex) {
                WriteOutput("Exception while downloading file " + link + ": " + ex.ToString());
            }
        }
        private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
            string linkname = (string)e.UserState;
            float val = (float)e.BytesReceived / (float)e.TotalBytesToReceive;

            val *= 100;
            _downloadProgress[linkname] = val;
        }
        private void DownloadFileCompleted(object sender, AsyncCompletedEventArgs e) {
            string linkname = (string)e.UserState;
            _lstCurrentDownloads.Remove(linkname);
            _lstCompletedDownloads.Add(linkname);
            string fname = this.FormatLinkToFile(linkname);
            WriteOutput("Downloaded " + fname);
        }

        private void UpdateDownloads(Object o, EventArgs e) {
            //**THIS IS A UI SYNCHRONOUS METHOD
            lock(_objListBoxLock)
            {

                //Add New
                List<string> toRemoveLink = new List<string>();
                for(int i = _lstPendingDownloads.Count-1; i>=0; --i) {
                    string link = (string)_lstPendingDownloads[i];
                    if(_lstCurrentDownloads.Count < (int)_nudMaxDownloads.Value) {
                        DownloadFileAsync(link);
                        _lstPendingDownloads.RemoveAt(i);
                    }
                }

                _lblPending.Text = "Pending (" + _lstPendingDownloads.Count + ")";
                _lblCurrent.Text = "Current (" + _lstCurrentDownloads.Count + ")";
            
                //UPdate List Boxes
                Point pt;
                ////
                pt = _lsbPendingDownloads.AutoScrollOffset;
                _lsbPendingDownloads.Items.Clear();
                for(int i=0; i<_lstPendingDownloads.Count; ++i) {
                    _lsbPendingDownloads.Items.Add(_lstPendingDownloads[i]);
                }
                _lsbPendingDownloads.AutoScrollOffset = pt;

                ////
                pt = _lsbDownloads.AutoScrollOffset;
                _lsbDownloads.Items.Clear();
                for(int i=0; i<_lstCurrentDownloads.Count; ++i) {
                    string sval = "";
                    float fval;
                    if(_downloadProgress.TryGetValue(_lstCurrentDownloads[i], out fval)) {
                        sval = fval.ToString("0.0");
                    }
                    _lsbDownloads.Items.Add("[" + sval + "] " + _lstCurrentDownloads[i]);
                }
                _lsbDownloads.AutoScrollOffset = pt;
                ////
                pt = _lsbCompletedDownloads.AutoScrollOffset;
                _lsbCompletedDownloads.Items.Clear();
                for(int i=0; i<_lstCompletedDownloads.Count; ++i) {
                    _lsbCompletedDownloads.Items.Add(_lstCompletedDownloads[i]);
                }
                _lsbCompletedDownloads.AutoScrollOffset = pt;

                //Udpates the progress bar and dir size.
                CheckDirSize();
            }
        }
        private string FormatLinkToFile(string link) {
            int maxFileLength = 128;
            string fn = System.IO.Path.GetFileName(link);
            string fne = System.IO.Path.GetFileNameWithoutExtension(link);
            string ext = System.IO.Path.GetExtension(fn);
            if(fne.Length > maxFileLength) {
                fne = fne.Substring(0,maxFileLength-1) + "~";
            }

            string fn_final = System.IO.Path.Combine(_txtOutputPath.Text, fne + ext);

            return fn_final;
        }

        private void WriteOutput(string text) {
            _txtOutput.BeginInvoke((Action)(() => {
                _txtOutput.AppendText(text + "\r\n");
            }));
        }
        private void _btnTestDownload_Click(object sender, EventArgs e)
        {
            lock(_objListBoxLock)
            {
                _lstPendingDownloads.Add(_txtTestFile.Text);
            }
        }
        List<string> GetDownloadableMediaExtensions() {
            List<string> ret = new List<string>();

            if (_chkGif.Checked==true) {
                ret.Add(".gif");
            }
            if (_chkJpg.Checked==true) {
                ret.Add(".jpg");
                ret.Add(".jpeg");
            }
            if (_chkWebm.Checked==true) {
                ret.Add(".webm");
            }
            if (_chkPng.Checked==true) {
                ret.Add(".png");
            }
            if (_chkMp4.Checked==true) {
                ret.Add(".mp4");
            }
            return ret;
        }


        private void _btnKillAll_Click(object sender, EventArgs e)
        {
           KillAllDownloads();
        }

        private void _btnKillAllPending_Click(object sender, EventArgs e)
        {
            KillAllPending();

        }
        void KillAllPending()
        {
            lock(_objListBoxLock)
            {
                _lstPendingDownloads.Clear();
            }
        }

        private void KillAllDownloads() {
            lock(_objListBoxLock)
            {
                for(int i=_lstCurrentDownloads.Count-1; i>=0; i--) {
                    _lstCurrentDownloads.RemoveAt(i);
                }
            }
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhelp h = new frmhelp();
            h.Show();
        }
        private void _btnShowOutput_Click(object sender, EventArgs e)
        {
            if (_txtOutput.Visible == false)
            {
                _txtOutput.Visible = true;
                Height += _txtOutput.Height;
            }
            else
            {
                _txtOutput.Visible = false;
                Height -= _txtOutput.Height;
            }
        }




        
        private void _chkMp4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void _txtBaseUrl_TextChanged(object sender, EventArgs e)
        {

        }
        private void _chkWebm_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void _lsbDownloads_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void _lsbPendingDownloads_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void _btnClearCompleted_Click(object sender, EventArgs e)
        {
            _lstCompletedDownloads.Clear();
        }

        void ToggleHideOptions(bool b) {
            if(b == false) {
                _gbDownloads.Visible = true;
                _gbSettings.Visible  = true;
                _gbFunction.Visible  = true;
                _gbFileTypes.Visible = true;
                _btnShowOptions.Text = "Hide Options";
                Height += _gbDownloads.Height;
            }
            else {
                _gbDownloads.Visible = false;
                _gbSettings.Visible  = false;
                _gbFunction.Visible  = false;
                _gbFileTypes.Visible = false;
                _btnShowOptions.Text = "Show Options";
                Height -= _gbDownloads.Height;

            }

        }
        private void _btnShowOptions_Click(object sender, EventArgs e)
        {
            ToggleHideOptions(_gbDownloads.Visible);




        }
    }
}
