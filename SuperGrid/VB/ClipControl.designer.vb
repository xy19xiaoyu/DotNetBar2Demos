Namespace SuperGridDemo
	Partial Public Class ClipControl
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ClipControl))
			Me.labelX1 = New DevComponents.DotNetBar.LabelX()
			Me.btnPlay = New DevComponents.DotNetBar.ButtonX()
			Me.btnStop = New DevComponents.DotNetBar.ButtonX()
			Me.SuspendLayout()
			' 
			' labelX1
			' 
			Me.labelX1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.labelX1.BackColor = System.Drawing.Color.Transparent
			' 
			' 
			' 
			Me.labelX1.BackgroundStyle.Class = ""
			Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
			Me.labelX1.Location = New System.Drawing.Point(5, 0)
			Me.labelX1.Name = "labelX1"
			Me.labelX1.Size = New System.Drawing.Size(60, 20)
			Me.labelX1.TabIndex = 2
			Me.labelX1.Text = "labelX1"
			' 
			' btnPlay
			' 
			Me.btnPlay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
			Me.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Right
			Me.btnPlay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
			Me.btnPlay.Image = (CType(resources.GetObject("btnPlay.Image"), System.Drawing.Image))
			Me.btnPlay.Location = New System.Drawing.Point(65, 2)
			Me.btnPlay.Name = "btnPlay"
			Me.btnPlay.Size = New System.Drawing.Size(16, 16)
			Me.btnPlay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.btnPlay.TabIndex = 1
			Me.btnPlay.Tooltip = "Play Audio Clip"
			' 
			' btnStop
			' 
			Me.btnStop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
			Me.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Right
			Me.btnStop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
			Me.btnStop.Image = (CType(resources.GetObject("btnStop.Image"), System.Drawing.Image))
			Me.btnStop.Location = New System.Drawing.Point(83, 2)
			Me.btnStop.Name = "btnStop"
			Me.btnStop.Size = New System.Drawing.Size(16, 16)
			Me.btnStop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
			Me.btnStop.TabIndex = 3
			Me.btnStop.Tooltip = "Stop Audio Clip"
			' 
			' ClipControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.btnStop)
			Me.Controls.Add(Me.labelX1)
			Me.Controls.Add(Me.btnPlay)
			Me.Name = "ClipControl"
			Me.Size = New System.Drawing.Size(100, 20)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Protected Friend btnPlay As DevComponents.DotNetBar.ButtonX
		Protected Friend labelX1 As DevComponents.DotNetBar.LabelX
		Protected Friend btnStop As DevComponents.DotNetBar.ButtonX

	End Class
End Namespace
