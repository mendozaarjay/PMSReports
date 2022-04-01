using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Data;
using System.IO;
using OfficeOpenXml.Style.XmlAccess;
using System.Windows.Forms;
using System;
using System.Linq;

namespace Reports
{
    public static class ExportToExcelFile
    {
        public static void Export(DataTable dt, string filename, ReportType reportType = ReportType.None)
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelPackage excel = new ExcelPackage();
                var workSheet = excel.Workbook.Worksheets.Add("Sheet1");
                workSheet.Row(1).Height = 20;
                workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                workSheet.Row(1).Style.Font.Bold = true;
                var col = 1;
                foreach (DataColumn dc in dt.Columns)
                {
                    workSheet.Cells[1, col].Value = dc.ColumnName;
                    col++;
                }
                for (int row = 1; row <= dt.Rows.Count; row++)
                {
                    for (int i = 1; i <= dt.Columns.Count; i++)
                    {
                        var type = dt.Rows[row - 1][i - 1].GetType().ToString();

                        workSheet.Cells[row + 1, i].Value = type.Equals("System.Decimal") ? decimal.Parse(dt.Rows[row - 1][i - 1].ToString()).ToString("N2") : dt.Rows[row - 1][i - 1].ToString();
                    }
                }
                int totalRow = dt.Rows.Count + 2;
                #region Sales Report
                if (reportType == ReportType.Sales)
                {
                    workSheet.Row(totalRow).Height = 20;
                    workSheet.Row(totalRow).Style.Font.Bold = true;

                    workSheet.Cells[totalRow, 1].Value = "TOTAL";

                    var grossAmount = dt.AsEnumerable().Sum(a => a.Field<decimal>("GrossAmount"));
                    var totalWithVat = dt.AsEnumerable().Sum(a => a.Field<decimal>("TotalWithVAT"));
                    var subTotal = dt.AsEnumerable().Sum(a => a.Field<decimal>("SubTotal"));
                    var discount = dt.AsEnumerable().Sum(a => a.Field<decimal>("Discount"));
                    var amountDue = dt.AsEnumerable().Sum(a => a.Field<decimal>("AmountDue"));
                    var amountTendered = dt.AsEnumerable().Sum(a => a.Field<decimal>("AmountTendered"));
                    var change = dt.AsEnumerable().Sum(a => a.Field<decimal>("Change"));
                    var vatable = dt.AsEnumerable().Sum(a => a.Field<decimal>("Vatable"));
                    var vat = dt.AsEnumerable().Sum(a => a.Field<decimal>("Vat"));
                    var vatExempt = dt.AsEnumerable().Sum(a => a.Field<decimal>("VatExempt"));
                    var zeroRated = dt.AsEnumerable().Sum(a => a.Field<int>("ZeroRated"));
                    var discountMoney = dt.AsEnumerable().Sum(a => a.Field<decimal>("DiscountMoney"));
                    var discountPercent = dt.AsEnumerable().Sum(a => a.Field<decimal>("DiscountPercent"));
                    var lostCardPenalty = dt.AsEnumerable().Sum(a => a.Field<decimal>("LostCardPenalty"));
                    var overnighPenalty = dt.AsEnumerable().Sum(a => a.Field<decimal>("OvernightPenalty"));

                    workSheet.Cells[totalRow, 12].Value = grossAmount.ToString("N2");
                    workSheet.Cells[totalRow, 13].Value = totalWithVat.ToString("N2");
                    workSheet.Cells[totalRow, 14].Value = subTotal.ToString("N2");
                    workSheet.Cells[totalRow, 15].Value = discount.ToString("N2");
                    workSheet.Cells[totalRow, 16].Value = amountDue.ToString("N2");
                    workSheet.Cells[totalRow, 17].Value = amountTendered.ToString("N2");
                    workSheet.Cells[totalRow, 18].Value = change.ToString("N2");
                    workSheet.Cells[totalRow, 19].Value = vatable.ToString("N2");
                    workSheet.Cells[totalRow, 20].Value = vat.ToString("N2");
                    workSheet.Cells[totalRow, 21].Value = vatExempt.ToString("N2");
                    workSheet.Cells[totalRow, 22].Value = decimal.Parse(zeroRated.ToString()).ToString("N2");
                    workSheet.Cells[totalRow, 23].Value = discountMoney.ToString("N2");
                    workSheet.Cells[totalRow, 24].Value = discountPercent.ToString("N2");
                    workSheet.Cells[totalRow, 35].Value = lostCardPenalty.ToString("N2");
                    workSheet.Cells[totalRow, 39].Value = overnighPenalty.ToString("N2");


                }
                #endregion
                #region Cashless Report
                if (reportType == ReportType.CashlessReport)
                {
                    workSheet.Row(totalRow).Height = 20;
                    workSheet.Row(totalRow).Style.Font.Bold = true;

                    workSheet.Cells[totalRow, 1].Value = "TOTAL";

                    var grossAmount = dt.AsEnumerable().Sum(a => a.Field<decimal>("GrossAmount"));
                    var totalWithVat = dt.AsEnumerable().Sum(a => a.Field<decimal>("TotalWithVAT"));
                    var subTotal = dt.AsEnumerable().Sum(a => a.Field<decimal>("SubTotal"));
                    var discount = dt.AsEnumerable().Sum(a => a.Field<decimal>("Discount"));
                    var amountDue = dt.AsEnumerable().Sum(a => a.Field<decimal>("AmountDue"));
                    var amountTendered = dt.AsEnumerable().Sum(a => a.Field<decimal>("AmountTendered"));
                    var change = dt.AsEnumerable().Sum(a => a.Field<decimal>("Change"));
                    var vatable = dt.AsEnumerable().Sum(a => a.Field<decimal>("Vatable"));
                    var vat = dt.AsEnumerable().Sum(a => a.Field<decimal>("Vat"));
                    var vatExempt = dt.AsEnumerable().Sum(a => a.Field<decimal>("VatExempt"));
                    var zeroRated = dt.AsEnumerable().Sum(a => a.Field<int>("ZeroRated"));
                    var discountMoney = dt.AsEnumerable().Sum(a => a.Field<decimal>("DiscountMoney"));
                    var discountPercent = dt.AsEnumerable().Sum(a => a.Field<decimal>("DiscountPercent"));
                    var lostCardPenalty = dt.AsEnumerable().Sum(a => a.Field<decimal>("LostCardPenalty"));
                    var overnighPenalty = dt.AsEnumerable().Sum(a => a.Field<decimal>("OvernightPenalty"));

                    workSheet.Cells[totalRow, 14].Value = grossAmount.ToString("N2");
                    workSheet.Cells[totalRow, 15].Value = totalWithVat.ToString("N2");
                    workSheet.Cells[totalRow, 16].Value = subTotal.ToString("N2");
                    workSheet.Cells[totalRow, 17].Value = discount.ToString("N2");
                    workSheet.Cells[totalRow, 18].Value = amountDue.ToString("N2");
                    workSheet.Cells[totalRow, 19].Value = amountTendered.ToString("N2");
                    workSheet.Cells[totalRow, 20].Value = change.ToString("N2");
                    workSheet.Cells[totalRow, 21].Value = vatable.ToString("N2");
                    workSheet.Cells[totalRow, 22].Value = vat.ToString("N2");
                    workSheet.Cells[totalRow, 23].Value = vatExempt.ToString("N2");
                    workSheet.Cells[totalRow, 24].Value = decimal.Parse(zeroRated.ToString()).ToString("N2");
                    workSheet.Cells[totalRow, 25].Value = discountMoney.ToString("N2");
                    workSheet.Cells[totalRow, 26].Value = discountPercent.ToString("N2");
                    workSheet.Cells[totalRow, 37].Value = lostCardPenalty.ToString("N2");
                    workSheet.Cells[totalRow, 41].Value = overnighPenalty.ToString("N2");


                }
                #endregion
                #region Detailed Report
                if (reportType == ReportType.DetailedTransactionSummaryReport)
                {
                    workSheet.Row(totalRow).Height = 20;
                    workSheet.Row(totalRow).Style.Font.Bold = true;
                    workSheet.Cells[totalRow, 1].Value = "TOTAL";
                    var amount = dt.AsEnumerable().Sum(a => a.Field<decimal>("Amount"));
                    var lostCard = dt.AsEnumerable().Sum(a => a.Field<decimal>("LostCardPenalty"));
                    var overNight = dt.AsEnumerable().Sum(a => a.Field<decimal>("OvernightPenalty"));
                    workSheet.Cells[totalRow, 11].Value = amount.ToString("N2");
                    workSheet.Cells[totalRow, 21].Value = lostCard.ToString("N2");
                    workSheet.Cells[totalRow, 25].Value = overNight.ToString("N2");
                }
                #endregion
                for (int i = 1; i <= dt.Columns.Count; i++)
                {
                    workSheet.Column(i).AutoFit();
                }
                if (File.Exists(filename))
                    File.Delete(filename);

                FileStream fs = File.Create(filename);
                fs.Close();
                File.WriteAllBytes(filename, excel.GetAsByteArray());
                excel.Dispose();
                MessageBox.Show("Process has been successfully completed.", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Continue.\n" + ex.Message, "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Export(DataSet ds, string filename)
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelPackage excel = new ExcelPackage();
                foreach(DataTable dt in ds.Tables)
                {

                    var workSheet = excel.Workbook.Worksheets.Add(dt.TableName);
                    workSheet.Row(1).Height = 20;
                    workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    workSheet.Row(1).Style.Font.Bold = true;
                    var col = 1;
                    foreach (DataColumn dc in dt.Columns)
                    {
                        workSheet.Cells[1, col].Value = dc.ColumnName;
                        col++;
                    }
                    for (int row = 1; row <= dt.Rows.Count; row++)
                    {
                        for (int i = 1; i <= dt.Columns.Count; i++)
                        {
                            var type = dt.Rows[row - 1][i - 1].GetType().ToString();

                            workSheet.Cells[row + 1, i].Value = type.Equals("System.Decimal") ? decimal.Parse(dt.Rows[row - 1][i - 1].ToString()).ToString("N2") : dt.Rows[row - 1][i - 1].ToString();
                        }
                    }
                    for (int i = 1; i <= dt.Columns.Count; i++)
                    {
                        workSheet.Column(i).AutoFit();
                    }
                }
                if (File.Exists(filename))
                    File.Delete(filename);

                FileStream fs = File.Create(filename);
                fs.Close();
                File.WriteAllBytes(filename, excel.GetAsByteArray());
                excel.Dispose();
                MessageBox.Show("Process has been successfully completed.", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Continue.\n" + ex.Message, "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
