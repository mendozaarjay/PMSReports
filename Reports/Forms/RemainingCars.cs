﻿using Reports.Models;
using Reports.Reports;
using Reports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UserAccess.Models;

namespace Reports
{
    public partial class RemainingCars : Form
    {
        RemainingCarsServices services = new RemainingCarsServices();
        public UserAccessItem UserAccess { get; set; }
        public RemainingCars()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            LoadAccess();
            base.OnLoad(e);
        }
        private void LoadAccess()
        {
            btnPrint.Visible = UserAccess.CanPrint;
            btnExcel.Visible = btnCsv.Visible = UserAccess.CanExport;
            btnRefresh.Enabled = btnGenerate.Enabled = UserAccess.CanAccess;
        }
        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            btnGenerate.Enabled = false;
            var items = await services.RemainingCarsAsync(dtDate.Value.Maximum());

            var regular = items.Where(a => a.ParkerType.ToLower().Contains("regular"));

            var visitor = items.Where(a => a.ParkerType.ToLower().Contains("visitor"));

            Spinner.ShowSpinner(this, () =>
            {
                PopulateRemainingCars(items);
                PopulateRegular(regular);
                PopulateVisitor(visitor);
            });
            btnGenerate.Enabled = true;
        }

        private void PopulateRemainingCars(IEnumerable<RemainingCarModel> items)
        {
            dgRemainingCars.Rows.Clear();
            if (items.Count() > 0)
                dgRemainingCars.Rows.Add(items.Count());

            var row = 0;

            foreach (var item in items)
            {
                dgRemainingCars[dtlAllNo.Index, row].Value = item.No;
                dgRemainingCars[dtlAllTimeIn.Index, row].Value = item.TimeIn;
                dgRemainingCars[dtlAllPlateNo.Index, row].Value = item.PlateNo;
                dgRemainingCars[dtlAllTicketNo.Index, row].Value = item.TicketNumber;
                dgRemainingCars[dtlAllRFIDName.Index, row].Value = item.RFIDName;
                dgRemainingCars[dtlAllRFIDNo.Index, row].Value = item.RFIDNumber;
                dgRemainingCars[dtlAllParkerType.Index, row].Value = item.ParkerType;
                row++;             
            }
            dgRemainingCars.AutoResizeColumns();
        }
        private void PopulateRegular(IEnumerable<RemainingCarModel> items)
        {
            dgRegular.Rows.Clear();
            if (items.Count() > 0)
                dgRegular.Rows.Add(items.Count());

            var row = 0;

            foreach (var item in items)
            {
                dgRegular[dtlRegularNo.Index, row].Value = row + 1;
                dgRegular[dtlRegularTimeIn.Index, row].Value = item.TimeIn;
                dgRegular[dtlRegularPlateNo.Index, row].Value = item.PlateNo;
                dgRegular[dtlRegularTicketNo.Index, row].Value = item.TicketNumber;
                dgRegular[dtlRegularRFIDName.Index, row].Value = item.RFIDName;
                dgRegular[dtlRegularRFIDNo.Index, row].Value = item.RFIDNumber;
                dgRegular[dtlRegularParkerType.Index, row].Value = item.ParkerType;
                row++;
            }
            dgRegular.AutoResizeColumns();
        }
        private void PopulateVisitor(IEnumerable<RemainingCarModel> items)
        {
            dgVisitor.Rows.Clear();
            if (items.Count() > 0)
                dgVisitor.Rows.Add(items.Count());

            var row = 0;

            foreach (var item in items)
            {
                dgVisitor[dtlAllNo.Index, row].Value = row + 1;
                dgVisitor[dtlAllTimeIn.Index, row].Value = item.TimeIn;
                dgVisitor[dtlAllPlateNo.Index, row].Value = item.PlateNo;
                dgVisitor[dtlAllTicketNo.Index, row].Value = item.TicketNumber;
                dgVisitor[dtlAllRFIDName.Index, row].Value = item.RFIDName;
                dgVisitor[dtlAllRFIDNo.Index, row].Value = item.RFIDNumber;
                dgVisitor[dtlAllParkerType.Index, row].Value = item.ParkerType;
                row++;
            }
            dgVisitor.AutoResizeColumns();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            btnGenerate_Click(null, null);
            btnRefresh.Enabled = true;
        }

        private async void btnCsv_Click(object sender, EventArgs e)
        {
            btnCsv.Enabled = false;
            var dt = await services.RemainingCarsDataTableAsync(dtDate.Value.Maximum());

            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV Files(*.csv) | *.csv";
            sd.Title = "Save Csv File";
            sd.FileName = "Remaining Cars Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                FileExport.ExportToCsv(dt, sd.FileName);
            }
            btnCsv.Enabled = true;
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            btnExcel.Enabled = false;
            var dt = await services.RemainingCarsDataTableAsync(dtDate.Value.Maximum());
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Excel File(.xlsx)|*.xlsx";
            sd.Title = "Save Excel File";
            sd.FileName = "Remaining Cars Report " + dtDate.Value.ToString("MMddyyyy");
            if (sd.ShowDialog() != DialogResult.Cancel)
            {
                ExportToExcelFile.Export(dt, sd.FileName);
            }
            btnExcel.Enabled = true;
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = false;
            var items = await services.RemainingCarsDataTableAsync(dtDate.Value.Maximum());
            items.TableName = "RemainingCars";
            var viewer = new Viewer();
            viewer.DateCovered = dtDate.Value.ToString("MM/dd/yyyy");
            viewer.ReportType = ReportType.RemainingCars;
            viewer.Source = items;
            viewer.ShowDialog();
            btnPrint.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (dgRemainingCars.Rows.Count < 0)
                return;
            var key = Finder.SearchResult();
            dgRemainingCars.FindValue(key);
        }
    }
}
