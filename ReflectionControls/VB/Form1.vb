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
    Friend WithEvents labelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents labelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents reflectionImage3 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents reflectionLabel3 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents reflectionLabel2 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents reflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents buttonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents labelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents labelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents reflectionImage2 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents reflectionImage1 As DevComponents.DotNetBar.Controls.ReflectionImage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.labelX4 = New DevComponents.DotNetBar.LabelX()
        Me.labelX3 = New DevComponents.DotNetBar.LabelX()
        Me.reflectionImage3 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.reflectionLabel3 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.reflectionLabel2 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.reflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.buttonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.labelX2 = New DevComponents.DotNetBar.LabelX()
        Me.labelX1 = New DevComponents.DotNetBar.LabelX()
        Me.reflectionImage2 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.reflectionImage1 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.SuspendLayout()
        '
        'labelX4
        '
        Me.labelX4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelX4.Location = New System.Drawing.Point(236, 167)
        Me.labelX4.Name = "labelX4"
        Me.labelX4.Size = New System.Drawing.Size(192, 16)
        Me.labelX4.TabIndex = 23
        Me.labelX4.Text = "Disabled state:"
        '
        'labelX3
        '
        Me.labelX3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelX3.Location = New System.Drawing.Point(12, 151)
        Me.labelX3.Name = "labelX3"
        Me.labelX3.Size = New System.Drawing.Size(192, 16)
        Me.labelX3.TabIndex = 22
        Me.labelX3.Text = "Disabled state:"
        '
        'reflectionImage3
        '
        '
        'reflectionImage3.BackgroundStyle
        '
        Me.reflectionImage3.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.reflectionImage3.Enabled = False
        Me.reflectionImage3.Image = CType(resources.GetObject("reflectionImage3.Image"), System.Drawing.Bitmap)
        Me.reflectionImage3.Location = New System.Drawing.Point(12, 175)
        Me.reflectionImage3.Name = "reflectionImage3"
        Me.reflectionImage3.Size = New System.Drawing.Size(88, 104)
        Me.reflectionImage3.TabIndex = 21
        '
        'reflectionLabel3
        '
        Me.reflectionLabel3.Enabled = False
        Me.reflectionLabel3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reflectionLabel3.Location = New System.Drawing.Point(236, 191)
        Me.reflectionLabel3.Name = "reflectionLabel3"
        Me.reflectionLabel3.Size = New System.Drawing.Size(232, 56)
        Me.reflectionLabel3.TabIndex = 20
        Me.reflectionLabel3.Text = "<b><font size=""+6""><i>Dev</i><font color=""#B02B2C"">Components</font></font></b>"
        '
        'reflectionLabel2
        '
        '
        'reflectionLabel2.BackgroundStyle
        '
        Me.reflectionLabel2.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.reflectionLabel2.BackgroundStyle.BackColor2 = System.Drawing.Color.WhiteSmoke
        Me.reflectionLabel2.BackgroundStyle.BackColorGradientAngle = 90
        Me.reflectionLabel2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.reflectionLabel2.BackgroundStyle.BorderBottomWidth = 3
        Me.reflectionLabel2.BackgroundStyle.BorderColor = System.Drawing.Color.Maroon
        Me.reflectionLabel2.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.reflectionLabel2.BackgroundStyle.BorderLeftWidth = 3
        Me.reflectionLabel2.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.reflectionLabel2.BackgroundStyle.BorderRightWidth = 3
        Me.reflectionLabel2.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.reflectionLabel2.BackgroundStyle.BorderTopWidth = 3
        Me.reflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.reflectionLabel2.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.reflectionLabel2.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reflectionLabel2.Location = New System.Drawing.Point(228, 95)
        Me.reflectionLabel2.Name = "reflectionLabel2"
        Me.reflectionLabel2.Size = New System.Drawing.Size(296, 64)
        Me.reflectionLabel2.TabIndex = 16
        Me.reflectionLabel2.Text = "<i>Dev</i><font color=""#B02B2C"">Components</font>"
        '
        'reflectionLabel1
        '
        Me.reflectionLabel1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reflectionLabel1.Location = New System.Drawing.Point(236, 31)
        Me.reflectionLabel1.Name = "reflectionLabel1"
        Me.reflectionLabel1.Size = New System.Drawing.Size(232, 56)
        Me.reflectionLabel1.TabIndex = 15
        Me.reflectionLabel1.Text = "<b><font size=""+6""><i>Dev</i><font color=""#B02B2C"">Components</font></font></b>"
        '
        'buttonX1
        '
        Me.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.buttonX1.Location = New System.Drawing.Point(436, 255)
        Me.buttonX1.Name = "buttonX1"
        Me.buttonX1.Size = New System.Drawing.Size(88, 24)
        Me.buttonX1.TabIndex = 19
        Me.buttonX1.Text = "&Close"
        '
        'labelX2
        '
        Me.labelX2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelX2.Location = New System.Drawing.Point(12, 7)
        Me.labelX2.Name = "labelX2"
        Me.labelX2.Size = New System.Drawing.Size(192, 16)
        Me.labelX2.TabIndex = 18
        Me.labelX2.Text = "Reflection Image Control:"
        '
        'labelX1
        '
        Me.labelX1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.labelX1.Location = New System.Drawing.Point(236, 7)
        Me.labelX1.Name = "labelX1"
        Me.labelX1.Size = New System.Drawing.Size(264, 16)
        Me.labelX1.TabIndex = 17
        Me.labelX1.Text = "Reflection Label Control with <a href=""tm"">text-markup</a> support:"
        '
        'reflectionImage2
        '
        '
        'reflectionImage2.BackgroundStyle
        '
        Me.reflectionImage2.BackgroundStyle.BackColor = System.Drawing.Color.White
        Me.reflectionImage2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.reflectionImage2.BackgroundStyle.BorderBottomWidth = 3
        Me.reflectionImage2.BackgroundStyle.BorderColor = System.Drawing.Color.Chocolate
        Me.reflectionImage2.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.reflectionImage2.BackgroundStyle.BorderLeftWidth = 3
        Me.reflectionImage2.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.reflectionImage2.BackgroundStyle.BorderRightWidth = 3
        Me.reflectionImage2.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.reflectionImage2.BackgroundStyle.BorderTopWidth = 3
        Me.reflectionImage2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.reflectionImage2.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.reflectionImage2.Image = CType(resources.GetObject("reflectionImage2.Image"), System.Drawing.Bitmap)
        Me.reflectionImage2.Location = New System.Drawing.Point(108, 31)
        Me.reflectionImage2.Name = "reflectionImage2"
        Me.reflectionImage2.Size = New System.Drawing.Size(88, 104)
        Me.reflectionImage2.TabIndex = 14
        '
        'reflectionImage1
        '
        '
        'reflectionImage1.BackgroundStyle
        '
        Me.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.reflectionImage1.Image = CType(resources.GetObject("reflectionImage1.Image"), System.Drawing.Bitmap)
        Me.reflectionImage1.Location = New System.Drawing.Point(12, 31)
        Me.reflectionImage1.Name = "reflectionImage1"
        Me.reflectionImage1.Size = New System.Drawing.Size(88, 104)
        Me.reflectionImage1.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 286)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.labelX4, Me.labelX3, Me.reflectionImage3, Me.reflectionLabel3, Me.reflectionLabel2, Me.reflectionLabel1, Me.buttonX1, Me.labelX2, Me.labelX1, Me.reflectionImage2, Me.reflectionImage1})
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub buttonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonX1.Click
        Me.Close()
    End Sub

    Private Sub labelX1_MarkupLinkClick(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.MarkupLinkClickEventArgs) Handles labelX1.MarkupLinkClick
        System.Diagnostics.Process.Start("http://www.devcomponents.com/kb/questions.php?questionid=5")
    End Sub
End Class
