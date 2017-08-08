Imports DevComponents.Instrumentation
Imports System.Drawing.Drawing2D

Public Class Form1

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
        InitializeComponent()

        ' Initialize our default label text

        lbl100.Text = ks100.Value.ToString()
        lbl200.Text = ks200.Value.ToString()
        lbl300.Text = ks300.Value.ToString()
        lbl400.Text = ks400.Value.ToString()
    End Sub

#Region "PreRenderTickLabel"

    ''' <summary>
    ''' Render a plum colored circle at pre-render tick label time
    ''' </summary>
    ''' <param name="sender">KnobControl</param>
    ''' <param name="e">PreRenderEventArgs</param>
    Private Sub PreRenderTickLabel(ByVal sender As Object, ByVal e As PreRenderEventArgs) Handles ks303.PreRenderTickLabel
        Dim kc As KnobControl = TryCast(sender, KnobControl)

        If kc IsNot Nothing Then
            ' Locate where the current "value label" is located,
            ' and then render our circle accordingly

            Dim pt As Point = GetLabelPoint(kc, e)

            e.Graphics.FillEllipse(Brushes.Plum, New Rectangle(pt.X, pt.Y, 20, 20))
        End If
    End Sub

#End Region

#Region "PostRenderKnobIndicator1"

    ''' <summary>
    ''' Render the Value onto the control at post-render indicator time
    ''' </summary>
    ''' <param name="sender">KnobControl</param>
    ''' <param name="e">PostRenderEventArgs</param>
    Private Sub PostRenderKnobIndicator1(ByVal sender As Object, ByVal e As PostRenderEventArgs) Handles ks401.PostRenderKnobIndicator
        Dim kc As KnobControl = TryCast(sender, KnobControl)

        If kc IsNot Nothing Then
            ' Draw the knob Value (with an offset shadow)
            ' on top of the KnobIndicator

            Using font As New Font("Arial", 30, FontStyle.Regular)
                Using strFormat As New StringFormat(StringFormatFlags.NoClip)
                    strFormat.Alignment = StringAlignment.Center

                    Dim s As String = kc.Value.ToString()

                    If s.EndsWith(".0") Then
                        s = s.Substring(0, s.Length - 2)
                    End If

                    Dim r As RectangleF = GetTextRect(e.Bounds, font)

                    r.Offset(2, 2)
                    e.Graphics.DrawString(s, font, Brushes.Black, r, strFormat)

                    r.Offset(-2, -2)
                    e.Graphics.DrawString(s, font, Brushes.White, r, strFormat)
                End Using
            End Using
        End If
    End Sub

#End Region

#Region "PostRenderKnobIndicator2"

    ''' <summary>
    ''' Render the control Value at post-render indicator time
    ''' </summary>
    ''' <param name="sender">KnobControl</param>
    ''' <param name="e">PostRenderEventArgs</param>
    Private Sub PostRenderKnobIndicator2(ByVal sender As Object, ByVal e As PostRenderEventArgs) Handles ks303.PostRenderKnobIndicator
        Dim kc As KnobControl = TryCast(sender, KnobControl)

        If kc IsNot Nothing Then
            ' Draw the knob Value on top of the KnobIndicator

            Using font As New Font("Arial", 16, FontStyle.Regular)
                Using strFormat As New StringFormat(StringFormatFlags.NoClip)
                    strFormat.Alignment = StringAlignment.Center

                    Dim r As RectangleF = GetTextRect(e.Bounds, font)

                    e.Graphics.DrawString(kc.Value.ToString(), font, Brushes.Black, r, strFormat)
                End Using
            End Using
        End If
    End Sub

#End Region

#Region "RenderFocusRect"

    ''' <summary>
    ''' Renders a hilight focus rect
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RenderFocusRect(ByVal sender As Object, ByVal e As RenderFocusRectEventArgs) Handles ks402.RenderFocusRect
        Dim kc As KnobControl = TryCast(sender, KnobControl)

        If kc IsNot Nothing Then
            Dim c As Color = Color.FromArgb(80, Color.Yellow)

            Using lbr As New LinearGradientBrush(e.Bounds, Color.White, c, 45.0F)
                e.Graphics.FillEllipse(lbr, e.Bounds)
            End Using
        End If
    End Sub

#End Region

#Region "GetLabelPoint"

    ''' <summary>
    ''' Returns tick label point
    ''' </summary>
    ''' <returns>Upper left tick label rect of the control</returns>
    Private Function GetLabelPoint(ByVal kc As KnobControl, ByVal e As PreRenderEventArgs) As Point
        Dim count As Decimal = kc.MaxValue - kc.MinValue

        Dim rad As Double = GetRadians(CSng(((kc.SweepAngle * kc.Value) / count + kc.StartAngle)))

        Dim x As Integer = e.Bounds.X + e.Bounds.Width / 2
        Dim dx As Integer = e.Bounds.Width / 2

        Dim pt As New Point()

        pt.X = CInt((Math.Cos(rad) * dx + x - 10))
        pt.Y = CInt((Math.Sin(rad) * dx + x - 10))

        Return (pt)
    End Function

#Region "GetRadians"

    ''' <summary>
    ''' Converts degrees to radians
    ''' </summary>
    ''' <param name="theta">degrees</param>
    ''' <returns>radians</returns>
    Public Function GetRadians(ByVal theta As Single) As Double
        Return (theta * Math.PI / 180)
    End Function

#End Region

#End Region

#Region "GetTextRect"

    ''' <summary>
    ''' Calculates the inner knob text bounding rectangle
    ''' </summary>
    ''' <param name="bounds">Knob bounding rectangle</param>
    ''' <param name="font">Text font</param>
    ''' <returns>Text bounding rectangle</returns>
    Private Function GetTextRect(ByVal bounds As Rectangle, ByVal font As Font) As RectangleF
        Dim width As Integer = bounds.Width
        Dim dy As Single = font.Height

        Return (New RectangleF(bounds.X, bounds.Y + (width - dy) / 2, bounds.Width, dy))
    End Function

#End Region

#Region "btnExit_Click"

    ''' <summary>
    ''' Program exit
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs)
        Application.[Exit]()
    End Sub

#End Region

#Region "ks100 range support"

#Region "ks100_Enter"

    ''' <summary>
    ''' ks100_Enter
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ks100_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles ks100.Enter, ks104.Enter, ks103.Enter, ks102.Enter, ks101.Enter
        UpdateLabel(sender, lbl100)
    End Sub

#End Region

#Region "ks100_ValueChanged"

    ''' <summary>
    ''' ks100_ValueChanged
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ks100_ValueChanged(ByVal sender As Object, ByVal e As ValueChangedEventArgs) Handles ks104.ValueChanged, ks103.ValueChanged, ks102.ValueChanged, ks101.ValueChanged, ks100.ValueChanged
        UpdateLabel(sender, lbl100)
    End Sub

#End Region

#End Region

#Region "ks200 range support"

#Region "ks200_Enter"

    ''' <summary>
    ''' ks200_Enter
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ks200_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles ks204.Enter, ks203.Enter, ks202.Enter, ks201.Enter, ks200.Enter
        UpdateLabel(sender, lbl200)
    End Sub

#End Region

#Region "ks200_ValueChanged"

    ''' <summary>
    ''' ks200_ValueChanged
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ks200_ValueChanged(ByVal sender As Object, ByVal e As ValueChangedEventArgs) Handles ks204.ValueChanged, ks203.ValueChanged, ks202.ValueChanged, ks201.ValueChanged, ks200.ValueChanged
        UpdateLabel(sender, lbl200)
    End Sub

#End Region

#End Region

#Region "ks300 range support"

#Region "ks300_Enter"

    ''' <summary>
    ''' ks300_Enter
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ks300_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles ks304.Enter, ks303.Enter, ks302.Enter, ks301.Enter, ks300.Enter
        UpdateLabel(sender, lbl300)
    End Sub

#End Region

#Region "ks300_ValueChanged"

    ''' <summary>
    ''' ks300_ValueChanged
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ks300_ValueChanged(ByVal sender As Object, ByVal e As ValueChangedEventArgs) Handles ks304.ValueChanged, ks303.ValueChanged, ks300.ValueChanged
        UpdateLabel(sender, lbl300)
    End Sub

#End Region

#Region "ks301_ValueChanged"

    ''' <summary>
    ''' ks301_ValueChanged
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ks301_ValueChanged(ByVal sender As Object, ByVal e As ValueChangedEventArgs) Handles ks301.ValueChanged
        UpdateLabel(sender, lbl300)

        If ks301.Value >= 3000 AndAlso ks301.Value <= 4000 Then
            ks301.KnobColor.MidZoneIndicatorColor.Start = Color.Magenta
        Else
            ks301.KnobColor.MidZoneIndicatorColor.Start = Color.MediumOrchid
        End If
    End Sub

#End Region

#Region "ks302_ValueChanged"

    ''' <summary>
    ''' ks302_ValueChanged
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ks302_ValueChanged(ByVal sender As Object, ByVal e As ValueChangedEventArgs) Handles ks302.ValueChanged
        UpdateLabel(sender, lbl300)

        ' Set our Min and Max zone percentages so that they
        ' follow the current knob value setting

        Dim count As Decimal = ks302.MaxValue - ks302.MinValue

        If count > 0 Then
            Dim pct As Integer = CInt(((ks302.Value / count) * 100))

            ks302.SuspendLayout()

            ks302.MinZonePercentage = pct
            ks302.MaxZonePercentage = 100 - pct

            ks302.ResumeLayout()
        End If
    End Sub

#End Region

#End Region

#Region "ks400 range support"

#Region "ks400_Enter"

    ''' <summary>
    ''' ks400_Enter
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ks400_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles ks404.Enter, ks403.Enter, ks402.Enter, ks401.Enter, ks400.Enter
        UpdateLabel(sender, lbl400)
    End Sub

#End Region

#Region "ks400_ValueChanged"

    ''' <summary>
    ''' ks400_ValueChanged
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ks400_ValueChanged(ByVal sender As Object, ByVal e As ValueChangedEventArgs) Handles ks404.ValueChanged, ks402.ValueChanged, ks401.ValueChanged, ks400.ValueChanged
        UpdateLabel(sender, lbl400)
    End Sub

#End Region

#Region "ks403_ValueChanged"

    ''' <summary>
    ''' ks403_ValueChanged
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ks403_ValueChanged(ByVal sender As Object, ByVal e As ValueChangedEventArgs) Handles ks403.ValueChanged
        UpdateLabel(sender, lbl400)

        Dim c As Color = ks403.KnobColor.KnobFaceColor.[End]

        Dim d As Decimal = ks403.MaxValue - ks403.MinValue
        Dim x As Decimal = ks403.Value / d

        ks403.KnobColor.KnobIndicatorColor.[End] = ControlPaint.Light(c, CSng(x))
    End Sub

#End Region

#End Region

#Region "UpdateLabel"

    ''' <summary>
    ''' UpdateLabel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="label"></param>
    Private Sub UpdateLabel(ByVal sender As Object, ByVal label As Label)
        Dim kc As KnobControl = TryCast(sender, KnobControl)

        If kc IsNot Nothing Then
            label.Text = kc.Value.ToString()
        End If
    End Sub

#End Region

End Class
