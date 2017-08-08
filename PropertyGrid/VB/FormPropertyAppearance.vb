Imports DevComponents.DotNetBar

Public Class FormPropertyAppearance

    Dim _AntiAliasPropertySetting As PropertySettings
    Private Sub FormPropertyAppearance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Customize AntiAlias property appearance
        _AntiAliasPropertySetting = New PropertySettings("AntiAlias") ' Specifies that this setting is attached to AntiAlias property
        _AntiAliasPropertySetting.Description = "This is custom description, help text, for the AntiAlias property"
        _AntiAliasPropertySetting.DisplayName = "AntiAliasCustomName" ' Change property name that is displayed in property grid
        ' Create new visual style for property
        Dim style As ElementStyle = New ElementStyle()
        style.BackColor = Color.WhiteSmoke
        style.BackColor2 = Color.LightGoldenrodYellow
        style.BackColorGradientAngle = 90
        style.TextColor = Color.Brown
        _AntiAliasPropertySetting.Style = style

        ' Adds property setting to the grid
        advPropertyGrid1.PropertySettings.Add(_AntiAliasPropertySetting)

        ' Set object to display properties for
        advPropertyGrid1.SelectedObject = buttonX1
    End Sub
End Class