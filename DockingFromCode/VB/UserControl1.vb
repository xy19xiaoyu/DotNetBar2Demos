Imports DevComponents.DotNetBar

Public Class UserControl1
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
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
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.button1.Location = New System.Drawing.Point(0, 127)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(150, 23)
        Me.button1.TabIndex = 3
        Me.button1.Text = "Which Bar I am on?"
        '
        'label1
        '
        Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(150, 150)
        Me.label1.TabIndex = 2
        Me.label1.Text = "label1"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserControl1
        '
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.button1, Me.label1})
        Me.Name = "UserControl1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Dim bar As Bar = CType(Me.Parent, Bar)
        If bar Is Nothing Then
            MessageBox.Show("Control is not on the bar")
        Else
            ' If reference to DotNetBarManager is needed this is how to get it
            Dim manager As DotNetBarManager = CType(bar.Owner, DotNetBarManager)
            Dim dockItem As DockContainerItem
            If bar.SelectedDockTab < 0 Then ' There is only one DockContainerItem on the bar
                dockItem = CType(bar.Items(0), DockContainerItem)
            Else
                dockItem = CType(bar.Items(bar.SelectedDockTab), DockContainerItem)
            End If

            MessageBox.Show("Control is on the bar: " + bar.Name + " (" + bar.Text + ") and on DockContainerItem: " + dockItem.Name + " (" + dockItem.Text + ")")
        End If
    End Sub
End Class
