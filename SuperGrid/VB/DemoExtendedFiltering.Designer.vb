Namespace SuperGridDemo
	Partial Public Class DemoExtendedFiltering
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
            Dim GridColumn2 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn3 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn4 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn5 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn6 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DemoExtendedFiltering))
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.labelX4 = New DevComponents.DotNetBar.LabelX
            Me.labelX3 = New DevComponents.DotNetBar.LabelX
            Me.labelX1 = New DevComponents.DotNetBar.LabelX
            Me.labelX2 = New DevComponents.DotNetBar.LabelX
            Me.cbFilterLevel = New DevComponents.DotNetBar.Controls.ComboBoxEx
            Me.cbFilterImageVisibility = New DevComponents.DotNetBar.Controls.ComboBoxEx
            Me.cbxUseAgeSlider = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.cbxShowPanelExpr = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.cbFilterAlignment = New DevComponents.DotNetBar.Controls.ComboBoxEx
            Me.cbMatchType = New DevComponents.DotNetBar.Controls.ComboBoxEx
            Me.btnResetColumnFilters = New DevComponents.DotNetBar.ButtonX
            Me.btnResetPanelFilter = New DevComponents.DotNetBar.ButtonX
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
            Me.richTextBox1.ReadOnly = True
            Me.richTextBox1.Size = New System.Drawing.Size(780, 113)
            Me.richTextBox1.TabIndex = 2
            Me.richTextBox1.Text = ""
            '
            'labelX4
            '
            Me.labelX4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX4.Location = New System.Drawing.Point(566, 528)
            Me.labelX4.Name = "labelX4"
            Me.labelX4.Size = New System.Drawing.Size(94, 19)
            Me.labelX4.TabIndex = 18
            Me.labelX4.Text = "Filter Match Type:"
            Me.labelX4.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'labelX3
            '
            Me.labelX3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX3.Location = New System.Drawing.Point(309, 502)
            Me.labelX3.Name = "labelX3"
            Me.labelX3.Size = New System.Drawing.Size(120, 19)
            Me.labelX3.TabIndex = 17
            Me.labelX3.Text = "Filter Image Visibility:"
            Me.labelX3.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'labelX1
            '
            Me.labelX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX1.Location = New System.Drawing.Point(309, 528)
            Me.labelX1.Name = "labelX1"
            Me.labelX1.Size = New System.Drawing.Size(120, 19)
            Me.labelX1.TabIndex = 16
            Me.labelX1.Text = "Filter Image Alignment:"
            Me.labelX1.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'labelX2
            '
            Me.labelX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX2.Location = New System.Drawing.Point(590, 502)
            Me.labelX2.Name = "labelX2"
            Me.labelX2.Size = New System.Drawing.Size(70, 19)
            Me.labelX2.TabIndex = 14
            Me.labelX2.Text = "Filter Level:"
            Me.labelX2.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'cbFilterLevel
            '
            Me.cbFilterLevel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cbFilterLevel.DisplayMember = "Text"
            Me.cbFilterLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cbFilterLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbFilterLevel.FormattingEnabled = True
            Me.cbFilterLevel.ItemHeight = 14
            Me.cbFilterLevel.Location = New System.Drawing.Point(666, 501)
            Me.cbFilterLevel.Name = "cbFilterLevel"
            Me.cbFilterLevel.Size = New System.Drawing.Size(106, 20)
            Me.cbFilterLevel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbFilterLevel.TabIndex = 15
            '
            'cbFilterImageVisibility
            '
            Me.cbFilterImageVisibility.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cbFilterImageVisibility.DisplayMember = "Text"
            Me.cbFilterImageVisibility.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cbFilterImageVisibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbFilterImageVisibility.FormattingEnabled = True
            Me.cbFilterImageVisibility.ItemHeight = 14
            Me.cbFilterImageVisibility.Location = New System.Drawing.Point(435, 501)
            Me.cbFilterImageVisibility.Name = "cbFilterImageVisibility"
            Me.cbFilterImageVisibility.Size = New System.Drawing.Size(106, 20)
            Me.cbFilterImageVisibility.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbFilterImageVisibility.TabIndex = 13
            '
            'cbxUseAgeSlider
            '
            Me.cbxUseAgeSlider.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.cbxUseAgeSlider.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.cbxUseAgeSlider.Location = New System.Drawing.Point(151, 526)
            Me.cbxUseAgeSlider.Name = "cbxUseAgeSlider"
            Me.cbxUseAgeSlider.Size = New System.Drawing.Size(152, 23)
            Me.cbxUseAgeSlider.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxUseAgeSlider.TabIndex = 12
            Me.cbxUseAgeSlider.Text = "Use Slider for Age Filter"
            '
            'cbxShowPanelExpr
            '
            Me.cbxShowPanelExpr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.cbxShowPanelExpr.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.cbxShowPanelExpr.Checked = True
            Me.cbxShowPanelExpr.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbxShowPanelExpr.CheckValue = "Y"
            Me.cbxShowPanelExpr.Location = New System.Drawing.Point(151, 500)
            Me.cbxShowPanelExpr.Name = "cbxShowPanelExpr"
            Me.cbxShowPanelExpr.Size = New System.Drawing.Size(152, 23)
            Me.cbxShowPanelExpr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxShowPanelExpr.TabIndex = 11
            Me.cbxShowPanelExpr.Text = "Show Filter Expression"
            '
            'cbFilterAlignment
            '
            Me.cbFilterAlignment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cbFilterAlignment.DisplayMember = "Text"
            Me.cbFilterAlignment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cbFilterAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbFilterAlignment.FormattingEnabled = True
            Me.cbFilterAlignment.ItemHeight = 14
            Me.cbFilterAlignment.Location = New System.Drawing.Point(435, 527)
            Me.cbFilterAlignment.Name = "cbFilterAlignment"
            Me.cbFilterAlignment.Size = New System.Drawing.Size(106, 20)
            Me.cbFilterAlignment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbFilterAlignment.TabIndex = 10
            '
            'cbMatchType
            '
            Me.cbMatchType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cbMatchType.DisplayMember = "Text"
            Me.cbMatchType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cbMatchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cbMatchType.FormattingEnabled = True
            Me.cbMatchType.ItemHeight = 14
            Me.cbMatchType.Location = New System.Drawing.Point(666, 527)
            Me.cbMatchType.Name = "cbMatchType"
            Me.cbMatchType.Size = New System.Drawing.Size(106, 20)
            Me.cbMatchType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbMatchType.TabIndex = 7
            '
            'btnResetColumnFilters
            '
            Me.btnResetColumnFilters.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnResetColumnFilters.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnResetColumnFilters.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnResetColumnFilters.Location = New System.Drawing.Point(18, 527)
            Me.btnResetColumnFilters.Name = "btnResetColumnFilters"
            Me.btnResetColumnFilters.Size = New System.Drawing.Size(113, 23)
            Me.btnResetColumnFilters.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnResetColumnFilters.TabIndex = 5
            Me.btnResetColumnFilters.Text = "Reset column filters"
            '
            'btnResetPanelFilter
            '
            Me.btnResetPanelFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnResetPanelFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnResetPanelFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnResetPanelFilter.Location = New System.Drawing.Point(18, 498)
            Me.btnResetPanelFilter.Name = "btnResetPanelFilter"
            Me.btnResetPanelFilter.Size = New System.Drawing.Size(113, 23)
            Me.btnResetPanelFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnResetPanelFilter.TabIndex = 4
            Me.btnResetPanelFilter.Text = "Reset panel filter"
            '
            'superGridControl1
            '
            Me.superGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.superGridControl1.BackColor = System.Drawing.Color.White
            Me.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
            Me.superGridControl1.FilterUseExtendedCustomDialog = True
            Me.superGridControl1.ForeColor = System.Drawing.Color.Black
            Me.superGridControl1.Location = New System.Drawing.Point(0, 123)
            Me.superGridControl1.Name = "superGridControl1"
            Me.superGridControl1.PrimaryGrid.AllowRowHeaderResize = True
            Me.superGridControl1.PrimaryGrid.AllowRowResize = True
            Me.superGridControl1.PrimaryGrid.ColumnHeader.RowHeight = 30
            GridColumn1.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
            GridColumn1.Name = "Index"
            GridColumn2.Name = "LastName"
            GridColumn3.Name = "FirstName"
            GridColumn3.ToolTip = ""
            GridColumn4.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl)
            GridColumn4.Name = "Age"
            GridColumn5.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridDateTimePickerEditControl)
            GridColumn5.Name = "HireDate"
            GridColumn6.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl)
            GridColumn6.Name = "Citizen"
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn1)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn2)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn3)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn4)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn5)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn6)
            Me.superGridControl1.PrimaryGrid.DefaultRowHeight = 24
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            Me.superGridControl1.PrimaryGrid.EnableColumnFiltering = True
            Me.superGridControl1.PrimaryGrid.EnableFiltering = True
            Me.superGridControl1.PrimaryGrid.EnableRowFiltering = True
            Me.superGridControl1.PrimaryGrid.Filter.Visible = True
            Me.superGridControl1.PrimaryGrid.NullString = "<<null>>"
            Me.superGridControl1.PrimaryGrid.RowHeaderWidth = 45
            Me.superGridControl1.PrimaryGrid.ShowRowGridIndex = True
            Me.superGridControl1.PrimaryGrid.ShowTreeButtons = True
            Me.superGridControl1.PrimaryGrid.ShowTreeLines = True
            Me.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
            Me.superGridControl1.Size = New System.Drawing.Size(784, 363)
            Me.superGridControl1.TabIndex = 0
            Me.superGridControl1.Text = "superGridControl1"
            '
            'styleManager1
            '
            Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
            Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
            '
            'DemoExtendedFiltering
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 562)
            Me.Controls.Add(Me.labelX4)
            Me.Controls.Add(Me.labelX3)
            Me.Controls.Add(Me.labelX1)
            Me.Controls.Add(Me.labelX2)
            Me.Controls.Add(Me.cbFilterLevel)
            Me.Controls.Add(Me.cbFilterImageVisibility)
            Me.Controls.Add(Me.cbxUseAgeSlider)
            Me.Controls.Add(Me.cbxShowPanelExpr)
            Me.Controls.Add(Me.cbFilterAlignment)
            Me.Controls.Add(Me.cbMatchType)
            Me.Controls.Add(Me.btnResetColumnFilters)
            Me.Controls.Add(Me.btnResetPanelFilter)
            Me.Controls.Add(Me.richTextBox1)
            Me.Controls.Add(Me.superGridControl1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MinimumSize = New System.Drawing.Size(390, 300)
            Me.Name = "DemoExtendedFiltering"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SuperGrid Demo - Extended Data Filtering"
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private superGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
		Private richTextBox1 As System.Windows.Forms.RichTextBox
		Private WithEvents btnResetPanelFilter As DevComponents.DotNetBar.ButtonX
		Private WithEvents btnResetColumnFilters As DevComponents.DotNetBar.ButtonX
		Private styleManager1 As DevComponents.DotNetBar.StyleManager
		Private WithEvents cbMatchType As DevComponents.DotNetBar.Controls.ComboBoxEx
		Private WithEvents cbFilterAlignment As DevComponents.DotNetBar.Controls.ComboBoxEx
		Private WithEvents cbxShowPanelExpr As DevComponents.DotNetBar.Controls.CheckBoxX
		Private WithEvents cbxUseAgeSlider As DevComponents.DotNetBar.Controls.CheckBoxX
		Private WithEvents cbFilterImageVisibility As DevComponents.DotNetBar.Controls.ComboBoxEx
		Private labelX2 As DevComponents.DotNetBar.LabelX
		Private WithEvents cbFilterLevel As DevComponents.DotNetBar.Controls.ComboBoxEx
		Private labelX1 As DevComponents.DotNetBar.LabelX
		Private labelX3 As DevComponents.DotNetBar.LabelX
		Private labelX4 As DevComponents.DotNetBar.LabelX
	End Class
End Namespace