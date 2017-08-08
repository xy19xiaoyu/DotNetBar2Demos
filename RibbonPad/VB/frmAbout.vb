Imports System.Collections
Imports System.ComponentModel

Namespace Ribbonpad
	''' <summary>
	''' Summary description for frmAbout.
	''' </summary>
	Public Class frmAbout
		Inherits Form
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
			Me.linkLabel1 = New LinkLabel()
			Me.SuspendLayout()
			' 
			' linkLabel1
			' 
			Me.linkLabel1.Location = New Point(92, 87)
			Me.linkLabel1.Name = "linkLabel1"
			Me.linkLabel1.Size = New Size(122, 13)
			Me.linkLabel1.TabIndex = 0
			Me.linkLabel1.TabStop = True
			Me.linkLabel1.Text = "DotNetBar Home Page"
'			Me.linkLabel1.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.linkLabel1_LinkClicked)
			' 
			' frmAbout
			' 
			Me.AutoScaleBaseSize = New Size(5, 13)
			Me.ClientSize = New Size(323, 217)
			Me.Controls.AddRange(New Control() { Me.linkLabel1})
			Me.FormBorderStyle = FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "frmAbout"
			Me.ShowInTaskbar = False
			Me.Text = "About DotNetBar Notepad Sample"
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub linkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked

		End Sub
	End Class
End Namespace
