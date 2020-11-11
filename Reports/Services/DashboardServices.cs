using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Services
{
    public class DashboardServices
    {
        public async Task<int> AvailedSlotsAsync(DateTime date)
        {
            var sql = string.Format("SELECT [dbo].[fnGetAvailedSlots]('{0}')", date.ToString("MM/dd/yyyy"));
            var result = await SCObjects.ReturnTextAsync(sql, Properties.Settings.Default.UserConnectionString);
            return int.Parse(result);
        }
        public async Task<int> AvailableSlotsAsync(DateTime date)
        {
            var sql = string.Format("SELECT [dbo].[fnGetAvailableSlots]('{0}')", date.ToString("MM/dd/yyyy"));
            var result = await SCObjects.ReturnTextAsync(sql, Properties.Settings.Default.UserConnectionString);
            return int.Parse(result);
        }
        public async Task<int> IssuedTicketsAsync(DateTime date)
        {
            var sql = string.Format("SELECT [dbo].[fnGetIssuedTickets]('{0}')", date.ToString("MM/dd/yyyy"));
            var result = await SCObjects.ReturnTextAsync(sql, Properties.Settings.Default.UserConnectionString);
            return int.Parse(result);
        }
        public async Task<int> ProcessedTicketsAsync(DateTime date)
        {
            var sql = string.Format("SELECT [dbo].[fnGetProcessedTickets]('{0}')", date.ToString("MM/dd/yyyy"));
            var result = await SCObjects.ReturnTextAsync(sql, Properties.Settings.Default.UserConnectionString);
            return int.Parse(result);
        }
        public async Task<decimal> TodaySalesAsync(DateTime date)
        {
            var sql = string.Format("SELECT [dbo].[fnGetTodaySales]('{0}')", date.ToString("MM/dd/yyyy"));
            var result = await SCObjects.ReturnTextAsync(sql, Properties.Settings.Default.UserConnectionString);
            return decimal.Parse(result);
        }
        public async Task<decimal> WeeklyTotalSalesAsync()
        {
            var sql = "EXEC [dbo].[spWeeklySalesDecimal]";
            var result = await SCObjects.ReturnTextAsync(sql, Properties.Settings.Default.UserConnectionString);
            return decimal.Parse(result);
        }
        public async Task<int> RemainingCarsAsync()
        {
            var sql = "SELECT [dbo].[fnGetRemainingCars]()";
            var result = await SCObjects.ReturnTextAsync(sql, Properties.Settings.Default.UserConnectionString);
            return int.Parse(result);
        }
        public async Task<DataTable> HourlyOccupancyAsync(DateTime date)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "[dbo].[spDashboardHourlyOccupancy]";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Date", date);
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<DataTable> WeeklyOccupancyAsync()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "[dbo].[spWeeklyOccupancy]";
            cmd.Parameters.Clear();
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<DataTable> WeeklySalesAsync()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "[dbo].[spWeeklySales]";
            cmd.Parameters.Clear();
            var result = await SCObjects.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
    }
}
