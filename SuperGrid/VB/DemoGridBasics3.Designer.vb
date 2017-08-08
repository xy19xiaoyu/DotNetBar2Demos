Namespace SuperGridDemo
	Partial Public Class DemoGridBasics3
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DemoGridBasics3))
            Dim GridColumn1 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn2 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn3 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding1 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Padding2 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Padding3 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim GridRow1 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell1 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell2 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell3 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow2 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell4 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell5 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell6 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow3 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell7 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell8 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell9 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow4 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell10 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell11 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell12 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow5 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell13 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell14 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell15 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow6 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell16 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell17 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell18 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.cbxIpCompare = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.labelX1 = New DevComponents.DotNetBar.LabelX
            Me.cbxSizeMode = New DevComponents.DotNetBar.Controls.ComboBoxEx
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
            Me.richTextBox1.TabIndex = 4
            Me.richTextBox1.TabStop = False
            Me.richTextBox1.Text = ""
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "Black Lab")
            Me.imageList1.Images.SetKeyName(1, "Boxer")
            Me.imageList1.Images.SetKeyName(2, "Collie")
            Me.imageList1.Images.SetKeyName(3, "Golden Retriever")
            Me.imageList1.Images.SetKeyName(4, "Husky")
            Me.imageList1.Images.SetKeyName(5, "St. Bernard")
            '
            'cbxIpCompare
            '
            Me.cbxIpCompare.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.cbxIpCompare.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.cbxIpCompare.Location = New System.Drawing.Point(47, 567)
            Me.cbxIpCompare.Name = "cbxIpCompare"
            Me.cbxIpCompare.Size = New System.Drawing.Size(117, 23)
            Me.cbxIpCompare.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxIpCompare.TabIndex = 8
            Me.cbxIpCompare.Text = "Enable IP Compare"
            '
            'labelX1
            '
            Me.labelX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX1.Location = New System.Drawing.Point(354, 567)
            Me.labelX1.Name = "labelX1"
            Me.labelX1.Size = New System.Drawing.Size(169, 23)
            Me.labelX1.TabIndex = 7
            Me.labelX1.Text = "ImageEdit Size Mode:"
            Me.labelX1.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'cbxSizeMode
            '
            Me.cbxSizeMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.cbxSizeMode.DisplayMember = "Text"
            Me.cbxSizeMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cbxSizeMode.FormattingEnabled = True
            Me.cbxSizeMode.ItemHeight = 14
            Me.cbxSizeMode.Location = New System.Drawing.Point(531, 568)
            Me.cbxSizeMode.Name = "cbxSizeMode"
            Me.cbxSizeMode.Size = New System.Drawing.Size(206, 20)
            Me.cbxSizeMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxSizeMode.TabIndex = 6
            '
            'superGridControl1
            '
            Me.superGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
            Me.superGridControl1.Location = New System.Drawing.Point(0, 123)
            Me.superGridControl1.Name = "superGridControl1"
            Me.superGridControl1.PrimaryGrid.AllowRowResize = True
            GridColumn1.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn1.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridIpAddressInputEditControl)
            GridColumn1.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            GridColumn1.Name = "IpAddressInput"
            GridColumn1.Width = 150
            GridColumn2.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn2.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridImageEditControl)
            GridColumn2.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
            GridColumn2.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.TopCenter
            GridColumn2.Name = "ImageEdit"
            GridColumn2.Width = 110
            GridColumn3.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn3.CellStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
            GridColumn3.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl)
            GridColumn3.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
            GridColumn3.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn3.HeaderStyles.Default.ImageOverlay = DevComponents.DotNetBar.SuperGrid.Style.ImageOverlay.Bottom
            GridColumn3.Name = "LabelX"
            GridColumn3.Width = 300
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn1)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn2)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn3)
            Me.superGridControl1.PrimaryGrid.DefaultRowHeight = 100
            Padding1.Bottom = 4
            Padding1.Left = 4
            Padding1.Right = 4
            Padding1.Top = 4
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Margin = Padding1
            Padding2.Bottom = -4
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.ImagePadding = Padding2
            Padding3.Bottom = 4
            Padding3.Left = 4
            Padding3.Right = 4
            Padding3.Top = 4
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.Margin = Padding3
            Me.superGridControl1.PrimaryGrid.FilterExpr = Nothing
            GridCell1.Value = "192.168.0.1"
            GridCell2.Value = "Boxer"
            GridCell3.Value = resources.GetString("GridCell3.Value")
            GridRow1.Cells.Add(GridCell1)
            GridRow1.Cells.Add(GridCell2)
            GridRow1.Cells.Add(GridCell3)
            GridCell4.Value = "77.255.0.128"
            GridCell5.Value = "Collie"
            GridCell6.Value = "The Collie is a distinctive type of herding dog, including many related landraces" & _
                " and formal breeds. It originates in Scotland and Northern England."
            GridRow2.Cells.Add(GridCell4)
            GridRow2.Cells.Add(GridCell5)
            GridRow2.Cells.Add(GridCell6)
            GridCell7.Value = "196.128.0.3"
            GridCell8.Value = "St. Bernard"
            GridCell9.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
            GridCell9.Value = "The St. Bernard is a breed of very large working dog from the Italian and Swiss A" & _
                "lps, originally bred for rescue."
            GridRow3.Cells.Add(GridCell7)
            GridRow3.Cells.Add(GridCell8)
            GridRow3.Cells.Add(GridCell9)
            GridCell10.Value = "66.88.2.12"
            GridCell11.Value = "Golden Retriever"
            GridCell12.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            GridCell12.CellStyles.Default.TextColor = System.Drawing.Color.Sienna
            GridCell12.Value = "The Golden Retriever is a medium-sized breed of dog. They were historically devel" & _
                "oped as gundogs to retrieve shot waterfowl such as ducks and upland game birds d" & _
                "uring hunting and shooting parties."
            GridRow4.Cells.Add(GridCell10)
            GridRow4.Cells.Add(GridCell11)
            GridRow4.Cells.Add(GridCell12)
            GridCell13.Value = "122.0.0.16"
            GridCell14.Value = "Black Lab"
            GridCell15.Value = resources.GetString("GridCell15.Value")
            GridRow5.Cells.Add(GridCell13)
            GridRow5.Cells.Add(GridCell14)
            GridRow5.Cells.Add(GridCell15)
            GridCell16.Value = "188.44.0.87"
            GridCell17.Value = "Husky"
            GridCell18.CellStyles.Default.TextColor = System.Drawing.Color.Navy
            GridCell18.Value = "The Siberian Husky is a medium-size, dense-coat working dog breed that originated" & _
                " in eastern Siberia. "
            GridRow6.Cells.Add(GridCell16)
            GridRow6.Cells.Add(GridCell17)
            GridRow6.Cells.Add(GridCell18)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow1)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow2)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow3)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow4)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow5)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow6)
            Me.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
            Me.superGridControl1.Size = New System.Drawing.Size(784, 429)
            Me.superGridControl1.TabIndex = 5
            Me.superGridControl1.Text = "superGridControl1"
            '
            'styleManager1
            '
            Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
            Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
            '
            'DemoGridBasics3
            '
            Me.ClientSize = New System.Drawing.Size(784, 602)
            Me.Controls.Add(Me.cbxIpCompare)
            Me.Controls.Add(Me.labelX1)
            Me.Controls.Add(Me.cbxSizeMode)
            Me.Controls.Add(Me.superGridControl1)
            Me.Controls.Add(Me.richTextBox1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "DemoGridBasics3"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SuperGrid Demo - IP, Image, and Label Control Types"
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private richTextBox1 As RichTextBox
		Private superGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
		Private imageList1 As ImageList
		Private WithEvents cbxSizeMode As DevComponents.DotNetBar.Controls.ComboBoxEx
		Private labelX1 As DevComponents.DotNetBar.LabelX
        Private WithEvents cbxIpCompare As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents styleManager1 As DevComponents.DotNetBar.StyleManager
	End Class
End Namespace