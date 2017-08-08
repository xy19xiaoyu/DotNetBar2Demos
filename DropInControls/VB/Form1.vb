Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering
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
    Friend WithEvents bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents buttonBlackScheme As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonSilverScheme As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents buttonBlueScheme As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents colorPickerCustomScheme As DevComponents.DotNetBar.ColorPickerDropDown
    Friend WithEvents groupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents textBoxX5 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents comboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents textBoxX4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents textBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents textBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents textBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents buttonX1 As DevComponents.DotNetBar.ButtonX
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.bar1 = New DevComponents.DotNetBar.Bar()
        Me.buttonBlackScheme = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonSilverScheme = New DevComponents.DotNetBar.ButtonItem()
        Me.buttonBlueScheme = New DevComponents.DotNetBar.ButtonItem()
        Me.colorPickerCustomScheme = New DevComponents.DotNetBar.ColorPickerDropDown()
        Me.groupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.textBoxX5 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.comboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.textBoxX4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.textBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.textBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.textBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.buttonX1 = New DevComponents.DotNetBar.ButtonX()
        CType(Me.bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bar1
        '
        Me.bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar
        Me.bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonBlackScheme, Me.buttonSilverScheme, Me.buttonBlueScheme, Me.colorPickerCustomScheme})
        Me.bar1.Name = "bar1"
        Me.bar1.RoundCorners = False
        Me.bar1.Size = New System.Drawing.Size(312, 25)
        Me.bar1.Stretch = True
        Me.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.bar1.TabIndex = 3
        Me.bar1.TabStop = False
        Me.bar1.Text = "bar1"
        '
        'buttonBlackScheme
        '
        Me.buttonBlackScheme.Name = "buttonBlackScheme"
        Me.buttonBlackScheme.Text = "Black"
        '
        'buttonSilverScheme
        '
        Me.buttonSilverScheme.Name = "buttonSilverScheme"
        Me.buttonSilverScheme.Text = "Silver"
        '
        'buttonBlueScheme
        '
        Me.buttonBlueScheme.Name = "buttonBlueScheme"
        Me.buttonBlueScheme.Text = "Blue"
        '
        'colorPickerCustomScheme
        '
        Me.colorPickerCustomScheme.AutoExpandOnClick = True
        Me.colorPickerCustomScheme.Image = CType(resources.GetObject("colorPickerCustomScheme.Image"), System.Drawing.Bitmap)
        Me.colorPickerCustomScheme.Name = "colorPickerCustomScheme"
        Me.colorPickerCustomScheme.Text = "Custom"
        '
        'groupPanel1
        '
        Me.groupPanel1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.groupPanel1.AutoScroll = True
        Me.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.groupPanel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.textBoxX5, Me.comboBoxEx1, Me.textBoxX4, Me.textBoxX3, Me.textBoxX2, Me.textBoxX1})
        Me.groupPanel1.Location = New System.Drawing.Point(8, 32)
        Me.groupPanel1.Name = "groupPanel1"
        Me.groupPanel1.Size = New System.Drawing.Size(296, 200)
        '
        'groupPanel1.Style
        '
        Me.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.groupPanel1.Style.BackColorGradientAngle = 90
        Me.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel1.Style.BorderBottomWidth = 1
        Me.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel1.Style.BorderLeftWidth = 1
        Me.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel1.Style.BorderRightWidth = 1
        Me.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel1.Style.BorderTopWidth = 1
        Me.groupPanel1.Style.CornerDiameter = 4
        Me.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.groupPanel1.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.groupPanel1.TabIndex = 4
        Me.groupPanel1.Text = "Customer Data"
        '
        'textBoxX5
        '
        Me.textBoxX5.AutoSize = False
        '
        'textBoxX5.Border
        '
        Me.textBoxX5.Border.Class = "TextBoxBorder"
        Me.textBoxX5.Location = New System.Drawing.Point(16, 168)
        Me.textBoxX5.Multiline = True
        Me.textBoxX5.Name = "textBoxX5"
        Me.textBoxX5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBoxX5.Size = New System.Drawing.Size(240, 104)
        Me.textBoxX5.TabIndex = 5
        '
        'comboBoxEx1
        '
        Me.comboBoxEx1.DisplayMember = "Text"
        Me.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboBoxEx1.Location = New System.Drawing.Point(16, 104)
        Me.comboBoxEx1.Name = "comboBoxEx1"
        Me.comboBoxEx1.Size = New System.Drawing.Size(240, 21)
        Me.comboBoxEx1.TabIndex = 4
        Me.comboBoxEx1.WatermarkText = "Choose State"
        '
        'textBoxX4
        '
        Me.textBoxX4.AutoSize = False
        '
        'textBoxX4.Border
        '
        Me.textBoxX4.Border.Class = "TextBoxBorder"
        Me.textBoxX4.Location = New System.Drawing.Point(16, 136)
        Me.textBoxX4.Name = "textBoxX4"
        Me.textBoxX4.Size = New System.Drawing.Size(240, 20)
        Me.textBoxX4.TabIndex = 3
        Me.textBoxX4.WatermarkText = "Post code"
        '
        'textBoxX3
        '
        Me.textBoxX3.AutoSize = False
        '
        'textBoxX3.Border
        '
        Me.textBoxX3.Border.Class = "TextBoxBorder"
        Me.textBoxX3.Location = New System.Drawing.Point(16, 72)
        Me.textBoxX3.Name = "textBoxX3"
        Me.textBoxX3.Size = New System.Drawing.Size(240, 20)
        Me.textBoxX3.TabIndex = 2
        Me.textBoxX3.WatermarkText = "Address"
        '
        'textBoxX2
        '
        Me.textBoxX2.AutoSize = False
        '
        'textBoxX2.Border
        '
        Me.textBoxX2.Border.Class = "TextBoxBorder"
        Me.textBoxX2.Location = New System.Drawing.Point(16, 40)
        Me.textBoxX2.Name = "textBoxX2"
        Me.textBoxX2.Size = New System.Drawing.Size(240, 20)
        Me.textBoxX2.TabIndex = 1
        Me.textBoxX2.WatermarkText = "Last Name"
        '
        'textBoxX1
        '
        Me.textBoxX1.AutoSize = False
        '
        'textBoxX1.Border
        '
        Me.textBoxX1.Border.Class = "TextBoxBorder"
        Me.textBoxX1.Location = New System.Drawing.Point(16, 8)
        Me.textBoxX1.Name = "textBoxX1"
        Me.textBoxX1.Size = New System.Drawing.Size(240, 20)
        Me.textBoxX1.TabIndex = 0
        Me.textBoxX1.WatermarkText = "First Name"
        '
        'buttonX1
        '
        Me.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.buttonX1.ColorScheme.DockSiteBackColorGradientAngle = 0
        Me.buttonX1.Location = New System.Drawing.Point(232, 240)
        Me.buttonX1.Name = "buttonX1"
        Me.buttonX1.Size = New System.Drawing.Size(72, 24)
        Me.buttonX1.TabIndex = 5
        Me.buttonX1.Text = "Close"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(194, Byte), CType(217, Byte), CType(247, Byte))
        Me.ClientSize = New System.Drawing.Size(312, 270)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.bar1, Me.groupPanel1, Me.buttonX1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub buttonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonX1.Click
        If MessageBoxEx.Show("Close this form?", "Controls Sample", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub buttonBlackScheme_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonBlackScheme.Click
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, eOffice2007ColorScheme.Black)
    End Sub

    Private Sub buttonSilverScheme_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonSilverScheme.Click
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, eOffice2007ColorScheme.Silver)
    End Sub

    Private Sub buttonBlueScheme_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonBlueScheme.Click
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, eOffice2007ColorScheme.Blue)
    End Sub

    Private m_ColorSelected As Boolean = False
    Private m_BaseColorScheme As eOffice2007ColorScheme = eOffice2007ColorScheme.Blue

    Private Sub colorPickerCustomScheme_ExpandChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorPickerCustomScheme.ExpandChange
        If colorPickerCustomScheme.Expanded Then
            ' Remember the starting color scheme to apply if no color is selected during live-preview
            m_ColorSelected = False
            m_BaseColorScheme = CType(GlobalManager.Renderer, Office2007Renderer).ColorTable.InitialColorScheme
        Else
            If Not m_ColorSelected Then
                RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, m_BaseColorScheme)
            End If
        End If
    End Sub

    Private Sub colorPickerCustomScheme_ColorPreview(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ColorPreviewEventArgs) Handles colorPickerCustomScheme.ColorPreview
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, m_BaseColorScheme, e.Color)
    End Sub

    Private Sub colorPickerCustomScheme_SelectedColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorPickerCustomScheme.SelectedColorChanged
        m_ColorSelected = True ' Indicate that color was selected for buttonStyleCustom_ExpandChange method
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, m_BaseColorScheme, colorPickerCustomScheme.SelectedColor)
    End Sub
End Class
