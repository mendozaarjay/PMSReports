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
    public partial class DetailedTransactionSummary : Form
    {
        DetailedTransactionSummaryServices services = new DetailedTransactionSummaryServices();
        private List<DetailedTransactionSummaryModel> SummaryItems { get; set; }
        public UserAccessItem UserAccess { get; set; }
        public DetailedTransactionSummary()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            dgDetailedTransaction.Columns[dtlEntranceImage.Index].Visible = false;
            dgDetailedTransaction.Columns[dtlExitImage.Index].Visible = false;
            timeFrom.Value = DateTime.Now.Minimun();
            timeTo.Value = DateTime.Now.Maximum();
            CheckForIllegalCrossThreadCalls = false;
            base.OnLoad(e);
        }
        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);

            var result = await services.DetailedTransactionSummaryAsync(from,to, txtSearch.Text.Trim());
            PopulateDetailedTransactionSummary(result);
            if(cbShowImages.Checked)
            {
                await ShowImage();
            }
            btnGenerate.Enabled = true;
        }

        private async Task ShowImage()
        {
            dgDetailedTransaction.Columns[dtlEntranceImage.Index].Visible = true;
            dgDetailedTransaction.Columns[dtlExitImage.Index].Visible = true;
            if (dgDetailedTransaction.Rows.Count > 0)
            {
                for(int i = 0; i <= dgDetailedTransaction.Rows.Count - 1;i++)
                {
                    await Task.Run(() =>
                    {
                        var item = SummaryItems.FirstOrDefault(a => a.TransitId.ToString() == dgDetailedTransaction[dtlTransitId.Index, i].Value.ToString());
                        dgDetailedTransaction.Columns[dtlEntranceImage.Index].Width = 150;
                        dgDetailedTransaction.Columns[dtlExitImage.Index].Width = 150;

                        if (item.EntranceImage != null)
                        {

                            var entranceImage = ImageHelper.ConvertByteToImage(item.EntranceImage);
                            var col =  new DataGridViewImageCell();
                            col.Value = entranceImage;
                            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            dgDetailedTransaction[dtlEntranceImage.Index, i] = col;
                            dgDetailedTransaction.Rows[i].Height = 150;
                            dgDetailedTransaction[dtlEntranceImage.Index, i].ReadOnly = true;
                        }
                        else
                        {
                            var col = new DataGridViewTextBoxCell();
                            col.Value = string.Empty;
        
                            dgDetailedTransaction[dtlEntranceImage.Index, i] = col;
                            dgDetailedTransaction.Rows[i].Height = 24;
                            dgDetailedTransaction[dtlEntranceImage.Index, i].ReadOnly = true;
                        }

                        if (item.ExitImage != null)
                        {

                            var image = ImageHelper.ConvertByteToImage(item.ExitImage);
                            var col = new DataGridViewImageCell();
                            col.Value = image;
                            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            dgDetailedTransaction[dtlExitImage.Index, i] = col;
                            dgDetailedTransaction.Rows[i].Height = 150;
                            dgDetailedTransaction[dtlExitImage.Index, i].ReadOnly = true;
                        }
                        else
                        {
                            var col = new DataGridViewTextBoxCell();
                            col.Value = string.Empty;

                            dgDetailedTransaction[dtlExitImage.Index, i] = col;
                            dgDetailedTransaction.Rows[i].Height = 24;
                            dgDetailedTransaction[dtlExitImage.Index, i].ReadOnly = true;
                        }

                    });


                }
            }
        }
        private void HideImage()
        {
            dgDetailedTransaction.Columns[dtlEntranceImage.Index].Visible = false;
            dgDetailedTransaction.Columns[dtlExitImage.Index].Visible = false;
            if(dgDetailedTransaction.Rows.Count > 0)
            {
                for(int i = 0; i <= dgDetailedTransaction.Rows.Count - 1; i++)
                {
                    dgDetailedTransaction.Rows[i].Height = 24;
                }
            }
        }
        private void PopulateDetailedTransactionSummary(IEnumerable<DetailedTransactionSummaryModel> items)
        {
            SummaryItems = null;
            SummaryItems = items.ToList();
            dgDetailedTransaction.Rows.Clear();
            if (items.Count() > 0)
            {
                dgDetailedTransaction.Rows.Add(items.Count());
                SummaryItems = items.ToList();
            }

            var row = 0;
            foreach (var item in items)
            {
                dgDetailedTransaction[dtlRow.Index, row].Value = row + 1;
                dgDetailedTransaction[dtlTransitId.Index, row].Value = item.TransitId;
                dgDetailedTransaction[dtlLocation.Index, row].Value = item.Location;
                dgDetailedTransaction[dtlORNumber.Index, row].Value = item.ORNumber;
                dgDetailedTransaction[dtlRateName.Index, row].Value = item.RateName;
                dgDetailedTransaction[dtlTimeIn.Index, row].Value = item.TimeIn;
                dgDetailedTransaction[dtlTimeOut.Index, row].Value = item.TimeOut;
                dgDetailedTransaction[dtlDuration.Index, row].Value = item.Duration;
                dgDetailedTransaction[dtlTotalHours.Index, row].Value = item.TotalHours;
                dgDetailedTransaction[dtlPlateNo.Index, row].Value = item.PlateNo;
                dgDetailedTransaction[dtlAmount.Index, row].Value = item.Amount;
                dgDetailedTransaction[dtlCardNumber.Index, row].Value = item.CardNumber;
                dgDetailedTransaction[dtlCashier.Index, row].Value = item.Username;
               
                row++;
            }
            dgDetailedTransaction.AutoResizeColumns();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            txtSearch.Clear();
            btnGenerate_Click(null, null);
            btnRefresh.Enabled = true;
        }

        private async void btnCsv_Click(object sender, EventArgs e)
        {
            btnCsv.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var dt = await services.DetailedTransactionSummaryDatatableAsync(from,to, txtSearch.Text.Trim());
            dt.Columns.Remove("TransitId");
            dt.Columns.Remove("EntranceImage");
            dt.Columns.Remove("ExitImage");
            dt.AcceptChanges();

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Detailed Transaction Summary Report " + dtFrom.Value.ToString("MMddyyy") + "-" + dtTo.Value.ToString("MMddyyyy");
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
            var dt = await services.DetailedTransactionSummaryDatatableAsync(from,to,txtSearch.Text.Trim());
            dt.Columns.Remove("TransitId");
            dt.Columns.Remove("EntranceImage");
            dt.Columns.Remove("ExitImage");
            dt.AcceptChanges();

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Detailed Transaction Summary Report " + dtFrom.Value.ToString("MMddyyy") + "-" + dtTo.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToExcel(dt, "Detailed Transaction Summary Report", sd.FileName);
            }
            btnExcel.Enabled = true;
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            var from = DateTimeConverter.GetDateTime(dtFrom, timeFrom);
            var to = DateTimeConverter.GetDateTime(dtTo, timeTo);
            var dt = await services.DetailedTransactionSummaryDatatableAsync(from,to,txtSearch.Text.Trim());
            dt.Columns.Remove("TransitId");
            dt.Columns.Remove("EntranceImage");
            dt.Columns.Remove("ExitImage");
            dt.AcceptChanges();

            dt.TableName = "DetailedTransactionSummary";
            var viewer = new Viewer();
            viewer.DateCovered = from.ToString("MM/dd/yyyy hh:mm tt") + "~" + to.ToString("MM/dd/yyyy hh:mm tt");
            viewer.ReportType = ReportType.DetailedTransactionSummaryReport;
            viewer.Source = dt;
            viewer.ShowDialog();
            btnPrint.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgDetailedTransaction.Rows.Count <= 0)
                return;

            var key = Finder.SearchResult();
            dgDetailedTransaction.FindValue(key);
        }

        private async void cbShowImages_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowImages.Checked)
            {
                if(SummaryItems != null)
                {
                    if(SummaryItems.Count() > 0)
                    {
                       await ShowImage();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                dgDetailedTransaction.Columns[dtlEntranceImage.Index].Visible = false;
                dgDetailedTransaction.Columns[dtlExitImage.Index].Visible = false;
                HideImage();
            }
        }

        private void dgDetailedTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if(e.ColumnIndex == dtlViewImage.Index)
            {
                var id = dgDetailedTransaction[dtlTransitId.Index, e.RowIndex].Value.ToString();
                ImageViewer.ShowImage(int.Parse(id));
            }
        }
    }
}
