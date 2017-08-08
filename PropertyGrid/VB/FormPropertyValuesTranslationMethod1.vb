Public Class FormPropertyValuesTranslationMethod1

    ' By handling AdvPropertyGrid events you can perform "bulk" property value conversions
    ' For example apply it to all boolean properties.
    Private Const Text_Yes As String = "Yes"
    Private Const Text_No As String = "No"

    Private Sub FormPropertyValuesTranslationMethod1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        advPropertyGrid1.SelectedObject = buttonX1
    End Sub

    Private Sub advPropertyGrid1_ConvertFromStringToPropertyValue(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ConvertValueEventArgs) Handles advPropertyGrid1.ConvertFromStringToPropertyValue
        If e.PropertyDescriptor.PropertyType Is GetType(Boolean) Then
            If e.StringValue = Text_Yes Then
                e.TypedValue = True
            Else
                e.TypedValue = False
            End If
            ' Note that you must indicate that you have converted the value
            e.IsConverted = True
        End If
    End Sub

    Private Sub advPropertyGrid1_ConvertPropertyValueToString(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ConvertValueEventArgs) Handles advPropertyGrid1.ConvertPropertyValueToString
        If e.PropertyDescriptor.PropertyType Is GetType(Boolean) Then
            If e.TypedValue = True Then
                e.StringValue = Text_Yes
            Else
                e.StringValue = Text_No
            End If
            ' Note that you must indicate that you have converted the value
            e.IsConverted = True
        End If
    End Sub

    Private Sub advPropertyGrid1_ProvidePropertyValueList(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.PropertyValueListEventArgs) Handles advPropertyGrid1.ProvidePropertyValueList
        If e.PropertyDescriptor.PropertyType Is GetType(Boolean) Then
            ' Text representation of all available property values
            e.ValueList = New List(Of String)(New String() {Text_Yes, Text_No})
            ' Indicate that a list was provided
            e.IsListValid = True
        End If
    End Sub
End Class