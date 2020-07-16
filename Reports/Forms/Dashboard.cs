using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Helpers;
using LiveCharts.Wpf;
using Reports.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccess.Models;

namespace Reports
{
    public partial class Dashboard : Form
    {
        private DashboardServices services = new DashboardServices();
        public UserAccessItem UserAccess { get; set; }
        public Dashboard()
        {
            InitializeComponent();
        }
        protected async override void OnLoad(EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            await LoadHourlyOccupancy();
            await LoadHeader();
            await LoadAvailableSlots();
            await LoadTickets();

            await LoadWeeklyOccupancy();
            await LoadWeeklySales();
            base.OnLoad(e);
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
                var ins = new List<ObservableValue>();
                var outs = new List<ObservableValue>();
                string[] insLabel = new string[dt.Rows.Count];
                var i = 0;
                foreach(DataRow dr in dt.Rows)
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
                    Separator = new Separator { Step = 1, IsEnabled = false},
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
            if(dt != null)
            {
                var sales = new List<ObservableValue>();
                string[] salesLabel = new string[dt.Rows.Count];
                int i = 0;
                foreach(DataRow dr in dt.Rows)
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
    }
}
