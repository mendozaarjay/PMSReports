using Reports.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Reports.Services
{
    public class OperationOccupancyServices
    {
        private const string StoredProcedure = "[dbo].[spOperationOccupancyReport]";
        
        public async Task<DataTable> OperationOccupancyReportDataTableAsync(DateTime date)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<IEnumerable<OperationOccupancyModel>> OperationOccupancyReportAsync(DateTime date)
        {
            var items = new List<OperationOccupancyModel>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new OperationOccupancyModel
                    {
                        RowNum = int.Parse(dr["RowNum"].ToString()),
                        Time = dr["Time"].ToString(),
                        In = int.Parse(dr["In"].ToString()),
                        Out = int.Parse(dr["Out"].ToString()),
                        Remaining = int.Parse(dr["Remaining"].ToString()),
                    };
                    items.Add(item);
                }
            }
            return items;
        }
    }
}
