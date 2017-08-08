<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPropertyValuesTranslationMethod1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPropertyValuesTranslationMethod1))
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
        Me.labelX1.Location = New System.Drawing.Point(282, 7)
        Me.labelX1.Name = "labelX1"
        Me.labelX1.Size = New System.Drawing.Size(230, 271)
        Me.labelX1.TabIndex = 8
        Me.labelX1.Text = "This sample shows how to perform ""bulk"" property value mapping. It shows replacin" & _
            "g of all boolean true, false values in property grid with Yes, No."
        Me.labelX1.TextLineAlignment = System.Drawing.StringAlignment.Near
        Me.labelX1.WordWrap = True
        '
        'buttonX1
        '
        Me.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.buttonX1.Location = New System.Drawing.Point(279, 289)
        Me.buttonX1.Name = "buttonX1"
        Me.buttonX1.Size = New System.Drawing.Size(121, 28)
        Me.buttonX1.TabIndex = 7
        Me.buttonX1.Text = "Property Button"
        '
        'advPropertyGrid1
        '
        Me.advPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Left
        Me.advPropertyGrid1.Location = New System.Drawing.Point(0, 0)
        Me.advPropertyGrid1.Name = "advPropertyGrid1"
        Me.advPropertyGrid1.Size = New System.Drawing.Size(271, 321)
        Me.advPropertyGrid1.TabIndex = 6
        Me.advPropertyGrid1.Text = "advPropertyGrid1"
        '
        'FormPropertyValuesTranslationMethod1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 321)
        Me.Controls.Add(Me.labelX1)
        Me.Controls.Add(Me.buttonX1)
        Me.Controls.Add(Me.advPropertyGrid1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPropertyValuesTranslationMethod1"
        Me.Text = "Property Value Translation Bulk Method"
        CType(Me.advPropertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents labelX1 As DevComponents.DotNetBar.LabelX
    Private WithEvents buttonX1 As DevComponents.DotNetBar.ButtonX
    Private WithEvents advPropertyGrid1 As DevComponents.DotNetBar.AdvPropertyGrid
End Class
