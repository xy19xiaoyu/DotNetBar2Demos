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
    Friend WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdPopupMenu As System.Windows.Forms.Button
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents cmdPopupBar As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents barTopDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barBottomDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barLeftDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barRightDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Private components As System.ComponentModel.IContainer

    'Required by the Windows Form Designer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents ContextMenuBar1 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents bRichPopup As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bCut As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bCopy As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bPaste As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bDelete As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents bSelectAll As DevComponents.DotNetBar.ButtonItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.barBottomDockSite = New DevComponents.DotNetBar.DockSite()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.barTopDockSite = New DevComponents.DotNetBar.DockSite()
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.barRightDockSite = New DevComponents.DotNetBar.DockSite()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cmdPopupBar = New System.Windows.Forms.Button()
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.barLeftDockSite = New DevComponents.DotNetBar.DockSite()
        Me.cmdPopupMenu = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.ContextMenuBar1 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.bRichPopup = New DevComponents.DotNetBar.ButtonItem()
        Me.bCut = New DevComponents.DotNetBar.ButtonItem()
        Me.bCopy = New DevComponents.DotNetBar.ButtonItem()
        Me.bPaste = New DevComponents.DotNetBar.ButtonItem()
        Me.bDelete = New DevComponents.DotNetBar.ButtonItem()
        Me.bSelectAll = New DevComponents.DotNetBar.ButtonItem()
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barBottomDockSite
        '
        Me.barBottomDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barBottomDockSite.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barBottomDockSite.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.barBottomDockSite.Location = New System.Drawing.Point(0, 273)
        Me.barBottomDockSite.Name = "barBottomDockSite"
        Me.barBottomDockSite.Size = New System.Drawing.Size(396, 0)
        Me.barBottomDockSite.TabIndex = 4
        Me.barBottomDockSite.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 15)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Silver
        '
        'barTopDockSite
        '
        Me.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top
        Me.barTopDockSite.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.barTopDockSite.Name = "barTopDockSite"
        Me.barTopDockSite.Size = New System.Drawing.Size(396, 0)
        Me.barTopDockSite.TabIndex = 3
        Me.barTopDockSite.TabStop = False
        '
        'richTextBox1
        '
        Me.richTextBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.ContextMenuBar1.SetContextMenuEx(Me.richTextBox1, Me.bRichPopup)
        Me.richTextBox1.Location = New System.Drawing.Point(8, 8)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(280, 256)
        Me.richTextBox1.TabIndex = 0
        Me.richTextBox1.Text = "Right-click in this edit box to show context menu"
        '
        'barRightDockSite
        '
        Me.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right
        Me.barRightDockSite.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.barRightDockSite.Location = New System.Drawing.Point(396, 0)
        Me.barRightDockSite.Name = "barRightDockSite"
        Me.barRightDockSite.Size = New System.Drawing.Size(0, 273)
        Me.barRightDockSite.TabIndex = 6
        Me.barRightDockSite.TabStop = False
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "VS.NET 2005"
        Me.ComboItem2.TextLineAlignment = System.Drawing.StringAlignment.Center
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Office 2003"
        Me.ComboItem1.TextLineAlignment = System.Drawing.StringAlignment.Center
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.ComboBoxEx1.DisableInternalDrawing = False
        Me.ComboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEx1.DropDownWidth = 88
        Me.ComboBoxEx1.Images = Nothing
        Me.ComboBoxEx1.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.ComboBoxEx1.Location = New System.Drawing.Point(300, 12)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(88, 21)
        Me.ComboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.ComboBoxEx1.TabIndex = 2
        '
        'cmdPopupBar
        '
        Me.cmdPopupBar.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.cmdPopupBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPopupBar.Location = New System.Drawing.Point(296, 76)
        Me.cmdPopupBar.Name = "cmdPopupBar"
        Me.cmdPopupBar.Size = New System.Drawing.Size(92, 24)
        Me.cmdPopupBar.TabIndex = 1
        Me.cmdPopupBar.Text = "Popup Bar"
        '
        'DotNetBarManager1
        '
        Me.DotNetBarManager1.BottomDockSite = Me.barBottomDockSite
        Me.DotNetBarManager1.DefinitionName = ""
        Me.DotNetBarManager1.Images = Me.ImageList1
        Me.DotNetBarManager1.LeftDockSite = Me.barLeftDockSite
        Me.DotNetBarManager1.ParentForm = Me
        Me.DotNetBarManager1.RightDockSite = Me.barRightDockSite
        Me.DotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.DotNetBarManager1.ToolbarBottomDockSite = Me.DockSite4
        Me.DotNetBarManager1.ToolbarLeftDockSite = Me.DockSite1
        Me.DotNetBarManager1.ToolbarRightDockSite = Me.DockSite2
        Me.DotNetBarManager1.ToolbarTopDockSite = Me.DockSite3
        Me.DotNetBarManager1.TopDockSite = Me.barTopDockSite
        '
        'barLeftDockSite
        '
        Me.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left
        Me.barLeftDockSite.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.barLeftDockSite.Name = "barLeftDockSite"
        Me.barLeftDockSite.Size = New System.Drawing.Size(0, 273)
        Me.barLeftDockSite.TabIndex = 5
        Me.barLeftDockSite.TabStop = False
        '
        'cmdPopupMenu
        '
        Me.cmdPopupMenu.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.cmdPopupMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPopupMenu.Location = New System.Drawing.Point(296, 44)
        Me.cmdPopupMenu.Name = "cmdPopupMenu"
        Me.cmdPopupMenu.Size = New System.Drawing.Size(92, 24)
        Me.cmdPopupMenu.TabIndex = 1
        Me.cmdPopupMenu.Text = "Popup Menu"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Location = New System.Drawing.Point(296, 240)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(92, 24)
        Me.cmdClose.TabIndex = 1
        Me.cmdClose.Text = "&Close"
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 273)
        Me.DockSite1.TabIndex = 7
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.Location = New System.Drawing.Point(396, 0)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 273)
        Me.DockSite2.TabIndex = 8
        Me.DockSite2.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(396, 0)
        Me.DockSite3.TabIndex = 9
        Me.DockSite3.TabStop = False
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.Location = New System.Drawing.Point(0, 273)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(396, 0)
        Me.DockSite4.TabIndex = 10
        Me.DockSite4.TabStop = False
        '
        'ContextMenuBar1
        '
        Me.ContextMenuBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bRichPopup})
        Me.ContextMenuBar1.Location = New System.Drawing.Point(272, 112)
        Me.ContextMenuBar1.Name = "ContextMenuBar1"
        Me.ContextMenuBar1.Size = New System.Drawing.Size(120, 25)
        Me.ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.ContextMenuBar1.TabIndex = 11
        Me.ContextMenuBar1.TabStop = False
        '
        'bRichPopup
        '
        Me.bRichPopup.AutoExpandOnClick = True
        Me.bRichPopup.GlobalName = "bRichPopup"
        Me.bRichPopup.Name = "bRichPopup"
        Me.bRichPopup.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bRichPopup.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.bCut, Me.bCopy, Me.bPaste, Me.bDelete, Me.bSelectAll})
        Me.bRichPopup.Text = "Rich Edit Popup"
        '
        'bCut
        '
        Me.bCut.GlobalName = "bCut"
        Me.bCut.ImageIndex = 0
        Me.bCut.Name = "bCut"
        Me.bCut.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bCut.Text = "Cu&t"
        '
        'bCopy
        '
        Me.bCopy.GlobalName = "bCopy"
        Me.bCopy.ImageIndex = 1
        Me.bCopy.Name = "bCopy"
        Me.bCopy.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bCopy.Text = "&Copy"
        '
        'bPaste
        '
        Me.bPaste.GlobalName = "bPaste"
        Me.bPaste.ImageIndex = 2
        Me.bPaste.Name = "bPaste"
        Me.bPaste.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bPaste.Text = "&Paste"
        '
        'bDelete
        '
        Me.bDelete.GlobalName = "bDelete"
        Me.bDelete.Name = "bDelete"
        Me.bDelete.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bDelete.Text = "&Delete"
        '
        'bSelectAll
        '
        Me.bSelectAll.BeginGroup = True
        Me.bSelectAll.GlobalName = "bSelectAll"
        Me.bSelectAll.Name = "bSelectAll"
        Me.bSelectAll.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault
        Me.bSelectAll.Text = "Select &All"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(396, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.ContextMenuBar1, Me.cmdClose, Me.cmdPopupBar, Me.ComboBoxEx1, Me.cmdPopupMenu, Me.richTextBox1, Me.barTopDockSite, Me.barBottomDockSite, Me.barLeftDockSite, Me.barRightDockSite, Me.DockSite1, Me.DockSite2, Me.DockSite3, Me.DockSite4})
        Me.Name = "Form1"
        Me.Text = "DotNetBar Popup Sample"
        CType(Me.ContextMenuBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private m_PopupFromCode As DevComponents.DotNetBar.ButtonItem

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBoxEx1.SelectedIndex = 0
    End Sub

    Private Sub CreatePopupMenu()
        Dim item As DevComponents.DotNetBar.ButtonItem

        m_PopupFromCode = New DevComponents.DotNetBar.ButtonItem()

        ' Create items
        item = New DevComponents.DotNetBar.ButtonItem("bCut")
        item.Text = "Cu&t"
        ' To remember: cannot use the ImageIndex for items that we create from code
        item.Image = ImageList1.Images(0)
        m_PopupFromCode.SubItems.Add(item)

        item = New DevComponents.DotNetBar.ButtonItem("bCopy")
        item.Text = "&Copy"
        item.Image = ImageList1.Images(1)
        m_PopupFromCode.SubItems.Add(item)

        item = New DevComponents.DotNetBar.ButtonItem("bPaste")
        item.Text = "&Paste"
        item.Image = ImageList1.Images(2)
        m_PopupFromCode.SubItems.Add(item)

        item = New DevComponents.DotNetBar.ButtonItem("bOpenFile")
        item.Text = "&Open File"
        item.Enabled = False
        item.BeginGroup = True
        m_PopupFromCode.SubItems.Add(item)

        item = New DevComponents.DotNetBar.ButtonItem("bInsertBreakpoint")
        item.Text = "Insert B&reakpoint"
        item.BeginGroup = True
        m_PopupFromCode.SubItems.Add(item)

        item = New DevComponents.DotNetBar.ButtonItem("bNewBreakpoint")
        item.Text = "New &Breakpoint..."
        m_PopupFromCode.SubItems.Add(item)

        item = New DevComponents.DotNetBar.ButtonItem("bRunToCursor")
        item.Text = "&Run To Cursor"
        item.BeginGroup = True
        m_PopupFromCode.SubItems.Add(item)

        item = New DevComponents.DotNetBar.ButtonItem("bAddTask")
        item.Text = "Add Task List S&hortcut"
        item.BeginGroup = True
        m_PopupFromCode.SubItems.Add(item)

        ' Setup side-bar, make sure that image that is used fits, or exceeds the height
        ' Side-bar will be displayed only for popup menus
        Dim si As DevComponents.DotNetBar.SideBarImage
        si = New DevComponents.DotNetBar.SideBarImage()
        si.Picture = New Bitmap(Me.GetType(), "devco.jpg")
        ' If image exceeds the size of the popup menu this specifies the image alignment
        si.Alignment = DevComponents.DotNetBar.eAlignment.Bottom
        ' If there is no image specified gradient can be used
        si.GradientColor1 = Color.Orange
        si.GradientColor2 = Color.Black
        m_PopupFromCode.PopUpSideBar = si
    End Sub

    Private Sub cmdPopupMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPopupMenu.Click
        If m_PopupFromCode Is Nothing Then CreatePopupMenu()

        m_PopupFromCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003

        If ComboBoxEx1.SelectedIndex = 1 Then m_PopupFromCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005

        ' MUST ALWAYS register popup with DotNetBar Manager
        DotNetBarManager1.RegisterPopup(m_PopupFromCode)

        Dim ctrl As Control = CType(sender, Control)
        Dim p As Point = Me.PointToScreen(New Point(ctrl.Left, ctrl.Bottom))

        m_PopupFromCode.PopupMenu(p)

    End Sub

    Private Sub cmdPopupBar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPopupBar.Click
        If m_PopupFromCode Is Nothing Then CreatePopupMenu()

        m_PopupFromCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003

        If ComboBoxEx1.SelectedIndex = 1 Then m_PopupFromCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005

        ' MUST ALWAYS register popup with DotNetBar Manager
        DotNetBarManager1.RegisterPopup(m_PopupFromCode)

        Dim ctrl As Control = CType(sender, Control)
        Dim p As Point = Me.PointToScreen(New Point(ctrl.Left, ctrl.Bottom))

        m_PopupFromCode.PopupBar(p)
    End Sub

    Private Sub DotNetBarManager1_PopupShowing(ByVal sender As Object, ByVal e As System.EventArgs) Handles DotNetBarManager1.PopupShowing
        Dim parentPopup As DevComponents.DotNetBar.BaseItem = CType(sender, DevComponents.DotNetBar.BaseItem)
        If parentPopup Is Nothing Then Exit Sub
        ' Disable Select All menu item
        parentPopup.SubItems("bPaste").Enabled = False
    End Sub
End Class
