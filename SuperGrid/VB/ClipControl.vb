Namespace SuperGridDemo
	Partial Public Class ClipControl
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "Public properties"

		#Region "Text"

		''' <summary>
		''' Gets or sets the control text
		''' </summary>
		Public Overrides Property Text() As String
			Get
				Return (MyBase.Text)
			End Get

			Set(ByVal value As String)
				labelX1.Text = value

				MyBase.Text = value
			End Set
		End Property

		#End Region

		#Region "Font"

		''' <summary>
		''' Gets or sets the control font
		''' </summary>
		Public Overrides Property Font() As Font
			Get
				Return (MyBase.Font)
			End Get

			Set(ByVal value As Font)
				labelX1.Font = value

				MyBase.Font = value
			End Set
		End Property

		#End Region

		#Region "ForeColor"

		''' <summary>
		''' Gets or sets the control fore color
		''' </summary>
		Public Overrides Property ForeColor() As Color
			Get
				Return (MyBase.ForeColor)
			End Get

			Set(ByVal value As Color)
				labelX1.ForeColor = value

				MyBase.ForeColor = value
			End Set
		End Property

		#End Region

		#End Region
	End Class
End Namespace
