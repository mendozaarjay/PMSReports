using Reports.Models;
using Reports.Reports;
using Reports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports
{
    public partial class RemainingCars : Form
    {
        RemainingCarsServices services = new RemainingCarsServices();
        public RemainingCars()
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
            var items = await services.RemainingCarsAsync(dtDate.Value);
            PopulateRemainingCars(items);
            btnGenerate.Enabled = true;
        }

        private void PopulateRemainingCars(IEnumerable<RemainingCarModel> items)
        {
            dgRemainingCars.Rows.Clear();
            if (items.Count() > 0)
                dgRemainingCars.Rows.Add(items.Count());

            var row = 0;

            foreach (var item in items)
            {
                dgRemainingCars[dtlNo.Index, row].Value = item.No;
                dgRemainingCars[dtlTimeIn.Index, row].Value = item.TimeIn;
                dgRemainingCars[dtlPlateNo.Index, row].Value = item.PlateNo;
                dgRemainingCars[dtlTicketNo.Index, row].Value = item.TicketNumber;
                dgRemainingCars[dtlRFIDName.Index, row].Value = item.RFIDName;
                dgRemainingCars[dtlRFIDNo.Index, row].Value = item.RFIDNumber;
                dgRemainingCars[dtlParkerType.Index, row].Value = item.ParkerType;
                row++;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            btnGenerate_Click(null, null);
            btnRefresh.Enabled = true;
        }

        private async void btnCsv_Click(object sender, EventArgs e)
        {
            var dt = await services.RemainingCarsDataTableAsync(dtDate.Value);

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Remaining Cars Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            var dt = await services.RemainingCarsDataTableAsync(dtDate.Value);
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Remaining Cars Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToExcel(dt, "Remaining Cars Report", sd.FileName);
            }
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            var items = await services.RemainingCarsDataTableAsync(dtDate.Value);
            items.TableName = "RemainingCars";
            var viewer = new Viewer();
            viewer.ReportType = ReportType.RemainingCars;
            viewer.Source = items;
            viewer.ShowDialog();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgRemainingCars.Rows.Count < 0)
                return;
            var key = Finder.SearchResult();
            dgRemainingCars.FindValue(key);
        }
    }
}
