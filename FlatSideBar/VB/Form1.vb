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
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents sideBar1 As DevComponents.DotNetBar.SideBar
    Friend WithEvents sideBarPanelItem1 As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents buttonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents sideBarPanelItem2 As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents buttonItem11 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem12 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonItem13 As DevComponents.DotNetBar.ButtonItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.label2 = New System.Windows.Forms.Label()
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.sideBar1 = New DevComponents.DotNetBar.SideBar()
        Me.sideBarPanelItem1 = New DevComponents.DotNetBar.SideBarPanelItem()
        Me.buttonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem10 = New DevComponents.DotNetBar.ButtonItem()
        Me.sideBarPanelItem2 = New DevComponents.DotNetBar.SideBarPanelItem()
        Me.buttonItem11 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem12 = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonItem13 = New DevComponents.DotNetBar.ButtonItem()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(192, 29)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(144, 16)
        Me.label2.TabIndex = 8
        Me.label2.Text = "Click Event Log:"
        '
        'richTextBox1
        '
        Me.richTextBox1.Location = New System.Drawing.Point(192, 48)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.richTextBox1.Size = New System.Drawing.Size(248, 208)
        Me.richTextBox1.TabIndex = 7
        Me.richTextBox1.Text = ""
        '
        'comboBox1
        '
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.Location = New System.Drawing.Point(8, 21)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(176, 21)
        Me.comboBox1.TabIndex = 6
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(8, 5)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(144, 16)
        Me.label1.TabIndex = 5
        Me.label1.Text = "SideBar Color Scheme:"
        '
        'sideBar1
        '
        Me.sideBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.sideBar1.Appearance = DevComponents.DotNetBar.eSideBarAppearance.Flat
        Me.sideBar1.BorderStyle = DevComponents.DotNetBar.eBorderType.None
        Me.sideBar1.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.sideBar1.ColorScheme.ItemCheckedBackground = System.Drawing.Color.Empty
        Me.sideBar1.ColorScheme.ItemCheckedBorder = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(128, Byte))
        Me.sideBar1.ColorScheme.ItemCheckedText = System.Drawing.Color.Black
        Me.sideBar1.ColorScheme.ItemExpandedBackground = System.Drawing.Color.FromArgb(CType(254, Byte), CType(142, Byte), CType(75, Byte))
        Me.sideBar1.ColorScheme.ItemExpandedBackground2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(207, Byte), CType(139, Byte))
        Me.sideBar1.ColorScheme.ItemExpandedShadow = System.Drawing.Color.Empty
        Me.sideBar1.ColorScheme.ItemExpandedText = System.Drawing.Color.Black
        Me.sideBar1.ColorScheme.ItemHotBackground = System.Drawing.Color.FromArgb(CType(255, Byte), CType(244, Byte), CType(204, Byte))
        Me.sideBar1.ColorScheme.ItemHotBackground2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(209, Byte), CType(147, Byte))
        Me.sideBar1.ColorScheme.ItemHotBorder = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(128, Byte))
        Me.sideBar1.ColorScheme.ItemHotText = System.Drawing.Color.Black
        Me.sideBar1.ColorScheme.ItemPressedBackground = System.Drawing.Color.FromArgb(CType(254, Byte), CType(142, Byte), CType(75, Byte))
        Me.sideBar1.ColorScheme.ItemPressedBackground2 = System.Drawing.Color.FromArgb(CType(255, Byte), CType(207, Byte), CType(139, Byte))
        Me.sideBar1.ColorScheme.ItemPressedBorder = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(128, Byte))
        Me.sideBar1.ColorScheme.ItemPressedText = System.Drawing.Color.Black
        Me.sideBar1.ColorScheme.ItemText = System.Drawing.Color.Black
        Me.sideBar1.ColorScheme.MenuBackground = System.Drawing.Color.FromArgb(CType(232, Byte), CType(232, Byte), CType(232, Byte))
        Me.sideBar1.ColorScheme.MenuBackground2 = System.Drawing.Color.White
        Me.sideBar1.ColorScheme.MenuBorder = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(128, Byte))
        Me.sideBar1.ColorScheme.MenuSide = System.Drawing.Color.FromArgb(CType(94, Byte), CType(137, Byte), CType(207, Byte))
        Me.sideBar1.ExpandedPanel = Me.sideBarPanelItem1
        Me.sideBar1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.sideBar1.Location = New System.Drawing.Point(8, 48)
        Me.sideBar1.Name = "sideBar1"
        Me.sideBar1.Panels.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.sideBarPanelItem1, Me.sideBarPanelItem2})
        Me.sideBar1.Size = New System.Drawing.Size(176, 216)
        Me.sideBar1.TabIndex = 9
        Me.sideBar1.TabStop = False
        '
        'sideBarPanelItem1
        '
        Me.sideBarPanelItem1.BackgroundStyle.BackColor1.Color = System.Drawing.Color.FromArgb(CType(232, Byte), CType(232, Byte), CType(232, Byte))
        Me.sideBarPanelItem1.BackgroundStyle.BackColor2.Color = System.Drawing.Color.White
        Me.sideBarPanelItem1.BackgroundStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.sideBarPanelItem1.BackgroundStyle.BorderColor.Color = System.Drawing.Color.FromArgb(CType(59, Byte), CType(97, Byte), CType(156, Byte))
        Me.sideBarPanelItem1.HeaderHotStyle.BackColor1.Color = System.Drawing.Color.FromArgb(CType(133, Byte), CType(171, Byte), CType(228, Byte))
        Me.sideBarPanelItem1.HeaderHotStyle.BackColor2.Color = System.Drawing.Color.FromArgb(CType(221, Byte), CType(236, Byte), CType(254, Byte))
        Me.sideBarPanelItem1.HeaderHotStyle.GradientAngle = 90
        Me.sideBarPanelItem1.HeaderSideHotStyle.BackColor1.Color = System.Drawing.Color.FromArgb(CType(133, Byte), CType(171, Byte), CType(228, Byte))
        Me.sideBarPanelItem1.HeaderSideHotStyle.BackColor2.Color = System.Drawing.Color.FromArgb(CType(221, Byte), CType(236, Byte), CType(254, Byte))
        Me.sideBarPanelItem1.HeaderSideHotStyle.GradientAngle = 90
        Me.sideBarPanelItem1.HeaderSideStyle.BackColor1.Color = System.Drawing.Color.FromArgb(CType(200, Byte), CType(220, Byte), CType(248, Byte))
        Me.sideBarPanelItem1.HeaderSideStyle.BackColor2.Color = System.Drawing.Color.FromArgb(CType(94, Byte), CType(137, Byte), CType(207, Byte))
        Me.sideBarPanelItem1.HeaderSideStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.sideBarPanelItem1.HeaderSideStyle.BorderColor.Color = System.Drawing.Color.FromArgb(CType(59, Byte), CType(97, Byte), CType(156, Byte))
        Me.sideBarPanelItem1.HeaderSideStyle.BorderSide = ((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Top) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom)
        Me.sideBarPanelItem1.HeaderSideStyle.GradientAngle = 90
        Me.sideBarPanelItem1.HeaderStyle.BackColor1.Color = System.Drawing.Color.FromArgb(CType(221, Byte), CType(236, Byte), CType(254, Byte))
        Me.sideBarPanelItem1.HeaderStyle.BackColor2.Color = System.Drawing.Color.FromArgb(CType(133, Byte), CType(171, Byte), CType(228, Byte))
        Me.sideBarPanelItem1.HeaderStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.sideBarPanelItem1.HeaderStyle.BorderColor.Color = System.Drawing.Color.FromArgb(CType(59, Byte), CType(97, Byte), CType(156, Byte))
        Me.sideBarPanelItem1.HeaderStyle.BorderSide = ((DevComponents.DotNetBar.eBorderSide.Right Or DevComponents.DotNetBar.eBorderSide.Top) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom)
        Me.sideBarPanelItem1.HeaderStyle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sideBarPanelItem1.HeaderStyle.ForeColor.Color = System.Drawing.Color.FromArgb(CType(0, Byte), CType(51, Byte), CType(102, Byte))
        Me.sideBarPanelItem1.HeaderStyle.GradientAngle = 90
        Me.sideBarPanelItem1.Icon = CType(resources.GetObject("sideBarPanelItem1.Icon"), System.Drawing.Icon)
        Me.sideBarPanelItem1.Name = "sideBarPanelItem1"
        Me.sideBarPanelItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem1, Me.buttonItem2, Me.buttonItem3, Me.buttonItem4, Me.buttonItem5, Me.buttonItem6, Me.buttonItem7})
        Me.sideBarPanelItem1.Text = "Mail (Favorite Folders)"
        '
        'buttonItem1
        '
        Me.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.buttonItem1.Icon = CType(resources.GetObject("buttonItem1.Icon"), System.Drawing.Icon)
        Me.buttonItem1.Name = "buttonItem1"
        Me.buttonItem1.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.buttonItem1.Text = "Inbox"
        '
        'buttonItem2
        '
        Me.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.buttonItem2.FontItalic = True
        Me.buttonItem2.Icon = CType(resources.GetObject("buttonItem2.Icon"), System.Drawing.Icon)
        Me.buttonItem2.Name = "buttonItem2"
        Me.buttonItem2.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.buttonItem2.Text = "Unread Mail"
        '
        'buttonItem3
        '
        Me.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.buttonItem3.FontItalic = True
        Me.buttonItem3.Icon = CType(resources.GetObject("buttonItem3.Icon"), System.Drawing.Icon)
        Me.buttonItem3.Name = "buttonItem3"
        Me.buttonItem3.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.buttonItem3.Text = "For Follow Up"
        '
        'buttonItem4
        '
        Me.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.buttonItem4.FontBold = True
        Me.buttonItem4.Icon = CType(resources.GetObject("buttonItem4.Icon"), System.Drawing.Icon)
        Me.buttonItem4.Name = "buttonItem4"
        Me.buttonItem4.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.buttonItem4.Text = "Sent Items"
        '
        'buttonItem5
        '
        Me.buttonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.buttonItem5.Icon = CType(resources.GetObject("buttonItem5.Icon"), System.Drawing.Icon)
        Me.buttonItem5.Name = "buttonItem5"
        Me.buttonItem5.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.buttonItem5.Text = "Drafts"
        '
        'buttonItem6
        '
        Me.buttonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.buttonItem6.Icon = CType(resources.GetObject("buttonItem6.Icon"), System.Drawing.Icon)
        Me.buttonItem6.Name = "buttonItem6"
        Me.buttonItem6.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.buttonItem6.Text = "Home"
        '
        'buttonItem7
        '
        Me.buttonItem7.BeginGroup = True
        Me.buttonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.buttonItem7.Icon = CType(resources.GetObject("buttonItem7.Icon"), System.Drawing.Icon)
        Me.buttonItem7.Name = "buttonItem7"
        Me.buttonItem7.PopupSide = DevComponents.DotNetBar.ePopupSide.Right
        Me.buttonItem7.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem8, Me.buttonItem9, Me.buttonItem10})
        Me.buttonItem7.Text = "Actions"
        '
        'buttonItem8
        '
        Me.buttonItem8.Name = "buttonItem8"
        Me.buttonItem8.Text = "New Message"
        '
        'buttonItem9
        '
        Me.buttonItem9.Name = "buttonItem9"
        Me.buttonItem9.Text = "Junk Mail Settings"
        '
        'buttonItem10
        '
        Me.buttonItem10.BeginGroup = True
        Me.buttonItem10.Name = "buttonItem10"
        Me.buttonItem10.Text = "Mail Accounts"
        '
        'sideBarPanelItem2
        '
        Me.sideBarPanelItem2.BackgroundStyle.BackColor1.Color = System.Drawing.Color.FromArgb(CType(232, Byte), CType(232, Byte), CType(232, Byte))
        Me.sideBarPanelItem2.BackgroundStyle.BackColor2.Color = System.Drawing.Color.White
        Me.sideBarPanelItem2.BackgroundStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.sideBarPanelItem2.BackgroundStyle.BorderColor.Color = System.Drawing.Color.FromArgb(CType(59, Byte), CType(97, Byte), CType(156, Byte))
        Me.sideBarPanelItem2.HeaderHotStyle.BackColor1.Color = System.Drawing.Color.FromArgb(CType(133, Byte), CType(171, Byte), CType(228, Byte))
        Me.sideBarPanelItem2.HeaderHotStyle.BackColor2.Color = System.Drawing.Color.FromArgb(CType(221, Byte), CType(236, Byte), CType(254, Byte))
        Me.sideBarPanelItem2.HeaderHotStyle.GradientAngle = 90
        Me.sideBarPanelItem2.HeaderSideHotStyle.BackColor1.Color = System.Drawing.Color.FromArgb(CType(133, Byte), CType(171, Byte), CType(228, Byte))
        Me.sideBarPanelItem2.HeaderSideHotStyle.BackColor2.Color = System.Drawing.Color.FromArgb(CType(221, Byte), CType(236, Byte), CType(254, Byte))
        Me.sideBarPanelItem2.HeaderSideHotStyle.GradientAngle = 90
        Me.sideBarPanelItem2.HeaderSideStyle.BackColor1.Color = System.Drawing.Color.FromArgb(CType(200, Byte), CType(220, Byte), CType(248, Byte))
        Me.sideBarPanelItem2.HeaderSideStyle.BackColor2.Color = System.Drawing.Color.FromArgb(CType(94, Byte), CType(137, Byte), CType(207, Byte))
        Me.sideBarPanelItem2.HeaderSideStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.sideBarPanelItem2.HeaderSideStyle.BorderColor.Color = System.Drawing.Color.FromArgb(CType(59, Byte), CType(97, Byte), CType(156, Byte))
        Me.sideBarPanelItem2.HeaderSideStyle.BorderSide = ((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Top) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom)
        Me.sideBarPanelItem2.HeaderSideStyle.GradientAngle = 90
        Me.sideBarPanelItem2.HeaderStyle.BackColor1.Color = System.Drawing.Color.FromArgb(CType(221, Byte), CType(236, Byte), CType(254, Byte))
        Me.sideBarPanelItem2.HeaderStyle.BackColor2.Color = System.Drawing.Color.FromArgb(CType(133, Byte), CType(171, Byte), CType(228, Byte))
        Me.sideBarPanelItem2.HeaderStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.sideBarPanelItem2.HeaderStyle.BorderColor.Color = System.Drawing.Color.FromArgb(CType(59, Byte), CType(97, Byte), CType(156, Byte))
        Me.sideBarPanelItem2.HeaderStyle.BorderSide = ((DevComponents.DotNetBar.eBorderSide.Right Or DevComponents.DotNetBar.eBorderSide.Top) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom)
        Me.sideBarPanelItem2.HeaderStyle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sideBarPanelItem2.HeaderStyle.ForeColor.Color = System.Drawing.Color.FromArgb(CType(0, Byte), CType(51, Byte), CType(102, Byte))
        Me.sideBarPanelItem2.HeaderStyle.GradientAngle = 90
        Me.sideBarPanelItem2.Icon = CType(resources.GetObject("sideBarPanelItem2.Icon"), System.Drawing.Icon)
        Me.sideBarPanelItem2.Name = "sideBarPanelItem2"
        Me.sideBarPanelItem2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem11, Me.buttonItem12, Me.buttonItem13})
        Me.sideBarPanelItem2.Text = "Notes"
        '
        'buttonItem11
        '
        Me.buttonItem11.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.buttonItem11.Name = "buttonItem11"
        Me.buttonItem11.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.buttonItem11.Text = "New Note"
        '
        'buttonItem12
        '
        Me.buttonItem12.BeginGroup = True
        Me.buttonItem12.Name = "buttonItem12"
        Me.buttonItem12.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.buttonItem12.Text = "Display All Notes"
        '
        'buttonItem13
        '
        Me.buttonItem13.Name = "buttonItem13"
        Me.buttonItem13.PopupSide = DevComponents.DotNetBar.ePopupSide.Left
        Me.buttonItem13.Text = "Display Most Recent"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 272)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.sideBar1, Me.label2, Me.richTextBox1, Me.comboBox1, Me.label1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As String
        For Each s In System.Enum.GetNames(GetType(DevComponents.DotNetBar.eSideBarColorScheme))
            comboBox1.Items.Add(s)
        Next
        comboBox1.SelectedIndex = 0
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        Dim scheme As DevComponents.DotNetBar.eSideBarColorScheme
        If comboBox1.SelectedIndex < 0 Then Exit Sub

        Dim sSel As String = comboBox1.SelectedItem.ToString()
        scheme = CType(System.Enum.Parse(GetType(DevComponents.DotNetBar.eSideBarColorScheme), sSel, False), DevComponents.DotNetBar.eSideBarColorScheme)
        sideBar1.PredefinedColorScheme = scheme
    End Sub

    Private Sub sideBar1_ItemClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles sideBar1.ItemClick
        Dim item As DevComponents.DotNetBar.BaseItem = CType(sender, DevComponents.DotNetBar.BaseItem)
        richTextBox1.Text = "ItemClick: " + item.Text + " (" + item.Name + ")" + vbCrLf + richTextBox1.Text
    End Sub
End Class
