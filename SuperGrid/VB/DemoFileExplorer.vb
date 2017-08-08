Imports System.IO
Imports DevComponents.DotNetBar.SuperGrid

Namespace SuperGridDemo
	Partial Public Class DemoFileExplorer
        Inherits DevComponents.DotNetBar.Office2007Form

        Private _SizeIndex As Integer

		Public Sub New()
			InitializeComponent()

			' Initialize our grid and
			' set the sample description text

			InitializeGrid()

            ShellServices.LoadRtbText(richTextBox1, "SuperGridDemo.DemoFileExplorer.rtf")
		End Sub

		#Region "InitializeGrid"

		Private Sub InitializeGrid()
			' Save the index of the "Size" column for later use
			' and populate our grid with the system drives

			_SizeIndex = superGridControl2.PrimaryGrid.Columns("Size").ColumnIndex

			PopulateDriveRows()
		End Sub

		#End Region

		#Region "SuperGridControl1"

		#Region "PopulateDriveRows"

		''' <summary>
		''' Populates the grid with the current
		''' discoverable system drives
		''' </summary>
		Private Sub PopulateDriveRows()
			Dim panel As GridPanel = superGridControl1.PrimaryGrid

			For Each drive As DriveInfo In DriveInfo.GetDrives()
				If drive.DriveType = DriveType.Fixed Then
					' Allocate a new GridRow for the drive, with the
					' first cell allocated and set to the drive name.

					Dim drow As New GridRow(drive.Name)

					' Let the height auto-size

					drow.RowHeight = 0

					' The RowsUnresolved property is a convenient mechanism
					' to tell the grid that the row may have nested rows, but
					' that fact has not yet been determined.
					' 
					' Later, when the user clicks on the row's expand button, the
					' application then can then resolve the row state by doing 2 things:
					'
					' 1 - Clear the RowsUnresolved property (as, whether there are nested
					'     rows or not) it is now resolved.
					'
					' 2 - Determine whether there are in fact any nested rows or
					'     not and load them into the grid if there are.

					drow.RowsUnresolved = True

					' Save the root directory path for use later if
					' the user clicks on the expand button

					drow.Tag = drive.RootDirectory.FullName

					' Set the cell image to the drive icon

					drow.Cells(0).CellStyles.Default.Image = ShellServices.GetFileImage(drive.Name, True, False)

					' Add the row to the panel

					panel.Rows.Add(drow)
				End If
			Next drive
		End Sub

		#End Region

		#Region "PopulateDirectoryRows"

		''' <summary>
		''' Populates the grid container 
		''' with the contents of a given directory.
		''' </summary>
		''' <param name="path">Directory path</param>
		''' <param name="row">Container to add the entries into</param>
		Private Sub PopulateDirectoryRows(ByVal path As String, ByVal row As GridContainer)
			Dim directories() As String = { }

			Try
				' Get the directory entries

				directories = Directory.GetDirectories(path)
			Catch
			End Try

			' Add each non-hidden, non-system directories into the container

			If directories.Length > 100 Then
				Cursor = Cursors.AppStarting
			End If

			For Each directory As String In directories
				Dim info As New DirectoryInfo(directory)

				If (info.Attributes And (FileAttributes.Hidden Or FileAttributes.System)) = 0 Then
					' Allocate a new GridRow for the directory entry, with
					' the first cell allocated and set to the directory name

					Dim frow As New GridRow(info.Name)

					' Let it's row height auto-size

					frow.RowHeight = 0

					' Tell the grid that the row might have nested rows
					' under it, which we will determine if / when the user
					' clicks on the row's expand button

					frow.RowsUnresolved = True

					' Set the Tag value to the directory, so we can use it later
					' to resolve and potentially load any discovered entries

					frow.Tag = directory

					' Set the cell image to the directory icon

					frow.Cells(0).CellStyles.Default.Image = ShellServices.GetFileImage(directory, False, False)

					' Add the row to the container

					row.Rows.Add(frow)
				End If
			Next directory
		End Sub

		#End Region

		#Region "PopulateDirectoryFiles"

		''' <summary>
		''' Populates the given container with files from
		''' the given directory path.
		''' </summary>
		''' <param name="path">Directory path</param>
		''' <param name="row">Container to add files into</param>
		Private Sub PopulateDirectoryFiles(ByVal path As String, ByVal row As GridContainer)
			Dim files() As String = { }

			Try
				' Get the directory files

				files = Directory.GetFiles(path)
			Catch
			End Try

			' Add each non-hidden, non-system file
			' into the container

			If files.Length > 100 Then
				Cursor = Cursors.AppStarting
			End If

			For Each file As String In files
				Dim info As New FileInfo(file)

				If (info.Attributes And (FileAttributes.Hidden Or FileAttributes.System)) = 0 Then
					' Allocate a GridRow, with the first cell contents
					' being allocated and set to the file's name

					Dim frow As New GridRow(info.Name)

					' Let the row height auto-size

					frow.RowHeight = 0

					' Save the file path for future use

					frow.Tag = file

					' Set the cell image to the file icon

					frow.Cells(0).CellStyles.Default.Image = ShellServices.GetFileImage(file, False, False)

					' Add the file to the container

					row.Rows.Add(frow)
				End If
			Next file
		End Sub

		#End Region

		#Region "SuperGridControl1SelectionChanged"

		''' <summary>
		''' This function will be called after
		''' every selection change in the grid.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e">GridEventArgs</param>
		Private Sub SuperGridControl1SelectionChanged(ByVal sender As Object, ByVal e As GridEventArgs) Handles superGridControl1.SelectionChanged
			Dim panel1 As GridPanel = superGridControl1.PrimaryGrid
			Dim panel2 As GridPanel = superGridControl2.PrimaryGrid

			superGridControl1.Update()

			' Clear all the rows in the right-hand grid.

			panel2.Rows.Clear()

			' Populate the right-hand grid with the selected files
			' from the left-hand grid.  At the same time, sum up the 
			' total size of the selected files.

			Dim count As Integer = 0
			Dim size As Long = 0

			For Each cell As GridCell In panel1.SelectedCells
				Dim path As String = CStr(cell.GridRow.Tag)

				Dim info As New FileInfo(path)

				If (info.Attributes And FileAttributes.Directory) = FileAttributes.Directory Then
					size += PopulateDirectoryInfo(path, panel2, count)
				End If

				If count Mod 20 = 0 Then
					superGridControl2.Update()
				End If
			Next cell

			' Set the right-hand grid's footer to a string
			' showing the total size of all the selected files.

			Dim s As String = String.Empty

			If count > 0 Then
                s = String.Format("{0:N0} file{1}, Size: {2:N0} KB", count, (IIf(count = 1, "", "s")), Math.Ceiling(CDbl(size) / 1024))
			End If

			panel2.Footer.Text = s
		End Sub

		#End Region

		#Region "SuperGridControl1BeforeExpand"

		''' <summary>
		''' This routine is called when a user clicks on a row's
		''' expand button - but before the row is actually expanded.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1BeforeExpand(ByVal sender As Object, ByVal e As GridBeforeExpandEventArgs) Handles superGridControl1.BeforeExpand
			' If we have previously set that the row's nested
			' rows have not been discovered yet, do so now.

			If e.GridContainer.RowsUnresolved = True Then
				' We don't want to expand every unresolved
				' row when the user performed an "ExpandAll" call.

				If e.ExpandSource <> ExpandSource.ExpandAll Then
					' Mark the unresolved status as resolved

					e.GridContainer.RowsUnresolved = False

					' And use the directory path we save earlier
					' to populate the container with any discovered
					' directories and Files.

					Dim path As String = CStr(e.GridContainer.Tag)

					PopulateDirectoryRows(path, e.GridContainer)
					PopulateDirectoryFiles(path, e.GridContainer)
				Else
					' Cancelling the operation here will keep this row from
					' being expanded during an ExpandAll operation

					e.Cancel = True
				End If
			End If
		End Sub

		#End Region

		#End Region

		#Region "SuperGridControl2"

		#Region "SuperGridControl2BeginEdit"

		''' <summary>
		''' This routine is called when the user attempts to edit
		''' a given cell. We are using this as an illustration of one way
		''' to prevent edits while yet keeping all other behavior and
		''' functionality the same. Edits could be cancelled for any
		''' programmatic reason through this mechanism.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl2BeginEdit(ByVal sender As Object, ByVal e As GridEditEventArgs) Handles superGridControl2.BeginEdit
			e.Cancel = True
		End Sub

		#End Region

		#Region "SuperGridControl2GetCellFormattedValue"

		''' <summary>
		''' This routine is called to get the formatted value
		''' of the cell.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl2GetCellFormattedValue(ByVal sender As Object, ByVal e As GridGetCellFormattedValueEventArgs) Handles superGridControl2.GetCellFormattedValue
			' If the grid is asking for the formatted value of a cell
			' in the "Size" column, then format an appropriate display.

			If e.GridCell.ColumnIndex = _SizeIndex Then
				Dim size As Long = CLng(Fix(e.GridCell.Value))

                e.FormattedValue = IIf(size >= 1024, Math.Ceiling(CDbl(size) / 1024) & " KB", size.ToString())
			End If
		End Sub

		#End Region

		#Region "SuperGridControl2RowsGrouped"

		''' <summary>
		''' This routine is called after the grid has finished
		''' grouping rows together (when grouping is enabled).
		''' 
		''' Handling this callout gives us the ability to perform
		''' styling - or any other panel, row, column, or cell (etc)
		''' level action needed on the grouped data.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl2RowsGrouped(ByVal sender As Object, ByVal e As GridEventArgs) Handles superGridControl2.RowsGrouped
			' Grouped rows are, by default, non-expanded. So now that the
			' grouping is complete we can tell the grid to go ahead and
			' expand all the created, expandable rows.

			e.GridPanel.ExpandAll()
		End Sub

		#End Region

		#Region "PopulateDirectoryInfo"

		''' <summary>
		''' This routine populates the right-hand grid with
		''' files discovered from the given directory path.
		''' </summary>
		''' <param name="path">Directory path</param>
		''' <param name="row">Container row</param>
		''' <param name="count">Count of files added</param>
		''' <returns>The total size of all files added</returns>
		Private Function PopulateDirectoryInfo(ByVal path As String, ByVal row As GridContainer, ByRef count As Integer) As Long
			Dim files() As String = { }

			Try
				' Get the directory files

				files = Directory.GetFiles(path)
			Catch
			End Try

			' Add each discovered, non-hidden, non-system files
			' into the given container

			Dim totalSize As Long = 0

			If files.Length > 100 Then
				Cursor = Cursors.AppStarting
			End If

			For Each file As String In files
				Dim info As New FileInfo(file)

				If (info.Attributes And (FileAttributes.Hidden Or FileAttributes.System)) = 0 Then
					' Create an array of
					' cell values to create the new row with.

					Dim size As Long = info.Length

					Dim s(4) As Object
					s(0) = info.Name
					s(1) = size
					s(2) = ShellServices.GetFileType(file)
					s(3) = info.CreationTime.ToShortDateString()
					s(4) = info.LastAccessTime.ToShortDateString()

					' Allocate a new row, giving it an array of objects
					' to use in the creation of the row's Cells

					Dim frow As New GridRow(s)

					' Let the rowheight auto-size and set the Tag value
					' to the file path for future use.

					frow.RowHeight = 0
					frow.Tag = file

					' Set the first cell's image to the file icon

					frow.Cells(0).CellStyles.Default.Image = ShellServices.GetFileImage(file, False, False)

					' Add the row to the container, and
					' update our running count and total size

					row.Rows.Add(frow)

					count += 1
					totalSize += size
				End If
			Next file

			Return (totalSize)
		End Function

		#End Region

		#Region "CbxGroupItemsCheckedChanged"

		''' <summary>
		''' Handles the user request to either group
		''' or ungroup the grid rows - based upon the "Type" column
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxGroupItemsCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CbxGroupItems.CheckedChanged
			Dim panel As GridPanel = superGridControl2.PrimaryGrid

			If CbxGroupItems.Checked = True Then
				panel.SetGroup(panel.Columns("Type"))
			Else
				panel.SetGroup()
			End If
		End Sub

		#End Region

		#Region "SuperGridControl2CellDoubleClick"

		''' <summary>
		''' Launches the associated program for the given file
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl2CellDoubleClick(ByVal sender As Object, ByVal e As GridCellDoubleClickEventArgs) Handles superGridControl2.CellDoubleClick
			Dim s As String = TryCast(e.GridCell.GridRow.Tag, String)

			If s IsNot Nothing Then
				Process.Start(New ProcessStartInfo(s))
			End If
		End Sub

		#End Region

		#End Region
	End Class
End Namespace