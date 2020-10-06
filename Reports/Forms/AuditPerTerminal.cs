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
    public partial class AuditPerTerminal : Form
    {
        private AuditPerTerminalServices services = new AuditPerTerminalServices();
        public UserAccessItem UserAccess { get; set; }
        public AuditPerTerminal()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            LoadAccess();
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            btnGenerate_Click(null, null);
            btnRefresh.Enabled = true;
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;

            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);

            var auditperterminal = await services.AuditPerTerminalAsync(from,to,cbTerminal.SelectedValue.ToString());
            var processedtickets = await services.AuditPerTerminalProcessedTicketsAsync(from, to, cbTerminal.SelectedValue.ToString());
            var ticketaccountability = await services.AuditPerTerminalTicketAccountabilityAsync(from, to, cbTerminal.SelectedValue.ToString());
            Spinner.ShowSpinner(this, () =>
             {
                 LoadAuditPerTerminal(auditperterminal);
                 LoadProcessedTickets(processedtickets);
                 LoadTicketAccountability(ticketaccountability);
             });

            btnGenerate.Enabled = true;
        }

        private void LoadAuditPerTerminal(IEnumerable<AuditPerTerminalModel> items)
        {
            dgAuditPerTerminal.Rows.Clear();

            if (items.Count() > 0)
                dgAuditPerTerminal.Rows.Add(items.Count());

            var row = 0;
            foreach(var item in items)
            {
                dgAuditPerTerminal[dtlaptDescription.Index, row].Value = item.Description;
                dgAuditPerTerminal[dtlaptValue.Index, row].Value = item.Value;
                row++;
            }
            dgAuditPerTerminal.AutoResizeColumns();
        }

        private void LoadProcessedTickets(IEnumerable<AuditPerTerminalProcessedTicketsModel> items)
        {

            dgProcessedTickets.Rows.Clear();

            if (items.Count() > 0)
                dgProcessedTickets.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgProcessedTickets[dtlptDescription.Index, row].Value = item.Description;
                dgProcessedTickets[dtlptValue.Index, row].Value = item.Value;
                row++;
            }
            dgProcessedTickets.AutoResizeColumns();
        }

        private void LoadTicketAccountability(IEnumerable<AuditPerTerminalTicketAccountabilityModel> items)
        {
            dgTicketAccountability.Rows.Clear();

            if (items.Count() > 0)
                dgTicketAccountability.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgTicketAccountability[dtltaDescription.Index, row].Value = item.Description;
                dgTicketAccountability[dtltaValue.Index, row].Value = item.Value;
                row++;
            }
            dgTicketAccountability.AutoResizeColumns();
        }

        private async void btnCsv_Click(object sender, EventArgs e)
        {
            btnCsv.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var dt = await services.AuditPerTerminalDataTableAsync(from, to, cbTerminal.SelectedValue.ToString());
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Audit Per Terminal Report " + from.ToString("MMddyyyy") + "-" + to.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
            btnCsv.Enabled = true;
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            btnExcel.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);

            var dt = await services.AuditPerTerminalDataTableAsync(from, to, cbTerminal.SelectedValue.ToString());
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Audit Per Terminal Report " + from.ToString("MMddyyyy") + "-" + to.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                ExportToExcelFile.Export(dt, sd.FileName);
            }
            btnExcel.Enabled = true;
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            var sources = new List<DataTable>();

            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);

            var _auditPerTerminal = await services.AuditPerTerminalDataTableAsync(from, to, cbTerminal.SelectedValue.ToString());
            _auditPerTerminal.TableName = "AuditPerTerminal";
            sources.Add(_auditPerTerminal);

            var _ticketAccountability = await services.AuditPerTerminalTicketAccountabilityDataTableAsync(from, to, cbTerminal.SelectedValue.ToString());
            _ticketAccountability.TableName = "AuditPerTerminalTicketAccountability";
            sources.Add(_ticketAccountability);

            var _processedTickets = await services.AuditPerTerminalProcessedTicketsDataTableAsync(from, to, cbTerminal.SelectedValue.ToString());
            _processedTickets.TableName = "AuditPerTerminalProcessedTickets";
            sources.Add(_processedTickets);

            var viewer = new Viewer();
            viewer.IsMultipleSource = true;
            viewer.DateCovered = from.ToString("MMddyyyy") + "~" + to.ToString("MMddyyyy");
            viewer.ReportType = ReportType.AuditPerTerminal;
            viewer.ReportSources = sources;
            viewer.ShowDialog();
            btnPrint.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgAuditPerTerminal.Rows.Count < 0)
                return;
            var key = Finder.SearchResult();
            dgAuditPerTerminal.FindValue(key);
        }
    }
}
