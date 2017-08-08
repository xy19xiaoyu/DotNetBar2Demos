Imports System.Text
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style
Imports DevComponents.Instrumentation

Namespace SuperGridDemo
	Partial Public Class DemoGridBasics5
        Inherits DevComponents.DotNetBar.Office2007Form
		#Region "Private variables"

		Private _Rand As New Random()

		#End Region

		Public Sub New()
			InitializeComponent()

			' Initialize the grid
			' and the sample description text

			InitializeGrid()

            ShellServices.LoadRtbText(richTextBox1, "SuperGridDemo.DemoBasics5.rtf")
		End Sub

		#Region "SuperGridControl1CellDoubleClick"

		''' <summary>
		''' Handles double clicks in grid cells
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1CellDoubleClick(ByVal sender As Object, ByVal e As GridCellDoubleClickEventArgs)
			' If the user double clicked in a MicroChart cell in 
			' the second column, then change the editor on the fly
			' so that they can textually edit the chart points.
			'
			' When the edit is over, the edit type for the column will
			' be set back to normal in the MyGridTextBoxXEditControl EndEdit
			' routine (we could have accomplished this same thing by hooking
			' onto the SuperGridControl.EndEdit event as well).

			If e.GridCell.ColumnIndex = 1 Then
				e.GridCell.EditorType = GetType(MyGridTextBoxXEditControl)
			End If
		End Sub

		#End Region

		#Region "InitializeGrid"

		''' <summary>
		''' Initializes the default grid
		''' </summary>
		Private Sub InitializeGrid()
			Dim panel As GridPanel = superGridControl1.PrimaryGrid

			' Use MyGridBubbleBarEditControl so that we can easily
			' give the BubbleBar EditorControl our small and large
			' ImageLists.

			Dim column As GridColumn = panel.Columns("BubbleBar")
			column.EditorType = GetType(MyGridBubbleBarEditControl)
			column.EditorParams = New Object() { imageList1, imageList2 }

			' Set the MicroChart1's RenderControl to have a Gray LineColor

			column = panel.Columns("MicroChart1")
			Dim mc As GridMicroChartEditControl = CType(column.RenderControl, GridMicroChartEditControl)
			mc.LineChartStyle.LineColor = Color.Gray

			' Set the MicroChart2's EditorType to MyGridMicroChartEditControl,
			' which just simply sets the ChartType to a Bar.

			column = panel.Columns("MicroChart2")
			column.EditorType = GetType(MyGridMicroChartEditControl)

			' Add a new Column - a Gauge Control column

			column = New GridColumn("Gauge")

			column.Width = 300
			column.EditorType = GetType(MyGridGaugeEditControl)

			panel.Columns.Add(column)

			' Add 30 rows for the user to play with

			For i As Integer = 0 To 29
				AddNewRow(panel)
			Next i

			' Hook onto the cell double-click event so that we can set the
			' cell editor type to a TextBoxX control and permit the user to
			' edit the chart points.

			AddHandler superGridControl1.CellDoubleClick, AddressOf SuperGridControl1CellDoubleClick
		End Sub

		#End Region

		#Region "AddNewRow"

		''' <summary>
		''' Adds a new row to out grid
		''' </summary>
		''' <param name="panel"></param>
		Private Sub AddNewRow(ByVal panel As GridPanel)
			Dim o(3) As Object

			o(0) = GetChartPoints(2, 6)
			o(1) = GetChartPoints(6, 10)

			Dim n As Integer = _Rand.Next(0, 3)
			Dim d As Double = _Rand.NextDouble() * 20

			o(2) = n
            o(3) = d * (IIf(n Mod 2 = 0, 1, -1))

			Dim row As New GridRow(o)

			panel.Rows.Add(row)

			row.Cells("BubbleBar").CellStyles.Default.Image = imageList2.Images(n)
		End Sub

		#Region "GetChartPoints"

		Private Function GetChartPoints(ByVal min As Integer, ByVal max As Integer) As Object
			Dim sb As New StringBuilder()

			Dim n As Integer = _Rand.Next(min, max)

			For i As Integer = 0 To n - 1
				sb.Append(_Rand.Next(-50, 50))
				sb.Append(" "c)
			Next i

			Return (sb.ToString())
		End Function

		#End Region

		#End Region

		#Region "MyGridBubbleBarEditControl"

		''' <summary>
		''' GridBubbleBarEditControl with the ability to set the
		''' small amd large ImageLists.  It also handles user image
		''' selection.
		''' </summary>
		Private Class MyGridBubbleBarEditControl
			Inherits GridBubbleBarEditControl
			Public Sub New(ByVal imageListSmall As ImageList, ByVal imageListLarge As ImageList)
				SetupBubbleTab(imageListSmall, imageListLarge)

				AddHandler ButtonClick, AddressOf MyGridBubbleBarEditControlButtonClick
			End Sub

			#Region "MyGridBubbleBarEditControlButtonClick"

			Private Sub MyGridBubbleBarEditControlButtonClick(ByVal sender As Object, ByVal e As ClickEventArgs)
				Dim bb As BubbleButton = CType(sender, BubbleButton)

				' Set the cell image to match the selected bubble image

				EditorCell.CellStyles.Default.Image = ImagesLarge.Images(bb.ImageIndex)
			End Sub

			#End Region

			#Region "SetupBubbleTab"

			''' <summary>
			''' Creates the default BubbleTab for the control
			''' </summary>
			''' <param name="imageListSmall"></param>
			''' <param name="imageListLarge"></param>
			Private Sub SetupBubbleTab(ByVal imageListSmall As ImageList, ByVal imageListLarge As ImageList)
				Images = imageListSmall
				ImagesLarge = imageListLarge

				ImageSizeNormal = New Size(32, 32)
				ImageSizeLarge = New Size(64, 64)

				Dim tab As New BubbleBarTab()
				Tabs.Add(tab)

				For i As Integer = 0 To imageListSmall.Images.Count - 1
					Dim bb As New BubbleButton()
					tab.Buttons.Add(bb)

					bb.ImageIndex = i
					bb.ImageIndexLarge = i
				Next i
			End Sub

			#End Region
		End Class

		#End Region

		#Region "MyGridMicroChartEditControl"

		''' <summary>
		''' GridMicroChartEditControl that
		''' simply sets the ChartType to a Bar
		''' </summary>
		Private Class MyGridMicroChartEditControl
			Inherits GridMicroChartEditControl
			Public Sub New()
				ChartType = eMicroChartType.Bar
			End Sub
		End Class

		#End Region

		#Region "MyGridTextBoxXEditControl"

		''' <summary>
		''' GridTextBoxXEditControl that
		''' simply resets the cell edit control back
		''' to a MicroChart when the cell edit is complete
		''' </summary>
		Private Class MyGridTextBoxXEditControl
			Inherits GridTextBoxXEditControl
			Public Overrides Function EndEdit() As Boolean
				EditorCell.EditorType = GetType(MyGridMicroChartEditControl)

				Return (MyBase.EndEdit())
			End Function
		End Class

		#End Region

		#Region "MyGridGaugeEditControl"

		''' <summary>
		''' GridGaugeEditControl that handles the creation
		''' and initialization of our grid's gauge cell control
		''' </summary>
		Private Class MyGridGaugeEditControl
			Inherits GridGaugeEditControl
			Public Sub New()
				InitGauge()

                AddHandler PointerValueChanged, AddressOf MyGridGaugeEditControlPointerChanged
			End Sub

			#Region "InitGauge"

			''' <summary>
			''' Initializes our gauge
			''' </summary>
			Private Sub InitGauge()
				Frame.Style = GaugeFrameStyle.None

				Dim scale As New GaugeLinearScale()
				scale.Width =.3f
				scale.Size = New SizeF(.7f,.81f)
				scale.Location = New PointF(.6f,.5f)
				scale.BorderColor = Color.DimGray
				scale.BorderWidth = 1
				scale.MinValue = -20
				scale.MaxValue = 20

				scale.MinPin.Visible = False
				scale.MaxPin.Visible = False

				scale.Labels.Layout.Font = New Font("Arial", 10)
				scale.Labels.Layout.AutoSize = False

				scale.MajorTickMarks.Layout.Width =.2f
				scale.MajorTickMarks.Layout.Length =.2f
				scale.MajorTickMarks.Layout.Style = GaugeMarkerStyle.Circle
				scale.MajorTickMarks.Layout.FillColor = New GradientFillColor(Color.White)
				scale.MajorTickMarks.Layout.FillColor.BorderColor = Color.DimGray
				scale.MajorTickMarks.Layout.FillColor.BorderWidth = 1

				Dim text As New GaugeText()

				text.AutoSize = False
				text.Location = New PointF(.12f,.5f)
				text.TextAlignment = TextAlignment.MiddleRight

				GaugeItems.Add(text)

				LinearScales.Add(scale)

				Dim section As New GaugeSection(scale)
				section.Width =.8f
				section.FillColor = New GradientFillColor(Color.Red, Color.Green)

				scale.Sections.Add(section)

				Dim pointer As New GaugePointer(scale)
				pointer.Name = "Pointer1"
				pointer.Style = PointerStyle.Marker
				pointer.MarkerStyle = GaugeMarkerStyle.Triangle
				pointer.Placement = DisplayPlacement.Far
				pointer.ScaleOffset =.03f
				pointer.Width =.3f
				pointer.Length =.3f

				pointer.Origin = PointerOrigin.Custom
				pointer.OriginInterval = 0

				pointer.AllowUserChange = True
				pointer.ChangeCursor = Cursors.Hand

				pointer.FillColor = New GradientFillColor(Color.Yellow)
				pointer.FillColor.BorderColor = Color.DimGray
				pointer.FillColor.BorderWidth = 1

				scale.Pointers.Add(pointer)
			End Sub

			#End Region

			#Region "MyGridGaugeEditControlPointerChanged"

			''' <summary>
			''' Handles gauge pointer changes
			''' </summary>
			''' <param name="sender"></param>
			''' <param name="e"></param>
			Private Sub MyGridGaugeEditControlPointerChanged(ByVal sender As Object, ByVal e As PointerChangedEventArgs)
				' Update the gauge text to reflect the new pointer value

				UpdateText(e.NewValue)
			End Sub

			#End Region

			#Region "UpdateText"

			''' <summary>
			''' Updates the GaugeText items with the current
			''' cell Value
			''' </summary>
			Private Sub UpdateText(ByVal value As Double)
				If EditorCell IsNot Nothing Then
					Dim text As GaugeText = TryCast(GaugeItems(0), GaugeText)

					If text IsNot Nothing Then
						text.Text = value.ToString()

                        text.ForeColor = IIf(value > 0, Color.Green, Color.Crimson)
					End If
				End If
			End Sub

			#End Region
		End Class

		#End Region

		#Region "CbxAddMicroBorderCheckedChanged"

		''' <summary>
		''' Handles user MicroBorderChecked changes
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxAddMicroBorderCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxAddMicroBorder.CheckedChanged
			If cbxAddMicroBorder.Checked = True Then
				AddHandler superGridControl1.CellValueChanged, AddressOf SuperGridControl1CellValueChanged
			Else
				RemoveHandler superGridControl1.CellValueChanged, AddressOf SuperGridControl1CellValueChanged
			End If

			UpdateMicroCellBorders()
		End Sub

		#Region "UpdateMicroCellBorders"

		''' <summary>
		''' Updates all MicroChart cells to reflect border changes
		''' </summary>
		Private Sub UpdateMicroCellBorders()
			Dim panel As GridPanel = superGridControl1.PrimaryGrid

			For Each row As GridRow In panel.Rows
				Dim cell As GridCell = row.Cells(0)
				UpdateMicroChartBorder(cell, NeedsChartBorder(cell.Value))

				cell = row.Cells(1)
				UpdateMicroChartBorder(cell, NeedsChartBorder(cell.Value))
			Next row
		End Sub

		#End Region

		#End Region

		#Region "SuperGridControl1CellValueChanged"

		''' <summary>
		''' Handles cell value changes in order to reflect MicroChart
		''' borders that are based upon the MicroChart values
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1CellValueChanged(ByVal sender As Object, ByVal e As GridCellValueChangedEventArgs)
			Dim cell As GridCell = e.GridCell

			If cell.ColumnIndex <= 1 Then
				Dim needsBorder As Boolean = NeedsChartBorder(e.NewValue)
				Dim hasBorder As Boolean = NeedsChartBorder(e.OldValue)

				If needsBorder <> hasBorder Then
					UpdateMicroChartBorder(cell, needsBorder)
				End If
			End If
		End Sub

		#End Region

		#Region "NeedsChartBorder"

		''' <summary>
		''' Determines if the given value should 
		''' have a border around it.
		''' </summary>
		''' <param name="value"></param>
		''' <returns></returns>
        Private Function NeedsChartBorder(ByVal value As Object) As Boolean
            If cbxAddMicroBorder.Checked Then
                Dim s As String = TryCast(value, String)

                If s IsNot Nothing Then
                    Dim n As Integer = GetChartPointCount(s)

                    Return (n < 4 OrElse n > 8)
                End If
            End If

            Return (False)
        End Function

		#End Region

		#Region "UpdateMicroChartBorder"

		''' <summary>
		''' Updates the MicroChart cell border
		''' </summary>
		''' <param name="cell"></param>
		''' <param name="needsBorder"></param>
		Private Sub UpdateMicroChartBorder(ByVal cell As GridCell, ByVal needsBorder As Boolean)
			If needsBorder = True Then
				cell.CellStyles.Default.BorderThickness = New Thickness(1)
				cell.CellStyles.Default.BorderPattern = New BorderPattern(LinePattern.Dot)

				cell.CellStyles.MouseOver.BorderColor = New BorderColor(Color.Red)
				cell.CellStyles.MouseOver.BorderPattern = New BorderPattern(LinePattern.Solid)

				cell.CellStyles.SelectedMouseOver.BorderColor = New BorderColor(Color.Red)
				cell.CellStyles.SelectedMouseOver.BorderPattern = New BorderPattern(LinePattern.Solid)

				cell.CellStyles.Default.Margin = New DevComponents.DotNetBar.SuperGrid.Style.Padding(6)
			Else
				cell.CellStyles.Default.BorderThickness = Nothing
				cell.CellStyles.Default.Margin = Nothing
			End If
		End Sub

		#End Region

		#Region "GetChartPointCount"

		''' <summary>
		''' Gets the number of defined chart points
		''' in the given string
		''' </summary>
		''' <param name="s"></param>
		''' <returns></returns>
		Private Function GetChartPointCount(ByVal s As String) As Integer
			If String.IsNullOrEmpty(s) = False Then
				Dim ss() As String = s.Split(" "c)

				Return (ss.Length)
			End If

			Return (0)
		End Function

		#End Region
	End Class
End Namespace