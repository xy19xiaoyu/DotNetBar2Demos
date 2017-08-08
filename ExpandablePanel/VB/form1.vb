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
    Friend WithEvents buttonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents panelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents expandablePanel3 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents expandablePanel2 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents expandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents expandablePanel5 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents itemPanel2 As DevComponents.DotNetBar.ItemPanel
    Friend WithEvents expandablePanel4 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents itemPanel1 As DevComponents.DotNetBar.ItemPanel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.buttonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.expandablePanel3 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.expandablePanel2 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.expandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.expandablePanel5 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.itemPanel2 = New DevComponents.DotNetBar.ItemPanel()
        Me.expandablePanel4 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.itemPanel1 = New DevComponents.DotNetBar.ItemPanel()
        Me.panelEx1.SuspendLayout()
        Me.expandablePanel1.SuspendLayout()
        Me.expandablePanel5.SuspendLayout()
        Me.expandablePanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonItem4
        '
        Me.buttonItem4.Name = "buttonItem4"
        Me.buttonItem4.Text = "Red"
        '
        'buttonItem5
        '
        Me.buttonItem5.Name = "buttonItem5"
        Me.buttonItem5.Text = "Dark Blue"
        '
        'buttonItem6
        '
        Me.buttonItem6.Name = "buttonItem6"
        Me.buttonItem6.Text = "Orange"
        '
        'buttonItem7
        '
        Me.buttonItem7.Name = "buttonItem7"
        Me.buttonItem7.Text = "Green"
        '
        'buttonItem1
        '
        Me.buttonItem1.Name = "buttonItem1"
        Me.buttonItem1.Text = "Black"
        '
        'buttonItem2
        '
        Me.buttonItem2.Name = "buttonItem2"
        Me.buttonItem2.Text = "Blue"
        '
        'buttonItem3
        '
        Me.buttonItem3.Name = "buttonItem3"
        Me.buttonItem3.Text = "Silver"
        '
        'panelEx1
        '
        Me.panelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelEx1.Controls.AddRange(New System.Windows.Forms.Control() {Me.expandablePanel3, Me.expandablePanel2, Me.expandablePanel1})
        Me.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelEx1.Name = "panelEx1"
        Me.panelEx1.Size = New System.Drawing.Size(536, 286)
        Me.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.panelEx1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
        Me.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.panelEx1.Style.GradientAngle = 90
        Me.panelEx1.TabIndex = 1
        '
        'expandablePanel3
        '
        Me.expandablePanel3.ButtonImageCollapse = CType(resources.GetObject("expandablePanel3.ButtonImageCollapse"), System.Drawing.Bitmap)
        Me.expandablePanel3.ButtonImageExpand = CType(resources.GetObject("expandablePanel3.ButtonImageExpand"), System.Drawing.Bitmap)
        Me.expandablePanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.expandablePanel3.DockPadding.All = 3
        Me.expandablePanel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expandablePanel3.Location = New System.Drawing.Point(352, 8)
        Me.expandablePanel3.Name = "expandablePanel3"
        Me.expandablePanel3.Size = New System.Drawing.Size(168, 264)
        Me.expandablePanel3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.expandablePanel3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuSide
        Me.expandablePanel3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuSide2
        Me.expandablePanel3.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
        Me.expandablePanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.expandablePanel3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.expandablePanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.expandablePanel3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandablePanel3.Style.GradientAngle = -90
        Me.expandablePanel3.Style.WordWrap = True
        Me.expandablePanel3.TabIndex = 2
        Me.expandablePanel3.Text = "ExpandablePanel with rounded border and custom style for title bar. Custom expand" & _
        "/collapse button is used as well."
        Me.expandablePanel3.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.expandablePanel3.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground
        Me.expandablePanel3.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground2
        Me.expandablePanel3.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.expandablePanel3.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder
        Me.expandablePanel3.TitleStyle.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.expandablePanel3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.expandablePanel3.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText
        Me.expandablePanel3.TitleStyle.GradientAngle = 90
        Me.expandablePanel3.TitleText = "Title Bar"
        '
        'expandablePanel2
        '
        Me.expandablePanel2.ButtonImageCollapse = CType(resources.GetObject("expandablePanel2.ButtonImageCollapse"), System.Drawing.Bitmap)
        Me.expandablePanel2.ButtonImageExpand = CType(resources.GetObject("expandablePanel2.ButtonImageExpand"), System.Drawing.Bitmap)
        Me.expandablePanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.expandablePanel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expandablePanel2.Location = New System.Drawing.Point(168, 8)
        Me.expandablePanel2.Name = "expandablePanel2"
        Me.expandablePanel2.Size = New System.Drawing.Size(168, 264)
        Me.expandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.expandablePanel2.Style.BackColor1.Color = System.Drawing.Color.White
        Me.expandablePanel2.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
        Me.expandablePanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.expandablePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.expandablePanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.expandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandablePanel2.Style.GradientAngle = 90
        Me.expandablePanel2.Style.WordWrap = True
        Me.expandablePanel2.TabIndex = 1
        Me.expandablePanel2.Text = "ExpandablePanel with rounded border and custom style for title bar. Custom expand" & _
        "/collapse button is used as well."
        Me.expandablePanel2.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.expandablePanel2.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.expandablePanel2.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.expandablePanel2.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.expandablePanel2.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandablePanel2.TitleStyle.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.expandablePanel2.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.expandablePanel2.TitleStyle.GradientAngle = 90
        Me.expandablePanel2.TitleText = "Title Bar"
        '
        'expandablePanel1
        '
        Me.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft
        Me.expandablePanel1.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.expandablePanel1.ColorScheme.ItemDesignTimeBorder = System.Drawing.Color.Black
        Me.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.expandablePanel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.expandablePanel5, Me.expandablePanel4})
        Me.expandablePanel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expandablePanel1.Location = New System.Drawing.Point(8, 8)
        Me.expandablePanel1.Name = "expandablePanel1"
        Me.expandablePanel1.Size = New System.Drawing.Size(144, 264)
        Me.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.expandablePanel1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
        Me.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandablePanel1.Style.GradientAngle = 90
        Me.expandablePanel1.Style.WordWrap = True
        Me.expandablePanel1.TabIndex = 0
        Me.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.expandablePanel1.TitleStyle.GradientAngle = 90
        Me.expandablePanel1.TitleStyle.MarginLeft = 6
        Me.expandablePanel1.TitleText = "Panel Styles"
        '
        'expandablePanel5
        '
        Me.expandablePanel5.CanvasColor = System.Drawing.SystemColors.Control
        Me.expandablePanel5.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.expandablePanel5.ColorScheme.ItemDesignTimeBorder = System.Drawing.Color.Black
        Me.expandablePanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.expandablePanel5.Controls.AddRange(New System.Windows.Forms.Control() {Me.itemPanel2})
        Me.expandablePanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.expandablePanel5.ExpandOnTitleClick = True
        Me.expandablePanel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expandablePanel5.Location = New System.Drawing.Point(0, 128)
        Me.expandablePanel5.Name = "expandablePanel5"
        Me.expandablePanel5.Size = New System.Drawing.Size(144, 136)
        Me.expandablePanel5.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.expandablePanel5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.expandablePanel5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.expandablePanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.expandablePanel5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.expandablePanel5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandablePanel5.Style.GradientAngle = 90
        Me.expandablePanel5.TabIndex = 3
        Me.expandablePanel5.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.expandablePanel5.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.expandablePanel5.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.expandablePanel5.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandablePanel5.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.expandablePanel5.TitleStyle.GradientAngle = 90
        Me.expandablePanel5.TitleStyle.MarginLeft = 12
        Me.expandablePanel5.TitleText = "Custom Schemes"
        '
        'itemPanel2
        '
        '
        'itemPanel2.BackgroundStyle
        '
        Me.itemPanel2.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.itemPanel2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.itemPanel2.BackgroundStyle.BorderBottomWidth = 1
        Me.itemPanel2.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(CType(127, Byte), CType(157, Byte), CType(185, Byte))
        Me.itemPanel2.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.itemPanel2.BackgroundStyle.BorderLeftWidth = 1
        Me.itemPanel2.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.itemPanel2.BackgroundStyle.BorderRightWidth = 1
        Me.itemPanel2.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.itemPanel2.BackgroundStyle.BorderTopWidth = 1
        Me.itemPanel2.BackgroundStyle.PaddingBottom = 1
        Me.itemPanel2.BackgroundStyle.PaddingLeft = 1
        Me.itemPanel2.BackgroundStyle.PaddingRight = 1
        Me.itemPanel2.BackgroundStyle.PaddingTop = 1
        Me.itemPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemPanel2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem4, Me.buttonItem5, Me.buttonItem6, Me.buttonItem7})
        Me.itemPanel2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.itemPanel2.Location = New System.Drawing.Point(0, 26)
        Me.itemPanel2.Name = "itemPanel2"
        Me.itemPanel2.Size = New System.Drawing.Size(144, 110)
        Me.itemPanel2.TabIndex = 3
        Me.itemPanel2.Text = "itemPanel2"
        '
        'expandablePanel4
        '
        Me.expandablePanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.expandablePanel4.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.expandablePanel4.ColorScheme.ItemDesignTimeBorder = System.Drawing.Color.Black
        Me.expandablePanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.expandablePanel4.Controls.AddRange(New System.Windows.Forms.Control() {Me.itemPanel1})
        Me.expandablePanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.expandablePanel4.ExpandOnTitleClick = True
        Me.expandablePanel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expandablePanel4.Location = New System.Drawing.Point(0, 26)
        Me.expandablePanel4.Name = "expandablePanel4"
        Me.expandablePanel4.Size = New System.Drawing.Size(144, 102)
        Me.expandablePanel4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.expandablePanel4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.expandablePanel4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.expandablePanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.expandablePanel4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.expandablePanel4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandablePanel4.Style.GradientAngle = 90
        Me.expandablePanel4.TabIndex = 3
        Me.expandablePanel4.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.expandablePanel4.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.expandablePanel4.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.expandablePanel4.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandablePanel4.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.expandablePanel4.TitleStyle.GradientAngle = 90
        Me.expandablePanel4.TitleStyle.MarginLeft = 12
        Me.expandablePanel4.TitleText = "Office 2007 Colors"
        '
        'itemPanel1
        '
        '
        'itemPanel1.BackgroundStyle
        '
        Me.itemPanel1.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.itemPanel1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.itemPanel1.BackgroundStyle.BorderBottomWidth = 1
        Me.itemPanel1.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(CType(127, Byte), CType(157, Byte), CType(185, Byte))
        Me.itemPanel1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.itemPanel1.BackgroundStyle.BorderLeftWidth = 1
        Me.itemPanel1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.itemPanel1.BackgroundStyle.BorderRightWidth = 1
        Me.itemPanel1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.itemPanel1.BackgroundStyle.BorderTopWidth = 1
        Me.itemPanel1.BackgroundStyle.PaddingBottom = 1
        Me.itemPanel1.BackgroundStyle.PaddingLeft = 1
        Me.itemPanel1.BackgroundStyle.PaddingRight = 1
        Me.itemPanel1.BackgroundStyle.PaddingTop = 1
        Me.itemPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemPanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem1, Me.buttonItem2, Me.buttonItem3})
        Me.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.itemPanel1.Location = New System.Drawing.Point(0, 26)
        Me.itemPanel1.Name = "itemPanel1"
        Me.itemPanel1.Size = New System.Drawing.Size(144, 76)
        Me.itemPanel1.TabIndex = 3
        Me.itemPanel1.Text = "itemPanel1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 286)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panelEx1})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panelEx1.ResumeLayout(False)
        Me.expandablePanel1.ResumeLayout(False)
        Me.expandablePanel5.ResumeLayout(False)
        Me.expandablePanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub buttonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonItem1.Click
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black)
    End Sub

    Private Sub buttonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonItem2.Click
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue)
    End Sub

    Private Sub buttonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonItem3.Click
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver)
    End Sub

    Private Sub buttonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonItem4.Click
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black, Color.Red)
    End Sub

    Private Sub buttonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonItem5.Click
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue, Color.DarkBlue)
    End Sub

    Private Sub buttonItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonItem6.Click
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver, Color.Orange)
    End Sub

    Private Sub buttonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonItem7.Click
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver, Color.Green)
    End Sub
End Class
