using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace ClockDemo
{
    public partial class FrmDemo : Office2007Form
    {
        public FrmDemo()
        {
            InitializeComponent();

            advPropertyGrid1.SelectedObject = clkPropGrid;

            AnalogClockControl clkCtrl;

            clkCtrl = new AnalogClockControl();
            clkCtrl.BackColor = Color.Transparent;
            clkCtrl.Location = new Point(50, 40);
            clkCtrl.Size = new Size(200, 200);
            clkCtrl.ClockStyle = eClockStyles.Style1;
            clkCtrl.ShowGlassOverlay = true;
            clkCtrl.ShowSecondHand = true;
            clkCtrl.Value = DateTime.Now;
            clkCtrl.AutomaticMode = true;

            clkCtrl.ClockStyleData.FaceColor.Color1 = Color.FromArgb(0, 0, 192);
            clkCtrl.ClockStyleData.FaceColor.Color2 = Color.White;
            clkCtrl.ClockStyleData.FaceColor.BorderColor = Color.FromArgb(64, 64, 64);
            
            clkCtrl.ClockStyleData.LargeTickColor.Color1 = Color.Black;
            clkCtrl.ClockStyleData.LargeTickColor.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Solid;
            clkCtrl.ClockStyleData.LargeTickColor.BorderColor = Color.FromArgb(128, 192, 192, 255);
            
            clkCtrl.ClockStyleData.SmallTickColor.Color1 = Color.Black;
            clkCtrl.ClockStyleData.SmallTickColor.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Solid;
            clkCtrl.ClockStyleData.SmallTickColor.BorderColor = Color.FromArgb(128, 192, 192, 255);

            clkCtrl.ClockStyleData.HourHandStyle.HandColor.Color1 = Color.Black;
            clkCtrl.ClockStyleData.HourHandStyle.HandColor.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Solid;
            
            clkCtrl.ClockStyleData.MinuteHandStyle.HandColor.Color1 = Color.Black;
            clkCtrl.ClockStyleData.MinuteHandStyle.HandColor.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Solid;
            
            clkCtrl.ClockStyleData.SecondHandStyle.HandColor.Color1 = Color.Black;
            clkCtrl.ClockStyleData.SecondHandStyle.HandColor.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Solid;

            superTabControlPanel4.Controls.Add(clkCtrl);
        }

    }
}
