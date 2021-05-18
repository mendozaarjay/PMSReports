using Reports.Models;
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
using UserAccess.Models;

namespace Reports
{
    public partial class RegularParkers : Form
    {
        public UserAccessItem UserAccess { get; set; }
        private RegularParkerServices services = new RegularParkerServices();
        public RegularParkers()
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
            //btnPrint.Visible = false;
            btnExcel.Visible = btnCsv.Visible = UserAccess.CanExport;
            btnRefresh.Enabled = btnGenerate.Enabled = UserAccess.CanAccess;
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            var result = await services.GetRegularParkersAsync();
            await Spinner.ShowSpinnerAsync(this, PopulateItems(result));
            btnGenerate.Enabled = true;
        }
        private async Task PopulateItems(IEnumerable<RegularParkerModel> items)
        {
            dgDetails.Rows.Clear();
            if(items.Count() > 0)
            {
                dgDetails.Rows.Add(items.Count());
            }
            await Task.Run(() =>
            {
                var row = 0;
                foreach(var item in items)
                {
                    dgDetails[dtlId.Index, row].Value = item.Id;
                    dgDetails[dtlRFID.Index, row].Value = item.RFID;
                    dgDetails[dtlParker.Index, row].Value = item.Parker;
                    dgDetails[dtlCompany.Index, row].Value = item.Company;
                    dgDetails[dtlValidFrom.Index, row].Value = item.ValidFrom;
                    dgDetails[dtlValidTo.Index, row].Value = item.ValidTo;
                    dgDetails[dtlStatus.Index, row].Value = item.Status;
                    row++;
                }
            });
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            btnCsv.Enabled = false;

            var dt = services.GetRegularParkerDataTable();
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Regular Parkers Report";
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
            btnCsv.Enabled = true;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            btnExcel.Enabled = false;
            var dt = services.GetRegularParkerDataTable();
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Regular Parkers Report";
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                ExportToExcelFile.Export(dt, sd.FileName);
            }
            btnExcel.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgDetails.Rows.Count <= 0)
                return;

            var key = Finder.SearchResult();
            dgDetails.FindValue(key);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnGenerate_Click(null, null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var items = services.GetRegularParkerDataTable();
            items.TableName = "RegularParker";
            var viewer = new CrystalViewer();
            viewer.DateCovered = DateTime.Now.ToString("MM/dd/");
            viewer.ReportType = ReportType.RegularParker;
            viewer.DataSource = items;
            viewer.ShowDialog();
        }
    }
}
