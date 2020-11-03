
using Microsoft.Reporting.WinForms;
using Reports.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Reports.Reports
{
    public partial class Viewer : Form
    {
        private GeneralSettingsServices services = new GeneralSettingsServices();
        public bool IsMultipleSource { get; set; } = false;
        public IEnumerable<DataTable> ReportSources { get; set; }
        public DataTable Source { get; set; }
        public ReportType ReportType { get; set; }
        public string DateCovered { get; set; }
        public string PrintDate { get; set; }
        public Viewer()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            var settings = services.GetSettings();
            if (!IsMultipleSource)
            {
                ReportDataSource dataSource = new ReportDataSource("Reports", Source);
                dataSource.Name = "dsSource";
                mReportViewer.LocalReport.DataSources.Add(dataSource);
            }
            else
            {
                foreach(var item in ReportSources)
                {
                    ReportDataSource dataSource = new ReportDataSource("Reports", item);
                    dataSource.Name = item.TableName;
                    mReportViewer.LocalReport.DataSources.Add(dataSource);
                }
            }
            switch (ReportType)
            {
                case ReportType.History:
                    mReportViewer.LocalReport.ReportEmbeddedResource = "Reports.Reports.HistoryReport.rdlc";
                    this.Text = "History Report";
                    break;
                case ReportType.Sales:
                    mReportViewer.LocalReport.ReportEmbeddedResource = "Reports.Reports.SalesReport.rdlc";
                    this.Text = "Sales Report";
                    break;
                case ReportType.BIR:
                    mReportViewer.LocalReport.ReportEmbeddedResource = "Reports.Reports.BIRReport.rdlc";
                    this.Text = "BIR Report";
                    break;
                case ReportType.DetailedTransactionSummaryReport:
                    mReportViewer.LocalReport.ReportEmbeddedResource = "Reports.Reports.DetailedTransactionSummaryReport.rdlc";
                    this.Text = "Detailed Transaction Summary Report";
                    break;
                case ReportType.LengthOfStay:
                    mReportViewer.LocalReport.ReportEmbeddedResource = "Reports.Reports.LengthOfStayReport.rdlc";
                    this.Text = "Length Of Stay Report";
                    break;
                case ReportType.RemainingCars:
                    mReportViewer.LocalReport.ReportEmbeddedResource = "Reports.Reports.RemainingCarsReport.rdlc";
                    this.Text = "Remaining Cars Report";
                    break;
                case ReportType.PeakLoad:
                    mReportViewer.LocalReport.ReportEmbeddedResource = "Reports.Reports.PeakLoadReport.rdlc";
                    this.Text = "Peak Load Report";
                    break;
                case ReportType.HourlyAccountability:
                    mReportViewer.LocalReport.ReportEmbeddedResource = "Reports.Reports.HourlyAccountabilityReport.rdlc";
                    this.Text = "Hourly Accountability Report";
                    break;
                case ReportType.OperationOccupancy:
                    mReportViewer.LocalReport.ReportEmbeddedResource = "Reports.Reports.OperationOccupancyReport.rdlc";
                    this.Text = "Operation Occupancy Report";
                    break;
                case ReportType.Shift:
                    mReportViewer.LocalReport.ReportEmbeddedResource = "Reports.Reports.ShiftReport.rdlc";
                    this.Text = "Shift Report";
                    break;
                case ReportType.CashierAccountability:
                    mReportViewer.LocalReport.ReportEmbeddedResource = "Reports.Reports.CashierAccountabilityReport.rdlc";
                    this.Text = "Cashier Accountability Report";
                    break;
                case ReportType.OperationHourlyAccountability:
                    mReportViewer.LocalReport.ReportEmbeddedResource = "Reports.Reports.OperationHourlyAccountabilityReport.rdlc";
                    this.Text = "Operation Hourly Accountability Report";
                    break;
                case ReportType.AuditPerCashier:
                    mReportViewer.LocalReport.ReportEmbeddedResource = "Reports.Reports.AuditPerCashierReport.rdlc";
                    this.Text = "Audit Per Cashier Report";
                    break;
                case ReportType.AuditPerTerminal:
                    mReportViewer.LocalReport.ReportEmbeddedResource = "Reports.Reports.AuditPerTerminalReport.rdlc";
                    this.Text = "Audit Per Terminal Report";
                    break;
                case ReportType.SummaryReportPerTerminal:
                    mReportViewer.LocalReport.ReportEmbeddedResource = "Reports.Reports.SummaryReportPerTerminalReport.rdlc";
                    this.Text = "Summary Report Per Terminal";
                    break;
                case ReportType.ZReading:
                    mReportViewer.LocalReport.ReportEmbeddedResource = "Reports.Reports.ZReadingReport.rdlc";
                    this.Text = "ZReading Report";
                    break;
                case ReportType.UserAccessMatrix:
                    mReportViewer.LocalReport.ReportEmbeddedResource = "Reports.Reports.UserAccessMatrixReport.rdlc";
                    this.Text = "User Access Matrix Report";
                    break;
                case ReportType.CardClearing:
                    mReportViewer.LocalReport.ReportEmbeddedResource = "Reports.Reports.CardClearingReport.rdlc";
                    this.Text = "Card Clearing Report";
                    break;
            }
            

            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("Company", settings.Company));
            parameters.Add(new ReportParameter("TIN", settings.TIN));
            parameters.Add(new ReportParameter("Address", settings.Address));

            if(ReportType == ReportType.AuditPerCashier)
            {
                parameters.Add(new ReportParameter("PrintDate", this.PrintDate));
            }

            parameters.Add(new ReportParameter("ProgramAndVersion", Properties.Settings.Default.ProgramVersion));
            parameters.Add(new ReportParameter("Serial", Properties.Settings.Default.SN));
            parameters.Add(new ReportParameter("Min", Properties.Settings.Default.MIN));
            parameters.Add(new ReportParameter("DateCovered", this.DateCovered));
            parameters.Add(new ReportParameter("Username", Properties.Settings.Default.Username));
            mReportViewer.LocalReport.SetParameters(parameters);

            this.mReportViewer.RefreshReport();
            base.OnLoad(e);
        }
    }
}
