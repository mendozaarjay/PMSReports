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
    public class CashierAccountabilityServices
    {
        private const string StoredProcedure = "[dbo].[spCashierAccountabilityReport]";
        
        public async Task<DataTable> CashierAccountabilityDataTableAsync(DateTime from, DateTime to,int terminal)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<IEnumerable<CashierAccountabilityModel>> CashierAccountabilityAsync(DateTime from,DateTime to, int terminal)
        {
            var items = new List<CashierAccountabilityModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new CashierAccountabilityModel
                    {
                        Row = dr["Row"].ToString(),
                        RunDate = dr["RunDate"].ToString(),
                        RunTime = dr["RunTime"].ToString(),
                        Location = dr["Location"].ToString(),
                        Terminal = dr["Terminal"].ToString(),
                        TotalAmount = decimal.Parse(dr["TotalAmount"].ToString()),
                        TotalChange = decimal.Parse(dr["TotalChange"].ToString()),
                        CarParkIncome = dr["CarParkIncome"].ToString(),
                        ReceiptsOut = int.Parse(dr["ReceiptsOut"].ToString()),
                        Amount = decimal.Parse(dr["Amount"].ToString()),
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
