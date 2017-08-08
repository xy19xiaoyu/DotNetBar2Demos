Namespace MetroBill
	Partial Public Class ClientControl
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
			Me.cancelButton = New DevComponents.DotNetBar.ButtonX()
			Me.saveButton = New DevComponents.DotNetBar.ButtonX()
			Me.labelX5 = New DevComponents.DotNetBar.LabelX()
			Me.labelX4 = New DevComponents.DotNetBar.LabelX()
			Me.textBoxX4 = New DevComponents.DotNetBar.Controls.TextBoxX()
			Me.labelX3 = New DevComponents.DotNetBar.LabelX()
			Me.textBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX()
			Me.labelX2 = New DevComponents.DotNetBar.LabelX()
			Me.textBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
			Me.labelX1 = New DevComponents.DotNetBar.LabelX()
			Me.textBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
			Me.panelEx1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panelEx1
			' 
			Me.panelEx1.CanvasColor = SystemColors.Control
			Me.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.panelEx1.Controls.Add(Me.cancelButton)
			Me.panelEx1.Controls.Add(Me.saveButton)
			Me.panelEx1.Controls.Add(Me.labelX5)
			Me.panelEx1.Controls.Add(Me.labelX4)
			Me.panelEx1.Controls.Add(Me.textBoxX4)
			Me.panelEx1.Controls.Add(Me.labelX3)
			Me.panelEx1.Controls.Add(Me.textBoxX3)
			Me.panelEx1.Controls.Add(Me.labelX2)
			Me.panelEx1.Controls.Add(Me.textBoxX2)
			Me.panelEx1.Controls.Add(Me.labelX1)
			Me.panelEx1.Controls.Add(Me.textBoxX1)
			Me.panelEx1.Location = New Point(0, 0)
			Me.panelEx1.Name = "panelEx1"
			Me.panelEx1.Size = New Size(241, 212)
			Me.panelEx1.Style.Alignment = StringAlignment.Center
			Me.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
			Me.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
			Me.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
			Me.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
			Me.panelEx1.Style.GradientAngle = 90
			Me.panelEx1.TabIndex = 11
			Me.panelEx1.Text = "panelEx1"
			' 
			' cancelButton
			' 
			Me.cancelButton.AccessibleRole = AccessibleRole.PushButton
			Me.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
			Me.cancelButton.Location = New Point(137, 174)
			Me.cancelButton.Name = "cancelButton"
			Me.cancelButton.Size = New Size(88, 29)
			Me.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.cancelButton.TabIndex = 21
			Me.cancelButton.Text = "Cancel"
			' 
			' saveButton
			' 
			Me.saveButton.AccessibleRole = AccessibleRole.PushButton
			Me.saveButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
			Me.saveButton.Location = New Point(43, 174)
			Me.saveButton.Name = "saveButton"
			Me.saveButton.Size = New Size(88, 29)
			Me.saveButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.saveButton.TabIndex = 20
			Me.saveButton.Text = "Save"
			' 
			' labelX5
			' 
			' 
			' 
			' 
			Me.labelX5.BackgroundStyle.Class = ""
			Me.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.labelX5.Location = New Point(16, 10)
			Me.labelX5.Name = "labelX5"
			Me.labelX5.Size = New Size(106, 32)
			Me.labelX5.TabIndex = 19
			Me.labelX5.Text = "New Client"
			' 
			' labelX4
			' 
			' 
			' 
			' 
			Me.labelX4.BackgroundStyle.Class = ""
			Me.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX4.Location = New Point(16, 126)
			Me.labelX4.Name = "labelX4"
			Me.labelX4.Size = New Size(75, 20)
			Me.labelX4.TabIndex = 18
			Me.labelX4.Text = "Email:"
			Me.labelX4.TextAlignment = StringAlignment.Far
			' 
			' textBoxX4
			' 
			' 
			' 
			' 
			Me.textBoxX4.Border.Class = "TextBoxBorder"
			Me.textBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.textBoxX4.Location = New Point(97, 126)
			Me.textBoxX4.Name = "textBoxX4"
			Me.textBoxX4.Size = New Size(128, 22)
			Me.textBoxX4.TabIndex = 17
			' 
			' labelX3
			' 
			' 
			' 
			' 
			Me.labelX3.BackgroundStyle.Class = ""
			Me.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX3.Location = New Point(16, 100)
			Me.labelX3.Name = "labelX3"
			Me.labelX3.Size = New Size(75, 20)
			Me.labelX3.TabIndex = 16
			Me.labelX3.Text = "Company:"
			Me.labelX3.TextAlignment = StringAlignment.Far
			' 
			' textBoxX3
			' 
			' 
			' 
			' 
			Me.textBoxX3.Border.Class = "TextBoxBorder"
			Me.textBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.textBoxX3.Location = New Point(97, 100)
			Me.textBoxX3.Name = "textBoxX3"
			Me.textBoxX3.Size = New Size(128, 22)
			Me.textBoxX3.TabIndex = 15
			' 
			' labelX2
			' 
			' 
			' 
			' 
			Me.labelX2.BackgroundStyle.Class = ""
			Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX2.Location = New Point(16, 74)
			Me.labelX2.Name = "labelX2"
			Me.labelX2.Size = New Size(75, 20)
			Me.labelX2.TabIndex = 14
			Me.labelX2.Text = "Last Name:"
			Me.labelX2.TextAlignment = StringAlignment.Far
			' 
			' textBoxX2
			' 
			' 
			' 
			' 
			Me.textBoxX2.Border.Class = "TextBoxBorder"
			Me.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.textBoxX2.Location = New Point(97, 74)
			Me.textBoxX2.Name = "textBoxX2"
			Me.textBoxX2.Size = New Size(128, 22)
			Me.textBoxX2.TabIndex = 13
			' 
			' labelX1
			' 
			' 
			' 
			' 
			Me.labelX1.BackgroundStyle.Class = ""
			Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX1.Location = New Point(16, 48)
			Me.labelX1.Name = "labelX1"
			Me.labelX1.Size = New Size(75, 20)
			Me.labelX1.TabIndex = 12
			Me.labelX1.Text = "First Name:"
			Me.labelX1.TextAlignment = StringAlignment.Far
			' 
			' textBoxX1
			' 
			' 
			' 
			' 
			Me.textBoxX1.Border.Class = "TextBoxBorder"
			Me.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.textBoxX1.Location = New Point(97, 48)
			Me.textBoxX1.Name = "textBoxX1"
			Me.textBoxX1.Size = New Size(128, 22)
			Me.textBoxX1.TabIndex = 11
			' 
			' ClientControl
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.panelEx1)
			Me.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.Name = "ClientControl"
			Me.Size = New Size(244, 215)
			Me.panelEx1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panelEx1 As DevComponents.DotNetBar.PanelEx
		Private cancelButton As DevComponents.DotNetBar.ButtonX
		Private saveButton As DevComponents.DotNetBar.ButtonX
		Private labelX5 As DevComponents.DotNetBar.LabelX
		Private labelX4 As DevComponents.DotNetBar.LabelX
		Private textBoxX4 As DevComponents.DotNetBar.Controls.TextBoxX
		Private labelX3 As DevComponents.DotNetBar.LabelX
		Private textBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
		Private labelX2 As DevComponents.DotNetBar.LabelX
		Private textBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
		Private labelX1 As DevComponents.DotNetBar.LabelX
		Private textBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX

	End Class
End Namespace
