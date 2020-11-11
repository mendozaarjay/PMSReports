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
        public async Task<DataTable> BIRReportDataTableAsync(DateTime dateFrom, DateTime dateTo,string terminal)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", dateFrom);
            cmd.Parameters.AddWithValue("@DateTo", dateTo);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<IEnumerable<BIRModel>> BIRReportAsync(DateTime dateFrom, DateTime dateTo,string terminal)
        {
            List<BIRModel> items = new List<BIRModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", dateFrom);
            cmd.Parameters.AddWithValue("@DateTo", dateTo);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);

            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new BIRModel
                    {
                        Date = dr["Date"].ToString(),
                        BeginningOR = dr["BeginningOR"].ToString(),
                        EndingOR = dr["EndingOR"].ToString(),
                        BeginningSales = dr["BeginningSales"].ToString(),
                        EndingSales = dr["EndingSales"].ToString(),
                        TotalSales = dr["TotalSales"].ToString(),
                        DiscountSC = dr["DiscountSC"].ToString(),
                        DiscountPWD = dr["DiscountPWD"].ToString(),
                        DiscountOthers = dr["DiscountOthers"].ToString(),
                        GrossAmount = dr["GrossAmount"].ToString(),
                        Vatable = dr["Vatable"].ToString(),
                        Vat = dr["Vat"].ToString(),
                        VatExempt = dr["VatExempt"].ToString(),
                        ZeroRated = dr["ZeroRated"].ToString(),
                        ResetCount = dr["ResetCount"].ToString(),
                        ZCounter = dr["ZCounter"].ToString(),
                        Remarks = dr["Remarks"].ToString(),
                    };
                    items.Add(item);
                }
            }

            return items;
        }
        public DataTable Gates()
        {
            var gates = SCObjects.LoadDataTable("SELECT [g].[GateID] AS [Id],[g].[GateName] AS [Name] FROM  [dbo].[Gates] [g] WHERE ISNULL([g].[IsDeleted],0) = 0 ", Properties.Settings.Default.UserConnectionString);
            return gates;
        }
    }
}
