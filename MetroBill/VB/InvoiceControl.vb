Imports System.ComponentModel
Imports System.Text

Namespace MetroBill
	Partial Public Class InvoiceControl
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private _Commands As MetroBillCommands
		''' <summary>
		''' Gets or sets the commands associated with the control.
		''' </summary>
		Public Property Commands() As MetroBillCommands
			Get
				Return _Commands
			End Get
			Set(ByVal value As MetroBillCommands)
				If value IsNot _Commands Then
					Dim oldValue As MetroBillCommands = _Commands
					_Commands = value
					OnCommandsChanged(oldValue, value)
				End If
			End Set
		End Property
		''' <summary>
		''' Called when Commands property has changed.
		''' </summary>
		''' <param name="oldValue">Old property value</param>
		''' <param name="newValue">New property value</param>
		Protected Overridable Sub OnCommandsChanged(ByVal oldValue As MetroBillCommands, ByVal newValue As MetroBillCommands)
			If newValue IsNot Nothing Then
				saveButton.Command = newValue.InvoiceCommands.Save
				cancelButton.Command = newValue.InvoiceCommands.Cancel
			Else
				saveButton.Command = Nothing
				cancelButton.Command = Nothing
			End If
		End Sub
	End Class
End Namespace
