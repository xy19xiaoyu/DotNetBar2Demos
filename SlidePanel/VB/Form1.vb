Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar.Controls

Namespace SlidePanel
	Partial Public Class Form1
		Inherits MetroForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub buttonX1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonX1.Click
			slidePanel1.IsOpen = False
		End Sub

		Private Sub ChangeSlideSide(ByVal side As eSlideSide)
			slidePanel1.SlideSide = side
			buttonLeft.Checked = (side = eSlideSide.Left)
			buttonTop.Checked = (side = eSlideSide.Top)
			buttonRight.Checked = (side = eSlideSide.Right)
			buttonBottom.Checked = (side = eSlideSide.Bottom)
		End Sub

		Private Sub buttonRight_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonRight.Click
			ChangeSlideSide(eSlideSide.Right)
		End Sub

		Private Sub buttonTop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonTop.Click
			ChangeSlideSide(eSlideSide.Top)
		End Sub

		Private Sub buttonLeft_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonLeft.Click
			ChangeSlideSide(eSlideSide.Left)
		End Sub

		Private Sub buttonBottom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonBottom.Click
			ChangeSlideSide(eSlideSide.Bottom)
		End Sub


	End Class
End Namespace