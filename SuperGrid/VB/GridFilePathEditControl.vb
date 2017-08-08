Imports System.ComponentModel
Imports System.IO
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.SuperGrid.Style

Namespace SuperGridDemo
	<ToolboxItem(False)> _
	Public Class GridFilePathEditControl
		Inherits FilePathControl
        Implements IGridCellEditControl

#Region "Private variables"

        Private _Cell As GridCell
        Private _EditorPanel As EditorPanel
        Private _EditorCellBitmap As Bitmap

        Private _ValueChanged As Boolean
        Private _SuspendUpdate As Boolean

        Private _StretchBehavior As StretchBehavior = StretchBehavior.HorizontalOnly

#End Region

        '''<summary>
        ''' GridClipEditControl
        '''</summary>
        Public Sub New()
            AutoSizeMode = AutoSizeMode.GrowAndShrink

            btnDialog.ColorTable = eButtonColor.OrangeWithBackground
            btnDialog.Style = eDotNetBarStyle.StyleManagerControlled

            AddHandler FilePathChanged, AddressOf GridFilePathChanged
        End Sub

#Region "GridFilePathChanged"

        Private Sub GridFilePathChanged(ByVal sender As Object, ByVal e As FilePathChangedEventArgs)
            If _SuspendUpdate = False Then
                _Cell.Value = e.NewFilePath

                _Cell.EditorValueChanged(Me)
            End If
        End Sub

#End Region

#Region "OnPaintBackground"

        ''' <summary>
        ''' Handles background painting.
        ''' </summary>
        ''' <param name="e"></param>
        Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)
            ' Perform default cell background painting

            _Cell.PaintEditorBackground(e, Me)
        End Sub

#End Region

#Region "GetValue"

        ''' <summary>
        ''' Gets the control 'value'
        ''' from the supplied cell value.
        ''' </summary>
        ''' <param name="value"></param>
        ''' <returns></returns>
        Public Overridable Function GetValue(ByVal value As Object) As String
            Dim panel As GridPanel = _Cell.GridPanel

            If value Is Nothing OrElse (panel.NullValue = NullValue.DBNull AndAlso value Is DBNull.Value) Then
                Return ("")
            End If

            If _Cell.IsValueExpression = True Then
                value = _Cell.GetExpValue(CStr(value))
            End If

            Return (Convert.ToString(value))
        End Function

#End Region

#Region "SetValue"

        ''' <summary>
        ''' Sets the control value from the cell value.
        ''' </summary>
        ''' <param name="s"></param>
        Private Sub SetValue(ByVal s As String)
            Text = s
        End Sub

#End Region

#Region "IGridCellEditControl Members"

#Region "Public properties"

#Region "CanInterrupt"

        Public ReadOnly Property CanInterrupt() As Boolean Implements IGridCellEditControl.CanInterrupt
            Get
                Return (True)
            End Get
        End Property

#End Region

#Region "CellEditMode"

        Public ReadOnly Property CellEditMode() As CellEditMode Implements IGridCellEditControl.CellEditMode
            Get
                Return (CellEditMode.Modal)
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
                If String.IsNullOrEmpty(Text) = True Then
                    Return ("")
                End If

                Return (" " & Path.GetFileNameWithoutExtension(Text))
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
                Return (Text)
            End Get
            Set(ByVal value As Object)
                SetValue(GetValue(value))
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
                Return (ValueChangeBehavior.InvalidateRender)
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

            SetValue(GetValue(_Cell.Value))

            Enabled = (_Cell.ReadOnly = False)

            Font = style.Font
            ForeColor = style.TextColor

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
            Return (Size)
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
            Focus()

            Select Case e.KeyData
                Case Else
                    OnKeyDown(e)
            End Select
        End Sub

#End Region

#Region "WantsInputKey"

        Public Overridable Function WantsInputKey(ByVal key As Keys, ByVal gridWantsKey As Boolean) As Boolean Implements IGridCellEditControl.WantsInputKey
            Select Case key And Keys.KeyCode
                Case Keys.Space, Keys.Up, Keys.Down
                    Return (True)

                Case Else
                    Return (gridWantsKey = False)
            End Select
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
            Refresh()
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
