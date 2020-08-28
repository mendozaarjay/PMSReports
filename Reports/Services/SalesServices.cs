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
        
        public async Task<DataTable> SalesReportDataTableAsync(DateTime datefrom, DateTime dateto, string keyword)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", datefrom);
            cmd.Parameters.AddWithValue("@DateTo", dateto);
            cmd.Parameters.AddWithValue("@SearchKey", keyword);
            cmd.Parameters.AddWithValue("@IncludeAll", 0);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<IEnumerable<SalesModel>> SalesReportAsync(DateTime datefrom, DateTime dateto, string keyword)
        {
            List<SalesModel> items = new List<SalesModel>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", datefrom);
            cmd.Parameters.AddWithValue("@DateTo", dateto);
            cmd.Parameters.AddWithValue("@SearchKey", keyword);
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
                        GrossAmount = decimal.Parse(dr["GrossAmount"].ToString()),
                        Discount = decimal.Parse(dr["Discount"].ToString()),
                        AmountDue = decimal.Parse(dr["AmountDue"].ToString()),
                        AmountTendered = decimal.Parse(dr["AmountTendered"].ToString()),
                        Change = decimal.Parse(dr["Change"].ToString()),
                        Vatable = decimal.Parse(dr["Vatable"].ToString()),
                        Vat = decimal.Parse(dr["Vat"].ToString()),
                        VatExempt = decimal.Parse(dr["VatExempt"].ToString()),
                        ZeroRated = decimal.Parse(dr["ZeroRated"].ToString()),
                        Reprint = int.Parse(dr["Reprint"].ToString()),
                        Description = string.Empty,
                        UpdateUser = dr["UpdateUser"].ToString(),
                        Username = dr["Username"].ToString(),
                        IsErased = dr["IsErased"].ToString().Equals("1") ? true : false,
                    };

                    items.Add(item);
                }
            }

            return items;
        }
    }
}
