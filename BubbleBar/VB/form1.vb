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
    Friend WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents bubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents bubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents bubbleButton4 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton3 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton1 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton2 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton5 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton6 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton7 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton10 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton8 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton9 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleBarTab2 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents bubbleButton11 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton12 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton13 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton14 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton15 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton16 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton17 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton18 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents checkBox2 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.bubbleBar1 = New DevComponents.DotNetBar.BubbleBar()
        Me.bubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.bubbleButton4 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton3 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton1 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton2 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton5 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton6 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton7 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton10 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton8 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton9 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleBarTab2 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.bubbleButton11 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton12 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton13 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton14 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton15 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton16 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton17 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton18 = New DevComponents.DotNetBar.BubbleButton()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panelEx1.SuspendLayout()
        CType(Me.bubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelEx1
        '
        Me.panelEx1.Controls.AddRange(New System.Windows.Forms.Control() {Me.checkBox2, Me.TextBox1, Me.checkBox1, Me.label1, Me.bubbleBar1, Me.label2})
        Me.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelEx1.Name = "panelEx1"
        Me.panelEx1.Size = New System.Drawing.Size(440, 266)
        Me.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.panelEx1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
        Me.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.panelEx1.Style.GradientAngle = 90
        Me.panelEx1.TabIndex = 5
        '
        'checkBox2
        '
        Me.checkBox2.BackColor = System.Drawing.Color.Transparent
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.Location = New System.Drawing.Point(8, 64)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(160, 16)
        Me.checkBox2.TabIndex = 7
        Me.checkBox2.Text = "Stretch button background"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(104, 176)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(232, 20)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = ""
        '
        'checkBox1
        '
        Me.checkBox1.BackColor = System.Drawing.Color.Transparent
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(8, 40)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(240, 24)
        Me.checkBox1.TabIndex = 4
        Me.checkBox1.Text = "Enable Animation"
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(8, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(200, 23)
        Me.label1.TabIndex = 1
        Me.label1.Text = "BubbleBar in action..."
        '
        'bubbleBar1
        '
        Me.bubbleBar1.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom
        Me.bubbleBar1.AntiAlias = True
        Me.bubbleBar1.BackColor = System.Drawing.Color.Transparent
        '
        'bubbleBar1.ButtonBackAreaStyle
        '
        Me.bubbleBar1.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(CType(66, Byte), CType(105, Byte), CType(105, Byte), CType(105, Byte))
        Me.bubbleBar1.ButtonBackAreaStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Tile
        Me.bubbleBar1.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bubbleBar1.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.bubbleBar1.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(180, Byte), CType(245, Byte), CType(245, Byte), CType(245, Byte))
        Me.bubbleBar1.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bubbleBar1.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.bubbleBar1.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bubbleBar1.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.bubbleBar1.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bubbleBar1.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.bubbleBar1.ButtonBackAreaStyle.PaddingBottom = 3
        Me.bubbleBar1.ButtonBackAreaStyle.PaddingLeft = 3
        Me.bubbleBar1.ButtonBackAreaStyle.PaddingRight = 3
        Me.bubbleBar1.ButtonBackAreaStyle.PaddingTop = 3
        Me.bubbleBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bubbleBar1.ImageSizeLarge = New System.Drawing.Size(64, 64)
        Me.bubbleBar1.ImageSizeNormal = New System.Drawing.Size(32, 32)
        Me.bubbleBar1.Location = New System.Drawing.Point(0, 208)
        Me.bubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.bubbleBar1.Name = "bubbleBar1"
        Me.bubbleBar1.SelectedTab = Me.bubbleBarTab1
        Me.bubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.bubbleBar1.Size = New System.Drawing.Size(440, 58)
        Me.bubbleBar1.TabIndex = 0
        Me.bubbleBar1.Tabs.Add(Me.bubbleBarTab1)
        Me.bubbleBar1.Tabs.Add(Me.bubbleBarTab2)
        Me.bubbleBar1.Text = "bubbleBar1"
        Me.bubbleBar1.TooltipFont = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bubbleBarTab1
        '
        Me.bubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(CType(221, Byte), CType(230, Byte), CType(247, Byte))
        Me.bubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(CType(138, Byte), CType(168, Byte), CType(228, Byte))
        Me.bubbleBarTab1.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.bubbleButton4, Me.bubbleButton3, Me.bubbleButton1, Me.bubbleButton2, Me.bubbleButton5, Me.bubbleButton6, Me.bubbleButton7, Me.bubbleButton10, Me.bubbleButton8, Me.bubbleButton9})
        Me.bubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(CType(190, Byte), CType(105, Byte), CType(105, Byte), CType(105, Byte))
        Me.bubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.bubbleBarTab1.Name = "bubbleBarTab1"
        Me.bubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.bubbleBarTab1.Text = "Main"
        Me.bubbleBarTab1.TextColor = System.Drawing.Color.Black
        '
        'bubbleButton4
        '
        Me.bubbleButton4.Image = CType(resources.GetObject("bubbleButton4.Image"), System.Drawing.Bitmap)
        Me.bubbleButton4.ImageLarge = CType(resources.GetObject("bubbleButton4.ImageLarge"), System.Drawing.Bitmap)
        Me.bubbleButton4.Name = "bubbleButton4"
        Me.bubbleButton4.TooltipText = "Create New File"
        '
        'bubbleButton3
        '
        Me.bubbleButton3.Image = CType(resources.GetObject("bubbleButton3.Image"), System.Drawing.Bitmap)
        Me.bubbleButton3.ImageLarge = CType(resources.GetObject("bubbleButton3.ImageLarge"), System.Drawing.Bitmap)
        Me.bubbleButton3.Name = "bubbleButton3"
        Me.bubbleButton3.TooltipText = "Open File"
        '
        'bubbleButton1
        '
        Me.bubbleButton1.Image = CType(resources.GetObject("bubbleButton1.Image"), System.Drawing.Bitmap)
        Me.bubbleButton1.ImageLarge = CType(resources.GetObject("bubbleButton1.ImageLarge"), System.Drawing.Bitmap)
        Me.bubbleButton1.Name = "bubbleButton1"
        Me.bubbleButton1.TooltipText = "Account List"
        '
        'bubbleButton2
        '
        Me.bubbleButton2.Image = CType(resources.GetObject("bubbleButton2.Image"), System.Drawing.Bitmap)
        Me.bubbleButton2.ImageLarge = CType(resources.GetObject("bubbleButton2.ImageLarge"), System.Drawing.Bitmap)
        Me.bubbleButton2.Name = "bubbleButton2"
        Me.bubbleButton2.TooltipText = "Search"
        '
        'bubbleButton5
        '
        Me.bubbleButton5.Enabled = False
        Me.bubbleButton5.Image = CType(resources.GetObject("bubbleButton5.Image"), System.Drawing.Bitmap)
        Me.bubbleButton5.ImageLarge = CType(resources.GetObject("bubbleButton5.ImageLarge"), System.Drawing.Bitmap)
        Me.bubbleButton5.Name = "bubbleButton5"
        Me.bubbleButton5.TooltipText = "Print (Note that this button is disabled)"
        '
        'bubbleButton6
        '
        Me.bubbleButton6.Image = CType(resources.GetObject("bubbleButton6.Image"), System.Drawing.Bitmap)
        Me.bubbleButton6.ImageLarge = CType(resources.GetObject("bubbleButton6.ImageLarge"), System.Drawing.Bitmap)
        Me.bubbleButton6.Name = "bubbleButton6"
        Me.bubbleButton6.TooltipText = "Write CD"
        '
        'bubbleButton7
        '
        Me.bubbleButton7.Image = CType(resources.GetObject("bubbleButton7.Image"), System.Drawing.Bitmap)
        Me.bubbleButton7.ImageLarge = CType(resources.GetObject("bubbleButton7.ImageLarge"), System.Drawing.Bitmap)
        Me.bubbleButton7.Name = "bubbleButton7"
        Me.bubbleButton7.TooltipText = "Take Snapshot"
        '
        'bubbleButton10
        '
        Me.bubbleButton10.Image = CType(resources.GetObject("bubbleButton10.Image"), System.Drawing.Bitmap)
        Me.bubbleButton10.ImageLarge = CType(resources.GetObject("bubbleButton10.ImageLarge"), System.Drawing.Bitmap)
        Me.bubbleButton10.Name = "bubbleButton10"
        '
        'bubbleButton8
        '
        Me.bubbleButton8.Image = CType(resources.GetObject("bubbleButton8.Image"), System.Drawing.Bitmap)
        Me.bubbleButton8.ImageLarge = CType(resources.GetObject("bubbleButton8.ImageLarge"), System.Drawing.Bitmap)
        Me.bubbleButton8.Name = "bubbleButton8"
        Me.bubbleButton8.TooltipText = "Delete"
        '
        'bubbleButton9
        '
        Me.bubbleButton9.Image = CType(resources.GetObject("bubbleButton9.Image"), System.Drawing.Bitmap)
        Me.bubbleButton9.ImageLarge = CType(resources.GetObject("bubbleButton9.ImageLarge"), System.Drawing.Bitmap)
        Me.bubbleButton9.Name = "bubbleButton9"
        Me.bubbleButton9.TooltipText = "Preferences"
        '
        'bubbleBarTab2
        '
        Me.bubbleBarTab2.BackColor = System.Drawing.Color.FromArgb(CType(249, Byte), CType(225, Byte), CType(226, Byte))
        Me.bubbleBarTab2.BackColor2 = System.Drawing.Color.FromArgb(CType(238, Byte), CType(149, Byte), CType(151, Byte))
        Me.bubbleBarTab2.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.bubbleButton11, Me.bubbleButton12, Me.bubbleButton13, Me.bubbleButton14, Me.bubbleButton15, Me.bubbleButton16, Me.bubbleButton17, Me.bubbleButton18})
        Me.bubbleBarTab2.DarkBorderColor = System.Drawing.Color.FromArgb(CType(190, Byte), CType(105, Byte), CType(105, Byte), CType(105, Byte))
        Me.bubbleBarTab2.LightBorderColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(255, Byte), CType(255, Byte), CType(255, Byte))
        Me.bubbleBarTab2.Name = "bubbleBarTab2"
        Me.bubbleBarTab2.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Red
        Me.bubbleBarTab2.Text = "Notes"
        Me.bubbleBarTab2.TextColor = System.Drawing.Color.Black
        '
        'bubbleButton11
        '
        Me.bubbleButton11.Image = CType(resources.GetObject("bubbleButton11.Image"), System.Drawing.Bitmap)
        Me.bubbleButton11.Name = "bubbleButton11"
        '
        'bubbleButton12
        '
        Me.bubbleButton12.Image = CType(resources.GetObject("bubbleButton12.Image"), System.Drawing.Bitmap)
        Me.bubbleButton12.Name = "bubbleButton12"
        '
        'bubbleButton13
        '
        Me.bubbleButton13.Image = CType(resources.GetObject("bubbleButton13.Image"), System.Drawing.Bitmap)
        Me.bubbleButton13.Name = "bubbleButton13"
        '
        'bubbleButton14
        '
        Me.bubbleButton14.Image = CType(resources.GetObject("bubbleButton14.Image"), System.Drawing.Bitmap)
        Me.bubbleButton14.Name = "bubbleButton14"
        '
        'bubbleButton15
        '
        Me.bubbleButton15.Image = CType(resources.GetObject("bubbleButton15.Image"), System.Drawing.Bitmap)
        Me.bubbleButton15.Name = "bubbleButton15"
        '
        'bubbleButton16
        '
        Me.bubbleButton16.Image = CType(resources.GetObject("bubbleButton16.Image"), System.Drawing.Bitmap)
        Me.bubbleButton16.Name = "bubbleButton16"
        '
        'bubbleButton17
        '
        Me.bubbleButton17.Image = CType(resources.GetObject("bubbleButton17.Image"), System.Drawing.Bitmap)
        Me.bubbleButton17.Name = "bubbleButton17"
        '
        'bubbleButton18
        '
        Me.bubbleButton18.Image = CType(resources.GetObject("bubbleButton18.Image"), System.Drawing.Bitmap)
        Me.bubbleButton18.Name = "bubbleButton18"
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Location = New System.Drawing.Point(8, 184)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(100, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Last click event:"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 266)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panelEx1})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panelEx1.ResumeLayout(False)
        CType(Me.bubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub checkBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If checkBox1.Checked Then
            bubbleBar1.AnimationTime = 120
        Else
            bubbleBar1.AnimationTime = 0
        End If
    End Sub

    Private Sub bubbleButton_Click(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs)
        Dim button As DevComponents.DotNetBar.BubbleButton = CType(sender, DevComponents.DotNetBar.BubbleButton)
        TextBox1.Text = button.Name + ", " + button.TooltipText
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler bubbleButton1.Click, AddressOf Me.bubbleButton_Click
        AddHandler bubbleButton2.Click, AddressOf Me.bubbleButton_Click
        AddHandler bubbleButton3.Click, AddressOf Me.bubbleButton_Click
        AddHandler bubbleButton4.Click, AddressOf Me.bubbleButton_Click
        AddHandler bubbleButton5.Click, AddressOf Me.bubbleButton_Click
        AddHandler bubbleButton6.Click, AddressOf Me.bubbleButton_Click
        AddHandler bubbleButton7.Click, AddressOf Me.bubbleButton_Click
        AddHandler bubbleButton8.Click, AddressOf Me.bubbleButton_Click
        AddHandler bubbleButton9.Click, AddressOf Me.bubbleButton_Click
        AddHandler bubbleButton10.Click, AddressOf Me.bubbleButton_Click
    End Sub

    Private Sub checkBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
        If checkBox2.Checked Then
            bubbleBar1.ButtonBackgroundStretch = True
        Else
            bubbleBar1.ButtonBackgroundStretch = False
        End If

        ' Apply layout changes and refresh
        bubbleBar1.RecalcLayout()
        bubbleBar1.Refresh()
    End Sub
End Class
