using Reports.Models;
using Reports.Reports;
using Reports.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports
{
    public partial class HourlyAccountability : Form
    {
        private HourlyAccountabilityServices services = new HourlyAccountabilityServices();
        public HourlyAccountability()
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
            var items = await services.HourlyAccountabilityReportAsync(dtDate.Value);
            PopulateHourlyAccountability(items);
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
                dgHourlyAccountability[dtlCardCounter.Index, row].Value = item.CardCounter;
                dgHourlyAccountability[dtlTotalAmount.Index, row].Value = item.TotalAmount;
                dgHourlyAccountability[dtlAmountCounter.Index, row].Value = item.AmountCounter;
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
            var dt = await services.HourlyAccountabilityReportDatatableAsync(dtDate.Value);

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Hourly Accountability Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
            btnCsv.Enabled = true;
        }

        private  async void btnExcel_Click(object sender, EventArgs e)
        {
            btnExcel.Enabled = false;
            var dt = await services.HourlyAccountabilityReportDatatableAsync(dtDate.Value);

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Hourly Accountability Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToExcel(dt, "Hourly Accountability Report", sd.FileName);
            }
            btnExcel.Enabled = true;
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            var items = await services.HourlyAccountabilityReportDatatableAsync(dtDate.Value);
            items.TableName = "HourlyAccountability";
            var viewer = new Viewer();
            viewer.ReportType = ReportType.HourlyAccountability;
            viewer.DateCovered = dtDate.Value.ToString("MM/dd/yyyy");
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
