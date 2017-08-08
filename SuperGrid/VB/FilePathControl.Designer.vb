Namespace SuperGridDemo
	Partial Public Class FilePathControl
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(FilePathControl))
			Me.btnDialog = New DevComponents.DotNetBar.ButtonX()
			Me.tbxFilePath = New DevComponents.DotNetBar.Controls.TextBoxX()
			Me.SuspendLayout()
			' 
			' btnDialog
			' 
			Me.btnDialog.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
			Me.btnDialog.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnDialog.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
			Me.btnDialog.Image = (CType(resources.GetObject("btnDialog.Image"), System.Drawing.Image))
			Me.btnDialog.Location = New System.Drawing.Point(142, 5)
			Me.btnDialog.Name = "btnDialog"
			Me.btnDialog.Size = New System.Drawing.Size(16, 15)
			Me.btnDialog.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.btnDialog.TabIndex = 3
			Me.btnDialog.Tooltip = "Click to launch OpenFileDialog"
'			Me.btnDialog.Click += New System.EventHandler(Me.BtnDialogClick)
			' 
			' tbxFilePath
			' 
			Me.tbxFilePath.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			' 
			' 
			' 
			Me.tbxFilePath.Border.Class = "TextBoxBorder"
			Me.tbxFilePath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.tbxFilePath.Location = New System.Drawing.Point(0, 1)
			Me.tbxFilePath.Name = "tbxFilePath"
			Me.tbxFilePath.Size = New System.Drawing.Size(139, 20)
			Me.tbxFilePath.TabIndex = 4
'			Me.tbxFilePath.TextChanged += New System.EventHandler(Me.TbxFilePathTextChanged)
			' 
			' FilePathControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.tbxFilePath)
			Me.Controls.Add(Me.btnDialog)
			Me.Name = "FilePathControl"
			Me.Size = New System.Drawing.Size(163, 23)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Protected Friend WithEvents btnDialog As DevComponents.DotNetBar.ButtonX
		Private WithEvents tbxFilePath As DevComponents.DotNetBar.Controls.TextBoxX

	End Class
End Namespace
