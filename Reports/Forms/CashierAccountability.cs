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
using UserAccess.Models;

namespace Reports
{
    public partial class CashierAccountability : Form
    {
        private CashierAccountabilityServices services = new CashierAccountabilityServices();
        public UserAccessItem UserAccess { get; set; }
        public CashierAccountability()
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

            var terminal = int.Parse(cbTerminal.SelectedValue.ToString());
            var items =  await services.CashierAccountabilityAsync(from,to, terminal);
            Spinner.ShowSpinner(this, () =>
            {
                LoadCashierAccountability(items);
            });

            btnGenerate.Enabled = true;
        }

        private void LoadCashierAccountability(IEnumerable<CashierAccountabilityModel> items)
        {
            dgCashierAccountability.Rows.Clear();
            if (items.Count() > 0)
                dgCashierAccountability.Rows.Add(items.Count());
            var row = 0;
            foreach(var item in items)
            {
                dgCashierAccountability[dtlCarParkIncome.Index, row].Value = item.CarParkIncome;
                dgCashierAccountability[dtlReceiptsOut.Index, row].Value = item.ReceiptsOut;
                dgCashierAccountability[dtlAmount.Index, row].Value = item.Amount;
                row++;
            }
            dgCashierAccountability.AutoResizeColumns();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            btnGenerate_Click(null, null);
            btnRefresh.Enabled = true;
        }

        private  async void btnCsv_Click(object sender, EventArgs e)
        {
            btnCsv.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);

            var terminal = int.Parse(cbTerminal.SelectedValue.ToString());
            var dt = await services.CashierAccountabilityDataTableAsync(from,to,terminal);
            dt.Columns.Remove("Row");
            dt.AcceptChanges();
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Cashier Accountability Report " + from.ToString("MMddyyyy hhmmsstt") + "-" + to.ToString("MMddyyyy hhmmsstt");
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

            var terminal = int.Parse(cbTerminal.SelectedValue.ToString());
            var dt = await services.CashierAccountabilityDataTableAsync(from,to, terminal);
            dt.Columns.Remove("Row");
            dt.AcceptChanges();
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Cashier Accountability Report " + from.ToString("MMddyyyy hhmmsstt") + "-" + to.ToString("MMddyyyy hhmmsstt");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                ExportToExcelFile.Export(dt, sd.FileName);
            }
            btnExcel.Enabled = true;
        }
        CashlessSummaryServices summaryServices = new CashlessSummaryServices();
        private async void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            var sources = new List<DataTable>();
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var terminal = int.Parse(cbTerminal.SelectedValue.ToString());
            var items = await services.CashierAccountabilityDataTableAsync(from, to , terminal);
            items.TableName = "dsSource";
            sources.Add(items);

            var cashlessSummary = await summaryServices.CashlessSummaryDataTableAsync(from, to, cbTerminal.SelectedValue.ToString());
            cashlessSummary.TableName = "CashlessSummary";
            sources.Add(cashlessSummary);

            var viewer = new Viewer();
            viewer.DateCovered = from.ToString() + "-" + to.ToString();
            viewer.ReportType = ReportType.CashierAccountability;
            viewer.ReportSources = sources;
            viewer.IsMultipleSource = true;
            viewer.ShowDialog();
            btnPrint.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgCashierAccountability.Rows.Count < 0)
                return;
            var key = Finder.SearchResult();
            dgCashierAccountability.FindValue(key);
        }
    }
}
