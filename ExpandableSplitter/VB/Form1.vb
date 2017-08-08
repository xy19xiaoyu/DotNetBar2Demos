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
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents panelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents expandableSplitter2 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents panelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents expandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents panelEx1 As DevComponents.DotNetBar.PanelEx
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.expandableSplitter2 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.panelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.expandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.panelEx3, Me.expandableSplitter2, Me.panelEx2})
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(160, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(280, 266)
        Me.panel1.TabIndex = 5
        '
        'panelEx3
        '
        Me.panelEx3.AntiAlias = True
        Me.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelEx3.Location = New System.Drawing.Point(0, 72)
        Me.panelEx3.Name = "panelEx3"
        Me.panelEx3.Size = New System.Drawing.Size(280, 194)
        Me.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.panelEx3.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
        Me.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.panelEx3.Style.GradientAngle = 90
        Me.panelEx3.TabIndex = 2
        Me.panelEx3.Text = "Fill Panel"
        '
        'expandableSplitter2
        '
        Me.expandableSplitter2.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter2.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.expandableSplitter2.Dock = System.Windows.Forms.DockStyle.Top
        Me.expandableSplitter2.ExpandableControl = Me.panelEx2
        Me.expandableSplitter2.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter2.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandableSplitter2.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandableSplitter2.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.expandableSplitter2.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.expandableSplitter2.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.expandableSplitter2.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter2.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandableSplitter2.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter2.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.expandableSplitter2.Location = New System.Drawing.Point(0, 64)
        Me.expandableSplitter2.Name = "expandableSplitter2"
        Me.expandableSplitter2.Size = New System.Drawing.Size(280, 8)
        Me.expandableSplitter2.TabIndex = 1
        Me.expandableSplitter2.TabStop = False
        '
        'panelEx2
        '
        Me.panelEx2.AntiAlias = True
        Me.panelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelEx2.Name = "panelEx2"
        Me.panelEx2.Size = New System.Drawing.Size(280, 64)
        Me.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEx2.Style.GradientAngle = 90
        Me.panelEx2.TabIndex = 0
        Me.panelEx2.Text = "Click to collapse"
        '
        'expandableSplitter1
        '
        Me.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.expandableSplitter1.ExpandableControl = Me.panelEx1
        Me.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.expandableSplitter1.Location = New System.Drawing.Point(152, 0)
        Me.expandableSplitter1.Name = "expandableSplitter1"
        Me.expandableSplitter1.Size = New System.Drawing.Size(8, 266)
        Me.expandableSplitter1.TabIndex = 4
        Me.expandableSplitter1.TabStop = False
        '
        'panelEx1
        '
        Me.panelEx1.AntiAlias = True
        Me.panelEx1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelEx1.Name = "panelEx1"
        Me.panelEx1.Size = New System.Drawing.Size(152, 266)
        Me.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.panelEx1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
        Me.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.panelEx1.Style.GradientAngle = 90
        Me.panelEx1.Style.WordWrap = True
        Me.panelEx1.TabIndex = 3
        Me.panelEx1.Text = "Click to collapse"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 266)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel1, Me.expandableSplitter1, Me.panelEx1})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub panelEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelEx1.Click
        expandableSplitter1.Expanded = False
    End Sub

    Private Sub panelEx2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelEx2.Click
        expandableSplitter2.Expanded = False
    End Sub
End Class
