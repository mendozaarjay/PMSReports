using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
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
using UserAccess.Models;

namespace Reports
{
    public partial class MainFormNew : Form
    {
        DashboardServices services = new DashboardServices();
        public IEnumerable<UserAccessItem> UserAccessItems { get; set; }
        public MainFormNew()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            var items = UserAccess.Utilities.AccessMatrix.GetUserAccess(int.Parse(Properties.Settings.Default.CurrentUserId));
            UserAccessItems = items;
            LoadUserAccess();
            base.OnLoad(e);
        }

        #region User  Access
        private void LoadUserAccess()
        {
            LoadTransactionAccess();
            LoadAccountabilityAccess();
            LoadStatisticsAccess();
            LoadPeriodicAccess();
        }

        private void LoadTransactionAccess()
        {
            //Transactional
            var cardEncoding = UserAccessItems.Any(a => a.ModuleCode == "RCE" && a.CanAccess);
            var history = UserAccessItems.Any(a => a.ModuleCode == "RH" && a.CanAccess);
            var shift = UserAccessItems.Any(a => a.ModuleCode == "RSHIFT" && a.CanAccess);
            var sales = UserAccessItems.Any(a => a.ModuleCode == "RSALES" && a.CanAccess);
            var detailedTransaction = UserAccessItems.Any(a => a.ModuleCode == "RDTS" && a.CanAccess);
            if (cardEncoding || history || shift || sales || detailedTransaction)
                transactionReportsToolStripMenuItem.Visible = true;
            else
                transactionReportsToolStripMenuItem.Visible = false;

            cardEncodingToolStripMenuItem.Visible = cardEncoding;
            historyToolStripMenuItem.Visible = history;
            shiftToolStripMenuItem.Visible = shift;
            salesToolStripMenuItem.Visible = sales;
            detailedTransactionSummaryToolStripMenuItem.Visible = detailedTransaction;
        }
        private void LoadAccountabilityAccess()
        {
            var auditPerCashier = UserAccessItems.Any(a => a.ModuleCode == "RAPC" && a.CanAccess);
            var auditPerTerminal = UserAccessItems.Any(a => a.ModuleCode == "RAPT" && a.CanAccess);
            var cashierAccountability = UserAccessItems.Any(a => a.ModuleCode == "RCA" && a.CanAccess);
            var hourlyAccountabability = UserAccessItems.Any(a => a.ModuleCode == "RHA" && a.CanAccess);
            var operationHourly = UserAccessItems.Any(a => a.ModuleCode == "ROHA" && a.CanAccess);
            var summaryReport = UserAccessItems.Any(a => a.ModuleCode == "RSRPT" && a.CanAccess);
            var uam = UserAccessItems.Any(a => a.ModuleCode == "RUAM" && a.CanAccess);
            if (auditPerCashier || auditPerTerminal || cashierAccountability || hourlyAccountabability || operationHourly || summaryReport || uam)
                accoutabilityReportsToolStripMenuItem.Visible = true;
            else
                accoutabilityReportsToolStripMenuItem.Visible = false;


            auditPerCashierToolStripMenuItem.Visible = auditPerCashier;
            auditPerTerminalToolStripMenuItem.Visible = auditPerTerminal;
            cashierAccountabilityToolStripMenuItem.Visible = cashierAccountability;
            hourlyAccountabilityToolStripMenuItem.Visible = hourlyAccountabability;
            operationHourlyAccoutabilityToolStripMenuItem.Visible = operationHourly;
            summaryReportPerTerminalToolStripMenuItem.Visible = summaryReport;
            userAccessMatrixToolStripMenuItem.Visible = uam;
        }
        private void LoadStatisticsAccess()
        {
            var los = UserAccessItems.Any(a => a.ModuleCode == "RLOS" && a.CanAccess);
            var oo = UserAccessItems.Any(a => a.ModuleCode == "ROO" && a.CanAccess);
            var pl = UserAccessItems.Any(a => a.ModuleCode == "RPL" && a.CanAccess);
            var rc = UserAccessItems.Any(a => a.ModuleCode == "RRC" && a.CanAccess);
            if (los || oo || pl || rc)
                statisticsReportToolStripMenuItem.Visible = true;
            else
                statisticsReportToolStripMenuItem.Visible = false;

            lenghtOfStayToolStripMenuItem.Visible = los;
            operationOccupancyToolStripMenuItem.Visible = oo;
            peakLoadToolStripMenuItem.Visible = pl;
            remainingCarsToolStripMenuItem.Visible = rc;
        }
        private void LoadPeriodicAccess()
        {
            var bir = UserAccessItems.Any(a => a.ModuleCode == "RBIR" && a.CanAccess);
            var zr = UserAccessItems.Any(a => a.ModuleCode == "RZR" && a.CanAccess);
            if (bir || zr)
                periodicReportsToolStripMenuItem.Visible = true;
            else
                periodicReportsToolStripMenuItem.Visible = false;

            bIRToolStripMenuItem.Visible = bir;
            zReadingToolStripMenuItem.Visible = zr;
        } 
        #endregion
        protected  async override void OnShown(EventArgs e)
        {
            await LoadHourlyOccupancy();
            await LoadHeader();
            await LoadAvailableSlots();
            await LoadTickets();

            await LoadWeeklyOccupancy();
            await LoadWeeklySales();
            base.OnShown(e);

        }

        #region DashboardFunctions
        private async Task LoadTickets()
        {
            var processed = await services.ProcessedTicketsAsync(DateTime.Now);
            var issued = await services.IssuedTicketsAsync(DateTime.Now);

            Func<ChartPoint, string> labelPoint = chartPoint =>
             string.Format("{0} ({1:P})", chartPoint.Y.ToString(), chartPoint.Participation);

            cTickets.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Proccessed",
                    Values = new ChartValues<int>{processed},
                    PushOut = 1,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Issued",
                    Values = new ChartValues<int>{issued},
                    PushOut = 1,
                    DataLabels = true,
                    LabelPoint = labelPoint,
                }
            };
            cTickets.LegendLocation = LegendLocation.Bottom;
        }
        private async Task LoadHeader()
        {
            var sales = await services.TodaySalesAsync(DateTime.Now);
            lblTodaySales.Text = sales.ToString("C");
            var totalSales = await services.WeeklyTotalSalesAsync();
            lblWeeklySales.Text = totalSales.ToString("C");
            var remaining = await services.RemainingCarsAsync();
            lblRemaining.Text = remaining.ToString("N0");
        }
        private async Task LoadAvailableSlots()
        {
            var available = await services.AvailableSlotsAsync(DateTime.Now);
            var availed = await services.AvailedSlotsAsync(DateTime.Now);

            Func<ChartPoint, string> labelPoint = chartPoint =>
             string.Format("{0} ({1:P})", chartPoint.Y.ToString(), chartPoint.Participation);

            cAvailableSlots.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Available",
                    Values = new ChartValues<int>{available},
                    PushOut = 1,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = "Availed",
                    Values = new ChartValues<int>{availed},
                    PushOut = 1,
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };
            cAvailableSlots.LegendLocation = LegendLocation.Bottom;
        }
        private async Task LoadHourlyOccupancy()
        {
            cHourly.Visible = false;
            DataTable dt = await services.HourlyOccupancyAsync(DateTime.Now);
            if (dt != null)
            {
                cHourly.Series.Clear();
                cHourly.AxisX.Clear();
                cHourly.AxisY.Clear();

                var ins = new List<ObservableValue>();
                var outs = new List<ObservableValue>();
                string[] insLabel = new string[dt.Rows.Count];
                var i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    var inItem = new ObservableValue(double.Parse(dr["In"].ToString()));
                    var outItem = new ObservableValue(double.Parse(dr["Out"].ToString()));
                    insLabel[i] = dr["Time"].ToString();
                    ins.Add(inItem);
                    outs.Add(outItem);
                    i++;
                };

                cHourly.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Values = ins.AsChartValues(),
                        DataLabels = true,
                        LabelPoint = point => point.Y.ToString(),
                        Title = "In",
                    },
                    new LineSeries
                    {
                        Values = outs.AsChartValues(),
                        DataLabels = true,
                        LabelPoint = point => point.Y.ToString(),
                        Title = "Out"
                    }
                };
                cHourly.AxisX.Add(new Axis
                {
                    Labels = insLabel,
                    Separator = new Separator { Step = 1, IsEnabled = false },
                });
                cHourly.LegendLocation = LegendLocation.Right;
            }
            cHourly.Visible = true;
        }
        private async Task LoadWeeklyOccupancy()
        {
            cWeeklyOccupancy.Visible = false;
            DataTable dt = await services.WeeklyOccupancyAsync();
            if (dt != null)
            {
                cWeeklyOccupancy.Series.Clear();
                cWeeklyOccupancy.AxisX.Clear();
                cWeeklyOccupancy.AxisY.Clear();
                var ins = new List<ObservableValue>();
                var outs = new List<ObservableValue>();
                string[] insLabel = new string[dt.Rows.Count];
                var i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    var inItem = new ObservableValue(double.Parse(dr["In"].ToString()));
                    var outItem = new ObservableValue(double.Parse(dr["Out"].ToString()));
                    insLabel[i] = dr["Name"].ToString();
                    ins.Add(inItem);
                    outs.Add(outItem);
                    i++;
                };

                cWeeklyOccupancy.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Values = ins.AsChartValues(),
                        DataLabels = true,
                        LabelPoint = point => point.Y.ToString(),
                        Title = "In",
                    },
                    new LineSeries
                    {
                        Values = outs.AsChartValues(),
                        DataLabels = true,
                        LabelPoint = point => point.Y.ToString(),
                        Title = "Out"
                    }
                };
                cWeeklyOccupancy.AxisX.Add(new Axis
                {
                    Labels = insLabel,
                    Separator = new Separator { Step = 1, IsEnabled = false },
                });
                cWeeklyOccupancy.LegendLocation = LegendLocation.Right;
            }
            cWeeklyOccupancy.Visible = true;
        }
        private async Task LoadWeeklySales()
        {
            cWeeklySales.Visible = false;
            DataTable dt = await services.WeeklySalesAsync();
            if (dt != null)
            {
                cWeeklySales.Series.Clear();
                cWeeklySales.AxisX.Clear();
                cWeeklySales.AxisY.Clear();
                var sales = new List<ObservableValue>();
                string[] salesLabel = new string[dt.Rows.Count];
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    var item = new ObservableValue(double.Parse(dr["Sales"].ToString()));
                    salesLabel[i] = dr["Name"].ToString();
                    sales.Add(item);
                    i++;
                }
                cWeeklySales.Series = new SeriesCollection
                {
                    new ColumnSeries
                    {
                        Values = sales.AsChartValues(),
                        DataLabels = true,
                        LabelPoint = point => point.Y.ToString("C"),
                        Title = "Sales",
                    }
                };
                cWeeklySales.AxisX.Add(new Axis
                {
                    Labels = salesLabel,
                    Separator = new Separator { Step = 1, IsEnabled = false },
                });
                cWeeklySales.LegendLocation = LegendLocation.Right;
            }
            cWeeklySales.Visible = true;
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadHourlyOccupancy();
            await LoadHeader();
            await LoadAvailableSlots();
            await LoadTickets();

            await LoadWeeklyOccupancy();
            await LoadWeeklySales();
        }       
        #endregion

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History frm = new History();
            var item = UserAccessItems.FirstOrDefault(a => a.ModuleCode == "RH");
            frm.UserAccess = item;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void shiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shift frm = new Shift();
            var item = UserAccessItems.FirstOrDefault(a => a.ModuleCode == "RSHIFT");
            frm.UserAccess = item;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales frm = new Sales();
            var item = UserAccessItems.FirstOrDefault(a => a.ModuleCode == "RSALES");
            frm.UserAccess = item;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void detailedTransactionSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailedTransactionSummary frm = new DetailedTransactionSummary();
            var item = UserAccessItems.FirstOrDefault(a => a.ModuleCode == "RDTS");
            frm.UserAccess = item;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void auditPerCashierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuditPerCashier frm = new AuditPerCashier();
            var item = UserAccessItems.FirstOrDefault(a => a.ModuleCode == "RAPC");
            frm.UserAccess = item;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void auditPerTerminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuditPerTerminal frm = new AuditPerTerminal();
            var item = UserAccessItems.FirstOrDefault(a => a.ModuleCode == "RAPT");
            frm.UserAccess = item;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void cashierAccountabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashierAccountability frm = new CashierAccountability();
            var item = UserAccessItems.FirstOrDefault(a => a.ModuleCode == "RCA");
            frm.UserAccess = item;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void hourlyAccountabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HourlyAccountability frm = new HourlyAccountability();
            var item = UserAccessItems.FirstOrDefault(a => a.ModuleCode == "RHA");
            frm.UserAccess = item;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void operationHourlyAccoutabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationHourlyAccountability frm = new OperationHourlyAccountability();
            var item = UserAccessItems.FirstOrDefault(a => a.ModuleCode == "ROHA");
            frm.UserAccess = item;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void summaryReportPerTerminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummaryReportPerTerminal frm = new SummaryReportPerTerminal();
            var item = UserAccessItems.FirstOrDefault(a => a.ModuleCode == "RSRPT");
            frm.UserAccess = item;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void lenghtOfStayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LengthOfStay frm = new LengthOfStay();
            var item = UserAccessItems.FirstOrDefault(a => a.ModuleCode == "RLOS");
            frm.UserAccess = item;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void operationOccupancyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationOccupancy frm = new OperationOccupancy();
            var item = UserAccessItems.FirstOrDefault(a => a.ModuleCode == "ROO");
            frm.UserAccess = item;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void peakLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeakLoad frm = new PeakLoad();
            var item = UserAccessItems.FirstOrDefault(a => a.ModuleCode == "RPL");
            frm.UserAccess = item;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void remainingCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemainingCars frm = new RemainingCars();
            var item = UserAccessItems.FirstOrDefault(a => a.ModuleCode == "RRC");
            frm.UserAccess = item;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void bIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BIR frm = new BIR();
            var item = UserAccessItems.FirstOrDefault(a => a.ModuleCode == "RBIR");
            frm.UserAccess = item;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void zReadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZReading frm = new ZReading();
            var item = UserAccessItems.FirstOrDefault(a => a.ModuleCode == "RZR");
            frm.UserAccess = item;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void cardEncodingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CardEncoding frm = new CardEncoding();
            var item = UserAccessItems.FirstOrDefault(a => a.ModuleCode == "RCE");
            frm.UserAccess = item;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void userAccessMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAccessMatrix frm = new UserAccessMatrix();
            var item = UserAccessItems.FirstOrDefault(a => a.ModuleCode == "RUAM");
            frm.UserAccess = item;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }
    }
}
