Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar
Imports DevComponents.AdvTree

Namespace MicroCharts
	Partial Public Class Form1
		Inherits Office2007Form
		Public Sub New()
			InitializeComponent()
			UpdateChartData()
			UpdateLiveChart()

			' Adjust colors of live chart
			microChartItem4.PieChartStyle.SliceColors(0) = Color.Transparent
			microChartItem4.PieChartStyle.SliceColors(1) = Color.FromArgb(79, 97, 40)
            microChartItem4.PieChartStyle.SliceOutlineColor = Color.Gray
            ' Set custom tool-tips
            microChartItem4.DataPointTooltips = New List(Of String)(New String() {"Competitors: {0}", "Our market share: {0}"})
		End Sub

		#Region "Random Data Creation"
		Private Function GetRandomDataPoints(ByVal allowNegative As Boolean) As List(Of Double)
			Return GetRandomDataPoints(allowNegative, 12)
		End Function
		Private Function GetRandomDataPoints(ByVal allowNegative As Boolean, ByVal pointsToCreate As Integer) As List(Of Double)
			Dim points As New List(Of Double)()
            Dim rnd As New Random()
			Dim rnd2 As New Random()

			For i As Integer = 0 To pointsToCreate - 1
                points.Add(IIf(allowNegative, ((IIf(rnd2.Next(50) > 25, 1, -1)) * rnd.Next(100)), rnd.Next(100)))
			Next i

			Return points
		End Function
		Private Function GetRandomDataPoints() As List(Of Double)
			Return GetRandomDataPoints(True)
		End Function
		#End Region

		Private Sub buttonItem5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonItem5.Click
			UpdateChartData()
		End Sub
		Private Sub UpdateChartData()
			microChartItem1.DataPoints = GetRandomDataPoints(False)
			microChartItem2.DataPoints = GetRandomDataPoints()
			microChartItem3.DataPoints = GetRandomDataPoints(False)

			' AdvTree Chart
			microChartItem5.DataPoints = GetRandomDataPoints()
			'Console.WriteLine(microChartItem3.DataPoints[microChartItem3.DataPoints.Count - 1]);
		End Sub

		Private Sub UpdateLiveChart()
			microChartItem4.DataPoints = GetRandomDataPoints(False, 2)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			microChart1.DataPoints = GetRandomDataPoints()
			microChart2.DataPoints = GetRandomDataPoints()
			microChart3.DataPoints = GetRandomDataPoints()
			microChart4.DataPoints = GetRandomDataPoints()
			microChart5.DataPoints = GetRandomDataPoints()
			microChart6.DataPoints = GetRandomDataPoints()
			microChart7.DataPoints = GetRandomDataPoints()
			microChart8.DataPoints = GetRandomDataPoints()

			' Add new micro-chart to a node3
			Dim cell_Renamed As New Cell()
			Dim microChart As New MicroChartItem()
			microChart.ChartType = eMicroChartType.Column
			microChart.ChartWidth = 64
			microChart.DataPoints = GetRandomDataPoints()
			cell_Renamed.HostedItem = microChart
			node3.Cells.Add(cell_Renamed)
		End Sub

		Private Sub refreshTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles refreshTimer.Tick
			UpdateLiveChart()
		End Sub

		Private Sub buttonItem6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonItem6.Click
			' Update Line-Chart for 5 seconds and count number of updates
			Dim start As Date = Date.Now
			Dim updatesCount As Integer = 0
			Dim [end] As Date
			Do
				microChart1.DataPoints = GetRandomDataPoints()
				' Ensure that graph is repainted
				microChart1.Update()
				[end] = Date.Now
				updatesCount += 1
			Loop While [end].Subtract(start).TotalMilliseconds < 5000

			MessageBox.Show(String.Format("Drawing {0} new charts per second!", Math.Round(updatesCount / [end].Subtract(start).TotalSeconds)))
		End Sub

        Private Sub LabelItem1_MarkupLinkClick(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.MarkupLinkClickEventArgs) Handles LabelItem1.MarkupLinkClick
            System.Diagnostics.Process.Start("http://www.devcomponents.com/kb2/?p=894")
        End Sub
    End Class
End Namespace