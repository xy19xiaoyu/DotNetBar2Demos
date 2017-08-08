Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar

Namespace TestVirtualKeyboard
	Partial Public Class StartForm
		Inherits DevComponents.DotNetBar.Metro.MetroForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub metroTileItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles metroTileItem1.Click
			Dim form As New Form1()
			form.ShowDialog(Me)
		End Sub

		Private Sub metroTileItem2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles metroTileItem2.Click
			Dim form As New Form2()
			form.ShowDialog(Me)
		End Sub

		Private Sub metroTileItem3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles metroTileItem3.Click
			Dim form As New Form3()
			form.ShowDialog(Me)
		End Sub

		Private Sub metroTileItem4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles metroTileItem4.Click
			Dim form As New Form4()
			form.ShowDialog(Me)
		End Sub

		Private Sub metroTileItem5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles metroTileItem5.Click
			Dim form As New Form5()
			form.ShowDialog(Me)
		End Sub
	End Class
End Namespace