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
    Friend WithEvents panelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents panelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents panelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents panelEx8 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents panelEx7 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents panelEx6 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents panelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents panelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx9 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents panelEx10 As DevComponents.DotNetBar.PanelEx
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.panelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.panelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.panelEx10 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx9 = New DevComponents.DotNetBar.PanelEx()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.panelEx8 = New DevComponents.DotNetBar.PanelEx()
        Me.panelEx7 = New DevComponents.DotNetBar.PanelEx()
        Me.panelEx6 = New DevComponents.DotNetBar.PanelEx()
        Me.panelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.panelEx1.SuspendLayout()
        Me.panelEx3.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelEx1
        '
        Me.panelEx1.Controls.AddRange(New System.Windows.Forms.Control() {Me.panelEx2})
        Me.panelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelEx1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelEx1.Name = "panelEx1"
        Me.panelEx1.Size = New System.Drawing.Size(544, 32)
        Me.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEx1.Style.GradientAngle = 90
        Me.panelEx1.Style.MarginLeft = 4
        Me.panelEx1.TabIndex = 2
        Me.panelEx1.Text = "PanelEx Sample Project"
        '
        'panelEx2
        '
        Me.panelEx2.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.panelEx2.Location = New System.Drawing.Point(520, 8)
        Me.panelEx2.Name = "panelEx2"
        Me.panelEx2.Size = New System.Drawing.Size(16, 16)
        Me.panelEx2.Style.BackgroundImage = CType(resources.GetObject("panelEx2.Style.BackgroundImage"), System.Drawing.Bitmap)
        Me.panelEx2.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Center
        Me.panelEx2.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx2.StyleMouseDown.BackgroundImage = CType(resources.GetObject("panelEx2.StyleMouseDown.BackgroundImage"), System.Drawing.Bitmap)
        Me.panelEx2.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx2.TabIndex = 2
        '
        'panelEx3
        '
        Me.panelEx3.Controls.AddRange(New System.Windows.Forms.Control() {Me.panelEx10, Me.PanelEx9, Me.Label5, Me.panelEx8, Me.panelEx7, Me.panelEx6, Me.panelEx5, Me.label4, Me.label3, Me.label2, Me.label1, Me.panelEx4})
        Me.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelEx3.Name = "panelEx3"
        Me.panelEx3.Size = New System.Drawing.Size(544, 278)
        Me.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEx3.Style.GradientAngle = 90
        Me.panelEx3.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx3.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx3.TabIndex = 3
        '
        'panelEx10
        '
        Me.panelEx10.AutoScroll = True
        Me.panelEx10.AutoScrollMinSize = New System.Drawing.Size(0, 457)
        Me.panelEx10.Location = New System.Drawing.Point(288, 56)
        Me.panelEx10.Name = "panelEx10"
        Me.panelEx10.Size = New System.Drawing.Size(248, 152)
        Me.panelEx10.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx10.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.panelEx10.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.panelEx10.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEx10.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.panelEx10.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.panelEx10.Style.GradientAngle = 90
        Me.panelEx10.TabIndex = 12
        Me.panelEx10.Text = "PanelEx control fully supports DevComponents <a href=""textMarkupLink""><b>text-mar" & _
        "kup</b></a>. You can use PanelEx as:<br/><br/>" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "<p>" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "- Extremely powerful <font " & _
        "color=""Navy""><b>Label</b></font> control<br/>" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "- Help panel with <font color=""Na" & _
        "vy""><b>automatic scrolling</b></font> support<br/>" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "- Documentation presentation" & _
        " control<br/>" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "</p>" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "<p>" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Here is longer text that demonstrates automatic PanelE" & _
        "x scrolling support:" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "</p>" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "<p>" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Lorem ipsum dolor sit amet, consectetuer adipis" & _
        "cing elit. Sed pharetra dolor quis tortor. Donec quis purus at ante tempor gravi" & _
        "da. Mauris velit lacus, viverra sit amet, aliquet sit amet, malesuada sed, metus" & _
        ". Morbi blandit. Etiam fermentum sapien et nunc. Vivamus et nisl. Phasellus eget" & _
        " elit. Nulla ac urna. Fusce elementum. Phasellus est mi, adipiscing ac, tristiqu" & _
        "e ac, lobortis nec, neque. Cras quis quam. Nam aliquam lectus sed augue. Suspend" & _
        "isse potenti. Praesent eget dui. Aliquam egestas eros et arcu." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "</p>" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "<p> " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "In h" & _
        "ac habitasse platea dictumst. Donec tellus. Morbi urna sapien, dictum vel, fring" & _
        "illa eu, scelerisque ullamcorper, tortor. Curabitur nec purus. Aliquam elit mi, " & _
        "suscipit quis, elementum vitae, volutpat in, ante. Duis non magna ut nibh tincid" & _
        "unt dignissim. In risus nulla, fringilla posuere, egestas vitae, elementum at, e" & _
        "ros. Integer id mi venenatis tellus ornare facilisis. Fusce convallis viverra an" & _
        "te. Aenean metus. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "</p>"
        '
        'PanelEx9
        '
        Me.PanelEx9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx9.Location = New System.Drawing.Point(176, 184)
        Me.PanelEx9.Name = "PanelEx9"
        Me.PanelEx9.Size = New System.Drawing.Size(104, 24)
        Me.PanelEx9.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx9.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx9.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx9.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx9.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx9.Style.CornerDiameter = 5
        Me.PanelEx9.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.PanelEx9.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx9.Style.GradientAngle = 90
        Me.PanelEx9.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx9.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx9.TabIndex = 10
        Me.PanelEx9.Text = "Panel Style"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(16, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Rounded Panel:"
        '
        'panelEx8
        '
        Me.panelEx8.Location = New System.Drawing.Point(176, 152)
        Me.panelEx8.Name = "panelEx8"
        Me.panelEx8.Size = New System.Drawing.Size(104, 24)
        Me.panelEx8.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx8.Style.BackColor1.Color = System.Drawing.Color.Linen
        Me.panelEx8.Style.BackColor2.Color = System.Drawing.Color.DarkOrange
        Me.panelEx8.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
        Me.panelEx8.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEx8.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.panelEx8.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.panelEx8.Style.GradientAngle = 90
        Me.panelEx8.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx8.StyleMouseDown.BackColor1.Color = System.Drawing.Color.OrangeRed
        Me.panelEx8.StyleMouseDown.BackColor2.Color = System.Drawing.Color.Linen
        Me.panelEx8.StyleMouseDown.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.panelEx8.StyleMouseDown.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText
        Me.panelEx8.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx8.StyleMouseOver.BackColor1.Color = System.Drawing.Color.NavajoWhite
        Me.panelEx8.StyleMouseOver.BackColor2.Color = System.Drawing.Color.IndianRed
        Me.panelEx8.StyleMouseOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelEx8.TabIndex = 8
        Me.panelEx8.Text = "Panel Style"
        '
        'panelEx7
        '
        Me.panelEx7.Location = New System.Drawing.Point(176, 120)
        Me.panelEx7.Name = "panelEx7"
        Me.panelEx7.Size = New System.Drawing.Size(104, 24)
        Me.panelEx7.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx7.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.panelEx7.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.panelEx7.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
        Me.panelEx7.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.panelEx7.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.panelEx7.Style.GradientAngle = 90
        Me.panelEx7.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx7.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx7.TabIndex = 7
        Me.panelEx7.Text = "Label Style"
        '
        'panelEx6
        '
        Me.panelEx6.Location = New System.Drawing.Point(176, 88)
        Me.panelEx6.Name = "panelEx6"
        Me.panelEx6.Size = New System.Drawing.Size(104, 24)
        Me.panelEx6.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.panelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.panelEx6.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
        Me.panelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.panelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.panelEx6.Style.GradientAngle = 90
        Me.panelEx6.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx6.StyleMouseDown.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.panelEx6.StyleMouseDown.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.panelEx6.StyleMouseDown.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.panelEx6.StyleMouseDown.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText
        Me.panelEx6.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx6.StyleMouseOver.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground
        Me.panelEx6.StyleMouseOver.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground2
        Me.panelEx6.StyleMouseOver.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder
        Me.panelEx6.StyleMouseOver.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText
        Me.panelEx6.TabIndex = 6
        Me.panelEx6.Text = "Button Style"
        '
        'panelEx5
        '
        Me.panelEx5.Location = New System.Drawing.Point(176, 56)
        Me.panelEx5.Name = "panelEx5"
        Me.panelEx5.Size = New System.Drawing.Size(104, 24)
        Me.panelEx5.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEx5.Style.GradientAngle = 90
        Me.panelEx5.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx5.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx5.TabIndex = 5
        Me.panelEx5.Text = "Panel Style"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(16, 160)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(168, 16)
        Me.label4.TabIndex = 4
        Me.label4.Text = "PanelEx with manually set style:"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(16, 128)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(152, 16)
        Me.label3.TabIndex = 3
        Me.label3.Text = "PanelEx with ""Label"" style:"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 96)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(152, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "PanelEx with ""Button"" style:"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 64)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(144, 16)
        Me.label1.TabIndex = 1
        Me.label1.Text = "PanelEx with ""Panel"" style:"
        '
        'panelEx4
        '
        Me.panelEx4.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.panelEx4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelEx4.Location = New System.Drawing.Point(456, 248)
        Me.panelEx4.Name = "panelEx4"
        Me.panelEx4.Size = New System.Drawing.Size(80, 24)
        Me.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.panelEx4.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
        Me.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.panelEx4.Style.GradientAngle = 90
        Me.panelEx4.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx4.StyleMouseDown.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.panelEx4.StyleMouseDown.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.panelEx4.StyleMouseDown.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder
        Me.panelEx4.StyleMouseDown.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText
        Me.panelEx4.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx4.StyleMouseOver.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground
        Me.panelEx4.StyleMouseOver.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground2
        Me.panelEx4.StyleMouseOver.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder
        Me.panelEx4.StyleMouseOver.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText
        Me.panelEx4.TabIndex = 0
        Me.panelEx4.Text = "Close"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 278)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panelEx1, Me.panelEx3})
        Me.MinimumSize = New System.Drawing.Size(224, 272)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panelEx1.ResumeLayout(False)
        Me.panelEx3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub panelEx4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelEx4.Click
        Me.Close()
    End Sub

    Private Sub panelEx10_MarkupLinkClick(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.MarkupLinkClickEventArgs) Handles panelEx10.MarkupLinkClick
        DevComponents.DotNetBar.MessageBoxEx.Show("You can use the hyperlink support to add actionable content to your text.", "PanelEx Demo")
    End Sub
End Class
