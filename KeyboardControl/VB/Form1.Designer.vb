Namespace TestVirtualKeyboard
	Partial Public Class Form1
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.textBox1 = New TextBox()
			Me.button1 = New Button()
			Me.checkBox1 = New CheckBox()
			Me.listBox1 = New ListBox()
			Me.comboBox1 = New ComboBox()
			Me.textBox2 = New TextBox()
			Me.touchKeyboard1 = New DevComponents.DotNetBar.Keyboard.TouchKeyboard()
			Me.textBox3 = New TextBox()
			Me.bar1 = New DevComponents.DotNetBar.Bar()
			Me.buttonItem5 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem6 = New DevComponents.DotNetBar.ButtonItem()
			Me.buttonItem7 = New DevComponents.DotNetBar.ButtonItem()
			CType(Me.bar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' textBox1
			' 
			Me.textBox1.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.textBox1.Location = New Point(224, 73)
			Me.textBox1.Multiline = True
			Me.textBox1.Name = "textBox1"
			Me.touchKeyboard1.SetShowTouchKeyboard(Me.textBox1, DevComponents.DotNetBar.Keyboard.TouchKeyboardStyle.Inline)
			Me.textBox1.Size = New Size(549, 84)
			Me.textBox1.TabIndex = 5
			' 
			' button1
			' 
			Me.button1.Location = New Point(12, 73)
			Me.button1.Name = "button1"
			Me.touchKeyboard1.SetShowTouchKeyboard(Me.button1, DevComponents.DotNetBar.Keyboard.TouchKeyboardStyle.Inline)
			Me.button1.Size = New Size(75, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "button1"
			Me.button1.UseVisualStyleBackColor = True
			' 
			' checkBox1
			' 
			Me.checkBox1.AutoSize = True
			Me.checkBox1.Location = New Point(12, 102)
			Me.checkBox1.Name = "checkBox1"
			Me.touchKeyboard1.SetShowTouchKeyboard(Me.checkBox1, DevComponents.DotNetBar.Keyboard.TouchKeyboardStyle.Inline)
			Me.checkBox1.Size = New Size(80, 17)
			Me.checkBox1.TabIndex = 2
			Me.checkBox1.Text = "checkBox1"
			Me.checkBox1.UseVisualStyleBackColor = True
			' 
			' listBox1
			' 
			Me.listBox1.FormattingEnabled = True
			Me.listBox1.Items.AddRange(New Object() { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
			Me.listBox1.Location = New Point(98, 75)
			Me.listBox1.Name = "listBox1"
			Me.touchKeyboard1.SetShowTouchKeyboard(Me.listBox1, DevComponents.DotNetBar.Keyboard.TouchKeyboardStyle.Inline)
			Me.listBox1.Size = New Size(120, 82)
			Me.listBox1.TabIndex = 4
			' 
			' comboBox1
			' 
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Items.AddRange(New Object() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
			Me.comboBox1.Location = New Point(12, 125)
			Me.comboBox1.Name = "comboBox1"
			Me.touchKeyboard1.SetShowTouchKeyboard(Me.comboBox1, DevComponents.DotNetBar.Keyboard.TouchKeyboardStyle.Inline)
			Me.comboBox1.Size = New Size(80, 21)
			Me.comboBox1.TabIndex = 3
			' 
			' textBox2
			' 
			Me.textBox2.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.textBox2.Location = New Point(12, 27)
			Me.textBox2.Multiline = True
			Me.textBox2.Name = "textBox2"
			Me.textBox2.ReadOnly = True
			Me.textBox2.Size = New Size(761, 40)
			Me.textBox2.TabIndex = 0
			Me.textBox2.Text = "A virtual keyboard is attached to all the controls bellow. Give input focus to on" & "e of them to see it working. Chose a different color scheme from the ColorTables" & " menu."
			' 
			' touchKeyboard1
			' 
			Me.touchKeyboard1.FloatingLocation = New Point(0, 500)
			Me.touchKeyboard1.FloatingSize = New Size(740, 250)
			Me.touchKeyboard1.Location = New Point(100, 400)
			Me.touchKeyboard1.Size = New Size(0, 0)
			Me.touchKeyboard1.Text = "Keyboard"
			' 
			' textBox3
			' 
			Me.textBox3.Anchor = (CType(((AnchorStyles.Top Or AnchorStyles.Left) Or AnchorStyles.Right), AnchorStyles))
			Me.textBox3.Location = New Point(12, 163)
			Me.textBox3.Multiline = True
			Me.textBox3.Name = "textBox3"
			Me.touchKeyboard1.SetShowTouchKeyboard(Me.textBox3, DevComponents.DotNetBar.Keyboard.TouchKeyboardStyle.Floating)
			Me.textBox3.Size = New Size(761, 343)
			Me.textBox3.TabIndex = 7
			' 
			' bar1
			' 
			Me.bar1.AntiAlias = True
			Me.bar1.Dock = DockStyle.Top
			Me.bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.buttonItem5})
			Me.bar1.Location = New Point(0, 0)
			Me.bar1.Name = "bar1"
			Me.bar1.Size = New Size(785, 25)
			Me.bar1.Stretch = True
			Me.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.bar1.TabIndex = 8
			Me.bar1.TabStop = False
			Me.bar1.Text = "bar1"
			' 
			' buttonItem5
			' 
			Me.buttonItem5.AutoExpandOnClick = True
			Me.buttonItem5.Name = "buttonItem5"
			Me.buttonItem5.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() { Me.buttonItem6, Me.buttonItem7})
			Me.buttonItem5.Text = "Color Table"
			' 
			' buttonItem6
			' 
			Me.buttonItem6.Name = "buttonItem6"
			Me.buttonItem6.Text = "Default"
'			Me.buttonItem6.Click += New System.EventHandler(Me.colorTable1ToolStripMenuItem_Click)
			' 
			' buttonItem7
			' 
			Me.buttonItem7.Name = "buttonItem7"
			Me.buttonItem7.Text = "Custom"
'			Me.buttonItem7.Click += New System.EventHandler(Me.colorTable2ToolStripMenuItem_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.ClientSize = New Size(785, 518)
			Me.Controls.Add(Me.bar1)
			Me.Controls.Add(Me.textBox3)
			Me.Controls.Add(Me.textBox2)
			Me.Controls.Add(Me.comboBox1)
			Me.Controls.Add(Me.listBox1)
			Me.Controls.Add(Me.checkBox1)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.textBox1)
			Me.DoubleBuffered = True
			Me.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
			Me.Name = "Form1"
			Me.Text = "TouchKeyboard attached to controls"
			CType(Me.bar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private textBox1 As TextBox
		Private button1 As Button
		Private checkBox1 As CheckBox
		Private listBox1 As ListBox
		Private comboBox1 As ComboBox
		Private textBox2 As TextBox
		Private touchKeyboard1 As DevComponents.DotNetBar.Keyboard.TouchKeyboard
		Private textBox3 As TextBox
		Private bar1 As DevComponents.DotNetBar.Bar
		Private buttonItem5 As DevComponents.DotNetBar.ButtonItem
		Private WithEvents buttonItem6 As DevComponents.DotNetBar.ButtonItem
		Private WithEvents buttonItem7 As DevComponents.DotNetBar.ButtonItem
	End Class
End Namespace

