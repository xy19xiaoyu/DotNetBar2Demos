Namespace SuperGridDemo
	Partial Public Class DemoSpreadsheet
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DemoSpreadsheet))
            Dim Padding1 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim Background2 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim Background3 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.bar1 = New DevComponents.DotNetBar.Bar
            Me.BtnFont = New DevComponents.DotNetBar.ButtonItem
            Me.CpText = New DevComponents.DotNetBar.ColorPickerDropDown
            Me.BtnEraseText = New DevComponents.DotNetBar.ButtonItem
            Me.BtnLeftAlign = New DevComponents.DotNetBar.ButtonItem
            Me.BtnMiddleAlign = New DevComponents.DotNetBar.ButtonItem
            Me.BtnRightAlign = New DevComponents.DotNetBar.ButtonItem
            Me.CpBackground = New DevComponents.DotNetBar.ColorPickerDropDown
            Me.BtnEraseBackground = New DevComponents.DotNetBar.ButtonItem
            Me.TbxCellText = New DevComponents.DotNetBar.TextBoxItem
            Me.btnShowEmptyCells = New DevComponents.DotNetBar.ButtonItem
            Me.controlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem
            Me.contextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.cmContext = New DevComponents.DotNetBar.ButtonItem
            Me.cmiClear = New DevComponents.DotNetBar.ButtonItem
            Me.cmiLeftAlign = New DevComponents.DotNetBar.ButtonItem
            Me.cmiCenterAlign = New DevComponents.DotNetBar.ButtonItem
            Me.cmiRightAlign = New DevComponents.DotNetBar.ButtonItem
            Me.superGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl
            Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
            CType(Me.bar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.contextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'richTextBox1
            '
            Me.richTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.richTextBox1.BackColor = System.Drawing.SystemColors.Window
            Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.richTextBox1.Location = New System.Drawing.Point(4, 387)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.ReadOnly = True
            Me.richTextBox1.Size = New System.Drawing.Size(780, 181)
            Me.richTextBox1.TabIndex = 2
            Me.richTextBox1.TabStop = False
            Me.richTextBox1.Text = ""
            '
            'bar1
            '
            Me.bar1.AntiAlias = True
            Me.bar1.CanUndock = False
            Me.bar1.Dock = System.Windows.Forms.DockStyle.Top
            Me.bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.BtnFont, Me.CpText, Me.BtnEraseText, Me.BtnLeftAlign, Me.BtnMiddleAlign, Me.BtnRightAlign, Me.CpBackground, Me.BtnEraseBackground, Me.TbxCellText, Me.btnShowEmptyCells})
            Me.bar1.Location = New System.Drawing.Point(0, 0)
            Me.bar1.Name = "bar1"
            Me.bar1.Size = New System.Drawing.Size(784, 24)
            Me.bar1.Stretch = True
            Me.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000
            Me.bar1.TabIndex = 6
            Me.bar1.TabStop = False
            Me.bar1.Text = "bar1"
            '
            'BtnFont
            '
            Me.BtnFont.BeginGroup = True
            Me.BtnFont.Image = CType(resources.GetObject("BtnFont.Image"), System.Drawing.Image)
            Me.BtnFont.Name = "BtnFont"
            Me.BtnFont.Text = "Font"
            '
            'CpText
            '
            Me.CpText.BeginGroup = True
            Me.CpText.Image = CType(resources.GetObject("CpText.Image"), System.Drawing.Image)
            Me.CpText.Name = "CpText"
            Me.CpText.SelectedColorImageRectangle = New System.Drawing.Rectangle(0, 13, 16, 4)
            '
            'BtnEraseText
            '
            Me.BtnEraseText.Image = CType(resources.GetObject("BtnEraseText.Image"), System.Drawing.Image)
            Me.BtnEraseText.Name = "BtnEraseText"
            Me.BtnEraseText.Text = "buttonItem2"
            '
            'BtnLeftAlign
            '
            Me.BtnLeftAlign.BeginGroup = True
            Me.BtnLeftAlign.Image = CType(resources.GetObject("BtnLeftAlign.Image"), System.Drawing.Image)
            Me.BtnLeftAlign.Name = "BtnLeftAlign"
            Me.BtnLeftAlign.Text = "buttonItem1"
            '
            'BtnMiddleAlign
            '
            Me.BtnMiddleAlign.Image = CType(resources.GetObject("BtnMiddleAlign.Image"), System.Drawing.Image)
            Me.BtnMiddleAlign.Name = "BtnMiddleAlign"
            Me.BtnMiddleAlign.Text = "buttonItem2"
            '
            'BtnRightAlign
            '
            Me.BtnRightAlign.Image = CType(resources.GetObject("BtnRightAlign.Image"), System.Drawing.Image)
            Me.BtnRightAlign.Name = "BtnRightAlign"
            Me.BtnRightAlign.Text = "buttonItem3"
            '
            'CpBackground
            '
            Me.CpBackground.BeginGroup = True
            Me.CpBackground.Image = CType(resources.GetObject("CpBackground.Image"), System.Drawing.Image)
            Me.CpBackground.Name = "CpBackground"
            Me.CpBackground.SelectedColorImageRectangle = New System.Drawing.Rectangle(0, 13, 16, 4)
            '
            'BtnEraseBackground
            '
            Me.BtnEraseBackground.Image = CType(resources.GetObject("BtnEraseBackground.Image"), System.Drawing.Image)
            Me.BtnEraseBackground.Name = "BtnEraseBackground"
            Me.BtnEraseBackground.Text = "buttonItem2"
            '
            'TbxCellText
            '
            Me.TbxCellText.BeginGroup = True
            Me.TbxCellText.Name = "TbxCellText"
            Me.TbxCellText.Stretch = True
            Me.TbxCellText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
            Me.TbxCellText.WatermarkColor = System.Drawing.SystemColors.GrayText
            '
            'btnShowEmptyCells
            '
            Me.btnShowEmptyCells.AutoCheckOnClick = True
            Me.btnShowEmptyCells.BeginGroup = True
            Me.btnShowEmptyCells.Image = CType(resources.GetObject("btnShowEmptyCells.Image"), System.Drawing.Image)
            Me.btnShowEmptyCells.Name = "btnShowEmptyCells"
            Me.btnShowEmptyCells.Text = "buttonItem1"
            '
            'controlContainerItem1
            '
            Me.controlContainerItem1.AllowItemResize = False
            Me.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
            Me.controlContainerItem1.Name = "controlContainerItem1"
            '
            'contextMenuBar1
            '
            Me.contextMenuBar1.AntiAlias = True
            Me.contextMenuBar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.contextMenuBar1.Images = Me.imageList1
            Me.contextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmContext})
            Me.contextMenuBar1.Location = New System.Drawing.Point(260, 333)
            Me.contextMenuBar1.Name = "contextMenuBar1"
            Me.contextMenuBar1.Size = New System.Drawing.Size(213, 25)
            Me.contextMenuBar1.Stretch = True
            Me.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.contextMenuBar1.TabIndex = 8
            Me.contextMenuBar1.TabStop = False
            Me.contextMenuBar1.Text = "contextMenuBar1"
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "LeftAlign")
            Me.imageList1.Images.SetKeyName(1, "CenterAlign")
            Me.imageList1.Images.SetKeyName(2, "RightAlign")
            Me.imageList1.Images.SetKeyName(3, "Eraser")
            '
            'cmContext
            '
            Me.cmContext.AutoExpandOnClick = True
            Me.cmContext.Name = "cmContext"
            Me.cmContext.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmiClear, Me.cmiLeftAlign, Me.cmiCenterAlign, Me.cmiRightAlign})
            Me.cmContext.Text = "Context"
            '
            'cmiClear
            '
            Me.cmiClear.ImageIndex = 3
            Me.cmiClear.Name = "cmiClear"
            Me.cmiClear.Text = "Clear"
            '
            'cmiLeftAlign
            '
            Me.cmiLeftAlign.BeginGroup = True
            Me.cmiLeftAlign.ImageIndex = 0
            Me.cmiLeftAlign.Name = "cmiLeftAlign"
            Me.cmiLeftAlign.Text = "Left Align"
            '
            'cmiCenterAlign
            '
            Me.cmiCenterAlign.ImageIndex = 1
            Me.cmiCenterAlign.Name = "cmiCenterAlign"
            Me.cmiCenterAlign.Text = "Center Align"
            '
            'cmiRightAlign
            '
            Me.cmiRightAlign.ImageIndex = 2
            Me.cmiRightAlign.Name = "cmiRightAlign"
            Me.cmiRightAlign.Text = "Right Align"
            '
            'superGridControl1
            '
            Me.superGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
            Me.superGridControl1.Location = New System.Drawing.Point(0, 24)
            Me.superGridControl1.Name = "superGridControl1"
            Me.superGridControl1.PrimaryGrid.AllowRowResize = True
            Padding1.Bottom = 1
            Padding1.Left = 1
            Padding1.Right = 1
            Padding1.Top = 1
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Margin = Padding1
            Background1.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.MouseOver.Background = Background1
            Background2.Color1 = System.Drawing.SystemColors.Highlight
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.Selected.Background = Background2
            Background3.Color1 = System.Drawing.SystemColors.GradientActiveCaption
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.SelectedMouseOver.Background = Background3
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.HorizontalLineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.VerticalLineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.superGridControl1.PrimaryGrid.EnableCellExpressions = True
            Me.superGridControl1.PrimaryGrid.FilterExpr = Nothing
            Me.superGridControl1.PrimaryGrid.RowHeaderWidth = 40
            Me.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
            Me.superGridControl1.Size = New System.Drawing.Size(784, 357)
            Me.superGridControl1.TabIndex = 0
            Me.superGridControl1.Text = "superGridControl1"
            '
            'styleManager1
            '
            Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
            Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
            '
            'DemoSpreadsheet
            '
            Me.ClientSize = New System.Drawing.Size(784, 568)
            Me.Controls.Add(Me.contextMenuBar1)
            Me.Controls.Add(Me.superGridControl1)
            Me.Controls.Add(Me.richTextBox1)
            Me.Controls.Add(Me.bar1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "DemoSpreadsheet"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SuperGrid Demo - Simple Spreadsheet Sample"
            CType(Me.bar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.contextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private richTextBox1 As RichTextBox
		Private WithEvents superGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
		Private bar1 As DevComponents.DotNetBar.Bar
		Private WithEvents BtnFont As DevComponents.DotNetBar.ButtonItem
		Private controlContainerItem1 As DevComponents.DotNetBar.ControlContainerItem
		Private WithEvents CpText As DevComponents.DotNetBar.ColorPickerDropDown
		Private WithEvents CpBackground As DevComponents.DotNetBar.ColorPickerDropDown
		Private WithEvents BtnEraseBackground As DevComponents.DotNetBar.ButtonItem
		Private WithEvents TbxCellText As DevComponents.DotNetBar.TextBoxItem
		Private WithEvents BtnEraseText As DevComponents.DotNetBar.ButtonItem
		Private WithEvents BtnLeftAlign As DevComponents.DotNetBar.ButtonItem
		Private WithEvents BtnMiddleAlign As DevComponents.DotNetBar.ButtonItem
		Private WithEvents BtnRightAlign As DevComponents.DotNetBar.ButtonItem
        Private WithEvents btnShowEmptyCells As DevComponents.DotNetBar.ButtonItem
        Private WithEvents contextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
        Private WithEvents cmContext As DevComponents.DotNetBar.ButtonItem
        Private WithEvents cmiClear As DevComponents.DotNetBar.ButtonItem
        Private WithEvents cmiLeftAlign As DevComponents.DotNetBar.ButtonItem
        Private WithEvents cmiCenterAlign As DevComponents.DotNetBar.ButtonItem
        Private WithEvents cmiRightAlign As DevComponents.DotNetBar.ButtonItem
        Private WithEvents imageList1 As System.Windows.Forms.ImageList
        Private WithEvents styleManager1 As DevComponents.DotNetBar.StyleManager
	End Class
End Namespace