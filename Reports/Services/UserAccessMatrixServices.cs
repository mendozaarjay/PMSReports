using Reports.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAccess.Helpers;

namespace Reports.Services
{
    public class UserAccessMatrixServices
    {
        private const string StoredProcedure = "[dbo].[spGetUserAccessMatrix]";

        public async Task<DataTable> GetUserAccessMatrixDatatableAsync(string userid)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@UserId", userid);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            return result;
        }
        public async Task<IEnumerable<UserAccessMatrixItemModel>> GetUserAccessMatrixAsync(string userid)
        {
            var items = new List<UserAccessMatrixItemModel>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@UserId", userid);
            var result = await DatabaseHelper.ExecGetDataAsync(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                foreach(DataRow dr in result.Rows)
                {
                    var item = new UserAccessMatrixItemModel
                    {
                        UserId = int.Parse(dr["UserId"].ToString()),
                        Username = dr["Username"].ToString(),
                        FirstName = dr["FirstName"].ToString(),
                        LastName = dr["LastName"].ToString(),
                        RoleId = int.Parse(dr["RoleId"].ToString()),
                        RoleCode = dr["RoleCode"].ToString(),
                        RoleDescription = dr["RoleDescription"].ToString(),
                        ModuleId = int.Parse(dr["ModuleId"].ToString()),
                        ModuleCode = dr["ModuleCode"].ToString(),
                        ModuleDescription = dr["ModuleDescription"].ToString(),
                        TypeId = int.Parse(dr["TypeId"].ToString()),
                        Type = dr["Type"].ToString(),
                        CanAdd = ValueConverter.ConvertFromBoolean(dr["CanAdd"].ToString()),
                        CanEdit = ValueConverter.ConvertFromBoolean(dr["CanEdit"].ToString()),
                        CanSave = ValueConverter.ConvertFromBoolean(dr["CanSave"].ToString()),
                        CanDelete = ValueConverter.ConvertFromBoolean(dr["CanDelete"].ToString()),
                        CanSearch = ValueConverter.ConvertFromBoolean(dr["CanSearch"].ToString()),
                        CanPrint = ValueConverter.ConvertFromBoolean(dr["CanPrint"].ToString()),
                        CanExport = ValueConverter.ConvertFromBoolean(dr["CanExport"].ToString()),
                        CanAccess = ValueConverter.ConvertFromBoolean(dr["CanAccess"].ToString()),

                    };
                    items.Add(item);
                }
            }
            return items;
        }
        public DataTable GetAllEmployees()
        {
            var sql = @"SELECT [UserID],
                               [Username]
                        FROM [dbo].[fnGetAllUsers]()";
            var result = DatabaseHelper.LoadDataTable(sql, Properties.Settings.Default.UserConnectionString);
            return result;
        }
    }
}
