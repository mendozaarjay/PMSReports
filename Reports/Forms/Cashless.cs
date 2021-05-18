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
    public partial class Cashless : Form
    {

        private CashlessServices services = new CashlessServices();
        public UserAccessItem UserAccess { get; set; }
        public Cashless()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            timeFrom.Value = DateTime.Now.Minimun();
            timeTo.Value = DateTime.Now.Maximum();
            CheckForIllegalCrossThreadCalls = false;
            LoadAccess();
            LoadAllTerminal();
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

            var result = await services.CashlessReportAsync(from, to, txtSearch.Text.Trim(),cboTerminal.SelectedValue.ToString());

            Spinner.ShowSpinner(this, () =>
            {

                PopulateData(result);
            });

            btnGenerate.Enabled = true;
        }
        private void PopulateData(IEnumerable<CashlessModel> items)
        {
            dgDetails.Rows.Clear();
            if (items.Count() > 0)
                dgDetails.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgDetails[dtlRow.Index, row].Value = row + 1;
                dgDetails[dtlTransitId.Index, row].Value = item.TransitId;
                dgDetails[dtlORNumber.Index, row].Value = item.ORNo;
                dgDetails[dtlType.Index, row].Value = item.PaymentType;
                dgDetails[dtlPlateNo.Index, row].Value = item.PlateNo;
                dgDetails[dtlTicketNo.Index, row].Value = item.TicketNo;
                dgDetails[dtlTimeIn.Index, row].Value = item.TimeIn;
                dgDetails[dtlTimeOut.Index, row].Value = item.TimeOut;
                dgDetails[dtlDuration.Index, row].Value = item.Duration;
                dgDetails[dtlRateName.Index, row].Value = item.RateName;
                dgDetails[dtlCoupon.Index, row].Value = item.Coupon;
                dgDetails[dtlGrossAmount.Index, row].Value = item.GrossAmount;
                dgDetails[dtlDiscount.Index, row].Value = item.Discount;
                dgDetails[dtlAmountDue.Index, row].Value = item.AmountDue;
                dgDetails[dtlAmountTendered.Index, row].Value = item.AmountTendered;
                dgDetails[dtlChange.Index, row].Value = item.Change;
                dgDetails[dtlVatable.Index, row].Value = item.Vatable;
                dgDetails[dtlVat.Index, row].Value = item.Vat;
                dgDetails[dtlVatExempt.Index, row].Value = item.VatExempt;
                dgDetails[dtlZeroRated.Index, row].Value = item.ZeroRated;
                dgDetails[dtlReprint.Index, row].Value = item.Reprint;
                dgDetails[dtlDescription.Index, row].Value = item.Description;
                dgDetails[dtlUpdateUser.Index, row].Value = item.Username;
                dgDetails[dtlEntrance.Index, row].Value = item.Entrance;
                dgDetails[dtlExit.Index, row].Value = item.Exit;


                dgDetails[dtlSCPWDName.Index, row].Value = item.SCPWDName;
                dgDetails[dtlSDPWDAddress.Index, row].Value = item.SCPWDAddress;
                dgDetails[dtlSCPWDId.Index, row].Value = item.SCPWDId;
                dgDetails[dtlLCPenalty.Index, row].Value = item.LostCardPenalty;
                dgDetails[dtlLCName.Index, row].Value = item.LostCardName;
                dgDetails[dtlLCLicenseNo.Index, row].Value = item.LostCardLicenseNo;
                dgDetails[dtlLCORCR.Index, row].Value = item.LostCardORCR;
                dgDetails[dtlOvernight.Index, row].Value = item.OvernightPenalty;
                dgDetails[dtlCashlessType.Index, row].Value = item.CashlessType;
                dgDetails[dtlCashlessReference.Index, row].Value = item.CashlessTransactionNo;


                row++;
            }
            dgDetails.AutoResizeColumns();
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
            btnCsv.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);

            var dt = await services.CashlessReportDataTableAsync(from, to, txtSearch.Text.Trim(), cboTerminal.SelectedValue.ToString());
            dt.Columns.Remove("TransitId");
            dt.Columns.Remove("IsErased");
            dt.AcceptChanges();

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Cashless Report " + from.ToString("MMddyyyy hhmmsstt") + "-" + to.ToString("MMddyyyy hhmmsstt");
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

            var dt = await services.CashlessReportDataTableAsync(from, to, txtSearch.Text.Trim(), cboTerminal.SelectedValue.ToString());
            dt.Columns.Remove("TransitId");
            dt.Columns.Remove("IsErased");
            dt.AcceptChanges();

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Cashless Report " + from.ToString("MMddyyyy hhmmsstt") + "-" + to.ToString("MMddyyyy hhmmsstt");
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

            var dt = await services.CashlessReportDataTableAsync(from, to, txtSearch.Text.Trim(), cboTerminal.SelectedValue.ToString());


            dt.TableName = "CashlessReport";
            var viewer = new CrystalViewer();
            viewer.DateCovered = from.ToString() + "-" + to.ToString();
            viewer.ReportType = ReportType.CashlessReport;
            viewer.DataSource = dt;
            viewer.ShowDialog();
            btnPrint.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgDetails.Rows.Count <= 0)
                return;

            var key = Finder.SearchResult();
            dgDetails.FindValue(key);
        }
        private void dgDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == dtlImage.Index)
            {
                var id = dgDetails[dtlTransitId.Index, e.RowIndex].Value.ToString();
                ImageViewer.ShowImage(int.Parse(id));
            }
        }
    }
}
