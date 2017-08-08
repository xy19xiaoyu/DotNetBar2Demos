Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar.Keyboard
Imports DevComponents.DotNetBar.Metro

Namespace TestVirtualKeyboard
	Partial Public Class Form1
		Inherits MetroForm
		Private _ColorTableDefault As New VirtualKeyboardColorTable()
		Private _ColorTableCustom As VirtualKeyboardColorTable


		Public Sub New()
			InitializeComponent()

			_ColorTableCustom = New VirtualKeyboardColorTable()
			_ColorTableCustom.BackgroundColor = Color.Gray
			_ColorTableCustom.DarkKeysColor = Color.Black
			_ColorTableCustom.KeysColor = Color.Black
			_ColorTableCustom.LightKeysColor = Color.Black
			_ColorTableCustom.PressedKeysColor = Color.Red
			_ColorTableCustom.TextColor = Color.White
			_ColorTableCustom.DownKeysColor = Color.IndianRed
			_ColorTableCustom.DownTextColor = Color.Black
			_ColorTableCustom.TopBarTextColor = Color.Black
			_ColorTableCustom.ToggleTextColor = Color.DarkRed

			touchKeyboard1.ColorTable = _ColorTableDefault

			AddHandler Disposed, AddressOf Form1_Disposed
		End Sub


		Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As EventArgs)
			_ColorTableDefault.Dispose()
			_ColorTableCustom.Dispose()
		End Sub

		#Region "Menu handlers"

		Private Sub KeyboardAttachedToFormClick(ByVal sender As Object, ByVal e As EventArgs)
			CType(New Form2(), Form2).Show()
		End Sub


		Private Sub testVirtualKeyboardToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			CType(New Form1(), Form1).Show()
		End Sub


		Private Sub testKeyboardLayoutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			CType(New Form3(), Form3).Show()
		End Sub


		Private Sub testCodeBehindToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			CType(New Form4(), Form4).Show()
		End Sub


		Private Sub testRendererToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			CType(New Form5(), Form5).Show()
		End Sub

		#End Region

		Private Sub colorTable1ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonItem6.Click
			touchKeyboard1.ColorTable = _ColorTableDefault
		End Sub


		Private Sub colorTable2ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonItem7.Click
			touchKeyboard1.ColorTable = _ColorTableCustom
		End Sub



	End Class
End Namespace
