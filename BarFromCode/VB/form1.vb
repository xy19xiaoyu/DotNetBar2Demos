Imports DevComponents.DotNetBar

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        CreateBar()

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
    Friend WithEvents m_DotNetBar As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents barLeftDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barRightDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barTopDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barBottomDockSite As DevComponents.DotNetBar.DockSite
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.m_DotNetBar = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.barBottomDockSite = New DevComponents.DotNetBar.DockSite()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.barLeftDockSite = New DevComponents.DotNetBar.DockSite()
        Me.barRightDockSite = New DevComponents.DotNetBar.DockSite()
        Me.barTopDockSite = New DevComponents.DotNetBar.DockSite()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.SuspendLayout()
        '
        'm_DotNetBar
        '
        Me.m_DotNetBar.BottomDockSite = Me.barBottomDockSite
        Me.m_DotNetBar.DefinitionName = ""
        Me.m_DotNetBar.Images = Me.ImageList1
        Me.m_DotNetBar.LeftDockSite = Me.barLeftDockSite
        Me.m_DotNetBar.ParentForm = Me
        Me.m_DotNetBar.RightDockSite = Me.barRightDockSite
        Me.m_DotNetBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.m_DotNetBar.ToolbarBottomDockSite = Me.DockSite4
        Me.m_DotNetBar.ToolbarLeftDockSite = Me.DockSite1
        Me.m_DotNetBar.ToolbarRightDockSite = Me.DockSite2
        Me.m_DotNetBar.ToolbarTopDockSite = Me.DockSite3
        Me.m_DotNetBar.TopDockSite = Me.barTopDockSite
        '
        'barBottomDockSite
        '
        Me.barBottomDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barBottomDockSite.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barBottomDockSite.Location = New System.Drawing.Point(0, 218)
        Me.barBottomDockSite.Name = "barBottomDockSite"
        Me.barBottomDockSite.Size = New System.Drawing.Size(384, 0)
        Me.barBottomDockSite.TabIndex = 3
        Me.barBottomDockSite.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Magenta
        '
        'barLeftDockSite
        '
        Me.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left
        Me.barLeftDockSite.Name = "barLeftDockSite"
        Me.barLeftDockSite.Size = New System.Drawing.Size(0, 218)
        Me.barLeftDockSite.TabIndex = 0
        Me.barLeftDockSite.TabStop = False
        '
        'barRightDockSite
        '
        Me.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right
        Me.barRightDockSite.Location = New System.Drawing.Point(384, 0)
        Me.barRightDockSite.Name = "barRightDockSite"
        Me.barRightDockSite.Size = New System.Drawing.Size(0, 218)
        Me.barRightDockSite.TabIndex = 1
        Me.barRightDockSite.TabStop = False
        '
        'barTopDockSite
        '
        Me.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top
        Me.barTopDockSite.Name = "barTopDockSite"
        Me.barTopDockSite.Size = New System.Drawing.Size(384, 0)
        Me.barTopDockSite.TabIndex = 2
        Me.barTopDockSite.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 218)
        Me.DockSite1.TabIndex = 4
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.Location = New System.Drawing.Point(384, 0)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 218)
        Me.DockSite2.TabIndex = 5
        Me.DockSite2.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(384, 0)
        Me.DockSite3.TabIndex = 6
        Me.DockSite3.TabStop = False
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.Location = New System.Drawing.Point(0, 218)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(384, 0)
        Me.DockSite4.TabIndex = 7
        Me.DockSite4.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(384, 218)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.barLeftDockSite, Me.barRightDockSite, Me.barTopDockSite, Me.barBottomDockSite, Me.DockSite1, Me.DockSite2, Me.DockSite3, Me.DockSite4})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub CreateBar()
        ' Create a new Bar
        Dim bar As Bar = New Bar("Standard")
        bar.CanHide = True
        bar.Style = eDotNetBarStyle.Office2003
        bar.GrabHandleStyle = eGrabHandleStyle.StripeFlat
        bar.WrapItemsDock = True
        bar.WrapItemsFloat = False
        bar.MenuBar = False
        ' Since we will be using ImageList bar have to be added to the DotNetBar Manager
        m_DotNetBar.Bars.Add(bar)

        ' Add Items to it
        Dim item, fileItem As ButtonItem
        ' New
        item = New ButtonItem("bNew")
        item.ImageIndex = 0
        item.Text = "&New"
        item.Shortcuts.Add(eShortcut.CtrlN)
        item.Category = "Standard"
        bar.Items.Add(item)
        m_DotNetBar.Items.Add(item.Copy())  ' This will create Category Entry

        ' Open
        item = New ButtonItem("bOpen")
        bar.Items.Add(item)
        item.ImageIndex = 1
        item.Text = "&Open"
        item.Shortcuts.Add(eShortcut.CtrlO)
        item.Category = "Standard"
        m_DotNetBar.Items.Add(item.Copy())
        ' Add Sub items to the Open, something like recently used files...
        fileItem = New ButtonItem("file1")
        fileItem.Text = "&1. File1.txt"
        item.SubItems.Add(fileItem)
        fileItem = New ButtonItem("file2")
        fileItem.Text = "&2. File2.txt"
        item.SubItems.Add(fileItem)
        fileItem = New ButtonItem("file3")
        fileItem.Text = "&3. File3.txt"
        item.SubItems.Add(fileItem)
        fileItem = New ButtonItem("file4")
        fileItem.Text = "&4. File4.txt"
        item.SubItems.Add(fileItem)
        fileItem = New ButtonItem("file5")
        fileItem.Text = "&5. File5.txt"
        item.SubItems.Add(fileItem)

        ' Close
        item = New ButtonItem("bClose")
        bar.Items.Add(item)
        item.ImageIndex = 2
        item.Text = "&Close"
        item.Shortcuts.Add(eShortcut.CtrlX)
        item.Category = "Standard"
        m_DotNetBar.Items.Add(item.Copy())

        ' Save
        item = New ButtonItem("bSave")
        bar.Items.Add(item)
        item.ImageIndex = 3
        item.Text = "&Save"
        item.Shortcuts.Add(eShortcut.CtrlS)
        item.Category = "Standard"
        m_DotNetBar.Items.Add(item.Copy())

        ' Print Preview
        item = New ButtonItem("bPrintPreview")
        bar.Items.Add(item)
        item.ImageIndex = 6
        item.Text = "Print Pre&view"
        item.Category = "Standard"
        item.BeginGroup = True
        m_DotNetBar.Items.Add(item.Copy())

        ' Print
        item = New ButtonItem("bPrint")
        bar.Items.Add(item)
        item.ImageIndex = 5
        item.Text = "&Print"
        item.Category = "Standard"
        item.Shortcuts.Add(eShortcut.CtrlP)
        m_DotNetBar.Items.Add(item.Copy())

        ' E-Mail
        item = New ButtonItem("bEmail")
        bar.Items.Add(item)
        item.ImageIndex = 4
        item.Text = "&Email"
        item.Category = "Standard"
        item.BeginGroup = True
        m_DotNetBar.Items.Add(item.Copy())

        ' Customize Item
        Dim citem As CustomizeItem = New CustomizeItem()
        bar.Items.Add(citem)

        ' This will dock the bar
        bar.DockSide = eDockSide.Top
    End Sub

    Private Sub m_DotNetBar_ItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles m_DotNetBar.ItemClick
        Dim item As BaseItem = CType(sender, BaseItem)
        If item Is Nothing Or item.Name = "" Or item.SystemItem Then Exit Sub
        MessageBox.Show("Item '" + item.Name + "' clicked")
    End Sub
End Class
