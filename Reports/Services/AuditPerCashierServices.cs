using Reports.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Reports.Services
{
    public class AuditPerCashierServices
    {
        private const string StoredProcedure = "[dbo].[spAuditPerCashier]";
        private const string ProcessedTicket = "[dbo].[spAuditPerCashierProcessedTickets]";
        private const string TicketAccountability = "[dbo].[spAuditPerCashierTicketAccountability]";
        public async Task<DataTable> AuditPerCashierDataTableAsync(DateTime date, string terminal)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@TerminalId", terminal);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<DataTable> ProcessedTicketsDataTableAsync(DateTime date)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = ProcessedTicket;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<DataTable> TicketAccountabilityDataTableAsync(DateTime date)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = TicketAccountability;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public DataTable Gates()
        {
            var gates = DatabaseHelper.LoadDataTable("SELECT [g].[GateID] AS [Id],[g].[GateName] AS [Name] FROM  [dbo].[Gates] [g] WHERE ISNULL([g].[IsDeleted],0) = 0 ", Properties.Settings.Default.UserConnectionString);
            return gates;
        }

        public async Task<IEnumerable<AuditPerCashierModel>> AuditPerCashierAsync(DateTime date, string terminal)
        {
            var items = new List<AuditPerCashierModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@TerminalId", terminal);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new AuditPerCashierModel
                    {
                        Id = dr["Id"].ToString(),
                        RunDate = dr["RunDate"].ToString(),
                        RunTime = dr["RunTime"].ToString(),
                        Date = dr["Date"].ToString(),
                        Location = dr["Location"].ToString(),
                        Terminal = dr["Terminal"].ToString(),
                        Description = dr["Description"].ToString(),
                        Cashier_1 = dr["Cashier_1"].ToString(),
                        Cashier_2 = dr["Cashier_2"].ToString(),
                        Cashier_3 = dr["Cashier_3"].ToString(),
                        Cashier_4 = dr["Cashier_4"].ToString(),
                        Cashier_5 = dr["Cashier_5"].ToString(),
                        Cashier_6 = dr["Cashier_6"].ToString(),
                        Total = dr["Total"].ToString(),
                    };
                    items.Add(item);
                }
            }
            return items;
        }
        public async Task<IEnumerable<AuditPerCashierProcessedTicketModel>> ProcessedTicketsAsync(DateTime date)
        {
            var items = new List<AuditPerCashierProcessedTicketModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = ProcessedTicket;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow  dr in result.Rows)
                {
                    var item = new AuditPerCashierProcessedTicketModel
                    {
                        Id = dr["Id"].ToString(),
                        Description = dr["Description"].ToString(),
                        Cashier_1 = dr["Cashier_1"].ToString(),
                        Cashier_2 = dr["Cashier_2"].ToString(),
                        Cashier_3 = dr["Cashier_3"].ToString(),
                        Cashier_4 = dr["Cashier_4"].ToString(),
                        Cashier_5 = dr["Cashier_5"].ToString(),
                        Cashier_6 = dr["Cashier_6"].ToString(),
                        Total = dr["Total"].ToString(),
                    };
                    items.Add(item);
                }
            }
            return items;
        }
        public async Task<IEnumerable<AuditPerCashierTicketAccountabilityModel>> TicketAccountabilityAsync(DateTime date)
        {
            var items = new List<AuditPerCashierTicketAccountabilityModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = TicketAccountability;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new AuditPerCashierTicketAccountabilityModel
                    {
                        Id = dr["Id"].ToString(),
                        Description = dr["Description"].ToString(),
                        Cashier_1 = dr["Cashier_1"].ToString(),
                        Cashier_2 = dr["Cashier_2"].ToString(),
                        Cashier_3 = dr["Cashier_3"].ToString(),
                        Cashier_4 = dr["Cashier_4"].ToString(),
                        Cashier_5 = dr["Cashier_5"].ToString(),
                        Cashier_6 = dr["Cashier_6"].ToString(),
                        Total = dr["Total"].ToString(),
                    };
                    items.Add(item);
                }
            }
            return items;
        }
    }
}
