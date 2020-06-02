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
    public partial class OperationHourlyAccountability : Form
    {
        private OperationHourlyAccountabilityServices services = new OperationHourlyAccountabilityServices();
        public OperationHourlyAccountability()
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
            var items = await services.OperationHourlyAccountabilityAsync(dtDate.Value);
            LoadOperationHourlyAccountability(items);
            btnGenerate.Enabled = true;
        }

        private void LoadOperationHourlyAccountability(IEnumerable<OperationHourlyAccountabilityModel> items)
        {
            dgOperation.Rows.Clear();
            if (items.Count() > 0)
                dgOperation.Rows.Add(items.Count());
            var row = 0;
            foreach(var item in items)
            {
                dgOperation[dtlDuration.Index, row].Value = item.DurationHours;
                dgOperation[dtlNumberOfVehicles.Index, row].Value = item.NumberOfVehicles;
                dgOperation[dtlAmount.Index, row].Value = item.Amount;
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
            var dt = await services.OperationHourlyAccountabilityDataTableAsync(dtDate.Value);

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Operation Hourly Accountability Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            var dt = await services.OperationHourlyAccountabilityDataTableAsync(dtDate.Value);
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Operation Hourly Accountability Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToExcel(dt, "Operation Hourly Accountability Report", sd.FileName);
            }
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            var items = await services.OperationHourlyAccountabilityDataTableAsync(dtDate.Value);
            items.TableName = "OperationHourlyAccountability";
            var viewer = new Viewer();
            viewer.ReportType = ReportType.OperationHourlyAccountability;
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
