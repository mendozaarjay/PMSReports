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
    public class SalesServices
    {
        private const string StoredProcedure = "[dbo].[spSalesReport]";
        
        public async Task<DataTable> SalesReportDataTableAsync(DateTime datefrom, DateTime dateto, string keyword,string terminal)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", datefrom);
            cmd.Parameters.AddWithValue("@DateTo", dateto);
            cmd.Parameters.AddWithValue("@SearchKey", keyword);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            cmd.Parameters.AddWithValue("@IncludeAll", 0);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<IEnumerable<SalesModel>> SalesReportAsync(DateTime datefrom, DateTime dateto, string keyword,string terminal)
        {
            List<SalesModel> items = new List<SalesModel>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", datefrom);
            cmd.Parameters.AddWithValue("@DateTo", dateto);
            cmd.Parameters.AddWithValue("@SearchKey", keyword);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new SalesModel
                    {
                        TransitId = int.Parse(dr["TransitId"].ToString()),
                        ORNo = dr["ORNumber"].ToString(),
                        Type = dr["Type"].ToString(),
                        PlateNo = dr["PlateNo"].ToString(),
                        TicketNo = dr["TicketNumber"].ToString(),
                        TimeIn = dr["TimeIn"].ToString(),
                        TimeOut = dr["TimeOut"].ToString(),
                        Duration = dr["Duration"].ToString(),
                        RateName = dr["RateName"].ToString(),
                        Coupon = dr["Coupon"].ToString(),
                        GrossAmount = dr["GrossAmount"].ToString().Length > 0 ? decimal.Parse(dr["GrossAmount"].ToString()) : 0,
                        Discount = dr["Discount"].ToString().Length > 0 ? decimal.Parse(dr["Discount"].ToString()) : 0,
                        AmountDue = dr["AmountDue"].ToString().Length > 0 ? decimal.Parse(dr["AmountDue"].ToString()) : 0,
                        AmountTendered = dr["AmountTendered"].ToString().Length > 0 ? decimal.Parse(dr["AmountTendered"].ToString()) : 0,
                        Change = dr["Change"].ToString().Length > 0 ? decimal.Parse(dr["Change"].ToString()) : 0,
                        Vatable = dr["Vatable"].ToString().Length > 0 ? decimal.Parse(dr["Vatable"].ToString()) : 0,
                        Vat = dr["Vat"].ToString().Length > 0 ? decimal.Parse(dr["Vat"].ToString()) : 0,
                        VatExempt = dr["VatExempt"].ToString().Length > 0 ? decimal.Parse(dr["VatExempt"].ToString()) : 0,
                        ZeroRated = dr["ZeroRated"].ToString().Length > 0 ? decimal.Parse(dr["ZeroRated"].ToString()) : 0,
                        Reprint = int.Parse(dr["Reprint"].ToString()),
                        Description = string.Empty,
                        UpdateUser = dr["UpdateUser"].ToString(),
                        Username = dr["Username"].ToString(),
                        Entrance = dr["Entrance"].ToString(),
                        Exit = dr["Exit"].ToString(),
                        IsErased = dr["IsErased"].ToString().Equals("1") ? true : false,
                    };

                    items.Add(item);
                }
            }

            return items;
        }
        public DataTable Terminals()
        {
            var sql = @"SELECT [fgag].[Id],
                               [fgag].[Name]
                        FROM [dbo].[fnGetAllGates]() [fgag]";
            var items = DatabaseHelper.LoadDataTable(sql, Properties.Settings.Default.UserConnectionString);
            return items;
        }
    }
}
