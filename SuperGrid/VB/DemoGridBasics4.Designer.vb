Namespace SuperGridDemo
	Partial Public Class DemoGridBasics4
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
            Dim GridColumn1 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DemoGridBasics4))
            Dim GridColumn2 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding1 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Padding2 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim GridColumn3 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding3 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Padding4 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim GridColumn4 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding5 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.superGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl
            Me.cbxProgressBugs = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.cbxGridLines = New DevComponents.DotNetBar.Controls.ComboBoxEx
            Me.labelX1 = New DevComponents.DotNetBar.LabelX
            Me.labelX2 = New DevComponents.DotNetBar.LabelX
            Me.cbxHLinePattern = New DevComponents.DotNetBar.Controls.ComboBoxEx
            Me.labelX3 = New DevComponents.DotNetBar.LabelX
            Me.cbxVLinePattern = New DevComponents.DotNetBar.Controls.ComboBoxEx
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
            Me.richTextBox1.ReadOnly = True
            Me.richTextBox1.Size = New System.Drawing.Size(780, 113)
            Me.richTextBox1.TabIndex = 5
            Me.richTextBox1.TabStop = False
            Me.richTextBox1.Text = ""
            '
            'superGridControl1
            '
            Me.superGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
            Me.superGridControl1.Location = New System.Drawing.Point(0, 123)
            Me.superGridControl1.Name = "superGridControl1"
            GridColumn1.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridProgressBarXEditControl)
            GridColumn1.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            GridColumn1.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn1.Name = "ProgressBar"
            GridColumn1.Width = 200
            GridColumn2.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridSliderEditControl)
            GridColumn2.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
            GridColumn2.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.BottomCenter
            Padding1.Bottom = 10
            Padding1.Top = -10
            GridColumn2.HeaderStyles.Default.ImagePadding = Padding1
            Padding2.Top = 10
            GridColumn2.HeaderStyles.Default.Margin = Padding2
            GridColumn2.Name = "Slider"
            GridColumn2.Width = 150
            Padding3.Bottom = 2
            Padding3.Left = 2
            Padding3.Right = 2
            Padding3.Top = 2
            GridColumn3.CellStyles.Default.Margin = Padding3
            GridColumn3.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridSwitchButtonEditControl)
            GridColumn3.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
            GridColumn3.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.TopCenter
            Padding4.Bottom = -6
            Padding4.Top = 10
            GridColumn3.HeaderStyles.Default.ImagePadding = Padding4
            GridColumn3.Name = "SwitchButton"
            GridColumn3.Width = 150
            GridColumn4.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn4.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl)
            GridColumn4.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
            GridColumn4.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.BottomCenter
            GridColumn4.Name = "CheckBoxX"
            GridColumn4.Width = 150
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn1)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn2)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn3)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn4)
            Me.superGridControl1.PrimaryGrid.DefaultRowHeight = 0
            Padding5.Bottom = 4
            Padding5.Left = 4
            Padding5.Right = 4
            Padding5.Top = 4
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.Margin = Padding5
            Me.superGridControl1.PrimaryGrid.FilterExpr = Nothing
            Me.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
            Me.superGridControl1.Size = New System.Drawing.Size(784, 439)
            Me.superGridControl1.TabIndex = 0
            Me.superGridControl1.Text = "superGridControl1"
            '
            'cbxProgressBugs
            '
            Me.cbxProgressBugs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.cbxProgressBugs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.cbxProgressBugs.Location = New System.Drawing.Point(32, 576)
            Me.cbxProgressBugs.Name = "cbxProgressBugs"
            Me.cbxProgressBugs.Size = New System.Drawing.Size(133, 23)
            Me.cbxProgressBugs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxProgressBugs.TabIndex = 7
            Me.cbxProgressBugs.Text = "Show Progress Bugs"
            '
            'cbxGridLines
            '
            Me.cbxGridLines.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cbxGridLines.DisplayMember = "Text"
            Me.cbxGridLines.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cbxGridLines.FormattingEnabled = True
            Me.cbxGridLines.ItemHeight = 14
            Me.cbxGridLines.Location = New System.Drawing.Point(344, 580)
            Me.cbxGridLines.Name = "cbxGridLines"
            Me.cbxGridLines.Size = New System.Drawing.Size(137, 20)
            Me.cbxGridLines.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxGridLines.TabIndex = 8
            '
            'labelX1
            '
            Me.labelX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX1.Location = New System.Drawing.Point(266, 578)
            Me.labelX1.Name = "labelX1"
            Me.labelX1.Size = New System.Drawing.Size(72, 23)
            Me.labelX1.TabIndex = 9
            Me.labelX1.Text = "Grid Lines:"
            Me.labelX1.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'labelX2
            '
            Me.labelX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX2.Location = New System.Drawing.Point(487, 577)
            Me.labelX2.Name = "labelX2"
            Me.labelX2.Size = New System.Drawing.Size(121, 23)
            Me.labelX2.TabIndex = 11
            Me.labelX2.Text = "Horizontal Line Pattern:"
            Me.labelX2.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'cbxHLinePattern
            '
            Me.cbxHLinePattern.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cbxHLinePattern.DisplayMember = "Text"
            Me.cbxHLinePattern.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cbxHLinePattern.FormattingEnabled = True
            Me.cbxHLinePattern.ItemHeight = 14
            Me.cbxHLinePattern.Location = New System.Drawing.Point(614, 579)
            Me.cbxHLinePattern.Name = "cbxHLinePattern"
            Me.cbxHLinePattern.Size = New System.Drawing.Size(137, 20)
            Me.cbxHLinePattern.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxHLinePattern.TabIndex = 10
            '
            'labelX3
            '
            Me.labelX3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX3.Location = New System.Drawing.Point(487, 603)
            Me.labelX3.Name = "labelX3"
            Me.labelX3.Size = New System.Drawing.Size(121, 23)
            Me.labelX3.TabIndex = 13
            Me.labelX3.Text = "Vertical Line Pattern:"
            Me.labelX3.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'cbxVLinePattern
            '
            Me.cbxVLinePattern.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cbxVLinePattern.DisplayMember = "Text"
            Me.cbxVLinePattern.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cbxVLinePattern.FormattingEnabled = True
            Me.cbxVLinePattern.ItemHeight = 14
            Me.cbxVLinePattern.Location = New System.Drawing.Point(614, 605)
            Me.cbxVLinePattern.Name = "cbxVLinePattern"
            Me.cbxVLinePattern.Size = New System.Drawing.Size(137, 20)
            Me.cbxVLinePattern.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxVLinePattern.TabIndex = 12
            '
            'styleManager1
            '
            Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
            Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
            '
            'DemoGridBasics4
            '
            Me.ClientSize = New System.Drawing.Size(784, 632)
            Me.Controls.Add(Me.labelX3)
            Me.Controls.Add(Me.cbxVLinePattern)
            Me.Controls.Add(Me.labelX2)
            Me.Controls.Add(Me.cbxHLinePattern)
            Me.Controls.Add(Me.labelX1)
            Me.Controls.Add(Me.cbxGridLines)
            Me.Controls.Add(Me.cbxProgressBugs)
            Me.Controls.Add(Me.superGridControl1)
            Me.Controls.Add(Me.richTextBox1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "DemoGridBasics4"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SuperGrid Demo - ProgressBar, Slider, SwitchButton, and CheckBox Control Types"
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private richTextBox1 As RichTextBox
		Private WithEvents superGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
		Private WithEvents cbxProgressBugs As DevComponents.DotNetBar.Controls.CheckBoxX
		Private WithEvents cbxGridLines As DevComponents.DotNetBar.Controls.ComboBoxEx
		Private labelX1 As DevComponents.DotNetBar.LabelX
		Private labelX2 As DevComponents.DotNetBar.LabelX
		Private WithEvents cbxHLinePattern As DevComponents.DotNetBar.Controls.ComboBoxEx
		Private labelX3 As DevComponents.DotNetBar.LabelX
        Private WithEvents cbxVLinePattern As DevComponents.DotNetBar.Controls.ComboBoxEx
        Private WithEvents styleManager1 As DevComponents.DotNetBar.StyleManager
	End Class
End Namespace