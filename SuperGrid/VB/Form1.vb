Imports DevComponents.DotNetBar.SuperGrid

Namespace SuperGridDemo
	Partial Public Class Form1
        Inherits DevComponents.DotNetBar.Office2007Form
		Public Sub New()
			InitializeComponent()

			InitializeGrid()

            ShellServices.LoadRtbText(rtb, "SuperGridDemo.Welcome.rtf")
		End Sub

		#Region "InitializeGrid"

		''' <summary>
		''' Initializes our base SuperGrid
		''' </summary>
		Private Sub InitializeGrid()
			Dim panel As GridPanel = superGridControl1.PrimaryGrid

			InitRowTags(panel)

			panel.SetGroup(panel.Columns(0), SortDirection.None)

			panel.ShowGroupExpand = False
			panel.ShowGroupUnderline = False

			AddHandler superGridControl1.ColumnGrouped, AddressOf SuperGridControl1ColumnGrouped

			superGridControl1.ArrangeGrid()

			panel.ExpandAll()
		End Sub

		#Region "InitRowTags"

		''' <summary>
		''' Initialize each row Tag to the demo
		''' application to run when executed
		''' </summary>
		''' <param name="panel"></param>
		Private Sub InitRowTags(ByVal panel As GridPanel)
			panel.Rows(0).Tag = GetType(DemoGridArchitecture)

			panel.Rows(1).Tag = GetType(DemoGridBasics0)
			panel.Rows(2).Tag = GetType(DemoGridBasics1)
			panel.Rows(3).Tag = GetType(DemoGridBasics2)
			panel.Rows(4).Tag = GetType(DemoGridBasics3)
			panel.Rows(5).Tag = GetType(DemoGridBasics4)
			panel.Rows(6).Tag = GetType(DemoGridBasics5)

			panel.Rows(7).Tag = GetType(DemoGridBinding)
			panel.Rows(8).Tag = GetType(DemoMasterDetail)
			panel.Rows(9).Tag = GetType(DemoNested)
			panel.Rows(10).Tag = GetType(DemoVirtualMode)

			panel.Rows(11).Tag = GetType(DemoBasicFiltering)
			panel.Rows(12).Tag = GetType(DemoExtendedFiltering)

			panel.Rows(13).Tag = GetType(DemoFileExplorer)
			panel.Rows(14).Tag = GetType(DemoSpreadsheet)
			panel.Rows(15).Tag = GetType(DemoUserEdit)
			panel.Rows(16).Tag = GetType(DemoDragDrop)
		End Sub

		#End Region

		#End Region

		#Region "SuperGridControl1ColumnGrouped"

		''' <summary>
		''' This routine is called when the column grouping
		''' is completed. This gives us the opportunity to set
		''' (or reset) any grid property that we need to pertaining
		''' to the newly established group rows.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1ColumnGrouped(ByVal sender As Object, ByVal e As GridColumnGroupedEventArgs)
			Dim s As String = e.GridGroup.Text

			Select Case s
				Case "0"
					e.GridGroup.Text = "Architecture"

				Case "1"
					e.GridGroup.Text = "Edit and Render Controls"

				Case "2"
					e.GridGroup.Text = "Data"

				Case "3"
					e.GridGroup.Text = "Filtering"

				Case "4"
					e.GridGroup.Text = "Samples"
			End Select
		End Sub

		#End Region

		#Region "SuperGridControl1MouseDoubleClick"

		''' <summary>
		''' Called when an item is double clicked.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles superGridControl1.MouseDoubleClick
			LaunchDemoItem()
		End Sub

		#End Region

		#Region "SuperGridControl1KeyDown"

		''' <summary>
		''' Called on key down to catch the enter key
		''' so we can launch the demo apps via the keyboard
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub SuperGridControl1KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles superGridControl1.KeyDown
			If e.KeyData = Keys.Enter Then
				LaunchDemoItem()
			End If
		End Sub

		#End Region

		#Region "LaunchDemoItem"

		''' <summary>
		''' Performs the launching / execution of 
		''' the individual demo sample apps
		''' </summary>
		Private Sub LaunchDemoItem()
			Dim row As GridRow = TryCast(superGridControl1.PrimaryGrid.ActiveRow, GridRow)

			If row IsNot Nothing Then
				Dim type As Type = TryCast(row.Tag, Type)

				If type IsNot Nothing Then
					Cursor.Current = Cursors.WaitCursor

                    Dim form As Form = CType(Activator.CreateInstance(type), Form)

                    If type IsNot GetType(DemoBasicFiltering) And type IsNot GetType(DemoExtendedFiltering) Then
                        form.Icon = Icon
                    End If

                    form.Show(Me)
                    form.Activate()
                End If
            End If
		End Sub

		#End Region

		#Region "BtnCloseClick"

		''' <summary>
		''' Closes the form.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub BtnCloseClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
			Close()
		End Sub

		#End Region
	End Class
End Namespace