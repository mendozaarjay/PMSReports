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
            base.OnLoad(e);
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
            var auditperterminal = await services.AuditPerTerminalAsync(dtDate.Value);
            var processedtickets = await services.AuditPerTerminalProcessedTicketsAsync(dtDate.Value);
            var ticketaccountability = await services.AuditPerTerminalTicketAccountabilityAsync(dtDate.Value);

            LoadAuditPerTerminal(auditperterminal);
            LoadProcessedTickets(processedtickets);
            LoadTicketAccountability(ticketaccountability);
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
                dgAuditPerTerminal[dtlaptTerminal1.Index, row].Value = item.Terminal_1;
                dgAuditPerTerminal[dtlaptTerminal2.Index, row].Value = item.Terminal_2;
                dgAuditPerTerminal[dtlaptTerminal3.Index, row].Value = item.Terminal_3;
                dgAuditPerTerminal[dtlaptTotal.Index, row].Value = item.Total;
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
                dgProcessedTickets[dtlptTerminal1.Index, row].Value = item.Terminal_1;
                dgProcessedTickets[dtlptTerminal2.Index, row].Value = item.Terminal_2;
                dgProcessedTickets[dtlptTerminal3.Index, row].Value = item.Terminal_3;
                dgProcessedTickets[dtlptTotal.Index, row].Value = item.Total;
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
                dgTicketAccountability[dtltaTerminal1.Index, row].Value = item.Terminal_1;
                dgTicketAccountability[dtltaTerminal2.Index, row].Value = item.Terminal_2;
                dgTicketAccountability[dtltaTerminal3.Index, row].Value = item.Terminal_3;
                dgTicketAccountability[dtltaTotal.Index, row].Value = item.Total;
                row++;
            }
            dgTicketAccountability.AutoResizeColumns();
        }

        private async void btnCsv_Click(object sender, EventArgs e)
        {
            btnCsv.Enabled = false;
            var dt = await services.AuditPerTerminalDataTableAsync(dtDate.Value);
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Audit Per Terminal Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
            btnCsv.Enabled = true;
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            btnExcel.Enabled = false;
            var dt = await services.AuditPerTerminalDataTableAsync(dtDate.Value);
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Audit Per Terminal Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToExcel(dt, "Audit Per Terminal Report", sd.FileName);
            }
            btnExcel.Enabled = true;
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            var sources = new List<DataTable>();

            var _auditPerTerminal = await services.AuditPerTerminalDataTableAsync(dtDate.Value);
            _auditPerTerminal.TableName = "AuditPerTerminal";
            sources.Add(_auditPerTerminal);

            var _ticketAccountability = await services.AuditPerTerminalTicketAccountabilityDataTableAsync(dtDate.Value);
            _ticketAccountability.TableName = "AuditPerTerminalTicketAccountability";
            sources.Add(_ticketAccountability);

            var _processedTickets = await services.AuditPerTerminalProcessedTicketsDataTableAsync(dtDate.Value);
            _processedTickets.TableName = "AuditPerTerminalProcessedTickets";
            sources.Add(_processedTickets);

            var viewer = new Viewer();
            viewer.IsMultipleSource = true;
            viewer.DateCovered = dtDate.Value.ToString("MM/dd/yyyy");
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
