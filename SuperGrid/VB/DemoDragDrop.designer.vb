Namespace SuperGridDemo
	Partial Public Class DemoDragDrop
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DemoDragDrop))
            Dim GridColumn1 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn2 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn3 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn4 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding1 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim GridColumn5 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn6 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn7 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn8 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding2 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.listBox1 = New System.Windows.Forms.ListBox
            Me.treeView1 = New System.Windows.Forms.TreeView
            Me.advTree1 = New DevComponents.AdvTree.AdvTree
            Me.LastName = New DevComponents.AdvTree.ColumnHeader
            Me.FirstName = New DevComponents.AdvTree.ColumnHeader
            Me.Age = New DevComponents.AdvTree.ColumnHeader
            Me.Id = New DevComponents.AdvTree.ColumnHeader
            Me.nodeConnector1 = New DevComponents.AdvTree.NodeConnector
            Me.elementStyle1 = New DevComponents.DotNetBar.ElementStyle
            Me.superGridControl2 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl
            Me.superGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl
            Me.elementStyle2 = New DevComponents.DotNetBar.ElementStyle
            Me.elementStyle3 = New DevComponents.DotNetBar.ElementStyle
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
            Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
            Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
            Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
            CType(Me.advTree1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.tableLayoutPanel3.SuspendLayout()
            Me.tableLayoutPanel2.SuspendLayout()
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
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "BugUp")
            Me.imageList1.Images.SetKeyName(1, "Empty")
            Me.imageList1.Images.SetKeyName(2, "ErrorCircle")
            Me.imageList1.Images.SetKeyName(3, "FontColor")
            Me.imageList1.Images.SetKeyName(4, "Function")
            Me.imageList1.Images.SetKeyName(5, "MusicNote")
            Me.imageList1.Images.SetKeyName(6, "Font")
            Me.imageList1.Images.SetKeyName(7, "BlueButton")
            '
            'listBox1
            '
            Me.listBox1.AllowDrop = True
            Me.listBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBox1.FormattingEnabled = True
            Me.listBox1.IntegralHeight = False
            Me.listBox1.Location = New System.Drawing.Point(3, 3)
            Me.listBox1.Name = "listBox1"
            Me.listBox1.Size = New System.Drawing.Size(190, 200)
            Me.listBox1.TabIndex = 7
            '
            'treeView1
            '
            Me.treeView1.AllowDrop = True
            Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeView1.Location = New System.Drawing.Point(199, 3)
            Me.treeView1.Name = "treeView1"
            Me.treeView1.Size = New System.Drawing.Size(190, 200)
            Me.treeView1.TabIndex = 8
            '
            'advTree1
            '
            Me.advTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
            Me.advTree1.AllowDrop = True
            Me.advTree1.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.advTree1.BackgroundStyle.Class = "TreeBorderKey"
            Me.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.advTree1.Columns.Add(Me.LastName)
            Me.advTree1.Columns.Add(Me.FirstName)
            Me.advTree1.Columns.Add(Me.Age)
            Me.advTree1.Columns.Add(Me.Id)
            Me.advTree1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.advTree1.ExpandBorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.advTree1.GridColumnLineResizeEnabled = True
            Me.advTree1.Location = New System.Drawing.Point(3, 3)
            Me.advTree1.MultiSelect = True
            Me.advTree1.Name = "advTree1"
            Me.advTree1.NodesConnector = Me.nodeConnector1
            Me.advTree1.NodeStyle = Me.elementStyle1
            Me.advTree1.PathSeparator = ";"
            Me.advTree1.Size = New System.Drawing.Size(386, 200)
            Me.advTree1.Styles.Add(Me.elementStyle1)
            Me.advTree1.TabIndex = 9
            Me.advTree1.Text = "advTree1"
            '
            'LastName
            '
            Me.LastName.Name = "LastName"
            Me.LastName.Text = "Last Name"
            Me.LastName.Width.Absolute = 125
            '
            'FirstName
            '
            Me.FirstName.Name = "FirstName"
            Me.FirstName.Text = "First Name"
            Me.FirstName.Width.Absolute = 100
            '
            'Age
            '
            Me.Age.Name = "Age"
            Me.Age.Text = "Age"
            Me.Age.Width.Absolute = 50
            '
            'Id
            '
            Me.Id.Name = "Id"
            Me.Id.Text = "Id"
            Me.Id.Width.Absolute = 70
            '
            'nodeConnector1
            '
            Me.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText
            '
            'elementStyle1
            '
            Me.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.elementStyle1.Name = "elementStyle1"
            Me.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText
            '
            'superGridControl2
            '
            Me.superGridControl2.AllowDrop = True
            Me.superGridControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.superGridControl2.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
            Me.superGridControl2.Location = New System.Drawing.Point(395, 3)
            Me.superGridControl2.Name = "superGridControl2"
            Me.superGridControl2.PrimaryGrid.AllowRowResize = True
            Me.superGridControl2.PrimaryGrid.ColumnHeaderClickBehavior = DevComponents.DotNetBar.SuperGrid.ColumnHeaderClickBehavior.[Select]
            GridColumn1.Name = "Last Name"
            GridColumn2.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn2.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn2.Name = "First Name"
            GridColumn3.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl)
            GridColumn3.Name = "Age"
            GridColumn3.Width = 50
            GridColumn4.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
            GridColumn4.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl)
            GridColumn4.Name = "Id"
            Me.superGridControl2.PrimaryGrid.Columns.Add(GridColumn1)
            Me.superGridControl2.PrimaryGrid.Columns.Add(GridColumn2)
            Me.superGridControl2.PrimaryGrid.Columns.Add(GridColumn3)
            Me.superGridControl2.PrimaryGrid.Columns.Add(GridColumn4)
            Padding1.Bottom = 2
            Padding1.Left = 2
            Padding1.Right = 2
            Padding1.Top = 2
            Me.superGridControl2.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.Margin = Padding1
            Me.superGridControl2.PrimaryGrid.FilterExpr = Nothing
            Me.superGridControl2.PrimaryGrid.ImageList = Me.imageList1
            Me.superGridControl2.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
            Me.superGridControl2.Size = New System.Drawing.Size(386, 199)
            Me.superGridControl2.TabIndex = 6
            Me.superGridControl2.Text = "superGridControl2"
            '
            'superGridControl1
            '
            Me.superGridControl1.AllowDrop = True
            Me.superGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
            Me.superGridControl1.Location = New System.Drawing.Point(3, 3)
            Me.superGridControl1.Name = "superGridControl1"
            Me.superGridControl1.PrimaryGrid.AllowRowResize = True
            Me.superGridControl1.PrimaryGrid.ColumnHeaderClickBehavior = DevComponents.DotNetBar.SuperGrid.ColumnHeaderClickBehavior.[Select]
            GridColumn5.Name = "Last Name"
            GridColumn6.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn6.Name = "First Name"
            GridColumn7.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl)
            GridColumn7.Name = "Age"
            GridColumn7.Width = 50
            GridColumn8.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
            GridColumn8.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl)
            GridColumn8.Name = "Id"
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn5)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn6)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn7)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn8)
            Padding2.Bottom = 2
            Padding2.Left = 2
            Padding2.Right = 2
            Padding2.Top = 2
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.Margin = Padding2
            Me.superGridControl1.PrimaryGrid.FilterExpr = Nothing
            Me.superGridControl1.PrimaryGrid.ImageList = Me.imageList1
            Me.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
            Me.superGridControl1.Size = New System.Drawing.Size(386, 199)
            Me.superGridControl1.TabIndex = 0
            Me.superGridControl1.Text = "superGridControl1"
            '
            'elementStyle2
            '
            Me.elementStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.elementStyle2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
            Me.elementStyle2.BackColorGradientAngle = 90
            Me.elementStyle2.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.elementStyle2.BorderBottomWidth = 1
            Me.elementStyle2.BorderColor = System.Drawing.Color.DarkGray
            Me.elementStyle2.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.elementStyle2.BorderLeftWidth = 1
            Me.elementStyle2.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.elementStyle2.BorderRightWidth = 1
            Me.elementStyle2.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.elementStyle2.BorderTopWidth = 1
            Me.elementStyle2.CornerDiameter = 4
            Me.elementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.elementStyle2.Description = "Blue"
            Me.elementStyle2.Name = "elementStyle2"
            Me.elementStyle2.PaddingBottom = 1
            Me.elementStyle2.PaddingLeft = 1
            Me.elementStyle2.PaddingRight = 1
            Me.elementStyle2.PaddingTop = 1
            Me.elementStyle2.TextColor = System.Drawing.Color.Black
            '
            'elementStyle3
            '
            Me.elementStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.elementStyle3.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
            Me.elementStyle3.BackColorGradientAngle = 90
            Me.elementStyle3.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.elementStyle3.BorderBottomWidth = 1
            Me.elementStyle3.BorderColor = System.Drawing.Color.DarkGray
            Me.elementStyle3.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.elementStyle3.BorderLeftWidth = 1
            Me.elementStyle3.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.elementStyle3.BorderRightWidth = 1
            Me.elementStyle3.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.elementStyle3.BorderTopWidth = 1
            Me.elementStyle3.CornerDiameter = 4
            Me.elementStyle3.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.elementStyle3.Description = "Blue"
            Me.elementStyle3.Name = "elementStyle3"
            Me.elementStyle3.PaddingBottom = 1
            Me.elementStyle3.PaddingLeft = 1
            Me.elementStyle3.PaddingRight = 1
            Me.elementStyle3.PaddingTop = 1
            Me.elementStyle3.TextColor = System.Drawing.Color.Black
            '
            'tableLayoutPanel1
            '
            Me.tableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tableLayoutPanel1.ColumnCount = 2
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel3, 1, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.superGridControl1, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.superGridControl2, 1, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel2, 0, 1)
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 118)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 2
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(784, 411)
            Me.tableLayoutPanel1.TabIndex = 10
            '
            'tableLayoutPanel3
            '
            Me.tableLayoutPanel3.ColumnCount = 1
            Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.tableLayoutPanel3.Controls.Add(Me.advTree1, 0, 0)
            Me.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel3.Location = New System.Drawing.Point(392, 205)
            Me.tableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
            Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
            Me.tableLayoutPanel3.RowCount = 1
            Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.tableLayoutPanel3.Size = New System.Drawing.Size(392, 206)
            Me.tableLayoutPanel3.TabIndex = 8
            '
            'tableLayoutPanel2
            '
            Me.tableLayoutPanel2.ColumnCount = 2
            Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.tableLayoutPanel2.Controls.Add(Me.treeView1, 1, 0)
            Me.tableLayoutPanel2.Controls.Add(Me.listBox1, 0, 0)
            Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel2.Location = New System.Drawing.Point(0, 205)
            Me.tableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
            Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
            Me.tableLayoutPanel2.RowCount = 1
            Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.tableLayoutPanel2.Size = New System.Drawing.Size(392, 206)
            Me.tableLayoutPanel2.TabIndex = 7
            '
            'styleManager1
            '
            Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
            Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
            '
            'DemoDragDrop
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 528)
            Me.Controls.Add(Me.tableLayoutPanel1)
            Me.Controls.Add(Me.richTextBox1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "DemoDragDrop"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SuperGrid Demo - Drag and Drop"
            CType(Me.advTree1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.tableLayoutPanel3.ResumeLayout(False)
            Me.tableLayoutPanel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private richTextBox1 As System.Windows.Forms.RichTextBox
		Private WithEvents superGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents superGridControl2 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
		Private WithEvents listBox1 As System.Windows.Forms.ListBox
		Private WithEvents treeView1 As System.Windows.Forms.TreeView
		Private advTree1 As DevComponents.AdvTree.AdvTree
		Private nodeConnector1 As DevComponents.AdvTree.NodeConnector
		Private elementStyle1 As DevComponents.DotNetBar.ElementStyle
		Private LastName As DevComponents.AdvTree.ColumnHeader
		Private FirstName As DevComponents.AdvTree.ColumnHeader
		Private Age As DevComponents.AdvTree.ColumnHeader
		Private Id As DevComponents.AdvTree.ColumnHeader
		Private elementStyle2 As DevComponents.DotNetBar.ElementStyle
		Private elementStyle3 As DevComponents.DotNetBar.ElementStyle
		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Private tableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
        Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
        Private WithEvents styleManager1 As DevComponents.DotNetBar.StyleManager
	End Class
End Namespace