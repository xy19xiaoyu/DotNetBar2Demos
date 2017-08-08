Imports System.Text
Imports DevComponents.DotNetBar

Namespace MetroBill
	''' <summary>
	''' Represents all application commands.
	''' </summary>
	Public Class MetroBillCommands
		Private _ClientCommands As New DocumentCommands()
		''' <summary>
		''' Gets the client related commands.
		''' </summary>
		Public Property ClientCommands() As DocumentCommands
			Get
				Return _ClientCommands
			End Get
			Set(ByVal value As DocumentCommands)
				_ClientCommands = value
			End Set
		End Property

		Private _InvoiceCommands As New DocumentCommands()
		''' <summary>
		''' Gets document related commands.
		''' </summary>
		Public Property InvoiceCommands() As DocumentCommands
			Get
				Return _InvoiceCommands
			End Get
			Set(ByVal value As DocumentCommands)
				_InvoiceCommands = value
			End Set
		End Property

		Private _SlideStartControl As Command
		''' <summary>
		''' Toggles start control visibility.
		''' </summary>
		Public Property ToggleStartControl() As Command
			Get
				Return _SlideStartControl
			End Get
			Set(ByVal value As Command)
				_SlideStartControl = value
			End Set
		End Property

		Private _ChangeMetroTheme As Command
		''' <summary>
		''' Changes the Metro theme.
		''' </summary>
		Public Property ChangeMetroTheme() As Command
			Get
				Return _ChangeMetroTheme
			End Get
			Set(ByVal value As Command)
				_ChangeMetroTheme = value
			End Set
		End Property

		Private _GettingStartedCommand As Command
		Public Property GettingStartedCommand() As Command
			Get
				Return _GettingStartedCommand
			End Get
			Set(ByVal value As Command)
				_GettingStartedCommand = value
			End Set
		End Property

		Private _NotImplemented As Command
		''' <summary>
		''' Not implemented command.
		''' </summary>
		Public Property NotImplemented() As Command
			Get
				Return _NotImplemented
			End Get
			Set(ByVal value As Command)
				_NotImplemented = value
			End Set
		End Property

		Private _DevComponents As Command
		''' <summary>
		''' Open DotNetBar web-site.
		''' </summary>
		Public Property DevComponents() As Command
			Get
				Return _DevComponents
			End Get
			Set(ByVal value As Command)
				_DevComponents = value
			End Set
		End Property
	End Class

	Public Class DocumentCommands
		Private _New As Command
		Public Property [New]() As Command
			Get
				Return _New
			End Get
			Set(ByVal value As Command)
				_New = value
			End Set
		End Property

		Private _Save As Command
		Public Property Save() As Command
			Get
				Return _Save
			End Get
			Set(ByVal value As Command)
				_Save = value
			End Set
		End Property

		Private _Cancel As Command
		Public Property Cancel() As Command
			Get
				Return _Cancel
			End Get
			Set(ByVal value As Command)
				_Cancel = value
			End Set
		End Property
	End Class
End Namespace
