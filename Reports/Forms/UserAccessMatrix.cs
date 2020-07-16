using Reports.Models;
using Reports.Reports;
using Reports.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UserAccess.Models;

namespace Reports
{
    public partial class UserAccessMatrix : Form
    {
        private UserAccessMatrixServices services = new UserAccessMatrixServices();
        public UserAccessItem UserAccess { get; set; }
        public UserAccessMatrix()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            LoadAllUsers();
            base.OnLoad(e);
        }

        private void LoadAllUsers()
        {
            var dt = services.GetAllEmployees();
            cboUser.DataSource = dt;
            cboUser.ValueMember = "UserId";
            cboUser.DisplayMember = "Username";
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            var items = await services.GetUserAccessMatrixAsync(cboUser.SelectedValue.ToString());
            PopulateUserAccessMatrix(items);
            btnGenerate.Enabled = true;
        }

        private void PopulateUserAccessMatrix(IEnumerable<UserAccessMatrixItemModel> items)
        {
            dgItems.Rows.Clear();
            if (items.Count() > 0)
                dgItems.Rows.Add(items.Count());
            var row = 0;

            foreach (var item in items)
            {
                dgItems[dtlRow.Index, row].Value = row + 1;
                dgItems[dtlUsername.Index, row].Value = item.Username;
                dgItems[dtlRole.Index, row].Value = item.RoleDescription;
                dgItems[dtlModule.Index, row].Value = item.ModuleDescription;
                dgItems[dtlType.Index, row].Value = item.Type;
                dgItems[dtlCanAdd.Index, row].Value = item.CanAdd;
                dgItems[dtlCanEdit.Index, row].Value = item.CanEdit;
                dgItems[dtlCanSave.Index, row].Value = item.CanSave;
                dgItems[dtlCanDelete.Index, row].Value = item.CanDelete;
                dgItems[dtlCanSearch.Index, row].Value = item.CanSearch;
                dgItems[dtlCanPrint.Index, row].Value = item.CanPrint;
                dgItems[dtlCanExport.Index, row].Value = item.CanExport;
                dgItems[dtlCanAccess.Index, row].Value = item.CanAccess;
                row++;
            }
            dgItems.AutoResizeColumns();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            btnGenerate_Click(null, null);
            btnRefresh.Enabled = true;
        }

        private async void btnCsv_Click(object sender, EventArgs e)
        {
            btnCsv.Enabled = false;
            var dt = await services.GetUserAccessMatrixDatatableAsync(cboUser.SelectedValue.ToString());

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "User Access Matrix Report " + DateTime.Now.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
            btnCsv.Enabled = true;
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            btnExcel.Enabled = false;
            var dt = await services.GetUserAccessMatrixDatatableAsync(cboUser.SelectedValue.ToString());

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "User Access Matrix Report " + DateTime.Now.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToExcel(dt, "User Access Matrix Report", sd.FileName);
            }
            btnExcel.Enabled = true;
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            var items = await services.GetUserAccessMatrixDatatableAsync(cboUser.SelectedValue.ToString());
            items.TableName = "UserAccessMatrix";
            items.Columns.Add(new DataColumn("Row"));
            items.AcceptChanges();
            var row = 1;
            foreach (DataRow dr in items.Rows)
            {
                dr["Row"] = row.ToString();
                row++;
            }
            var viewer = new Viewer();
            viewer.DateCovered = DateTime.Now.ToString("MMddyyyy");
            viewer.ReportType = ReportType.UserAccessMatrix;
            viewer.Source = items;
            viewer.ShowDialog();
            btnPrint.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgItems.Rows.Count < 0)
                return;
            var key = Finder.SearchResult();
            dgItems.FindValue(key);
        }

        private void dgItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }
    }
}
