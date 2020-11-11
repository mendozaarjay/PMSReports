using Reports.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Services
{
    public class GeneralSettingsServices
    {
        private const string StoredProcedure = "[dbo].[spGetGeneralSettings]";
        public GeneralSettingModel GetSettings()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = StoredProcedure;
            var result = SCObjects.ExecGetData(cmd, Properties.Settings.Default.UserConnectionString);
            if(result != null)
            {
                var item = new GeneralSettingModel
                {
                    ParkingName = result.Rows[0]["ParkingName"].ToString(),
                    TIN = result.Rows[0]["TIN"].ToString(),
                    Company = result.Rows[0]["Company"].ToString(),
                    Address1 = result.Rows[0]["Address1"].ToString(),
                    Address2 = result.Rows[0]["Address2"].ToString(),
                    Address3 = result.Rows[0]["Address3"].ToString(),
                    PhoneNumber = result.Rows[0]["PhoneNumber"].ToString(),
                    Address = result.Rows[0]["Address"].ToString(),
                };
                return item;
            }
            else
            {
                return null;
            }
        }
    }
}
