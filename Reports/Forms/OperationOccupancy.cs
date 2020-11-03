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
    public partial class OperationOccupancy : Form
    {
        private OperationOccupancyServices services = new OperationOccupancyServices();
        public UserAccessItem UserAccess { get; set; }
        public OperationOccupancy()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            LoadAccess();
            base.OnLoad(e);
        }
        private void LoadAccess()
        {
            btnPrint.Visible = UserAccess.CanPrint;
            btnExcel.Visible = btnCsv.Visible = UserAccess.CanExport;
            btnRefresh.Enabled = btnGenerate.Enabled = UserAccess.CanAccess;
        }
        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            var items = await services.OperationOccupancyReportAsync(dtDate.Value);
            Spinner.ShowSpinner(this, () =>
            {
                PopulateOperationOccupancy(items);
            });

            btnGenerate.Enabled = true;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            btnGenerate_Click(null, null);
            btnRefresh.Enabled = true;
        }
        private void PopulateOperationOccupancy(IEnumerable<OperationOccupancyModel> items)
        {
            dgOperation.Rows.Clear();
            if (items.Count() > 0)
                dgOperation.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgOperation[dtlDurationHours.Index, row].Value = item.Time;
                dgOperation[dtlIn.Index, row].Value = item.In;
                dgOperation[dtlOut.Index, row].Value = item.Out;
                dgOperation[dtlRemaining.Index, row].Value = item.Remaining;
                row++;
            }
            dgOperation.AutoResizeColumns();
        }

        private async void btnCsv_Click(object sender, EventArgs e)
        {
            btnCsv.Enabled = false;
            var dt = await services.OperationOccupancyReportDataTableAsync(dtDate.Value);

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Operation Occupancy Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
            btnCsv.Enabled = true;
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            btnExcel.Enabled = false;
            var dt = await services.OperationOccupancyReportDataTableAsync(dtDate.Value);

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Operation Occupancy Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                ExportToExcelFile.Export(dt, sd.FileName);
            }
            btnExcel.Enabled = true;
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            var items = await services.OperationOccupancyReportDataTableAsync(dtDate.Value);
            items.TableName = "OperationOccupancy";
            var viewer = new Viewer();
            viewer.DateCovered = dtDate.Value.ToString("MM/dd/yyyy");
            viewer.ReportType = ReportType.OperationOccupancy;
            viewer.Source = items;
            viewer.ShowDialog();
            btnPrint.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgOperation.Rows.Count < 0)
                return;
            var key = Finder.SearchResult();
            dgOperation.FindValue(key);
        }
    }
}
