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
    public partial class DetailedTransactionSummary : Form
    {
        DetailedTransactionSummaryServices services = new DetailedTransactionSummaryServices();
        public DetailedTransactionSummary()
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
            var result = await services.DetailedTransactionSummaryAsync(dtFrom.Value.Minimun(), dtTo.Value.Maximum(), txtSearch.Text.Trim());
            PopulateDetailedTransactionSummary(result);
            btnGenerate.Enabled = true;
        }

        private void PopulateDetailedTransactionSummary(IEnumerable<DetailedTransactionSummaryModel> items)
        {
            dgDetailedTransaction.Rows.Clear();
            if (items.Count() > 0)
                dgDetailedTransaction.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgDetailedTransaction[dtlTransitId.Index, row].Value = item.TransitId;
                dgDetailedTransaction[dtlLocation.Index, row].Value = item.Location;
                dgDetailedTransaction[dtlORNumber.Index, row].Value = item.ORNumber;
                dgDetailedTransaction[dtlRateName.Index, row].Value = item.RateName;
                dgDetailedTransaction[dtlTimeIn.Index, row].Value = item.TimeIn;
                dgDetailedTransaction[dtlTimeOut.Index, row].Value = item.TimeOut;
                dgDetailedTransaction[dtlDuration.Index, row].Value = item.Duration;
                dgDetailedTransaction[dtlTotalHours.Index, row].Value = item.TotalHours;
                dgDetailedTransaction[dtlPlateNo.Index, row].Value = item.PlateNo;
                dgDetailedTransaction[dtlAmount.Index, row].Value = item.Amount;
                dgDetailedTransaction[dtlCardNumber.Index, row].Value = item.CardNumber;
                dgDetailedTransaction[dtlCashier.Index, row].Value = item.Cashier;
                row++;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            txtSearch.Clear();
            btnGenerate_Click(null, null);
            btnRefresh.Enabled = true;
        }

        private async void btnCsv_Click(object sender, EventArgs e)
        {
            var dt = await services.DetailedTransactionSummaryDatatableAsync(dtFrom.Value.Minimun(), dtTo.Value.Maximum(), txtSearch.Text.Trim());
            dt.Columns.Remove("TransitId");
            dt.AcceptChanges();

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Detailed Transaction Summary Report " + dtFrom.Value.ToString("MMddyyy") + "-" + dtTo.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            var dt = await services.DetailedTransactionSummaryDatatableAsync(dtFrom.Value.Minimun(), dtTo.Value.Maximum(), txtSearch.Text.Trim());
            dt.Columns.Remove("TransitId");
            dt.AcceptChanges();

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Detailed Transaction Summary Report " + dtFrom.Value.ToString("MMddyyy") + "-" + dtTo.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToExcel(dt, "Detailed Transaction Summary Report", sd.FileName);
            }
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            var dt = await services.DetailedTransactionSummaryDatatableAsync(dtFrom.Value.Minimun(), dtTo.Value.Maximum(), txtSearch.Text.Trim());
            dt.Columns.Remove("TransitId");
            dt.AcceptChanges();

            dt.TableName = "DetailedTransactionSummary";
            var viewer = new Viewer();
            viewer.ReportType = ReportType.DetailedTransactionSummaryReport;
            viewer.Source = dt;
            viewer.ShowDialog();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgDetailedTransaction.Rows.Count <= 0)
                return;

            var key = Finder.SearchResult();
            dgDetailedTransaction.FindValue(key);
        }

        private void dgDetailedTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;
            if(e.ColumnIndex == dtlImage.Index)
            {
                var id = int.Parse(dgDetailedTransaction[dtlTransitId.Index, e.RowIndex].Value.ToString());
                ImageViewer.ShowImage(id);
            }
        }
    }
}
