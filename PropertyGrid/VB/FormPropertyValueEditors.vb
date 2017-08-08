Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar

Partial Public Class FormPropertyValueEditors
    Inherits Office2007Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FormPropertyValueEditors_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Property setting applies to property name: TrackBarDynamic
        Dim propertySetting As New PropertySettings("TrackBarDynamic")
        ' Assign our custom property value editor
        propertySetting.ValueEditor = New TrackBarPropertyEditor(0, 100)
        advPropertyGrid1.PropertySettings.Add(propertySetting)

        Dim custom As New CustomClass()
        AddHandler custom.PropertyChanged, AddressOf CustomClassPropertyChanged
        advPropertyGrid1.SelectedObject = custom
    End Sub

    Private Sub CustomClassPropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
        Console.WriteLine("Property Change {0}, Value: {1}", e.PropertyName, TypeDescriptor.GetProperties(advPropertyGrid1.SelectedObject)(e.PropertyName).GetValue(advPropertyGrid1.SelectedObject))
    End Sub
End Class

''' <summary>
''' Defines the custom attribute that can be used to decorate properties
''' or assigned to property settings.
''' </summary>
Public Class TrackBarPropertyEditor
    Inherits PropertyValueEditor
    ''' <summary>
    ''' Minimum track bar value.
    ''' </summary>
    Public Minimum As Integer = 0
    ''' <summary>
    ''' Maximum track bar value.
    ''' </summary>
    Public Maximum As Integer = 100

    ''' <summary>
    ''' Initializes a new instance of the TrackBarPropertyEditor class.
    ''' </summary>
    ''' <param name="minimum"></param>
    ''' <param name="maximum"></param>
    Public Sub New(ByVal minimum As Integer, ByVal maximum As Integer)
        Me.Minimum = minimum
        Me.Maximum = maximum
    End Sub

    ''' <summary>
    ''' Creates the control that is used in AdvPropertyGrid to edit property value.
    ''' </summary>
    Public Overrides Function CreateEditor(ByVal propertyDescriptor_Renamed As PropertyDescriptor, ByVal targetObject As Object) As IPropertyValueEditor
        ' We use custom control that implements IPropertyValueEditor interface
        Dim editor As New TrackBarEditor()
        editor.Minimum = Minimum
        editor.Maximum = Maximum

        editor.TickStyle = TickStyle.None
        editor.AutoSize = False
        editor.Height = 20

        Return editor
    End Function

    ''' <summary>
    ''' This is actual control that is used in AdvPropertyGrid to edit value.
    ''' It must inherit from System.Windows.Forms.Control or its descendants.
    ''' </summary>
    Private Class TrackBarEditor
        Inherits TrackBar
        Implements IPropertyValueEditor
#Region "IPropertyValueEditor Members - This interface must be implemented so control can be used by AdvPropertyGrid"
        ''' <summary>
        ''' Gets or sets the value being edited.
        ''' </summary>
        Public Property EditValue() As Object Implements IPropertyValueEditor.EditValue
            Get
                Return Me.Value
            End Get
            Set(ByVal value As Object)
                Me.Value = CInt(Fix(value))
            End Set
        End Property

        ''' <summary>
        ''' This provides notification back to the property grid that value in editor has changed by raising EditValueChanged event.
        ''' </summary>
        ''' <param name="e"></param>
        Protected Overrides Sub OnValueChanged(ByVal e As EventArgs)
            OnEditValueChanged(e)
            MyBase.OnValueChanged(e)
        End Sub
        ''' <summary>
        ''' Occurs when EditValue changes by the end user. Raising this even will cause the property value to be updated with the EditValue.
        ''' </summary>
        Public Event EditValueChanged As EventHandler Implements IPropertyValueEditor.EditValueChanged
        Private Sub OnEditValueChanged(ByVal e As EventArgs)
            RaiseEvent EditValueChanged(Me, e)
        End Sub
        ''' <summary>
        ''' Gets or sets the font used by the edit part of the control. Font might be used to visually indicate that property value has changed. Implementing this property is optional.
        ''' </summary>
        Public Property EditorFont() As Font Implements IPropertyValueEditor.EditorFont
            Get
                Return Me.Font
            End Get
            Set(ByVal value As Font)
                Me.Font = value
            End Set
        End Property
        ''' <summary>
        ''' Focus the edit part of the control.
        ''' </summary>
        Public Sub FocusEditor() Implements IPropertyValueEditor.FocusEditor
            Me.Focus()
        End Sub
        ''' <summary>
        ''' Gets whether the edit part of the control is focused.
        ''' </summary>
        Public ReadOnly Property IsEditorFocused() As Boolean Implements IPropertyValueEditor.IsEditorFocused
            Get
                Return Me.Focused
            End Get
        End Property

#End Region
    End Class


End Class

''' <summary>
''' This is class to demonstrate property-value editors included with AdvPropertyGrid
''' </summary>
Public Class CustomClass
    Implements INotifyPropertyChanged
    Private _DoubleValue As Double = 0
    <PropertyDoubleEditor(0, 100), Description("Uses double value editor with min and max values defined. Min=0, Max=100")> _
Public Property DoubleValue() As Double
        Get
            Return _DoubleValue
        End Get
        Set(ByVal value As Double)
            _DoubleValue = value
            OnPropertyChanged(New PropertyChangedEventArgs("DoubleValue"))
        End Set
    End Property

    Private _SliderEditor As Integer = 0
    <PropertySliderEditor(-10, 20), Description("Office style slider property editor. Min=-10, Max=20")> _
Public Property SliderEditor() As Integer
        Get
            Return _SliderEditor
        End Get
        Set(ByVal value As Integer)
            _SliderEditor = value
            OnPropertyChanged(New PropertyChangedEventArgs("SliderEditor"))
        End Set
    End Property

    Private _MultiStringOption As String
    <PropertyMultiChoiceEditor("Option 1,Option 2,Option 3")> _
Public Property MultiStringOption() As String
        Get
            Return _MultiStringOption
        End Get
        Set(ByVal value As String)
            _MultiStringOption = value
            OnPropertyChanged(New PropertyChangedEventArgs("MultiStringOption"))
        End Set
    End Property

    Private _MultiSelect As String
    <PropertyMultiChoiceEditor("Option 1,Option 2,Option 3", True)> _
Public Property MultiSelect() As String
        Get
            Return _MultiSelect
        End Get
        Set(ByVal value As String)
            _MultiSelect = value
            OnPropertyChanged(New PropertyChangedEventArgs("MultiSelect"))
        End Set
    End Property

    Private _IntegerValue As Integer
    <PropertyIntegerEditor(0, 100), Description("Uses integer value editor with min and max values defined. Min=0, Max=100")> _
Public Property IntegerValue() As Integer
        Get
            Return _IntegerValue
        End Get
        Set(ByVal value As Integer)
            _IntegerValue = value
            OnPropertyChanged(New PropertyChangedEventArgs("IntegerValue"))
        End Set
    End Property

    Private _TrackBarDecorated As Integer = 20
    <TrackBarPropertyEditor(0, 200), Description("Custom Editor assigned using attribute.")> _
Public Property TrackBarDecorated() As Integer
        Get
            Return _TrackBarDecorated
        End Get
        Set(ByVal value As Integer)
            _TrackBarDecorated = value
            OnPropertyChanged(New PropertyChangedEventArgs("TrackBarDecorated"))
        End Set
    End Property

    Private _TrackBarDynamic As Integer = 0
    <Description("Custom Editor assigned through property settings on AdvPropertyGrid")> _
Public Property TrackBarDynamic() As Integer
        Get
            Return _TrackBarDynamic
        End Get
        Set(ByVal value As Integer)
            _TrackBarDynamic = value
            OnPropertyChanged(New PropertyChangedEventArgs("TrackBarDynamic"))
        End Set
    End Property

    Private _Date As Date = Date.Today
    <PropertyDateTimeEditor(), Description("Date-Time Editor")> _
Public Property [Date]() As Date
        Get
            Return _Date
        End Get
        Set(ByVal value As Date)
            _Date = value
            OnPropertyChanged(New PropertyChangedEventArgs("Date"))
        End Set
    End Property

    Private _Time As Date = Date.Today
    <PropertyDateTimeEditor(DevComponents.Editors.eDateTimePickerFormat.ShortTime), Description("Date-Time Editor with format ShortTime")> _
Public Property Time() As Date
        Get
            Return _Time
        End Get
        Set(ByVal value As Date)
            _Time = value
            OnPropertyChanged(New PropertyChangedEventArgs("Time"))
        End Set
    End Property

#Region "INotifyPropertyChanged Members"
    ''' <summary>
    ''' Occurs when property value has changed.
    ''' </summary>
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    ''' <summary>
    ''' Raises the PropertyChanged event.
    ''' </summary>
    ''' <param name="e">Event arguments</param>
    Protected Overridable Sub OnPropertyChanged(ByVal e As PropertyChangedEventArgs)
        RaiseEvent PropertyChanged(Me, e)
    End Sub
#End Region
End Class
