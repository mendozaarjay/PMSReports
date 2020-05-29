using Reports.Services;
using Reports.Models;
using Reports.Reports;
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
    public partial class History : Form
    {
        private HistoryServices services = new HistoryServices();
        public History()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            timeFrom.Value = DateTime.Now.Minimun();
            timeTo.Value = DateTime.Now.Maximum();
            CheckForIllegalCrossThreadCalls = false;
            base.OnLoad(e);
        }

        private async void  btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;

            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);

            var items = await services.GetHistoryReportAsync(from,to,txtSearch.Text.Trim());

            var parkerIn = items.Where(a => a.MonthlyName == "" && a.TimeOut == "");
            var parkerOut = items.Where(a => a.MonthlyName == "" && a.TimeOut != "");

            var monthlyIn = items.Where(a => a.MonthlyName != "" && a.TimeOut == "");
            var monthlyOut = items.Where(a => a.MonthlyName != "" && a.TimeOut != "");

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
                dgHistoryAll[dtlAllTransitId.Index, row].Value = item.Id;
                dgHistoryAll[dtlAllTerminal.Index, row].Value = item.Terminal;
                dgHistoryAll[dtlAllORNo.Index, row].Value = item.ORNumber;
                dgHistoryAll[dtlAllType.Index, row].Value = item.Type;
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
        }
        private void PopulateHistoryParkerIn(IEnumerable<HistoryModel> items)
        {
            dgParkerIn.Rows.Clear();
            if (items.Count() > 0)
                dgParkerIn.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgParkerIn[dtlParkerInTransitId.Index, row].Value = item.Id;
                dgParkerIn[dtlParkerInTerminal.Index, row].Value = item.Terminal;
                dgParkerIn[dtlParkerInORNo.Index, row].Value = item.ORNumber;
                dgParkerIn[dtlParkerInType.Index, row].Value = item.Type;
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
        }
        private void PopulateHistoryParkerOut(IEnumerable<HistoryModel> items)
        {
            dgParkerOut.Rows.Clear();
            if (items.Count() > 0)
                dgParkerOut.Rows.Add(items.Count());

            var row = 0;

            foreach (var item in items)
            {
                dgParkerOut[dtlParkerOutTransitId.Index, row].Value = item.Id;
                dgParkerOut[dtlParkerOutTerminal.Index, row].Value = item.Terminal;
                dgParkerOut[dtlParkerOutORNo.Index, row].Value = item.ORNumber;
                dgParkerOut[dtlParkerOutType.Index, row].Value = item.Type;
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
        }

        private void PopulateHistoryMonthlyIn(IEnumerable<HistoryModel> items)
        {
            dgMonthlyIn.Rows.Clear();
            if (items.Count() > 0)
                dgMonthlyIn.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgMonthlyIn[dtlMonthlyInTransitId.Index, row].Value = item.Id;
                dgMonthlyIn[dtlMonthlyInTerminal.Index, row].Value = item.Terminal;
                dgMonthlyIn[dtlMonthlyInORNo.Index, row].Value = item.ORNumber;
                dgMonthlyIn[dtlMonthlyInType.Index, row].Value = item.Type;
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
        }
        private void PopulateHistoryMonthlyOut(IEnumerable<HistoryModel> items)
        {
            dgMonthlyOut.Rows.Clear();
            if (items.Count() > 0)
                dgMonthlyOut.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgMonthlyOut[dtlMonthlyOutTransitId.Index, row].Value = item.Id;
                dgMonthlyOut[dtlMonthlyOutTerminal.Index, row].Value = item.Terminal;
                dgMonthlyOut[dtlMonthlyOutORNo.Index, row].Value = item.ORNumber;
                dgMonthlyOut[dtlMonthlyOutType.Index, row].Value = item.Type;
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
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
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

        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);

            var items = await services.GetHistoryDataTableAsync(from,to, txtSearch.Text.Trim());
            items.Columns.Remove("TransitId");
            items.AcceptChanges();

            items.TableName = "History";
            var viewer = new Viewer();
            viewer.ReportType = ReportType.History;
            viewer.Source = items;
            viewer.ShowDialog();
        }

        private async void btnCsv_Click(object sender, EventArgs e)
        {
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
