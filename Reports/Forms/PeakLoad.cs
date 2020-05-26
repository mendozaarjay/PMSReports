﻿using Reports.Models;
using Reports.Reports;
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
    public partial class PeakLoad : Form
    {
        private PeakLoadServices services = new PeakLoadServices();
        public PeakLoad()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            base.OnLoad(e);
        }
        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            var items = await services.PeakLoadReportAsync(dtDate.Value);
            PopulatePeakLoadReport(items);
            btnGenerate.Enabled = true;
        }

        private void PopulatePeakLoadReport(IEnumerable<PeakLoadModel> items)
        {
            dgPeakLoad.Rows.Clear();
            if (items.Count() > 0)
                dgPeakLoad.Rows.Add(items.Count());
            var row = 0;

            foreach (var item in items)
            {
                dgPeakLoad[dtlRow.Index, row].Value = item.Row;
                dgPeakLoad[dtlDuration.Index, row].Value = item.Duration;
                dgPeakLoad[dtlGrossIn.Index, row].Value = item.GrossIn;
                dgPeakLoad[dtlCancel.Index, row].Value = item.Cancel;
                dgPeakLoad[dtlNetIn.Index, row].Value = item.NetIn;
                dgPeakLoad[dtlInPercentage.Index, row].Value = item.InPercentage;
                dgPeakLoad[dtlNetOut.Index, row].Value = item.NetOut;
                dgPeakLoad[dtlOutPercentage.Index, row].Value = item.OutPercentage;
                dgPeakLoad[dtlAmount.Index, row].Value = item.Amount;
                row++;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            btnGenerate_Click(null, null);
            btnRefresh.Enabled = true;
        }

        private async void btnCsv_Click(object sender, EventArgs e)
        {
            var dt = await services.PeakLoadReportDataTableAsync(dtDate.Value);

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Peak Load Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            var dt = await services.PeakLoadReportDataTableAsync(dtDate.Value);

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Peak Load Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToExcel(dt, "Peak Load Report", sd.FileName);
            }
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            var items = await services.PeakLoadReportDataTableAsync(dtDate.Value);
            items.TableName = "PeakLoad";
            var viewer = new Viewer();
            viewer.ReportType = ReportType.PeakLoad;
            viewer.Source = items;
            viewer.ShowDialog();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgPeakLoad.Rows.Count < 0)
                return;
            var key = Finder.SearchResult();
            dgPeakLoad.FindValue(key);
        }
    }
}