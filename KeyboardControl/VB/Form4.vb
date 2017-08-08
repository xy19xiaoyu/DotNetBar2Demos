Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar.Keyboard
Imports DevComponents.DotNetBar.Metro

Namespace TestVirtualKeyboard
	Partial Public Class Form4
		Inherits MetroForm
		Private virtualKeyboard As KeyboardControl

		Public Sub New()
			InitializeComponent()

			virtualKeyboard = New KeyboardControl()
			virtualKeyboard.Location = New Point(10, 200)
			virtualKeyboard.Visible = False
			virtualKeyboard.Text = "Touch Keyboard"

			Me.Controls.Add(virtualKeyboard)
		End Sub

		Private Sub btnAttach_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonX1.Click
			virtualKeyboard.AttachTo(button1)
			virtualKeyboard.AttachTo(checkBox1)
			virtualKeyboard.AttachTo(comboBox1)
			virtualKeyboard.AttachTo(listBox1)
			virtualKeyboard.AttachTo(textBox1)
		End Sub

		Private Sub btnDetach_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonX2.Click
			virtualKeyboard.DetachFrom(button1)
			virtualKeyboard.DetachFrom(checkBox1)
			virtualKeyboard.DetachFrom(comboBox1)
			virtualKeyboard.DetachFrom(listBox1)
			virtualKeyboard.DetachFrom(textBox1)
		End Sub

	End Class
End Namespace
