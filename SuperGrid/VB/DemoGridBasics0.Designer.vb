Namespace SuperGridDemo
	Partial Public Class DemoGridBasics0
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
            Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DemoGridBasics0))
            Dim Padding1 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Padding2 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Background2 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim Background3 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim Padding3 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Padding4 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Background4 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim Padding5 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Padding6 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Background5 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Dim Padding7 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Padding8 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Background6 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.cbxHeader = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.cbxFooter = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.cbxCaption = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.cbxTitle = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.btnPurgeRows = New DevComponents.DotNetBar.ButtonX
            Me.cbxGridIndex = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.cbxRowHeaders = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.btnShowDeleted = New DevComponents.DotNetBar.ButtonX
            Me.btnHideDeleted = New DevComponents.DotNetBar.ButtonX
            Me.cbxAutoDelete = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.superGridControl1 = New DevComponents.DotNetBar.SuperGrid.SuperGridControl
            Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
            Me.groupBox1.SuspendLayout()
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
            Me.richTextBox1.Size = New System.Drawing.Size(780, 119)
            Me.richTextBox1.TabIndex = 3
            Me.richTextBox1.TabStop = False
            Me.richTextBox1.Text = ""
            '
            'groupBox1
            '
            Me.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.groupBox1.Controls.Add(Me.cbxHeader)
            Me.groupBox1.Controls.Add(Me.cbxFooter)
            Me.groupBox1.Controls.Add(Me.cbxCaption)
            Me.groupBox1.Controls.Add(Me.cbxTitle)
            Me.groupBox1.Location = New System.Drawing.Point(12, 537)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(282, 57)
            Me.groupBox1.TabIndex = 12
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Show"
            '
            'cbxHeader
            '
            Me.cbxHeader.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.cbxHeader.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.cbxHeader.Location = New System.Drawing.Point(147, 19)
            Me.cbxHeader.Name = "cbxHeader"
            Me.cbxHeader.Size = New System.Drawing.Size(61, 23)
            Me.cbxHeader.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxHeader.TabIndex = 10
            Me.cbxHeader.Text = "Header"
            '
            'cbxFooter
            '
            Me.cbxFooter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.cbxFooter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.cbxFooter.Location = New System.Drawing.Point(216, 19)
            Me.cbxFooter.Name = "cbxFooter"
            Me.cbxFooter.Size = New System.Drawing.Size(58, 23)
            Me.cbxFooter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxFooter.TabIndex = 11
            Me.cbxFooter.Text = "Footer"
            '
            'cbxCaption
            '
            Me.cbxCaption.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.cbxCaption.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.cbxCaption.Checked = True
            Me.cbxCaption.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbxCaption.CheckValue = "Y"
            Me.cbxCaption.Location = New System.Drawing.Point(15, 19)
            Me.cbxCaption.Name = "cbxCaption"
            Me.cbxCaption.Size = New System.Drawing.Size(64, 23)
            Me.cbxCaption.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxCaption.TabIndex = 8
            Me.cbxCaption.Text = "Caption"
            '
            'cbxTitle
            '
            Me.cbxTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.cbxTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.cbxTitle.Location = New System.Drawing.Point(86, 19)
            Me.cbxTitle.Name = "cbxTitle"
            Me.cbxTitle.Size = New System.Drawing.Size(48, 23)
            Me.cbxTitle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxTitle.TabIndex = 9
            Me.cbxTitle.Text = "Title"
            '
            'btnPurgeRows
            '
            Me.btnPurgeRows.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnPurgeRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.btnPurgeRows.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnPurgeRows.Location = New System.Drawing.Point(548, 569)
            Me.btnPurgeRows.Name = "btnPurgeRows"
            Me.btnPurgeRows.Size = New System.Drawing.Size(109, 26)
            Me.btnPurgeRows.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnPurgeRows.TabIndex = 15
            Me.btnPurgeRows.Text = "Purge Deleted Rows"
            '
            'cbxGridIndex
            '
            Me.cbxGridIndex.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            '
            '
            '
            Me.cbxGridIndex.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.cbxGridIndex.Checked = True
            Me.cbxGridIndex.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbxGridIndex.CheckValue = "Y"
            Me.cbxGridIndex.Location = New System.Drawing.Point(344, 568)
            Me.cbxGridIndex.Name = "cbxGridIndex"
            Me.cbxGridIndex.Size = New System.Drawing.Size(148, 23)
            Me.cbxGridIndex.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxGridIndex.TabIndex = 14
            Me.cbxGridIndex.Text = "Show Row Grid Indexes"
            '
            'cbxRowHeaders
            '
            Me.cbxRowHeaders.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            '
            '
            '
            Me.cbxRowHeaders.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.cbxRowHeaders.Checked = True
            Me.cbxRowHeaders.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbxRowHeaders.CheckValue = "Y"
            Me.cbxRowHeaders.Location = New System.Drawing.Point(344, 543)
            Me.cbxRowHeaders.Name = "cbxRowHeaders"
            Me.cbxRowHeaders.Size = New System.Drawing.Size(148, 23)
            Me.cbxRowHeaders.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxRowHeaders.TabIndex = 13
            Me.cbxRowHeaders.Text = "Show Row Headers"
            '
            'btnShowDeleted
            '
            Me.btnShowDeleted.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnShowDeleted.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.btnShowDeleted.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnShowDeleted.Location = New System.Drawing.Point(663, 569)
            Me.btnShowDeleted.Name = "btnShowDeleted"
            Me.btnShowDeleted.Size = New System.Drawing.Size(109, 26)
            Me.btnShowDeleted.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnShowDeleted.TabIndex = 7
            Me.btnShowDeleted.Text = "Show Deleted Rows"
            '
            'btnHideDeleted
            '
            Me.btnHideDeleted.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.btnHideDeleted.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.btnHideDeleted.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.btnHideDeleted.Location = New System.Drawing.Point(663, 540)
            Me.btnHideDeleted.Name = "btnHideDeleted"
            Me.btnHideDeleted.Size = New System.Drawing.Size(109, 26)
            Me.btnHideDeleted.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.btnHideDeleted.TabIndex = 6
            Me.btnHideDeleted.Text = "Hide Deleted Rows"
            '
            'cbxAutoDelete
            '
            Me.cbxAutoDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            '
            '
            '
            Me.cbxAutoDelete.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.cbxAutoDelete.Checked = True
            Me.cbxAutoDelete.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbxAutoDelete.CheckValue = "Y"
            Me.cbxAutoDelete.Location = New System.Drawing.Point(509, 540)
            Me.cbxAutoDelete.Name = "cbxAutoDelete"
            Me.cbxAutoDelete.Size = New System.Drawing.Size(148, 23)
            Me.cbxAutoDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cbxAutoDelete.TabIndex = 5
            Me.cbxAutoDelete.Text = "Auto Hide Deleted Rows"
            '
            'superGridControl1
            '
            Me.superGridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
            Me.superGridControl1.Location = New System.Drawing.Point(0, 123)
            Me.superGridControl1.Name = "superGridControl1"
            Me.superGridControl1.PrimaryGrid.AllowRowDelete = True
            Me.superGridControl1.PrimaryGrid.AllowRowHeaderResize = True
            Me.superGridControl1.PrimaryGrid.AllowRowInsert = True
            Me.superGridControl1.PrimaryGrid.AllowRowResize = True
            Me.superGridControl1.PrimaryGrid.Caption.Text = "(Caption)<div align=""vcenter"">Wolf Power and Machine Works Inc.</div>"
            GridColumn1.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn1.DefaultNewRowCellValue = "Machine Name"
            GridColumn1.Name = "Machine"
            GridColumn2.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn2.DefaultNewRowCellValue = "false"
            GridColumn2.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl)
            GridColumn2.Name = "Dual Voltage"
            GridColumn3.DefaultNewRowCellValue = "false"
            GridColumn3.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridSwitchButtonEditControl)
            GridColumn3.Name = "Power State"
            GridColumn4.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn4.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl)
            GridColumn4.Name = "Last Maintance"
            GridColumn4.Width = 140
            GridColumn5.DefaultNewRowCellValue = "Start"
            GridColumn5.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridButtonXEditControl)
            GridColumn5.MarkRowDirtyOnCellValueChange = False
            GridColumn5.Name = "Start/Stop"
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn1)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn2)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn3)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn4)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn5)
            Me.superGridControl1.PrimaryGrid.DefaultRowHeight = 30
            Background1.Color1 = System.Drawing.Color.AliceBlue
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Background = Background1
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            Padding1.Right = 6
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.ImagePadding = Padding1
            Padding2.Bottom = 6
            Padding2.Left = 6
            Padding2.Right = 6
            Padding2.Top = 6
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Margin = Padding2
            Background2.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.SelectedMouseOver.Background = Background2
            Background3.Color1 = System.Drawing.Color.Lavender
            Background3.Color2 = System.Drawing.Color.DarkSlateGray
            Background3.GradientAngle = 45
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderRowStyles.Default.RowHeader.Background = Background3
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderRowStyles.Default.RowHeader.BorderHighlightColor = System.Drawing.Color.White
            Padding3.Bottom = 4
            Padding3.Left = 4
            Padding3.Right = 4
            Padding3.Top = 4
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.Margin = Padding3
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.TopLeft
            Padding4.Bottom = 4
            Padding4.Left = 4
            Padding4.Right = 4
            Padding4.Top = 4
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.Margin = Padding4
            Background4.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.FooterStyles.SelectedMouseOver.Background = Background4
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.ImageOverlay = DevComponents.DotNetBar.SuperGrid.Style.ImageOverlay.None
            Padding5.Right = 4
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.ImagePadding = Padding5
            Padding6.Bottom = 4
            Padding6.Left = 4
            Padding6.Right = 4
            Padding6.Top = 4
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.Margin = Padding6
            Background5.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.SelectedMouseOver.Background = Background5
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.Font = New System.Drawing.Font("Lucida Handwriting", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
            Padding7.Right = 6
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.ImagePadding = Padding7
            Padding8.Bottom = 4
            Padding8.Left = 4
            Padding8.Right = 4
            Padding8.Top = 4
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.Margin = Padding8
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.TextColor = System.Drawing.Color.Navy
            Background6.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.SelectedMouseOver.Background = Background6
            Me.superGridControl1.PrimaryGrid.FilterExpr = Nothing
            Me.superGridControl1.PrimaryGrid.Footer.Text = "(Footer)<div align=""vcenter"">Check with your Supervisor if you have <b>ANY</b> qu" & _
                "estions.</div>"
            Me.superGridControl1.PrimaryGrid.Footer.Visible = False
            Me.superGridControl1.PrimaryGrid.Header.Text = "(Header) <div align=""vcenter"">Make sure operator is a <b><font color=""#ED1C24"">SA" & _
                "FE DISTANCE</font> </b>away from the machine power panel before starting machine" & _
                ".</div>"
            Me.superGridControl1.PrimaryGrid.Header.Visible = False
            Me.superGridControl1.PrimaryGrid.ImmediateResize = True
            Me.superGridControl1.PrimaryGrid.RowDragBehavior = DevComponents.DotNetBar.SuperGrid.RowDragBehavior.Move
            Me.superGridControl1.PrimaryGrid.ShowInsertRow = True
            Me.superGridControl1.PrimaryGrid.ShowRowGridIndex = True
            Me.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
            Me.superGridControl1.PrimaryGrid.Title.Text = "(Title)<div align=""vcenter"">Check operators manual for suggested maintanance inte" & _
                "rvals</div>"
            Me.superGridControl1.PrimaryGrid.Title.Visible = False
            Me.superGridControl1.PrimaryGrid.UseAlternateRowStyle = True
            Me.superGridControl1.Size = New System.Drawing.Size(784, 408)
            Me.superGridControl1.TabIndex = 4
            Me.superGridControl1.Text = "superGridControl1"
            '
            'styleManager1
            '
            Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
            Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
            '
            'DemoGridBasics0
            '
            Me.ClientSize = New System.Drawing.Size(784, 603)
            Me.Controls.Add(Me.btnPurgeRows)
            Me.Controls.Add(Me.cbxGridIndex)
            Me.Controls.Add(Me.cbxRowHeaders)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.btnShowDeleted)
            Me.Controls.Add(Me.btnHideDeleted)
            Me.Controls.Add(Me.cbxAutoDelete)
            Me.Controls.Add(Me.superGridControl1)
            Me.Controls.Add(Me.richTextBox1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "DemoGridBasics0"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SuperGrid Demo - Basic Components"
            Me.groupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private richTextBox1 As RichTextBox
		Private superGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
		Private WithEvents cbxAutoDelete As DevComponents.DotNetBar.Controls.CheckBoxX
		Private WithEvents btnHideDeleted As DevComponents.DotNetBar.ButtonX
		Private WithEvents btnShowDeleted As DevComponents.DotNetBar.ButtonX
		Private WithEvents cbxCaption As DevComponents.DotNetBar.Controls.CheckBoxX
		Private WithEvents cbxTitle As DevComponents.DotNetBar.Controls.CheckBoxX
		Private WithEvents cbxHeader As DevComponents.DotNetBar.Controls.CheckBoxX
		Private WithEvents cbxFooter As DevComponents.DotNetBar.Controls.CheckBoxX
		Private groupBox1 As GroupBox
		Private WithEvents cbxRowHeaders As DevComponents.DotNetBar.Controls.CheckBoxX
		Private WithEvents cbxGridIndex As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents btnPurgeRows As DevComponents.DotNetBar.ButtonX
        Private WithEvents styleManager1 As DevComponents.DotNetBar.StyleManager
    End Class
End Namespace