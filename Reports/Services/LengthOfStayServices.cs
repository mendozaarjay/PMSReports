using Reports.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Reports.Services
{
    public class LengthOfStayServices
    {
        private const string StoredProcedure = "[dbo].[spLengthOfStayReport]";
        public async Task<DataTable> LengthOfStayDataTableAsync(DateTime from, DateTime to, string terminal)
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
        public async Task<IEnumerable<LengthOfStayModel>> LengthOfStayAsync(DateTime from, DateTime to, string terminal)
        {
            List<LengthOfStayModel> items = new List<LengthOfStayModel>();
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
                    var item = new LengthOfStayModel
                    {
                        RowNum = dr["RowNum"].ToString(),
                        DurationHour = dr["DurationHour"].ToString(),
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
            var gates = DatabaseHelper.LoadDataTable("SELECT [g].[GateID] AS [Id],[g].[GateName] AS [Name] FROM  [dbo].[Gates] [g] WHERE ISNULL([g].[IsDeleted],0) = 0 ", Properties.Settings.Default.UserConnectionString);
            return gates;
        }
    }
}
