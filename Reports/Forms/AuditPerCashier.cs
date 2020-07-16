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
    public partial class AuditPerCashier : Form
    {
        private AuditPerCashierServices services = new AuditPerCashierServices();
        public UserAccessItem UserAccess { get; set; }
        public AuditPerCashier()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            LoadGates();
            base.OnLoad(e);
        }

        private void LoadGates()
        {
            var items = services.Gates();
            cbTerminal.DataSource = items;
            cbTerminal.ValueMember = "Id";
            cbTerminal.DisplayMember = "Name";
        }
        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            var items = await services.AuditPerCashierAsync(dtDate.Value, cbTerminal.SelectedValue.ToString());
            var ticketaccountability = await services.TicketAccountabilityAsync(dtDate.Value);
            var proccessedtickets = await services.ProcessedTicketsAsync(dtDate.Value);
            LoadAuditPerCashier(items);
            LoadTicketAccountability(ticketaccountability);
            LoadProcessedTickets(proccessedtickets);
            btnGenerate.Enabled = true;
        }

        private void LoadAuditPerCashier(IEnumerable<AuditPerCashierModel> items)
        {
            dgAuditPerCashier.Rows.Clear();
            if (items.Count() > 0)
                dgAuditPerCashier.Rows.Add(items.Count());
            var row = 0;
            foreach(var item in items)
            {
                dgAuditPerCashier[dtlapcDescription.Index,row].Value = item.Description;
                dgAuditPerCashier[dtlapcCashier1.Index,row].Value = item.Cashier_1;
                dgAuditPerCashier[dtlapcCashier2.Index,row].Value = item.Cashier_2;
                dgAuditPerCashier[dtlapcCashier3.Index,row].Value = item.Cashier_3;
                dgAuditPerCashier[dtlapcCashier4.Index,row].Value = item.Cashier_4;
                dgAuditPerCashier[dtlapcCashier5.Index,row].Value = item.Cashier_5;
                dgAuditPerCashier[dtlapcCashier6.Index,row].Value = item.Cashier_6;
                dgAuditPerCashier[dtlapcTotal.Index, row].Value = item.Total;
                row++;
            }
            dgAuditPerCashier.AutoResizeColumns(); 
        }

        private void LoadTicketAccountability(IEnumerable<AuditPerCashierTicketAccountabilityModel> items)
        {
            dgTicketAccountability.Rows.Clear();
            if (items.Count() > 0)
                dgTicketAccountability.Rows.Add(items.Count());
            var row = 0;
            foreach (var item in items)
            {
                dgTicketAccountability[dtltaDescription.Index, row].Value = item.Description;
                dgTicketAccountability[dtltaCashier1.Index, row].Value = item.Cashier_1;
                dgTicketAccountability[dtltaCashier2.Index, row].Value = item.Cashier_2;
                dgTicketAccountability[dtltaCashier3.Index, row].Value = item.Cashier_3;
                dgTicketAccountability[dtltaCashier4.Index, row].Value = item.Cashier_4;
                dgTicketAccountability[dtltaCashier5.Index, row].Value = item.Cashier_5;
                dgTicketAccountability[dtltaCashier6.Index, row].Value = item.Cashier_6;
                dgTicketAccountability[dtltaTotal.Index, row].Value = item.Total;
                row++;
            }
            dgTicketAccountability.AutoResizeColumns();
        }

        private void LoadProcessedTickets(IEnumerable<AuditPerCashierProcessedTicketModel> items)
        {
            dgProcessedTickets.Rows.Clear();
            if (items.Count() > 0)
                dgProcessedTickets.Rows.Add(items.Count());
            var row = 0;
            foreach (var item in items)
            {
                dgProcessedTickets[dtlptDescription.Index, row].Value = item.Description;
                dgProcessedTickets[dtlptCashier1.Index, row].Value = item.Cashier_1;
                dgProcessedTickets[dtlptCashier2.Index, row].Value = item.Cashier_2;
                dgProcessedTickets[dtlptCashier3.Index, row].Value = item.Cashier_3;
                dgProcessedTickets[dtlptCashier4.Index, row].Value = item.Cashier_4;
                dgProcessedTickets[dtlptCashier5.Index, row].Value = item.Cashier_5;
                dgProcessedTickets[dtlptCashier6.Index, row].Value = item.Cashier_6;
                dgProcessedTickets[dtlptTotal.Index, row].Value = item.Total;
                row++;
            }
            dgProcessedTickets.AutoResizeColumns();
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
            var dt = await services.AuditPerCashierDataTableAsync(dtDate.Value, cbTerminal.SelectedValue.ToString());
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Audit Per Cashier Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
            btnCsv.Enabled = true;
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            btnExcel.Enabled = false;
            var dt = await services.AuditPerCashierDataTableAsync(dtDate.Value, cbTerminal.SelectedValue.ToString());
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Audit Per Cashier Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToExcel(dt, "Audit Per Cashier Report",sd.FileName);
            }
            btnExcel.Enabled = true;
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            var sources = new List<DataTable>();

            var auditpercashier = await services.AuditPerCashierDataTableAsync(dtDate.Value, cbTerminal.SelectedValue.ToString());
            auditpercashier.TableName = "AuditPerCashier";
            sources.Add(auditpercashier);

            var processedtickets = await services.ProcessedTicketsDataTableAsync(dtDate.Value);
            processedtickets.TableName = "AuditPerCashierProcessedTickets";
            sources.Add(processedtickets);

            var ticketaccountability = await services.TicketAccountabilityDataTableAsync(dtDate.Value);
            ticketaccountability.TableName = "AuditPerCashierTicketAccountability";
            sources.Add(ticketaccountability);

            var viewer = new Viewer();
            viewer.DateCovered = dtDate.Value.ToString("MM/dd/yyyy");
            viewer.IsMultipleSource = true;
            viewer.ReportType = ReportType.AuditPerCashier;
            viewer.ReportSources = sources;
            viewer.ShowDialog();
            btnPrint.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgAuditPerCashier.Rows.Count < 0)
                return;
            var key = Finder.SearchResult();
            dgAuditPerCashier.FindValue(key);
        }
    }
}
