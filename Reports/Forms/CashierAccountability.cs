using Reports.Models;
using Reports.Reports;
using Reports.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports
{
    public partial class CashierAccountability : Form
    {
        private CashierAccountabilityServices services = new CashierAccountabilityServices();
        public CashierAccountability()
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
            var terminal = int.Parse(cbTerminal.SelectedValue.ToString());
            var items =  await services.CashierAccountabilityAsync(dtDate.Value, terminal);
            LoadCashierAccountability(items);
            btnGenerate.Enabled = true;
        }

        private void LoadCashierAccountability(IEnumerable<CashierAccountabilityModel> items)
        {
            dgCashierAccountability.Rows.Clear();
            if (items.Count() > 0)
                dgCashierAccountability.Rows.Add(items.Count());
            var row = 0;
            foreach(var item in items)
            {
                dgCashierAccountability[dtlCarParkIncome.Index, row].Value = item.CarParkIncome;
                dgCashierAccountability[dtlReceiptsOut.Index, row].Value = item.ReceiptsOut;
                dgCashierAccountability[dtlAmount.Index, row].Value = item.Amount;
                row++;
            }
            dgCashierAccountability.AutoResizeColumns();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            btnGenerate_Click(null, null);
            btnRefresh.Enabled = true;
        }

        private  async void btnCsv_Click(object sender, EventArgs e)
        {
            var terminal = int.Parse(cbTerminal.SelectedValue.ToString());
            var dt = await services.CashierAccountabilityDataTableAsync(dtDate.Value,terminal);
            dt.Columns.Remove("Row");
            dt.AcceptChanges();
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Cashier Accountability Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            var terminal = int.Parse(cbTerminal.SelectedValue.ToString());
            var dt = await services.CashierAccountabilityDataTableAsync(dtDate.Value, terminal);
            dt.Columns.Remove("Row");
            dt.AcceptChanges();
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Cashier Accountability Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToExcel(dt, "Cashier Accountability Report", sd.FileName);
            }
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            var terminal = int.Parse(cbTerminal.SelectedValue.ToString());
            var items = await services.CashierAccountabilityDataTableAsync(dtDate.Value, terminal);
            items.TableName = "CashierAccountability";
            var viewer = new Viewer();
            viewer.DateCovered = dtDate.Value.Minimun().ToString();
            viewer.ReportType = ReportType.CashierAccountability;
            viewer.Source = items;
            viewer.ShowDialog();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgCashierAccountability.Rows.Count < 0)
                return;
            var key = Finder.SearchResult();
            dgCashierAccountability.FindValue(key);
        }
    }
}
