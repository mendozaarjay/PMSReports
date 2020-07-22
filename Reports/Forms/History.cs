using Reports.Models;
using Reports.Reports;
using Reports.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UserAccess.Models;

namespace Reports
{
    public partial class History : Form
    {
        private HistoryServices services = new HistoryServices();
        public UserAccessItem UserAccess { get; set; }
        public History()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            timeFrom.Value = DateTime.Now.Minimun();
            timeTo.Value = DateTime.Now.Maximum();
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
        private async void  btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;

            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);

            var items = await services.GetHistoryReportAsync(from,to,txtSearch.Text.Trim());

            var parkerIn = items.Where(a => a.MonthlyName == "" && a.TimeOut == "");
            var parkerOut = items.Where(a => a.MonthlyName == "");

            var monthlyIn = items.Where(a => a.MonthlyName != "" && a.TimeOut == "");
            var monthlyOut = items.Where(a => a.MonthlyName != "");

            PopulateHistoryAll(items);
            PopulateHistoryParkerIn(parkerIn);
            PopulateHistoryParkerOut(parkerOut);
            PopulateHistoryMonthlyIn(monthlyIn);
            PopulateHistoryMonthlyOut(monthlyOut);
            btnGenerate.Enabled = true;
        }
        private void PopulateHistoryAll(IEnumerable<HistoryModel> items)
        {
            dgHistoryAll.Rows.Clear();
            if (items.Count() > 0)
                dgHistoryAll.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgHistoryAll[dtlAllRow.Index, row].Value = row + 1;
                dgHistoryAll[dtlAllTransitId.Index, row].Value = item.Id;
                dgHistoryAll[dtlAllTerminal.Index, row].Value = item.Terminal;
                dgHistoryAll[dtlAllORNo.Index, row].Value = item.ORNumber;
                dgHistoryAll[dtlAllPlateNo.Index, row].Value = item.PlateNo;
                dgHistoryAll[dtlAllTicketNo.Index, row].Value = item.TicketNumber;
                dgHistoryAll[dtlAllDateTimeIn.Index, row].Value = item.TimeIn;
                dgHistoryAll[dtlAllDateTimeOut.Index, row].Value = item.TimeOut;
                dgHistoryAll[dtlAllDurationOfStay.Index, row].Value = item.Duration;
                dgHistoryAll[dtlAllRatesName.Index, row].Value = item.RateName;
                dgHistoryAll[dtlAllCoupon.Index, row].Value = item.Coupon;
                dgHistoryAll[dtlAllMonthlyRFID.Index, row].Value = item.MonthlyRFID;
                dgHistoryAll[dtlAllMonthlyName.Index, row].Value = item.MonthlyName;
                dgHistoryAll[dtlAllUpdateDate.Index, row].Value = item.UpdateDate;
                dgHistoryAll[dtlAllUpdateUser.Index, row].Value = item.UpdateUser;
                dgHistoryAll[dtlAllUpdateId.Index, row].Value = item.UpdateId;
                row++;
            }
            dgHistoryAll.AutoResizeColumns();
        }
        private void PopulateHistoryParkerIn(IEnumerable<HistoryModel> items)
        {
            dgParkerIn.Rows.Clear();
            if (items.Count() > 0)
                dgParkerIn.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgParkerIn[dtlParkerInRow.Index, row].Value = row + 1;
                dgParkerIn[dtlParkerInTransitId.Index, row].Value = item.Id;
                dgParkerIn[dtlParkerInTerminal.Index, row].Value = item.Terminal;
                dgParkerIn[dtlParkerInORNo.Index, row].Value = item.ORNumber;
                dgParkerIn[dtlParkerInPlateNo.Index, row].Value = item.PlateNo;
                dgParkerIn[dtlParkerInTicketNo.Index, row].Value = item.TicketNumber;
                dgParkerIn[dtlParkerInDateTimeIn.Index, row].Value = item.TimeIn;
                dgParkerIn[dtlParkerInDateTimeOut.Index, row].Value = item.TimeOut;
                dgParkerIn[dtlParkerInDurationOfStay.Index, row].Value = item.Duration;
                dgParkerIn[dtlParkerInRatesName.Index, row].Value = item.RateName;
                dgParkerIn[dtlParkerInCoupon.Index, row].Value = item.Coupon;
                dgParkerIn[dtlParkerInMonthlyRFID.Index, row].Value = item.MonthlyRFID;
                dgParkerIn[dtlParkerInMonthlyName.Index, row].Value = item.MonthlyName;
                dgParkerIn[dtlParkerInUpdateDate.Index, row].Value = item.UpdateDate;
                dgParkerIn[dtlParkerInUpdateUser.Index, row].Value = item.UpdateUser;
                dgParkerIn[dtlParkerInUpdateId.Index, row].Value = item.UpdateId;
                row++;
            }
            dgParkerIn.AutoResizeColumns();
        }
        private void PopulateHistoryParkerOut(IEnumerable<HistoryModel> items)
        {
            dgParkerOut.Rows.Clear();
            if (items.Count() > 0)
                dgParkerOut.Rows.Add(items.Count());

            var row = 0;

            foreach (var item in items)
            {
                dgParkerOut[dtlParkerOutRow.Index, row].Value = row + 1;
                dgParkerOut[dtlParkerOutTransitId.Index, row].Value = item.Id;
                dgParkerOut[dtlParkerOutTerminal.Index, row].Value = item.Terminal;
                dgParkerOut[dtlParkerOutORNo.Index, row].Value = item.ORNumber;
                dgParkerOut[dtlParkerOutPlateNo.Index, row].Value = item.PlateNo;
                dgParkerOut[dtlParkerOutTicketNo.Index, row].Value = item.TicketNumber;
                dgParkerOut[dtlParkerOutDateTimeIn.Index, row].Value = item.TimeIn;
                dgParkerOut[dtlParkerOutDateTimeOut.Index, row].Value = item.TimeOut;
                dgParkerOut[dtlParkerOutDurationOfStay.Index, row].Value = item.Duration;
                dgParkerOut[dtlParkerOutRatesName.Index, row].Value = item.RateName;
                dgParkerOut[dtlParkerOutCoupon.Index, row].Value = item.Coupon;
                dgParkerOut[dtlParkerOutMonthlyRFID.Index, row].Value = item.MonthlyRFID;
                dgParkerOut[dtlParkerOutMonthlyName.Index, row].Value = item.MonthlyName;
                dgParkerOut[dtlParkerOutUpdateDate.Index, row].Value = item.UpdateDate;
                dgParkerOut[dtlParkerOutUpdateUser.Index, row].Value = item.UpdateUser;
                dgParkerOut[dtlParkerOutUpdateId.Index, row].Value = item.UpdateId;
                row++;
            }
            dgParkerOut.AutoResizeColumns();
        }

        private void PopulateHistoryMonthlyIn(IEnumerable<HistoryModel> items)
        {
            dgMonthlyIn.Rows.Clear();
            if (items.Count() > 0)
                dgMonthlyIn.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgMonthlyIn[dtlMonthlyInRow.Index, row].Value = row + 1;
                dgMonthlyIn[dtlMonthlyInTransitId.Index, row].Value = item.Id;
                dgMonthlyIn[dtlMonthlyInTerminal.Index, row].Value = item.Terminal;
                dgMonthlyIn[dtlMonthlyInORNo.Index, row].Value = item.ORNumber;
                dgMonthlyIn[dtlMonthlyInPlateNo.Index, row].Value = item.PlateNo;
                dgMonthlyIn[dtlMonthlyInTicketNo.Index, row].Value = item.TicketNumber;
                dgMonthlyIn[dtlMonthlyInDateTimeIn.Index, row].Value = item.TimeIn;
                dgMonthlyIn[dtlMonthlyInDateTimeOut.Index, row].Value = item.TimeOut;
                dgMonthlyIn[dtlMonthlyInDurationOfStay.Index, row].Value = item.Duration;
                dgMonthlyIn[dtlMonthlyInRatesName.Index, row].Value = item.RateName;
                dgMonthlyIn[dtlMonthlyInCoupon.Index, row].Value = item.Coupon;
                dgMonthlyIn[dtlMonthlyInMonthlyRFID.Index, row].Value = item.MonthlyRFID;
                dgMonthlyIn[dtlMonthlyInMonthlyName.Index, row].Value = item.MonthlyName;
                dgMonthlyIn[dtlMonthlyInUpdateDate.Index, row].Value = item.UpdateDate;
                dgMonthlyIn[dtlMonthlyInUpdateUser.Index, row].Value = item.UpdateUser;
                dgMonthlyIn[dtlMonthlyInUpdateId.Index, row].Value = item.UpdateId;
                row++;
            }
            dgMonthlyIn.AutoResizeColumns();
        }
        private void PopulateHistoryMonthlyOut(IEnumerable<HistoryModel> items)
        {
            dgMonthlyOut.Rows.Clear();
            if (items.Count() > 0)
                dgMonthlyOut.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgMonthlyOut[dtlMonthlyOutRow.Index, row].Value = row + 1;
                dgMonthlyOut[dtlMonthlyOutTransitId.Index, row].Value = item.Id;
                dgMonthlyOut[dtlMonthlyOutTerminal.Index, row].Value = item.Terminal;
                dgMonthlyOut[dtlMonthlyOutORNo.Index, row].Value = item.ORNumber;
                dgMonthlyOut[dtlMonthlyOutPlateNo.Index, row].Value = item.PlateNo;
                dgMonthlyOut[dtlMonthlyOutTicketNo.Index, row].Value = item.TicketNumber;
                dgMonthlyOut[dtlMonthlyOutDateTimeIn.Index, row].Value = item.TimeIn;
                dgMonthlyOut[dtlMonthlyOutDateTimeOut.Index, row].Value = item.TimeOut;
                dgMonthlyOut[dtlMonthlyOutDurationOfStay.Index, row].Value = item.Duration;
                dgMonthlyOut[dtlMonthlyOutRatesName.Index, row].Value = item.RateName;
                dgMonthlyOut[dtlMonthlyOutCoupon.Index, row].Value = item.Coupon;
                dgMonthlyOut[dtlMonthlyOutMonthlyRFID.Index, row].Value = item.MonthlyRFID;
                dgMonthlyOut[dtlMonthlyOutMonthlyName.Index, row].Value = item.MonthlyName;
                dgMonthlyOut[dtlMonthlyOutUpdateDate.Index, row].Value = item.UpdateDate;
                dgMonthlyOut[dtlMonthlyOutUpdateUser.Index, row].Value = item.UpdateUser;
                dgMonthlyOut[dtlMonthlyOutUpdateId.Index, row].Value = item.UpdateId;
                row++;
            }
            dgMonthlyOut.AutoResizeColumns();
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            btnExcel.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var dt = await services.GetHistoryDataTableAsync(from,to, txtSearch.Text.Trim());
            dt.Columns.Remove("TransitId");
            dt.AcceptChanges();

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "History Report " + dtFrom.Value.ToString("MMddyyy") + "-" + dtTo.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToExcel(dt, "History Report", sd.FileName);
            }
            btnExcel.Enabled = true;
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);

            var items = await services.GetHistoryDataTableAsync(from,to, txtSearch.Text.Trim());
            items.Columns.Remove("TransitId");
            items.AcceptChanges();

            items.TableName = "History";
            var viewer = new Viewer();
            viewer.DateCovered = from.ToString() + "~" + to.ToString();
            viewer.ReportType = ReportType.History;
            viewer.Source = items;
            viewer.ShowDialog();
            btnPrint.Enabled = true;
        }

        private async void btnCsv_Click(object sender, EventArgs e)
        {
            btnCsv.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);

            var dt = await services.GetHistoryDataTableAsync(from,to, txtSearch.Text.Trim());
            dt.Columns.Remove("TransitId");
            dt.AcceptChanges();

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "History Report " + dtFrom.Value.ToString("MMddyyy") + "-" + dtTo.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
            btnCsv.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgHistoryAll.Rows.Count <= 0)
                return;

            var key = Finder.SearchResult();
            dgHistoryAll.FindValue(key);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            txtSearch.Clear();
            btnGenerate_Click(null, null);
            btnRefresh.Enabled = true;
        }

        private void dgHistoryAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if(e.ColumnIndex == dtlAllImage.Index)
            {
                var id = int.Parse(dgHistoryAll[dtlAllTransitId.Index, e.RowIndex].Value.ToString());
                ImageViewer.ShowImage(id);
            }
        }

        private void dgParkerIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == dtlParkerInImage.Index)
            {
                var id = int.Parse(dgParkerIn[dtlParkerInTransitId.Index, e.RowIndex].Value.ToString());
                ImageViewer.ShowImage(id);
            }
        }

        private void dgParkerOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == dtlParkerOutImage.Index)
            {
                var id = int.Parse(dgParkerOut[dtlParkerOutTransitId.Index, e.RowIndex].Value.ToString());
                ImageViewer.ShowImage(id);
            }
        }

        private void dgMonthlyIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == dtlMonthlyInImage.Index)
            {
                var id = int.Parse(dgMonthlyIn[dtlMonthlyInTransitId.Index, e.RowIndex].Value.ToString());
                ImageViewer.ShowImage(id);
            }
        }

        private void dgMonthlyOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == dtlMonthlyOutImage.Index)
            {
                var id = int.Parse(dgMonthlyOut[dtlMonthlyOutTransitId.Index, e.RowIndex].Value.ToString());
                ImageViewer.ShowImage(id);
            }
        }
    }
}
