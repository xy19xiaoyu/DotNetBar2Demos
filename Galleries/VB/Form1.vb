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
    Friend WithEvents buttonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents itemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents buttonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents labelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents buttonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents itemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents buttonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents labelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents buttonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents labelItem3 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents itemContainer3 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents buttonItem10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem11 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents labelItem4 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents itemContainer4 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents buttonItem12 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem13 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents ribbonTabItem1 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ribbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents ribbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents ribbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents galleryContainer1 As DevComponents.DotNetBar.GalleryContainer
    Friend WithEvents buttonItem14 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem15 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem16 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem17 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem18 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem19 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem20 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem21 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem22 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem23 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem24 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem25 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents GalleryGroup1 As DevComponents.DotNetBar.GalleryGroup
    Friend WithEvents GalleryGroup2 As DevComponents.DotNetBar.GalleryGroup
    Friend WithEvents GalleryGroup3 As DevComponents.DotNetBar.GalleryGroup
    Friend WithEvents GalleryGroup4 As DevComponents.DotNetBar.GalleryGroup
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.buttonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.itemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.buttonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.labelItem2 = New DevComponents.DotNetBar.LabelItem()
        Me.buttonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.itemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.labelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.buttonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.labelItem3 = New DevComponents.DotNetBar.LabelItem()
        Me.itemContainer3 = New DevComponents.DotNetBar.ItemContainer()
        Me.buttonItem10 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem11 = New DevComponents.DotNetBar.ButtonItem()
        Me.labelItem4 = New DevComponents.DotNetBar.LabelItem()
        Me.itemContainer4 = New DevComponents.DotNetBar.ItemContainer()
        Me.buttonItem12 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem13 = New DevComponents.DotNetBar.ButtonItem()
        Me.label1 = New System.Windows.Forms.Label()
        Me.ribbonTabItem1 = New DevComponents.DotNetBar.RibbonTabItem()
        Me.ribbonPanel1 = New DevComponents.DotNetBar.RibbonPanel()
        Me.ribbonBar1 = New DevComponents.DotNetBar.RibbonBar()
        Me.galleryContainer1 = New DevComponents.DotNetBar.GalleryContainer()
        Me.buttonItem14 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem15 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem16 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem17 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem18 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem19 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem20 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem21 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem22 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem23 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem24 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem25 = New DevComponents.DotNetBar.ButtonItem()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ribbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.GalleryGroup1 = New DevComponents.DotNetBar.GalleryGroup()
        Me.GalleryGroup2 = New DevComponents.DotNetBar.GalleryGroup()
        Me.GalleryGroup3 = New DevComponents.DotNetBar.GalleryGroup()
        Me.GalleryGroup4 = New DevComponents.DotNetBar.GalleryGroup()
        Me.ribbonPanel1.SuspendLayout()
        Me.ribbonControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonItem6
        '
        Me.buttonItem6.Image = CType(resources.GetObject("buttonItem6.Image"), System.Drawing.Bitmap)
        Me.buttonItem6.Name = "buttonItem6"
        Me.buttonItem6.Text = "Surface Graph 1"
        '
        'itemContainer2
        '
        Me.itemContainer2.MinimumSize = New System.Drawing.Size(0, 0)
        Me.itemContainer2.Name = "itemContainer2"
        Me.itemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem6, Me.buttonItem7, Me.buttonItem8, Me.buttonItem9})
        '
        'buttonItem7
        '
        Me.buttonItem7.Image = CType(resources.GetObject("buttonItem7.Image"), System.Drawing.Bitmap)
        Me.buttonItem7.Name = "buttonItem7"
        Me.buttonItem7.Text = "Surface Graph 2"
        '
        'buttonItem8
        '
        Me.buttonItem8.Image = CType(resources.GetObject("buttonItem8.Image"), System.Drawing.Bitmap)
        Me.buttonItem8.Name = "buttonItem8"
        Me.buttonItem8.Text = "Surface Graph 3"
        '
        'buttonItem9
        '
        Me.buttonItem9.Image = CType(resources.GetObject("buttonItem9.Image"), System.Drawing.Bitmap)
        Me.buttonItem9.Name = "buttonItem9"
        Me.buttonItem9.Text = "Surface Graph 4"
        '
        'labelItem2
        '
        Me.labelItem2.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(228, Byte), CType(236, Byte))
        Me.labelItem2.BorderType = DevComponents.DotNetBar.eBorderType.Raised
        Me.labelItem2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(15, Byte), CType(99, Byte))
        Me.labelItem2.Name = "labelItem2"
        Me.labelItem2.PaddingBottom = 1
        Me.labelItem2.PaddingTop = 1
        Me.labelItem2.SingleLineColor = System.Drawing.Color.DarkGray
        Me.labelItem2.Text = "Surface"
        '
        'buttonItem5
        '
        Me.buttonItem5.Image = CType(resources.GetObject("buttonItem5.Image"), System.Drawing.Bitmap)
        Me.buttonItem5.Name = "buttonItem5"
        Me.buttonItem5.Text = "Stock Line 4"
        '
        'itemContainer1
        '
        Me.itemContainer1.MinimumSize = New System.Drawing.Size(0, 0)
        Me.itemContainer1.Name = "itemContainer1"
        Me.itemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem2, Me.buttonItem3, Me.buttonItem4, Me.buttonItem5})
        '
        'buttonItem2
        '
        Me.buttonItem2.Image = CType(resources.GetObject("buttonItem2.Image"), System.Drawing.Bitmap)
        Me.buttonItem2.Name = "buttonItem2"
        Me.buttonItem2.Text = "Stock-Line"
        '
        'buttonItem3
        '
        Me.buttonItem3.Image = CType(resources.GetObject("buttonItem3.Image"), System.Drawing.Bitmap)
        Me.buttonItem3.Name = "buttonItem3"
        Me.buttonItem3.Text = "Stock Line 2"
        '
        'buttonItem4
        '
        Me.buttonItem4.Image = CType(resources.GetObject("buttonItem4.Image"), System.Drawing.Bitmap)
        Me.buttonItem4.Name = "buttonItem4"
        Me.buttonItem4.Text = "Stock Line 3"
        '
        'labelItem1
        '
        Me.labelItem1.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(228, Byte), CType(236, Byte))
        Me.labelItem1.BorderType = DevComponents.DotNetBar.eBorderType.Raised
        Me.labelItem1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(15, Byte), CType(99, Byte))
        Me.labelItem1.Name = "labelItem1"
        Me.labelItem1.PaddingBottom = 1
        Me.labelItem1.PaddingTop = 1
        Me.labelItem1.SingleLineColor = System.Drawing.Color.DarkGray
        Me.labelItem1.Text = "Stock"
        '
        'buttonItem1
        '
        Me.buttonItem1.AutoExpandOnClick = True
        Me.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.buttonItem1.Image = CType(resources.GetObject("buttonItem1.Image"), System.Drawing.Bitmap)
        Me.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.buttonItem1.Name = "buttonItem1"
        Me.buttonItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.labelItem1, Me.itemContainer1, Me.labelItem2, Me.itemContainer2, Me.labelItem3, Me.itemContainer3, Me.labelItem4, Me.itemContainer4})
        Me.buttonItem1.Text = "Chart"
        '
        'labelItem3
        '
        Me.labelItem3.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(228, Byte), CType(236, Byte))
        Me.labelItem3.BorderType = DevComponents.DotNetBar.eBorderType.Raised
        Me.labelItem3.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(15, Byte), CType(99, Byte))
        Me.labelItem3.Name = "labelItem3"
        Me.labelItem3.PaddingBottom = 1
        Me.labelItem3.PaddingTop = 1
        Me.labelItem3.SingleLineColor = System.Drawing.Color.DarkGray
        Me.labelItem3.Text = "Doughnut"
        '
        'itemContainer3
        '
        Me.itemContainer3.MinimumSize = New System.Drawing.Size(0, 0)
        Me.itemContainer3.Name = "itemContainer3"
        Me.itemContainer3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem10, Me.buttonItem11})
        '
        'buttonItem10
        '
        Me.buttonItem10.Image = CType(resources.GetObject("buttonItem10.Image"), System.Drawing.Bitmap)
        Me.buttonItem10.Name = "buttonItem10"
        Me.buttonItem10.Text = "Doughnut Graph 1"
        '
        'buttonItem11
        '
        Me.buttonItem11.Image = CType(resources.GetObject("buttonItem11.Image"), System.Drawing.Bitmap)
        Me.buttonItem11.Name = "buttonItem11"
        Me.buttonItem11.Text = "Doughnut Graph 2"
        '
        'labelItem4
        '
        Me.labelItem4.BackColor = System.Drawing.Color.FromArgb(CType(217, Byte), CType(228, Byte), CType(236, Byte))
        Me.labelItem4.BorderType = DevComponents.DotNetBar.eBorderType.Raised
        Me.labelItem4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(15, Byte), CType(99, Byte))
        Me.labelItem4.Name = "labelItem4"
        Me.labelItem4.PaddingBottom = 1
        Me.labelItem4.PaddingTop = 1
        Me.labelItem4.SingleLineColor = System.Drawing.Color.DarkGray
        Me.labelItem4.Text = "Bubble"
        '
        'itemContainer4
        '
        Me.itemContainer4.MinimumSize = New System.Drawing.Size(0, 0)
        Me.itemContainer4.Name = "itemContainer4"
        Me.itemContainer4.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem12, Me.buttonItem13})
        '
        'buttonItem12
        '
        Me.buttonItem12.Image = CType(resources.GetObject("buttonItem12.Image"), System.Drawing.Bitmap)
        Me.buttonItem12.Name = "buttonItem12"
        Me.buttonItem12.Text = "Bubble Graph 1"
        '
        'buttonItem13
        '
        Me.buttonItem13.Image = CType(resources.GetObject("buttonItem13.Image"), System.Drawing.Bitmap)
        Me.buttonItem13.Name = "buttonItem13"
        Me.buttonItem13.Text = "Bubble Graph 2"
        '
        'label1
        '
        Me.label1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.label1.Location = New System.Drawing.Point(272, 135)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(96, 16)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Preview"
        '
        'ribbonTabItem1
        '
        Me.ribbonTabItem1.Checked = True
        Me.ribbonTabItem1.Name = "ribbonTabItem1"
        Me.ribbonTabItem1.Panel = Me.ribbonPanel1
        Me.ribbonTabItem1.Text = "Insert"
        '
        'ribbonPanel1
        '
        Me.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ribbonPanel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.ribbonBar1})
        Me.ribbonPanel1.DefaultLayout = True
        Me.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ribbonPanel1.DockPadding.Bottom = 3
        Me.ribbonPanel1.DockPadding.Left = 3
        Me.ribbonPanel1.DockPadding.Right = 3
        Me.ribbonPanel1.Location = New System.Drawing.Point(0, 25)
        Me.ribbonPanel1.Name = "ribbonPanel1"
        Me.ribbonPanel1.Size = New System.Drawing.Size(464, 93)
        '
        'ribbonPanel1.Style
        '
        Me.ribbonPanel1.Style.BackColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(232, Byte), CType(245, Byte))
        Me.ribbonPanel1.Style.BackColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(222, Byte), CType(232, Byte), CType(245, Byte)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(209, Byte), CType(223, Byte), CType(240, Byte)), 15.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(199, Byte), CType(216, Byte), CType(237, Byte)), 15.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(231, Byte), CType(242, Byte), CType(255, Byte)), 1.0!)})
        Me.ribbonPanel1.Style.BackColorGradientAngle = 90
        Me.ribbonPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double
        Me.ribbonPanel1.Style.BorderBottomWidth = 1
        Me.ribbonPanel1.Style.BorderColor = System.Drawing.Color.FromArgb(CType(141, Byte), CType(178, Byte), CType(227, Byte))
        Me.ribbonPanel1.Style.BorderColor2 = System.Drawing.Color.FromArgb(CType(136, Byte), CType(161, Byte), CType(194, Byte))
        Me.ribbonPanel1.Style.BorderColorLight = System.Drawing.Color.FromArgb(CType(231, Byte), CType(239, Byte), CType(248, Byte))
        Me.ribbonPanel1.Style.BorderColorLight2 = System.Drawing.Color.FromArgb(CType(192, Byte), CType(249, Byte), CType(255, Byte))
        Me.ribbonPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double
        Me.ribbonPanel1.Style.BorderLeftWidth = 1
        Me.ribbonPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double
        Me.ribbonPanel1.Style.BorderRightWidth = 1
        Me.ribbonPanel1.Style.BorderTopWidth = 1
        Me.ribbonPanel1.Style.CornerDiameter = 3
        Me.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ribbonPanel1.Style.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonPanel1.Style.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Square
        Me.ribbonPanel1.TabIndex = 1
        '
        'ribbonBar1
        '
        Me.ribbonBar1.AutoOverflowEnabled = True
        Me.ribbonBar1.BackColor = System.Drawing.Color.Transparent
        '
        'ribbonBar1.BackgroundMouseOverStyle
        '
        Me.ribbonBar1.BackgroundMouseOverStyle.BackColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(230, Byte), CType(241, Byte), CType(255, Byte)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(233, Byte), CType(241, Byte), CType(253, Byte)), 15.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(222, Byte), CType(236, Byte), CType(253, Byte)), 15.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(222, Byte), CType(234, Byte), CType(250, Byte)), 1.0!)})
        Me.ribbonBar1.BackgroundMouseOverStyle.BackColorGradientAngle = 90
        Me.ribbonBar1.BackgroundMouseOverStyle.BorderColor = System.Drawing.Color.FromArgb(CType(173, Byte), CType(199, Byte), CType(224, Byte))
        Me.ribbonBar1.BackgroundMouseOverStyle.BorderColor2 = System.Drawing.Color.FromArgb(CType(126, Byte), CType(173, Byte), CType(211, Byte))
        Me.ribbonBar1.BackgroundMouseOverStyle.BorderColorLight = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(255, Byte))
        '
        'ribbonBar1.BackgroundStyle
        '
        Me.ribbonBar1.BackgroundStyle.BackColorBlend.AddRange(New DevComponents.DotNetBar.BackgroundColorBlend() {New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(222, Byte), CType(232, Byte), CType(245, Byte)), 0.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(209, Byte), CType(223, Byte), CType(240, Byte)), 15.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(199, Byte), CType(216, Byte), CType(237, Byte)), 15.0!), New DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(CType(231, Byte), CType(242, Byte), CType(255, Byte)), 1.0!)})
        Me.ribbonBar1.BackgroundStyle.BackColorGradientAngle = 90
        Me.ribbonBar1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.ribbonBar1.BackgroundStyle.BorderBottomWidth = 1
        Me.ribbonBar1.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(CType(198, Byte), CType(210, Byte), CType(223, Byte))
        Me.ribbonBar1.BackgroundStyle.BorderColor2 = System.Drawing.Color.FromArgb(CType(159, Byte), CType(193, Byte), CType(219, Byte))
        Me.ribbonBar1.BackgroundStyle.BorderColorLight = System.Drawing.Color.FromArgb(CType(239, Byte), CType(244, Byte), CType(250, Byte))
        Me.ribbonBar1.BackgroundStyle.BorderColorLight2 = System.Drawing.Color.FromArgb(CType(243, Byte), CType(249, Byte), CType(255, Byte))
        Me.ribbonBar1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.ribbonBar1.BackgroundStyle.BorderLeftWidth = 1
        Me.ribbonBar1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.ribbonBar1.BackgroundStyle.BorderRightWidth = 1
        Me.ribbonBar1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched
        Me.ribbonBar1.BackgroundStyle.BorderTopWidth = 1
        Me.ribbonBar1.BackgroundStyle.CornerDiameter = 3
        Me.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ribbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem1, Me.galleryContainer1})
        Me.ribbonBar1.Location = New System.Drawing.Point(3, 0)
        Me.ribbonBar1.Name = "ribbonBar1"
        Me.ribbonBar1.Size = New System.Drawing.Size(309, 90)
        Me.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ribbonBar1.TabIndex = 1
        Me.ribbonBar1.Text = "Drop-Down Galleries"
        '
        'ribbonBar1.TitleStyle
        '
        Me.ribbonBar1.TitleStyle.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(217, Byte), CType(241, Byte))
        Me.ribbonBar1.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(193, Byte), CType(217, Byte), CType(240, Byte))
        Me.ribbonBar1.TitleStyle.BackColorGradientAngle = 90
        Me.ribbonBar1.TitleStyle.PaddingBottom = 1
        Me.ribbonBar1.TitleStyle.PaddingTop = 1
        Me.ribbonBar1.TitleStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ribbonBar1.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(62, Byte), CType(106, Byte), CType(170, Byte))
        '
        'ribbonBar1.TitleStyleMouseOver
        '
        Me.ribbonBar1.TitleStyleMouseOver.BackColor = System.Drawing.Color.FromArgb(CType(200, Byte), CType(224, Byte), CType(255, Byte))
        Me.ribbonBar1.TitleStyleMouseOver.BackColor2 = System.Drawing.Color.FromArgb(CType(214, Byte), CType(237, Byte), CType(255, Byte))
        Me.ribbonBar1.TitleStyleMouseOver.BackColorGradientAngle = 90
        Me.ribbonBar1.TitleStyleMouseOver.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ribbonBar1.TitleStyleMouseOver.TextColor = System.Drawing.Color.FromArgb(CType(62, Byte), CType(106, Byte), CType(170, Byte))
        '
        'galleryContainer1
        '
        '
        'galleryContainer1.BackgroundStyle
        '
        Me.galleryContainer1.BackgroundStyle.Class = "RibbonGalleryContainer"
        Me.galleryContainer1.GalleryGroups.AddRange(New DevComponents.DotNetBar.GalleryGroup() {Me.GalleryGroup1, Me.GalleryGroup2, Me.GalleryGroup3, Me.GalleryGroup4})
        Me.galleryContainer1.MinimumSize = New System.Drawing.Size(58, 58)
        Me.galleryContainer1.Name = "galleryContainer1"
        Me.galleryContainer1.StretchGallery = True
        Me.galleryContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem14, Me.buttonItem15, Me.buttonItem16, Me.buttonItem17, Me.buttonItem18, Me.buttonItem19, Me.buttonItem20, Me.buttonItem21, Me.buttonItem22, Me.buttonItem23, Me.buttonItem24, Me.buttonItem25})
        '
        'buttonItem14
        '
        Me.galleryContainer1.SetGalleryGroup(Me.buttonItem14, Me.GalleryGroup1)
        Me.buttonItem14.Image = CType(resources.GetObject("buttonItem14.Image"), System.Drawing.Bitmap)
        Me.buttonItem14.Name = "buttonItem14"
        Me.buttonItem14.Text = "buttonItem14"
        '
        'buttonItem15
        '
        Me.galleryContainer1.SetGalleryGroup(Me.buttonItem15, Me.GalleryGroup1)
        Me.buttonItem15.Image = CType(resources.GetObject("buttonItem15.Image"), System.Drawing.Bitmap)
        Me.buttonItem15.Name = "buttonItem15"
        Me.buttonItem15.Text = "buttonItem15"
        '
        'buttonItem16
        '
        Me.galleryContainer1.SetGalleryGroup(Me.buttonItem16, Me.GalleryGroup1)
        Me.buttonItem16.Image = CType(resources.GetObject("buttonItem16.Image"), System.Drawing.Bitmap)
        Me.buttonItem16.Name = "buttonItem16"
        Me.buttonItem16.Text = "buttonItem16"
        '
        'buttonItem17
        '
        Me.galleryContainer1.SetGalleryGroup(Me.buttonItem17, Me.GalleryGroup1)
        Me.buttonItem17.Image = CType(resources.GetObject("buttonItem17.Image"), System.Drawing.Bitmap)
        Me.buttonItem17.Name = "buttonItem17"
        Me.buttonItem17.Text = "buttonItem17"
        '
        'buttonItem18
        '
        Me.galleryContainer1.SetGalleryGroup(Me.buttonItem18, Me.GalleryGroup2)
        Me.buttonItem18.Image = CType(resources.GetObject("buttonItem18.Image"), System.Drawing.Bitmap)
        Me.buttonItem18.Name = "buttonItem18"
        Me.buttonItem18.Text = "buttonItem18"
        '
        'buttonItem19
        '
        Me.galleryContainer1.SetGalleryGroup(Me.buttonItem19, Me.GalleryGroup2)
        Me.buttonItem19.Image = CType(resources.GetObject("buttonItem19.Image"), System.Drawing.Bitmap)
        Me.buttonItem19.Name = "buttonItem19"
        Me.buttonItem19.Text = "buttonItem19"
        '
        'buttonItem20
        '
        Me.galleryContainer1.SetGalleryGroup(Me.buttonItem20, Me.GalleryGroup2)
        Me.buttonItem20.Image = CType(resources.GetObject("buttonItem20.Image"), System.Drawing.Bitmap)
        Me.buttonItem20.Name = "buttonItem20"
        Me.buttonItem20.Text = "buttonItem20"
        '
        'buttonItem21
        '
        Me.galleryContainer1.SetGalleryGroup(Me.buttonItem21, Me.GalleryGroup2)
        Me.buttonItem21.Image = CType(resources.GetObject("buttonItem21.Image"), System.Drawing.Bitmap)
        Me.buttonItem21.Name = "buttonItem21"
        Me.buttonItem21.Text = "buttonItem21"
        '
        'buttonItem22
        '
        Me.galleryContainer1.SetGalleryGroup(Me.buttonItem22, Me.GalleryGroup3)
        Me.buttonItem22.Image = CType(resources.GetObject("buttonItem22.Image"), System.Drawing.Bitmap)
        Me.buttonItem22.Name = "buttonItem22"
        Me.buttonItem22.Text = "buttonItem22"
        '
        'buttonItem23
        '
        Me.galleryContainer1.SetGalleryGroup(Me.buttonItem23, Me.GalleryGroup3)
        Me.buttonItem23.Image = CType(resources.GetObject("buttonItem23.Image"), System.Drawing.Bitmap)
        Me.buttonItem23.Name = "buttonItem23"
        Me.buttonItem23.Text = "buttonItem23"
        '
        'buttonItem24
        '
        Me.galleryContainer1.SetGalleryGroup(Me.buttonItem24, Me.GalleryGroup4)
        Me.buttonItem24.Image = CType(resources.GetObject("buttonItem24.Image"), System.Drawing.Bitmap)
        Me.buttonItem24.Name = "buttonItem24"
        Me.buttonItem24.Text = "buttonItem24"
        '
        'buttonItem25
        '
        Me.galleryContainer1.SetGalleryGroup(Me.buttonItem25, Me.GalleryGroup4)
        Me.buttonItem25.Image = CType(resources.GetObject("buttonItem25.Image"), System.Drawing.Bitmap)
        Me.buttonItem25.Name = "buttonItem25"
        Me.buttonItem25.Text = "buttonItem25"
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.pictureBox1.BackColor = System.Drawing.Color.White
        Me.pictureBox1.Location = New System.Drawing.Point(272, 159)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(176, 152)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox1.TabIndex = 4
        Me.pictureBox1.TabStop = False
        '
        'ribbonControl1
        '
        '
        'ribbonControl1.BackgroundStyle
        '
        Me.ribbonControl1.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(CType(191, Byte), CType(219, Byte), CType(255, Byte))
        Me.ribbonControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.ribbonPanel1})
        Me.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ribbonControl1.DockPadding.Bottom = 2
        Me.ribbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ribbonTabItem1})
        Me.ribbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Size = New System.Drawing.Size(464, 120)
        Me.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ribbonControl1.TabGroupHeight = 14
        Me.ribbonControl1.TabIndex = 3
        '
        'GalleryGroup1
        '
        Me.GalleryGroup1.Name = "GalleryGroup1"
        Me.GalleryGroup1.Text = "<b>Stock</b>"
        '
        'GalleryGroup2
        '
        Me.GalleryGroup2.DisplayOrder = 1
        Me.GalleryGroup2.Name = "GalleryGroup2"
        Me.GalleryGroup2.Text = "<b>Surface</b>"
        '
        'GalleryGroup3
        '
        Me.GalleryGroup3.DisplayOrder = 2
        Me.GalleryGroup3.Name = "GalleryGroup3"
        Me.GalleryGroup3.Text = "<b>Doughnut</b>"
        '
        'GalleryGroup4
        '
        Me.GalleryGroup4.DisplayOrder = 3
        Me.GalleryGroup4.Name = "GalleryGroup4"
        Me.GalleryGroup4.Text = "<b>Bubble</b>"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(464, 318)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.label1, Me.pictureBox1, Me.ribbonControl1})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ribbonPanel1.ResumeLayout(False)
        Me.ribbonControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ribbonBar1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ribbonBar1.MouseEnter
        Dim item As BaseItem = CType(sender, BaseItem)
        If item Is Nothing Then
            ResetPreview()
            Exit Sub
        End If

        If item.IsOnMenu AndAlso TypeOf (item) Is ButtonItem Then
            Dim button As ButtonItem = CType(item, ButtonItem)
            pictureBox1.Image = button.Image
        End If
    End Sub

    Private Sub ribbonBar1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ribbonBar1.MouseLeave
        ResetPreview()
    End Sub

    Private Sub ResetPreview()
        pictureBox1.Image = Nothing
    End Sub
End Class
