using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Data;
using System.IO;
using OfficeOpenXml.Style.XmlAccess;
using System.Windows.Forms;
using System;

namespace Reports
{
    public static class ExportToExcelFile
    {
        public static void Export(DataTable dt, string filename)
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
