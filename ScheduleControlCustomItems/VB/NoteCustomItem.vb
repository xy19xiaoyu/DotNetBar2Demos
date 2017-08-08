Public Class NoteCustomItem
    Inherits CustomCalendarItem

#Region "Constants"

    ' Corner radius
    Private Const _Radius As Integer = 10

    ' Resize area size
    Private Const _ResizeArea As Integer = 5

#End Region

#Region "Private variables"

    ' Image
    Private _Image As Image

#End Region

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New(ByVal Note As String)
        Text = Note

        HookEvents(True)
    End Sub

    Public Sub New()
        Me.New("")
    End Sub

#Region "Public properties"

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

#Region "EndTime"

    ''' <summary>
    ''' Gets and sets the item EndTime
    ''' </summary>
    Public Overloads Overrides Property EndTime() As DateTime
        Get
            Return MyBase.EndTime
        End Get

        Set(ByVal value As DateTime)
            ' As an added touch, always keep our EndTime equal
            ' to our StartTime so the Schedule Control won't
            ' allocate appointment space for it

            MyBase.EndTime = StartTime
        End Set
    End Property

#End Region

#Region "Image"

    ''' <summary>
    ''' Gets and sets the item Image
    ''' </summary>
    Public Property Image() As Image
        Get
            Return (_Image)
        End Get

        Set(ByVal value As Image)
            _Image = value

            Me.Refresh()
        End Set
    End Property

#End Region

#End Region

#Region "HookEvents"

    ''' <summary>
    ''' Hooks or unhooks our events.
    ''' 
    ''' In order to keep all displayed items "in-sync", it is necessary
    ''' to propagate data to and from the BaseCalendarItem.  This is
    ''' accomplished via hooking those members you are interested in, at
    ''' both the item (HookEvents) and BaseCalendarItem (HookBaseEvents)
    ''' level.
    ''' </summary>
    ''' <param name="hook">true to hook, false to unhook</param>
    Private Sub HookEvents(ByVal hook As Boolean)
        ' In the NoteCustomItem case, we want to make sure the Text
        ' is kept in sync across all created item versions

        If hook = True Then
            AddHandler TextChanged, AddressOf ItemTextChanged
        Else
            RemoveHandler TextChanged, AddressOf ItemTextChanged
        End If
    End Sub

#End Region

#Region "HookBaseEvents"

    ''' <summary>
    ''' Hooks or unhooks our BaseCalendarItem events.
    ''' 
    ''' In order to keep all displayed items "in-sync", it is necessary
    ''' to propagate data to and from the BaseCalendarItem.  This is
    ''' accomplished via hooking those members you are interested in, at
    ''' both the item (HookEvents) and BaseCalendarItem (HookBaseEvents)
    ''' level.
    ''' </summary>
    ''' <param name="hook">true to hook, false to unhook</param>
    Private Sub HookBaseEvents(ByVal hook As Boolean)
        Dim nci As NoteCustomItem = TryCast(BaseCalendarItem, NoteCustomItem)

        If nci IsNot Nothing Then
            If hook = True Then
                AddHandler nci.TextChanged, AddressOf BaseCalendarItem_TextChanged
            Else
                RemoveHandler nci.TextChanged, AddressOf BaseCalendarItem_TextChanged
            End If
        End If
    End Sub

#End Region

#Region "Event processing"

    ''' <summary>
    ''' Handles TextChanged events for the specific item.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ItemTextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim nci As NoteCustomItem = TryCast(BaseCalendarItem, NoteCustomItem)

        ' Propagate the event to all other potential versions
        ' via the BaseCalendarItem

        If nci IsNot Nothing Then
            nci.Text = Text
        End If
    End Sub

    ''' <summary>
    ''' Handles TextChange events for the BaseCalendarItem
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BaseCalendarItem_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim nci As NoteCustomItem = TryCast(BaseCalendarItem, NoteCustomItem)

        If nci IsNot Nothing Then
            Text = nci.Text

            Refresh()
        End If
    End Sub

#End Region

#Region "RecalcSize"

    ''' <summary>
    ''' Calculates the Bounding size for the item
    ''' </summary>
    Public Overloads Overrides Sub RecalcSize()
        MyBase.RecalcSize()

        ' Instead of taking the preferred size given to us
        ' let's tell the Calendar that we want something different

        Me.WidthInternal = 300
        Me.HeightInternal = 100
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

        ' Draw the border and content area

        DrawBorder(g)
        DrawContent(g)

        ' Set our CompostingQuality back

        g.CompositingQuality = comp
    End Sub

#Region "DrawBorder"

    ''' <summary>
    ''' Draws the item border
    ''' </summary>
    ''' <param name="g"></param>
    Private Sub DrawBorder(ByVal g As Graphics)
        Using path As GraphicsPath = GetItemPath(g, 0)
            If IsSelected = True Then
                g.FillPath(Brushes.Black, path)
            Else
                g.FillPath(Brushes.White, path)
            End If

            g.DrawPath(Pens.Black, path)

        End Using
    End Sub

#End Region

#Region "DrawContent"

    ''' <summary>
    ''' Draws the content area of the item
    ''' </summary>
    ''' <param name="g"></param>
    Private Sub DrawContent(ByVal g As Graphics)
        ' Grab a path slightly inset from the border

        Using path As GraphicsPath = GetItemPath(g, -3)
            ' Set up a new clip region for the item

            Dim rgnSave As Region = g.Clip

            Using rgn As New Region(rgnSave.GetRegionData())
                rgn.Intersect(path)
                g.Clip = rgn

                g.FillPath(Brushes.White, path)

                Dim rf As RectangleF = Bounds

                Using sf As New StringFormat()
                    sf.Alignment = StringAlignment.Center
                    sf.LineAlignment = StringAlignment.Center

                    If _Image IsNot Nothing Then
                        Dim x As Integer = Bounds.X + (Bounds.Width - _Image.Width) / 2
                        Dim y As Integer = Bounds.Y + 6

                        g.DrawImage(_Image, x, y)

                        rf.Y += _Image.Height / 2
                        rf.Height -= _Image.Height / 2
                    End If

                    g.DrawString(Text, SystemFonts.DefaultFont, Brushes.Black, rf, sf)

                End Using
            End Using

            ' Restore our original clip region

            g.Clip = rgnSave

            If IsSelected = True Then
                g.DrawPath(Pens.Black, path)
            End If
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

        r.Width -= 1
        r.Height -= 1

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
        ' By default we are in the move area

        If Locked = False Then
            Return (eHitArea.Move)
        End If

        Return (eHitArea.None)
    End Function

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
        Dim objCopy As New NoteCustomItem()
        CopyToItem(objCopy)

        Return (objCopy)
    End Function

    ''' <summary>
    ''' Copies the CustomCalendarItem specific properties
    ''' to new instance of the item
    ''' </summary>
    ''' <param name="copy">New CustomCalendarItem instance</param>
    Protected Overloads Overrides Sub CopyToItem(ByVal copy As BaseItem)
        Dim objCopy As NoteCustomItem = TryCast(copy, NoteCustomItem)
        MyBase.CopyToItem(objCopy)

        ' All private data that you want to carried
        ' forward, needs to be propagated here

        objCopy._Image = Me._Image
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

        MyBase.Dispose(disposing)
    End Sub

#End Region

End Class
