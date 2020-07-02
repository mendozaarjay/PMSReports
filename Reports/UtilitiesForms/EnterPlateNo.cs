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
    public partial class EnterPlateNo : Form
    {
        public string TransitId { get; set; }
        public string PlateNo { get; set; }
        public bool IsSuccess { get; set; }
        public EnterPlateNo()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            txtPlateNo.Text = PlateNo;
            base.OnLoad(e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.IsSuccess = false;
            this.Close();
        }
        private CardEncodingServices services = new CardEncodingServices();
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var result = await services.UpdatePlateNo(this.TransitId, txtPlateNo.Text);
            if (result.ToLower().Contains("success"))
            {
                this.PlateNo = txtPlateNo.Text;
                this.IsSuccess = true;
                this.Close();
            }
            else
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.IsSuccess = false;
                this.Close();
            }
        }
    }
}
