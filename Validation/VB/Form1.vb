Public Class Form1
    ' Want to see how everything is done in code?
    ' Explore InitializeComponent() method in Form1.Designer.vb
    ' All that is done on the form you can find there.

    Private Sub buttonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonX2.Click
        superValidator1.Enabled = False
        Me.Close()
    End Sub

    Private Sub buttonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonX1.Click
        Me.Close()
    End Sub

    Private Sub linkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.devcomponents.com/kb/questions.php?questionid=118")
    End Sub
End Class
