Namespace SuperGridDemo
	Partial Public Class DemoGridBasics1
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DemoGridBasics1))
            Dim GridColumn1 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding1 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Padding2 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim GridColumn2 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding3 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim GridColumn3 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding4 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim GridColumn4 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding5 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim GridColumn5 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding6 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Padding7 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim GridRow1 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell1 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell2 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell3 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell4 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell5 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow2 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell6 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell7 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell8 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell9 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell10 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow3 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell11 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell12 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell13 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell14 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell15 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow4 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell16 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell17 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell18 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell19 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell20 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow5 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell21 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell22 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell23 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell24 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell25 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow6 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell26 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell27 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell28 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell29 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell30 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow7 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell31 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell32 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell33 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell34 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell35 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow8 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell36 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell37 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell38 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell39 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell40 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow9 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell41 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell42 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell43 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell44 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell45 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow10 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell46 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell47 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell48 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell49 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell50 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow11 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell51 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell52 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell53 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell54 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell55 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow12 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell56 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell57 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell58 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell59 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell60 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.flowerImageList = New System.Windows.Forms.ImageList(Me.components)
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
            Me.richTextBox1.Size = New System.Drawing.Size(780, 182)
            Me.richTextBox1.TabIndex = 2
            Me.richTextBox1.Text = ""
            '
            'flowerImageList
            '
            Me.flowerImageList.ImageStream = CType(resources.GetObject("flowerImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.flowerImageList.TransparentColor = System.Drawing.Color.Transparent
            Me.flowerImageList.Images.SetKeyName(0, "Amaranth")
            Me.flowerImageList.Images.SetKeyName(1, "Bellflower")
            Me.flowerImageList.Images.SetKeyName(2, "Columbine")
            Me.flowerImageList.Images.SetKeyName(3, "Foxglove")
            Me.flowerImageList.Images.SetKeyName(4, "Laurestine")
            Me.flowerImageList.Images.SetKeyName(5, "Orange-blossom")
            Me.flowerImageList.Images.SetKeyName(6, "Hortensia")
            Me.flowerImageList.Images.SetKeyName(7, "Rose")
            Me.flowerImageList.Images.SetKeyName(8, "Sweet William")
            Me.flowerImageList.Images.SetKeyName(9, "Touch-me-not")
            Me.flowerImageList.Images.SetKeyName(10, "Violet")
            Me.flowerImageList.Images.SetKeyName(11, "Whortleberry")
            '
            'superGridControl1
            '
            Me.superGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
            Me.superGridControl1.Location = New System.Drawing.Point(0, 192)
            Me.superGridControl1.Name = "superGridControl1"
            Me.superGridControl1.PrimaryGrid.AllowRowHeaderResize = True
            Me.superGridControl1.PrimaryGrid.AllowRowResize = True
            GridColumn1.CellStyles.Default.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            GridColumn1.CellStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            Padding1.Left = 4
            GridColumn1.CellStyles.Default.Margin = Padding1
            GridColumn1.CellStyles.MouseOver.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
            GridColumn1.CellStyles.MouseOver.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            GridColumn1.CellStyles.MouseOver.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            GridColumn1.CellStyles.SelectedMouseOver.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
            GridColumn1.CellStyles.SelectedMouseOver.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            GridColumn1.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.Multiple
            GridColumn1.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
            GridColumn1.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.TopCenter
            Padding2.Bottom = 3
            Padding2.Left = 3
            Padding2.Right = 3
            Padding2.Top = 3
            GridColumn1.HeaderStyles.Default.Margin = Padding2
            GridColumn1.Name = "TextBoxX"
            GridColumn1.Width = 180
            GridColumn2.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn2.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.Multiple
            GridColumn2.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxDropDownEditControl)
            GridColumn2.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
            Padding3.Left = 6
            GridColumn2.HeaderStyles.Default.ImagePadding = Padding3
            GridColumn2.Name = "TextBoxDropDown"
            GridColumn2.Width = 150
            GridColumn3.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.Multiple
            GridColumn3.DisplayIndex = 1
            GridColumn3.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridButtonXEditControl)
            GridColumn3.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
            GridColumn3.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            Padding4.Bottom = 3
            Padding4.Left = 3
            Padding4.Right = 3
            Padding4.Top = 3
            GridColumn3.HeaderStyles.Default.Margin = Padding4
            GridColumn3.MarkRowDirtyOnCellValueChange = False
            GridColumn3.Name = "ButtonX"
            GridColumn3.Width = 130
            GridColumn4.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn4.CellStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn4.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.Multiple
            GridColumn4.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridMaskedTextBoxEditControl)
            GridColumn4.HeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn4.HeaderStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
            GridColumn4.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
            GridColumn4.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.TopRight
            Padding5.Bottom = 4
            Padding5.Left = 4
            Padding5.Right = 4
            Padding5.Top = 4
            GridColumn4.HeaderStyles.Default.Margin = Padding5
            GridColumn4.HeaderText = "Masked TextBox"
            GridColumn4.Name = "MaskedTextBox"
            GridColumn4.Width = 120
            GridColumn5.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn5.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.Multiple
            GridColumn5.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridComboBoxExEditControl)
            GridColumn5.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
            GridColumn5.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.BottomRight
            GridColumn5.HeaderStyles.Default.ImageOverlay = DevComponents.DotNetBar.SuperGrid.Style.ImageOverlay.Top
            Padding6.Bottom = 4
            Padding6.Left = 4
            Padding6.Right = 4
            Padding6.Top = 4
            GridColumn5.HeaderStyles.Default.Margin = Padding6
            GridColumn5.Name = "ComboBoxEx"
            GridColumn5.Width = 140
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn1)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn2)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn3)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn4)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn5)
            Me.superGridControl1.PrimaryGrid.DefaultRowHeight = 25
            Padding7.Top = 6
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.ImagePadding = Padding7
            Me.superGridControl1.PrimaryGrid.FilterExpr = Nothing
            GridCell1.Value = "Amaranth"
            GridCell2.Value = "Unfading"
            GridCell3.Value = "Amaranth"
            GridCell4.Value = "EU-A-833"
            GridCell5.Value = "Eudicots"
            GridRow1.Cells.Add(GridCell1)
            GridRow1.Cells.Add(GridCell2)
            GridRow1.Cells.Add(GridCell3)
            GridRow1.Cells.Add(GridCell4)
            GridRow1.Cells.Add(GridCell5)
            GridCell6.Value = "Asterales"
            GridCell7.Value = "Indescretion"
            GridCell8.Value = "Bellflower"
            GridCell9.Value = "AS-A-631"
            GridCell10.Value = "Asterids"
            GridRow2.Cells.Add(GridCell6)
            GridRow2.Cells.Add(GridCell7)
            GridRow2.Cells.Add(GridCell8)
            GridRow2.Cells.Add(GridCell9)
            GridRow2.Cells.Add(GridCell10)
            GridCell11.Value = "Columbine"
            GridCell12.Value = "Folly"
            GridCell13.Value = "Columbine"
            GridCell14.Value = "EU-C-087"
            GridCell15.Value = "Eudicots"
            GridRow3.Cells.Add(GridCell11)
            GridRow3.Cells.Add(GridCell12)
            GridRow3.Cells.Add(GridCell13)
            GridRow3.Cells.Add(GridCell14)
            GridRow3.Cells.Add(GridCell15)
            GridCell16.Value = "Foxglove"
            GridCell17.Value = "Occupation"
            GridCell18.Value = "Foxglove"
            GridCell19.Value = "AS-F-004"
            GridCell20.Value = "Asterids"
            GridRow4.Cells.Add(GridCell16)
            GridRow4.Cells.Add(GridCell17)
            GridRow4.Cells.Add(GridCell18)
            GridRow4.Cells.Add(GridCell19)
            GridRow4.Cells.Add(GridCell20)
            GridCell21.Value = "Hortensia"
            GridCell22.Value = "Carelessness"
            GridCell23.Value = "Hortensia"
            GridCell24.Value = "AS-H-754"
            GridCell25.Value = "Asterids"
            GridRow5.Cells.Add(GridCell21)
            GridRow5.Cells.Add(GridCell22)
            GridRow5.Cells.Add(GridCell23)
            GridRow5.Cells.Add(GridCell24)
            GridRow5.Cells.Add(GridCell25)
            GridCell26.Value = "Laurestine"
            GridCell27.Value = "Delicate attentions"
            GridCell28.Value = "Laurestine"
            GridCell29.Value = "AS-L-339"
            GridCell30.Value = "Asterids"
            GridRow6.Cells.Add(GridCell26)
            GridRow6.Cells.Add(GridCell27)
            GridRow6.Cells.Add(GridCell28)
            GridRow6.Cells.Add(GridCell29)
            GridRow6.Cells.Add(GridCell30)
            GridCell31.Value = "Orange-blossom"
            GridCell32.Value = "Chasity"
            GridCell33.Value = "Orange-blossom"
            GridCell34.Value = "RO-O-059"
            GridCell35.Value = "Rosids"
            GridRow7.Cells.Add(GridCell31)
            GridRow7.Cells.Add(GridCell32)
            GridRow7.Cells.Add(GridCell33)
            GridRow7.Cells.Add(GridCell34)
            GridRow7.Cells.Add(GridCell35)
            GridCell36.Value = "Rose"
            GridCell37.Value = "Beauty"
            GridCell38.Value = "Rose"
            GridCell39.Value = "RO-R-826"
            GridCell40.Value = "Rosids"
            GridRow8.Cells.Add(GridCell36)
            GridRow8.Cells.Add(GridCell37)
            GridRow8.Cells.Add(GridCell38)
            GridRow8.Cells.Add(GridCell39)
            GridRow8.Cells.Add(GridCell40)
            GridCell41.Value = "Sweet William"
            GridCell42.Value = "Scorn"
            GridCell43.Value = "Sweet William"
            GridCell44.Value = "EU-W-635"
            GridCell45.Value = "Eudicots"
            GridRow9.Cells.Add(GridCell41)
            GridRow9.Cells.Add(GridCell42)
            GridRow9.Cells.Add(GridCell43)
            GridRow9.Cells.Add(GridCell44)
            GridRow9.Cells.Add(GridCell45)
            GridCell46.Value = "Touch-me-not"
            GridCell47.Value = "Impatience"
            GridCell48.Value = "Touch-me-not"
            GridCell49.Value = "AS-T-414"
            GridCell50.Value = "Asterids"
            GridRow10.Cells.Add(GridCell46)
            GridRow10.Cells.Add(GridCell47)
            GridRow10.Cells.Add(GridCell48)
            GridRow10.Cells.Add(GridCell49)
            GridRow10.Cells.Add(GridCell50)
            GridCell51.Value = "Violet"
            GridCell52.Value = "Modesty"
            GridCell53.Value = "Violet"
            GridCell54.Value = "RO-V-012"
            GridCell55.Value = "Rosids"
            GridRow11.Cells.Add(GridCell51)
            GridRow11.Cells.Add(GridCell52)
            GridRow11.Cells.Add(GridCell53)
            GridRow11.Cells.Add(GridCell54)
            GridRow11.Cells.Add(GridCell55)
            GridCell56.Value = "Whortleberry"
            GridCell57.Value = "Treachery"
            GridCell58.Value = "Whortleberry"
            GridCell59.Value = "AS-W-502"
            GridCell60.Value = "Asterids"
            GridRow12.Cells.Add(GridCell56)
            GridRow12.Cells.Add(GridCell57)
            GridRow12.Cells.Add(GridCell58)
            GridRow12.Cells.Add(GridCell59)
            GridRow12.Cells.Add(GridCell60)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow1)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow2)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow3)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow4)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow5)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow6)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow7)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow8)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow9)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow10)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow11)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow12)
            Me.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
            Me.superGridControl1.PrimaryGrid.UseAlternateColumnStyle = True
            Me.superGridControl1.Size = New System.Drawing.Size(784, 370)
            Me.superGridControl1.TabIndex = 3
            Me.superGridControl1.Text = "superGridControl1"
            '
            'styleManager1
            '
            Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
            Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
            '
            'DemoGridBasics1
            '
            Me.ClientSize = New System.Drawing.Size(784, 562)
            Me.Controls.Add(Me.superGridControl1)
            Me.Controls.Add(Me.richTextBox1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "DemoGridBasics1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SuperGrid Demo - Text Related Control Types"
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private richTextBox1 As RichTextBox
		Private superGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
        Private flowerImageList As ImageList
        Private WithEvents styleManager1 As DevComponents.DotNetBar.StyleManager
	End Class
End Namespace