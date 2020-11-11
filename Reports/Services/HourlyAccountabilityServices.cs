using Reports.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Reports.Services
{
    public class HourlyAccountabilityServices
    {
        private const string StoredProcedure = "[dbo].[spHourlyAccountabilityReport]";
        public async Task<DataTable> HourlyAccountabilityReportDatatableAsync(DateTime from, DateTime to, string terminal)
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
        public async Task<IEnumerable<HourlyAccountabilityModel>> HourlyAccountabilityReportAsync(DateTime from, DateTime to, string terminal)
        {
            var items = new List<HourlyAccountabilityModel>();

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
                    var item = new HourlyAccountabilityModel
                    {
                        TimeString = dr["TimeString"].ToString(),
                        TotalCard = int.Parse(dr["TotalCard"].ToString()),
                        TotalAmount = decimal.Parse(dr["TotalAmount"].ToString()),
                    };
                    items.Add(item);
                }
            }
            return items;
        }
        public DataTable Gates()
        {
            var gates = SCObjects.LoadDataTable("SELECT * FROM  [dbo].[fnGetAllGates]() [fgag]", Properties.Settings.Default.UserConnectionString);
            return gates;
        }
    }
}
