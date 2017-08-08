Partial Public Class FormPropertyValueEditors
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.advPropertyGrid1 = New DevComponents.DotNetBar.AdvPropertyGrid()
        Me.labelX1 = New DevComponents.DotNetBar.LabelX()
        CType(Me.advPropertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' advPropertyGrid1
        ' 
        Me.advPropertyGrid1.GridLinesColor = Color.WhiteSmoke
        Me.advPropertyGrid1.HelpType = DevComponents.DotNetBar.ePropertyGridHelpType.Panel
        Me.advPropertyGrid1.Location = New Point(12, 50)
        Me.advPropertyGrid1.Name = "advPropertyGrid1"
        Me.advPropertyGrid1.Size = New Size(376, 358)
        Me.advPropertyGrid1.TabIndex = 0
        Me.advPropertyGrid1.Text = "advPropertyGrid1"
        ' 
        ' labelX1
        ' 
        ' 
        ' 
        ' 
        Me.labelX1.BackgroundStyle.Class = ""
        Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX1.Location = New Point(12, 4)
        Me.labelX1.Name = "labelX1"
        Me.labelX1.Size = New Size(376, 43)
        Me.labelX1.TabIndex = 1
        Me.labelX1.Text = "AdvPropertyGrid includes pre-defined property value editor, like multi-choice, da" & "te-time etc. You can also define your own. See code inside of this form for an e" & "xample."
        Me.labelX1.WordWrap = True
        ' 
        ' FormPropertyValueEditors
        ' 
        Me.AutoScaleDimensions = New SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(400, 420)
        Me.Controls.Add(Me.labelX1)
        Me.Controls.Add(Me.advPropertyGrid1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPropertyValueEditors"
        Me.Text = "Property Value Editors"
        '			Me.Load += New System.EventHandler(Me.FormPropertyValueEditors_Load)
        CType(Me.advPropertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private advPropertyGrid1 As DevComponents.DotNetBar.AdvPropertyGrid
    Private labelX1 As DevComponents.DotNetBar.LabelX
End Class
