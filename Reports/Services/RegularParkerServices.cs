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
    public class RegularParkerServices
    {
        private const string StoredProcedure = "[dbo].[spRegularParkerReport]";
        public async Task<IEnumerable<RegularParkerModel>> GetRegularParkersAsync()
        {
            var items = new List<RegularParkerModel>();
            var cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new RegularParkerModel
                    {
                        Id = dr["Id"].ToString(),
                        RFID = dr["RFID"].ToString(),
                        Parker = dr["Parker"].ToString(),
                        Company = dr["Company"].ToString(),
                        DateIssued = dr["DateIssued"].ToString(),
                        ValidFrom = dr["ValidFrom"].ToString(),
                        ValidTo = dr["ValidTo"].ToString(),
                        Status = dr["Status"].ToString(),
                    };
                    items.Add(item);
                }
            }

            return items;
        }
        public DataTable GetRegularParkerDataTable()
        {
            var cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            var result = SCObjects.ExecGetData(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
    }
}
