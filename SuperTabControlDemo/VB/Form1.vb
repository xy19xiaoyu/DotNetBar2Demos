Public Class Form1

#Region "Private variables"

    Private _NewTabId As Integer = 3

#End Region

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
        ' Initialize our components and their associated data

        InitializeComponent()
        AddNewControlBoxItem()

    End Sub

#Region "AddNewControlBoxItem"

#Region "AddNewControlBoxItem"

    ''' <summary>
    ''' Adds the "New" ControlBox item
    ''' </summary>
    Private Sub AddNewControlBoxItem()

        ' Create a new button and add it to the ControlBox

        AddControlBoxColorTable()

        Dim bi As New ButtonItem()

        bi.Image = My.Resources.PlusSign
        bi.CustomColorName = "ControlBoxColorTable"

        AddHandler bi.Click, AddressOf AddTabClick

        stcOffice2007.ControlBox.SubItems.Add(bi)
    End Sub

#End Region

#Region "AddControlBoxColorTable"

    ''' <summary>
    ''' Adds the ControlBox color scheme table to the system
    ''' </summary>
    Private Sub AddControlBoxColorTable()
        If TypeOf GlobalManager.Renderer Is Office2007Renderer Then
            ' Create custom color scheme for the button and register it globally

            Dim table As New Office2007ButtonItemColorTable()

            table.Name = "ControlBoxColorTable"

            ' Define standard colors when mouse is not over the button

            table.[Default] = New Office2007ButtonItemStateColorTable()

            ' Define colors when mouse is over the button

            Dim outer As Color = Color.FromArgb(&HFF, &HBD, &H69)
            Dim back As Color = Color.FromArgb(&HFF, &HE7, &HA2)

            table.MouseOver = New Office2007ButtonItemStateColorTable()
            table.MouseOver.OuterBorder.Start = outer
            table.MouseOver.OuterBorder.[End] = outer
            table.MouseOver.TopBackground.Start = back
            table.MouseOver.TopBackground.[End] = back
            table.MouseOver.BottomBackground.Start = back
            table.MouseOver.BottomBackground.[End] = back

            ' Define colors when mouse is pressed

            back = Color.FromArgb(&HFB, &H8C, &H3C)

            table.Pressed = New Office2007ButtonItemStateColorTable()
            table.Pressed.OuterBorder.Start = outer
            table.Pressed.OuterBorder.[End] = outer
            table.Pressed.TopBackground.Start = back
            table.Pressed.TopBackground.[End] = back
            table.Pressed.BottomBackground.Start = back
            table.Pressed.BottomBackground.[End] = back

            Dim r As Office2007Renderer = TryCast(GlobalManager.Renderer, Office2007Renderer)

            r.ColorTable.ButtonItemColors.Add(table)
        End If
    End Sub

#End Region

#Region "AddTabClick"

    ''' <summary>
    ''' Handles "Add Tab" ControlBox selections
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddTabClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim s As String = "New Tab " & _NewTabId
        Dim tab As SuperTabItem = stcOffice2007.CreateTab(s)

        _NewTabId += 1

        tab.ImageIndex = 2

        Dim lab As New LabelX()
        lab.Text = "New tab created in code."
        lab.TextAlignment = StringAlignment.Center
        lab.BackColor = Color.Transparent
        lab.Dock = DockStyle.Fill

        tab.AttachedControl.Controls.Add(lab)
    End Sub

#End Region

#End Region

End Class
