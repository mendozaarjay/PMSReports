using Reports.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Reports.Services
{
    public class OperationHourlyAccountabilityServices
    {
        private const string StoredProcedure = "[dbo].[spOperationHourlyAccountabilityReport]";
        public async Task<DataTable> OperationHourlyAccountabilityDataTableAsync(DateTime from,DateTime to, string terminal)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<IEnumerable<OperationHourlyAccountabilityModel>> OperationHourlyAccountabilityAsync(DateTime from, DateTime to, string terminal)
        {
            var items = new List<OperationHourlyAccountabilityModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new OperationHourlyAccountabilityModel
                    {
                        RowNum = int.Parse(dr["RowNum"].ToString()),
                        DurationHours = dr["DurationHours"].ToString(),
                        NumberOfVehicles = int.Parse(dr["NumberOfVehicles"].ToString()),
                        Amount = decimal.Parse(dr["Amount"].ToString()),
                    };
                    items.Add(item);
                }
            }
            return items;
        }
        public DataTable Gates()
        {
            var gates = DatabaseHelper.LoadDataTable("SELECT * FROM  [dbo].[fnGetAllGates]() [fgag]", Properties.Settings.Default.UserConnectionString);
            return gates;
        }
    }
}
