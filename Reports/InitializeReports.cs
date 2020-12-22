using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports
{
    public static class InitializeReports
    {
        public static void StartReports(string connectionString, string programAndVersion, string serialNumber, string min, string currentusername, string currentuserid)
        {
            Properties.Settings.Default.UserConnectionString = connectionString;
            Properties.Settings.Default.ProgramVersion = programAndVersion;
            Properties.Settings.Default.SN = serialNumber;
            Properties.Settings.Default.MIN = min;
            Properties.Settings.Default.Username = currentusername;
            Properties.Settings.Default.CurrentUserId = currentuserid;
            MainFormNew frm = new MainFormNew();
            frm.ShowDialog();
        }
    }
}
