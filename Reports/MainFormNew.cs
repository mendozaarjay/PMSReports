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

namespace Reports
{
    public partial class MainFormNew : Form
    {
        DashboardServices services = new DashboardServices();
        public MainFormNew()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            base.OnLoad(e);
        }
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

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History frm = new History();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void shiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shift frm = new Shift();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales frm = new Sales();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void detailedTransactionSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailedTransactionSummary frm = new DetailedTransactionSummary();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void auditPerCashierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuditPerCashier frm = new AuditPerCashier();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void auditPerTerminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuditPerTerminal frm = new AuditPerTerminal();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void cashierAccountabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashierAccountability frm = new CashierAccountability();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void hourlyAccountabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HourlyAccountability frm = new HourlyAccountability();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void operationHourlyAccoutabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationHourlyAccountability frm = new OperationHourlyAccountability();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void summaryReportPerTerminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummaryReportPerTerminal frm = new SummaryReportPerTerminal();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void lenghtOfStayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LengthOfStay frm = new LengthOfStay();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void operationOccupancyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperationOccupancy frm = new OperationOccupancy();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void peakLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeakLoad frm = new PeakLoad();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void remainingCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemainingCars frm = new RemainingCars();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void bIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BIR frm = new BIR();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void zReadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZReading frm = new ZReading();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void cardEncodingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CardEncoding frm = new CardEncoding();
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }
    }
}
