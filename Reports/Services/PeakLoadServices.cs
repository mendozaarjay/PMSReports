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
    public class PeakLoadServices
    {
        private const string StoredProcedure = "[dbo].[spPeakLoadReport]";
        public async Task<DataTable> PeakLoadReportDataTableAsync(DateTime date)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<IEnumerable<PeakLoadModel>> PeakLoadReportAsync(DateTime date)
        {
            var items = new List<PeakLoadModel>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new PeakLoadModel
                    {
                        Row = int.Parse(dr["Row"].ToString()),
                        Time = dr["Time"].ToString(),
                        GrossIn = decimal.Parse(dr["GrossIn"].ToString()),
                        Cancel = decimal.Parse(dr["Cancel"].ToString()),
                        NetIn = decimal.Parse(dr["NetIn"].ToString()),
                        InPercentage = decimal.Parse(dr["InPercentage"].ToString()),
                        NetOut = decimal.Parse(dr["NetOut"].ToString()),
                        OutPercentage = decimal.Parse(dr["OutPercentage"].ToString()),
                        Amount = decimal.Parse(dr["Amount"].ToString()),
                    };
                    items.Add(item);
                }
            }

            return items;
        }
    }
}
