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
namespace DirPoll
{
    public partial class StatsForm : MetroForm
    {
        public string Status = "";//program status;
        public double WritesPerSecond = 0;
        public int NumberOfScans = 0;
        public int FileCount = 0;
        public int ScanCount = 0;
        public int NewCount = 0;
        public long AverageScanTimeMs = 0;
        public long LastScanTimeMs = 0;
        public double CurrentScanPct = 0;//[0,1]

        public double DeletedPerSecond = 0;
        public double AddedPerSecond = 0;
        public double ChangedPerSecond = 0;

        public double AvgDeletedPerScan = 0;
        public double AvgAddedPerScan = 0;
        public double AvgChangedPerScan = 0;

        public List<FsItem> TopFileWriteList = new List<FsItem>();

        public StatsForm()
        {
            InitializeComponent();
        }
        public string FmtTime(long d)
        {
            return TimeSpan.FromMilliseconds(d).ToString(@"hh\:mm\:ss\:fff");
        }
        public string FmtDec(double d)
        {
            return string.Format("{0:0.00}", d);
        }
        public void Update( bool statusOnly = false)
        {
            _lblStatus.Text = Status;
            _pgbCurrentScan.Minimum = 0;
            _pgbCurrentScan.Maximum = 100;
            _lblCurrentScanPct.Text = string.Format("{0:0.0%}", CurrentScanPct);
            _pgbCurrentScan.Value = (int)(CurrentScanPct * 100);

            if (!statusOnly)
            {
                _lblMemory.Text = "Mem Usage: " + GC.GetTotalMemory(true).ToString() + "k";
                //public Decimal AverageScanTime = 0;

                _lblAverageScanTime.Text = "Average Scan Time: " + FmtTime(AverageScanTimeMs);
                _lblScanCount.Text = "Total Directory Scans: " + NumberOfScans;

                _lblLastScanTime.Text = "Last Scan Time: " + FmtTime(LastScanTimeMs);
                _lblScannedItemCount.Text = "Number of Files (Last Scan): " + FileCount;
                _lblScanCount.Text = "Total Files Scanned (Last Scan): " + ScanCount;
                _lblNewFiles.Text = "Number of New Items (Last Scan): " + NewCount;

                _lblAddedPerScan.Text = "Avg Items Added Per Scan: " + FmtDec(AvgAddedPerScan);
                _lblChangedPerScan.Text = "Avg Items Changed Per Scan: " + FmtDec(AvgChangedPerScan);
                _lblDeletedPerScan.Text = "Avg Items Deleted Per Scan: " + FmtDec(AvgDeletedPerScan);

                _lblAddedPerSecond.Text = "Avg Items Added Per Second:" + FmtDec(AddedPerSecond);
                _lblChangedPerSecond.Text = "Avg Items Changed Per Second:" + FmtDec(ChangedPerSecond);
                _lblDeletedPerSecond.Text = "Avg Items Deleted Per Second:" + FmtDec(DeletedPerSecond);
                //        _lblperse
                //                public double DeletedPerSecond = 0;
                //public double AddedPerSecond = 0;
                //public double ChangedPerSecond = 0;
                _grdTopFileChanges.Rows.Clear();

                foreach(FsItem fs in this.TopFileWriteList)
                {

                    _grdTopFileChanges.Rows.Add(fs.FullPath, fs.WriteCount);
                }


            }

        }
        private void StatsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void _grdTopFileChanges_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StatsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void _cboNumTopFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveData();
        }

        private void LoadData()
        {
            Globals.SelectCboItem(_cboNumTopFiles, Globals.Settings.NumTopFiles.ToString(), 5);
        }

        private void SaveData()
        {
            Globals.Settings.NumTopFiles = Globals.ToInt(_cboNumTopFiles.SelectedItem as string, 5);
        }

    }
}
