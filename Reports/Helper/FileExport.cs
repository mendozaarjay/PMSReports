using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports
{
    public static class FileExport
    {
        #region Export To Excel
        public static bool ExportToExcel(DataTable dt, string sheetname, string filename)
        {
            try
            {
                using (SpreadsheetDocument spreadsheet = SpreadsheetDocument.Create(filename, SpreadsheetDocumentType.Workbook))
                {
                    spreadsheet.AddWorkbookPart();
                    spreadsheet.WorkbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

                    spreadsheet.WorkbookPart.Workbook.Append(new BookViews(new WorkbookView()));

                    WorkbookStylesPart workbookStylesPart = spreadsheet.WorkbookPart.AddNewPart<WorkbookStylesPart>("rIdStyles");
                    Stylesheet stylesheet = new Stylesheet();
                    workbookStylesPart.Stylesheet = stylesheet;


                    WorksheetPart newWorksheetPart = spreadsheet.WorkbookPart.AddNewPart<WorksheetPart>();
                    newWorksheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet();

                    newWorksheetPart.Worksheet.AppendChild(new DocumentFormat.OpenXml.Spreadsheet.SheetData());

                    WriteDataTableToExcelWorksheet(dt, newWorksheetPart);
                    newWorksheetPart.Worksheet.Save();


                    spreadsheet.WorkbookPart.Workbook.AppendChild(new DocumentFormat.OpenXml.Spreadsheet.Sheets());

                    spreadsheet.WorkbookPart.Workbook.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>().AppendChild(new DocumentFormat.OpenXml.Spreadsheet.Sheet()
                    {
                        Id = spreadsheet.WorkbookPart.GetIdOfPart(newWorksheetPart),
                        SheetId = 1,
                        Name = sheetname
                    });

                    spreadsheet.WorkbookPart.Workbook.Save();
                }
                MessageBox.Show("Process has been successfully completed.", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured.\n" + ex.Message, "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static bool ExportToExcel(List<DataTable> dataTables, string filename)
        {
            try
            {
                using (SpreadsheetDocument document = SpreadsheetDocument.Create(filename, SpreadsheetDocumentType.Workbook))
                {
                    WriteExcelFile(dataTables, document);
                }
                MessageBox.Show("Process has been successfully completed.", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured.\n" + ex.Message, "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private static void WriteExcelFile(List<DataTable> dataTables, SpreadsheetDocument spreadsheet)
        {
            spreadsheet.AddWorkbookPart();
            spreadsheet.WorkbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();
            spreadsheet.WorkbookPart.Workbook.Append(new BookViews(new WorkbookView()));
            WorkbookStylesPart workbookStylesPart = spreadsheet.WorkbookPart.AddNewPart<WorkbookStylesPart>("rIdStyles");
            Stylesheet stylesheet = new Stylesheet();
            workbookStylesPart.Stylesheet = stylesheet;

            uint worksheetNumber = 1;
            foreach (DataTable dt in dataTables)
            {
                string workSheetID = "rId" + worksheetNumber.ToString();
                string worksheetName = dt.TableName;

                WorksheetPart newWorksheetPart = spreadsheet.WorkbookPart.AddNewPart<WorksheetPart>();
                newWorksheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet();

                newWorksheetPart.Worksheet.AppendChild(new DocumentFormat.OpenXml.Spreadsheet.SheetData());

                WriteDataTableToExcelWorksheet(dt, newWorksheetPart);
                newWorksheetPart.Worksheet.Save();
                if (worksheetNumber == 1)
                    spreadsheet.WorkbookPart.Workbook.AppendChild(new DocumentFormat.OpenXml.Spreadsheet.Sheets());

                spreadsheet.WorkbookPart.Workbook.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>().AppendChild(new DocumentFormat.OpenXml.Spreadsheet.Sheet()
                {
                    Id = spreadsheet.WorkbookPart.GetIdOfPart(newWorksheetPart),
                    SheetId = (uint)worksheetNumber,
                    Name = dt.TableName
                });

                worksheetNumber++;
            }

            spreadsheet.WorkbookPart.Workbook.Save();
        }


        private static void WriteDataTableToExcelWorksheet(DataTable dt, WorksheetPart worksheetPart)
        {
            var worksheet = worksheetPart.Worksheet;
            var sheetData = worksheet.GetFirstChild<SheetData>();

            string cellValue = "";
            int numberOfColumns = dt.Columns.Count;
            bool[] IsNumericColumn = new bool[numberOfColumns];

            string[] excelColumnNames = new string[numberOfColumns];
            for (int n = 0; n < numberOfColumns; n++)
                excelColumnNames[n] = GetExcelColumnName(n);

            uint rowIndex = 1;

            var headerRow = new Row { RowIndex = rowIndex }; 
            sheetData.Append(headerRow);

            for (int colInx = 0; colInx < numberOfColumns; colInx++)
            {
                DataColumn col = dt.Columns[colInx];
                AppendTextCell(excelColumnNames[colInx] + "1", col.ColumnName, headerRow);
                IsNumericColumn[colInx] = (col.DataType.FullName == "System.Decimal") || (col.DataType.FullName == "System.Int32");
            }

            double cellNumericValue = 0;
            foreach (DataRow dr in dt.Rows)
            {
                ++rowIndex;
                var newExcelRow = new Row { RowIndex = rowIndex };  
                sheetData.Append(newExcelRow);

                for (int colInx = 0; colInx < numberOfColumns; colInx++)
                {
                    cellValue = dr.ItemArray[colInx].ToString();
                    if (IsNumericColumn[colInx])
                    {
                        cellNumericValue = 0;
                        if (double.TryParse(cellValue, out cellNumericValue))
                        {
                            cellValue = cellNumericValue.ToString();
                            AppendNumericCell(excelColumnNames[colInx] + rowIndex.ToString(), cellValue, newExcelRow);
                        }
                    }
                    else
                    {
                        AppendTextCell(excelColumnNames[colInx] + rowIndex.ToString(), cellValue, newExcelRow);
                    }
                }
            }
        }

        private static void AppendTextCell(string cellReference, string cellStringValue, Row excelRow)
        {
            Cell cell = new Cell() { CellReference = cellReference, DataType = CellValues.String };
            CellValue cellValue = new CellValue();
            cellValue.Text = cellStringValue;
            cell.Append(cellValue);
            excelRow.Append(cell);
        }

        private static void AppendNumericCell(string cellReference, string cellStringValue, Row excelRow)
        {
            Cell cell = new Cell() { CellReference = cellReference };
            CellValue cellValue = new CellValue();
            cellValue.Text = cellStringValue;
            cell.Append(cellValue);
            excelRow.Append(cell);
        }

        private static string GetExcelColumnName(int columnIndex)
        {
            if (columnIndex < 26)
                return ((char)('A' + columnIndex)).ToString();

            char firstChar = (char)('A' + (columnIndex / 26) - 1);
            char secondChar = (char)('A' + (columnIndex % 26));

            return string.Format("{0}{1}", firstChar, secondChar);
        }
        #endregion

        #region Export to CSV
        public static bool ExportToCsv(DataTable dt, string path)
        {
            try
            {
                StreamWriter writer = new StreamWriter(path, false);
                for(int col = 0; col< dt.Columns.Count; col++)
                {
                    writer.Write(dt.Columns[col].ToString());
                    if (col < dt.Columns.Count - 1)
                        writer.Write(",");
                }
                writer.Write(writer.NewLine);
                foreach(DataRow dr in dt.Rows)
                {
                    for(int col = 0; col < dt.Columns.Count; col++)
                    {
                        string value = dr[col].ToString().Length > 0 ? dr[col].ToString() : "";
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            writer.Write(value);
                        }
                        else
                        {
                            writer.Write(value);
                        }
                        if (col < dt.Columns.Count - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.Write(writer.NewLine);
                }
                writer.Close();
                MessageBox.Show("Process has been successfully completed.", "Export to Csv", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured.\n" + ex.Message, "Export to Csv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion
    }
}
