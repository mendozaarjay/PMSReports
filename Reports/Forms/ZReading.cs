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
    public partial class ZReading : Form
    {
        private ZReadingServices services = new ZReadingServices();
        public UserAccessItem UserAccess { get; set; }
        public ZReading()
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

            var result = await services.ZReadingAsync(dateFrom, dateTo,cbTerminal.SelectedValue.ToString());
            PopulateReport(result);
            btnGenerate.Enabled = true;
        }

        private void PopulateReport(IEnumerable<ZReadingModel> items)
        {
            dgReading.Rows.Clear();
            if (items.Count() > 0)
                dgReading.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgReading[dtlDate.Index, row].Value = item.Date;
                dgReading[dtlTime.Index, row].Value = item.Time;
                dgReading[dtlNewORNo.Index, row].Value = item.NewORNo;
                dgReading[dtlOldORNo.Index, row].Value = item.OldORNo;
                dgReading[dtlNewFRNo.Index, row].Value = item.NewFRNo;
                dgReading[dtlOldFRNo.Index, row].Value = item.OldFRNo;
                dgReading[dtlTodaySales.Index, row].Value = item.TodaySales;
                dgReading[dtlNewSales.Index, row].Value = item.NewSales;
                dgReading[dtlOldSales.Index, row].Value = item.OldSales;
                row++;
            }
            dgReading.AutoResizeColumns();
        }

        private async void btnCsv_Click(object sender, EventArgs e)
        {
            btnCsv.Enabled = false;
            var month = int.Parse(cboMonth.SelectedValue.ToString());
            var year = int.Parse(cboYear.SelectedValue.ToString());
            var dateFrom = new DateTime(year, month, 1);
            var dateTo = dateFrom.AddMonths(1).AddDays(-1);
            var dt = await services.ZReadingDataTableAsync(dateFrom, dateTo, cbTerminal.SelectedValue.ToString());


            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "ZReading Report " + dateFrom.ToString("MMddyyy") + "-" + dateTo.ToString("MMddyyyy");
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
            var dt = await services.ZReadingDataTableAsync(dateFrom, dateTo, cbTerminal.SelectedValue.ToString());

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "ZReading Report " + dateFrom.ToString("MMddyyy") + "-" + dateTo.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToExcel(dt, "ZReading Report", sd.FileName);
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
            var dt = await services.ZReadingDataTableAsync(dateFrom, dateTo, cbTerminal.SelectedValue.ToString());


            dt.TableName = "ZReading";
            var viewer = new Viewer();
            viewer.DateCovered = dateFrom.ToString("MM/dd/yyyy") + "~" + dateTo.ToString("MM/dd/yyyy");
            viewer.ReportType = ReportType.ZReading;
            viewer.Source = dt;
            viewer.ShowDialog();
            btnPrint.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgReading.Rows.Count <= 0)
                return;
            var searchKey = Finder.SearchResult();
            dgReading.FindValue(searchKey);
        }
    }
}
