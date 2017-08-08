Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Namespace SuperGridDemo
	Partial Public Class DemoNested
        Inherits DevComponents.DotNetBar.Office2007Form
		#Region "Private variables"

		Private _Rand As New Random()

		#End Region

		Public Sub New()
			InitializeComponent()

			' Initialize the grid
			' and set the sample description text

			InitializeGrid()

            ShellServices.LoadRtbText(richTextBox1, "SuperGridDemo.DemoNested.rtf")
		End Sub

		#Region "InitializeGrid"

		''' <summary>
		''' Initializes the default grid
		''' </summary>
		Private Sub InitializeGrid()
			Dim panel As GridPanel = superGridControl1.PrimaryGrid

			InitPanel(panel)
		End Sub

		#End Region

		#Region "InitPanel"

		''' <summary>
		''' Initializes the given panel
		''' </summary>
		''' <param name="panel"></param>
		Private Sub InitPanel(ByVal panel As GridPanel)
			panel.CheckBoxes = True
			panel.ShowCheckBox = False
			panel.ShowTreeButtons = True
			panel.ShowTreeLines = True
			panel.ShowRowGridIndex = True

			panel.RowHeaderWidth = 40
			panel.DefaultRowHeight = 0
			panel.ColumnHeader.RowHeight = 30

			panel.DefaultVisualStyles.CellStyles.Default.Alignment = Alignment.MiddleCenter
			panel.DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = Alignment.MiddleCenter

			AddPanelData(panel)
		End Sub

		#Region "AddPanelData"

		Private Sub AddPanelData(ByVal panel As GridPanel)
			Dim l As Integer = _Rand.Next(5, 8)

			For i As Integer = 0 To l - 1
				Dim col As New GridColumn("Column " & (i + 1))

				col.Width = 130
				col.InfoImageAlignment = Alignment.MiddleLeft
				col.EditorType = GetType(GridDoubleInputEditControl)

				panel.Columns.Add(col)
			Next i

			Dim m As Integer = _Rand.Next(3, 20)

			For i As Integer = 0 To m - 1
				Dim row As New GridRow()

				If i Mod 5 = 0 Then
					row.CellStyles.Default.BorderThickness = New Thickness(1)
					row.CellStyles.Default.Margin = New DevComponents.DotNetBar.SuperGrid.Style.Padding(4)
				End If

				Dim t As Integer = 100
				Dim n As Integer = _Rand.Next(2, l)

				For j As Integer = 0 To n - 1
                    Dim k As Integer = IIf(j = n - 1, t, _Rand.Next(0, t))

					row.Cells.Add(New GridCell(CDbl(k)))

					t -= k
				Next j

				panel.Rows.Add(row)
			Next i
		End Sub

		#End Region

		#End Region

		#Region "SuperGridControl1AfterCheck"

		''' <summary>
		''' Handles row CheckBox checked changes
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1AfterCheck(ByVal sender As Object, ByVal e As GridAfterCheckEventArgs) Handles superGridControl1.AfterCheck
			Dim crow As GridRow = TryCast(e.Item, GridRow)

			' If the check state is going from unchecked to
			' checked, then add anew sub panel under the the
			' row that was checked.

			If crow IsNot Nothing AndAlso crow.Checked = True Then
				Dim panel As New GridPanel()

				InitPanel(panel)

				crow.Rows.Add(panel)

				' Since we are always adding the row to the end
				' of the list, lets make sure it is visible on the screen

				panel.EnsureVisible(True)
			End If
		End Sub

		#End Region

		#Region "SuperGridControl1RowValidating"

		''' <summary>
		''' Handles row level validation.  For this example, the
		''' cell data for the row must exactly equal 100.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1RowValidating(ByVal sender As Object, ByVal e As GridRowValidatingEventArgs) Handles superGridControl1.RowValidating
			Dim row As GridRow = e.GridRow

			Dim total As Double = 0

			For Each cell As GridCell In row.Cells
				If cell.Value IsNot Nothing Then
					total += CDbl(cell.Value)
				End If
			Next cell

			If total <> 100 Then
				row.InfoText = "All cell Values must add up to exactly 100 (currently " & total & "). Double-click on this icon to auto-correct."

				e.Cancel = True
			End If
		End Sub

		#End Region

		#Region "SuperGridControl1CellValidating"

		''' <summary>
		''' Handles cell level validation.  For this example the
		''' cell must be between 0 and 100, inclusive.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1CellValidating(ByVal sender As Object, ByVal e As GridCellValidatingEventArgs) Handles superGridControl1.CellValidating
			Dim value As Double = CDbl(e.Value)

			If value < 0 OrElse value > 100 Then
				e.GridCell.InfoText = "Cell Value must be between 0 and 100, inclusive"
				e.Cancel = True
			End If
		End Sub

		#End Region

		#Region "SuperGridControl1CellValidated"

		''' <summary>
		''' Resets the cell level InfoText after successful
		''' cell validation
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1CellValidated(ByVal sender As Object, ByVal e As GridCellValidatedEventArgs) Handles superGridControl1.CellValidated
			e.GridCell.InfoText = Nothing
		End Sub

		#End Region

		#Region "SuperGridControl1RowValidated"

		''' <summary>
		''' Resets the row level InfoText after a successful
		''' row level validation
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1RowValidated(ByVal sender As Object, ByVal e As GridRowValidatedEventArgs) Handles superGridControl1.RowValidated
			e.GridRow.InfoText = Nothing
		End Sub

		#End Region

		#Region "SuperGridControl1CancelEdit"

		''' <summary>
		''' Resets the cell level InfoText upon
		''' user cancel of the edit operation
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1CancelEdit(ByVal sender As Object, ByVal e As GridEditEventArgs) Handles superGridControl1.CancelEdit
			e.GridCell.InfoText = Nothing
		End Sub

		#End Region

		#Region "SuperGridControl1RowInfoDoubleClick"

		''' <summary>
		''' Handle row level InfoImage double-clicks
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1RowInfoDoubleClick(ByVal sender As Object, ByVal e As GridRowDoubleClickEventArgs) Handles superGridControl1.RowInfoDoubleClick
			Dim row As GridRow = TryCast(e.GridRow, GridRow)

			If row IsNot Nothing Then
				' Just simply change every cell to have the average
				' value needed to total 100

				Dim avg As Integer = 100 \ row.Cells.Count
				Dim [step] As Integer = 100 Mod row.Cells.Count

				For i As Integer = 0 To row.Cells.Count - 1
                    row.Cells(i).Value = CDbl(avg + (IIf(i < [step], 1, 0)))
				Next i

				row.InfoText = Nothing
			End If
		End Sub

		#End Region
	End Class
End Namespace