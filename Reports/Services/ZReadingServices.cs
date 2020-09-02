using Reports.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Reports.Services
{
    public class ZReadingServices
    {
        private const string StoredProcedure = "[dbo].[spZReadingReport]";
        public async Task<DataTable> ZReadingDataTableAsync(DateTime dateFrom, DateTime dateTo,string terminal)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", dateFrom);
            cmd.Parameters.AddWithValue("@DateTo", dateTo);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<IEnumerable<ZReadingModel>> ZReadingAsync(DateTime dateFrom, DateTime dateTo,string terminal)
        {
            var items = new List<ZReadingModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", dateFrom);
            cmd.Parameters.AddWithValue("@DateTo", dateTo);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new ZReadingModel
                    {
                        Id = dr["Id"].ToString(),
                        Date = dr["Date"].ToString(),
                        Time = dr["Time"].ToString(),
                        NewORNo = dr["NewORNo"].ToString(),
                        OldORNo = dr["OldORNo"].ToString(),
                        OldFRNo = dr["OldFRNo"].ToString(),
                        NewFRNo = dr["NewFRNo"].ToString(),
                        TodaySales = dr["TodaySales"].ToString().Length == 0 ? 0 : decimal.Parse(dr["TodaySales"].ToString()),
                        OldSales = dr["OldSales"].ToString().Length == 0 ? 0 : decimal.Parse(dr["OldSales"].ToString()),
                        NewSales = dr["NewSales"].ToString().Length == 0 ? 0 : decimal.Parse(dr["NewSales"].ToString()),
                    };
                    items.Add(item);
                }
            }
            return items;
        }
        public DataTable Gates()
        {
            var gates = DatabaseHelper.LoadDataTable("SELECT [g].[GateID] AS [Id],[g].[GateName] AS [Name] FROM  [dbo].[Gates] [g] WHERE ISNULL([g].[IsDeleted],0) = 0 ", Properties.Settings.Default.UserConnectionString);
            return gates;
        }
    }
}
