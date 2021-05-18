using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Reports.Crystal;
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
    public partial class CrystalViewer : Form
    {
        public ReportType ReportType { get; set; }
        public DataTable DataSource { get; set; }
        public string DateCovered { get; set; }

        private DetailedTransactionSummaryServices testService = new DetailedTransactionSummaryServices();
        public CrystalViewer()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            ShowReport();
            base.OnLoad(e);
        }
        private GeneralSettingsServices services = new GeneralSettingsServices();
        private ReportDocument ReportDocument { get; set; }
        private void ShowReport()
        {
            var settings = services.GetSettings();
            switch (ReportType)
            {
                case ReportType.History:
                    HistoryCrystalReport report = new HistoryCrystalReport();
                    report.SetDataSource(DataSource);
                    viewer.ReportSource = report;
                    report.DataDefinition.FormulaFields["Company"].Text = FormulaFieldBuilder(settings.Company);
                    report.DataDefinition.FormulaFields["Address"].Text = FormulaFieldBuilder(settings.Address);
                    report.DataDefinition.FormulaFields["TIN"].Text = FormulaFieldBuilder(settings.TIN);
                    report.DataDefinition.FormulaFields["ProgramAndVersion"].Text = FormulaFieldBuilder(Properties.Settings.Default.ProgramVersion);
                    report.DataDefinition.FormulaFields["Serial"].Text = FormulaFieldBuilder(Properties.Settings.Default.SN);
                    report.DataDefinition.FormulaFields["Min"].Text = FormulaFieldBuilder(Properties.Settings.Default.MIN);
                    report.DataDefinition.FormulaFields["DateCovered"].Text = FormulaFieldBuilder(this.DateCovered);
                    report.DataDefinition.FormulaFields["Username"].Text = FormulaFieldBuilder(Properties.Settings.Default.Username);
                    ReportDocument = report;
                    this.Text = "History Report";
                    break;
                case ReportType.DetailedTransactionSummaryReport:
                    DetailedTransactionCrystalReport detailedreport = new DetailedTransactionCrystalReport();
                    detailedreport.SetDataSource(DataSource);
                    viewer.ReportSource = detailedreport;
                    detailedreport.DataDefinition.FormulaFields["Company"].Text = FormulaFieldBuilder(settings.Company);
                    detailedreport.DataDefinition.FormulaFields["Address"].Text = FormulaFieldBuilder(settings.Address);
                    detailedreport.DataDefinition.FormulaFields["TIN"].Text = FormulaFieldBuilder(settings.TIN);
                    detailedreport.DataDefinition.FormulaFields["ProgramAndVersion"].Text = FormulaFieldBuilder(Properties.Settings.Default.ProgramVersion);
                    detailedreport.DataDefinition.FormulaFields["Serial"].Text = FormulaFieldBuilder(Properties.Settings.Default.SN);
                    detailedreport.DataDefinition.FormulaFields["Min"].Text = FormulaFieldBuilder(Properties.Settings.Default.MIN);
                    detailedreport.DataDefinition.FormulaFields["DateCovered"].Text = FormulaFieldBuilder(this.DateCovered);
                    detailedreport.DataDefinition.FormulaFields["Username"].Text = FormulaFieldBuilder(Properties.Settings.Default.Username);
                    ReportDocument = detailedreport;
                    break;
                case ReportType.Sales:
                    SalesCrystalReport salesreport = new SalesCrystalReport();
                    salesreport.SetDataSource(DataSource);
                    viewer.ReportSource = salesreport;
                    salesreport.DataDefinition.FormulaFields["Company"].Text = FormulaFieldBuilder(settings.Company);
                    salesreport.DataDefinition.FormulaFields["Address"].Text = FormulaFieldBuilder(settings.Address);
                    salesreport.DataDefinition.FormulaFields["TIN"].Text = FormulaFieldBuilder(settings.TIN);
                    salesreport.DataDefinition.FormulaFields["ProgramAndVersion"].Text = FormulaFieldBuilder(Properties.Settings.Default.ProgramVersion);
                    salesreport.DataDefinition.FormulaFields["Serial"].Text = FormulaFieldBuilder(Properties.Settings.Default.SN);
                    salesreport.DataDefinition.FormulaFields["Min"].Text = FormulaFieldBuilder(Properties.Settings.Default.MIN);
                    salesreport.DataDefinition.FormulaFields["DateCovered"].Text = FormulaFieldBuilder(this.DateCovered);
                    salesreport.DataDefinition.FormulaFields["Username"].Text = FormulaFieldBuilder(Properties.Settings.Default.Username);
                    ReportDocument = salesreport;
                    break;
                case ReportType.CashlessReport:
                    CashlessCrystalReport cashless = new CashlessCrystalReport();
                    cashless.SetDataSource(DataSource);
                    viewer.ReportSource = cashless;
                    cashless.DataDefinition.FormulaFields["Company"].Text = FormulaFieldBuilder(settings.Company);
                    cashless.DataDefinition.FormulaFields["Address"].Text = FormulaFieldBuilder(settings.Address);
                    cashless.DataDefinition.FormulaFields["TIN"].Text = FormulaFieldBuilder(settings.TIN);
                    cashless.DataDefinition.FormulaFields["ProgramAndVersion"].Text = FormulaFieldBuilder(Properties.Settings.Default.ProgramVersion);
                    cashless.DataDefinition.FormulaFields["Serial"].Text = FormulaFieldBuilder(Properties.Settings.Default.SN);
                    cashless.DataDefinition.FormulaFields["Min"].Text = FormulaFieldBuilder(Properties.Settings.Default.MIN);
                    cashless.DataDefinition.FormulaFields["DateCovered"].Text = FormulaFieldBuilder(this.DateCovered);
                    cashless.DataDefinition.FormulaFields["Username"].Text = FormulaFieldBuilder(Properties.Settings.Default.Username);
                    ReportDocument = cashless;
                    break;
                case ReportType.RegularParker:
                    RegularParkerReport regular = new RegularParkerReport();
                    regular.SetDataSource(DataSource);
                    viewer.ReportSource = regular;
                    regular.DataDefinition.FormulaFields["Company"].Text = FormulaFieldBuilder(settings.Company);
                    regular.DataDefinition.FormulaFields["Address"].Text = FormulaFieldBuilder(settings.Address);
                    regular.DataDefinition.FormulaFields["TIN"].Text = FormulaFieldBuilder(settings.TIN);
                    regular.DataDefinition.FormulaFields["ProgramAndVersion"].Text = FormulaFieldBuilder(Properties.Settings.Default.ProgramVersion);
                    regular.DataDefinition.FormulaFields["Serial"].Text = FormulaFieldBuilder(Properties.Settings.Default.SN);
                    regular.DataDefinition.FormulaFields["Min"].Text = FormulaFieldBuilder(Properties.Settings.Default.MIN);
                    regular.DataDefinition.FormulaFields["DateCovered"].Text = FormulaFieldBuilder(this.DateCovered);
                    regular.DataDefinition.FormulaFields["Username"].Text = FormulaFieldBuilder(Properties.Settings.Default.Username);
                    ReportDocument = regular;
                    break;
                case ReportType.AuditTrail:
                    AuditTrailReport audit = new AuditTrailReport();
                    audit.SetDataSource(DataSource);
                    viewer.ReportSource = audit;
                    audit.DataDefinition.FormulaFields["Company"].Text = FormulaFieldBuilder(settings.Company);
                    audit.DataDefinition.FormulaFields["Address"].Text = FormulaFieldBuilder(settings.Address);
                    audit.DataDefinition.FormulaFields["TIN"].Text = FormulaFieldBuilder(settings.TIN);
                    audit.DataDefinition.FormulaFields["ProgramAndVersion"].Text = FormulaFieldBuilder(Properties.Settings.Default.ProgramVersion);
                    audit.DataDefinition.FormulaFields["Serial"].Text = FormulaFieldBuilder(Properties.Settings.Default.SN);
                    audit.DataDefinition.FormulaFields["Min"].Text = FormulaFieldBuilder(Properties.Settings.Default.MIN);
                    audit.DataDefinition.FormulaFields["DateCovered"].Text = FormulaFieldBuilder(this.DateCovered);
                    audit.DataDefinition.FormulaFields["Username"].Text = FormulaFieldBuilder(Properties.Settings.Default.Username);
                    ReportDocument = audit;
                    break;
            }
            viewer.Show();
            viewer.RefreshReport();
        }
        private string FormulaFieldBuilder(string value)
        {
            var item = $"'{value}'";
            return item;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog fd = new SaveFileDialog();
                fd.Filter = "PDF Files(*.pdf) | *.pdf";
                fd.Title = "Save PDF File";
                var reportName = string.Empty;
                this.Enabled = false;
                switch (ReportType)
                {
                    case ReportType.History:
                        reportName = "History Report.pdf";
                        fd.FileName = reportName;
                        fd.ShowDialog();
                        ReportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, fd.FileName);
                        break;
                    case ReportType.Sales:
                        reportName = "Sales Report.pdf";
                        fd.FileName = reportName;
                        fd.ShowDialog();
                        ReportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, fd.FileName);
                        break;
                    case ReportType.DetailedTransactionSummaryReport:
                        reportName = "Detailed Transaction Summary Report.pdf";
                        fd.FileName = reportName;
                        fd.ShowDialog();
                        ReportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, fd.FileName);
                        break;
                    case ReportType.CashlessReport:
                        reportName = "Cashless Report.pdf";
                        fd.FileName = reportName;
                        fd.ShowDialog();
                        ReportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, fd.FileName);
                        break;
                    case ReportType.RegularParker:
                        reportName = "Regular Parker Report.pdf";
                        fd.FileName = reportName;
                        fd.ShowDialog();
                        ReportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, fd.FileName);
                        break;
                    case ReportType.AuditTrail:
                        reportName = "Audit Trail Report.pdf";
                        fd.FileName = reportName;
                        fd.ShowDialog();
                        ReportDocument.ExportToDisk(ExportFormatType.PortableDocFormat, fd.FileName);
                        break;
                }
                MessageBox.Show("Process has been successfully completed.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
            }
        }
    }
}
