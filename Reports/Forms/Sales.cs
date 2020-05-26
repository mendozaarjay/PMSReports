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
    public partial class Sales : Form
    {

        private SalesServices services = new SalesServices();
        public Sales()
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
            var result = await services.SalesReportAsync(dtFrom.Value.Minimun(), dtTo.Value.Maximum(), txtSearch.Text.Trim());
            var all = result;
            var transaction = result.Where(a => a.AmountDue > 0 && !a.IsErased).ToList();
            var collection = result.Where(a => a.TimeOut.Length > 0 && !a.IsErased).ToList();
            var discount = result.Where(a => a.Discount > 0 && !a.IsErased).ToList();
            var erased = result.Where(a => a.IsErased).ToList();
            var fee = result.Where(a => a.AmountDue > 0 && !a.IsErased).ToList();
            PopulateSalesAll(all);
            PopulateSalesTransactions(transaction);
            PopulateSalesCollection(collection);
            PopulateSalesDiscount(discount);
            PopulateSalesErased(erased);
            PopulateSalesFee(fee);
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
                dgAllSales[dtlAllTransitId.Index, row].Value = item.TransitId;
                dgAllSales[dtlAllORNumber.Index, row].Value = item.ORNo;
                dgAllSales[dtlAllType.Index, row].Value = item.Type;
                dgAllSales[dtlAllPlateNo.Index, row].Value = item.PlateNo;
                dgAllSales[dtlAllTicketNo.Index, row].Value = item.TicketNo;
                dgAllSales[dtlAllTimeIn.Index, row].Value = item.TimeIn;
                dgAllSales[dtlAllTimeOut.Index, row].Value = item.TimeOut;
                dgAllSales[dtlAllDuration.Index, row].Value = item.Duration;
                dgAllSales[dtlAllRateName.Index, row].Value = item.RateName;
                dgAllSales[dtlAllCoupon.Index, row].Value = item.Coupon;
                dgAllSales[dtlAllMonthlyRFID.Index, row].Value = item.MonthlyRFID;
                dgAllSales[dtlAllMonthlyName.Index, row].Value = item.MonthlyName;
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
                dgAllSales[dtlAllUpdateUser.Index, row].Value = item.UpdateUser;
                row++;
            }
        }
        private void PopulateSalesTransactions(IEnumerable<SalesModel> items)
        {
            dgTransactions.Rows.Clear();
            if (items.Count() > 0)
                dgTransactions.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgTransactions[dtlTransactionTransitId.Index, row].Value = item.TransitId;
                dgTransactions[dtlTransactionORNumber.Index, row].Value = item.ORNo;
                dgTransactions[dtlTransactionType.Index, row].Value = item.Type;
                dgTransactions[dtlTransactionPlateNo.Index, row].Value = item.PlateNo;
                dgTransactions[dtlTransactionTicketNo.Index, row].Value = item.TicketNo;
                dgTransactions[dtlTransactionTimeIn.Index, row].Value = item.TimeIn;
                dgTransactions[dtlTransactionTimeOut.Index, row].Value = item.TimeOut;
                dgTransactions[dtlTransactionDuration.Index, row].Value = item.Duration;
                dgTransactions[dtlTransactionRateName.Index, row].Value = item.RateName;
                dgTransactions[dtlTransactionCoupon.Index, row].Value = item.Coupon;
                dgTransactions[dtlTransactionMonthlyRFID.Index, row].Value = item.MonthlyRFID;
                dgTransactions[dtlTransactionMonthlyName.Index, row].Value = item.MonthlyName;
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
                dgTransactions[dtlTransactionUpdateUser.Index, row].Value = item.UpdateUser;
                row++;
            }
        }
        private void PopulateSalesCollection(IEnumerable<SalesModel> items)
        {
            dgCollections.Rows.Clear();
            if (items.Count() > 0)
                dgCollections.Rows.Add(items.Count());

            var row = 0;

            foreach (var item in items)
            {
                dgCollections[dtlCollectionTransitId.Index, row].Value = item.TransitId;
                dgCollections[dtlCollectionORNumber.Index, row].Value = item.ORNo;
                dgCollections[dtlCollectionType.Index, row].Value = item.Type;
                dgCollections[dtlCollectionPlateNo.Index, row].Value = item.PlateNo;
                dgCollections[dtlCollectionTicketNo.Index, row].Value = item.TicketNo;
                dgCollections[dtlCollectionTimeIn.Index, row].Value = item.TimeIn;
                dgCollections[dtlCollectionTimeOut.Index, row].Value = item.TimeOut;
                dgCollections[dtlCollectionDuration.Index, row].Value = item.Duration;
                dgCollections[dtlCollectionRateName.Index, row].Value = item.RateName;
                dgCollections[dtlCollectionCoupon.Index, row].Value = item.Coupon;
                dgCollections[dtlCollectionMonthlyRFID.Index, row].Value = item.MonthlyRFID;
                dgCollections[dtlCollectionMonthlyName.Index, row].Value = item.MonthlyName;
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
                dgCollections[dtlCollectionUpdateUser.Index, row].Value = item.UpdateUser;
                row++;
            }
        }
        private void PopulateSalesDiscount(IEnumerable<SalesModel> items)
        {
            dgDiscounts.Rows.Clear();
            if (items.Count() > 0)
                dgDiscounts.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgDiscounts[dtlDiscountTransitId.Index, row].Value = item.TransitId;
                dgDiscounts[dtlDiscountORNumber.Index, row].Value = item.ORNo;
                dgDiscounts[dtlDiscountType.Index, row].Value = item.Type;
                dgDiscounts[dtlDiscountPlateNo.Index, row].Value = item.PlateNo;
                dgDiscounts[dtlDiscountTicketNo.Index, row].Value = item.TicketNo;
                dgDiscounts[dtlDiscountTimeIn.Index, row].Value = item.TimeIn;
                dgDiscounts[dtlDiscountTimeOut.Index, row].Value = item.TimeOut;
                dgDiscounts[dtlDiscountDuration.Index, row].Value = item.Duration;
                dgDiscounts[dtlDiscountRateName.Index, row].Value = item.RateName;
                dgDiscounts[dtlDiscountCoupon.Index, row].Value = item.Coupon;
                dgDiscounts[dtlDiscountMonthlyRFID.Index, row].Value = item.MonthlyRFID;
                dgDiscounts[dtlDiscountMonthlyName.Index, row].Value = item.MonthlyName;
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
                dgDiscounts[dtlDiscountUpdateUser.Index, row].Value = item.UpdateUser;
                row++;
            }
        }
        private void PopulateSalesErased(IEnumerable<SalesModel> items)
        {
            dgErased.Rows.Clear();
            if (items.Count() > 0)
                dgErased.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgErased[dtlEraseTransitId.Index, row].Value = item.TransitId;
                dgErased[dtlEraseORNumber.Index, row].Value = item.ORNo;
                dgErased[dtlEraseType.Index, row].Value = item.Type;
                dgErased[dtlErasePlateNo.Index, row].Value = item.PlateNo;
                dgErased[dtlEraseTicketNo.Index, row].Value = item.TicketNo;
                dgErased[dtlEraseTimeIn.Index, row].Value = item.TimeIn;
                dgErased[dtlEraseTimeOut.Index, row].Value = item.TimeOut;
                dgErased[dtlEraseDuration.Index, row].Value = item.Duration;
                dgErased[dtlEraseRateName.Index, row].Value = item.RateName;
                dgErased[dtlEraseCoupon.Index, row].Value = item.Coupon;
                dgErased[dtlEraseMonthlyRFID.Index, row].Value = item.MonthlyRFID;
                dgErased[dtlEraseMonthlyName.Index, row].Value = item.MonthlyName;
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
                dgErased[dtlEraseUpdateUser.Index, row].Value = item.UpdateUser;
                row++;
            }
        }
        private void PopulateSalesFee(IEnumerable<SalesModel> items)
        {
            dgFees.Rows.Clear();
            if (items.Count() > 0)
                dgFees.Rows.Add(items.Count());

            var row = 0;

            foreach (var item in items)
            {
                dgFees[dtlFeeTransitId.Index, row].Value = item.TransitId;
                dgFees[dtlFeeORNumber.Index, row].Value = item.ORNo;
                dgFees[dtlFeeType.Index, row].Value = item.Type;
                dgFees[dtlFeePlateNo.Index, row].Value = item.PlateNo;
                dgFees[dtlFeeTicketNo.Index, row].Value = item.TicketNo;
                dgFees[dtlFeeTimeIn.Index, row].Value = item.TimeIn;
                dgFees[dtlFeeTimeOut.Index, row].Value = item.TimeOut;
                dgFees[dtlFeeDuration.Index, row].Value = item.Duration;
                dgFees[dtlFeeRateName.Index, row].Value = item.RateName;
                dgFees[dtlFeeCoupon.Index, row].Value = item.Coupon;
                dgFees[dtlFeeMonthlyRFID.Index, row].Value = item.MonthlyRFID;
                dgFees[dtlFeeMonthlyName.Index, row].Value = item.MonthlyName;
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
                dgFees[dtlFeeUpdateUser.Index, row].Value = item.UpdateUser;
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
            var dt = await services.SalesReportDataTableAsync(dtFrom.Value.Minimun(), dtTo.Value.Maximum(), txtSearch.Text.Trim());
            dt.Columns.Remove("TransitId");
            dt.Columns.Remove("IsErased");
            dt.AcceptChanges();

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Sales Report " + dtFrom.Value.ToString("MMddyyy") + "-" + dtTo.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            var dt = await services.SalesReportDataTableAsync(dtFrom.Value.Minimun(), dtTo.Value.Maximum(), txtSearch.Text.Trim());
            dt.Columns.Remove("TransitId");
            dt.Columns.Remove("IsErased");
            dt.AcceptChanges();

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Sales Report " + dtFrom.Value.ToString("MMddyyy") + "-" + dtTo.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToExcel(dt, "Sales Report", sd.FileName);
            }
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            var dt = await services.SalesReportDataTableAsync(dtFrom.Value.Minimun(), dtTo.Value.Maximum(), txtSearch.Text.Trim());
            dt.Columns.Remove("TransitId");
            dt.Columns.Remove("IsErased");
            dt.AcceptChanges();

            dt.TableName = "Sales";
            var viewer = new Viewer();
            viewer.ReportType = ReportType.Sales;
            viewer.Source = dt;
            viewer.ShowDialog();
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
