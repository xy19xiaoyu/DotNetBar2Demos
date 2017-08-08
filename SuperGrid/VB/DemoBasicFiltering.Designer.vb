Namespace SuperGridDemo
	Partial Public Class DemoBasicFiltering
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DemoBasicFiltering))
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.btnResetPanelFilter = New DevComponents.DotNetBar.ButtonX
            Me.btnResetColumnFilters = New DevComponents.DotNetBar.ButtonX
            Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
            Me.btnAddRows = New DevComponents.DotNetBar.ButtonX
            Me.superGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl
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
            'btnResetPanelFilter
            '
            Me.btnResetPanelFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnResetPanelFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnResetPanelFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnResetPanelFilter.Location = New System.Drawing.Point(12, 531)
            Me.btnResetPanelFilter.Name = "btnResetPanelFilter"
            Me.btnResetPanelFilter.Size = New System.Drawing.Size(113, 23)
            Me.btnResetPanelFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnResetPanelFilter.TabIndex = 4
            Me.btnResetPanelFilter.Text = "Reset panel filter"
            '
            'btnResetColumnFilters
            '
            Me.btnResetColumnFilters.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnResetColumnFilters.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnResetColumnFilters.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnResetColumnFilters.Location = New System.Drawing.Point(131, 531)
            Me.btnResetColumnFilters.Name = "btnResetColumnFilters"
            Me.btnResetColumnFilters.Size = New System.Drawing.Size(113, 23)
            Me.btnResetColumnFilters.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnResetColumnFilters.TabIndex = 5
            Me.btnResetColumnFilters.Text = "Reset column filters"
            '
            'styleManager1
            '
            Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
            Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
            '
            'btnAddRows
            '
            Me.btnAddRows.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnAddRows.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAddRows.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnAddRows.Location = New System.Drawing.Point(659, 531)
            Me.btnAddRows.Name = "btnAddRows"
            Me.btnAddRows.Size = New System.Drawing.Size(113, 23)
            Me.btnAddRows.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnAddRows.TabIndex = 6
            Me.btnAddRows.Text = "Add 1000 rows"
            '
            'superGridControl1
            '
            Me.superGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.superGridControl1.BackColor = System.Drawing.Color.White
            Me.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
            Me.superGridControl1.ForeColor = System.Drawing.Color.Black
            Me.superGridControl1.Location = New System.Drawing.Point(0, 123)
            Me.superGridControl1.Name = "superGridControl1"
            Me.superGridControl1.PrimaryGrid.AllowRowHeaderResize = True
            Me.superGridControl1.PrimaryGrid.AllowRowResize = True
            Me.superGridControl1.PrimaryGrid.ColumnHeader.RowHeight = 30
            GridColumn1.Name = "Index"
            GridColumn2.Name = "LastName"
            GridColumn3.Name = "FirstName"
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
            Me.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
            Me.superGridControl1.Size = New System.Drawing.Size(784, 399)
            Me.superGridControl1.TabIndex = 0
            Me.superGridControl1.Text = "superGridControl1"
            '
            'DemoBasicFiltering
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 562)
            Me.Controls.Add(Me.btnAddRows)
            Me.Controls.Add(Me.btnResetColumnFilters)
            Me.Controls.Add(Me.btnResetPanelFilter)
            Me.Controls.Add(Me.richTextBox1)
            Me.Controls.Add(Me.superGridControl1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MinimumSize = New System.Drawing.Size(390, 300)
            Me.Name = "DemoBasicFiltering"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SuperGrid Demo - Basic Data Filtering"
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private superGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
		Private richTextBox1 As System.Windows.Forms.RichTextBox
		Private WithEvents btnResetPanelFilter As DevComponents.DotNetBar.ButtonX
		Private WithEvents btnResetColumnFilters As DevComponents.DotNetBar.ButtonX
		Private styleManager1 As DevComponents.DotNetBar.StyleManager
		Private WithEvents btnAddRows As DevComponents.DotNetBar.ButtonX
	End Class
End Namespace