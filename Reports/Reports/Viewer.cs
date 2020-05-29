
using Microsoft.Reporting.WinForms;
using Reports.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace Reports.Reports
{
    public partial class Viewer : Form
    {
        private GeneralSettingsServices services = new GeneralSettingsServices();
        public DataTable Source { get; set; }
        public ReportType ReportType { get; set; }
        public Viewer()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            var settings = services.GetSettings();

            ReportDataSource dataSource = new ReportDataSource("Reports", Source);
            
            dataSource.Name = "dsSource";
            mReportViewer.LocalReport.DataSources.Add(dataSource);




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
            }

            ReportParameterCollection parameters = new ReportParameterCollection();
            parameters.Add(new ReportParameter("Company", settings.Company));
            parameters.Add(new ReportParameter("TIN", settings.TIN));
            parameters.Add(new ReportParameter("Address", settings.Address));
            mReportViewer.LocalReport.SetParameters(parameters);

            this.mReportViewer.RefreshReport();
            base.OnLoad(e);
        }
    }
}
