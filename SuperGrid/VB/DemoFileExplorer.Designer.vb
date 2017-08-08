Namespace SuperGridDemo
	Partial Public Class DemoFileExplorer
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim Background2 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim Background3 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim GridColumn1 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn2 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding1 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim GridColumn3 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding2 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim GridColumn4 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding3 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim GridColumn5 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding4 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Background4 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim Background5 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim Background6 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim Background7 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim Background8 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim GridColumn6 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding5 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Padding6 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Background9 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DemoFileExplorer))
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.CbxGroupItems = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.superGridControl2 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl
            Me.superGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl
            Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
            Me.SuspendLayout()
            '
            'richTextBox1
            '
            Me.richTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.richTextBox1.BackColor = System.Drawing.SystemColors.Window
            Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.richTextBox1.Location = New System.Drawing.Point(4, 4)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.Size = New System.Drawing.Size(780, 113)
            Me.richTextBox1.TabIndex = 4
            Me.richTextBox1.Text = ""
            '
            'CbxGroupItems
            '
            Me.CbxGroupItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.CbxGroupItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.CbxGroupItems.Location = New System.Drawing.Point(624, 531)
            Me.CbxGroupItems.Name = "CbxGroupItems"
            Me.CbxGroupItems.Size = New System.Drawing.Size(147, 23)
            Me.CbxGroupItems.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.CbxGroupItems.TabIndex = 9
            Me.CbxGroupItems.Text = "Group Items by Type"
            '
            'superGridControl2
            '
            Me.superGridControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Background1.Color1 = System.Drawing.Color.White
            Me.superGridControl2.DefaultVisualStyles.GridPanelStyle.Background = Background1
            Background2.Color1 = System.Drawing.Color.White
            Me.superGridControl2.DefaultVisualStyles.GroupHeaderStyles.Default.Background = Background2
            Me.superGridControl2.DefaultVisualStyles.GroupHeaderStyles.Default.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Background3.Color1 = System.Drawing.Color.White
            Me.superGridControl2.DefaultVisualStyles.GroupHeaderStyles.MouseOver.Background = Background3
            Me.superGridControl2.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
            Me.superGridControl2.Location = New System.Drawing.Point(274, 123)
            Me.superGridControl2.Name = "superGridControl2"
            Me.superGridControl2.PrimaryGrid.ColumnHeader.SortImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            GridColumn1.CellHighlightMode = DevComponents.DotNetBar.SuperGrid.Style.CellHighlightMode.Content
            GridColumn1.CellStyles.Default.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            GridColumn1.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.Multiple
            GridColumn1.Name = "Name"
            GridColumn1.Width = 200
            GridColumn2.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            Padding1.Left = 2
            Padding1.Right = 2
            GridColumn2.CellStyles.Default.Margin = Padding1
            GridColumn2.CellStyles.Default.TextColor = System.Drawing.Color.Gray
            GridColumn2.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.Multiple
            GridColumn2.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl)
            GridColumn2.Name = "Size"
            Padding2.Left = 2
            Padding2.Right = 2
            GridColumn3.CellStyles.Default.Margin = Padding2
            GridColumn3.CellStyles.Default.TextColor = System.Drawing.Color.Gray
            GridColumn3.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.Multiple
            GridColumn3.Name = "Type"
            GridColumn4.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            Padding3.Left = 2
            Padding3.Right = 2
            GridColumn4.CellStyles.Default.Margin = Padding3
            GridColumn4.CellStyles.Default.TextColor = System.Drawing.Color.Gray
            GridColumn4.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.Multiple
            GridColumn4.Name = "Date Created"
            GridColumn5.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            Padding4.Left = 2
            Padding4.Right = 2
            GridColumn5.CellStyles.Default.Margin = Padding4
            GridColumn5.CellStyles.Default.TextColor = System.Drawing.Color.Gray
            GridColumn5.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.Multiple
            GridColumn5.Name = "Date Modified"
            Me.superGridControl2.PrimaryGrid.Columns.Add(GridColumn1)
            Me.superGridControl2.PrimaryGrid.Columns.Add(GridColumn2)
            Me.superGridControl2.PrimaryGrid.Columns.Add(GridColumn3)
            Me.superGridControl2.PrimaryGrid.Columns.Add(GridColumn4)
            Me.superGridControl2.PrimaryGrid.Columns.Add(GridColumn5)
            Background4.Color1 = System.Drawing.Color.AliceBlue
            Background4.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
            Me.superGridControl2.PrimaryGrid.DefaultVisualStyles.CellStyles.MouseOver.Background = Background4
            Background5.Color1 = System.Drawing.Color.WhiteSmoke
            Me.superGridControl2.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.Background = Background5
            Me.superGridControl2.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.superGridControl2.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.TextColor = System.Drawing.Color.DimGray
            Background6.Color1 = System.Drawing.Color.White
            Me.superGridControl2.PrimaryGrid.DefaultVisualStyles.GroupHeaderStyles.Default.Background = Background6
            Background7.Color1 = System.Drawing.Color.White
            Me.superGridControl2.PrimaryGrid.DefaultVisualStyles.GroupHeaderStyles.MouseOver.Background = Background7
            Me.superGridControl2.PrimaryGrid.FilterExpr = Nothing
            Me.superGridControl2.PrimaryGrid.GridLines = DevComponents.DotNetBar.SuperGrid.GridLines.None
            Me.superGridControl2.PrimaryGrid.ImmediateResize = True
            Me.superGridControl2.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None
            Me.superGridControl2.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None
            Me.superGridControl2.PrimaryGrid.PrimaryColumnIndex = 2
            Me.superGridControl2.PrimaryGrid.ShowGroupExpand = False
            Me.superGridControl2.PrimaryGrid.ShowRowHeaders = False
            Me.superGridControl2.PrimaryGrid.SortLevel = CType((DevComponents.DotNetBar.SuperGrid.SortLevel.Root Or DevComponents.DotNetBar.SuperGrid.SortLevel.Expanded), DevComponents.DotNetBar.SuperGrid.SortLevel)
            Me.superGridControl2.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
            Me.superGridControl2.Size = New System.Drawing.Size(510, 398)
            Me.superGridControl2.TabIndex = 6
            Me.superGridControl2.Text = "superGridControl2"
            '
            'superGridControl1
            '
            Me.superGridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Background8.Color1 = System.Drawing.Color.White
            Me.superGridControl1.DefaultVisualStyles.GridPanelStyle.Background = Background8
            Me.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
            Me.superGridControl1.Location = New System.Drawing.Point(0, 123)
            Me.superGridControl1.Name = "superGridControl1"
            Me.superGridControl1.PrimaryGrid.ColumnHeader.Visible = False
            GridColumn6.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
            GridColumn6.CellHighlightMode = DevComponents.DotNetBar.SuperGrid.Style.CellHighlightMode.Content
            Padding5.Right = 4
            GridColumn6.CellStyles.Default.ImagePadding = Padding5
            Padding6.Bottom = 1
            Padding6.Top = 1
            GridColumn6.CellStyles.Default.Margin = Padding6
            Background9.BackFillType = DevComponents.DotNetBar.SuperGrid.Style.BackFillType.VerticalCenter
            Background9.Color1 = System.Drawing.Color.AliceBlue
            Background9.Color2 = System.Drawing.SystemColors.GradientInactiveCaption
            GridColumn6.CellStyles.MouseOver.Background = Background9
            GridColumn6.Name = "Column1"
            GridColumn6.ReadOnly = True
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn6)
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.HorizontalLineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.TreeLineColor = System.Drawing.Color.Gray
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.TreeLinePattern = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.Dot
            Me.superGridControl1.PrimaryGrid.FilterExpr = Nothing
            Me.superGridControl1.PrimaryGrid.RowDoubleClickBehavior = DevComponents.DotNetBar.SuperGrid.RowDoubleClickBehavior.ExpandCollapse
            Me.superGridControl1.PrimaryGrid.ShowColumnHeader = False
            Me.superGridControl1.PrimaryGrid.ShowRowHeaders = False
            Me.superGridControl1.PrimaryGrid.ShowTreeButtons = True
            Me.superGridControl1.PrimaryGrid.ShowTreeLines = True
            Me.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
            Me.superGridControl1.Size = New System.Drawing.Size(268, 434)
            Me.superGridControl1.TabIndex = 5
            Me.superGridControl1.Text = "superGridControl1"
            '
            'styleManager1
            '
            Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
            Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
            '
            'DemoFileExplorer
            '
            Me.ClientSize = New System.Drawing.Size(784, 562)
            Me.Controls.Add(Me.CbxGroupItems)
            Me.Controls.Add(Me.superGridControl2)
            Me.Controls.Add(Me.superGridControl1)
            Me.Controls.Add(Me.richTextBox1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "DemoFileExplorer"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SuperGrid Demo - Sample File Explorer"
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private richTextBox1 As RichTextBox
		Private WithEvents superGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
		Private WithEvents superGridControl2 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
        Private WithEvents CbxGroupItems As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents styleManager1 As DevComponents.DotNetBar.StyleManager
	End Class
End Namespace