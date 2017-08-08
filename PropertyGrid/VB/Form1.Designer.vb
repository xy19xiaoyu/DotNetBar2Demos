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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.buttonX5 = New DevComponents.DotNetBar.ButtonX
        Me.buttonX4 = New DevComponents.DotNetBar.ButtonX
        Me.buttonX3 = New DevComponents.DotNetBar.ButtonX
        Me.buttonX2 = New DevComponents.DotNetBar.ButtonX
        Me.buttonX1 = New DevComponents.DotNetBar.ButtonX
        Me.buttonX6 = New DevComponents.DotNetBar.ButtonX
        Me.SuspendLayout()
        '
        'buttonX5
        '
        Me.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.buttonX5.Image = CType(resources.GetObject("buttonX5.Image"), System.Drawing.Image)
        Me.buttonX5.Location = New System.Drawing.Point(244, 93)
        Me.buttonX5.Name = "buttonX5"
        Me.buttonX5.Size = New System.Drawing.Size(218, 58)
        Me.buttonX5.TabIndex = 9
        Me.buttonX5.Text = "<b>Sample 5</b><br/>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Customizing Category node appearance"
        '
        'buttonX4
        '
        Me.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.buttonX4.Image = CType(resources.GetObject("buttonX4.Image"), System.Drawing.Image)
        Me.buttonX4.Location = New System.Drawing.Point(244, 19)
        Me.buttonX4.Name = "buttonX4"
        Me.buttonX4.Size = New System.Drawing.Size(218, 58)
        Me.buttonX4.TabIndex = 8
        Me.buttonX4.Text = "<b>Sample 4</b><br/>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Adding custom buttons to grid toolbar"
        '
        'buttonX3
        '
        Me.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.buttonX3.Image = CType(resources.GetObject("buttonX3.Image"), System.Drawing.Image)
        Me.buttonX3.Location = New System.Drawing.Point(11, 166)
        Me.buttonX3.Name = "buttonX3"
        Me.buttonX3.Size = New System.Drawing.Size(205, 58)
        Me.buttonX3.TabIndex = 7
        Me.buttonX3.Text = "<b>Sample 3</b><br/>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Property Value Mapping method 2"
        '
        'buttonX2
        '
        Me.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.buttonX2.Image = CType(resources.GetObject("buttonX2.Image"), System.Drawing.Image)
        Me.buttonX2.Location = New System.Drawing.Point(11, 93)
        Me.buttonX2.Name = "buttonX2"
        Me.buttonX2.Size = New System.Drawing.Size(205, 58)
        Me.buttonX2.TabIndex = 6
        Me.buttonX2.Text = "<b>Sample 2</b><br/>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Property Value Mapping ""bulk"" method"
        '
        'buttonX1
        '
        Me.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.buttonX1.Image = CType(resources.GetObject("buttonX1.Image"), System.Drawing.Image)
        Me.buttonX1.Location = New System.Drawing.Point(11, 19)
        Me.buttonX1.Name = "buttonX1"
        Me.buttonX1.Size = New System.Drawing.Size(205, 58)
        Me.buttonX1.TabIndex = 5
        Me.buttonX1.Text = "<b>Sample 1</b><br/>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Customizing Property Appearance"
        '
        'buttonX6
        '
        Me.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.buttonX6.Image = CType(resources.GetObject("buttonX6.Image"), System.Drawing.Image)
        Me.buttonX6.Location = New System.Drawing.Point(244, 166)
        Me.buttonX6.Name = "buttonX6"
        Me.buttonX6.Size = New System.Drawing.Size(217, 58)
        Me.buttonX6.TabIndex = 10
        Me.buttonX6.Text = "<b>Sample 6</b><br/>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inline property value editors"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 242)
        Me.Controls.Add(Me.buttonX6)
        Me.Controls.Add(Me.buttonX5)
        Me.Controls.Add(Me.buttonX4)
        Me.Controls.Add(Me.buttonX3)
        Me.Controls.Add(Me.buttonX2)
        Me.Controls.Add(Me.buttonX1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "DotNetBar Advanced Property Grid Control Demo"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents buttonX5 As DevComponents.DotNetBar.ButtonX
    Private WithEvents buttonX4 As DevComponents.DotNetBar.ButtonX
    Private WithEvents buttonX3 As DevComponents.DotNetBar.ButtonX
    Private WithEvents buttonX2 As DevComponents.DotNetBar.ButtonX
    Private WithEvents buttonX1 As DevComponents.DotNetBar.ButtonX
    Private WithEvents buttonX6 As DevComponents.DotNetBar.ButtonX

End Class
