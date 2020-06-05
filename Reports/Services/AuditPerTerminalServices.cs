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
    public class AuditPerTerminalServices
    {
        public const string AuditPerTerminal = "[dbo].[spAuditPerTerminal]";
        public const string AuditPerTerminalTicketAccountability = "[dbo].[spAuditPerTerminalTicketAccountability]";
        public const string AuditPerTerminalProcessedTickets = "[dbo].[spAuditPerTerminalProcessedTickets]";

        public async Task<DataTable> AuditPerTerminalDataTableAsync(DateTime date)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = AuditPerTerminal;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<DataTable> AuditPerTerminalTicketAccountabilityDataTableAsync(DateTime date)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = AuditPerTerminalTicketAccountability;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<DataTable> AuditPerTerminalProcessedTicketsDataTableAsync(DateTime date)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = AuditPerTerminalProcessedTickets;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }

        public async Task<IEnumerable<AuditPerTerminalModel>> AuditPerTerminalAsync(DateTime date)
        {
            var items = new List<AuditPerTerminalModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = AuditPerTerminal;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new AuditPerTerminalModel
                    {
                        RunDate = dr["RunDate"].ToString(),
                        RunTime = dr["RunTime"].ToString(),
                        Date = dr["Date"].ToString(),
                        Description = dr["Description"].ToString(),
                        Id = dr["Id"].ToString(),
                        Location = dr["Location"].ToString(),
                        Terminal_1 = dr["Terminal_1"].ToString(),
                        Terminal_2 = dr["Terminal_2"].ToString(),
                        Terminal_3 = dr["Terminal_3"].ToString(),
                        Total = dr["Total"].ToString(),
                    };
                    items.Add(item);
                }
            }
            return items;
        }
        public async Task<IEnumerable<AuditPerTerminalTicketAccountabilityModel>> AuditPerTerminalTicketAccountabilityAsync(DateTime date)
        {
            var items = new List<AuditPerTerminalTicketAccountabilityModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = AuditPerTerminalTicketAccountability;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new AuditPerTerminalTicketAccountabilityModel
                    {
                        Id = dr["Id"].ToString(),
                        Description = dr["Description"].ToString(),
                        Terminal_1 = dr["Terminal_1"].ToString(),
                        Terminal_2 = dr["Terminal_2"].ToString(),
                        Terminal_3 = dr["Terminal_3"].ToString(),
                        Total = dr["Total"].ToString(),
                    };
                    items.Add(item);
                }
            }
            return items;
        }
        public async Task<IEnumerable<AuditPerTerminalProcessedTicketsModel>> AuditPerTerminalProcessedTicketsAsync(DateTime date)
        {
            var items = new List<AuditPerTerminalProcessedTicketsModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = AuditPerTerminalProcessedTickets;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new AuditPerTerminalProcessedTicketsModel
                    {
                        Id = dr["Id"].ToString(),
                        Description = dr["Description"].ToString(),
                        Terminal_1 = dr["Terminal_1"].ToString(),
                        Terminal_2 = dr["Terminal_2"].ToString(),
                        Terminal_3 = dr["Terminal_3"].ToString(),
                        Total = dr["Total"].ToString(),
                    };
                    items.Add(item);
                }
            }
            return items;
        }

    }
}
