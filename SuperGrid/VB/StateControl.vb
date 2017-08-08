Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Text

Namespace SuperGridDemo
	Partial Public Class StateControl
		Inherits Control
		#Region "Events"

		#Region "StateChanged"

		''' <summary>
		''' Occurs when the control state has changed
		''' </summary>
		<Description("Occurs when the control state has changed.")> _
		Public Event StateChanged As EventHandler(Of StateChangedEventArgs)

		#End Region

		#End Region

		#Region "Private variables"

		Private _States() As MyState

		Private _HitItem As MyState
		Private _LastHitItem As MyState
		Private _MouseDownItem As MyState

		Private _Value As String
		Private _NeedRecalc As Boolean
		Private _PreferredSize As Size

		#End Region

		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "Public properties"

		#Region "Value"

		''' <summary>
		''' Gets or sets the comma delimited state string.
		''' </summary>
		Protected Property Value() As String
			Get
				If _Value Is Nothing Then
					_Value = GetStates()
				End If

				Return (_Value)
			End Get

			Set(ByVal value As String)
				If (value IsNot Nothing AndAlso value.Equals(_Value) = False) OrElse (value Is Nothing AndAlso value <> _Value) Then
					_Value = value

					SetStates(value)
				End If
			End Set
		End Property

		#Region "GetStates"

		''' <summary>
		''' Gets the states "string" value.
		''' </summary>
		''' <returns></returns>
		Private Function GetStates() As String
			Dim sb As New StringBuilder()

			If _States IsNot Nothing Then
				For Each state As MyState In _States
					sb.Append(state.ColorIndex)
					sb.Append(",")
				Next state

				If sb.Length > 0 Then
					sb.Length -= 1
				End If
			End If

			Return (sb.ToString())
		End Function

		#End Region

		#Region "SetStates"

		''' <summary>
		''' Sets the states "string" value
		''' </summary>
		''' <param name="value"></param>
		Private Sub SetStates(ByVal value As String)
			If value Is Nothing Then
				_States = Nothing
			Else
				Dim states() As String = value.Split(","c)

				_States = New MyState(states.Length - 1){}

				Dim i As Integer = 0
				For Each s As String In states
					Dim n As Integer
					Integer.TryParse(s, n)

					_States(i) = New MyState(n)
					i += 1
				Next s
			End If

			_NeedRecalc = True
		End Sub

		#End Region

		#End Region

		#End Region

		#Region "OnPaint"

		''' <summary>
		''' Handles paint event requests
		''' </summary>
		''' <param name="e"></param>
		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			If _States IsNot Nothing Then
				If _NeedRecalc = True Then
					RecalcLayout()
				End If

				Dim g As Graphics = e.Graphics
				g.SmoothingMode = SmoothingMode.AntiAlias

				For Each state As MyState In _States
					Dim r As Rectangle = state.Bounds

					If _HitItem Is state Then
						r.Inflate(1, 1)
					End If

					Dim index As Integer = state.ColorIndex

					If CUInt(index) >= imageList1.Images.Count Then
						index = 0
					End If

					g.DrawImageUnscaledAndClipped(imageList1.Images(index), r)
				Next state
			End If
		End Sub

		#End Region

		#Region "RecalcLayout"

		''' <summary>
		''' Recalculates the states layout
		''' </summary>
		Private Sub RecalcLayout()
			_PreferredSize = Bounds.Size

			If _States IsNot Nothing Then
				Dim r As Rectangle = Bounds
				r.Inflate(-2, -2)
				r.Width = 16

				r.Y += (r.Height - 16)\2
				r.Height = 16

				For Each state As MyState In _States
					state.Bounds = r

					r.X += 18
				Next state

				_PreferredSize.Width = r.X - Bounds.X
			End If

			_NeedRecalc = False
		End Sub

		#End Region

		#Region "GetPreferredSize"

		''' <summary>
		''' Gets the control's preferred size
		''' </summary>
		''' <param name="proposedSize"></param>
		''' <returns></returns>
		Public Overrides Function GetPreferredSize(ByVal proposedSize As Size) As Size
			If _NeedRecalc = True Then
				RecalcLayout()
			End If

			Return (_PreferredSize)
		End Function

		#End Region

		#Region "Mouse support"

		#Region "OnMouseMove"

		''' <summary>
		''' Handles MouseMove events
		''' </summary>
		''' <param name="e"></param>
		Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
			MyBase.OnMouseMove(e)

			_HitItem = GetHitItem(e.Location)

			If _HitItem IsNot _LastHitItem Then
				_LastHitItem = _HitItem

				Invalidate()
			End If
		End Sub

		#Region "GetHitItem"

		''' <summary>
		''' Gets the item currently under the mouse
		''' </summary>
		''' <param name="pt"></param>
		''' <returns></returns>
		Private Function GetHitItem(ByVal pt As Point) As MyState
			If _States IsNot Nothing Then
				For Each state As MyState In _States
					If state.Bounds.Contains(pt) = True Then
						Return (state)
					End If
				Next state
			End If

			Return (Nothing)
		End Function

		#End Region

		#End Region

		#Region "OnMouseDown"

		''' <summary>
		''' Handles MouseDown events
		''' </summary>
		''' <param name="e"></param>
		Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
			MyBase.OnMouseDown(e)

			_MouseDownItem = _HitItem
		End Sub

		#End Region

		#Region "OnMouseUp"

		''' <summary>
		''' Handles MouseUp events
		''' </summary>
		''' <param name="e"></param>
		Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
			' Change the state colorIndex
			' if the user clicked on an item.

			If _MouseDownItem IsNot Nothing AndAlso _MouseDownItem Is _HitItem Then
				_MouseDownItem.ColorIndex = (_MouseDownItem.ColorIndex + 1) Mod imageList1.Images.Count

				OnValueChanged()
			End If

			_MouseDownItem = Nothing

			MyBase.OnMouseUp(e)
		End Sub

		#Region "OnValueChanged"

		''' <summary>
		''' OnValueChanged
		''' </summary>
		Private Sub OnValueChanged()
			Dim oldValue As String = Value

			_Value = Nothing

			RaiseEvent StateChanged(Me, New StateChangedEventArgs(oldValue, Value))
		End Sub

		#End Region

		#End Region

		#End Region
	End Class

	#Region "StateChangedEventArgs"

	''' <summary>
	''' StateChangedEventArgs
	''' </summary>
	Public Class StateChangedEventArgs
		Inherits EventArgs
		#Region "Private variables"

		Private _OldValue As String
		Private _NewValue As String

		#End Region

		'''<summary>
		''' StateChangedEventArgs
		'''</summary>
		'''<param name="oldValue"></param>
		'''<param name="newValue"></param>
		Public Sub New(ByVal oldValue As String, ByVal newValue As String)
			_OldValue = oldValue
			_NewValue = newValue
		End Sub

		#Region "Public properties"

		''' <summary>
		''' Gets the old value
		''' </summary>
		Public ReadOnly Property OldValue() As String
			Get
				Return (_OldValue)
			End Get
		End Property

		''' <summary>
		''' Gets the new value
		''' </summary>
		Public ReadOnly Property NewValue() As String
			Get
				Return (_NewValue)
			End Get
		End Property

		#End Region
	End Class

	#End Region

	#Region "MyState"

	Public Class MyState
		#Region "Private variables"

		Private _ColorIndex As Integer
		Private _Bounds As Rectangle

		#End Region

		Public Sub New(ByVal colorIndex As Integer)
			_ColorIndex = colorIndex
		End Sub

		#Region "Public properties"

		#Region "Bounds"

		''' <summary>
		''' Gets the state bounding rect
		''' </summary>
		Public Property Bounds() As Rectangle
			Get
				Return (_Bounds)
			End Get
			Friend Set(ByVal value As Rectangle)
				_Bounds = value
			End Set
		End Property

		#End Region

		#Region "ColorIndex"

		''' <summary>
		''' Gets or sets the state color index
		''' </summary>
		Public Property ColorIndex() As Integer
			Get
				Return (_ColorIndex)
			End Get
			Set(ByVal value As Integer)
				_ColorIndex = value
			End Set
		End Property

		#End Region

		#End Region
	End Class

	#End Region
End Namespace
