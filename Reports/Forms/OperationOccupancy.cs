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
    public partial class OperationOccupancy : Form
    {
        private OperationOccupancyServices services = new OperationOccupancyServices();
        public OperationOccupancy()
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
            var items = await services.OperationOccupancyReportAsync(dtDate.Value);
            PopulateOperationOccupancy(items);
            btnGenerate.Enabled = true;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            btnGenerate_Click(null, null);
            btnRefresh.Enabled = true;
        }
        private void PopulateOperationOccupancy(IEnumerable<OperationOccupancyModel> items)
        {
            dgOperation.Rows.Clear();
            if (items.Count() > 0)
                dgOperation.Rows.Add(items.Count());

            var row = 0;
            foreach (var item in items)
            {
                dgOperation[dtlDurationHours.Index, row].Value = item.DurationHours;
                dgOperation[dtlIn.Index, row].Value = item.In;
                dgOperation[dtlOut.Index, row].Value = item.Out;
                dgOperation[dtlRemaining.Index, row].Value = item.Remaining;
                row++;
            }
        }

        private async void btnCsv_Click(object sender, EventArgs e)
        {
            var dt = await services.OperationOccupancyReportDataTableAsync(dtDate.Value);

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Operation Occupancy Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            var dt = await services.OperationOccupancyReportDataTableAsync(dtDate.Value);

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Operation Occupancy Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToExcel(dt, "Operation Occupancy Report", sd.FileName);
            }
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            var items = await services.OperationOccupancyReportDataTableAsync(dtDate.Value);
            items.TableName = "OperationOccupancy";
            var viewer = new Viewer();
            viewer.ReportType = ReportType.OperationOccupancy;
            viewer.Source = items;
            viewer.ShowDialog();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgOperation.Rows.Count < 0)
                return;
            var key = Finder.SearchResult();
            dgOperation.FindValue(key);
        }
    }
}