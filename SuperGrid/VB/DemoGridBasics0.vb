Imports System.Text
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Namespace SuperGridDemo
	Partial Public Class DemoGridBasics0
        Inherits DevComponents.DotNetBar.Office2007Form
		#Region "Private variables"

		Private _Rand As New Random()

		#End Region

		Public Sub New()
			InitializeComponent()

			' Initialize the grid and set the sample description text

			InitializeGrid()

            ShellServices.LoadRtbText(richTextBox1, "SuperGridDemo.DemoBasics0.rtf")
		End Sub

		#Region "InitializeGrid"

		''' <summary>
		''' Initialises the grid
		''' </summary>
		Private Sub InitializeGrid()
			Dim panel As GridPanel = superGridControl1.PrimaryGrid

			' Set the "Start/Stop" column editor type to our
			' own defined MyGridButtonXEditControl.

			Dim column As GridColumn = panel.Columns("Start/Stop")
			column.EditorType = GetType(MyGridButtonXEditControl)

			' Add 30 rows for the user to play around with

			For i As Integer = 0 To 29
				panel.Rows.Add(GetNewRow())
			Next i

			' Tell the SuperGrid that we want to be informed when any cell
			' Value changes, and when a new row needs its default values set.

			AddHandler superGridControl1.CellValueChanged, AddressOf SuperGridControl1CellValueChanged
			AddHandler superGridControl1.RowSetDefaultValues, AddressOf SuperGridControl1RowSetDefaultValues
		End Sub

		#End Region

		#Region "SuperGridControl1RowSetDefaultValues"

		''' <summary>
		''' This routine is called to let the application set default
		''' cell values for the given row.
		''' 
		''' This routine will be called with 2 possible contexts - 
		''' new row initialization and new row activation.
		''' 
		''' New rows added by the user selecting a row and pressing the
		''' "ins" key, will result in this routine being called with a
		''' e.NewRowContext equal to NewRowContext.RowInit.
		''' 
		''' When a new InsertRow (the row at the very bottom of the grid) is
		''' created, this routine will be called to permit the application to
		''' initialize it to a set of default values. The e.GridRow.IsInsertRow
		''' can be tested to see which if the InsertRow is the row being set.
		''' 
		''' When the user activate the InsertRow, this routine will also be
		''' called to let the application set - or reset - the values again.
		''' 
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1RowSetDefaultValues(ByVal sender As Object, ByVal e As GridRowSetDefaultValuesEventArgs)
			' We only want to initialize new rows upon their creation,
			' not each time they are activated (only applicable to the InsertRow).

			If e.NewRowContext = NewRowContext.RowInit Then
				Dim row As GridRow = e.GridRow

				row.Cells(0).Value = GetMachineName()
				row.Cells(1).Value = False
				row.Cells(2).Value = False
				row.Cells(3).Value = Date.Now

				row.Cells(4).Value = "Start"
				row.Cells(4).Visible = False
			End If
		End Sub

		#End Region

		#Region "SuperGridControl1CellValueChanged"

		''' <summary>
		''' This routine is called whenever a grid cell value changes
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1CellValueChanged(ByVal sender As Object, ByVal e As GridCellValueChangedEventArgs)
			Dim cell As GridCell = e.GridCell

			' If the cell changing value is in the "Power State" column
			' then adjust the row "Start/Stop" cell appropriately

			If cell.GridColumn.Name.Equals("Power State") = True Then
				Dim row As GridRow = cell.GridRow

				' Hide the cell if the switch button is off
				' and reset the cell's value back to the "Start" state

				row.Cells("Start/Stop").Visible = CBool(e.NewValue)
				row.Cells("Start/Stop").Value = "Start"
			End If
		End Sub

		#End Region

		#Region "GetNewRow"

		''' <summary>
		''' Creates a new GridRow
		''' </summary>
		''' <returns></returns>
		Private Function GetNewRow() As GridRow
			' GridRows can be created with varying parameters set
			' to the GridRow constructor. In this case we are
			' sending a variable list of parameters.

			Dim machine As String = GetMachineName()
			Dim dualVoltage As Boolean = _Rand.Next() Mod 2 = 0
			Dim powerConnected As Boolean = _Rand.Next() Mod 2 = 0
			Dim [date] As Date = Date.Now.AddDays(-_Rand.NextDouble() * 1000)

			Dim row As New GridRow(machine, dualVoltage, powerConnected, [date], "Start")

			' If the "power is not connected" then set the
			' "Start/Stop" cell to be hidden by default

			If powerConnected = False Then
                row.Cells(4).Visible = False
            End If

			Return (row)
		End Function

		#End Region

		#Region "GetMachineName"

		''' <summary>
		''' Creates and returns a dummy Machine name
		''' </summary>
		''' <returns>Machine name</returns>
		Private Function GetMachineName() As String
			Dim sb As New StringBuilder()

			For i As Integer = 0 To 2
				Dim n As Integer = _Rand.Next(2, 4)

				For j As Integer = 0 To n - 1
					sb.Append(ChrW(65 + _Rand.Next(0, 26)))
				Next j

				sb.Append("-"c)
			Next i

			sb.Length -= 1

			Return (sb.ToString())
		End Function

		#End Region

		#Region "MyGridButtonXEditControl"

		''' <summary>
		''' GridButtonXEditControl Class that controls the
		''' ButtonX color initialization and user button clicks.
		''' </summary>
		Private Class MyGridButtonXEditControl
			Inherits GridButtonXEditControl
			''' <summary>
			''' Constructor
			''' </summary>
			Public Sub New()
				' We want to be notified when the user clicks the button
				' so that we can change the underlying cell value to reflect
				' the mouse click.

				AddHandler Click, AddressOf MyGridButtonXEditControlClick
			End Sub

			#Region "InitializeContext"

			''' <summary>
			''' Initializes the color table for the button
			''' </summary>
			''' <param name="cell"></param>
			''' <param name="style"></param>
			Public Overrides Sub InitializeContext(ByVal cell As GridCell, ByVal style As CellVisualStyle)
				MyBase.InitializeContext(cell, style)

				Dim running As Boolean = Text.Equals("Stop") = False

                ColorTable = IIf(running = True, eButtonColor.OrangeWithBackground, eButtonColor.BlueOrb)
			End Sub

			#End Region

			#Region "MyGridButtonXEditControlClick"

			''' <summary>
			''' Handles user clicks of the button
			''' </summary>
			''' <param name="sender"></param>
			''' <param name="e"></param>
			Private Sub MyGridButtonXEditControlClick(ByVal sender As Object, ByVal e As EventArgs)
				Dim running As Boolean = (EditorCell.Value IsNot Nothing AndAlso EditorCell.Value.Equals("Start"))

                EditorCell.Value = IIf(running = True, "Stop", "Start")
			End Sub

			#End Region
		End Class

		#End Region

		#Region "CbxAutoDeleteCheckedChanged"

		''' <summary>
		''' Handles user change of whether the grid should
		''' auto-hide deleted rows.  The default is true.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxAutoDeleteCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxAutoDelete.CheckedChanged
			superGridControl1.PrimaryGrid.AutoHideDeletedRows = cbxAutoDelete.Checked
		End Sub

		#End Region

		#Region "BtnHideDelRowsClick"

		''' <summary>
		''' Hides all deleted rows
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub BtnHideDelRowsClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnHideDeleted.Click
			' You can use the following call to determine
			' what the currently "Active" grid is. In our case
			' this will always be equal to our PrimaryGrid.

			Dim panel As GridPanel = superGridControl1.ActiveGrid

			superGridControl1.BeginUpdate()

			For Each row As GridContainer In panel.FlatDeletedRows
				row.Visible = False
			Next row

			superGridControl1.EndUpdate()
		End Sub

		#End Region

		#Region "BtnShowDelRowsClick"

		''' <summary>
		''' Shows all currently deleted rows
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub BtnShowDelRowsClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowDeleted.Click
			Dim panel As GridPanel = superGridControl1.ActiveGrid

			superGridControl1.BeginUpdate()

			For Each row As GridContainer In panel.FlatDeletedRows
				row.Visible = True
			Next row

			superGridControl1.EndUpdate()
		End Sub

		#End Region

		#Region "CbxCaptionCheckedChanged"

		''' <summary>
		''' Shows or hides the grid Caption
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxCaptionCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxCaption.CheckedChanged
			superGridControl1.PrimaryGrid.Caption.Visible = cbxCaption.Checked
		End Sub

		#End Region

		#Region "CbxTitleCheckedChanged"

		''' <summary>
		''' Shows or hides the grid Title
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxTitleCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxTitle.CheckedChanged
			superGridControl1.PrimaryGrid.Title.Visible = cbxTitle.Checked
		End Sub

		#End Region

		#Region "CbxHeaderCheckedChanged"

		''' <summary>
		''' Shows or hides the grid header
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxHeaderCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxHeader.CheckedChanged
			superGridControl1.PrimaryGrid.Header.Visible = cbxHeader.Checked
		End Sub

		#End Region

		#Region "CbxFooterCheckedChanged"

		''' <summary>
		''' Shows or hides the grid Footer
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxFooterCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxFooter.CheckedChanged
			superGridControl1.PrimaryGrid.Footer.Visible = cbxFooter.Checked
		End Sub

		#End Region

		#Region "CbxRowHeadersCheckedChanged"

		''' <summary>
		''' Shows or hides the RowHeaders
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxRowHeadersCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxRowHeaders.CheckedChanged
			superGridControl1.PrimaryGrid.ShowRowHeaders = cbxRowHeaders.Checked
		End Sub

		#End Region

		#Region "CbxGridIndexCheckedChanged"

		''' <summary>
		''' Enables or disables the showing of the row
		''' GridIndex in each row header
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxGridIndexCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxGridIndex.CheckedChanged
			superGridControl1.PrimaryGrid.ShowRowGridIndex = cbxGridIndex.Checked
		End Sub

		#End Region

		#Region "BtnPurgeRowsClick"

		''' <summary>
		''' Purges all currently deleted rows.
		''' 
		''' When rows are deleted, they are marked as deleted and
		''' potentially hidden. To actually irreversibly remove deleted
		''' rows from the grid, they must be purged.
		''' 
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub BtnPurgeRowsClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnPurgeRows.Click
			superGridControl1.PrimaryGrid.PurgeDeletedRows()
		End Sub

		#End Region
	End Class
End Namespace