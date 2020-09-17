using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports
{
    public partial class cSpinner : UserControl
    {
        public cSpinner()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            this.Width = 150;
            this.Height = 150;
            base.OnLoad(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.Width = 150;
            this.Height = 150;
            base.OnPaint(e);
        }
        protected override void OnResize(EventArgs e)
        {
            this.Width = 150;
            this.Height = 150;
            base.OnResize(e);
        }
    }
}
