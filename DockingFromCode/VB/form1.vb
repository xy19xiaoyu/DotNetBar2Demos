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
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
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
        Me.DotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
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
        Me.barBottomDockSite.Location = New System.Drawing.Point(0, 334)
        Me.barBottomDockSite.Name = "barBottomDockSite"
        Me.barBottomDockSite.Size = New System.Drawing.Size(408, 0)
        Me.barBottomDockSite.TabIndex = 3
        Me.barBottomDockSite.TabStop = False
        '
        'barLeftDockSite
        '
        Me.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left
        Me.barLeftDockSite.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.barLeftDockSite.Name = "barLeftDockSite"
        Me.barLeftDockSite.Size = New System.Drawing.Size(0, 334)
        Me.barLeftDockSite.TabIndex = 0
        Me.barLeftDockSite.TabStop = False
        '
        'barRightDockSite
        '
        Me.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right
        Me.barRightDockSite.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.barRightDockSite.Location = New System.Drawing.Point(408, 0)
        Me.barRightDockSite.Name = "barRightDockSite"
        Me.barRightDockSite.Size = New System.Drawing.Size(0, 334)
        Me.barRightDockSite.TabIndex = 1
        Me.barRightDockSite.TabStop = False
        '
        'barTopDockSite
        '
        Me.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top
        Me.barTopDockSite.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.barTopDockSite.Name = "barTopDockSite"
        Me.barTopDockSite.Size = New System.Drawing.Size(408, 0)
        Me.barTopDockSite.TabIndex = 2
        Me.barTopDockSite.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 334)
        Me.DockSite1.TabIndex = 4
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.Location = New System.Drawing.Point(408, 0)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 334)
        Me.DockSite2.TabIndex = 5
        Me.DockSite2.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(408, 0)
        Me.DockSite3.TabIndex = 6
        Me.DockSite3.TabStop = False
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.Location = New System.Drawing.Point(0, 334)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(408, 0)
        Me.DockSite4.TabIndex = 7
        Me.DockSite4.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 334)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.barLeftDockSite, Me.barRightDockSite, Me.barTopDockSite, Me.barBottomDockSite, Me.DockSite1, Me.DockSite2, Me.DockSite3, Me.DockSite4})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler DotNetBarManager1.DockTabChange, AddressOf Me.DockTabChanged
        CreateBottomBarAutoHide()
        CreateLeftDockedBars()
    End Sub

    Private Sub DockTabChanged(ByVal sender As Object, ByVal e As DockTabChangeEventArgs)
        ' Sync caption of the bar with the currently selected dock tab
        Dim bar As Bar = CType(sender, Bar)
        If bar Is Nothing Or e.NewTab Is Nothing Then
            Exit Sub
        Else
            bar.Text = e.NewTab.Text
        End If
    End Sub

    Private Sub CreateBottomBarAutoHide()
        Dim bar As Bar = New Bar("Bottom Bar in auto-hide state")
        bar.Name = "bottomBar"
        bar.LayoutType = eLayoutType.DockContainer ' Dock Container Layout needed for dockable windows
        bar.Stretch = True ' Dockable windows stretch to fill container
        bar.AutoHideAnimationTime = 0 ' Some controls do not support animation so turn it off
        bar.GrabHandleStyle = eGrabHandleStyle.Caption ' Dockable Windows have captions
        DotNetBarManager1.Bars.Add(Bar) ' DotNetBar needs to be aware of the bar so it can manage it's docking etc.

        ' Create hosted controls
        Dim dockItem As DockContainerItem = New DockContainerItem("bottomDockItem1", "First dock item")
        bar.Items.Add(dockItem)
        ' Create control that we want to host on dockable window
        Dim dockedControl As UserControl1 = New UserControl1()
        dockedControl.label1.Text = Bar.Name + " - " + dockItem.Text
        dockedControl.BackColor = Color.Azure
        dockItem.Control = dockedControl ' Specify that control is hosted on the dock container
        dockItem.Height = 128 ' Specify the height of the dockable container and at the same time control

        ' Create second dock container and add it to the bar
        dockItem = New DockContainerItem("bottomDockItem2", "Second dock item")
        Bar.Items.Add(dockItem)
        dockedControl = New UserControl1()
        dockedControl.label1.Text = Bar.Name + " - " + dockItem.Text
        dockedControl.BackColor = Color.Aquamarine
        dockItem.Control = dockedControl ' Specify that control is hosted on the dock container
        ' Dock bar to bottom dock site
        DotNetBarManager1.BottomDockSite.GetDocumentUIManager().Dock(bar)

        dockItem.Height = 128 ' Specify the height of the dockable container and at the same time control

        bar.RecalcLayout() ' Apply all layout changes...
        Bar.AutoHide = True ' Place bar in auto-hide mode. Bar needs to be docked before it can be places in auto-hide mode
    End Sub

    Private Sub CreateLeftDockedBars()
        ' Dock first two bars side by side and dock third bar next to them...
        Dim bar As Bar = New Bar("Bar1")
        bar.Name = "leftBar1"
        bar.LayoutType = eLayoutType.DockContainer ' Dock Container Layout needed for dockable windows
        bar.Stretch = True ' Dockable windows stretch to fill container
        bar.AutoHideAnimationTime = 0 ' Some controls do not support animation so turn it off
        bar.GrabHandleStyle = eGrabHandleStyle.Caption ' Dockable Windows have captions
        bar.CanHide = True

        Dim dockItem As DockContainerItem = New DockContainerItem("leftDockItem1", "Top Left Dock Container")
        bar.Items.Add(dockItem)
        ' Create control that is hosted on dock container
        Dim dockedControl As UserControl1 = New UserControl1()
        dockedControl.label1.Text = Bar.Name + " - " + dockItem.Text
        dockedControl.BackColor = Color.Khaki
        dockItem.Control = dockedControl ' Specify that control is hosted on the dock container
        DotNetBarManager1.Bars.Add(bar) ' DotNetBar needs to be aware of the bar so it can manage it's docking etc.
        DotNetBarManager1.LeftDockSite.GetDocumentUIManager().Dock(bar) ' Performs actual docking of the Bar to the specified dock site
        dockItem.Width = 128 ' Specify Width of dock container item which resizes the bar as well

        ' Create second bar and dock it below the first bar
        Dim bar2 As Bar = New Bar("Bar2")
        bar2.Name = "leftBar2"
        bar2.LayoutType = eLayoutType.DockContainer ' Dock Container Layout needed for dockable windows
        bar2.Stretch = True ' Dockable windows stretch to fill container
        bar2.AutoHideAnimationTime = 0 ' Some controls do not support animation so turn it off
        bar2.CanHide = True
        bar2.GrabHandleStyle = eGrabHandleStyle.Caption ' Dockable Windows have captions
        dockItem = New DockContainerItem("leftDockItem2", "Bottom Left Dock Container")
        bar2.Items.Add(dockItem)
        ' Create control that is hosted on dock container
        dockedControl = New UserControl1()
        dockedControl.label1.Text = Bar.Name + " - " + dockItem.Text
        dockedControl.BackColor = Color.Lavender
        dockItem.Control = dockedControl ' Specify that control is hosted on the dock container
        DotNetBarManager1.Bars.Add(bar2) ' DotNetBar needs to be aware of the bar so it can manage it's docking etc.
        DotNetBarManager1.LeftDockSite.GetDocumentUIManager().Dock(bar, bar2, eDockSide.Bottom) ' Dock new bar2 below the bar that we created previously

        ' Create third bar that is docked next to the first and second
        ' i.e. on the line 1
        bar = New Bar("Bar3")
        bar.Name = "leftBar3"
        bar.LayoutType = eLayoutType.DockContainer ' Dock Container Layout needed for dockable windows
        bar.Stretch = True ' Dockable windows stretch to fill container
        bar.AutoHideAnimationTime = 0 ' Some controls do not support animation so turn it off
        bar.CanHide = True
        bar.GrabHandleStyle = eGrabHandleStyle.Caption ' Dockable Windows have captions
        DotNetBarManager1.Bars.Add(Bar) ' DotNetBar needs to be aware of the bar so it can manage it's docking etc.
        ' Setting DockOffset to the value that is greater than DockOffset value of the first
        ' bar will dock this bar below the first bar
        bar.DockOffset = 0
        bar.DockLine = 1 ' This will force the bar to be docked on the line 1
        bar.DockSide = eDockSide.Left ' Dock the bar to the left

        dockItem = New DockContainerItem("leftDockItem3", "Left Dock Container line 1")
        bar.Items.Add(dockItem)
        ' Create control that is hosted on dock container
        dockedControl = New UserControl1()
        dockedControl.label1.Text = Bar.Name + " - " + dockItem.Text
        dockedControl.BackColor = Color.LemonChiffon
        dockItem.Control = dockedControl ' Specify that control is hosted on the dock container
        dockItem.Width = 96 ' Specify Width of dock container item
        DotNetBarManager1.LeftDockSite.GetDocumentUIManager().Dock(bar)

        ' Setting the width of the dock site will also scale the bars docked inside,
        ' however the size should be large enough to accomodate all bars including the constraints like MinimumSize etc.
        DotNetBarManager1.LeftDockSite.Width = 150
    End Sub
End Class
