Namespace SlidePanel
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.slidePanel1 = New DevComponents.DotNetBar.Controls.SlidePanel()
			Me.labelX3 = New DevComponents.DotNetBar.LabelX()
			Me.buttonX1 = New DevComponents.DotNetBar.ButtonX()
			Me.labelX2 = New DevComponents.DotNetBar.LabelX()
			Me.labelX1 = New DevComponents.DotNetBar.LabelX()
			Me.buttonTop = New DevComponents.DotNetBar.ButtonX()
			Me.buttonBottom = New DevComponents.DotNetBar.ButtonX()
			Me.buttonRight = New DevComponents.DotNetBar.ButtonX()
			Me.buttonLeft = New DevComponents.DotNetBar.ButtonX()
			Me.labelX4 = New DevComponents.DotNetBar.LabelX()
			Me.slidePanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' slidePanel1
			' 
			Me.slidePanel1.Controls.Add(Me.labelX4)
			Me.slidePanel1.Controls.Add(Me.buttonLeft)
			Me.slidePanel1.Controls.Add(Me.buttonRight)
			Me.slidePanel1.Controls.Add(Me.buttonBottom)
			Me.slidePanel1.Controls.Add(Me.buttonTop)
			Me.slidePanel1.Controls.Add(Me.labelX3)
			Me.slidePanel1.Controls.Add(Me.buttonX1)
			Me.slidePanel1.Controls.Add(Me.labelX2)
			Me.slidePanel1.Controls.Add(Me.labelX1)
			Me.slidePanel1.Location = New Point(12, 5)
			Me.slidePanel1.Name = "slidePanel1"
			Me.slidePanel1.Size = New Size(448, 237)
			Me.slidePanel1.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right
			Me.slidePanel1.TabIndex = 0
			Me.slidePanel1.Text = "slidePanel1"
			' 
			' labelX3
			' 
			' 
			' 
			' 
			Me.labelX3.BackgroundStyle.Class = ""
			Me.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX3.Location = New Point(3, 128)
			Me.labelX3.Name = "labelX3"
			Me.labelX3.Size = New Size(348, 47)
			Me.labelX3.TabIndex = 3
			Me.labelX3.Text = "Click button below to close panel. Then use the panel ""thumb"" on right side to dr" & "ag it out. You can drag the panel out or you can just click the thumb to open th" & "e panel."
			Me.labelX3.WordWrap = True
			' 
			' buttonX1
			' 
			Me.buttonX1.AccessibleRole = AccessibleRole.PushButton
			Me.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
			Me.buttonX1.Location = New Point(3, 187)
			Me.buttonX1.Name = "buttonX1"
			Me.buttonX1.Size = New Size(107, 37)
			Me.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.buttonX1.TabIndex = 2
			Me.buttonX1.Text = "Click to Slide-Out"
'			Me.buttonX1.Click += New System.EventHandler(Me.buttonX1_Click)
			' 
			' labelX2
			' 
			' 
			' 
			' 
			Me.labelX2.BackgroundStyle.Class = ""
			Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX2.Location = New Point(3, 56)
			Me.labelX2.Name = "labelX2"
			Me.labelX2.Size = New Size(348, 66)
			Me.labelX2.TabIndex = 1
			Me.labelX2.Text = resources.GetString("labelX2.Text")
			Me.labelX2.WordWrap = True
			' 
			' labelX1
			' 
			' 
			' 
			' 
			Me.labelX1.BackgroundStyle.Class = ""
			Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX1.Dock = DockStyle.Top
			Me.labelX1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.labelX1.Location = New Point(0, 0)
			Me.labelX1.Name = "labelX1"
			Me.labelX1.Size = New Size(448, 50)
			Me.labelX1.TabIndex = 0
			Me.labelX1.Text = "SlidePanel Control"
			' 
			' buttonTop
			' 
			Me.buttonTop.AccessibleRole = AccessibleRole.PushButton
			Me.buttonTop.AutoCheckOnClick = True
			Me.buttonTop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
			Me.buttonTop.Location = New Point(394, 154)
			Me.buttonTop.Name = "buttonTop"
			Me.buttonTop.Size = New Size(24, 24)
			Me.buttonTop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.buttonTop.TabIndex = 4
'			Me.buttonTop.Click += New System.EventHandler(Me.buttonTop_Click)
			' 
			' buttonBottom
			' 
			Me.buttonBottom.AccessibleRole = AccessibleRole.PushButton
			Me.buttonBottom.AutoCheckOnClick = True
			Me.buttonBottom.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
			Me.buttonBottom.Location = New Point(394, 203)
			Me.buttonBottom.Name = "buttonBottom"
			Me.buttonBottom.Size = New Size(24, 24)
			Me.buttonBottom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.buttonBottom.TabIndex = 5
'			Me.buttonBottom.Click += New System.EventHandler(Me.buttonBottom_Click)
			' 
			' buttonRight
			' 
			Me.buttonRight.AccessibleRole = AccessibleRole.PushButton
			Me.buttonRight.AutoCheckOnClick = True
			Me.buttonRight.Checked = True
			Me.buttonRight.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
			Me.buttonRight.Location = New Point(421, 179)
			Me.buttonRight.Name = "buttonRight"
			Me.buttonRight.Size = New Size(24, 24)
			Me.buttonRight.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.buttonRight.TabIndex = 6
'			Me.buttonRight.Click += New System.EventHandler(Me.buttonRight_Click)
			' 
			' buttonLeft
			' 
			Me.buttonLeft.AccessibleRole = AccessibleRole.PushButton
			Me.buttonLeft.AutoCheckOnClick = True
			Me.buttonLeft.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
			Me.buttonLeft.Location = New Point(367, 179)
			Me.buttonLeft.Name = "buttonLeft"
			Me.buttonLeft.Size = New Size(24, 24)
			Me.buttonLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.buttonLeft.TabIndex = 7
'			Me.buttonLeft.Click += New System.EventHandler(Me.buttonLeft_Click)
			' 
			' labelX4
			' 
			' 
			' 
			' 
			Me.labelX4.BackgroundStyle.Class = ""
			Me.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX4.Location = New Point(302, 186)
			Me.labelX4.Name = "labelX4"
			Me.labelX4.Size = New Size(62, 17)
			Me.labelX4.TabIndex = 8
			Me.labelX4.Text = "Slide side:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(472, 254)
			Me.Controls.Add(Me.slidePanel1)
			Me.DoubleBuffered = True
			Me.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.Text = "SlidePanel Demo"
			Me.slidePanel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private slidePanel1 As DevComponents.DotNetBar.Controls.SlidePanel
		Private labelX2 As DevComponents.DotNetBar.LabelX
		Private labelX1 As DevComponents.DotNetBar.LabelX
		Private WithEvents buttonX1 As DevComponents.DotNetBar.ButtonX
		Private labelX3 As DevComponents.DotNetBar.LabelX
		Private labelX4 As DevComponents.DotNetBar.LabelX
		Private WithEvents buttonLeft As DevComponents.DotNetBar.ButtonX
		Private WithEvents buttonRight As DevComponents.DotNetBar.ButtonX
		Private WithEvents buttonBottom As DevComponents.DotNetBar.ButtonX
		Private WithEvents buttonTop As DevComponents.DotNetBar.ButtonX
	End Class
End Namespace

