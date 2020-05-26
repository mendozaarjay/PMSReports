using Reports.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Reports.Services
{
    public class LengthOfStayServices
    {
        private const string StoredProcedure = "[dbo].[spLengthOfStayReport]";
        public async Task<DataTable> LengthOfStayDataTableAsync(DateTime date)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<IEnumerable<LengthOfStayModel>> LengthOfStayAsync(DateTime date)
        {
            List<LengthOfStayModel> items = new List<LengthOfStayModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new LengthOfStayModel
                    {
                        RowNum = dr["RowNum"].ToString(),
                        DurationHour = dr["DurationHour"].ToString(),
                        NumberOfVehicles = int.Parse(dr["NumberOfVehicles"].ToString()),
                        Amount = decimal.Parse(dr["Amount"].ToString()),
                    };
                    items.Add(item);
                }
            }
            return items;
        }
    }
}
