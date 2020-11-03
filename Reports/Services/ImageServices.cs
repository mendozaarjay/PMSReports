using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Services
{
    public class ImageServices
    {
        private const string StoredProcedure = "[dbo].[spLoadTransitImage]";

        public async Task<DataTable> GetTransactionImages(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Id", id);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<DataTable> GetTransactionImagesHighReso(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "[dbo].[spLoadTransitImageHighReso]";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Id", id);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
    }
}
