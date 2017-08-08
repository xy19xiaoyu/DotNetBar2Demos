Namespace TestVirtualKeyboard
	Partial Public Class Form4
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form4))
			Me.textBox2 = New TextBox()
			Me.comboBox1 = New ComboBox()
			Me.listBox1 = New ListBox()
			Me.checkBox1 = New CheckBox()
			Me.button1 = New Button()
			Me.textBox1 = New TextBox()
			Me.buttonX1 = New DevComponents.DotNetBar.ButtonX()
			Me.buttonX2 = New DevComponents.DotNetBar.ButtonX()
			Me.SuspendLayout()
			' 
			' textBox2
			' 
			Me.textBox2.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.textBox2.Location = New Point(12, 15)
			Me.textBox2.Multiline = True
			Me.textBox2.Name = "textBox2"
			Me.textBox2.ReadOnly = True
			Me.textBox2.Size = New Size(599, 40)
			Me.textBox2.TabIndex = 14
			Me.textBox2.Text = resources.GetString("textBox2.Text")
			' 
			' comboBox1
			' 
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Items.AddRange(New Object() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
			Me.comboBox1.Location = New Point(12, 113)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New Size(80, 21)
			Me.comboBox1.TabIndex = 17
			' 
			' listBox1
			' 
			Me.listBox1.FormattingEnabled = True
			Me.listBox1.Items.AddRange(New Object() { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
			Me.listBox1.Location = New Point(98, 63)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New Size(120, 82)
			Me.listBox1.TabIndex = 18
			' 
			' checkBox1
			' 
			Me.checkBox1.AutoSize = True
			Me.checkBox1.Location = New Point(12, 90)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New Size(80, 17)
			Me.checkBox1.TabIndex = 16
			Me.checkBox1.Text = "checkBox1"
			Me.checkBox1.UseVisualStyleBackColor = True
			' 
			' button1
			' 
			Me.button1.Location = New Point(12, 61)
			Me.button1.Name = "button1"
			Me.button1.Size = New Size(75, 23)
			Me.button1.TabIndex = 15
			Me.button1.Text = "button1"
			Me.button1.UseVisualStyleBackColor = True
			' 
			' textBox1
			' 
			Me.textBox1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.textBox1.Location = New Point(224, 61)
			Me.textBox1.Multiline = True
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New Size(549, 84)
			Me.textBox1.TabIndex = 19
			' 
			' buttonX1
			' 
			Me.buttonX1.AccessibleRole = AccessibleRole.PushButton
			Me.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
			Me.buttonX1.Location = New Point(617, 18)
			Me.buttonX1.Name = "buttonX1"
			Me.buttonX1.Size = New Size(75, 34)
			Me.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.buttonX1.TabIndex = 23
			Me.buttonX1.Text = "Attach"
'			Me.buttonX1.Click += New System.EventHandler(Me.btnAttach_Click)
			' 
			' buttonX2
			' 
			Me.buttonX2.AccessibleRole = AccessibleRole.PushButton
			Me.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
			Me.buttonX2.Location = New Point(698, 18)
			Me.buttonX2.Name = "buttonX2"
			Me.buttonX2.Size = New Size(75, 34)
			Me.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.buttonX2.TabIndex = 24
			Me.buttonX2.Text = "Detach"
'			Me.buttonX2.Click += New System.EventHandler(Me.btnDetach_Click)
			' 
			' Form4
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(785, 518)
			Me.Controls.Add(Me.buttonX2)
			Me.Controls.Add(Me.buttonX1)
			Me.Controls.Add(Me.textBox2)
			Me.Controls.Add(Me.comboBox1)
			Me.Controls.Add(Me.listBox1)
			Me.Controls.Add(Me.checkBox1)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.textBox1)
			Me.DoubleBuffered = True
			Me.Name = "Form4"
			Me.Text = "How to use TouchKeyboard from codee"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private textBox2 As TextBox
		Private comboBox1 As ComboBox
		Private listBox1 As ListBox
		Private checkBox1 As CheckBox
		Private button1 As Button
		Private textBox1 As TextBox
		Private WithEvents buttonX1 As DevComponents.DotNetBar.ButtonX
		Private WithEvents buttonX2 As DevComponents.DotNetBar.ButtonX

	End Class
End Namespace