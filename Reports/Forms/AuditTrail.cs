using Reports.Models;
using Reports.Reports;
using Reports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UserAccess.Models;

namespace Reports
{
    public partial class AuditTrail : Form
    {
        private AuditTrailServices services = new AuditTrailServices();
        public UserAccessItem UserAccess { get; set; }
        public AuditTrail()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            LoadGates();
            LoadAccess();
            timeFrom.Value = DateTime.Now.Minimun();
            timeTo.Value = DateTime.Now.Maximum();
            base.OnLoad(e);
        }
        private void LoadGates()
        {
            var items = services.Gates();
            cbTerminal.DataSource = items;
            cbTerminal.ValueMember = "Id";
            cbTerminal.DisplayMember = "Name";
        }
        private void LoadAccess()
        {
            btnPrint.Visible = UserAccess.CanPrint;
            btnExcel.Visible = btnCsv.Visible = UserAccess.CanExport;
            btnRefresh.Enabled = btnGenerate.Enabled = UserAccess.CanAccess;
        }
        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var items = await services.GetAuditTrailAsync(from,to,cbTerminal.SelectedValue.ToString(),txtKeyword.Text);
            Spinner.ShowSpinner(this, () =>
            {
                LoadAuditTrail(items);
            });

            btnGenerate.Enabled = true;
        }

        private void LoadAuditTrail(IEnumerable<AuditTrailModel> items)
        {
            dgDetails.Rows.Clear();
            if(items.Count() > 0)
            {
                dgDetails.Rows.Add(items.Count());
            }
            if(items != null)
            {
                var row = 0;
                foreach(var item in items)
                {
                    dgDetails[dtlId.Index, row].Value = item.Id;
                    dgDetails[dtlDescription.Index, row].Value = item.Description;
                    dgDetails[dtlGate.Index, row].Value = item.Gate;
                    dgDetails[dtlUsername.Index, row].Value = item.Username;
                    dgDetails[dtlDate.Index, row].Value = item.Date;
                    row++;
                }
            }
          
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            btnGenerate_Click(null, null);
            btnRefresh.Enabled = true;
        }

        private  void btnCsv_Click(object sender, EventArgs e)
        {
            btnCsv.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var dt = services.AuditTrailDataTable(from, to, cbTerminal.SelectedValue.ToString(),txtKeyword.Text);

            SaveFileDialog sd = new SaveFileDialog(); 
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Audit Trail Report " + from.ToString("MMddyyyy hhmmsstt") + "-" + to.ToString("MMddyyyy hhmmsstt");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
            btnCsv.Enabled = true;
        }

        private  void btnExcel_Click(object sender, EventArgs e)
        {
            btnExcel.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var dt = services.AuditTrailDataTable(from, to, cbTerminal.SelectedValue.ToString(),txtKeyword.Text);
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Audit Trail Report " + from.ToString("MMddyyyy hhmmsstt") + "-" + to.ToString("MMddyyyy hhmmsstt");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                ExportToExcelFile.Export(dt, sd.FileName);
            }
            btnExcel.Enabled = true;
        }

        private  void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var items = services.AuditTrailDataTable(from, to, cbTerminal.SelectedValue.ToString(), txtKeyword.Text);
            items.TableName = "AuditTrail";
            var viewer = new CrystalViewer();
            viewer.DateCovered = from.ToString() + "-" + to.ToString();
            viewer.ReportType = ReportType.AuditTrail;
            viewer.DataSource = items;
            viewer.ShowDialog();
            btnPrint.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgDetails.Rows.Count < 0)
                return;
            var key = Finder.SearchResult();
            dgDetails.FindValue(key);
        }
    }
}
