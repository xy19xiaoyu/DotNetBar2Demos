Imports System.Drawing.Drawing2d

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()

        MyBase.New()

        Application.EnableVisualStyles()
        Application.DoEvents()

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
    Friend WithEvents TreeGX1 As DevComponents.Tree.TreeGX
    Friend WithEvents Node1 As DevComponents.Tree.Node
    Friend WithEvents NodeConnector1 As DevComponents.Tree.NodeConnector
    Friend WithEvents NodeConnector2 As DevComponents.Tree.NodeConnector
    Friend WithEvents ElementStyle1 As DevComponents.Tree.ElementStyle
    Friend WithEvents Node2 As DevComponents.Tree.Node
    Friend WithEvents Node3 As DevComponents.Tree.Node
    Friend WithEvents ElementStyle3 As DevComponents.Tree.ElementStyle
    Friend WithEvents ElementStyle2 As DevComponents.Tree.ElementStyle
    Friend WithEvents Node4 As DevComponents.Tree.Node
    Friend WithEvents ElementStyle4 As DevComponents.Tree.ElementStyle
    Friend WithEvents Node5 As DevComponents.Tree.Node
    Friend WithEvents ElementStyle5 As DevComponents.Tree.ElementStyle
    Friend WithEvents Node6 As DevComponents.Tree.Node
    Friend WithEvents ElementStyle6 As DevComponents.Tree.ElementStyle
    Friend WithEvents Node7 As DevComponents.Tree.Node
    Friend WithEvents ElementStyle7 As DevComponents.Tree.ElementStyle
    Friend WithEvents Node8 As DevComponents.Tree.Node
    Friend WithEvents Node9 As DevComponents.Tree.Node
    Friend WithEvents Node10 As DevComponents.Tree.Node
    Friend WithEvents Node11 As DevComponents.Tree.Node
    Friend WithEvents Node12 As DevComponents.Tree.Node
    Friend WithEvents Node13 As DevComponents.Tree.Node
    Friend WithEvents Node14 As DevComponents.Tree.Node
    Friend WithEvents Node15 As DevComponents.Tree.Node
    Friend WithEvents Node16 As DevComponents.Tree.Node
    Friend WithEvents Node17 As DevComponents.Tree.Node
    Friend WithEvents Node18 As DevComponents.Tree.Node
    Friend WithEvents Node19 As DevComponents.Tree.Node
    Friend WithEvents Node20 As DevComponents.Tree.Node
    Friend WithEvents Node21 As DevComponents.Tree.Node
    Friend WithEvents Node22 As DevComponents.Tree.Node
    Friend WithEvents Node23 As DevComponents.Tree.Node
    Friend WithEvents Node24 As DevComponents.Tree.Node
    Friend WithEvents Node25 As DevComponents.Tree.Node
    Friend WithEvents Node26 As DevComponents.Tree.Node
    Friend WithEvents NodeConnector3 As DevComponents.Tree.NodeConnector
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents labelZoom As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents trackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents printPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents printDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents buttonPrint As System.Windows.Forms.Button
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.TreeGX1 = New DevComponents.Tree.TreeGX
        Me.Node1 = New DevComponents.Tree.Node
        Me.Node2 = New DevComponents.Tree.Node
        Me.Node8 = New DevComponents.Tree.Node
        Me.ElementStyle3 = New DevComponents.Tree.ElementStyle
        Me.Node9 = New DevComponents.Tree.Node
        Me.Node10 = New DevComponents.Tree.Node
        Me.Node11 = New DevComponents.Tree.Node
        Me.Node3 = New DevComponents.Tree.Node
        Me.Node12 = New DevComponents.Tree.Node
        Me.ElementStyle2 = New DevComponents.Tree.ElementStyle
        Me.Node13 = New DevComponents.Tree.Node
        Me.Node4 = New DevComponents.Tree.Node
        Me.Node14 = New DevComponents.Tree.Node
        Me.ElementStyle4 = New DevComponents.Tree.ElementStyle
        Me.Node15 = New DevComponents.Tree.Node
        Me.Node16 = New DevComponents.Tree.Node
        Me.Node17 = New DevComponents.Tree.Node
        Me.Node18 = New DevComponents.Tree.Node
        Me.Node5 = New DevComponents.Tree.Node
        Me.Node19 = New DevComponents.Tree.Node
        Me.ElementStyle5 = New DevComponents.Tree.ElementStyle
        Me.Node20 = New DevComponents.Tree.Node
        Me.Node6 = New DevComponents.Tree.Node
        Me.Node21 = New DevComponents.Tree.Node
        Me.ElementStyle6 = New DevComponents.Tree.ElementStyle
        Me.Node22 = New DevComponents.Tree.Node
        Me.Node23 = New DevComponents.Tree.Node
        Me.Node7 = New DevComponents.Tree.Node
        Me.Node24 = New DevComponents.Tree.Node
        Me.ElementStyle7 = New DevComponents.Tree.ElementStyle
        Me.Node25 = New DevComponents.Tree.Node
        Me.Node26 = New DevComponents.Tree.Node
        Me.NodeConnector2 = New DevComponents.Tree.NodeConnector
        Me.ElementStyle1 = New DevComponents.Tree.ElementStyle
        Me.NodeConnector1 = New DevComponents.Tree.NodeConnector
        Me.NodeConnector3 = New DevComponents.Tree.NodeConnector
        Me.panel1 = New System.Windows.Forms.Panel
        Me.buttonPrint = New System.Windows.Forms.Button
        Me.labelZoom = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.trackBar1 = New System.Windows.Forms.TrackBar
        Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.printDocument1 = New System.Drawing.Printing.PrintDocument
        Me.button1 = New System.Windows.Forms.Button
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        CType(Me.TreeGX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeGX1
        '
        Me.TreeGX1.AllowDrop = True
        Me.TreeGX1.AutoScrollMinSize = New System.Drawing.Size(413, 364)
        '
        'TreeGX1.BackgroundStyle
        '
        Me.TreeGX1.BackgroundStyle.BackColor = System.Drawing.Color.Azure
        Me.TreeGX1.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.TreeGX1.BackgroundStyle.BackColorGradientAngle = 90
        Me.TreeGX1.CellEdit = True
        Me.TreeGX1.CommandBackColorGradientAngle = 90
        Me.TreeGX1.CommandMouseOverBackColor2SchemePart = DevComponents.Tree.eColorSchemePart.ItemHotBackground2
        Me.TreeGX1.CommandMouseOverBackColorGradientAngle = 90
        Me.TreeGX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeGX1.ExpandLineColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder
        Me.TreeGX1.Location = New System.Drawing.Point(0, 32)
        Me.TreeGX1.Name = "TreeGX1"
        Me.TreeGX1.Nodes.AddRange(New DevComponents.Tree.Node() {Me.Node1})
        Me.TreeGX1.NodesConnector = Me.NodeConnector2
        Me.TreeGX1.NodeStyle = Me.ElementStyle1
        Me.TreeGX1.NodeVerticalSpacing = 16
        Me.TreeGX1.PathSeparator = ";"
        Me.TreeGX1.RootConnector = Me.NodeConnector1
        Me.TreeGX1.SelectedPathConnector = Me.NodeConnector3
        Me.TreeGX1.Size = New System.Drawing.Size(512, 390)
        Me.TreeGX1.Styles.Add(Me.ElementStyle1)
        Me.TreeGX1.Styles.Add(Me.ElementStyle3)
        Me.TreeGX1.Styles.Add(Me.ElementStyle2)
        Me.TreeGX1.Styles.Add(Me.ElementStyle4)
        Me.TreeGX1.Styles.Add(Me.ElementStyle5)
        Me.TreeGX1.Styles.Add(Me.ElementStyle6)
        Me.TreeGX1.Styles.Add(Me.ElementStyle7)
        Me.TreeGX1.SuspendPaint = False
        Me.TreeGX1.TabIndex = 0
        Me.TreeGX1.Text = "TreeGX1"
        '
        'Node1
        '
        Me.Node1.Expanded = True
        Me.Node1.Name = "Node1"
        Me.Node1.Nodes.AddRange(New DevComponents.Tree.Node() {Me.Node2, Me.Node3, Me.Node4, Me.Node5, Me.Node6, Me.Node7})
        Me.Node1.Text = "<b><font size=""+4"">Six Hats</font></b>"
        '
        'Node2
        '
        Me.Node2.Expanded = True
        Me.Node2.Name = "Node2"
        Me.Node2.Nodes.AddRange(New DevComponents.Tree.Node() {Me.Node8, Me.Node9, Me.Node10, Me.Node11})
        Me.Node2.Style = Me.ElementStyle3
        Me.Node2.Text = "Blue"
        '
        'Node8
        '
        Me.Node8.Expanded = True
        Me.Node8.Name = "Node8"
        Me.Node8.Style = Me.ElementStyle3
        Me.Node8.Text = "Agenda"
        '
        'ElementStyle3
        '
        Me.ElementStyle3.BackColor = System.Drawing.Color.FromArgb(CType(221, Byte), CType(230, Byte), CType(247, Byte))
        Me.ElementStyle3.BackColor2 = System.Drawing.Color.FromArgb(CType(138, Byte), CType(168, Byte), CType(228, Byte))
        Me.ElementStyle3.BackColorGradientAngle = 90
        Me.ElementStyle3.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle3.BorderBottomWidth = 1
        Me.ElementStyle3.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle3.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle3.BorderLeftWidth = 1
        Me.ElementStyle3.BorderRight = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle3.BorderRightWidth = 1
        Me.ElementStyle3.BorderTop = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle3.BorderTopWidth = 1
        Me.ElementStyle3.CornerDiameter = 4
        Me.ElementStyle3.CornerType = DevComponents.Tree.eCornerType.Rounded
        Me.ElementStyle3.Description = "Blue"
        Me.ElementStyle3.Name = "ElementStyle3"
        Me.ElementStyle3.PaddingBottom = 3
        Me.ElementStyle3.PaddingLeft = 3
        Me.ElementStyle3.PaddingRight = 3
        Me.ElementStyle3.PaddingTop = 3
        Me.ElementStyle3.TextColor = System.Drawing.Color.Black
        '
        'Node9
        '
        Me.Node9.Expanded = True
        Me.Node9.Name = "Node9"
        Me.Node9.Style = Me.ElementStyle3
        Me.Node9.Text = "Decision"
        '
        'Node10
        '
        Me.Node10.Expanded = True
        Me.Node10.Name = "Node10"
        Me.Node10.Style = Me.ElementStyle3
        Me.Node10.Text = "Global"
        '
        'Node11
        '
        Me.Node11.Expanded = True
        Me.Node11.Name = "Node11"
        Me.Node11.Style = Me.ElementStyle3
        Me.Node11.Text = "Overview"
        '
        'Node3
        '
        Me.Node3.Expanded = True
        Me.Node3.Name = "Node3"
        Me.Node3.Nodes.AddRange(New DevComponents.Tree.Node() {Me.Node12, Me.Node13})
        Me.Node3.Style = Me.ElementStyle2
        Me.Node3.Text = "Black"
        '
        'Node12
        '
        Me.Node12.Expanded = True
        Me.Node12.Name = "Node12"
        Me.Node12.Style = Me.ElementStyle2
        Me.Node12.Text = "Critic"
        '
        'ElementStyle2
        '
        Me.ElementStyle2.BackColor = System.Drawing.Color.FromArgb(CType(77, Byte), CType(108, Byte), CType(152, Byte))
        Me.ElementStyle2.BackColor2 = System.Drawing.Color.Navy
        Me.ElementStyle2.BackColorGradientAngle = 90
        Me.ElementStyle2.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle2.BorderBottomWidth = 1
        Me.ElementStyle2.BorderColor = System.Drawing.Color.Navy
        Me.ElementStyle2.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle2.BorderLeftWidth = 1
        Me.ElementStyle2.BorderRight = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle2.BorderRightWidth = 1
        Me.ElementStyle2.BorderTop = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle2.BorderTopWidth = 1
        Me.ElementStyle2.CornerDiameter = 4
        Me.ElementStyle2.CornerType = DevComponents.Tree.eCornerType.Rounded
        Me.ElementStyle2.Description = "BlueNight"
        Me.ElementStyle2.Name = "ElementStyle2"
        Me.ElementStyle2.PaddingBottom = 3
        Me.ElementStyle2.PaddingLeft = 3
        Me.ElementStyle2.PaddingRight = 3
        Me.ElementStyle2.PaddingTop = 3
        Me.ElementStyle2.TextColor = System.Drawing.Color.White
        '
        'Node13
        '
        Me.Node13.Expanded = True
        Me.Node13.Name = "Node13"
        Me.Node13.Style = Me.ElementStyle2
        Me.Node13.Text = "Analyst"
        '
        'Node4
        '
        Me.Node4.Expanded = True
        Me.Node4.Name = "Node4"
        Me.Node4.Nodes.AddRange(New DevComponents.Tree.Node() {Me.Node14, Me.Node15, Me.Node16, Me.Node18})
        Me.Node4.Style = Me.ElementStyle4
        Me.Node4.Text = "<font color=""maroon"" size=""+2""><b>Red</b></font>"
        '
        'Node14
        '
        Me.Node14.Expanded = True
        Me.Node14.Name = "Node14"
        Me.Node14.Style = Me.ElementStyle4
        Me.Node14.Text = "Emotions"
        '
        'ElementStyle4
        '
        Me.ElementStyle4.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(225, Byte), CType(226, Byte))
        Me.ElementStyle4.BackColor2 = System.Drawing.Color.FromArgb(CType(238, Byte), CType(149, Byte), CType(151, Byte))
        Me.ElementStyle4.BackColorGradientAngle = 90
        Me.ElementStyle4.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle4.BorderBottomWidth = 1
        Me.ElementStyle4.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle4.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle4.BorderLeftWidth = 1
        Me.ElementStyle4.BorderRight = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle4.BorderRightWidth = 1
        Me.ElementStyle4.BorderTop = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle4.BorderTopWidth = 1
        Me.ElementStyle4.CornerDiameter = 4
        Me.ElementStyle4.CornerType = DevComponents.Tree.eCornerType.Rounded
        Me.ElementStyle4.Description = "Red"
        Me.ElementStyle4.Name = "ElementStyle4"
        Me.ElementStyle4.PaddingBottom = 3
        Me.ElementStyle4.PaddingLeft = 3
        Me.ElementStyle4.PaddingRight = 3
        Me.ElementStyle4.PaddingTop = 3
        Me.ElementStyle4.TextColor = System.Drawing.Color.Black
        '
        'Node15
        '
        Me.Node15.Expanded = True
        Me.Node15.Name = "Node15"
        Me.Node15.Style = Me.ElementStyle4
        Me.Node15.Text = "Hunches"
        '
        'Node16
        '
        Me.Node16.Expanded = True
        Me.Node16.Name = "Node16"
        Me.Node16.Nodes.AddRange(New DevComponents.Tree.Node() {Me.Node17})
        Me.Node16.Style = Me.ElementStyle4
        Me.Node16.Text = "Feelings"
        '
        'Node17
        '
        Me.Node17.Expanded = True
        Me.Node17.Name = "Node17"
        Me.Node17.Style = Me.ElementStyle4
        Me.Node17.Text = "Gut"
        '
        'Node18
        '
        Me.Node18.Expanded = True
        Me.Node18.Name = "Node18"
        Me.Node18.Style = Me.ElementStyle4
        Me.Node18.Text = "Instincts"
        '
        'Node5
        '
        Me.Node5.Expanded = True
        Me.Node5.Name = "Node5"
        Me.Node5.Nodes.AddRange(New DevComponents.Tree.Node() {Me.Node19, Me.Node20})
        Me.Node5.Style = Me.ElementStyle5
        Me.Node5.Text = "<div align=""center"">Yellow<br/><a href=""http://www.treegx.com"" name=""TreeGXHomePa" & _
        "ge"">Path</a></div>"
        '
        'Node19
        '
        Me.Node19.Expanded = True
        Me.Node19.Name = "Node19"
        Me.Node19.Style = Me.ElementStyle5
        Me.Node19.Text = "Logical"
        '
        'ElementStyle5
        '
        Me.ElementStyle5.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(244, Byte), CType(213, Byte))
        Me.ElementStyle5.BackColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(216, Byte), CType(105, Byte))
        Me.ElementStyle5.BackColorGradientAngle = 90
        Me.ElementStyle5.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle5.BorderBottomWidth = 1
        Me.ElementStyle5.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle5.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle5.BorderLeftWidth = 1
        Me.ElementStyle5.BorderRight = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle5.BorderRightWidth = 1
        Me.ElementStyle5.BorderTop = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle5.BorderTopWidth = 1
        Me.ElementStyle5.CornerDiameter = 4
        Me.ElementStyle5.CornerType = DevComponents.Tree.eCornerType.Rounded
        Me.ElementStyle5.Description = "Yellow"
        Me.ElementStyle5.Name = "ElementStyle5"
        Me.ElementStyle5.PaddingBottom = 3
        Me.ElementStyle5.PaddingLeft = 3
        Me.ElementStyle5.PaddingRight = 3
        Me.ElementStyle5.PaddingTop = 3
        Me.ElementStyle5.TextColor = System.Drawing.Color.Black
        '
        'Node20
        '
        Me.Node20.Expanded = True
        Me.Node20.Name = "Node20"
        Me.Node20.Style = Me.ElementStyle5
        Me.Node20.Text = "Positive"
        '
        'Node6
        '
        Me.Node6.Expanded = True
        Me.Node6.Name = "Node6"
        Me.Node6.Nodes.AddRange(New DevComponents.Tree.Node() {Me.Node21, Me.Node22, Me.Node23})
        Me.Node6.Style = Me.ElementStyle6
        Me.Node6.Text = "Green"
        '
        'Node21
        '
        Me.Node21.Expanded = True
        Me.Node21.Name = "Node21"
        Me.Node21.Style = Me.ElementStyle6
        Me.Node21.Text = "Creative"
        '
        'ElementStyle6
        '
        Me.ElementStyle6.BackColor = System.Drawing.Color.FromArgb(CType(234, Byte), CType(240, Byte), CType(226, Byte))
        Me.ElementStyle6.BackColor2 = System.Drawing.Color.FromArgb(CType(183, Byte), CType(201, Byte), CType(151, Byte))
        Me.ElementStyle6.BackColorGradientAngle = 90
        Me.ElementStyle6.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle6.BorderBottomWidth = 1
        Me.ElementStyle6.BorderColor = System.Drawing.Color.DarkGray
        Me.ElementStyle6.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle6.BorderLeftWidth = 1
        Me.ElementStyle6.BorderRight = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle6.BorderRightWidth = 1
        Me.ElementStyle6.BorderTop = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle6.BorderTopWidth = 1
        Me.ElementStyle6.CornerDiameter = 4
        Me.ElementStyle6.CornerType = DevComponents.Tree.eCornerType.Rounded
        Me.ElementStyle6.Description = "Green"
        Me.ElementStyle6.Name = "ElementStyle6"
        Me.ElementStyle6.PaddingBottom = 3
        Me.ElementStyle6.PaddingLeft = 3
        Me.ElementStyle6.PaddingRight = 3
        Me.ElementStyle6.PaddingTop = 3
        Me.ElementStyle6.TextColor = System.Drawing.Color.Black
        '
        'Node22
        '
        Me.Node22.Expanded = True
        Me.Node22.Name = "Node22"
        Me.Node22.Style = Me.ElementStyle6
        Me.Node22.Text = "Growth"
        '
        'Node23
        '
        Me.Node23.Expanded = True
        Me.Node23.Name = "Node23"
        Me.Node23.Style = Me.ElementStyle6
        Me.Node23.Text = "Ideas"
        '
        'Node7
        '
        Me.Node7.Expanded = True
        Me.Node7.Name = "Node7"
        Me.Node7.Nodes.AddRange(New DevComponents.Tree.Node() {Me.Node24, Me.Node25, Me.Node26})
        Me.Node7.Style = Me.ElementStyle7
        Me.Node7.Text = "White"
        '
        'Node24
        '
        Me.Node24.Expanded = True
        Me.Node24.Name = "Node24"
        Me.Node24.Style = Me.ElementStyle7
        Me.Node24.Text = "Facts"
        '
        'ElementStyle7
        '
        Me.ElementStyle7.Description = "White"
        Me.ElementStyle7.Name = "ElementStyle7"
        Me.ElementStyle7.TextColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(0, Byte))
        '
        'Node25
        '
        Me.Node25.Expanded = True
        Me.Node25.Name = "Node25"
        Me.Node25.Style = Me.ElementStyle7
        Me.Node25.Text = "Data"
        '
        'Node26
        '
        Me.Node26.Expanded = True
        Me.Node26.Name = "Node26"
        Me.Node26.Style = Me.ElementStyle7
        Me.Node26.Text = "Figures"
        '
        'NodeConnector2
        '
        Me.NodeConnector2.LineWidth = 5
        '
        'ElementStyle1
        '
        Me.ElementStyle1.BackColor2SchemePart = DevComponents.Tree.eColorSchemePart.BarBackground2
        Me.ElementStyle1.BackColorGradientAngle = 90
        Me.ElementStyle1.BackColorSchemePart = DevComponents.Tree.eColorSchemePart.BarBackground
        Me.ElementStyle1.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle1.BorderBottomWidth = 1
        Me.ElementStyle1.BorderColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder
        Me.ElementStyle1.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle1.BorderLeftWidth = 1
        Me.ElementStyle1.BorderRight = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle1.BorderRightWidth = 1
        Me.ElementStyle1.BorderTop = DevComponents.Tree.eStyleBorderType.Solid
        Me.ElementStyle1.BorderTopWidth = 1
        Me.ElementStyle1.CornerDiameter = 4
        Me.ElementStyle1.CornerType = DevComponents.Tree.eCornerType.Rounded
        Me.ElementStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ElementStyle1.Name = "ElementStyle1"
        Me.ElementStyle1.PaddingBottom = 3
        Me.ElementStyle1.PaddingLeft = 3
        Me.ElementStyle1.PaddingRight = 3
        Me.ElementStyle1.PaddingTop = 3
        Me.ElementStyle1.TextColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(128, Byte))
        '
        'NodeConnector1
        '
        Me.NodeConnector1.LineWidth = 5
        '
        'NodeConnector3
        '
        Me.NodeConnector3.LineColor = System.Drawing.Color.Goldenrod
        Me.NodeConnector3.LineWidth = 5
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.buttonPrint)
        Me.panel1.Controls.Add(Me.labelZoom)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.trackBar1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(512, 32)
        Me.panel1.TabIndex = 2
        '
        'buttonPrint
        '
        Me.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.buttonPrint.Location = New System.Drawing.Point(8, 5)
        Me.buttonPrint.Name = "buttonPrint"
        Me.buttonPrint.Size = New System.Drawing.Size(56, 22)
        Me.buttonPrint.TabIndex = 4
        Me.buttonPrint.Text = "Print"
        '
        'labelZoom
        '
        Me.labelZoom.Location = New System.Drawing.Point(184, 8)
        Me.labelZoom.Name = "labelZoom"
        Me.labelZoom.Size = New System.Drawing.Size(37, 15)
        Me.labelZoom.TabIndex = 2
        Me.labelZoom.Text = "100%"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(152, 7)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(37, 15)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Zoom: "
        '
        'trackBar1
        '
        Me.trackBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trackBar1.AutoSize = False
        Me.trackBar1.LargeChange = 50
        Me.trackBar1.Location = New System.Drawing.Point(224, 4)
        Me.trackBar1.Maximum = 400
        Me.trackBar1.Minimum = 20
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(280, 24)
        Me.trackBar1.SmallChange = 10
        Me.trackBar1.TabIndex = 0
        Me.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.trackBar1.Value = 100
        '
        'printPreviewDialog1
        '
        Me.printPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.printPreviewDialog1.Document = Me.printDocument1
        Me.printPreviewDialog1.Enabled = True
        Me.printPreviewDialog1.Icon = CType(resources.GetObject("printPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.printPreviewDialog1.Location = New System.Drawing.Point(30, 375)
        Me.printPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.printPreviewDialog1.Name = "printPreviewDialog1"
        Me.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.printPreviewDialog1.UseAntiAlias = True
        Me.printPreviewDialog1.Visible = False
        '
        'printDocument1
        '
        Me.printDocument1.OriginAtMargins = True
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Location = New System.Drawing.Point(72, 5)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(69, 22)
        Me.button1.TabIndex = 5
        Me.button1.Text = "Save Image"
        '
        'saveFileDialog1
        '
        Me.saveFileDialog1.DefaultExt = "png"
        Me.saveFileDialog1.Filter = "PNG Files | *.png"
        Me.saveFileDialog1.Title = "Save TreeGX control content to image"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 422)
        Me.Controls.Add(Me.TreeGX1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Form1"
        Me.Text = "Six Thinking Hats"
        CType(Me.TreeGX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub trackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBar1.ValueChanged
        TreeGX1.Zoom = trackBar1.Value / 100
        labelZoom.Text = trackBar1.Value.ToString() + "%"
    End Sub

    Private Sub buttonPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonPrint.Click
        printPreviewDialog1.Bounds = Me.Bounds
        printPreviewDialog1.ShowDialog()
    End Sub

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDocument1.PrintPage
        ' Center tree on the page
        Dim p As Point = New Point((e.PageBounds.Width - TreeGX1.TreeSize.Width) / 2, (e.PageBounds.Height - TreeGX1.TreeSize.Height) / 2)
        If p.X > 0 And p.Y > 0 Then
            e.Graphics.TranslateTransform(p.X, p.Y, MatrixOrder.Append)
        End If

        ' Perform actual rendering
        TreeGX1.PaintTo(e.Graphics, False, e.PageBounds)
    End Sub

    Private Sub Node5_MarkupLinkClick(ByVal sender As Object, ByVal e As DevComponents.Tree.MarkupLinkClickEventArgs) Handles Node5.MarkupLinkClick
        System.Diagnostics.Trace.WriteLine("MarkupLinkClick event. Link name: " + e.Name + " : href=" + e.HRef)
        If e.HRef.StartsWith("http://") Then System.Diagnostics.Process.Start(e.HRef)
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim bmp As Bitmap = New Bitmap(TreeGX1.TreeSize.Width, TreeGX1.TreeSize.Height)
            Dim g As Graphics = Graphics.FromImage(bmp)
            ' Perform actual rendering
            TreeGX1.PaintTo(g, True, Rectangle.Empty)
            g.Dispose()
            bmp.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png)
            bmp.Dispose()
        End If
    End Sub
End Class
