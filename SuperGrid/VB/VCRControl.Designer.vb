Namespace SuperGridDemo
	Partial Public Class VcrControl
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(VcrControl))
			Me.btnFirst = New Button()
			Me.imageList1 = New ImageList(Me.components)
			Me.btnLast = New Button()
			Me.btnPrevious = New Button()
			Me.btnNext = New Button()
			Me.label_Renamed = New Label()
			Me.leftPanel = New Panel()
			Me.rightPanel = New Panel()
			Me.leftPanel.SuspendLayout()
			Me.rightPanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' btnFirst
			' 
			Me.btnFirst.AutoSize = True
			Me.btnFirst.Dock = DockStyle.Left
			Me.btnFirst.ImageKey = "First"
			Me.btnFirst.ImageList = Me.imageList1
			Me.btnFirst.Location = New Point(0, 0)
			Me.btnFirst.Name = "btnFirst"
			Me.btnFirst.Size = New Size(33, 36)
			Me.btnFirst.TabIndex = 0
			Me.btnFirst.UseVisualStyleBackColor = True
'			Me.btnFirst.Click += New System.EventHandler(Me.BtnFirstClick)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), ImageListStreamer))
			Me.imageList1.TransparentColor = Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "First")
			Me.imageList1.Images.SetKeyName(1, "Last")
			Me.imageList1.Images.SetKeyName(2, "Next")
			Me.imageList1.Images.SetKeyName(3, "Previous")
			' 
			' btnLast
			' 
			Me.btnLast.AutoSize = True
			Me.btnLast.Dock = DockStyle.Right
			Me.btnLast.ImageKey = "Last"
			Me.btnLast.ImageList = Me.imageList1
			Me.btnLast.Location = New Point(35, 0)
			Me.btnLast.Name = "btnLast"
			Me.btnLast.Size = New Size(33, 36)
			Me.btnLast.TabIndex = 1
			Me.btnLast.UseVisualStyleBackColor = True
'			Me.btnLast.Click += New System.EventHandler(Me.BtnLastClick)
			' 
			' btnPrevious
			' 
			Me.btnPrevious.AutoSize = True
			Me.btnPrevious.Dock = DockStyle.Right
			Me.btnPrevious.ImageKey = "Previous"
			Me.btnPrevious.ImageList = Me.imageList1
			Me.btnPrevious.Location = New Point(35, 0)
			Me.btnPrevious.Name = "btnPrevious"
			Me.btnPrevious.Size = New Size(33, 36)
			Me.btnPrevious.TabIndex = 2
			Me.btnPrevious.UseVisualStyleBackColor = True
'			Me.btnPrevious.Click += New System.EventHandler(Me.BtnPreviousClick)
			' 
			' btnNext
			' 
			Me.btnNext.AutoSize = True
			Me.btnNext.Dock = DockStyle.Left
			Me.btnNext.ImageKey = "Next"
			Me.btnNext.ImageList = Me.imageList1
			Me.btnNext.Location = New Point(0, 0)
			Me.btnNext.Name = "btnNext"
			Me.btnNext.Size = New Size(33, 36)
			Me.btnNext.TabIndex = 3
			Me.btnNext.UseVisualStyleBackColor = True
'			Me.btnNext.Click += New System.EventHandler(Me.BtnNextClick)
			' 
			' label
			' 
			Me.label_Renamed.Dock = DockStyle.Fill
			Me.label_Renamed.Location = New Point(68, 0)
			Me.label_Renamed.Name = "label"
			Me.label_Renamed.Size = New Size(174, 36)
			Me.label_Renamed.TabIndex = 4
			Me.label_Renamed.TextAlign = ContentAlignment.MiddleCenter
			' 
			' leftPanel
			' 
			Me.leftPanel.Controls.Add(Me.btnFirst)
			Me.leftPanel.Controls.Add(Me.btnPrevious)
			Me.leftPanel.Dock = DockStyle.Left
			Me.leftPanel.Location = New Point(0, 0)
			Me.leftPanel.Name = "leftPanel"
			Me.leftPanel.Size = New Size(68, 36)
			Me.leftPanel.TabIndex = 5
			' 
			' rightPanel
			' 
			Me.rightPanel.Controls.Add(Me.btnNext)
			Me.rightPanel.Controls.Add(Me.btnLast)
			Me.rightPanel.Dock = DockStyle.Right
			Me.rightPanel.Location = New Point(242, 0)
			Me.rightPanel.Name = "rightPanel"
			Me.rightPanel.Size = New Size(68, 36)
			Me.rightPanel.TabIndex = 6
			' 
			' VcrControl
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.Transparent
			Me.Controls.Add(Me.label_Renamed)
			Me.Controls.Add(Me.rightPanel)
			Me.Controls.Add(Me.leftPanel)
			Me.Name = "VcrControl"
			Me.Size = New Size(310, 36)
			Me.leftPanel.ResumeLayout(False)
			Me.leftPanel.PerformLayout()
			Me.rightPanel.ResumeLayout(False)
			Me.rightPanel.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents btnFirst As Button
		Private WithEvents btnLast As Button
		Private WithEvents btnPrevious As Button
		Private WithEvents btnNext As Button
		Private imageList1 As ImageList
'INSTANT VB NOTE: The variable label was renamed since Visual Basic does not allow class members with the same name:
		Private label_Renamed As Label
		Private leftPanel As Panel
		Private rightPanel As Panel

	End Class
End Namespace
