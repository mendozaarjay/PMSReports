using DocumentFormat.OpenXml.Office.CustomUI;
using Reports.Models;
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
    public partial class CardEncoding : Form
    {
        private CardEncodingServices services = new CardEncodingServices();
        private List<CardEncodingModel> CardEncodingItems { get; set; }
        public CardEncoding()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            dgEncoding.Columns[dtlImage.Index].Visible = false;
            CheckForIllegalCrossThreadCalls = false;
            base.OnLoad(e);
        }
        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            var items = await services.CardEncodingAsync(dtDate.Value.Maximum(), txtSearch.Text);
            PopulateEncoding(items);
            if(cbShowImages.Checked)
            {
                await ShowImages();
            }
            btnGenerate.Enabled = true;
        }

        private async Task ShowImages()
        {
            dgEncoding.Columns[dtlImage.Index].Visible = true;
            if (dgEncoding.Rows.Count > 0)
            {
                for (int i = 0; i <= dgEncoding.Rows.Count - 1; i++)
                {
                    await Task.Run(() =>
                    {
                        var item = CardEncodingItems.FirstOrDefault(a => a.Id.ToString() == dgEncoding[dtlId.Index, i].Value.ToString());
                        dgEncoding.Columns[dtlImage.Index].Width = 150;

                        if (item.EntranceImage != null)
                        {

                            var entranceImage = ImageHelper.ConvertByteToImage(item.EntranceImage);
                            var col = new DataGridViewImageCell();
                            col.Value = entranceImage;
                            col.ImageLayout = DataGridViewImageCellLayout.Stretch;
                            dgEncoding[dtlImage.Index, i] = col;
                            dgEncoding.Rows[i].Height = 150;
                            dgEncoding[dtlImage.Index, i].ReadOnly = true;
                        }
                        else
                        {
                            var col = new DataGridViewTextBoxCell();
                            col.Value = string.Empty;

                            dgEncoding[dtlImage.Index, i] = col;
                            dgEncoding.Rows[i].Height = 24;
                            dgEncoding[dtlImage.Index, i].ReadOnly = true;
                        }

                    });


                }
            }
        }
        private void HideImage()
        {
            dgEncoding.Columns[dtlImage.Index].Visible = false;
            if (dgEncoding.Rows.Count > 0)
            {
                for (int i = 0; i <= dgEncoding.Rows.Count - 1; i++)
                {
                    dgEncoding.Rows[i].Height = 24;
                }
            }
        }

        private void PopulateEncoding(IEnumerable<CardEncodingModel> items)
        {
            dgEncoding.Rows.Clear();
            if (items.Count() > 0)
            {
                dgEncoding.Rows.Add(items.Count());
                this.CardEncodingItems = items.ToList();
            }
            var row = 0;
            foreach(var item in items)
            {
                dgEncoding[dtlId.Index, row].Value = item.Id;
                dgEncoding[dtlNo.Index, row].Value = item.No;
                dgEncoding[dtlTimeIn.Index, row].Value = item.TimeIn;
                dgEncoding[dtlPlateNo.Index, row].Value = item.PlateNo;
                dgEncoding[dtlTicketNo.Index, row].Value = item.TicketNumber;
                dgEncoding[dtlOrNo.Index, row].Value = item.ORNumber;
                dgEncoding[dtlRate.Index, row].Value = item.Rate;
                row++;
            }
            
        }

        private async void cbShowImages_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowImages.Checked)
            {
                if (CardEncodingItems != null)
                {
                    if (CardEncodingItems.Count() > 0)
                    {
                        await ShowImages();
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
                dgEncoding.Columns[dtlImage.Index].Visible = false;
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
            if(e.KeyCode.ToString() == "Return")
            {
                if(dgEncoding.CurrentRow.Index >= 0)
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgEncoding.Rows.Count < 0)
                return;
            var key = Finder.SearchResult();
            dgEncoding.FindValue(key);
        }
    }
}
