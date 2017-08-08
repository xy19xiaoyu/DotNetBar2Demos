Namespace SuperGridDemo
	Partial Public Class Form1
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim GridColumn1 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn2 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn3 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding1 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
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
            Dim GridRow7 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell19 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell20 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell21 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow8 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell22 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell23 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell24 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow9 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell25 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell26 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell27 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow10 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell28 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell29 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell30 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow11 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell31 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell32 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell33 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow12 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell34 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell35 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell36 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow13 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell37 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell38 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell39 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow14 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell40 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell41 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell42 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow15 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell43 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell44 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell45 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow16 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell46 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell47 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell48 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridRow17 As DevComponents.DotNetBar.SuperGrid.GridRow = New DevComponents.DotNetBar.SuperGrid.GridRow
            Dim GridCell49 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell50 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Dim GridCell51 As DevComponents.DotNetBar.SuperGrid.GridCell = New DevComponents.DotNetBar.SuperGrid.GridCell
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.rtb = New System.Windows.Forms.RichTextBox
            Me.btnClose = New DevComponents.DotNetBar.ButtonX
            Me.superGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl
            Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
            Me.SuspendLayout()
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "audio-headset.png")
            Me.imageList1.Images.SetKeyName(1, "camera-web.png")
            Me.imageList1.Images.SetKeyName(2, "input-gaming.png")
            Me.imageList1.Images.SetKeyName(3, "media-flash-smart-media.png")
            Me.imageList1.Images.SetKeyName(4, "network-wireless.png")
            '
            'rtb
            '
            Me.rtb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.rtb.BackColor = System.Drawing.SystemColors.Window
            Me.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.rtb.Location = New System.Drawing.Point(551, 5)
            Me.rtb.Name = "rtb"
            Me.rtb.ReadOnly = True
            Me.rtb.Size = New System.Drawing.Size(254, 449)
            Me.rtb.TabIndex = 4
            Me.rtb.TabStop = False
            Me.rtb.Text = ""
            '
            'btnClose
            '
            Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnClose.Location = New System.Drawing.Point(718, 469)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(75, 23)
            Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnClose.TabIndex = 5
            Me.btnClose.Text = "Close"
            '
            'superGridControl1
            '
            Me.superGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.superGridControl1.DefaultVisualStyles.CellStyles.Default.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
            Me.superGridControl1.Location = New System.Drawing.Point(3, 3)
            Me.superGridControl1.Name = "superGridControl1"
            Me.superGridControl1.PrimaryGrid.ColumnHeader.Visible = False
            GridColumn1.EditorType = Nothing
            GridColumn1.Name = "Key"
            GridColumn1.Visible = False
            GridColumn1.Width = 200
            GridColumn2.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None
            GridColumn2.CellStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
            GridColumn2.CellStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn2.EditorType = Nothing
            GridColumn2.Name = "Topic"
            GridColumn2.Width = 280
            GridColumn3.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
            GridColumn3.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl)
            GridColumn3.Name = "Column1"
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn1)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn2)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn3)
            Me.superGridControl1.PrimaryGrid.DefaultRowHeight = 0
            Padding1.Bottom = 2
            Padding1.Left = 4
            Padding1.Right = 4
            Padding1.Top = 2
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Margin = Padding1
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.GroupHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            Background1.Color1 = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(69, Byte), Integer))
            Background1.Color2 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(167, Byte), Integer))
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.GroupHeaderStyles.Default.Background = Background1
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.GroupHeaderStyles.Default.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.superGridControl1.PrimaryGrid.FocusCuesEnabled = False
            Me.superGridControl1.PrimaryGrid.GridLines = DevComponents.DotNetBar.SuperGrid.GridLines.None
            Me.superGridControl1.PrimaryGrid.GroupHeaderHeight = 35
            Me.superGridControl1.PrimaryGrid.ImageList = Me.imageList1
            GridCell1.Value = "0"
            GridCell2.CellStyles.Default.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            GridCell2.Value = ""
            GridCell3.Value = "<h5>SuperGrid Architecture Basics</h5>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<p padding = ""10,10,5, 0""><font color=""Bl" & _
                "ack"">A brief description of the overall architecture of a SuperGrid.</font></p>"
            GridRow1.Cells.Add(GridCell1)
            GridRow1.Cells.Add(GridCell2)
            GridRow1.Cells.Add(GridCell3)
            GridCell4.Value = "1"
            GridCell5.CellStyles.Default.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
            GridCell5.Value = ""
            GridCell6.Value = resources.GetString("GridCell6.Value")
            GridRow2.Cells.Add(GridCell4)
            GridRow2.Cells.Add(GridCell5)
            GridRow2.Cells.Add(GridCell6)
            GridCell7.Value = "1"
            GridCell8.CellStyles.Default.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
            GridCell8.Value = ""
            GridCell9.Value = "<h5>SuperGrid Edit Controls</h5>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<p padding = ""10,10,5, 0""><font color=""Black"">D" & _
                "emonstrates the TextBoxX, ButtonX, TextBoxDropDown, MaskedTextBox, and ComboBoxE" & _
                "x Edit Controls.</font></p>"
            GridRow3.Cells.Add(GridCell7)
            GridRow3.Cells.Add(GridCell8)
            GridRow3.Cells.Add(GridCell9)
            GridCell10.Value = "1"
            GridCell11.CellStyles.Default.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
            GridCell11.Value = ""
            GridCell12.Value = "<h5>SuperGrid Edit Controls</h5>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<p padding = ""10,10,5, 0""><font color=""Black"">D" & _
                "emonstrates the DateTimeInput, DateTimePicker, NumericUpDown, IntegerInput, and " & _
                "DoubleInput Edit Controls.</font></p>"
            GridRow4.Cells.Add(GridCell10)
            GridRow4.Cells.Add(GridCell11)
            GridRow4.Cells.Add(GridCell12)
            GridCell13.Value = "1"
            GridCell14.CellStyles.Default.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
            GridCell14.Value = ""
            GridCell15.Value = "<h5>SuperGrid Edit Controls</h5>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<p padding = ""10,10,5, 0""><font color=""Black"">D" & _
                "emonstrates the IpAddressInput, PictureBox, LabelX Edit Controls.</font></p>"
            GridRow5.Cells.Add(GridCell13)
            GridRow5.Cells.Add(GridCell14)
            GridRow5.Cells.Add(GridCell15)
            GridCell16.Value = "1"
            GridCell17.CellStyles.Default.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
            GridCell17.Value = ""
            GridCell18.Value = "<h5>SuperGrid Edit Controls</h5>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<p padding = ""10,10,5, 0""><font color=""Black"">D" & _
                "emonstrates the ProgressBarX, Slider, SwitchButton, and CheckBoxX Edit Controls." & _
                "</font></p>"
            GridRow6.Cells.Add(GridCell16)
            GridRow6.Cells.Add(GridCell17)
            GridRow6.Cells.Add(GridCell18)
            GridCell19.Value = "1"
            GridCell20.CellStyles.Default.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
            GridCell20.Value = ""
            GridCell21.Value = "<h5>SuperGrid Edit Controls</h5>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<p padding = ""10,10,5, 0""><font color=""Black"">D" & _
                "emonstrates the MicroChart, BubbleBar, Gauge Edit Controls.</font></p>"
            GridRow7.Cells.Add(GridCell19)
            GridRow7.Cells.Add(GridCell20)
            GridRow7.Cells.Add(GridCell21)
            GridCell22.Value = "2"
            GridCell23.CellStyles.Default.Image = CType(resources.GetObject("resource.Image7"), System.Drawing.Image)
            GridCell23.Value = ""
            GridCell24.Value = "<h5>Data Binding</h5>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<div padding=""10,10,5,5""><font color=""Black"">Demonstrates " & _
                "IList, IListSource, IBindingList, and DataSet binding.</font></div>"
            GridRow8.Cells.Add(GridCell22)
            GridRow8.Cells.Add(GridCell23)
            GridRow8.Cells.Add(GridCell24)
            GridCell25.Value = "2"
            GridCell26.CellStyles.Default.Image = CType(resources.GetObject("resource.Image8"), System.Drawing.Image)
            GridCell26.Value = ""
            GridCell27.Value = "<h5>Master / Detail</h5>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<div padding=""10,10,5,5""><font color=""Black"">Demonstrat" & _
                "es a  data bound Master/Detail SuperGrid.</font></div>"
            GridRow9.Cells.Add(GridCell25)
            GridRow9.Cells.Add(GridCell26)
            GridRow9.Cells.Add(GridCell27)
            GridRow9.Expanded = True
            GridCell28.Value = "2"
            GridCell29.CellStyles.Default.Image = CType(resources.GetObject("resource.Image9"), System.Drawing.Image)
            GridCell29.Value = ""
            GridCell30.Value = "<h5>Nested Data</h5>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<div padding=""10,10,5,5""><font color=""Black"">Demonstrates a" & _
                " nested SuperGrid with cell and row level data validation.</font></div>"
            GridRow10.Cells.Add(GridCell28)
            GridRow10.Cells.Add(GridCell29)
            GridRow10.Cells.Add(GridCell30)
            GridCell31.Value = "2"
            GridCell32.CellStyles.Default.Image = CType(resources.GetObject("resource.Image10"), System.Drawing.Image)
            GridCell32.Value = ""
            GridCell33.Value = "<h5>Virtual Data</h5>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<div padding=""10,10,5,5""><font color=""Black"">Demonstrates " & _
                "a 2,000,000 row SuperGrid.</font></div>"
            GridRow11.Cells.Add(GridCell31)
            GridRow11.Cells.Add(GridCell32)
            GridRow11.Cells.Add(GridCell33)
            GridCell34.Value = "3"
            GridCell35.CellStyles.Default.Image = CType(resources.GetObject("resource.Image11"), System.Drawing.Image)
            GridCell35.Value = ""
            GridCell36.Value = "<h5>Basic Data Filtering</h5>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<div padding=""10,10,5,5""><font color=""Black"">Demon" & _
                "strates the basics of both row level and column level filtering.</font></div>"
            GridRow12.Cells.Add(GridCell34)
            GridRow12.Cells.Add(GridCell35)
            GridRow12.Cells.Add(GridCell36)
            GridCell37.Value = "3"
            GridCell38.CellStyles.Default.Image = CType(resources.GetObject("resource.Image12"), System.Drawing.Image)
            GridCell38.Value = ""
            GridCell39.Value = "<h5>Extended Data Filtering</h5>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<div padding=""10,10,5,5""><font color=""Black"">A " & _
                "more advanced Data Filtering example that demonstrates user supplied filtering c" & _
                "ontrols and intervention.</font></div>"
            GridRow13.Cells.Add(GridCell37)
            GridRow13.Cells.Add(GridCell38)
            GridRow13.Cells.Add(GridCell39)
            GridCell40.Value = "4"
            GridCell41.CellStyles.Default.Image = CType(resources.GetObject("resource.Image13"), System.Drawing.Image)
            GridCell41.Value = ""
            GridCell42.Value = "<h5>File Explorer</h5>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<div padding=""10,10,5,5""><font color=""Black"">Simple Windo" & _
                "ws-Like File Explorer.</font></div>"
            GridRow14.Cells.Add(GridCell40)
            GridRow14.Cells.Add(GridCell41)
            GridRow14.Cells.Add(GridCell42)
            GridCell43.Value = "4"
            GridCell44.CellStyles.Default.Image = CType(resources.GetObject("resource.Image14"), System.Drawing.Image)
            GridCell44.Value = ""
            GridCell45.Value = "<h5>Simple Spreadsheet</h5>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<div padding=""10,10,5,5""><font color=""Black"">Simple " & _
                "Spreadsheet display.</font></div>"
            GridRow15.Cells.Add(GridCell43)
            GridRow15.Cells.Add(GridCell44)
            GridRow15.Cells.Add(GridCell45)
            GridCell46.Value = "4"
            GridCell47.CellStyles.Default.Image = CType(resources.GetObject("resource.Image15"), System.Drawing.Image)
            GridCell47.Value = ""
            GridCell48.Value = "<h5>User Defined Cell Editors</h5>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<div padding=""10,10,5,5""><font color=""Black"">" & _
                "Sample user defined Modal, NonModal, and InPlace Cell Editors.</font></div>"
            GridRow16.Cells.Add(GridCell46)
            GridRow16.Cells.Add(GridCell47)
            GridRow16.Cells.Add(GridCell48)
            GridCell49.Value = "4"
            GridCell50.CellStyles.Default.Image = CType(resources.GetObject("resource.Image16"), System.Drawing.Image)
            GridCell50.Value = ""
            GridCell51.Value = "<h5>Drag and Drop</h5>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<div padding=""10,10,5,5""><font color=""Black"">Simple Drag-" & _
                "and-drop example.</font></div>"
            GridRow17.Cells.Add(GridCell49)
            GridRow17.Cells.Add(GridCell50)
            GridRow17.Cells.Add(GridCell51)
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
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow13)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow14)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow15)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow16)
            Me.superGridControl1.PrimaryGrid.Rows.Add(GridRow17)
            Me.superGridControl1.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
            Me.superGridControl1.PrimaryGrid.ShowColumnHeader = False
            Me.superGridControl1.PrimaryGrid.ShowRowHeaders = False
            Me.superGridControl1.PrimaryGrid.ShowToolTips = False
            Me.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
            Me.superGridControl1.Size = New System.Drawing.Size(541, 496)
            Me.superGridControl1.TabIndex = 0
            Me.superGridControl1.Text = "superGridControl1"
            '
            'styleManager1
            '
            Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
            Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
            '
            'Form1
            '
            Me.AcceptButton = Me.btnClose
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(805, 502)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.rtb)
            Me.Controls.Add(Me.superGridControl1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "DevComponents SuperGrid - Demo Application Explorer"
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents superGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
		Private rtb As System.Windows.Forms.RichTextBox
        Private WithEvents btnClose As DevComponents.DotNetBar.ButtonX
        Private WithEvents styleManager1 As DevComponents.DotNetBar.StyleManager
	End Class
End Namespace

