Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar.Keyboard
Imports DevComponents.DotNetBar.Metro

Namespace TestVirtualKeyboard
	Partial Public Class Form3
		Inherits MetroForm
		Public Sub New()
			InitializeComponent()

			virtualKeyboard1.Keyboard = CreateNumericKeyboard()

			virtualKeyboard1.Invalidate()
		End Sub

		Private Function CreateNumericKeyboard() As Keyboard
			Dim keyboard As New Keyboard()

			Dim klNumLockOn As New LinearKeyboardLayout()

			klNumLockOn.AddKey("NumLock", info:= Nothing, style:= KeyStyle.Pressed, layout:= 1)
			klNumLockOn.AddKey("/", "{DIVIDE}")
			klNumLockOn.AddKey("*", "{MULTIPLY}")
			klNumLockOn.AddKey("-", "{SUBTRACT}")
			klNumLockOn.AddLine()

			klNumLockOn.AddKey("7")
			klNumLockOn.AddKey("8")
			klNumLockOn.AddKey("9")
			klNumLockOn.AddKey("+", "{ADD}", height:= 21)
			klNumLockOn.AddLine()

			klNumLockOn.AddKey("4")
			klNumLockOn.AddKey("5")
			klNumLockOn.AddKey("6")
			klNumLockOn.AddLine()

			klNumLockOn.AddKey("1")
			klNumLockOn.AddKey("2")
			klNumLockOn.AddKey("3")
			klNumLockOn.AddKey("Enter", "{ENTER}", height:= 21)
			klNumLockOn.AddLine()

			klNumLockOn.AddKey("0", width:= 21)
			klNumLockOn.AddKey(".")


			Dim klNumLockOff As New LinearKeyboardLayout()

			klNumLockOff.AddKey("NumLock", style:= KeyStyle.Normal, layout:= 0)
			klNumLockOff.AddKey("/", "{DIVIDE}")
			klNumLockOff.AddKey("*", "{MULTIPLY}")
			klNumLockOff.AddKey("-", "{SUBTRACT}")
			klNumLockOff.AddLine()

			klNumLockOff.AddKey("Home", "{HOME}")
			klNumLockOff.AddKey("Up", "{UP}")
			klNumLockOff.AddKey("PgUp", "{PGUP}")
			klNumLockOff.AddKey("+", "{ADD}", height:= 21)
			klNumLockOff.AddLine()

			klNumLockOff.AddKey("Left", "{LEFT}")
			klNumLockOff.AddKey("")
			klNumLockOff.AddKey("Right", "{RIGHT}")
			klNumLockOff.AddLine()

			klNumLockOff.AddKey("End", "{END}")
			klNumLockOff.AddKey("Down", "{DOWN}")
			klNumLockOff.AddKey("PgDn", "{PGDN}")
			klNumLockOff.AddKey("Enter", "{ENTER}", height:= 21)
			klNumLockOff.AddLine()

			klNumLockOff.AddKey("Ins", "{INSERT}", width:= 21)
			klNumLockOff.AddKey(".")


			keyboard.Layouts.Add(klNumLockOn)
			keyboard.Layouts.Add(klNumLockOff)

			Return keyboard
		End Function
	End Class
End Namespace
