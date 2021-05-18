using Reports.Models;
using Reports.Reports;
using Reports.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
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
            LoadAllTerminal();
            LoadAccess();
            base.OnLoad(e);
        }
        private void LoadAllTerminal()
        {
            var items = services.Terminals();
            if (items != null)
            {
                cboTerminal.DataSource = null;
                cboTerminal.DataSource = items;
                cboTerminal.DisplayMember = "Name";
                cboTerminal.ValueMember = "Id";
            }
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

            var items = await services.GetHistoryReportAsync(from, to, cboTerminal.SelectedValue.ToString(), txtSearch.Text.Trim(), rbExit.Checked);

            var parkerIn = items.Where(a => a.MonthlyName.Replace(" ","").Length == 0 && a.TimeOut == "");
            var parkerOut = items.Where(a => a.MonthlyName.Replace(" ", "").Length == 0 && a.TimeOut.Length > 0);

            var monthlyIn = items.Where(a => a.MonthlyName.Replace(" ", "").Length > 0 && a.TimeOut == "");
            var monthlyOut = items.Where(a => a.MonthlyName.Replace(" ", "").Length > 0 && a.TimeOut.Length > 0);

            HistoryItems = null;
            HistoryItems = items.ToList();
            //PopulateHistory(items, parkerIn, parkerOut, monthlyIn, monthlyOut)
            Spinner.ShowSpinner(this, () => {
                PopulateHistoryAll(items);
                PopulateHistoryParkerIn(parkerIn);
                PopulateHistoryParkerOut(parkerOut);
                PopulateHistoryMonthlyIn(monthlyIn);
                PopulateHistoryMonthlyOut(monthlyOut);
            });
            if(cbShowImages.Checked)
            {
                await Spinner.ShowSpinnerAsync(this, ShowImage());
            }
            for(int i = 0; i < tabControl1.TabCount;i++)
            {
                foreach(Control c in tabControl1.TabPages[i].Controls)
                {
                    if(c.GetType() == typeof(DataGridView))
                    {
                        ((DataGridView)c).Invalidate();
                        ((DataGridView)c).ResumeLayout();
                        ((DataGridView)c).ScrollBars = ScrollBars.Both;
                        ((DataGridView)c).Update();
                        ((DataGridView)c).Refresh();
                    }
                }
            }
            this.ResumeLayout();
            tabControl1.Refresh();
            btnGenerate.Enabled = true;
        }
        private void PopulateHistory(IEnumerable<HistoryModel> items, IEnumerable<HistoryModel> parkerIn, IEnumerable<HistoryModel> parkerOut, IEnumerable<HistoryModel> monthlyIn, IEnumerable<HistoryModel> monthlyOut)
        {
            PopulateHistoryAll(items);
            PopulateHistoryParkerIn(parkerIn);
            PopulateHistoryParkerOut(parkerOut);
            PopulateHistoryMonthlyIn(monthlyIn);
            PopulateHistoryMonthlyOut(monthlyOut);
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
                dgHistoryAll[dtlAllSCPWDName.Index, row].Value = item.SCPWDName;
                dgHistoryAll[dtlAllSCPWDAddress.Index, row].Value = item.SCPWDAddress;
                dgHistoryAll[dtlAllSCPWDId.Index, row].Value = item.SCPWDId;
                dgHistoryAll[dtlAllLCPenalty.Index, row].Value = item.LostCardPenalty;
                dgHistoryAll[dtlAllLCName.Index, row].Value = item.LostCardName;
                dgHistoryAll[dtlAllLCLicenseNo.Index, row].Value = item.LostCardLicenseNo;
                dgHistoryAll[dtlAllLCOrCr.Index, row].Value = item.LostCardORCR;
                dgHistoryAll[dtlAllOvernightPenalty.Index, row].Value = item.OvernightPenalty;
                dgHistoryAll[dtlAllEntranceGate.Index, row].Value = item.EntranceGate;
                row++;
            }
            this.Invoke((MethodInvoker)delegate
            {
                dgHistoryAll.ScrollBars = ScrollBars.Both; 
            });
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
                dgParkerIn[dtlParkerInEntranceGate.Index, row].Value = item.EntranceGate;
                dgParkerIn[dtlParkerInSCPWDName.Index, row].Value = item.SCPWDName;
                dgParkerIn[dtlParkerInSCPWDAddress.Index, row].Value = item.SCPWDAddress;
                dgParkerIn[dtlParkerInSCPWDId.Index, row].Value = item.SCPWDId;
                dgParkerIn[dtlParkerInLCPenalty.Index, row].Value = item.LostCardPenalty;
                dgParkerIn[dtlParkerInLCName.Index, row].Value = item.LostCardName;
                dgParkerIn[dtlParkerInLCLicenseNo.Index, row].Value = item.LostCardLicenseNo;
                dgParkerIn[dtlParkerInLCOrCr.Index, row].Value = item.LostCardORCR;
                dgParkerIn[dtlParkerInOvernightPenalty.Index, row].Value = item.OvernightPenalty;
                row++;
            }
            this.Invoke((MethodInvoker)delegate
            {
                dgParkerIn.ScrollBars = ScrollBars.Both;
            });
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
                dgParkerOut[dtlParkerOutEntranceGate.Index, row].Value = item.EntranceGate;
                dgParkerOut[dtlParkerOutSCPWDName.Index, row].Value = item.SCPWDName;
                dgParkerOut[dtlParkerOutSCPWDAddress.Index, row].Value = item.SCPWDAddress;
                dgParkerOut[dtlParkerOutSCPWDId.Index, row].Value = item.SCPWDId;
                dgParkerOut[dtlParkerOutLCPenalty.Index, row].Value = item.LostCardPenalty;
                dgParkerOut[dtlParkerOutLCName.Index, row].Value = item.LostCardName;
                dgParkerOut[dtlParkerOutLCLicenseNo.Index, row].Value = item.LostCardLicenseNo;
                dgParkerOut[dtlParkerOutLCOrCr.Index, row].Value = item.LostCardORCR;
                dgParkerOut[dtlParkerOutOvernightPenalty.Index, row].Value = item.OvernightPenalty;
                row++;
            }
            this.Invoke((MethodInvoker)delegate
            {
                dgParkerOut.ScrollBars = ScrollBars.Both;
            });
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
                dgMonthlyIn[dtlMonthlyInEntranceGate.Index, row].Value = item.EntranceGate;

                dgMonthlyIn[dtlMonthlyInSCPWDName.Index, row].Value = item.SCPWDName;
                dgMonthlyIn[dtlMonthlyInSCPWDAddress.Index, row].Value = item.SCPWDAddress;
                dgMonthlyIn[dtlMonthlyInSCPWDId.Index, row].Value = item.SCPWDId;
                dgMonthlyIn[dtlMonthlyInLCPenalty.Index, row].Value = item.LostCardPenalty;
                dgMonthlyIn[dtlMonthlyInLCName.Index, row].Value = item.LostCardName;
                dgMonthlyIn[dtlMonthlyInLCLicenseNo.Index, row].Value = item.LostCardLicenseNo;
                dgMonthlyIn[dtlMonthlyInLCOrCr.Index, row].Value = item.LostCardORCR;
                dgMonthlyIn[dtlMonthlyInOvernightPenalty.Index, row].Value = item.OvernightPenalty;
                row++;
            }
            this.Invoke((MethodInvoker)delegate
            {
                dgMonthlyIn.ScrollBars = ScrollBars.Both;
            });
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
                dgMonthlyOut[dtlMonthlyOutEntranceGate.Index, row].Value = item.EntranceGate;

                dgMonthlyOut[dtlMonthlyOutSCPWDName.Index, row].Value = item.SCPWDName;
                dgMonthlyOut[dtlMonthlyOutSCPWDAddress.Index, row].Value = item.SCPWDAddress;
                dgMonthlyOut[dtlMonthlyOutSCPWDId.Index, row].Value = item.SCPWDId;
                dgMonthlyOut[dtlMonthlyOutLCPenalty.Index, row].Value = item.LostCardPenalty;
                dgMonthlyOut[dtlMonthlyOutLCName.Index, row].Value = item.LostCardName;
                dgMonthlyOut[dtlMonthlyOutLCLicenseNo.Index, row].Value = item.LostCardLicenseNo;
                dgMonthlyOut[dtlMonthlyOutLCOrCr.Index, row].Value = item.LostCardORCR;
                dgMonthlyOut[dtlMonthlyOutOvernightPenalty.Index, row].Value = item.OvernightPenalty;
                row++;
            }
            this.Invoke((MethodInvoker)delegate
            {
                dgMonthlyOut.ScrollBars = ScrollBars.Both;
            });
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            btnExcel.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var dt = await services.GetHistoryDataTableAsync(from, to, cboTerminal.SelectedValue.ToString(), txtSearch.Text.Trim(), rbExit.Checked);
            dt.Columns.Remove("TransitId");
            dt.AcceptChanges();

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "History Report " + from.ToString("MMddyyyy hhmmsstt") + "-" + to.ToString("MMddyyyy hhmmsstt");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                ExportToExcelFile.Export(dt, sd.FileName);
            }
            btnExcel.Enabled = true;
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);

            var items = await services.GetHistoryDataTableAsync(from, to, cboTerminal.SelectedValue.ToString(), txtSearch.Text.Trim(), rbExit.Checked);
            //items.Columns.Remove("TransitId");
            //items.AcceptChanges();

            items.TableName = "HistoryReport";
            var viewer = new CrystalViewer();
            viewer.DateCovered = from.ToString() + "-" + to.ToString();
            viewer.ReportType = ReportType.History;
            viewer.DataSource = items;
            viewer.ShowDialog();


            btnPrint.Enabled = true;
        }

        private async void btnCsv_Click(object sender, EventArgs e)
        {
            btnCsv.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);

            var dt = await services.GetHistoryDataTableAsync(from, to, cboTerminal.SelectedValue.ToString(), txtSearch.Text.Trim(), rbExit.Checked);
            dt.Columns.Remove("TransitId");
            dt.AcceptChanges();

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "History Report " + from.ToString("MMddyyyy hhmmsstt") + "-" + to.ToString("MMddyyyy hhmmsstt");
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
                        await Spinner.ShowSpinnerAsync(this, ShowImage());

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
            this.Enabled = false;
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
                        dgHistoryAll.Columns[dtlAllEntranceImage.Index].Width = 250;
                        dgHistoryAll.Columns[dtlAllExitImage.Index].Width = 250;

                        if (item.EntranceImage != null)
                        {
                            var entranceImage = ImageHelper.ConvertByteToImage(item.EntranceImage);
                            var col = new DataGridViewImageCell();
                            col.Value = entranceImage;
                            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            dgHistoryAll[dtlAllEntranceImage.Index, i] = col;
                            dgHistoryAll.Rows[i].Height = 250;
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
                            dgHistoryAll.Rows[i].Height = 250;
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

                        if (item.EntranceImage != null || item.ExitImage != null)
                            dgHistoryAll.Rows[i].Height = 250;
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
                        dgParkerIn.Columns[dtlParkerInEntranceImage.Index].Width = 250;
                        dgParkerIn.Columns[dtlParkerInExitImage.Index].Width = 250;

                        if (item.EntranceImage != null)
                        {

                            var entranceImage = ImageHelper.ConvertByteToImage(item.EntranceImage);
                            var col = new DataGridViewImageCell();
                            col.Value = entranceImage;
                            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            dgParkerIn[dtlParkerInEntranceImage.Index, i] = col;
                            dgParkerIn.Rows[i].Height = 250;
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
                            dgParkerIn.Rows[i].Height = 250;
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
                        if (item.EntranceImage != null || item.ExitImage != null)
                            dgParkerIn.Rows[i].Height = 250;

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
                        dgParkerOut.Columns[dtlParkerOutEntranceImage.Index].Width = 250;
                        dgParkerOut.Columns[dtlParkerOutExitImage.Index].Width = 250;

                        if (item.EntranceImage != null)
                        {

                            var entranceImage = ImageHelper.ConvertByteToImage(item.EntranceImage);
                            var col = new DataGridViewImageCell();
                            col.Value = entranceImage;
                            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            dgParkerOut[dtlParkerOutEntranceImage.Index, i] = col;
                            dgParkerOut.Rows[i].Height = 250;
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
                            dgParkerOut.Rows[i].Height = 250;
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
                        if (item.EntranceImage != null || item.ExitImage != null)
                            dgParkerOut.Rows[i].Height = 250;

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
                        dgMonthlyIn.Columns[dtlMonthlyInEntranceImage.Index].Width = 250;
                        dgMonthlyIn.Columns[dtlMonthlyInExitImage.Index].Width = 250;

                        if (item.EntranceImage != null)
                        {

                            var entranceImage = ImageHelper.ConvertByteToImage(item.EntranceImage);
                            var col = new DataGridViewImageCell();
                            col.Value = entranceImage;
                            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            dgMonthlyIn[dtlMonthlyInEntranceImage.Index, i] = col;
                            dgMonthlyIn.Rows[i].Height = 250;
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
                            dgMonthlyIn.Rows[i].Height = 250;
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
                        if (item.EntranceImage != null || item.ExitImage != null)
                            dgMonthlyIn.Rows[i].Height = 250;

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
                        dgMonthlyOut.Columns[dtlMonthlyOutEntranceImage.Index].Width = 250;
                        dgMonthlyOut.Columns[dtlMonthlyOutExitImage.Index].Width = 250;

                        if (item.EntranceImage != null)
                        {

                            var entranceImage = ImageHelper.ConvertByteToImage(item.EntranceImage);
                            var col = new DataGridViewImageCell();
                            col.Value = entranceImage;
                            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            dgMonthlyOut[dtlMonthlyOutEntranceImage.Index, i] = col;
                            dgMonthlyOut.Rows[i].Height = 250;
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
                            dgMonthlyOut.Rows[i].Height = 250;
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
                        if (item.EntranceImage != null || item.ExitImage != null)
                            dgMonthlyOut.Rows[i].Height = 250;

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

        private void dgMonthlyOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == dtlMonthlyOutView.Index)
            {
                var id = dgMonthlyOut[dtlMonthlyOutTransitId.Index, e.RowIndex].Value.ToString();
                ImageViewer.ShowImage(int.Parse(id));
            }
        }

        private void dgMonthlyIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == dtlMonthlyInView.Index)
            {
                var id = dgMonthlyIn[dtlMonthlyInTransitId.Index, e.RowIndex].Value.ToString();
                ImageViewer.ShowImage(int.Parse(id));
            }

        }

        private void dgParkerOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == dtlParkerOutView.Index)
            {
                var id = dgParkerOut[dtlParkerOutTransitId.Index, e.RowIndex].Value.ToString();
                ImageViewer.ShowImage(int.Parse(id));
            }
        }

        private void dgParkerIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == dtlParkerInView.Index)
            {
                var id = dgParkerIn[dtlParkerInTransitId.Index, e.RowIndex].Value.ToString();
                ImageViewer.ShowImage(int.Parse(id));
            }
        }

        private void dgHistoryAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == dtlAllView.Index)
            {
                var id = dgHistoryAll[dtlAllTransitId.Index, e.RowIndex].Value.ToString();
                ImageViewer.ShowImage(int.Parse(id));
            }
        }
    }
}
