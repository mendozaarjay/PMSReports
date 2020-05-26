
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Reports.Reports
{
    public partial class Viewer : Form
    {
        public DataTable Source { get; set; }
        public ReportType ReportType { get; set; }
        public Viewer()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
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
            }
            this.mReportViewer.RefreshReport();
            base.OnLoad(e);
        }
    }
}
