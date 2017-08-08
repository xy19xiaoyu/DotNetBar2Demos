Public Class Form1

    Private Sub buttonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonX5.Click
        Dim form As FormCategoryStyling = New FormCategoryStyling
        form.Show()
    End Sub

    Private Sub buttonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonX4.Click
        Dim form As FormCustomToolbarButtons = New FormCustomToolbarButtons
        form.Show()
    End Sub

    Private Sub buttonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonX1.Click
        Dim form As FormPropertyAppearance = New FormPropertyAppearance
        form.Show()
    End Sub

    Private Sub buttonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonX2.Click
        Dim form As FormPropertyValuesTranslationMethod1 = New FormPropertyValuesTranslationMethod1
        form.Show()
    End Sub

    Private Sub buttonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonX3.Click
        Dim form As FormPropertyValuesTranslationMethod2 = New FormPropertyValuesTranslationMethod2
        form.Show()
    End Sub

    Private Sub buttonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonX6.Click
        Dim form As FormPropertyValueEditors = New FormPropertyValueEditors
        form.Show()
    End Sub
End Class
