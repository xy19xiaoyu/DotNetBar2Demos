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
    Friend WithEvents ribbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents ribbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents ribbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents buttonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ribbonTabItem1 As DevComponents.DotNetBar.RibbonTabItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ribbonControl1 = New DevComponents.DotNetBar.RibbonControl
        Me.ribbonPanel1 = New DevComponents.DotNetBar.RibbonPanel
        Me.ribbonBar1 = New DevComponents.DotNetBar.RibbonBar
        Me.buttonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem
        Me.ribbonTabItem1 = New DevComponents.DotNetBar.RibbonTabItem
        Me.ribbonControl1.SuspendLayout()
        Me.ribbonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        '
        '
        '
        Me.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonControl1.Controls.Add(Me.ribbonPanel1)
        Me.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ribbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ribbonTabItem1})
        Me.ribbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.ribbonControl1.Size = New System.Drawing.Size(640, 120)
        Me.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>"
        Me.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel"
        Me.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.ribbonControl1.SystemText.QatDialogOkButton = "OK"
        Me.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove"
        Me.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.ribbonControl1.TabGroupHeight = 14
        Me.ribbonControl1.TabIndex = 1
        Me.ribbonControl1.Text = "ribbonControl1"
        '
        'ribbonPanel1
        '
        Me.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ribbonPanel1.Controls.Add(Me.ribbonBar1)
        Me.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ribbonPanel1.Location = New System.Drawing.Point(0, 26)
        Me.ribbonPanel1.Name = "ribbonPanel1"
        Me.ribbonPanel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.ribbonPanel1.Size = New System.Drawing.Size(640, 92)
        '
        '
        '
        Me.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonPanel1.TabIndex = 1
        '
        'ribbonBar1
        '
        Me.ribbonBar1.AutoOverflowEnabled = True
        '
        '
        '
        Me.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonBar1.ContainerControlProcessDialogKey = True
        Me.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ribbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem1, Me.buttonItem2})
        Me.ribbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonBar1.Name = "ribbonBar1"
        Me.ribbonBar1.Size = New System.Drawing.Size(136, 91)
        Me.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ribbonBar1.TabIndex = 0
        Me.ribbonBar1.Text = "ribbonBar1"
        '
        '
        '
        Me.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'buttonItem1
        '
        Me.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.buttonItem1.Image = CType(resources.GetObject("buttonItem1.Image"), System.Drawing.Image)
        Me.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.buttonItem1.Name = "buttonItem1"
        Me.buttonItem1.Text = "<div align=""center"">Show MDI<br/>Child 1</div>"
        '
        'buttonItem2
        '
        Me.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.buttonItem2.Image = CType(resources.GetObject("buttonItem2.Image"), System.Drawing.Image)
        Me.buttonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.buttonItem2.Name = "buttonItem2"
        Me.buttonItem2.Text = "<div align=""center"">Show MDI<br/>Child 2</div>"
        '
        'ribbonTabItem1
        '
        Me.ribbonTabItem1.Checked = True
        Me.ribbonTabItem1.Name = "ribbonTabItem1"
        Me.ribbonTabItem1.Panel = Me.ribbonPanel1
        Me.ribbonTabItem1.Text = "MDI Tab"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 454)
        Me.Controls.Add(Me.ribbonControl1)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ribbonControl1.ResumeLayout(False)
        Me.ribbonControl1.PerformLayout()
        Me.ribbonPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub buttonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonItem1.Click
        Dim f As ChildForm1 = New ChildForm1()
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub buttonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonItem2.Click
        Dim f As ChildForm2 = New ChildForm2()
        f.MdiParent = Me
        f.Show()
    End Sub
End Class
