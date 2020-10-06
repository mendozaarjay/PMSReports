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
        public async Task<DataTable> AuditPerCashierDataTableAsync(DateTime from,DateTime to,string cashier, string terminal)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Cashier", cashier);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<DataTable> ProcessedTicketsDataTableAsync(DateTime from, DateTime to, string cashier,string terminal)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = ProcessedTicket;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Cashier", cashier);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<DataTable> TicketAccountabilityDataTableAsync(DateTime from, DateTime to, string cashier, string terminal)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = TicketAccountability;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Cashier", cashier);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public DataTable Gates()
        {
            var gates = DatabaseHelper.LoadDataTable("SELECT [g].[GateID] AS [Id],[g].[GateName] AS [Name] FROM  [dbo].[Gates] [g] WHERE ISNULL([g].[IsDeleted],0) = 0 ", Properties.Settings.Default.UserConnectionString);
            return gates;
        }

        public async Task<IEnumerable<AuditPerCashierModel>> AuditPerCashierAsync(DateTime from, DateTime to, string cashier, string terminal)
        {
            var items = new List<AuditPerCashierModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Cashier", cashier);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new AuditPerCashierModel
                    {
                        Id = dr["Id"].ToString(),
                        Description = dr["Description"].ToString(),
                        Value = dr["Value"].ToString(),
                    };
                    items.Add(item);
                }
            }
            return items;
        }
        public async Task<IEnumerable<AuditPerCashierProcessedTicketModel>> ProcessedTicketsAsync(DateTime from, DateTime to, string cashier, string terminal)
        {
            var items = new List<AuditPerCashierProcessedTicketModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = ProcessedTicket;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Cashier", cashier);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow  dr in result.Rows)
                {
                    var item = new AuditPerCashierProcessedTicketModel
                    {
                        Id = dr["Id"].ToString(),
                        Description = dr["Description"].ToString(),
                        Value = dr["Value"].ToString(),
                    };
                    items.Add(item);
                }
            }
            return items;
        }
        public async Task<IEnumerable<AuditPerCashierTicketAccountabilityModel>> TicketAccountabilityAsync(DateTime from, DateTime to, string cashier, string terminal)
        {
            var items = new List<AuditPerCashierTicketAccountabilityModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = TicketAccountability;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@Cashier", cashier);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new AuditPerCashierTicketAccountabilityModel
                    {
                        Id = dr["Id"].ToString(),
                        Description = dr["Description"].ToString(),
                        Value = dr["Value"].ToString(),
                    };
                    items.Add(item);
                }
            }
            return items;
        }
        public DataTable CashiersPerTerminal(DateTime from,DateTime to, string terminal)
        {
            var sql = string.Format(@"EXEC [dbo].[spGetCashierPerTerminal] @DateFrom = '{0}', 
                                     @DateTo = '{1}',   
                                     @Terminal ={2}", from, to, terminal);
            var items = DatabaseHelper.LoadDataTable(sql, Properties.Settings.Default.UserConnectionString);
            return items;
        }
    }
}
