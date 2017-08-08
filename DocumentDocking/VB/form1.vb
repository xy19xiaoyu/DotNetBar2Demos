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
    Friend WithEvents bar4 As DevComponents.DotNetBar.Bar
    Friend WithEvents buttonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents barLeftDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barRightDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barTopDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents barBottomDockSite As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents DockContainerItem1 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents PanelDockContainer1 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents DockContainerItem2 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents PanelDockContainer2 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents DockContainerItem3 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents PanelDockContainer3 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents DockContainerItem4 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents PanelDockContainer4 As DevComponents.DotNetBar.PanelDockContainer
    Friend WithEvents Bar2 As DevComponents.DotNetBar.Bar
    Friend WithEvents Bar3 As DevComponents.DotNetBar.Bar
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.bar4 = New DevComponents.DotNetBar.Bar()
        Me.buttonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.barBottomDockSite = New DevComponents.DotNetBar.DockSite()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer3 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PanelDockContainer1 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DockContainerItem1 = New DevComponents.DotNetBar.DockContainerItem()
        Me.DockContainerItem3 = New DevComponents.DotNetBar.DockContainerItem()
        Me.Bar2 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer4 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DockContainerItem4 = New DevComponents.DotNetBar.DockContainerItem()
        Me.Bar3 = New DevComponents.DotNetBar.Bar()
        Me.PanelDockContainer2 = New DevComponents.DotNetBar.PanelDockContainer()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DockContainerItem2 = New DevComponents.DotNetBar.DockContainerItem()
        Me.barLeftDockSite = New DevComponents.DotNetBar.DockSite()
        Me.barRightDockSite = New DevComponents.DotNetBar.DockSite()
        Me.barTopDockSite = New DevComponents.DotNetBar.DockSite()
        CType(Me.bar4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockSite1.SuspendLayout()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar1.SuspendLayout()
        Me.PanelDockContainer3.SuspendLayout()
        Me.PanelDockContainer1.SuspendLayout()
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar2.SuspendLayout()
        Me.PanelDockContainer4.SuspendLayout()
        CType(Me.Bar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar3.SuspendLayout()
        Me.PanelDockContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bar4
        '
        Me.bar4.BackgroundImageAlpha = CType(255, Byte)
        Me.bar4.Dock = System.Windows.Forms.DockStyle.Top
        Me.bar4.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem1, Me.buttonItem2})
        Me.bar4.Name = "bar4"
        Me.bar4.Size = New System.Drawing.Size(720, 25)
        Me.bar4.Stretch = True
        Me.bar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.bar4.TabIndex = 3
        Me.bar4.TabStop = False
        Me.bar4.Text = "bar4"
        '
        'buttonItem1
        '
        Me.buttonItem1.Name = "buttonItem1"
        Me.buttonItem1.Text = "New Document"
        '
        'buttonItem2
        '
        Me.buttonItem2.Name = "buttonItem2"
        Me.buttonItem2.Text = "Show All Tabs"
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
        Me.DotNetBarManager1.FillDockSite = Me.DockSite1
        Me.DotNetBarManager1.LeftDockSite = Me.barLeftDockSite
        Me.DotNetBarManager1.ParentForm = Me
        Me.DotNetBarManager1.RightDockSite = Me.barRightDockSite
        Me.DotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.DotNetBarManager1.ThemeAware = False
        Me.DotNetBarManager1.TopDockSite = Me.barTopDockSite
        '
        'barBottomDockSite
        '
        Me.barBottomDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barBottomDockSite.BackgroundImageAlpha = CType(255, Byte)
        Me.barBottomDockSite.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barBottomDockSite.DocumentDockContainer = Nothing
        Me.barBottomDockSite.Location = New System.Drawing.Point(0, 430)
        Me.barBottomDockSite.Name = "barBottomDockSite"
        Me.barBottomDockSite.NeedsLayout = False
        Me.barBottomDockSite.Size = New System.Drawing.Size(720, 0)
        Me.barBottomDockSite.TabIndex = 7
        Me.barBottomDockSite.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.BackgroundImageAlpha = CType(255, Byte)
        Me.DockSite1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Bar1, Me.Bar2, Me.Bar3})
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar1, 358, 405), New DevComponents.DotNetBar.DocumentDockContainer(New DevComponents.DotNetBar.DocumentBaseContainer() {New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar2, 359, 218), New DevComponents.DotNetBar.DocumentBarContainer(Me.Bar3, 359, 184)}, DevComponents.DotNetBar.eOrientation.Vertical)}, DevComponents.DotNetBar.eOrientation.Horizontal)
        Me.DockSite1.Location = New System.Drawing.Point(0, 25)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.NeedsLayout = False
        Me.DockSite1.Size = New System.Drawing.Size(720, 405)
        Me.DockSite1.TabIndex = 8
        Me.DockSite1.TabStop = False
        '
        'Bar1
        '
        Me.Bar1.AccessibleDescription = "DotNetBar Bar (Bar1)"
        Me.Bar1.AccessibleName = "DotNetBar Bar"
        Me.Bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar1.AlwaysDisplayDockTab = True
        Me.Bar1.BackgroundImageAlpha = CType(255, Byte)
        Me.Bar1.CanCustomize = False
        Me.Bar1.CanDockBottom = False
        Me.Bar1.CanDockDocument = True
        Me.Bar1.CanDockLeft = False
        Me.Bar1.CanDockRight = False
        Me.Bar1.CanDockTop = False
        Me.Bar1.CanHide = True
        Me.Bar1.CanUndock = False
        Me.Bar1.Controls.AddRange(New System.Windows.Forms.Control() {Me.PanelDockContainer3, Me.PanelDockContainer1})
        Me.Bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.Bar1.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem1, Me.DockContainerItem3})
        Me.Bar1.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar1.Name = "Bar1"
        Me.Bar1.SelectedDockTab = 0
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.Bar1.TabIndex = 0
        Me.Bar1.TabStop = False
        '
        'PanelDockContainer3
        '
        Me.PanelDockContainer3.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox2})
        Me.PanelDockContainer3.Location = New System.Drawing.Point(2, 2)
        Me.PanelDockContainer3.Name = "PanelDockContainer3"
        Me.PanelDockContainer3.Size = New System.Drawing.Size(0, 0)
        Me.PanelDockContainer3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.PanelDockContainer3.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
        Me.PanelDockContainer3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer3.Style.GradientAngle = 90
        Me.PanelDockContainer3.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.AutoSize = False
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(0, 0)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "Document 3"
        '
        'PanelDockContainer1
        '
        Me.PanelDockContainer1.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox1})
        Me.PanelDockContainer1.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer1.Name = "PanelDockContainer1"
        Me.PanelDockContainer1.Size = New System.Drawing.Size(352, 374)
        Me.PanelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.PanelDockContainer1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
        Me.PanelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer1.Style.GradientAngle = 90
        Me.PanelDockContainer1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.AutoSize = False
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(352, 374)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Document 1, Drag & Drop tabs to change docking layout"
        '
        'DockContainerItem1
        '
        Me.DockContainerItem1.Control = Me.PanelDockContainer1
        Me.DockContainerItem1.Height = 378
        Me.DockContainerItem1.Name = "DockContainerItem1"
        Me.DockContainerItem1.Text = "Document 1"
        Me.DockContainerItem1.Width = 356
        '
        'DockContainerItem3
        '
        Me.DockContainerItem3.Control = Me.PanelDockContainer3
        Me.DockContainerItem3.Height = 378
        Me.DockContainerItem3.Name = "DockContainerItem3"
        Me.DockContainerItem3.Text = "Document 3"
        Me.DockContainerItem3.Width = 356
        '
        'Bar2
        '
        Me.Bar2.AccessibleDescription = "DotNetBar Bar (Bar2)"
        Me.Bar2.AccessibleName = "DotNetBar Bar"
        Me.Bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar2.AlwaysDisplayDockTab = True
        Me.Bar2.BackgroundImageAlpha = CType(255, Byte)
        Me.Bar2.CanCustomize = False
        Me.Bar2.CanDockBottom = False
        Me.Bar2.CanDockDocument = True
        Me.Bar2.CanDockLeft = False
        Me.Bar2.CanDockRight = False
        Me.Bar2.CanDockTop = False
        Me.Bar2.CanUndock = False
        Me.Bar2.Controls.AddRange(New System.Windows.Forms.Control() {Me.PanelDockContainer4})
        Me.Bar2.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.Bar2.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.Bar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem4})
        Me.Bar2.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar2.Location = New System.Drawing.Point(361, 0)
        Me.Bar2.Name = "Bar2"
        Me.Bar2.SelectedDockTab = 0
        Me.Bar2.Stretch = True
        Me.Bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.Bar2.TabIndex = 1
        Me.Bar2.TabStop = False
        '
        'PanelDockContainer4
        '
        Me.PanelDockContainer4.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox3})
        Me.PanelDockContainer4.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer4.Name = "PanelDockContainer4"
        Me.PanelDockContainer4.Size = New System.Drawing.Size(353, 187)
        Me.PanelDockContainer4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.PanelDockContainer4.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
        Me.PanelDockContainer4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer4.Style.GradientAngle = 90
        Me.PanelDockContainer4.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.AutoSize = False
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(353, 187)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "Document 4"
        '
        'DockContainerItem4
        '
        Me.DockContainerItem4.Control = Me.PanelDockContainer4
        Me.DockContainerItem4.Height = 191
        Me.DockContainerItem4.Name = "DockContainerItem4"
        Me.DockContainerItem4.Text = "Document 4"
        Me.DockContainerItem4.Width = 357
        '
        'Bar3
        '
        Me.Bar3.AccessibleDescription = "DotNetBar Bar (Bar3)"
        Me.Bar3.AccessibleName = "DotNetBar Bar"
        Me.Bar3.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.Bar3.AlwaysDisplayDockTab = True
        Me.Bar3.BackgroundImageAlpha = CType(255, Byte)
        Me.Bar3.CanCustomize = False
        Me.Bar3.CanDockBottom = False
        Me.Bar3.CanDockDocument = True
        Me.Bar3.CanDockLeft = False
        Me.Bar3.CanDockRight = False
        Me.Bar3.CanDockTop = False
        Me.Bar3.CanHide = True
        Me.Bar3.CanUndock = False
        Me.Bar3.Controls.AddRange(New System.Windows.Forms.Control() {Me.PanelDockContainer2})
        Me.Bar3.DockSide = DevComponents.DotNetBar.eDockSide.Document
        Me.Bar3.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top
        Me.Bar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.DockContainerItem2})
        Me.Bar3.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer
        Me.Bar3.Location = New System.Drawing.Point(361, 221)
        Me.Bar3.Name = "Bar3"
        Me.Bar3.SelectedDockTab = 0
        Me.Bar3.Stretch = True
        Me.Bar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.Bar3.TabIndex = 2
        Me.Bar3.TabStop = False
        '
        'PanelDockContainer2
        '
        Me.PanelDockContainer2.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox4})
        Me.PanelDockContainer2.Location = New System.Drawing.Point(3, 28)
        Me.PanelDockContainer2.Name = "PanelDockContainer2"
        Me.PanelDockContainer2.Size = New System.Drawing.Size(353, 153)
        Me.PanelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelDockContainer2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.PanelDockContainer2.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
        Me.PanelDockContainer2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.PanelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelDockContainer2.Style.GradientAngle = 90
        Me.PanelDockContainer2.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.AutoSize = False
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(353, 153)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = "Document 2"
        '
        'DockContainerItem2
        '
        Me.DockContainerItem2.Control = Me.PanelDockContainer2
        Me.DockContainerItem2.Height = 157
        Me.DockContainerItem2.Name = "DockContainerItem2"
        Me.DockContainerItem2.Text = "Document 2"
        Me.DockContainerItem2.Width = 357
        '
        'barLeftDockSite
        '
        Me.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barLeftDockSite.BackgroundImageAlpha = CType(255, Byte)
        Me.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left
        Me.barLeftDockSite.DocumentDockContainer = Nothing
        Me.barLeftDockSite.Name = "barLeftDockSite"
        Me.barLeftDockSite.NeedsLayout = False
        Me.barLeftDockSite.Size = New System.Drawing.Size(0, 430)
        Me.barLeftDockSite.TabIndex = 4
        Me.barLeftDockSite.TabStop = False
        '
        'barRightDockSite
        '
        Me.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barRightDockSite.BackgroundImageAlpha = CType(255, Byte)
        Me.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right
        Me.barRightDockSite.DocumentDockContainer = Nothing
        Me.barRightDockSite.Location = New System.Drawing.Point(720, 0)
        Me.barRightDockSite.Name = "barRightDockSite"
        Me.barRightDockSite.NeedsLayout = False
        Me.barRightDockSite.Size = New System.Drawing.Size(0, 430)
        Me.barRightDockSite.TabIndex = 5
        Me.barRightDockSite.TabStop = False
        '
        'barTopDockSite
        '
        Me.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barTopDockSite.BackgroundImageAlpha = CType(255, Byte)
        Me.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top
        Me.barTopDockSite.DocumentDockContainer = Nothing
        Me.barTopDockSite.Name = "barTopDockSite"
        Me.barTopDockSite.NeedsLayout = False
        Me.barTopDockSite.Size = New System.Drawing.Size(720, 0)
        Me.barTopDockSite.TabIndex = 6
        Me.barTopDockSite.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(720, 430)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.DockSite1, Me.bar4, Me.barLeftDockSite, Me.barRightDockSite, Me.barTopDockSite, Me.barBottomDockSite})
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.bar4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockSite1.ResumeLayout(False)
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar1.ResumeLayout(False)
        Me.PanelDockContainer3.ResumeLayout(False)
        Me.PanelDockContainer1.ResumeLayout(False)
        CType(Me.Bar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar2.ResumeLayout(False)
        Me.PanelDockContainer4.ResumeLayout(False)
        CType(Me.Bar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar3.ResumeLayout(False)
        Me.PanelDockContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub buttonItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonItem1.Click
        ' Create new document and add it to existing bar
        Dim dockItem As DevComponents.DotNetBar.DockContainerItem = New DevComponents.DotNetBar.DockContainerItem()
        dockItem.Text = "Custom Document"

        ' Add control to it
        Dim t As TextBox = New TextBox()
        t.AutoSize = False
        t.Multiline = True
        t.Text = dockItem.Text

        ' PanelDockContainer will be used to host any controls. It provides automatic focus management so focused
        ' document tab appears bold
        Dim panel As New DevComponents.DotNetBar.PanelDockContainer()
        panel.Controls.Add(t)
        t.Dock = DockStyle.Fill
        dockItem.Control = panel

        Bar1.Items.Add(dockItem)

        If Not Bar1.Visible Then
            Bar1.Visible = True
        Else
            Bar1.RecalcLayout()
        End If

    End Sub

    Private Sub buttonItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonItem2.Click
        ' Optimize display by disabling layout for all dock sites
        DotNetBarManager1.SuspendLayout = True
        Try
            Dim bar As DevComponents.DotNetBar.Bar
            For Each bar In DotNetBarManager1.Bars
                If bar.DockSide = DevComponents.DotNetBar.eDockSide.Document Then
                    Dim dock As DevComponents.DotNetBar.DockContainerItem
                    For Each dock In bar.Items
                        dock.Visible = True
                    Next
                End If
                If Not bar.Visible Then bar.Visible = True
            Next
        Finally
            DotNetBarManager1.SuspendLayout = False
        End Try
    End Sub

    Private Sub OnDocumentClosing(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.DockTabClosingEventArgs) Handles DotNetBarManager1.DockTabClosing
        ' In this event you save any changes to the active document or cancel the closing...
        ' e.DockContainerItem returns the reference to the item being closed
        ' Set e.Cancel to true to cancel the closing
        ' Set e.RemoveDockTab to true to automatically remove the closed tab from Bar.Items collection, otherwise tab will just be hidden

        Dim r As DialogResult = MessageBox.Show("Document '" + e.DockContainerItem.Text + " is about to close. Close it?", "Document Docking", MessageBoxButtons.YesNo)
        If r = DialogResult.No Then e.Cancel = True
    End Sub
End Class
