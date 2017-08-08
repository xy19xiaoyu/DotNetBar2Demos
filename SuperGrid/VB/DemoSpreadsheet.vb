Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Namespace SuperGridDemo
    Partial Public Class DemoSpreadsheet
        Inherits DevComponents.DotNetBar.Office2007Form
        Public Sub New()
            InitializeComponent()

            ' Initialize the grid, color pickers, 
            ' and set the sample description text

            InitializeGrid()
            InitColorPickers()

            ShellServices.LoadRtbText(richTextBox1, "SuperGridDemo.DemoSpreadsheet.rtf")
        End Sub

#Region "InitializeGrid"

        ''' <summary>
        ''' Initializes the default grid
        ''' </summary>
        Private Sub InitializeGrid()
            Dim panel As GridPanel = superGridControl1.PrimaryGrid

            panel.NullString = Nothing
            panel.AllowEmptyCellSelection = True
            panel.ShowRowGridIndex = True
            panel.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.[Select]

            panel.DefaultVisualStyles.CellStyles.Empty.Background = New Background(Color.White)

            ' Add a column for each letter of the alphabet

            For i As Integer = 0 To 25
                Dim col As New GridColumn((ChrW(65 + i)).ToString())

                col.Width = 60

                panel.Columns.Add(col)
            Next

            ' Add 1000 rows for the user to play with.
            ' No cells are added at this point.

            For i As Integer = 0 To 999
                panel.Rows.Add(New GridRow())
            Next

            AddHandler superGridControl1.SelectionChanged, AddressOf SuperGridControl1SelectionChanged

            AddHandler superGridControl1.BeginEdit, AddressOf SuperGridControl1BeginEdit
            AddHandler superGridControl1.EndEdit, AddressOf SuperGridControl1EndEdit
        End Sub

#End Region

#Region "InitColorPickers"

        ''' <summary>
        ''' Initializes the default colors for the CPs
        ''' </summary>
        Private Sub InitColorPickers()
            CpBackground.SelectedColor = Color.Red
            CpText.SelectedColor = Color.Black
        End Sub

#End Region

#Region "Cell edit routines"

#Region "SuperGridControl1BeginEdit"

        ''' <summary>
        ''' This routine is called when an edit is about to begin.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub SuperGridControl1BeginEdit(ByVal sender As Object, ByVal e As GridEditEventArgs)
            ' Hook the TextChanged event so that we can reflect the
            ' pre-cell contents in the toolbar textbox.

            Dim tbx As GridTextBoxXEditControl = TryCast(e.EditControl, GridTextBoxXEditControl)

            If tbx IsNot Nothing Then
                AddHandler tbx.TextChanged, AddressOf TbxTextChanged
            End If
        End Sub

#End Region

#Region "SuperGridControl1EndEdit"

        ''' <summary>
        ''' This routine is called when a cell edit is about to end.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub SuperGridControl1EndEdit(ByVal sender As Object, ByVal e As GridEditEventArgs)
            ' Unhook the TextChanged listener.

            Dim tbx As GridTextBoxXEditControl = TryCast(e.EditControl, GridTextBoxXEditControl)

            If tbx IsNot Nothing Then
                RemoveHandler tbx.TextChanged, AddressOf TbxTextChanged
            End If
        End Sub

#End Region

#Region "TbxTextChanged"

        ''' <summary>
        ''' Called when the edit text changes.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub TbxTextChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' Reflect the change in the toolbar textbox

            Dim tbx As GridTextBoxXEditControl = TryCast(sender, GridTextBoxXEditControl)

            If tbx IsNot Nothing Then
                TbxCellText.Text = tbx.Text
            End If
        End Sub

#End Region

#End Region

#Region "SuperGridControl1SelectionChanged"

        ''' <summary>
        ''' Handles grid selection changes by updating the
        ''' toolbar textbox if all selected cells have the
        ''' same content value.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub SuperGridControl1SelectionChanged(ByVal sender As Object, ByVal e As GridEventArgs)
            Dim panel As GridPanel = superGridControl1.PrimaryGrid
            Dim items As SelectedElementCollection = panel.GetSelectedElements()
            Dim cells As List(Of GridCell) = items.GetCells()

            Dim s As String = Nothing

            If cells.Count > 0 Then
                For Each cell As GridCell In cells
                    If ValuesMatch(s, DirectCast(cell.Value, String)) = False Then
                        Exit For
                    End If
                Next
            End If

            TbxCellText.Text = s
        End Sub

#Region "ValuesMatch"

        Private Function ValuesMatch(ByRef s As String, ByVal t As String) As Boolean
            If s Is Nothing OrElse s.Equals(t) = True Then
                s = t

                Return (True)
            End If

            s = ""

            Return (False)
        End Function

#End Region

#End Region

#Region "SuperGridControl1DoubleClick"

        ''' <summary>
        ''' Handles double clicking a grid cell, by launching
        ''' a cell edit session.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub SuperGridControl1DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles superGridControl1.DoubleClick
            Dim pt As Point = superGridControl1.PointToClient(MousePosition)

            Dim cell As GridCell = TryCast(superGridControl1.GetElementAt(pt), GridCell)

            If cell IsNot Nothing Then
                LaunchEdit(cell, True)
            End If
        End Sub

#Region "LaunchEdit"

        ''' <summary>
        ''' Launches a GridTextBoxXEditControl edit session.
        ''' </summary>
        ''' <param name="cell"></param>
        ''' <param name="beginEdit"></param>
        Private Sub LaunchEdit(ByVal cell As GridCell, ByVal beginEdit As Boolean)
            If cell IsNot Nothing Then
                If cell.IsEmptyCell = True Then
                    cell = AllocateCell(cell)
                End If

                cell.CellStyles.[Default].TextColor = CpText.SelectedColor

                If beginEdit = True Then
                    cell.BeginEdit(True)
                End If
            End If
        End Sub

#End Region

#End Region

#Region "SuperGridControl1KeyDown"

        ''' <summary>
        ''' Handles edit launching when the user selects a
        ''' and just starts typing.
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub SuperGridControl1KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles superGridControl1.KeyDown
            If superGridControl1.ActiveEditor Is Nothing Then
                Dim cell As GridCell = TryCast(superGridControl1.ActiveElement, GridCell)

                If cell IsNot Nothing Then
                    If e.KeyData = Keys.F2 Then
                        LaunchEdit(cell, False)
                    Else
                        Dim c As Char = e.KeyData.ToString().Substring(0, 1)

                        If (Char.IsControl(c) = False) Then
                            LaunchEdit(cell, False)
                        End If
                    End If
                End If
            End If
        End Sub

#End Region

#Region "CpBackgroundClick"

        ''' <summary>
        ''' Handles user requests to fill the selected cells with
        ''' the currently set color picker background color
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CpBackgroundClick(ByVal sender As Object, ByVal e As EventArgs) Handles CpBackground.Click
            If CpBackground.SelectedColor.IsEmpty = False Then
                Dim panel As GridPanel = superGridControl1.PrimaryGrid
                Dim items As SelectedElementCollection = panel.GetSelectedElements()
                Dim cells As List(Of GridCell) = items.GetCells()

                ' The AllocateCells routine allocates all the cells needed
                ' to be able to satisfy the user's request.
                '
                ' Special care should be taken to understand that the List of cells
                ' returned in the call to items.GetCells is only useful for the
                ' determination of row and column details, and is not valid for any
                ' type of modification.
                '
                ' After cell allocation has taken place, the grid rows now contain
                ' newly created cells - and it is those cells that need to be referenced
                ' in any future cell operation.

                AllocateCells(cells)

                Dim background As New Background(CpBackground.SelectedColor)

                For Each cell As GridCell In cells
                    ' Make sure we use any newly allocated cell, and not
                    ' a potentially Empty cell retrieved in the selection list

                    Dim ncell As GridCell = cell.GridRow.Cells(cell.ColumnIndex)

                    ncell.CellStyles.[Default].Background = background
                Next

                ' Clear all user selections so that the
                ' background change is more apparent to the user.

                panel.ClearAll()
            End If
        End Sub

#End Region

#Region "CpTextClick"

        ''' <summary>
        ''' Handles text color change requests
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CpTextClick(ByVal sender As Object, ByVal e As EventArgs) Handles CpText.Click
            If CpText.SelectedColor.IsEmpty = False Then
                Dim panel As GridPanel = superGridControl1.PrimaryGrid

                Dim color As Color = CpText.SelectedColor

                For Each col As GridColumn In panel.SelectedColumns
                    col.CellStyles.[Default].TextColor = color
                Next

                For Each row As GridRow In panel.SelectedRows
                    row.CellStyles.[Default].TextColor = color
                Next

                For Each cell As GridCell In panel.SelectedCells
                    If cell.IsEmptyCell = False Then
                        cell.CellStyles.[Default].TextColor = color
                    End If
                Next
            End If
        End Sub

#End Region

#Region "TbxCellTextKeyDown"

        ''' <summary>
        ''' Handles the text update of all selected cells, when
        ''' the user is entering txt in the toolbar textbox
        ''' and hits the enter key.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub TbxCellTextKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TbxCellText.KeyDown
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True

                Dim panel As GridPanel = superGridControl1.PrimaryGrid
                Dim items As SelectedElementCollection = panel.GetSelectedElements()
                Dim cells As List(Of GridCell) = items.GetCells()

                ' See above comments about the difference in accessibility
                ' between Empty cells and newly allocated ones.

                AllocateCells(cells)

                Dim s As String = TbxCellText.Text

                For Each cell As GridCell In cells
                    Dim ncell As GridCell = cell.GridRow.Cells(cell.ColumnIndex)

                    ncell.Value = s
                    ncell.GridRow.RowDirty = True
                Next
            End If
        End Sub

#End Region

#Region "BtnFontClick"

        ''' <summary>
        ''' Handles user requests to change each 
        ''' selected cells font
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BtnFontClick(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFont.Click
            Dim fd As New FontDialog()

            fd.ShowColor = True
            fd.ShowEffects = True

            Dim result As DialogResult = fd.ShowDialog()

            If result = DialogResult.OK Then
                Dim panel As GridPanel = superGridControl1.PrimaryGrid
                Dim items As SelectedElementCollection = panel.GetSelectedElements()
                Dim cells As List(Of GridCell) = items.GetCells()

                For Each cell As GridCell In cells
                    If cell.IsEmptyCell = False Then
                        cell.GridRow.Cells(cell.ColumnIndex).CellStyles.[Default].Font = fd.Font
                    End If
                Next
            End If
        End Sub

#End Region

#Region "BtnEraseBackgroundClick"

        ''' <summary>
        ''' Handles user requests to erase the background
        ''' of each selected cell.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BtnEraseBackgroundClick(ByVal sender As Object, ByVal e As EventArgs) Handles BtnEraseText.Click
            EraseBackground()
        End Sub

#Region "EraseBackground"

        Private Sub EraseBackground()
            Dim panel As GridPanel = superGridControl1.PrimaryGrid

            For Each col As GridColumn In panel.SelectedColumns
                col.CellStyles.[Default].Background = Nothing
            Next

            For Each row As GridRow In panel.SelectedRows
                row.CellStyles.[Default].Background = Nothing
            Next

            For Each cell As GridCell In panel.SelectedCells
                If cell.IsEmptyCell = False Then
                    cell.CellStyles.[Default].Background = Nothing
                End If
            Next

            panel.ClearAll()
        End Sub

#End Region

#End Region

#Region "BtnEraseTextClick"

        ''' <summary>
        ''' Handles user requests to erase the cell value
        ''' in each selected cell
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BtnEraseTextClick(ByVal sender As Object, ByVal e As EventArgs) Handles BtnEraseBackground.Click
            EraseText()
        End Sub

#Region "EraseText"

        Private Sub EraseText()
            Dim panel As GridPanel = superGridControl1.PrimaryGrid
            Dim items As SelectedElementCollection = panel.GetSelectedElements()
            Dim cells As List(Of GridCell) = items.GetCells()

            For Each cell As GridCell In cells
                If cell.IsEmptyCell = False Then
                    cell.CellStyles.[Default].Font = Nothing
                    cell.CellStyles.[Default].TextColor = Color.Empty

                    cell.Value = Nothing
                End If
            Next
        End Sub

#End Region

#End Region

#Region "BtnShowEmptyCellsClick"

        ''' <summary>
        ''' Handles user requests to show (or not) all Empty
        ''' cells in their default style color, so that Empty
        ''' and non-Empty cells can be visibly seen.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BtnShowEmptyCellsClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowEmptyCells.Click
            If btnShowEmptyCells.Checked = True Then
                superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.Empty.Background = Nothing
            Else
                superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.Empty.Background = New Background(Color.White)
            End If
        End Sub

#End Region

#Region "Text alignment"

#Region "BtnLeftAlignClick"

        Private Sub BtnLeftAlignClick(ByVal sender As Object, ByVal e As EventArgs) Handles BtnLeftAlign.Click
            AlignItems(Alignment.MiddleLeft)
        End Sub

#End Region

#Region "BtnMiddleAlignClick"

        Private Sub BtnMiddleAlignClick(ByVal sender As Object, ByVal e As EventArgs) Handles BtnMiddleAlign.Click
            AlignItems(Alignment.MiddleCenter)
        End Sub

#End Region

#Region "BtnRightAlignClick"

        Private Sub BtnRightAlignClick(ByVal sender As Object, ByVal e As EventArgs) Handles BtnRightAlign.Click
            AlignItems(Alignment.MiddleRight)
        End Sub

#End Region

#Region "AlignItems"

        Private Sub AlignItems(ByVal alignment As Alignment)
            Dim panel As GridPanel = superGridControl1.PrimaryGrid

            For Each col As GridColumn In panel.SelectedColumns
                col.CellStyles.[Default].Alignment = alignment
            Next

            For Each row As GridRow In panel.SelectedRows
                row.CellStyles.[Default].Alignment = alignment
            Next

            For Each cell As GridCell In panel.SelectedCells
                If cell.IsEmptyCell = False Then
                    cell.CellStyles.[Default].Alignment = alignment
                End If
            Next
        End Sub

#End Region

#End Region

#Region "Support routines"

#Region "AllocateCells"

        ''' <summary>
        ''' Allocates all non-Empty cells
        ''' </summary>
        ''' <param name="cells"></param>
        Private Sub AllocateCells(ByVal cells As IEnumerable(Of GridCell))
            For Each cell As GridCell In cells
                If cell.IsEmptyCell = True Then
                    AllocateCell(cell)
                End If
            Next
        End Sub

#End Region

#Region "AllocateCell"

        ''' <summary>
        ''' Allocates all the cells in a row that are necessary
        ''' to eventually allocate the cell at the given ColumnIndex.
        ''' </summary>
        ''' <param name="cell"></param>
        ''' <returns></returns>
        Private Function AllocateCell(ByVal cell As GridCell) As GridCell
            Dim row As GridRow = cell.GridRow

            For i As Integer = row.Cells.Count To cell.ColumnIndex
                Dim newCell As New GridCell()

                row.Cells.Add(newCell)
            Next

            Return (cell.GridRow.Cells(cell.ColumnIndex))
        End Function

#End Region

#End Region

#Region "SuperGridControl1MouseClick"

        Private Sub SuperGridControl1MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles superGridControl1.MouseClick
            If (e.Button And MouseButtons.Right) = MouseButtons.Right Then
                Dim item As GridElement = superGridControl1.GetElementAt(e.Location)

                If TypeOf item Is GridCell Then
                    ShowContextMenu(cmContext)
                End If
            End If
        End Sub

#Region "ShowContextMenu"

        ''' <summary>
        ''' Shows the given ContextMenu
        ''' </summary>
        ''' <param name="cm">ContextMenu to show</param>
        Private Sub ShowContextMenu(ByVal cm As ButtonItem)
            cm.Popup(MousePosition)
        End Sub

#End Region

#End Region

#Region "CmiClearClick"

        Private Sub CmiClearClick(ByVal sender As Object, ByVal e As EventArgs) Handles cmiClear.Click
            EraseText()
            EraseBackground()
        End Sub

#End Region

#Region "CmiLeftAlignClick"

        Private Sub CmiLeftAlignClick(ByVal sender As Object, ByVal e As EventArgs) Handles cmiLeftAlign.Click
            AlignItems(Alignment.MiddleLeft)
        End Sub

#End Region

#Region "CmiCenterAlignClick"

        Private Sub CmiCenterAlignClick(ByVal sender As Object, ByVal e As EventArgs) Handles cmiCenterAlign.Click
            AlignItems(Alignment.MiddleCenter)
        End Sub

#End Region

#Region "CmiRightAlignClick"

        Private Sub CmiRightAlignClick(ByVal sender As Object, ByVal e As EventArgs) Handles cmiRightAlign.Click
            AlignItems(Alignment.MiddleRight)
        End Sub

#End Region

    End Class

End Namespace
