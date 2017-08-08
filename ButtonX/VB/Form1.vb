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
    Friend WithEvents buttonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonX5 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents buttonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents buttonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents buttonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonX6 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents buttonX9 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents buttonItem12 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonX8 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents buttonItem11 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents buttonX7 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents buttonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents buttonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents buttonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX10 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents buttonX12 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents buttonX11 As DevComponents.DotNetBar.ButtonX
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.buttonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonX5 = New DevComponents.DotNetBar.ButtonX()
        Me.buttonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.buttonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.label2 = New System.Windows.Forms.Label()
        Me.buttonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonX6 = New DevComponents.DotNetBar.ButtonX()
        Me.buttonX9 = New DevComponents.DotNetBar.ButtonX()
        Me.buttonItem12 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem10 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonX8 = New DevComponents.DotNetBar.ButtonX()
        Me.buttonItem11 = New DevComponents.DotNetBar.ButtonItem()
        Me.label3 = New System.Windows.Forms.Label()
        Me.buttonX7 = New DevComponents.DotNetBar.ButtonX()
        Me.buttonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.buttonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.label1 = New System.Windows.Forms.Label()
        Me.buttonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX10 = New DevComponents.DotNetBar.ButtonX()
        Me.buttonX12 = New DevComponents.DotNetBar.ButtonX()
        Me.buttonX11 = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'buttonItem7
        '
        Me.buttonItem7.ImagePaddingHorizontal = 8
        Me.buttonItem7.Name = "buttonItem7"
        Me.buttonItem7.Text = "buttonItem4"
        '
        'buttonItem6
        '
        Me.buttonItem6.ImagePaddingHorizontal = 8
        Me.buttonItem6.Name = "buttonItem6"
        Me.buttonItem6.Text = "buttonItem6"
        '
        'buttonItem5
        '
        Me.buttonItem5.ImagePaddingHorizontal = 8
        Me.buttonItem5.Name = "buttonItem5"
        Me.buttonItem5.Text = "buttonItem5"
        '
        'buttonX5
        '
        Me.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX5.AutoExpandOnClick = True
        Me.buttonX5.Location = New System.Drawing.Point(12, 77)
        Me.buttonX5.Name = "buttonX5"
        Me.buttonX5.Size = New System.Drawing.Size(105, 29)
        Me.buttonX5.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem1, Me.buttonItem2, Me.buttonItem3})
        Me.buttonX5.TabIndex = 17
        Me.buttonX5.Text = "Drop down menu"
        '
        'buttonItem1
        '
        Me.buttonItem1.ImagePaddingHorizontal = 8
        Me.buttonItem1.Name = "buttonItem1"
        Me.buttonItem1.Text = "Sample Menu Item 1"
        '
        'buttonItem2
        '
        Me.buttonItem2.ImagePaddingHorizontal = 8
        Me.buttonItem2.Name = "buttonItem2"
        Me.buttonItem2.Text = "Sample Menu Item 2"
        '
        'buttonItem3
        '
        Me.buttonItem3.ImagePaddingHorizontal = 8
        Me.buttonItem3.Name = "buttonItem3"
        Me.buttonItem3.Text = "<b><font color=""Orange"">Menu</font></b> item with<br/><b>mini-markup</b>"
        '
        'buttonX3
        '
        Me.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.buttonX3.Location = New System.Drawing.Point(82, 38)
        Me.buttonX3.Name = "buttonX3"
        Me.buttonX3.Size = New System.Drawing.Size(64, 27)
        Me.buttonX3.TabIndex = 15
        Me.buttonX3.Text = "Orange"
        '
        'buttonItem8
        '
        Me.buttonItem8.ImagePaddingHorizontal = 8
        Me.buttonItem8.Name = "buttonItem8"
        Me.buttonItem8.Text = "buttonItem5"
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.Color.SteelBlue
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(235, 10)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(132, 16)
        Me.label2.TabIndex = 19
        Me.label2.Text = "Office 2003 Style"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'buttonItem4
        '
        Me.buttonItem4.ImagePaddingHorizontal = 8
        Me.buttonItem4.Name = "buttonItem4"
        Me.buttonItem4.Text = "buttonItem4"
        '
        'buttonX6
        '
        Me.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.buttonX6.Image = CType(resources.GetObject("buttonX6.Image"), System.Drawing.Bitmap)
        Me.buttonX6.Location = New System.Drawing.Point(13, 115)
        Me.buttonX6.Name = "buttonX6"
        Me.buttonX6.Size = New System.Drawing.Size(117, 39)
        Me.buttonX6.TabIndex = 18
        Me.buttonX6.Text = "<div align=""center""><b>Mini</b>-<u><font color=""DarkOrange"">markup</font></u> <fo" & _
        "nt color=""Red"">on</font> the <font color=""Green"">button</font></div>"
        '
        'buttonX9
        '
        Me.buttonX9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX9.CustomColorName = "MyColorName"
        Me.buttonX9.Location = New System.Drawing.Point(14, 170)
        Me.buttonX9.Name = "buttonX9"
        Me.buttonX9.Size = New System.Drawing.Size(128, 42)
        Me.buttonX9.TabIndex = 23
        Me.buttonX9.Text = "Custom Colors see CustomColorName"
        '
        'buttonItem12
        '
        Me.buttonItem12.ImagePaddingHorizontal = 8
        Me.buttonItem12.Name = "buttonItem12"
        Me.buttonItem12.Text = "buttonItem6"
        '
        'buttonItem10
        '
        Me.buttonItem10.ImagePaddingHorizontal = 8
        Me.buttonItem10.Name = "buttonItem10"
        Me.buttonItem10.Text = "buttonItem4"
        '
        'buttonX8
        '
        Me.buttonX8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX8.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.buttonX8.Image = CType(resources.GetObject("buttonX8.Image"), System.Drawing.Bitmap)
        Me.buttonX8.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.buttonX8.Location = New System.Drawing.Point(263, 102)
        Me.buttonX8.Name = "buttonX8"
        Me.buttonX8.Size = New System.Drawing.Size(77, 55)
        Me.buttonX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.buttonX8.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem10, Me.buttonItem11, Me.buttonItem12})
        Me.buttonX8.TabIndex = 22
        Me.buttonX8.Text = "ButtonX"
        '
        'buttonItem11
        '
        Me.buttonItem11.ImagePaddingHorizontal = 8
        Me.buttonItem11.Name = "buttonItem11"
        Me.buttonItem11.Text = "buttonItem5"
        '
        'label3
        '
        Me.label3.BackColor = System.Drawing.Color.SteelBlue
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(235, 79)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(132, 16)
        Me.label3.TabIndex = 21
        Me.label3.Text = "VS.NET 2005 Style"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'buttonX7
        '
        Me.buttonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.buttonX7.Image = CType(resources.GetObject("buttonX7.Image"), System.Drawing.Bitmap)
        Me.buttonX7.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right
        Me.buttonX7.Location = New System.Drawing.Point(254, 34)
        Me.buttonX7.Name = "buttonX7"
        Me.buttonX7.Size = New System.Drawing.Size(95, 35)
        Me.buttonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.buttonX7.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem4, Me.buttonItem5, Me.buttonItem6})
        Me.buttonX7.TabIndex = 20
        Me.buttonX7.Text = "ButtonX"
        '
        'buttonX4
        '
        Me.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.buttonX4.Location = New System.Drawing.Point(152, 38)
        Me.buttonX4.Name = "buttonX4"
        Me.buttonX4.Size = New System.Drawing.Size(64, 27)
        Me.buttonX4.TabIndex = 16
        Me.buttonX4.Text = "Magenta"
        '
        'buttonX2
        '
        Me.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX2.Location = New System.Drawing.Point(12, 38)
        Me.buttonX2.Name = "buttonX2"
        Me.buttonX2.Size = New System.Drawing.Size(64, 27)
        Me.buttonX2.TabIndex = 14
        Me.buttonX2.Text = "Blue"
        Me.buttonX2.Tooltip = "Built-in Tooltip with the <font color=""Red"">mini</font>-<font color=""DarkOrange"">" & _
        "markup</font> enabled." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "<div align=""center"">Multiple lines are easy with mini-ma" & _
        "rkup</div>"
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.SteelBlue
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(11, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(207, 16)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Office 2007 Style"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'buttonItem9
        '
        Me.buttonItem9.ImagePaddingHorizontal = 8
        Me.buttonItem9.Name = "buttonItem9"
        Me.buttonItem9.Text = "buttonItem6"
        '
        'buttonX1
        '
        Me.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.buttonX1.Location = New System.Drawing.Point(306, 226)
        Me.buttonX1.Name = "buttonX1"
        Me.buttonX1.Size = New System.Drawing.Size(72, 24)
        Me.buttonX1.TabIndex = 12
        Me.buttonX1.Text = "Close"
        Me.buttonX1.ThemeAware = True
        '
        'ButtonX10
        '
        Me.ButtonX10.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX10.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.ButtonX10.Location = New System.Drawing.Point(124, 77)
        Me.ButtonX10.Name = "ButtonX10"
        Me.ButtonX10.Size = New System.Drawing.Size(92, 29)
        Me.ButtonX10.TabIndex = 24
        Me.ButtonX10.Text = "Office 2007"
        '
        'buttonX12
        '
        Me.buttonX12.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX12.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.buttonX12.FocusCuesEnabled = False
        Me.buttonX12.Image = CType(resources.GetObject("buttonX12.Image"), System.Drawing.Bitmap)
        Me.buttonX12.Location = New System.Drawing.Point(159, 171)
        Me.buttonX12.Name = "buttonX12"
        Me.buttonX12.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.buttonX12.Size = New System.Drawing.Size(40, 40)
        Me.buttonX12.TabIndex = 26
        '
        'buttonX11
        '
        Me.buttonX11.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX11.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb
        Me.buttonX11.FocusCuesEnabled = False
        Me.buttonX11.Location = New System.Drawing.Point(141, 115)
        Me.buttonX11.Name = "buttonX11"
        Me.buttonX11.Size = New System.Drawing.Size(76, 39)
        Me.buttonX11.TabIndex = 25
        Me.buttonX11.Text = "Blue Orb"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(388, 260)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.buttonX12, Me.buttonX11, Me.ButtonX10, Me.buttonX5, Me.buttonX3, Me.label2, Me.buttonX6, Me.buttonX9, Me.buttonX8, Me.label3, Me.buttonX7, Me.buttonX4, Me.buttonX2, Me.label1, Me.buttonX1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub buttonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonX1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Create custom color scheme for the button and register it globaly
        Dim table As DevComponents.DotNetBar.Rendering.Office2007ButtonItemColorTable = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemColorTable()
        table.Name = "MyColorName" ' This is the color table name that we assigned to the CustomColorName property in designer

        ' Define standard colors when mouse is not over the button
        table.Default = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemStateColorTable()
        table.Default.OuterBorder.Start = System.Drawing.Color.DarkRed
        table.Default.OuterBorder.End = System.Drawing.Color.Black
        table.Default.TopBackground.Start = System.Drawing.Color.WhiteSmoke
        table.Default.TopBackground.End = System.Drawing.Color.Salmon
        table.Default.BottomBackground.Start = System.Drawing.Color.Salmon
        table.Default.BottomBackground.End = System.Drawing.Color.DarkSalmon
        table.Default.BottomBackgroundHighlight.Start = System.Drawing.Color.Yellow
        table.Default.BottomBackgroundHighlight.End = System.Drawing.Color.Transparent
        table.Default.Text = System.Drawing.Color.Maroon

        ' Define colors when mouse is over the button
        table.MouseOver = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemStateColorTable()
        table.MouseOver.OuterBorder.Start = System.Drawing.Color.Maroon
        table.MouseOver.OuterBorder.End = System.Drawing.Color.Black
        table.MouseOver.TopBackground.Start = System.Drawing.Color.LightYellow
        table.MouseOver.TopBackground.End = System.Drawing.Color.Orange
        table.MouseOver.BottomBackground.Start = System.Drawing.Color.Orange
        table.MouseOver.BottomBackground.End = System.Drawing.Color.OrangeRed
        table.MouseOver.BottomBackgroundHighlight.Start = System.Drawing.Color.LightYellow
        table.MouseOver.BottomBackgroundHighlight.End = System.Drawing.Color.Transparent
        table.MouseOver.Text = System.Drawing.Color.Maroon

        ' Define colors when mouse is pressed
        table.Pressed = New DevComponents.DotNetBar.Rendering.Office2007ButtonItemStateColorTable()
        table.Pressed.OuterBorder.Start = System.Drawing.Color.Maroon
        table.Pressed.OuterBorder.End = System.Drawing.Color.Black
        table.Pressed.TopBackground.Start = System.Drawing.Color.Yellow
        table.Pressed.TopBackground.End = System.Drawing.Color.OrangeRed
        table.Pressed.BottomBackground.Start = System.Drawing.Color.OrangeRed
        table.Pressed.BottomBackground.End = System.Drawing.Color.DarkOrange
        table.Pressed.BottomBackgroundHighlight.Start = System.Drawing.Color.Yellow
        table.Pressed.BottomBackgroundHighlight.End = System.Drawing.Color.Transparent
        table.Pressed.Text = System.Drawing.Color.Maroon

        If TypeOf (DevComponents.DotNetBar.Rendering.GlobalManager.Renderer) Is DevComponents.DotNetBar.Rendering.Office2007Renderer Then
            Dim r As DevComponents.DotNetBar.Rendering.Office2007Renderer = CType(DevComponents.DotNetBar.Rendering.GlobalManager.Renderer, DevComponents.DotNetBar.Rendering.Office2007Renderer)
            r.ColorTable.ButtonItemColors.Add(table)
        End If

        ' Start Button Pulse
        buttonX6.Pulse(11)
    End Sub
End Class
