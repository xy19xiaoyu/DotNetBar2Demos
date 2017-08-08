Public Class ButtonCustomItem
    Inherits CustomCalendarItem

#Region "Constants"

    ' Corner radius
    Private Const _Radius As Integer = 20

    ' Resize area size
    Private Const _ResizeArea As Integer = 5

#End Region

#Region "Private variables"

    ' Added Button
    Private _Button As ButtonItem

    ' Associated CalendarView
    Private _CalendarView As CalendarView

    ' Item was moved flag
    Private _BoundsChanged As Boolean

#End Region

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
        Me.New(Nothing)
    End Sub

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <param name="CalendarView">Associated CalendarView</param>
    Public Sub New(ByVal CalendarView As CalendarView)
        _CalendarView = CalendarView

        ' Lets add a simple Buttons to our item

        _Button = New ButtonItem()

        _Button.Text = "Goto CalendarItem"
        _Button.ColorTable = eButtonColor.BlueOrb
        _Button.AutoExpandOnClick = False
        _Button.Displayed = True

        ' Add a subItem placeholder so that the user has visual indication
        ' that there are items present - though we will not actually load
        ' the items until the "PopupOpen" event activation is fired

        _Button.SubItems.Add(New ButtonItem("", ""))

        SubItems.Add(_Button)

        ' Hook onto our required events

        HookEvents(True)
    End Sub

#Region "Public properties"

#Region "Bounds"

    ''' <summary>
    ''' Item Bounding rectangle
    ''' </summary>
    Public Overloads Overrides Property Bounds() As Rectangle
        Get
            Return (MyBase.Bounds)
        End Get

        Set(ByVal value As Rectangle)
            If Bounds.Equals(value) = False Then
                MyBase.Bounds = value

                ' Keep our SubItems in-sync with the new
                ' item Bounds

                UpdateSubBounds()

                ' Flag the fact that the item's bounds changed
                ' so that we don't present the SubItem popup
                ' on Bounds change

                _BoundsChanged = True
            End If
        End Set
    End Property

    ''' <summary>
    ''' Updates our SubItem bounds
    ''' </summary>
    Private Sub UpdateSubBounds()
        For i As Integer = 0 To SubItems.Count - 1
            SubItems(i).Bounds = Bounds
        Next
    End Sub

#End Region

#Region "Tooltip"

    ''' <summary>
    ''' Gets or sets the control tooltip
    ''' 
    ''' We are overriding this property so that we can
    ''' automatically keep our included Button's tooltip
    ''' in-sync with our custom calendar item
    ''' </summary>
    Public Overloads Overrides Property Tooltip() As String
        Get
            Return (MyBase.Tooltip)
        End Get

        Set(ByVal value As String)
            If MyBase.Tooltip.Equals(value) = False Then
                MyBase.Tooltip = value

                _Button.Tooltip = value
            End If
        End Set
    End Property

#End Region

#End Region

#Region "HookEvents"

    ''' <summary>
    ''' Hooks or unhooks system events
    ''' </summary>
    ''' <param name="hook">true to hook, false to unhook</param>
    Private Sub HookEvents(ByVal hook As Boolean)
        If hook = True Then
            AddHandler _Button.PopupOpen, AddressOf Button_PopupOpen

            AddHandler _Button.MouseDown, AddressOf Button_MouseDown
            AddHandler _Button.MouseUp, AddressOf Button_MouseUp
        Else
            RemoveHandler _Button.PopupOpen, AddressOf Button_PopupOpen

            RemoveHandler _Button.MouseDown, AddressOf Button_MouseDown
            RemoveHandler _Button.MouseUp, AddressOf Button_MouseUp
        End If
    End Sub

#End Region

#Region "Event processing"

#Region "Button_PopupOpen"

    ''' <summary>
    ''' Processes Button PopupOpen events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_PopupOpen(ByVal sender As Object, ByVal e As PopupOpenEventArgs)
        ' If the user has moved the item on the calendar, then
        ' don't permit the associated popup to be displayed

        If _BoundsChanged = False Then
            ' Reload the popup with the current list
            ' of Appointments and CustomItems

            If _CalendarView IsNot Nothing Then
                _Button.SubItems.Clear()

                AddAppointments()
                AddCustomItems()
            End If
        End If
    End Sub

#Region "AddAppointments"

    ''' <summary>
    ''' Adds CalendarView Appointments to our list
    ''' </summary>
    Private Sub AddAppointments()
        ' Get the current list of Appointments

        Dim apc As AppointmentCollection = _CalendarView.CalendarModel.Appointments

        ' Loop through each appointment

        Dim itemsAdded As Boolean = False

        For i As Integer = 0 To apc.Count - 1
            ' Check to see if the given appointment
            ' is a valid one for this Owner

            If _CalendarView.SelectedOwner = "" OrElse apc(i).OwnerKey.Equals(_CalendarView.SelectedOwner) Then
                Dim bi As New ButtonItem()

                ' If we haven't already done so, add a heading

                If itemsAdded = False Then
                    itemsAdded = True

                    bi.Text = "Appointments"
                    bi.ColorTable = eButtonColor.BlueOrb
                    bi.Displayed = True

                    _Button.SubItems.Add(bi)

                    bi = New ButtonItem()
                End If

                ' Add the appointment to the list

                Dim s As String = _
                    [String].Format("{0}<div padding=""8,0,0,0""><font Color=""darkred"" size=""-2"">{1}</font></div>", _
                    apc(i).Subject, apc(i).StartTime)

                bi.Text = s
                bi.BeginGroup = True

                bi.ColorTable = eButtonColor.Orange
                bi.Displayed = True
                bi.Tag = apc(i)

                AddHandler bi.Click, AddressOf App_Click

                _Button.SubItems.Add(bi)
            End If
        Next
    End Sub

#End Region

#Region "AddCustomItems"

    ''' <summary>
    ''' Adds CalendarView CustomItems to our list
    ''' </summary>
    Private Sub AddCustomItems()
        ' Get the current list of CustomItems

        Dim cic As CustomCalendarItemCollection = _CalendarView.CustomItems

        ' Loop through each appointment

        Dim itemAdded As Boolean = False

        For i As Integer = 0 To cic.Count - 1
            ' Check to see if the given item
            ' is a valid one for this Owner

            If _CalendarView.SelectedOwner = "" OrElse cic(i).OwnerKey.Equals(_CalendarView.SelectedOwner) Then
                Dim bi As New ButtonItem()

                ' If we haven't already done so, add a heading

                If itemAdded = False Then
                    itemAdded = True

                    bi.Displayed = True
                    bi.Text = "CustomItems"
                    bi.ColorTable = eButtonColor.BlueOrb

                    _Button.SubItems.Add(bi)

                    bi = New ButtonItem()
                End If

                ' Add the item to the list

                Dim s As String = _
                    [String].Format("{0}<div padding=""8,0,0,0""><font Color=""darkred"" size=""-2"">{1}</font></div>", _
                    cic(i).Text, cic(i).StartTime)

                bi.Text = s
                bi.BeginGroup = True

                bi.Displayed = True
                bi.ColorTable = eButtonColor.Orange
                bi.Tag = cic(i)

                AddHandler bi.Click, AddressOf User_Click

                _Button.SubItems.Add(bi)
            End If
        Next
    End Sub

#End Region

#End Region

#Region "Button_MouseUp"

    ''' <summary>
    ''' Processes Button MouseUp events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' If the left button is presses and the user hasn't moved
        ' the item, then present the associated subItem popup

        If e.Button = MouseButtons.Left AndAlso _BoundsChanged = False Then
            Dim c As Control = DirectCast(_CalendarView.GetContainerControl(), Control)

            If c IsNot Nothing Then
                Dim pt As New Point(_Button.Bounds.Left, _Button.Bounds.Bottom)

                _Button.Popup(c.PointToScreen(pt))
            End If
        End If
    End Sub

#End Region

#Region "Button_MouseDown"

    ''' <summary>
    ''' Processes Button MouseDown events
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' Clear our _BoundsChanged state flag

        If _Button.PopupControl Is Nothing Then
            _BoundsChanged = False
        Else
            _BoundsChanged = True
        End If

    End Sub

#End Region

#End Region

#Region "App_Click / User_Click"

    ''' <summary>
    ''' Processes SubItem Appointment selection
    ''' </summary>
    ''' <param name="sender">ButtonItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub App_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)

        If bi IsNot Nothing Then
            Dim app As Appointment = TryCast(bi.Tag, Appointment)

            ' Move this item to the selected appointment StartTime

            If app IsNot Nothing Then
                MoveItem(app.StartTime)
            End If
        End If

        _Button.ClosePopup()
    End Sub

    ''' <summary>
    ''' Processes SubItem CustomItem selection
    ''' </summary>
    ''' <param name="sender">ButtonItem</param>
    ''' <param name="e">EventArgs</param>
    Private Sub User_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim bi As ButtonItem = TryCast(sender, ButtonItem)

        If bi IsNot Nothing Then
            Dim item As CustomCalendarItem = TryCast(bi.Tag, CustomCalendarItem)

            ' If the user selected a non-ButtonCustomItem, then
            ' move this item to the selected appointment StartTime.
            '
            ' If they selected another ButtonCustomItem then just
            ' ensure it is visible

            If item IsNot Nothing Then
                If TypeOf item Is ButtonCustomItem = False Then
                    MoveItem(item.StartTime)
                Else
                    _CalendarView.EnsureVisible(item)
                End If
            End If
        End If

        _Button.ClosePopup()
    End Sub

    ''' <summary>
    ''' Moves the given item to the specified startTime
    ''' </summary>
    ''' <param name="startTime1">StartTime to move the item to</param>
    Private Sub MoveItem(ByVal startTime1 As DateTime)
        Dim ts As TimeSpan = EndTime - StartTime
        Dim endTime1 As DateTime = startTime1.Add(ts)

        ' Don't let our item cross day boundaries

        If startTime1.Day <> endTime1.Day Then
            startTime1 = startTime1.[Date]
            endTime1 = startTime1.Add(ts)
        End If

        _CalendarView.CustomItems.BeginUpdate()

        StartTime = startTime1
        EndTime = endTime1

        _CalendarView.CustomItems.EndUpdate()

        _CalendarView.EnsureVisible(Me)
    End Sub

#End Region

#Region "RecalcSize"

    ''' <summary>
    ''' Recalculates the size of the item
    ''' </summary>
    Public Overloads Overrides Sub RecalcSize()
        MyBase.RecalcSize()

        For i As Integer = 0 To Me.SubItems.Count - 1
            Me.SubItems(i).WidthInternal = WidthInternal
            Me.SubItems(i).HeightInternal = HeightInternal

            Me.SubItems(i).RecalcSize()

            SubItems(i).Bounds = Bounds
        Next
    End Sub

#End Region

#Region "Paint processing"

    ''' <summary>
    ''' Initiates the Painting of the item
    ''' </summary>
    ''' <param name="e"></param>
    Public Overloads Overrides Sub Paint(ByVal e As ItemPaintArgs)
        Dim g As Graphics = e.Graphics

        ' Lets have it draw as best it can

        Dim comp As CompositingQuality = g.CompositingQuality
        g.CompositingQuality = CompositingQuality.HighQuality

        DrawBorder(e)
        DrawContent(e)

        ' Set our CompostingQuality back

        g.CompositingQuality = comp
    End Sub

#Region "DrawBorder"

    ''' <summary>
    ''' Draws the item border
    ''' </summary>
    ''' <param name="e">ItemPaintArgs</param>
    Private Sub DrawBorder(ByVal e As ItemPaintArgs)
        Dim g As Graphics = e.Graphics

        Using path As GraphicsPath = GetItemPath(g, 0)
            g.DrawPath(Pens.Black, path)
        End Using
    End Sub

#End Region

#Region "DrawContent"

    ''' <summary>
    ''' Draws the content area of the item
    ''' </summary>
    ''' <param name="e"></param>
    Private Sub DrawContent(ByVal e As ItemPaintArgs)
        Dim g As Graphics = e.Graphics

        ' Grab a path slightly inset from the border

        Using gPath As GraphicsPath = GetItemPath(g, -1)
            ' Set up a new clip region for the item

            Dim rgnSave As Region = g.Clip

            Using rgn As New Region(rgnSave.GetRegionData())
                rgn.Intersect(gPath)
                g.Clip = rgn

                ' Now let all our added SubItems draw themselves

                For i As Integer = 0 To Me.SubItems.Count - 1
                    If SubItems(i).Displayed = True Then
                        SubItems(i).Paint(e)
                    End If
                Next
            End Using

            ' Restore our original clip region

            g.Clip = rgnSave

            ' Draw a contrast border around the item

            g.DrawPath(Pens.White, gPath)
        End Using
    End Sub

#End Region

#Region "GetItemPath"

    ''' <summary>
    ''' Gets a path defining the item
    ''' </summary>
    ''' <param name="g">Graphics</param>
    ''' <param name="inset">Inset amount</param>
    ''' <returns>GraphicsPath</returns>
    Private Function GetItemPath(ByVal g As Graphics, ByVal inset As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        Dim r As Rectangle = Bounds
        r.Inflate(inset, inset)

        Dim ar As New Rectangle(r.Right - _Radius, r.Bottom - _Radius, _Radius, _Radius)

        path.AddArc(ar, 0, 90)

        ar.X = r.X
        path.AddArc(ar, 90, 90)

        ar.Y = r.Y
        path.AddArc(ar, 180, 90)

        ar.X = r.Right - _Radius
        path.AddArc(ar, 270, 90)

        path.CloseAllFigures()

        Return (path)
    End Function

#End Region

#End Region

#Region "Mouse support"

#Region "MouseMove"

    ''' <summary>
    ''' Process MouseMove events
    ''' </summary>
    ''' <param name="objArg"></param>
    Public Overloads Overrides Sub InternalMouseMove(ByVal objArg As MouseEventArgs)
        ' Tell the system what area the mouse
        ' just passed over

        Me.HitArea = GetHitArea(objArg)

        ' And pass the event on

        MyBase.InternalMouseMove(objArg)
    End Sub

#Region "GetHitArea"

    ''' <summary>
    ''' Gets the 'HitArea' for the item
    ''' </summary>
    ''' <param name="objArg"></param>
    ''' <returns>eHitArea (move, resize, etc)</returns>
    Private Function GetHitArea(ByVal objArg As MouseEventArgs) As eHitArea
        ' WeekDayView item

        Dim wv As WeekDayView = TryCast(Me.Parent, WeekDayView)

        If wv IsNot Nothing Then
            Return (GetWeekDayHitArea(objArg))
        End If

        ' MonthView item

        Dim mv As MonthView = TryCast(Me.Parent, MonthView)

        If mv IsNot Nothing Then
            Return (GetMonthHitArea(mv, objArg))
        End If

        ' TimeLineView item

        Dim tv As TimeLineView = TryCast(Me.Parent, TimeLineView)

        If tv IsNot Nothing Then
            Return (GetTimeLineHitArea(objArg))
        End If

        ' Nowhere we recognize

        Return (eHitArea.None)
    End Function

#Region "GetWeekDayHitArea"

    ''' <summary>
    ''' Gets the HitArea for WeekDayView items
    ''' </summary>
    ''' <param name="objArg"></param>
    ''' <returns>eHitArea</returns>
    Private Function GetWeekDayHitArea(ByVal objArg As MouseEventArgs) As eHitArea
        ' See if we are in the top resize area

        If objArg.Location.Y < Bounds.Y + _ResizeArea Then
            Return (eHitArea.TopResize)
        End If

        ' See if we are in the bottom resize area

        If objArg.Location.Y > Bounds.Bottom - _ResizeArea Then
            Return (eHitArea.BottomResize)
        End If

        ' Don't permit move when over the expand arrow

        If _Button.IsMouseOverExpand = True Then
            Return (eHitArea.None)
        End If

        ' By default we are in the move area

        Return (eHitArea.Move)
    End Function

#End Region

#Region "GetMonthHitArea"

    ''' <summary>
    ''' Gets the HitArea for MonthView items
    ''' </summary>
    ''' <param name="mv"></param>
    ''' <param name="objArg"></param>
    ''' <returns>eHitArea</returns>
    Private Function GetMonthHitArea(ByVal mv As MonthView, ByVal objArg As MouseEventArgs) As eHitArea
        ' Get what week this item is in, so we can
        ' determine whether the item extends into either
        ' the next or previous weeks

        Dim monthWeek As MonthWeek = mv.GetItemWeek(Me)

        Dim start As DateTime = monthWeek.FirstDayOfWeek
        Dim [end] As DateTime = start.AddDays(7)

        ' See if we are in the left resize area

        If StartTime >= start AndAlso objArg.Location.X < Bounds.X + _ResizeArea Then
            Return (eHitArea.LeftResize)
        End If

        ' See if we are in the right resize area

        If EndTime <= [end] AndAlso objArg.Location.X > Bounds.Right - _ResizeArea Then
            Return (eHitArea.RightResize)
        End If

        ' By default we are in the move area

        Return (eHitArea.Move)
    End Function

#End Region

#Region "GetTimeLineHitArea"

    ''' <summary>
    ''' Gets the HitArea for TimeLineView items
    ''' </summary>
    ''' <param name="objArg"></param>
    ''' <returns>eHitArea</returns>
    Private Function GetTimeLineHitArea(ByVal objArg As MouseEventArgs) As eHitArea
        ' See if we are in the left resize area

        If objArg.Location.X < Bounds.X + _ResizeArea Then
            Return (eHitArea.LeftResize)
        End If

        ' See if we are in the right resize area

        If objArg.Location.X > Bounds.Right - _ResizeArea Then
            Return (eHitArea.RightResize)
        End If

        ' By default we are in the move area

        Return (eHitArea.Move)
    End Function

#End Region

#End Region

#End Region

#End Region

#Region "Copy Object"

    ''' <summary>
    ''' Returns copy of the item.
    ''' 
    ''' This routine is called to propagate the item
    ''' within each view (both in the same view as well as
    ''' across multiple views in multi-user displays)
    ''' </summary>
    Public Overloads Overrides Function Copy() As BaseItem
        Dim objCopy As New ButtonCustomItem()
        CopyToItem(objCopy)

        Return (objCopy)
    End Function

    ''' <summary>
    ''' Copies the CustomCalendarItem specific properties
    ''' to new instance of the item
    ''' </summary>
    ''' <param name="copy">New CustomCalendarItem instance</param>
    Protected Overloads Overrides Sub CopyToItem(ByVal copy As BaseItem)
        Dim objCopy As ButtonCustomItem = TryCast(copy, ButtonCustomItem)
        MyBase.CopyToItem(objCopy)

        objCopy._CalendarView = _CalendarView
    End Sub

#End Region

#Region "Dispose"

    ''' <summary>
    ''' Disposes of the item
    ''' </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        HookEvents(False)

        MyBase.Dispose(disposing)
    End Sub

#End Region

End Class
