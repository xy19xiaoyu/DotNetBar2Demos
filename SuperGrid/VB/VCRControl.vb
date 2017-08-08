Imports System.ComponentModel

Namespace SuperGridDemo
	Partial Public Class VcrControl
		Inherits UserControl
		#Region "Events"

		#Region "FirstClick"

		''' <summary>
		''' Occurs when the 'First' button has been clicked
		''' </summary>
		<Description("Occurs when a cell has been clicked.")> _
		Public Event FirstClick As EventHandler(Of EventArgs)

		#End Region

		#Region "PreviousClick"

		''' <summary>
		''' Occurs when the 'Previous' button has been clicked
		''' </summary>
		<Description("Occurs when the 'Previous' button has been clicked.")> _
		Public Event PreviousClick As EventHandler(Of EventArgs)

		#End Region

		#Region "NextClick"

		''' <summary>
		''' Occurs when the 'Next' button has been clicked
		''' </summary>
		<Description("Occurs when the 'Next' button has been clicked.")> _
		Public Event NextClick As EventHandler(Of EventArgs)

		#End Region

		#Region "LastClick"

		''' <summary>
		''' Occurs when the 'Last' button has been clicked
		''' </summary>
		<Description("Occurs when the 'Last' button has been clicked.")> _
		Public Event LastClick As EventHandler(Of EventArgs)

		#End Region

		#End Region

		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "Public properties"

		Public ReadOnly Property Label() As Label
			Get
				Return (label_Renamed)
			End Get
		End Property

		Public ReadOnly Property FirstButton() As Button
			Get
				Return (btnFirst)
			End Get
		End Property

		Public ReadOnly Property PreviousButton() As Button
			Get
				Return (btnPrevious)
			End Get
		End Property

		Public ReadOnly Property NextButton() As Button
			Get
				Return (btnNext)
			End Get
		End Property

		Public ReadOnly Property LastButton() As Button
			Get
				Return (btnLast)
			End Get
		End Property

		#End Region

		#Region "Button events"

		Private Sub BtnFirstClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
			RaiseEvent FirstClick(Me, EventArgs.Empty)
		End Sub

		Private Sub BtnPreviousClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
			RaiseEvent PreviousClick(Me, EventArgs.Empty)
		End Sub

		Private Sub BtnNextClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			RaiseEvent NextClick(Me, EventArgs.Empty)
		End Sub

		Private Sub BtnLastClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
			RaiseEvent LastClick(Me, EventArgs.Empty)
		End Sub

		#End Region
	End Class
End Namespace
