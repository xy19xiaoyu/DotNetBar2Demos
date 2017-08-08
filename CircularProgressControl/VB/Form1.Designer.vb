Namespace CircularProgressControl
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
			Me.components = New System.ComponentModel.Container()
			Me.ribbonControl1 = New DevComponents.DotNetBar.RibbonControl()
			Me.ribbonPanel1 = New DevComponents.DotNetBar.RibbonPanel()
			Me.ribbonBar2 = New DevComponents.DotNetBar.RibbonBar()
			Me.circularProgressItem6 = New DevComponents.DotNetBar.CircularProgressItem()
			Me.circularProgressItem7 = New DevComponents.DotNetBar.CircularProgressItem()
			Me.circularProgressItem8 = New DevComponents.DotNetBar.CircularProgressItem()
			Me.circularProgressItem9 = New DevComponents.DotNetBar.CircularProgressItem()
			Me.circularProgressItem10 = New DevComponents.DotNetBar.CircularProgressItem()
			Me.itemContainer1 = New DevComponents.DotNetBar.ItemContainer()
			Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem()
			Me.ProgressRun = New DevComponents.DotNetBar.Command(Me.components)
			Me.checkBoxItem1 = New DevComponents.DotNetBar.CheckBoxItem()
			Me.ProgressValueVisible = New DevComponents.DotNetBar.Command(Me.components)
			Me.ribbonBar1 = New DevComponents.DotNetBar.RibbonBar()
			Me.circularProgressItem1 = New DevComponents.DotNetBar.CircularProgressItem()
			Me.circularProgressItem2 = New DevComponents.DotNetBar.CircularProgressItem()
			Me.circularProgressItem3 = New DevComponents.DotNetBar.CircularProgressItem()
			Me.circularProgressItem4 = New DevComponents.DotNetBar.CircularProgressItem()
			Me.circularProgressItem5 = New DevComponents.DotNetBar.CircularProgressItem()
			Me.buttonItem1 = New DevComponents.DotNetBar.ButtonItem()
			Me.ToggleEndlessProgress = New DevComponents.DotNetBar.Command(Me.components)
			Me.ribbonTabItem1 = New DevComponents.DotNetBar.RibbonTabItem()
			Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
			Me.timer1 = New Timer(Me.components)
			Me.bar1 = New DevComponents.DotNetBar.Bar()
			Me.labelItem1 = New DevComponents.DotNetBar.LabelItem()
			Me.circularProgressItem11 = New DevComponents.DotNetBar.CircularProgressItem()
			Me.circularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
			Me.ribbonControl1.SuspendLayout()
			Me.ribbonPanel1.SuspendLayout()
			CType(Me.bar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonControl1
			' 
			' 
			' 
			' 
			Me.ribbonControl1.BackgroundStyle.Class = ""
			Me.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.ribbonControl1.Controls.Add(Me.ribbonPanel1)
			Me.ribbonControl1.Dock = DockStyle.Top
			Me.ribbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.ribbonTabItem1})
			Me.ribbonControl1.KeyTipsFont = New Font("Tahoma", 7F)
			Me.ribbonControl1.Location = New Point(0, 0)
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Padding = New Padding(0, 0, 0, 2)
			Me.ribbonControl1.Size = New Size(561, 98)
			Me.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
			Me.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
			Me.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
			Me.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
			Me.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
			Me.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>"
			Me.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel"
			Me.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
			Me.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
			Me.ribbonControl1.SystemText.QatDialogOkButton = "OK"
			Me.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
			Me.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove"
			Me.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
			Me.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
			Me.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
			Me.ribbonControl1.TabGroupHeight = 14
			Me.ribbonControl1.TabIndex = 0
			Me.ribbonControl1.Text = "ribbonControl1"
			' 
			' ribbonPanel1
			' 
			Me.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.ribbonPanel1.Controls.Add(Me.ribbonBar2)
			Me.ribbonPanel1.Controls.Add(Me.ribbonBar1)
			Me.ribbonPanel1.Dock = DockStyle.Fill
			Me.ribbonPanel1.Location = New Point(0, 25)
			Me.ribbonPanel1.Name = "ribbonPanel1"
			Me.ribbonPanel1.Padding = New Padding(3, 0, 3, 3)
			Me.ribbonPanel1.Size = New Size(561, 71)
			' 
			' 
			' 
			Me.ribbonPanel1.Style.Class = ""
			Me.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.ribbonPanel1.StyleMouseDown.Class = ""
			Me.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.ribbonPanel1.StyleMouseOver.Class = ""
			Me.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.ribbonPanel1.TabIndex = 1
			' 
			' ribbonBar2
			' 
			Me.ribbonBar2.AutoOverflowEnabled = True
			' 
			' 
			' 
			Me.ribbonBar2.BackgroundMouseOverStyle.Class = ""
			Me.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.ribbonBar2.BackgroundStyle.Class = ""
			Me.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.ribbonBar2.ContainerControlProcessDialogKey = True
			Me.ribbonBar2.Dock = DockStyle.Left
			Me.ribbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.circularProgressItem6, Me.circularProgressItem7, Me.circularProgressItem8, Me.circularProgressItem9, Me.circularProgressItem10, Me.itemContainer1})
			Me.ribbonBar2.ItemSpacing = 6
			Me.ribbonBar2.Location = New Point(232, 0)
			Me.ribbonBar2.Name = "ribbonBar2"
			Me.ribbonBar2.Size = New Size(326, 68)
			Me.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.ribbonBar2.TabIndex = 1
			Me.ribbonBar2.Text = "Percent"
			' 
			' 
			' 
			Me.ribbonBar2.TitleStyle.Class = ""
			Me.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.ribbonBar2.TitleStyleMouseOver.Class = ""
			Me.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.ribbonBar2.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
			' 
			' circularProgressItem6
			' 
			Me.circularProgressItem6.Diameter = 48
			Me.circularProgressItem6.Name = "circularProgressItem6"
			Me.circularProgressItem6.ProgressTextVisible = True
			' 
			' circularProgressItem7
			' 
			Me.circularProgressItem7.Diameter = 32
			Me.circularProgressItem7.Name = "circularProgressItem7"
			Me.circularProgressItem7.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
			Me.circularProgressItem7.ProgressColor = Color.SeaGreen
			Me.circularProgressItem7.ProgressTextVisible = True
			' 
			' circularProgressItem8
			' 
			Me.circularProgressItem8.Diameter = 32
			Me.circularProgressItem8.Name = "circularProgressItem8"
			Me.circularProgressItem8.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut
			Me.circularProgressItem8.ProgressColor = Color.IndianRed
			Me.circularProgressItem8.ProgressTextVisible = True
			' 
			' circularProgressItem9
			' 
			Me.circularProgressItem9.Diameter = 32
			Me.circularProgressItem9.Name = "circularProgressItem9"
			Me.circularProgressItem9.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Spoke
			Me.circularProgressItem9.ProgressColor = Color.Turquoise
			Me.circularProgressItem9.ProgressTextColor = Color.FromArgb((CInt((CByte(192)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.circularProgressItem9.ProgressTextFormat = "{0}"
			Me.circularProgressItem9.ProgressTextVisible = True
			' 
			' circularProgressItem10
			' 
			Me.circularProgressItem10.Diameter = 32
			Me.circularProgressItem10.Name = "circularProgressItem10"
			Me.circularProgressItem10.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Pie
			Me.circularProgressItem10.ProgressColor = Color.Tan
			Me.circularProgressItem10.ProgressTextColor = Color.FromArgb((CInt((CByte(64)))), (CInt((CByte(64)))), (CInt((CByte(0)))))
			Me.circularProgressItem10.ProgressTextVisible = True
			' 
			' itemContainer1
			' 
			' 
			' 
			' 
			Me.itemContainer1.BackgroundStyle.Class = ""
			Me.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.itemContainer1.ItemSpacing = 4
			Me.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
			Me.itemContainer1.Name = "itemContainer1"
			Me.itemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.buttonItem2, Me.checkBoxItem1})
			' 
			' buttonItem2
			' 
			Me.buttonItem2.BeginGroup = True
			Me.buttonItem2.Checked = True
			Me.buttonItem2.Command = Me.ProgressRun
			Me.buttonItem2.Name = "buttonItem2"
			Me.buttonItem2.SubItemsExpandWidth = 14
			Me.buttonItem2.Text = "Stop"
			' 
			' ProgressRun
			' 
			Me.ProgressRun.Checked = True
			Me.ProgressRun.Name = "ProgressRun"
'			Me.ProgressRun.Executed += New System.EventHandler(Me.ProgressRun_Executed)
			' 
			' checkBoxItem1
			' 
			Me.checkBoxItem1.Checked = True
			Me.checkBoxItem1.CheckState = CheckState.Checked
			Me.checkBoxItem1.Command = Me.ProgressValueVisible
			Me.checkBoxItem1.Name = "checkBoxItem1"
			Me.checkBoxItem1.Text = "Show value"
			' 
			' ProgressValueVisible
			' 
			Me.ProgressValueVisible.Checked = True
			Me.ProgressValueVisible.Name = "ProgressValueVisible"
'			Me.ProgressValueVisible.Executed += New System.EventHandler(Me.ProgressValueVisible_Executed)
			' 
			' ribbonBar1
			' 
			Me.ribbonBar1.AutoOverflowEnabled = True
			' 
			' 
			' 
			Me.ribbonBar1.BackgroundMouseOverStyle.Class = ""
			Me.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.ribbonBar1.BackgroundStyle.Class = ""
			Me.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.ribbonBar1.ContainerControlProcessDialogKey = True
			Me.ribbonBar1.Dock = DockStyle.Left
			Me.ribbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.circularProgressItem1, Me.circularProgressItem2, Me.circularProgressItem3, Me.circularProgressItem4, Me.circularProgressItem5, Me.buttonItem1})
			Me.ribbonBar1.ItemSpacing = 12
			Me.ribbonBar1.Location = New Point(3, 0)
			Me.ribbonBar1.Name = "ribbonBar1"
			Me.ribbonBar1.Size = New Size(229, 68)
			Me.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.ribbonBar1.TabIndex = 0
			Me.ribbonBar1.Text = "Endless"
			' 
			' 
			' 
			Me.ribbonBar1.TitleStyle.Class = ""
			Me.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			' 
			' 
			' 
			Me.ribbonBar1.TitleStyleMouseOver.Class = ""
			Me.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.ribbonBar1.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle
			' 
			' circularProgressItem1
			' 
			Me.circularProgressItem1.Name = "circularProgressItem1"
			Me.circularProgressItem1.PieBorderLight = Color.Empty
			Me.circularProgressItem1.ProgressColor = Color.DarkMagenta
			Me.circularProgressItem1.Text = "Line"
			Me.circularProgressItem1.TextPosition = DevComponents.DotNetBar.eTextPosition.Bottom
			Me.circularProgressItem1.Value = 60
			' 
			' circularProgressItem2
			' 
			Me.circularProgressItem2.Name = "circularProgressItem2"
			Me.circularProgressItem2.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
			Me.circularProgressItem2.ProgressColor = Color.DarkGreen
			Me.circularProgressItem2.Text = "Dot"
			Me.circularProgressItem2.TextPosition = DevComponents.DotNetBar.eTextPosition.Bottom
			Me.circularProgressItem2.Value = 80
			' 
			' circularProgressItem3
			' 
			Me.circularProgressItem3.Name = "circularProgressItem3"
			Me.circularProgressItem3.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut
			Me.circularProgressItem3.ProgressColor = Color.SteelBlue
			Me.circularProgressItem3.Text = "Donut"
			Me.circularProgressItem3.TextPosition = DevComponents.DotNetBar.eTextPosition.Bottom
			Me.circularProgressItem3.Value = 75
			' 
			' circularProgressItem4
			' 
			Me.circularProgressItem4.Name = "circularProgressItem4"
			Me.circularProgressItem4.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Spoke
			Me.circularProgressItem4.Text = "Spoke"
			Me.circularProgressItem4.TextPosition = DevComponents.DotNetBar.eTextPosition.Bottom
			Me.circularProgressItem4.Value = 45
			' 
			' circularProgressItem5
			' 
			Me.circularProgressItem5.Name = "circularProgressItem5"
			Me.circularProgressItem5.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Pie
			Me.circularProgressItem5.ProgressColor = Color.DarkOrange
			Me.circularProgressItem5.Text = "Pie"
			Me.circularProgressItem5.TextPosition = DevComponents.DotNetBar.eTextPosition.Bottom
			Me.circularProgressItem5.Value = 90
			' 
			' buttonItem1
			' 
			Me.buttonItem1.BeginGroup = True
			Me.buttonItem1.Command = Me.ToggleEndlessProgress
			Me.buttonItem1.Name = "buttonItem1"
			Me.buttonItem1.SubItemsExpandWidth = 14
			Me.buttonItem1.Text = "Stop"
			' 
			' ToggleEndlessProgress
			' 
			Me.ToggleEndlessProgress.Checked = False
			Me.ToggleEndlessProgress.Name = "ToggleEndlessProgress"
'			Me.ToggleEndlessProgress.Executed += New System.EventHandler(Me.ToggleEndlessProgress_Executed)
			' 
			' ribbonTabItem1
			' 
			Me.ribbonTabItem1.Checked = True
			Me.ribbonTabItem1.Name = "ribbonTabItem1"
			Me.ribbonTabItem1.Panel = Me.ribbonPanel1
			Me.ribbonTabItem1.Text = "Circular Progresss"
			' 
			' styleManager1
			' 
			Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			Me.timer1.Interval = 150
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick)
			' 
			' bar1
			' 
			Me.bar1.AntiAlias = True
			Me.bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar
			Me.bar1.Dock = DockStyle.Bottom
			Me.bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.labelItem1, Me.circularProgressItem11})
			Me.bar1.Location = New Point(0, 264)
			Me.bar1.Name = "bar1"
			Me.bar1.Size = New Size(561, 23)
			Me.bar1.Stretch = True
			Me.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.bar1.TabIndex = 1
			Me.bar1.TabStop = False
			Me.bar1.Text = "bar1"
			' 
			' labelItem1
			' 
			Me.labelItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
			Me.labelItem1.Name = "labelItem1"
			Me.labelItem1.Text = "Status bar circular progress indicator:"
			' 
			' circularProgressItem11
			' 
			Me.circularProgressItem11.Diameter = 20
			Me.circularProgressItem11.Name = "circularProgressItem11"
			' 
			' circularProgress1
			' 
			' 
			' 
			' 
			Me.circularProgress1.BackgroundStyle.BackgroundImageAlpha = (CByte(64))
			Me.circularProgress1.BackgroundStyle.Class = ""
			Me.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.circularProgress1.Dock = DockStyle.Fill
			Me.circularProgress1.FocusCuesEnabled = False
			Me.circularProgress1.Location = New Point(0, 98)
			Me.circularProgress1.Name = "circularProgress1"
			Me.circularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot
			Me.circularProgress1.ProgressColor = Color.YellowGreen
			Me.circularProgress1.Size = New Size(561, 166)
			Me.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
			Me.circularProgress1.TabIndex = 2
			Me.circularProgress1.Value = 100
'			Me.circularProgress1.Click += New System.EventHandler(Me.circularProgress1_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(561, 287)
			Me.Controls.Add(Me.circularProgress1)
			Me.Controls.Add(Me.bar1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.DoubleBuffered = True
			Me.EnableGlass = False
			Me.Name = "Form1"
			Me.Text = "Circular Progress Control Demo"
			Me.ribbonControl1.ResumeLayout(False)
			Me.ribbonControl1.PerformLayout()
			Me.ribbonPanel1.ResumeLayout(False)
			CType(Me.bar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private ribbonControl1 As DevComponents.DotNetBar.RibbonControl
		Private ribbonPanel1 As DevComponents.DotNetBar.RibbonPanel
		Private ribbonBar1 As DevComponents.DotNetBar.RibbonBar
		Private ribbonTabItem1 As DevComponents.DotNetBar.RibbonTabItem
		Private styleManager1 As DevComponents.DotNetBar.StyleManager
		Private ribbonBar2 As DevComponents.DotNetBar.RibbonBar
		Private circularProgressItem1 As DevComponents.DotNetBar.CircularProgressItem
		Private circularProgressItem2 As DevComponents.DotNetBar.CircularProgressItem
		Private circularProgressItem3 As DevComponents.DotNetBar.CircularProgressItem
		Private circularProgressItem4 As DevComponents.DotNetBar.CircularProgressItem
		Private circularProgressItem5 As DevComponents.DotNetBar.CircularProgressItem
		Private buttonItem1 As DevComponents.DotNetBar.ButtonItem
		Private WithEvents ToggleEndlessProgress As DevComponents.DotNetBar.Command
		Private circularProgressItem6 As DevComponents.DotNetBar.CircularProgressItem
		Private circularProgressItem7 As DevComponents.DotNetBar.CircularProgressItem
		Private circularProgressItem8 As DevComponents.DotNetBar.CircularProgressItem
		Private circularProgressItem9 As DevComponents.DotNetBar.CircularProgressItem
		Private circularProgressItem10 As DevComponents.DotNetBar.CircularProgressItem
		Private WithEvents timer1 As Timer
		Private WithEvents ProgressRun As DevComponents.DotNetBar.Command
		Private buttonItem2 As DevComponents.DotNetBar.ButtonItem
		Private itemContainer1 As DevComponents.DotNetBar.ItemContainer
		Private checkBoxItem1 As DevComponents.DotNetBar.CheckBoxItem
		Private WithEvents ProgressValueVisible As DevComponents.DotNetBar.Command
		Private bar1 As DevComponents.DotNetBar.Bar
		Private labelItem1 As DevComponents.DotNetBar.LabelItem
		Private circularProgressItem11 As DevComponents.DotNetBar.CircularProgressItem
		Private WithEvents circularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
	End Class
End Namespace

