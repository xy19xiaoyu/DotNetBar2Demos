Public Class FormCategoryStyling

    Private Sub FormCategoryStyling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Create new Category style and assign it to Property Grid Appearance object
        Dim style As DevComponents.DotNetBar.ElementStyle = New DevComponents.DotNetBar.ElementStyle()
        style.BackColor = Color.WhiteSmoke
        style.BackColor2 = Color.Silver
        style.TextColor = Color.Olive
        style.BackColorGradientAngle = 90
        advPropertyGrid1.Appearance.CategoryStyle = style

        ' Set object to display properties for
        advPropertyGrid1.SelectedObject = buttonX1
    End Sub
End Class