using Reports.Models;
using Reports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccess.Models;

namespace Reports
{
    public partial class CardEncoding : Form
    {
        private CardEncodingServices services = new CardEncodingServices();
        private List<CardEncodingModel> CardEncodingItems { get; set; }
        public UserAccessItem UserAccess { get; set; }
        public CardEncoding()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            dgEncoding.Columns[dtlEntranceImage.Index].Visible = false;
            dgEncoding.Columns[dtlExitImage.Index].Visible = false;
            this.DoubleBuffered = true;
            CheckForIllegalCrossThreadCalls = false;
            LoadAccess();
            base.OnLoad(e);
        }
        private void LoadAccess()
        {
            btnRefresh.Enabled = btnGenerate.Enabled = UserAccess.CanAccess;
        }
        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            var items = await services.CardEncodingAsync(dtDate.Value.Maximum(), txtSearch.Text);

            await Spinner.ShowSpinnerAsync(this, PopulateEncoding(items));
            if (cbShowImages.Checked)
            {
                await Spinner.ShowSpinnerAsync(this, ShowImages());
            }
            btnGenerate.Enabled = true;
        }

        private async Task ShowImages()
        {
            dgEncoding.Enabled = false;
            dgEncoding.Columns[dtlEntranceImage.Index].Visible = true;
            dgEncoding.Columns[dtlExitImage.Index].Visible = true;

            if (dgEncoding.Rows.Count > 0)
            {
                for (int i = 0; i <= dgEncoding.Rows.Count - 1; i++)
                {
                    try
                    {
                        await Task.Run(() =>
                        {
                            var item = CardEncodingItems.FirstOrDefault(a => a.Id.ToString() == dgEncoding[dtlId.Index, i].Value.ToString());
                            dgEncoding.Columns[dtlEntranceImage.Index].Width = 250;

                            if (item.EntranceImage != null)
                            {

                                var entranceImage = ImageHelper.ConvertByteToImageWithResizing(item.EntranceImage);
                                var col = new DataGridViewImageCell();
                                col.Value = entranceImage;
                                col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                                dgEncoding[dtlEntranceImage.Index, i] = col;
                                dgEncoding.Rows[i].Height = 250;
                                dgEncoding[dtlEntranceImage.Index, i].ReadOnly = true;

                            }
                            else
                            {
                                var col = new DataGridViewTextBoxCell();
                                col.Value = string.Empty;

                                dgEncoding[dtlEntranceImage.Index, i] = col;
                                dgEncoding.Rows[i].Height = 24;
                                dgEncoding[dtlEntranceImage.Index, i].ReadOnly = true;
                            }


                            if (item.ExitImage != null)
                            {

                                var exitImage = ImageHelper.ConvertByteToImageWithResizing(item.ExitImage);
                                var col = new DataGridViewImageCell();
                                col.Value = exitImage;
                                col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                                dgEncoding[dtlExitImage.Index, i] = col;
                                dgEncoding.Rows[i].Height = 250;
                                dgEncoding[dtlExitImage.Index, i].ReadOnly = true;
                            }
                            else
                            {
                                var col = new DataGridViewTextBoxCell();
                                col.Value = string.Empty;

                                dgEncoding[dtlExitImage.Index, i] = col;
                                dgEncoding.Rows[i].Height = 24;
                                dgEncoding[dtlExitImage.Index, i].ReadOnly = true;
                            }

                            if (item.EntranceImage != null || item.ExitImage != null)
                                dgEncoding.Rows[i].Height = 250;

                        });
                    }
                    catch (Exception)
                    {

                    }


                }
            }
            dgEncoding.Enabled = true;
        }
        private void HideImage()
        {
            dgEncoding.Columns[dtlEntranceImage.Index].Visible = false;
            dgEncoding.Columns[dtlExitImage.Index].Visible = false;
            if (dgEncoding.Rows.Count > 0)
            {
                for (int i = 0; i <= dgEncoding.Rows.Count - 1; i++)
                {
                    dgEncoding.Rows[i].Height = 24;
                }
            }
        }

        private async Task PopulateEncoding(IEnumerable<CardEncodingModel> items)
        {
            dgEncoding.Rows.Clear();
            if (items.Count() > 0)
            {
                dgEncoding.Rows.Add(items.Count());
                this.CardEncodingItems = items.ToList();
            }

           await Task.Run(() =>
           {
               var row = 0;
               foreach (var item in items)
               {
                   dgEncoding[dtlId.Index, row].Value = item.Id;
                   dgEncoding[dtlNo.Index, row].Value = item.No;
                   dgEncoding[dtlTimeIn.Index, row].Value = item.TimeIn;
                   dgEncoding[dtlPlateNo.Index, row].Value = item.PlateNo;
                   dgEncoding[dtlTicketNo.Index, row].Value = item.TicketNumber;
                   row++;
               }
           });

        }

        private async void cbShowImages_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowImages.Checked)
            {
                if (CardEncodingItems != null)
                {
                    if (CardEncodingItems.Count() > 0)
                    {
                        await Spinner.ShowSpinnerAsync(this, ShowImages());
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
                dgEncoding.Columns[dtlEntranceImage.Index].Visible = false;
                dgEncoding.Columns[dtlExitImage.Index].Visible = false;
                HideImage();
            }
        }

        private void dgEncoding_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (e.ColumnIndex == dtlView.Index)
            {
                var id = dgEncoding[dtlId.Index, e.RowIndex].Value.ToString();
                ImageViewer.ShowImage(int.Parse(id));
            }
        }

        private void dgEncoding_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                if (dgEncoding.CurrentRow.Index >= 0)
                {
                    if (UserAccess.CanEdit)
                    {
                        var current = dgEncoding.CurrentRow.Index;
                        var id = dgEncoding[dtlId.Index, current].Value.ToString();
                        var plateno = dgEncoding[dtlPlateNo.Index, current].Value.ToString();
                        bool success = false;
                        var newPlate = PlateNoUpdater.Update(ref success, id, plateno);
                        if (success)
                        {
                            dgEncoding[dtlPlateNo.Index, current].Value = newPlate;
                        }
                        dgEncoding.Rows[current].Cells[dtlPlateNo.Index].Selected = true;
                    }
                }

            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgEncoding.Rows.Count < 0)
                return;
            var key = Finder.SearchResult();
            dgEncoding.FindValue(key);
        }
    }
}
