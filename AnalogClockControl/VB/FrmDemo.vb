Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Namespace ClockDemo
	Partial Public Class FrmDemo
		Inherits Office2007Form
		Public Sub New()
			InitializeComponent()

			advPropertyGrid1.SelectedObject = clkPropGrid

			Dim clkCtrl As AnalogClockControl

			clkCtrl = New AnalogClockControl()
			clkCtrl.BackColor = Color.Transparent
			clkCtrl.Location = New Point(50, 40)
			clkCtrl.Size = New Size(200, 200)
			clkCtrl.ClockStyle = eClockStyles.Style1
			clkCtrl.ShowGlassOverlay = True
			clkCtrl.ShowSecondHand = True
			clkCtrl.Value = Date.Now
			clkCtrl.AutomaticMode = True

			clkCtrl.ClockStyleData.FaceColor.Color1 = Color.FromArgb(0, 0, 192)
			clkCtrl.ClockStyleData.FaceColor.Color2 = Color.White
			clkCtrl.ClockStyleData.FaceColor.BorderColor = Color.FromArgb(64, 64, 64)

			clkCtrl.ClockStyleData.LargeTickColor.Color1 = Color.Black
			clkCtrl.ClockStyleData.LargeTickColor.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Solid
			clkCtrl.ClockStyleData.LargeTickColor.BorderColor = Color.FromArgb(128, 192, 192, 255)

			clkCtrl.ClockStyleData.SmallTickColor.Color1 = Color.Black
			clkCtrl.ClockStyleData.SmallTickColor.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Solid
			clkCtrl.ClockStyleData.SmallTickColor.BorderColor = Color.FromArgb(128, 192, 192, 255)

			clkCtrl.ClockStyleData.HourHandStyle.HandColor.Color1 = Color.Black
			clkCtrl.ClockStyleData.HourHandStyle.HandColor.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Solid

			clkCtrl.ClockStyleData.MinuteHandStyle.HandColor.Color1 = Color.Black
			clkCtrl.ClockStyleData.MinuteHandStyle.HandColor.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Solid

			clkCtrl.ClockStyleData.SecondHandStyle.HandColor.Color1 = Color.Black
			clkCtrl.ClockStyleData.SecondHandStyle.HandColor.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Solid

			superTabControlPanel4.Controls.Add(clkCtrl)
		End Sub

	End Class
End Namespace
