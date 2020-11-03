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
    public partial class HourlyAccountability : Form
    {
        private HourlyAccountabilityServices services = new HourlyAccountabilityServices();
        public UserAccessItem UserAccess { get; set; }
        public HourlyAccountability()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            LoadAccess();
            LoadGates();
            timeFrom.Value = DateTime.Now.Minimun();
            timeTo.Value = DateTime.Now.Maximum();
            base.OnLoad(e);
        }
        private void LoadAccess()
        {
            btnPrint.Visible = UserAccess.CanPrint;
            btnExcel.Visible = btnCsv.Visible = UserAccess.CanExport;
            btnRefresh.Enabled = btnGenerate.Enabled = UserAccess.CanAccess;
        }
        private void LoadGates()
        {
            var items = services.Gates();
            cbTerminal.DataSource = items;
            cbTerminal.ValueMember = "Id";
            cbTerminal.DisplayMember = "Name";
        }
        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var items = await services.HourlyAccountabilityReportAsync(from, to, cbTerminal.SelectedValue.ToString());
            Spinner.ShowSpinner(this, () =>
            {
                PopulateHourlyAccountability(items);
            });

            btnGenerate.Enabled = true;
        }

        private void PopulateHourlyAccountability(IEnumerable<HourlyAccountabilityModel> items)
        {
            dgHourlyAccountability.Rows.Clear();
            if (items.Count() > 0)
                dgHourlyAccountability.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgHourlyAccountability[dtlTime.Index, row].Value = item.TimeString;
                dgHourlyAccountability[dtlTotalCard.Index, row].Value = item.TotalCard;
                dgHourlyAccountability[dtlTotalAmount.Index, row].Value = item.TotalAmount;
                row++;
            }
            dgHourlyAccountability.AutoResizeColumns();
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
            var dt = await services.HourlyAccountabilityReportDatatableAsync(from, to, cbTerminal.SelectedValue.ToString());
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Hourly Accountability Report " + from.ToString("MMddyyyy hhmmsstt") + "-" + to.ToString("MMddyyyy hhmmsstt");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
            btnCsv.Enabled = true;
        }

        private  async void btnExcel_Click(object sender, EventArgs e)
        {
            btnExcel.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var dt = await services.HourlyAccountabilityReportDatatableAsync(from, to, cbTerminal.SelectedValue.ToString());

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Hourly Accountability Report " + from.ToString("MMddyyyy hhmmsstt") + "-" + to.ToString("MMddyyyy hhmmsstt");
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
            var items = await services.HourlyAccountabilityReportDatatableAsync(from, to, cbTerminal.SelectedValue.ToString());
            items.TableName = "HourlyAccountability";
            var viewer = new Viewer();
            viewer.ReportType = ReportType.HourlyAccountability;
            viewer.DateCovered = from.ToString() + "-" + to.ToString();
            viewer.Source = items;
            viewer.ShowDialog();
            btnPrint.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgHourlyAccountability.Rows.Count < 0)
                return;
            var key = Finder.SearchResult();
            dgHourlyAccountability.FindValue(key);
        }
    }
}
