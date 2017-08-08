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
    Friend WithEvents dotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents barLeftDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barRightDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barTopDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barBottomDockSite As DevComponents.DotNetBar.DockSite

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
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
        'dotNetBarManager1
        '
        Me.dotNetBarManager1.BottomDockSite = Me.barBottomDockSite
        Me.dotNetBarManager1.DefinitionName = ""
        Me.dotNetBarManager1.LeftDockSite = Me.barLeftDockSite
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
        Me.barBottomDockSite.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barBottomDockSite.Location = New System.Drawing.Point(0, 273)
        Me.barBottomDockSite.Name = "barBottomDockSite"
        Me.barBottomDockSite.Size = New System.Drawing.Size(292, 0)
        Me.barBottomDockSite.TabIndex = 3
        Me.barBottomDockSite.TabStop = False
        '
        'barLeftDockSite
        '
        Me.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left
        Me.barLeftDockSite.Name = "barLeftDockSite"
        Me.barLeftDockSite.Size = New System.Drawing.Size(0, 273)
        Me.barLeftDockSite.TabIndex = 0
        Me.barLeftDockSite.TabStop = False
        '
        'barRightDockSite
        '
        Me.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right
        Me.barRightDockSite.Location = New System.Drawing.Point(292, 0)
        Me.barRightDockSite.Name = "barRightDockSite"
        Me.barRightDockSite.Size = New System.Drawing.Size(0, 273)
        Me.barRightDockSite.TabIndex = 1
        Me.barRightDockSite.TabStop = False
        '
        'barTopDockSite
        '
        Me.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top
        Me.barTopDockSite.Name = "barTopDockSite"
        Me.barTopDockSite.Size = New System.Drawing.Size(292, 0)
        Me.barTopDockSite.TabIndex = 2
        Me.barTopDockSite.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 273)
        Me.DockSite1.TabIndex = 4
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.Location = New System.Drawing.Point(292, 0)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 273)
        Me.DockSite2.TabIndex = 5
        Me.DockSite2.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(292, 0)
        Me.DockSite3.TabIndex = 6
        Me.DockSite3.TabStop = False
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.Location = New System.Drawing.Point(0, 273)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(292, 0)
        Me.DockSite4.TabIndex = 7
        Me.DockSite4.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.barLeftDockSite, Me.barRightDockSite, Me.barTopDockSite, Me.barBottomDockSite, Me.DockSite1, Me.DockSite2, Me.DockSite3, Me.DockSite4})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateMenu()
    End Sub

    Private Sub CreateMenu()
        Dim bar As Bar
        Dim menu, submenu As ButtonItem

        bar = New Bar("Menu Bar")
        bar.MenuBar = True
        bar.Stretch = True
        bar.Style = eDotNetBarStyle.Office2003
        dotNetBarManager1.Bars.Add(bar)
        bar.DockSide = eDockSide.Top

        menu = New ButtonItem("bFile", "&File")
        bar.Items.Add(menu)
        submenu = New ButtonItem("bOpen", "&Open")
        menu.SubItems.Add(submenu)
        submenu = New ButtonItem("bClose", "&Close")
        menu.SubItems.Add(submenu)
        submenu = New ButtonItem("bExit", "&Exit")
        submenu.BeginGroup = True
        menu.SubItems.Add(submenu)

        menu = New ButtonItem("bEdit", "&Edit")
        bar.Items.Add(menu)
        submenu = New ButtonItem("bCut", "&Cut")
        menu.SubItems.Add(submenu)
        submenu = New ButtonItem("bCopy", "&Copy")
        menu.SubItems.Add(submenu)
        submenu = New ButtonItem("bPaste", "&Paste")
        menu.SubItems.Add(submenu)
        submenu = New ButtonItem("bClear", "&Clear")
        submenu.BeginGroup = True
        menu.SubItems.Add(submenu)

        bar.RecalcLayout()
    End Sub
End Class
