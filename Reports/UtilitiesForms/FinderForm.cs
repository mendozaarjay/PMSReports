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
    public partial class FinderForm : Form
    {
        public string SearchResult { get; set; } = string.Empty;
        public FinderForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            txtSearchKey.Focus();
            base.OnLoad(e);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SearchResult = txtSearchKey.Text;
            this.Close();
        }
    }
}
