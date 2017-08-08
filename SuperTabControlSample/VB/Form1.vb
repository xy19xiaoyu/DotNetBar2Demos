Partial Public Class Form1
    Inherits Form

#Region "Private constants"

    Private Const Radius As Integer = 6

#End Region

#Region "Private variables"

    Private _ModifyTabMenu As Boolean
    Private _UserTabCount As Integer = 1

#End Region

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
        ' Initialize our components and associated data

        InitializeComponent()
        InitializeData()

        ' Hook onto our control events

        HookEvents(True)
    End Sub

#Region "InitializeData"

    ''' <summary>
    ''' Initializes our interface control data
    ''' </summary>
    Private Sub InitializeData()
        ' Tab Alignment

        Dim names As String() = [Enum].GetNames(GetType(eSuperTabStyle))

        cbxTabStyle.Items.AddRange(names)
        cbxTabStyle.SelectedIndex = 4

        names = [Enum].GetNames(GetType(eTabStripAlignment))

        cbxTabAlignment.Items.AddRange(names)
        cbxTabAlignment.SelectedIndex = 2

        ' Text Alignment

        names = [Enum].GetNames(GetType(eItemAlignment))

        cbxTextAlignment.Items.AddRange(names)
        cbxTextAlignment.SelectedIndex = 0

        cbxBaseItemAlignment.Items.AddRange(names)
        cbxBaseItemAlignment.SelectedIndex = 0

        ' Line Alignment

        names = [Enum].GetNames(GetType(eSuperTabLayoutType))

        cbxLineAlignment.Items.AddRange(names)
        cbxLineAlignment.SelectedIndex = 0

        ' Image Alignment

        cbImagePos.Items.AddRange([Enum].GetNames(GetType(ImageAlignment)))
        cbImagePos.SelectedIndex = 9

        cbDefImagePos.Items.AddRange([Enum].GetNames(GetType(ImageAlignment)))
        cbDefImagePos.SelectedIndex = 9
    End Sub

#End Region

#Region "HookEvents"

    ''' <summary>
    ''' Hooks our system control events
    ''' </summary>
    ''' <param name="hook"></param>
    Private Sub HookEvents(ByVal hook As Boolean)
        If hook = True Then
            AddHandler superTabControl1.ControlBox.MenuBox.PopupOpen, AddressOf MenuBox_PopupOpen
        Else
            RemoveHandler superTabControl1.ControlBox.MenuBox.PopupOpen, AddressOf MenuBox_PopupOpen
        End If
    End Sub

#End Region

#Region "Tab Style"

#Region "cbxStyle_SelectedIndexChanged"

    ''' <summary>
    ''' Handles TabStyle selection changes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxTabStyle.SelectedIndexChanged
        Dim values As Integer() = DirectCast([Enum].GetValues(GetType(eSuperTabStyle)), Integer())

        superTabControl1.TabStyle = DirectCast((values(cbxTabStyle.SelectedIndex)), eSuperTabStyle)
    End Sub

#End Region

#Region "ContextMenu support"

    ''' <summary>
    ''' Handles TabStyle tab mouseUp events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub stiTabStyle_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles stiTabStyle.MouseUp
        If e.Button = MouseButtons.Right Then
            ' Set the appropriate style as "Checked"

            cmiOffice2007.Checked = superTabControl1.TabStyle = eSuperTabStyle.Office2007
            cmiBackstageBlue.Checked = superTabControl1.TabStyle = eSuperTabStyle.Office2010BackstageBlue
            cmiOneNote2007.Checked = superTabControl1.TabStyle = eSuperTabStyle.OneNote2007
            cmiVs2008Dock.Checked = superTabControl1.TabStyle = eSuperTabStyle.VisualStudio2008Dock
            cmiVs2008Document.Checked = superTabControl1.TabStyle = eSuperTabStyle.VisualStudio2008Document
            cmiWinMediaPlayer12.Checked = superTabControl1.TabStyle = eSuperTabStyle.WinMediaPlayer12

            ' Show the ContextMenu

            ShowContextMenu(cmTabStyle, e)
        End If
    End Sub

#Region "cmiOffice2007_Click"

    ''' <summary>
    ''' Handles Office2007 style selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiOffice2007_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiOffice2007.Click
        cbxTabStyle.SelectedIndex = CInt(eSuperTabStyle.Office2007)
    End Sub

#End Region

#Region "cmiBackstageBlue_Click"

    ''' <summary>
    ''' Handles BackstageBlue selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiBackstageBlue_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiBackstageBlue.Click
        cbxTabStyle.SelectedIndex = CInt(eSuperTabStyle.Office2010BackstageBlue)
    End Sub

#End Region

#Region "cmiOneNote2007_Click"

    ''' <summary>
    ''' Handles OneNote2007 selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiOneNote2007_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiOneNote2007.Click
        cbxTabStyle.SelectedIndex = CInt(eSuperTabStyle.OneNote2007)
    End Sub

#End Region

#Region "Vs2008Dock_Click"

    ''' <summary>
    ''' Handles VisualStudio2008Dock selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Vs2008Dock_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiVs2008Dock.Click
        cbxTabStyle.SelectedIndex = CInt(eSuperTabStyle.VisualStudio2008Dock)
    End Sub

#End Region

#Region "Vs2008Document_Click"

    ''' <summary>
    ''' Handles VisualStudio2008Document style selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Vs2008Document_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiVs2008Document.Click
        cbxTabStyle.SelectedIndex = CInt(eSuperTabStyle.VisualStudio2008Document)
    End Sub

#End Region

#Region "WinMediaPlayer12_Click"

    ''' <summary>
    ''' Handles WinMediaPlayer12 selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub WinMediaPlayer12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiWinMediaPlayer12.Click
        cbxTabStyle.SelectedIndex = CInt(eSuperTabStyle.WinMediaPlayer12)
    End Sub

#End Region

#End Region

#End Region

#Region "Tab Alignment"

#Region "cbxTabAlignment_SelectedIndexChanged"

    ''' <summary>
    ''' Handles Tab Alignment changes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxTabAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxTabAlignment.SelectedIndexChanged
        Dim values As Integer() = DirectCast([Enum].GetValues(GetType(eSuperTabStyle)), Integer())

        superTabControl1.TabAlignment = DirectCast((values(cbxTabAlignment.SelectedIndex)), eTabStripAlignment)
    End Sub

#End Region

#Region "cbxLineAlignment_SelectedIndexChanged"

    ''' <summary>
    ''' Handles Line Alignment changes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxLineAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxLineAlignment.SelectedIndexChanged
        Dim values As Integer() = DirectCast([Enum].GetValues(GetType(eSuperTabLayoutType)), Integer())

        superTabControl1.TabLayoutType = DirectCast((values(cbxLineAlignment.SelectedIndex)), eSuperTabLayoutType)
    End Sub

#End Region

#Region "ContextMenu support"

    Private Sub stiTabAlignment_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles stiTabAlignment.MouseUp
        If e.Button = MouseButtons.Right Then
            ' Set our ContextMenu "check" states

            cmiTop.Checked = superTabControl1.TabAlignment = eTabStripAlignment.Top
            cmiLeft.Checked = superTabControl1.TabAlignment = eTabStripAlignment.Left
            cmiBottom.Checked = superTabControl1.TabAlignment = eTabStripAlignment.Bottom
            cmiRight.Checked = superTabControl1.TabAlignment = eTabStripAlignment.Right

            cmiSingleLine.Checked = superTabControl1.TabLayoutType = eSuperTabLayoutType.SingleLine
            cmiSingleLineFit.Checked = superTabControl1.TabLayoutType = eSuperTabLayoutType.SingleLineFit
            cmiMultiLine.Checked = superTabControl1.TabLayoutType = eSuperTabLayoutType.MultiLine
            cmiMultiLineFit.Checked = superTabControl1.TabLayoutType = eSuperTabLayoutType.MultiLineFit

            ' Show the ContextMenu

            ShowContextMenu(cmTabAlignment, e)
        End If
    End Sub

#Region "cmiLeft_Click"

    ''' <summary>
    ''' Handles Left-Alignment selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiLeft_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiLeft.Click
        cbxTabAlignment.SelectedIndex = CInt(eTabStripAlignment.Left)
    End Sub

#End Region

#Region "cmiRight_Click"

    ''' <summary>
    ''' Handles Right-Alignment selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiRight_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiRight.Click
        cbxTabAlignment.SelectedIndex = CInt(eTabStripAlignment.Right)
    End Sub

#End Region

#Region "cmiTop_Click"

    ''' <summary>
    ''' Handles Top-alignment selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiTop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiTop.Click
        cbxTabAlignment.SelectedIndex = CInt(eTabStripAlignment.Top)
    End Sub

#End Region

#Region "cmiBottom_Click"

    ''' <summary>
    ''' Handles Bottom-alignment selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiBottom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiBottom.Click
        cbxTabAlignment.SelectedIndex = CInt(eTabStripAlignment.Bottom)
    End Sub

#End Region

#Region "cmiSingleLine_Click"

    ''' <summary>
    ''' Handles SingleLine selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiSingleLine_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiSingleLine.Click
        cbxLineAlignment.SelectedIndex = CInt(eSuperTabLayoutType.SingleLine)
    End Sub

#End Region

#Region "cmiSingleLineFit_Click"

    ''' <summary>
    ''' Handles SingleLineFit selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiSingleLineFit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiSingleLineFit.Click
        cbxLineAlignment.SelectedIndex = CInt(eSuperTabLayoutType.SingleLineFit)
    End Sub

#End Region

#Region "cmiMultiLine_Click"

    ''' <summary>
    ''' Handles MultiLine selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiMultiLine_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiMultiLine.Click
        cbxLineAlignment.SelectedIndex = CInt(eSuperTabLayoutType.MultiLine)
    End Sub

#End Region

#Region "cmiMultiLineFit_Click"

    ''' <summary>
    ''' Handles MultiLineFit selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiMultiLineFit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiMultiLineFit.Click
        cbxLineAlignment.SelectedIndex = CInt(eSuperTabLayoutType.MultiLineFit)
    End Sub

#End Region

#End Region

#End Region

#Region "Tab Size"

#Region "iiWidth_ValueChanged"

    ''' <summary>
    ''' Handles FixedTabSize width changes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub iiWidth_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles iiWidth.ValueChanged
        superTabControl1.FixedTabSize = New Size(iiWidth.Value, superTabControl1.FixedTabSize.Height)
    End Sub

#End Region

#Region "iiHeight_ValueChanged"

    ''' <summary>
    ''' Handles FixedTabSize height changes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub iiHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles iiHeight.ValueChanged
        superTabControl1.FixedTabSize = New Size(superTabControl1.FixedTabSize.Width, iiHeight.Value)
    End Sub

#End Region

#Region "iiHorizontalSpace_ValueChanged"

    ''' <summary>
    ''' Handles HorizontalSpace changes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub iiHorizontalSpace_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles iiHorizontalSpace.ValueChanged
        superTabControl1.TabHorizontalSpacing = iiHorizontalSpace.Value
    End Sub

#End Region

#Region "iiVerticalSpace_ValueChanged"

    ''' <summary>
    ''' Handles VerticalSpace changes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub iiVerticalSpace_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles iiVerticalSpace.ValueChanged
        superTabControl1.TabVerticalSpacing = iiVerticalSpace.Value
    End Sub

#End Region

#Region "btxResetSize_Click"

    ''' <summary>
    ''' Initiates the reset of the FixedTabSize
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btxResetSize_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btxResetSize.Click
        ResetSize()
    End Sub

    ''' <summary>
    ''' Resets the FixedTabSize
    ''' </summary>
    Private Sub ResetSize()
        superTabControl1.FixedTabSize = Size.Empty

        iiWidth.Value = 0
        iiHeight.Value = 0
    End Sub

#End Region

#Region "btxResetSpacing_Click"

    ''' <summary>
    ''' Initiates the reset of the tab spacing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btxResetSpacing_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btxResetSpacing.Click, cmiResetSpacing.Click
        ResetSpacing()
    End Sub

    ''' <summary>
    ''' Resets the tab spacing
    ''' </summary>
    Private Sub ResetSpacing()
        superTabControl1.TabHorizontalSpacing = 5
        superTabControl1.TabVerticalSpacing = 4

        iiHorizontalSpace.Value = 5
        iiVerticalSpace.Value = 4
    End Sub

#End Region

#Region "ContextMenu support"

#Region "stiTabSize_MouseUp"

    ''' <summary>
    ''' Handles TabSize tab mouseUp events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub stiTabSize_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles stiTabSize.MouseUp
        If e.Button = MouseButtons.Right Then
            ShowContextMenu(cmTabSize, e)
        End If
    End Sub

#End Region

#Region "cniResetSize_Click"

    ''' <summary>
    ''' Initiates a FixedTabSize reset
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cniResetSize_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cniResetSize.Click
        ResetSize()
    End Sub

#End Region

#Region "cmiResetSpacing_Click"

    ''' <summary>
    ''' Initiates a tab spacing reset
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiResetSpacing_Click(ByVal sender As Object, ByVal e As EventArgs)
        ResetSpacing()
    End Sub

#End Region

#End Region

#End Region

#Region "Text Alignment"

#Region "cbxTextAlignment_SelectedIndexChanged"

    ''' <summary>
    ''' Handles TextAlignment changes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxTextAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxTextAlignment.SelectedIndexChanged
        Dim values As Integer() = DirectCast([Enum].GetValues(GetType(eItemAlignment)), Integer())

        superTabControl1.TextAlignment = DirectCast((values(cbxTextAlignment.SelectedIndex)), eItemAlignment)
    End Sub

#End Region

#Region "cbxHorizontal_CheckedChanged"

    ''' <summary>
    ''' Handles Horizontal text changes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxHorizontal_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxHorizontal.CheckedChanged
        superTabControl1.HorizontalText = cbxHorizontal.Checked
    End Sub

#End Region

#Region "cbxRotateText_CheckedChanged"

    ''' <summary>
    ''' Handles Horizontal text changes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxRotateText_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxRotateText.CheckedChanged
        superTabControl1.RotateVerticalText = cbxRotateText.Checked
    End Sub

#End Region

#Region "cbxDisplayOnlySelectedText_CheckedChanged"

    ''' <summary>
    ''' Handles DisplayOnlySelectedText changes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxDisplayOnlySelectedText_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxTextAlignment.SelectedIndexChanged, cbxDisplayOnlySelectedText.CheckedChanged
        superTabControl1.DisplaySelectedTextOnly = cbxDisplayOnlySelectedText.Checked
    End Sub

#End Region

#Region "ContextMenu support"

#Region "stiTextAlignment_MouseUp"

    ''' <summary>
    ''' Handles TextAlignment tab mouseUp events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub stiTextAlignment_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles stiTextAlignment.MouseUp
        If e.Button = MouseButtons.Right Then
            cmiTextNear.Checked = superTabControl1.TextAlignment = eItemAlignment.Near
            cmiTextCenter.Checked = superTabControl1.TextAlignment = eItemAlignment.Center
            cmiTextFar.Checked = superTabControl1.TextAlignment = eItemAlignment.Far

            cmiHorizText.Checked = superTabControl1.HorizontalText
            cmiOnlySelText.Checked = superTabControl1.DisplaySelectedTextOnly

            ShowContextMenu(cmTextAlignment, e)
        End If
    End Sub

#End Region

#Region "cmiTextNear_Click"

    ''' <summary>
    ''' Handles TextNear selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiTextNear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiTextNear.Click
        cbxTextAlignment.SelectedIndex = CInt(eItemAlignment.Near)
    End Sub

#End Region

#Region "cmiTextCenter_Click"

    ''' <summary>
    ''' Handles TextCenter selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiTextCenter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiTextCenter.Click
        cbxTextAlignment.SelectedIndex = CInt(eItemAlignment.Center)
    End Sub

#End Region

#Region "cmiTextFar_Click"

    ''' <summary>
    ''' Handles TextFar selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiTextFar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiTextFar.Click
        cbxTextAlignment.SelectedIndex = CInt(eItemAlignment.Far)
    End Sub

#End Region

#Region "cmiHorizText_Click"

    ''' <summary>
    ''' Handles Horizontal text selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiHorizText_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiHorizText.Click
        cbxHorizontal.Checked = Not cbxHorizontal.Checked
    End Sub

#End Region

#Region "cmiOnlySelText_Click"

    ''' <summary>
    ''' Handles DisplayOnlySelectedText selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiOnlySelText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmiOnlySelText.Click
        cbxDisplayOnlySelectedText.Checked = Not cbxDisplayOnlySelectedText.Checked
    End Sub

#End Region

#End Region

#End Region

#Region "Color"

#Region "cbColorDefault_CheckedChanged"

    ''' <summary>
    ''' Handles default color selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbColorDefault_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbColorDefault.CheckedChanged
        If cbColorDefault.Checked = True Then
            superTabControl1.TabStrip.BeginUpdate()

            ' Loop through each tab, whose color we may have changed,
            ' resetting its color setting back to the default

            For i As Integer = 0 To superTabControl1.Tabs.Count - 1
                Dim tab As SuperTabItem = TryCast(superTabControl1.Tabs(i), SuperTabItem)

                If tab IsNot Nothing Then
                    ResetAllTabColors(tab)
                End If
            Next

            superTabControl1.ResetTabStripColor()

            superTabControl1.TabStrip.EndUpdate()
        End If
    End Sub

#End Region

#Region "cbColor1_CheckedChanged"

    ''' <summary>
    ''' Sets the colors of our tabs to a predefined
    ''' set of unique, individual colors
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbColor1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbColor1.CheckedChanged
        If cbColor1.Checked = True Then
            superTabControl1.TabStrip.BeginUpdate()

            Dim values As Integer() = DirectCast([Enum].GetValues(GetType(eTabItemColor)), Integer())

            ' Loop through each tab, setting its PredefinedColor
            ' scheme in a Round Robin fashion

            For i As Integer = 0 To superTabControl1.Tabs.Count - 1
                Dim tab As SuperTabItem = TryCast(superTabControl1.Tabs(i), SuperTabItem)

                If tab IsNot Nothing Then
                    tab.ResetTabColor()
                    tab.PredefinedColor = DirectCast((i Mod (values.Length - 1)), eTabItemColor) + 1
                End If
            Next

            ' Reset our TabStrip color back to default

            superTabControl1.ResetTabStripColor()

            superTabControl1.TabStrip.EndUpdate()

        End If
    End Sub

#End Region

#Region "cbColor2_CheckedChanged"

    ''' <summary>
    ''' Sets the colors of our "TabStyle" tab to a concocted
    ''' set of unique, individual colors
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbColor2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbColor2.CheckedChanged
        If cbColor2.Checked = True Then

            superTabControl1.TabStrip.BeginUpdate()

            ' Start by resetting our TabStyle tab colors to the default

            ResetAllTabColors(stiTabStyle)

            ' Allocate a new SuperTabColorTable and initialize it
            ' to suit our color needs. These values will be used for
            ' the coloring of the TabStrip portion of the control

            Dim ct As New SuperTabColorTable()

            ct.Background = New SuperTabLinearGradientColorTable(Color.LightGreen, Color.DarkGreen)
            ct.ControlBoxDefault.Image = Color.White

            superTabControl1.TabStripColor = ct

            ' Allocate a new SuperTabItemColorTable and initialize it to
            ' suit our needs.  These values will be used for the tab (and panel)
            ' portion of the control

            Dim stc As New SuperTabItemColorTable()

            ' The SuperTabItemColorTable contains 4 SuperTabColorStates entries.
            ' These entries correspond to the TabAlignment settings:
            ' 
            ' Default - Colors set for this scheme will be used, by default, for the other three
            '           alignment settings, unless they are each individually configured and set.
            '
            ' Left - Color settings for the Left tab alignment.
            ' Bottom - Color settings for the Bottom tab alignment.
            ' Right - Color settings for the Right tab alignment.
            '
            ' Each of the aboveSuperTabColorStates entries contains 4 SuperTabItemStateColorTable
            ' entries.  These correspond to the 4 following possible tab display states:
            '
            ' Normal - Non-Selected, non-MouseOver state
            ' MouseOver - Non-Selected, MouseOver state
            ' Selected - Selected, non-MouseOver
            ' SelectedMouseOver - Selected, MouseOver
            '
            ' Each one of these color tables can be defined to control the display colors
            ' for each state. 
            '
            ' Colors definitions are applied in the following order:
            '
            ' Default, built-in color definitions.
            ' Predefined color usage.

            stc.[Default].Normal.Background = New SuperTabLinearGradientColorTable(New Color() {Color.Yellow, Color.Orange, Color.DarkRed}, New Single() {0, 0.6, 1})

            stc.[Default].Normal.InnerBorder = Color.White
            stc.[Default].Normal.OuterBorder = Color.Black

            stc.[Default].Selected = stc.[Default].Normal

            stc.[Default].SelectedMouseOver.Background = New SuperTabLinearGradientColorTable(New Color() {Color.White, Color.Orange, Color.Red}, New Single() {0, 0.6, 1})

            stc.[Default].SelectedMouseOver.InnerBorder = Color.White
            stc.[Default].SelectedMouseOver.OuterBorder = Color.Black

            stc.[Default].MouseOver = stc.[Default].SelectedMouseOver

            stiTabStyle.TabColor = stc

            Dim panel As SuperTabControlPanel = TryCast(stiTabStyle.AttachedControl, SuperTabControlPanel)

            If panel IsNot Nothing Then

                Dim pct As SuperTabPanelColorTable = New SuperTabPanelColorTable()

                pct.Default.Background = stc.Default.Selected.Background
                pct.Default.InnerBorder = stc.Default.Selected.InnerBorder
                pct.Default.OuterBorder = stc.Default.Selected.OuterBorder

                panel.PanelColor = pct

            End If

            superTabControl1.TabStrip.EndUpdate()

        End If
    End Sub

#End Region

#Region "ResetAllTabColors"

    ''' <summary>
    ''' Resets the entire control color definitions
    ''' back to the default
    ''' </summary>
    ''' <param name="tab"></param>
    Private Sub ResetAllTabColors(ByVal tab As SuperTabItem)
        superTabControl1.ResetTabStripColor()

        tab.ResetTabColor()
        tab.PredefinedColor = eTabItemColor.[Default]
    End Sub

#End Region

#Region "ContextMenu support"

#Region "stiColor_MouseUp"

    ''' <summary>
    ''' Handles Color tab mouseUp events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub stiColor_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles stiColor.MouseUp
        If e.Button = MouseButtons.Right Then
            cmiColorDefault.Checked = cbColorDefault.Checked
            cmiColor1.Checked = cbColor1.Checked
            cmiColor2.Checked = cbColor2.Checked

            ShowContextMenu(cmColor, e)
        End If
    End Sub

#End Region

#Region "cmiColorDefault_Click"

    ''' <summary>
    ''' Handles Default Color selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiColorDefault_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiColorDefault.Click
        cbColorDefault.Checked = True
    End Sub

#End Region

#Region "cmiColor1_Click"

    ''' <summary>
    ''' Handles Color1 selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiColor1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiColor1.Click
        cbColor1.Checked = True
    End Sub

#End Region

#Region "cmiColor2_Click"

    ''' <summary>
    ''' Handles Color2 selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiColor2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiColor2.Click
        cbColor2.Checked = True
    End Sub

#End Region

#End Region

#End Region

#Region "BaseItems"

#Region "btxAddBaseItems_Click"

#Region "btxAddBaseItems_Click"

    ''' <summary>
    ''' handles AddBaseItem selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btxAddBaseItems_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btxAddBaseItems.Click, cmiAddBaseItems.Click
        AddBaseItems()
    End Sub

#End Region

#Region "AddBaseItems"

    ''' <summary>
    ''' Initiates the addition of sample BaseItem entries
    ''' </summary>
    Private Sub AddBaseItems()
        AddPrintButton()
        AddItalicizeCheckbox()
        AddColorPicker()
    End Sub

#End Region

#Region "AddColorPicker"

#Region "AddColorPicker"

    ''' <summary>
    ''' Adds a ColorPickerDropdown BaseItem object
    ''' to the Tabs list
    ''' </summary>
    Private Sub AddColorPicker()
        Dim cp As New ColorPickerDropDown()

        cp.EnableMarkup = True
        cp.Text = "Text Color"
        cp.Stretch = cbxStretch.Checked

        AddHandler cp.Click, AddressOf CpClick

        superTabControl1.Tabs.Insert(0, cp)
    End Sub

#End Region

#Region "CpClick"

    ''' <summary>
    ''' Handles ColorPickerDropdown selections
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CpClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim cp As ColorPickerDropDown = TryCast(sender, ColorPickerDropDown)

        If cp IsNot Nothing Then
            ' Set the Text color for our currently selected tab

            Dim tab As SuperTabItem = superTabControl1.SelectedTab

            If tab IsNot Nothing Then
                tab.TabColor.[Default].Normal.Text = cp.SelectedColor
                tab.TabColor.[Default].Selected.Text = cp.SelectedColor
                tab.TabColor.[Default].SelectedMouseOver.Text = cp.SelectedColor
                tab.TabColor.[Default].MouseOver.Text = cp.SelectedColor
            End If
        End If
    End Sub

#End Region

#End Region

#Region "AddItalicizeCheckbox"

#Region "AddItalicizeCheckbox"

    ''' <summary>
    ''' Adds a CheckBox BaseItem to our Tabs list
    ''' </summary>
    Private Sub AddItalicizeCheckbox()
        Dim cbi As New CheckBoxItem()

        cbi.Text = "Italicize "
        cbi.Stretch = cbxStretch.Checked
        AddHandler cbi.CheckedChanged, AddressOf CbiCheckedChanged

        superTabControl1.Tabs.Add(cbi)
    End Sub

#End Region

#Region "CbiClick"

    ''' <summary>
    ''' Handles CheckBox item selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbiClick(ByVal sender As Object, ByVal e As EventArgs)
        MessageBox.Show("Italicize Clicked!")
    End Sub

#End Region

#Region "CbiCheckedChanged"

    ''' <summary>
    ''' Handles "Italicize" checkBox change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbiCheckedChanged(ByVal sender As Object, ByVal e As CheckBoxChangeEventArgs)
        Dim cbi As CheckBoxItem = TryCast(sender, CheckBoxItem)

        If cbi IsNot Nothing Then
            If cbi.Checked = True Then
                ' Set our current TabFont and SelectedTabFont to reflect the Italics

                superTabControl1.TabFont = New Font(SystemFonts.CaptionFont, FontStyle.Italic)
                superTabControl1.SelectedTabFont = New Font(SystemFonts.CaptionFont, FontStyle.Italic Or FontStyle.Bold)
            Else
                ' Reset our tab fonts back to the system defaults

                superTabControl1.TabFont = Nothing
                superTabControl1.SelectedTabFont = Nothing
            End If
        End If
    End Sub

#End Region

#End Region

#Region "AddPrintButton"

#Region "AddPrintButton"

    ''' <summary>
    ''' Adds a ButtonItem BaseItem to our Tabs list
    ''' </summary>
    Private Sub AddPrintButton()
        Dim bi As New ButtonItem()

        bi.Text = "Print"
        bi.ButtonStyle = eButtonStyle.ImageAndText
        bi.Stretch = cbxStretch.Checked
        bi.ImageIndex = 1
        AddHandler bi.Click, AddressOf Print_Click

        Dim bi2 As New ButtonItem()

        bi2.Text = "Local Printer"
        bi2.ButtonStyle = eButtonStyle.ImageAndText
        AddHandler bi2.Click, AddressOf Print_Click

        bi.SubItems.Add(bi2)

        bi2 = New ButtonItem()

        bi2.Text = "Remote Printer"
        bi2.ButtonStyle = eButtonStyle.ImageAndText
        AddHandler bi2.Click, AddressOf Print_Click

        bi.SubItems.Add(bi2)

        superTabControl1.Tabs.Add(bi)
    End Sub

#End Region

#Region "Print_Click"

    ''' <summary>
    ''' Handles ButtonItem Click selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Print_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)

        If bi IsNot Nothing Then
            Dim esa As EventSourceArgs = TryCast(e, EventSourceArgs)

            ' Check to see if the event was generated via the mouse, or
            ' was generated via a ControlBox.MenuBox.TabMenu selection
            ' when the RaiseClickOnSelection property is set

            If esa IsNot Nothing AndAlso esa.Source = eEventSource.Code Then
                MessageBox.Show(bi.Text & " selected via MenuBox!")
            Else
                MessageBox.Show(bi.Text & " selected!")
            End If
        End If
    End Sub

#End Region

#End Region

#End Region

#Region "btxDelBaseItems_Click"

#Region "btxDelBaseItems_Click"

    ''' <summary>
    ''' Handles DelBaseItems selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btxDelBaseItems_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btxDelBaseItems.Click, cmiDelBaseItems.Click
        DelBaseItems()
    End Sub

#End Region

#Region "DelBaseItems"

    ''' <summary>
    ''' Deletes all BaseItems from the Tabs list
    ''' </summary>
    Private Sub DelBaseItems()
        ' Loop through each Tabs entry, removing every BaseItem
        ' occurrence we find

        For i As Integer = superTabControl1.Tabs.Count - 1 To 0 Step -1
            If (TypeOf superTabControl1.Tabs(i) Is SuperTabItem) = False Then
                superTabControl1.Tabs.RemoveAt(i)
            End If
        Next
    End Sub

#End Region

#End Region

#Region "cbxBaseItemAlignment_SelectedIndexChanged"

    ''' <summary>
    ''' Handles BaseItem Alignment selection.
    ''' 
    ''' When BaseItems are added to the Tabs list, they can be
    ''' aligned Near, Center, or Far.  Near is default.  This
    ''' setting has no effect when Stretch is set to true.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxBaseItemAlignment_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxBaseItemAlignment.SelectedIndexChanged
        Dim values As Integer() = DirectCast([Enum].GetValues(GetType(eItemAlignment)), Integer())
        Dim eia As eItemAlignment = DirectCast((values(cbxBaseItemAlignment.SelectedIndex)), eItemAlignment)

        For i As Integer = 0 To superTabControl1.Tabs.Count - 1
            If (TypeOf superTabControl1.Tabs(i) Is SuperTabItem) = False Then
                superTabControl1.Tabs(i).ItemAlignment = eia
            End If
        Next
    End Sub

#End Region

#Region "cbxStretch_CheckedChanged"

    ''' <summary>
    ''' Handles Stretch selection.
    ''' 
    ''' This setting causes the underlying BaseItem object to be
    ''' stretched (either vertically or horizontally) to fill the allotted
    ''' control tab space.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxStretch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxStretch.CheckedChanged
        For i As Integer = 0 To superTabControl1.Tabs.Count - 1
            If (TypeOf superTabControl1.Tabs(i) Is SuperTabItem) = False Then
                superTabControl1.Tabs(i).Stretch = cbxStretch.Checked
            End If
        Next
    End Sub

#End Region

#Region "ContextMenu support"

#Region "stiBaseItems_MouseUp"

    ''' <summary>
    ''' Handles BaseItems mouseUp events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub stiBaseItems_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles stiBaseItems.MouseUp
        If e.Button = MouseButtons.Right Then
            ' Set our Checked states

            cmiStretch.Checked = cbxStretch.Checked

            cmiBaseItemsNear.Checked = cbxBaseItemAlignment.SelectedIndex = CInt(eItemAlignment.Near)
            cmiBaseItemsCenter.Checked = cbxBaseItemAlignment.SelectedIndex = CInt(eItemAlignment.Center)
            cmiBaseItemsFar.Checked = cbxBaseItemAlignment.SelectedIndex = CInt(eItemAlignment.Far)

            ' Set our DelBaseItems Checked state

            Dim delState As Boolean = False

            For i As Integer = 0 To superTabControl1.Tabs.Count - 1
                If TypeOf superTabControl1.Tabs(i) Is SuperTabItem = False Then
                    delState = True
                    Exit For
                End If
            Next

            cmiDelBaseItems.Enabled = delState

            ' Show our ContextMenu

            ShowContextMenu(cmBaseItems, e)
        End If
    End Sub

#End Region

#Region "cmiAddBaseItems_Click"

    ''' <summary>
    ''' Handles AddBaseItems selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiAddBaseItems_Click(ByVal sender As Object, ByVal e As EventArgs)
        AddBaseItems()
    End Sub

#End Region

#Region "cmiDelBaseItems_Click"

    ''' <summary>
    ''' Handles DelBaseItems selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiDelBaseItems_Click(ByVal sender As Object, ByVal e As EventArgs)
        DelBaseItems()
    End Sub

#End Region

#Region "cmiStretch_Click"

    ''' <summary>
    ''' Handles Stretch selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiStretch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiStretch.Click
        cbxStretch.Checked = Not cbxStretch.Checked
    End Sub

#End Region

#Region "cmiBaseItemsNear_Click"

    ''' <summary>
    ''' Handles Near selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiBaseItemsNear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiBaseItemsNear.Click
        cbxBaseItemAlignment.SelectedIndex = CInt(eItemAlignment.Near)
    End Sub

#End Region

#Region "cmiBaseItemsCenter_Click"

    ''' <summary>
    ''' Handles Center selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiBaseItemsCenter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiBaseItemsCenter.Click
        cbxBaseItemAlignment.SelectedIndex = CInt(eItemAlignment.Center)
    End Sub

#End Region

#Region "cmiBaseItemsFar_Click"

    ''' <summary>
    ''' Handles Far selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiBaseItemsFar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiBaseItemsFar.Click
        cbxBaseItemAlignment.SelectedIndex = CInt(eItemAlignment.Far)
    End Sub

#End Region

#End Region

#End Region

#Region "ControlBox Visibility"

#Region "cbxControlBoxVisible_CheckedChanged"

    ''' <summary>
    ''' Handles ControlBoxVisible selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxControlBoxVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxControlBoxVisible.CheckedChanged
        superTabControl1.ControlBox.Visible = cbxControlBoxVisible.Checked
    End Sub

#End Region

#Region "cbxCloseBoxVisible_CheckedChanged"

    ''' <summary>
    ''' Handles CloseBoxVisible selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxCloseBoxVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxCloseBoxVisible.CheckedChanged
        superTabControl1.ControlBox.CloseBox.Visible = cbxCloseBoxVisible.Checked
        cbxCloseBoxVisible2.Checked = cbxCloseBoxVisible.Checked
    End Sub

#End Region

#Region "cbxMenuBoxVisible_CheckedChanged"

    ''' <summary>
    ''' Handles MenuBoxVisible selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxMenuBoxVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxMenuBoxVisible.CheckedChanged
        superTabControl1.ControlBox.MenuBox.Visible = cbxMenuBoxVisible.Checked
    End Sub

#End Region

#Region "cbxAutoHide_CheckedChanged"

    ''' <summary>
    ''' Handles AutoHide selection.
    ''' 
    ''' This property controls whether the system will automatically
    ''' hide the ControlBox.MenuBox when it is not needed (ie. when all
    ''' the tabs concurrently are visible in the TabStrip).
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxAutoHide_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxAutoHide.CheckedChanged
        superTabControl1.ControlBox.MenuBox.AutoHide = cbxAutoHide.Checked
        cbxMenuBoxVisible.Checked = superTabControl1.ControlBox.MenuBox.Visible
    End Sub

#End Region

#Region "cbxShowTabsOnly_CheckedChanged"

    ''' <summary>
    ''' Handles ShowTabsOnly selection.
    ''' 
    ''' The ShowTabsOnly property set to true, will cause only
    ''' SuperTabItems to be included in the MenuBox.TabMenu.  Setting
    ''' it to false will cause all Tab entries to be included.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxShowTabsOnly_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxShowTabsOnly.CheckedChanged
        superTabControl1.ControlBox.MenuBox.ShowTabsOnly = cbxShowTabsOnly.Checked
    End Sub

#End Region

#Region "cbxShowImages_CheckedChanged"

    ''' <summary>
    ''' Handles ShowImages selection.
    ''' 
    ''' Setting the ShowImages property to true will cause all
    ''' SuperTabItem entries images to be displayed in the
    ''' MenuBox.TabMenu.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxShowImages_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxShowImages.CheckedChanged
        superTabControl1.ControlBox.MenuBox.ShowImages = cbxShowImages.Checked
    End Sub

#End Region

#Region "cbxRaiseClick_CheckedChanged"

    ''' <summary>
    ''' Handles RaiseClick selection.
    ''' 
    ''' Setting the RaiseClickOnSelection to true will cause the
    ''' MenuBox.TabMenu to Raise a Click event when an item is selected.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxRaiseClick_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxRaiseClick.CheckedChanged
        superTabControl1.ControlBox.MenuBox.RaiseClickOnSelection = cbxRaiseClick.Checked
    End Sub

#End Region

#Region "ContextMenu support"

#Region "stiCbVisibility_MouseUp"

    ''' <summary>
    ''' Handles ControlBoxVisibility mouseUp events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub stiCbVisibility_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles stiCbVisibility.MouseUp
        If e.Button = MouseButtons.Right Then
            cmiControlBoxVis.Checked = cbxControlBoxVisible.Checked
            cmiCloseBoxVis.Checked = cbxCloseBoxVisible.Checked
            cmiMenuBoxVis.Checked = cbxMenuBoxVisible.Checked
            cmiAutoHide.Checked = cbxAutoHide.Checked
            cmiShowTabsOnly.Checked = cbxShowTabsOnly.Checked
            cmiShowImages.Checked = cbxShowImages.Checked
            cmiRaiseClick.Checked = cbxRaiseClick.Checked

            ShowContextMenu(cmControlBoxVis, e)
        End If
    End Sub

#End Region

#Region "cmiControlBoxVis_Click"

    ''' <summary>
    ''' Handles ControlBoxVis selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiControlBoxVis_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiControlBoxVis.Click
        cbxControlBoxVisible.Checked = Not cbxControlBoxVisible.Checked
    End Sub

#End Region

#Region "cmiCloseBoxVis_Click"

    ''' <summary>
    ''' Handles CloseBoxVis selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiCloseBoxVis_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiCloseBoxVis.Click
        cbxCloseBoxVisible.Checked = Not cbxCloseBoxVisible.Checked
    End Sub

#End Region

#Region "cmiMenuBoxVis_Click"

    ''' <summary>
    ''' Handles MenuBoxVis selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiMenuBoxVis_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiMenuBoxVis.Click
        cbxMenuBoxVisible.Checked = Not cbxMenuBoxVisible.Checked
    End Sub

#End Region

#Region "cmiAutoHide_Click"

    ''' <summary>
    '''  Handles AutoHide selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiAutoHide_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiAutoHide.Click
        cbxAutoHide.Checked = Not cbxAutoHide.Checked
    End Sub

#End Region

#Region "cmiShowTabsOnly_Click"

    ''' <summary>
    ''' Handles ShowTabsOnly selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiShowTabsOnly_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiShowTabsOnly.Click
        cbxShowTabsOnly.Checked = Not cbxShowTabsOnly.Checked
    End Sub

#End Region

#Region "cmiShowImages_Click"

    ''' <summary>
    ''' Handles ShowImages selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiShowImages_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiShowImages.Click
        cbxShowImages.Checked = Not cbxShowImages.Checked
    End Sub

#End Region

#Region "cmiRaiseClick_Click"

    ''' <summary>
    ''' Handles RaiseClick selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiRaiseClick_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiRaiseClick.Click
        cbxRaiseClick.Checked = Not cbxRaiseClick.Checked
    End Sub

#End Region

#End Region

#End Region

#Region "ControlBox Customization"

#Region "btxAddBoxItems_Click"

#Region "btxAddBoxItems_Click"

    ''' <summary>
    ''' Initiates the addition of sample ControlBox items
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btxAddBoxItems_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btxAddBoxItems.Click
        AddBoxItems()
    End Sub

#End Region

#Region "AddBoxItems"

    ''' <summary>
    ''' Adds sample items to the ControlBox
    ''' </summary>
    Private Sub AddBoxItems()
        Dim bi As New ButtonItem()

        bi.ImageIndex = 2
        bi.Text = "Help"
        bi.ButtonStyle = eButtonStyle.ImageAndText
        AddHandler bi.Click, AddressOf Help_Click

        Dim sbi As New ButtonItem()
        sbi.Text = "Contact Helpdesk"
        sbi.AutoCollapseOnClick = True
        AddHandler sbi.Click, AddressOf Help_Click

        bi.SubItems.Add(sbi)

        sbi = New ButtonItem()
        sbi.Text = "Contact DevComponents"
        sbi.AutoCollapseOnClick = True
        AddHandler sbi.Click, AddressOf Help_Click

        bi.SubItems.Add(sbi)

        superTabControl1.ControlBox.SubItems.Add(bi)
    End Sub

#End Region

#Region "Help_Click"

    ''' <summary>
    ''' Handles ControlBox sample item selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Help_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)

        If bi IsNot Nothing Then
            MessageBox.Show("""" & bi.Text & """" & " selected!")
        End If
    End Sub

#End Region

#End Region

#Region "btxDelBoxItems_Click"

#Region "btxDelBoxItems_Click"

    ''' <summary>
    ''' Initiates the deletion of any added sample
    ''' ControlBox items
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btxDelBoxItems_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btxDelBoxItems.Click
        DelBoxItems()
    End Sub

#End Region

#Region "DelBoxItems"

    ''' <summary>
    ''' Deletes any previously added ControlBox sample items
    ''' </summary>
    Private Sub DelBoxItems()
        superTabControl1.ControlBox.RemoveUserItems()
    End Sub

#End Region

#End Region

#Region "MenuBox_TabMenuOpen"

    ''' <summary>
    ''' Handles MenuBox_PopupOpen events.
    ''' 
    ''' This event is sent just before the ControlBoxMenuBox.TabMenu is
    ''' opened and displayed.  The user has the ability to add, delete, or
    ''' even cancel the operation.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MenuBox_PopupOpen(ByVal sender As Object, ByVal e As PopupOpenEventArgs)
        ' If the user has said they want us to modify the TabMenu,
        ' just add a couple of items to the list to let them
        ' add or delete new user tabs

        If _ModifyTabMenu = True Then
            Dim pi As PopupItem = sender

            If pi IsNot Nothing Then
                Dim bi As New ButtonItem()
                bi.Text = "Add User Tab"
                bi.BeginGroup = True
                AddHandler bi.Click, AddressOf AddUserTab_Click

                pi.SubItems.Insert(0, bi)

                bi = New ButtonItem()
                bi.Text = "Delete User Tab"
                bi.Tag = superTabControl1.SelectedTab
                AddHandler bi.Click, AddressOf DelUserTab_Click

                pi.SubItems.Insert(1, bi)

                ' Enable the added Delete entry if the currently selected
                ' tab is one they have previously added

                If superTabControl1.SelectedTab Is Nothing OrElse superTabControl1.SelectedTab.Text.StartsWith("New Tab") = False Then
                    bi.Enabled = False
                End If

                If pi.SubItems.Count > 2 Then
                    pi.SubItems(2).BeginGroup = True
                End If
            End If
        End If
    End Sub

#Region "DelUserTab_Click"

    Private Sub DelUserTab_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)

        If bi IsNot Nothing Then
            Dim tab As SuperTabItem = TryCast(bi.Tag, SuperTabItem)

            If tab IsNot Nothing AndAlso tab.Text.StartsWith("New Tab") = True Then
                tab.Close()
            End If
        End If
    End Sub

#End Region

#Region "AddUserTab_Click"

    Private Sub AddUserTab_Click(ByVal sender As Object, ByVal e As EventArgs)
        AddNewUserTab()
    End Sub

#Region "AddNewUserTab"

    Private Sub AddNewUserTab()
        Dim tab As SuperTabItem = superTabControl1.CreateTab("New Tab " & _UserTabCount, 0)
        tab.Tag = _UserTabCount

        _UserTabCount = _UserTabCount + 1

        If cbxAddTabImages.Checked = True Then
            tab.ImageIndex = 12
        End If

        Dim lbx As New LabelX()
        lbx.Text = "This space intentionally left blank."
        lbx.TextAlignment = StringAlignment.Center
        lbx.TextLineAlignment = StringAlignment.Center
        lbx.BackColor = Color.Transparent

        tab.AttachedControl.Controls.Add(lbx)
        lbx.Dock = DockStyle.Fill

        UpdateDelUserButton()
    End Sub

#End Region

#End Region

#Region "UpdateDelUserButton"

    Private Sub UpdateDelUserButton()
        btxDelUserTab.SubItems.Clear()

        For i As Integer = 0 To superTabControl1.Tabs.Count - 1
            Dim tab As SuperTabItem = TryCast(superTabControl1.Tabs(i), SuperTabItem)

            If tab IsNot Nothing Then
                If tab.Text.StartsWith("New Tab") = True Then
                    Dim bi As New ButtonItem()
                    bi.Tag = tab
                    bi.Text = tab.Text
                    AddHandler bi.Click, AddressOf DelUserTab_Click

                    btxDelUserTab.SubItems.Add(bi)
                End If
            End If
        Next

        btxDelUserTab.Enabled = (btxDelUserTab.SubItems.Count > 0)

        btxDelUserTab.RecalcLayout()
    End Sub

#End Region

#End Region

#Region "cbxModifyTabMenu_CheckedChanged"

    ''' <summary>
    ''' Handles ModifyTabMenu selections
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxModifyTabMenu_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxModifyTabMenu.CheckedChanged
        _ModifyTabMenu = cbxModifyTabMenu.Checked
    End Sub

#End Region

#Region "ContextMenu support"

#Region "stiCbCustom_MouseUp"

    ''' <summary>
    ''' Handles ControlBoxCustomization mouseUp events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub stiCbCustom_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles stiCbCustom.MouseUp
        If e.Button = MouseButtons.Right Then
            cmiModifyTabMenu.Checked = cbxModifyTabMenu.Checked

            ShowContextMenu(cmCbCustom, e)
        End If
    End Sub

#End Region

#Region "cmiAddCbItems_Click"

    ''' <summary>
    ''' Handles AddControlBoxItems selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiAddCbItems_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiAddCbItems.Click
        AddBoxItems()
    End Sub

#End Region

#Region "cmiDelCbItems_Click"

    ''' <summary>
    ''' Handles DelControlBoxItems selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiDelCbItems_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiDelCbItems.Click
        DelBoxItems()
    End Sub

#End Region

#Region "cmiModifyTabMenu_Click"

    ''' <summary>
    ''' Handles ModifyTabMenu selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiModifyTabMenu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiModifyTabMenu.Click
        cbxModifyTabMenu.Checked = Not cbxModifyTabMenu.Checked
    End Sub

#End Region

#End Region

#End Region

#Region "CloseBox Visibility"

#Region "cbxCloseBoxVisible2_CheckedChanged"

    ''' <summary>
    ''' Handles CloseBoxVisible selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxCloseBoxVisible2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxCloseBoxVisible2.CheckedChanged
        cbxCloseBoxVisible.Checked = cbxCloseBoxVisible2.Checked
    End Sub

#End Region

#Region "cbxTabCloseVisible_CheckedChanged"

    ''' <summary>
    ''' Handles TabCloseVisible selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxTabCloseVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxTabCloseVisible.CheckedChanged
        superTabControl1.CloseButtonOnTabsVisible = cbxTabCloseVisible.Checked
    End Sub

#End Region

#Region "cbxTabCloseAlwaysDisplayed_CheckedChanged"

    ''' <summary>
    ''' Handles TabCloseAlwaysDisplayed selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxTabCloseAlwaysDisplayed_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxTabCloseAlwaysDisplayed.CheckedChanged
        superTabControl1.CloseButtonOnTabsAlwaysDisplayed = cbxTabCloseAlwaysDisplayed.Checked
    End Sub

#End Region

#Region "cbxTabCloseLeft_CheckedChanged"

    ''' <summary>
    ''' Handles TabCloseLeft selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxTabCloseLeft_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxTabCloseLeft.CheckedChanged
        superTabControl1.CloseButtonPosition = eTabCloseButtonPosition.Left
    End Sub

#End Region

#Region "cbxTabCloseRight_CheckedChanged"

    ''' <summary>
    ''' Handles TabCloseRight selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxTabCloseRight_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxTabCloseRight.CheckedChanged
        superTabControl1.CloseButtonPosition = eTabCloseButtonPosition.Right
    End Sub

#End Region

#Region "ContextMenu support"

#Region "stiCloseVisibility_MouseUp"

    ''' <summary>
    ''' Handles CloseVisibility mouseUp events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub stiCloseVisibility_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles stiCloseVisibility.MouseUp
        If e.Button = MouseButtons.Right Then
            cmiControlBoxCloseVis.Checked = cbxCloseBoxVisible2.Checked
            cmiTabCloseVisible.Checked = cbxTabCloseVisible.Checked
            cmiTabCloseAlwaysDisplayed.Checked = cbxTabCloseAlwaysDisplayed.Checked
            cmiTabCloseLeft.Checked = cbxTabCloseLeft.Checked
            cmiTabCloseRight.Checked = cbxTabCloseRight.Checked

            ShowContextMenu(cmCloseBoxVis, e)
        End If
    End Sub

#End Region

#Region "cmiControlBoxCloseVis_Click"

    ''' <summary>
    ''' Handles ControlBoxCloseVis selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiControlBoxCloseVis_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiControlBoxCloseVis.Click
        cbxCloseBoxVisible2.Checked = Not cbxCloseBoxVisible2.Checked
    End Sub

#End Region

#Region "cmiTabCloseVisible_Click"

    ''' <summary>
    ''' Handles TabCloseVisible selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiTabCloseVisible_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiTabCloseVisible.Click
        cbxTabCloseVisible.Checked = Not cbxTabCloseVisible.Checked
    End Sub

#End Region

#Region "cmiTabCloseAlwaysVisible_Click"

    ''' <summary>
    ''' Handles TabCloseAlwaysDisplayed selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiTabCloseAlwaysDisplayed_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiTabCloseAlwaysDisplayed.Click
        cbxTabCloseAlwaysDisplayed.Checked = Not cbxTabCloseAlwaysDisplayed.Checked
    End Sub

#End Region

#Region "cmiTabCloseLeft_Click"

    ''' <summary>
    ''' Handles TabCloseLeft selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiTabCloseLeft_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiTabCloseLeft.Click
        cbxTabCloseLeft.Checked = Not cbxTabCloseLeft.Checked
    End Sub


#End Region

#Region "cmiTabCloseRight_Click"

    ''' <summary>
    ''' Handles TabCloseRight selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiTabCloseRight_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiTabCloseRight.Click
        cbxTabCloseRight.Checked = Not cbxTabCloseRight.Checked
    End Sub

#End Region

#End Region

#End Region

#Region "User Tab Customization"

#Region "cbxUserDefined_CheckedChanged"

    ''' <summary>
    ''' Handles UserDefined selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxUserDefined_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxUserDefined.CheckedChanged
        If cbxUserDefined.Checked = True Then
            EnableUserDraw()
        Else
            DisableUserDraw()
        End If
    End Sub

#Region "EnableUserDraw"

    ''' <summary>
    ''' Enables call-outs for user defined tab definition
    ''' </summary>
    Private Sub EnableUserDraw()
        AddHandler superTabControl1.MeasureTabItem, AddressOf MeasureTabItem
        AddHandler superTabControl1.PreRenderTabItem, AddressOf PreRenderTabItem
        AddHandler superTabControl1.PostRenderTabItem, AddressOf PostRenderTabItem
        AddHandler superTabControl1.GetTabItemPath, AddressOf GetTabItemPath
        AddHandler superTabControl1.GetTabItemContentRectangle, AddressOf GetTabItemContentRectangle

        ' We are changing how the control is laid out, so force
        ' a recalc of the control to reflect our changes

        superTabControl1.RecalcLayout()
    End Sub

#Region "MeasureTabItem"

    ''' <summary>
    ''' Handles the MeasureTabItem event.
    ''' 
    ''' The e.Size parameter is set to the size the system has
    ''' calculated for the item.  You can add to or subtract from this
    ''' sized value (or replace it all together) - it all depends upon
    ''' how you choose to layout your tab item.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MeasureTabItem(ByVal sender As Object, ByVal e As SuperTabMeasureTabItemEventArgs)
        Dim size As Size = e.Size

        ' Our user defined TabItemPath will have a half-circle bump
        ' on it, so add extra to the width and/or height to allow for it

        If e.Tab.TabAlignment = eTabStripAlignment.Left OrElse e.Tab.TabAlignment = eTabStripAlignment.Right Then
            size.Width += 15
        Else
            size.Height += 15
        End If

        ' Return the new size to the system

        e.Size = size
    End Sub

#End Region

#Region "PreRenderTabItem"

    ''' <summary>
    ''' Handles the PreRenderTabItem event.
    ''' 
    ''' This event gives you the opportunity to totally replace all
    ''' tab drawing by the system - if you return e.Cancel = true.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PreRenderTabItem(ByVal sender As Object, ByVal e As SuperTabPreRenderTabItemEventArgs)
        ' Here just for documentation purposes
    End Sub

#End Region

#Region "PostRenderTabItem"

    ''' <summary>
    ''' Handles PostRenderTabItem events.
    ''' 
    ''' This event lets you handle any rendering to the tab after the system
    ''' has completed all of its rendering.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PostRenderTabItem(ByVal sender As Object, ByVal e As SuperTabPostRenderTabItemEventArgs)
        ' Here just for demonstration purposes

        If e.Tab.Text.StartsWith("New Tab") Then
            Dim n As Integer = CInt((e.Tab.Tag))

            If n Mod 2 = 0 Then
                Using path As GraphicsPath = e.Tab.GetTabItemPath()
                    Dim color1 As Color = Color.FromArgb(30, Color.AliceBlue)
                    Dim color2 As Color = Color.FromArgb(30, Color.Blue)

                    Using br As Brush = New HatchBrush(HatchStyle.LightUpwardDiagonal, color1, color2)
                        e.Graphics.FillPath(br, path)
                    End Using
                End Using
            End If
        End If
    End Sub

#End Region

#Region "GetTabItemPath"

#Region "GetTabItemPath"

    ''' <summary>
    ''' Handles the GetTabItemPath event.
    ''' 
    ''' This event gives you the ability to define your own user
    ''' tab layout.  Your layout is used in conjunction with the 
    ''' TabStyle you have chosen.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GetTabItemPath(ByVal sender As Object, ByVal e As SuperTabGetTabItemPathEventArgs)
        ' Determine what Tab alignment we need to
        ' provide an item path for

        Select Case e.Tab.TabAlignment
            Case eTabStripAlignment.Top
                GetTopItemPath(e)
                Exit Select

            Case eTabStripAlignment.Left
                GetLeftItemPath(e)
                Exit Select

            Case eTabStripAlignment.Bottom
                GetBottomItemPath(e)
                Exit Select
            Case Else

                GetRightItemPath(e)
                Exit Select
        End Select
    End Sub

#End Region

#Region "GetTopItemPath"

    ''' <summary>
    ''' Gets out Top Alignment tab path
    ''' </summary>
    ''' <param name="e"></param>
    Private Sub GetTopItemPath(ByVal e As SuperTabGetTabItemPathEventArgs)
        Dim path As New GraphicsPath()

        ' The ContentRectangle is the rectangle that defines the bounds of
        ' the "content" of the tab (encompassing the the image, text, and closeBox)

        Dim t As Rectangle = e.Tab.ContentRectangle
        Dim r As Rectangle = e.Tab.DisplayRectangle

        r.Width -= 1
        r.Height -= 1

        t.Width -= 1
        t.Height -= 1

        ' If the tab is the selected tab, we need to allow for
        ' the 2 pixel wide TabStrip border

        If e.Tab.IsSelected = True Then
            r.Height += 2
        End If

        ' We are defining a tab that has a knobby on the top, and for the
        ' VisualStudio2008Document style tabs, we want it on the opposite side

        Dim h As Integer = r.Height / 2

        If e.Tab.TabStyle = eSuperTabStyle.VisualStudio2008Document Then
            path.AddLine(r.Right, r.Bottom, r.Right, r.Top + Radius)
            path.AddArc(New Rectangle(r.Right - Radius * 2, r.Top, Radius * 2, Radius * 2), 0, -180)
            path.AddLine(r.Right - Radius * 2, r.Top + Radius * 2, t.X, r.Top + Radius * 2)
            path.AddLine(t.X, r.Top + Radius * 2, t.X, r.Top + h)
            path.AddLine(t.X, r.Top + h, r.X, r.Bottom)
        Else
            path.AddLine(r.X, r.Bottom, r.X, r.Top + Radius)
            path.AddArc(New Rectangle(r.X, r.Top, Radius * 2, Radius * 2), 180, 180)
            path.AddLine(r.X + Radius * 2, r.Top + Radius * 2, t.Right, r.Top + Radius * 2)
            path.AddLine(t.Right, r.Top + Radius * 2, t.Right, r.Top + h)
            path.AddLine(t.Right, r.Top + h, r.Right, r.Bottom)
        End If

        ' Return the path to the system

        e.Path = path
    End Sub

#End Region

#Region "GetLeftItemPath"

    ''' <summary>
    ''' Get the Left Tab alignment path
    ''' </summary>
    ''' <param name="e"></param>
    Private Sub GetLeftItemPath(ByVal e As SuperTabGetTabItemPathEventArgs)
        Dim path As New GraphicsPath()

        ' The ContentRectangle is the rectangle that defines the bounds of
        ' the "content" of the tab (encompassing the the image, text, and closeBox)

        Dim t As Rectangle = e.Tab.ContentRectangle
        Dim r As Rectangle = e.Tab.DisplayRectangle

        r.Width -= 1
        r.Height -= 1

        t.Width -= 1
        t.Height -= 1

        ' If the tab is the selected tab, we need to allow for
        ' the 2 pixel wide TabStrip border

        If e.Tab.IsSelected = True Then
            r.Width += 2
        End If

        ' We are defining a tab that has a knobby on the top, and for the
        ' VisualStudio2008Document style tabs, we want it on the opposite side

        Dim w As Integer = r.Width / 2

        If e.Tab.TabStyle = eSuperTabStyle.VisualStudio2008Document Then
            path.AddLine(r.Right, r.Bottom, r.X + Radius, r.Bottom)
            path.AddArc(New Rectangle(r.X, r.Bottom - Radius * 2, Radius * 2, Radius * 2), 90, 180)
            path.AddLine(r.X + Radius * 2, r.Bottom - Radius * 2, r.X + Radius * 2, t.Top + 2)
            path.AddLine(r.X + Radius * 2, t.Top + 2, r.X + w, t.Top + 2)
            path.AddLine(r.X + w, t.Top + 2, r.Right, r.Top)
        Else
            path.AddLine(r.Right, r.Top, r.X + Radius, r.Top)
            path.AddArc(New Rectangle(r.X, r.Y, Radius * 2, Radius * 2), 270, -180)
            path.AddLine(r.X + Radius * 2, r.Top + Radius * 2, r.X + Radius * 2, t.Bottom)
            path.AddLine(r.X + Radius * 2, t.Bottom, r.X + w, t.Bottom)
            path.AddLine(r.X + w, t.Bottom, r.Right, r.Bottom)
        End If

        ' Return the path to the system

        e.Path = path
    End Sub

#End Region

#Region "GetBottomItemPath"

    ''' <summary>
    ''' Gets the Bottom tab alignment path
    ''' </summary>
    ''' <param name="e"></param>
    Private Sub GetBottomItemPath(ByVal e As SuperTabGetTabItemPathEventArgs)
        Dim path As New GraphicsPath()

        ' The ContentRectangle is the rectangle that defines the bounds of
        ' the "content" of the tab (encompassing the the image, text, and closeBox)

        Dim t As Rectangle = e.Tab.ContentRectangle
        Dim r As Rectangle = e.Tab.DisplayRectangle

        r.Width -= 1
        r.Height -= 1

        t.Width -= 1
        t.Height -= 1

        ' If the tab is the selected tab, we need to allow for
        ' the 2 pixel wide TabStrip border

        If e.Tab.IsSelected = True Then
            r.Y -= 2
            r.Height += 2
        End If

        ' We are defining a tab that has a knobby on the top, and for the
        ' VisualStudio2008Document style tabs, we want it on the opposite side

        Dim h As Integer = r.Height / 2

        If e.Tab.TabStyle = eSuperTabStyle.VisualStudio2008Document Then
            path.AddLine(r.Right, r.Top, r.Right, r.Bottom - Radius)
            path.AddArc(New Rectangle(r.Right - Radius * 2, r.Bottom - Radius * 2, Radius * 2, Radius * 2), 0, 180)
            path.AddLine(r.Right - Radius * 2, r.Bottom - Radius * 2, t.X, r.Bottom - Radius * 2)
            path.AddLine(t.X, r.Bottom - Radius * 2, t.X, r.Top + h)
            path.AddLine(t.X, r.Top + h, r.X, r.Top)
        Else
            path.AddLine(r.X, r.Top, r.X, r.Bottom - Radius)
            path.AddArc(New Rectangle(r.X, r.Bottom - Radius * 2, Radius * 2, Radius * 2), 180, -180)
            path.AddLine(r.X + Radius * 2, r.Bottom - Radius * 2, t.Right, r.Bottom - Radius * 2)
            path.AddLine(t.Right, r.Bottom - Radius * 2, t.Right, r.Top + h)
            path.AddLine(t.Right, r.Top + h, r.Right, r.Top)
        End If

        ' Return the path to the system

        e.Path = path
    End Sub

#End Region

#Region "GetRightItemPath"

    ''' <summary>
    ''' Get the Right Tab alignment path
    ''' </summary>
    ''' <param name="e"></param>
    Private Sub GetRightItemPath(ByVal e As SuperTabGetTabItemPathEventArgs)
        Dim path As New GraphicsPath()

        ' The ContentRectangle is the rectangle that defines the bounds of
        ' the "content" of the tab (encompassing the the image, text, and closeBox)

        Dim t As Rectangle = e.Tab.ContentRectangle
        Dim r As Rectangle = e.Tab.DisplayRectangle

        r.Width -= 1
        r.Height -= 1

        t.Width -= 1
        t.Height -= 1

        ' If the tab is the selected tab, we need to allow for
        ' the 2 pixel wide TabStrip border

        If e.Tab.IsSelected = True Then
            r.X -= 2
            r.Width += 2
        End If

        ' We are defining a tab that has a knobby on the top, and for the
        ' VisualStudio2008Document style tabs, we want it on the opposite side

        Dim w As Integer = r.Width / 2

        If e.Tab.TabStyle = eSuperTabStyle.VisualStudio2008Document Then
            path.AddLine(r.X, r.Bottom, r.Right - Radius, r.Bottom)
            path.AddArc(New Rectangle(r.Right - Radius * 2, r.Bottom - Radius * 2, Radius * 2, Radius * 2), 90, -180)
            path.AddLine(r.Right - Radius * 2, r.Bottom - Radius * 2, r.Right - Radius * 2, t.Top + 2)
            path.AddLine(r.Right - Radius * 2, t.Top + 2, r.X + w, t.Top + 2)
            path.AddLine(r.X + w, t.Top + 2, r.X, r.Top)
        Else
            path.AddLine(r.X, r.Top, r.Right - Radius, r.Top)
            path.AddArc(New Rectangle(r.Right - Radius * 2, r.Y, Radius * 2, Radius * 2), 270, 180)
            path.AddLine(r.Right - Radius * 2, r.Top + Radius * 2, r.Right - Radius * 2, t.Bottom)
            path.AddLine(r.Right - Radius * 2, t.Bottom, r.X + w, t.Bottom)
            path.AddLine(r.X + w, t.Bottom, r.X, r.Bottom)
        End If

        ' Return the path to the system

        e.Path = path
    End Sub

#End Region

#End Region

#Region "GetTabItemContentRectangle"

    ''' <summary>
    ''' Handles the GetTabItemContentRectangle event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GetTabItemContentRectangle(ByVal sender As Object, ByVal e As SuperTabGetTabItemContentRectangleEventArgs)
        ' The ContentRectangle is the rectangle that defines the bounds of
        ' the "content" of the tab (encompassing the the image, text, and closeBox).
        ' If your tab is non-rectangularly shaped, you may not want the
        ' ContentRectangle to be aligned with the DisplayRectangle.

        Dim r As Rectangle = e.ContentRectangle

        ' Offset our ContentRectangle to allow for the bump
        ' we added to our tab paths

        Select Case e.Tab.TabAlignment
            Case eTabStripAlignment.Top
                r.Y += 10
                r.Height -= 10
                Exit Select

            Case eTabStripAlignment.Left
                r.X += 15
                r.Width -= 15
                Exit Select

            Case eTabStripAlignment.Bottom
                r.Height -= 15
                Exit Select

            Case eTabStripAlignment.Right
                r.Width -= 15
                Exit Select
        End Select

        ' Return the ContentRectangle to the system

        e.ContentRectangle = r
    End Sub

#End Region

#End Region

#Region "DisableUserDraw"

    ''' <summary>
    ''' Disables call-outs for user defined tab definition
    ''' </summary>
    Private Sub DisableUserDraw()
        ' Unhook our control events

        RemoveHandler superTabControl1.MeasureTabItem, AddressOf MeasureTabItem
        RemoveHandler superTabControl1.PreRenderTabItem, AddressOf PreRenderTabItem
        RemoveHandler superTabControl1.PostRenderTabItem, AddressOf PostRenderTabItem
        RemoveHandler superTabControl1.GetTabItemPath, AddressOf GetTabItemPath
        RemoveHandler superTabControl1.GetTabItemContentRectangle, AddressOf GetTabItemContentRectangle

        ' Cause a layout recalculation to reflect the changes we just made

        superTabControl1.RecalcLayout()
    End Sub

#End Region

#End Region

#Region "cbxUserCloseBounds_CheckedChanged"

    ''' <summary>
    ''' Handles UserCloseBounds selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxUserCloseBounds_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxUserCloseBounds.CheckedChanged
        If cbxUserCloseBounds.Checked = True Then
            AddHandler superTabControl1.GetTabCloseBounds, AddressOf GetTabCloseBounds
        Else
            RemoveHandler superTabControl1.GetTabCloseBounds, AddressOf GetTabCloseBounds
        End If

        superTabControl1.RecalcLayout()
    End Sub

#Region "GetTabCloseBounds"

    ''' <summary>
    ''' Handles GetTabCloseBounds event.
    ''' 
    ''' This events permits the user to provide an alternate bounding
    ''' rectangle for the tab CloseBox.  It is initially set to the
    ''' system calculated bounds.
    ''' 
    ''' Though we are only providing the CloseBounds, the same principle
    ''' applies if you want/need to specify the Image or Text bounds.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GetTabCloseBounds(ByVal sender As Object, ByVal e As SuperTabGetTabCloseBoundsEventArgs)
        ' Let's put the closeBox at the top of the ContentRectangle
        ' just for sample demo purposes

        Dim r As Rectangle = e.Bounds
        r.X += 2
        r.Y = e.Tab.ContentRectangle.Y + 4

        ' Return the new bounds to the system

        e.Bounds = r
    End Sub

#End Region

#End Region

#Region "cbxPaintBackground_CheckedChanged"

    ''' <summary>
    ''' Handles PaintBackground selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxPaintBackground_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxPaintBackground.CheckedChanged
        If cbxPaintBackground.Checked = True Then
            AddHandler superTabControl1.TabStripPaintBackground, AddressOf TabStripPaintBackground
        Else
            RemoveHandler superTabControl1.TabStripPaintBackground, AddressOf TabStripPaintBackground
        End If

        superTabControl1.TabStrip.Refresh()
    End Sub

#Region "TabStripPaintBackground"

    ''' <summary>
    ''' Handles TabStripPaintBackground events.
    ''' 
    ''' This event permits the user to paint the TabStrip background area. 
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TabStripPaintBackground(ByVal sender As Object, ByVal e As SuperTabStripPaintBackgroundEventArgs)
        Dim r As Rectangle = superTabControl1.TabStrip.DisplayRectangle

        ' Text, or anything could be painted here, but some care might need be taken
        ' to determine available TabStrip display space (as the TabStrip area can
        ' be overlaid by currently defined visible tabs.

        If superTabControl1.TabStyle <> eSuperTabStyle.Office2010BackstageBlue Then
            ' As an example, let's just paint stripes on the TabStrip

            Using pen As New Pen(e.ColorTable.OuterBorder)
                For i As Integer = r.Top + 2 To r.Bottom - 1 Step 2
                    e.Graphics.DrawLine(pen, r.Left, i, r.Right, i)
                Next
            End Using
        End If
    End Sub

#End Region

#End Region

#Region "cbxAddTabImages_CheckedChanged"

    ''' <summary>
    ''' Handles AddTabImages selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxAddTabImages_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbxAddTabImages.CheckedChanged
        If cbxAddTabImages.Checked = True Then
            stiTabStyle.ImageIndex = 3
            stiTabAlignment.ImageIndex = 4
            stiTabSize.ImageIndex = 5
            stiTextAlignment.ImageIndex = 6
            stiColor.ImageIndex = 7
            stiBaseItems.ImageIndex = 8
            stiCbVisibility.ImageIndex = 9
            stiCloseVisibility.ImageIndex = 9
            stiCbCustom.ImageIndex = 10
            stiUserTab.ImageIndex = 11

            SetAllUserTabsImage(12)
        Else
            stiTabStyle.ImageIndex = -1
            stiTabAlignment.ImageIndex = -1
            stiTabSize.ImageIndex = -1
            stiTextAlignment.ImageIndex = -1
            stiColor.ImageIndex = -1
            stiBaseItems.ImageIndex = -1
            stiCbVisibility.ImageIndex = -1
            stiCloseVisibility.ImageIndex = -1
            stiCbCustom.ImageIndex = -1
            stiUserTab.ImageIndex = -1

            SetAllUserTabsImage(-1)
        End If
    End Sub

    ''' <summary>
    ''' Sets user tabs imageIndex
    ''' </summary>
    ''' <param name="index"></param>
    Private Sub SetAllUserTabsImage(ByVal index As Integer)
        For i As Integer = 0 To superTabControl1.Tabs.Count - 1
            Dim tab As SuperTabItem = TryCast(superTabControl1.Tabs(i), SuperTabItem)

            If tab IsNot Nothing Then
                If tab.Text.StartsWith("New Tab") Then
                    tab.ImageIndex = index
                End If
            End If
        Next
    End Sub

#End Region

#Region "CbDefImagePosSelectedIndexChanged"

    Private Sub CbDefImagePosSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbDefImagePos.SelectedIndexChanged
        superTabControl1.ImageAlignment = DirectCast([Enum].Parse(GetType(ImageAlignment), cbDefImagePos.Text), ImageAlignment)
    End Sub

#End Region

#Region "CbImagePosSelectedIndexChanged"

    Private Sub CbImagePosSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbImagePos.SelectedIndexChanged
        Dim tab As SuperTabItem = superTabControl1.SelectedTab

        If tab IsNot Nothing Then
            tab.ImageAlignment = DirectCast([Enum].Parse(GetType(ImageAlignment), cbImagePos.Text), ImageAlignment)
        End If
    End Sub

#End Region

#Region "btxAddUserTab_Click"

    ''' <summary>
    ''' Initiates the addition of a new User tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btxAddUserTab_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btxAddUserTab.Click
        AddNewUserTab()
    End Sub

#End Region

#Region "btxSort_Click"

#Region "btxSort_Click"

    ''' <summary>
    ''' Handles SortTabs selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btxSort_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btxSort.Click
        SortTabs()
    End Sub

#End Region

#Region "SortTabs"

    ''' <summary>
    ''' Sorts the tab according to their item Text
    ''' </summary>
    Private Sub SortTabs()
        Dim keys As String() = New String(superTabControl1.Tabs.Count - 1) {}
        Dim items As BaseItem() = New BaseItem(superTabControl1.Tabs.Count - 1) {}

        For i As Integer = 0 To superTabControl1.Tabs.Count - 1
            items(i) = superTabControl1.Tabs(i)
            keys(i) = superTabControl1.Tabs(i).PlainText
        Next

        Array.Sort(keys, items)

        For i As Integer = 0 To superTabControl1.Tabs.Count - 1
            superTabControl1.Tabs(i) = items(i)
        Next

        superTabControl1.RecalcLayout()
    End Sub

#End Region

#End Region

#Region "btxShuffle_Click"

#Region "btxShuffle_Click"

    ''' <summary>
    ''' Handles Shuffle tabs selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btxShuffle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btxShuffle.Click
        ShuffleTabs()
    End Sub

#End Region

#Region "ShuffleTabs"

    ''' <summary>
    ''' Randomly shuffles the tabs
    ''' </summary>
    Private Sub ShuffleTabs()
        Dim keys As String() = New String(superTabControl1.Tabs.Count - 1) {}
        Dim items As BaseItem() = New BaseItem(superTabControl1.Tabs.Count - 1) {}

        Dim rnd As New Random()

        For i As Integer = 0 To superTabControl1.Tabs.Count - 1
            items(i) = superTabControl1.Tabs(i)
            keys(i) = rnd.[Next]().ToString()
        Next

        Array.Sort(keys, items)

        For i As Integer = 0 To superTabControl1.Tabs.Count - 1
            superTabControl1.Tabs(i) = items(i)
        Next

        superTabControl1.RecalcLayout()
    End Sub

#End Region

#End Region

#Region "ContextMenu support"

#Region "stiUserTab_MouseUp"

    ''' <summary>
    ''' Handles UserTab MouseUp events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub stiUserTab_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles stiUserTab.MouseUp
        If e.Button = MouseButtons.Right Then
            ' Set our Checked states

            cmiUserDrawn.Checked = cbxUserDefined.Checked
            cmiUserCloseBounds.Checked = cbxUserCloseBounds.Checked
            cmiUserPaintBackground.Checked = cbxPaintBackground.Checked
            cmiAddTabImages.Checked = cbxAddTabImages.Checked

            ' Show our ContextMenu

            ShowContextMenu(cmUserTab, e)
        End If
    End Sub

#End Region

#Region "cmiUserDefined_Click"

    ''' <summary>
    ''' Handles UserDefined selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiUserDefined_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiUserDrawn.Click
        cbxUserDefined.Checked = Not cbxUserDefined.Checked
    End Sub

#End Region

#Region "cmiUserCloseBounds_Click"

    ''' <summary>
    ''' Handles UserCloseBounds selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiUserCloseBounds_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiUserCloseBounds.Click
        cbxUserCloseBounds.Checked = Not cbxUserCloseBounds.Checked
    End Sub

#End Region

#Region "cmiUserPaintBackground_Click"

    ''' <summary>
    ''' Handles UserPaintBackground selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiUserPaintBackground_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiUserPaintBackground.Click, cmiPaintBackground.Click
        cbxPaintBackground.Checked = Not cbxPaintBackground.Checked
    End Sub

#End Region

#Region "cmiAddTabImages_Click"

    ''' <summary>
    ''' Handles AddTabImages selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiAddTabImages_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiAddTabImages.Click
        cbxAddTabImages.Checked = Not cbxAddTabImages.Checked
    End Sub

#End Region

#Region "cmiAddUserTab_Click"

    ''' <summary>
    ''' Handles AddUserTab selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiAddUserTab_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiAddUserTab.Click
        AddNewUserTab()
    End Sub

#End Region

#Region "cmiSortTabs_Click"

    ''' <summary>
    ''' Handles SortTabs selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiSortTabs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiSortTabs.Click
        SortTabs()
    End Sub

#End Region

#Region "cmiShuffleTabs_Click"

    ''' <summary>
    ''' Handles ShuffleTabs selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmiShuffleTabs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmiShuffleTabs.Click
        ShuffleTabs()
    End Sub

#End Region

#End Region

#End Region

#Region "SuperTabControl"

#Region "superTabControl1_TabItemClose"

    ''' <summary>
    ''' Handles TabItemClose events.
    ''' 
    ''' This event is sent before a tab is actually closed. This event gives
    ''' you the chance to selectively cancel the close operation.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub superTabControl1_TabItemClose(ByVal sender As Object, ByVal e As SuperTabStripTabItemCloseEventArgs)
        Dim tab As SuperTabItem = TryCast(e.Tab, SuperTabItem)

        ' In our sample app, only let the user close tabs they have added

        If tab Is Nothing OrElse tab.Text.StartsWith("New Tab") = False Then
            MessageBox.Show("This app selectively let's you close only 'Newly Added Tabs'")

            e.Cancel = True
        End If
    End Sub

#End Region

#Region "superTabControl1_TabRemoved"

    ''' <summary>
    ''' Handles TabRemoved events.
    ''' 
    ''' This event is sent after a tab has been closed.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub superTabControl1_TabRemoved(ByVal sender As Object, ByVal e As SuperTabStripTabRemovedEventArgs)
        UpdateDelUserButton()
    End Sub

#End Region

#Region "superTabControl1_TabMoved"

    ''' <summary>
    ''' Handles TabMoved events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub superTabControl1_TabMoved(ByVal sender As Object, ByVal e As SuperTabStripTabMovedEventArgs)
        If e.Tab.Text.StartsWith("New Tab") = True Then
            MessageBox.Show("User Tab Moved!")
        End If
    End Sub

#End Region

#Region "superTabControl1_TabStripMouseUp"

    ''' <summary>
    ''' Handles TabStrip MouseUp events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub superTabControl1_TabStripMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles superTabControl1.TabStripMouseUp
        If e.Button = MouseButtons.Right Then
            ' Set our Checked state

            cmiPaintBackground.Checked = cbxPaintBackground.Checked

            ' Show the context menu for the TabStrip

            ShowContextMenu(cmTabStrip, e)
        End If
    End Sub

#End Region

#End Region

#Region "ShowContextMenu"

    ''' <summary>
    ''' Shows the given ContextMenu
    ''' </summary>
    ''' <param name="cm">ContextMenu to show</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub ShowContextMenu(ByVal cm As ButtonItem, ByVal e As MouseEventArgs)
        cm.Popup(MousePosition)
    End Sub

#End Region

End Class
