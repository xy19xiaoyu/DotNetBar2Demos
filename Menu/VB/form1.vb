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
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents barTopDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barBottomDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barLeftDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barRightDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents MdiClient1 As System.Windows.Forms.MdiClient
    Private components As System.ComponentModel.IContainer

    'Required by the Windows Form Designer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents mainmenu As DevComponents.DotNetBar.Bar
    Friend WithEvents item_50 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mNew As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mTextFile As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mXMLDocument As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mHTMLDocument As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mOpen As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mExit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents item_55 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mAbout As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mSwitch As DevComponents.DotNetBar.ButtonItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.MdiClient1 = New System.Windows.Forms.MdiClient()
        Me.barLeftDockSite = New DevComponents.DotNetBar.DockSite()
        Me.barTopDockSite = New DevComponents.DotNetBar.DockSite()
        Me.barRightDockSite = New DevComponents.DotNetBar.DockSite()
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.barBottomDockSite = New DevComponents.DotNetBar.DockSite()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.mainmenu = New DevComponents.DotNetBar.Bar()
        Me.item_50 = New DevComponents.DotNetBar.ButtonItem()
        Me.mNew = New DevComponents.DotNetBar.ButtonItem()
        Me.mTextFile = New DevComponents.DotNetBar.ButtonItem()
        Me.mXMLDocument = New DevComponents.DotNetBar.ButtonItem()
        Me.mHTMLDocument = New DevComponents.DotNetBar.ButtonItem()
        Me.mOpen = New DevComponents.DotNetBar.ButtonItem()
        Me.mExit = New DevComponents.DotNetBar.ButtonItem()
        Me.item_55 = New DevComponents.DotNetBar.ButtonItem()
        Me.mAbout = New DevComponents.DotNetBar.ButtonItem()
        Me.mSwitch = New DevComponents.DotNetBar.ButtonItem()
        Me.DockSite3.SuspendLayout()
        CType(Me.mainmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MdiClient1
        '
        Me.MdiClient1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MdiClient1.Location = New System.Drawing.Point(0, 25)
        Me.MdiClient1.Name = "MdiClient1"
        Me.MdiClient1.TabIndex = 5
        '
        'barLeftDockSite
        '
        Me.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left
        Me.barLeftDockSite.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.barLeftDockSite.Location = New System.Drawing.Point(0, 25)
        Me.barLeftDockSite.Name = "barLeftDockSite"
        Me.barLeftDockSite.Size = New System.Drawing.Size(0, 228)
        Me.barLeftDockSite.TabIndex = 3
        Me.barLeftDockSite.TabStop = False
        '
        'barTopDockSite
        '
        Me.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top
        Me.barTopDockSite.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.barTopDockSite.Location = New System.Drawing.Point(0, 25)
        Me.barTopDockSite.Name = "barTopDockSite"
        Me.barTopDockSite.Size = New System.Drawing.Size(396, 0)
        Me.barTopDockSite.TabIndex = 1
        Me.barTopDockSite.TabStop = False
        '
        'barRightDockSite
        '
        Me.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right
        Me.barRightDockSite.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.barRightDockSite.Location = New System.Drawing.Point(396, 25)
        Me.barRightDockSite.Name = "barRightDockSite"
        Me.barRightDockSite.Size = New System.Drawing.Size(0, 228)
        Me.barRightDockSite.TabIndex = 4
        Me.barRightDockSite.TabStop = False
        '
        'DotNetBarManager1
        '
        Me.DotNetBarManager1.BottomDockSite = Me.barBottomDockSite
        Me.DotNetBarManager1.DefinitionName = ""
        Me.DotNetBarManager1.LeftDockSite = Me.barLeftDockSite
        Me.DotNetBarManager1.ParentForm = Me
        Me.DotNetBarManager1.RightDockSite = Me.barRightDockSite
        Me.DotNetBarManager1.ShowCustomizeContextMenu = False
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
        Me.barBottomDockSite.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.barBottomDockSite.Location = New System.Drawing.Point(0, 253)
        Me.barBottomDockSite.Name = "barBottomDockSite"
        Me.barBottomDockSite.Size = New System.Drawing.Size(396, 0)
        Me.barBottomDockSite.TabIndex = 2
        Me.barBottomDockSite.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.Location = New System.Drawing.Point(0, 25)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 228)
        Me.DockSite1.TabIndex = 6
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.Location = New System.Drawing.Point(396, 25)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 228)
        Me.DockSite2.TabIndex = 7
        Me.DockSite2.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Controls.AddRange(New System.Windows.Forms.Control() {Me.mainmenu})
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(396, 25)
        Me.DockSite3.TabIndex = 8
        Me.DockSite3.TabStop = False
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.Location = New System.Drawing.Point(0, 253)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(396, 0)
        Me.DockSite4.TabIndex = 9
        Me.DockSite4.TabStop = False
        '
        'mainmenu
        '
        Me.mainmenu.AccessibleDescription = "Main Menu (mainmenu)"
        Me.mainmenu.AccessibleName = "Main Menu"
        Me.mainmenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.mainmenu.DockSide = DevComponents.DotNetBar.eDockSide.Top
        Me.mainmenu.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.item_50, Me.item_55, Me.mSwitch})
        Me.mainmenu.MenuBar = True
        Me.mainmenu.Name = "mainmenu"
        Me.mainmenu.Size = New System.Drawing.Size(396, 24)
        Me.mainmenu.Stretch = True
        Me.mainmenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.mainmenu.TabIndex = 0
        Me.mainmenu.TabStop = False
        Me.mainmenu.Text = "Main Menu"
        '
        'item_50
        '
        Me.item_50.GlobalName = "item_50"
        Me.item_50.Name = "item_50"
        Me.item_50.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.item_50.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mNew, Me.mOpen, Me.mExit})
        Me.item_50.Text = "&File"
        '
        'mNew
        '
        Me.mNew.GlobalName = "mNew"
        Me.mNew.Image = CType(resources.GetObject("mNew.Image"), System.Drawing.Bitmap)
        Me.mNew.Name = "mNew"
        Me.mNew.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.mNew.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN)
        Me.mNew.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mTextFile, Me.mXMLDocument, Me.mHTMLDocument})
        Me.mNew.Text = "&New"
        '
        'mTextFile
        '
        Me.mTextFile.GlobalName = "mTextFile"
        Me.mTextFile.Name = "mTextFile"
        Me.mTextFile.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.mTextFile.Text = "&Text File"
        '
        'mXMLDocument
        '
        Me.mXMLDocument.GlobalName = "mXMLDocument"
        Me.mXMLDocument.Name = "mXMLDocument"
        Me.mXMLDocument.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.mXMLDocument.Text = "&XML Document"
        '
        'mHTMLDocument
        '
        Me.mHTMLDocument.GlobalName = "mHTMLDocument"
        Me.mHTMLDocument.Name = "mHTMLDocument"
        Me.mHTMLDocument.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.mHTMLDocument.Text = "&HTML Document"
        '
        'mOpen
        '
        Me.mOpen.GlobalName = "mOpen"
        Me.mOpen.Image = CType(resources.GetObject("mOpen.Image"), System.Drawing.Bitmap)
        Me.mOpen.Name = "mOpen"
        Me.mOpen.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.mOpen.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlO)
        Me.mOpen.Text = "&Open"
        '
        'mExit
        '
        Me.mExit.BeginGroup = True
        Me.mExit.GlobalName = "mExit"
        Me.mExit.Name = "mExit"
        Me.mExit.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.mExit.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.mExit.Text = "&Exit"
        '
        'item_55
        '
        Me.item_55.GlobalName = "item_55"
        Me.item_55.Name = "item_55"
        Me.item_55.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.item_55.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mAbout})
        Me.item_55.Text = "&Help"
        '
        'mAbout
        '
        Me.mAbout.GlobalName = "mAbout"
        Me.mAbout.Name = "mAbout"
        Me.mAbout.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.mAbout.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F1)
        Me.mAbout.Text = "&About"
        '
        'mSwitch
        '
        Me.mSwitch.GlobalName = "mSwitch"
        Me.mSwitch.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.mSwitch.Name = "mSwitch"
        Me.mSwitch.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.mSwitch.ShowSubItems = False
        Me.mSwitch.Text = "Switch Style"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(396, 253)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.barTopDockSite, Me.barBottomDockSite, Me.barLeftDockSite, Me.barRightDockSite, Me.DockSite1, Me.DockSite2, Me.DockSite3, Me.DockSite4, Me.MdiClient1})
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.DockSite3.ResumeLayout(False)
        CType(Me.mainmenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub DotNetBarManager1_ItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles DotNetBarManager1.ItemClick
        Dim item As BaseItem
        Dim bar As Bar
        item = CType(sender, BaseItem)
        If item.Name = "mExit" Then
            Me.Close()
        ElseIf item.Name = "mOpen" Or item.Name = "mTextFile" Or item.Name = "mXMLDocument" Or item.Name = "mHTMLDocument" Then
            MessageBox.Show("Item " + item.Name + " Clicked.")
        ElseIf item.Name = "mAbout" Then
            MessageBox.Show("DevComponents DotNetBar Framework component")
        ElseIf item.Name = "mSwitch" Then
            For Each bar In DotNetBarManager1.Bars
                If bar.Style = eDotNetBarStyle.Office2003 Then
                    bar.Style = eDotNetBarStyle.VS2005
                Else
                    bar.Style = eDotNetBarStyle.Office2003
                End If
            Next
        End If
    End Sub
End Class
