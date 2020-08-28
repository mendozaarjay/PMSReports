using Reports.Models;
using Reports.Reports;
using Reports.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccess.Models;

namespace Reports
{
    public partial class History : Form
    {
        private HistoryServices services = new HistoryServices();
        public UserAccessItem UserAccess { get; set; }
        IEnumerable<HistoryModel> HistoryItems { get; set; }
        public History()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            timeFrom.Value = DateTime.Now.Minimun();
            timeTo.Value = DateTime.Now.Maximum();
            CheckForIllegalCrossThreadCalls = false;
            //All
            dgHistoryAll.Columns[dtlAllEntranceImage.Index].Visible = false;
            dgHistoryAll.Columns[dtlAllExitImage.Index].Visible = false;
            //Parker In
            dgParkerIn.Columns[dtlParkerInEntranceImage.Index].Visible = false;
            dgParkerIn.Columns[dtlParkerInExitImage.Index].Visible = false;
            //Parker Out
            dgParkerOut.Columns[dtlParkerOutEntranceImage.Index].Visible = false;
            dgParkerOut.Columns[dtlParkerOutExitImage.Index].Visible = false;
            //Monthly In
            dgMonthlyIn.Columns[dtlMonthlyInEntranceImage.Index].Visible = false;
            dgMonthlyIn.Columns[dtlMonthlyInExitImage.Index].Visible = false;
            //Mnthly Out
            dgMonthlyOut.Columns[dtlMonthlyOutEntranceImage.Index].Visible = false;
            dgMonthlyOut.Columns[dtlMonthlyOutExitImage.Index].Visible = false;
            LoadAccess();
            base.OnLoad(e);
        }
        private void LoadAccess()
        {
            btnPrint.Visible = UserAccess.CanPrint;
            btnExcel.Visible = btnCsv.Visible = UserAccess.CanExport;
            btnRefresh.Enabled = btnGenerate.Enabled = UserAccess.CanAccess;
        }
        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;

            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);

            var items = await services.GetHistoryReportAsync(from, to, txtSearch.Text.Trim());

            var parkerIn = items.Where(a => a.MonthlyName == "" && a.TimeOut == "");
            var parkerOut = items.Where(a => a.MonthlyName == "" && a.TimeOut.Length > 0);

            var monthlyIn = items.Where(a => a.MonthlyName != "" && a.TimeOut == "");
            var monthlyOut = items.Where(a => a.MonthlyName != "" && a.TimeOut.Length > 0);

            HistoryItems = null;
            HistoryItems = items.ToList();


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
                row++;
            }
            dgMonthlyOut.AutoResizeColumns();
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            btnExcel.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var dt = await services.GetHistoryDataTableAsync(from, to, txtSearch.Text.Trim());
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

            var items = await services.GetHistoryDataTableAsync(from, to, txtSearch.Text.Trim());
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

            var dt = await services.GetHistoryDataTableAsync(from, to, txtSearch.Text.Trim());
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

        private async void cbShowImages_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowImages.Checked)
            {
                if (HistoryItems != null)
                {
                    if (HistoryItems.Count() > 0)
                    {
                        await ShowImage();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                //All
                dgHistoryAll.Columns[dtlAllEntranceImage.Index].Visible = false;
                dgHistoryAll.Columns[dtlAllExitImage.Index].Visible = false;
                //Parker In
                dgParkerIn.Columns[dtlParkerInEntranceImage.Index].Visible = false;
                dgParkerIn.Columns[dtlParkerInExitImage.Index].Visible = false;
                //Parker Out
                dgParkerOut.Columns[dtlParkerOutEntranceImage.Index].Visible = false;
                dgParkerOut.Columns[dtlParkerOutExitImage.Index].Visible = false;
                //Monthly In
                dgMonthlyIn.Columns[dtlMonthlyInEntranceImage.Index].Visible = false;
                dgMonthlyIn.Columns[dtlMonthlyInExitImage.Index].Visible = false;
                //Mnthly Out
                dgMonthlyOut.Columns[dtlMonthlyOutEntranceImage.Index].Visible = false;
                dgMonthlyOut.Columns[dtlMonthlyOutExitImage.Index].Visible = false;

                HideImage();
            }
        }
        private async Task ShowImage()
        {
            //All
            dgHistoryAll.Columns[dtlAllEntranceImage.Index].Visible = true;
            dgHistoryAll.Columns[dtlAllExitImage.Index].Visible = true;
            //Parker In
            dgParkerIn.Columns[dtlParkerInEntranceImage.Index].Visible = true;
            dgParkerIn.Columns[dtlParkerInExitImage.Index].Visible = true;
            //Parker Out
            dgParkerOut.Columns[dtlParkerOutEntranceImage.Index].Visible = true;
            dgParkerOut.Columns[dtlParkerOutExitImage.Index].Visible = true;
            //Monthly In
            dgMonthlyIn.Columns[dtlMonthlyInEntranceImage.Index].Visible = true;
            dgMonthlyIn.Columns[dtlMonthlyInExitImage.Index].Visible = true;
            //Mnthly Out
            dgMonthlyOut.Columns[dtlMonthlyOutEntranceImage.Index].Visible = true;
            dgMonthlyOut.Columns[dtlMonthlyOutExitImage.Index].Visible = true;

            #region All
            if (dgHistoryAll.Rows.Count > 0)
            {
                for (int i = 0; i <= dgHistoryAll.Rows.Count - 1; i++)
                {
                    await Task.Run(() =>
                    {
                        var item = HistoryItems.FirstOrDefault(a => a.Id.ToString() == dgHistoryAll[dtlAllTransitId.Index, i].Value.ToString());
                        dgHistoryAll.Columns[dtlAllEntranceImage.Index].Width = 150;
                        dgHistoryAll.Columns[dtlAllExitImage.Index].Width = 150;

                        if (item.EntranceImage != null)
                        {

                            var entranceImage = ImageHelper.ConvertByteToImage(item.EntranceImage);
                            var col = new DataGridViewImageCell();
                            col.Value = entranceImage;
                            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            dgHistoryAll[dtlAllEntranceImage.Index, i] = col;
                            dgHistoryAll.Rows[i].Height = 150;
                            dgHistoryAll[dtlAllEntranceImage.Index, i].ReadOnly = true;
                        }
                        else
                        {
                            var col = new DataGridViewTextBoxCell();
                            col.Value = string.Empty;

                            dgHistoryAll[dtlAllEntranceImage.Index, i] = col;
                            dgHistoryAll.Rows[i].Height = 24;
                            dgHistoryAll[dtlAllEntranceImage.Index, i].ReadOnly = true;
                        }

                        if (item.ExitImage != null)
                        {

                            var image = ImageHelper.ConvertByteToImage(item.ExitImage);
                            var col = new DataGridViewImageCell();
                            col.Value = image;
                            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            dgHistoryAll[dtlAllExitImage.Index, i] = col;
                            dgHistoryAll.Rows[i].Height = 150;
                            dgHistoryAll[dtlAllExitImage.Index, i].ReadOnly = true;
                        }
                        else
                        {
                            var col = new DataGridViewTextBoxCell();
                            col.Value = string.Empty;

                            dgHistoryAll[dtlAllExitImage.Index, i] = col;
                            dgHistoryAll.Rows[i].Height = 24;
                            dgHistoryAll[dtlAllExitImage.Index, i].ReadOnly = true;
                        }

                    });


                }
            }
            #endregion

            #region Parker In
            if (dgParkerIn.Rows.Count > 0)
            {
                for (int i = 0; i <= dgParkerIn.Rows.Count - 1; i++)
                {
                    await Task.Run(() =>
                    {
                        var item = HistoryItems.FirstOrDefault(a => a.Id.ToString() == dgParkerIn[dtlParkerInTransitId.Index, i].Value.ToString());
                        dgParkerIn.Columns[dtlParkerInEntranceImage.Index].Width = 150;
                        dgParkerIn.Columns[dtlParkerInExitImage.Index].Width = 150;

                        if (item.EntranceImage != null)
                        {

                            var entranceImage = ImageHelper.ConvertByteToImage(item.EntranceImage);
                            var col = new DataGridViewImageCell();
                            col.Value = entranceImage;
                            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            dgParkerIn[dtlParkerInEntranceImage.Index, i] = col;
                            dgParkerIn.Rows[i].Height = 150;
                            dgParkerIn[dtlParkerInEntranceImage.Index, i].ReadOnly = true;
                        }
                        else
                        {
                            var col = new DataGridViewTextBoxCell();
                            col.Value = string.Empty;

                            dgParkerIn[dtlParkerInEntranceImage.Index, i] = col;
                            dgParkerIn.Rows[i].Height = 24;
                            dgParkerIn[dtlParkerInEntranceImage.Index, i].ReadOnly = true;
                        }

                        if (item.ExitImage != null)
                        {

                            var image = ImageHelper.ConvertByteToImage(item.ExitImage);
                            var col = new DataGridViewImageCell();
                            col.Value = image;
                            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            dgParkerIn[dtlParkerInExitImage.Index, i] = col;
                            dgParkerIn.Rows[i].Height = 150;
                            dgParkerIn[dtlParkerInExitImage.Index, i].ReadOnly = true;
                        }
                        else
                        {
                            var col = new DataGridViewTextBoxCell();
                            col.Value = string.Empty;

                            dgParkerIn[dtlParkerInExitImage.Index, i] = col;
                            dgParkerIn.Rows[i].Height = 24;
                            dgParkerIn[dtlParkerInExitImage.Index, i].ReadOnly = true;
                        }

                    });


                }
            }
            #endregion

            #region Parker Out

            if (dgParkerOut.Rows.Count > 0)
            {
                for (int i = 0; i <= dgParkerOut.Rows.Count - 1; i++)
                {
                    await Task.Run(() =>
                    {
                        var item = HistoryItems.FirstOrDefault(a => a.Id.ToString() == dgParkerOut[dtlParkerOutTransitId.Index, i].Value.ToString());
                        dgParkerOut.Columns[dtlParkerOutEntranceImage.Index].Width = 150;
                        dgParkerOut.Columns[dtlParkerOutExitImage.Index].Width = 150;

                        if (item.EntranceImage != null)
                        {

                            var entranceImage = ImageHelper.ConvertByteToImage(item.EntranceImage);
                            var col = new DataGridViewImageCell();
                            col.Value = entranceImage;
                            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            dgParkerOut[dtlParkerOutEntranceImage.Index, i] = col;
                            dgParkerOut.Rows[i].Height = 150;
                            dgParkerOut[dtlParkerOutEntranceImage.Index, i].ReadOnly = true;
                        }
                        else
                        {
                            var col = new DataGridViewTextBoxCell();
                            col.Value = string.Empty;

                            dgParkerOut[dtlParkerOutEntranceImage.Index, i] = col;
                            dgParkerOut.Rows[i].Height = 24;
                            dgParkerOut[dtlParkerOutEntranceImage.Index, i].ReadOnly = true;
                        }

                        if (item.ExitImage != null)
                        {

                            var image = ImageHelper.ConvertByteToImage(item.ExitImage);
                            var col = new DataGridViewImageCell();
                            col.Value = image;
                            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            dgParkerOut[dtlParkerOutExitImage.Index, i] = col;
                            dgParkerOut.Rows[i].Height = 150;
                            dgParkerOut[dtlParkerOutExitImage.Index, i].ReadOnly = true;
                        }
                        else
                        {
                            var col = new DataGridViewTextBoxCell();
                            col.Value = string.Empty;

                            dgParkerOut[dtlParkerOutExitImage.Index, i] = col;
                            dgParkerOut.Rows[i].Height = 24;
                            dgParkerOut[dtlParkerOutExitImage.Index, i].ReadOnly = true;
                        }

                    });


                }
            }


            #endregion

            #region Monthly In
            if (dgMonthlyIn.Rows.Count > 0)
            {
                for (int i = 0; i <= dgMonthlyIn.Rows.Count - 1; i++)
                {
                    await Task.Run(() =>
                    {
                        var item = HistoryItems.FirstOrDefault(a => a.Id.ToString() == dgMonthlyIn[dtlMonthlyInTransitId.Index, i].Value.ToString());
                        dgMonthlyIn.Columns[dtlMonthlyInEntranceImage.Index].Width = 150;
                        dgMonthlyIn.Columns[dtlMonthlyInExitImage.Index].Width = 150;

                        if (item.EntranceImage != null)
                        {

                            var entranceImage = ImageHelper.ConvertByteToImage(item.EntranceImage);
                            var col = new DataGridViewImageCell();
                            col.Value = entranceImage;
                            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            dgMonthlyIn[dtlMonthlyInEntranceImage.Index, i] = col;
                            dgMonthlyIn.Rows[i].Height = 150;
                            dgMonthlyIn[dtlMonthlyInEntranceImage.Index, i].ReadOnly = true;
                        }
                        else
                        {
                            var col = new DataGridViewTextBoxCell();
                            col.Value = string.Empty;

                            dgMonthlyIn[dtlMonthlyInEntranceImage.Index, i] = col;
                            dgMonthlyIn.Rows[i].Height = 24;
                            dgMonthlyIn[dtlMonthlyInEntranceImage.Index, i].ReadOnly = true;
                        }

                        if (item.ExitImage != null)
                        {

                            var image = ImageHelper.ConvertByteToImage(item.ExitImage);
                            var col = new DataGridViewImageCell();
                            col.Value = image;
                            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            dgMonthlyIn[dtlMonthlyInExitImage.Index, i] = col;
                            dgMonthlyIn.Rows[i].Height = 150;
                            dgMonthlyIn[dtlMonthlyInExitImage.Index, i].ReadOnly = true;
                        }
                        else
                        {
                            var col = new DataGridViewTextBoxCell();
                            col.Value = string.Empty;

                            dgMonthlyIn[dtlMonthlyInExitImage.Index, i] = col;
                            dgMonthlyIn.Rows[i].Height = 24;
                            dgMonthlyIn[dtlMonthlyInExitImage.Index, i].ReadOnly = true;
                        }

                    });

                }
            }
            #endregion

            #region Monthly Out
            if (dgMonthlyOut.Rows.Count > 0)
            {
                for (int i = 0; i <= dgMonthlyOut.Rows.Count - 1; i++)
                {
                    await Task.Run(() =>
                    {
                        var item = HistoryItems.FirstOrDefault(a => a.Id.ToString() == dgMonthlyOut[dtlMonthlyOutTransitId.Index, i].Value.ToString());
                        dgMonthlyOut.Columns[dtlMonthlyOutEntranceImage.Index].Width = 150;
                        dgMonthlyOut.Columns[dtlMonthlyOutExitImage.Index].Width = 150;

                        if (item.EntranceImage != null)
                        {

                            var entranceImage = ImageHelper.ConvertByteToImage(item.EntranceImage);
                            var col = new DataGridViewImageCell();
                            col.Value = entranceImage;
                            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            dgMonthlyOut[dtlMonthlyOutEntranceImage.Index, i] = col;
                            dgMonthlyOut.Rows[i].Height = 150;
                            dgMonthlyOut[dtlMonthlyOutEntranceImage.Index, i].ReadOnly = true;
                        }
                        else
                        {
                            var col = new DataGridViewTextBoxCell();
                            col.Value = string.Empty;

                            dgMonthlyOut[dtlMonthlyOutEntranceImage.Index, i] = col;
                            dgMonthlyOut.Rows[i].Height = 24;
                            dgMonthlyOut[dtlMonthlyOutEntranceImage.Index, i].ReadOnly = true;
                        }

                        if (item.ExitImage != null)
                        {

                            var image = ImageHelper.ConvertByteToImage(item.ExitImage);
                            var col = new DataGridViewImageCell();
                            col.Value = image;
                            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            dgMonthlyOut[dtlMonthlyOutExitImage.Index, i] = col;
                            dgMonthlyOut.Rows[i].Height = 150;
                            dgMonthlyOut[dtlMonthlyOutExitImage.Index, i].ReadOnly = true;
                        }
                        else
                        {
                            var col = new DataGridViewTextBoxCell();
                            col.Value = string.Empty;

                            dgMonthlyOut[dtlMonthlyOutExitImage.Index, i] = col;
                            dgMonthlyOut.Rows[i].Height = 24;
                            dgMonthlyOut[dtlMonthlyOutExitImage.Index, i].ReadOnly = true;
                        }

                    });

                }
            }
            #endregion

        }
        private void HideImage()
        {
            //All
            dgHistoryAll.Columns[dtlAllEntranceImage.Index].Visible = false;
            dgHistoryAll.Columns[dtlAllExitImage.Index].Visible = false;
            if (dgHistoryAll.Rows.Count > 0)
            {
                for (int i = 0; i <= dgHistoryAll.Rows.Count - 1; i++)
                {
                    dgHistoryAll.Rows[i].Height = 24;
                }
            }
            //Parker In
            dgParkerIn.Columns[dtlParkerInEntranceImage.Index].Visible = false;
            dgParkerIn.Columns[dtlParkerInExitImage.Index].Visible = false;
            if (dgParkerIn.Rows.Count > 0)
            {
                for (int i = 0; i <= dgParkerIn.Rows.Count - 1; i++)
                {
                    dgParkerIn.Rows[i].Height = 24;
                }
            }
            //Parker Out
            dgParkerOut.Columns[dtlParkerOutEntranceImage.Index].Visible = false;
            dgParkerOut.Columns[dtlParkerOutExitImage.Index].Visible = false;
            if (dgParkerOut.Rows.Count > 0)
            {
                for (int i = 0; i <= dgParkerOut.Rows.Count - 1; i++)
                {
                    dgParkerOut.Rows[i].Height = 24;
                }
            }
            //Monthly In
            dgMonthlyIn.Columns[dtlMonthlyInEntranceImage.Index].Visible = false;
            dgMonthlyIn.Columns[dtlMonthlyInExitImage.Index].Visible = false;
            if (dgMonthlyIn.Rows.Count > 0)
            {
                for (int i = 0; i <= dgMonthlyIn.Rows.Count - 1; i++)
                {
                    dgMonthlyIn.Rows[i].Height = 24;
                }
            }
            //Monthly Out
            dgMonthlyOut.Columns[dtlMonthlyOutEntranceImage.Index].Visible = false;
            dgMonthlyOut.Columns[dtlMonthlyOutExitImage.Index].Visible = false;
            if (dgMonthlyOut.Rows.Count > 0)
            {
                for (int i = 0; i <= dgMonthlyOut.Rows.Count - 1; i++)
                {
                    dgMonthlyOut.Rows[i].Height = 24;
                }
            }
        }
    }
}
