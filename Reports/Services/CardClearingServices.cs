using Reports.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Reports.Services
{
    public class CardClearingServices
    {
        private const string StoredProcedure = "[dbo].[spCardClearing]";
        public async Task<DataTable> CardClearingDataTableAsync(DateTime from, DateTime to, string terminal)
        {
            var cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<IEnumerable<CardClearingModel>> CardClearingAsync(DateTime from, DateTime to, string terminal)
        {
            var items = new List<CardClearingModel>();
            var cmd = new SqlCommand();
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
                    var item = new CardClearingModel
                    {
                        Id = dr["Id"].ToString(),
                        Row = dr["Row"].ToString(),
                        EntranceGate = dr["EntranceGate"].ToString(),
                        PlateNo = dr["PlateNo"].ToString(),
                        TicketNo = dr["TicketNo"].ToString(),
                        DateTimein = dr["DateTimein"].ToString(),
                        Comment = dr["Comment"].ToString(),
                        ClearedUser = dr["ClearedUser"].ToString(),
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
            var items = DatabaseHelper.LoadDataTable(sql, Properties.Settings.Default.UserConnectionString);
            return items;
        }
    }
}
