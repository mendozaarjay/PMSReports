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
    public partial class ImageViewerForm : Form
    {
        public int TransitId { get; set; }
        private ImageServices services = new ImageServices();
        public ImageViewerForm()
        {
            InitializeComponent();
        }
        protected override async void OnLoad(EventArgs e)
        {
            var dt = await services.GetTransactionImages(this.TransitId);
            if(dt.Rows.Count > 0)
            {
                var entraneImage1 = dt.Rows[0]["EntranceImage1"];
                var entraneImage2 = dt.Rows[0]["EntranceImage2"];
                var posImage = dt.Rows[0]["PosImage1"];
                var exitImage1 = dt.Rows[0]["ExitImage1"];
                var exitImage2 = dt.Rows[0]["ExitImage2"];

                if(entraneImage1.ToString().Length > 0)
                {
                    var image = ImageHelper.ConvertByteToImage((byte[])entraneImage1);
                    pbEntranceImage1.Image = image;
                }
                if (entraneImage2.ToString().Length > 0)
                {
                    var image = ImageHelper.ConvertByteToImage((byte[])entraneImage2);
                    pbEntranceImage2.Image = image;
                }
                if (posImage.ToString().Length > 0)
                {
                    var image = ImageHelper.ConvertByteToImage((byte[])posImage);
                    pbPOSImage.Image = image;
                }
                if (exitImage1.ToString().Length > 0)
                {
                    var image = ImageHelper.ConvertByteToImage((byte[])exitImage1);
                    pbExitImage1.Image = image;
                }
                if (exitImage2.ToString().Length > 0)
                {
                    var image = ImageHelper.ConvertByteToImage((byte[])exitImage2);
                    pbExitImage2.Image = image;
                }

            }
            base.OnLoad(e);
        }

        private void pbEntranceImage1_DoubleClick(object sender, EventArgs e)
        {
            if(pbEntranceImage1.Image != null)
            {
                ImageZommer frm = new ImageZommer();
                frm.ImageToZoom = pbEntranceImage1.Image;
                frm.ShowDialog();
            }
        }

        private void pbEntranceImage2_DoubleClick(object sender, EventArgs e)
        {
            if (pbEntranceImage2.Image != null)
            {
                ImageZommer frm = new ImageZommer();
                frm.ImageToZoom = pbEntranceImage2.Image;
                frm.ShowDialog();
            }
        }

        private void pbPOSImage_DoubleClick(object sender, EventArgs e)
        {
            if (pbPOSImage.Image != null)
            {
                ImageZommer frm = new ImageZommer();
                frm.ImageToZoom = pbPOSImage.Image;
                frm.ShowDialog();
            }
        }

        private void pbExitImage1_DoubleClick(object sender, EventArgs e)
        {
            if (pbExitImage1.Image != null)
            {
                ImageZommer frm = new ImageZommer();
                frm.ImageToZoom = pbExitImage1.Image;
                frm.ShowDialog();
            }
        }

        private void pbExitImage2_DoubleClick(object sender, EventArgs e)
        {
            if (pbExitImage2.Image != null)
            {
                ImageZommer frm = new ImageZommer();
                frm.ImageToZoom = pbExitImage2.Image;
                frm.ShowDialog();
            }
        }
    }
}
