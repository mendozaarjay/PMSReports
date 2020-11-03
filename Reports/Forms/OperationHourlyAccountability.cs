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
    public partial class OperationHourlyAccountability : Form
    {
        private OperationHourlyAccountabilityServices services = new OperationHourlyAccountabilityServices();
        public UserAccessItem UserAccess { get; set; }
        public OperationHourlyAccountability()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            LoadGates();
            LoadAccess();
            timeFrom.Value = DateTime.Now.Minimun();
            timeTo.Value = DateTime.Now.Maximum();
            base.OnLoad(e);
        }
        private void LoadGates()
        {
            var items = services.Gates();
            cbTerminal.DataSource = items;
            cbTerminal.ValueMember = "Id";
            cbTerminal.DisplayMember = "Name";
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
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var items = await services.OperationHourlyAccountabilityAsync(from,to,cbTerminal.SelectedValue.ToString());
            Spinner.ShowSpinner(this, () =>
            {
                LoadOperationHourlyAccountability(items);
            });

            btnGenerate.Enabled = true;
        }

        private void LoadOperationHourlyAccountability(IEnumerable<OperationHourlyAccountabilityModel> items)
        {
            dgOperation.Rows.Clear();
            if (items.Count() > 0)
                dgOperation.Rows.Add(items.Count());
            var row = 0;
            foreach(var item in items)
            {
                dgOperation[dtlDuration.Index, row].Value = item.DurationHours;
                dgOperation[dtlNumberOfVehicles.Index, row].Value = item.NumberOfVehicles;
                dgOperation[dtlAmount.Index, row].Value = item.Amount;
                row++;
            }
            dgOperation.AutoResizeColumns();
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
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var dt = await services.OperationHourlyAccountabilityDataTableAsync(from, to, cbTerminal.SelectedValue.ToString());

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Operation Hourly Accountability Report " + from.ToString("MMddyyyy hhmmsstt") + "-" + to.ToString("MMddyyyy hhmmsstt");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
            btnCsv.Enabled = true;
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            btnExcel.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var dt = await services.OperationHourlyAccountabilityDataTableAsync(from, to, cbTerminal.SelectedValue.ToString());
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Operation Hourly Accountability Report " + from.ToString("MMddyyyy hhmmsstt") + "-" + to.ToString("MMddyyyy hhmmsstt");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                ExportToExcelFile.Export(dt, sd.FileName);
            }
            btnExcel.Enabled = true;
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var items = await services.OperationHourlyAccountabilityDataTableAsync(from, to, cbTerminal.SelectedValue.ToString());
            items.TableName = "OperationHourlyAccountability";
            var viewer = new Viewer();
            viewer.DateCovered = from.ToString() + "-" + to.ToString();
            viewer.ReportType = ReportType.OperationHourlyAccountability;
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
