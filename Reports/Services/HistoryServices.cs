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
    public class HistoryServices
    {
        private const string StoredProcedure = "[dbo].[spHistoryReport]";

        public async Task<IEnumerable<HistoryModel>> GetHistoryReportAsync(DateTime dateFrom, DateTime dateTo, string terminal, string Keyword)
        {
            var items = new List<HistoryModel>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", dateFrom);
            cmd.Parameters.AddWithValue("@DateTo", dateTo);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            cmd.Parameters.AddWithValue("@SearchKey", Keyword);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);

            foreach (DataRow dr in result.Rows)
            {
                var item = new HistoryModel();
                item.Id = int.Parse(dr["TransitId"].ToString());
                item.Terminal = dr["Terminal"].ToString();
                item.ORNumber = dr["ORNumber"].ToString();
                item.Type = dr["Type"].ToString();
                item.PlateNo = dr["PlateNo"].ToString();
                item.TicketNumber = dr["TicketNumber"].ToString();
                item.TimeIn = dr["TimeIn"].ToString();
                item.TimeOut = dr["TimeOut"].ToString();
                item.Duration = dr["Duration"].ToString();
                item.RateName = dr["RateName"].ToString();
                item.Coupon = dr["Coupon"].ToString();
                item.MonthlyName = dr["MonthlyName"].ToString();
                item.MonthlyRFID = dr["MonthlyRFID"].ToString();
                item.SCPWDName = dr["SCPWDName"].ToString();
                item.SCPWDAddress = dr["SCPWDAddress"].ToString();
                item.SCPWDId = dr["SCPWDId"].ToString();
                item.LostCardPenalty = decimal.Parse(dr["LostCardPenalty"].ToString());
                item.LostCardName = dr["LostCardName"].ToString();
                item.LostCardLicenseNo = dr["LostCardLicenseNo"].ToString();
                item.LostCardORCR = dr["LostCardORCR"].ToString();
                item.OvernightPenalty = decimal.Parse(dr["OvernightPenalty"].ToString());

                item.EntranceImage = dr["EntranceImage"].ToString().Length > 0 ? (byte[])(dr["EntranceImage"]) : null;
                item.ExitImage = dr["ExitImage"].ToString().Length > 0 ? (byte[])(dr["ExitImage"]) : null;
                item.EntranceGate = dr["EntranceGate"].ToString();
                items.Add(item);
            }
            return items;
        }
        public async Task<DataTable> GetHistoryDataTableAsync(DateTime dateFrom, DateTime dateTo, string terminal, string Keyword)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DateFrom", dateFrom);
            cmd.Parameters.AddWithValue("@DateTo", dateTo);
            cmd.Parameters.AddWithValue("@Terminal", terminal);
            cmd.Parameters.AddWithValue("@SearchKey", Keyword);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
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
