Namespace TestVirtualKeyboard
	Partial Public Class Form5
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
			Me.textBox2 = New TextBox()
			Me.comboBox1 = New ComboBox()
			Me.listBox1 = New ListBox()
			Me.checkBox1 = New CheckBox()
			Me.button1 = New Button()
			Me.textBox1 = New TextBox()
			Me.touchKeyboard1 = New DevComponents.DotNetBar.Keyboard.TouchKeyboard()
			Me.bar1 = New DevComponents.DotNetBar.Bar()
			Me.buttonItem1 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem3 = New DevComponents.DotNetBar.ButtonItem()
			CType(Me.bar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' textBox2
			' 
			Me.textBox2.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.textBox2.Location = New Point(12, 28)
			Me.textBox2.Multiline = True
			Me.textBox2.Name = "textBox2"
			Me.textBox2.ReadOnly = True
			Me.textBox2.Size = New Size(761, 40)
			Me.textBox2.TabIndex = 13
			Me.textBox2.Text = "A virtual keyboard is attached to this form. All the controls in the form are aff" & "ected by this."
			' 
			' comboBox1
			' 
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Items.AddRange(New Object() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
			Me.comboBox1.Location = New Point(12, 126)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New Size(80, 21)
			Me.comboBox1.TabIndex = 16
			' 
			' listBox1
			' 
			Me.listBox1.FormattingEnabled = True
			Me.listBox1.Items.AddRange(New Object() { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
			Me.listBox1.Location = New Point(98, 76)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New Size(120, 82)
			Me.listBox1.TabIndex = 17
			' 
			' checkBox1
			' 
			Me.checkBox1.AutoSize = True
			Me.checkBox1.Location = New Point(12, 103)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New Size(80, 17)
			Me.checkBox1.TabIndex = 15
			Me.checkBox1.Text = "checkBox1"
			Me.checkBox1.UseVisualStyleBackColor = True
			' 
			' button1
			' 
			Me.button1.Location = New Point(12, 74)
			Me.button1.Name = "button1"
			Me.button1.Size = New Size(75, 23)
			Me.button1.TabIndex = 14
			Me.button1.Text = "button1"
			Me.button1.UseVisualStyleBackColor = True
			' 
			' textBox1
			' 
			Me.textBox1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.textBox1.Location = New Point(224, 74)
			Me.textBox1.Multiline = True
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New Size(549, 84)
			Me.textBox1.TabIndex = 18
			' 
			' touchKeyboard1
			' 
			Me.touchKeyboard1.FloatingLocation = New Point(0, 0)
			Me.touchKeyboard1.FloatingSize = New Size(740, 250)
			Me.touchKeyboard1.Location = New Point(0, 0)
			Me.touchKeyboard1.Size = New Size(740, 216)
			Me.touchKeyboard1.Text = "Touch keyboard"
			' 
			' bar1
			' 
			Me.bar1.AntiAlias = True
			Me.bar1.Dock = DockStyle.Top
			Me.bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.buttonItem1})
			Me.bar1.Location = New Point(0, 0)
			Me.bar1.Name = "bar1"
			Me.bar1.Size = New Size(785, 25)
			Me.bar1.Stretch = True
			Me.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.bar1.TabIndex = 19
			Me.bar1.TabStop = False
			Me.bar1.Text = "bar1"
			' 
			' buttonItem1
			' 
			Me.buttonItem1.AutoExpandOnClick = True
			Me.buttonItem1.Name = "buttonItem1"
			Me.buttonItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.buttonItem2, Me.buttonItem3})
			Me.buttonItem1.Text = "Renderers"
			' 
			' buttonItem2
			' 
			Me.buttonItem2.Name = "buttonItem2"
			Me.buttonItem2.Text = "Default"
'			Me.buttonItem2.Click += New System.EventHandler(Me.defaultRendererToolStripMenuItem_Click)
			' 
			' buttonItem3
			' 
			Me.buttonItem3.Name = "buttonItem3"
			Me.buttonItem3.Text = "Custom"
'			Me.buttonItem3.Click += New System.EventHandler(Me.dRendererToolStripMenuItem_Click)
			' 
			' Form5
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(785, 518)
			Me.Controls.Add(Me.bar1)
			Me.Controls.Add(Me.textBox2)
			Me.Controls.Add(Me.comboBox1)
			Me.Controls.Add(Me.listBox1)
			Me.Controls.Add(Me.checkBox1)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.textBox1)
			Me.DoubleBuffered = True
			Me.Name = "Form5"
			Me.touchKeyboard1.SetShowTouchKeyboard(Me, DevComponents.DotNetBar.Keyboard.TouchKeyboardStyle.Inline)
			Me.Text = "Form5 - Test Keyboard Renderer - make keyboard look the way you want"
			CType(Me.bar1, System.ComponentModel.ISupportInitialize).EndInit()
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
		Private touchKeyboard1 As DevComponents.DotNetBar.Keyboard.TouchKeyboard
		Private bar1 As DevComponents.DotNetBar.Bar
		Private buttonItem1 As DevComponents.DotNetBar.ButtonItem
		Private WithEvents buttonItem2 As DevComponents.DotNetBar.ButtonItem
		Private WithEvents buttonItem3 As DevComponents.DotNetBar.ButtonItem

	End Class
End Namespace