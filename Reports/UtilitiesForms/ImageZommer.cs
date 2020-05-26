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
    public partial class ImageZommer : Form
    {
        public Image ImageToZoom { get; set; }
        public ImageZommer()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            this.pbImage.Image = ImageToZoom;
            base.OnLoad(e);
        }
    }
}
