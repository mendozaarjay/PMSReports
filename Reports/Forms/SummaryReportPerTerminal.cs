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
    public partial class SummaryReportPerTerminal : Form
    {
        private SummaryReportPerTerminalServices services = new SummaryReportPerTerminalServices();
        public UserAccessItem UserAccess { get; set; }
        public SummaryReportPerTerminal()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            LoadGates();
            LoadAccess();
            base.OnLoad(e);
        }
        private void LoadAccess()
        {
            btnPrint.Visible = UserAccess.CanPrint;
            btnExcel.Visible = btnCsv.Visible = UserAccess.CanExport;
            btnRefresh.Enabled = btnGenerate.Enabled = UserAccess.CanAccess;
        }
        private void LoadGates()
        {
            var items = services.Gates();
            cbTerminal.DataSource = items;
            cbTerminal.ValueMember = "Id";
            cbTerminal.DisplayMember = "Name";
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
            var summary = await services.SummaryReportPerTerminalAsync(dtDate.Value, cbTerminal.SelectedValue.ToString());
            var tickets = await services.SummaryReportPerTerminalTicketAccountabilityAsync(dtDate.Value, cbTerminal.SelectedValue.ToString());
            var processed = await services.SummaryReportPerTerminalProcessedTicketsAsync(dtDate.Value, cbTerminal.SelectedValue.ToString());

            LoadSummary(summary);
            LoadTicketAccountability(tickets);
            LoadProcessedTickets(processed);
            btnGenerate.Enabled = true;
        }

        private void LoadSummary(IEnumerable<SummaryReportPerTerminalModel> items)
        {
            dgSummary.Rows.Clear();
            if (items.Count() > 0)
                dgSummary.Rows.Add(items.Count());
            var row = 0;
            foreach(var item in items)
            {
                dgSummary[dtlSummaryDescription.Index, row].Value = item.Description;
                dgSummary[dtlSummaryValue.Index, row].Value = item.Value;
                row++;
            }
            dgSummary.AutoResizeColumns();
        }

        private void LoadTicketAccountability(IEnumerable<SummaryReportPerTerminalTickeAccountabilityModel> items)
        {
            dgTickets.Rows.Clear();
            if (items.Count() > 0)
                dgTickets.Rows.Add(items.Count());
            var row = 0;
            foreach (var item in items)
            {
                dgTickets[dtlTicketsDescription.Index, row].Value = item.Description;
                dgTickets[dtlTicketsValue.Index, row].Value = item.Value;
                row++;
            }
            dgTickets.AutoResizeColumns();
        }

        private void LoadProcessedTickets(IEnumerable<SummaryReportPerTerminalProcessedTicketsModel> items)
        {
            dgProcessed.Rows.Clear();
            if (items.Count() > 0)
                dgProcessed.Rows.Add(items.Count());
            var row = 0;
            foreach (var item in items)
            {
                dgProcessed[dtlProcessedDescription.Index, row].Value = item.Description;
                dgProcessed[dtlProcessedValue.Index, row].Value = item.Value;
                row++;
            }
            dgProcessed.AutoResizeColumns();
        }

        private async void btnCsv_Click(object sender, EventArgs e)
        {
            btnCsv.Enabled = false;
            var dt = await services.SummaryReportPerTerminalDataTableAsync(dtDate.Value, cbTerminal.SelectedValue.ToString());
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Summary Report Per Terminal " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
            btnCsv.Enabled = true;
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            btnExcel.Enabled = false;
            var dt = await services.SummaryReportPerTerminalDataTableAsync(dtDate.Value, cbTerminal.SelectedValue.ToString());
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Summary Report Per Terminal " + dtDate.Value.ToString("MMddyyyy");
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

            var summary = await services.SummaryReportPerTerminalDataTableAsync(dtDate.Value, cbTerminal.SelectedValue.ToString());
            summary.TableName = "SummaryReportPerTerminal";
            sources.Add(summary);

            var processedtickets = await services.SummaryReportPerTerminalProcessedTicketsDataTableAsync(dtDate.Value, cbTerminal.SelectedValue.ToString());
            processedtickets.TableName = "SummaryReportPerTerminalTickeAccountability";
            sources.Add(processedtickets);

            var ticketaccountability = await services.SummaryReportPerTerminalTicketAccountabilityDataTableAsync(dtDate.Value, cbTerminal.SelectedValue.ToString());
            ticketaccountability.TableName = "SummaryReportPerTerminalProcessedTickets";
            sources.Add(ticketaccountability);

            var viewer = new Viewer();
            viewer.IsMultipleSource = true;
            viewer.DateCovered = dtDate.Value.ToString("MM/dd/yyyy");
            viewer.ReportType = ReportType.SummaryReportPerTerminal;
            viewer.ReportSources = sources;
            viewer.ShowDialog();
            btnPrint.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgSummary.Rows.Count < 0)
                return;
            var key = Finder.SearchResult();
            dgSummary.FindValue(key);
        }
    }
}
