Imports System.Text
Imports DevComponents.DotNetBar.SuperGrid

Namespace SuperGridDemo
	Partial Public Class DemoVirtualMode
        Inherits DevComponents.DotNetBar.Office2007Form
		Public Sub New()
			InitializeComponent()

			' Set the sample description text

            ShellServices.LoadRtbText(richTextBox1, "SuperGridDemo.DemoVirtualMode.rtf")
		End Sub

		#Region "SuperGridControl1LoadVirtualRow"

		''' <summary>
		''' This routine is called by the grid when it needs a
		''' given virtual row to be loaded.  All of the row cells
		''' have been allocated prior to this call.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1LoadVirtualRow(ByVal sender As Object, ByVal e As GridVirtualRowEventArgs) Handles superGridControl1.LoadVirtualRow
			Dim row As GridRow = e.GridRow
			Dim panel As GridPanel = e.GridPanel

			Dim index As Integer = row.Index

			' We'll pretend, for this example, to do sorting by just
			' reversing the index when ask to sort descending

			If panel.SortColumns.Count > 0 Then
				Dim column As GridColumn = panel.SortColumns(0)

				If column.SortDirection = SortDirection.Descending Then
					index = panel.VirtualRowCount - row.Index - 1
				End If
			End If

			' For this demo sample, we will save and restore any
			' user changed data. So, before initializing a new default
			' row, look to see if we have it tucked away already.

			Dim vdata As Dictionary(Of Integer, String) = TryCast(panel.Tag, Dictionary(Of Integer, String))

			If vdata IsNot Nothing Then
				Dim value As String

				If vdata.TryGetValue(index, value) = True Then
					Dim s() As String = value.Split(";"c)

					For i As Integer = 0 To panel.Columns.Count - 1
						row.Cells(i).Value = s(i)
					Next i

					row.RowDirty = True

					Return
				End If
			End If

			' Fill the cell data in with some nonsense data

			For i As Integer = 0 To panel.Columns.Count - 1
				row.Cells(i).Value = String.Format("Row {0}, Cell {1}", index, i)
			Next i
		End Sub

		#End Region

		#Region "SuperGridControl1StoreVirtualRow"

		''' <summary>
		''' This routine is called by the grid whenever a user has
		''' modified the row contents (ie made the row "Dirty").
		''' 
		''' In this example we will save the changed data in our local
		''' store so that it can be retrieved later, if need be.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1StoreVirtualRow(ByVal sender As Object, ByVal e As GridVirtualRowEventArgs) Handles superGridControl1.StoreVirtualRow
			Dim row As GridRow = e.GridRow
			Dim panel As GridPanel = e.GridPanel

			Dim index As Integer = e.Index

			Dim vdata As Dictionary(Of Integer, String) = TryCast(e.GridPanel.Tag, Dictionary(Of Integer, String))

			If vdata Is Nothing Then
				vdata = New Dictionary(Of Integer, String)()

				panel.Tag = vdata
			End If

			Dim sb As New StringBuilder()

			For i As Integer = 0 To panel.Columns.Count - 1
				sb.Append(row.Cells(i).Value)
				sb.Append(";")
			Next i

			sb.Length -= 1

			vdata(index) = sb.ToString()
		End Sub

		#End Region

		#Region "BtnLoadRowsClick"

		''' <summary>
		''' Handles user requests to load the grid with 2,000,000 rows
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub BtnLoadRowsClick(ByVal sender As Object, ByVal e As EventArgs) Handles BtnLoadRows.Click
			superGridControl1.PrimaryGrid.VirtualRowCount = 2000000

			superGridControl1.Focus()
		End Sub

		#End Region

		#Region "BtnClearRowsClick"

		''' <summary>
		''' Handles user requests to clear, or remove, all virtual rows.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub BtnClearRowsClick(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClearRows.Click
			superGridControl1.PrimaryGrid.VirtualRowCount = 0

			superGridControl1.Focus()
		End Sub

		#End Region

		#Region "CbxAltRowStyleCheckedChanged"

		''' <summary>
		''' Handles user requests to display the data using
		''' the AlternateRowStyle.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxAltRowStyleCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CbxAltRowStyle.CheckedChanged
			superGridControl1.PrimaryGrid.UseAlternateRowStyle = CbxAltRowStyle.Checked

			superGridControl1.Focus()
		End Sub

		#End Region

		#Region "CbxAltColStyleCheckedChanged"

		''' <summary>
		''' Handles user requests to display the data using
		''' the AlternateColumnStyle.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxAltColStyleCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CbxAltColStyle.CheckedChanged
			superGridControl1.PrimaryGrid.UseAlternateColumnStyle = CbxAltColStyle.Checked

			superGridControl1.Focus()
		End Sub

		#End Region
	End Class
End Namespace