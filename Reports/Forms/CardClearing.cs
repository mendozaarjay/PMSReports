using Reports.Models;
using Reports.Reports;
using Reports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccess.Models;

namespace Reports
{
    public partial class CardClearing : Form
    {

        private CardClearingServices services = new CardClearingServices();
        public UserAccessItem UserAccess { get; set; }
        public CardClearing()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            timeFrom.Value = DateTime.Now.Minimun();
            timeTo.Value = DateTime.Now.Maximum();
            CheckForIllegalCrossThreadCalls = false;
            LoadAccess();
            LoadAllTerminal();
            base.OnLoad(e);
        }
        private void LoadAllTerminal()
        {
            var items = services.Terminals();
            if (items != null)
            {
                cboTerminal.DataSource = null;
                cboTerminal.DataSource = items;
                cboTerminal.DisplayMember = "Name";
                cboTerminal.ValueMember = "Id";
            }
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

            var result = await services.CardClearingAsync(from, to,cboTerminal.SelectedValue.ToString());

            await Spinner.ShowSpinnerAsync(this, PopulateItems(result));

            btnGenerate.Enabled = true;
        }
        public async Task PopulateItems(IEnumerable<CardClearingModel> items)
        {
            dgCardClearing.Rows.Clear();
            if (items.Count() > 0)
            {
                dgCardClearing.Rows.Add(items.Count());
            }

            await Task.Run(() =>
            {
                var row = 0;
                foreach (var item in items)
                {
                    dgCardClearing[dtlId.Index, row].Value = item.Id;
                    dgCardClearing[dtlRow.Index, row].Value = item.Row;
                    dgCardClearing[dtlEntranceGate.Index, row].Value = item.EntranceGate;
                    dgCardClearing[dtlTimeIn.Index, row].Value = item.DateTimein;
                    dgCardClearing[dtlPlateNo.Index, row].Value = item.PlateNo;
                    dgCardClearing[dtlTicketNo.Index, row].Value = item.TicketNo;
                    dgCardClearing[dtlComment.Index, row].Value = item.Comment;
                    dgCardClearing[dtlClearedUser.Index, row].Value = item.ClearedUser;
                    row++;
                }
            });
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

            var dt = await services.CardClearingDataTableAsync(from, to, cboTerminal.SelectedValue.ToString());

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Card Clearing Report " + from.ToString("MMddyyyy hhmmsstt") + "-" + to.ToString("MMddyyyy hhmmsstt");
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

            var dt = await services.CardClearingDataTableAsync(from, to,  cboTerminal.SelectedValue.ToString());

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Card Clearing Report " + from.ToString("MMddyyyy hhmmsstt") + "-" + to.ToString("MMddyyyy hhmmsstt");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                ExportToExcelFile.Export(dt, sd.FileName);
            }
            btnExcel.Enabled = true;
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);

            var dt = await services.CardClearingDataTableAsync(from, to, cboTerminal.SelectedValue.ToString());

            dt.TableName = "dsSource";
            var viewer = new Viewer();
            viewer.DateCovered = from.ToString() + "-" + to.ToString();
            viewer.ReportType = ReportType.CardClearing;
            viewer.Source = dt;
            viewer.ShowDialog();
            btnPrint.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgCardClearing.Rows.Count <= 0)
                return;

            var key = Finder.SearchResult();
            dgCardClearing.FindValue(key);
        }

        private void dgCardClearing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == dtlView.Index)
            {
                var id = dgCardClearing[dtlId.Index, e.RowIndex].Value.ToString();
                ImageViewer.ShowImage(int.Parse(id));
            }
        }
    }
}
