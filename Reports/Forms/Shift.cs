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
    public partial class Shift : Form
    {
        private ShiftServices services = new ShiftServices();
        public UserAccessItem UserAccess { get; set; }
        public Shift()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            timeFrom.Value = DateTime.Now.Minimun();
            timeTo.Value = DateTime.Now.Maximum();

            CheckForIllegalCrossThreadCalls = false;
            this.PerformLayout();
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

            var items = await services.ShiftReportAsync(from, to, txtSearch.Text);


            PopulateAll(items);

            var shiftIn = items.Where(a => a.Type == "Shift In");
            var shiftOut = items.Where(a => a.Type == "Shift Out");
            var partial = items.Where(a => a.Type == "Partial");
            var dutyOff = items.Where(a => a.Type == "Duty Off");
            var cutOff = items.Where(a => a.Type == "Cut Off");
            var endOfDay = items.Where(a => a.Type == "End of Day");


            Spinner.ShowSpinner(this, () =>
            {
                PopulateShiftIn(shiftIn);
                PopulateShiftOut(shiftOut);
                PopulatePartial(partial);
                PopulateDutyOff(dutyOff);
                PopulateCutOff(cutOff);
                PopulateEndOfDay(endOfDay);
            });

            btnGenerate.Enabled = true;
        }
        #region Populate Report

        private void PopulateAll(IEnumerable<ShiftModel> items)
        {
            dgAll.Rows.Clear();
            if (items.Count() > 0)
                dgAll.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgAll[dtlAllRow.Index, row].Value = row + 1;
                dgAll[dtlAllSRNumber.Index, row].Value = item.SRNumber;
                dgAll[dtlAllType.Index, row].Value = item.Type;
                dgAll[dtlAllDateTimeIn.Index, row].Value = item.DateTimeIn;
                dgAll[dtlAllDateTimeOut.Index, row].Value = item.DateTimeOut;
                dgAll[dtlAllExitCount.Index, row].Value = item.ExitCount;
                dgAll[dtlAllGrossAmount.Index, row].Value = item.GrossAmount;
                dgAll[dtlAllVat.Index, row].Value = item.Vat;
                dgAll[dtlAllVatable.Index, row].Value = item.Vatable;
                dgAll[dtlAllDiscount.Index, row].Value = item.Discount;
                dgAll[dtlAllTodaySales.Index, row].Value = item.GrossAmount;
                dgAll[dtlAllAmountTendered.Index, row].Value = item.AmountTendered;
                dgAll[dtlAllChange.Index, row].Value = item.Change;
                dgAll[dtlAllChangeFund.Index, row].Value = item.ChangeFund;
                dgAll[dtlAllTenderDeclaration.Index, row].Value = item.TenderDeclaration;
                dgAll[dtlAllVariance.Index, row].Value = item.Variance;
                dgAll[dtlAllUpdateUser.Index, row].Value = item.Username;
                row++;
            }
            dgAll.AutoResizeColumns();
        }
        private void PopulateShiftIn(IEnumerable<ShiftModel> items)
        {
            dgShiftIn.Rows.Clear();
            if (items.Count() > 0)
                dgShiftIn.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgShiftIn[dtlShiftInRow.Index, row].Value = row + 1;
                dgShiftIn[dtlShiftInSRNumber.Index, row].Value = item.SRNumber;
                dgShiftIn[dtlShiftInType.Index, row].Value = item.Type;
                dgShiftIn[dtlShiftInDateTimeIn.Index, row].Value = item.DateTimeIn;
                dgShiftIn[dtlShiftInDateTimeOut.Index, row].Value = item.DateTimeOut;
                dgShiftIn[dtlShiftInExitCount.Index, row].Value = item.ExitCount;
                dgShiftIn[dtlShiftInGrossAmount.Index, row].Value = item.GrossAmount;
                dgShiftIn[dtlShiftInVat.Index, row].Value = item.Vat;
                dgShiftIn[dtlShiftInVatable.Index, row].Value = item.Vatable;
                dgShiftIn[dtlShiftInDiscount.Index, row].Value = item.Discount;
                dgShiftIn[dtlShiftInTodaySales.Index, row].Value = item.GrossAmount;
                dgShiftIn[dtlShiftInAmountTendered.Index, row].Value = item.AmountTendered;
                dgShiftIn[dtlShiftInChange.Index, row].Value = item.Change;
                dgShiftIn[dtlShiftInChangeFund.Index, row].Value = item.ChangeFund;
                dgShiftIn[dtlShiftInTenderDeclaration.Index, row].Value = item.TenderDeclaration;
                dgShiftIn[dtlShiftInVariance.Index, row].Value = item.Variance;
                dgShiftIn[dtlShiftInUpdateUser.Index, row].Value = item.Username;
                row++;
            }
            dgShiftIn.AutoResizeColumns();
        }
        private void PopulateShiftOut(IEnumerable<ShiftModel> items)
        {
            dgShiftOut.Rows.Clear();
            if (items.Count() > 0)
                dgShiftOut.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgShiftOut[dtlShiftOutRow.Index, row].Value = row + 1;
                dgShiftOut[dtlShiftOutSRNumber.Index, row].Value = item.SRNumber;
                dgShiftOut[dtlShiftOutType.Index, row].Value = item.Type;
                dgShiftOut[dtlShiftOutDateTimeIn.Index, row].Value = item.DateTimeIn;
                dgShiftOut[dtlShiftOutDateTimeOut.Index, row].Value = item.DateTimeOut;
                dgShiftOut[dtlShiftOutExitCount.Index, row].Value = item.ExitCount;
                dgShiftOut[dtlShiftOutGrossAmount.Index, row].Value = item.GrossAmount;
                dgShiftOut[dtlShiftOutVat.Index, row].Value = item.Vat;
                dgShiftOut[dtlShiftOutVatable.Index, row].Value = item.Vatable;
                dgShiftOut[dtlShiftOutDiscount.Index, row].Value = item.Discount;
                dgShiftOut[dtlShiftOutTodaySales.Index, row].Value = item.GrossAmount;
                dgShiftOut[dtlShiftOutAmountTendered.Index, row].Value = item.AmountTendered;
                dgShiftOut[dtlShiftOutChange.Index, row].Value = item.Change;
                dgShiftOut[dtlShiftOutChangeFund.Index, row].Value = item.ChangeFund;
                dgShiftOut[dtlShiftOutTenderDeclaration.Index, row].Value = item.TenderDeclaration;
                dgShiftOut[dtlShiftOutVariance.Index, row].Value = item.Variance;
                dgShiftOut[dtlShiftOutUpdateUser.Index, row].Value = item.Username;
                row++;
            }
            dgShiftOut.AutoResizeColumns();
        }
        private void PopulatePartial(IEnumerable<ShiftModel> items)
        {
            dgPartial.Rows.Clear();
            if (items.Count() > 0)
                dgPartial.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgPartial[dtlPartialRow.Index, row].Value = row + 1;
                dgPartial[dtlPartialSRNumber.Index, row].Value = item.SRNumber;
                dgPartial[dtlPartialType.Index, row].Value = item.Type;
                dgPartial[dtlPartialDateTimeIn.Index, row].Value = item.DateTimeIn;
                dgPartial[dtlPartialDateTimeOut.Index, row].Value = item.DateTimeOut;
                dgPartial[dtlPartialExitCount.Index, row].Value = item.ExitCount;
                dgPartial[dtlPartialGrossAmount.Index, row].Value = item.GrossAmount;
                dgPartial[dtlPartialVat.Index, row].Value = item.Vat;
                dgPartial[dtlPartialVatable.Index, row].Value = item.Vatable;
                dgPartial[dtlPartialDiscount.Index, row].Value = item.Discount;
                dgPartial[dtlPartialTodaySales.Index, row].Value = item.GrossAmount;
                dgPartial[dtlPartialAmountTendered.Index, row].Value = item.AmountTendered;
                dgPartial[dtlPartialChange.Index, row].Value = item.Change;
                dgPartial[dtlPartialChangeFund.Index, row].Value = item.ChangeFund;
                dgPartial[dtlPartialTenderDeclaration.Index, row].Value = item.TenderDeclaration;
                dgPartial[dtlPartialVariance.Index, row].Value = item.Variance;
                dgPartial[dtlPartialUpdateUser.Index, row].Value = item.Username;
                row++;
            }
            dgPartial.AutoResizeColumns();
        }

        private void PopulateDutyOff(IEnumerable<ShiftModel> items)
        {
            dgDutyOff.Rows.Clear();
            if (items.Count() > 0)
                dgDutyOff.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgDutyOff[dtlDutyOffRow.Index, row].Value = row + 1;
                dgDutyOff[dtlDutyOffSRNumber.Index, row].Value = item.SRNumber;
                dgDutyOff[dtlDutyOffType.Index, row].Value = item.Type;
                dgDutyOff[dtlDutyOffDateTimeIn.Index, row].Value = item.DateTimeIn;
                dgDutyOff[dtlDutyOffDateTimeOut.Index, row].Value = item.DateTimeOut;
                dgDutyOff[dtlDutyOffExitCount.Index, row].Value = item.ExitCount;
                dgDutyOff[dtlDutyOffGrossAmount.Index, row].Value = item.GrossAmount;
                dgDutyOff[dtlDutyOffVat.Index, row].Value = item.Vat;
                dgDutyOff[dtlDutyOffVatable.Index, row].Value = item.Vatable;
                dgDutyOff[dtlDutyOffDiscount.Index, row].Value = item.Discount;
                dgDutyOff[dtlDutyOffTodaySales.Index, row].Value = item.GrossAmount;
                dgDutyOff[dtlDutyOffAmountTendered.Index, row].Value = item.AmountTendered;
                dgDutyOff[dtlDutyOffChange.Index, row].Value = item.Change;
                dgDutyOff[dtlDutyOffChangeFund.Index, row].Value = item.ChangeFund;
                dgDutyOff[dtlDutyOffTenderDeclaration.Index, row].Value = item.TenderDeclaration;
                dgDutyOff[dtlDutyOffVariance.Index, row].Value = item.Variance;
                dgDutyOff[dtlDutyOffUpdateUser.Index, row].Value = item.Username;
                row++;
            }
            dgDutyOff.AutoResizeColumns();
        }

        private void PopulateCutOff(IEnumerable<ShiftModel> items)
        {
            dgCutOff.Rows.Clear();
            if (items.Count() > 0)
                dgCutOff.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgCutOff[dtlCutOffRow.Index, row].Value = row + 1;
                dgCutOff[dtlCutOffSRNumber.Index, row].Value = item.SRNumber;
                dgCutOff[dtlCutOffType.Index, row].Value = item.Type;
                dgCutOff[dtlCutOffDateTimeIn.Index, row].Value = item.DateTimeIn;
                dgCutOff[dtlCutOffDateTimeOut.Index, row].Value = item.DateTimeOut;
                dgCutOff[dtlCutOffExitCount.Index, row].Value = item.ExitCount;
                dgCutOff[dtlCutOffGrossAmount.Index, row].Value = item.GrossAmount;
                dgCutOff[dtlCutOffVat.Index, row].Value = item.Vat;
                dgCutOff[dtlCutOffVatable.Index, row].Value = item.Vatable;
                dgCutOff[dtlCutOffDiscount.Index, row].Value = item.Discount;
                dgCutOff[dtlCutOffTodaySales.Index, row].Value = item.GrossAmount;
                dgCutOff[dtlCutOffAmountTendered.Index, row].Value = item.AmountTendered;
                dgCutOff[dtlCutOffChange.Index, row].Value = item.Change;
                dgCutOff[dtlCutOffChangeFund.Index, row].Value = item.ChangeFund;
                dgCutOff[dtlCutOffTenderDeclaration.Index, row].Value = item.TenderDeclaration;
                dgCutOff[dtlCutOffVariance.Index, row].Value = item.Variance;
                dgCutOff[dtlCutOffUpdateUser.Index, row].Value = item.Username;
                row++;
            }
            dgCutOff.AutoResizeColumns();
        }

        private void PopulateEndOfDay(IEnumerable<ShiftModel> items)
        {
            dgEndOfDay.Rows.Clear();
            if (items.Count() > 0)
                dgEndOfDay.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgEndOfDay[dtlEndOfDayRow.Index, row].Value = row + 1;
                dgEndOfDay[dtlEndOfDaySRNumber.Index, row].Value = item.SRNumber;
                dgEndOfDay[dtlEndOfDayType.Index, row].Value = item.Type;
                dgEndOfDay[dtlEndOfDayDateTimeIn.Index, row].Value = item.DateTimeIn;
                dgEndOfDay[dtlEndOfDayDateTimeOut.Index, row].Value = item.DateTimeOut;
                dgEndOfDay[dtlEndOfDayExitCount.Index, row].Value = item.ExitCount;
                dgEndOfDay[dtlEndOfDayGrossAmount.Index, row].Value = item.GrossAmount;
                dgEndOfDay[dtlEndOfDayVat.Index, row].Value = item.Vat;
                dgEndOfDay[dtlEndOfDayVatable.Index, row].Value = item.Vatable;
                dgEndOfDay[dtlEndOfDayDiscount.Index, row].Value = item.Discount;
                dgEndOfDay[dtlEndOfDayTodaySales.Index, row].Value = item.GrossAmount;
                dgEndOfDay[dtlEndOfDayAmountTendered.Index, row].Value = item.AmountTendered;
                dgEndOfDay[dtlEndOfDayChange.Index, row].Value = item.Change;
                dgEndOfDay[dtlEndOfDayChangeFund.Index, row].Value = item.ChangeFund;
                dgEndOfDay[dtlEndOfDayTenderDeclaration.Index, row].Value = item.TenderDeclaration;
                dgEndOfDay[dtlEndOfDayVariance.Index, row].Value = item.Variance;
                dgEndOfDay[dtlEndOfDayUpdateUser.Index, row].Value = item.Username;
                row++;
            }
            dgEndOfDay.AutoResizeColumns();
        } 
        #endregion

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
            var dt = await services.ShiftReportDataTableAsync(from, to, txtSearch.Text);

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Shift Report " + dtFrom.Value.ToString("MMddyyy") + "-" + dtTo.Value.ToString("MMddyyyy");
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
            var dt = await services.ShiftReportDataTableAsync(from, to, txtSearch.Text);

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Shift Report " + dtFrom.Value.ToString("MMddyyy") + "-" + dtTo.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                //FileExport.ExportToExcel(dt, "Shift Report", sd.FileName);
                ExportToExcelFile.Export(dt, sd.FileName);
            }
            btnExcel.Enabled = true;
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var dt = await services.ShiftReportDataTableAsync(from, to, txtSearch.Text);

            dt.TableName = "Shift";
            var viewer = new Viewer();
            viewer.DateCovered = from.ToString() + "~" + to.ToString();
            viewer.ReportType = ReportType.Shift;
            viewer.Source = dt;
            viewer.ShowDialog();
            btnPrint.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgAll.Rows.Count <= 0)
                return;

            var key = Finder.SearchResult();
            dgAll.FindValue(key);
        }
    }
}
