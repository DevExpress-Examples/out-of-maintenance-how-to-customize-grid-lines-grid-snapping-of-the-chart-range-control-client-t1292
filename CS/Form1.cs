using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace DateTimeChartRangeControlClient {
    public partial class Form1 : Form {

        const int daysForYear = 30;

        public Form1() {
            InitializeComponent();

            // Call the InitializeChart method. 
            InitializeChart();

            // Specify a Chart control as the Range control client. 
            rangeControl1.Client = chartControl1;

            // Access the date-time grid options of the chart range control client.
            var clientOptions = (ChartRangeControlClientDateTimeOptions)rangeControl1.ClientOptions;
            ChartRangeControlClientDateTimeGridOptions gridOptions = clientOptions.RangeControlDateTimeGridOptions;

            // Specify the manual grid mode of the chart range control client. 
            gridOptions.GridMode = ChartRangeControlClientGridMode.Manual;

            // Customize snap and grid properties of the chart range control client.            
            gridOptions.SnapOffset = 2;
            gridOptions.SnapSpacing = 7;
            gridOptions.SnapAlignment = DateTimeGridAlignment.Day;
            gridOptions.GridSpacing = 7;
            gridOptions.GridAlignment = DateTimeGridAlignment.Day;
            gridOptions.GridOffset = 1;

            // Format labels of the chart range control client.
            gridOptions.LabelFormat = "D";
        }

        void InitializeChart() {

            DateTime baseDate = new DateTime(2000, 1, 1);
            Random rnd = new Random();
            Series series = new Series("Series", ViewType.Bar);

            for (int dayCount = 0; dayCount < daysForYear; dayCount++) {
                DateTime argument = baseDate.AddDays(dayCount);
                double value = rnd.Next(50, 100);
                var seriesPoint = new SeriesPoint(argument, value);
                series.Points.Add(seriesPoint);
            }
            chartControl1.Series.Add(series);
        }
    }
}
