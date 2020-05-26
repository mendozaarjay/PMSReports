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
    public class BIRServices
    {
        private const string StoredProcedure = "[dbo].[spBIRReport]";
        public async Task<DataTable> BIRReportDataTableAsync(DateTime dateFrom, DateTime dateTo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", dateFrom);
            cmd.Parameters.AddWithValue("@DateTo", dateTo);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<IEnumerable<BIRModel>> BIRReportAsync(DateTime dateFrom, DateTime dateTo)
        {
            List<BIRModel> items = new List<BIRModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", dateFrom);
            cmd.Parameters.AddWithValue("@DateTo", dateTo);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);

            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new BIRModel
                    {
                        Date = dr["Date"].ToString(),
                        BeginningOR = dr["BeginningOR"].ToString(),
                        EndingOR = dr["EndingOR"].ToString(),
                        BeginningSales = decimal.Parse(dr["BeginningSales"].ToString()),
                        EndingSales = decimal.Parse(dr["EndingSales"].ToString()),
                        TotalSales = decimal.Parse(dr["TotalSales"].ToString()),
                        DiscountSC = decimal.Parse(dr["DiscountSC"].ToString()),
                        DiscountPWD = decimal.Parse(dr["DiscountPWD"].ToString()),
                        DiscountOthers = decimal.Parse(dr["DiscountOthers"].ToString()),
                        GrossAmount = decimal.Parse(dr["GrossAmount"].ToString()),
                        Vatable = decimal.Parse(dr["Vatable"].ToString()),
                        Vat = decimal.Parse(dr["Vat"].ToString()),
                        VatExempt = decimal.Parse(dr["VatExempt"].ToString()),
                        ZeroRated = decimal.Parse(dr["ZeroRated"].ToString()),
                        ResetCount = dr["ResetCount"].ToString(),
                        ZCounter = dr["ZCounter"].ToString(),
                        Remarks = dr["Remarks"].ToString(),
                    };
                    items.Add(item);
                }
            }

            return items;
        }
    }
}
