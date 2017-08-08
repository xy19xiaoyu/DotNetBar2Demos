using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace MetroBill
{
    public partial class StartControl : DevComponents.DotNetBar.Controls.SlidePanel
    {
        public StartControl()
        {
            InitializeComponent();

            // Add self-updating chart to the sales tile
            MicroChartItem chart = new MicroChartItem();
            chart.ChartType = eMicroChartType.Column;
            chart.ChartWidth = salesTile.TileSize.Width - 26;
            chart.ChartHeight = salesTile.TileSize.Height - 30;
            chart.DataPoints = GetRandomDataPoints(false, 12);
            chart.TooltipValueFormatString = "C"; // Currency format for tooltips
            chart.ColumnChartStyle.PositiveBarColor = Color.White;
            salesTile.SubItems.Add(chart);
        }

        protected override void OnResize(EventArgs e)
        {
            // Center the panel
            itemPanel1.Location = new Point((this.Width - itemPanel1.Width) / 2 + 16, ((this.Height - labelX1.Height - 16) - itemPanel1.Height) / 2 + labelX1.Height + 16);
            base.OnResize(e);
        }

        private MetroBillCommands _Commands;
        /// <summary>
        /// Gets or sets the commands associated with the control.
        /// </summary>
        public MetroBillCommands Commands
        {
            get { return _Commands; }
            set
            {
                if (value != _Commands)
                {
                    MetroBillCommands oldValue = _Commands;
                    _Commands = value;
                    OnCommandsChanged(oldValue, value);
                }
            }
        }
        /// <summary>
        /// Called when Commands property has changed.
        /// </summary>
        /// <param name="oldValue">Old property value</param>
        /// <param name="newValue">New property value</param>
        protected virtual void OnCommandsChanged(MetroBillCommands oldValue, MetroBillCommands newValue)
        {
            if (newValue != null)
            {
                newClientTile.Command = newValue.ClientCommands.New;
                newInvoiceTile.Command = newValue.InvoiceCommands.New;
                appViewTile.Command = newValue.ToggleStartControl;
                devCoTile.Command = newValue.DevComponents;
                reportTile.Command = newValue.NotImplemented;
                unpaidTile.Command = newValue.NotImplemented;
                ytdTile.Command = newValue.NotImplemented;
                helpTile.Command = newValue.GettingStartedCommand;
            }
            else
            {
                newClientTile.Command = null;
                newInvoiceTile.Command = null;
                appViewTile.Command = null;
                devCoTile.Command = null;
                reportTile.Command = null;
                unpaidTile.Command = null;
                ytdTile.Command = null;
                helpTile.Command = null;
            }
        }

        private void chartUpdateTimer_Tick(object sender, EventArgs e)
        {
            ((MicroChartItem)salesTile.SubItems[0]).DataPoints = GetRandomDataPoints(false, 12);
        }

        private List<double> GetRandomDataPoints(bool allowNegative, int pointsToCreate)
        {
            List<double> points = new List<double>();
            Random rnd = new Random((int)DateTime.Now.Ticks);
            Random rnd2 = new Random();

            for (int i = 0; i < pointsToCreate; i++)
            {
                points.Add(allowNegative ? ((rnd2.Next(500) > 250 ? 1 : -1) * rnd.Next(1000)) : rnd.Next(1000));
            }

            return points;
        }
    }
}
