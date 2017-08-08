Namespace SuperGridDemo
	Partial Public Class DemoUserEdit
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DemoUserEdit))
            Dim GridColumn1 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn2 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding1 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim GridColumn3 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim GridColumn4 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding2 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim Padding3 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Dim GridColumn5 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn
            Dim Padding4 As DevComponents.DotNetBar.SuperGrid.Style.Padding = New DevComponents.DotNetBar.SuperGrid.Style.Padding
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
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
            GridColumn1.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            GridColumn1.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn1.Name = "Color Combo"
            GridColumn1.Width = 160
            GridColumn2.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
            GridColumn2.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.TopCenter
            Padding1.Bottom = -5
            Padding1.Top = 4
            GridColumn2.HeaderStyles.Default.ImagePadding = Padding1
            GridColumn2.Name = "Image Combo"
            GridColumn2.Width = 110
            GridColumn3.HeaderStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.[True]
            GridColumn3.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter
            GridColumn3.HeaderText = "Audio Clip (NonModal)"
            GridColumn3.Name = "Audio Clip"
            GridColumn3.Width = 110
            GridColumn4.HeaderStyles.Default.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
            GridColumn4.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.BottomCenter
            Padding2.Bottom = 4
            GridColumn4.HeaderStyles.Default.ImagePadding = Padding2
            Padding3.Bottom = 4
            GridColumn4.HeaderStyles.Default.Margin = Padding3
            GridColumn4.HeaderText = "Process States (InPlace)"
            GridColumn4.Name = "Process State"
            GridColumn4.Width = 170
            GridColumn5.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
            GridColumn5.HeaderText = "File Path (Modal)"
            GridColumn5.Name = "File Path"
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn1)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn2)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn3)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn4)
            Me.superGridControl1.PrimaryGrid.Columns.Add(GridColumn5)
            Me.superGridControl1.PrimaryGrid.DefaultRowHeight = 0
            Padding4.Bottom = 4
            Padding4.Left = 4
            Padding4.Right = 4
            Padding4.Top = 4
            Me.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.Margin = Padding4
            Me.superGridControl1.PrimaryGrid.FilterExpr = Nothing
            Me.superGridControl1.PrimaryGrid.ImageList = Me.imageList1
            Me.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled
            Me.superGridControl1.Size = New System.Drawing.Size(784, 413)
            Me.superGridControl1.TabIndex = 0
            Me.superGridControl1.Text = "superGridControl1"
            '
            'styleManager1
            '
            Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue
            Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
            '
            'DemoUserEdit
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 536)
            Me.Controls.Add(Me.superGridControl1)
            Me.Controls.Add(Me.richTextBox1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "DemoUserEdit"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SuperGrid Demo - User defined cell editors (User drawn, Modal, NonModal, and InPl" & _
                "ace)"
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private richTextBox1 As System.Windows.Forms.RichTextBox
		Private WithEvents superGridControl1 As DevComponents.DotNetBar.SuperGrid.SuperGridControl
        Private imageList1 As System.Windows.Forms.ImageList
        Private WithEvents styleManager1 As DevComponents.DotNetBar.StyleManager
	End Class
End Namespace