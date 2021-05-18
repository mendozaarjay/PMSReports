using Reports.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Reports.Services
{
    public class AuditTrailServices
    {
        private const string StoredProcedure = "[dbo].[spAuditTrailReport]";
        public async Task<IEnumerable<AuditTrailModel>> GetAuditTrailAsync(DateTime from, DateTime to, string terminal, string keyword)
        {
            var cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Keyword", keyword);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            var items = new List<AuditTrailModel>();
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new AuditTrailModel
                    {
                        Id = dr["Id"].ToString(),
                        Date = dr["Date"].ToString(),
                        Description = dr["Description"].ToString(),
                        Gate = dr["Gate"].ToString(),
                        Username = dr["Username"].ToString(),
                    };
                    items.Add(item);
                }
            }

            return items;
        }
        public DataTable AuditTrailDataTable(DateTime from, DateTime to, string terminal, string keyword)
        {
            var cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Keyword", keyword);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = SCObjects.ExecGetData(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public DataTable Gates()
        {
            var gates = SCObjects.LoadDataTable("SELECT * FROM  [dbo].[fnGetAllGates]() [fgag]", Properties.Settings.Default.UserConnectionString);
            return gates;
        }
    }
}
