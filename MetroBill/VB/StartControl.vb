Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar

Namespace MetroBill
	Partial Public Class StartControl
		Inherits DevComponents.DotNetBar.Controls.SlidePanel
		Public Sub New()
			InitializeComponent()

			' Add self-updating chart to the sales tile
			Dim chart As New MicroChartItem()
			chart.ChartType = eMicroChartType.Column
			chart.ChartWidth = salesTile.TileSize.Width - 26
			chart.ChartHeight = salesTile.TileSize.Height - 30
			chart.DataPoints = GetRandomDataPoints(False, 12)
			chart.TooltipValueFormatString = "C" ' Currency format for tooltips
			chart.ColumnChartStyle.PositiveBarColor = Color.White
			salesTile.SubItems.Add(chart)
		End Sub

		Protected Overrides Sub OnResize(ByVal e As EventArgs)
			' Center the panel
			itemPanel1.Location = New Point((Me.Width - itemPanel1.Width) / 2 + 16, ((Me.Height - labelX1.Height - 16) - itemPanel1.Height) / 2 + labelX1.Height + 16)
			MyBase.OnResize(e)
		End Sub

		Private _Commands As MetroBillCommands
		''' <summary>
		''' Gets or sets the commands associated with the control.
		''' </summary>
		Public Property Commands() As MetroBillCommands
			Get
				Return _Commands
			End Get
			Set(ByVal value As MetroBillCommands)
				If value IsNot _Commands Then
					Dim oldValue As MetroBillCommands = _Commands
					_Commands = value
					OnCommandsChanged(oldValue, value)
				End If
			End Set
		End Property
		''' <summary>
		''' Called when Commands property has changed.
		''' </summary>
		''' <param name="oldValue">Old property value</param>
		''' <param name="newValue">New property value</param>
		Protected Overridable Sub OnCommandsChanged(ByVal oldValue As MetroBillCommands, ByVal newValue As MetroBillCommands)
			If newValue IsNot Nothing Then
                newClientTile.Command = newValue.ClientCommands.[New]
                newInvoiceTile.Command = newValue.InvoiceCommands.[New]
				appViewTile.Command = newValue.ToggleStartControl
				devCoTile.Command = newValue.DevComponents
				reportTile.Command = newValue.NotImplemented
				unpaidTile.Command = newValue.NotImplemented
				ytdTile.Command = newValue.NotImplemented
				helpTile.Command = newValue.GettingStartedCommand
			Else
				newClientTile.Command = Nothing
				newInvoiceTile.Command = Nothing
				appViewTile.Command = Nothing
				devCoTile.Command = Nothing
				reportTile.Command = Nothing
				unpaidTile.Command = Nothing
				ytdTile.Command = Nothing
				helpTile.Command = Nothing
			End If
		End Sub

		Private Sub chartUpdateTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles chartUpdateTimer.Tick
			CType(salesTile.SubItems(0), MicroChartItem).DataPoints = GetRandomDataPoints(False, 12)
		End Sub

		Private Function GetRandomDataPoints(ByVal allowNegative As Boolean, ByVal pointsToCreate As Integer) As List(Of Double)
			Dim points As New List(Of Double)()
            Dim rnd As New Random()
			Dim rnd2 As New Random()

			For i As Integer = 0 To pointsToCreate - 1
                points.Add(IIf(allowNegative, ((IIf(rnd2.Next(500) > 250, 1, -1)) * rnd.Next(1000)), rnd.Next(1000)))
			Next i

			Return points
		End Function
	End Class
End Namespace
