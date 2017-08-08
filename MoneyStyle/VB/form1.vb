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
    Friend WithEvents listView1 As System.Windows.Forms.ListView
    Friend WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents barLeftDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barRightDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barTopDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barBottomDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.columnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.barBottomDockSite = New DevComponents.DotNetBar.DockSite()
        Me.barLeftDockSite = New DevComponents.DotNetBar.DockSite()
        Me.barRightDockSite = New DevComponents.DotNetBar.DockSite()
        Me.barTopDockSite = New DevComponents.DotNetBar.DockSite()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.SuspendLayout()
        '
        'listView1
        '
        Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1})
        Me.listView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listView1.FullRowSelect = True
        Me.listView1.GridLines = True
        Me.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(528, 266)
        Me.listView1.TabIndex = 5
        Me.listView1.View = System.Windows.Forms.View.Details
        '
        'columnHeader1
        '
        Me.columnHeader1.Width = 523
        '
        'DotNetBarManager1
        '
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins)
        Me.DotNetBarManager1.BottomDockSite = Me.barBottomDockSite
        Me.DotNetBarManager1.DefinitionName = ""
        Me.DotNetBarManager1.LeftDockSite = Me.barLeftDockSite
        Me.DotNetBarManager1.ParentForm = Me
        Me.DotNetBarManager1.RightDockSite = Me.barRightDockSite
        Me.DotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.DotNetBarManager1.ToolbarBottomDockSite = Me.DockSite4
        Me.DotNetBarManager1.ToolbarLeftDockSite = Me.DockSite1
        Me.DotNetBarManager1.ToolbarRightDockSite = Me.DockSite2
        Me.DotNetBarManager1.ToolbarTopDockSite = Me.DockSite3
        Me.DotNetBarManager1.TopDockSite = Me.barTopDockSite
        '
        'barBottomDockSite
        '
        Me.barBottomDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barBottomDockSite.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barBottomDockSite.Location = New System.Drawing.Point(0, 266)
        Me.barBottomDockSite.Name = "barBottomDockSite"
        Me.barBottomDockSite.Size = New System.Drawing.Size(528, 0)
        Me.barBottomDockSite.TabIndex = 9
        Me.barBottomDockSite.TabStop = False
        '
        'barLeftDockSite
        '
        Me.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left
        Me.barLeftDockSite.Name = "barLeftDockSite"
        Me.barLeftDockSite.Size = New System.Drawing.Size(0, 266)
        Me.barLeftDockSite.TabIndex = 6
        Me.barLeftDockSite.TabStop = False
        '
        'barRightDockSite
        '
        Me.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right
        Me.barRightDockSite.Location = New System.Drawing.Point(528, 0)
        Me.barRightDockSite.Name = "barRightDockSite"
        Me.barRightDockSite.Size = New System.Drawing.Size(0, 266)
        Me.barRightDockSite.TabIndex = 7
        Me.barRightDockSite.TabStop = False
        '
        'barTopDockSite
        '
        Me.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top
        Me.barTopDockSite.Name = "barTopDockSite"
        Me.barTopDockSite.Size = New System.Drawing.Size(528, 0)
        Me.barTopDockSite.TabIndex = 8
        Me.barTopDockSite.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 266)
        Me.DockSite1.TabIndex = 10
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.Location = New System.Drawing.Point(528, 0)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 266)
        Me.DockSite2.TabIndex = 11
        Me.DockSite2.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(528, 0)
        Me.DockSite3.TabIndex = 12
        Me.DockSite3.TabStop = False
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.Location = New System.Drawing.Point(0, 266)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(528, 0)
        Me.DockSite4.TabIndex = 13
        Me.DockSite4.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 266)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.listView1, Me.barLeftDockSite, Me.barRightDockSite, Me.barTopDockSite, Me.barBottomDockSite, Me.DockSite1, Me.DockSite2, Me.DockSite3, Me.DockSite4})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateToolbar()
    End Sub

    Private Sub CreateToolbar()
        ' Suspend layout to optimize for multiple bars/items creation
        Me.DotNetBarManager1.SuspendLayout = True

        ' This style does not need menu shadows...
        Me.DotNetBarManager1.MenuDropShadow = DevComponents.DotNetBar.eMenuDropShadow.Hide
        ' Add general click handler...
        AddHandler DotNetBarManager1.ItemClick, AddressOf ItemClick

        Dim bar As Bar

        ' Menu Bar
        bar = New Bar("Menu")
        bar.Stretch = True
        bar.MenuBar = True
        SetMenuColorScheme(bar.ColorScheme)

        Dim Menu As ButtonItem, MenuItem As ButtonItem

        ' File
        Menu = New ButtonItem("mFile", "&File")
        bar.Items.Add(Menu)
        ' New
        MenuItem = New ButtonItem("mNew", "New")
        Menu.SubItems.Add(MenuItem)
        ' Open
        MenuItem = New ButtonItem("mOpen", "&Open")
        MenuItem.Shortcuts.Add(eShortcut.CtrlO)
        Menu.SubItems.Add(MenuItem)
        ' Password manager
        MenuItem = New ButtonItem("mPasswordManager", "Password Manager")
        MenuItem.BeginGroup = True
        Menu.SubItems.Add(MenuItem)
        ' Backup
        MenuItem = New ButtonItem("mBackup", "&Back Up...")
        MenuItem.BeginGroup = True
        Menu.SubItems.Add(MenuItem)
        ' Restore
        MenuItem = New ButtonItem("mRestore", "&Restore...")
        Menu.SubItems.Add(MenuItem)
        ' Archive
        MenuItem = New ButtonItem("mArchive", "&Archive...")
        Menu.SubItems.Add(MenuItem)
        ' Exit
        MenuItem = New ButtonItem("mExit", "E&xit")
        MenuItem.BeginGroup = True
        Menu.SubItems.Add(MenuItem)

        ' Edit
        Menu = New ButtonItem("mEdit", "&Edit")
        bar.Items.Add(Menu)
        ' New
        MenuItem = New ButtonItem("mUndo", "Undo")
        MenuItem.Shortcuts.Add(eShortcut.CtrlZ)
        Menu.SubItems.Add(MenuItem)
        ' Cut
        MenuItem = New ButtonItem("mCut", "Cut")
        MenuItem.Shortcuts.Add(eShortcut.CtrlX)
        MenuItem.BeginGroup = True
        Menu.SubItems.Add(MenuItem)
        ' Copy
        MenuItem = New ButtonItem("mCopy", "Copy")
        MenuItem.Shortcuts.Add(eShortcut.CtrlC)
        Menu.SubItems.Add(MenuItem)
        ' Paste
        MenuItem = New ButtonItem("mPaste", "Paste")
        MenuItem.Shortcuts.Add(eShortcut.CtrlV)
        Menu.SubItems.Add(MenuItem)

        ' Must add bar to the bars collection so DotNetBarManager is aware of it
        DotNetBarManager1.Bars.Add(bar)
        ' After manager is aware of the bar, we can dock it on appropriate side
        bar.DockSide = eDockSide.Top


        ' Standard Toolbar
        bar = New Bar("Standard")
        bar.Name = "barStandard"
        bar.Stretch = True
        bar.EqualButtonSize = True
        bar.DisplayMoreItemsOnMenu = True
        bar.BackgroundImage = New Bitmap(Me.GetType(), "background.png")
        bar.BackgroundImagePosition = eBackgroundImagePosition.Tile
        SetToolbarColorScheme(bar.ColorScheme)

        ' Must add bar to the bars collection so DotNetBarManager is aware of it
        DotNetBarManager1.Bars.Add(bar)
        ' Set the inital docking line
        bar.DockLine = 1
        ' After manager is aware of the bar, we can dock it on appropriate side
        bar.DockSide = eDockSide.Top

        ' Account List
        bar.Items.Add(CreateToolbarButton("bAccountList", "Account List", "AccountList.png", "AccountListHot.png"))
        ' Portofolio
        bar.Items.Add(CreateToolbarButton("bPortofolio", "Portofolio", "Portofolio.png", "PortofolioHot.png"))
        ' Bills and Deposits
        bar.Items.Add(CreateToolbarButton("bBills", "Bills && Deposits", "BillsAndDeposits.png", "BillsAndDepositsHot.png"))
        ' Reports
        bar.Items.Add(CreateToolbarButton("bReports", "Reports", "Reports.png", "ReportsHot.png"))
        ' Cash Flow
        bar.Items.Add(CreateToolbarButton("bCashFlow", "Cash Flow", "CashFlow.png", "CashFlowHot.png"))
        ' Budget
        bar.Items.Add(CreateToolbarButton("bBudget", "Budget", "Budget.png", "BudgetHot.png"))

        ' Bottom bar...
        ' Standard Toolbar
        bar = New Bar("BottomBar")
        bar.Name = "barBottom"
        bar.Stretch = True
        bar.EqualButtonSize = True
        bar.DisplayMoreItemsOnMenu = True
        bar.BackgroundImage = New Bitmap(Me.GetType(), "background.png")
        bar.BackgroundImagePosition = eBackgroundImagePosition.Tile
        SetToolbarColorScheme(bar.ColorScheme)

        ' Must add bar to the bars collection so DotNetBarManager is aware of it
        DotNetBarManager1.Bars.Add(bar)
        ' After manager is aware of the bar, we can dock it on appropriate side
        bar.DockSide = eDockSide.Bottom

        Dim label As LabelItem = New LabelItem("lStatus", "Online")
        label.PaddingTop = 2
        label.PaddingBottom = 2
        label.Width = 64
        label.TextAlignment = StringAlignment.Center
        label.ForeColor = Color.FromArgb(247, 222, 156)
        bar.Items.Add(label)

        Dim button As ButtonItem = New ButtonItem("bInternetUpdates", "Internet Updates...")
        button.BeginGroup = True
        button.HotTrackingStyle = eHotTrackingStyle.None
        button.Cursor = Cursors.Hand
        AddHandler button.Click, AddressOf InternetUpdates
        bar.Items.Add(button)

        ' Resume layout
        Me.DotNetBarManager1.SuspendLayout = False
    End Sub

    Private Sub SetToolbarColorScheme(ByVal scheme As ColorScheme)
        ' Setup toolbar custom color scheme...
        scheme.ItemText = Color.White
        scheme.ItemHotText = Color.FromArgb(247, 222, 156)
        scheme.ItemPressedText = Color.FromArgb(247, 222, 156)
        ' This portion of color scheme changes is used only for overflow items
        ' i.e. if they cannot fit on toolbar they are displayed on menu
        scheme.ItemHotBackground = Color.FromArgb(80, 80, 80)
        scheme.ItemHotBorder = Color.FromArgb(80, 80, 80)
        scheme.ItemPressedBackground = Color.FromArgb(91, 91, 91)
        scheme.ItemPressedBorder = Color.FromArgb(91, 91, 91)
        scheme.ItemExpandedText = Color.FromArgb(247, 222, 156)
        scheme.ItemExpandedBackground = Color.FromArgb(91, 91, 91)
        scheme.ItemExpandedShadow = Color.Empty
        scheme.MenuBackground = Color.FromArgb(91, 91, 91)
        scheme.MenuBarBackground = Color.FromArgb(91, 91, 91)
        scheme.MenuBorder = Color.Black
        scheme.MenuSide = Color.FromArgb(91, 91, 91)
    End Sub

    Private Sub SetMenuColorScheme(ByVal scheme As ColorScheme)
        ' Setup custom menu color scheme
        scheme.BarBackground = Color.FromArgb(91, 91, 91)
        scheme.MenuBackground = Color.FromArgb(91, 91, 91)
        scheme.MenuBarBackground = Color.FromArgb(91, 91, 91)
        scheme.MenuBorder = Color.Black
        scheme.MenuSide = Color.FromArgb(91, 91, 91)
        scheme.ItemBackground = Color.FromArgb(91, 91, 91)
        scheme.ItemText = Color.White
        scheme.ItemHotBackground = Color.FromArgb(80, 80, 80)
        scheme.ItemHotBorder = Color.FromArgb(80, 80, 80)
        scheme.ItemHotText = Color.FromArgb(247, 222, 156)
        scheme.ItemPressedText = Color.FromArgb(247, 222, 156)
        scheme.ItemPressedBackground = Color.FromArgb(91, 91, 91)
        scheme.ItemPressedBorder = Color.FromArgb(91, 91, 91)
        scheme.ItemExpandedText = Color.FromArgb(247, 222, 156)
        scheme.ItemExpandedBackground = Color.FromArgb(91, 91, 91)
        scheme.ItemExpandedShadow = Color.Empty
    End Sub

    Private Function CreateToolbarButton(ByVal name As String, ByVal text As String, ByVal imageName As String, ByVal hotImageName As String) As ButtonItem
        Dim button As ButtonItem = New ButtonItem(name, text)
        button.Image = New Bitmap(Me.GetType(), imageName)
        button.HoverImage = New Bitmap(Me.GetType(), hotImageName)
        button.PressedImage = button.HoverImage
        button.HotTrackingStyle = eHotTrackingStyle.None
        button.ButtonStyle = eButtonStyle.ImageAndText
        button.ImagePosition = eImagePosition.Top
        button.Cursor = Cursors.Hand
        CreateToolbarButton = button
    End Function

    Private Sub InternetUpdates(ByVal sender As Object, ByVal e As EventArgs)
        listView1.Items.Insert(0, "Internet Updates Item Click Handler")
    End Sub

    Private Sub ItemClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As BaseItem = CType(sender, BaseItem)
        listView1.Items.Insert(0, item.Text + " Global Click Handler")
    End Sub
End Class
