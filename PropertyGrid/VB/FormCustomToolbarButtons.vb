Imports DevComponents.DotNetBar

Public Class FormCustomToolbarButtons

    Private Sub FormCustomToolbarButtons_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Create new button item
        Dim button As ButtonItem = New ButtonItem("helpPanel", "Help Panel")
        button.ButtonStyle = eButtonStyle.TextOnlyAlways
        button.OptionGroup = "helpPanel" ' This will automatically manage the Check property so only one button in group is checked
        AddHandler button.OptionGroupChanging, AddressOf ButtonOptionGroupChanging
        ' This is how to access the Property Grid toolbar and add new button to it
        advPropertyGrid1.Toolbar.Items.Add(button)

        ' Create second button
        button = New ButtonItem("helpTooltip", "SuperTooltip Help")
        button.ButtonStyle = eButtonStyle.TextOnlyAlways
        button.OptionGroup = "helpPanel"
        button.Checked = True ' This is default value
        AddHandler button.OptionGroupChanging, AddressOf ButtonOptionGroupChanging
        advPropertyGrid1.Toolbar.Items.Add(button)

        ' Apply layout changes so items become visible
        advPropertyGrid1.Toolbar.RecalcLayout()

        ' Set object to display properties for
        advPropertyGrid1.SelectedObject = buttonX1
    End Sub
    Private Sub ButtonOptionGroupChanging(ByVal sender As Object, ByVal e As OptionGroupChangingEventArgs)
        If e.NewChecked.Name = "helpPanel" Then
            advPropertyGrid1.HelpType = ePropertyGridHelpType.Panel
        Else
            advPropertyGrid1.HelpType = ePropertyGridHelpType.SuperTooltip
        End If
    End Sub
End Class