Namespace MicroCharts
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
            Me.ribbonControl1 = New DevComponents.DotNetBar.RibbonControl
            Me.ribbonPanel1 = New DevComponents.DotNetBar.RibbonPanel
            Me.ribbonBar3 = New DevComponents.DotNetBar.RibbonBar
            Me.buttonItem5 = New DevComponents.DotNetBar.ButtonItem
            Me.buttonItem6 = New DevComponents.DotNetBar.ButtonItem
            Me.ribbonBar4 = New DevComponents.DotNetBar.RibbonBar
            Me.microChartItem4 = New DevComponents.DotNetBar.MicroChartItem
            Me.ribbonBar2 = New DevComponents.DotNetBar.RibbonBar
            Me.itemContainer2 = New DevComponents.DotNetBar.ItemContainer
            Me.microChartItem1 = New DevComponents.DotNetBar.MicroChartItem
            Me.microChartItem2 = New DevComponents.DotNetBar.MicroChartItem
            Me.microChartItem3 = New DevComponents.DotNetBar.MicroChartItem
            Me.ribbonBar1 = New DevComponents.DotNetBar.RibbonBar
            Me.buttonItem1 = New DevComponents.DotNetBar.ButtonItem
            Me.itemContainer1 = New DevComponents.DotNetBar.ItemContainer
            Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem
            Me.buttonItem3 = New DevComponents.DotNetBar.ButtonItem
            Me.buttonItem4 = New DevComponents.DotNetBar.ButtonItem
            Me.ribbonPanel2 = New DevComponents.DotNetBar.RibbonPanel
            Me.ribbonTabItem1 = New DevComponents.DotNetBar.RibbonTabItem
            Me.ribbonTabItem2 = New DevComponents.DotNetBar.RibbonTabItem
            Me.qatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem
            Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
            Me.labelX1 = New DevComponents.DotNetBar.LabelX
            Me.refreshTimer = New System.Windows.Forms.Timer(Me.components)
            Me.microChart1 = New DevComponents.DotNetBar.MicroChart
            Me.microChart2 = New DevComponents.DotNetBar.MicroChart
            Me.microChart3 = New DevComponents.DotNetBar.MicroChart
            Me.microChart4 = New DevComponents.DotNetBar.MicroChart
            Me.microChart5 = New DevComponents.DotNetBar.MicroChart
            Me.microChart6 = New DevComponents.DotNetBar.MicroChart
            Me.microChart7 = New DevComponents.DotNetBar.MicroChart
            Me.microChart8 = New DevComponents.DotNetBar.MicroChart
            Me.labelX2 = New DevComponents.DotNetBar.LabelX
            Me.labelX3 = New DevComponents.DotNetBar.LabelX
            Me.labelX4 = New DevComponents.DotNetBar.LabelX
            Me.labelX5 = New DevComponents.DotNetBar.LabelX
            Me.labelX6 = New DevComponents.DotNetBar.LabelX
            Me.labelX7 = New DevComponents.DotNetBar.LabelX
            Me.labelX8 = New DevComponents.DotNetBar.LabelX
            Me.labelX9 = New DevComponents.DotNetBar.LabelX
            Me.advTree1 = New DevComponents.AdvTree.AdvTree
            Me.node1 = New DevComponents.AdvTree.Node
            Me.node2 = New DevComponents.AdvTree.Node
            Me.cell1 = New DevComponents.AdvTree.Cell
            Me.microChartItem5 = New DevComponents.DotNetBar.MicroChartItem
            Me.node3 = New DevComponents.AdvTree.Node
            Me.nodeConnector1 = New DevComponents.AdvTree.NodeConnector
            Me.elementStyle1 = New DevComponents.DotNetBar.ElementStyle
            Me.labelX10 = New DevComponents.DotNetBar.LabelX
            Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem
            Me.ribbonControl1.SuspendLayout()
            Me.ribbonPanel1.SuspendLayout()
            CType(Me.advTree1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ribbonControl1
            '
            '
            '
            '
            Me.ribbonControl1.BackgroundStyle.Class = ""
            Me.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ribbonControl1.Controls.Add(Me.ribbonPanel1)
            Me.ribbonControl1.Controls.Add(Me.ribbonPanel2)
            Me.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.ribbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ribbonTabItem1, Me.ribbonTabItem2, Me.LabelItem1})
            Me.ribbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
            Me.ribbonControl1.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.qatCustomizeItem1})
            Me.ribbonControl1.Size = New System.Drawing.Size(730, 120)
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
            'ribbonPanel1
            '
            Me.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ribbonPanel1.Controls.Add(Me.ribbonBar3)
            Me.ribbonPanel1.Controls.Add(Me.ribbonBar4)
            Me.ribbonPanel1.Controls.Add(Me.ribbonBar2)
            Me.ribbonPanel1.Controls.Add(Me.ribbonBar1)
            Me.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ribbonPanel1.Location = New System.Drawing.Point(0, 25)
            Me.ribbonPanel1.Name = "ribbonPanel1"
            Me.ribbonPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.ribbonPanel1.Size = New System.Drawing.Size(730, 93)
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
            'ribbonBar3
            '
            Me.ribbonBar3.AutoOverflowEnabled = True
            '
            '
            '
            Me.ribbonBar3.BackgroundMouseOverStyle.Class = ""
            Me.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.ribbonBar3.BackgroundStyle.Class = ""
            Me.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ribbonBar3.ContainerControlProcessDialogKey = True
            Me.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left
            Me.ribbonBar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem5, Me.buttonItem6})
            Me.ribbonBar3.Location = New System.Drawing.Point(399, 0)
            Me.ribbonBar3.Name = "ribbonBar3"
            Me.ribbonBar3.Size = New System.Drawing.Size(165, 90)
            Me.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ribbonBar3.TabIndex = 2
            Me.ribbonBar3.Text = "Data"
            '
            '
            '
            Me.ribbonBar3.TitleStyle.Class = ""
            Me.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.ribbonBar3.TitleStyleMouseOver.Class = ""
            Me.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            'buttonItem5
            '
            Me.buttonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem5.Image = Global.My.Resources.Resources.Refresh
            Me.buttonItem5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.buttonItem5.Name = "buttonItem5"
            Me.buttonItem5.SubItemsExpandWidth = 14
            Me.buttonItem5.Text = "Refresh Data"
            '
            'buttonItem6
            '
            Me.buttonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem6.Image = Global.My.Resources.Resources.SpeedTest
            Me.buttonItem6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.buttonItem6.Name = "buttonItem6"
            Me.buttonItem6.SubItemsExpandWidth = 14
            Me.buttonItem6.Text = "Speed Test"
            '
            'ribbonBar4
            '
            Me.ribbonBar4.AutoOverflowEnabled = True
            '
            '
            '
            Me.ribbonBar4.BackgroundMouseOverStyle.Class = ""
            Me.ribbonBar4.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.ribbonBar4.BackgroundStyle.Class = ""
            Me.ribbonBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ribbonBar4.ContainerControlProcessDialogKey = True
            Me.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left
            Me.ribbonBar4.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.microChartItem4})
            Me.ribbonBar4.Location = New System.Drawing.Point(299, 0)
            Me.ribbonBar4.Name = "ribbonBar4"
            Me.ribbonBar4.Size = New System.Drawing.Size(100, 90)
            Me.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ribbonBar4.TabIndex = 3
            Me.ribbonBar4.Text = "Live"
            '
            '
            '
            Me.ribbonBar4.TitleStyle.Class = ""
            Me.ribbonBar4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.ribbonBar4.TitleStyleMouseOver.Class = ""
            Me.ribbonBar4.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            'microChartItem4
            '
            Me.microChartItem4.ChartHeight = 48
            Me.microChartItem4.ChartType = DevComponents.DotNetBar.eMicroChartType.Pie
            Me.microChartItem4.ChartWidth = 48
            Me.microChartItem4.Name = "microChartItem4"
            Me.microChartItem4.Text = "Market Share:"
            Me.microChartItem4.TextPosition = DevComponents.DotNetBar.eMicroChartTextPosition.Top
            '
            'ribbonBar2
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
            Me.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left
            Me.ribbonBar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.itemContainer2})
            Me.ribbonBar2.Location = New System.Drawing.Point(146, 0)
            Me.ribbonBar2.Name = "ribbonBar2"
            Me.ribbonBar2.Size = New System.Drawing.Size(153, 90)
            Me.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ribbonBar2.TabIndex = 1
            Me.ribbonBar2.Text = "Stats"
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
            '
            'itemContainer2
            '
            '
            '
            '
            Me.itemContainer2.BackgroundStyle.Class = ""
            Me.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.itemContainer2.ItemSpacing = 0
            Me.itemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
            Me.itemContainer2.Name = "itemContainer2"
            Me.itemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.microChartItem1, Me.microChartItem2, Me.microChartItem3})
            '
            'microChartItem1
            '
            Me.microChartItem1.LineChartStyle.DrawZeroLine = False
            Me.microChartItem1.LineChartStyle.LastPointColor = System.Drawing.Color.Red
            Me.microChartItem1.Name = "microChartItem1"
            Me.microChartItem1.Text = "Orders:"
            '
            'microChartItem2
            '
            Me.microChartItem2.ChartType = DevComponents.DotNetBar.eMicroChartType.WinLose
            Me.microChartItem2.Name = "microChartItem2"
            Me.microChartItem2.Text = "On-Time:"
            Me.microChartItem2.WinLoseChartStyle.NegativeBarColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(77, Byte), Integer))
            '
            'microChartItem3
            '
            Me.microChartItem3.AreaChartStyle.AreaColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(60, Byte), Integer))
            Me.microChartItem3.ChartType = DevComponents.DotNetBar.eMicroChartType.Area
            Me.microChartItem3.Name = "microChartItem3"
            Me.microChartItem3.Text = "Profit:"
            Me.microChartItem3.TooltipValueFormatString = "Profit custom format: #0"
            '
            'ribbonBar1
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
            Me.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left
            Me.ribbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem1, Me.itemContainer1})
            Me.ribbonBar1.Location = New System.Drawing.Point(3, 0)
            Me.ribbonBar1.Name = "ribbonBar1"
            Me.ribbonBar1.Size = New System.Drawing.Size(143, 90)
            Me.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ribbonBar1.TabIndex = 0
            Me.ribbonBar1.Text = "Orders"
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
            '
            'buttonItem1
            '
            Me.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem1.Image = Global.My.Resources.Resources.NewSalesOrder
            Me.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
            Me.buttonItem1.Name = "buttonItem1"
            Me.buttonItem1.SubItemsExpandWidth = 14
            Me.buttonItem1.Text = "New Order"
            '
            'itemContainer1
            '
            '
            '
            '
            Me.itemContainer1.BackgroundStyle.Class = ""
            Me.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
            Me.itemContainer1.Name = "itemContainer1"
            Me.itemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem2, Me.buttonItem3, Me.buttonItem4})
            '
            'buttonItem2
            '
            Me.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem2.Image = Global.My.Resources.Resources.TableFind
            Me.buttonItem2.Name = "buttonItem2"
            Me.buttonItem2.Text = "Find Order"
            '
            'buttonItem3
            '
            Me.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem3.Image = Global.My.Resources.Resources.BarCode
            Me.buttonItem3.Name = "buttonItem3"
            Me.buttonItem3.Text = "Ship Order"
            '
            'buttonItem4
            '
            Me.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem4.Image = Global.My.Resources.Resources.Car
            Me.buttonItem4.Name = "buttonItem4"
            Me.buttonItem4.Text = "Track Order"
            '
            'ribbonPanel2
            '
            Me.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ribbonPanel2.Location = New System.Drawing.Point(0, 0)
            Me.ribbonPanel2.Name = "ribbonPanel2"
            Me.ribbonPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.ribbonPanel2.Size = New System.Drawing.Size(622, 118)
            '
            '
            '
            Me.ribbonPanel2.Style.Class = ""
            Me.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.ribbonPanel2.StyleMouseDown.Class = ""
            Me.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.ribbonPanel2.StyleMouseOver.Class = ""
            Me.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ribbonPanel2.TabIndex = 2
            Me.ribbonPanel2.Visible = False
            '
            'ribbonTabItem1
            '
            Me.ribbonTabItem1.Checked = True
            Me.ribbonTabItem1.Name = "ribbonTabItem1"
            Me.ribbonTabItem1.Panel = Me.ribbonPanel1
            Me.ribbonTabItem1.Text = "Sales"
            '
            'ribbonTabItem2
            '
            Me.ribbonTabItem2.Name = "ribbonTabItem2"
            Me.ribbonTabItem2.Panel = Me.ribbonPanel2
            Me.ribbonTabItem2.Text = "Inventory"
            '
            'qatCustomizeItem1
            '
            Me.qatCustomizeItem1.Name = "qatCustomizeItem1"
            '
            'styleManager1
            '
            Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue
            '
            'labelX1
            '
            '
            '
            '
            Me.labelX1.BackgroundStyle.Class = ""
            Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelX1.Location = New System.Drawing.Point(10, 126)
            Me.labelX1.Name = "labelX1"
            Me.labelX1.Size = New System.Drawing.Size(523, 19)
            Me.labelX1.TabIndex = 1
            Me.labelX1.Text = "Standalone Micro-Charts:"
            '
            'refreshTimer
            '
            Me.refreshTimer.Enabled = True
            Me.refreshTimer.Interval = 8000
            '
            'microChart1
            '
            '
            '
            '
            Me.microChart1.BackgroundStyle.Class = ""
            Me.microChart1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.microChart1.LineChartStyle.HighPointColor = System.Drawing.Color.Lime
            Me.microChart1.LineChartStyle.LowPointColor = System.Drawing.Color.Red
            Me.microChart1.Location = New System.Drawing.Point(10, 166)
            Me.microChart1.Name = "microChart1"
            Me.microChart1.Size = New System.Drawing.Size(94, 35)
            Me.microChart1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.microChart1.TabIndex = 2
            Me.microChart1.Text = "microChart1"
            '
            'microChart2
            '
            '
            '
            '
            Me.microChart2.BackgroundStyle.Class = ""
            Me.microChart2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.microChart2.ChartType = DevComponents.DotNetBar.eMicroChartType.Plot
            Me.microChart2.Location = New System.Drawing.Point(10, 231)
            Me.microChart2.Name = "microChart2"
            Me.microChart2.Size = New System.Drawing.Size(94, 35)
            Me.microChart2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.microChart2.TabIndex = 3
            Me.microChart2.Text = "microChart2"
            '
            'microChart3
            '
            '
            '
            '
            Me.microChart3.BackgroundStyle.Class = ""
            Me.microChart3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.microChart3.ChartType = DevComponents.DotNetBar.eMicroChartType.WinLose
            Me.microChart3.Location = New System.Drawing.Point(143, 166)
            Me.microChart3.Name = "microChart3"
            Me.microChart3.Size = New System.Drawing.Size(94, 35)
            Me.microChart3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.microChart3.TabIndex = 4
            Me.microChart3.Text = "microChart3"
            Me.microChart3.WinLoseChartStyle.HighPointBarColor = System.Drawing.Color.Lime
            Me.microChart3.WinLoseChartStyle.LowPointBarColor = System.Drawing.Color.Maroon
            '
            'microChart4
            '
            '
            '
            '
            Me.microChart4.BackgroundStyle.Class = ""
            Me.microChart4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.microChart4.ChartType = DevComponents.DotNetBar.eMicroChartType.Area
            Me.microChart4.Location = New System.Drawing.Point(143, 231)
            Me.microChart4.Name = "microChart4"
            Me.microChart4.Size = New System.Drawing.Size(94, 35)
            Me.microChart4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.microChart4.TabIndex = 5
            Me.microChart4.Text = "microChart4"
            '
            'microChart5
            '
            '
            '
            '
            Me.microChart5.BackgroundStyle.Class = ""
            Me.microChart5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.microChart5.ChartType = DevComponents.DotNetBar.eMicroChartType.Column
            Me.microChart5.ColumnChartStyle.HighPointBarColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.microChart5.ColumnChartStyle.LowPointBarColor = System.Drawing.Color.Maroon
            Me.microChart5.Location = New System.Drawing.Point(272, 166)
            Me.microChart5.Name = "microChart5"
            Me.microChart5.Size = New System.Drawing.Size(94, 35)
            Me.microChart5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.microChart5.TabIndex = 6
            Me.microChart5.Text = "microChart5"
            '
            'microChart6
            '
            '
            '
            '
            Me.microChart6.BackgroundStyle.Class = ""
            Me.microChart6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.microChart6.ChartType = DevComponents.DotNetBar.eMicroChartType.Bar
            Me.microChart6.Location = New System.Drawing.Point(272, 231)
            Me.microChart6.Name = "microChart6"
            Me.microChart6.Size = New System.Drawing.Size(94, 73)
            Me.microChart6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.microChart6.TabIndex = 7
            Me.microChart6.Text = "microChart6"
            '
            'microChart7
            '
            '
            '
            '
            Me.microChart7.BackgroundStyle.Class = ""
            Me.microChart7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.microChart7.ChartType = DevComponents.DotNetBar.eMicroChartType.Pie
            Me.microChart7.Location = New System.Drawing.Point(397, 231)
            Me.microChart7.Name = "microChart7"
            Me.microChart7.Size = New System.Drawing.Size(94, 60)
            Me.microChart7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.microChart7.TabIndex = 8
            Me.microChart7.Text = "microChart7"
            '
            'microChart8
            '
            '
            '
            '
            Me.microChart8.BackgroundStyle.Class = ""
            Me.microChart8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.microChart8.ChartType = DevComponents.DotNetBar.eMicroChartType.HundredPercentBar
            Me.microChart8.Location = New System.Drawing.Point(397, 166)
            Me.microChart8.Name = "microChart8"
            Me.microChart8.Size = New System.Drawing.Size(94, 35)
            Me.microChart8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.microChart8.TabIndex = 9
            Me.microChart8.Text = "microChart8"
            '
            'labelX2
            '
            Me.labelX2.AutoSize = True
            '
            '
            '
            Me.labelX2.BackgroundStyle.Class = ""
            Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX2.Location = New System.Drawing.Point(10, 149)
            Me.labelX2.Name = "labelX2"
            Me.labelX2.Size = New System.Drawing.Size(26, 15)
            Me.labelX2.TabIndex = 10
            Me.labelX2.Text = "Line:"
            '
            'labelX3
            '
            Me.labelX3.AutoSize = True
            '
            '
            '
            Me.labelX3.BackgroundStyle.Class = ""
            Me.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX3.Location = New System.Drawing.Point(10, 215)
            Me.labelX3.Name = "labelX3"
            Me.labelX3.Size = New System.Drawing.Size(25, 15)
            Me.labelX3.TabIndex = 11
            Me.labelX3.Text = "Plot:"
            '
            'labelX4
            '
            Me.labelX4.AutoSize = True
            '
            '
            '
            Me.labelX4.BackgroundStyle.Class = ""
            Me.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX4.Location = New System.Drawing.Point(143, 215)
            Me.labelX4.Name = "labelX4"
            Me.labelX4.Size = New System.Drawing.Size(29, 15)
            Me.labelX4.TabIndex = 12
            Me.labelX4.Text = "Area:"
            '
            'labelX5
            '
            Me.labelX5.AutoSize = True
            '
            '
            '
            Me.labelX5.BackgroundStyle.Class = ""
            Me.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX5.Location = New System.Drawing.Point(143, 149)
            Me.labelX5.Name = "labelX5"
            Me.labelX5.Size = New System.Drawing.Size(51, 15)
            Me.labelX5.TabIndex = 13
            Me.labelX5.Text = "Win/Lose:"
            '
            'labelX6
            '
            Me.labelX6.AutoSize = True
            '
            '
            '
            Me.labelX6.BackgroundStyle.Class = ""
            Me.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX6.Location = New System.Drawing.Point(272, 149)
            Me.labelX6.Name = "labelX6"
            Me.labelX6.Size = New System.Drawing.Size(44, 15)
            Me.labelX6.TabIndex = 14
            Me.labelX6.Text = "Column:"
            '
            'labelX7
            '
            Me.labelX7.AutoSize = True
            '
            '
            '
            Me.labelX7.BackgroundStyle.Class = ""
            Me.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX7.Location = New System.Drawing.Point(272, 215)
            Me.labelX7.Name = "labelX7"
            Me.labelX7.Size = New System.Drawing.Size(23, 15)
            Me.labelX7.TabIndex = 15
            Me.labelX7.Text = "Bar:"
            '
            'labelX8
            '
            Me.labelX8.AutoSize = True
            '
            '
            '
            Me.labelX8.BackgroundStyle.Class = ""
            Me.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX8.Location = New System.Drawing.Point(397, 149)
            Me.labelX8.Name = "labelX8"
            Me.labelX8.Size = New System.Drawing.Size(54, 15)
            Me.labelX8.TabIndex = 16
            Me.labelX8.Text = "100% Bar:"
            '
            'labelX9
            '
            Me.labelX9.AutoSize = True
            '
            '
            '
            Me.labelX9.BackgroundStyle.Class = ""
            Me.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX9.Location = New System.Drawing.Point(435, 215)
            Me.labelX9.Name = "labelX9"
            Me.labelX9.Size = New System.Drawing.Size(22, 15)
            Me.labelX9.TabIndex = 17
            Me.labelX9.Text = "Pie:"
            '
            'advTree1
            '
            Me.advTree1.AllowDrop = True
            Me.advTree1.BackColor = System.Drawing.SystemColors.Window
            '
            '
            '
            Me.advTree1.BackgroundStyle.Class = "TreeBorderKey"
            Me.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.advTree1.Location = New System.Drawing.Point(519, 149)
            Me.advTree1.Name = "advTree1"
            Me.advTree1.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.node1})
            Me.advTree1.NodesConnector = Me.nodeConnector1
            Me.advTree1.NodeStyle = Me.elementStyle1
            Me.advTree1.PathSeparator = ";"
            Me.advTree1.Size = New System.Drawing.Size(199, 154)
            Me.advTree1.Styles.Add(Me.elementStyle1)
            Me.advTree1.TabIndex = 18
            Me.advTree1.Text = "advTree1"
            '
            'node1
            '
            Me.node1.Expanded = True
            Me.node1.Name = "node1"
            Me.node1.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.node2, Me.node3})
            Me.node1.Text = "Charts in tree"
            '
            'node2
            '
            Me.node2.Cells.Add(Me.cell1)
            Me.node2.Expanded = True
            Me.node2.Name = "node2"
            Me.node2.Text = "Line:"
            '
            'cell1
            '
            Me.cell1.HostedItem = Me.microChartItem5
            Me.cell1.Name = "cell1"
            Me.cell1.StyleMouseOver = Nothing
            '
            'microChartItem5
            '
            Me.microChartItem5.LineChartStyle.DrawZeroLine = False
            Me.microChartItem5.LineChartStyle.FirstPointColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.microChartItem5.LineChartStyle.LastPointColor = System.Drawing.Color.Red
            Me.microChartItem5.LineChartStyle.LineColor = System.Drawing.Color.OliveDrab
            Me.microChartItem5.Name = "microChartItem5"
            Me.microChartItem5.Text = "microChartItem5"
            Me.microChartItem5.TextVisible = False
            '
            'node3
            '
            Me.node3.Expanded = True
            Me.node3.Name = "node3"
            Me.node3.Text = "Column:"
            '
            'nodeConnector1
            '
            Me.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText
            '
            'elementStyle1
            '
            Me.elementStyle1.Class = ""
            Me.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.elementStyle1.Name = "elementStyle1"
            Me.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText
            '
            'labelX10
            '
            Me.labelX10.AutoSize = True
            '
            '
            '
            Me.labelX10.BackgroundStyle.Class = ""
            Me.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX10.Location = New System.Drawing.Point(521, 130)
            Me.labelX10.Name = "labelX10"
            Me.labelX10.Size = New System.Drawing.Size(95, 15)
            Me.labelX10.TabIndex = 19
            Me.labelX10.Text = "In AdvTree control:"
            '
            'LabelItem1
            '
            Me.LabelItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
            Me.LabelItem1.Name = "LabelItem1"
            Me.LabelItem1.PaddingBottom = 5
            Me.LabelItem1.Text = "<a href=""#"">Micro-Charts Quick Start Guide</a>"
            '
            'Form1
            '
            Me.ClientSize = New System.Drawing.Size(730, 316)
            Me.Controls.Add(Me.labelX10)
            Me.Controls.Add(Me.advTree1)
            Me.Controls.Add(Me.labelX9)
            Me.Controls.Add(Me.labelX8)
            Me.Controls.Add(Me.labelX7)
            Me.Controls.Add(Me.labelX6)
            Me.Controls.Add(Me.labelX5)
            Me.Controls.Add(Me.labelX4)
            Me.Controls.Add(Me.labelX3)
            Me.Controls.Add(Me.labelX2)
            Me.Controls.Add(Me.microChart8)
            Me.Controls.Add(Me.microChart7)
            Me.Controls.Add(Me.microChart6)
            Me.Controls.Add(Me.microChart5)
            Me.Controls.Add(Me.microChart4)
            Me.Controls.Add(Me.microChart3)
            Me.Controls.Add(Me.microChart2)
            Me.Controls.Add(Me.microChart1)
            Me.Controls.Add(Me.labelX1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.DoubleBuffered = True
            Me.EnableGlass = False
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.Text = "DotNetBar Micro-Charts"
            Me.ribbonControl1.ResumeLayout(False)
            Me.ribbonControl1.PerformLayout()
            Me.ribbonPanel1.ResumeLayout(False)
            CType(Me.advTree1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private ribbonControl1 As DevComponents.DotNetBar.RibbonControl
		Private ribbonPanel1 As DevComponents.DotNetBar.RibbonPanel
		Private ribbonBar1 As DevComponents.DotNetBar.RibbonBar
		Private ribbonPanel2 As DevComponents.DotNetBar.RibbonPanel
		Private ribbonTabItem1 As DevComponents.DotNetBar.RibbonTabItem
		Private ribbonTabItem2 As DevComponents.DotNetBar.RibbonTabItem
		Private qatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
		Private styleManager1 As DevComponents.DotNetBar.StyleManager
		Private labelX1 As DevComponents.DotNetBar.LabelX
		Private buttonItem1 As DevComponents.DotNetBar.ButtonItem
		Private itemContainer1 As DevComponents.DotNetBar.ItemContainer
		Private buttonItem2 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem3 As DevComponents.DotNetBar.ButtonItem
		Private buttonItem4 As DevComponents.DotNetBar.ButtonItem
		Private ribbonBar2 As DevComponents.DotNetBar.RibbonBar
		Private itemContainer2 As DevComponents.DotNetBar.ItemContainer
		Private microChartItem1 As DevComponents.DotNetBar.MicroChartItem
		Private microChartItem2 As DevComponents.DotNetBar.MicroChartItem
		Private microChartItem3 As DevComponents.DotNetBar.MicroChartItem
		Private ribbonBar3 As DevComponents.DotNetBar.RibbonBar
		Private WithEvents buttonItem5 As DevComponents.DotNetBar.ButtonItem
		Private WithEvents refreshTimer As Timer
		Private ribbonBar4 As DevComponents.DotNetBar.RibbonBar
		Private microChartItem4 As DevComponents.DotNetBar.MicroChartItem
		Private microChart1 As DevComponents.DotNetBar.MicroChart
		Private microChart2 As DevComponents.DotNetBar.MicroChart
		Private microChart3 As DevComponents.DotNetBar.MicroChart
		Private microChart4 As DevComponents.DotNetBar.MicroChart
		Private microChart5 As DevComponents.DotNetBar.MicroChart
		Private microChart6 As DevComponents.DotNetBar.MicroChart
		Private microChart7 As DevComponents.DotNetBar.MicroChart
		Private microChart8 As DevComponents.DotNetBar.MicroChart
		Private labelX2 As DevComponents.DotNetBar.LabelX
		Private labelX3 As DevComponents.DotNetBar.LabelX
		Private labelX4 As DevComponents.DotNetBar.LabelX
		Private labelX5 As DevComponents.DotNetBar.LabelX
		Private labelX6 As DevComponents.DotNetBar.LabelX
		Private labelX7 As DevComponents.DotNetBar.LabelX
		Private labelX8 As DevComponents.DotNetBar.LabelX
		Private labelX9 As DevComponents.DotNetBar.LabelX
		Private advTree1 As DevComponents.AdvTree.AdvTree
		Private node1 As DevComponents.AdvTree.Node
		Private nodeConnector1 As DevComponents.AdvTree.NodeConnector
		Private elementStyle1 As DevComponents.DotNetBar.ElementStyle
		Private labelX10 As DevComponents.DotNetBar.LabelX
		Private node2 As DevComponents.AdvTree.Node
		Private cell1 As DevComponents.AdvTree.Cell
		Private node3 As DevComponents.AdvTree.Node
		Private microChartItem5 As DevComponents.DotNetBar.MicroChartItem
        Private WithEvents buttonItem6 As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
	End Class
End Namespace

