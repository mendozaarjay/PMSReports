using Reports.Models;
using Reports.Reports;
using Reports.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using UserAccess.Models;

namespace Reports
{
    public partial class BIR : Form
    {
        private BIRServices services = new BIRServices();
        public UserAccessItem UserAccess { get; set; }
        public BIR()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {

            CheckForIllegalCrossThreadCalls = false;
            GenerateParameters();
            LoadGates();
            LoadAccess();
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
        private void GenerateParameters()
        {
            DataTable dtMonths = new DataTable();
            dtMonths.Columns.Add("Id");
            dtMonths.Columns.Add("Name");

            for (int i = 1; i <= 12; i++)
            {
                var monthname = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                DataRow dr = dtMonths.NewRow();
                dr["Id"] = i;
                dr["Name"] = monthname;
                dtMonths.Rows.Add(dr);
                dtMonths.AcceptChanges();
            }
            cboMonth.DataSource = dtMonths;
            cboMonth.ValueMember = "Id";
            cboMonth.DisplayMember = "Name";

            var currentMonth = DateTime.Now.Month;
            cboMonth.SelectedValue = currentMonth;


            DataTable dtYear = new DataTable();
            dtYear.Columns.Add("Id");
            dtYear.Columns.Add("Name");
            for (int i = 2000; i <= 2050; i++)
            {
                DataRow dr = dtYear.NewRow();
                dr["Id"] = i;
                dr["Name"] = i;
                dtYear.Rows.Add(dr);
                dtYear.AcceptChanges();
            }
            cboYear.DataSource = dtYear;
            cboYear.ValueMember = "Id";
            cboYear.DisplayMember = "Name";
            var currentYear = DateTime.Now.Year;
            cboYear.SelectedValue = currentYear;
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {

            btnGenerate.Enabled = false;
            var month = int.Parse(cboMonth.SelectedValue.ToString());
            var year = int.Parse(cboYear.SelectedValue.ToString());
            var dateFrom = new DateTime(year, month, 1);
            var dateTo = dateFrom.AddMonths(1).AddDays(-1);

            var result = await services.BIRReportAsync(dateFrom, dateTo,cbTerminal.SelectedValue.ToString());
            Spinner.ShowSpinner(this, () =>
             {
                 PopulateBIRReport(result);
             });

            btnGenerate.Enabled = true;

        }
        private void PopulateBIRReport(IEnumerable<BIRModel> items)
        {
            dgBIR.Rows.Clear();
            if(items.Count() > 0)
            {
                dgBIR.Rows.Add(items.Count());
            }
            var row = 0;
            foreach (var item in items)
            {
                dgBIR[dtlDate.Index, row].Value = item.Date;
                dgBIR[dtlBeginningOR.Index, row].Value = item.BeginningOR;
                dgBIR[dtlEndingOR.Index, row].Value = item.EndingOR;
                dgBIR[dtlBeginningSales.Index, row].Value = item.BeginningSales;
                dgBIR[dtlEndingSales.Index, row].Value = item.EndingSales;
                dgBIR[dtlTotalSales.Index, row].Value = item.TotalSales;
                dgBIR[dtlDiscountSC.Index, row].Value = item.DiscountSC;
                dgBIR[dtlDiscountPWD.Index, row].Value = item.DiscountPWD;
                dgBIR[dtlDiscountOthers.Index, row].Value = item.DiscountOthers;
                dgBIR[dtlGrossAmount.Index, row].Value = item.GrossAmount;
                dgBIR[dtlVatable.Index, row].Value = item.Vatable;
                dgBIR[dtlVat.Index, row].Value = item.Vat;
                dgBIR[dtlVatExempt.Index, row].Value = item.VatExempt;
                dgBIR[dtlZeroRated.Index, row].Value = item.ZeroRated;
                dgBIR[dtlResetCount.Index, row].Value = item.ResetCount;
                dgBIR[dtlZCounter.Index, row].Value = item.ZCounter;
                dgBIR[dtlRemarks.Index, row].Value = item.Remarks;
                row++;
            }
            dgBIR.AutoResizeColumns();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            var currentMonth = DateTime.Now.Month;
            cboMonth.SelectedValue = currentMonth;
            var currentYear = DateTime.Now.Year;
            cboYear.SelectedValue = currentYear;
            btnGenerate_Click(null, null);
        }

        private async void btnCsv_Click(object sender, EventArgs e)
        {
            btnCsv.Enabled = false;
            var month = int.Parse(cboMonth.SelectedValue.ToString());
            var year = int.Parse(cboYear.SelectedValue.ToString());
            var dateFrom = new DateTime(year, month, 1);
            var dateTo = dateFrom.AddMonths(1).AddDays(-1);
            var dt = await services.BIRReportDataTableAsync(dateFrom, dateTo, cbTerminal.SelectedValue.ToString());


            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "BIR Report " + dateFrom.ToString("MMddyyy") + "-" + dateTo.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
            btnCsv.Enabled = true;
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            btnExcel.Enabled = false;
            var month = int.Parse(cboMonth.SelectedValue.ToString());
            var year = int.Parse(cboYear.SelectedValue.ToString());
            var dateFrom = new DateTime(year, month, 1);
            var dateTo = dateFrom.AddMonths(1).AddDays(-1);
            var dt = await services.BIRReportDataTableAsync(dateFrom, dateTo, cbTerminal.SelectedValue.ToString());

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "BIR Report " + dateFrom.ToString("MMddyyy") + "-" + dateTo.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                ExportToExcelFile.Export(dt, sd.FileName);
            }
            btnExcel.Enabled = true;
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            var month = int.Parse(cboMonth.SelectedValue.ToString());
            var year = int.Parse(cboYear.SelectedValue.ToString());
            var dateFrom = new DateTime(year, month, 1);
            var dateTo = dateFrom.AddMonths(1).AddDays(-1);
            var dt = await services.BIRReportDataTableAsync(dateFrom, dateTo, cbTerminal.SelectedValue.ToString());


            dt.TableName = "BIR";
            var viewer = new Viewer();
            viewer.DateCovered = dateFrom.ToString("MM/dd/yyyy") + "~" + dateTo.ToString("MM/dd/yyyy");
            viewer.ReportType = ReportType.BIR;
            viewer.Source = dt;
            viewer.ShowDialog();
            btnPrint.Enabled = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgBIR.Rows.Count <= 0)
                return;
            var searchKey = Finder.SearchResult();
            dgBIR.FindValue(searchKey);
        }
    }
}
