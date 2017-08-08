Imports DevComponents.DotNetBar.SuperGrid

Namespace SuperGridDemo
	Partial Public Class DemoGridBasics2
        Inherits DevComponents.DotNetBar.Office2007Form
		#Region "Private variables"

		Private _Rand As New Random()

		#End Region

		Public Sub New()
			InitializeComponent()

			' Initialize the grid, SortLevel
			' ComboBox, and the sample description text.

			InitializeGrid()
			InitSortLevelComboBox()

			ShellServices.LoadRtbText(richTextBox1, "SuperGridDemo.DemoBasics2.rtf")
		End Sub

		#Region "InitSortLevelComboBox"

		''' <summary>
		''' Handles the initialization
		''' of the SortLevel ComboBox
		''' </summary>
		Private Sub InitSortLevelComboBox()
			For Each s As String In System.Enum.GetNames(GetType(SortLevel))
				comboBoxEx1.Items.Add(s)
			Next s

			comboBoxEx1.SelectedIndex = 1
		End Sub

		#End Region

		#Region "InitializeGrid"

		''' <summary>
		''' Handles the default grid initialization
		''' </summary>
		Private Sub InitializeGrid()
			Dim panel As GridPanel = superGridControl1.PrimaryGrid

			' In this example we have two different Editor
			' and Render controls for the "NumericUpDown" column

			Dim column As GridColumn = panel.Columns("NumericUpDown")

			' Set the min and max range for the EditControl

			Dim nc As GridNumericUpDownEditControl = CType(column.EditControl, GridNumericUpDownEditControl)

			nc.Minimum = -10000
			nc.Maximum = 10000
			nc.DecimalPlaces = 3

			' Set the column's RenderType to be a GridDoubleInputEditControl
			' so that we can set a specialized display format for it

			column.RenderType = GetType(GridDoubleInputEditControl)

			Dim rc As GridDoubleInputEditControl = CType(column.RenderControl, GridDoubleInputEditControl)

			rc.DisplayFormat = "#,###.###;(#,###.###);**Zero**"

			' Now lets add 100 rows for the user to play around with

			For i As Integer = 0 To 99
				Dim row As GridRow = GetNewRow()

				' Add a few random nested sub-rows, and then finally
				' add the newly created row to the grid panel

				AddRandomSubRows(row)

				panel.Rows.Add(row)
			Next i
		End Sub

		#End Region

		#Region "AddRandomSubRows"

		''' <summary>
		''' Adds a random number of nested rows to
		''' the given row.
		''' </summary>
		''' <param name="row">Row to add rows to</param>
		Private Sub AddRandomSubRows(ByVal row As GridRow)
			Dim count As Integer = _Rand.Next(1, 7)

			For i As Integer = 0 To count - 1
				row.Rows.Add(GetNewRow())
			Next i
		End Sub

		#End Region

		#Region "GetNewRow"

		''' <summary>
		''' Create a new GridRow for our grid
		''' </summary>
		''' <returns></returns>
		Private Function GetNewRow() As GridRow
			Dim time1 As Date = GetRandomDate()
			Dim time2 As Date = GetRandomDate()

			Dim inum As Integer = GetRandomInteger(500)

			Dim dnum As Double = GetRandomDouble()
			Dim decn As Decimal = GetRandomDecimal()

			Return (New GridRow(time1, time2, decn, inum, dnum))
		End Function

		#Region "GetRandomDate"

		Private Function GetRandomDate() As Date
			Return (Date.Now.AddDays(GetRandomDouble()))
		End Function

		#End Region

		#Region "GetRandomInteger"

		Private Function GetRandomInteger(ByVal max As Integer) As Integer
			Return (_Rand.Next(1, max))
		End Function

		#End Region

		#Region "GetRandomDouble"

		Private Function GetRandomDouble() As Double
			Return (_Rand.NextDouble() * 500)
		End Function

		#End Region

		#Region "GetRandomDecimal"

		Private Function GetRandomDecimal() As Decimal
			Dim decn As Decimal = CDec(_Rand.NextDouble() * 5000)

			If _Rand.Next() Mod 2 = 0 Then
				decn = -decn
			End If

			Return (decn)
		End Function

		#End Region

		#End Region

		#Region "CbxTreeButtonsCheckedChanged"

		''' <summary>
		''' Handles the TreeButton check changes
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxTreeButtonsCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxTreeButtons.CheckedChanged
			Dim panel As GridPanel = superGridControl1.PrimaryGrid

			If cbxTreeButtons.Checked = True Then
				' Change the expand and collapse images to little red bugs

				panel.ExpandImage = ShellServices.LoadBitmap("SuperGridDemo.BugUp.png")
				panel.CollapseImage = ShellServices.LoadBitmap("SuperGridDemo.BugRight.png")
			Else
				' Reset the expand and collapse images

				Dim image As Image = panel.ExpandImage
				If image IsNot Nothing Then
					panel.ExpandImage = Nothing
					image.Dispose()
				End If

				image = panel.CollapseImage
				If image IsNot Nothing Then
					panel.CollapseImage = Nothing
					image.Dispose()
				End If
			End If
		End Sub

		#End Region

		#Region "CbxHeaderImagesCheckedChanged"

		''' <summary>
		''' Handle user requests to either show
		''' or hide all images in the columnheader
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxHeaderImagesCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxHeaderImages.CheckedChanged
			superGridControl1.PrimaryGrid.ColumnHeader.ShowHeaderImages = cbxHeaderImages.Checked
		End Sub

		#End Region

		#Region "CbxAltRowStyleCheckedChanged"

		''' <summary>
		''' Handles user requests to use (or not)
		''' the currently defined AlternateRowStyle
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxAltRowStyleCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxAltRowStyle.CheckedChanged
			superGridControl1.PrimaryGrid.UseAlternateRowStyle = cbxAltRowStyle.Checked
		End Sub

		#End Region

		#Region "CbxAltColStyleCheckedChanged"

		''' <summary>
		''' Handles user requests to use (or not)
		''' the currently defined AlternateColumnStyle
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxAltColStyleCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxAltColStyle.CheckedChanged
			superGridControl1.PrimaryGrid.UseAlternateColumnStyle = cbxAltColStyle.Checked
		End Sub

		#End Region

		#Region "BtnExpandAllClick"

		''' <summary>
		''' Expands all rows
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub BtnExpandAllClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnExpandAll.Click
			superGridControl1.PrimaryGrid.ExpandAll()
		End Sub

		#End Region

		#Region "BtnCollapseAllClick"

		''' <summary>
		''' Collapses all rows
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub BtnCollapseAllClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnCollapseAll.Click
			superGridControl1.PrimaryGrid.CollapseAll()
		End Sub

		#End Region

		#Region "ComboBoxEx1SelectedIndexChanged"

		''' <summary>
		''' Handles SortLevel changes
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub ComboBoxEx1SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEx1.SelectedIndexChanged
			If comboBoxEx1.SelectedIndex >= 0 Then
				superGridControl1.PrimaryGrid.SortLevel = CType(System.Enum.Parse(GetType(SortLevel), CStr(comboBoxEx1.SelectedItem)), SortLevel)
			End If
		End Sub

		#End Region
	End Class
End Namespace