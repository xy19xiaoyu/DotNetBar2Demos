Namespace PageSlider
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
			Me.pageSlider1 = New DevComponents.DotNetBar.Controls.PageSlider()
			Me.pageSliderPage1 = New DevComponents.DotNetBar.Controls.PageSliderPage()
			Me.buttonX1 = New DevComponents.DotNetBar.ButtonX()
			Me.labelX3 = New DevComponents.DotNetBar.LabelX()
			Me.labelX1 = New DevComponents.DotNetBar.LabelX()
			Me.pageSliderPage2 = New DevComponents.DotNetBar.Controls.PageSliderPage()
			Me.labelX2 = New DevComponents.DotNetBar.LabelX()
			Me.pageSlider1.SuspendLayout()
			Me.pageSliderPage1.SuspendLayout()
			Me.pageSliderPage2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' pageSlider1
			' 
			Me.pageSlider1.AnimationTime = 250
			Me.pageSlider1.Controls.Add(Me.pageSliderPage1)
			Me.pageSlider1.Controls.Add(Me.pageSliderPage2)
			Me.pageSlider1.Location = New Point(72, 58)
			Me.pageSlider1.Name = "pageSlider1"
			Me.pageSlider1.SelectedPage = Me.pageSliderPage1
			Me.pageSlider1.Size = New Size(459, 307)
			Me.pageSlider1.TabIndex = 0
			Me.pageSlider1.Text = "pageSlider1"
			' 
			' pageSliderPage1
			' 
			Me.pageSliderPage1.Controls.Add(Me.buttonX1)
			Me.pageSliderPage1.Controls.Add(Me.labelX3)
			Me.pageSliderPage1.Controls.Add(Me.labelX1)
			Me.pageSliderPage1.Location = New Point(4, 8)
			Me.pageSliderPage1.Name = "pageSliderPage1"
			Me.pageSliderPage1.Size = New Size(353, 295)
			Me.pageSliderPage1.TabIndex = 3
			' 
			' buttonX1
			' 
			Me.buttonX1.AccessibleRole = AccessibleRole.PushButton
			Me.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
			Me.buttonX1.Location = New Point(3, 176)
			Me.buttonX1.Name = "buttonX1"
			Me.buttonX1.Size = New Size(108, 47)
			Me.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.buttonX1.TabIndex = 2
			Me.buttonX1.Text = "Click to create new page"
'			Me.buttonX1.Click += New System.EventHandler(Me.buttonX1_Click)
			' 
			' labelX3
			' 
			' 
			' 
			' 
			Me.labelX3.BackgroundStyle.Class = ""
			Me.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX3.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.labelX3.Location = New Point(3, 58)
			Me.labelX3.Name = "labelX3"
			Me.labelX3.Size = New Size(239, 91)
			Me.labelX3.TabIndex = 1
			Me.labelX3.Text = "Each Page Slider page is standard panel which can host any control you choose." & vbCrLf & vbCr & vbLf & "Page Slider also support Touch and inertial scrolling so its great choice for t" & "ouch based apps."
			Me.labelX3.WordWrap = True
			' 
			' labelX1
			' 
			' 
			' 
			' 
			Me.labelX1.BackgroundStyle.Class = ""
			Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX1.Dock = DockStyle.Top
			Me.labelX1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.labelX1.Location = New Point(0, 0)
			Me.labelX1.Name = "labelX1"
			Me.labelX1.Size = New Size(353, 52)
			Me.labelX1.TabIndex = 0
			Me.labelX1.Text = "First Page Slider Page"
			Me.labelX1.TextAlignment = StringAlignment.Center
			' 
			' pageSliderPage2
			' 
			Me.pageSliderPage2.Controls.Add(Me.labelX2)
			Me.pageSliderPage2.Location = New Point(405, 8)
			Me.pageSliderPage2.Name = "pageSliderPage2"
			Me.pageSliderPage2.Size = New Size(353, 295)
			Me.pageSliderPage2.TabIndex = 4
			' 
			' labelX2
			' 
			' 
			' 
			' 
			Me.labelX2.BackgroundStyle.Class = ""
			Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX2.Dock = DockStyle.Top
			Me.labelX2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.labelX2.Location = New Point(0, 0)
			Me.labelX2.Name = "labelX2"
			Me.labelX2.Size = New Size(353, 52)
			Me.labelX2.TabIndex = 1
			Me.labelX2.Text = "Second Page Slider Page"
			Me.labelX2.TextAlignment = StringAlignment.Center
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(602, 377)
			Me.Controls.Add(Me.pageSlider1)
			Me.DoubleBuffered = True
			Me.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.Text = "Page Slider Demo"
			Me.pageSlider1.ResumeLayout(False)
			Me.pageSliderPage1.ResumeLayout(False)
			Me.pageSliderPage2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pageSlider1 As DevComponents.DotNetBar.Controls.PageSlider
		Private pageSliderPage1 As DevComponents.DotNetBar.Controls.PageSliderPage
		Private labelX1 As DevComponents.DotNetBar.LabelX
		Private pageSliderPage2 As DevComponents.DotNetBar.Controls.PageSliderPage
		Private labelX2 As DevComponents.DotNetBar.LabelX
		Private labelX3 As DevComponents.DotNetBar.LabelX
		Private WithEvents buttonX1 As DevComponents.DotNetBar.ButtonX
	End Class
End Namespace

