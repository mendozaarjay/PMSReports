using Reports.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Reports.Services
{
    public class CardEncodingServices
    {
        public async Task<IEnumerable<CardEncodingModel>> CardEncodingAsync(DateTime date,string keyword,string terminal)
        {
            var items = new List<CardEncodingModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "[dbo].[spCardEncoding]";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@Keyword", keyword);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);

            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new CardEncodingModel
                    {
                        Id = dr["Id"].ToString(),
                        EntranceGate = dr["EntranceGate"].ToString(),
                        No = dr["No"].ToString(),
                        PlateNo = dr["PlateNo"].ToString(),
                        TimeIn = dr["TimeIn"].ToString(),
                        TicketNumber = dr["TicketNumber"].ToString(),
                        EntranceImage = dr["EntranceImage"].ToString().Length > 0 ? (byte[])dr["EntranceImage"] : null ,
                    };
                    items.Add(item);
                }
            }
            return items;
        }
        public async Task<string> UpdatePlateNo(string id, string plateno)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "[dbo].[spUpdatePlateNo]";
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@PlateNo", plateno);
            var result = await SCObjects.ExecNonQueryAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
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
