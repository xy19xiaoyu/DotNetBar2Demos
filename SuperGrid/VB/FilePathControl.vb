Imports System.ComponentModel
Imports System.IO

Namespace SuperGridDemo
	Partial Public Class FilePathControl
		Inherits UserControl
		#Region "Events"

		#Region "FilePathChanged"

		''' <summary>
		''' Occurs when the FilePath has Changed
		''' </summary>
		<Description("Occurs when the FilePath has Changed.")> _
		Public Event FilePathChanged As EventHandler(Of FilePathChangedEventArgs)

		#End Region

		#End Region

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
				If (Text IsNot Nothing AndAlso Text.Equals(value) = False) OrElse (Text Is Nothing AndAlso Text <> value) Then
					Dim oldValue As String = Text

					If value Is Nothing Then
						tbxFilePath.Text = ""
					Else
						tbxFilePath.Text = Path.GetFileNameWithoutExtension(value)
					End If

					OnFilePathChanged(oldValue, value)
				End If

				MyBase.Text = value
			End Set
		End Property

		#Region "OnFilePathChanged"

		''' <summary>
		''' Handles listener notification that the
		''' file path has changed
		''' </summary>
		''' <param name="oldPath"></param>
		''' <param name="newPath"></param>
		Private Sub OnFilePathChanged(ByVal oldPath As String, ByVal newPath As String)
			RaiseEvent FilePathChanged(Me, New FilePathChangedEventArgs(oldPath, newPath))
		End Sub

		#End Region

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
				tbxFilePath.Font = value

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
				tbxFilePath.ForeColor = value

				MyBase.ForeColor = value
			End Set
		End Property

		#End Region

		#Region "BtnDialogClick"

		''' <summary>
		''' Handles click event to initiate the OpenFile dialog
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub BtnDialogClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnDialog.Click
			Dim ofd As New OpenFileDialog()

			Dim result As DialogResult = ofd.ShowDialog()

			If result = DialogResult.OK Then
				Text = ofd.FileName
			End If
		End Sub

		#End Region

		#Region "TbxFilePathTextChanged"

		''' <summary>
		''' Handles the change events in the
		''' TextBox portion of the control.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub TbxFilePathTextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbxFilePath.TextChanged
			If tbxFilePath.Focused = True Then
				Text = tbxFilePath.Text
			End If
		End Sub

		#End Region

		#End Region
	End Class

	#Region "FilePathChangedEventArgs"

	''' <summary>
	''' FilePathChangedEventArgs
	''' </summary>
	Public Class FilePathChangedEventArgs
		Inherits EventArgs
		#Region "Private variables"

		Private _OldFilePath As String
		Private _NewFilePath As String

		#End Region

		'''<summary>
		''' GridAfterCheckEventArgs
		'''</summary>
		'''<param name="oldFilePath"></param>
		'''<param name="newFilePath"></param>
		Public Sub New(ByVal oldFilePath As String, ByVal newFilePath As String)
			_OldFilePath = oldFilePath
			_NewFilePath = newFilePath
		End Sub

		#Region "Public properties"

		''' <summary>
		''' Gets the new file path
		''' </summary>
		Public ReadOnly Property NewFilePath() As String
			Get
				Return (_NewFilePath)
			End Get
		End Property

		''' <summary>
		''' Gets the old file path
		''' </summary>
		Public ReadOnly Property OldFilePath() As String
			Get
				Return (_OldFilePath)
			End Get
		End Property

		#End Region
	End Class

	#End Region

End Namespace
