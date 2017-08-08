Public Class GlossyCustomItem
    Inherits CustomCalendarItem

#Region "Constants"

    ' Corner radius
    Private Const _Radius As Integer = 20

    ' Resize area size
    Private Const _ResizeArea As Integer = 5

#End Region

#Region "Private class definitions"

    ''' <summary>
    ''' Local Item Color scheme
    ''' </summary>
    Private Class ItemColorScheme
        Public BackBrush As Brush
        Public BackColor As Color
        Public BackLitColor1 As Color
        Public BackLitColor2 As Color

        Public Sub New(ByVal BackBrush As Brush, ByVal BackColor As Color, ByVal BackLitColor1 As Color, ByVal BackLitColor2 As Color)
            Me.BackBrush = BackBrush
            Me.BackColor = BackColor
            Me.BackLitColor1 = BackLitColor1
            Me.BackLitColor2 = BackLitColor2
        End Sub
    End Class

#End Region

#Region "Private variables"

    Private _CheckBox As CheckBoxItem
    ' CheckBox contained in our item
    ' Define a couple of color schemes for our item

    Private _MyColors As ItemColorScheme() = { _
        New ItemColorScheme(Brushes.MidnightBlue, Color.MidnightBlue, Color.DodgerBlue, Color.RoyalBlue), _
        New ItemColorScheme(Brushes.Maroon, Color.Maroon, Color.IndianRed, Color.Maroon)}

#End Region

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
        ' Lets add a simple CheckBox to our item

        _CheckBox = New CheckBoxItem()

        _CheckBox.Text = "Color"
        _CheckBox.TextColor = Color.White

        SubItems.Add(_CheckBox)

        ' Hook our events

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

                ' Update our SubItem bounds

                UpdateSubBounds()
            End If
        End Set
    End Property

    ''' <summary>
    ''' Updates our SubItem (CheckBox) bounds
    ''' </summary>
    Private Sub UpdateSubBounds()
        ' Loop through each SubItem, centering
        ' the item inside our CustomCalendarItem

        For i As Integer = 0 To SubItems.Count - 1
            CenterItem(SubItems(i))
        Next
    End Sub

#End Region

#Region "BaseCalendarItem"

    ''' <summary>
    ''' Base CalendarItem
    ''' 
    ''' This property holds the base CalendarItem from which
    ''' each displayed CustomItem (of this type) is based.
    ''' 
    ''' In order to keep all displayed items "in-sync", it is necessary
    ''' to propagate data to and from the base CalendarItem.  This is
    ''' accomplished via hooking those members you are interested in, at
    ''' both the item (HookEvents) and BaseCalendarItem (HookBaseEvents)
    ''' level.
    ''' 
    ''' </summary>
    Public Overloads Overrides Property BaseCalendarItem() As CustomCalendarItem
        Get
            Return (MyBase.BaseCalendarItem)
        End Get

        Set(ByVal value As CustomCalendarItem)
            ' Release the event hooks for the old Base

            If MyBase.BaseCalendarItem IsNot Nothing Then
                HookBaseEvents(False)
            End If

            ' Set the new Base and hook the new events

            MyBase.BaseCalendarItem = value

            If value IsNot Nothing Then
                HookBaseEvents(True)
            End If
        End Set
    End Property

#End Region

#Region "CheckBox"

    ''' <summary>
    ''' Gets the CheckBox item
    ''' </summary>
    Public ReadOnly Property CheckBox() As CheckBoxItem
        Get
            Return (_CheckBox)
        End Get
    End Property

#End Region

#End Region

#Region "HookEvents"

    ''' <summary>
    ''' Hooks or unhooks our item events
    ''' </summary>
    ''' <param name="hook">true to hook, false to unhook</param>
    Private Sub HookEvents(ByVal hook As Boolean)
        ' Hook onto all events that we are interested in
        ' propagating through the BaseCalendarItem to other
        ' like duplicated items

        If hook = True Then
            AddHandler _CheckBox.CheckedChanged, AddressOf CheckedChanged
        Else
            RemoveHandler _CheckBox.CheckedChanged, AddressOf CheckedChanged
        End If
    End Sub

#End Region

#Region "HookBaseEvents"

    ''' <summary>
    ''' Hooks or unhooks our BaseCalendarItem events
    ''' </summary>
    ''' <param name="hook">true to hook, false to unhook</param>
    Private Sub HookBaseEvents(ByVal hook As Boolean)
        Dim gci As GlossyCustomItem = TryCast(BaseCalendarItem, GlossyCustomItem)

        If gci IsNot Nothing Then
            ' Hook onto all base events that we are interested in
            ' propagating back through the BaseCalendarItem to other
            ' like items

            If hook = True Then
                AddHandler gci.CheckBox.CheckedChanged, AddressOf BaseCheckedChanged
            Else
                RemoveHandler gci.CheckBox.CheckedChanged, AddressOf BaseCheckedChanged
            End If
        End If
    End Sub

#End Region

#Region "Event processing"

    ''' <summary>
    ''' Handles CheckBox CheckChange events for non-base items
    ''' 
    ''' This routine handles item CheckBox.Checked changes. This routine
    ''' then propagates the change to the BaseCalendarItem.  All
    ''' associated items should have hooked onto the BaseCalendarItem so
    ''' that they will be notified of the change (via BaseCheckedChanged).
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CheckedChanged(ByVal sender As Object, ByVal e As CheckBoxChangeEventArgs)
        Dim myView As GlossyCustomItem = DirectCast(BaseCalendarItem, GlossyCustomItem)

        ' Propagate the change

        If myView IsNot Nothing Then
            myView.CheckBox.Checked = _CheckBox.Checked
        End If
    End Sub

    ''' <summary>
    ''' Handles CheckBox CheckChange events for base items
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BaseCheckedChanged(ByVal sender As Object, ByVal e As CheckBoxChangeEventArgs)
        Dim myView As GlossyCustomItem = DirectCast(BaseCalendarItem, GlossyCustomItem)

        If myView IsNot Nothing Then
            ' Update our state and refresh our control

            _CheckBox.Checked = myView.CheckBox.Checked

            Refresh()
        End If
    End Sub

#End Region

#Region "RecalcSize"

    ''' <summary>
    ''' Recalculates the size of the item.  We also make
    ''' sure we initiate the recalc of any SubItems we have added
    ''' </summary>
    Public Overloads Overrides Sub RecalcSize()
        MyBase.RecalcSize()

        For i As Integer = 0 To Me.SubItems.Count - 1
            Me.SubItems(i).WidthInternal = WidthInternal / 2
            Me.SubItems(i).HeightInternal = HeightInternal / 2

            Me.SubItems(i).RecalcSize()

            CenterItem(SubItems(i))

            Me.SubItems(i).Displayed = True
        Next
    End Sub

    ''' <summary>
    ''' Centers the item per our bounding rectangle
    ''' </summary>
    ''' <param name="item"></param>
    Private Sub CenterItem(ByVal item As BaseItem)
        Dim x As Integer = (Bounds.Width - item.Bounds.Width) / 2
        Dim y As Integer = (Bounds.Height - item.Bounds.Height) / 2

        item.Bounds = New Rectangle(Bounds.X + x, Bounds.Y + y, item.Bounds.Width, item.Bounds.Height)
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

        ' The color scheme used is based on whether
        ' the CheckBox is checked or not

        Dim scheme As Integer = 0

        If _CheckBox.Checked = True Then
            scheme = 1
        End If

        ' Draw the border and content area

        DrawBorder(e, scheme)
        DrawContent(e, scheme)

        ' Set our CompostingQuality back

        g.CompositingQuality = comp
    End Sub

#Region "DrawBorder"

    ''' <summary>
    ''' Draws the item border
    ''' </summary>
    ''' <param name="e"></param>
    ''' <param name="scheme"></param>
    Private Sub DrawBorder(ByVal e As ItemPaintArgs, ByVal scheme As Integer)
        Dim g As Graphics = e.Graphics

        Using path As GraphicsPath = GetItemPath(g, 0)
            g.FillPath(_MyColors(scheme).BackBrush, path)
            g.DrawPath(Pens.Black, path)
        End Using
    End Sub

#End Region

#Region "DrawContent"

    ''' <summary>
    ''' Draws the content area of the item
    ''' </summary>
    ''' <param name="e"></param>
    ''' <param name="scheme"></param>
    Private Sub DrawContent(ByVal e As ItemPaintArgs, ByVal scheme As Integer)
        Dim g As Graphics = e.Graphics

        ' Grab a path slightly inset from the border

        Using gPath As GraphicsPath = GetItemPath(g, -1)
            ' Set up a new clip region for the item

            Dim rgnSave As Region = g.Clip

            Using rgn As New Region(rgnSave.GetRegionData())
                rgn.Intersect(gPath)
                g.Clip = rgn

                ' Draw the top half of the item

                Dim r As Rectangle = Bounds
                r.Height = r.Height / 2

                Using lbr As New LinearGradientBrush(r, Color.LightGray, _MyColors(scheme).BackColor, 90.0F)
                    r.Height -= 1
                    g.FillRectangle(lbr, r)
                End Using

                ' Draw the bottom back-lit area

                r.Y = r.Bottom
                r.Height = Bounds.Height

                Using ePath As New GraphicsPath()
                    ePath.AddEllipse(r)

                    Using pbr As New PathGradientBrush(ePath)
                        pbr.CenterPoint = New PointF(r.X + r.Width / 2, r.Y + r.Height / 2)

                        ' If it is selected, make it a little more lit

                        If IsSelected = True Then
                            pbr.CenterColor = _MyColors(scheme).BackLitColor1
                        Else
                            pbr.CenterColor = _MyColors(scheme).BackLitColor2
                        End If

                        pbr.SurroundColors = New Color() {_MyColors(scheme).BackColor}

                        g.FillEllipse(pbr, r)
                    End Using
                End Using

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
    ''' <returns></returns>
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
        Dim objCopy As New GlossyCustomItem()
        CopyToItem(objCopy)

        Return (objCopy)
    End Function

    ''' <summary>
    ''' Copies the CustomCalendarItem specific properties
    ''' to new instance of the item
    ''' </summary>
    ''' <param name="copy">New CustomCalendarItem instance</param>
    Protected Overloads Overrides Sub CopyToItem(ByVal copy As BaseItem)
        Dim objCopy As GlossyCustomItem = TryCast(copy, GlossyCustomItem)

        If objCopy IsNot Nothing Then
            objCopy.HookEvents(False)
            objCopy.SubItems.Clear()

            MyBase.CopyToItem(objCopy)

            objCopy._CheckBox = DirectCast(objCopy.SubItems(0), CheckBoxItem)
            objCopy.HookEvents(True)

            objCopy.CheckBox.Checked = _CheckBox.Checked
        End If
    End Sub

#End Region

#Region "Dispose"

    ''' <summary>
    ''' Disposes of the item
    ''' </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        ' Unhook our call-outs
        ' and dispose of the item

        HookEvents(False)
        HookBaseEvents(False)

        MyBase.Dispose(disposing)
    End Sub

#End Region

End Class