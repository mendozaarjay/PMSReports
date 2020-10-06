using Reports.Models;
using Reports.Reports;
using Reports.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
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
            LoadAccess();
            timeFrom.Value = DateTime.Now.Minimun();
            timeTo.Value = DateTime.Now.Maximum();


            cbTerminal_SelectedValueChanged(null, null);
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
        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            btnGenerate.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);

            var items = await services.AuditPerCashierAsync(from, to, cboCashier.SelectedValue.ToString(), cbTerminal.SelectedValue.ToString());
            var ticketaccountability = await services.TicketAccountabilityAsync(from, to, cboCashier.SelectedValue.ToString(), cbTerminal.SelectedValue.ToString());
            var proccessedtickets = await services.ProcessedTicketsAsync(from, to, cboCashier.SelectedValue.ToString(), cbTerminal.SelectedValue.ToString());
            await Spinner.ShowSpinnerAsync(this, LoadData(items, ticketaccountability, proccessedtickets));
            btnGenerate.Enabled = true;
        }

        private async Task LoadData(IEnumerable<AuditPerCashierModel> items, IEnumerable<AuditPerCashierTicketAccountabilityModel> ticketaccountability,IEnumerable<AuditPerCashierProcessedTicketModel> proccessedtickets)
        {
            await Task.Run(() =>
            {
                LoadAuditPerCashier(items);
                LoadTicketAccountability(ticketaccountability);
                LoadProcessedTickets(proccessedtickets);
            });
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
                dgAuditPerCashier[dtlapcValue.Index, row].Value = item.Value;
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
                dgTicketAccountability[dtltaValue.Index, row].Value = item.Value;
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
                dgProcessedTickets[dtlptValue.Index, row].Value = item.Value;
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
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var dt = await services.AuditPerCashierDataTableAsync(from, to, cboCashier.SelectedValue.ToString(), cbTerminal.SelectedValue.ToString());
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Audit Per Cashier Report " + from.ToString("MMddyyyy") + '-' + to.ToString("MMddyyyy");
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
            var dt = await services.AuditPerCashierDataTableAsync(from, to, cboCashier.SelectedValue.ToString(), cbTerminal.SelectedValue.ToString());
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Audit Per Cashier Report " + from.ToString("MMddyyyy") + '-' + to.ToString("MMddyyyy");
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

            var auditpercashier = await services.AuditPerCashierDataTableAsync(from,to,cboCashier.SelectedValue.ToString(), cbTerminal.SelectedValue.ToString());
            auditpercashier.TableName = "AuditPerCashier";
            sources.Add(auditpercashier);

            var processedtickets = await services.ProcessedTicketsDataTableAsync(from, to, cboCashier.SelectedValue.ToString(), cbTerminal.SelectedValue.ToString());
            processedtickets.TableName = "AuditPerCashierProcessedTickets";
            sources.Add(processedtickets);

            var ticketaccountability = await services.TicketAccountabilityDataTableAsync(from, to, cboCashier.SelectedValue.ToString(), cbTerminal.SelectedValue.ToString());
            ticketaccountability.TableName = "AuditPerCashierTicketAccountability";
            sources.Add(ticketaccountability);

            var viewer = new Viewer();
            viewer.DateCovered = from.ToString() + '~' + to.ToString();
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

        private void cbTerminal_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadCashier();
            }
            catch (Exception ex)
            {

            }
        }
        void LoadCashier()
        {
            cboCashier.DataSource = null;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var items = services.CashiersPerTerminal(from, to, cbTerminal.SelectedValue.ToString());
            cboCashier.DataSource = items;
            cboCashier.ValueMember = "UserId";
            cboCashier.DisplayMember = "Username";
        }
        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadCashier();
            }
            catch (Exception ex)
            {

            }
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadCashier();
            }
            catch (Exception ex)
            {

            }
        }

        private void timeFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadCashier();
            }
            catch (Exception ex)
            {

            }
        }

        private void timeTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadCashier();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
