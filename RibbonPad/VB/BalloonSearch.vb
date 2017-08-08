Imports System.Collections
Imports System.ComponentModel
Imports DevComponents.DotNetBar

Namespace Ribbonpad
	''' <summary>
	''' Summary description for BalloonSearch.
	''' </summary>
	Public Class BalloonSearch
		Inherits DevComponents.DotNetBar.Balloon
		Private textBox1 As TextBox
		Private WithEvents button1 As Button
		Private label1 As Label
		Private pictureBox1 As PictureBox
		Private WithEvents linkLabel1 As LinkLabel
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.Resources.ResourceManager(GetType(BalloonSearch))
			Me.textBox1 = New TextBox()
			Me.button1 = New Button()
			Me.label1 = New Label()
			Me.pictureBox1 = New PictureBox()
			Me.linkLabel1 = New LinkLabel()
			Me.SuspendLayout()
			' 
			' textBox1
			' 
			Me.textBox1.BorderStyle = BorderStyle.FixedSingle
			Me.textBox1.Location = New Point(72, 48)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New Size(160, 20)
			Me.textBox1.TabIndex = 0
			Me.textBox1.Text = ""
			' 
			' button1
			' 
			Me.button1.DialogResult = DialogResult.OK
			Me.button1.FlatStyle = FlatStyle.Flat
			Me.button1.Location = New Point(116, 72)
			Me.button1.Name = "button1"
			Me.button1.Size = New Size(72, 24)
			Me.button1.TabIndex = 1
			Me.button1.Text = "&Search"
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' label1
			' 
			Me.label1.BackColor = Color.Transparent
			Me.label1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New Point(72, 32)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(112, 16)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Find what:"
			' 
			' pictureBox1
			' 
			Me.pictureBox1.BackColor = Color.Transparent
			Me.pictureBox1.Image = (CType(resources.GetObject("pictureBox1.Image"), Bitmap))
			Me.pictureBox1.Location = New Point(8, 24)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New Size(64, 64)
			Me.pictureBox1.TabIndex = 3
			Me.pictureBox1.TabStop = False
			' 
			' linkLabel1
			' 
			Me.linkLabel1.AutoSize = True
			Me.linkLabel1.BackColor = Color.Transparent
			Me.linkLabel1.Font = New Font("Verdana", 6.75F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel1.Location = New Point(8, 88)
			Me.linkLabel1.Name = "linkLabel1"
			Me.linkLabel1.Size = New Size(61, 11)
			Me.linkLabel1.TabIndex = 4
			Me.linkLabel1.TabStop = True
			Me.linkLabel1.Text = "Switch Style"
			Me.linkLabel1.VisitedLinkColor = Color.Blue
'			Me.linkLabel1.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.linkLabel1_LinkClicked)
			' 
			' BalloonSearch
			' 
			Me.AutoScaleBaseSize = New Size(5, 13)
			Me.ClientSize = New Size(240, 104)
			Me.Controls.AddRange(New Control() { Me.linkLabel1, Me.pictureBox1, Me.label1, Me.button1, Me.textBox1})
			Me.Location = New Point(0, 0)
			Me.Name = "BalloonSearch"
'			Me.Activated += New System.EventHandler(Me.BalloonSearch_Activated)
'			Me.Deactivate += New System.EventHandler(Me.BalloonSearch_Deactivate)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub BalloonSearch_Deactivate(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Deactivate
			Me.Opacity=.75
		End Sub

		Private Sub BalloonSearch_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
			Me.Opacity=1
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			If Me.Owner IsNot Nothing Then
				If textBox1.Text="" Then
					MessageBoxEx.Show("Please enter search text.","Search",MessageBoxButtons.OK,MessageBoxIcon.Information)
				Else
					CType(Me.Owner, frmMain).SearchActiveDocument(textBox1.Text)
				End If
			End If
		End Sub

		Private Sub linkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
			If Me.BackColor=SystemColors.Info Then
				' Switch to Office 2003 style colors...
				Dim scheme As New ColorScheme(eDotNetBarStyle.Office2003)
				Me.BackColor=scheme.ItemCheckedBackground
				Me.BackColor2=scheme.ItemCheckedBackground2
				Me.BackColorGradientAngle=scheme.ItemCheckedBackgroundGradientAngle
				Me.Refresh()
			Else
				Me.BackColor=SystemColors.Info
				Me.BackColor2=Color.Empty
				Me.Refresh()
			End If
		End Sub
	End Class
End Namespace
