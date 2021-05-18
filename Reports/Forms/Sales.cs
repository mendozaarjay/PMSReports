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
    public partial class Sales : Form
    {

        private SalesServices services = new SalesServices();
        public UserAccessItem UserAccess { get; set; }
        public Sales()
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

            var result = await services.SalesReportAsync(from, to, txtSearch.Text.Trim(),cboTerminal.SelectedValue.ToString());
            var all = result;
            var transaction = result.Where(a => a.AmountDue > 0 && !a.IsErased).ToList();
            var collection = result.Where(a => a.TimeOut.Length > 0 && !a.IsErased && a.Exit.ToLower().Contains("valid")).ToList();
            var discount = result.Where(a => a.Discount > 0 && !a.IsErased).ToList();
            var erased = result.Where(a => a.IsErased).ToList();
            var fee = result.Where(a => a.AmountDue > 0 && !a.IsErased).ToList();
            var cashless = result.Where(a => a.PaymentType.ToLower() == "cashless" && !a.IsErased);

            Spinner.ShowSpinner(this, () =>
            {

                PopulateSalesAll(all);
                PopulateSalesTransactions(transaction);
                PopulateSalesCollection(collection);
                PopulateSalesDiscount(discount);
                PopulateSalesErased(erased);
                PopulateSalesFee(fee);
                PopulateSalesCashless(cashless);
            });

            btnGenerate.Enabled = true;
        }
        private void PopulateSalesAll(IEnumerable<SalesModel> items)
        {
            dgAllSales.Rows.Clear();
            if (items.Count() > 0)
                dgAllSales.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgAllSales[dtlAllRow.Index, row].Value = row + 1;
                dgAllSales[dtlAllTransitId.Index, row].Value = item.TransitId;
                dgAllSales[dtlAllORNumber.Index, row].Value = item.ORNo;
                dgAllSales[dtlAllType.Index, row].Value = item.PaymentType;
                dgAllSales[dtlAllPlateNo.Index, row].Value = item.PlateNo;
                dgAllSales[dtlAllTicketNo.Index, row].Value = item.TicketNo;
                dgAllSales[dtlAllTimeIn.Index, row].Value = item.TimeIn;
                dgAllSales[dtlAllTimeOut.Index, row].Value = item.TimeOut;
                dgAllSales[dtlAllDuration.Index, row].Value = item.Duration;
                dgAllSales[dtlAllRateName.Index, row].Value = item.RateName;
                dgAllSales[dtlAllCoupon.Index, row].Value = item.Coupon;
                dgAllSales[dtlAllGrossAmount.Index, row].Value = item.GrossAmount;
                dgAllSales[dtlAllDiscount.Index, row].Value = item.Discount;
                dgAllSales[dtlAllAmountDue.Index, row].Value = item.AmountDue;
                dgAllSales[dtlAllAmountTendered.Index, row].Value = item.AmountTendered;
                dgAllSales[dtlAllChange.Index, row].Value = item.Change;
                dgAllSales[dtlAllVatable.Index, row].Value = item.Vatable;
                dgAllSales[dtlAllVat.Index, row].Value = item.Vat;
                dgAllSales[dtlAllVatExempt.Index, row].Value = item.VatExempt;
                dgAllSales[dtlAllZeroRated.Index, row].Value = item.ZeroRated;
                dgAllSales[dtlAllReprint.Index, row].Value = item.Reprint;
                dgAllSales[dtlAllDescription.Index, row].Value = item.Description;
                dgAllSales[dtlAllUpdateUser.Index, row].Value = item.Username;
                dgAllSales[dtlAllEntrance.Index, row].Value = item.Entrance;
                dgAllSales[dtlAllExit.Index, row].Value = item.Exit;


                dgAllSales[dtlAllSCPWDName.Index, row].Value = item.SCPWDName;
                dgAllSales[dtlAllSDPWDAddress.Index, row].Value = item.SCPWDAddress;
                dgAllSales[dtlAllSCPWDId.Index, row].Value = item.SCPWDId;
                dgAllSales[dtlAllLCPenalty.Index, row].Value = item.LostCardPenalty;
                dgAllSales[dtlAllLCName.Index, row].Value = item.LostCardName;
                dgAllSales[dtlAllLCLicenseNo.Index, row].Value = item.LostCardLicenseNo;
                dgAllSales[dtlAllLCORCR.Index, row].Value = item.LostCardORCR;
                dgAllSales[dtlAllOvernight.Index, row].Value = item.OvernightPenalty;


                row++;
            }
            dgAllSales.AutoResizeColumns();
        }
        private void PopulateSalesTransactions(IEnumerable<SalesModel> items)
        {
            dgTransactions.Rows.Clear();
            if (items.Count() > 0)
                dgTransactions.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgTransactions[dtlTransactionRow.Index, row].Value = row + 1;
                dgTransactions[dtlTransactionTransitId.Index, row].Value = item.TransitId;
                dgTransactions[dtlTransactionORNumber.Index, row].Value = item.ORNo;
                dgTransactions[dtlTransactionType.Index, row].Value = item.PaymentType;
                dgTransactions[dtlTransactionPlateNo.Index, row].Value = item.PlateNo;
                dgTransactions[dtlTransactionTicketNo.Index, row].Value = item.TicketNo;
                dgTransactions[dtlTransactionTimeIn.Index, row].Value = item.TimeIn;
                dgTransactions[dtlTransactionTimeOut.Index, row].Value = item.TimeOut;
                dgTransactions[dtlTransactionDuration.Index, row].Value = item.Duration;
                dgTransactions[dtlTransactionRateName.Index, row].Value = item.RateName;
                dgTransactions[dtlTransactionCoupon.Index, row].Value = item.Coupon;
                dgTransactions[dtlTransactionGrossAmount.Index, row].Value = item.GrossAmount;
                dgTransactions[dtlTransactionDiscount.Index, row].Value = item.Discount;
                dgTransactions[dtlTransactionAmountDue.Index, row].Value = item.AmountDue;
                dgTransactions[dtlTransactionAmountTendered.Index, row].Value = item.AmountTendered;
                dgTransactions[dtlTransactionChange.Index, row].Value = item.Change;
                dgTransactions[dtlTransactionVatable.Index, row].Value = item.Vatable;
                dgTransactions[dtlTransactionVat.Index, row].Value = item.Vat;
                dgTransactions[dtlTransactionVatExempt.Index, row].Value = item.VatExempt;
                dgTransactions[dtlTransactionZeroRated.Index, row].Value = item.ZeroRated;
                dgTransactions[dtlTransactionReprint.Index, row].Value = item.Reprint;
                dgTransactions[dtlTransactionDescription.Index, row].Value = item.Description;
                dgTransactions[dtlTransactionUpdateUser.Index, row].Value = item.Username;
                dgTransactions[dtlTransactionEntrance.Index, row].Value = item.Entrance;
                dgTransactions[dtlTransactionExit.Index, row].Value = item.Exit;

                dgTransactions[dtlTransactionSCPWDName.Index, row].Value = item.SCPWDName;
                dgTransactions[dtlTransactionSDPWDAddress.Index, row].Value = item.SCPWDAddress;
                dgTransactions[dtlTransactionSCPWDId.Index, row].Value = item.SCPWDId;
                dgTransactions[dtlTransactionLCPenalty.Index, row].Value = item.LostCardPenalty;
                dgTransactions[dtlTransactionLCName.Index, row].Value = item.LostCardName;
                dgTransactions[dtlTransactionLCLicenseNo.Index, row].Value = item.LostCardLicenseNo;
                dgTransactions[dtlTransactionLCORCR.Index, row].Value = item.LostCardORCR;
                dgTransactions[dtlTransactionOvernight.Index, row].Value = item.OvernightPenalty;
                row++;
            }
            dgTransactions.AutoResizeColumns();
        }
        private void PopulateSalesCollection(IEnumerable<SalesModel> items)
        {
            dgCollections.Rows.Clear();
            if (items.Count() > 0)
                dgCollections.Rows.Add(items.Count());

            var row = 0;

            foreach (var item in items)
            {
                dgCollections[dtlCollectionRow.Index, row].Value = row + 1;
                dgCollections[dtlCollectionTransitId.Index, row].Value = item.TransitId;
                dgCollections[dtlCollectionORNumber.Index, row].Value = item.ORNo;
                dgCollections[dtlCollectionType.Index, row].Value = item.PaymentType;
                dgCollections[dtlCollectionPlateNo.Index, row].Value = item.PlateNo;
                dgCollections[dtlCollectionTicketNo.Index, row].Value = item.TicketNo;
                dgCollections[dtlCollectionTimeIn.Index, row].Value = item.TimeIn;
                dgCollections[dtlCollectionTimeOut.Index, row].Value = item.TimeOut;
                dgCollections[dtlCollectionDuration.Index, row].Value = item.Duration;
                dgCollections[dtlCollectionRateName.Index, row].Value = item.RateName;
                dgCollections[dtlCollectionCoupon.Index, row].Value = item.Coupon;
                dgCollections[dtlCollectionGrossAmount.Index, row].Value = item.GrossAmount;
                dgCollections[dtlCollectionDiscount.Index, row].Value = item.Discount;
                dgCollections[dtlCollectionAmountDue.Index, row].Value = item.AmountDue;
                dgCollections[dtlCollectionAmountTendered.Index, row].Value = item.AmountTendered;
                dgCollections[dtlCollectionChange.Index, row].Value = item.Change;
                dgCollections[dtlCollectionVatable.Index, row].Value = item.Vatable;
                dgCollections[dtlCollectionVat.Index, row].Value = item.Vat;
                dgCollections[dtlCollectionVatExempt.Index, row].Value = item.VatExempt;
                dgCollections[dtlCollectionZeroRated.Index, row].Value = item.ZeroRated;
                dgCollections[dtlCollectionReprint.Index, row].Value = item.Reprint;
                dgCollections[dtlCollectionDescription.Index, row].Value = item.Description;
                dgCollections[dtlCollectionUpdateUser.Index, row].Value = item.Username;
                dgCollections[dtlCollectionEntrance.Index, row].Value = item.Entrance;
                dgCollections[dtlCollectionExit.Index, row].Value = item.Exit;

                dgCollections[dtlCollectionSCPWDName.Index, row].Value = item.SCPWDName;
                dgCollections[dtlCollectionSDPWDAddress.Index, row].Value = item.SCPWDAddress;
                dgCollections[dtlCollectionSCPWDId.Index, row].Value = item.SCPWDId;
                dgCollections[dtlCollectionLCPenalty.Index, row].Value = item.LostCardPenalty;
                dgCollections[dtlCollectionLCName.Index, row].Value = item.LostCardName;
                dgCollections[dtlCollectionLCLicenseNo.Index, row].Value = item.LostCardLicenseNo;
                dgCollections[dtlCollectionLCORCR.Index, row].Value = item.LostCardORCR;
                dgCollections[dtlCollectionOvernight.Index, row].Value = item.OvernightPenalty;
                row++;
            }
            dgCollections.AutoResizeColumns();
        }
        private void PopulateSalesDiscount(IEnumerable<SalesModel> items)
        {
            dgDiscounts.Rows.Clear();
            if (items.Count() > 0)
                dgDiscounts.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgDiscounts[dtlDiscountRow.Index, row].Value = row + 1;
                dgDiscounts[dtlDiscountTransitId.Index, row].Value = item.TransitId;
                dgDiscounts[dtlDiscountORNumber.Index, row].Value = item.ORNo;
                dgDiscounts[dtlDiscountType.Index, row].Value = item.PaymentType;
                dgDiscounts[dtlDiscountPlateNo.Index, row].Value = item.PlateNo;
                dgDiscounts[dtlDiscountTicketNo.Index, row].Value = item.TicketNo;
                dgDiscounts[dtlDiscountTimeIn.Index, row].Value = item.TimeIn;
                dgDiscounts[dtlDiscountTimeOut.Index, row].Value = item.TimeOut;
                dgDiscounts[dtlDiscountDuration.Index, row].Value = item.Duration;
                dgDiscounts[dtlDiscountRateName.Index, row].Value = item.RateName;
                dgDiscounts[dtlDiscountCoupon.Index, row].Value = item.Coupon;
                dgDiscounts[dtlDiscountGrossAmount.Index, row].Value = item.GrossAmount;
                dgDiscounts[dtlDiscountDiscount.Index, row].Value = item.Discount;
                dgDiscounts[dtlDiscountAmountDue.Index, row].Value = item.AmountDue;
                dgDiscounts[dtlDiscountAmountTendered.Index, row].Value = item.AmountTendered;
                dgDiscounts[dtlDiscountChange.Index, row].Value = item.Change;
                dgDiscounts[dtlDiscountVatable.Index, row].Value = item.Vatable;
                dgDiscounts[dtlDiscountVat.Index, row].Value = item.Vat;
                dgDiscounts[dtlDiscountVatExempt.Index, row].Value = item.VatExempt;
                dgDiscounts[dtlDiscountZeroRated.Index, row].Value = item.ZeroRated;
                dgDiscounts[dtlDiscountReprint.Index, row].Value = item.Reprint;
                dgDiscounts[dtlDiscountDescription.Index, row].Value = item.Description;
                dgDiscounts[dtlDiscountUpdateUser.Index, row].Value = item.Username;
                dgDiscounts[dtlDiscountEntrance.Index, row].Value = item.Entrance;
                dgDiscounts[dtlDiscountExit.Index, row].Value = item.Exit;

                dgDiscounts[dtlDiscountSCPWDName.Index, row].Value = item.SCPWDName;
                dgDiscounts[dtlDiscountSDPWDAddress.Index, row].Value = item.SCPWDAddress;
                dgDiscounts[dtlDiscountSCPWDId.Index, row].Value = item.SCPWDId;
                dgDiscounts[dtlDiscountLCPenalty.Index, row].Value = item.LostCardPenalty;
                dgDiscounts[dtlDiscountLCName.Index, row].Value = item.LostCardName;
                dgDiscounts[dtlDiscountLCLicenseNo.Index, row].Value = item.LostCardLicenseNo;
                dgDiscounts[dtlDiscountLCORCR.Index, row].Value = item.LostCardORCR;
                dgDiscounts[dtlDiscountOvernight.Index, row].Value = item.OvernightPenalty;
                row++;
            }
            dgDiscounts.AutoResizeColumns();
        }
        private void PopulateSalesErased(IEnumerable<SalesModel> items)
        {
            dgErased.Rows.Clear();
            if (items.Count() > 0)
                dgErased.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgErased[dtlEraseRow.Index, row].Value = row + 1;
                dgErased[dtlEraseTransitId.Index, row].Value = item.TransitId;
                dgErased[dtlEraseORNumber.Index, row].Value = item.ORNo;
                dgErased[dtlEraseType.Index, row].Value = item.PaymentType;
                dgErased[dtlErasePlateNo.Index, row].Value = item.PlateNo;
                dgErased[dtlEraseTicketNo.Index, row].Value = item.TicketNo;
                dgErased[dtlEraseTimeIn.Index, row].Value = item.TimeIn;
                dgErased[dtlEraseTimeOut.Index, row].Value = item.TimeOut;
                dgErased[dtlEraseDuration.Index, row].Value = item.Duration;
                dgErased[dtlEraseRateName.Index, row].Value = item.RateName;
                dgErased[dtlEraseCoupon.Index, row].Value = item.Coupon;
                dgErased[dtlEraseGrossAmount.Index, row].Value = item.GrossAmount;
                dgErased[dtlEraseDiscount.Index, row].Value = item.Discount;
                dgErased[dtlEraseAmountDue.Index, row].Value = item.AmountDue;
                dgErased[dtlEraseAmountTendered.Index, row].Value = item.AmountTendered;
                dgErased[dtlEraseChange.Index, row].Value = item.Change;
                dgErased[dtlEraseVatable.Index, row].Value = item.Vatable;
                dgErased[dtlEraseVat.Index, row].Value = item.Vat;
                dgErased[dtlEraseVatExempt.Index, row].Value = item.VatExempt;
                dgErased[dtlEraseZeroRated.Index, row].Value = item.ZeroRated;
                dgErased[dtlEraseReprint.Index, row].Value = item.Reprint;
                dgErased[dtlEraseDescription.Index, row].Value = item.Description;
                dgErased[dtlEraseUpdateUser.Index, row].Value = item.Username;
                dgErased[dtlEraseEntrance.Index, row].Value = item.Entrance;
                dgErased[dtlEraseExit.Index, row].Value = item.Exit;


                dgErased[dtlEraseSCPWDName.Index, row].Value = item.SCPWDName;
                dgErased[dtlEraseSDPWDAddress.Index, row].Value = item.SCPWDAddress;
                dgErased[dtlEraseSCPWDId.Index, row].Value = item.SCPWDId;
                dgErased[dtlEraseLCPenalty.Index, row].Value = item.LostCardPenalty;
                dgErased[dtlEraseLCName.Index, row].Value = item.LostCardName;
                dgErased[dtlEraseLCLicenseNo.Index, row].Value = item.LostCardLicenseNo;
                dgErased[dtlEraseLCORCR.Index, row].Value = item.LostCardORCR;
                dgErased[dtlEraseOvernight.Index, row].Value = item.OvernightPenalty;
                row++;
            }
            dgErased.AutoResizeColumns();
        }
        private void PopulateSalesFee(IEnumerable<SalesModel> items)
        {
            dgFees.Rows.Clear();
            if (items.Count() > 0)
                dgFees.Rows.Add(items.Count());

            var row = 0;

            foreach (var item in items)
            {
                dgFees[dtlFeeRow.Index, row].Value = row + 1;
                dgFees[dtlFeeTransitId.Index, row].Value = item.TransitId;
                dgFees[dtlFeeORNumber.Index, row].Value = item.ORNo;
                dgFees[dtlFeeType.Index, row].Value = item.PaymentType;
                dgFees[dtlFeePlateNo.Index, row].Value = item.PlateNo;
                dgFees[dtlFeeTicketNo.Index, row].Value = item.TicketNo;
                dgFees[dtlFeeTimeIn.Index, row].Value = item.TimeIn;
                dgFees[dtlFeeTimeOut.Index, row].Value = item.TimeOut;
                dgFees[dtlFeeDuration.Index, row].Value = item.Duration;
                dgFees[dtlFeeRateName.Index, row].Value = item.RateName;
                dgFees[dtlFeeCoupon.Index, row].Value = item.Coupon;
                dgFees[dtlFeeGrossAmount.Index, row].Value = item.GrossAmount;
                dgFees[dtlFeeDiscount.Index, row].Value = item.Discount;
                dgFees[dtlFeeAmountDue.Index, row].Value = item.AmountDue;
                dgFees[dtlFeeAmountTendered.Index, row].Value = item.AmountTendered;
                dgFees[dtlFeeChange.Index, row].Value = item.Change;
                dgFees[dtlFeeVatable.Index, row].Value = item.Vatable;
                dgFees[dtlFeeVat.Index, row].Value = item.Vat;
                dgFees[dtlFeeVatExempt.Index, row].Value = item.VatExempt;
                dgFees[dtlFeeZeroRated.Index, row].Value = item.ZeroRated;
                dgFees[dtlFeeReprint.Index, row].Value = item.Reprint;
                dgFees[dtlFeeDescription.Index, row].Value = item.Description;
                dgFees[dtlFeeUpdateUser.Index, row].Value = item.Username;
                dgFees[dtlFeeEntrance.Index, row].Value = item.Entrance;
                dgFees[dtlFeeExit.Index, row].Value = item.Exit;

                dgFees[dtlFeeSCPWDName.Index, row].Value = item.SCPWDName;
                dgFees[dtlFeeSDPWDAddress.Index, row].Value = item.SCPWDAddress;
                dgFees[dtlFeeSCPWDId.Index, row].Value = item.SCPWDId;
                dgFees[dtlFeeLCPenalty.Index, row].Value = item.LostCardPenalty;
                dgFees[dtlFeeLCName.Index, row].Value = item.LostCardName;
                dgFees[dtlFeeLCLicenseNo.Index, row].Value = item.LostCardLicenseNo;
                dgFees[dtlFeeLCORCR.Index, row].Value = item.LostCardORCR;
                dgFees[dtlFeeOvernight.Index, row].Value = item.OvernightPenalty;
                row++;
            }
            dgFees.AutoResizeColumns();
        }
        private void PopulateSalesCashless(IEnumerable<SalesModel> items)
        {
            dgCashless.Rows.Clear();
            if (items.Count() > 0)
                dgCashless.Rows.Add(items.Count());

            var row = 0;

            foreach (var item in items)
            {
                dgCashless[dtlCashlessRow.Index, row].Value = row + 1;
                dgCashless[dtlCashlessTransitId.Index, row].Value = item.TransitId;
                dgCashless[dtlCashlessORNumber.Index, row].Value = item.ORNo;
                dgCashless[dtlCashlessType.Index, row].Value = item.PaymentType;
                dgCashless[dtlCashlessPlateNo.Index, row].Value = item.PlateNo;
                dgCashless[dtlCashlessTicketNo.Index, row].Value = item.TicketNo;
                dgCashless[dtlCashlessTimeIn.Index, row].Value = item.TimeIn;
                dgCashless[dtlCashlessTimeOut.Index, row].Value = item.TimeOut;
                dgCashless[dtlCashlessDuration.Index, row].Value = item.Duration;
                dgCashless[dtlCashlessRateName.Index, row].Value = item.RateName;
                dgCashless[dtlCashlessCoupon.Index, row].Value = item.Coupon;
                dgCashless[dtlCashlessGrossAmount.Index, row].Value = item.GrossAmount;
                dgCashless[dtlCashlessDiscount.Index, row].Value = item.Discount;
                dgCashless[dtlCashlessAmountDue.Index, row].Value = item.AmountDue;
                dgCashless[dtlCashlessAmountTendered.Index, row].Value = item.AmountTendered;
                dgCashless[dtlCashlessChange.Index, row].Value = item.Change;
                dgCashless[dtlCashlessVatable.Index, row].Value = item.Vatable;
                dgCashless[dtlCashlessVat.Index, row].Value = item.Vat;
                dgCashless[dtlCashlessVatExempt.Index, row].Value = item.VatExempt;
                dgCashless[dtlCashlessZeroRated.Index, row].Value = item.ZeroRated;
                dgCashless[dtlCashlessReprint.Index, row].Value = item.Reprint;
                dgCashless[dtlCashlessDescription.Index, row].Value = item.Description;
                dgCashless[dtlCashlessUpdateUser.Index, row].Value = item.Username;
                dgCashless[dtlCashlessEntrance.Index, row].Value = item.Entrance;
                dgCashless[dtlCashlessExit.Index, row].Value = item.Exit;

                dgCashless[dtlCashlessSCPWDName.Index, row].Value = item.SCPWDName;
                dgCashless[dtlCashlessSDPWDAddress.Index, row].Value = item.SCPWDAddress;
                dgCashless[dtlCashlessSCPWDId.Index, row].Value = item.SCPWDId;
                dgCashless[dtlCashlessLCPenalty.Index, row].Value = item.LostCardPenalty;
                dgCashless[dtlCashlessLCName.Index, row].Value = item.LostCardName;
                dgCashless[dtlCashlessLCLicenseNo.Index, row].Value = item.LostCardLicenseNo;
                dgCashless[dtlCashlessLCORCR.Index, row].Value = item.LostCardORCR;
                dgCashless[dtlCashlessOvernight.Index, row].Value = item.OvernightPenalty;
                row++;
            }
            dgFees.AutoResizeColumns();
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

            var dt = await services.SalesReportDataTableAsync(from, to, txtSearch.Text.Trim(), cboTerminal.SelectedValue.ToString());
            dt.Columns.Remove("TransitId");
            dt.Columns.Remove("IsErased");
            dt.AcceptChanges();

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Sales Report " + from.ToString("MMddyyyy hhmmsstt") + "-" + to.ToString("MMddyyyy hhmmsstt");
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

            var dt = await services.SalesReportDataTableAsync(from, to, txtSearch.Text.Trim(), cboTerminal.SelectedValue.ToString());
            dt.Columns.Remove("TransitId");
            dt.Columns.Remove("IsErased");
            dt.AcceptChanges();

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Sales Report " + from.ToString("MMddyyyy hhmmsstt") + "-" + to.ToString("MMddyyyy hhmmsstt");
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

            var dt = await services.SalesReportDataTableAsync(from, to, txtSearch.Text.Trim(), cboTerminal.SelectedValue.ToString());


            dt.TableName = "SalesReport";
            var viewer = new CrystalViewer();
            viewer.DateCovered = from.ToString() + "-" + to.ToString();
            viewer.ReportType = ReportType.Sales;
            viewer.DataSource = dt;
            viewer.ShowDialog();
            btnPrint.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgAllSales.Rows.Count <= 0)
                return;

            var key = Finder.SearchResult();
            dgAllSales.FindValue(key);
        }

        private void dgAllSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if(e.ColumnIndex == dtlAllImage.Index)
            {
                var id = dgAllSales[dtlAllTransitId.Index, e.RowIndex].Value.ToString();
                ImageViewer.ShowImage(int.Parse(id));
            }
        }

        private void dgTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == dtlTransactionImage.Index)
            {
                var id = dgTransactions[dtlTransactionTransitId.Index, e.RowIndex].Value.ToString();
                ImageViewer.ShowImage(int.Parse(id));
            }
        }

        private void dgCollections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == dtlCollectionImage.Index)
            {
                var id = dgCollections[dtlCollectionTransitId.Index, e.RowIndex].Value.ToString();
                ImageViewer.ShowImage(int.Parse(id));
            }
        }

        private void dgDiscounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == dtlDiscountImage.Index)
            {
                var id = dgDiscounts[dtlDiscountTransitId.Index, e.RowIndex].Value.ToString();
                ImageViewer.ShowImage(int.Parse(id));
            }
        }

        private void dgErased_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == dtlEraseImage.Index)
            {
                var id = dgErased[dtlEraseTransitId.Index, e.RowIndex].Value.ToString();
                ImageViewer.ShowImage(int.Parse(id));
            }
        }

        private void dgFees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == dtlFeeImage.Index)
            {
                var id = dgFees[dtlFeeTransitId.Index, e.RowIndex].Value.ToString();
                ImageViewer.ShowImage(int.Parse(id));
            }
        }
    }
}
