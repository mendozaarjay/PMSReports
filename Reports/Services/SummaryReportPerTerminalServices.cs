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
    public class SummaryReportPerTerminalServices
    {
        private const string SummaryReportPerTerminal = "[dbo].[spSummaryReportPerTerminal]";
        private const string SummaryReportPerTerminalTicketAccountability = "[dbo].[spSummaryReportPerTerminalTickeAccountability]";
        private const string SummaryReportPerTerminalProcessedTickets = "[dbo].[spSummaryReportPerTerminalProcessedTickets]";

        public async Task<DataTable> SummaryReportPerTerminalDataTableAsync(DateTime from,DateTime to, string terminal)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = SummaryReportPerTerminal;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@TerminalId", terminal);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<DataTable> SummaryReportPerTerminalTicketAccountabilityDataTableAsync(DateTime from, DateTime to, string terminal)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = SummaryReportPerTerminalTicketAccountability;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@TerminalId", terminal);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<DataTable> SummaryReportPerTerminalProcessedTicketsDataTableAsync(DateTime from,DateTime to, string terminal)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = SummaryReportPerTerminalProcessedTickets;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@TerminalId", terminal);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public DataTable Gates()
        {
            var gates = SCObjects.LoadDataTable("SELECT [g].[GateID] AS [Id],[g].[GateName] AS [Name] FROM  [dbo].[Gates] [g] WHERE ISNULL([g].[IsDeleted],0) = 0 ", Properties.Settings.Default.UserConnectionString);
            return gates;
        }

        public async Task<IEnumerable<SummaryReportPerTerminalModel>> SummaryReportPerTerminalAsync(DateTime from,DateTime to, string terminal)
        {
            var items = new List<SummaryReportPerTerminalModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = SummaryReportPerTerminal;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@TerminalId", terminal);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new SummaryReportPerTerminalModel
                    {
                        Id = dr["Id"].ToString(),
                        RunDate = dr["RunDate"].ToString(),
                        RunTime = dr["RunTime"].ToString(),
                        Date = dr["Date"].ToString(),
                        Description = dr["Description"].ToString(),
                        Value = dr["Value"].ToString(),
                        Location = dr["Location"].ToString(),
                        Terminal = dr["Terminal"].ToString(),
                    };
                    items.Add(item);
                }
            }
            return items;
        }
        public async Task<IEnumerable<SummaryReportPerTerminalTickeAccountabilityModel>> SummaryReportPerTerminalTicketAccountabilityAsync(DateTime from,DateTime to, string terminal)
        {
            var items = new List<SummaryReportPerTerminalTickeAccountabilityModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = SummaryReportPerTerminalTicketAccountability;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@TerminalId", terminal);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach (DataRow dr in result.Rows)
                {
                    var item = new SummaryReportPerTerminalTickeAccountabilityModel
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
        public async Task<IEnumerable<SummaryReportPerTerminalProcessedTicketsModel>> SummaryReportPerTerminalProcessedTicketsAsync(DateTime from,DateTime to, string terminal)
        {
            var items = new List<SummaryReportPerTerminalProcessedTicketsModel>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = SummaryReportPerTerminalProcessedTickets;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", from);
            cmd.Parameters.AddWithValue("@DateTo", to);
            cmd.Parameters.AddWithValue("@TerminalId", terminal);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if (result != null)
            {
                foreach (DataRow dr in result.Rows)
                {
                    var item = new SummaryReportPerTerminalProcessedTicketsModel
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
    }
}
