Imports DevComponents.DotNetBar
Imports DevComponents.Editors
Imports DevComponents.Editors.DateTimeAdv
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomersDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.CustomersDataSet.Customers)
        dateTimeInput1.Value = DateTime.Today
        dateTimeInput2.Value = DateTime.Today
        dateTimeInput3.Value = DateTime.Now
        dateTimeInput4.Value = DateTime.Now
        dateTimeInput5.Value = DateTime.Now
        dateTimeInput6.Value = DateTime.Now
        dateTimeInput7.Value = DateTime.Now
        dateTimeInput8.Value = DateTime.Now
        dateTimeInput9.Value = DateTime.Now
    End Sub


    Private Sub dateTimeInput3_ButtonCustomClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateTimeInput3.ButtonCustomClick
        MessageBoxEx.Show("Use custom buttons to show dialogs, provide customized value pickers etc.", "Date/Time Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub dateTimeInput5_ButtonCustomClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateTimeInput5.ButtonCustomClick
        If MessageBox.Show("Set value of control to NULL?", "Time Input", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            dateTimeInput5.ValueObject = Nothing
        End If
    End Sub

    Private Sub dateTimeInput11_MonthCalendar_PaintLabel(ByVal sender As Object, ByVal e As DevComponents.Editors.DateTimeAdv.DayPaintEventArgs) Handles dateTimeInput11.MonthCalendar.PaintLabel
        Dim day As DevComponents.Editors.DateTimeAdv.DayLabel = CType(sender, DevComponents.Editors.DateTimeAdv.DayLabel)

        If day Is Nothing OrElse day.Date = DateTime.MinValue Then
            Exit Sub
        End If

        ' Cross all weekend days and disable selection for them...
        If (day.Date.DayOfWeek = DayOfWeek.Saturday Or day.Date.DayOfWeek = DayOfWeek.Sunday) And day.Date <> DateTime.Today.AddDays(1) Then

            day.Selectable = False  ' Mark label as not selectable...
            day.TrackMouse = False  ' Do not track mouse movement...
            e.PaintBackground()
            e.PaintText()
            Dim r As Rectangle = day.Bounds
            r.Inflate(-2, -2)
            Dim sm As SmoothingMode = e.Graphics.SmoothingMode
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            e.Graphics.DrawLine(Pens.Red, r.X, r.Y, r.Right, r.Bottom)
            e.Graphics.DrawLine(Pens.Red, r.Right, r.Y, r.X, r.Bottom)
            e.Graphics.SmoothingMode = sm
            ' Ensure that no part is rendered internally by control...
            e.RenderParts = DevComponents.Editors.DateTimeAdv.eDayPaintParts.None
        ElseIf Not day Is Nothing And day.Date = DateTime.Today.AddDays(1) Then ' Mark tomorrows day...
            e.PaintBackground()
            e.PaintText()
            Dim sm As SmoothingMode = e.Graphics.SmoothingMode
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            Dim r As Rectangle = day.Bounds
            r.Width -= 1
            r.Height -= 1
            Dim pen As Pen = New Pen(Color.FromArgb(128, Color.Blue))
            e.Graphics.DrawEllipse(pen, r)
            pen.Dispose()
            e.Graphics.SmoothingMode = sm
            ' Ensure that no part is rendered internally by control...
            e.RenderParts = DevComponents.Editors.DateTimeAdv.eDayPaintParts.None
        End If
    End Sub

    Private Sub monthCalendarAdv2_MonthChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles monthCalendarAdv2.MonthChanged
        ' You can use this event to add custom markers to the calendar for example mark appointments for days...
        ' In this sample we'll just pick the day 8 days from today...
        Dim d As DateTime = DateTime.Today.AddDays(8)
        ' DayLabel control is used to represents each date on calendar
        Dim day As DayLabel = monthCalendarAdv2.GetDay(d)
        If Not day Is Nothing Then ' Null will be returned if date is not displayed on calendar
            ' Display image on the label...
            day.Image = Global.EditorsDateNumericCalendar.My.Resources.Resources.Bell
            day.ImageAlign = eLabelPartAlignment.MiddleRight
            day.TextAlign = eLabelPartAlignment.MiddleLeft
            day.Tooltip = "Click image to see appointments"
            ' You can display the popup when day image is clicked with for example the appointment details...
            day.SubItems.Add(New ButtonItem("appointment1", "10:45 AM Call Dave to setup meeting"))
            day.SubItems.Add(New ButtonItem("appointment2", "12:05 PM Lunch with Kurt"))
        End If
    End Sub

    Private Sub monthCalendarAdv2_PaintLabel(ByVal sender As Object, ByVal e As DevComponents.Editors.DateTimeAdv.DayPaintEventArgs) Handles monthCalendarAdv2.PaintLabel
        ' Cross Sundays and disable selection
        Dim day As DayLabel = CType(sender, DayLabel)
        If Not day Is Nothing AndAlso day.Date > DateTime.MinValue AndAlso day.Date.DayOfWeek = DayOfWeek.Sunday Then
            day.Selectable = False  ' Mark label as not selectable...
            day.TrackMouse = False  ' Do not track mouse movement...
            e.PaintBackground()
            e.PaintText(Color.Gray)
            Dim r As Rectangle = day.Bounds
            r.Inflate(-2, -2)
            Dim sm As SmoothingMode = e.Graphics.SmoothingMode
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            Dim pen As Pen = New Pen(Color.FromArgb(128, Color.Red))
            e.Graphics.DrawLine(pen, r.X, r.Y, r.Right, r.Bottom)
            e.Graphics.DrawLine(pen, r.Right, r.Y, r.X, r.Bottom)
            pen.Dispose()
            e.Graphics.SmoothingMode = sm
            ' Ensure that no part is rendered internally by control...
            e.RenderParts = DevComponents.Editors.DateTimeAdv.eDayPaintParts.None
        End If
    End Sub

    Private Sub integerInput2_ButtonCustomClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles integerInput2.ButtonCustomClick
        MessageBoxEx.Show("Execute custom action here...", "IntegerInput", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
