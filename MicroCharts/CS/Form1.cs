using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.AdvTree;

namespace MicroCharts
{
    public partial class Form1 : Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateChartData();
            UpdateLiveChart();

            // Adjust colors of live chart
            microChartItem4.PieChartStyle.SliceColors[0] = Color.Transparent;
            microChartItem4.PieChartStyle.SliceColors[1] = Color.FromArgb(79, 97, 40);
            microChartItem4.PieChartStyle.SliceOutlineColor = Color.Gray;
            // Set custom tool-tips
            microChartItem4.DataPointTooltips = new List<string>(new string[] { "Competitors: {0}", "Our market share: {0}" });
        }

        #region Random Data Creation
        private List<double> GetRandomDataPoints(bool allowNegative)
        {
            return GetRandomDataPoints(allowNegative, 12);
        }
        private List<double> GetRandomDataPoints(bool allowNegative, int pointsToCreate)
        {
            List<double> points = new List<double>();
            Random rnd = new Random((int)DateTime.Now.Ticks);
            Random rnd2 = new Random();

            for (int i = 0; i < pointsToCreate; i++)
            {
                points.Add(allowNegative ? ((rnd2.Next(50) > 25 ? 1 : -1) * rnd.Next(100)) : rnd.Next(100));
            }

            return points;
        }
        private List<double> GetRandomDataPoints()
        {
            return GetRandomDataPoints(true);
        }
        #endregion

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            UpdateChartData();
        }
        private void UpdateChartData()
        {
            microChartItem1.DataPoints = GetRandomDataPoints(false);
            microChartItem2.DataPoints = GetRandomDataPoints();
            microChartItem3.DataPoints = GetRandomDataPoints(false);

            // AdvTree Chart
            microChartItem5.DataPoints = GetRandomDataPoints();
            //Console.WriteLine(microChartItem3.DataPoints[microChartItem3.DataPoints.Count - 1]);
        }

        private void UpdateLiveChart()
        {
            microChartItem4.DataPoints = GetRandomDataPoints(false, 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            microChart1.DataPoints = GetRandomDataPoints();
            microChart2.DataPoints = GetRandomDataPoints();
            microChart3.DataPoints = GetRandomDataPoints();
            microChart4.DataPoints = GetRandomDataPoints();
            microChart5.DataPoints = GetRandomDataPoints();
            microChart6.DataPoints = GetRandomDataPoints();
            microChart7.DataPoints = GetRandomDataPoints();
            microChart8.DataPoints = GetRandomDataPoints();

            // Add new micro-chart to a node3
            Cell cell = new Cell();
            MicroChartItem microChart = new MicroChartItem();
            microChart.ChartType = eMicroChartType.Column;
            microChart.ChartWidth = 64;
            microChart.DataPoints = GetRandomDataPoints();
            cell.HostedItem = microChart;
            node3.Cells.Add(cell);
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            UpdateLiveChart();
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            // Update Line-Chart for 5 seconds and count number of updates
            DateTime start = DateTime.Now;
            int updatesCount = 0;
            DateTime end;
            do
            {
                microChart1.DataPoints = GetRandomDataPoints();
                // Ensure that graph is repainted
                microChart1.Update();
                end = DateTime.Now;
                updatesCount++;
            } while (end.Subtract(start).TotalMilliseconds < 5000);

            MessageBox.Show(string.Format("Drawing {0} new charts per second!", Math.Round(updatesCount / end.Subtract(start).TotalSeconds)));
        }

        private void labelItem1_MarkupLinkClick(object sender, DevComponents.DotNetBar.MarkupLinkClickEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.devcomponents.com/kb2/?p=894");
        }
    }
}