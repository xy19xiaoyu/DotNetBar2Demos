Namespace MetroBill
	Partial Public Class InvoiceControl
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
			Me.labelX6 = New DevComponents.DotNetBar.LabelX()
			Me.labelX4 = New DevComponents.DotNetBar.LabelX()
			Me.advTree1 = New DevComponents.AdvTree.AdvTree()
			Me.columnHeader1 = New DevComponents.AdvTree.ColumnHeader()
			Me.columnHeader2 = New DevComponents.AdvTree.ColumnHeader()
			Me.nodeConnector1 = New DevComponents.AdvTree.NodeConnector()
			Me.elementStyle1 = New DevComponents.DotNetBar.ElementStyle()
			Me.labelX3 = New DevComponents.DotNetBar.LabelX()
			Me.textBoxDropDown1 = New DevComponents.DotNetBar.Controls.TextBoxDropDown()
			Me.cancelButton = New DevComponents.DotNetBar.ButtonX()
			Me.saveButton = New DevComponents.DotNetBar.ButtonX()
			Me.labelX5 = New DevComponents.DotNetBar.LabelX()
			Me.labelX2 = New DevComponents.DotNetBar.LabelX()
			Me.textBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
			Me.labelX1 = New DevComponents.DotNetBar.LabelX()
			Me.panelEx1.SuspendLayout()
			CType(Me.advTree1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panelEx1
			' 
			Me.panelEx1.CanvasColor = SystemColors.Control
			Me.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.panelEx1.Controls.Add(Me.labelX6)
			Me.panelEx1.Controls.Add(Me.labelX4)
			Me.panelEx1.Controls.Add(Me.advTree1)
			Me.panelEx1.Controls.Add(Me.labelX3)
			Me.panelEx1.Controls.Add(Me.textBoxDropDown1)
			Me.panelEx1.Controls.Add(Me.cancelButton)
			Me.panelEx1.Controls.Add(Me.saveButton)
			Me.panelEx1.Controls.Add(Me.labelX5)
			Me.panelEx1.Controls.Add(Me.labelX2)
			Me.panelEx1.Controls.Add(Me.textBoxX2)
			Me.panelEx1.Controls.Add(Me.labelX1)
			Me.panelEx1.Dock = DockStyle.Fill
			Me.panelEx1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.panelEx1.Location = New Point(0, 0)
			Me.panelEx1.Name = "panelEx1"
			Me.panelEx1.Size = New Size(438, 340)
			Me.panelEx1.Style.Alignment = StringAlignment.Center
			Me.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
			Me.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
			Me.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
			Me.panelEx1.Style.GradientAngle = 90
			Me.panelEx1.TabIndex = 0
			' 
			' labelX6
			' 
			' 
			' 
			' 
			Me.labelX6.BackgroundStyle.Class = ""
			Me.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX6.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			Me.labelX6.Location = New Point(348, 268)
			Me.labelX6.Name = "labelX6"
			Me.labelX6.Size = New Size(78, 20)
			Me.labelX6.TabIndex = 37
			Me.labelX6.Text = "$0 USD"
			Me.labelX6.TextAlignment = StringAlignment.Far
			' 
			' labelX4
			' 
			' 
			' 
			' 
			Me.labelX4.BackgroundStyle.Class = ""
			Me.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX4.Location = New Point(254, 268)
			Me.labelX4.Name = "labelX4"
			Me.labelX4.Size = New Size(88, 20)
			Me.labelX4.TabIndex = 36
			Me.labelX4.Text = "TOTAL:"
			Me.labelX4.TextAlignment = StringAlignment.Far
			' 
			' advTree1
			' 
			Me.advTree1.AccessibleRole = AccessibleRole.Outline
			Me.advTree1.AllowDrop = True
			Me.advTree1.BackColor = SystemColors.Window
			' 
			' 
			' 
			Me.advTree1.BackgroundStyle.Class = "TreeBorderKey"
			Me.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.advTree1.Columns.Add(Me.columnHeader1)
			Me.advTree1.Columns.Add(Me.columnHeader2)
			Me.advTree1.Location = New Point(97, 104)
			Me.advTree1.Name = "advTree1"
			Me.advTree1.NodesConnector = Me.nodeConnector1
			Me.advTree1.NodeStyle = Me.elementStyle1
			Me.advTree1.PathSeparator = ";"
			Me.advTree1.Size = New Size(329, 160)
			Me.advTree1.Styles.Add(Me.elementStyle1)
			Me.advTree1.TabIndex = 35
			Me.advTree1.Text = "advTree1"
			' 
			' columnHeader1
			' 
			Me.columnHeader1.Name = "columnHeader1"
			Me.columnHeader1.Text = "Description"
			Me.columnHeader1.Width.Relative = 75
			' 
			' columnHeader2
			' 
			Me.columnHeader2.Name = "columnHeader2"
			Me.columnHeader2.Text = "Amount"
			Me.columnHeader2.Width.Relative = 25
			' 
			' nodeConnector1
			' 
			Me.nodeConnector1.LineColor = SystemColors.ControlText
			' 
			' elementStyle1
			' 
			Me.elementStyle1.Class = ""
			Me.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.elementStyle1.Name = "elementStyle1"
			Me.elementStyle1.TextColor = SystemColors.ControlText
			' 
			' labelX3
			' 
			' 
			' 
			' 
			Me.labelX3.BackgroundStyle.Class = ""
			Me.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX3.Location = New Point(3, 102)
			Me.labelX3.Name = "labelX3"
			Me.labelX3.Size = New Size(88, 20)
			Me.labelX3.TabIndex = 34
			Me.labelX3.Text = "Invoice Detail:"
			Me.labelX3.TextAlignment = StringAlignment.Far
			' 
			' textBoxDropDown1
			' 
			Me.textBoxDropDown1.AutoCompleteMode = AutoCompleteMode.None
			Me.textBoxDropDown1.AutoCompleteSource = AutoCompleteSource.None
			' 
			' 
			' 
			Me.textBoxDropDown1.BackgroundStyle.Class = "TextBoxBorder"
			Me.textBoxDropDown1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.textBoxDropDown1.ButtonDropDown.Visible = True
			Me.textBoxDropDown1.CharacterCasing = CharacterCasing.Normal
			Me.textBoxDropDown1.Location = New Point(97, 51)
			Me.textBoxDropDown1.Name = "textBoxDropDown1"
			Me.textBoxDropDown1.Size = New Size(245, 22)
			Me.textBoxDropDown1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.textBoxDropDown1.TabIndex = 33
			Me.textBoxDropDown1.Text = ""
			Me.textBoxDropDown1.TextAlign = HorizontalAlignment.Left
			' 
			' cancelButton
			' 
			Me.cancelButton.AccessibleRole = AccessibleRole.PushButton
			Me.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
			Me.cancelButton.Location = New Point(338, 299)
			Me.cancelButton.Name = "cancelButton"
			Me.cancelButton.Size = New Size(88, 29)
			Me.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.cancelButton.TabIndex = 32
			Me.cancelButton.Text = "Cancel"
			' 
			' saveButton
			' 
			Me.saveButton.AccessibleRole = AccessibleRole.PushButton
			Me.saveButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
			Me.saveButton.Location = New Point(244, 299)
			Me.saveButton.Name = "saveButton"
			Me.saveButton.Size = New Size(88, 29)
			Me.saveButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.saveButton.TabIndex = 31
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
			Me.labelX5.Location = New Point(16, 11)
			Me.labelX5.Name = "labelX5"
			Me.labelX5.Size = New Size(294, 32)
			Me.labelX5.TabIndex = 30
			Me.labelX5.Text = "New Invoice"
			' 
			' labelX2
			' 
			' 
			' 
			' 
			Me.labelX2.BackgroundStyle.Class = ""
			Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX2.Location = New Point(3, 76)
			Me.labelX2.Name = "labelX2"
			Me.labelX2.Size = New Size(88, 20)
			Me.labelX2.TabIndex = 25
			Me.labelX2.Text = "Invoice Number:"
			Me.labelX2.TextAlignment = StringAlignment.Far
			' 
			' textBoxX2
			' 
			Me.textBoxX2.BackColor = Color.White
			' 
			' 
			' 
			Me.textBoxX2.Border.Class = "TextBoxBorder"
			Me.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.textBoxX2.ForeColor = Color.Black
			Me.textBoxX2.Location = New Point(97, 76)
			Me.textBoxX2.Name = "textBoxX2"
			Me.textBoxX2.Size = New Size(245, 22)
			Me.textBoxX2.TabIndex = 24
			' 
			' labelX1
			' 
			' 
			' 
			' 
			Me.labelX1.BackgroundStyle.Class = ""
			Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX1.Location = New Point(16, 50)
			Me.labelX1.Name = "labelX1"
			Me.labelX1.Size = New Size(75, 20)
			Me.labelX1.TabIndex = 23
			Me.labelX1.Text = "Client:"
			Me.labelX1.TextAlignment = StringAlignment.Far
			' 
			' InvoiceControl
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.Controls.Add(Me.panelEx1)
			Me.Name = "InvoiceControl"
			Me.Size = New Size(438, 340)
			Me.panelEx1.ResumeLayout(False)
			CType(Me.advTree1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panelEx1 As DevComponents.DotNetBar.PanelEx
		Private cancelButton As DevComponents.DotNetBar.ButtonX
		Private saveButton As DevComponents.DotNetBar.ButtonX
		Private labelX5 As DevComponents.DotNetBar.LabelX
		Private labelX2 As DevComponents.DotNetBar.LabelX
		Private textBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
		Private labelX1 As DevComponents.DotNetBar.LabelX
		Private textBoxDropDown1 As DevComponents.DotNetBar.Controls.TextBoxDropDown
		Private labelX3 As DevComponents.DotNetBar.LabelX
		Private labelX6 As DevComponents.DotNetBar.LabelX
		Private labelX4 As DevComponents.DotNetBar.LabelX
		Private advTree1 As DevComponents.AdvTree.AdvTree
		Private columnHeader1 As DevComponents.AdvTree.ColumnHeader
		Private columnHeader2 As DevComponents.AdvTree.ColumnHeader
		Private nodeConnector1 As DevComponents.AdvTree.NodeConnector
		Private elementStyle1 As DevComponents.DotNetBar.ElementStyle
	End Class
End Namespace
