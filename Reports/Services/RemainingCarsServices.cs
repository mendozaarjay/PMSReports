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
    public class RemainingCarsServices
    {
        private const string StoredProcedure = "[dbo].[spRemainingCars]";
        public async Task<DataTable> RemainingCarsDataTableAsync(DateTime date)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<IEnumerable<RemainingCarModel>> RemainingCarsAsync(DateTime date)
        {
            List<RemainingCarModel> items = new List<RemainingCarModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new RemainingCarModel
                    {
                        No = dr["No"].ToString(),
                        ParkerType = dr["ParkerType"].ToString(),
                        PlateNo = dr["PlateNo"].ToString(),
                        RFIDName = dr["RFIDName"].ToString(),
                        RFIDNumber = dr["RFIDNumber"].ToString(),
                        TicketNumber = dr["TicketNumber"].ToString(),
                        TimeIn = dr["TimeIn"].ToString(),
                    };
                    items.Add(item);
                }
            }
            return items;
        }
    }
}
