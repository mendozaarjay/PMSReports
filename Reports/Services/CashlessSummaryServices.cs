using Reports.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Services
{
    public class CashlessSummaryServices
    {
        private static string StoredProcedure = "[dbo].[spCashlessSummary]";
        public async Task<DataTable> CashlessSummaryDataTableAsync(DateTime from, DateTime to, string terminal)
        {
            var cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<IEnumerable<CashlessSummaryModel>> CashlessSummaryAsync(DateTime from, DateTime to, string terminal)
        {
            var items = new List<CashlessSummaryModel>();
            var cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if (result == null)
                return null;

            foreach(DataRow dr in result.Rows)
            {
                var item = new CashlessSummaryModel
                {
                    Id = int.Parse(dr["Id"].ToString()),
                    Description = dr["Description"].ToString(),
                    Value = dr["Value"].ToString(),
                };
                items.Add(item);
            }

            return items;
        }
    }
}
