Namespace SuperGridDemo
	Partial Public Class DemoGridBasics5
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DemoGridBasics5))
            Dim GridColumn1 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn2 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn3 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding1 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.superGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl
            Me.cbxAddMicroBorder = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
            Me.SuspendLayout()
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "Avion Small")
            Me.imageList1.Images.SetKeyName(1, "Car Small")
            Me.imageList1.Images.SetKeyName(2, "Helicopter Small")
            Me.imageList1.Images.SetKeyName(3, "Truck Small")
            '
            'imageList2
            '
            Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList2.Images.SetKeyName(0, "Avion Large")
            Me.imageList2.Images.SetKeyName(1, "Car Large")
            Me.imageList2.Images.SetKeyName(2, "Helicopter Large")
            Me.imageList2.Images.SetKeyName(3, "Truck Large")
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
            GridColumn1.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridMicroChartEditControl)
            GridColumn1.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            GridColumn1.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn1.HeaderText = "MicroChart"
            GridColumn1.Name = "MicroChart1"
            GridColumn2.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridMicroChartEditControl)
            GridColumn2.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
            GridColumn2.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn2.HeaderText = "MicroChart"
            GridColumn2.Name = "MicroChart2"
            GridColumn3.CellStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.TopCenter
            GridColumn3.CellStyles.Default.ImageOverlay = DevComponents.DotNetBar.SuperGrid.Style.ImageOverlay.Bottom
            GridColumn3.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridBubbleBarEditControl)
            GridColumn3.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
            GridColumn3.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn3.Name = "BubbleBar"
            GridColumn3.Width = 200
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn1)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn2)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn3)
            Me.superGridControl1.PrimaryGrid.DefaultRowHeight = 70
            Padding1.Bottom = 2
            Padding1.Left = 2
            Padding1.Right = 2
            Padding1.Top = 2
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.Margin = Padding1
            Me.superGridControl1.PrimaryGrid.FilterExpr = Nothing
            Me.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
            Me.superGridControl1.Size = New System.Drawing.Size(784, 436)
            Me.superGridControl1.TabIndex = 6
            Me.superGridControl1.Text = "superGridControl1"
            '
            'cbxAddMicroBorder
            '
            Me.cbxAddMicroBorder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.cbxAddMicroBorder.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.cbxAddMicroBorder.Location = New System.Drawing.Point(12, 570)
            Me.cbxAddMicroBorder.Name = "cbxAddMicroBorder"
            Me.cbxAddMicroBorder.Size = New System.Drawing.Size(350, 23)
            Me.cbxAddMicroBorder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxAddMicroBorder.TabIndex = 7
            Me.cbxAddMicroBorder.Text = "Add Border to MicroCharts with less than 4 points or more than 8"
            '
            'styleManager1
            '
            Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
            Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
            '
            'DemoGridBasics5
            '
            Me.ClientSize = New System.Drawing.Size(784, 603)
            Me.Controls.Add(Me.cbxAddMicroBorder)
            Me.Controls.Add(Me.superGridControl1)
            Me.Controls.Add(Me.richTextBox1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "DemoGridBasics5"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SuperGrid Demo - MicroChart, BubbleBar, and Gauge Control Types"
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private imageList1 As ImageList
		Private imageList2 As ImageList
		Private richTextBox1 As RichTextBox
		Private superGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
        Private WithEvents cbxAddMicroBorder As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents styleManager1 As DevComponents.DotNetBar.StyleManager
	End Class
End Namespace