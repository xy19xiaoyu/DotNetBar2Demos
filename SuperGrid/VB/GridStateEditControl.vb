Imports System.ComponentModel
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Namespace SuperGridDemo
	'''<summary>
	''' GridStateEditControl
	'''</summary>
	<ToolboxItem(False)> _
	Public Class GridStateEditControl
		Inherits StateControl
        Implements IGridCellEditControl

#Region "Private variables"

        Private _Cell As GridCell
        Private _EditorPanel As EditorPanel
        Private _EditorCellBitmap As Bitmap

        Private _ValueChanged As Boolean
        Private _SuspendUpdate As Boolean

        Private _StretchBehavior As StretchBehavior = StretchBehavior.None

#End Region

        '''<summary>
        ''' GridStateEditControl
        '''</summary>
        Public Sub New()
            AddHandler StateChanged, AddressOf ControlStateChanged
        End Sub

#Region "ControlStateChanged"

        ''' <summary>
        ''' Routine called when the control 'state' has changed.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub ControlStateChanged(ByVal sender As Object, ByVal e As StateChangedEventArgs)
            If _SuspendUpdate = False Then
                _Cell.Value = e.NewValue

                _Cell.EditorValueChanged(Me)
            End If
        End Sub

#End Region

#Region "OnInvalidated"

        Protected Overrides Sub OnInvalidated(ByVal e As InvalidateEventArgs)
            MyBase.OnInvalidated(e)

            If _Cell IsNot Nothing AndAlso _SuspendUpdate = False Then
                _Cell.InvalidateRender()
            End If
        End Sub

#End Region

#Region "OnPaint"

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            _Cell.PaintEditorBackground(e, Me)

            MyBase.OnPaint(e)
        End Sub

#End Region

#Region "GetValue"

        '''<summary>
        ''' GetValue
        '''</summary>
        '''<param name="value"></param>
        '''<returns></returns>
        '''<exception cref="Exception"></exception>
        Public Overridable Function GetValue(ByVal value As Object) As String
            Dim panel As GridPanel = _Cell.GridPanel

            If value Is Nothing OrElse (panel.NullValue = NullValue.DBNull AndAlso value Is DBNull.Value) Then
                Return ("")
            End If

            Return (Convert.ToString(value))
        End Function

#End Region

#Region "IGridCellEditControl Members"

#Region "Public properties"

#Region "CanInterrupt"

        Public ReadOnly Property CanInterrupt() As Boolean Implements IGridCellEditControl.CanInterrupt
            Get
                Return ((MouseButtons And MouseButtons.Left) <> MouseButtons.Left)
            End Get
        End Property

#End Region

#Region "CellEditMode"

        Public ReadOnly Property CellEditMode() As CellEditMode Implements IGridCellEditControl.CellEditMode
            Get
                Return (CellEditMode.InPlace)
            End Get
        End Property

#End Region

#Region "EditorCell"

        Public Property EditorCell() As GridCell Implements IGridCellEditControl.EditorCell
            Get
                Return (_Cell)
            End Get
            Set(ByVal value As GridCell)
                _Cell = value
            End Set
        End Property

#End Region

#Region "EditorCellBitmap"

        '''<summary>
        ''' EditorCellBitmap
        '''</summary>
        Public Property EditorCellBitmap() As Bitmap Implements IGridCellEditControl.EditorCellBitmap
            Get
                Return (_EditorCellBitmap)
            End Get

            Set(ByVal value As Bitmap)
                If _EditorCellBitmap IsNot Nothing Then
                    _EditorCellBitmap.Dispose()
                End If

                _EditorCellBitmap = value
            End Set
        End Property

#End Region

#Region "EditorFormattedValue"

        '''<summary>
        ''' EditorFormattedValue
        '''</summary>
        Public Overridable ReadOnly Property EditorFormattedValue() As String Implements IGridCellEditControl.EditorFormattedValue
            Get
                Return (Text)
            End Get
        End Property

#End Region

#Region "EditorPanel"

        Public Property EditorPanel() As EditorPanel Implements IGridCellEditControl.EditorPanel
            Get
                Return (_EditorPanel)
            End Get
            Set(ByVal value As EditorPanel)
                _EditorPanel = value
            End Set
        End Property

#End Region

#Region "EditorValue"

        Public Overridable Property EditorValue() As Object Implements IGridCellEditControl.EditorValue
            Get
                Return (Value)
            End Get
            Set(ByVal value As Object)
                value = GetValue(value)
            End Set
        End Property

#End Region

#Region "EditorValueChanged"

        Public Overridable Property EditorValueChanged() As Boolean Implements IGridCellEditControl.EditorValueChanged
            Get
                Return (_ValueChanged)
            End Get

            Set(ByVal value As Boolean)
                If _ValueChanged <> value Then
                    _ValueChanged = value

                    If value = True Then
                        _Cell.SetEditorDirty(Me)
                    End If
                End If
            End Set
        End Property

#End Region

#Region "EditorValueType"

        '''<summary>
        ''' EditorValueType
        '''</summary>
        Public Overridable ReadOnly Property EditorValueType() As Type Implements IGridCellEditControl.EditorValueType
            Get
                Return (GetType(String))
            End Get
        End Property

#End Region

#Region "StretchBehavior"

        Public Overridable ReadOnly Property StretchBehavior() As StretchBehavior Implements IGridCellEditControl.StretchBehavior
            Get
                Return (_StretchBehavior)
            End Get
        End Property

#End Region

#Region "SuspendUpdate"

        Public Property SuspendUpdate() As Boolean Implements IGridCellEditControl.SuspendUpdate
            Get
                Return (_SuspendUpdate)
            End Get
            Set(ByVal value As Boolean)
                _SuspendUpdate = value
            End Set
        End Property

#End Region

#Region "ValueChangeBehavior"

        Public Overridable ReadOnly Property ValueChangeBehavior() As ValueChangeBehavior Implements IGridCellEditControl.ValueChangeBehavior
            Get
                Return (ValueChangeBehavior.InvalidateLayout)
            End Get
        End Property

#End Region

#End Region

#Region "InitializeContext"

        '''<summary>
        ''' InitializeContext
        '''</summary>
        '''<param name="cell"></param>
        '''<param name="style"></param>
        Public Overridable Sub InitializeContext(ByVal cell As GridCell, ByVal style As CellVisualStyle) Implements IGridCellEditControl.InitializeContext
            _Cell = cell

            Value = GetValue(_Cell.Value)
            Enabled = (_Cell.IsReadOnly = False)

            _ValueChanged = False
        End Sub

#End Region

#Region "GetProposedSize"

        '''<summary>
        ''' GetProposedSize
        '''</summary>
        '''<param name="g"></param>
        '''<param name="cell"></param>
        '''<param name="style"></param>
        '''<param name="constraintSize"></param>
        '''<returns></returns>
        Public Overridable Function GetProposedSize(ByVal g As Graphics, ByVal cell As GridCell, ByVal style As CellVisualStyle, ByVal constraintSize As Size) As Size Implements IGridCellEditControl.GetProposedSize
            Return (GetPreferredSize(constraintSize))
        End Function

#End Region

#Region "Edit support"

#Region "BeginEdit"

        Public Overridable Function BeginEdit(ByVal selectAll As Boolean) As Boolean Implements IGridCellEditControl.BeginEdit
            Return (False)
        End Function

#End Region

#Region "EndEdit"

        Public Overridable Function EndEdit() As Boolean Implements IGridCellEditControl.EndEdit
            Return (False)
        End Function

#End Region

#Region "CancelEdit"

        Public Overridable Function CancelEdit() As Boolean Implements IGridCellEditControl.CancelEdit
            Return (False)
        End Function

#End Region

#End Region

#Region "CellRender"

        Public Overridable Sub CellRender(ByVal g As Graphics) Implements IGridCellEditControl.CellRender
            _Cell.CellRender(Me, g)
        End Sub

#End Region

#Region "Keyboard support"

#Region "CellKeyDown"

        '''<summary>
        ''' CellKeyDown
        '''</summary>
        Public Overridable Sub CellKeyDown(ByVal e As KeyEventArgs) Implements IGridCellEditControl.CellKeyDown
            ' If the user types a digit (0 - 9) then increment
            ' the state color by 1 at that state offset

            If e.KeyData >= Keys.D0 AndAlso e.KeyData <= Keys.D9 Then
                Dim index As Integer = e.KeyData - Keys.D0
                Dim value As String = DirectCast(EditorCell.Value, String)
                Dim s As String() = value.Split(","c)

                Dim k As Integer = Math.Max(index + 1, s.Length)
                Dim n As Integer() = New Integer(k - 1) {}

                For i As Integer = 0 To k - 1
                    If i < s.Length Then
                        n(i) = Val(s(i)(0))
                    Else
                        n(i) = 0
                    End If
                Next

                n(index) = (n(index) + 1) Mod 5

                Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder()

                For i As Integer = 0 To k - 1
                    sb.Append(n(i))
                    sb.Append(",")
                Next

                sb.Length -= 1

                EditorCell.Value = sb.ToString()
            Else
                OnKeyDown(e)
            End If
        End Sub

#End Region

#Region "WantsInputKey"

        Public Overridable Function WantsInputKey(ByVal key As Keys, ByVal gridWantsKey As Boolean) As Boolean Implements IGridCellEditControl.WantsInputKey
            ' Lets handle all the digit keys

            If key >= Keys.D0 AndAlso key <= Keys.D9 Then
                Return (True)
            End If

            ' And let the grid handle the rest

            Return (gridWantsKey = False)
        End Function


#End Region

#End Region

#Region "Mouse support"

#Region "OnCellMouseMove"

        '''<summary>
        ''' OnCellMouseMove
        '''</summary>
        '''<param name="e"></param>
        Public Overridable Sub OnCellMouseMove(ByVal e As MouseEventArgs) Implements IGridCellEditControl.OnCellMouseMove
            OnMouseMove(e)
        End Sub

#End Region

#Region "OnCellMouseEnter"

        '''<summary>
        ''' OnCellMouseEnter
        '''</summary>
        '''<param name="e"></param>
        Public Overridable Sub OnCellMouseEnter(ByVal e As EventArgs) Implements IGridCellEditControl.OnCellMouseEnter
            OnMouseEnter(e)
        End Sub

#End Region

#Region "OnCellMouseLeave"

        '''<summary>
        ''' OnCellMouseLeave
        '''</summary>
        '''<param name="e"></param>
        Public Overridable Sub OnCellMouseLeave(ByVal e As EventArgs) Implements IGridCellEditControl.OnCellMouseLeave
            OnMouseLeave(e)
        End Sub

#End Region

#Region "OnCellMouseUp"

        '''<summary>
        ''' OnCellMouseUp
        '''</summary>
        '''<param name="e"></param>
        Public Overridable Sub OnCellMouseUp(ByVal e As MouseEventArgs) Implements IGridCellEditControl.OnCellMouseUp
            OnMouseUp(e)
        End Sub

#End Region

#Region "OnCellMouseDown"

        '''<summary>
        ''' OnCellMouseDown
        '''</summary>
        '''<param name="e"></param>
        Public Overridable Sub OnCellMouseDown(ByVal e As MouseEventArgs) Implements IGridCellEditControl.OnCellMouseDown
            OnMouseDown(e)
        End Sub

#End Region

#End Region

#End Region

    End Class
End Namespace
