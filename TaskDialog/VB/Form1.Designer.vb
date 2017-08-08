Namespace TaskDialogTester
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
            Me.labelX1 = New DevComponents.DotNetBar.LabelX
            Me.textBoxTitle = New DevComponents.DotNetBar.Controls.TextBoxX
            Me.textBoxHeader = New DevComponents.DotNetBar.Controls.TextBoxX
            Me.labelX2 = New DevComponents.DotNetBar.LabelX
            Me.textBoxContent = New DevComponents.DotNetBar.Controls.TextBoxX
            Me.labelX3 = New DevComponents.DotNetBar.LabelX
            Me.labelX4 = New DevComponents.DotNetBar.LabelX
            Me.comboBoxIcon = New DevComponents.DotNetBar.Controls.ComboBoxEx
            Me.buttonX1 = New DevComponents.DotNetBar.ButtonX
            Me.groupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
            Me.labelX5 = New DevComponents.DotNetBar.LabelX
            Me.checkBoxFooterImage = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.textBoxFooter = New DevComponents.DotNetBar.Controls.TextBoxX
            Me.groupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
            Me.checkBoxTaskButtons = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.checkBoxTaskRadio = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.groupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel
            Me.checkBoxVisible = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.checkBoxClose = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.checkBoxRetry = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.checkBoxNo = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.checkBoxYes = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.checkBoxCancel = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.checkBoxOk = New DevComponents.DotNetBar.Controls.CheckBoxX
            Me.comboBoxColor = New DevComponents.DotNetBar.Controls.ComboBoxEx
            Me.labelX6 = New DevComponents.DotNetBar.LabelX
            Me.commandRadio1 = New DevComponents.DotNetBar.Command(Me.components)
            Me.commandRadio2 = New DevComponents.DotNetBar.Command(Me.components)
            Me.commandButton1 = New DevComponents.DotNetBar.Command(Me.components)
            Me.commandCheckBox = New DevComponents.DotNetBar.Command(Me.components)
            Me.commandButton2 = New DevComponents.DotNetBar.Command(Me.components)
            Me.textBoxLog = New DevComponents.DotNetBar.Controls.TextBoxX
            Me.labelX7 = New DevComponents.DotNetBar.LabelX
            Me.groupPanel1.SuspendLayout()
            Me.groupPanel2.SuspendLayout()
            Me.groupPanel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'labelX1
            '
            Me.labelX1.AutoSize = True
            '
            '
            '
            Me.labelX1.BackgroundStyle.Class = ""
            Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX1.Location = New System.Drawing.Point(7, 11)
            Me.labelX1.Name = "labelX1"
            Me.labelX1.Size = New System.Drawing.Size(61, 15)
            Me.labelX1.TabIndex = 0
            Me.labelX1.Text = "Dialog Title:"
            '
            'textBoxTitle
            '
            '
            '
            '
            Me.textBoxTitle.Border.Class = "TextBoxBorder"
            Me.textBoxTitle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.textBoxTitle.Location = New System.Drawing.Point(7, 29)
            Me.textBoxTitle.Name = "textBoxTitle"
            Me.textBoxTitle.Size = New System.Drawing.Size(275, 20)
            Me.textBoxTitle.TabIndex = 1
            Me.textBoxTitle.Text = "Task Dialog Window Title"
            '
            'textBoxHeader
            '
            '
            '
            '
            Me.textBoxHeader.Border.Class = "TextBoxBorder"
            Me.textBoxHeader.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.textBoxHeader.Location = New System.Drawing.Point(7, 74)
            Me.textBoxHeader.Name = "textBoxHeader"
            Me.textBoxHeader.Size = New System.Drawing.Size(275, 20)
            Me.textBoxHeader.TabIndex = 3
            Me.textBoxHeader.Text = "Header Text For Task Dialog"
            '
            'labelX2
            '
            Me.labelX2.AutoSize = True
            '
            '
            '
            Me.labelX2.BackgroundStyle.Class = ""
            Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX2.Location = New System.Drawing.Point(7, 57)
            Me.labelX2.Name = "labelX2"
            Me.labelX2.Size = New System.Drawing.Size(42, 15)
            Me.labelX2.TabIndex = 2
            Me.labelX2.Text = "Header:"
            '
            'textBoxContent
            '
            '
            '
            '
            Me.textBoxContent.Border.Class = "TextBoxBorder"
            Me.textBoxContent.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.textBoxContent.Location = New System.Drawing.Point(7, 167)
            Me.textBoxContent.Multiline = True
            Me.textBoxContent.Name = "textBoxContent"
            Me.textBoxContent.Size = New System.Drawing.Size(275, 114)
            Me.textBoxContent.TabIndex = 5
            Me.textBoxContent.Text = resources.GetString("textBoxContent.Text")
            '
            'labelX3
            '
            Me.labelX3.AutoSize = True
            '
            '
            '
            Me.labelX3.BackgroundStyle.Class = ""
            Me.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX3.Location = New System.Drawing.Point(7, 150)
            Me.labelX3.Name = "labelX3"
            Me.labelX3.Size = New System.Drawing.Size(192, 15)
            Me.labelX3.TabIndex = 4
            Me.labelX3.Text = "Content Text with <a href=""#"">text-markup</a> support:"
            '
            'labelX4
            '
            Me.labelX4.AutoSize = True
            '
            '
            '
            Me.labelX4.BackgroundStyle.Class = ""
            Me.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX4.Location = New System.Drawing.Point(7, 100)
            Me.labelX4.Name = "labelX4"
            Me.labelX4.Size = New System.Drawing.Size(26, 15)
            Me.labelX4.TabIndex = 6
            Me.labelX4.Text = "Icon:"
            '
            'comboBoxIcon
            '
            Me.comboBoxIcon.DisplayMember = "Text"
            Me.comboBoxIcon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.comboBoxIcon.FormattingEnabled = True
            Me.comboBoxIcon.ItemHeight = 14
            Me.comboBoxIcon.Location = New System.Drawing.Point(7, 119)
            Me.comboBoxIcon.Name = "comboBoxIcon"
            Me.comboBoxIcon.Size = New System.Drawing.Size(134, 20)
            Me.comboBoxIcon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.comboBoxIcon.TabIndex = 7
            '
            'buttonX1
            '
            Me.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.buttonX1.Location = New System.Drawing.Point(514, 241)
            Me.buttonX1.Name = "buttonX1"
            Me.buttonX1.Size = New System.Drawing.Size(122, 40)
            Me.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.buttonX1.TabIndex = 8
            Me.buttonX1.Text = "Show"
            '
            'groupPanel1
            '
            Me.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control
            Me.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.groupPanel1.Controls.Add(Me.labelX5)
            Me.groupPanel1.Controls.Add(Me.checkBoxFooterImage)
            Me.groupPanel1.Controls.Add(Me.textBoxFooter)
            Me.groupPanel1.Location = New System.Drawing.Point(322, 78)
            Me.groupPanel1.Name = "groupPanel1"
            Me.groupPanel1.Size = New System.Drawing.Size(314, 77)
            '
            '
            '
            Me.groupPanel1.Style.BackColorGradientAngle = 90
            Me.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.groupPanel1.Style.BorderBottomWidth = 1
            Me.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.groupPanel1.Style.BorderLeftWidth = 1
            Me.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.groupPanel1.Style.BorderRightWidth = 1
            Me.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.groupPanel1.Style.BorderTopWidth = 1
            Me.groupPanel1.Style.Class = ""
            Me.groupPanel1.Style.CornerDiameter = 4
            Me.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.groupPanel1.StyleMouseDown.Class = ""
            Me.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.groupPanel1.StyleMouseOver.Class = ""
            Me.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.groupPanel1.TabIndex = 9
            Me.groupPanel1.Text = "Footer"
            '
            'labelX5
            '
            Me.labelX5.AutoSize = True
            Me.labelX5.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.labelX5.BackgroundStyle.Class = ""
            Me.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX5.Location = New System.Drawing.Point(3, -3)
            Me.labelX5.Name = "labelX5"
            Me.labelX5.Size = New System.Drawing.Size(27, 15)
            Me.labelX5.TabIndex = 2
            Me.labelX5.Text = "Text:"
            '
            'checkBoxFooterImage
            '
            Me.checkBoxFooterImage.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.checkBoxFooterImage.BackgroundStyle.Class = ""
            Me.checkBoxFooterImage.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.checkBoxFooterImage.Location = New System.Drawing.Point(1, 34)
            Me.checkBoxFooterImage.Name = "checkBoxFooterImage"
            Me.checkBoxFooterImage.Size = New System.Drawing.Size(277, 24)
            Me.checkBoxFooterImage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.checkBoxFooterImage.TabIndex = 4
            Me.checkBoxFooterImage.Text = "Show Footer Image"
            '
            'textBoxFooter
            '
            '
            '
            '
            Me.textBoxFooter.Border.Class = "TextBoxBorder"
            Me.textBoxFooter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.textBoxFooter.Location = New System.Drawing.Point(3, 14)
            Me.textBoxFooter.Name = "textBoxFooter"
            Me.textBoxFooter.Size = New System.Drawing.Size(302, 20)
            Me.textBoxFooter.TabIndex = 3
            '
            'groupPanel2
            '
            Me.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control
            Me.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.groupPanel2.Controls.Add(Me.checkBoxTaskButtons)
            Me.groupPanel2.Controls.Add(Me.checkBoxTaskRadio)
            Me.groupPanel2.Location = New System.Drawing.Point(322, 163)
            Me.groupPanel2.Name = "groupPanel2"
            Me.groupPanel2.Size = New System.Drawing.Size(314, 66)
            '
            '
            '
            Me.groupPanel2.Style.BackColorGradientAngle = 90
            Me.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.groupPanel2.Style.BorderBottomWidth = 1
            Me.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.groupPanel2.Style.BorderLeftWidth = 1
            Me.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.groupPanel2.Style.BorderRightWidth = 1
            Me.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.groupPanel2.Style.BorderTopWidth = 1
            Me.groupPanel2.Style.Class = ""
            Me.groupPanel2.Style.CornerDiameter = 4
            Me.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.groupPanel2.StyleMouseDown.Class = ""
            Me.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.groupPanel2.StyleMouseOver.Class = ""
            Me.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.groupPanel2.TabIndex = 10
            Me.groupPanel2.Text = "Task Buttons, Radio Buttons"
            '
            'checkBoxTaskButtons
            '
            Me.checkBoxTaskButtons.AutoSize = True
            Me.checkBoxTaskButtons.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.checkBoxTaskButtons.BackgroundStyle.Class = ""
            Me.checkBoxTaskButtons.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.checkBoxTaskButtons.Location = New System.Drawing.Point(3, 23)
            Me.checkBoxTaskButtons.Name = "checkBoxTaskButtons"
            Me.checkBoxTaskButtons.Size = New System.Drawing.Size(117, 15)
            Me.checkBoxTaskButtons.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.checkBoxTaskButtons.TabIndex = 6
            Me.checkBoxTaskButtons.Text = "Show Task Buttons"
            '
            'checkBoxTaskRadio
            '
            Me.checkBoxTaskRadio.AutoSize = True
            Me.checkBoxTaskRadio.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.checkBoxTaskRadio.BackgroundStyle.Class = ""
            Me.checkBoxTaskRadio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.checkBoxTaskRadio.Location = New System.Drawing.Point(3, 4)
            Me.checkBoxTaskRadio.Name = "checkBoxTaskRadio"
            Me.checkBoxTaskRadio.Size = New System.Drawing.Size(123, 15)
            Me.checkBoxTaskRadio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.checkBoxTaskRadio.TabIndex = 5
            Me.checkBoxTaskRadio.Text = "Show Radio-Buttons"
            '
            'groupPanel3
            '
            Me.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control
            Me.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.groupPanel3.Controls.Add(Me.checkBoxVisible)
            Me.groupPanel3.Controls.Add(Me.checkBoxClose)
            Me.groupPanel3.Controls.Add(Me.checkBoxRetry)
            Me.groupPanel3.Controls.Add(Me.checkBoxNo)
            Me.groupPanel3.Controls.Add(Me.checkBoxYes)
            Me.groupPanel3.Controls.Add(Me.checkBoxCancel)
            Me.groupPanel3.Controls.Add(Me.checkBoxOk)
            Me.groupPanel3.Location = New System.Drawing.Point(322, 3)
            Me.groupPanel3.Name = "groupPanel3"
            Me.groupPanel3.Size = New System.Drawing.Size(314, 69)
            '
            '
            '
            Me.groupPanel3.Style.BackColorGradientAngle = 90
            Me.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.groupPanel3.Style.BorderBottomWidth = 1
            Me.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.groupPanel3.Style.BorderLeftWidth = 1
            Me.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.groupPanel3.Style.BorderRightWidth = 1
            Me.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.groupPanel3.Style.BorderTopWidth = 1
            Me.groupPanel3.Style.Class = ""
            Me.groupPanel3.Style.CornerDiameter = 4
            Me.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.groupPanel3.StyleMouseDown.Class = ""
            Me.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.groupPanel3.StyleMouseOver.Class = ""
            Me.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.groupPanel3.TabIndex = 11
            Me.groupPanel3.Text = "Dialog Buttons"
            '
            'checkBoxVisible
            '
            Me.checkBoxVisible.AutoSize = True
            '
            '
            '
            Me.checkBoxVisible.BackgroundStyle.Class = ""
            Me.checkBoxVisible.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.checkBoxVisible.Location = New System.Drawing.Point(152, 30)
            Me.checkBoxVisible.Name = "checkBoxVisible"
            Me.checkBoxVisible.Size = New System.Drawing.Size(109, 15)
            Me.checkBoxVisible.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.checkBoxVisible.TabIndex = 10
            Me.checkBoxVisible.Text = "Check-box visible"
            '
            'checkBoxClose
            '
            Me.checkBoxClose.AutoSize = True
            Me.checkBoxClose.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.checkBoxClose.BackgroundStyle.Class = ""
            Me.checkBoxClose.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.checkBoxClose.Location = New System.Drawing.Point(223, 7)
            Me.checkBoxClose.Name = "checkBoxClose"
            Me.checkBoxClose.Size = New System.Drawing.Size(51, 15)
            Me.checkBoxClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.checkBoxClose.TabIndex = 9
            Me.checkBoxClose.Text = "Close"
            '
            'checkBoxRetry
            '
            Me.checkBoxRetry.AutoSize = True
            Me.checkBoxRetry.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.checkBoxRetry.BackgroundStyle.Class = ""
            Me.checkBoxRetry.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.checkBoxRetry.Location = New System.Drawing.Point(152, 7)
            Me.checkBoxRetry.Name = "checkBoxRetry"
            Me.checkBoxRetry.Size = New System.Drawing.Size(49, 15)
            Me.checkBoxRetry.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.checkBoxRetry.TabIndex = 8
            Me.checkBoxRetry.Text = "Retry"
            '
            'checkBoxNo
            '
            Me.checkBoxNo.AutoSize = True
            Me.checkBoxNo.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.checkBoxNo.BackgroundStyle.Class = ""
            Me.checkBoxNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.checkBoxNo.Location = New System.Drawing.Point(68, 30)
            Me.checkBoxNo.Name = "checkBoxNo"
            Me.checkBoxNo.Size = New System.Drawing.Size(37, 15)
            Me.checkBoxNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.checkBoxNo.TabIndex = 7
            Me.checkBoxNo.Text = "No"
            '
            'checkBoxYes
            '
            Me.checkBoxYes.AutoSize = True
            Me.checkBoxYes.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.checkBoxYes.BackgroundStyle.Class = ""
            Me.checkBoxYes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.checkBoxYes.Location = New System.Drawing.Point(4, 30)
            Me.checkBoxYes.Name = "checkBoxYes"
            Me.checkBoxYes.Size = New System.Drawing.Size(41, 15)
            Me.checkBoxYes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.checkBoxYes.TabIndex = 6
            Me.checkBoxYes.Text = "Yes"
            '
            'checkBoxCancel
            '
            Me.checkBoxCancel.AutoSize = True
            Me.checkBoxCancel.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.checkBoxCancel.BackgroundStyle.Class = ""
            Me.checkBoxCancel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.checkBoxCancel.Checked = True
            Me.checkBoxCancel.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxCancel.CheckValue = "Y"
            Me.checkBoxCancel.Location = New System.Drawing.Point(68, 7)
            Me.checkBoxCancel.Name = "checkBoxCancel"
            Me.checkBoxCancel.Size = New System.Drawing.Size(57, 15)
            Me.checkBoxCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.checkBoxCancel.TabIndex = 5
            Me.checkBoxCancel.Text = "Cancel"
            '
            'checkBoxOk
            '
            Me.checkBoxOk.AutoSize = True
            Me.checkBoxOk.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.checkBoxOk.BackgroundStyle.Class = ""
            Me.checkBoxOk.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.checkBoxOk.Checked = True
            Me.checkBoxOk.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxOk.CheckValue = "Y"
            Me.checkBoxOk.Location = New System.Drawing.Point(4, 7)
            Me.checkBoxOk.Name = "checkBoxOk"
            Me.checkBoxOk.Size = New System.Drawing.Size(38, 15)
            Me.checkBoxOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.checkBoxOk.TabIndex = 4
            Me.checkBoxOk.Text = "OK"
            '
            'comboBoxColor
            '
            Me.comboBoxColor.DisplayMember = "Text"
            Me.comboBoxColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.comboBoxColor.FormattingEnabled = True
            Me.comboBoxColor.ItemHeight = 14
            Me.comboBoxColor.Location = New System.Drawing.Point(148, 119)
            Me.comboBoxColor.Name = "comboBoxColor"
            Me.comboBoxColor.Size = New System.Drawing.Size(134, 20)
            Me.comboBoxColor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.comboBoxColor.TabIndex = 13
            '
            'labelX6
            '
            Me.labelX6.AutoSize = True
            '
            '
            '
            Me.labelX6.BackgroundStyle.Class = ""
            Me.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX6.Location = New System.Drawing.Point(148, 100)
            Me.labelX6.Name = "labelX6"
            Me.labelX6.Size = New System.Drawing.Size(98, 15)
            Me.labelX6.TabIndex = 12
            Me.labelX6.Text = "Dialog Background:"
            '
            'commandRadio1
            '
            Me.commandRadio1.Name = "commandRadio1"
            Me.commandRadio1.Text = "Radio button 1"
            '
            'commandRadio2
            '
            Me.commandRadio2.Name = "commandRadio2"
            Me.commandRadio2.Text = "Radio button 2"
            '
            'commandButton1
            '
            Me.commandButton1.Image = Global.My.Resources.Resources.ConvertToSmartArt
            Me.commandButton1.Name = "commandButton1"
            Me.commandButton1.Text = "<font size=""+2"">Custom Button</font><br/>with line break in text"
            '
            'commandCheckBox
            '
            Me.commandCheckBox.Name = "commandCheckBox"
            Me.commandCheckBox.Text = "Remember last choice?"
            '
            'commandButton2
            '
            Me.commandButton2.Image = Global.My.Resources.Resources.CollapseAll
            Me.commandButton2.Name = "commandButton2"
            Me.commandButton2.Text = "<font size=""+2"">Custom Button 2</font><br/>with line break in text"
            '
            'textBoxLog
            '
            '
            '
            '
            Me.textBoxLog.Border.Class = "TextBoxBorder"
            Me.textBoxLog.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.textBoxLog.Location = New System.Drawing.Point(7, 302)
            Me.textBoxLog.Multiline = True
            Me.textBoxLog.Name = "textBoxLog"
            Me.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.textBoxLog.Size = New System.Drawing.Size(628, 75)
            Me.textBoxLog.TabIndex = 14
            '
            'labelX7
            '
            Me.labelX7.AutoSize = True
            '
            '
            '
            Me.labelX7.BackgroundStyle.Class = ""
            Me.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX7.Location = New System.Drawing.Point(8, 284)
            Me.labelX7.Name = "labelX7"
            Me.labelX7.Size = New System.Drawing.Size(54, 15)
            Me.labelX7.TabIndex = 15
            Me.labelX7.Text = "Action log:"
            '
            'Form1
            '
            Me.ClientSize = New System.Drawing.Size(643, 383)
            Me.Controls.Add(Me.labelX7)
            Me.Controls.Add(Me.textBoxLog)
            Me.Controls.Add(Me.comboBoxColor)
            Me.Controls.Add(Me.labelX6)
            Me.Controls.Add(Me.groupPanel3)
            Me.Controls.Add(Me.groupPanel2)
            Me.Controls.Add(Me.groupPanel1)
            Me.Controls.Add(Me.buttonX1)
            Me.Controls.Add(Me.comboBoxIcon)
            Me.Controls.Add(Me.labelX4)
            Me.Controls.Add(Me.textBoxContent)
            Me.Controls.Add(Me.labelX3)
            Me.Controls.Add(Me.textBoxHeader)
            Me.Controls.Add(Me.labelX2)
            Me.Controls.Add(Me.textBoxTitle)
            Me.Controls.Add(Me.labelX1)
            Me.DoubleBuffered = True
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.Text = "DotNetBar Task-Dialog Component"
            Me.groupPanel1.ResumeLayout(False)
            Me.groupPanel1.PerformLayout()
            Me.groupPanel2.ResumeLayout(False)
            Me.groupPanel2.PerformLayout()
            Me.groupPanel3.ResumeLayout(False)
            Me.groupPanel3.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private labelX1 As DevComponents.DotNetBar.LabelX
		Private textBoxTitle As DevComponents.DotNetBar.Controls.TextBoxX
		Private textBoxContent As DevComponents.DotNetBar.Controls.TextBoxX
		Private textBoxHeader As DevComponents.DotNetBar.Controls.TextBoxX
		Private labelX2 As DevComponents.DotNetBar.LabelX
		Private WithEvents labelX3 As DevComponents.DotNetBar.LabelX
		Private labelX4 As DevComponents.DotNetBar.LabelX
		Private comboBoxIcon As DevComponents.DotNetBar.Controls.ComboBoxEx
		Private WithEvents buttonX1 As DevComponents.DotNetBar.ButtonX
		Private groupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
		Private groupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
		Private checkBoxFooterImage As DevComponents.DotNetBar.Controls.CheckBoxX
		Private textBoxFooter As DevComponents.DotNetBar.Controls.TextBoxX
		Private labelX5 As DevComponents.DotNetBar.LabelX
		Private checkBoxTaskButtons As DevComponents.DotNetBar.Controls.CheckBoxX
		Private checkBoxTaskRadio As DevComponents.DotNetBar.Controls.CheckBoxX
		Private groupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
		Private checkBoxOk As DevComponents.DotNetBar.Controls.CheckBoxX
		Private checkBoxNo As DevComponents.DotNetBar.Controls.CheckBoxX
		Private checkBoxYes As DevComponents.DotNetBar.Controls.CheckBoxX
		Private checkBoxCancel As DevComponents.DotNetBar.Controls.CheckBoxX
		Private checkBoxClose As DevComponents.DotNetBar.Controls.CheckBoxX
		Private checkBoxRetry As DevComponents.DotNetBar.Controls.CheckBoxX
		Private comboBoxColor As DevComponents.DotNetBar.Controls.ComboBoxEx
		Private labelX6 As DevComponents.DotNetBar.LabelX
		Private WithEvents commandRadio1 As DevComponents.DotNetBar.Command
		Private WithEvents commandRadio2 As DevComponents.DotNetBar.Command
		Private WithEvents commandButton1 As DevComponents.DotNetBar.Command
		Private WithEvents commandCheckBox As DevComponents.DotNetBar.Command
		Private checkBoxVisible As DevComponents.DotNetBar.Controls.CheckBoxX
		Private WithEvents commandButton2 As DevComponents.DotNetBar.Command
		Private textBoxLog As DevComponents.DotNetBar.Controls.TextBoxX
		Private labelX7 As DevComponents.DotNetBar.LabelX
	End Class
End Namespace

