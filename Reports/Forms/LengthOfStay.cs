using Reports.Models;
using Reports.Reports;
using Reports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UserAccess.Models;

namespace Reports
{
    public partial class LengthOfStay : Form
    {
        private LengthOfStayServices services = new LengthOfStayServices();
        public UserAccessItem UserAccess { get; set; }
        public LengthOfStay()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            base.OnLoad(e);
        }
        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            var items = await services.LengthOfStayAsync(dtDate.Value);
            PopulateLengthOfStay(items);
            btnGenerate.Enabled = true;
        }

        private void PopulateLengthOfStay(IEnumerable<LengthOfStayModel> items)
        {
            dgLengthOfStay.Rows.Clear();
            if (items.Count() > 0)
                dgLengthOfStay.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgLengthOfStay[dtlDuration.Index, row].Value = item.DurationHour;
                dgLengthOfStay[dtlNumberOfVehicles.Index, row].Value = item.NumberOfVehicles;
                dgLengthOfStay[dtlAmount.Index, row].Value = item.Amount;
                row++;
            }
            dgLengthOfStay.AutoResizeColumns();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            btnGenerate_Click(null, null);
            btnRefresh.Enabled = true;
        }

        private async void btnCsv_Click(object sender, EventArgs e)
        {
            btnCsv.Enabled = false;
            var dt = await services.LengthOfStayDataTableAsync(dtDate.Value);

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Length Of Stay Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
            btnCsv.Enabled = true;
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            btnExcel.Enabled = false;
            var dt = await services.LengthOfStayDataTableAsync(dtDate.Value);

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Length Of Stay Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToExcel(dt, "Length Of Stay Report", sd.FileName);
            }
            btnExcel.Enabled = true;
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            var items = await services.LengthOfStayDataTableAsync(dtDate.Value);
            items.TableName = "LengthOfStay";
            var viewer = new Viewer();
            viewer.DateCovered = dtDate.Value.ToString("MM/dd/yyyy");
            viewer.ReportType = ReportType.LengthOfStay;
            viewer.Source = items;
            viewer.ShowDialog();
            btnPrint.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgLengthOfStay.Rows.Count < 0)
                return;
            var key = Finder.SearchResult();
            dgLengthOfStay.FindValue(key);
        }
    }
}
