Namespace SuperGridDemo
	Partial Public Class DemoVirtualMode
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
            Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim Background2 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DemoVirtualMode))
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.CbxAltColStyle = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.CbxAltRowStyle = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.BtnClearRows = New DevComponents.DotNetBar.ButtonX
            Me.BtnLoadRows = New DevComponents.DotNetBar.ButtonX
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
            Me.richTextBox1.Size = New System.Drawing.Size(781, 117)
            Me.richTextBox1.TabIndex = 3
            Me.richTextBox1.TabStop = False
            Me.richTextBox1.Text = ""
            '
            'CbxAltColStyle
            '
            Me.CbxAltColStyle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.CbxAltColStyle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.CbxAltColStyle.Location = New System.Drawing.Point(195, 522)
            Me.CbxAltColStyle.Name = "CbxAltColStyle"
            Me.CbxAltColStyle.Size = New System.Drawing.Size(178, 23)
            Me.CbxAltColStyle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.CbxAltColStyle.TabIndex = 8
            Me.CbxAltColStyle.Text = "Use Alternating Column Style"
            '
            'CbxAltRowStyle
            '
            Me.CbxAltRowStyle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.CbxAltRowStyle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.CbxAltRowStyle.Location = New System.Drawing.Point(28, 522)
            Me.CbxAltRowStyle.Name = "CbxAltRowStyle"
            Me.CbxAltRowStyle.Size = New System.Drawing.Size(161, 23)
            Me.CbxAltRowStyle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.CbxAltRowStyle.TabIndex = 7
            Me.CbxAltRowStyle.Text = "Use Alternating Row Style"
            '
            'BtnClearRows
            '
            Me.BtnClearRows.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.BtnClearRows.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnClearRows.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.BtnClearRows.Location = New System.Drawing.Point(697, 522)
            Me.BtnClearRows.Name = "BtnClearRows"
            Me.BtnClearRows.Size = New System.Drawing.Size(75, 28)
            Me.BtnClearRows.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.BtnClearRows.TabIndex = 6
            Me.BtnClearRows.Text = "Clear Rows"
            '
            'BtnLoadRows
            '
            Me.BtnLoadRows.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.BtnLoadRows.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnLoadRows.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.BtnLoadRows.Location = New System.Drawing.Point(616, 522)
            Me.BtnLoadRows.Name = "BtnLoadRows"
            Me.BtnLoadRows.Size = New System.Drawing.Size(75, 28)
            Me.BtnLoadRows.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.BtnLoadRows.TabIndex = 5
            Me.BtnLoadRows.Text = "Load Rows"
            '
            'superGridControl1
            '
            Me.superGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
            Me.superGridControl1.Location = New System.Drawing.Point(0, 127)
            Me.superGridControl1.Name = "superGridControl1"
            Me.superGridControl1.PrimaryGrid.AllowRowHeaderResize = True
            Me.superGridControl1.PrimaryGrid.AllowRowResize = True
            Me.superGridControl1.PrimaryGrid.CheckBoxes = True
            Me.superGridControl1.PrimaryGrid.ColumnHeader.RowHeight = 30
            GridColumn1.Name = "Column1"
            GridColumn1.Width = 150
            GridColumn2.Name = "Column2"
            GridColumn2.Width = 150
            GridColumn3.Name = "Column3"
            GridColumn3.Width = 150
            GridColumn4.Name = "Column4"
            GridColumn4.Width = 150
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn1)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn2)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn3)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn4)
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
            Background1.BackFillType = DevComponents.DotNetBar.SuperGrid.Style.BackFillType.ForwardDiagonal
            Background1.Color1 = System.Drawing.Color.Silver
            Background1.Color2 = System.Drawing.Color.White
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.Background = Background1
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Background2.Color1 = System.Drawing.Color.LightSteelBlue
            Background2.Color2 = System.Drawing.Color.Azure
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.Background = Background2
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            Me.superGridControl1.PrimaryGrid.FilterExpr = Nothing
            Me.superGridControl1.PrimaryGrid.FrozenRowCount = 5
            Me.superGridControl1.PrimaryGrid.Header.Text = "<div valign=""middle"" align=""center"">SuperGrid VirtualMode Sample Application</div" & _
                ">"
            Me.superGridControl1.PrimaryGrid.NoRowsText = "Click on the ""Load Rows"" button to add 2,000,000 rows!"
            Me.superGridControl1.PrimaryGrid.RowHeaderWidth = 55
            Me.superGridControl1.PrimaryGrid.ShowRowGridIndex = True
            Me.superGridControl1.PrimaryGrid.ShowTreeButtons = True
            Me.superGridControl1.PrimaryGrid.ShowTreeLines = True
            Me.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
            Me.superGridControl1.PrimaryGrid.VirtualMode = True
            Me.superGridControl1.Size = New System.Drawing.Size(785, 377)
            Me.superGridControl1.TabIndex = 0
            Me.superGridControl1.Text = "superGridControl1"
            '
            'styleManager1
            '
            Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
            Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
            '
            'DemoVirtualMode
            '
            Me.ClientSize = New System.Drawing.Size(784, 562)
            Me.Controls.Add(Me.CbxAltColStyle)
            Me.Controls.Add(Me.CbxAltRowStyle)
            Me.Controls.Add(Me.BtnClearRows)
            Me.Controls.Add(Me.BtnLoadRows)
            Me.Controls.Add(Me.superGridControl1)
            Me.Controls.Add(Me.richTextBox1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "DemoVirtualMode"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SuperGrid Demo - Virtual Mode Sample"
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private richTextBox1 As RichTextBox
		Private WithEvents superGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
		Private WithEvents BtnLoadRows As DevComponents.DotNetBar.ButtonX
		Private WithEvents BtnClearRows As DevComponents.DotNetBar.ButtonX
		Private WithEvents CbxAltRowStyle As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents CbxAltColStyle As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents styleManager1 As DevComponents.DotNetBar.StyleManager
	End Class
End Namespace