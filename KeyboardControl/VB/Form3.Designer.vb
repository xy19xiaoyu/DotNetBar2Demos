Namespace TestVirtualKeyboard
	Partial Public Class Form3
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
			Dim virtualKeyboardColorTable2 As New DevComponents.DotNetBar.Keyboard.VirtualKeyboardColorTable()
			Dim flatStyleRenderer2 As New DevComponents.DotNetBar.Keyboard.FlatStyleRenderer()
			Me.virtualKeyboard1 = New DevComponents.DotNetBar.Keyboard.KeyboardControl()
			Me.textBox1 = New TextBox()
			Me.SuspendLayout()
			' 
			' virtualKeyboard1
			' 
			Me.virtualKeyboard1.Anchor = (CType((((AnchorStyles.Top Or AnchorStyles.Bottom) Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			virtualKeyboardColorTable2.BackgroundColor = Color.Black
			virtualKeyboardColorTable2.DarkKeysColor = Color.FromArgb((CInt((CByte(29)))), (CInt((CByte(28)))), (CInt((CByte(33)))))
			virtualKeyboardColorTable2.DownKeysColor = Color.White
			virtualKeyboardColorTable2.DownTextColor = Color.FromArgb((CInt((CByte(32)))), (CInt((CByte(32)))), (CInt((CByte(32)))))
			virtualKeyboardColorTable2.KeysColor = Color.FromArgb((CInt((CByte(48)))), (CInt((CByte(47)))), (CInt((CByte(55)))))
			virtualKeyboardColorTable2.LightKeysColor = Color.FromArgb((CInt((CByte(69)))), (CInt((CByte(68)))), (CInt((CByte(76)))))
			virtualKeyboardColorTable2.PressedKeysColor = Color.FromArgb((CInt((CByte(16)))), (CInt((CByte(161)))), (CInt((CByte(81)))))
			virtualKeyboardColorTable2.TextColor = Color.White
			virtualKeyboardColorTable2.ToggleTextColor = Color.Green
			virtualKeyboardColorTable2.TopBarTextColor = Color.White
			Me.virtualKeyboard1.ColorTable = virtualKeyboardColorTable2
			Me.virtualKeyboard1.Location = New Point(13, 39)
			Me.virtualKeyboard1.Name = "virtualKeyboard1"
			flatStyleRenderer2.ColorTable = virtualKeyboardColorTable2
			flatStyleRenderer2.ForceAntiAlias = False
			Me.virtualKeyboard1.Renderer = flatStyleRenderer2
			Me.virtualKeyboard1.Size = New Size(237, 296)
			Me.virtualKeyboard1.TabIndex = 0
			Me.virtualKeyboard1.Text = "virtualKeyboard1"
			' 
			' textBox1
			' 
			Me.textBox1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.textBox1.Location = New Point(13, 13)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New Size(237, 20)
			Me.textBox1.TabIndex = 1
			' 
			' Form3
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(262, 347)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.virtualKeyboard1)
			Me.Name = "Form3"
			Me.Text = "Form3 - Test Keyboard Layout"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private virtualKeyboard1 As DevComponents.DotNetBar.Keyboard.KeyboardControl
		Private textBox1 As TextBox
	End Class
End Namespace