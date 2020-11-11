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
        public async Task<DataTable> ShiftReportDataTableAsync(DateTime from, DateTime to, string keyword,string terminal)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Keyword", keyword);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<IEnumerable<ShiftModel>> ShiftReportAsync(DateTime from, DateTime to, string keyword,string terminal)
        {
            var items = new List<ShiftModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Keyword", keyword);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
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
                        GrossAmount = dr["GrossAmount"].ToString().Length > 0 ? decimal.Parse(dr["GrossAmount"].ToString()) : 0,
                        Vatable = dr["Vatable"].ToString().Length > 0 ? decimal.Parse(dr["Vatable"].ToString()) : 0,
                        Vat = dr["Vat"].ToString().Length > 0 ? decimal.Parse(dr["Vat"].ToString()) : 0,
                        Discount = dr["Discount"].ToString().Length > 0 ? decimal.Parse(dr["Discount"].ToString()) : 0,
                        AmountTendered = dr["AmountTendered"].ToString().Length > 0 ? decimal.Parse(dr["AmountTendered"].ToString()) : 0,
                        Change = dr["Change"].ToString().Length > 0 ? decimal.Parse(dr["Change"].ToString()) : 0,
                        ChangeFund = dr["ChangeFund"].ToString().Length > 0 ? decimal.Parse(dr["ChangeFund"].ToString()) : 0,
                        TenderDeclaration = dr["TenderDeclaration"].ToString().Length > 0 ? decimal.Parse(dr["TenderDeclaration"].ToString()) : 0,
                        SubTotal = dr["SubTotal"].ToString().Length > 0 ? decimal.Parse(dr["SubTotal"].ToString()) : 0,
                        Variance = dr["Variance"].ToString().Length > 0 ? decimal.Parse(dr["Variance"].ToString()) : 0,
                        Cashier = dr["Cashier"].ToString(),
                        Exit = dr["Exit"].ToString(),
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
            var items = SCObjects.LoadDataTable(sql, Properties.Settings.Default.UserConnectionString);
            return items;
        }
    }
}
