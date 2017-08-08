Imports DevComponents.DotNetBar

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents buttonItem16 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem17 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem18 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem13 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem14 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem15 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem20 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem21 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem22 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem19 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents labelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents lineContainer As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents buttonItem23 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents lineSelector As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents pieSelector As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents barSelector As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents panelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents buttonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents columnSelector As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents labelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents columnContainer As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents buttonItem12 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents areaSelector As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents xySelector As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents stockSelector As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents labelItem5 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents areaContainer As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents buttonItem31 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem32 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem33 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem30 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem28 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem29 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem27 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents buttonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents chartTypes As DevComponents.DotNetBar.ItemPanel
    Friend WithEvents itemPanel2 As DevComponents.DotNetBar.ItemPanel
    Friend WithEvents labelItem3 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents pieContainer As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents buttonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem11 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents labelItem4 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents barContainer As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents buttonItem24 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem25 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem26 As DevComponents.DotNetBar.ButtonItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.buttonItem16 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem17 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem18 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem13 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem14 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem15 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem20 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem21 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem22 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem19 = New DevComponents.DotNetBar.ButtonItem
        Me.labelItem2 = New DevComponents.DotNetBar.LabelItem
        Me.lineContainer = New DevComponents.DotNetBar.ItemContainer
        Me.buttonItem23 = New DevComponents.DotNetBar.ButtonItem
        Me.lineSelector = New DevComponents.DotNetBar.ButtonItem
        Me.pieSelector = New DevComponents.DotNetBar.ButtonItem
        Me.barSelector = New DevComponents.DotNetBar.ButtonItem
        Me.panelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.buttonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.columnSelector = New DevComponents.DotNetBar.ButtonItem
        Me.labelItem1 = New DevComponents.DotNetBar.LabelItem
        Me.columnContainer = New DevComponents.DotNetBar.ItemContainer
        Me.buttonItem12 = New DevComponents.DotNetBar.ButtonItem
        Me.areaSelector = New DevComponents.DotNetBar.ButtonItem
        Me.xySelector = New DevComponents.DotNetBar.ButtonItem
        Me.stockSelector = New DevComponents.DotNetBar.ButtonItem
        Me.labelItem5 = New DevComponents.DotNetBar.LabelItem
        Me.areaContainer = New DevComponents.DotNetBar.ItemContainer
        Me.buttonItem31 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem32 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem33 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem30 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem28 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem29 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem27 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonX2 = New DevComponents.DotNetBar.ButtonX
        Me.buttonX1 = New DevComponents.DotNetBar.ButtonX
        Me.chartTypes = New DevComponents.DotNetBar.ItemPanel
        Me.itemPanel2 = New DevComponents.DotNetBar.ItemPanel
        Me.labelItem3 = New DevComponents.DotNetBar.LabelItem
        Me.pieContainer = New DevComponents.DotNetBar.ItemContainer
        Me.buttonItem9 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem10 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem11 = New DevComponents.DotNetBar.ButtonItem
        Me.labelItem4 = New DevComponents.DotNetBar.LabelItem
        Me.barContainer = New DevComponents.DotNetBar.ItemContainer
        Me.buttonItem24 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem25 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem26 = New DevComponents.DotNetBar.ButtonItem
        Me.SuspendLayout()
        '
        'buttonItem16
        '
        Me.buttonItem16.Image = CType(resources.GetObject("buttonItem16.Image"), System.Drawing.Image)
        Me.buttonItem16.Name = "buttonItem16"
        Me.buttonItem16.OptionGroup = "chart"
        Me.buttonItem16.Text = "Stacked Column"
        Me.buttonItem16.Tooltip = "Stacked Column"
        '
        'buttonItem17
        '
        Me.buttonItem17.Image = CType(resources.GetObject("buttonItem17.Image"), System.Drawing.Image)
        Me.buttonItem17.Name = "buttonItem17"
        Me.buttonItem17.OptionGroup = "chart"
        Me.buttonItem17.Text = "100% Stacked Column"
        Me.buttonItem17.Tooltip = "100% Stacked Column"
        '
        'buttonItem18
        '
        Me.buttonItem18.Image = CType(resources.GetObject("buttonItem18.Image"), System.Drawing.Image)
        Me.buttonItem18.Name = "buttonItem18"
        Me.buttonItem18.OptionGroup = "chart"
        Me.buttonItem18.Text = "Clustered Column"
        Me.buttonItem18.Tooltip = "Clustered Column"
        '
        'buttonItem13
        '
        Me.buttonItem13.Image = CType(resources.GetObject("buttonItem13.Image"), System.Drawing.Image)
        Me.buttonItem13.Name = "buttonItem13"
        Me.buttonItem13.OptionGroup = "chart"
        Me.buttonItem13.Text = "Stacked Column"
        Me.buttonItem13.Tooltip = "Stacked Column"
        '
        'buttonItem14
        '
        Me.buttonItem14.Image = CType(resources.GetObject("buttonItem14.Image"), System.Drawing.Image)
        Me.buttonItem14.Name = "buttonItem14"
        Me.buttonItem14.OptionGroup = "chart"
        Me.buttonItem14.Text = "100% Stacked Column"
        Me.buttonItem14.Tooltip = "100% Stacked Column"
        '
        'buttonItem15
        '
        Me.buttonItem15.Image = CType(resources.GetObject("buttonItem15.Image"), System.Drawing.Image)
        Me.buttonItem15.Name = "buttonItem15"
        Me.buttonItem15.OptionGroup = "chart"
        Me.buttonItem15.Text = "Clustered Column"
        Me.buttonItem15.Tooltip = "Clustered Column"
        '
        'buttonItem20
        '
        Me.buttonItem20.Image = CType(resources.GetObject("buttonItem20.Image"), System.Drawing.Image)
        Me.buttonItem20.Name = "buttonItem20"
        Me.buttonItem20.OptionGroup = "chart"
        Me.buttonItem20.Text = "Line"
        Me.buttonItem20.Tooltip = "Line"
        '
        'buttonItem21
        '
        Me.buttonItem21.Image = CType(resources.GetObject("buttonItem21.Image"), System.Drawing.Image)
        Me.buttonItem21.Name = "buttonItem21"
        Me.buttonItem21.OptionGroup = "chart"
        Me.buttonItem21.Text = "Stacked Line"
        Me.buttonItem21.Tooltip = "Stacked Line"
        '
        'buttonItem22
        '
        Me.buttonItem22.Image = CType(resources.GetObject("buttonItem22.Image"), System.Drawing.Image)
        Me.buttonItem22.Name = "buttonItem22"
        Me.buttonItem22.OptionGroup = "chart"
        Me.buttonItem22.Text = "100% Stacked Line"
        Me.buttonItem22.Tooltip = "100% Stacked Line"
        '
        'buttonItem19
        '
        Me.buttonItem19.Image = CType(resources.GetObject("buttonItem19.Image"), System.Drawing.Image)
        Me.buttonItem19.Name = "buttonItem19"
        Me.buttonItem19.OptionGroup = "chart"
        Me.buttonItem19.Text = "Stacked Column"
        Me.buttonItem19.Tooltip = "Stacked Column"
        '
        'labelItem2
        '
        Me.labelItem2.BackColor = System.Drawing.Color.FromArgb(CType(235, Byte), CType(235, Byte), CType(235, Byte))
        Me.labelItem2.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.labelItem2.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.labelItem2.Name = "labelItem2"
        Me.labelItem2.PaddingBottom = 1
        Me.labelItem2.PaddingLeft = 1
        Me.labelItem2.PaddingRight = 1
        Me.labelItem2.PaddingTop = 1
        Me.labelItem2.SingleLineColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(197, Byte), CType(197, Byte))
        Me.labelItem2.Text = "<b>Line</b>"
        '
        'lineContainer
        '
        Me.lineContainer.MinimumSize = New System.Drawing.Size(0, 0)
        Me.lineContainer.MultiLine = True
        Me.lineContainer.Name = "lineContainer"
        Me.lineContainer.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem20, Me.buttonItem21, Me.buttonItem22, Me.buttonItem23})
        '
        'buttonItem23
        '
        Me.buttonItem23.Image = CType(resources.GetObject("buttonItem23.Image"), System.Drawing.Image)
        Me.buttonItem23.Name = "buttonItem23"
        Me.buttonItem23.OptionGroup = "chart"
        Me.buttonItem23.Text = "Line With Markers"
        Me.buttonItem23.Tooltip = "Line With Markers"
        '
        'lineSelector
        '
        Me.lineSelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.lineSelector.Image = CType(resources.GetObject("lineSelector.Image"), System.Drawing.Image)
        Me.lineSelector.Name = "lineSelector"
        Me.lineSelector.OptionGroup = "charts"
        Me.lineSelector.Text = "Line"
        '
        'pieSelector
        '
        Me.pieSelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.pieSelector.Image = CType(resources.GetObject("pieSelector.Image"), System.Drawing.Image)
        Me.pieSelector.Name = "pieSelector"
        Me.pieSelector.OptionGroup = "charts"
        Me.pieSelector.Text = "Pie"
        '
        'barSelector
        '
        Me.barSelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.barSelector.Image = CType(resources.GetObject("barSelector.Image"), System.Drawing.Image)
        Me.barSelector.Name = "barSelector"
        Me.barSelector.OptionGroup = "charts"
        Me.barSelector.Text = "Bar"
        '
        'panelEx1
        '
        Me.panelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelEx1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelEx1.Location = New System.Drawing.Point(0, 0)
        Me.panelEx1.Name = "panelEx1"
        Me.panelEx1.Size = New System.Drawing.Size(562, 32)
        Me.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(95, Byte), CType(136, Byte), CType(215, Byte))
        Me.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(67, Byte), CType(108, Byte), CType(191, Byte))
        Me.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEx1.Style.GradientAngle = 90
        Me.panelEx1.Style.MarginLeft = 8
        Me.panelEx1.TabIndex = 5
        Me.panelEx1.Text = "Choose a Chart Type"
        '
        'buttonItem1
        '
        Me.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.buttonItem1.Image = CType(resources.GetObject("buttonItem1.Image"), System.Drawing.Image)
        Me.buttonItem1.Name = "buttonItem1"
        Me.buttonItem1.OptionGroup = "charts"
        Me.buttonItem1.Text = "Templates"
        '
        'columnSelector
        '
        Me.columnSelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.columnSelector.Checked = True
        Me.columnSelector.Image = CType(resources.GetObject("columnSelector.Image"), System.Drawing.Image)
        Me.columnSelector.Name = "columnSelector"
        Me.columnSelector.OptionGroup = "charts"
        Me.columnSelector.Text = "Column"
        '
        'labelItem1
        '
        Me.labelItem1.BackColor = System.Drawing.Color.FromArgb(CType(235, Byte), CType(235, Byte), CType(235, Byte))
        Me.labelItem1.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.labelItem1.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.labelItem1.Name = "labelItem1"
        Me.labelItem1.PaddingBottom = 1
        Me.labelItem1.PaddingLeft = 1
        Me.labelItem1.PaddingRight = 1
        Me.labelItem1.PaddingTop = 1
        Me.labelItem1.SingleLineColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(197, Byte), CType(197, Byte))
        Me.labelItem1.Text = "<b>Column</b>"
        '
        'columnContainer
        '
        Me.columnContainer.MinimumSize = New System.Drawing.Size(0, 0)
        Me.columnContainer.MultiLine = True
        Me.columnContainer.Name = "columnContainer"
        Me.columnContainer.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem12, Me.buttonItem13, Me.buttonItem14, Me.buttonItem15, Me.buttonItem16, Me.buttonItem17, Me.buttonItem18, Me.buttonItem19})
        '
        'buttonItem12
        '
        Me.buttonItem12.Image = CType(resources.GetObject("buttonItem12.Image"), System.Drawing.Image)
        Me.buttonItem12.Name = "buttonItem12"
        Me.buttonItem12.OptionGroup = "chart"
        Me.buttonItem12.Text = "Clustered Column"
        Me.buttonItem12.Tooltip = "Clustered Column"
        '
        'areaSelector
        '
        Me.areaSelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.areaSelector.Image = CType(resources.GetObject("areaSelector.Image"), System.Drawing.Image)
        Me.areaSelector.Name = "areaSelector"
        Me.areaSelector.OptionGroup = "charts"
        Me.areaSelector.Text = "Area"
        '
        'xySelector
        '
        Me.xySelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.xySelector.Image = CType(resources.GetObject("xySelector.Image"), System.Drawing.Image)
        Me.xySelector.Name = "xySelector"
        Me.xySelector.OptionGroup = "charts"
        Me.xySelector.Text = "X Y (Scatter)"
        '
        'stockSelector
        '
        Me.stockSelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.stockSelector.Image = CType(resources.GetObject("stockSelector.Image"), System.Drawing.Image)
        Me.stockSelector.Name = "stockSelector"
        Me.stockSelector.OptionGroup = "charts"
        Me.stockSelector.Text = "Stock"
        '
        'labelItem5
        '
        Me.labelItem5.BackColor = System.Drawing.Color.FromArgb(CType(235, Byte), CType(235, Byte), CType(235, Byte))
        Me.labelItem5.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.labelItem5.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.labelItem5.Name = "labelItem5"
        Me.labelItem5.PaddingBottom = 1
        Me.labelItem5.PaddingLeft = 1
        Me.labelItem5.PaddingRight = 1
        Me.labelItem5.PaddingTop = 1
        Me.labelItem5.SingleLineColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(197, Byte), CType(197, Byte))
        Me.labelItem5.Text = "<b>Area</b>"
        '
        'areaContainer
        '
        Me.areaContainer.MinimumSize = New System.Drawing.Size(0, 0)
        Me.areaContainer.MultiLine = True
        Me.areaContainer.Name = "areaContainer"
        Me.areaContainer.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem31, Me.buttonItem32, Me.buttonItem33})
        '
        'buttonItem31
        '
        Me.buttonItem31.Image = CType(resources.GetObject("buttonItem31.Image"), System.Drawing.Image)
        Me.buttonItem31.Name = "buttonItem31"
        Me.buttonItem31.OptionGroup = "chart"
        Me.buttonItem31.Text = "Area"
        Me.buttonItem31.Tooltip = "Area"
        '
        'buttonItem32
        '
        Me.buttonItem32.Image = CType(resources.GetObject("buttonItem32.Image"), System.Drawing.Image)
        Me.buttonItem32.Name = "buttonItem32"
        Me.buttonItem32.OptionGroup = "chart"
        Me.buttonItem32.Text = "Stacked Area"
        Me.buttonItem32.Tooltip = "Stacked Area"
        '
        'buttonItem33
        '
        Me.buttonItem33.Image = CType(resources.GetObject("buttonItem33.Image"), System.Drawing.Image)
        Me.buttonItem33.Name = "buttonItem33"
        Me.buttonItem33.OptionGroup = "chart"
        Me.buttonItem33.Text = "100% Stacked Area"
        Me.buttonItem33.Tooltip = "100% Stacked Area"
        '
        'buttonItem30
        '
        Me.buttonItem30.Image = CType(resources.GetObject("buttonItem30.Image"), System.Drawing.Image)
        Me.buttonItem30.Name = "buttonItem30"
        Me.buttonItem30.OptionGroup = "chart"
        Me.buttonItem30.Text = "Clustered Bar"
        Me.buttonItem30.Tooltip = "Clustered Bar"
        '
        'buttonItem28
        '
        Me.buttonItem28.Image = CType(resources.GetObject("buttonItem28.Image"), System.Drawing.Image)
        Me.buttonItem28.Name = "buttonItem28"
        Me.buttonItem28.OptionGroup = "chart"
        Me.buttonItem28.Text = "Stacked Bar"
        Me.buttonItem28.Tooltip = "Stacked Bar"
        '
        'buttonItem29
        '
        Me.buttonItem29.Image = CType(resources.GetObject("buttonItem29.Image"), System.Drawing.Image)
        Me.buttonItem29.Name = "buttonItem29"
        Me.buttonItem29.OptionGroup = "chart"
        Me.buttonItem29.Text = "100% Stacked Bar"
        Me.buttonItem29.Tooltip = "100% Stacked Bar"
        '
        'buttonItem27
        '
        Me.buttonItem27.Image = CType(resources.GetObject("buttonItem27.Image"), System.Drawing.Image)
        Me.buttonItem27.Name = "buttonItem27"
        Me.buttonItem27.OptionGroup = "chart"
        Me.buttonItem27.Text = "Clustered Bar"
        Me.buttonItem27.Tooltip = "Clustered Bar"
        '
        'buttonX2
        '
        Me.buttonX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonX2.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.buttonX2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonX2.Location = New System.Drawing.Point(482, 306)
        Me.buttonX2.Name = "buttonX2"
        Me.buttonX2.Size = New System.Drawing.Size(72, 24)
        Me.buttonX2.TabIndex = 8
        Me.buttonX2.Text = "Cancel"
        Me.buttonX2.ThemeAware = True
        '
        'buttonX1
        '
        Me.buttonX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonX1.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.buttonX1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.buttonX1.Location = New System.Drawing.Point(404, 306)
        Me.buttonX1.Name = "buttonX1"
        Me.buttonX1.Size = New System.Drawing.Size(72, 24)
        Me.buttonX1.TabIndex = 7
        Me.buttonX1.Text = "OK"
        Me.buttonX1.ThemeAware = True
        '
        'chartTypes
        '
        Me.chartTypes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        'chartTypes.BackgroundStyle
        '
        Me.chartTypes.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.chartTypes.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.chartTypes.BackgroundStyle.BorderBottomWidth = 1
        Me.chartTypes.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(CType(127, Byte), CType(157, Byte), CType(185, Byte))
        Me.chartTypes.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.chartTypes.BackgroundStyle.BorderLeftWidth = 1
        Me.chartTypes.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.chartTypes.BackgroundStyle.BorderRightWidth = 1
        Me.chartTypes.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.chartTypes.BackgroundStyle.BorderTopWidth = 1
        Me.chartTypes.BackgroundStyle.PaddingBottom = 1
        Me.chartTypes.BackgroundStyle.PaddingLeft = 1
        Me.chartTypes.BackgroundStyle.PaddingRight = 1
        Me.chartTypes.BackgroundStyle.PaddingTop = 1
        Me.chartTypes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chartTypes.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem1, Me.columnSelector, Me.lineSelector, Me.pieSelector, Me.barSelector, Me.areaSelector, Me.xySelector, Me.stockSelector})
        Me.chartTypes.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.chartTypes.Location = New System.Drawing.Point(6, 38)
        Me.chartTypes.Name = "chartTypes"
        Me.chartTypes.Size = New System.Drawing.Size(152, 262)
        Me.chartTypes.TabIndex = 6
        Me.chartTypes.Text = "itemPanel1"
        '
        'itemPanel2
        '
        Me.itemPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.itemPanel2.AutoScroll = True
        Me.itemPanel2.AutoScrollMinSize = New System.Drawing.Size(369, 493)
        '
        'itemPanel2.BackgroundStyle
        '
        Me.itemPanel2.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.itemPanel2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.itemPanel2.BackgroundStyle.BorderBottomWidth = 1
        Me.itemPanel2.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(CType(127, Byte), CType(157, Byte), CType(185, Byte))
        Me.itemPanel2.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.itemPanel2.BackgroundStyle.BorderLeftWidth = 1
        Me.itemPanel2.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.itemPanel2.BackgroundStyle.BorderRightWidth = 1
        Me.itemPanel2.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.itemPanel2.BackgroundStyle.BorderTopWidth = 1
        Me.itemPanel2.BackgroundStyle.PaddingBottom = 1
        Me.itemPanel2.BackgroundStyle.PaddingLeft = 1
        Me.itemPanel2.BackgroundStyle.PaddingRight = 1
        Me.itemPanel2.BackgroundStyle.PaddingTop = 1
        Me.itemPanel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemPanel2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.labelItem1, Me.columnContainer, Me.labelItem2, Me.lineContainer, Me.labelItem3, Me.pieContainer, Me.labelItem4, Me.barContainer, Me.labelItem5, Me.areaContainer})
        Me.itemPanel2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.itemPanel2.Location = New System.Drawing.Point(168, 38)
        Me.itemPanel2.Name = "itemPanel2"
        Me.itemPanel2.Size = New System.Drawing.Size(386, 262)
        Me.itemPanel2.TabIndex = 9
        Me.itemPanel2.Text = "itemPanel2"
        '
        'labelItem3
        '
        Me.labelItem3.BackColor = System.Drawing.Color.FromArgb(CType(235, Byte), CType(235, Byte), CType(235, Byte))
        Me.labelItem3.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.labelItem3.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.labelItem3.Name = "labelItem3"
        Me.labelItem3.PaddingBottom = 1
        Me.labelItem3.PaddingLeft = 1
        Me.labelItem3.PaddingRight = 1
        Me.labelItem3.PaddingTop = 1
        Me.labelItem3.SingleLineColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(197, Byte), CType(197, Byte))
        Me.labelItem3.Text = "<b>Pie</b>"
        '
        'pieContainer
        '
        Me.pieContainer.MinimumSize = New System.Drawing.Size(0, 0)
        Me.pieContainer.MultiLine = True
        Me.pieContainer.Name = "pieContainer"
        Me.pieContainer.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem9, Me.buttonItem10, Me.buttonItem11})
        '
        'buttonItem9
        '
        Me.buttonItem9.Image = CType(resources.GetObject("buttonItem9.Image"), System.Drawing.Image)
        Me.buttonItem9.Name = "buttonItem9"
        Me.buttonItem9.OptionGroup = "chart"
        Me.buttonItem9.Text = "Pie"
        Me.buttonItem9.Tooltip = "Pie"
        '
        'buttonItem10
        '
        Me.buttonItem10.Image = CType(resources.GetObject("buttonItem10.Image"), System.Drawing.Image)
        Me.buttonItem10.Name = "buttonItem10"
        Me.buttonItem10.OptionGroup = "chart"
        Me.buttonItem10.Text = "Pie"
        Me.buttonItem10.Tooltip = "Pie"
        '
        'buttonItem11
        '
        Me.buttonItem11.Image = CType(resources.GetObject("buttonItem11.Image"), System.Drawing.Image)
        Me.buttonItem11.Name = "buttonItem11"
        Me.buttonItem11.OptionGroup = "chart"
        Me.buttonItem11.Text = "Pie"
        Me.buttonItem11.Tooltip = "Pie"
        '
        'labelItem4
        '
        Me.labelItem4.BackColor = System.Drawing.Color.FromArgb(CType(235, Byte), CType(235, Byte), CType(235, Byte))
        Me.labelItem4.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.labelItem4.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.labelItem4.Name = "labelItem4"
        Me.labelItem4.PaddingBottom = 1
        Me.labelItem4.PaddingLeft = 1
        Me.labelItem4.PaddingRight = 1
        Me.labelItem4.PaddingTop = 1
        Me.labelItem4.SingleLineColor = System.Drawing.Color.FromArgb(CType(197, Byte), CType(197, Byte), CType(197, Byte))
        Me.labelItem4.Text = "<b>Bar</b>"
        '
        'barContainer
        '
        Me.barContainer.MinimumSize = New System.Drawing.Size(0, 0)
        Me.barContainer.MultiLine = True
        Me.barContainer.Name = "barContainer"
        Me.barContainer.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem24, Me.buttonItem25, Me.buttonItem26, Me.buttonItem27, Me.buttonItem28, Me.buttonItem29, Me.buttonItem30})
        '
        'buttonItem24
        '
        Me.buttonItem24.Image = CType(resources.GetObject("buttonItem24.Image"), System.Drawing.Image)
        Me.buttonItem24.Name = "buttonItem24"
        Me.buttonItem24.OptionGroup = "chart"
        Me.buttonItem24.Text = "Clustered Bar"
        Me.buttonItem24.Tooltip = "Clustered Bar"
        '
        'buttonItem25
        '
        Me.buttonItem25.Image = CType(resources.GetObject("buttonItem25.Image"), System.Drawing.Image)
        Me.buttonItem25.Name = "buttonItem25"
        Me.buttonItem25.OptionGroup = "chart"
        Me.buttonItem25.Text = "Stacked Bar"
        Me.buttonItem25.Tooltip = "Stacked Bar"
        '
        'buttonItem26
        '
        Me.buttonItem26.Image = CType(resources.GetObject("buttonItem26.Image"), System.Drawing.Image)
        Me.buttonItem26.Name = "buttonItem26"
        Me.buttonItem26.OptionGroup = "chart"
        Me.buttonItem26.Text = "100% Stacked Bar"
        Me.buttonItem26.Tooltip = "100% Stacked Bar"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(562, 332)
        Me.Controls.Add(Me.panelEx1)
        Me.Controls.Add(Me.buttonX2)
        Me.Controls.Add(Me.buttonX1)
        Me.Controls.Add(Me.chartTypes)
        Me.Controls.Add(Me.itemPanel2)
        Me.Name = "Form1"
        Me.Text = "Create Chart"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub columnSelector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles columnSelector.Click
        itemPanel2.EnsureVisible(columnContainer)
    End Sub

    Private Sub lineSelector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lineSelector.Click
        itemPanel2.EnsureVisible(lineContainer)
    End Sub

    Private Sub pieSelector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pieSelector.Click
        itemPanel2.EnsureVisible(pieContainer)
    End Sub

    Private Sub barSelector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles barSelector.Click
        itemPanel2.EnsureVisible(barContainer)
    End Sub

    Private Sub areaSelector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles areaSelector.Click
        itemPanel2.EnsureVisible(areaContainer)
    End Sub

    Private Sub itemPanel2_ItemClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles itemPanel2.ItemClick
        If TypeOf (sender) Is ButtonItem Then
            ' Since chart selector buttons are in separate containers the ButtonItem.OptionGroup setting will not unselect
            ' the button from another container so we need to do it here
            Dim button As ButtonItem = GetCheckedButton(itemPanel2.Items, CType(sender, ButtonItem))
            If Not button Is Nothing Then button.Checked = False
        End If
    End Sub

    Private Function GetCheckedButton(ByVal parentCollection As SubItemsCollection, ByVal exclude As ButtonItem) As ButtonItem
        Dim item As BaseItem
        For Each item In parentCollection
            If TypeOf (item) Is ButtonItem AndAlso Not item Is exclude AndAlso CType(item, ButtonItem).Checked Then
                Return CType(item, ButtonItem)
            ElseIf item.IsContainer Then
                Dim button As ButtonItem = GetCheckedButton(item.SubItems, exclude)
                If Not button Is Nothing Then Return button
            End If
        Next
        Return Nothing
    End Function

    Private Sub buttonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonX1.Click
        Me.Close()
    End Sub

    Private Sub buttonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonX2.Click
        Me.Close()
    End Sub
End Class
