using Reports.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Reports.Services
{
    public class DetailedTransactionSummaryServices
    {
        private const string StoredProcedure = "[dbo].[spDetailedTransactionSummaryReport]";
        public async Task<DataTable> DetailedTransactionSummaryDatatableAsync(DateTime dateFrom, DateTime dateTo,string keyword)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", dateFrom);
            cmd.Parameters.AddWithValue("@DateTo", dateTo);
            cmd.Parameters.AddWithValue("@SearchKey", keyword);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }

        public async Task<IEnumerable<DetailedTransactionSummaryModel>> DetailedTransactionSummaryAsync(DateTime dateFrom, DateTime dateTo, string keyword)
        {
            List<DetailedTransactionSummaryModel> items = new List<DetailedTransactionSummaryModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", dateFrom);
            cmd.Parameters.AddWithValue("@DateTo", dateTo);
            cmd.Parameters.AddWithValue("@SearchKey", keyword);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);

            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new DetailedTransactionSummaryModel
                    {
                        TransitId = int.Parse(dr["TransitId"].ToString()),
                        ORNumber = dr["ORNumber"].ToString(),
                        Amount = decimal.Parse(dr["Amount"].ToString()),
                        CardNumber = dr["CardNumber"].ToString(),
                        Cashier = dr["Cashier"].ToString(),
                        Duration = dr["Duration"].ToString(),
                        EntranceDate = dr["EntranceDate"].ToString(),
                        EntranceTime = dr["EntranceTime"].ToString(),
                        ExitDate = dr["ExitDate"].ToString(),
                        ExitTime = dr["ExitTime"].ToString(),
                        Location = dr["Location"].ToString(),
                        PlateNo = dr["PlateNo"].ToString(),
                        RateName = dr["RateName"].ToString(),
                        TimeIn = dr["TimeIn"].ToString(),
                        TimeOut = dr["TimeOut"].ToString(),
                        TotalHours = dr["TotalHours"].ToString(),
                        Username = dr["Username"].ToString(),
                    };
                    items.Add(item);
                }
            }
            return items;
        }
    }
}
