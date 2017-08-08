Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevComponents.AdvTree
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Namespace SuperGridDemo
	Partial Public Class DemoDragDrop
        Inherits DevComponents.DotNetBar.Office2007Form
		#Region "Private variables"

		Private _SrcGrid As SuperGridControl
		Private _SrcElement As GridElement

		Private _DragOverRow As GridRow
		Private _DragOverCell As GridCell
		Private _DragOverColumn As GridColumn

		Private _MouseDownPoint As Point

		#End Region

		Public Sub New()
			InitializeComponent()

			' Initialize the grid and
			' set the sample description text

			InitializeGrid()
			InitializeListBox()
			InitializeTreeView()
			InitializeAdvTree()

            ShellServices.LoadRtbText(richTextBox1, "SuperGridDemo.DemoDragDrop.rtf")

			AddHandler superGridControl1.ItemDrag, AddressOf SuperGridControlItemDrag
		End Sub

		#Region "Initialization support"

		#Region "InitializeGrid"

		''' <summary>
		''' Initializes the default grid
		''' </summary>
		Private Sub InitializeGrid()
			AddDefaultData(superGridControl1)
			AddDefaultData(superGridControl2)
		End Sub

		#Region "AddDefaultData"

		''' <summary>
		''' Adds default data to the supplied grid
		''' </summary>
		''' <param name="grid"></param>
		Private Sub AddDefaultData(ByVal grid As SuperGridControl)
			Dim panel As GridPanel = grid.PrimaryGrid

			For i As Integer = 0 To 9
				Dim emp As Employee = Employee.GetNewEmployee()

				Dim row As New GridRow(emp.LastName, emp.FirstName, emp.Age, emp.Id)

				panel.Rows.Add(row)
			Next i
		End Sub

		#End Region

		#End Region

		#Region "InitializeListBox"

		''' <summary>
		''' Initializes the ListBox with default data
		''' </summary>
		Private Sub InitializeListBox()
			Dim sb As New StringBuilder()

			For i As Integer = 0 To 19
				Dim emp As Employee = Employee.GetNewEmployee()

				sb.Length = 0

				sb.AppendFormat("{0}, {1}, {2}, {3}", emp.LastName, emp.FirstName, emp.Age, emp.Id)

				listBox1.Items.Add(sb.ToString())
			Next i
		End Sub

		#End Region

		#Region "InitializeTreeView"

		''' <summary>
		''' Initializes the TreeView with default data
		''' </summary>
		Private Sub InitializeTreeView()
			Dim sb As New StringBuilder()

			For i As Integer = 0 To 19
				Dim emp As Employee = Employee.GetNewEmployee()

				sb.Length = 0

				sb.AppendFormat("{0}, {1}, {2}, {3}", emp.LastName, emp.FirstName, emp.Age, emp.Id)

				Dim s As String = sb.ToString()

				Dim n As Integer = treeView1.Nodes.IndexOfKey(emp.LastName)

				If n >= 0 Then
					treeView1.Nodes(n).Nodes.Add(emp.LastName, s)
				Else
					treeView1.Nodes.Add(emp.LastName, s)
				End If
			Next i
		End Sub

		#End Region

		#Region "InitializeAdvTree"

		''' <summary>
		''' Initializes the AdvTree with default data
		''' </summary>
		Private Sub InitializeAdvTree()
			Dim sb As New StringBuilder()

			For i As Integer = 0 To 19
				Dim emp As Employee = Employee.GetNewEmployee()

				sb.Length = 0

				sb.AppendFormat("{0}, {1}, {2}, {3}", emp.LastName, emp.FirstName, emp.Age, emp.Id)

				Dim node As New Node()
				node.Cells.Clear()

				node.Cells.Add(New Cell(emp.LastName))
				node.Cells.Add(New Cell(emp.FirstName))
				node.Cells.Add(New Cell(emp.Age.ToString()))
				node.Cells.Add(New Cell(emp.Id.ToString()))

				Dim pnode As Node = advTree1.FindNodeByText(emp.LastName)

				If pnode IsNot Nothing Then
					pnode.Nodes.Add(node)
				Else
					advTree1.Nodes.Add(node)
				End If
			Next i
		End Sub

		#End Region

		#End Region

		#Region "SuperGrid support"

		#Region "SuperGridControlItemDrag"

		''' <summary>
		''' Handles the initiation of SuperGrid
		''' Drag and Drop operations.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControlItemDrag(ByVal sender As Object, ByVal e As GridItemDragEventArgs) Handles superGridControl2.ItemDrag, superGridControl1.ItemDrag
			Dim sg As SuperGridControl = TryCast(sender, SuperGridControl)

			If sg IsNot Nothing Then
				' Get the collection of selected items

				Dim items As SelectedElementCollection = Nothing

				If TypeOf e.Item Is GridCell Then
					items = sg.PrimaryGrid.GetSelectedCells()

				ElseIf TypeOf e.Item Is GridRow Then
					items = sg.PrimaryGrid.GetSelectedRows()

				ElseIf TypeOf e.Item Is GridColumn Then
					items = sg.PrimaryGrid.GetSelectedColumns()
				End If

				' If the user has selected items, then make the
				' data accessible, and start the drag operation.

				If items IsNot Nothing AndAlso items.Count > 0 Then
					_SrcGrid = sg
					_SrcElement = TryCast(e.Item, GridElement)

					Dim dob As New DataObject(items)

					If TypeOf e.Item Is GridRow Then
						Dim nodes(items.Count - 1) As Node

						For i As Integer = 0 To items.Count - 1
							Dim row As GridRow = CType(items(i), GridRow)

							Dim node As New Node()
							node.Cells.Clear()

							For Each cell As GridCell In row.Cells
								Dim acell As New Cell(cell.Value.ToString())

								node.Cells.Add(acell)
							Next cell

							nodes(i) = node
						Next i

						dob.SetData(nodes)
					End If

					' Initiate the drag operation

					sg.DoDragDrop(dob, DragDropEffects.Copy Or DragDropEffects.Move)

					_SrcGrid = Nothing
					_SrcElement = Nothing
				End If

				ClearDragHighlight()
			End If
		End Sub

		#End Region

		#Region "SuperGridControlDragOver"

		''' <summary>
		''' Handles SuperGrid DragOver events
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControlDragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles superGridControl2.DragOver, superGridControl1.DragOver
			Dim sg As SuperGridControl = TryCast(sender, SuperGridControl)

			If sg IsNot Nothing Then
				ClearDragHighlight()

				e.Effect = DragDropEffects.None

				Dim clientPoint As Point = sg.PointToClient(New Point(e.X, e.Y))
				Dim item As GridElement = sg.GetElementAt(clientPoint.X, clientPoint.Y)

				If TypeOf item Is GridCell Then
					If TypeOf _SrcElement Is GridRow Then
						item = CType(item, GridCell).GridRow
					ElseIf _SrcElement Is Nothing OrElse TypeOf _SrcElement Is GridCell Then
						_DragOverCell = CType(item, GridCell)
						_DragOverCell.CellStyles.Default.Background = New Background(Color.AliceBlue)

						e.Effect = DragDropEffects.Copy Or DragDropEffects.Move
					End If
				End If

				If TypeOf item Is GridRow Then
					If _SrcElement Is Nothing OrElse TypeOf _SrcElement Is GridRow Then
						_DragOverRow = CType(item, GridRow)
						_DragOverRow.CellStyles.Default.Background = New Background(Color.AliceBlue)

						e.Effect = DragDropEffects.Copy Or DragDropEffects.Move
					End If
				ElseIf TypeOf item Is GridColumnHeader Then
					If TypeOf _SrcElement Is GridColumn Then
						Dim doColumn As GridColumn = CType(item, GridColumnHeader).GetHitColumn(clientPoint)

                        If CType(_SrcElement, GridColumn).EditorType.Equals(doColumn.EditorType) Then
                            _DragOverColumn = doColumn
                            _DragOverColumn.CellStyles.Default.Background = New Background(Color.AliceBlue)

                            e.Effect = DragDropEffects.Copy Or DragDropEffects.Move
                        End If
					ElseIf _SrcElement Is Nothing OrElse TypeOf _SrcElement Is GridRow Then
						e.Effect = DragDropEffects.Copy Or DragDropEffects.Move
					End If
				End If

				If sg IsNot _SrcGrid Then
					e.Effect = e.Effect And Not(DragDropEffects.Move)
				Else
					If (e.KeyState And 8) <> 8 Then
						e.Effect = e.Effect And Not(DragDropEffects.Copy)
					End If
				End If
			End If
		End Sub

		#End Region

		#Region "SuperGridControlDragDrop"

		''' <summary>
		''' Handles SuperGrid DragDrop events
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControlDragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles superGridControl2.DragDrop, superGridControl1.DragDrop
			Dim sg As SuperGridControl = TryCast(sender, SuperGridControl)

			If sg IsNot Nothing Then
				ClearStyles(sg)

				Dim pt As Point = sg.PointToClient(New Point(e.X, e.Y))
				Dim item As GridElement = sg.GetElementAt(pt.X, pt.Y)

				' If the data we are dropping is from a SuperGrid, then
				' be a little bit more discerning about how we drop it

				If _SrcGrid IsNot Nothing Then
					Dim items As SelectedElementCollection = CType(e.Data.GetData(GetType(SelectedElementCollection)), SelectedElementCollection)

					If TypeOf item Is GridCell Then
						If TypeOf _SrcElement Is GridRow Then
							DropSgRow(e, CType(item, GridCell).GridRow, items)
						Else
							DropSgCell(CType(item, GridCell), items)
						End If
					ElseIf TypeOf item Is GridRow Then
						DropSgRow(e, CType(item, GridRow), items)

					ElseIf TypeOf item Is GridColumnHeader Then
						DropSgColumnHeader(CType(item, GridColumnHeader), items, pt)

					ElseIf TypeOf item Is GridPanel Then
						DropSgPanel(CType(item, GridPanel), items)
					End If
				Else
					If TypeOf item Is GridCell Then
						If TypeOf _SrcElement Is GridRow Then
							DropRow(e, CType(item, GridCell).GridRow)
						Else
							DropCell(e, CType(item, GridCell))
						End If
					ElseIf TypeOf item Is GridRow Then
						DropRow(e, CType(item, GridRow))

					ElseIf TypeOf item Is GridColumnHeader Then
						DropColumnHeader(e, CType(item, GridColumnHeader), pt)
					End If
				End If

				ClearDragHighlight()
			End If
		End Sub

		#Region "ClearStyles"

		Private Sub ClearStyles(ByVal sgrid As SuperGridControl)
			Dim panel As GridPanel = sgrid.PrimaryGrid

			For Each row As GridRow In panel.Rows
				For Each cell As GridCell In row.Cells
					cell.CellStyles.Default = Nothing
				Next cell
			Next row
		End Sub

		#End Region

		#End Region

		#Region "SG_DragDrop"

		#Region "DropSgCell"

		''' <summary>
		''' Handles Dropping data on a GridCell
		''' </summary>
		''' <param name="cell"></param>
		''' <param name="cells"></param>
		Private Sub DropSgCell(ByVal cell As GridCell, ByVal cells As IEnumerable(Of GridElement))
			Dim sb As New StringBuilder()

			For Each droppedCell As GridCell In cells
				If droppedCell.Value IsNot Nothing Then
					sb.Append(droppedCell.Value.ToString())
					sb.Append(", ")
				End If
			Next droppedCell

			If sb.Length > 0 Then
				sb.Length -= 2
			End If

			cell.Value = sb.ToString()
			cell.CellStyles.Default.TextColor = Color.Red
		End Sub

		#End Region

		#Region "DropSgRow"

		''' <summary>
		''' Handles dropping row data on a SuperGrid
		''' </summary>
		''' <param name="e"></param>
		''' <param name="row"></param>
		''' <param name="rows"></param>
		Private Sub DropSgRow(ByVal e As DragEventArgs, ByVal row As GridRow, ByVal rows As IEnumerable(Of GridElement))
			If e.Effect = DragDropEffects.Move Then
				If row.IsSelected = False Then
					MoveSgRows(row, rows)
				End If
			Else
				CopySgRows(row, rows)
			End If
		End Sub

		#End Region

		#Region "CopySgRows"

		''' <summary>
		''' Handles copying GridRow data into a SuperGrid
		''' </summary>
		''' <param name="row"></param>
		''' <param name="rows"></param>
		Private Sub CopySgRows(ByVal row As GridRow, ByVal rows As IEnumerable(Of GridElement))
			Dim panel As GridPanel = row.GridPanel

			For Each item As GridRow In rows
				If row Is Nothing Then
					row = New GridRow()
					panel.Rows.Add(row)
				End If

				Dim n As Integer = Math.Min(item.Cells.Count, panel.Columns.Count)

				For i As Integer = 0 To n - 1
					Dim cell As GridCell = item.Cells(i)

					Dim value As String = cell.Value.ToString()

					If i >= row.Cells.Count Then
						row.Cells.Add(New GridCell(value))
					Else
						If cell.Value IsNot Nothing Then
							row.Cells(i).Value = value
							row.Cells(i).CellStyles.Default.TextColor = Color.Red
						End If
					End If
				Next i

				row = TryCast(row.NextVisibleRow, GridRow)
			Next item
		End Sub

		#End Region

		#Region "MoveSgRows"

		''' <summary>
		''' Handles moving GridRows within the same SuperGrid
		''' </summary>
		''' <param name="row"></param>
		''' <param name="rows"></param>
		Private Sub MoveSgRows(ByVal row As GridRow, ByVal rows As IEnumerable(Of GridElement))
			Dim panel As GridPanel = row.GridPanel

			For Each item As GridRow In rows
				panel.Rows.Remove(item)
			Next item

			Dim n As Integer = row.RowIndex

			For Each item As GridRow In rows
				panel.Rows.Insert(n, item)

				For Each cell As GridCell In item.Cells
					cell.CellStyles.Default.TextColor = Color.Red
				Next cell
			Next item
		End Sub

		#End Region

		#Region "DropSgColumnHeader"

		''' <summary>
		''' Handles dropping data onto a ColumnHeader
		''' </summary>
		''' <param name="item"></param>
		''' <param name="items"></param>
		''' <param name="pt"></param>
		Private Sub DropSgColumnHeader(ByVal item As GridColumnHeader, ByVal items As IEnumerable(Of GridElement), ByVal pt As Point)
			Dim column As GridColumn = item.GetHitColumn(pt)

			If column IsNot Nothing Then
				If TypeOf _SrcElement Is GridColumn Then
					DropSgColumns(column, items)
				Else
					DropSgPanel(item.GridPanel, items)
				End If
			End If
		End Sub

		#Region "DropSgColumns"

        ''' <summary>
        ''' Handles dropping data onto a ColumnHeader
        ''' </summary>
        Private Sub DropSgColumns(ByVal column As GridColumn, ByVal cols As IEnumerable(Of GridElement))
            Dim panel1 As GridPanel = _SrcGrid.PrimaryGrid
            Dim panel2 As GridPanel = column.GridPanel

            If panel1.Rows.Count > panel2.Rows.Count Then
                For i As Integer = panel2.Rows.Count To panel1.Rows.Count - 1
                    panel2.Rows.Add(New GridRow("", "", ""))
                Next i
            End If

            For Each item As GridColumn In cols
                If column Is Nothing OrElse column.EditorType.Equals(item.EditorType) = False Then
                    Exit For
                End If

                Dim index1 As Integer = item.ColumnIndex
                Dim index2 As Integer = column.ColumnIndex

                For i As Integer = 0 To panel1.Rows.Count - 1
                    Dim row1 As GridRow = CType(panel1.Rows(i), GridRow)
                    Dim row2 As GridRow = CType(panel2.Rows(i), GridRow)

                    Dim cell As GridCell = row1.Cells(index1)

                    Dim value As Object = cell.Value

                    If index2 >= row2.Cells.Count Then
                        For j As Integer = row2.Cells.Count To index2 - 1
                            cell = New GridCell("")
                            cell.CellStyles.Default.TextColor = Color.Red

                            row2.Cells.Add(cell)
                        Next j

                        row2.Cells.Add(New GridCell())
                    End If

                    row2.Cells(index2).Value = value
                    row2.Cells(index2).CellStyles.Default.TextColor = Color.Red
                Next i

                column = column.NextVisibleColumn
            Next item
        End Sub

		#End Region

		#End Region

		#Region "DropSgPanel"

		''' <summary>
		''' Handles dropping data on a GridPanel
		''' </summary>
		''' <param name="panel"></param>
		''' <param name="rows"></param>
		Private Sub DropSgPanel(ByVal panel As GridPanel, ByVal rows As IEnumerable(Of GridElement))
			Dim lastRow As GridRow = Nothing

			For Each item As GridRow In rows
				Dim row As New GridRow()

				For i As Integer = 0 To item.Cells.Count - 1
					Dim cell As GridCell = item.Cells(i)

					cell = New GridCell(cell.Value)
					cell.CellStyles.Default.TextColor = Color.Red

					row.Cells.Add(cell)
				Next i

				panel.Rows.Add(row)

				lastRow = row
			Next item

			If lastRow IsNot Nothing Then
				lastRow.EnsureVisible()
			End If
		End Sub

		#End Region

		#End Region

		#Region "NSG_DragDrop"

		#Region "DropCell"

		''' <summary>
		''' Handles dropping non-grid data on a grid cell
		''' </summary>
		''' <param name="e"></param>
		''' <param name="cell"></param>
		Private Sub DropCell(ByVal e As DragEventArgs, ByVal cell As GridCell)
			Dim sb As New StringBuilder()

			If e.Data.GetDataPresent(GetType(String)) = True Then
				Dim s As String = CStr(e.Data.GetData(GetType(String)))

				sb.Append(s)
			ElseIf e.Data.GetDataPresent(GetType(TreeNode)) = True Then
				Dim tnode As TreeNode = CType(e.Data.GetData(GetType(TreeNode)), TreeNode)

				sb.Append(tnode.Text)
			ElseIf e.Data.GetDataPresent(GetType(Node)) = True Then
				Dim node As Node = CType(e.Data.GetData(GetType(Node)), Node)

				For Each droppedCell As Cell In node.Cells
					sb.Append(droppedCell.Text)
					sb.Append(", ")
				Next droppedCell

				If sb.Length > 0 Then
					sb.Length -= 2
				End If
			ElseIf e.Data.GetDataPresent(GetType(Node())) = True Then
				Dim nodes() As Node = CType(e.Data.GetData(GetType(Node())), Node())

				For Each node As Node In nodes
					For Each droppedCell As Cell In node.Cells
						sb.Append(droppedCell.Text)
						sb.Append(", ")
					Next droppedCell

					If sb.Length > 0 Then
						sb.Length -= 2
					End If
				Next node
			End If

			cell.Value = sb.ToString()
			cell.CellStyles.Default.TextColor = Color.Red
		End Sub

		#End Region

		#Region "DropRow"

		''' <summary>
		''' Handles dropping non-grid data on a grid row
		''' </summary>
		''' <param name="e"></param>
		''' <param name="row"></param>
		Private Sub DropRow(ByVal e As DragEventArgs, ByVal row As GridRow)
			Dim panel As GridPanel = row.GridPanel

			If e.Data.GetDataPresent(GetType(String)) = True Then
				Dim s As String = CStr(e.Data.GetData(GetType(String)))

				DropTextRow(row, s.Split(","c))
			ElseIf e.Data.GetDataPresent(GetType(TreeNode)) = True Then
				Dim tnode As TreeNode = CType(e.Data.GetData(GetType(TreeNode)), TreeNode)

				DropTextRow(row, tnode.Text.Split(","c))
			ElseIf e.Data.GetDataPresent(GetType(Node)) = True Then
				Dim node As Node = CType(e.Data.GetData(GetType(Node)), Node)

				DropNodeRow(row, node.Cells)
			ElseIf e.Data.GetDataPresent(GetType(Node())) = True Then
				Dim nodes() As Node = CType(e.Data.GetData(GetType(Node())), Node())

				For Each node As Node In nodes
					If row Is Nothing Then
						row = New GridRow()

						panel.Rows.Add(row)
					End If

					DropNodeRow(row, node.Cells)

					row = TryCast(row.NextVisibleRow, GridRow)
				Next node
			End If
		End Sub

		#Region "DropNodeRow"

		Private Sub DropNodeRow(ByVal row As GridRow, ByVal cells As CellCollection)
			Dim text(cells.Count - 1) As String

			For i As Integer = 0 To cells.Count - 1
				text(i) = cells(i).Text
			Next i

			DropTextRow(row, text)
		End Sub

		#End Region

		#Region "DropTextRow"

		Private Sub DropTextRow(ByVal row As GridRow, ByVal s() As String)
			Dim panel As GridPanel = row.GridPanel

			Dim n As Integer = Math.Min(s.Length, panel.Columns.Count)

			For i As Integer = 0 To n - 1
				If i >= row.Cells.Count Then
					row.Cells.Add(New GridCell())
				End If

				row.Cells(i).Value = s(i)
				row.Cells(i).CellStyles.Default.TextColor = Color.Red
			Next i

			row.EnsureVisible(False)
		End Sub

		#End Region

		#End Region

		#Region "DropColumnHeader"

		''' <summary>
		''' Handles dropping non-grid data on a grid column header
		''' </summary>
		''' <param name="e"></param>
		''' <param name="header"></param>
		''' <param name="pt"></param>
		Private Sub DropColumnHeader(ByVal e As DragEventArgs, ByVal header As GridColumnHeader, ByVal pt As Point)
			Dim column As GridColumn = header.GetHitColumn(pt)

			If column IsNot Nothing Then
				Dim panel As GridPanel = column.GridPanel

				Dim row As New GridRow()
				panel.Rows.Add(row)

				If e.Data.GetDataPresent(GetType(String)) = True Then
					Dim s As String = CStr(e.Data.GetData(GetType(String)))

					DropTextRow(row, s.Split(","c))
				ElseIf e.Data.GetDataPresent(GetType(TreeNode)) = True Then
					Dim tnode As TreeNode = CType(e.Data.GetData(GetType(TreeNode)), TreeNode)

					DropTextRow(row, tnode.Text.Split(","c))
				ElseIf e.Data.GetDataPresent(GetType(Node)) = True Then
					Dim node As Node = CType(e.Data.GetData(GetType(Node)), Node)

					DropNodeRow(row, node.Cells)
				ElseIf e.Data.GetDataPresent(GetType(Node())) = True Then
					Dim nodes() As Node = CType(e.Data.GetData(GetType(Node())), Node())

					For Each node As Node In nodes
						If row Is Nothing Then
							row = New GridRow()

							panel.Rows.Add(row)
						End If

						DropNodeRow(row, node.Cells)

						row = TryCast(row.NextVisibleRow, GridRow)
					Next node
				End If
			End If
		End Sub

		#End Region

		#End Region

		#Region "SuperGridControlDragLeave"

		''' <summary>
		''' Handles SuperGrid DragLeave events
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControlDragLeave(ByVal sender As Object, ByVal e As EventArgs) Handles superGridControl2.DragLeave, superGridControl1.DragLeave
			' Make sure our highlights are cleared

			ClearDragHighlight()
		End Sub

		#End Region

		#Region "ClearDragHighlight"

		''' <summary>
		''' Clears all temporary grid highlights
		''' </summary>
		Private Sub ClearDragHighlight()
			If _DragOverRow IsNot Nothing Then
				_DragOverRow.CellStyles.Default.Background = Nothing
			End If

			If _DragOverCell IsNot Nothing Then
				_DragOverCell.CellStyles.Default.Background = Nothing
			End If

			If _DragOverColumn IsNot Nothing Then
				_DragOverColumn.CellStyles.Default.Background = Nothing
			End If
		End Sub

		#End Region

		#End Region

		#Region "TreeView support"

		#Region "TreeView1MouseDown"

		''' <summary>
		''' Handles TreeView MouseDown events
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub TreeView1MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles treeView1.MouseDown
			Dim tv As TreeView = TryCast(sender, TreeView)

			If tv IsNot Nothing Then
				_MouseDownPoint = Point.Empty

				If e.Button = MouseButtons.Left Then
					Dim node As TreeNode = tv.GetNodeAt(e.Location)

					If node.IsSelected = True Then
						_MouseDownPoint = e.Location
					End If
				End If
			End If
		End Sub

		#End Region

		#Region "TreeView1MouseMove"

		''' <summary>
		''' Handles TreeView MouseMove events
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub TreeView1MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles treeView1.MouseMove
			Dim tv As TreeView = TryCast(sender, TreeView)

			If tv IsNot Nothing Then
				If MouseButtons = MouseButtons.Left Then
					If _MouseDownPoint.IsEmpty = False Then
						If DragStarted(_MouseDownPoint, e.Location) = True Then
							_MouseDownPoint = Point.Empty

							Dim node As TreeNode = tv.GetNodeAt(e.Location)

							tv.DoDragDrop(node.Text, DragDropEffects.Copy)
						End If
					End If
				End If
			End If
		End Sub

		#End Region

		#Region "TreeView1DragOver"

		''' <summary>
		''' Handles TreeView DragOver events
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub TreeView1DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles treeView1.DragOver
			Dim tv As TreeView = TryCast(sender, TreeView)

			If tv IsNot Nothing Then
				' Let's only accept drops from the SuperGrid

				If _SrcElement IsNot Nothing Then
					e.Effect = DragDropEffects.Copy Or DragDropEffects.Move
				End If
			End If
		End Sub

		#End Region

		#Region "TreeView1DragDrop"

		''' <summary>
		''' Handles SuperGrid drag drops
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub TreeView1DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles treeView1.DragDrop
			Dim tv As TreeView = TryCast(sender, TreeView)

			If tv IsNot Nothing Then
				ClearNodeStyles(tv)

				Dim clientPoint As Point = tv.PointToClient(New Point(e.X, e.Y))
				Dim node As TreeNode = tv.GetNodeAt(clientPoint.X, clientPoint.Y)

				If e.Data.GetDataPresent(GetType(SelectedElementCollection)) = True Then
					Dim rows As SelectedElementCollection = CType(e.Data.GetData(GetType(SelectedElementCollection)), SelectedElementCollection)

					If TypeOf rows(0) Is GridRow Then
						Dim sb As New StringBuilder()

						For Each item As GridRow In rows
							If node Is Nothing Then
								node = New TreeNode()
								tv.Nodes.Add(node)
							End If

							sb.Length = 0

							For i As Integer = 0 To item.Cells.Count - 1
								Dim cell As GridCell = item.Cells(i)

								sb.Append(cell.Value)
								sb.Append(", ")
							Next i

							sb.Length -= 2

							node.Text = sb.ToString()
							node.ForeColor = Color.Red

							node = node.NextVisibleNode
						Next item
					End If
				End If
			End If
		End Sub

		#Region "ClearStyles"

		''' <summary>
		''' Clears all TreeNode highlights
		''' </summary>
		''' <param name="tv"></param>
		Private Sub ClearNodeStyles(ByVal tv As TreeView)
			For Each node As TreeNode In tv.Nodes
				node.ForeColor = Color.Black
			Next node
		End Sub

		#End Region

		#End Region

		#End Region

		#Region "ListBox support"

		#Region "ListBox1MouseDown"

		''' <summary>
		''' Handles ListBox MouseDown events
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub ListBox1MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles listBox1.MouseDown
			Dim lb As ListBox = TryCast(sender, ListBox)

			If lb IsNot Nothing Then
				_MouseDownPoint = Point.Empty

				If e.Button = MouseButtons.Left Then
					Dim index As Integer = lb.IndexFromPoint(e.Location)

					If index >= 0 Then
						If lb.SelectedItems.Contains(lb.Items(index)) Then
							_MouseDownPoint = e.Location
						End If
					End If
				End If
			End If
		End Sub

		#End Region

		#Region "ListBox1MouseMove"

		''' <summary>
		''' Handles ListBox MouseMove events
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub ListBox1MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles listBox1.MouseMove
			Dim lb As ListBox = TryCast(sender, ListBox)

			If lb IsNot Nothing Then
				If MouseButtons = MouseButtons.Left Then
					If _MouseDownPoint.IsEmpty = False Then
						If DragStarted(_MouseDownPoint, e.Location) = True Then
							_MouseDownPoint = Point.Empty

							Dim index As Integer = lb.IndexFromPoint(e.Location)

							If index >= 0 Then
								lb.DoDragDrop(lb.SelectedItem.ToString(), DragDropEffects.Copy)
							End If
						End If
					End If
				End If
			End If
		End Sub

		#End Region

		#Region "ListBox1DragOver"

		''' <summary>
		''' Handles ListBox DragOver events
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub ListBox1DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles listBox1.DragOver
			Dim lb As ListBox = TryCast(sender, ListBox)

			If lb IsNot Nothing Then
				' Let's only accept SuperGrid drag drop requests

				If _SrcElement IsNot Nothing Then
					e.Effect = DragDropEffects.Copy Or DragDropEffects.Move
				End If
			End If
		End Sub

		#End Region

		#Region "ListBox1DragDrop"

		''' <summary>
		''' Handles SuperGrid drag drop requests
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub ListBox1DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles listBox1.DragDrop
			Dim lb As ListBox = TryCast(sender, ListBox)

			If lb IsNot Nothing Then
				Dim clientPoint As Point = lb.PointToClient(New Point(e.X, e.Y))
				Dim index As Integer = lb.IndexFromPoint(clientPoint)

				If index >= 0 Then
					If e.Data.GetDataPresent(GetType(SelectedElementCollection)) = True Then
						Dim rows As SelectedElementCollection = CType(e.Data.GetData(GetType(SelectedElementCollection)), SelectedElementCollection)

						If TypeOf rows(0) Is GridRow Then
							Dim sb As New StringBuilder()

							For Each item As GridRow In rows
								If index >= lb.Items.Count Then
									lb.Items.Add("")
								End If

								sb.Length = 0

								For i As Integer = 0 To item.Cells.Count - 1
									Dim cell As GridCell = item.Cells(i)

									sb.Append(cell.Value)
									sb.Append(", ")
								Next i

								sb.Length -= 2

								lb.Items(index) = sb.ToString()
								index += 1
							Next item
						End If
					End If
				End If
			End If
		End Sub

		#End Region

		#End Region

		#Region "DragStarted"

		''' <summary>
		''' Determins when to initiate a Drag operation
		''' </summary>
		''' <param name="pt1"></param>
		''' <param name="pt2"></param>
		''' <returns></returns>
		Private Function DragStarted(ByVal pt1 As Point, ByVal pt2 As Point) As Boolean
			Dim r As New Rectangle(pt1.X, pt1.Y, 0, 0)

			r.Inflate(SystemInformation.DragSize.Width, SystemInformation.DragSize.Height)

			Return (r.Contains(pt2.X, pt2.Y) = False)
		End Function

		#End Region
	End Class
End Namespace