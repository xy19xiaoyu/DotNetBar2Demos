Namespace SuperGridDemo
	Partial Public Class StateControl
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(StateControl))
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.SuspendLayout()
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "Gray")
			Me.imageList1.Images.SetKeyName(1, "Blue")
			Me.imageList1.Images.SetKeyName(2, "Green")
			Me.imageList1.Images.SetKeyName(3, "Yellow")
			Me.imageList1.Images.SetKeyName(4, "Red")
			' 
			' StateControl
			' 
			Me.Name = "StateControl"
			Me.Size = New System.Drawing.Size(90, 20)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private imageList1 As System.Windows.Forms.ImageList

	End Class
End Namespace
