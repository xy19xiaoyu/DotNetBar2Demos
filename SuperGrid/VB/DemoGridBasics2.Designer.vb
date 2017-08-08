Namespace SuperGridDemo
	Partial Public Class DemoGridBasics2
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
            Dim Padding1 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim GridColumn1 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DemoGridBasics2))
            Dim GridColumn2 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn3 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn4 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding2 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim GridColumn5 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding3 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim BackColorBlend1 As DevComponents.DotNetBar.SuperGrid.Style.BackColorBlend = New DevComponents.DotNetBar.SuperGrid.Style.BackColorBlend
            Dim BorderPattern1 As DevComponents.DotNetBar.SuperGrid.Style.BorderPattern = New DevComponents.DotNetBar.SuperGrid.Style.BorderPattern
            Dim Padding4 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Padding5 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.cbxAltRowStyle = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.cbxAltColStyle = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.cbxTreeButtons = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.cbxHeaderImages = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.btnExpandAll = New DevComponents.DotNetBar.ButtonX
            Me.btnCollapseAll = New DevComponents.DotNetBar.ButtonX
            Me.superGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl
            Me.comboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx
            Me.labelX1 = New DevComponents.DotNetBar.LabelX
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
            Me.richTextBox1.TabIndex = 3
            Me.richTextBox1.TabStop = False
            Me.richTextBox1.Text = ""
            '
            'cbxAltRowStyle
            '
            Me.cbxAltRowStyle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.cbxAltRowStyle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.cbxAltRowStyle.Location = New System.Drawing.Point(193, 555)
            Me.cbxAltRowStyle.Name = "cbxAltRowStyle"
            Me.cbxAltRowStyle.Size = New System.Drawing.Size(160, 23)
            Me.cbxAltRowStyle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxAltRowStyle.TabIndex = 5
            Me.cbxAltRowStyle.Text = "Use Alternate Row Style"
            '
            'cbxAltColStyle
            '
            Me.cbxAltColStyle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.cbxAltColStyle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.cbxAltColStyle.Location = New System.Drawing.Point(193, 583)
            Me.cbxAltColStyle.Name = "cbxAltColStyle"
            Me.cbxAltColStyle.Size = New System.Drawing.Size(160, 23)
            Me.cbxAltColStyle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxAltColStyle.TabIndex = 6
            Me.cbxAltColStyle.Text = "Use Alternate Column Style"
            '
            'cbxTreeButtons
            '
            Me.cbxTreeButtons.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.cbxTreeButtons.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.cbxTreeButtons.Location = New System.Drawing.Point(14, 555)
            Me.cbxTreeButtons.Name = "cbxTreeButtons"
            Me.cbxTreeButtons.Size = New System.Drawing.Size(173, 23)
            Me.cbxTreeButtons.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxTreeButtons.TabIndex = 7
            Me.cbxTreeButtons.Text = "Set Tree Buttons"
            '
            'cbxHeaderImages
            '
            Me.cbxHeaderImages.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.cbxHeaderImages.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.cbxHeaderImages.Location = New System.Drawing.Point(14, 583)
            Me.cbxHeaderImages.Name = "cbxHeaderImages"
            Me.cbxHeaderImages.Size = New System.Drawing.Size(173, 23)
            Me.cbxHeaderImages.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxHeaderImages.TabIndex = 8
            Me.cbxHeaderImages.Text = "Show Column Header Images"
            '
            'btnExpandAll
            '
            Me.btnExpandAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnExpandAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnExpandAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnExpandAll.Location = New System.Drawing.Point(573, 560)
            Me.btnExpandAll.Name = "btnExpandAll"
            Me.btnExpandAll.Size = New System.Drawing.Size(152, 20)
            Me.btnExpandAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnExpandAll.TabIndex = 9
            Me.btnExpandAll.Text = "Expand All Rows"
            '
            'btnCollapseAll
            '
            Me.btnCollapseAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnCollapseAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnCollapseAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnCollapseAll.Location = New System.Drawing.Point(573, 586)
            Me.btnCollapseAll.Name = "btnCollapseAll"
            Me.btnCollapseAll.Size = New System.Drawing.Size(152, 20)
            Me.btnCollapseAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnCollapseAll.TabIndex = 10
            Me.btnCollapseAll.Text = "Collapse All Rows"
            '
            'superGridControl1
            '
            Me.superGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Padding1.Bottom = 2
            Padding1.Left = 2
            Padding1.Right = 2
            Padding1.Top = 2
            Me.superGridControl1.DefaultVisualStyles.CellStyles.Default.Margin = Padding1
            Me.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
            Me.superGridControl1.Location = New System.Drawing.Point(0, 123)
            Me.superGridControl1.Name = "superGridControl1"
            Me.superGridControl1.PrimaryGrid.Caption.Text = "Numeric related Input Cell Editors"
            Me.superGridControl1.PrimaryGrid.ColumnHeader.ShowHeaderImages = False
            GridColumn1.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
            GridColumn1.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
            GridColumn1.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl)
            GridColumn1.FillWeight = 140
            GridColumn1.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            GridColumn1.Name = "DateTimeInput"
            GridColumn2.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
            GridColumn2.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn2.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridDateTimePickerEditControl)
            GridColumn2.FillWeight = 170
            GridColumn2.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
            GridColumn2.Name = "DateTimePicker"
            GridColumn3.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
            GridColumn3.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            GridColumn3.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridNumericUpDownEditControl)
            GridColumn3.FillWeight = 130
            GridColumn3.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
            GridColumn3.Name = "NumericUpDown"
            GridColumn4.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
            GridColumn4.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            GridColumn4.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl)
            GridColumn4.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
            GridColumn4.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.BottomCenter
            Padding2.Bottom = 8
            Padding2.Left = 4
            Padding2.Right = 4
            Padding2.Top = 4
            GridColumn4.HeaderStyles.Default.ImagePadding = Padding2
            GridColumn4.Name = "IntegerInput"
            GridColumn5.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
            GridColumn5.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            GridColumn5.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl)
            GridColumn5.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
            Padding3.Bottom = 8
            Padding3.Left = 4
            Padding3.Right = 4
            Padding3.Top = 4
            GridColumn5.HeaderStyles.Default.ImagePadding = Padding3
            GridColumn5.Name = "DoubleInput"
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn1)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn2)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn3)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn4)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn5)
            Me.superGridControl1.PrimaryGrid.DefaultRowHeight = 30
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[False]
            BackColorBlend1.Colors = New System.Drawing.Color() {System.Drawing.Color.SkyBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.SteelBlue, System.Drawing.Color.Aqua}
            Background1.BackColorBlend = BackColorBlend1
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Background = Background1
            BorderPattern1.Bottom = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.DashDotDot
            BorderPattern1.Left = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.DashDotDot
            BorderPattern1.Right = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.DashDotDot
            BorderPattern1.Top = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.DashDotDot
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.BorderPattern = BorderPattern1
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Padding4.Bottom = 6
            Padding4.Left = 6
            Padding4.Right = 6
            Padding4.Top = 6
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Margin = Padding4
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.TextColor = System.Drawing.Color.White
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.BottomCenter
            Padding5.Bottom = 4
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.ImagePadding = Padding5
            Me.superGridControl1.PrimaryGrid.FilterExpr = Nothing
            Me.superGridControl1.PrimaryGrid.RowHeaderWidth = 50
            Me.superGridControl1.PrimaryGrid.ShowRowGridIndex = True
            Me.superGridControl1.PrimaryGrid.ShowTreeButtons = True
            Me.superGridControl1.PrimaryGrid.ShowTreeLines = True
            Me.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
            Me.superGridControl1.Size = New System.Drawing.Size(784, 422)
            Me.superGridControl1.TabIndex = 0
            Me.superGridControl1.Text = "superGridControl1"
            '
            'comboBoxEx1
            '
            Me.comboBoxEx1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.comboBoxEx1.DisplayMember = "Text"
            Me.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.comboBoxEx1.FormattingEnabled = True
            Me.comboBoxEx1.ItemHeight = 14
            Me.comboBoxEx1.Location = New System.Drawing.Point(399, 583)
            Me.comboBoxEx1.Name = "comboBoxEx1"
            Me.comboBoxEx1.Size = New System.Drawing.Size(121, 20)
            Me.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.comboBoxEx1.TabIndex = 11
            '
            'labelX1
            '
            Me.labelX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX1.Location = New System.Drawing.Point(399, 561)
            Me.labelX1.Name = "labelX1"
            Me.labelX1.Size = New System.Drawing.Size(96, 19)
            Me.labelX1.TabIndex = 12
            Me.labelX1.Text = "Sort Level"
            '
            'styleManager1
            '
            Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
            Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
            '
            'DemoGridBasics2
            '
            Me.ClientSize = New System.Drawing.Size(784, 621)
            Me.Controls.Add(Me.labelX1)
            Me.Controls.Add(Me.comboBoxEx1)
            Me.Controls.Add(Me.btnCollapseAll)
            Me.Controls.Add(Me.btnExpandAll)
            Me.Controls.Add(Me.cbxHeaderImages)
            Me.Controls.Add(Me.cbxTreeButtons)
            Me.Controls.Add(Me.cbxAltColStyle)
            Me.Controls.Add(Me.cbxAltRowStyle)
            Me.Controls.Add(Me.superGridControl1)
            Me.Controls.Add(Me.richTextBox1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "DemoGridBasics2"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SuperGrid Demo - Numeric Related Control Types"
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private richTextBox1 As RichTextBox
		Private superGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
		Private WithEvents cbxAltRowStyle As DevComponents.DotNetBar.Controls.CheckBoxX
		Private WithEvents cbxAltColStyle As DevComponents.DotNetBar.Controls.CheckBoxX
		Private WithEvents cbxTreeButtons As DevComponents.DotNetBar.Controls.CheckBoxX
		Private WithEvents cbxHeaderImages As DevComponents.DotNetBar.Controls.CheckBoxX
		Private WithEvents btnExpandAll As DevComponents.DotNetBar.ButtonX
		Private WithEvents btnCollapseAll As DevComponents.DotNetBar.ButtonX
		Private WithEvents comboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
        Private labelX1 As DevComponents.DotNetBar.LabelX
        Private WithEvents styleManager1 As DevComponents.DotNetBar.StyleManager
	End Class
End Namespace