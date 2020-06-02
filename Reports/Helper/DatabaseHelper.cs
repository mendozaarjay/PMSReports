using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Reports
{
    public static class DatabaseHelper
    {
        public static DataTable ExecGetData(SqlCommand cmd,string SqlConnectionString)
        {
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                cn.ConnectionString = SqlConnectionString;
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            return dt;
        }
        public static async Task<DataTable> ExecGetDataAsync(SqlCommand cmd, string SqlConnectionString)
        {
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                cn.ConnectionString = SqlConnectionString;
                await cn.OpenAsync();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn;
                da.SelectCommand = cmd;
                await Task.Run(() => da.Fill(dt));
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            return dt;
        }
        public static DataTable LoadDataTable(string SqlQuery, string SqlConnectionString)
        {
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = SqlConnectionString;
                cn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = SqlQuery;
                cmd.Connection = cn;
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            return dt;
        }
        public static async Task<DataTable> LoadDataTableAsync(string SqlQuery, string SqlConnectionString)
        {
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cn.ConnectionString = SqlConnectionString;
                await cn.OpenAsync();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = SqlQuery;
                cmd.Connection = cn;
                da.SelectCommand = cmd;
                await Task.Run(() => da.Fill(dt));
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            return dt;
        }
    }
}
