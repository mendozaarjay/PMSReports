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
    public class ShiftServices
    {
        private const string StoredProcedure = "[dbo].[spShiftReport]";
        public async Task<DataTable> ShiftReportDataTableAsync(DateTime from, DateTime to, string keyword)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Keyword", keyword);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<IEnumerable<ShiftModel>> ShiftReportAsync(DateTime from, DateTime to, string keyword)
        {
            var items = new List<ShiftModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Keyword", keyword);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new ShiftModel
                    {
                        SRNumber = dr["SRNumber"].ToString(),
                        Type = dr["Type"].ToString(),
                        DateTimeIn = dr["DateTimeIn"].ToString(),
                        DateTimeOut = dr["DateTimeOut"].ToString(),
                        ExitCount = int.Parse(dr["ExitCount"].ToString()),
                        GrossAmount = decimal.Parse(dr["GrossAmount"].ToString()),
                        Vatable = decimal.Parse(dr["Vatable"].ToString()),
                        Vat = decimal.Parse(dr["Vat"].ToString()),
                        Discount = decimal.Parse(dr["Discount"].ToString()),
                        AmountTendered = decimal.Parse(dr["AmountTendered"].ToString()),
                        Change = decimal.Parse(dr["Change"].ToString()),
                        ChangeFund = decimal.Parse(dr["ChangeFund"].ToString()),
                        TenderDeclaration = decimal.Parse(dr["TenderDeclaration"].ToString()),
                        SubTotal = decimal.Parse(dr["SubTotal"].ToString()),
                        Variance = decimal.Parse(dr["Variance"].ToString()),
                        Cashier = dr["Cashier"].ToString(),
                        Username = dr["Username"].ToString(),
                    };
                    items.Add(item);
                }
            }
            return items;
        }
    }
}
