using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinancialChartDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a new chart control
            Chart chart1 = new Chart();

            // Set the chart properties
            chart1.Dock = DockStyle.Fill;

            // Add the chart to the form
            this.Controls.Add(chart1);

            // Create a new series
            Series series1 = new Series("Stock Prices");

            // Add data points to the series
            series1.Points.AddXY("Jan", 100);
            series1.Points.AddXY("Feb", 150);
            series1.Points.AddXY("Mar", 120);
            series1.Points.AddXY("Apr", 200);
            series1.Points.AddXY("May", 180);
            series1.Points.AddXY("Jun", 220);
            series1.Points.AddXY("Jul", 250);

            // Set the chart type to a line chart
            series1.ChartType = SeriesChartType.Line;

            // Add the series to the chart
            chart1.Series.Add(series1);

            // Set the title of the chart
            chart1.Titles.Add("Stock Prices");

            // Set the X-axis label
            chart1.ChartAreas[0].AxisX.Title = "Month";

            // Set the Y-axis label
            chart1.ChartAreas[0].AxisY.Title = "Price";
        }
    }
}
