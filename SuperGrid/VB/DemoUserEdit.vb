Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Media
Imports System.Text
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Namespace SuperGridDemo
	Partial Public Class DemoUserEdit
        Inherits DevComponents.DotNetBar.Office2007Form
		#Region "Private variables"

		Private _Rand As New Random()

		Private Shared _colors() As Color

		Private Shared _Clips() As String = { "Bad Feeling", "Hump", "Looking For", "Oz", "Terminator", "The Ritz"}

		#End Region

		Public Sub New()
			InitializeComponent()

			' Initialize the grid, ComboBoxes,
			' Audio Clip, etc, and set the sample description text.

			InitializeGrid()

            ShellServices.LoadRtbText(richTextBox1, "SuperGridDemo.DemoUserEdit.rtf")
		End Sub

		#Region "InitializeGrid"

		''' <summary>
		''' Initializes the default grid
		''' </summary>
		Private Sub InitializeGrid()
			Dim itemHeight As Integer = imageList1.Images(0).Height

			Dim panel As GridPanel = superGridControl1.PrimaryGrid

			panel.DefaultRowHeight = itemHeight + 8
			panel.ColumnHeader.Tag = 0

			' Set the Color, Image, Audio, Process, and FilePath
			' column Edit types our own defined controls

			Dim column As GridColumn = panel.Columns("Color Combo")
			column.EditorType = GetType(GridColorCombo)
			column.EditorParams = New Object() { itemHeight }

			column = panel.Columns("Image Combo")
			column.EditorType = GetType(GridImageCombo)
			column.EditorParams = New Object() { imageList1, itemHeight }

			column = panel.Columns("Audio Clip")
			column.EditorType = GetType(MyGridClipEditControl)

			column = panel.Columns("Process State")
			column.EditorType = GetType(GridStateEditControl)

			column = panel.Columns("File Path")
			column.EditorType = GetType(GridFilePathEditControl)

			' Add 30 rows for the user to play around with

			Dim files() As String = GetInitialFiles(30)

			Dim values() As KnownColor = CType(System.Enum.GetValues(GetType(KnownColor)), KnownColor())
			_colors = New Color(values.Length - 1){}

			For i As Integer = 0 To values.Length - 1
				_colors(i) = Color.FromKnownColor(values(i))
			Next i

			Dim sb As New StringBuilder()

			For i As Integer = 0 To 29
				Dim row As New GridRow(_colors(i Mod _colors.Length).Name, imageList1.Images.Keys(i Mod imageList1.Images.Count), _Clips(i Mod _Clips.Length), GetNewState(sb), files(i))

				panel.Rows.Add(row)
			Next i
		End Sub

		#Region "GetInitialFiles"

		''' <summary>
		''' Gets a list of files from the user's system
		''' to initially load into the grid
		''' </summary>
		''' <param name="count"></param>
		''' <returns></returns>
		Private Function GetInitialFiles(ByVal count As Integer) As String()
			Dim n As Integer = 0
			Dim files(count - 1) As String

			For Each drive As DriveInfo In DriveInfo.GetDrives()
				If drive.DriveType = DriveType.Fixed Then
					Dim temp() As String = Directory.GetDirectories(drive.Name)

					For Each dir As String In temp
						Dim di As New DirectoryInfo(dir)

						If ((di.Attributes And FileAttributes.Hidden) = 0) AndAlso (di.Attributes And FileAttributes.System) = 0 Then
							n = GetFiles(files, dir, n)

							If n >= count Then
								Exit For
							End If
						End If
					Next dir
                End If

                If n >= count Then
                    Exit For
                End If

			Next drive

			For i As Integer = n To count - 1
				files(i) = ""
			Next i

			Return (files)
		End Function

		#Region "GetFiles"

		''' <summary>
		''' Gets a set of files from the users system
		''' to display in the grid
		''' </summary>
		''' <param name="files"></param>
		''' <param name="dir"></param>
		''' <param name="n"></param>
		''' <returns></returns>
		Private Function GetFiles(ByVal files() As String, ByVal dir As String, ByVal n As Integer) As Integer
			Dim count As Integer = files.Length

			Try
				Dim temp() As String = Directory.GetFiles(dir)

				For Each file As String In temp
					Dim fi As New FileInfo(file)

					If (fi.Attributes And (FileAttributes.Directory Or FileAttributes.Hidden Or FileAttributes.System)) = 0 Then
						files(n) = file
						n += 1

						If n >= count Then
							Exit For
						End If
					End If
				Next file
			Catch
			End Try

			Return (n)
		End Function

		#End Region

		#End Region

		#Region "GetNewState"

		Private Function GetNewState(ByVal sb As StringBuilder) As String
			Dim n As Integer = _Rand.Next(2, 7)

			sb.Length = 0

			For i As Integer = 0 To n - 1
				sb.Append(_Rand.Next(0, 5))
				sb.Append(",")
			Next i

			sb.Length -= 1

			Return (sb.ToString())
		End Function

		#End Region

		#End Region

		#Region "GridColorCombo"

		Public Class GridColorCombo
			Inherits GridComboBoxExEditControl
			Public Sub New(ByVal itemHeight As Integer)
				DisableInternalDrawing = True
				DropDownStyle = ComboBoxStyle.DropDownList
				ItemHeight = itemHeight

				For Each color As Color In _colors
					Items.Add(color.Name)
				Next color

				AddHandler DrawItem, AddressOf GridColorComboDrawItem
			End Sub

			#Region "CellRender"

			Public Overrides Sub CellRender(ByVal g As Graphics)
				Dim r As Rectangle = EditorCell.Bounds
				r.Height -= 1
				r.Width -= 1

				RenderItem(g, r, Color.FromName(Text))
			End Sub

			#End Region

			#Region "GetProposedSize"

			Public Overrides Function GetProposedSize(ByVal g As Graphics, ByVal cell As GridCell, ByVal style As CellVisualStyle, ByVal constraintSize As Size) As Size
				Dim size As Size = MyBase.GetProposedSize(g, cell, style, constraintSize)

				size.Width += 40

				Return (size)
			End Function

			#End Region

			#Region "GridColorComboDrawItem"

			Private Sub GridColorComboDrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs)
				If e.Index >= 0 Then
					e.DrawBackground()

					RenderItem(e.Graphics, e.Bounds, Color.FromName(_colors(e.Index Mod _colors.Length).Name))
				End If
			End Sub

			#End Region

			#Region "RenderItem"

			Private Sub RenderItem(ByVal g As Graphics, ByVal bounds As Rectangle, ByVal color As Color)
				Using br As Brush = New SolidBrush(color)
					bounds.Width -= 1
					bounds.Height -= 1

					Dim r As Rectangle = bounds
					r.Width = 30
					r.Inflate(-2, -2)

					g.FillRectangle(br, r)
					g.DrawRectangle(Pens.Black, r)

					r = bounds
					r.X += 30
					r.Width -= 30

					Using sf As New StringFormat()
						sf.LineAlignment = StringAlignment.Center

						g.DrawString(color.Name, Font, Brushes.Black, r, sf)
					End Using
				End Using
			End Sub

			#End Region
		End Class

		#End Region

		#Region "GridImageCombo"

		Public Class GridImageCombo
			Inherits GridComboBoxExEditControl
			Private _ImageList As ImageList

			Public Sub New(ByVal imageList As ImageList, ByVal itemHeight As Integer)
				_ImageList = imageList

				DisableInternalDrawing = True
				DropDownStyle = ComboBoxStyle.DropDownList
				ItemHeight = itemHeight

				For i As Integer = 0 To imageList.Images.Count - 1
					Items.Add(imageList.Images.Keys(i))
				Next i

				AddHandler DrawItem, AddressOf GridImageComboDrawItem
			End Sub

			#Region "CellRender"

			Public Overrides Sub CellRender(ByVal g As Graphics)
				Dim r As Rectangle = EditorCell.Bounds
				r.X += 4
				r.Width -= 4

				RenderItem(g, r, Text)
			End Sub

			#End Region

			#Region "GridImageComboDrawItem"

			Private Sub GridImageComboDrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs)
				If e.Index >= 0 Then
					e.DrawBackground()

					RenderItem(e.Graphics, e.Bounds, _ImageList.Images.Keys(e.Index))
				End If
			End Sub

			#End Region

			#Region "RenderItem"

			Private Sub RenderItem(ByVal g As Graphics, ByVal bounds As Rectangle, ByVal key As String)
				Dim image As Image = _ImageList.Images(key)

				If image IsNot Nothing Then
					Dim r As Rectangle = bounds
					r.Size = image.Size
					r.X += 2
					r.Y += (bounds.Height - r.Height) \ 2

					g.DrawImageUnscaled(image, r)

					r = bounds
					r.X += image.Width + 2
					r.Width -= image.Width + 2

					Using sf As New StringFormat()
						sf.LineAlignment = StringAlignment.Center

						g.DrawString(key, Font, Brushes.Black, r, sf)
					End Using
				End If
			End Sub

			#End Region
		End Class

		#End Region

		#Region "MyGridClipEditControl"

		Public Class MyGridClipEditControl
            Inherits GridClipEditControl

			#Region "Private variables"

			Private _Sp As SoundPlayer

			#End Region

			#Region "ContentDoubleClick"

			''' <summary>
			''' Handles user double-clicks
			''' </summary>
			''' <param name="sender"></param>
			''' <param name="e"></param>
			Protected Overrides Sub ContentDoubleClick(ByVal sender As Object, ByVal e As EventArgs)
				' Launch a comboBox
				' to let the user change audio clips.

				LaunchCombo(Nothing)

				MyBase.ContentDoubleClick(sender, e)
			End Sub

			#End Region

			#Region "BtnPlayClick"

			''' <summary>
			''' Handles user "play clip" button clicks
			''' </summary>
			''' <param name="sender"></param>
			''' <param name="e"></param>
			Protected Overrides Sub BtnPlayClick(ByVal sender As Object, ByVal e As EventArgs)
				' Play the audio clip

				If EditorCell.Value IsNot Nothing Then
                    Using stream As Stream = CType(ShellServices.GetResource("SuperGridDemo." & EditorCell.Value & ".wav"), Stream)
                        If stream IsNot Nothing Then
                            If _Sp Is Nothing Then
                                _Sp = New SoundPlayer()
                            End If

                            _Sp.Stream = stream
                            _Sp.Play()
                        End If
                    End Using
				End If

				MyBase.BtnPlayClick(sender, e)
			End Sub

			#End Region

			#Region "BtnStopClick"

			''' <summary>
			''' Handles user "Stop clip" button clicks
			''' </summary>
			''' <param name="sender"></param>
			''' <param name="e"></param>
			Protected Overrides Sub BtnStopClick(ByVal sender As Object, ByVal e As EventArgs)
				' Stop the audio clip

				_Sp.Stop()

				MyBase.BtnStopClick(sender, e)
			End Sub

			#End Region

			#Region "OnKeyDown"

			''' <summary>
			''' Handles user key presses
			''' </summary>
			''' <param name="e"></param>
			Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
				' Launch a comboBox
				' to let the user change audio clips.

				LaunchCombo(e)

				MyBase.OnKeyDown(e)
			End Sub

			#End Region

			#Region "LaunchCombo"

			''' <summary>
			''' Launches a "clip" comboBox to let the user select the
			''' cell clip.  It does this by temporarily setting the
			''' appropriate cell-level EditorType - and resets it when
			''' editing is complete.
			''' </summary>
			''' <param name="e"></param>
			Private Sub LaunchCombo(ByVal e As KeyEventArgs)
				' Set a new cell-level EditorType, and initialize
				' the combo dropdown with the available audio clips

				EditorCell.EditorType = GetType(MyGridComboBoxExEditControl)

				Dim cb As GridComboBoxExEditControl = TryCast(EditorCell.EditControl, GridComboBoxExEditControl)

				If cb IsNot Nothing Then
					cb.DisableInternalDrawing = True
					cb.DropDownStyle = ComboBoxStyle.DropDownList

					For Each clip As String In _Clips
						cb.Items.Add(clip)
					Next clip

					AddHandler cb.DrawItem, AddressOf GridClipControlDrawItem
				End If

				' Deactivate the current active editor, and initiate
				' an edit session on the newly set modal combo editor.

				EditorCell.SuperGrid.DeactivateNonModalEditor()
				EditorCell.BeginEdit(True, e)
			End Sub

			#End Region

			#Region "CellRender"

			''' <summary>
			''' Handles our user drawn rendering of the cell.
			''' </summary>
			''' <param name="g"></param>
			Public Overrides Sub CellRender(ByVal g As Graphics)
				' Nudge our text over a little so it more closely
				' aligns with the ComboBox text (when active)

				Dim r As Rectangle = EditorCell.Bounds
				r.X += 4
				r.Width -= 4

				' Render the item

				RenderItem(g, r, Text)
			End Sub

			#End Region

			#Region "GridClipControlDrawItem"

			''' <summary>
			''' Handles ComboBox item draw requests
			''' </summary>
			''' <param name="sender"></param>
			''' <param name="e"></param>
			Private Sub GridClipControlDrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs)
				If e.Index >= 0 Then
					e.DrawBackground()

					Dim cbx As ComboBoxEx = TryCast(sender, ComboBoxEx)

					If cbx IsNot Nothing Then
						RenderItem(e.Graphics, e.Bounds, _Clips(e.Index Mod _Clips.Length))
					End If
				End If
			End Sub

			#End Region

			#Region "RenderItem"

			''' <summary>
			''' Renders the given item
			''' </summary>
			''' <param name="g"></param>
			''' <param name="bounds"></param>
			''' <param name="text"></param>
			Private Sub RenderItem(ByVal g As Graphics, ByVal bounds As Rectangle, ByVal text As String)
				Dim style As CellVisualStyle = EditorCell.GetEffectiveStyle()

				Using sf As New StringFormat()
					g.SmoothingMode = SmoothingMode.AntiAlias

					sf.LineAlignment = StringAlignment.Center

					Using br As Brush = New SolidBrush(style.TextColor)
						g.DrawString(text, style.Font, br, bounds, sf)
					End Using
				End Using
			End Sub

			#End Region
		End Class

		#End Region

		#Region "MyGridComboBoxExEditControl"

		''' <summary>
		''' My special GridComboBoxExEditControl that does nothing more
		''' than receive notification when the combo edit session has
		''' completed, so that it can reset the cell-level EditorType
		''' back to its default null state.
		''' </summary>
		Public Class MyGridComboBoxExEditControl
			Inherits GridComboBoxExEditControl
			#Region "CancelEdit"

			''' <summary>
			''' Handles used edit cancels
			''' </summary>
			''' <returns></returns>
			Public Overrides Function CancelEdit() As Boolean
				ResetEdit()

				Return (MyBase.CancelEdit())
			End Function

			#End Region

			#Region "EndEdit"

			''' <summary>
			''' Handles user end edits
			''' </summary>
			''' <returns></returns>
			Public Overrides Function EndEdit() As Boolean
				ResetEdit()

				Return (MyBase.EndEdit())
			End Function

			#End Region

			#Region "ResetEdit"

			''' <summary>
			''' Reset the cell-level EditorType back to
			''' its null state (column setting will then be used)
			''' </summary>
			Private Sub ResetEdit()
				EditorCell.EditorType = Nothing
			End Sub

			#End Region
		End Class

		#End Region

		#Region "SuperGridControl1ColumnHeaderClick"

		''' <summary>
		''' This routine shows a simple example of processing
		''' the MouseClick in the style defined header image.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1ColumnHeaderClick(ByVal sender As Object, ByVal e As GridColumnHeaderClickEventArgs) Handles superGridControl1.ColumnHeaderClick
			Dim header As GridColumnHeader = e.GridPanel.ColumnHeader
			Dim r As Rectangle = header.GetImageBounds(e.GridColumn)

			Dim pt As Point = MousePosition
			pt = e.GridColumn.SuperGrid.PointToClient(pt)

			' If the user clicked in the header image, then instead
			' of sorting the column, let's redefine every cell in the
			' column to contain a visible state pattern.

			If r.Contains(pt) = True Then
				Dim k As Integer = CInt(Fix(header.Tag))
				k += 1
				header.Tag = k

				For i As Integer = 0 To e.GridPanel.Rows.Count - 1
					Dim row As GridRow = TryCast(e.GridPanel.Rows(i), GridRow)

					If row IsNot Nothing Then
						Dim n As Integer = (k + i) Mod 8

						If (k + i) Mod 16 >= 8 Then
							n = 8 - n
						End If

						row.Cells(3).Value = "0,1,2,3,4,3,2,1,0".Substring(n << 1)
					End If
				Next i

				e.Cancel = True
			End If
		End Sub

		#End Region

		#Region "SuperGridControl1MouseMove"

		''' <summary>
		''' Gives column 3 (Process State) some extra feedback 
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles superGridControl1.MouseMove
			Dim sg As SuperGridControl = TryCast(sender, SuperGridControl)

			If sg IsNot Nothing Then
				Dim header As GridColumnHeader = TryCast(sg.GetElementAt(e.Location), GridColumnHeader)

				If header IsNot Nothing Then
					Dim pt As Point = header.SuperGrid.PointToClient(MousePosition)
					Dim column As GridColumn = header.GetHitColumn(pt)

					If column IsNot Nothing AndAlso column.ColumnIndex = 3 Then
						Dim r As Rectangle = header.GetImageBounds(column)

						If r.Contains(pt) = True Then
							If column.HeaderStyles.MouseOver.ImageIndex < 0 Then
								column.HeaderStyles.MouseOver.ImageIndex = 7
							End If
						Else
							If column.HeaderStyles.MouseOver.ImageIndex >= 0 Then
								column.HeaderStyles.MouseOver.ImageIndex = -1
							End If
						End If
					End If
				End If
			End If
		End Sub

		#End Region
	End Class
End Namespace