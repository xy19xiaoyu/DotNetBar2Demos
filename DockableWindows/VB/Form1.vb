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
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents barLeftDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barRightDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barTopDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barBottomDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents mainmenu As DevComponents.DotNetBar.Bar
    Friend WithEvents item_67 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_78 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_89 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_100 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_111 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_122 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_133 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_144 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_155 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_166 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_167 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_237 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_248 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_259 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_270 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_281 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_292 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_303 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bar4 As DevComponents.DotNetBar.Bar
    Friend WithEvents buttonNew As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_364 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_365 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_366 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_367 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_368 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_369 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_370 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_371 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_372 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_373 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_374 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_388 As DevComponents.DotNetBar.ComboBoxItem
    Friend WithEvents item_389 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_403 As DevComponents.DotNetBar.ComboBoxItem
    Friend WithEvents item_404 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_405 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_407 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_408 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bar2 As DevComponents.DotNetBar.Bar
    Friend WithEvents dTaskList As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents dOutput As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents PanelDockContainer1 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents PanelDockContainer2 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents barSolutionExplorer As DevComponents.DotNetBar.Bar
    Friend WithEvents dSolutionExplorer As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents dSolutionProperties As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents PanelDockContainer3 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents PanelDockContainer4 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents listView1 As System.Windows.Forms.ListView
    Friend WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents columnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents columnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents item_283 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_284 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_285 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents PropertyGrid1 As System.Windows.Forms.PropertyGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.barBottomDockSite = New DevComponents.DotNetBar.DockSite()
        Me.bar2 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer2 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PanelDockContainer1 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.columnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.columnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.columnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.columnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.dTaskList = New DevComponents.DotNetBar.DockContainerItem()
        Me.dOutput = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.barLeftDockSite = New DevComponents.DotNetBar.DockSite()
        Me.barRightDockSite = New DevComponents.DotNetBar.DockSite()
        Me.barSolutionExplorer = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer3 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.bar1 = New DevComponents.DotNetBar.Bar()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.item_283 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_284 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_285 = New DevComponents.DotNetBar.ButtonItem()
        Me.PanelDockContainer4 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.dSolutionExplorer = New DevComponents.DotNetBar.DockContainerItem()
        Me.dSolutionProperties = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.mainmenu = New DevComponents.DotNetBar.Bar()
        Me.item_67 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_78 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_89 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_100 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_111 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_122 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_133 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_144 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_155 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_166 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_167 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_237 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_248 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_259 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_270 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_281 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_292 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_303 = New DevComponents.DotNetBar.ButtonItem()
        Me.bar4 = New DevComponents.DotNetBar.Bar()
        Me.buttonNew = New DevComponents.DotNetBar.ButtonItem()
        Me.item_364 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_365 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_366 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_367 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_368 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_369 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_370 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_371 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_372 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_373 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_374 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_388 = New DevComponents.DotNetBar.ComboBoxItem()
        Me.item_389 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_403 = New DevComponents.DotNetBar.ComboBoxItem()
        Me.item_404 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_405 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_407 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_408 = New DevComponents.DotNetBar.ButtonItem()
        Me.barTopDockSite = New DevComponents.DotNetBar.DockSite()
        Me.barBottomDockSite.SuspendLayout()
        CType(Me.bar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bar2.SuspendLayout()
        Me.PanelDockContainer2.SuspendLayout()
        Me.PanelDockContainer1.SuspendLayout()
        Me.barRightDockSite.SuspendLayout()
        CType(Me.barSolutionExplorer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barSolutionExplorer.SuspendLayout()
        Me.PanelDockContainer3.SuspendLayout()
        CType(Me.bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDockContainer4.SuspendLayout()
        Me.DockSite4.SuspendLayout()
        CType(Me.mainmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DotNetBarManager1
        '
        Me.DotNetBarManager1.BottomDockSite = Me.barBottomDockSite
        Me.DotNetBarManager1.DefinitionName = ""
        Me.DotNetBarManager1.FillDockSite = Me.DockSite1
        Me.DotNetBarManager1.Images = Me.imageList1
        Me.DotNetBarManager1.LeftDockSite = Me.barLeftDockSite
        Me.DotNetBarManager1.ParentForm = Me
        Me.DotNetBarManager1.RightDockSite = Me.barRightDockSite
        Me.DotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.DotNetBarManager1.ToolbarBottomDockSite = Me.DockSite5
        Me.DotNetBarManager1.ToolbarLeftDockSite = Me.DockSite2
        Me.DotNetBarManager1.ToolbarRightDockSite = Me.DockSite3
        Me.DotNetBarManager1.ToolbarTopDockSite = Me.DockSite4
        Me.DotNetBarManager1.TopDockSite = Me.barTopDockSite
        '
        'barBottomDockSite
        '
        Me.barBottomDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barBottomDockSite.Controls.AddRange(New System.Windows.Forms.Control() {Me.bar2})
        Me.barBottomDockSite.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barBottomDockSite.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {New DevComponents.DotNetBar.DocumentBarContainer(Me.bar2, 591, 117)}, DevComponents.DotNetBar.eOrientation.Vertical)
        Me.barBottomDockSite.Location = New System.Drawing.Point(0, 269)
        Me.barBottomDockSite.Name = "barBottomDockSite"
        Me.barBottomDockSite.Size = New System.Drawing.Size(591, 120)
        Me.barBottomDockSite.TabIndex = 4
        Me.barBottomDockSite.TabStop = False
        '
        'bar2
        '
        Me.bar2.AccessibleDescription = "DotNetBar Bar (bar2)"
        Me.bar2.AccessibleName = "DotNetBar Bar"
        Me.bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.bar2.AutoHideAnimationTime = 0
        Me.bar2.AutoSyncBarCaption = True
        Me.bar2.CanDockTop = False
        Me.bar2.CloseSingleTab = True
        Me.bar2.Controls.AddRange(New System.Windows.Forms.Control() {Me.PanelDockContainer2, Me.PanelDockContainer1})
        Me.bar2.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption
        Me.bar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.dTaskList, Me.dOutput})
        Me.bar2.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.bar2.Location = New System.Drawing.Point(0, 3)
        Me.bar2.Name = "bar2"
        Me.bar2.SelectedDockTab = 1
        Me.bar2.Size = New System.Drawing.Size(591, 117)
        Me.bar2.Stretch = True
        Me.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.bar2.TabIndex = 0
        Me.bar2.TabStop = False
        Me.bar2.Text = "Output"
        '
        'PanelDockContainer2
        '
        Me.PanelDockContainer2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.PanelDockContainer2.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox1})
        Me.PanelDockContainer2.Location = New System.Drawing.Point(3, 23)
        Me.PanelDockContainer2.Name = "PanelDockContainer2"
        Me.PanelDockContainer2.Size = New System.Drawing.Size(585, 66)
        Me.PanelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.PanelDockContainer2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer2.Style.GradientAngle = 90
        Me.PanelDockContainer2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(585, 66)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'PanelDockContainer1
        '
        Me.PanelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.PanelDockContainer1.Controls.AddRange(New System.Windows.Forms.Control() {Me.listView1})
        Me.PanelDockContainer1.Location = New System.Drawing.Point(3, 23)
        Me.PanelDockContainer1.Name = "PanelDockContainer1"
        Me.PanelDockContainer1.Size = New System.Drawing.Size(585, 66)
        Me.PanelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.PanelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer1.Style.GradientAngle = 90
        Me.PanelDockContainer1.TabIndex = 1
        '
        'listView1
        '
        Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader3, Me.columnHeader4})
        Me.listView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(585, 66)
        Me.listView1.TabIndex = 3
        Me.listView1.View = System.Windows.Forms.View.Details
        '
        'columnHeader1
        '
        Me.columnHeader1.Text = "!"
        Me.columnHeader1.Width = 18
        '
        'columnHeader2
        '
        Me.columnHeader2.Text = ""
        Me.columnHeader2.Width = 18
        '
        'columnHeader3
        '
        Me.columnHeader3.Text = "Description"
        Me.columnHeader3.Width = 128
        '
        'columnHeader4
        '
        Me.columnHeader4.Text = "File"
        Me.columnHeader4.Width = 256
        '
        'dTaskList
        '
        Me.dTaskList.Control = Me.PanelDockContainer1
        Me.dTaskList.GlobalItem = True
        Me.dTaskList.GlobalName = "dTaskList"
        Me.dTaskList.Name = "dTaskList"
        Me.dTaskList.Text = "Task List"
        '
        'dOutput
        '
        Me.dOutput.Control = Me.PanelDockContainer2
        Me.dOutput.GlobalItem = True
        Me.dOutput.GlobalName = "dOutput"
        Me.dOutput.Name = "dOutput"
        Me.dOutput.Text = "Output"
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.Location = New System.Drawing.Point(0, 50)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(445, 219)
        Me.DockSite1.TabIndex = 6
        Me.DockSite1.TabStop = False
        '
        'imageList1
        '
        Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
        '
        'barLeftDockSite
        '
        Me.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left
        Me.barLeftDockSite.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.barLeftDockSite.Location = New System.Drawing.Point(0, 50)
        Me.barLeftDockSite.Name = "barLeftDockSite"
        Me.barLeftDockSite.Size = New System.Drawing.Size(0, 219)
        Me.barLeftDockSite.TabIndex = 1
        Me.barLeftDockSite.TabStop = False
        '
        'barRightDockSite
        '
        Me.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barRightDockSite.Controls.AddRange(New System.Windows.Forms.Control() {Me.barSolutionExplorer})
        Me.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right
        Me.barRightDockSite.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {New DevComponents.DotNetBar.DocumentBarContainer(Me.barSolutionExplorer, 143, 219)}, DevComponents.DotNetBar.eOrientation.Horizontal)
        Me.barRightDockSite.Location = New System.Drawing.Point(445, 50)
        Me.barRightDockSite.Name = "barRightDockSite"
        Me.barRightDockSite.Size = New System.Drawing.Size(146, 219)
        Me.barRightDockSite.TabIndex = 2
        Me.barRightDockSite.TabStop = False
        '
        'barSolutionExplorer
        '
        Me.barSolutionExplorer.AccessibleDescription = "DotNetBar Bar (barSolutionExplorer)"
        Me.barSolutionExplorer.AccessibleName = "DotNetBar Bar"
        Me.barSolutionExplorer.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.barSolutionExplorer.AutoHideAnimationTime = 0
        Me.barSolutionExplorer.AutoSyncBarCaption = True
        Me.barSolutionExplorer.CanDockTop = False
        Me.barSolutionExplorer.CanHide = True
        Me.barSolutionExplorer.CloseSingleTab = True
        Me.barSolutionExplorer.Controls.AddRange(New System.Windows.Forms.Control() {Me.PanelDockContainer3, Me.PanelDockContainer4})
        Me.barSolutionExplorer.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption
        Me.barSolutionExplorer.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.dSolutionExplorer, Me.dSolutionProperties})
        Me.barSolutionExplorer.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.barSolutionExplorer.Location = New System.Drawing.Point(3, 0)
        Me.barSolutionExplorer.Name = "barSolutionExplorer"
        Me.barSolutionExplorer.SelectedDockTab = 0
        Me.barSolutionExplorer.Size = New System.Drawing.Size(143, 219)
        Me.barSolutionExplorer.Stretch = True
        Me.barSolutionExplorer.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.barSolutionExplorer.TabIndex = 0
        Me.barSolutionExplorer.TabStop = False
        Me.barSolutionExplorer.Text = "Solution Explorer"
        '
        'PanelDockContainer3
        '
        Me.PanelDockContainer3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.PanelDockContainer3.Controls.AddRange(New System.Windows.Forms.Control() {Me.TreeView1, Me.bar1})
        Me.PanelDockContainer3.Location = New System.Drawing.Point(3, 23)
        Me.PanelDockContainer3.Name = "PanelDockContainer3"
        Me.PanelDockContainer3.Size = New System.Drawing.Size(137, 168)
        Me.PanelDockContainer3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.PanelDockContainer3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer3.Style.GradientAngle = 90
        Me.PanelDockContainer3.TabIndex = 1
        '
        'TreeView1
        '
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.ImageList = Me.imageList1
        Me.TreeView1.Location = New System.Drawing.Point(0, 25)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(137, 143)
        Me.TreeView1.TabIndex = 5
        '
        'bar1
        '
        Me.bar1.AccessibleDescription = "Solution Explorer Commands (bar1)"
        Me.bar1.AccessibleName = "Solution Explorer Commands"
        Me.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.bar1.Images = Me.ImageList2
        Me.bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.item_283, Me.item_284, Me.item_285})
        Me.bar1.Name = "bar1"
        Me.bar1.Size = New System.Drawing.Size(137, 25)
        Me.bar1.Stretch = True
        Me.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.bar1.TabIndex = 6
        Me.bar1.TabStop = False
        Me.bar1.Text = "Solution Explorer Commands"
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Magenta
        '
        'item_283
        '
        Me.item_283.GlobalName = "item_283"
        Me.item_283.ImageIndex = 0
        Me.item_283.ImagePaddingHorizontal = 8
        Me.item_283.Name = "item_283"
        Me.item_283.Text = "Refresh"
        '
        'item_284
        '
        Me.item_284.BeginGroup = True
        Me.item_284.GlobalName = "item_284"
        Me.item_284.ImageIndex = 1
        Me.item_284.ImagePaddingHorizontal = 8
        Me.item_284.Name = "item_284"
        Me.item_284.Text = "Show all Files"
        '
        'item_285
        '
        Me.item_285.BeginGroup = True
        Me.item_285.GlobalName = "item_285"
        Me.item_285.ImageIndex = 2
        Me.item_285.ImagePaddingHorizontal = 8
        Me.item_285.Name = "item_285"
        Me.item_285.Text = "Properties"
        '
        'PanelDockContainer4
        '
        Me.PanelDockContainer4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.PanelDockContainer4.Controls.AddRange(New System.Windows.Forms.Control() {Me.PropertyGrid1})
        Me.PanelDockContainer4.Location = New System.Drawing.Point(3, 23)
        Me.PanelDockContainer4.Name = "PanelDockContainer4"
        Me.PanelDockContainer4.Size = New System.Drawing.Size(137, 168)
        Me.PanelDockContainer4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.PanelDockContainer4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer4.Style.GradientAngle = 90
        Me.PanelDockContainer4.TabIndex = 2
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.CommandsVisibleIfAvailable = True
        Me.PropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyGrid1.LargeButtons = False
        Me.PropertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.SelectedObject = Me.PropertyGrid1
        Me.PropertyGrid1.Size = New System.Drawing.Size(137, 168)
        Me.PropertyGrid1.TabIndex = 1
        Me.PropertyGrid1.Text = "PropertyGrid1"
        Me.PropertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window
        Me.PropertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText
        '
        'dSolutionExplorer
        '
        Me.dSolutionExplorer.Control = Me.PanelDockContainer3
        Me.dSolutionExplorer.GlobalItem = True
        Me.dSolutionExplorer.GlobalName = "dSolutionExplorer"
        Me.dSolutionExplorer.ImageIndex = 0
        Me.dSolutionExplorer.Name = "dSolutionExplorer"
        Me.dSolutionExplorer.Text = "Solution Explorer"
        '
        'dSolutionProperties
        '
        Me.dSolutionProperties.Control = Me.PanelDockContainer4
        Me.dSolutionProperties.GlobalItem = True
        Me.dSolutionProperties.GlobalName = "dSolutionProperties"
        Me.dSolutionProperties.ImageIndex = 1
        Me.dSolutionProperties.Name = "dSolutionProperties"
        Me.dSolutionProperties.Text = "Properties"
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite5.Location = New System.Drawing.Point(0, 389)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(591, 0)
        Me.DockSite5.TabIndex = 11
        Me.DockSite5.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite2.Location = New System.Drawing.Point(0, 50)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 339)
        Me.DockSite2.TabIndex = 8
        Me.DockSite2.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite3.Location = New System.Drawing.Point(591, 50)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(0, 339)
        Me.DockSite3.TabIndex = 9
        Me.DockSite3.TabStop = False
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Controls.AddRange(New System.Windows.Forms.Control() {Me.mainmenu, Me.bar4})
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(591, 50)
        Me.DockSite4.TabIndex = 10
        Me.DockSite4.TabStop = False
        '
        'mainmenu
        '
        Me.mainmenu.AccessibleDescription = "DotNetBar Bar (mainmenu)"
        Me.mainmenu.AccessibleName = "DotNetBar Bar"
        Me.mainmenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.mainmenu.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me.mainmenu.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.item_67, Me.item_167})
        Me.mainmenu.LockDockPosition = True
        Me.mainmenu.MenuBar = True
        Me.mainmenu.Name = "mainmenu"
        Me.mainmenu.Size = New System.Drawing.Size(591, 24)
        Me.mainmenu.Stretch = True
        Me.mainmenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.mainmenu.TabIndex = 0
        Me.mainmenu.TabStop = False
        Me.mainmenu.Text = "Main Menu"
        '
        'item_67
        '
        Me.item_67.GlobalName = "item_67"
        Me.item_67.ImagePaddingHorizontal = 8
        Me.item_67.Name = "item_67"
        Me.item_67.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.item_78, Me.item_89, Me.item_100, Me.item_111, Me.item_122, Me.item_133, Me.item_144, Me.item_155, Me.item_166})
        Me.item_67.Text = "&File"
        '
        'item_78
        '
        Me.item_78.GlobalName = "item_78"
        Me.item_78.ImagePaddingHorizontal = 8
        Me.item_78.Name = "item_78"
        Me.item_78.Text = "&New"
        '
        'item_89
        '
        Me.item_89.GlobalName = "item_89"
        Me.item_89.ImageIndex = 10
        Me.item_89.ImagePaddingHorizontal = 8
        Me.item_89.Name = "item_89"
        Me.item_89.Text = "&Open"
        '
        'item_100
        '
        Me.item_100.GlobalName = "item_100"
        Me.item_100.ImagePaddingHorizontal = 8
        Me.item_100.Name = "item_100"
        Me.item_100.Text = "&Close"
        '
        'item_111
        '
        Me.item_111.BeginGroup = True
        Me.item_111.GlobalName = "item_111"
        Me.item_111.ImagePaddingHorizontal = 8
        Me.item_111.Name = "item_111"
        Me.item_111.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlShiftA)
        Me.item_111.Text = "Add Ne&w Item"
        '
        'item_122
        '
        Me.item_122.GlobalName = "item_122"
        Me.item_122.ImagePaddingHorizontal = 8
        Me.item_122.Name = "item_122"
        Me.item_122.Text = "Add Existin&g Item"
        '
        'item_133
        '
        Me.item_133.GlobalName = "item_133"
        Me.item_133.ImagePaddingHorizontal = 8
        Me.item_133.Name = "item_133"
        Me.item_133.Text = "A&dd Project"
        '
        'item_144
        '
        Me.item_144.BeginGroup = True
        Me.item_144.GlobalName = "item_144"
        Me.item_144.ImagePaddingHorizontal = 8
        Me.item_144.Name = "item_144"
        Me.item_144.Text = "Open Solution"
        '
        'item_155
        '
        Me.item_155.GlobalName = "item_155"
        Me.item_155.ImagePaddingHorizontal = 8
        Me.item_155.Name = "item_155"
        Me.item_155.Text = "Close Solution"
        '
        'item_166
        '
        Me.item_166.BeginGroup = True
        Me.item_166.GlobalName = "item_166"
        Me.item_166.ImagePaddingHorizontal = 8
        Me.item_166.Name = "item_166"
        Me.item_166.Text = "&Exit"
        '
        'item_167
        '
        Me.item_167.GlobalName = "item_167"
        Me.item_167.ImagePaddingHorizontal = 8
        Me.item_167.Name = "item_167"
        Me.item_167.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.item_237, Me.item_248, Me.item_259, Me.item_270, Me.item_281, Me.item_292, Me.item_303})
        Me.item_167.Text = "&Edit"
        '
        'item_237
        '
        Me.item_237.GlobalName = "item_237"
        Me.item_237.ImagePaddingHorizontal = 8
        Me.item_237.Name = "item_237"
        Me.item_237.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ)
        Me.item_237.Text = "&Undo"
        '
        'item_248
        '
        Me.item_248.GlobalName = "item_248"
        Me.item_248.ImagePaddingHorizontal = 8
        Me.item_248.Name = "item_248"
        Me.item_248.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY)
        Me.item_248.Text = "&Redo"
        '
        'item_259
        '
        Me.item_259.BeginGroup = True
        Me.item_259.GlobalName = "item_259"
        Me.item_259.ImageIndex = 5
        Me.item_259.ImagePaddingHorizontal = 8
        Me.item_259.Name = "item_259"
        Me.item_259.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.item_259.Text = "Cut"
        '
        'item_270
        '
        Me.item_270.GlobalName = "item_270"
        Me.item_270.ImageIndex = 4
        Me.item_270.ImagePaddingHorizontal = 8
        Me.item_270.Name = "item_270"
        Me.item_270.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.item_270.Text = "Copy"
        '
        'item_281
        '
        Me.item_281.GlobalName = "item_281"
        Me.item_281.ImageIndex = 11
        Me.item_281.ImagePaddingHorizontal = 8
        Me.item_281.Name = "item_281"
        Me.item_281.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV)
        Me.item_281.Text = "Paste"
        '
        'item_292
        '
        Me.item_292.GlobalName = "item_292"
        Me.item_292.ImagePaddingHorizontal = 8
        Me.item_292.Name = "item_292"
        Me.item_292.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del)
        Me.item_292.Text = "Delete"
        '
        'item_303
        '
        Me.item_303.GlobalName = "item_303"
        Me.item_303.ImagePaddingHorizontal = 8
        Me.item_303.Name = "item_303"
        Me.item_303.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.item_303.Text = "Select All"
        '
        'bar4
        '
        Me.bar4.AccessibleDescription = "DotNetBar Bar (bar4)"
        Me.bar4.AccessibleName = "DotNetBar Bar"
        Me.bar4.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.bar4.CanHide = True
        Me.bar4.DockLine = 1
        Me.bar4.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me.bar4.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.bar4.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonNew, Me.item_364, Me.item_365, Me.item_366, Me.item_367, Me.item_368, Me.item_369, Me.item_370, Me.item_371, Me.item_372, Me.item_373, Me.item_374, Me.item_388, Me.item_389, Me.item_403, Me.item_404, Me.item_405, Me.item_407, Me.item_408})
        Me.bar4.Location = New System.Drawing.Point(0, 25)
        Me.bar4.Name = "bar4"
        Me.bar4.Size = New System.Drawing.Size(591, 25)
        Me.bar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.bar4.TabIndex = 1
        Me.bar4.TabStop = False
        Me.bar4.Text = "Commands"
        '
        'buttonNew
        '
        Me.buttonNew.GlobalName = "buttonNew"
        Me.buttonNew.Image = CType(resources.GetObject("buttonNew.Image"), System.Drawing.Bitmap)
        Me.buttonNew.ImagePaddingHorizontal = 8
        Me.buttonNew.Name = "buttonNew"
        Me.buttonNew.Text = "New"
        '
        'item_364
        '
        Me.item_364.GlobalName = "item_364"
        Me.item_364.ImageIndex = 9
        Me.item_364.ImagePaddingHorizontal = 8
        Me.item_364.Name = "item_364"
        Me.item_364.Text = "New Project"
        '
        'item_365
        '
        Me.item_365.GlobalName = "item_365"
        Me.item_365.ImageIndex = 2
        Me.item_365.ImagePaddingHorizontal = 8
        Me.item_365.Name = "item_365"
        Me.item_365.Text = "Add To Project"
        '
        'item_366
        '
        Me.item_366.GlobalName = "item_366"
        Me.item_366.ImageIndex = 10
        Me.item_366.ImagePaddingHorizontal = 8
        Me.item_366.Name = "item_366"
        Me.item_366.Text = "Open File"
        '
        'item_367
        '
        Me.item_367.DisabledImage = CType(resources.GetObject("item_367.DisabledImage"), System.Drawing.Bitmap)
        Me.item_367.Enabled = False
        Me.item_367.GlobalName = "item_367"
        Me.item_367.ImageIndex = 12
        Me.item_367.ImagePaddingHorizontal = 8
        Me.item_367.Name = "item_367"
        Me.item_367.Text = "Save"
        '
        'item_368
        '
        Me.item_368.DisabledImage = CType(resources.GetObject("item_368.DisabledImage"), System.Drawing.Bitmap)
        Me.item_368.Enabled = False
        Me.item_368.GlobalName = "item_368"
        Me.item_368.ImageIndex = 13
        Me.item_368.ImagePaddingHorizontal = 8
        Me.item_368.Name = "item_368"
        Me.item_368.Text = "Save All"
        '
        'item_369
        '
        Me.item_369.BeginGroup = True
        Me.item_369.GlobalName = "item_369"
        Me.item_369.ImageIndex = 5
        Me.item_369.ImagePaddingHorizontal = 8
        Me.item_369.Name = "item_369"
        Me.item_369.Text = "Cut"
        '
        'item_370
        '
        Me.item_370.GlobalName = "item_370"
        Me.item_370.ImageIndex = 4
        Me.item_370.ImagePaddingHorizontal = 8
        Me.item_370.Name = "item_370"
        Me.item_370.Text = "Copy"
        '
        'item_371
        '
        Me.item_371.DisabledImage = CType(resources.GetObject("item_371.DisabledImage"), System.Drawing.Bitmap)
        Me.item_371.Enabled = False
        Me.item_371.GlobalName = "item_371"
        Me.item_371.ImageIndex = 11
        Me.item_371.ImagePaddingHorizontal = 8
        Me.item_371.Name = "item_371"
        Me.item_371.Text = "Paste"
        '
        'item_372
        '
        Me.item_372.BeginGroup = True
        Me.item_372.GlobalName = "item_372"
        Me.item_372.ImageIndex = 7
        Me.item_372.ImagePaddingHorizontal = 8
        Me.item_372.Name = "item_372"
        Me.item_372.Text = "Navigate Backwards"
        '
        'item_373
        '
        Me.item_373.DisabledImage = CType(resources.GetObject("item_373.DisabledImage"), System.Drawing.Bitmap)
        Me.item_373.Enabled = False
        Me.item_373.GlobalName = "item_373"
        Me.item_373.ImageIndex = 8
        Me.item_373.ImagePaddingHorizontal = 8
        Me.item_373.Name = "item_373"
        Me.item_373.Text = "Navigate Forwards"
        '
        'item_374
        '
        Me.item_374.BeginGroup = True
        Me.item_374.GlobalName = "item_374"
        Me.item_374.ImageIndex = 15
        Me.item_374.ImagePaddingHorizontal = 8
        Me.item_374.Name = "item_374"
        Me.item_374.Text = "Run Project"
        '
        'item_388
        '
        Me.item_388.ComboWidth = 72
        Me.item_388.GlobalName = "item_388"
        Me.item_388.ItemHeight = 14
        Me.item_388.Name = "item_388"
        Me.item_388.Text = "Run Mode"
        '
        'item_389
        '
        Me.item_389.BeginGroup = True
        Me.item_389.GlobalName = "item_389"
        Me.item_389.ImageIndex = 6
        Me.item_389.ImagePaddingHorizontal = 8
        Me.item_389.Name = "item_389"
        Me.item_389.Text = "Find in Files"
        '
        'item_403
        '
        Me.item_403.ComboWidth = 128
        Me.item_403.GlobalName = "item_403"
        Me.item_403.ItemHeight = 14
        Me.item_403.Name = "item_403"
        Me.item_403.Text = "Search Text"
        '
        'item_404
        '
        Me.item_404.BeginGroup = True
        Me.item_404.GlobalName = "item_404"
        Me.item_404.ImageIndex = 0
        Me.item_404.ImagePaddingHorizontal = 8
        Me.item_404.Name = "item_404"
        Me.item_404.Text = "Project Explorer"
        '
        'item_405
        '
        Me.item_405.GlobalName = "item_405"
        Me.item_405.ImageIndex = 1
        Me.item_405.ImagePaddingHorizontal = 8
        Me.item_405.Name = "item_405"
        Me.item_405.Text = "Project Properties"
        '
        'item_407
        '
        Me.item_407.GlobalName = "item_407"
        Me.item_407.ImageIndex = 16
        Me.item_407.ImagePaddingHorizontal = 8
        Me.item_407.Name = "item_407"
        Me.item_407.Text = "Toolbox"
        '
        'item_408
        '
        Me.item_408.GlobalName = "item_408"
        Me.item_408.ImageIndex = 3
        Me.item_408.ImagePaddingHorizontal = 8
        Me.item_408.Name = "item_408"
        Me.item_408.Text = "Class View"
        '
        'barTopDockSite
        '
        Me.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top
        Me.barTopDockSite.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.barTopDockSite.Location = New System.Drawing.Point(0, 50)
        Me.barTopDockSite.Name = "barTopDockSite"
        Me.barTopDockSite.Size = New System.Drawing.Size(591, 0)
        Me.barTopDockSite.TabIndex = 3
        Me.barTopDockSite.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(591, 389)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.DockSite1, Me.barLeftDockSite, Me.barRightDockSite, Me.barTopDockSite, Me.barBottomDockSite, Me.DockSite2, Me.DockSite3, Me.DockSite4, Me.DockSite5})
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.barBottomDockSite.ResumeLayout(False)
        CType(Me.bar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bar2.ResumeLayout(False)
        Me.PanelDockContainer2.ResumeLayout(False)
        Me.PanelDockContainer1.ResumeLayout(False)
        Me.barRightDockSite.ResumeLayout(False)
        CType(Me.barSolutionExplorer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barSolutionExplorer.ResumeLayout(False)
        Me.PanelDockContainer3.ResumeLayout(False)
        CType(Me.bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDockContainer4.ResumeLayout(False)
        Me.DockSite4.ResumeLayout(False)
        CType(Me.mainmenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim documentCount As Int32 = 0
    Dim uniqueBarCount As Int32 = 0

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bar As Bar = BarUtilities.CreateDocumentBar()
        uniqueBarCount += 1
        bar.Name = "barDocuments" + uniqueBarCount.ToString()
        AddHandler bar.DockTabClosing, AddressOf DocumentBar_DockTabClosing
        DockSite1.GetDocumentUIManager().Dock(bar)
        CreateNewDocument()
    End Sub

    Private Sub CreateNewDocument()
        ' Create new DockContainerItem with the edit control and add it to the barDocuments
        documentCount = documentCount + 1
        Dim document As DockContainerItem = New DockContainerItem("docDock" + documentCount.ToString(), "Document [" + documentCount.ToString() + "]")
        ' Create control to host inside of new document
        document.Control = CreateNewDocumentControl()
        Dim bar As Bar = GetFirstDocumentBar()
        bar.Items.Add(document)
        If Not bar.Visible Then bar.Visible = True
        bar.SelectedDockTab = bar.Items.IndexOf(document)
        bar.RecalcLayout()
    End Sub

    Private Function GetFirstDocumentBar() As Bar
        Dim b As Bar
        For Each b In DotNetBarManager1.Bars
            If b.DockSide = eDockSide.Document And b.Visible Then
                Return b
            End If
        Next

        ' If no documents bars found, create new one
        uniqueBarCount += 1
        Dim bar As Bar = BarUtilities.CreateDocumentBar()
        AddHandler bar.DockTabClosing, AddressOf DocumentBar_DockTabClosing
        bar.Name = "barDocuments" + uniqueBarCount.ToString()
        DockSite1.GetDocumentUIManager().Dock(bar)
        Return bar
    End Function

    Private Function CreateNewDocumentControl() As Control
        Dim txt As TextBox = New TextBox()
        txt.Multiline = True
        txt.ScrollBars = ScrollBars.Vertical
        txt.AutoSize = False
        Return txt
    End Function

    Private Sub DocumentBar_DockTabClosing(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.DockTabClosingEventArgs)
        ' In this event you save any changes to the active document or cancel the closing...
        ' e.DockContainerItem returns the reference to the item being closed
        ' Set e.Cancel to true to cancel the closing
        ' Set e.RemoveDockTab to true to automatically remove the closed tab from Bar.Items collection
        e.RemoveDockTab = True

        Dim b As Bar = CType(sender, Bar)

        If b.Items.Count = 1 Then
            ' Remove bar as well if last item is closed...
            DotNetBarManager1.Bars.Remove(b)
        End If

    End Sub

    Private Sub DotNetBarManager1_BarTearOff(ByVal sender As Object, ByVal e As System.EventArgs) Handles DotNetBarManager1.BarTearOff
        Dim b As Bar = CType(sender, Bar)
        AddHandler b.DockTabClosing, AddressOf DocumentBar_DockTabClosing
    End Sub

    Private Sub DotNetBarManager1_ItemClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DotNetBarManager1.ItemClick
        Dim item As BaseItem = CType(sender, BaseItem)

        If item.Name = "buttonNew" Then
            CreateNewDocument()
        End If

    End Sub
End Class
