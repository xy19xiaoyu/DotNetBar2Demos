Imports System.Drawing.Drawing2D
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Namespace SuperGridDemo
	Partial Public Class DemoGridBasics4
        Inherits DevComponents.DotNetBar.Office2007Form
		#Region "Private variables"

		Private _Rand As New Random()
		Private _ShowProgressBugs As Boolean

		#End Region

		Public Sub New()
			InitializeComponent()

			' Initialize the grid, GridLines
			' ComboBox, and the sample description text.

			InitializeGrid()
			InitGridLinesComboBox()

            ShellServices.LoadRtbText(richTextBox1, "SuperGridDemo.DemoBasics4.rtf")
        End Sub

#Region "InitializeGrid"

        ''' <summary>
        ''' Initializes the default grid
        ''' </summary>
        Private Sub InitializeGrid()
            Dim panel As GridPanel = superGridControl1.PrimaryGrid

            ' Set both the Slider and SitchButton columns to
            ' our own defined EditControls

            Dim column As GridColumn = panel.Columns("Slider")
            column.EditorType = GetType(MyGridSliderEditControl)

            column = panel.Columns("SwitchButton")
            column.EditorType = GetType(MyGridSwitchButtonEditControl)

            ' Add 30 rows for the user to play around with

            For i As Integer = 0 To 29
                AddNewRow(panel)
            Next i
        End Sub

#Region "AddNewRow"

        ''' <summary>
        ''' Adds a new row to the grid
        ''' </summary>
        ''' <param name="panel"></param>
        Private Sub AddNewRow(ByVal panel As GridPanel)
            Dim o(3) As Object

            o(0) = _Rand.Next(0, 100)
            o(1) = _Rand.Next(0, 100)
            o(2) = (_Rand.Next(0, 100) Mod 2 = 0)
            o(3) = (_Rand.Next(0, 100) Mod 2 = 0)

            Dim row As New GridRow(o)

            panel.Rows.Add(row)
        End Sub

#End Region

#End Region

#Region "InitGridLinesComboBox"

        ''' <summary>
        ''' Initializes the GridLines ComboBox
        ''' </summary>
        Private Sub InitGridLinesComboBox()
            For Each s As String In System.Enum.GetNames(GetType(GridLines))
                cbxGridLines.Items.Add(s)
            Next s

            cbxGridLines.SelectedIndex = 3

            For Each s As String In System.Enum.GetNames(GetType(LinePattern))
                cbxHLinePattern.Items.Add(s)
                cbxVLinePattern.Items.Add(s)
            Next s

            cbxHLinePattern.SelectedIndex = 2
            cbxVLinePattern.SelectedIndex = 2
        End Sub

#End Region

#Region "SuperGridControl1GetRenderer"

        ''' <summary>
        ''' This routine is called to dynamically obtain the
        ''' renderer control for the given cell.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub SuperGridControl1GetRenderer(ByVal sender As Object, ByVal e As GridGetRendererEventArgs) Handles superGridControl1.GetRenderer
            Dim columnIndex As Integer = e.GridCell.ColumnIndex

            ' Just as an example, lets have all CheckBox cells, whose
            ' adjacent SwitchButton cell is 'true', to render as a textual
            ' value, instead of the normal checkbox display.

            If columnIndex = 3 Then
                Dim scell As GridCell = e.GridCell.GridRow.Cells(2)

                e.RenderType = IIf(CBool(scell.Value) = True, GetType(GridTextBoxXEditControl), Nothing)
            End If
        End Sub

#End Region

#Region "SuperGridControl1PostRenderCell"

        ''' <summary>
        ''' This routine is called after each
        ''' RenderPart has been rendered by the grid, in order
        ''' to permit the application to render additional
        ''' visuals to the cell part.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub SuperGridControl1PostRenderCell(ByVal sender As Object, ByVal e As GridPostRenderCellEventArgs) Handles superGridControl1.PostRenderCell
            If e.GridCell.ColumnIndex = 0 Then
                If _ShowProgressBugs = True Then
                    RenderProgressBugs(e)
                End If
            ElseIf e.GridCell.ColumnIndex = 1 Then
                RenderSliderBackground(e)
            End If
        End Sub

#Region "RenderSliderBackground"

        ''' <summary>
        ''' Renders the slider background
        ''' </summary>
        ''' <param name="e"></param>
        Private Sub RenderSliderBackground(ByVal e As GridPostRenderCellEventArgs)
            If (e.RenderParts And RenderParts.Background) = RenderParts.Background Then
                ' Render a Red gradient background for
                ' the slider if the cell Value is > 75

                If CInt(Fix(e.GridCell.Value)) > 75 Then
                    Using br As Brush = New LinearGradientBrush(e.Bounds, Color.Transparent, Color.Red, 0.0F)
                        e.Graphics.FillRectangle(br, e.Bounds)
                    End Using
                End If
            End If
        End Sub

#End Region

#Region "RenderProgressBugs"

        ''' <summary>
        ''' Renders ProgressBar bugs
        ''' </summary>
        ''' <param name="e"></param>
        Private Sub RenderProgressBugs(ByVal e As GridPostRenderCellEventArgs)
            If (e.RenderParts And RenderParts.Content) = RenderParts.Content Then
                Dim pbx As GridProgressBarXEditControl = TryCast(e.GridCell.GridColumn.EditControl, GridProgressBarXEditControl)

                If pbx IsNot Nothing Then
                    Using image As Image = ShellServices.LoadBitmap("SuperGridDemo.BugRight.png")
                        If image IsNot Nothing Then
                            Dim r As Rectangle = e.Bounds
                            r.Inflate(-3, -3)

                            r.Y += ((e.Bounds.Height - image.Height) / 2) - 2
                            r.Size = image.Size

                            Dim value As Integer = CInt(Fix(e.GridCell.Value))
                            Dim n As Integer = CInt(Fix(e.Bounds.Width * (CSng(value) / pbx.Maximum)))
                            Dim count As Integer = n \ image.Width

                            For i As Integer = 0 To count - 1
                                e.Graphics.DrawImage(image, r)

                                r.X += image.Width
                            Next i
                        End If
                    End Using
                End If
            End If
        End Sub

#End Region

#End Region

		#Region "MyGridSwitchButtonEditControl"

		''' <summary>
		''' GridSwitchButtonEditControl with the ability to catch when
		''' the switch changes (just another way to be notified when
		''' a cell value changes)
		''' </summary>
		Private Class MyGridSwitchButtonEditControl
			Inherits GridSwitchButtonEditControl
			Public Sub New()
				' Lets have this one only stretch horizontally
				' and not vertically as well

				StretchBehavior = StretchBehavior.HorizontalOnly

				AddHandler ValueChanged, AddressOf MyGridSwitchButtonEditControlValueChanged
			End Sub

			#Region "MyGridSwitchButtonEditControlValueChanged"

			Private Sub MyGridSwitchButtonEditControlValueChanged(ByVal sender As Object, ByVal e As EventArgs)
				' Refresh the adjacent CheckBoxes
				' to reflect the new switch state

				Dim cell As GridCell = EditorCell

				If cell IsNot Nothing Then
					cell.GridRow.Cells(3).InvalidateRender()
				End If
			End Sub

			#End Region
		End Class

		#End Region

		#Region "MyGridSliderEditControl"

		''' <summary>
		''' GridSliderEditControl where we are enabling the slider
		''' label and setting the label to reflect the cell value
		''' </summary>
		Private Class MyGridSliderEditControl
			Inherits GridSliderEditControl
			Public Sub New()
				LabelVisible = True
			End Sub

			#Region "InitializeContext"

			''' <summary>
			''' Handles the setting of the slider text to 
			''' match the current cell value
			''' </summary>
			''' <param name="cell"></param>
			''' <param name="style"></param>
			Public Overrides Sub InitializeContext(ByVal cell As GridCell, ByVal style As CellVisualStyle)
				MyBase.InitializeContext(cell, style)

				Text = ((CSng(Value) / Maximum) * 100).ToString()
			End Sub

			#End Region
		End Class

		#End Region

		#Region "CbxProgressBugsCheckedChanged"

		''' <summary>
		''' Handles user requests to show
		''' (or not) bugs over the ProgressBar.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxProgressBugsCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxProgressBugs.CheckedChanged
			_ShowProgressBugs = cbxProgressBugs.Checked

			' Refresh the column to reflect the change

			superGridControl1.PrimaryGrid.Columns(0).InvalidateRender()
		End Sub

		#End Region

		#Region "CbxGridLinesSelectedIndexChanged"

		''' <summary>
		''' Handles user changes in the GridLines display
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxGridLinesSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxGridLines.SelectedIndexChanged
			If cbxGridLines.SelectedIndex >= 0 Then
				superGridControl1.PrimaryGrid.GridLines = CType(System.Enum.Parse(GetType(GridLines), CStr(cbxGridLines.SelectedItem)), GridLines)
			End If
		End Sub

		#End Region

		#Region "CbxHLinePatternSelectedIndexChanged"

		''' <summary>
		''' Handles user changes in the Horizontal LinePatter
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxHLinePatternSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxHLinePattern.SelectedIndexChanged
			superGridControl1.DefaultVisualStyles.GridPanelStyle.HorizontalLinePattern = CType(System.Enum.Parse(GetType(LinePattern), CStr(cbxHLinePattern.SelectedItem)), LinePattern)
		End Sub

		#End Region

		#Region "CbxVLinePatternSelectedIndexChanged"

		''' <summary>
		''' Handles user changes in the Vertical LinePatter
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CbxVLinePatternSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxVLinePattern.SelectedIndexChanged
			superGridControl1.DefaultVisualStyles.GridPanelStyle.VerticalLinePattern = CType(System.Enum.Parse(GetType(LinePattern), CStr(cbxVLinePattern.SelectedItem)), LinePattern)
		End Sub

		#End Region
	End Class
End Namespace