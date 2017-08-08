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
    Friend WithEvents tabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents tabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents panelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents panelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents richTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents tabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents richTextBox5 As System.Windows.Forms.RichTextBox
    Friend WithEvents panelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents panelEx6 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents richTextBox6 As System.Windows.Forms.RichTextBox
    Friend WithEvents tabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents richTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents panelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents panelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents richTextBox4 As System.Windows.Forms.RichTextBox
    Friend WithEvents tabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents tabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents tabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents ExpandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents ItemPanel1 As DevComponents.DotNetBar.ItemPanel
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tabControl1 = New DevComponents.DotNetBar.TabControl()
        Me.tabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.richTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.tabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.tabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.richTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.panelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.richTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.tabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.tabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel()
        Me.richTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.panelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.label3 = New System.Windows.Forms.Label()
        Me.panelEx6 = New DevComponents.DotNetBar.PanelEx()
        Me.richTextBox6 = New System.Windows.Forms.RichTextBox()
        Me.tabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.ExpandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.ItemPanel1 = New DevComponents.DotNetBar.ItemPanel()
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        CType(Me.tabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl1.SuspendLayout()
        Me.tabControlPanel1.SuspendLayout()
        Me.panelEx1.SuspendLayout()
        Me.panelEx2.SuspendLayout()
        Me.tabControlPanel2.SuspendLayout()
        Me.panelEx3.SuspendLayout()
        Me.panelEx4.SuspendLayout()
        Me.tabControlPanel3.SuspendLayout()
        Me.panelEx5.SuspendLayout()
        Me.panelEx6.SuspendLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.CanReorderTabs = True
        Me.tabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.tabControlPanel1, Me.tabControlPanel2, Me.tabControlPanel3})
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.Location = New System.Drawing.Point(128, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tabControl1.SelectedTabIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(344, 278)
        Me.tabControl1.TabIndex = 4
        Me.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.tabControl1.Tabs.Add(Me.tabItem1)
        Me.tabControl1.Tabs.Add(Me.tabItem2)
        Me.tabControl1.Tabs.Add(Me.tabItem3)
        '
        'tabControlPanel1
        '
        Me.tabControlPanel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.richTextBox1, Me.panelEx1})
        Me.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlPanel1.DockPadding.All = 1
        Me.tabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.tabControlPanel1.Name = "tabControlPanel1"
        Me.tabControlPanel1.Size = New System.Drawing.Size(344, 252)
        Me.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(142, Byte), CType(179, Byte), CType(231, Byte))
        Me.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(223, Byte), CType(237, Byte), CType(254, Byte))
        Me.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(59, Byte), CType(97, Byte), CType(156, Byte))
        Me.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom)
        Me.tabControlPanel1.Style.GradientAngle = 90
        Me.tabControlPanel1.TabIndex = 1
        Me.tabControlPanel1.TabItem = Me.tabItem1
        '
        'richTextBox1
        '
        Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richTextBox1.Location = New System.Drawing.Point(1, 56)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(342, 195)
        Me.richTextBox1.TabIndex = 1
        Me.richTextBox1.Text = "OneNote style on new tab control has 16 predefined  color styles for tabs includi" & _
        "ng default style that is based on system colors. This sample project is 100% con" & _
        "structed using DotNetBar design-time interface. Right-click tabs to change their" & _
        " color."
        Me.richTextBox1.ZoomFactor = 1.199854!
        '
        'panelEx1
        '
        Me.panelEx1.Controls.AddRange(New System.Windows.Forms.Control() {Me.label1, Me.panelEx2})
        Me.panelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelEx1.Location = New System.Drawing.Point(1, 1)
        Me.panelEx1.Name = "panelEx1"
        Me.panelEx1.Size = New System.Drawing.Size(342, 55)
        Me.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(221, Byte), CType(230, Byte), CType(247, Byte))
        Me.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEx1.Style.GradientAngle = 90
        Me.panelEx1.TabIndex = 0
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Gray
        Me.label1.Location = New System.Drawing.Point(8, 40)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(26, 14)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Title"
        '
        'panelEx2
        '
        Me.panelEx2.Controls.AddRange(New System.Windows.Forms.Control() {Me.richTextBox2})
        Me.panelEx2.DockPadding.All = 1
        Me.panelEx2.Location = New System.Drawing.Point(8, 8)
        Me.panelEx2.Name = "panelEx2"
        Me.panelEx2.Size = New System.Drawing.Size(192, 32)
        Me.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx2.Style.BackColor1.Color = System.Drawing.Color.White
        Me.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEx2.Style.BorderColor.Color = System.Drawing.Color.Gray
        Me.panelEx2.Style.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEx2.Style.GradientAngle = 90
        Me.panelEx2.TabIndex = 0
        Me.panelEx2.Text = "panelEx2"
        '
        'richTextBox2
        '
        Me.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.richTextBox2.Location = New System.Drawing.Point(1, 1)
        Me.richTextBox2.Name = "richTextBox2"
        Me.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.richTextBox2.Size = New System.Drawing.Size(190, 30)
        Me.richTextBox2.TabIndex = 0
        Me.richTextBox2.Text = "DotNetBar"
        '
        'tabItem1
        '
        Me.tabItem1.AttachedControl = Me.tabControlPanel1
        Me.tabItem1.Name = "tabItem1"
        Me.tabItem1.Text = "&General"
        '
        'tabControlPanel2
        '
        Me.tabControlPanel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.richTextBox3, Me.panelEx3})
        Me.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlPanel2.DockPadding.All = 1
        Me.tabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.tabControlPanel2.Name = "tabControlPanel2"
        Me.tabControlPanel2.Size = New System.Drawing.Size(344, 252)
        Me.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(255, Byte), CType(244, Byte), CType(213, Byte))
        Me.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(255, Byte), CType(216, Byte), CType(105, Byte))
        Me.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(59, Byte), CType(97, Byte), CType(156, Byte))
        Me.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom)
        Me.tabControlPanel2.Style.GradientAngle = -90
        Me.tabControlPanel2.TabIndex = 2
        Me.tabControlPanel2.TabItem = Me.tabItem2
        '
        'richTextBox3
        '
        Me.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richTextBox3.Location = New System.Drawing.Point(1, 56)
        Me.richTextBox3.Name = "richTextBox3"
        Me.richTextBox3.Size = New System.Drawing.Size(342, 195)
        Me.richTextBox3.TabIndex = 3
        Me.richTextBox3.Text = "The style power in tab panels comes directly from PanelEx control. PanelEx contro" & _
        "l is a multi-functional container control with powerful visual control."
        Me.richTextBox3.ZoomFactor = 1.199854!
        '
        'panelEx3
        '
        Me.panelEx3.Controls.AddRange(New System.Windows.Forms.Control() {Me.label2, Me.panelEx4})
        Me.panelEx3.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelEx3.Location = New System.Drawing.Point(1, 1)
        Me.panelEx3.Name = "panelEx3"
        Me.panelEx3.Size = New System.Drawing.Size(342, 55)
        Me.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(255, Byte), CType(244, Byte), CType(213, Byte))
        Me.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEx3.Style.GradientAngle = 90
        Me.panelEx3.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Gray
        Me.label2.Location = New System.Drawing.Point(8, 40)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(26, 14)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Title"
        '
        'panelEx4
        '
        Me.panelEx4.Controls.AddRange(New System.Windows.Forms.Control() {Me.richTextBox4})
        Me.panelEx4.DockPadding.All = 1
        Me.panelEx4.Location = New System.Drawing.Point(8, 8)
        Me.panelEx4.Name = "panelEx4"
        Me.panelEx4.Size = New System.Drawing.Size(192, 32)
        Me.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx4.Style.BackColor1.Color = System.Drawing.Color.White
        Me.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEx4.Style.BorderColor.Color = System.Drawing.Color.Gray
        Me.panelEx4.Style.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEx4.Style.GradientAngle = 90
        Me.panelEx4.TabIndex = 0
        Me.panelEx4.Text = "panelEx2"
        '
        'richTextBox4
        '
        Me.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richTextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.richTextBox4.Location = New System.Drawing.Point(1, 1)
        Me.richTextBox4.Name = "richTextBox4"
        Me.richTextBox4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.richTextBox4.Size = New System.Drawing.Size(190, 30)
        Me.richTextBox4.TabIndex = 0
        Me.richTextBox4.Text = "PanelEx Control"
        '
        'tabItem2
        '
        Me.tabItem2.AttachedControl = Me.tabControlPanel2
        Me.tabItem2.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(244, Byte), CType(213, Byte))
        Me.tabItem2.BackColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(216, Byte), CType(105, Byte))
        Me.tabItem2.Name = "tabItem2"
        Me.tabItem2.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Yellow
        Me.tabItem2.Text = "Project &A"
        '
        'tabControlPanel3
        '
        Me.tabControlPanel3.Controls.AddRange(New System.Windows.Forms.Control() {Me.richTextBox5, Me.panelEx5})
        Me.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlPanel3.DockPadding.All = 1
        Me.tabControlPanel3.Location = New System.Drawing.Point(0, 26)
        Me.tabControlPanel3.Name = "tabControlPanel3"
        Me.tabControlPanel3.Size = New System.Drawing.Size(344, 252)
        Me.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(232, Byte), CType(248, Byte), CType(224, Byte))
        Me.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(173, Byte), CType(231, Byte), CType(146, Byte))
        Me.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(59, Byte), CType(97, Byte), CType(156, Byte))
        Me.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom)
        Me.tabControlPanel3.Style.GradientAngle = -90
        Me.tabControlPanel3.TabIndex = 3
        Me.tabControlPanel3.TabItem = Me.tabItem3
        '
        'richTextBox5
        '
        Me.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richTextBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richTextBox5.Location = New System.Drawing.Point(1, 56)
        Me.richTextBox5.Name = "richTextBox5"
        Me.richTextBox5.Size = New System.Drawing.Size(342, 195)
        Me.richTextBox5.TabIndex = 3
        Me.richTextBox5.Text = "TabStrip control implements all styling capabilities of Tab control including One" & _
        "Note style. Take a look at modified Notepad sample for an example of TabStrip co" & _
        "ntrol using OneNote style for MDI child for navigation."
        Me.richTextBox5.ZoomFactor = 1.199854!
        '
        'panelEx5
        '
        Me.panelEx5.Controls.AddRange(New System.Windows.Forms.Control() {Me.label3, Me.panelEx6})
        Me.panelEx5.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelEx5.Location = New System.Drawing.Point(1, 1)
        Me.panelEx5.Name = "panelEx5"
        Me.panelEx5.Size = New System.Drawing.Size(342, 55)
        Me.panelEx5.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx5.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(232, Byte), CType(248, Byte), CType(224, Byte))
        Me.panelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEx5.Style.GradientAngle = 90
        Me.panelEx5.TabIndex = 2
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Gray
        Me.label3.Location = New System.Drawing.Point(8, 40)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(26, 14)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Title"
        '
        'panelEx6
        '
        Me.panelEx6.Controls.AddRange(New System.Windows.Forms.Control() {Me.richTextBox6})
        Me.panelEx6.DockPadding.All = 1
        Me.panelEx6.Location = New System.Drawing.Point(8, 8)
        Me.panelEx6.Name = "panelEx6"
        Me.panelEx6.Size = New System.Drawing.Size(192, 32)
        Me.panelEx6.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx6.Style.BackColor1.Color = System.Drawing.Color.White
        Me.panelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEx6.Style.BorderColor.Color = System.Drawing.Color.Gray
        Me.panelEx6.Style.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.panelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEx6.Style.GradientAngle = 90
        Me.panelEx6.TabIndex = 0
        Me.panelEx6.Text = "panelEx2"
        '
        'richTextBox6
        '
        Me.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richTextBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.richTextBox6.Location = New System.Drawing.Point(1, 1)
        Me.richTextBox6.Name = "richTextBox6"
        Me.richTextBox6.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.richTextBox6.Size = New System.Drawing.Size(190, 30)
        Me.richTextBox6.TabIndex = 0
        Me.richTextBox6.Text = "TabStrip Control"
        '
        'tabItem3
        '
        Me.tabItem3.AttachedControl = Me.tabControlPanel3
        Me.tabItem3.BackColor = System.Drawing.Color.FromArgb(CType(232, Byte), CType(248, Byte), CType(224, Byte))
        Me.tabItem3.BackColor2 = System.Drawing.Color.FromArgb(CType(173, Byte), CType(231, Byte), CType(146, Byte))
        Me.tabItem3.Name = "tabItem3"
        Me.tabItem3.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Apple
        Me.tabItem3.Text = "Project &B"
        '
        'ExpandableSplitter1
        '
        Me.ExpandableSplitter1.BackColor = System.Drawing.Color.FromArgb(CType(227, Byte), CType(239, Byte), CType(255, Byte))
        Me.ExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(CType(101, Byte), CType(147, Byte), CType(207, Byte))
        Me.ExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandableSplitter1.ExpandableControl = Me.ItemPanel1
        Me.ExpandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(CType(101, Byte), CType(147, Byte), CType(207, Byte))
        Me.ExpandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte))
        Me.ExpandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte))
        Me.ExpandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(CType(227, Byte), CType(239, Byte), CType(255, Byte))
        Me.ExpandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(CType(252, Byte), CType(151, Byte), CType(61, Byte))
        Me.ExpandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(184, Byte), CType(94, Byte))
        Me.ExpandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.ExpandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(101, Byte), CType(147, Byte), CType(207, Byte))
        Me.ExpandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte))
        Me.ExpandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(101, Byte), CType(147, Byte), CType(207, Byte))
        Me.ExpandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(CType(227, Byte), CType(239, Byte), CType(255, Byte))
        Me.ExpandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableSplitter1.Location = New System.Drawing.Point(120, 0)
        Me.ExpandableSplitter1.Name = "ExpandableSplitter1"
        Me.ExpandableSplitter1.Size = New System.Drawing.Size(8, 278)
        Me.ExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.ExpandableSplitter1.TabIndex = 6
        Me.ExpandableSplitter1.TabStop = False
        '
        'ItemPanel1
        '
        '
        'ItemPanel1.BackgroundStyle
        '
        Me.ItemPanel1.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.ItemPanel1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ItemPanel1.BackgroundStyle.BorderBottomWidth = 1
        Me.ItemPanel1.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(CType(127, Byte), CType(157, Byte), CType(185, Byte))
        Me.ItemPanel1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ItemPanel1.BackgroundStyle.BorderLeftWidth = 1
        Me.ItemPanel1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ItemPanel1.BackgroundStyle.BorderRightWidth = 1
        Me.ItemPanel1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ItemPanel1.BackgroundStyle.BorderTopWidth = 1
        Me.ItemPanel1.BackgroundStyle.PaddingBottom = 1
        Me.ItemPanel1.BackgroundStyle.PaddingLeft = 1
        Me.ItemPanel1.BackgroundStyle.PaddingRight = 1
        Me.ItemPanel1.BackgroundStyle.PaddingTop = 1
        Me.ItemPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ItemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemPanel1.Name = "ItemPanel1"
        Me.ItemPanel1.Size = New System.Drawing.Size(120, 278)
        Me.ItemPanel1.TabIndex = 5
        Me.ItemPanel1.Text = "ItemPanel1"
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.Location = New System.Drawing.Point(56, 232)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(75, 25)
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.ContextMenuBar1.TabIndex = 7
        Me.ContextMenuBar1.TabStop = False
        Me.ContextMenuBar1.Text = "ContextMenuBar1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(472, 278)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.ContextMenuBar1, Me.tabControl1, Me.ExpandableSplitter1, Me.ItemPanel1})
        Me.MinimumSize = New System.Drawing.Size(360, 250)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.tabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl1.ResumeLayout(False)
        Me.tabControlPanel1.ResumeLayout(False)
        Me.panelEx1.ResumeLayout(False)
        Me.panelEx2.ResumeLayout(False)
        Me.tabControlPanel2.ResumeLayout(False)
        Me.panelEx3.ResumeLayout(False)
        Me.panelEx4.ResumeLayout(False)
        Me.tabControlPanel3.ResumeLayout(False)
        Me.panelEx5.ResumeLayout(False)
        Me.panelEx6.ResumeLayout(False)
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler tabControl1.TabStrip.MouseDown, AddressOf tabControl1_MouseDown

        ' Load available tab control styles into the panel
        Dim tabStyles As String() = System.Enum.GetNames(GetType(eTabStripStyle))
        Dim style As String

        ItemPanel1.BeginUpdate()
        For Each style In tabStyles
            Dim button As ButtonItem = New ButtonItem(style, style)
            button.OptionGroup = "TabStyle" ' This provides automatic management for Checked property
            ItemPanel1.Items.Add(button)

            If tabControl1.Style.ToString() = style Then button.Checked = True
        Next
        ItemPanel1.EndUpdate()
    End Sub

    Dim m_TabMouseDown As TabItem
    Private Sub tabControl1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button <> MouseButtons.Right Then Exit Sub

        ' Convert to screen based coordinates for context menu
        Dim p As Point = New Point(e.X, e.Y)
        Dim pScreen As Point = tabControl1.PointToScreen(p)
        Dim tab As TabItem = tabControl1.TabStrip.HitTest(p.X, p.Y)
        If Not (tab Is Nothing) Then
            m_TabMouseDown = tab
            CreateContextMenu()
            Dim item As ButtonItem = CType(ContextMenuBar1.Items("tabColors"), ButtonItem)
            item.Popup(pScreen)
        End If
    End Sub

    Private Sub CreateContextMenu()

        If ContextMenuBar1.Items.Contains("tabColors") Then Exit Sub

        Dim item As ButtonItem = New ButtonItem("tabColors", "Tab Colors Context menu")
        item.Style = eDotNetBarStyle.Office2003
        ContextMenuBar1.Items.Add(item)

        ' Create one menu item for each entry in eTabItemColor
        Dim names As String() = System.Enum.GetNames(GetType(eTabItemColor))

        Dim s As String
        For Each s In names
            Dim menuItem As ButtonItem = New ButtonItem(s, s)
            ' Construct the image for the menu item by creating dummy tab item to get right colors from it
            Dim tabTemp As TabItem = New TabItem()
            tabTemp.PredefinedColor = CType(System.Enum.Parse(GetType(eTabItemColor), s), eTabItemColor)
            Dim bmp As Bitmap = New Bitmap(16, 16, System.Drawing.Imaging.PixelFormat.Format24bppRgb)
            Dim g As Graphics = Graphics.FromImage(bmp)
            Try
                g.Clear(SystemColors.Control)
                Dim r As Rectangle = New Rectangle(1, 1, 14, 14)
                Dim brush As System.Drawing.Drawing2D.LinearGradientBrush = New System.Drawing.Drawing2D.LinearGradientBrush(r, tabTemp.BackColor, tabTemp.BackColor2, tabTemp.BackColorGradientAngle)
                g.FillRectangle(brush, r)
                brush.Dispose()
                Dim pen As Pen = New Pen(Color.DarkGray, 1)
                g.DrawRectangle(pen, r)
                pen.Dispose()
            Finally
                g.Dispose()
            End Try
            bmp.MakeTransparent(SystemColors.Control)
            menuItem.Image = bmp
            AddHandler menuItem.Click, AddressOf ChangeTabColor
            item.SubItems.Add(menuItem)
        Next
    End Sub

    Private Sub ChangeTabColor(ByVal sender As Object, ByVal e As EventArgs)
        If Not m_TabMouseDown Is Nothing Then
            m_TabMouseDown.PredefinedColor = CType((System.Enum.Parse(GetType(eTabItemColor), CType(sender, BaseItem).Text)), eTabItemColor)
        End If
    End Sub

    Private Sub SetTabStyle(ByVal style As eTabStripStyle)
        tabControl1.Style = style

        Dim tab As TabItem

        For Each tab In tabControl1.Tabs
            tab.PredefinedColor = eTabItemColor.Default
        Next
    End Sub

    Private Sub ItemPanel1_ItemClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItemPanel1.ItemClick
        If Not TypeOf (sender) Is ButtonItem Then Exit Sub

        Dim button As ButtonItem = CType(sender, ButtonItem)
        Dim style As eTabStripStyle = System.Enum.Parse(GetType(eTabStripStyle), button.Name)
        SetTabStyle(style)
    End Sub
End Class
