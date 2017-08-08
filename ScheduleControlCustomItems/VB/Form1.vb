Public Class Form1
    Inherits Office2007Form

#Region "Private variables"

    Private _CustomUserID As Integer = 1
    Private _ColorCycle As Integer = 0

#Region "_MyAppColorTable"

    ' DefaultBorder
    ' DefaultBackground
    ' BlueBorder
    ' BlueBackground
    ' GreenBorder
    ' GreenBackground
    ' OrangeBorder
    ' OrangeBackground
    ' PurpleBorder
    ' PurpleBackground
    ' RedBorder
    ' RedBackground
    ' YellowBorder
    ' YellowBackground
    ' BusyTimeMarker
    ' FreeTimeMarker
    ' OutOfOfficeTimeMarker

    Private _MyAppColorTable As ColorDef() = New ColorDef() { _
        New ColorDef(&H4B71A2), _
        New ColorDef(New Integer() {&HCCCC, &H6B6B}, New Single() {0.0F, 1.0F}, 90.0F), _
        New ColorDef(&H28518E), _
        New ColorDef(New Integer() {&HAAFF, &H47B2}, New Single() {0.0F, 1.0F}, 90.0F), _
        New ColorDef(&H2C6524), _
        New ColorDef(New Integer() {&HFF00, &H7D00}, New Single() {0.0F, 1.0F}, 90.0F), _
        New ColorDef(&H8B3E0A), _
        New ColorDef(New Integer() {&HFFB200, &HB26B00}, New Single() {0.0F, 1.0F}, 90.0F), _
        New ColorDef(&H3E2771), _
        New ColorDef(New Integer() {&HEABFFE, &H660099}, New Single() {0.0F, 1.0F}, 90.0F), _
        New ColorDef(&H86171C), _
        New ColorDef(New Integer() {&HFFB0B0, &HCC0000}, New Single() {0.0F, 1.0F}, 90.0F), _
        New ColorDef(&H7C7814), _
        New ColorDef(New Integer() {&HFFFF00, &HB2B300}, New Single() {0.0F, 1.0F}, 90.0F), _
        New ColorDef(-1), _
        New ColorDef(&HFFFFFF), _
        New ColorDef(&H0)}

#End Region

#End Region

    Public Sub New()

        BarUtilities.UseTextRenderer = True

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Set our Calendar Model

        calendarView1.CalendarModel = New CalendarModel()

        ' And add some sample appointments

        AddSampleAppointments()

    End Sub

#Region "AddSampleAppointments"

    ''' <summary>
    ''' Adds some example appointments to the Calendar Model
    ''' </summary>
    Private Sub AddSampleAppointments()
        ' Recurring appointment

        Dim appointment As New Appointment()

        appointment.Subject = "Recurring Appointment every 3rd week day"
        appointment.Description = "Custom description for this appointment"
        appointment.Tooltip = "This is a Custom tooltip for this appointment"

        appointment.CategoryColor = Appointment.CategoryOrange

        appointment.StartTime = DateTime.Today.AddHours(11.25)
        appointment.EndTime = appointment.StartTime.AddHours(1)

        appointment.Recurrence = New AppointmentRecurrence()

        ' Set recurrence type to Daily

        appointment.Recurrence.RecurrenceType = eRecurrencePatternType.Daily
        appointment.Recurrence.Daily.RepeatOnDaysOfWeek = eDailyRecurrenceRepeat.All
        appointment.Recurrence.Daily.RepeatInterval = 10
        appointment.Recurrence.RangeLimitType = eRecurrenceRangeLimitType.RangeEndDate
        appointment.Recurrence.RangeEndDate = DateTime.Today.AddDays(120)

        ' Add appointment to the model

        calendarView1.CalendarModel.Appointments.Add(appointment)

        Dim startDate As DateTime = DateTime.Today.AddHours(8)

        ' Multi-day appointment #1

        AddAppointment("#1 Multiple days Appointment", _
            startDate, startDate.AddDays(4), appointment.CategoryBlue, _
            appointment.TimerMarkerDefault)

        ' Multi-day appointment #2

        AddAppointment("#2 Multiple days Appointment", _
            startDate.AddDays(2), startDate.AddDays(14.5), appointment.CategoryGreen, _
            appointment.TimerMarkerDefault)

        ' Create some new appointments and add them to the model

        Dim ap As Appointment = AddAppointment("Busy Appointment", _
            startDate, startDate.AddMinutes(180), appointment.CategoryYellow, _
            appointment.TimerMarkerBusy)

        ' Make sure this appointment is visible

        calendarView1.EnsureVisible(ap)

        AddAppointment("Out Of Office Appointment", _
            startDate.AddHours(1), startDate.AddHours(2), appointment.CategoryBlue, _
            appointment.TimerMarkerOutOfOffice)

        startDate = startDate.AddDays(1)

        AddAppointment("Free Appointment", _
            startDate.AddHours(2), startDate.AddMinutes(170), appointment.CategoryRed, _
            appointment.TimerMarkerFree)

        AddAppointment("Tentative Appointment", _
            startDate.AddHours(4), startDate.AddHours(6), appointment.CategoryDefault, _
            appointment.TimerMarkerTentative)

        startDate = startDate.AddDays(1)

        AddAppointment("Default Appointment", _
            startDate.AddHours(1.5), startDate.AddHours(4.25), appointment.CategoryPurple, _
            appointment.TimerMarkerDefault)
    End Sub

#Region "AddAppointment"

    ''' <summary>
    ''' Adds the specified appointment to the model
    ''' </summary>
    ''' <param name="s">Appointment subject</param>
    ''' <param name="startTime">Appointment start time</param>
    ''' <param name="endTime">Appointment end time</param>
    ''' <param name="color">Appointment color</param>
    ''' <param name="marker">Appointment marker</param>
    Private Function AddAppointment(ByVal s As String, ByVal startTime As DateTime, ByVal endTime As DateTime, ByVal color As String, ByVal marker As String) As Appointment
        Dim appointment As New Appointment()

        appointment.StartTime = startTime
        appointment.EndTime = endTime

        appointment.Subject = s
        appointment.Description = "Custom description for this appointment"
        appointment.CategoryColor = color
        appointment.TimeMarkedAs = marker

        appointment.Tooltip = "This is a Custom tooltip for this appointment"

        calendarView1.CalendarModel.Appointments.Add(appointment)

        Return (appointment)
    End Function

#End Region

#End Region

#Region "View change"

    ''' <summary>
    ''' Day view selection
    ''' </summary>
    ''' <param name="sender">PopupItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnDay_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDay.Click
        calendarView1.SelectedView = eCalendarView.Day
    End Sub

    ''' <summary>
    ''' Week view selection
    ''' </summary>
    ''' <param name="sender">PopupItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnWeek_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnWeek.Click
        calendarView1.SelectedView = eCalendarView.Week
    End Sub

    ''' <summary>
    ''' Month view selection
    ''' </summary>
    ''' <param name="sender">PopupItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnMonth_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMonth.Click
        calendarView1.SelectedView = eCalendarView.Month
    End Sub

    ''' <summary>
    ''' TimeLine view selection
    ''' </summary>
    ''' <param name="sender">PopupItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnTimeLine_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTimeLine.Click
        calendarView1.SelectedView = eCalendarView.TimeLine
    End Sub

#End Region

#Region "calendarView1_ItemDoubleClick"

    ''' <summary>
    ''' Handles Appointment View double clicks
    ''' </summary>
    ''' <param name="sender">AppointmentView</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub calendarView1_ItemDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles calendarView1.ItemDoubleClick
        Dim item As AppointmentView = TryCast(sender, AppointmentView)

        If item IsNot Nothing Then
            Dim ap As Appointment = item.Appointment
            Dim CategoryColor As String = ap.CategoryColor
            Dim TimeMarkedAs As String = ap.TimeMarkedAs

            If String.IsNullOrEmpty(CategoryColor) Then
                CategoryColor = "Default"
            End If

            If String.IsNullOrEmpty(TimeMarkedAs) Then
                TimeMarkedAs = "Default"
            End If

            Dim s As String = String.Format("Subject: {0}" & vbLf & "Description: {1}" & vbLf & _
                "ToolTip: {2}" & vbLf & vbLf & "StartTime: {3}" & vbLf & "EndTime: {4}" & vbLf & vbLf & _
                "CategoryColor: {5}" & vbLf & "TimeMarkedAs: {6}", _
                ap.Subject, ap.Description, ap.Tooltip, ap.StartTime, ap.EndTime, _
                CategoryColor, TimeMarkedAs)

            MessageBox.Show(s)
        End If
    End Sub

#End Region

#Region "CalendarView1_MouseUp"

    ''' <summary>
    ''' Handles CalendarView MouseUp events
    ''' </summary>
    ''' <param name="sender">Varied sender</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub CalendarView1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles calendarView1.MouseUp
        ' Process Right MouseUp event in order to
        ' present view specific ContextMenu

        If e.Button = MouseButtons.Right Then
            ' Main Calendar View hit

            If TypeOf sender Is BaseView Then
                BaseViewMouseUp(sender, e)

                ' AppointmentView hit

            ElseIf TypeOf sender Is AppointmentView Then
                AppointmentViewMouseUp(sender, e)

                ' AllDayPanel hit

            ElseIf TypeOf sender Is AllDayPanel Then
                AllDayPanelMouseUp(sender, e)

                ' TimeRulerPanel

            ElseIf TypeOf sender Is TimeRulerPanel Then
                TimeRulerPanelMouseUp(sender, e)

                ' TimeLineHeaderPanel

            ElseIf TypeOf sender Is TimeLineHeaderPanel Then
                TimeLineHeaderPanelMouseUp(sender, e)

                ' CustomCalendarItem

            ElseIf TypeOf sender Is CustomCalendarItem Then
                CustomCalendarItemMouseUp(sender, e)

            ElseIf TypeOf sender Is BaseItem Then
                Dim bi As BaseItem = TryCast(sender, BaseItem)

                If TypeOf bi.Parent Is CustomCalendarItem Then
                    CustomCalendarItemMouseUp(bi.Parent, e)
                End If
            End If
        End If
    End Sub

#Region "BaseViewMouseUp"

    ''' <summary>
    ''' Handles Day, Week, and Month View MouseUp events
    ''' </summary>
    ''' <param name="sender">BaseView</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub BaseViewMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim view As BaseView = TryCast(sender, BaseView)
        Dim area As eViewArea = view.GetViewAreaFromPoint(e.Location)

        If area = eViewArea.InContent Then
            InContentMouseUp(view, e)

        ElseIf area = eViewArea.InDayOfWeekHeader Then
            InHeaderMouseUp(view, e)

        ElseIf area = eViewArea.InSideBarPanel Then
            InSideBarMouseUp(view, e)

        ElseIf area = eViewArea.InCondensedView Then
            InCondensedViewMouseUp(e)
        End If
    End Sub

#Region "InContentMouseUp"

    ''' <summary>
    ''' Handles BaseView InContent MouseUp events
    ''' </summary>
    ''' <param name="view">BaseView</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub InContentMouseUp(ByVal view As BaseView, ByVal e As MouseEventArgs)
        ' Get the DateSelection start and end
        ' from the current mouse location

        Dim startDate As DateTime, endDate As DateTime

        If calendarView1.GetDateSelectionFromPoint(e.Location, startDate, endDate) = True Then
            ' If this date already falls outside the currently
            ' selected range (DateSelectionStart and DateSelectionEnd)
            ' then select the new range

            If IsDateSelected(startDate, endDate) = False Then
                calendarView1.DateSelectionStart = startDate
                calendarView1.DateSelectionEnd = endDate
            End If
        End If

        ' Remove any previously added view specific items

        For i As Integer = InContentContextMenu.SubItems.Count - 1 To 4 Step -1
            InContentContextMenu.SubItems.RemoveAt(i)
        Next

        ' If this is a TimeLine view, then add a couple
        ' of extra items

        If TypeOf view Is TimeLineView Then
            Dim bi As New ButtonItem()

            ' Page Navigator

            If calendarView1.TimeLineShowPageNavigation = True Then
                bi.Text = "Hide Page Navigator"
            Else
                bi.Text = "Show Page Navigator"
            End If

            bi.BeginGroup = True

            AddHandler bi.Click, AddressOf bi_PageNavigatorClick

            InContentContextMenu.SubItems.Add(bi)

            ' Condensed Visibility

            If calendarView1.TimeLineCondensedViewVisibility = eCondensedViewVisibility.Hidden Then
                bi = New ButtonItem("", "Show Condensed View")
                AddHandler bi.Click, AddressOf bi_CondensedClick

                InContentContextMenu.SubItems.Add(bi)
            End If
        End If

        ShowContextMenu(InContentContextMenu)
    End Sub

#Region "bi_CondensedClick"

    ''' <summary>
    ''' Handles InContentContextMenu Condensed selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub bi_CondensedClick(ByVal sender As Object, ByVal e As EventArgs)
        calendarView1.TimeLineCondensedViewVisibility = eCondensedViewVisibility.AllResources
    End Sub

#End Region

#Region "bi_PageNavigatorClick"

    ''' <summary>
    ''' Handles InContentContextMenu PageNavigator selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub bi_PageNavigatorClick(ByVal sender As Object, ByVal e As EventArgs)
        calendarView1.TimeLineShowPageNavigation = (calendarView1.TimeLineShowPageNavigation = False)
    End Sub

#End Region

#Region "IsDateSelected"

    ''' <summary>
    ''' Determines if the given date range is within the currently selected
    ''' CalendarView selection range (DateSelectionStart to DateSelectionEnd)
    ''' </summary>
    ''' <param name="startDate">Start date range</param>
    ''' <param name="endDate">End date range</param>
    ''' <returns>True if selected</returns>
    Private Function IsDateSelected(ByVal startDate As DateTime, ByVal endDate As DateTime) As Boolean
        If calendarView1.DateSelectionStart.HasValue AndAlso calendarView1.DateSelectionEnd.HasValue Then
            If calendarView1.DateSelectionStart.Value <= startDate AndAlso calendarView1.DateSelectionEnd.Value >= endDate Then
                Return (True)
            End If
        End If

        Return (False)
    End Function

#End Region

#Region "miAdd_Click"

    ''' <summary>
    ''' Handles BaseView "Add Appointment" 
    ''' ContextMenu selections
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InContentAddAppContextItem.Click
        Dim startDate As DateTime = calendarView1.DateSelectionStart.GetValueOrDefault()
        Dim endDate As DateTime = calendarView1.DateSelectionEnd.GetValueOrDefault()

        AddNewAppointment(startDate, endDate)
    End Sub

    ''' <summary>
    ''' Adds a new appointment at the user selected time
    ''' </summary>
    Private Function AddNewAppointment(ByVal startDate As DateTime, ByVal endDate As DateTime) As Appointment
        ' Create new appointment and add it to the model
        ' Appointment will show up in the view automatically

        Dim appointment As New Appointment()

        appointment.StartTime = startDate
        appointment.EndTime = endDate

        appointment.Subject = "New " & appointment.CategoryColor & " appointment!"

        appointment.Description = "This is a new appointment"
        appointment.Tooltip = "This is a Custom tooltip for this new appointment"

        ' Add appointment to the model

        calendarView1.CalendarModel.Appointments.Add(appointment)

        Return (appointment)
    End Function

#End Region

#End Region

#Region "InHeaderMouseUp"

    ''' <summary>
    ''' Handles BaseView InHeader MouseUp events.
    ''' </summary>
    ''' <param name="view">BaseView</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub InHeaderMouseUp(ByVal view As BaseView, ByVal e As MouseEventArgs)
        If TypeOf view Is MonthView Then
            Dim mv As MonthView = TryCast(view, MonthView)

            ' The View is a month view, so let the user
            ' hide or show the SideBar panel

            If mv.IsSideBarVisible = True Then
                InHeaderHideSideBarContextItem.Visible = True
                InHeaderShowSideBarContextItem.Visible = False
            Else
                InHeaderHideSideBarContextItem.Visible = False
                InHeaderShowSideBarContextItem.Visible = True
            End If
        Else
            InHeaderHideSideBarContextItem.Visible = False
            InHeaderShowSideBarContextItem.Visible = False
        End If

        InHeaderContextMenu.Tag = view

        ShowContextMenu(InHeaderContextMenu)
    End Sub

#Region "miCalendarColor_Click"

    ''' <summary>
    ''' Handles selection of a ContextMenu color item
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miCalendarColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InHeaderCalColorYellow.Click, InHeaderCalColorTeal.Click, InHeaderCalColorSteel.Click, InHeaderCalColorRed.Click, InHeaderCalColorPurple.Click, InHeaderCalColorOlive.Click, InHeaderCalColorMaroon.Click, InHeaderCalColorGreen.Click, InHeaderCalColorDarkSteel.Click, InHeaderCalColorDarkPeach.Click, InHeaderCalColorDarkGreen.Click, InHeaderCalColorBlue.Click, InHeaderCalColorAutomatic.Click
        Dim mi As ButtonItem = TryCast(sender, ButtonItem)
        Dim view As BaseView = TryCast(mi.Parent.Tag, BaseView)

        If view IsNot Nothing Then
            view.CalendarColor = DirectCast([Enum].Parse(GetType(eCalendarColor), mi.Text), eCalendarColor)
        End If
    End Sub

#End Region

#Region "SideBar show/hide"

    ''' <summary>
    ''' Handles ContextMenu "Show" for the SideBar panel
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miShowSideBar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InHeaderShowSideBarContextItem.Click
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)
        Dim view As MonthView = TryCast(bi.Parent.Tag, MonthView)

        If view IsNot Nothing Then
            view.IsSideBarVisible = True
        End If
    End Sub

    ''' <summary>
    ''' Handles ContextMenu "Hide" for the SideBar panel
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miHideSideBar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InHeaderHideSideBarContextItem.Click, InSideBarHideContextItem.Click
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)
        Dim view As MonthView = TryCast(bi.Parent.Tag, MonthView)

        If view IsNot Nothing Then
            view.IsSideBarVisible = False
        End If
    End Sub

#End Region

#End Region

#Region "InSideBarMouseUp"

    ''' <summary>
    ''' Handles SideBar MouseUp events
    ''' </summary>
    ''' <param name="view">BaseView</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub InSideBarMouseUp(ByVal view As BaseView, ByVal e As MouseEventArgs)
        InSideBarContextMenu.Tag = view

        ShowContextMenu(InSideBarContextMenu)
    End Sub

#End Region

#Region "InCondensedViewMouseUp"

    ''' <summary>
    ''' Handles Mouse Up events in the CondensedView
    ''' area of the control
    ''' </summary>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub InCondensedViewMouseUp(ByVal e As MouseEventArgs)
        ShowContextMenu(CondensedViewContextMenu)
    End Sub

#End Region

#End Region

#Region "AppointmentViewMouseUp"

    ''' <summary>
    ''' Handles AppointmentView MouseUp events
    ''' </summary>
    ''' <param name="sender">AppointmentView</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub AppointmentViewMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim view As AppointmentView = TryCast(sender, AppointmentView)

        ' Select the appointment
        view.IsSelected = True

        ' Let the user delete the appointment
        AppDeleteContextItem.Enabled = (view.Appointment.IsRecurringInstance = False)
        AppointmentContextMenu.Tag = view

        ShowContextMenu(AppointmentContextMenu)
    End Sub

#Region "miDelete_Click"

    ''' <summary>
    ''' Handles BaseView "Delete Appointment" 
    ''' ContextMenu selections
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AppDeleteContextItem.Click
        Dim mi As ButtonItem = TryCast(sender, ButtonItem)
        Dim view As AppointmentView = TryCast(mi.Parent.Tag, AppointmentView)

        If view IsNot Nothing Then
            calendarView1.CalendarModel.Appointments.Remove(view.Appointment)
        End If
    End Sub

#End Region

#Region "Color item code"

    Private Sub CategoryColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AppCatYellow.Click, AppCatRed.Click, AppCatPurple.Click, AppCatOrange.Click, AppCatGreen.Click, AppCatDefault.Click, AppCatBlue.Click
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)
        Dim view As AppointmentView = TryCast(bi.Parent.Tag, AppointmentView)

        If view IsNot Nothing Then
            view.Appointment.CategoryColor = bi.Text
        End If
    End Sub

#End Region

#Region "Marker item code"
    Private Sub TimeMarker_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AppMarkerTentative.Click, AppMarkerOutOfOffice.Click, AppMarkerFree.Click, AppMarkerDefault.Click, AppMarkerBusy.Click
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)
        Dim view As AppointmentView = TryCast(bi.Parent.Tag, AppointmentView)

        If view IsNot Nothing Then
            If bi.Text.Equals("Default") Then
                view.Appointment.TimeMarkedAs = Nothing
            Else
                view.Appointment.TimeMarkedAs = bi.Text
            End If
        End If
    End Sub

#End Region

#End Region

#Region "AllDayPanelMouseUp"

    ''' <summary>
    ''' Handles AllDayPanel MouseUp events
    ''' </summary>
    ''' <param name="sender">AllDayPanel</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub AllDayPanelMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' Let the user Shrink and expand the panel
        ' by 20 each time

        AllDayShrinkContextItem.Enabled = calendarView1.FixedAllDayPanelHeight = -1 OrElse calendarView1.FixedAllDayPanelHeight > 20

        AllDayGrowContextItem.Enabled = calendarView1.FixedAllDayPanelHeight < 200
        AllDayReset.Enabled = calendarView1.FixedAllDayPanelHeight <> -1
        AllDayPanelContextMenu.Tag = sender

        ShowContextMenu(AllDayPanelContextMenu)
    End Sub

    ''' <summary>
    ''' Handles "Shrink" ContextMenu selections
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miShrink_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AllDayShrinkContextItem.Click
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)
        Dim panel As AllDayPanel = TryCast(bi.Parent.Tag, AllDayPanel)

        If calendarView1.FixedAllDayPanelHeight = -1 Then
            calendarView1.FixedAllDayPanelHeight = panel.PanelHeight - 20
        Else

            calendarView1.FixedAllDayPanelHeight = Math.Max(20, calendarView1.FixedAllDayPanelHeight - 20)
        End If
    End Sub

    ''' <summary>
    ''' Handles "Grow" ContextMenu selections
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miGrow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AllDayGrowContextItem.Click
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)
        Dim panel As AllDayPanel = TryCast(bi.Parent.Tag, AllDayPanel)

        If calendarView1.FixedAllDayPanelHeight = -1 Then
            calendarView1.FixedAllDayPanelHeight = panel.PanelHeight + 20
        Else

            calendarView1.FixedAllDayPanelHeight = Math.Min(500, calendarView1.FixedAllDayPanelHeight + 20)
        End If
    End Sub

    ''' <summary>
    ''' Handles "Reset" ContextMenu selections
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AllDayReset.Click
        calendarView1.FixedAllDayPanelHeight = -1
    End Sub

#End Region

#Region "TimeRulerPanelMouseUp"

    ''' <summary>
    ''' Handles TimeRulerPanel MouseUp events
    ''' </summary>
    ''' <param name="sender">TimeRulerPanel</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub TimeRulerPanelMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        ShowContextMenu(TimeRulerPanelContextMenu)
    End Sub

    ''' <summary>
    ''' Handles "TimeSlotDuration" ContextMenu selections
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miTimeDuration_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TimeDuration30.Click, buttonItem9.Click, buttonItem8.Click, buttonItem7.Click, buttonItem6.Click, buttonItem22.Click, buttonItem16.Click, buttonItem15.Click, buttonItem13.Click, buttonItem12.Click, buttonItem11.Click
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)

        Dim duration As Integer

        If Integer.TryParse(bi.Text, duration) = True Then
            calendarView1.TimeSlotDuration = duration
        End If
    End Sub

#End Region

#Region "TimeLineHeaderPanelMouseUp"

    ''' <summary>
    ''' Handles Mouse Up events in the TimeLineHeaderPanel.
    ''' 
    ''' (The TimeLineHeaderPanel is the area at the top of the
    ''' TimeLineView that holds the Period and Interval Headers.)
    ''' </summary>
    ''' <param name="sender">TimeLineHeaderPanel</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub TimeLineHeaderPanelMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim tp As TimeLineHeaderPanel = TryCast(sender, TimeLineHeaderPanel)

        If tp IsNot Nothing Then
            Dim area As eViewArea = tp.GetViewAreaFromPoint(e.Location)

            If area = eViewArea.InPeriodHeader Then
                InPeriodHeaderMouseUp(e)

            ElseIf area = eViewArea.InIntervalHeader Then
                InIntervalHeaderMouseUp(e)
            End If
        End If
    End Sub

#Region "InPeriodHeaderMouseUp"

    ''' <summary>
    ''' Handles MouseUp events in the Period Header
    ''' </summary>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub InPeriodHeaderMouseUp(ByVal e As MouseEventArgs)
        ShowContextMenu(PeriodHeaderContextMenu)
    End Sub

#End Region

#Region "InPeriodHeaderHide_Click"

    ''' <summary>
    ''' Handles Period Header "Hide" menu selections
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub InPeriodHeaderHide_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InPeriodHeaderHide.Click
        calendarView1.TimeLineShowPeriodHeader = False
    End Sub

#End Region

#Region "PeriodHeaderContextMenu Period change"

    ''' <summary>
    ''' Handles PeriodHeaderContextMenu "Minute" selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPeriodMinutes_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnPeriodMinutes.Click
        If btnPeriodMinutes.Checked = True Then
            calendarView1.TimeLinePeriod = eTimeLinePeriod.Minutes
        End If
    End Sub

    ''' <summary>
    ''' Handles PeriodHeaderContextMenu "Hours" selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPeriodHours_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnPeriodHours.Click
        If btnPeriodHours.Checked = True Then
            calendarView1.TimeLinePeriod = eTimeLinePeriod.Hours
        End If
    End Sub

    ''' <summary>
    ''' Handles PeriodHeaderContextMenu "Days" selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPeriodDays_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnPeriodDays.Click
        If btnPeriodDays.Checked = True Then
            calendarView1.TimeLinePeriod = eTimeLinePeriod.Days
        End If
    End Sub

    ''' <summary>
    ''' Handles PeriodHeaderContextMenu "Years" selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPeriodYears_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles btnPeriodYears.Click
        If btnPeriodYears.Checked = True Then
            calendarView1.TimeLinePeriod = eTimeLinePeriod.Years
        End If
    End Sub

#End Region

#Region "InIntervalHeaderMouseUp"

    ''' <summary>
    ''' Handles MouseUp events in the IntervalHeader
    ''' </summary>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub InIntervalHeaderMouseUp(ByVal e As MouseEventArgs)
        ' Get rid of any previously added non-essential items

        For i As Integer = IntervalHeaderContextMenu.SubItems.Count - 1 To 3 Step -1
            IntervalHeaderContextMenu.SubItems.RemoveAt(i)
        Next

        ' If the Period Header is not visible, present the user
        ' with the items to be able to re-show it

        lblPeriodHeader2.Visible = (calendarView1.TimeLineShowPeriodHeader = False)

        btnIntervalHeaderShow.Visible = (calendarView1.TimeLineShowPeriodHeader = False)

        ' Add some Interval time selection options
        ' for the current selected Interval Period

        Select Case calendarView1.TimeLinePeriod
            Case eTimeLinePeriod.Minutes
                AddIntervalMinutes()
                Exit Select

            Case eTimeLinePeriod.Hours
                AddIntervalHours()
                Exit Select

            Case eTimeLinePeriod.Days
                AddIntervalDays()
                Exit Select

            Case eTimeLinePeriod.Years
                AddIntervalYears()
                Exit Select
        End Select

        ShowContextMenu(IntervalHeaderContextMenu)
    End Sub

#Region "Interval time support"

#Region "AddIntervalMinutes"

    ''' <summary>
    ''' Adds Interval "Minute" items
    ''' </summary>
    Private Sub AddIntervalMinutes()
        For i As Integer = 1 To 60
            If 60 Mod i = 0 Then
                AddIntervalItem(i)
            End If
        Next
    End Sub

#End Region

#Region "AddIntervalHours"

    ''' <summary>
    ''' Adds Interval "Hour" items
    ''' </summary>
    Private Sub AddIntervalHours()
        For i As Integer = 1 To 24
            If 24 Mod i = 0 Then
                AddIntervalItem(i)
            End If
        Next
    End Sub

#End Region

#Region "AddIntervalDays"

    ''' <summary>
    ''' Adds Interval "Day" items
    ''' </summary>
    Private Sub AddIntervalDays()
        For i As Integer = 1 To 10
            AddIntervalItem(i)
        Next

        For i As Integer = 30 To 199 Step 30
            AddIntervalItem(i)
        Next

        AddIntervalItem(365)
    End Sub

#End Region

#Region "AddIntervalYears"

    ''' <summary>
    ''' Adds Interval "Year" items
    ''' </summary>
    Private Sub AddIntervalYears()
        For i As Integer = 1 To 10
            AddIntervalItem(i)
        Next
    End Sub

#End Region

#Region "AddIntervalItem"

    ''' <summary>
    ''' Adds individual Interval items
    ''' </summary>
    ''' <param name="i">Item to add</param>
    Private Sub AddIntervalItem(ByVal i As Integer)
        Dim bi As New ButtonItem("", i.ToString())

        AddHandler bi.Click, AddressOf bi_IntervalClick

        If calendarView1.TimeLineInterval = i Then
            bi.Checked = True
        End If

        IntervalHeaderContextMenu.SubItems.Add(bi)
    End Sub

#End Region

#Region "bi_IntervalClick"

    ''' <summary>
    ''' Handles Interval time selections
    ''' </summary>
    ''' <param name="sender">ButtonItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub bi_IntervalClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)

        Dim n As Integer

        If Integer.TryParse(bi.Text, n) = True Then
            calendarView1.TimeLineInterval = n
        End If
    End Sub

#End Region

#End Region

#Region "btnIntervalHeaderShow_Click"

    ''' <summary>
    ''' Handles IntervalHeaderContextMenu "Show Header" selections
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnIntervalHeaderShow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnIntervalHeaderShow.Click
        CalendarView1.TimeLineShowPeriodHeader = True
    End Sub

#End Region

#End Region

#End Region

#Region "CustomCalendarItemMouseUp"

    ''' <summary>
    ''' Handles CustomUserItem MouseUp events
    ''' </summary>
    ''' <param name="sender">CustomCalendarItem</param>
    ''' <param name="e">MouseEventArgs</param>
    Private Sub CustomCalendarItemMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim item As CustomCalendarItem = TryCast(sender, CustomCalendarItem)

        ' Select the item
        item.IsSelected = True

        ' Let the user delete the appointment
        CustomItemContextMenu.Tag = item

        ShowContextMenu(CustomItemContextMenu)
    End Sub

#Region "miItemDelete_Click"

    ''' <summary>
    ''' Handles Deletion of CustomCalendarItem
    ''' ContextMenu selections
    ''' </summary>
    ''' <param name="sender">MenuItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub miItemDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CustomDeleteContextItem.Click
        Dim mi As ButtonItem = TryCast(sender, ButtonItem)
        Dim item As CustomCalendarItem = TryCast(mi.Parent.Tag, CustomCalendarItem)

        If item IsNot Nothing Then
            calendarView1.CustomItems.Remove(item)
        End If
    End Sub

#End Region

#End Region

#Region "ShowContextMenu"

    ''' <summary>
    ''' Shows the given ContextMenu
    ''' </summary>
    ''' <param name="cm">ContextMenu to show</param>
    Private Sub ShowContextMenu(ByVal cm As ButtonItem)
        Dim pt As Point = Control.MousePosition
        cm.Popup(pt)
    End Sub

#End Region

#End Region

#Region "CondensedViewContextMenu support"

    ''' <summary>
    ''' Handles "AllResources" selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCondensedViewAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCondensedViewAll.Click
        ' AllResources - This selection enables Condensed
        ' views to be displayed in every visible TimeLine
        ' when Multiuser TimeLine views are displayed

        CalendarView1.TimeLineCondensedViewVisibility = eCondensedViewVisibility.AllResources
    End Sub

    ''' <summary>
    ''' Handles "SelectedResource" selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCondensedViewSelected_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCondensedViewSelected.Click
        ' SelectedResource - This selection enables Condensed
        ' views to be displayed only in the currently selected
        ' TimeLine view when Multiuser TimeLine views are displayed

        CalendarView1.TimeLineCondensedViewVisibility = eCondensedViewVisibility.SelectedResource
    End Sub

    ''' <summary>
    ''' Handles "Hidden" selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCondensedViewHidden_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCondensedViewHidden.Click
        ' Hidden - This selection disables all Condensed
        ' views from being displayed

        CalendarView1.TimeLineCondensedViewVisibility = eCondensedViewVisibility.Hidden
    End Sub

#End Region

#Region "Color Scheme Selection"

    ''' <summary>
    ''' Selects the Office2007Blue color scheme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Office2007Blue_Click(ByVal sender As Object, ByVal e As EventArgs)
        styleManager1.ManagerStyle = eStyle.Office2007Blue
    End Sub

    ''' <summary>
    ''' Selects the Office2007Silver color scheme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Office2007Silver_Click(ByVal sender As Object, ByVal e As EventArgs)
        styleManager1.ManagerStyle = eStyle.Office2007Silver
    End Sub

    ''' <summary>
    ''' Selects the Office2007Black color scheme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Office2007Black_Click(ByVal sender As Object, ByVal e As EventArgs)
        styleManager1.ManagerStyle = eStyle.Office2007Black
    End Sub

    ''' <summary>
    ''' Selects the Office2007VistaGlass color scheme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Office2007VistaGlass_Click(ByVal sender As Object, ByVal e As EventArgs)
        styleManager1.ManagerStyle = eStyle.Office2007VistaGlass
    End Sub

    ''' <summary>
    ''' Selects the Office2010Silver color scheme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Office2010Silver_Click(ByVal sender As Object, ByVal e As EventArgs)
        styleManager1.ManagerStyle = eStyle.Office2010Silver
    End Sub

    ''' <summary>
    ''' Selects the Windows7Blue color scheme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Windows7Blue_Click(ByVal sender As Object, ByVal e As EventArgs)
        styleManager1.ManagerStyle = eStyle.Windows7Blue
    End Sub

#End Region

#Region "btnToday_Click"

    ''' <summary>
    ''' Sets the calendar view display to today's date
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnToday_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnToday.Click
        calendarView1.ShowDate(DateTime.Today)
    End Sub

#End Region

#Region "btnNewAppointment_Click"

    ''' <summary>
    ''' Adds a new appointment to the calendar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNewAppointment_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNewAppointment.Click
        ' Get dates to add appointment to

        Dim startDate As DateTime, endDate As DateTime
        GetAddDates(startDate, endDate)

        ' Create new appointment and add it to the model
        ' Appointment will show up in the view automatically

        Dim ap As Appointment = AddNewAppointment(startDate, endDate)

        ' Make sure the appointment is visible

        calendarView1.EnsureVisible(ap)
    End Sub

#End Region

#Region "btnNewGlossyItem_Click"

    ''' <summary>
    ''' Adds a new GlossyCustomItem to the calendar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNewGlossyItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNewGlossyItem.Click
        ' Get dates to add item to

        Dim startDate As DateTime, endDate As DateTime
        GetAddDates(startDate, endDate)

        ' Create new GlossyCustomItem and add it to the model.
        ' Item will show up in the view automatically

        Dim item As New GlossyCustomItem()

        item.StartTime = startDate
        item.EndTime = endDate

        item.Text = "Custom GlossyItem - ID #" & _CustomUserID
        item.Tooltip = "User defined " & item.Text

        _CustomUserID = _CustomUserID + 1

        calendarView1.CustomItems.Add(item)

        ' Make sure it is visible

        calendarView1.EnsureVisible(item)
    End Sub

#End Region

#Region "btnNewNoteItem_Click"

    ''' <summary>
    ''' Adds a new NoteCustomItem to the calendar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNewNoteItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNewNoteItem.Click
        ' Get dates to add item to

        Dim startDate As DateTime, endDate As DateTime
        GetAddDates(startDate, endDate)

        ' Create new NoteCustomItem and add it to the model.
        ' Item will show up in the view automatically

        Dim s As String = "This is an example of a CustomCalendarItem. " & _
            "It's sole purpose is to display this text on the Calendar."

        Dim item As New NoteCustomItem(s)

        item.StartTime = startDate
        item.EndTime = endDate

        item.Tooltip = "User defined NoteCustomItem!"

        calendarView1.CustomItems.Add(item)

        ' Make sure the item is visible

        calendarView1.EnsureVisible(item)
    End Sub

#End Region

#Region "btnNewButtonItem_Click"

    ''' <summary>
    ''' Adds a new CustomItem #3 to the calendar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNewButtonItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNewButtonItem.Click
        ' Get dates to add item to

        Dim startDate As DateTime, endDate As DateTime
        GetAddDates(startDate, endDate)

        ' Create new ButtonCustomItem and add it to the model.
        ' Item will show up in the view automatically

        Dim item As New ButtonCustomItem(calendarView1)

        item.StartTime = startDate
        item.EndTime = endDate

        item.Text = "Custom ButtonItem - ID #" & _CustomUserID
        item.Tooltip = "User defined " & item.Text

        _CustomUserID = _CustomUserID + 1

        calendarView1.CustomItems.Add(item)

        ' Make sure the item is visible

        calendarView1.EnsureVisible(item)
    End Sub

#End Region

#Region "GetAddDates"

    ''' <summary>
    ''' Gets start and end addition dates
    ''' </summary>
    ''' <param name="startDate">[out]start date</param>
    ''' <param name="endDate">[out]end date</param>
    Private Sub GetAddDates(ByRef startDate As DateTime, ByRef endDate As DateTime)
        If calendarView1.DateSelectionStart.HasValue AndAlso calendarView1.DateSelectionEnd.HasValue Then
            startDate = calendarView1.DateSelectionStart.Value
            endDate = calendarView1.DateSelectionEnd.Value
        Else
            startDate = DateTime.Today.AddDays(3).AddHours(5)
            endDate = startDate.AddHours(2.5)
        End If
    End Sub

#End Region

#Region "labelItem1_MarkupLinkClick"
    Private Sub labelItem1_MarkupLinkClick(ByVal sender As Object, ByVal e As MarkupLinkClickEventArgs) Handles labelItem1.MarkupLinkClick
        System.Diagnostics.Process.Start("http://www.devcomponents.com/kb/questions.php?questionid=122&vs")
    End Sub
#End Region

#Region "InContentAddGlossyItem_Click"

    ''' <summary>
    ''' Adds a GlossyCustomItem to the calendar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub InContentAddGlossyItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InContentAddGlossyItem.Click
        Dim startDate As DateTime = calendarView1.DateSelectionStart.GetValueOrDefault()
        Dim endDate As DateTime = calendarView1.DateSelectionEnd.GetValueOrDefault()

        Dim item As New GlossyCustomItem()

        item.StartTime = startDate
        item.EndTime = endDate

        item.Text = "Custom GlossyItem - ID #" & _CustomUserID
        item.Tooltip = "User defined " & item.Text

        _CustomUserID = _CustomUserID + 1

        calendarView1.CustomItems.Add(item)
    End Sub

#End Region

#Region "InContentAddNoteItem_Click"

    ''' <summary>
    ''' Adds a NoteCustomItem to the calendar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub InContentAddNoteItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InContentAddNoteItem.Click
        Dim startDate As DateTime = calendarView1.DateSelectionStart.GetValueOrDefault()
        Dim endDate As DateTime = calendarView1.DateSelectionEnd.GetValueOrDefault()

        Dim s As String = "This is an example of a CustomCalendarItem. " & _
            "It's sole purpose is to display this text on the Calendar."

        Dim item As New NoteCustomItem(s)

        item.StartTime = startDate
        item.EndTime = endDate

        item.Tooltip = "User defined Custom NoteItem - ID #" & _CustomUserID

        _CustomUserID = _CustomUserID + 1

        item.Image = Me.imageList1.Images(0)

        calendarView1.CustomItems.Add(item)
    End Sub

#End Region

#Region "InContentAddButtonItem_Click"

    ''' <summary>
    ''' Adds a ButtonCustomItem to the calendar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub InContentAddButtonItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles InContentAddButtonItem.Click
        Dim startDate As DateTime = calendarView1.DateSelectionStart.GetValueOrDefault()
        Dim endDate As DateTime = calendarView1.DateSelectionEnd.GetValueOrDefault()

        Dim item As New ButtonCustomItem(calendarView1)

        item.StartTime = startDate
        item.EndTime = endDate

        item.Text = "Custom ButtonItem - ID #" & _CustomUserID
        item.Tooltip = "User defined " & item.Text

        _CustomUserID = _CustomUserID + 1

        calendarView1.CustomItems.Add(item)
    End Sub

#End Region

#Region "SetAppColors1_Click"

    ''' <summary>
    ''' Processes "Set Appointment Color #1" request.
    ''' 
    ''' This routine changes the Appointment colors by
    ''' replacing the global AppointmentColor table
    ''' with my local AppointmentColor table.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SetAppColors1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SetAppColors.Click
        If TypeOf GlobalManager.Renderer Is Office2007Renderer Then
            Dim ct As Office2007ColorTable = DirectCast(GlobalManager.Renderer, Office2007Renderer).ColorTable

            ct.CalendarView.AppointmentColors = _MyAppColorTable

            calendarView1.Refresh()
        End If
    End Sub

#End Region

#Region "SetAppColors2_Click"

    ''' <summary>
    ''' Processes "Set Appointment Color #2" request.
    ''' 
    ''' Though the effect is basically the same as done via
    ''' setting the entire Appointment color table (as in SetAppColors1_Click),
    ''' this routine does so by setting each Appointment color individually.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SetAppColors2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SetWildAppColors.Click
        Dim renderer As Office2007Renderer = TryCast(GlobalManager.Renderer, Office2007Renderer)

        If renderer IsNot Nothing Then
            Dim ct As ColorDef() = New ColorDef([Enum].GetValues(GetType(eAppointmentPart)).Length - 1) {}

            ct(CInt(eAppointmentPart.DefaultBorder)) = New ColorDef(Color.Black)

            ct(CInt(eAppointmentPart.DefaultBackground)) = New _
                ColorDef(New Color() {Color.White, Color.LightGray, Color.Gainsboro, Color.Black}, New Single() {0.0F, 0.3, 0.6, 1.0F}, 45)

            ct(CInt(eAppointmentPart.BlueBorder)) = New ColorDef(Color.MidnightBlue)

            ct(CInt(eAppointmentPart.BlueBackground)) = New _
                ColorDef(New Color() {Color.White, Color.LightBlue, Color.SkyBlue, Color.MidnightBlue}, New Single() {0.0F, 0.3, 0.6, 1.0F}, 45)

            ct(CInt(eAppointmentPart.OrangeBorder)) = New ColorDef(Color.OrangeRed)

            ct(CInt(eAppointmentPart.OrangeBackground)) = New _
                ColorDef(New Color() {Color.White, Color.DarkOrange, Color.Orange, Color.OrangeRed}, New Single() {0.0F, 0.3, 0.6, 1.0F}, 45)

            ct(CInt(eAppointmentPart.PurpleBorder)) = New ColorDef(Color.Indigo)

            ct(CInt(eAppointmentPart.PurpleBackground)) = New _
                ColorDef(New Color() {Color.White, Color.BlueViolet, Color.MediumPurple, Color.Indigo}, New Single() {0.0F, 0.6, 0.65, 1.0F}, 45)

            ct(CInt(eAppointmentPart.RedBorder)) = New ColorDef(Color.Maroon)

            ct(CInt(eAppointmentPart.RedBackground)) = New _
                ColorDef(New Color() {Color.White, Color.LightPink, Color.MistyRose, Color.Maroon}, New Single() {0.0F, 0.3, 0.6, 1.0F}, 45)

            ct(CInt(eAppointmentPart.GreenBorder)) = New ColorDef(Color.DarkGreen)

            ct(CInt(eAppointmentPart.GreenBackground)) = New _
                ColorDef(New Color() {Color.White, Color.LightGreen, Color.Chartreuse, Color.DarkGreen}, New Single() {0.0F, 0.3, 0.6, 1.0F}, 45)

            ct(CInt(eAppointmentPart.YellowBorder)) = New ColorDef(Color.Black)

            ct(CInt(eAppointmentPart.YellowBackground)) = New _
                ColorDef(New Color() {Color.White, Color.LightYellow, Color.LightGoldenrodYellow, Color.Yellow}, New Single() {0.0F, 0.1, 0.4, 1.0F}, 45)

            ct(CInt(eAppointmentPart.BusyTimeMarker)) = New ColorDef(Color.Yellow)
            ct(CInt(eAppointmentPart.FreeTimeMarker)) = New ColorDef(-1)
            ct(CInt(eAppointmentPart.OutOfOfficeTimeMarker)) = New ColorDef(Color.White)

            renderer.ColorTable.CalendarView.AppointmentColors = ct

            calendarView1.Refresh()
        End If
    End Sub

#End Region

#Region "SetCategoryColors_Click"

    ''' <summary>
    ''' Processes "Set Appointment CategoryColors" request.
    ''' 
    ''' This routine establishes a set of user defined CategoryColors.
    ''' User defined CategoryColors can be used in place of (or in addition to)
    ''' the built-in Appointment.CategoryColor values.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SetCategoryColors_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SetCategoryColors.Click

        ' If we haven't defined any CategoryColors, do so now

        If calendarView1.CategoryColors.Count = 0 Then

            ' Create a new AppointmentCategoryColor and add
            ' it to the CalendarView.CategoryColors

            Dim cdef As New ColorDef(New Integer() {&HFF7800, &HE05600, &HB53700}, New Single() {0.0F, 0.5, 1.0F})

            Dim acc As New AppointmentCategoryColor("MyOrangeColor", Color.White, Color.DarkRed, cdef)

            calendarView1.CategoryColors.Add(acc)

            ' Create a new AppointmentCategoryColor and use it to
            ' redefine the current Appointment.CategoryYellow color set

            acc = New AppointmentCategoryColor("Yellow", Color.Black, Color.DarkGreen, New ColorDef(Color.Yellow, Color.YellowGreen))

            calendarView1.CategoryColors.Add(acc)

            ' Go through our current appointments and set all CategoryOrange
            ' appointments to use our newly defined MyOrangeColor CategoryColor

            For i As Integer = 0 To calendarView1.CalendarModel.Appointments.Count - 1
                If calendarView1.CalendarModel.Appointments(i).CategoryColor = Appointment.CategoryOrange Then
                    calendarView1.CalendarModel.Appointments(i).CategoryColor = "MyOrangeColor"
                End If
            Next
        End If
    End Sub

#End Region

#Region "ResetAppColors_Click"

    ''' <summary>
    ''' Resets the Appointment colors back to the Blue default
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ResetAppColors_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ResetAppColors.Click
        ' Get Office2007Renderer

        Dim renderer As Office2007Renderer = TryCast(GlobalManager.Renderer, Office2007Renderer)

        If renderer IsNot Nothing Then
            ' Get Office2007ColorTable

            Dim ct As New Office2007ColorTable(eOffice2007ColorScheme.Blue)

            renderer.ColorTable.CalendarView.AppointmentColors = ct.CalendarView.AppointmentColors

            calendarView1.Refresh()
        End If

        ' Go through our current appointments are reset all MyOrangeColor CategoryColor
        ' settings back to their previous CategoryOrange settings

        For i As Integer = 0 To calendarView1.CalendarModel.Appointments.Count - 1
            If calendarView1.CalendarModel.Appointments(i).CategoryColor = "MyOrangeColor" Then
                calendarView1.CalendarModel.Appointments(i).CategoryColor = Appointment.CategoryOrange
            End If
        Next

        ' Clear our CategoryColors

        calendarView1.CategoryColors.Clear()

    End Sub

#End Region

#Region "CycleViewColors_Click"

    ''' <summary>
    ''' Sets the current View colors by cycling through a new
    ''' RGB combination each time this routine is called.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CycleViewColors_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CycleViewColors.Click
        If TypeOf GlobalManager.Renderer Is Office2007Renderer Then
            Dim ct As Office2007ColorTable = DirectCast(GlobalManager.Renderer, Office2007Renderer).ColorTable

            For Each val As Integer In [Enum].GetValues(GetType(eCalendarWeekDayPart))
                SetNewScheme(ct.CalendarView.WeekDayViewColors(val).Colors)
            Next

            For Each val As Integer In [Enum].GetValues(GetType(eCalendarMonthPart))
                SetNewScheme(ct.CalendarView.MonthViewColors(val).Colors)
            Next

            For Each val As Integer In [Enum].GetValues(GetType(eTimeRulerPart))
                SetNewScheme(ct.CalendarView.TimeRulerColors(val).Colors)
            Next

            calendarView1.Refresh()

            _ColorCycle += 1
        End If
    End Sub

    ''' <summary>
    ''' Sets new colors for the given color table
    ''' </summary>
    ''' <param name="colors">Color Table</param>
    Private Sub SetNewScheme(ByVal colors As Color())
        ' Loop through each color in the table

        For i As Integer = 0 To colors.Length - 1
            colors(i) = GetNewColor(colors(i))
        Next
    End Sub

    ''' <summary>
    ''' Gets a new RGB cycle color
    ''' </summary>
    ''' <param name="color1">Current color</param>
    ''' <returns>New cycled color</returns>
    Private Function GetNewColor(ByVal color1 As Color) As Color
        If (_ColorCycle And 1) = 0 Then
            Return (Color.FromArgb(color1.R, color1.B, color1.G))
        End If

        Return (Color.FromArgb(color1.G, color1.R, color1.B))
    End Function

#End Region

#Region "ResetViewColors_Click"

    ''' <summary>
    ''' Reset the View colors back to the Blue default
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ResetViewColors_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ResetViewColors.Click
        ' Get Office2007Renderer

        Dim renderer As Office2007Renderer = TryCast(GlobalManager.Renderer, Office2007Renderer)

        If renderer IsNot Nothing Then
            ' Get Office2007ColorTable

            Dim ct As New Office2007ColorTable(eOffice2007ColorScheme.Blue)

            renderer.ColorTable.CalendarView.WeekDayViewColors = ct.CalendarView.WeekDayViewColors
            renderer.ColorTable.CalendarView.MonthViewColors = ct.CalendarView.MonthViewColors
            renderer.ColorTable.CalendarView.TimeRulerColors = ct.CalendarView.TimeRulerColors

            calendarView1.Refresh()
        End If
    End Sub

#End Region

End Class
