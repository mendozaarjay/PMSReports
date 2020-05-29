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
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private bool IsAlreadyOpen(string formname)
        {
            FormCollection formCollection = Application.OpenForms;
            foreach (Form item in formCollection)
            {
                if (item.Name.ToLower().Equals(formname.ToLower()))
                {
                    item.Focus();
                    return true;
                }
            }
            return false;
        }

       

        private void historyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!IsAlreadyOpen("History"))
            {
                History frm = new History();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void shiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsAlreadyOpen("Shift"))
            {
                Shift frm = new Shift();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsAlreadyOpen("Sales"))
            {
                Sales frm = new Sales();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void detailedTransactionSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsAlreadyOpen("DetailedTransactionSummary"))
            {
                DetailedTransactionSummary frm = new DetailedTransactionSummary();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void lengthOfStayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsAlreadyOpen("LengthOfStay"))
            {
                LengthOfStay frm = new LengthOfStay();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void operationOccupancyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsAlreadyOpen("OperationOccupancy"))
            {
                OperationOccupancy frm = new OperationOccupancy();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void peakLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsAlreadyOpen("PeakLoad"))
            {
                PeakLoad frm = new PeakLoad();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void remainingCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsAlreadyOpen("RemainingCars"))
            {
                RemainingCars frm = new RemainingCars();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void zReadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!IsAlreadyOpen("RemainingCars"))
            //{
            //    RemainingCars frm = new RemainingCars();
            //    frm.MdiParent = this;
            //    frm.WindowState = FormWindowState.Maximized;
            //    frm.Show();
            //}
        }

        private void bIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsAlreadyOpen("BIR"))
            {
                BIR frm = new BIR();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }
    }
}
