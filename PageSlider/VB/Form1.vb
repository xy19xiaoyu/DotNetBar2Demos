Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar

Namespace PageSlider
	Partial Public Class Form1
		Inherits MetroForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub buttonX1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonX1.Click
			Dim page As New PageSliderPage()
			pageSlider1.Controls.Add(page)
			Dim label As New LabelX()
			label.Height = 32
			label.Text = "Another page slider page..."
			label.Dock = DockStyle.Top
			page.Controls.Add(label)
			' Select it
			pageSlider1.SelectedPage = page
		End Sub
	End Class
End Namespace