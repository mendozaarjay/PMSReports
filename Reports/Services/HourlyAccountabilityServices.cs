using Reports.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Reports.Services
{
    public class HourlyAccountabilityServices
    {
        private const string StoredProcedure = "[dbo].[spHourlyAccountabilityReport]";
        public async Task<DataTable> HourlyAccountabilityReportDatatableAsync(DateTime date)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<IEnumerable<HourlyAccountabilityModel>> HourlyAccountabilityReportAsync(DateTime date)
        {
            var items = new List<HourlyAccountabilityModel>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new HourlyAccountabilityModel
                    {
                        TimeString = dr["TimeString"].ToString(),
                        TotalCard = int.Parse(dr["TotalCard"].ToString()),
                        CardCounter = int.Parse(dr["CardCounter"].ToString()),
                        TotalAmount = decimal.Parse(dr["TotalAmount"].ToString()),
                        AmountCounter = decimal.Parse(dr["AmountCounter"].ToString()),
                    };
                    items.Add(item);
                }
            }
            return items;
        }
    }
}
