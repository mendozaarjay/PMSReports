using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports
{
    public static class DataGridExtension
    {
        public static DataTable ToDataTable(this DataGridView dataGrid)
        {
            DataTable dt = new DataTable();
            if (dataGrid.Columns.Count <= 0)
                return null;

            foreach (DataGridViewColumn column in dataGrid.Columns)
                dt.Columns.Add(column.HeaderText);

            for(int row = 0; row < dataGrid.Rows.Count;row++)
            {
                dt.Rows.Add();
                for(int col = 0; col < dataGrid.Columns.Count;col++)
                {
                    dt.Rows[row][col] = dataGrid[col, row].Value;
                }
                dt.AcceptChanges();
            }

            return dt;
        }
        public static void FindValue(this DataGridView dataGrid,string value)
        {
            dataGrid.ClearSelection();
            for(int col = 0; col < dataGrid.Columns.Count; col++)
            {
                for(int row = 0; row < dataGrid.Rows.Count;row++)
                {
                    if(dataGrid[col, row].Value != null)
                    {
                        var currentvalue = dataGrid[col, row].Value.ToString().ToLower();
                        if (currentvalue.Contains(value))
                        {
                            dataGrid.Rows[row].Cells[col].Selected = true;
                            return;
                        }
                    }
                }
            }
        }
    }
}
