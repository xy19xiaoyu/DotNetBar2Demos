<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.groupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.labelX4 = New DevComponents.DotNetBar.LabelX
        Me.labelX5 = New DevComponents.DotNetBar.LabelX
        Me.labelX6 = New DevComponents.DotNetBar.LabelX
        Me.textBoxX4 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.textBoxX5 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.textBoxX6 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.panel1 = New System.Windows.Forms.Panel
        Me.labelX1 = New DevComponents.DotNetBar.LabelX
        Me.highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter
        Me.textBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.textBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.textBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.labelX2 = New DevComponents.DotNetBar.LabelX
        Me.labelX3 = New DevComponents.DotNetBar.LabelX
        Me.groupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.groupPanel2.SuspendLayout()
        Me.groupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupPanel2
        '
        Me.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.groupPanel2.Controls.Add(Me.labelX4)
        Me.groupPanel2.Controls.Add(Me.labelX5)
        Me.groupPanel2.Controls.Add(Me.labelX6)
        Me.groupPanel2.Controls.Add(Me.textBoxX4)
        Me.groupPanel2.Controls.Add(Me.textBoxX5)
        Me.groupPanel2.Controls.Add(Me.textBoxX6)
        Me.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupPanel2.Location = New System.Drawing.Point(4, 145)
        Me.groupPanel2.Name = "groupPanel2"
        Me.groupPanel2.Size = New System.Drawing.Size(276, 124)
        '
        '
        '
        Me.groupPanel2.Style.BackColorGradientAngle = 90
        Me.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel2.Style.BorderBottomWidth = 1
        Me.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel2.Style.BorderLeftWidth = 1
        Me.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel2.Style.BorderRightWidth = 1
        Me.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel2.Style.BorderTopWidth = 1
        Me.groupPanel2.Style.CornerDiameter = 4
        Me.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.groupPanel2.TabIndex = 3
        Me.groupPanel2.Text = "Highlighting On Focus"
        '
        'labelX4
        '
        Me.labelX4.AutoSize = True
        Me.labelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.labelX4.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.labelX4.Location = New System.Drawing.Point(6, 77)
        Me.labelX4.Name = "labelX4"
        Me.labelX4.Size = New System.Drawing.Size(42, 15)
        Me.labelX4.TabIndex = 8
        Me.labelX4.Text = "Twittter:"
        '
        'labelX5
        '
        Me.labelX5.AutoSize = True
        Me.labelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.labelX5.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.labelX5.Location = New System.Drawing.Point(15, 43)
        Me.labelX5.Name = "labelX5"
        Me.labelX5.Size = New System.Drawing.Size(33, 15)
        Me.labelX5.TabIndex = 7
        Me.labelX5.Text = "Email:"
        '
        'labelX6
        '
        Me.labelX6.AutoSize = True
        Me.labelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.labelX6.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.labelX6.Location = New System.Drawing.Point(13, 10)
        Me.labelX6.Name = "labelX6"
        Me.labelX6.Size = New System.Drawing.Size(35, 15)
        Me.labelX6.TabIndex = 6
        Me.labelX6.Text = "Name:"
        '
        'textBoxX4
        '
        '
        '
        '
        Me.textBoxX4.Border.Class = "TextBoxBorder"
        Me.highlighter1.SetHighlightOnFocus(Me.textBoxX4, True)
        Me.textBoxX4.Location = New System.Drawing.Point(60, 76)
        Me.textBoxX4.Name = "textBoxX4"
        Me.textBoxX4.Size = New System.Drawing.Size(197, 20)
        Me.textBoxX4.TabIndex = 5
        '
        'textBoxX5
        '
        '
        '
        '
        Me.textBoxX5.Border.Class = "TextBoxBorder"
        Me.highlighter1.SetHighlightOnFocus(Me.textBoxX5, True)
        Me.textBoxX5.Location = New System.Drawing.Point(60, 42)
        Me.textBoxX5.Name = "textBoxX5"
        Me.textBoxX5.Size = New System.Drawing.Size(197, 20)
        Me.textBoxX5.TabIndex = 4
        '
        'textBoxX6
        '
        '
        '
        '
        Me.textBoxX6.Border.Class = "TextBoxBorder"
        Me.highlighter1.SetHighlightOnFocus(Me.textBoxX6, True)
        Me.textBoxX6.Location = New System.Drawing.Point(60, 9)
        Me.textBoxX6.Name = "textBoxX6"
        Me.textBoxX6.Size = New System.Drawing.Size(197, 20)
        Me.textBoxX6.TabIndex = 3
        '
        'panel1
        '
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(4, 128)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(276, 17)
        Me.panel1.TabIndex = 4
        '
        'labelX1
        '
        Me.labelX1.AutoSize = True
        Me.labelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.labelX1.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.labelX1.Location = New System.Drawing.Point(22, 10)
        Me.labelX1.Name = "labelX1"
        Me.labelX1.Size = New System.Drawing.Size(26, 15)
        Me.labelX1.TabIndex = 3
        Me.labelX1.Text = "Red:"
        '
        'highlighter1
        '
        Me.highlighter1.ContainerControl = Me
        '
        'textBoxX3
        '
        '
        '
        '
        Me.textBoxX3.Border.Class = "TextBoxBorder"
        Me.highlighter1.SetHighlightColor(Me.textBoxX3, DevComponents.DotNetBar.Validator.eHighlightColor.Orange)
        Me.textBoxX3.Location = New System.Drawing.Point(60, 76)
        Me.textBoxX3.Name = "textBoxX3"
        Me.textBoxX3.Size = New System.Drawing.Size(197, 20)
        Me.textBoxX3.TabIndex = 2
        '
        'textBoxX2
        '
        '
        '
        '
        Me.textBoxX2.Border.Class = "TextBoxBorder"
        Me.highlighter1.SetHighlightColor(Me.textBoxX2, DevComponents.DotNetBar.Validator.eHighlightColor.Green)
        Me.textBoxX2.Location = New System.Drawing.Point(60, 42)
        Me.textBoxX2.Name = "textBoxX2"
        Me.textBoxX2.Size = New System.Drawing.Size(197, 20)
        Me.textBoxX2.TabIndex = 1
        '
        'textBoxX1
        '
        '
        '
        '
        Me.textBoxX1.Border.Class = "TextBoxBorder"
        Me.highlighter1.SetHighlightColor(Me.textBoxX1, DevComponents.DotNetBar.Validator.eHighlightColor.Red)
        Me.textBoxX1.Location = New System.Drawing.Point(60, 9)
        Me.textBoxX1.Name = "textBoxX1"
        Me.textBoxX1.Size = New System.Drawing.Size(197, 20)
        Me.textBoxX1.TabIndex = 0
        '
        'labelX2
        '
        Me.labelX2.AutoSize = True
        Me.labelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.labelX2.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.labelX2.Location = New System.Drawing.Point(12, 43)
        Me.labelX2.Name = "labelX2"
        Me.labelX2.Size = New System.Drawing.Size(36, 15)
        Me.labelX2.TabIndex = 4
        Me.labelX2.Text = "Green:"
        '
        'labelX3
        '
        Me.labelX3.AutoSize = True
        Me.labelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.labelX3.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.labelX3.Location = New System.Drawing.Point(6, 77)
        Me.labelX3.Name = "labelX3"
        Me.labelX3.Size = New System.Drawing.Size(42, 15)
        Me.labelX3.TabIndex = 5
        Me.labelX3.Text = "Orange:"
        '
        'groupPanel1
        '
        Me.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.groupPanel1.Controls.Add(Me.labelX3)
        Me.groupPanel1.Controls.Add(Me.labelX2)
        Me.groupPanel1.Controls.Add(Me.labelX1)
        Me.groupPanel1.Controls.Add(Me.textBoxX3)
        Me.groupPanel1.Controls.Add(Me.textBoxX2)
        Me.groupPanel1.Controls.Add(Me.textBoxX1)
        Me.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.groupPanel1.Location = New System.Drawing.Point(4, 4)
        Me.groupPanel1.Name = "groupPanel1"
        Me.groupPanel1.Size = New System.Drawing.Size(276, 124)
        '
        '
        '
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
        Me.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.groupPanel1.TabIndex = 2
        Me.groupPanel1.Text = "Fixed Highlighting"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 273)
        Me.Controls.Add(Me.groupPanel2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.groupPanel1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Text = "Highlighter Component"
        Me.groupPanel2.ResumeLayout(False)
        Me.groupPanel2.PerformLayout()
        Me.groupPanel1.ResumeLayout(False)
        Me.groupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents labelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX5 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX6 As DevComponents.DotNetBar.LabelX
    Private WithEvents textBoxX4 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents groupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents labelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX1 As DevComponents.DotNetBar.LabelX
    Private WithEvents textBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents textBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents textBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents textBoxX5 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents textBoxX6 As DevComponents.DotNetBar.Controls.TextBoxX

End Class
