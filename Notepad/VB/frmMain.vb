Imports DevComponents.DotNetBar
Public Class frmMain
    Inherits System.Windows.Forms.Form

    Private WithEvents m_CheckStyle As CheckBox
    Private WithEvents m_CheckTaskShowStartup As CheckBox

    Private m_Search As BalloonSearch
    Private m_InfoBalloon As Balloon

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
    Friend WithEvents barLeftDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barRightDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barTopDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barBottomDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents dotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents saveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tabStrip1 As DevComponents.DotNetBar.TabStrip
    Friend WithEvents timerInfoBallon As System.Windows.Forms.Timer
    Friend WithEvents labelStatus As DevComponents.DotNetBar.LabelItem
    Friend WithEvents labelPosition As DevComponents.DotNetBar.LabelItem
    Friend WithEvents itemProgressBar As DevComponents.DotNetBar.ProgressBarItem
    Private WithEvents barStatus As DevComponents.DotNetBar.Bar
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents mainmenu As DevComponents.DotNetBar.Bar
    Friend WithEvents bFile As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bNew As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bOpen As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bClose As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bSave As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bSaveAs As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bPageSetup As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bPrintPreview As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bPrint As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bExit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bEdit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bFormat As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bWindow As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bNewWindow As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bArrangeAll As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_236 As DevComponents.DotNetBar.MdiWindowListItem
    Friend WithEvents bHelp As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bAbout As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bChangeStyle As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bStyle2003 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bVS2005 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bStyleXP As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bStyle2007Blue As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents standard As DevComponents.DotNetBar.Bar
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bThemes As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bTabbedMdi As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_139 As DevComponents.DotNetBar.CustomizeItem
    Friend WithEvents edit As DevComponents.DotNetBar.Bar
    Friend WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_140 As DevComponents.DotNetBar.CustomizeItem
    Friend WithEvents format As DevComponents.DotNetBar.Bar
    Friend WithEvents ButtonItem11 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem12 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem13 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem14 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem15 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem16 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem17 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem18 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_141 As DevComponents.DotNetBar.CustomizeItem
    Friend WithEvents barTaskList As DevComponents.DotNetBar.Bar
    Friend WithEvents dockTaskList As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents dockSearchResults As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents PanelDockContainer1 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents PanelDockContainer2 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents windowlist As DevComponents.DotNetBar.Bar
    Friend WithEvents item_162 As DevComponents.DotNetBar.MdiWindowListItem
    Friend WithEvents barTaskPane As DevComponents.DotNetBar.Bar
    Friend WithEvents TaskPane1 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents TaskPane2 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents PanelDockContainer3 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents PanelDockContainer4 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents bEditPopup As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem19 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem20 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem21 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem22 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bTaskListMenu As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_477 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_504 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_531 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bTabContext As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bTabColor As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bDockContext As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents explorerBar1 As DevComponents.DotNetBar.ExplorerBar
    Friend WithEvents explorerBarGroupItem1 As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents ButtonItem25 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem26 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem27 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents explorerBarGroupItem2 As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents ButtonItem28 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem29 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem30 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem31 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents listBox1 As System.Windows.Forms.ListBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Public WithEvents bUndo As DevComponents.DotNetBar.ButtonItem
    Public WithEvents bCut As DevComponents.DotNetBar.ButtonItem
    Public WithEvents bCopy As DevComponents.DotNetBar.ButtonItem
    Public WithEvents bPaste As DevComponents.DotNetBar.ButtonItem
    Public WithEvents bDelete As DevComponents.DotNetBar.ButtonItem
    Public WithEvents bSelectAll As DevComponents.DotNetBar.ButtonItem
    Public WithEvents bFind As DevComponents.DotNetBar.ButtonItem
    Public WithEvents bFindNext As DevComponents.DotNetBar.ButtonItem
    Public WithEvents bReplace As DevComponents.DotNetBar.ButtonItem
    Public WithEvents bBold As DevComponents.DotNetBar.ButtonItem
    Public WithEvents bItalic As DevComponents.DotNetBar.ButtonItem
    Public WithEvents bUnderline As DevComponents.DotNetBar.ButtonItem
    Public WithEvents bStrikethrough As DevComponents.DotNetBar.ButtonItem
    Public WithEvents bAlignLeft As DevComponents.DotNetBar.ButtonItem
    Public WithEvents bAlignCenter As DevComponents.DotNetBar.ButtonItem
    Public WithEvents bAlignRight As DevComponents.DotNetBar.ButtonItem
    Public WithEvents bTextColor As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdFind As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdContextSave As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmdContextClose As DevComponents.DotNetBar.ButtonItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "!", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "Description of some task")}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "", System.Drawing.SystemColors.WindowText, System.Drawing.Color.WhiteSmoke, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "Task sample number 2")}, -1)
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.dotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.barBottomDockSite = New DevComponents.DotNetBar.DockSite()
        Me.barTaskList = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer1 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.PanelDockContainer2 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dockTaskList = New DevComponents.DotNetBar.DockContainerItem()
        Me.dockSearchResults = New DevComponents.DotNetBar.DockContainerItem()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.barLeftDockSite = New DevComponents.DotNetBar.DockSite()
        Me.barRightDockSite = New DevComponents.DotNetBar.DockSite()
        Me.barTaskPane = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer4 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.explorerBar1 = New DevComponents.DotNetBar.ExplorerBar()
        Me.explorerBarGroupItem1 = New DevComponents.DotNetBar.ExplorerBarGroupItem()
        Me.ButtonItem25 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem26 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem27 = New DevComponents.DotNetBar.ButtonItem()
        Me.explorerBarGroupItem2 = New DevComponents.DotNetBar.ExplorerBarGroupItem()
        Me.ButtonItem28 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem29 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem30 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem31 = New DevComponents.DotNetBar.ButtonItem()
        Me.PanelDockContainer3 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.TaskPane1 = New DevComponents.DotNetBar.DockContainerItem()
        Me.TaskPane2 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.windowlist = New DevComponents.DotNetBar.Bar()
        Me.item_162 = New DevComponents.DotNetBar.MdiWindowListItem()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.mainmenu = New DevComponents.DotNetBar.Bar()
        Me.bFile = New DevComponents.DotNetBar.ButtonItem()
        Me.bNew = New DevComponents.DotNetBar.ButtonItem()
        Me.bOpen = New DevComponents.DotNetBar.ButtonItem()
        Me.bClose = New DevComponents.DotNetBar.ButtonItem()
        Me.bSave = New DevComponents.DotNetBar.ButtonItem()
        Me.bSaveAs = New DevComponents.DotNetBar.ButtonItem()
        Me.bPageSetup = New DevComponents.DotNetBar.ButtonItem()
        Me.bPrintPreview = New DevComponents.DotNetBar.ButtonItem()
        Me.bPrint = New DevComponents.DotNetBar.ButtonItem()
        Me.bExit = New DevComponents.DotNetBar.ButtonItem()
        Me.bEdit = New DevComponents.DotNetBar.ButtonItem()
        Me.bUndo = New DevComponents.DotNetBar.ButtonItem()
        Me.bCut = New DevComponents.DotNetBar.ButtonItem()
        Me.bCopy = New DevComponents.DotNetBar.ButtonItem()
        Me.bPaste = New DevComponents.DotNetBar.ButtonItem()
        Me.bDelete = New DevComponents.DotNetBar.ButtonItem()
        Me.bSelectAll = New DevComponents.DotNetBar.ButtonItem()
        Me.bFind = New DevComponents.DotNetBar.ButtonItem()
        Me.bFindNext = New DevComponents.DotNetBar.ButtonItem()
        Me.bReplace = New DevComponents.DotNetBar.ButtonItem()
        Me.bFormat = New DevComponents.DotNetBar.ButtonItem()
        Me.bBold = New DevComponents.DotNetBar.ButtonItem()
        Me.bItalic = New DevComponents.DotNetBar.ButtonItem()
        Me.bUnderline = New DevComponents.DotNetBar.ButtonItem()
        Me.bStrikethrough = New DevComponents.DotNetBar.ButtonItem()
        Me.bAlignLeft = New DevComponents.DotNetBar.ButtonItem()
        Me.bAlignCenter = New DevComponents.DotNetBar.ButtonItem()
        Me.bAlignRight = New DevComponents.DotNetBar.ButtonItem()
        Me.bTextColor = New DevComponents.DotNetBar.ButtonItem()
        Me.bWindow = New DevComponents.DotNetBar.ButtonItem()
        Me.bNewWindow = New DevComponents.DotNetBar.ButtonItem()
        Me.bArrangeAll = New DevComponents.DotNetBar.ButtonItem()
        Me.item_236 = New DevComponents.DotNetBar.MdiWindowListItem()
        Me.bHelp = New DevComponents.DotNetBar.ButtonItem()
        Me.bAbout = New DevComponents.DotNetBar.ButtonItem()
        Me.bChangeStyle = New DevComponents.DotNetBar.ButtonItem()
        Me.bStyle2003 = New DevComponents.DotNetBar.ButtonItem()
        Me.bVS2005 = New DevComponents.DotNetBar.ButtonItem()
        Me.bStyleXP = New DevComponents.DotNetBar.ButtonItem()
        Me.bStyle2007Blue = New DevComponents.DotNetBar.ButtonItem()
        Me.standard = New DevComponents.DotNetBar.Bar()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.bThemes = New DevComponents.DotNetBar.ButtonItem()
        Me.bTabbedMdi = New DevComponents.DotNetBar.ButtonItem()
        Me.item_139 = New DevComponents.DotNetBar.CustomizeItem()
        Me.edit = New DevComponents.DotNetBar.Bar()
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdFind = New DevComponents.DotNetBar.ButtonItem()
        Me.item_140 = New DevComponents.DotNetBar.CustomizeItem()
        Me.format = New DevComponents.DotNetBar.Bar()
        Me.ButtonItem11 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem12 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem13 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem14 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem15 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem16 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem17 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem18 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_141 = New DevComponents.DotNetBar.CustomizeItem()
        Me.barTopDockSite = New DevComponents.DotNetBar.DockSite()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tabStrip1 = New DevComponents.DotNetBar.TabStrip()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timerInfoBallon = New System.Windows.Forms.Timer(Me.components)
        Me.barStatus = New DevComponents.DotNetBar.Bar()
        Me.labelStatus = New DevComponents.DotNetBar.LabelItem()
        Me.labelPosition = New DevComponents.DotNetBar.LabelItem()
        Me.itemProgressBar = New DevComponents.DotNetBar.ProgressBarItem()
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.bDockContext = New DevComponents.DotNetBar.ButtonItem()
        Me.bTabContext = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdContextSave = New DevComponents.DotNetBar.ButtonItem()
        Me.cmdContextClose = New DevComponents.DotNetBar.ButtonItem()
        Me.bTabColor = New DevComponents.DotNetBar.ButtonItem()
        Me.bEditPopup = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem19 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem20 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem21 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem22 = New DevComponents.DotNetBar.ButtonItem()
        Me.bTaskListMenu = New DevComponents.DotNetBar.ButtonItem()
        Me.item_477 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_504 = New DevComponents.DotNetBar.ButtonItem()
        Me.item_531 = New DevComponents.DotNetBar.ButtonItem()
        Me.barBottomDockSite.SuspendLayout()
        CType(Me.barTaskList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barTaskList.SuspendLayout()
        Me.PanelDockContainer1.SuspendLayout()
        Me.PanelDockContainer2.SuspendLayout()
        Me.barRightDockSite.SuspendLayout()
        CType(Me.barTaskPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barTaskPane.SuspendLayout()
        Me.PanelDockContainer4.SuspendLayout()
        CType(Me.explorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDockContainer3.SuspendLayout()
        Me.DockSite4.SuspendLayout()
        CType(Me.windowlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockSite3.SuspendLayout()
        CType(Me.mainmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.standard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.format, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dotNetBarManager1
        '
        Me.dotNetBarManager1.BottomDockSite = Me.barBottomDockSite
        Me.dotNetBarManager1.DefinitionName = ""
        Me.dotNetBarManager1.Images = Me.imageList1
        Me.dotNetBarManager1.LeftDockSite = Me.barLeftDockSite
        Me.dotNetBarManager1.MdiSystemItemVisible = False
        Me.dotNetBarManager1.ParentForm = Me
        Me.dotNetBarManager1.RightDockSite = Me.barRightDockSite
        Me.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.dotNetBarManager1.ToolbarBottomDockSite = Me.DockSite4
        Me.dotNetBarManager1.ToolbarLeftDockSite = Me.DockSite1
        Me.dotNetBarManager1.ToolbarRightDockSite = Me.DockSite2
        Me.dotNetBarManager1.ToolbarTopDockSite = Me.DockSite3
        Me.dotNetBarManager1.TopDockSite = Me.barTopDockSite
        '
        'barBottomDockSite
        '
        Me.barBottomDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barBottomDockSite.Controls.AddRange(New System.Windows.Forms.Control() {Me.barTaskList})
        Me.barBottomDockSite.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barBottomDockSite.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {New DevComponents.DotNetBar.DocumentBarContainer(Me.barTaskList, 704, 119)}, DevComponents.DotNetBar.eOrientation.Vertical)
        Me.barBottomDockSite.Location = New System.Drawing.Point(0, 343)
        Me.barBottomDockSite.Name = "barBottomDockSite"
        Me.barBottomDockSite.Size = New System.Drawing.Size(704, 122)
        Me.barBottomDockSite.TabIndex = 4
        Me.barBottomDockSite.TabStop = False
        '
        'barTaskList
        '
        Me.barTaskList.AccessibleDescription = "DotNetBar Bar (barTaskList)"
        Me.barTaskList.AccessibleName = "DotNetBar Bar"
        Me.barTaskList.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.barTaskList.CanCustomize = False
        Me.barTaskList.CanHide = True
        Me.ContextMenuBar1.SetContextMenuEx(Me.barTaskList, Me.bDockContext)
        Me.barTaskList.Controls.AddRange(New System.Windows.Forms.Control() {Me.PanelDockContainer1, Me.PanelDockContainer2})
        Me.barTaskList.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption
        Me.barTaskList.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.dockTaskList, Me.dockSearchResults})
        Me.barTaskList.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.barTaskList.Location = New System.Drawing.Point(0, 3)
        Me.barTaskList.Name = "barTaskList"
        Me.barTaskList.SelectedDockTab = 0
        Me.barTaskList.Size = New System.Drawing.Size(704, 119)
        Me.barTaskList.Stretch = True
        Me.barTaskList.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.barTaskList.TabIndex = 0
        Me.barTaskList.TabNavigation = True
        Me.barTaskList.TabStop = False
        Me.barTaskList.Text = "Dockable Window"
        '
        'PanelDockContainer1
        '
        Me.PanelDockContainer1.Controls.AddRange(New System.Windows.Forms.Control() {Me.ListView1})
        Me.PanelDockContainer1.Location = New System.Drawing.Point(3, 23)
        Me.PanelDockContainer1.Name = "PanelDockContainer1"
        Me.PanelDockContainer1.Size = New System.Drawing.Size(698, 68)
        Me.PanelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.PanelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer1.Style.GradientAngle = 90
        Me.PanelDockContainer1.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(698, 68)
        Me.ListView1.TabIndex = 1
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "!"
        Me.ColumnHeader1.Width = 16
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 105
        '
        'PanelDockContainer2
        '
        Me.PanelDockContainer2.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox1})
        Me.PanelDockContainer2.Location = New System.Drawing.Point(3, 23)
        Me.PanelDockContainer2.Name = "PanelDockContainer2"
        Me.PanelDockContainer2.Size = New System.Drawing.Size(698, 68)
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
        Me.TextBox1.AutoSize = False
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(698, 68)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'dockTaskList
        '
        Me.dockTaskList.Control = Me.PanelDockContainer1
        Me.dockTaskList.DefaultFloatingSize = New System.Drawing.Size(256, 196)
        Me.dockTaskList.GlobalItem = True
        Me.dockTaskList.GlobalName = "dockTaskList"
        Me.dockTaskList.Image = CType(resources.GetObject("dockTaskList.Image"), System.Drawing.Bitmap)
        Me.dockTaskList.MinimumSize = New System.Drawing.Size(64, 64)
        Me.dockTaskList.Name = "dockTaskList"
        Me.dockTaskList.Text = "Task ListView"
        '
        'dockSearchResults
        '
        Me.dockSearchResults.Control = Me.PanelDockContainer2
        Me.dockSearchResults.DefaultFloatingSize = New System.Drawing.Size(256, 196)
        Me.dockSearchResults.GlobalItem = True
        Me.dockSearchResults.GlobalName = "dockSearchResults"
        Me.dockSearchResults.Image = CType(resources.GetObject("dockSearchResults.Image"), System.Drawing.Bitmap)
        Me.dockSearchResults.MinimumSize = New System.Drawing.Size(64, 64)
        Me.dockSearchResults.Name = "dockSearchResults"
        Me.dockSearchResults.Text = "Search Results"
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
        Me.barLeftDockSite.Location = New System.Drawing.Point(0, 76)
        Me.barLeftDockSite.Name = "barLeftDockSite"
        Me.barLeftDockSite.Size = New System.Drawing.Size(0, 267)
        Me.barLeftDockSite.TabIndex = 1
        Me.barLeftDockSite.TabStop = False
        '
        'barRightDockSite
        '
        Me.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barRightDockSite.Controls.AddRange(New System.Windows.Forms.Control() {Me.barTaskPane})
        Me.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right
        Me.barRightDockSite.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {New DevComponents.DotNetBar.DocumentBarContainer(Me.barTaskPane, 160, 267)}, DevComponents.DotNetBar.eOrientation.Horizontal)
        Me.barRightDockSite.Location = New System.Drawing.Point(541, 76)
        Me.barRightDockSite.Name = "barRightDockSite"
        Me.barRightDockSite.Size = New System.Drawing.Size(163, 267)
        Me.barRightDockSite.TabIndex = 2
        Me.barRightDockSite.TabStop = False
        '
        'barTaskPane
        '
        Me.barTaskPane.AccessibleDescription = "DotNetBar Bar (barTaskPane)"
        Me.barTaskPane.AccessibleName = "DotNetBar Bar"
        Me.barTaskPane.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.barTaskPane.AutoSyncBarCaption = True
        Me.barTaskPane.Controls.AddRange(New System.Windows.Forms.Control() {Me.PanelDockContainer4, Me.PanelDockContainer3})
        Me.barTaskPane.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.CaptionTaskPane
        Me.barTaskPane.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.TaskPane1, Me.TaskPane2})
        Me.barTaskPane.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.barTaskPane.Location = New System.Drawing.Point(3, 0)
        Me.barTaskPane.Name = "barTaskPane"
        Me.barTaskPane.SelectedDockTab = 0
        Me.barTaskPane.Size = New System.Drawing.Size(160, 267)
        Me.barTaskPane.Stretch = True
        Me.barTaskPane.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.barTaskPane.TabIndex = 0
        Me.barTaskPane.TabStop = False
        Me.barTaskPane.Text = "Getting Started"
        '
        'PanelDockContainer4
        '
        Me.PanelDockContainer4.Controls.AddRange(New System.Windows.Forms.Control() {Me.explorerBar1})
        Me.PanelDockContainer4.Location = New System.Drawing.Point(3, 26)
        Me.PanelDockContainer4.Name = "PanelDockContainer4"
        Me.PanelDockContainer4.Size = New System.Drawing.Size(154, 238)
        Me.PanelDockContainer4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.PanelDockContainer4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer4.Style.GradientAngle = 90
        Me.PanelDockContainer4.TabIndex = 2
        '
        'explorerBar1
        '
        Me.explorerBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.explorerBar1.BackColor = System.Drawing.SystemColors.Control
        '
        'explorerBar1.BackStyle
        '
        Me.explorerBar1.BackStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.explorerBar1.BackStyle.BackColorGradientAngle = 90
        Me.explorerBar1.BackStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.explorerBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.explorerBar1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.explorerBar1.GroupImages = Nothing
        Me.explorerBar1.Groups.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.explorerBarGroupItem1, Me.explorerBarGroupItem2})
        Me.explorerBar1.Images = Nothing
        Me.explorerBar1.Name = "explorerBar1"
        Me.explorerBar1.Size = New System.Drawing.Size(154, 238)
        Me.explorerBar1.TabIndex = 5
        Me.explorerBar1.Text = "explorerBar1"
        '
        'explorerBarGroupItem1
        '
        '
        'explorerBarGroupItem1.BackStyle
        '
        Me.explorerBarGroupItem1.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(214, Byte), CType(223, Byte), CType(247, Byte))
        Me.explorerBarGroupItem1.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.explorerBarGroupItem1.BackStyle.BorderColor = System.Drawing.Color.White
        Me.explorerBarGroupItem1.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.explorerBarGroupItem1.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.explorerBarGroupItem1.BackStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.explorerBarGroupItem1.ExpandBorderColor = System.Drawing.Color.FromArgb(CType(174, Byte), CType(182, Byte), CType(216, Byte))
        Me.explorerBarGroupItem1.ExpandButtonVisible = False
        Me.explorerBarGroupItem1.Expanded = True
        Me.explorerBarGroupItem1.ExpandForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(60, Byte), CType(165, Byte))
        Me.explorerBarGroupItem1.ExpandHotBorderColor = System.Drawing.Color.FromArgb(CType(174, Byte), CType(182, Byte), CType(216, Byte))
        Me.explorerBarGroupItem1.ExpandHotForeColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        Me.explorerBarGroupItem1.HeaderExpands = False
        Me.explorerBarGroupItem1.Name = "explorerBarGroupItem1"
        Me.explorerBarGroupItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem25, Me.ButtonItem26, Me.ButtonItem27})
        Me.explorerBarGroupItem1.Text = "Assistance"
        '
        'explorerBarGroupItem1.TitleHotStyle
        '
        Me.explorerBarGroupItem1.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.explorerBarGroupItem1.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(199, Byte), CType(211, Byte), CType(247, Byte))
        Me.explorerBarGroupItem1.TitleHotStyle.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.explorerBarGroupItem1.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        '
        'explorerBarGroupItem1.TitleStyle
        '
        Me.explorerBarGroupItem1.TitleStyle.BackColor = System.Drawing.Color.White
        Me.explorerBarGroupItem1.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(199, Byte), CType(211, Byte), CType(247, Byte))
        Me.explorerBarGroupItem1.TitleStyle.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.explorerBarGroupItem1.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        '
        'ButtonItem25
        '
        Me.ButtonItem25.ForeColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        Me.ButtonItem25.HotFontUnderline = True
        Me.ButtonItem25.HotForeColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        Me.ButtonItem25.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItem25.Name = "ButtonItem25"
        Me.ButtonItem25.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.ButtonItem25.Text = "· Connect to DevComponents Online"
        '
        'ButtonItem26
        '
        Me.ButtonItem26.ForeColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        Me.ButtonItem26.HotFontUnderline = True
        Me.ButtonItem26.HotForeColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        Me.ButtonItem26.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItem26.Name = "ButtonItem26"
        Me.ButtonItem26.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.ButtonItem26.Text = "· Get latest news about using this product"
        '
        'ButtonItem27
        '
        Me.ButtonItem27.ForeColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        Me.ButtonItem27.HotFontUnderline = True
        Me.ButtonItem27.HotForeColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        Me.ButtonItem27.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItem27.Name = "ButtonItem27"
        Me.ButtonItem27.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.ButtonItem27.Text = "· Automatically update this list from web"
        '
        'explorerBarGroupItem2
        '
        '
        'explorerBarGroupItem2.BackStyle
        '
        Me.explorerBarGroupItem2.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(214, Byte), CType(223, Byte), CType(247, Byte))
        Me.explorerBarGroupItem2.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.explorerBarGroupItem2.BackStyle.BorderColor = System.Drawing.Color.White
        Me.explorerBarGroupItem2.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.explorerBarGroupItem2.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.explorerBarGroupItem2.BackStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.explorerBarGroupItem2.ExpandBorderColor = System.Drawing.Color.FromArgb(CType(174, Byte), CType(182, Byte), CType(216, Byte))
        Me.explorerBarGroupItem2.ExpandButtonVisible = False
        Me.explorerBarGroupItem2.Expanded = True
        Me.explorerBarGroupItem2.ExpandForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(60, Byte), CType(165, Byte))
        Me.explorerBarGroupItem2.ExpandHotBorderColor = System.Drawing.Color.FromArgb(CType(174, Byte), CType(182, Byte), CType(216, Byte))
        Me.explorerBarGroupItem2.ExpandHotForeColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        Me.explorerBarGroupItem2.HeaderExpands = False
        Me.explorerBarGroupItem2.Name = "explorerBarGroupItem2"
        Me.explorerBarGroupItem2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem28, Me.ButtonItem29, Me.ButtonItem30, Me.ButtonItem31})
        Me.explorerBarGroupItem2.Text = "Open"
        '
        'explorerBarGroupItem2.TitleHotStyle
        '
        Me.explorerBarGroupItem2.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.explorerBarGroupItem2.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(199, Byte), CType(211, Byte), CType(247, Byte))
        Me.explorerBarGroupItem2.TitleHotStyle.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.explorerBarGroupItem2.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        '
        'explorerBarGroupItem2.TitleStyle
        '
        Me.explorerBarGroupItem2.TitleStyle.BackColor = System.Drawing.Color.White
        Me.explorerBarGroupItem2.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(199, Byte), CType(211, Byte), CType(247, Byte))
        Me.explorerBarGroupItem2.TitleStyle.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.explorerBarGroupItem2.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        '
        'ButtonItem28
        '
        Me.ButtonItem28.ForeColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        Me.ButtonItem28.HotFontUnderline = True
        Me.ButtonItem28.HotForeColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        Me.ButtonItem28.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItem28.Name = "ButtonItem28"
        Me.ButtonItem28.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.ButtonItem28.Text = "Document1.doc"
        '
        'ButtonItem29
        '
        Me.ButtonItem29.ForeColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        Me.ButtonItem29.HotFontUnderline = True
        Me.ButtonItem29.HotForeColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        Me.ButtonItem29.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItem29.Name = "ButtonItem29"
        Me.ButtonItem29.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.ButtonItem29.Text = "My Document 2.doc"
        '
        'ButtonItem30
        '
        Me.ButtonItem30.ForeColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        Me.ButtonItem30.HotFontUnderline = True
        Me.ButtonItem30.HotForeColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        Me.ButtonItem30.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItem30.Name = "ButtonItem30"
        Me.ButtonItem30.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.ButtonItem30.Text = "Report.doc"
        '
        'ButtonItem31
        '
        Me.ButtonItem31.ForeColor = System.Drawing.Color.FromArgb(CType(33, Byte), CType(93, Byte), CType(198, Byte))
        Me.ButtonItem31.HotFontUnderline = True
        Me.ButtonItem31.HotForeColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(142, Byte), CType(255, Byte))
        Me.ButtonItem31.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.ButtonItem31.Name = "ButtonItem31"
        Me.ButtonItem31.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.ButtonItem31.Text = "End of year account.doc"
        '
        'PanelDockContainer3
        '
        Me.PanelDockContainer3.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox2, Me.label1, Me.label2, Me.listBox1, Me.button1})
        Me.PanelDockContainer3.Location = New System.Drawing.Point(3, 26)
        Me.PanelDockContainer3.Name = "PanelDockContainer3"
        Me.PanelDockContainer3.Size = New System.Drawing.Size(154, 238)
        Me.PanelDockContainer3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.PanelDockContainer3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer3.Style.GradientAngle = 90
        Me.PanelDockContainer3.TabIndex = 1
        '
        'TaskPane1
        '
        Me.TaskPane1.Control = Me.PanelDockContainer4
        Me.TaskPane1.DefaultFloatingSize = New System.Drawing.Size(193, 290)
        Me.TaskPane1.GlobalItem = True
        Me.TaskPane1.GlobalName = "TaskPane1"
        Me.TaskPane1.Name = "TaskPane1"
        Me.TaskPane1.Text = "Getting Started"
        '
        'TaskPane2
        '
        Me.TaskPane2.Control = Me.PanelDockContainer3
        Me.TaskPane2.DefaultFloatingSize = New System.Drawing.Size(193, 290)
        Me.TaskPane2.GlobalItem = True
        Me.TaskPane2.GlobalName = "TaskPane2"
        Me.TaskPane2.Name = "TaskPane2"
        Me.TaskPane2.Text = "Research"
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Controls.AddRange(New System.Windows.Forms.Control() {Me.windowlist})
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.Location = New System.Drawing.Point(0, 465)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(704, 26)
        Me.DockSite4.TabIndex = 14
        Me.DockSite4.TabStop = False
        '
        'windowlist
        '
        Me.windowlist.AccessibleDescription = "Open Windows (windowlist)"
        Me.windowlist.AccessibleName = "Open Windows"
        Me.windowlist.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.windowlist.CanDockLeft = False
        Me.windowlist.CanDockRight = False
        Me.windowlist.CanDockTop = False
        Me.windowlist.DockSide = DevComponents.DotNetBar.eDockSide.Bottom
        Me.windowlist.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.item_162})
        Me.windowlist.Name = "windowlist"
        Me.windowlist.Size = New System.Drawing.Size(36, 25)
        Me.windowlist.Stretch = True
        Me.windowlist.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.windowlist.TabIndex = 0
        Me.windowlist.TabStop = False
        Me.windowlist.Text = "Open Windows"
        Me.windowlist.Visible = False
        '
        'item_162
        '
        Me.item_162.GlobalName = "item_162"
        Me.item_162.Name = "item_162"
        Me.item_162.ShowWindowIcons = True
        Me.item_162.Text = "MDI Window List"
        Me.item_162.Visible = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.Location = New System.Drawing.Point(0, 76)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 389)
        Me.DockSite1.TabIndex = 11
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.Location = New System.Drawing.Point(704, 76)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 389)
        Me.DockSite2.TabIndex = 12
        Me.DockSite2.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Controls.AddRange(New System.Windows.Forms.Control() {Me.mainmenu, Me.standard, Me.edit, Me.format})
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(704, 76)
        Me.DockSite3.TabIndex = 13
        Me.DockSite3.TabStop = False
        '
        'mainmenu
        '
        Me.mainmenu.AccessibleDescription = "DotNetBar Bar (mainmenu)"
        Me.mainmenu.AccessibleName = "DotNetBar Bar"
        Me.mainmenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.mainmenu.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me.mainmenu.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bFile, Me.bEdit, Me.bFormat, Me.bWindow, Me.bHelp, Me.bChangeStyle})
        Me.mainmenu.LockDockPosition = True
        Me.mainmenu.MenuBar = True
        Me.mainmenu.Name = "mainmenu"
        Me.mainmenu.Size = New System.Drawing.Size(704, 24)
        Me.mainmenu.Stretch = True
        Me.mainmenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.mainmenu.TabIndex = 0
        Me.mainmenu.TabStop = False
        Me.mainmenu.Text = "Main Menu"
        '
        'bFile
        '
        Me.bFile.Category = "Main Menu"
        Me.bFile.GlobalName = "bFile"
        Me.bFile.Name = "bFile"
        Me.bFile.PersonalizedMenus = DevComponents.DotNetBar.ePersonalizedMenus.Both
        Me.bFile.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bNew, Me.bOpen, Me.bClose, Me.bSave, Me.bSaveAs, Me.bPageSetup, Me.bPrintPreview, Me.bPrint, Me.bExit})
        Me.bFile.Text = "&File"
        '
        'bNew
        '
        Me.bNew.Category = "File"
        Me.bNew.GlobalName = "bNew"
        Me.bNew.ImageIndex = 10
        Me.bNew.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bNew.Name = "bNew"
        Me.bNew.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bNew.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN)
        Me.bNew.Text = "&New"
        Me.bNew.Tooltip = "Create new document"
        '
        'bOpen
        '
        Me.bOpen.Category = "File"
        Me.bOpen.GlobalName = "bOpen"
        Me.bOpen.ImageIndex = 11
        Me.bOpen.Name = "bOpen"
        Me.bOpen.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bOpen.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlO)
        Me.bOpen.Text = "&Open"
        Me.bOpen.Tooltip = "Open existing document"
        '
        'bClose
        '
        Me.bClose.Category = "File"
        Me.bClose.Enabled = False
        Me.bClose.GlobalName = "bClose"
        Me.bClose.ImageIndex = 3
        Me.bClose.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bClose.Name = "bClose"
        Me.bClose.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bClose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.bClose.Text = "&Close"
        Me.bClose.Tooltip = "Close active document"
        '
        'bSave
        '
        Me.bSave.BeginGroup = True
        Me.bSave.Category = "File"
        Me.bSave.GlobalName = "bSave"
        Me.bSave.ImageIndex = 17
        Me.bSave.Name = "bSave"
        Me.bSave.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.bSave.Text = "&Save"
        Me.bSave.Tooltip = "Save active document"
        '
        'bSaveAs
        '
        Me.bSaveAs.Category = "File"
        Me.bSaveAs.GlobalName = "bSaveAs"
        Me.bSaveAs.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bSaveAs.Name = "bSaveAs"
        Me.bSaveAs.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bSaveAs.Text = "Save &As..."
        '
        'bPageSetup
        '
        Me.bPageSetup.BeginGroup = True
        Me.bPageSetup.Category = "File"
        Me.bPageSetup.GlobalName = "bPageSetup"
        Me.bPageSetup.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bPageSetup.Name = "bPageSetup"
        Me.bPageSetup.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bPageSetup.Text = "Page &Setup..."
        '
        'bPrintPreview
        '
        Me.bPrintPreview.Category = "File"
        Me.bPrintPreview.GlobalName = "bPrintPreview"
        Me.bPrintPreview.ImageIndex = 14
        Me.bPrintPreview.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bPrintPreview.Name = "bPrintPreview"
        Me.bPrintPreview.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bPrintPreview.Text = "Print Pre&view"
        '
        'bPrint
        '
        Me.bPrint.Category = "File"
        Me.bPrint.GlobalName = "bPrint"
        Me.bPrint.ImageIndex = 13
        Me.bPrint.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bPrint.Name = "bPrint"
        Me.bPrint.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bPrint.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlP)
        Me.bPrint.Text = "&Print"
        '
        'bExit
        '
        Me.bExit.BeginGroup = True
        Me.bExit.Category = "File"
        Me.bExit.GlobalName = "bExit"
        Me.bExit.Name = "bExit"
        Me.bExit.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bExit.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.bExit.Text = "E&xit"
        '
        'bEdit
        '
        Me.bEdit.Category = "Main Menu"
        Me.bEdit.GlobalName = "bEdit"
        Me.bEdit.Name = "bEdit"
        Me.bEdit.PersonalizedMenus = DevComponents.DotNetBar.ePersonalizedMenus.Both
        Me.bEdit.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bUndo, Me.bCut, Me.bCopy, Me.bPaste, Me.bDelete, Me.bSelectAll, Me.bFind, Me.bFindNext, Me.bReplace})
        Me.bEdit.Text = "&Edit"
        '
        'bUndo
        '
        Me.bUndo.Category = "Edit"
        Me.bUndo.Enabled = False
        Me.bUndo.GlobalName = "bUndo"
        Me.bUndo.ImageIndex = 19
        Me.bUndo.Name = "bUndo"
        Me.bUndo.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bUndo.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ)
        Me.bUndo.Text = "&Undo"
        '
        'bCut
        '
        Me.bCut.BeginGroup = True
        Me.bCut.Category = "Edit"
        Me.bCut.Enabled = False
        Me.bCut.GlobalName = "bCut"
        Me.bCut.ImageIndex = 5
        Me.bCut.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bCut.Name = "bCut"
        Me.bCut.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bCut.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.bCut.Text = "Cu&t"
        '
        'bCopy
        '
        Me.bCopy.Category = "Edit"
        Me.bCopy.Enabled = False
        Me.bCopy.GlobalName = "bCopy"
        Me.bCopy.ImageIndex = 4
        Me.bCopy.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bCopy.Name = "bCopy"
        Me.bCopy.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bCopy.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.bCopy.Text = "&Copy"
        '
        'bPaste
        '
        Me.bPaste.Category = "Edit"
        Me.bPaste.Enabled = False
        Me.bPaste.GlobalName = "bPaste"
        Me.bPaste.ImageIndex = 12
        Me.bPaste.Name = "bPaste"
        Me.bPaste.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bPaste.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV)
        Me.bPaste.Text = "&Paste"
        '
        'bDelete
        '
        Me.bDelete.Category = "Edit"
        Me.bDelete.Enabled = False
        Me.bDelete.GlobalName = "bDelete"
        Me.bDelete.ImageIndex = 2
        Me.bDelete.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bDelete.Name = "bDelete"
        Me.bDelete.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD)
        Me.bDelete.Text = "&Delete"
        '
        'bSelectAll
        '
        Me.bSelectAll.BeginGroup = True
        Me.bSelectAll.Category = "Edit"
        Me.bSelectAll.Enabled = False
        Me.bSelectAll.GlobalName = "bSelectAll"
        Me.bSelectAll.Name = "bSelectAll"
        Me.bSelectAll.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bSelectAll.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.bSelectAll.Text = "Select &All"
        '
        'bFind
        '
        Me.bFind.BeginGroup = True
        Me.bFind.Category = "Edit"
        Me.bFind.Enabled = False
        Me.bFind.GlobalName = "bFind"
        Me.bFind.ImageIndex = 7
        Me.bFind.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bFind.Name = "bFind"
        Me.bFind.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bFind.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlF)
        Me.bFind.Text = "&Find..."
        '
        'bFindNext
        '
        Me.bFindNext.Category = "Edit"
        Me.bFindNext.Enabled = False
        Me.bFindNext.GlobalName = "bFindNext"
        Me.bFindNext.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bFindNext.Name = "bFindNext"
        Me.bFindNext.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bFindNext.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F3)
        Me.bFindNext.Text = "Find &Next"
        '
        'bReplace
        '
        Me.bReplace.Category = "Edit"
        Me.bReplace.Enabled = False
        Me.bReplace.GlobalName = "bReplace"
        Me.bReplace.ImageIndex = 15
        Me.bReplace.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bReplace.Name = "bReplace"
        Me.bReplace.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bReplace.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlH)
        Me.bReplace.Text = "&Replace..."
        '
        'bFormat
        '
        Me.bFormat.Category = "Main Menu"
        Me.bFormat.GlobalName = "bFormat"
        Me.bFormat.Name = "bFormat"
        Me.bFormat.PersonalizedMenus = DevComponents.DotNetBar.ePersonalizedMenus.Both
        Me.bFormat.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bBold, Me.bItalic, Me.bUnderline, Me.bStrikethrough, Me.bAlignLeft, Me.bAlignCenter, Me.bAlignRight, Me.bTextColor})
        Me.bFormat.Text = "F&ormat"
        '
        'bBold
        '
        Me.bBold.Category = "Format"
        Me.bBold.Enabled = False
        Me.bBold.GlobalName = "bBold"
        Me.bBold.ImageIndex = 0
        Me.bBold.Name = "bBold"
        Me.bBold.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bBold.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlB)
        Me.bBold.Text = "&Bold"
        '
        'bItalic
        '
        Me.bItalic.Category = "Format"
        Me.bItalic.Enabled = False
        Me.bItalic.GlobalName = "bItalic"
        Me.bItalic.ImageIndex = 8
        Me.bItalic.Name = "bItalic"
        Me.bItalic.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bItalic.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlI)
        Me.bItalic.Text = "&Italic"
        '
        'bUnderline
        '
        Me.bUnderline.Category = "Format"
        Me.bUnderline.Enabled = False
        Me.bUnderline.GlobalName = "bUnderline"
        Me.bUnderline.ImageIndex = 18
        Me.bUnderline.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bUnderline.Name = "bUnderline"
        Me.bUnderline.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bUnderline.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlU)
        Me.bUnderline.Text = "&Underline"
        '
        'bStrikethrough
        '
        Me.bStrikethrough.Category = "Format"
        Me.bStrikethrough.Enabled = False
        Me.bStrikethrough.GlobalName = "bStrikethrough"
        Me.bStrikethrough.ImageIndex = 20
        Me.bStrikethrough.Name = "bStrikethrough"
        Me.bStrikethrough.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bStrikethrough.Text = "&Strikethrough"
        '
        'bAlignLeft
        '
        Me.bAlignLeft.BeginGroup = True
        Me.bAlignLeft.Category = "Format"
        Me.bAlignLeft.Enabled = False
        Me.bAlignLeft.GlobalName = "bAlignLeft"
        Me.bAlignLeft.ImageIndex = 9
        Me.bAlignLeft.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bAlignLeft.Name = "bAlignLeft"
        Me.bAlignLeft.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bAlignLeft.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlL)
        Me.bAlignLeft.Text = "Align &Left"
        '
        'bAlignCenter
        '
        Me.bAlignCenter.Category = "Format"
        Me.bAlignCenter.Enabled = False
        Me.bAlignCenter.GlobalName = "bAlignCenter"
        Me.bAlignCenter.ImageIndex = 1
        Me.bAlignCenter.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bAlignCenter.Name = "bAlignCenter"
        Me.bAlignCenter.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bAlignCenter.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlM)
        Me.bAlignCenter.Text = "Align &Center"
        '
        'bAlignRight
        '
        Me.bAlignRight.Category = "Format"
        Me.bAlignRight.Enabled = False
        Me.bAlignRight.GlobalName = "bAlignRight"
        Me.bAlignRight.ImageIndex = 16
        Me.bAlignRight.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bAlignRight.Name = "bAlignRight"
        Me.bAlignRight.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bAlignRight.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlR)
        Me.bAlignRight.Text = "Align &Right"
        '
        'bTextColor
        '
        Me.bTextColor.BeginGroup = True
        Me.bTextColor.Category = "Format"
        Me.bTextColor.Enabled = False
        Me.bTextColor.GlobalName = "bTextColor"
        Me.bTextColor.ImageIndex = 21
        Me.bTextColor.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bTextColor.Name = "bTextColor"
        Me.bTextColor.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bTextColor.PopupType = DevComponents.DotNetBar.ePopupType.Container
        Me.bTextColor.Text = "&Text Color"
        Me.bTextColor.Tooltip = "Set text color"
        '
        'bWindow
        '
        Me.bWindow.Category = "Main Menu"
        Me.bWindow.GlobalName = "bWindow"
        Me.bWindow.Name = "bWindow"
        Me.bWindow.PersonalizedMenus = DevComponents.DotNetBar.ePersonalizedMenus.Both
        Me.bWindow.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bNewWindow, Me.bArrangeAll, Me.item_236})
        Me.bWindow.Text = "&Window"
        '
        'bNewWindow
        '
        Me.bNewWindow.Category = "Window"
        Me.bNewWindow.GlobalName = "bNew"
        Me.bNewWindow.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bNewWindow.Name = "bNewWindow"
        Me.bNewWindow.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bNewWindow.Text = "&New Window"
        '
        'bArrangeAll
        '
        Me.bArrangeAll.Category = "Window"
        Me.bArrangeAll.GlobalName = "bArrangeAll"
        Me.bArrangeAll.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.bArrangeAll.Name = "bArrangeAll"
        Me.bArrangeAll.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bArrangeAll.Text = "&Arrange All"
        '
        'item_236
        '
        Me.item_236.BeginGroup = True
        Me.item_236.GlobalName = "item_236"
        Me.item_236.Name = "item_236"
        Me.item_236.ShowWindowIcons = True
        Me.item_236.Text = "MDI Window List"
        Me.item_236.Visible = False
        '
        'bHelp
        '
        Me.bHelp.Category = "Main Menu"
        Me.bHelp.GlobalName = "bHelp"
        Me.bHelp.Name = "bHelp"
        Me.bHelp.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bAbout})
        Me.bHelp.Text = "&Help"
        '
        'bAbout
        '
        Me.bAbout.Category = "Help"
        Me.bAbout.GlobalName = "bAbout"
        Me.bAbout.Name = "bAbout"
        Me.bAbout.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bAbout.Text = "&About..."
        '
        'bChangeStyle
        '
        Me.bChangeStyle.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bChangeStyle.GlobalName = "bChangeStyle"
        Me.bChangeStyle.Image = CType(resources.GetObject("bChangeStyle.Image"), System.Drawing.Bitmap)
        Me.bChangeStyle.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.bChangeStyle.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.bChangeStyle.Name = "bChangeStyle"
        Me.bChangeStyle.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bStyle2003, Me.bVS2005, Me.bStyleXP, Me.bStyle2007Blue})
        Me.bChangeStyle.Text = "Style"
        '
        'bStyle2003
        '
        Me.bStyle2003.GlobalName = "bStyle2003"
        Me.bStyle2003.Name = "bStyle2003"
        Me.bStyle2003.Text = "Office 2003"
        '
        'bVS2005
        '
        Me.bVS2005.GlobalName = "bVS2005"
        Me.bVS2005.Name = "bVS2005"
        Me.bVS2005.Text = "VS 2005"
        '
        'bStyleXP
        '
        Me.bStyleXP.GlobalName = "bStyleXP"
        Me.bStyleXP.Name = "bStyleXP"
        Me.bStyleXP.Text = "Office XP"
        '
        'bStyle2007Blue
        '
        Me.bStyle2007Blue.GlobalName = "bStyle2007Blue"
        Me.bStyle2007Blue.Name = "bStyle2007Blue"
        Me.bStyle2007Blue.Text = "Office 2007 <font color=""Blue""><b>Blue</b></font>"
        '
        'standard
        '
        Me.standard.AccessibleDescription = "DotNetBar Bar (standard)"
        Me.standard.AccessibleName = "DotNetBar Bar"
        Me.standard.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.standard.CanHide = True
        Me.standard.DockLine = 1
        Me.standard.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me.standard.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.standard.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.ButtonItem2, Me.ButtonItem3, Me.ButtonItem4, Me.ButtonItem5, Me.bThemes, Me.bTabbedMdi, Me.item_139})
        Me.standard.Location = New System.Drawing.Point(0, 25)
        Me.standard.Name = "standard"
        Me.standard.Size = New System.Drawing.Size(327, 25)
        Me.standard.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.standard.TabIndex = 1
        Me.standard.TabStop = False
        Me.standard.Text = "Standard"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.GlobalName = "bNew"
        Me.ButtonItem1.ImageIndex = 10
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN)
        Me.ButtonItem1.Text = "&New"
        Me.ButtonItem1.Tooltip = "Create new document"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.GlobalName = "bOpen"
        Me.ButtonItem2.ImageIndex = 11
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem2.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlO)
        Me.ButtonItem2.Text = "&Open"
        Me.ButtonItem2.Tooltip = "Open existing document"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.GlobalName = "bSave"
        Me.ButtonItem3.ImageIndex = 17
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem3.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS)
        Me.ButtonItem3.Text = "&Save"
        Me.ButtonItem3.Tooltip = "Save active document"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.BeginGroup = True
        Me.ButtonItem4.GlobalName = "bPrintPreview"
        Me.ButtonItem4.ImageIndex = 14
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem4.Text = "Print Pre&view"
        Me.ButtonItem4.Tooltip = "Display print preview"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.GlobalName = "bPrint"
        Me.ButtonItem5.ImageIndex = 13
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem5.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlP)
        Me.ButtonItem5.Text = "&Print"
        Me.ButtonItem5.Tooltip = "Print active document"
        '
        'bThemes
        '
        Me.bThemes.BeginGroup = True
        Me.bThemes.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bThemes.Category = "Commands"
        Me.bThemes.GlobalName = "bThemes"
        Me.bThemes.Image = CType(resources.GetObject("bThemes.Image"), System.Drawing.Bitmap)
        Me.bThemes.Name = "bThemes"
        Me.bThemes.Text = "Enable Themes"
        Me.bThemes.Tooltip = "Enable DotNetBar Theme Support"
        '
        'bTabbedMdi
        '
        Me.bTabbedMdi.BeginGroup = True
        Me.bTabbedMdi.Category = "Commands"
        Me.bTabbedMdi.Checked = True
        Me.bTabbedMdi.GlobalName = "bTabbedMdi"
        Me.bTabbedMdi.Name = "bTabbedMdi"
        Me.bTabbedMdi.Text = "Tabbed Mdi"
        '
        'item_139
        '
        Me.item_139.AutoCollapseOnClick = True
        Me.item_139.CanCustomize = True
        Me.item_139.GlobalName = "item_139"
        Me.item_139.Name = "item_139"
        Me.item_139.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.item_139.Text = "&Add or Remove Buttons"
        Me.item_139.Tooltip = "Bar Options"
        '
        'edit
        '
        Me.edit.AccessibleDescription = "DotNetBar Bar (edit)"
        Me.edit.AccessibleName = "DotNetBar Bar"
        Me.edit.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.edit.CanHide = True
        Me.edit.DockLine = 1
        Me.edit.DockOffset = 156
        Me.edit.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me.edit.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.edit.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem6, Me.ButtonItem7, Me.ButtonItem8, Me.ButtonItem9, Me.cmdFind, Me.item_140})
        Me.edit.Location = New System.Drawing.Point(329, 25)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(159, 25)
        Me.edit.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.edit.TabIndex = 2
        Me.edit.TabStop = False
        Me.edit.Text = "Edit"
        '
        'ButtonItem6
        '
        Me.ButtonItem6.DisabledImage = CType(resources.GetObject("ButtonItem6.DisabledImage"), System.Drawing.Bitmap)
        Me.ButtonItem6.Enabled = False
        Me.ButtonItem6.GlobalName = "bUndo"
        Me.ButtonItem6.ImageIndex = 19
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem6.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ)
        Me.ButtonItem6.Text = "&Undo"
        Me.ButtonItem6.Tooltip = "Undo last action"
        '
        'ButtonItem7
        '
        Me.ButtonItem7.BeginGroup = True
        Me.ButtonItem7.DisabledImage = CType(resources.GetObject("ButtonItem7.DisabledImage"), System.Drawing.Bitmap)
        Me.ButtonItem7.Enabled = False
        Me.ButtonItem7.GlobalName = "bCut"
        Me.ButtonItem7.ImageIndex = 5
        Me.ButtonItem7.Name = "ButtonItem7"
        Me.ButtonItem7.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem7.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.ButtonItem7.Text = "Cu&t"
        Me.ButtonItem7.Tooltip = "Cut selected text"
        '
        'ButtonItem8
        '
        Me.ButtonItem8.DisabledImage = CType(resources.GetObject("ButtonItem8.DisabledImage"), System.Drawing.Bitmap)
        Me.ButtonItem8.Enabled = False
        Me.ButtonItem8.GlobalName = "bCopy"
        Me.ButtonItem8.ImageIndex = 4
        Me.ButtonItem8.Name = "ButtonItem8"
        Me.ButtonItem8.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem8.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.ButtonItem8.Text = "&Copy"
        Me.ButtonItem8.Tooltip = "Copy selected text"
        '
        'ButtonItem9
        '
        Me.ButtonItem9.DisabledImage = CType(resources.GetObject("ButtonItem9.DisabledImage"), System.Drawing.Bitmap)
        Me.ButtonItem9.Enabled = False
        Me.ButtonItem9.GlobalName = "bPaste"
        Me.ButtonItem9.ImageIndex = 12
        Me.ButtonItem9.Name = "ButtonItem9"
        Me.ButtonItem9.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem9.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV)
        Me.ButtonItem9.Text = "&Paste"
        Me.ButtonItem9.Tooltip = "Paste text from clipboard"
        '
        'cmdFind
        '
        Me.cmdFind.BeginGroup = True
        Me.cmdFind.DisabledImage = CType(resources.GetObject("cmdFind.DisabledImage"), System.Drawing.Bitmap)
        Me.cmdFind.Enabled = False
        Me.cmdFind.GlobalName = "bFind"
        Me.cmdFind.ImageIndex = 7
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.cmdFind.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlF)
        Me.cmdFind.Text = "&Find..."
        Me.cmdFind.Tooltip = "Find text in active document"
        '
        'item_140
        '
        Me.item_140.AutoCollapseOnClick = True
        Me.item_140.CanCustomize = True
        Me.item_140.GlobalName = "item_140"
        Me.item_140.Name = "item_140"
        Me.item_140.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.item_140.Text = "&Add or Remove Buttons"
        Me.item_140.Tooltip = "Bar Options"
        '
        'format
        '
        Me.format.AccessibleDescription = "DotNetBar Bar (format)"
        Me.format.AccessibleName = "DotNetBar Bar"
        Me.format.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.format.CanHide = True
        Me.format.DockLine = 2
        Me.format.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me.format.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003
        Me.format.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem11, Me.ButtonItem12, Me.ButtonItem13, Me.ButtonItem14, Me.ButtonItem15, Me.ButtonItem16, Me.ButtonItem17, Me.ButtonItem18, Me.item_141})
        Me.format.Location = New System.Drawing.Point(0, 51)
        Me.format.Name = "format"
        Me.format.Size = New System.Drawing.Size(250, 25)
        Me.format.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.format.TabIndex = 3
        Me.format.TabStop = False
        Me.format.Text = "Format"
        '
        'ButtonItem11
        '
        Me.ButtonItem11.Category = "Format"
        Me.ButtonItem11.DisabledImage = CType(resources.GetObject("ButtonItem11.DisabledImage"), System.Drawing.Bitmap)
        Me.ButtonItem11.Enabled = False
        Me.ButtonItem11.GlobalName = "bBold"
        Me.ButtonItem11.ImageIndex = 0
        Me.ButtonItem11.Name = "ButtonItem11"
        Me.ButtonItem11.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem11.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlB)
        Me.ButtonItem11.Text = "&Bold"
        Me.ButtonItem11.Tooltip = "Bold"
        '
        'ButtonItem12
        '
        Me.ButtonItem12.Category = "Format"
        Me.ButtonItem12.DisabledImage = CType(resources.GetObject("ButtonItem12.DisabledImage"), System.Drawing.Bitmap)
        Me.ButtonItem12.Enabled = False
        Me.ButtonItem12.GlobalName = "bItalic"
        Me.ButtonItem12.ImageIndex = 8
        Me.ButtonItem12.Name = "ButtonItem12"
        Me.ButtonItem12.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem12.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlI)
        Me.ButtonItem12.Text = "&Italic"
        Me.ButtonItem12.Tooltip = "Italic"
        '
        'ButtonItem13
        '
        Me.ButtonItem13.Category = "Format"
        Me.ButtonItem13.DisabledImage = CType(resources.GetObject("ButtonItem13.DisabledImage"), System.Drawing.Bitmap)
        Me.ButtonItem13.Enabled = False
        Me.ButtonItem13.GlobalName = "bUnderline"
        Me.ButtonItem13.ImageIndex = 18
        Me.ButtonItem13.Name = "ButtonItem13"
        Me.ButtonItem13.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem13.Text = "&Underline"
        Me.ButtonItem13.Tooltip = "Underline"
        '
        'ButtonItem14
        '
        Me.ButtonItem14.Category = "Format"
        Me.ButtonItem14.DisabledImage = CType(resources.GetObject("ButtonItem14.DisabledImage"), System.Drawing.Bitmap)
        Me.ButtonItem14.Enabled = False
        Me.ButtonItem14.GlobalName = "bStrikethrough"
        Me.ButtonItem14.ImageIndex = 20
        Me.ButtonItem14.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed
        Me.ButtonItem14.Name = "ButtonItem14"
        Me.ButtonItem14.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem14.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlT)
        Me.ButtonItem14.Text = "&Strikethrough"
        '
        'ButtonItem15
        '
        Me.ButtonItem15.BeginGroup = True
        Me.ButtonItem15.Category = "Format"
        Me.ButtonItem15.DisabledImage = CType(resources.GetObject("ButtonItem15.DisabledImage"), System.Drawing.Bitmap)
        Me.ButtonItem15.Enabled = False
        Me.ButtonItem15.GlobalName = "bAlignLeft"
        Me.ButtonItem15.ImageIndex = 9
        Me.ButtonItem15.Name = "ButtonItem15"
        Me.ButtonItem15.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem15.Text = "Align &Left"
        Me.ButtonItem15.Tooltip = "Align Left"
        '
        'ButtonItem16
        '
        Me.ButtonItem16.Category = "Format"
        Me.ButtonItem16.DisabledImage = CType(resources.GetObject("ButtonItem16.DisabledImage"), System.Drawing.Bitmap)
        Me.ButtonItem16.Enabled = False
        Me.ButtonItem16.GlobalName = "bAlignCenter"
        Me.ButtonItem16.ImageIndex = 1
        Me.ButtonItem16.Name = "ButtonItem16"
        Me.ButtonItem16.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem16.Text = "Align &Center"
        Me.ButtonItem16.Tooltip = "Align Center"
        '
        'ButtonItem17
        '
        Me.ButtonItem17.Category = "Format"
        Me.ButtonItem17.DisabledImage = CType(resources.GetObject("ButtonItem17.DisabledImage"), System.Drawing.Bitmap)
        Me.ButtonItem17.Enabled = False
        Me.ButtonItem17.GlobalName = "bAlignRight"
        Me.ButtonItem17.ImageIndex = 16
        Me.ButtonItem17.Name = "ButtonItem17"
        Me.ButtonItem17.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem17.Text = "Align &Right"
        Me.ButtonItem17.Tooltip = "Align Right"
        '
        'ButtonItem18
        '
        Me.ButtonItem18.BeginGroup = True
        Me.ButtonItem18.Category = "Format"
        Me.ButtonItem18.DisabledImage = CType(resources.GetObject("ButtonItem18.DisabledImage"), System.Drawing.Bitmap)
        Me.ButtonItem18.Enabled = False
        Me.ButtonItem18.GlobalName = "bTextColor"
        Me.ButtonItem18.ImageIndex = 21
        Me.ButtonItem18.Name = "ButtonItem18"
        Me.ButtonItem18.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem18.PopupType = DevComponents.DotNetBar.ePopupType.Container
        Me.ButtonItem18.Text = "&Text Color"
        Me.ButtonItem18.Tooltip = "Set text color"
        '
        'item_141
        '
        Me.item_141.AutoCollapseOnClick = True
        Me.item_141.CanCustomize = True
        Me.item_141.GlobalName = "item_141"
        Me.item_141.Name = "item_141"
        Me.item_141.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.item_141.Text = "&Add or Remove Buttons"
        Me.item_141.Tooltip = "Bar Options"
        '
        'barTopDockSite
        '
        Me.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top
        Me.barTopDockSite.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.barTopDockSite.Location = New System.Drawing.Point(0, 76)
        Me.barTopDockSite.Name = "barTopDockSite"
        Me.barTopDockSite.Size = New System.Drawing.Size(704, 0)
        Me.barTopDockSite.TabIndex = 3
        Me.barTopDockSite.TabStop = False
        '
        'listBox1
        '
        Me.listBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listBox1.IntegralHeight = False
        Me.listBox1.Location = New System.Drawing.Point(8, 72)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(134, 160)
        Me.listBox1.TabIndex = 9
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Location = New System.Drawing.Point(8, 56)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(80, 16)
        Me.label2.TabIndex = 8
        Me.label2.Text = "Search results:"
        '
        'button1
        '
        Me.button1.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.button1.BackColor = System.Drawing.Color.Transparent
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.ForeColor = System.Drawing.Color.Transparent
        Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Bitmap)
        Me.button1.Location = New System.Drawing.Point(120, 24)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(21, 21)
        Me.button1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(8, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(104, 21)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Text = ""
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Location = New System.Drawing.Point(8, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 16)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Search for:"
        '
        'tabStrip1
        '
        Me.tabStrip1.CanReorderTabs = True
        Me.tabStrip1.CloseButtonOnTabsVisible = True
        Me.tabStrip1.CloseButtonVisible = False
        Me.ContextMenuBar1.SetContextMenuEx(Me.tabStrip1, Me.bTabContext)
        Me.tabStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabStrip1.Location = New System.Drawing.Point(0, 76)
        Me.tabStrip1.MdiTabbedDocuments = True
        Me.tabStrip1.Name = "tabStrip1"
        Me.tabStrip1.SelectedTab = Nothing
        Me.tabStrip1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabStrip1.Size = New System.Drawing.Size(541, 26)
        Me.tabStrip1.Style = DevComponents.DotNetBar.eTabStripStyle.OneNote
        Me.tabStrip1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.tabStrip1.TabIndex = 7
        Me.tabStrip1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.tabStrip1.Text = "tabStrip1"
        '
        'saveFileDialog1
        '
        Me.saveFileDialog1.FileName = "doc1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'timerInfoBallon
        '
        Me.timerInfoBallon.Interval = 3000
        '
        'barStatus
        '
        Me.barStatus.AccessibleDescription = "DotNetBar Bar (barStatus)"
        Me.barStatus.AccessibleName = "DotNetBar Bar"
        Me.barStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar
        Me.barStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barStatus.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle
        Me.barStatus.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.labelStatus, Me.labelPosition, Me.itemProgressBar})
        Me.barStatus.ItemSpacing = 2
        Me.barStatus.Location = New System.Drawing.Point(0, 491)
        Me.barStatus.Name = "barStatus"
        Me.barStatus.Size = New System.Drawing.Size(704, 19)
        Me.barStatus.Stretch = True
        Me.barStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.barStatus.TabIndex = 9
        Me.barStatus.TabStop = False
        '
        'labelStatus
        '
        Me.labelStatus.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.PaddingLeft = 2
        Me.labelStatus.PaddingRight = 2
        Me.labelStatus.SingleLineColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(97, Byte), CType(156, Byte))
        Me.labelStatus.Stretch = True
        '
        'labelPosition
        '
        Me.labelPosition.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.labelPosition.Name = "labelPosition"
        Me.labelPosition.PaddingLeft = 2
        Me.labelPosition.PaddingRight = 2
        Me.labelPosition.SingleLineColor = System.Drawing.Color.FromArgb(CType(59, Byte), CType(97, Byte), CType(156, Byte))
        Me.labelPosition.Width = 100
        '
        'itemProgressBar
        '
        Me.itemProgressBar.ChunkColor = System.Drawing.Color.FromArgb(CType(254, Byte), CType(142, Byte), CType(75, Byte))
        Me.itemProgressBar.ChunkColor2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(207, Byte), CType(139, Byte))
        Me.itemProgressBar.ChunkGradientAngle = 90.0!
        Me.itemProgressBar.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.itemProgressBar.Name = "itemProgressBar"
        Me.itemProgressBar.RecentlyUsed = False
        Me.itemProgressBar.Text = "progressBarItem1"
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.Images = Me.imageList1
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bEditPopup, Me.bTaskListMenu, Me.bTabContext, Me.bDockContext})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(160, 120)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(368, 25)
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.ContextMenuBar1.TabIndex = 15
        Me.ContextMenuBar1.TabStop = False
        '
        'bDockContext
        '
        Me.bDockContext.AutoExpandOnClick = True
        Me.bDockContext.GlobalName = "bDockContext"
        Me.bDockContext.Name = "bDockContext"
        Me.bDockContext.Text = "bDockContext"
        '
        'bTabContext
        '
        Me.bTabContext.AutoExpandOnClick = True
        Me.bTabContext.GlobalName = "bTabContext"
        Me.bTabContext.Name = "bTabContext"
        Me.bTabContext.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdContextSave, Me.cmdContextClose, Me.bTabColor})
        Me.bTabContext.Text = "bTabContext"
        '
        'cmdContextSave
        '
        Me.cmdContextSave.GlobalItem = False
        Me.cmdContextSave.ImageIndex = 17
        Me.cmdContextSave.Name = "cmdContextSave"
        Me.cmdContextSave.Text = "Save"
        Me.cmdContextSave.Tooltip = "Save active document"
        '
        'cmdContextClose
        '
        Me.cmdContextClose.Enabled = False
        Me.cmdContextClose.GlobalItem = False
        Me.cmdContextClose.Name = "cmdContextClose"
        Me.cmdContextClose.Text = "Close"
        Me.cmdContextClose.Tooltip = "Close active document"
        '
        'bTabColor
        '
        Me.bTabColor.BeginGroup = True
        Me.bTabColor.GlobalName = "bTabColor"
        Me.bTabColor.Name = "bTabColor"
        Me.bTabColor.PopupType = DevComponents.DotNetBar.ePopupType.Container
        Me.bTabColor.Text = "Change Tab Color"
        '
        'bEditPopup
        '
        Me.bEditPopup.AutoExpandOnClick = True
        Me.bEditPopup.GlobalName = "bEditPopup"
        Me.bEditPopup.Name = "bEditPopup"
        Me.bEditPopup.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bEditPopup.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem19, Me.ButtonItem20, Me.ButtonItem21, Me.ButtonItem22})
        Me.bEditPopup.Text = "bEditPopup"
        '
        'ButtonItem19
        '
        Me.ButtonItem19.BeginGroup = True
        Me.ButtonItem19.GlobalName = "bCut"
        Me.ButtonItem19.ImageIndex = 5
        Me.ButtonItem19.Name = "ButtonItem19"
        Me.ButtonItem19.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem19.Text = "Cu&t"
        '
        'ButtonItem20
        '
        Me.ButtonItem20.GlobalName = "bCopy"
        Me.ButtonItem20.ImageIndex = 4
        Me.ButtonItem20.Name = "ButtonItem20"
        Me.ButtonItem20.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem20.Text = "&Copy"
        '
        'ButtonItem21
        '
        Me.ButtonItem21.GlobalName = "bPaste"
        Me.ButtonItem21.ImageIndex = 12
        Me.ButtonItem21.Name = "ButtonItem21"
        Me.ButtonItem21.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem21.Text = "&Paste"
        '
        'ButtonItem22
        '
        Me.ButtonItem22.BeginGroup = True
        Me.ButtonItem22.GlobalName = "bSelectAll"
        Me.ButtonItem22.Name = "ButtonItem22"
        Me.ButtonItem22.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.ButtonItem22.Text = "Select &All"
        '
        'bTaskListMenu
        '
        Me.bTaskListMenu.AutoExpandOnClick = True
        Me.bTaskListMenu.GlobalName = "bTaskListMenu"
        Me.bTaskListMenu.Name = "bTaskListMenu"
        Me.bTaskListMenu.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.item_477, Me.item_504, Me.item_531})
        Me.bTaskListMenu.Text = "bTaskListMenu"
        '
        'item_477
        '
        Me.item_477.GlobalName = "item_477"
        Me.item_477.Name = "item_477"
        Me.item_477.Text = "Show All Tasks"
        '
        'item_504
        '
        Me.item_504.GlobalName = "item_504"
        Me.item_504.Name = "item_504"
        Me.item_504.Text = "Show High Importance only"
        '
        'item_531
        '
        Me.item_531.BeginGroup = True
        Me.item_531.GlobalName = "item_531"
        Me.item_531.Name = "item_531"
        Me.item_531.Text = "Hide"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 510)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.ContextMenuBar1, Me.tabStrip1, Me.barLeftDockSite, Me.barRightDockSite, Me.barTopDockSite, Me.barBottomDockSite, Me.DockSite1, Me.DockSite2, Me.DockSite3, Me.DockSite4, Me.barStatus})
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.barBottomDockSite.ResumeLayout(False)
        CType(Me.barTaskList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barTaskList.ResumeLayout(False)
        Me.PanelDockContainer1.ResumeLayout(False)
        Me.PanelDockContainer2.ResumeLayout(False)
        Me.barRightDockSite.ResumeLayout(False)
        CType(Me.barTaskPane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barTaskPane.ResumeLayout(False)
        Me.PanelDockContainer4.ResumeLayout(False)
        CType(Me.explorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDockContainer3.ResumeLayout(False)
        Me.DockSite4.ResumeLayout(False)
        CType(Me.windowlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockSite3.ResumeLayout(False)
        CType(Me.mainmenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.standard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.format, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ContextMenuBar1_PopupContainerLoad(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextMenuBar1.PopupContainerLoad, dotNetBarManager1.PopupContainerLoad
        Dim item As ButtonItem = CType(sender, ButtonItem)

        If item Is Nothing Then Exit Sub

        If item.GlobalName = "bTextColor" Or item.Name = "bTabColor" Then
            Dim container As PopupContainerControl = CType(item.PopupContainerControl, PopupContainerControl)
            Dim clr As ColorPicker = New ColorPicker()
            container.Controls.Add(clr)
            clr.Location = container.ClientRectangle.Location
            container.ClientSize = clr.Size
        End If

    End Sub

    Private Sub ContextMenuBar1_PopupContainerUnload(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextMenuBar1.PopupContainerUnload, dotNetBarManager1.PopupContainerUnload
        Dim item As ButtonItem = CType(sender, ButtonItem)
        Dim clr As ColorPicker
        Dim container As PopupContainerControl

        If item Is Nothing Then Exit Sub

        If item.GlobalName = "bTextColor" Then
            container = CType(item.PopupContainerControl, PopupContainerControl)
            clr = CType(container.Controls(0), ColorPicker)
            If Not Color.Empty.Equals(clr.SelectedColor) Then
                Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
                If Not activedocument Is Nothing Then
                    activedocument.ExecuteCommand(item.GlobalName, clr.SelectedColor)
                End If
            End If
        ElseIf item.Name = "bTabColor" Then
            container = CType(item.PopupContainerControl, PopupContainerControl)
            clr = CType(container.Controls(0), ColorPicker)
            If Not Color.Empty.Equals(clr.SelectedColor) Then
                tabStrip1.ColorScheme.TabBackground = ControlPaint.LightLight(clr.SelectedColor)
                tabStrip1.ColorScheme.TabBackground2 = clr.SelectedColor
                tabStrip1.Refresh()
            End If
            ' Close popup menu, since it is not closed when Popup Container is closed...
            item.Parent.Expanded = False
        End If
    End Sub

    Public Sub EditContextMenu()
        bEditPopup.Displayed = False
        bEditPopup.PopupMenu(Control.MousePosition)
    End Sub

    Private Sub dotNetBarManager1_ItemClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dotNetBarManager1.ItemClick
        Dim objItem As BaseItem = CType(sender, BaseItem)
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)

        Select Case objItem.GlobalName
            Case bNew.GlobalName
                CreateNewDocument()

            Case bOpen.GlobalName
                OpenDocument()

            Case bSave.GlobalName
                SaveDocument()

            Case bSaveAs.GlobalName
                SaveDocumentAs()

            Case bClose.GlobalName
                If Not activedocument Is Nothing Then
                    activedocument.Close()
                End If

            Case bPageSetup.GlobalName
                MessageBox.Show("Not implemented yet.")

            Case bPrintPreview.GlobalName
                MessageBox.Show("Not implemented yet.")

            Case bPrint.GlobalName
                MessageBox.Show("Not implemented yet.")

            Case bExit.GlobalName
                Me.Close()

                ' Window menu
            Case bArrangeAll.GlobalName
                Me.LayoutMdi(MdiLayout.Cascade)

            Case bThemes.GlobalName
                EnableThemes(bThemes)
            Case bStyle2007Blue.GlobalName
                ChangeDotNetBarStyle(eDotNetBarStyle.Office2007)
            Case bStyle2003.GlobalName
                ChangeDotNetBarStyle(eDotNetBarStyle.Office2003)
            Case bStyleXP.GlobalName
                ChangeDotNetBarStyle(eDotNetBarStyle.OfficeXP)
            Case bVS2005.GlobalName
                ChangeDotNetBarStyle(eDotNetBarStyle.VS2005)
            Case bFind.GlobalName
                If m_Search Is Nothing OrElse m_Search.IsDisposed Then
                    m_Search = New BalloonSearch()
                    m_Search.Owner = Me
                    m_Search.Show(objItem, True)
                End If
            Case Else
                ' Pass them to the active document
                If Not activedocument Is Nothing Then
                    ' Pass command to the active document
                    ' Note the usage of GlobalName property! Since same command can be found on both menus and toolbars, for example Bold
                    ' you have to give two different names through Name property to these two instances. However, you can and should
                    ' give them same GlobalName. GlobalName will ensure that properties set on one instance are replicated to all
                    ' objects with the same GlobalName. You can read more about Global Items feature in help file.
                    activedocument.ExecuteCommand(objItem.GlobalName, Nothing)
                End If
        End Select
    End Sub

    Private Sub CreateNewDocument()
        Dim doc As frmDocument = New frmDocument()
        doc.MdiParent = Me
        doc.WindowState = FormWindowState.Maximized
        doc.Show()
        doc.Update()
        doc.Text = "New Document " + Me.MdiChildren.Length.ToString()
    End Sub

    Private Sub EnableFileItems()
        ' Accessing items through the Items collection and setting the properties on them
        ' will propagate certain properties to all items with the same name...
        If Me.ActiveMdiChild Is Nothing Then
            bSave.Enabled = False
            bSaveAs.Enabled = False
            bPrint.Enabled = False
            bPrintPreview.Enabled = False
            bPageSetup.Enabled = False
        Else
            bSave.Enabled = True
            bSaveAs.Enabled = True
            bPrint.Enabled = True
            bPrintPreview.Enabled = True
            bPageSetup.Enabled = True
        End If
    End Sub


    Private Sub frmMain_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate
        EnableFileItems()
    End Sub

    Private Sub OpenDocument()
        openFileDialog1.FileName = ""
        openFileDialog1.ShowDialog()
        If openFileDialog1.FileName = "" Then Exit Sub
        Dim doc As frmDocument = New frmDocument()
        doc.Text = openFileDialog1.FileName
        doc.MdiParent = Me
        doc.Show()
        doc.OpenFile(openFileDialog1.FileName)
    End Sub

    Public Sub SaveDocument()
        If Me.ActiveMdiChild Is Nothing Then Exit Sub
        Dim doc As frmDocument = CType(Me.ActiveMdiChild, frmDocument)

        If doc Is Nothing Then Exit Sub
        If Not doc.DocumentChanged Then Exit Sub
        SaveDocument(doc)
    End Sub

    Public Sub SaveDocument(ByVal doc As frmDocument)
        If doc.FileName = "" Then
            Dim dr As System.Windows.Forms.DialogResult = saveFileDialog1.ShowDialog()
            If saveFileDialog1.FileName = "" Then Exit Sub
            If dr = System.Windows.Forms.DialogResult.OK Then doc.FileName = saveFileDialog1.FileName
        End If
        If doc.FileName <> "" Then doc.SaveFile()
    End Sub

    Private Sub SaveDocumentAs()
        If Me.ActiveMdiChild Is Nothing Then Exit Sub
        Dim doc As frmDocument = CType(Me.ActiveMdiChild, frmDocument)

        If doc Is Nothing Then Exit Sub
        If Not doc.DocumentChanged Then Exit Sub
        If doc.FileName = "" Then
            SaveDocument(doc)
            Exit Sub
        End If

        saveFileDialog1.ShowDialog()

        If saveFileDialog1.FileName = "" Then Exit Sub

        doc.FileName = saveFileDialog1.FileName
        doc.SaveFile()
    End Sub


    Private Sub m_CheckTaskShowStartup_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles m_CheckTaskShowStartup.CheckedChanged
        MessageBox.Show("This item is here for demonstration purposes only and code should be added to save the state of it.")
    End Sub

    Private Sub dotNetBarManager1_DefinitionLoaded(ByVal sender As Object, ByVal e As System.EventArgs) Handles dotNetBarManager1.DefinitionLoaded

    End Sub

    Private Sub dotNetBarManager1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dotNetBarManager1.MouseEnter
        ' Sync Status-bar with the item tooltip...
        Dim item As BaseItem = CType(sender, BaseItem)
        If item Is Nothing Then Exit Sub

        labelStatus.Text = item.Tooltip

        ' Disable timer...
        If item.Name = "bThemes" And Timer1.Enabled Then
            Timer1.Enabled = False
            CType(item, ButtonItem).ForeColor = Color.Empty
        End If
    End Sub

    Private Sub dotNetBarManager1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dotNetBarManager1.MouseLeave
        labelStatus.Text = ""
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Assign optional "Customize" menu to the bar that contains this item
        barTaskList.CustomizeMenu = bTaskListMenu

        ChangeDotNetBarStyle(eDotNetBarStyle.Office2003)

        ' This makes sure that Theme support is enabled by the end-user as well as present on this OS
        If dotNetBarManager1.IsThemeActive Then
            dotNetBarManager1.GetItem("bThemes").Visible = True
            Timer1.Enabled = True
        End If
        ' Neccessary for Automatic Tab-Strip Mdi support
        tabStrip1.MdiForm = Me

        ' Setup Context menu for the barTaskList TabStrip...
        Dim barTask As Bar = dotNetBarManager1.Bars("barTaskList")
        dotNetBarManager1.SetContextMenuEx(barTask, "bDockContext")

        Me.timerInfoBallon.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' Flash Item to attract attention...
        Dim item As ButtonItem = CType(dotNetBarManager1.GetItem("bThemes"), ButtonItem)
        If item.ForeColor.Equals(Color.Red) Then
            item.ForeColor = Color.Empty
        Else
            item.ForeColor = Color.Red
        End If

        Dim progress As ProgressBarItem = itemProgressBar
        If progress.Value = progress.Maximum Then
            progress.Value = progress.Minimum
        Else
            progress.Increment(10)
        End If
    End Sub

    Private Sub EnableThemes(ByVal item As ButtonItem)
        Dim bEnable As Boolean = Not item.Checked
        item.Checked = bEnable
        If bEnable Then
            item.Text = "Disable Themes"
        Else
            item.Text = "Enable Themes"
        End If

        dotNetBarManager1.SuspendLayout = True
        dotNetBarManager1.ThemeAware = bEnable
        dotNetBarManager1.SuspendLayout = False
        Me.Refresh()
    End Sub

    Private Sub ContextMenuBar1_PopupOpen(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.PopupOpenEventArgs) Handles ContextMenuBar1.PopupOpen
        Dim item As BaseItem = CType(sender, BaseItem)
        If item Is Nothing Then Exit Sub

        If item Is bTabContext Then
            ' Enable/Disable the document related menu items based on where user right-clicked...
            Dim tab As TabItem = TabItemFromPoint(tabStrip1.PointToClient(Control.MousePosition))
            ' If no tab is under the mouse disable document related items...
            If tab Is Nothing Then
                cmdContextClose.Enabled = False
                cmdContextSave.Enabled = False
            Else
                cmdContextClose.Enabled = True
                cmdContextSave.Enabled = True
                ' Make sure that tab under the mouse is active tab
                tabStrip1.SelectedTab = tab
            End If
        ElseIf item Is bDockContext Then
            ' Display our context menu only if user clicks on the bar caption or tab strip control
            If Not barTaskList.GrabHandleRect.Contains(barTaskList.PointToClient(Control.MousePosition)) AndAlso Not barTaskList.DockTabControl Is Nothing AndAlso Not barTaskList.DockTabControl.Bounds.Contains(barTaskList.PointToClient(Control.MousePosition)) Then
                e.Cancel = True
                Exit Sub
            End If
            item.SubItems.Clear()
            Dim contextItem As ButtonItem
            Dim dockItem As BaseItem
            For Each dockItem In barTaskList.Items
                contextItem = New ButtonItem(dockItem.Name, dockItem.Text)
                contextItem.GlobalItem = False
                AddHandler contextItem.Click, AddressOf DockContextClick
                item.SubItems.Add(contextItem)
                contextItem.Checked = dockItem.Visible
            Next
            contextItem = New ButtonItem("bc_tabnavigation", "Tab Navigation")
            contextItem.Checked = barTaskList.TabNavigation
            contextItem.BeginGroup = True
            AddHandler contextItem.Click, AddressOf DockContextClick
            item.SubItems.Add(contextItem)
        End If
    End Sub

    Private Sub DockContextClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As ButtonItem = CType(sender, ButtonItem)
        If item Is Nothing Then Exit Sub

        If item.Name = "bc_tabnavigation" Then
            barTaskList.TabNavigation = Not item.Checked
            barTaskList.DockTabControl.Refresh()
            Exit Sub
        End If

        If barTaskList.Items.Contains(item.Name) Then
            BarUtilities.SetDockContainerVisible(CType(barTaskList.Items(item.Name), DockContainerItem), Not item.Checked)
        End If

        barTaskList.RecalcLayout()

    End Sub

    Private Function TabItemFromPoint(ByVal pClient As Point) As TabItem
        TabItemFromPoint = Nothing
        If Not tabStrip1.ClientRectangle.Contains(pClient) Then Exit Function

        Dim tab As TabItem
        For Each tab In tabStrip1.Tabs
            If tab.Visible And tab.DisplayRectangle.Contains(pClient) Then
                TabItemFromPoint = tab
                Exit Function
            End If
        Next
    End Function

    Private Sub ChangeDotNetBarStyle(ByVal style As eDotNetBarStyle)
        CType(dotNetBarManager1.GetItem("bStyle2007Blue"), ButtonItem).Checked = (style = eDotNetBarStyle.Office2007)
        CType(dotNetBarManager1.GetItem("bStyle2003"), ButtonItem).Checked = (style = eDotNetBarStyle.Office2003)
        CType(dotNetBarManager1.GetItem("bStyleXP"), ButtonItem).Checked = (style = eDotNetBarStyle.OfficeXP)
        CType(dotNetBarManager1.GetItem("bVS2005"), ButtonItem).Checked = (style = eDotNetBarStyle.VS2005)

        dotNetBarManager1.Style = style
        If style = eDotNetBarStyle.Office2003 Or style = eDotNetBarStyle.OfficeXP Then
            If dotNetBarManager1.IsThemeActive Then
                Dim item As BaseItem = dotNetBarManager1.GetItem("bThemes")
                item.Visible = True
                CType(item.ContainerControl, Bar).RecalcLayout()
            End If
        ElseIf dotNetBarManager1.IsThemeActive Then
            dotNetBarManager1.GetItem("bThemes").Visible = False
        End If
        If style = eDotNetBarStyle.Office2003 Or style = eDotNetBarStyle.Office2007 Then
            tabStrip1.Style = eTabStripStyle.OneNote
        ElseIf style = eDotNetBarStyle.VS2005 Then
            tabStrip1.Style = eTabStripStyle.VS2005
        Else
            tabStrip1.Style = eTabStripStyle.Flat
        End If
        ' Change status bar size
        barStatus.Style = style
    End Sub

    Private Sub timerInfoBallon_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerInfoBallon.Tick
        timerInfoBallon.Enabled = False
        m_InfoBalloon = New Balloon()
        m_InfoBalloon.CaptionImage = New Bitmap(GetType(frmMain), "Info.png")
        m_InfoBalloon.CaptionText = "New DotNetBar Feature Alert..."
        m_InfoBalloon.Text = "DotNetBar now includes Balloon control to help you convey your information effectively to the end-user.\nCheck out Find command implementation in this sample for an example of highly customized Balloon control."
        m_InfoBalloon.AutoResize()
        m_InfoBalloon.AutoCloseTimeOut = 10
        m_InfoBalloon.Owner = Me
        m_InfoBalloon.Show(cmdFind, False)
    End Sub

    Private Sub frmMain_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Move
        CloseInfoBalloon()
        CloseSearch()
    End Sub

    Private Sub CloseInfoBalloon()
        If Not m_InfoBalloon Is Nothing Then
            m_InfoBalloon.Close()
            m_InfoBalloon.Dispose()
            m_InfoBalloon = Nothing
        End If
    End Sub

    Private Sub CloseSearch()
        If (Not m_Search Is Nothing) Then
            m_Search.Close()
            m_Search.Dispose()
            m_Search = Nothing
        End If
    End Sub

    Public Sub SearchActiveDocument(ByVal text As String)
        Dim activedocument As frmDocument = CType(Me.ActiveMdiChild, frmDocument)
        If Not activedocument Is Nothing Then
            activedocument.ExecuteCommand("bFind", text)
        End If
    End Sub

    Private Sub dotNetBarManager1_BarClosing(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.BarClosingEventArgs) Handles dotNetBarManager1.BarClosing
        Dim bar As Bar = CType(sender, Bar)
        If bar Is Nothing Then Exit Sub

        If Not bar Is barTaskList Then Exit Sub

        If bar.VisibleItemCount > 1 Then
            e.Cancel = True
            bar.Items(bar.SelectedDockTab).Visible = False
            bar.RecalcLayout()
        End If
    End Sub
End Class
