
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccess.Models;

namespace Reports
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //for testing purposes.
            var access = new UserAccessItem
            {
                CanAccess = true,
                CanAdd = true,
                CanDelete = true,
                CanEdit = true,
                CanExport = true,
                CanPrint = true,
                CanSave = true,
                CanSearch = true,
            };
            var main = new MainFormNew(); //Change to main when deployment
            var form = new Sales(); //Testing of form
            form.UserAccess = access;

            Application.Run(main);
        }
    }
}
