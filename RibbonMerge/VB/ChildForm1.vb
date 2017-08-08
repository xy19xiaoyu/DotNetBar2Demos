Public Class ChildForm1
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
    Friend WithEvents checkBoxItem1 As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents checkBoxItem2 As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents checkBoxItem3 As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents panelEx1 As DevComponents.DotNetBar.PanelEx
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.ribbonBarMergeContainer1 = New DevComponents.DotNetBar.RibbonBarMergeContainer()
        Me.ribbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.checkBoxItem1 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.checkBoxItem2 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.checkBoxItem3 = New DevComponents.DotNetBar.CheckBoxItem()
        Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.ribbonBarMergeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ribbonBarMergeContainer1
        '
        Me.ribbonBarMergeContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ribbonBarMergeContainer1.Controls.AddRange(New System.Windows.Forms.Control() {Me.ribbonBar1})
        Me.ribbonBarMergeContainer1.Location = New System.Drawing.Point(16, 40)
        Me.ribbonBarMergeContainer1.Name = "ribbonBarMergeContainer1"
        Me.ribbonBarMergeContainer1.RibbonTabText = "MDI Child Tab 1"
        Me.ribbonBarMergeContainer1.Size = New System.Drawing.Size(320, 88)
        Me.ribbonBarMergeContainer1.TabIndex = 2
        Me.ribbonBarMergeContainer1.Visible = False
        '
        'ribbonBar1
        '
        Me.ribbonBar1.AutoOverflowEnabled = True
        Me.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ribbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.checkBoxItem1, Me.checkBoxItem2, Me.checkBoxItem3})
        Me.ribbonBar1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ribbonBar1.Name = "ribbonBar1"
        Me.ribbonBar1.Size = New System.Drawing.Size(144, 88)
        Me.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ribbonBar1.TabIndex = 0
        Me.ribbonBar1.Text = "ribbonBar1"
        '
        'checkBoxItem1
        '
        Me.checkBoxItem1.Name = "checkBoxItem1"
        Me.checkBoxItem1.Text = "checkBoxItem1"
        '
        'checkBoxItem2
        '
        Me.checkBoxItem2.Name = "checkBoxItem2"
        Me.checkBoxItem2.Text = "checkBoxItem2"
        '
        'checkBoxItem3
        '
        Me.checkBoxItem3.Name = "checkBoxItem3"
        Me.checkBoxItem3.Text = "checkBoxItem3"
        '
        'panelEx1
        '
        Me.panelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.panelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelEx1.Name = "panelEx1"
        Me.panelEx1.Size = New System.Drawing.Size(360, 32)
        Me.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEx1.Style.GradientAngle = 90
        Me.panelEx1.TabIndex = 3
        Me.panelEx1.Text = "This is MDI Child Form 1"
        '
        'ChildForm1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 238)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.ribbonBarMergeContainer1, Me.panelEx1})
        Me.Name = "ChildForm1"
        Me.Text = "ChildForm1"
        Me.ribbonBarMergeContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
