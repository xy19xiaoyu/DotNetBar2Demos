Namespace TestVirtualKeyboard
	Partial Public Class StartForm
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
			Me.itemPanel1 = New DevComponents.DotNetBar.ItemPanel()
			Me.metroTileItem1 = New DevComponents.DotNetBar.Metro.MetroTileItem()
			Me.metroTileItem2 = New DevComponents.DotNetBar.Metro.MetroTileItem()
			Me.metroTileItem3 = New DevComponents.DotNetBar.Metro.MetroTileItem()
			Me.metroTileItem4 = New DevComponents.DotNetBar.Metro.MetroTileItem()
			Me.metroTileItem5 = New DevComponents.DotNetBar.Metro.MetroTileItem()
			Me.labelX1 = New DevComponents.DotNetBar.LabelX()
			Me.SuspendLayout()
			' 
			' itemPanel1
			' 
			' 
			' 
			' 
			Me.itemPanel1.BackgroundStyle.Class = ""
			Me.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.itemPanel1.ContainerControlProcessDialogKey = True
			Me.itemPanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.metroTileItem1, Me.metroTileItem2, Me.metroTileItem3, Me.metroTileItem4, Me.metroTileItem5})
			Me.itemPanel1.Location = New Point(27, 55)
			Me.itemPanel1.MultiLine = True
			Me.itemPanel1.Name = "itemPanel1"
			Me.itemPanel1.ResizeItemsToFit = False
			Me.itemPanel1.Size = New Size(369, 282)
			Me.itemPanel1.TabIndex = 0
			Me.itemPanel1.Text = "itemPanel1"
			' 
			' metroTileItem1
			' 
			Me.metroTileItem1.Name = "metroTileItem1"
			Me.metroTileItem1.Text = "<font size=""+4"">Attached to Controls</font><br/>TouchKeyboard component attached " & "directly to controls"
			Me.metroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default
			' 
			' 
			' 
			Me.metroTileItem1.TileStyle.BackColor = Color.FromArgb((CInt((CByte(36)))), (CInt((CByte(83)))), (CInt((CByte(117)))))
			Me.metroTileItem1.TileStyle.BackColor2 = Color.FromArgb((CInt((CByte(48)))), (CInt((CByte(103)))), (CInt((CByte(155)))))
			Me.metroTileItem1.TileStyle.BackColorGradientAngle = 45
			Me.metroTileItem1.TileStyle.Class = ""
			Me.metroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroTileItem1.TileStyle.PaddingBottom = 4
			Me.metroTileItem1.TileStyle.PaddingLeft = 4
			Me.metroTileItem1.TileStyle.PaddingRight = 4
			Me.metroTileItem1.TileStyle.PaddingTop = 4
			Me.metroTileItem1.TileStyle.TextColor = Color.White
			Me.metroTileItem1.TitleText = "Keyboard"
'			Me.metroTileItem1.Click += New System.EventHandler(Me.metroTileItem1_Click)
			' 
			' metroTileItem2
			' 
			Me.metroTileItem2.Name = "metroTileItem2"
			Me.metroTileItem2.Text = "<font size=""+4"">Attached to Form</font><br/>TouchKeyboard component attached to F" & "orm only"
			Me.metroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default
			' 
			' 
			' 
			Me.metroTileItem2.TileStyle.BackColor = Color.FromArgb((CInt((CByte(36)))), (CInt((CByte(83)))), (CInt((CByte(117)))))
			Me.metroTileItem2.TileStyle.BackColor2 = Color.FromArgb((CInt((CByte(48)))), (CInt((CByte(103)))), (CInt((CByte(155)))))
			Me.metroTileItem2.TileStyle.BackColorGradientAngle = 45
			Me.metroTileItem2.TileStyle.Class = ""
			Me.metroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroTileItem2.TileStyle.PaddingBottom = 4
			Me.metroTileItem2.TileStyle.PaddingLeft = 4
			Me.metroTileItem2.TileStyle.PaddingRight = 4
			Me.metroTileItem2.TileStyle.PaddingTop = 4
			Me.metroTileItem2.TileStyle.TextColor = Color.White
			Me.metroTileItem2.TitleText = "Keyboard"
'			Me.metroTileItem2.Click += New System.EventHandler(Me.metroTileItem2_Click)
			' 
			' metroTileItem3
			' 
			Me.metroTileItem3.Name = "metroTileItem3"
			Me.metroTileItem3.Text = "<font size=""+4"">Custom Layout</font><br/>How to create keyboard with custom layou" & "t"
			Me.metroTileItem3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green
			' 
			' 
			' 
			Me.metroTileItem3.TileStyle.BackColor = Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(151)))), (CInt((CByte(42)))))
			Me.metroTileItem3.TileStyle.BackColor2 = Color.FromArgb((CInt((CByte(152)))), (CInt((CByte(177)))), (CInt((CByte(51)))))
			Me.metroTileItem3.TileStyle.BackColorGradientAngle = 45
			Me.metroTileItem3.TileStyle.Class = ""
			Me.metroTileItem3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroTileItem3.TileStyle.PaddingBottom = 4
			Me.metroTileItem3.TileStyle.PaddingLeft = 4
			Me.metroTileItem3.TileStyle.PaddingRight = 4
			Me.metroTileItem3.TileStyle.PaddingTop = 4
			Me.metroTileItem3.TileStyle.TextColor = Color.White
			Me.metroTileItem3.TitleText = "Keyboard"
'			Me.metroTileItem3.Click += New System.EventHandler(Me.metroTileItem3_Click)
			' 
			' metroTileItem4
			' 
			Me.metroTileItem4.Name = "metroTileItem4"
			Me.metroTileItem4.Text = "<font size=""+4"">From Code</font><br/>TouchKeyboard from code usage"
			Me.metroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta
			' 
			' 
			' 
			Me.metroTileItem4.TileStyle.BackColor = Color.FromArgb((CInt((CByte(118)))), (CInt((CByte(85)))), (CInt((CByte(148)))))
			Me.metroTileItem4.TileStyle.BackColor2 = Color.FromArgb((CInt((CByte(133)))), (CInt((CByte(98)))), (CInt((CByte(185)))))
			Me.metroTileItem4.TileStyle.BackColorGradientAngle = 45
			Me.metroTileItem4.TileStyle.Class = ""
			Me.metroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroTileItem4.TileStyle.PaddingBottom = 4
			Me.metroTileItem4.TileStyle.PaddingLeft = 4
			Me.metroTileItem4.TileStyle.PaddingRight = 4
			Me.metroTileItem4.TileStyle.PaddingTop = 4
			Me.metroTileItem4.TileStyle.TextColor = Color.White
			Me.metroTileItem4.TitleText = "Keyboard"
'			Me.metroTileItem4.Click += New System.EventHandler(Me.metroTileItem4_Click)
			' 
			' metroTileItem5
			' 
			Me.metroTileItem5.Name = "metroTileItem5"
			Me.metroTileItem5.Text = "<font size=""+4"">Custom Rendering</font><br/>Shows how to draw keyboard yourself"
			Me.metroTileItem5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal
			' 
			' 
			' 
			Me.metroTileItem5.TileStyle.BackColor = Color.FromArgb((CInt((CByte(69)))), (CInt((CByte(169)))), (CInt((CByte(142)))))
			Me.metroTileItem5.TileStyle.BackColor2 = Color.FromArgb((CInt((CByte(80)))), (CInt((CByte(187)))), (CInt((CByte(158)))))
			Me.metroTileItem5.TileStyle.BackColorGradientAngle = 45
			Me.metroTileItem5.TileStyle.Class = ""
			Me.metroTileItem5.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.metroTileItem5.TileStyle.PaddingBottom = 4
			Me.metroTileItem5.TileStyle.PaddingLeft = 4
			Me.metroTileItem5.TileStyle.PaddingRight = 4
			Me.metroTileItem5.TileStyle.PaddingTop = 4
			Me.metroTileItem5.TileStyle.TextColor = Color.White
			Me.metroTileItem5.TitleText = "Keyboard"
'			Me.metroTileItem5.Click += New System.EventHandler(Me.metroTileItem5_Click)
			' 
			' labelX1
			' 
			' 
			' 
			' 
			Me.labelX1.BackgroundStyle.Class = ""
			Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.labelX1.Location = New Point(10, 0)
			Me.labelX1.Name = "labelX1"
			Me.labelX1.Size = New Size(388, 49)
			Me.labelX1.TabIndex = 1
			Me.labelX1.Text = "Touch Keyboard Demo"
			' 
			' StartForm
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(419, 352)
			Me.Controls.Add(Me.labelX1)
			Me.Controls.Add(Me.itemPanel1)
			Me.DoubleBuffered = True
			Me.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = FormBorderStyle.FixedDialog
			Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "StartForm"
			Me.Text = "DotNetBar Keyboard Control"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private itemPanel1 As DevComponents.DotNetBar.ItemPanel
		Private labelX1 As DevComponents.DotNetBar.LabelX
		Private WithEvents metroTileItem1 As DevComponents.DotNetBar.Metro.MetroTileItem
		Private WithEvents metroTileItem2 As DevComponents.DotNetBar.Metro.MetroTileItem
		Private WithEvents metroTileItem3 As DevComponents.DotNetBar.Metro.MetroTileItem
		Private WithEvents metroTileItem4 As DevComponents.DotNetBar.Metro.MetroTileItem
		Private WithEvents metroTileItem5 As DevComponents.DotNetBar.Metro.MetroTileItem
	End Class
End Namespace