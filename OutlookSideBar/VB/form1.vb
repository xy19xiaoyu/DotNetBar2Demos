Imports DevComponents.DotNetBar
Public Class Form1
    Inherits DevComponents.DotNetBar.Office2007Form

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
    Friend WithEvents imagesMedium As System.Windows.Forms.ImageList
    Friend WithEvents imagesSmall As System.Windows.Forms.ImageList
    Friend WithEvents dotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents sideBar1 As DevComponents.DotNetBar.SideBar
    Friend WithEvents sideBarPanelItem1 As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents bInbox As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bCalendar As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bContacts As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bTasks As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bNotes As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bDeletedItems As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents sideBarPanelItem2 As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents bDrafts As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bOutbox As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bSentItems As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bJournal As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bUpdate As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents listView1 As System.Windows.Forms.ListView
    Friend WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents bContextMenu As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bLargeIcons As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bSmallIcons As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bRemoveItem As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ExpandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.imagesMedium = New System.Windows.Forms.ImageList(Me.components)
        Me.imagesSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.dotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.sideBar1 = New DevComponents.DotNetBar.SideBar()
        Me.sideBarPanelItem1 = New DevComponents.DotNetBar.SideBarPanelItem()
        Me.bInbox = New DevComponents.DotNetBar.ButtonItem()
        Me.bCalendar = New DevComponents.DotNetBar.ButtonItem()
        Me.bContacts = New DevComponents.DotNetBar.ButtonItem()
        Me.bTasks = New DevComponents.DotNetBar.ButtonItem()
        Me.bNotes = New DevComponents.DotNetBar.ButtonItem()
        Me.bDeletedItems = New DevComponents.DotNetBar.ButtonItem()
        Me.sideBarPanelItem2 = New DevComponents.DotNetBar.SideBarPanelItem()
        Me.bDrafts = New DevComponents.DotNetBar.ButtonItem()
        Me.bOutbox = New DevComponents.DotNetBar.ButtonItem()
        Me.bSentItems = New DevComponents.DotNetBar.ButtonItem()
        Me.bJournal = New DevComponents.DotNetBar.ButtonItem()
        Me.bUpdate = New DevComponents.DotNetBar.ButtonItem()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.bContextMenu = New DevComponents.DotNetBar.ButtonItem()
        Me.bLargeIcons = New DevComponents.DotNetBar.ButtonItem()
        Me.bSmallIcons = New DevComponents.DotNetBar.ButtonItem()
        Me.bRemoveItem = New DevComponents.DotNetBar.ButtonItem()
        Me.ExpandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.panel1.SuspendLayout()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imagesMedium
        '
        Me.imagesMedium.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imagesMedium.ImageSize = New System.Drawing.Size(32, 32)
        Me.imagesMedium.ImageStream = CType(resources.GetObject("imagesMedium.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagesMedium.TransparentColor = System.Drawing.Color.Transparent
        '
        'imagesSmall
        '
        Me.imagesSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imagesSmall.ImageSize = New System.Drawing.Size(16, 16)
        Me.imagesSmall.ImageStream = CType(resources.GetObject("imagesSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagesSmall.TransparentColor = System.Drawing.Color.Transparent
        '
        'dotNetBarManager1
        '
        Me.dotNetBarManager1.BottomDockSite = Nothing
        Me.dotNetBarManager1.DefinitionName = ""
        Me.dotNetBarManager1.LeftDockSite = Nothing
        Me.dotNetBarManager1.ParentForm = Me
        Me.dotNetBarManager1.RightDockSite = Nothing
        Me.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.dotNetBarManager1.ToolbarBottomDockSite = Me.DockSite4
        Me.dotNetBarManager1.ToolbarLeftDockSite = Me.DockSite1
        Me.dotNetBarManager1.ToolbarRightDockSite = Me.DockSite2
        Me.dotNetBarManager1.ToolbarTopDockSite = Me.DockSite3
        Me.dotNetBarManager1.TopDockSite = Nothing
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.Location = New System.Drawing.Point(0, 254)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(408, 0)
        Me.DockSite4.TabIndex = 8
        Me.DockSite4.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 254)
        Me.DockSite1.TabIndex = 5
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.Location = New System.Drawing.Point(408, 0)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 254)
        Me.DockSite2.TabIndex = 6
        Me.DockSite2.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(408, 0)
        Me.DockSite3.TabIndex = 7
        Me.DockSite3.TabStop = False
        '
        'sideBar1
        '
        Me.sideBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.sideBar1.AllowDrop = True
        Me.sideBar1.AllowExternalDrop = True
        Me.sideBar1.BorderStyle = DevComponents.DotNetBar.eBorderType.None
        Me.ContextMenuBar1.SetContextMenuEx(Me.sideBar1, Me.bContextMenu)
        Me.sideBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.sideBar1.ExpandedPanel = Me.sideBarPanelItem1
        Me.sideBar1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.sideBar1.Images = Me.imagesSmall
        Me.sideBar1.ImagesMedium = Me.imagesMedium
        Me.sideBar1.Name = "sideBar1"
        Me.sideBar1.Panels.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.sideBarPanelItem1, Me.sideBarPanelItem2})
        Me.sideBar1.Size = New System.Drawing.Size(120, 254)
        Me.sideBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.sideBar1.TabIndex = 1
        Me.sideBar1.TabStop = False
        Me.sideBar1.UseNativeDragDrop = True
        '
        'sideBarPanelItem1
        '
        Me.sideBarPanelItem1.FontBold = True
        Me.sideBarPanelItem1.ItemImageSize = DevComponents.DotNetBar.eBarImageSize.Medium
        Me.sideBarPanelItem1.Name = "sideBarPanelItem1"
        Me.sideBarPanelItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bInbox, Me.bCalendar, Me.bContacts, Me.bTasks, Me.bNotes, Me.bDeletedItems})
        Me.sideBarPanelItem1.Text = "SideBar Panel"
        '
        'bInbox
        '
        Me.bInbox.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bInbox.ImageIndex = 0
        Me.bInbox.ImagePaddingHorizontal = 8
        Me.bInbox.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bInbox.Name = "bInbox"
        Me.bInbox.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.bInbox.Text = "Inbox"
        Me.bInbox.Tooltip = "Opens your Inbox"
        '
        'bCalendar
        '
        Me.bCalendar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bCalendar.ImageIndex = 1
        Me.bCalendar.ImagePaddingHorizontal = 8
        Me.bCalendar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bCalendar.Name = "bCalendar"
        Me.bCalendar.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.bCalendar.Text = "Calendar"
        Me.bCalendar.Tooltip = "Shows your Calendar"
        '
        'bContacts
        '
        Me.bContacts.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bContacts.ImageIndex = 2
        Me.bContacts.ImagePaddingHorizontal = 8
        Me.bContacts.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bContacts.Name = "bContacts"
        Me.bContacts.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.bContacts.Text = "Contacts"
        Me.bContacts.Tooltip = "Opens your Contacts"
        '
        'bTasks
        '
        Me.bTasks.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bTasks.ImageIndex = 3
        Me.bTasks.ImagePaddingHorizontal = 8
        Me.bTasks.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bTasks.Name = "bTasks"
        Me.bTasks.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.bTasks.Text = "Tasks"
        Me.bTasks.Tooltip = "Shows your Tasks"
        '
        'bNotes
        '
        Me.bNotes.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bNotes.ImageIndex = 4
        Me.bNotes.ImagePaddingHorizontal = 8
        Me.bNotes.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bNotes.Name = "bNotes"
        Me.bNotes.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.bNotes.Text = "Notes"
        Me.bNotes.Tooltip = "Shows your Notes"
        '
        'bDeletedItems
        '
        Me.bDeletedItems.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bDeletedItems.ImageIndex = 5
        Me.bDeletedItems.ImagePaddingHorizontal = 8
        Me.bDeletedItems.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.bDeletedItems.Name = "bDeletedItems"
        Me.bDeletedItems.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.bDeletedItems.Text = "Deleted Items"
        Me.bDeletedItems.Tooltip = "Shows Deleted Items"
        '
        'sideBarPanelItem2
        '
        Me.sideBarPanelItem2.FontBold = True
        Me.sideBarPanelItem2.Name = "sideBarPanelItem2"
        Me.sideBarPanelItem2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bDrafts, Me.bOutbox, Me.bSentItems, Me.bJournal, Me.bUpdate})
        Me.sideBarPanelItem2.Text = "My Shortcuts"
        '
        'bDrafts
        '
        Me.bDrafts.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bDrafts.ImageIndex = 6
        Me.bDrafts.ImagePaddingHorizontal = 8
        Me.bDrafts.Name = "bDrafts"
        Me.bDrafts.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.bDrafts.Text = "Drafts"
        Me.bDrafts.Tooltip = "Shows Document Drafts "
        '
        'bOutbox
        '
        Me.bOutbox.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bOutbox.ImageIndex = 7
        Me.bOutbox.ImagePaddingHorizontal = 8
        Me.bOutbox.Name = "bOutbox"
        Me.bOutbox.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.bOutbox.Text = "Outbox"
        Me.bOutbox.Tooltip = "Open Outbox Folder"
        '
        'bSentItems
        '
        Me.bSentItems.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bSentItems.ImageIndex = 8
        Me.bSentItems.ImagePaddingHorizontal = 8
        Me.bSentItems.Name = "bSentItems"
        Me.bSentItems.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.bSentItems.Text = "Sent Items"
        Me.bSentItems.Tooltip = "Open Sent Items Folder"
        '
        'bJournal
        '
        Me.bJournal.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bJournal.ImageIndex = 9
        Me.bJournal.ImagePaddingHorizontal = 8
        Me.bJournal.Name = "bJournal"
        Me.bJournal.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.bJournal.Text = "Journal"
        Me.bJournal.Tooltip = "Open the Journal"
        '
        'bUpdate
        '
        Me.bUpdate.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.bUpdate.ImageIndex = 10
        Me.bUpdate.ImagePaddingHorizontal = 8
        Me.bUpdate.Name = "bUpdate"
        Me.bUpdate.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.bUpdate.Text = "Update"
        Me.bUpdate.Tooltip = "Download software update..."
        '
        'panel1
        '
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.checkBox1, Me.label2, Me.listView1, Me.textBox1, Me.label1, Me.ContextMenuBar1})
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(120, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(288, 254)
        Me.panel1.TabIndex = 4
        '
        'checkBox1
        '
        Me.checkBox1.Location = New System.Drawing.Point(40, 232)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(128, 24)
        Me.checkBox1.TabIndex = 9
        Me.checkBox1.Text = "Multi-Column Layout"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(88, 64)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(176, 24)
        Me.label2.TabIndex = 6
        Me.label2.Text = "You can drag && drop items from and to the ListView"
        '
        'listView1
        '
        Me.listView1.AllowDrop = True
        Me.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listView1.HideSelection = False
        Me.listView1.LabelEdit = True
        Me.listView1.LargeImageList = Me.imagesMedium
        Me.listView1.Location = New System.Drawing.Point(88, 96)
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(176, 112)
        Me.listView1.SmallImageList = Me.imagesSmall
        Me.listView1.TabIndex = 5
        '
        'textBox1
        '
        Me.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.textBox1.Location = New System.Drawing.Point(12, 30)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(258, 20)
        Me.textBox1.TabIndex = 1
        Me.textBox1.Text = ""
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(10, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(81, 14)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Item Clicked:"
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bContextMenu})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(200, 232)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(96, 25)
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ContextMenuBar1.TabIndex = 9
        Me.ContextMenuBar1.TabStop = False
        '
        'bContextMenu
        '
        Me.bContextMenu.AutoExpandOnClick = True
        Me.bContextMenu.GlobalName = "bContextMenu"
        Me.bContextMenu.ImagePaddingHorizontal = 8
        Me.bContextMenu.Name = "bContextMenu"
        Me.bContextMenu.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bLargeIcons, Me.bSmallIcons, Me.bRemoveItem})
        Me.bContextMenu.Text = "bContextMenu"
        '
        'bLargeIcons
        '
        Me.bLargeIcons.GlobalName = "bLargeIcons"
        Me.bLargeIcons.Image = CType(resources.GetObject("bLargeIcons.Image"), System.Drawing.Bitmap)
        Me.bLargeIcons.ImagePaddingHorizontal = 8
        Me.bLargeIcons.Name = "bLargeIcons"
        Me.bLargeIcons.Text = "Large Icons"
        '
        'bSmallIcons
        '
        Me.bSmallIcons.GlobalName = "bSmallIcons"
        Me.bSmallIcons.Image = CType(resources.GetObject("bSmallIcons.Image"), System.Drawing.Bitmap)
        Me.bSmallIcons.ImagePaddingHorizontal = 8
        Me.bSmallIcons.Name = "bSmallIcons"
        Me.bSmallIcons.Text = "Small Icons"
        '
        'bRemoveItem
        '
        Me.bRemoveItem.BeginGroup = True
        Me.bRemoveItem.GlobalName = "bRemoveItem"
        Me.bRemoveItem.ImagePaddingHorizontal = 8
        Me.bRemoveItem.Name = "bRemoveItem"
        Me.bRemoveItem.Text = "Remove Item"
        '
        'ExpandableSplitter1
        '
        Me.ExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(CType(101, Byte), CType(147, Byte), CType(207, Byte))
        Me.ExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandableSplitter1.ExpandableControl = Me.sideBar1
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
        Me.ExpandableSplitter1.Size = New System.Drawing.Size(8, 254)
        Me.ExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.ExpandableSplitter1.TabIndex = 9
        Me.ExpandableSplitter1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(217, Byte), CType(247, Byte))
        Me.ClientSize = New System.Drawing.Size(408, 254)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.ExpandableSplitter1, Me.panel1, Me.sideBar1, Me.DockSite1, Me.DockSite2, Me.DockSite3, Me.DockSite4})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panel1.ResumeLayout(False)
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' We need to track "hot" item so we know which item to remove if user decides to do so
    Private m_HotItem As ButtonItem = Nothing
    Private m_InternalDragDrop As Boolean = False

    Private Sub sideBar1_ItemClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles sideBar1.ItemClick
        Dim item As BaseItem = CType(sender, BaseItem)
        If item Is Nothing Then Exit Sub
        textBox1.Text = item.Text + " (" + item.Name + ")"
    End Sub

    Private Sub sideBar1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sideBar1.MouseDown
        If e.Button = MouseButtons.Right And TypeOf (sender) Is ButtonItem Then
            m_HotItem = CType(sender, ButtonItem)
        Else
            m_HotItem = Nothing
        End If
    End Sub

    Private Sub listView1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles listView1.DragDrop
        If m_InternalDragDrop Then Exit Sub

        Dim item As ButtonItem = e.Data.GetData("DevComponents.DotNetBar.ButtonItem")
        If item Is Nothing Then Exit Sub

        listView1.Items.Add(item.Text, item.ImageIndex)
        item.Parent.SubItems.Remove(item)
    End Sub

    Private Sub listView1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles listView1.DragEnter
        If m_InternalDragDrop Then Exit Sub
        If e.Data.GetData("DevComponents.DotNetBar.ButtonItem") Is Nothing Then
            e.Effect = DragDropEffects.None
        Else
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    Private Sub listView1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listView1.MouseMove
        If e.Button = MouseButtons.Left And (Math.Abs(e.X) >= 4 Or Math.Abs(e.Y) >= 4) Then
            If listView1.SelectedItems.Count = 1 Then
                Dim item As ButtonItem = New ButtonItem("dragitem", listView1.SelectedItems(0).Text)
                item.ImageIndex = listView1.SelectedItems(0).ImageIndex
                item.ButtonStyle = eButtonStyle.ImageAndText
                item.ImagePosition = eImagePosition.Top
                m_InternalDragDrop = True
                If listView1.DoDragDrop(item, DragDropEffects.All) = DragDropEffects.Move Then
                    listView1.Items.Remove(listView1.SelectedItems(0))
                End If
                m_InternalDragDrop = False
            End If
        End If
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Dim layout As eSideBarLayoutType = eSideBarLayoutType.Default
        If checkBox1.Checked Then layout = eSideBarLayoutType.MultiColumn
        Dim panel As SideBarPanelItem
        For Each panel In sideBar1.Panels
            panel.LayoutType = eSideBarLayoutType.MultiColumn
        Next
        sideBar1.RecalcLayout()
    End Sub

    Private Sub bLargeIcons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLargeIcons.Click
        If Not sideBar1.ExpandedPanel Is Nothing Then sideBar1.ExpandedPanel.ItemImageSize = eBarImageSize.Medium
    End Sub

    Private Sub bSmallIcons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSmallIcons.Click
        If Not sideBar1.ExpandedPanel Is Nothing Then sideBar1.ExpandedPanel.ItemImageSize = eBarImageSize.Default
    End Sub

    Private Sub bRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRemoveItem.Click
        If Not m_HotItem Is Nothing Then
            If MessageBox.Show("Are you sure you want to remove '" + m_HotItem.Text + "'?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                m_HotItem.Parent.SubItems.Remove(m_HotItem)
                m_HotItem = Nothing
            End If
        End If
    End Sub

    Private Sub ContextMenuBar1_PopupOpen(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.PopupOpenEventArgs) Handles ContextMenuBar1.PopupOpen
        If Not sideBar1.ExpandedPanel Is Nothing Then
            If sideBar1.ExpandedPanel.ItemImageSize = eBarImageSize.Default Then
                bSmallIcons.Checked = True
                bLargeIcons.Checked = False
            Else
                bSmallIcons.Checked = False
                bLargeIcons.Checked = True
            End If
        End If

        ' Enable the Remove Item button if item can be removed
        If m_HotItem Is Nothing Then
            bRemoveItem.Enabled = False
        Else
            bRemoveItem.Enabled = True
        End If
    End Sub
End Class
