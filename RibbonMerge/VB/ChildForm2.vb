Public Class ChildForm2
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
    Friend WithEvents ribbonBarMergeContainer1 As DevComponents.DotNetBar.RibbonBarMergeContainer
    Friend WithEvents ribbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents buttonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents panelEx1 As DevComponents.DotNetBar.PanelEx
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ChildForm2))
        Me.ribbonBarMergeContainer1 = New DevComponents.DotNetBar.RibbonBarMergeContainer()
        Me.ribbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.buttonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.ribbonBarMergeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ribbonBarMergeContainer1
        '
        Me.ribbonBarMergeContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ribbonBarMergeContainer1.Controls.AddRange(New System.Windows.Forms.Control() {Me.ribbonBar1})
        Me.ribbonBarMergeContainer1.Location = New System.Drawing.Point(32, 40)
        Me.ribbonBarMergeContainer1.Name = "ribbonBarMergeContainer1"
        Me.ribbonBarMergeContainer1.RibbonTabText = "MDI Child Tab 2"
        Me.ribbonBarMergeContainer1.Size = New System.Drawing.Size(256, 72)
        Me.ribbonBarMergeContainer1.TabIndex = 3
        Me.ribbonBarMergeContainer1.Visible = False
        '
        'ribbonBar1
        '
        Me.ribbonBar1.AutoOverflowEnabled = True
        Me.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ribbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem1, Me.buttonItem2, Me.buttonItem3})
        Me.ribbonBar1.Name = "ribbonBar1"
        Me.ribbonBar1.Size = New System.Drawing.Size(168, 72)
        Me.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ribbonBar1.TabIndex = 0
        Me.ribbonBar1.Text = "Views"
        '
        'buttonItem1
        '
        Me.buttonItem1.Image = CType(resources.GetObject("buttonItem1.Image"), System.Drawing.Bitmap)
        Me.buttonItem1.Name = "buttonItem1"
        Me.buttonItem1.Text = "buttonItem1"
        '
        'buttonItem2
        '
        Me.buttonItem2.Image = CType(resources.GetObject("buttonItem2.Image"), System.Drawing.Bitmap)
        Me.buttonItem2.Name = "buttonItem2"
        Me.buttonItem2.Text = "buttonItem2"
        '
        'buttonItem3
        '
        Me.buttonItem3.Image = CType(resources.GetObject("buttonItem3.Image"), System.Drawing.Bitmap)
        Me.buttonItem3.Name = "buttonItem3"
        Me.buttonItem3.Text = "buttonItem3"
        '
        'panelEx1
        '
        Me.panelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.panelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelEx1.Name = "panelEx1"
        Me.panelEx1.Size = New System.Drawing.Size(408, 32)
        Me.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground
        Me.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground2
        Me.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEx1.Style.GradientAngle = 90
        Me.panelEx1.TabIndex = 4
        Me.panelEx1.Text = "This is MDI Child Form 2"
        '
        'ChildForm2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 238)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.ribbonBarMergeContainer1, Me.panelEx1})
        Me.Name = "ChildForm2"
        Me.Text = "ChildForm2"
        Me.ribbonBarMergeContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
