<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCategoryStyling
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
        Me.labelX1 = New DevComponents.DotNetBar.LabelX
        Me.buttonX1 = New DevComponents.DotNetBar.ButtonX
        Me.advPropertyGrid1 = New DevComponents.DotNetBar.AdvPropertyGrid
        CType(Me.advPropertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelX1
        '
        Me.labelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelX1.ForeColor = System.Drawing.Color.Black
        Me.labelX1.Location = New System.Drawing.Point(278, 5)
        Me.labelX1.Name = "labelX1"
        Me.labelX1.Size = New System.Drawing.Size(244, 271)
        Me.labelX1.TabIndex = 11
        Me.labelX1.Text = "This sample shows how to assign custom style to Category nodes displayed in prope" & _
            "rty grid. See Form Load event for details."
        Me.labelX1.TextLineAlignment = System.Drawing.StringAlignment.Near
        Me.labelX1.WordWrap = True
        '
        'buttonX1
        '
        Me.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.buttonX1.Location = New System.Drawing.Point(278, 290)
        Me.buttonX1.Name = "buttonX1"
        Me.buttonX1.Size = New System.Drawing.Size(121, 28)
        Me.buttonX1.TabIndex = 10
        Me.buttonX1.Text = "Property Button"
        '
        'advPropertyGrid1
        '
        Me.advPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Left
        Me.advPropertyGrid1.Location = New System.Drawing.Point(0, 0)
        Me.advPropertyGrid1.Name = "advPropertyGrid1"
        Me.advPropertyGrid1.Size = New System.Drawing.Size(271, 321)
        Me.advPropertyGrid1.TabIndex = 9
        Me.advPropertyGrid1.Text = "advPropertyGrid1"
        '
        'FormCategoryStyling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 321)
        Me.Controls.Add(Me.labelX1)
        Me.Controls.Add(Me.buttonX1)
        Me.Controls.Add(Me.advPropertyGrid1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCategoryStyling"
        Me.Text = "Custom Category Style"
        CType(Me.advPropertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents labelX1 As DevComponents.DotNetBar.LabelX
    Private WithEvents buttonX1 As DevComponents.DotNetBar.ButtonX
    Private WithEvents advPropertyGrid1 As DevComponents.DotNetBar.AdvPropertyGrid
End Class
