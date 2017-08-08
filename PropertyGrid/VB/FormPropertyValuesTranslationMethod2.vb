Imports DevComponents.DotNetBar

Public Class FormPropertyValuesTranslationMethod2

    Dim _BackImageLayoutPropertySetting As PropertySettings
    Dim _Values As Dictionary(Of ImageLayout, String) = New Dictionary(Of ImageLayout, String)

    Private Sub FormPropertyValuesTranslationMethod2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Initialize the value mapping collection
        _Values.Add(ImageLayout.Center, "Center Image")
        _Values.Add(ImageLayout.None, "As is")
        _Values.Add(ImageLayout.Stretch, "Stretch Image")
        _Values.Add(ImageLayout.Tile, "Tile Image")
        _Values.Add(ImageLayout.Zoom, "Zoom Image")

        ' Initialize property setting object
        _BackImageLayoutPropertySetting = New PropertySettings("BackgroundImageLayout")
        ' Handling these 3 events is needed for proper value mapping
        AddHandler _BackImageLayoutPropertySetting.ConvertFromStringToPropertyValue, AddressOf BackImageLayoutConvertFromStringToPropertyValue
        AddHandler _BackImageLayoutPropertySetting.ConvertPropertyValueToString, AddressOf BackImageLayoutConvertPropertyValueToString
        AddHandler _BackImageLayoutPropertySetting.ProvidePropertyValueList, AddressOf BackImageLayoutProvidePropertyValueList

        ' Create new visual style for property node so we can see it better
        _BackImageLayoutPropertySetting.Style = New ElementStyle()
        _BackImageLayoutPropertySetting.Style.TextColor = Color.DarkRed
        ' Add property setting to the grid
        advPropertyGrid1.PropertySettings.Add(_BackImageLayoutPropertySetting)

        ' Set object to display properties for
        advPropertyGrid1.SelectedObject = buttonX1
    End Sub
    Private Sub BackImageLayoutConvertFromStringToPropertyValue(ByVal sender As Object, ByVal e As ConvertValueEventArgs)
        ' Convert text representation to the typed value
        Dim value As String = ""
        If Not e.StringValue Is Nothing Then value = e.StringValue.ToLower()

        For Each item As KeyValuePair(Of ImageLayout, String) In _Values
            If item.Value.ToLower() = value Then
                e.TypedValue = item.Key
                e.IsConverted = True
            End If
        Next
    End Sub
    Private Sub BackImageLayoutConvertPropertyValueToString(ByVal sender As Object, ByVal e As ConvertValueEventArgs)
        ' Convert typed value to its text representation
        If e.TypedValue Is Nothing Then
            e.StringValue = ""
        Else
            e.StringValue = _Values(CType(e.TypedValue, ImageLayout))
        End If
        e.IsConverted = True
    End Sub
    Private Sub BackImageLayoutProvidePropertyValueList(ByVal sender As Object, ByVal e As PropertyValueListEventArgs)
        ' This list is used for auto-complete while typing the property value
        ' as well as for drop-down Combo-Box 
        e.ValueList = New List(Of String)(_Values.Values)
        e.IsListValid = True
    End Sub
End Class