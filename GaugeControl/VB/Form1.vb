Imports System.Drawing.Drawing2D
Imports DevComponents.Instrumentation

Namespace GaugeControl_Sample
	Partial Public Class Form1
		Inherits Form
		#Region "Private variables"

		Private _Timer1 As Timer
		Private _Timer2 As Timer

		Private _Rand As Random

		Private _LastItem As GaugeItem

		Private _RenderPointerEventCount As Integer
		Private _GetPointerPathEventCount As Integer

		Private _Colors() As Color = { Color.ForestGreen, Color.Lime, Color.Yellow, Color.Orange, Color.Red }
		Private _Positions() As Single = { 0f,.25f,.3f,.6f, 1f }

		#End Region

		''' <summary>
		''' Constructor
		''' </summary>
		Public Sub New()
			InitializeComponent()

			_Rand = New Random()

			sliderDampen1.Value = 15
			colorPickerButton1.SelectedColor = Color.Red
			cbFillMode.SelectedIndex = 0
		End Sub

#Region "Indicator Elements"

        ''' <summary>
        ''' Handles PreRenderIndicatorDigit events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GaugeControl2PreRenderIndicatorDigit(ByVal sender As Object, ByVal e As PreRenderIndicatorDigitEventArgs) Handles gaugeControl2.PreRenderIndicatorDigit
            ' Just for element identification purposes, turn on
            ' the Colon on digit 2 so the user can see it better.

            If e.Indicator.Name.Equals("Digital71") = True Then
                If e.Index = 2 Then
                    e.Digit.ColonPointsOn = True
                End If
            End If
        End Sub

#End Region

#Region "Circular samples"

#Region "gcCircular1"

#Region "CbShowTooltipsCheckedChanged"

        ''' <summary>
        ''' Handles ShowTooltips checkbox events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbShowTooltipsCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbShowTooltips.CheckedChanged
            ' Enabling of tooltips is handled at the
            ' gauge level, so set it accordingly

            gcCircular1.ShowToolTips = cbShowTooltips.Checked
        End Sub

#End Region

#Region "SliderScaleAngleValueChanged"

        ''' <summary>
        ''' Handles gcCircular1 StartAngle changes
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub SliderScaleAngleValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles sliderScaleAngle.ValueChanged
            If gcCircular1.CircularScales.Count > 0 Then
                gcCircular1.CircularScales("Scale1").StartAngle = sliderScaleAngle.Value
            End If
        End Sub

#End Region

#Region "GcCircular1PointerChanged"

        ''' <summary>
        ''' Handles gCircular1 PointerChanged events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcCircular1PointerChanged(ByVal sender As Object, ByVal e As PointerChangedEventArgs) Handles gcCircular1.PointerChanged
            Dim ind As NumericIndicator = TryCast(gcCircular1.GaugeItems("NumericIndicator1"), NumericIndicator)

            If ind IsNot Nothing Then
                ind.Value = e.NewValue
            End If
        End Sub

#End Region

#End Region

#Region "gcCircular2"

#Region "CbCAddGlassEffectCheckedChanged"

        ''' <summary>
        ''' Handles AddGlassEffect checkbox change events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbCAddGlassEffectCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbCAddGlassEffect.CheckedChanged
            gcCircular2.Frame.AddGlassEffect = cbCAddGlassEffect.Checked
        End Sub

#End Region

#Region "CbCReverse1Click"

        ''' <summary>
        ''' Handles Reverse1 checkbox change
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbCReverse1Click(ByVal sender As Object, ByVal e As EventArgs) Handles cbReverse1.CheckedChanged
            ' Locate the scale to reverse in our the gauges
            ' CircularScales list, and reverse it

            Dim scale As GaugeScale = gcCircular2.CircularScales("Scale1")

            If scale IsNot Nothing Then
                scale.Reversed = cbReverse1.Checked
            End If
        End Sub

#End Region

#Region "CbCReverse2Click"

        ''' <summary>
        ''' Handles Reverse1 checkbox change
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbCReverse2Click(ByVal sender As Object, ByVal e As EventArgs) Handles cbReverse2.CheckedChanged
            ' Locate the scale to reverse in our the gauges
            ' CircularScales list, and reverse it

            Dim scale As GaugeScale = gcCircular2.CircularScales("Scale2")

            If scale IsNot Nothing Then
                scale.Reversed = cbReverse2.Checked
            End If
        End Sub

#End Region

#Region "GcCircular2PointerChanged"

        ''' <summary>
        ''' Handles gcCircular2 PointerChanged events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcCircular2PointerChanged(ByVal sender As Object, ByVal e As PointerChangedEventArgs) Handles gcCircular2.PointerChanged
            Dim ind As StateIndicator = TryCast(gcCircular2.GaugeItems("StateIndicator1"), StateIndicator)

            If ind IsNot Nothing Then
                ind.Value = e.NewValue
            End If
        End Sub

#End Region

#End Region

#Region "gcCircular4"

#Region "CbCAutoOrientLabelsCheckedChanged"

        ''' <summary>
        ''' Handles AutoOrientLabels checkbox events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbCAutoOrientLabelsCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbCAutoOrientLabels.CheckedChanged
            ' Locate the associated scale in the gauges
            ' CircularScales list, and set the AutoOrientLabel accordingly

            Dim scale As GaugeScale = gcCircular4.CircularScales("Large Scale")

            If scale IsNot Nothing Then
                scale.Labels.Layout.AutoOrientLabel = cbCAutoOrientLabels.Checked
            End If
        End Sub

#End Region

#Region "CbCRotateLabelsCheckedChanged"

        ''' <summary>
        ''' Handles RotateLabels checkbox events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbCRotateLabelsCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbCRotateLabels.CheckedChanged
            ' Locate the associated scale from the gauges
            ' CircularScales list, and set accordingly

            Dim scale As GaugeCircularScale = gcCircular4.CircularScales("Large Scale")

            If scale IsNot Nothing Then
                scale.Labels.Layout.RotateLabel = cbCRotateLabels.Checked

                ' AutoOrientLabels is not used when
                ' the labels are not permitted to rotate

                cbCAutoOrientLabels.Enabled = cbCRotateLabels.Checked
            End If
        End Sub

#End Region

#Region "SliderCAngleValueChanged"

        ''' <summary>
        ''' Handles Angle slider value changes
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub SliderCAngleValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles sliderCAngle.ValueChanged
            ' Locate the associated scale from the gauges
            ' CircularScales list, and set accordingly.

            Dim scale As GaugeCircularScale = gcCircular4.CircularScales("Large Scale")

            If scale IsNot Nothing Then
                scale.Labels.Layout.Angle = sliderCAngle.Value
            End If
        End Sub

#End Region

#Region "GcCircular4PointerChanged"

        ''' <summary>
        ''' Handles PointerChanged events for the gauge
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcCircular4PointerChanged(ByVal sender As Object, ByVal e As PointerChangedEventArgs) Handles gcCircular4.PointerChanged
            ' Keep the alternate scale pointer insync (opposite value, for grins) with
            ' the pointer that was just changed.

            ' A couple notes about the SetPointerValue routine:
            '
            ' 1 - This routine looks for the provided pointer Name first from any
            ' defined CircularScales, then any defined LinearScales. Since pointer Names
            ' are not constrained to be unique across scales, if you use this call you
            ' should make sure you choose a unique name for the pointer in question.
            '
            ' 2 - The last parameter to the call tells the system whether the visual
            ' update should be dampened.  Since we are interactively adjusting one of
            ' the pointers, we want the feedback of the second pointer to match, therefore
            ' we want no dampening - ie. immediate feedback.

            gcCircular4.SetPointerValue(CStr(IIf(e.Pointer.Name.Equals("LargeNeedle"), "SmallNeedle", "LargeNeedle")), 100 - e.Pointer.Value, False)
        End Sub

#End Region

#End Region

#Region "gcCircular5"

#Region "RbNoneCheckedChanged"

        ''' <summary>
        ''' Handles RbNoneChecked changes
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub RbNoneCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbNone.CheckedChanged
            If rbNone.Checked = True Then
                gcCircular5.Frame.Style = GaugeFrameStyle.None

                sliderArc.Enabled = False
            End If
        End Sub

#End Region

#Region "RbCircularCheckedChanged"

        ''' <summary>
        ''' Handles RbCircularChecked changes
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub RbCircularCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbCircular.CheckedChanged
            If rbCircular.Checked = True Then
                gcCircular5.Frame.Style = GaugeFrameStyle.Circular

                sliderArc.Enabled = False
            End If
        End Sub

#End Region

#Region "RbRectCheckedChanged"

        ''' <summary>
        ''' Handles RbRectChecked changes
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub RbRectCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbRect.CheckedChanged
            If rbRect.Checked = True Then
                gcCircular5.Frame.Style = GaugeFrameStyle.Rectangular

                sliderArc.Enabled = False
            End If
        End Sub

#End Region

#Region "RbRoundRectCheckedChanged"

        ''' <summary>
        ''' Handles RbRoundRectChecked changes
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub RbRoundRectCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbRoundRect.CheckedChanged
            If rbRoundRect.Checked = True Then
                gcCircular5.Frame.Style = GaugeFrameStyle.RoundedRectangular

                sliderArc.Enabled = True
            End If
        End Sub

#End Region

#Region "SliderArcValueChanged"

        ''' <summary>
        ''' Handles SliderArc value changes
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub SliderArcValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles sliderArc.ValueChanged
            gcCircular5.Frame.RoundRectangleArc = CSng(sliderArc.Value) / 100
        End Sub

#End Region

#End Region

#Region "gcCircular6"

#Region "CbRotateCapCheckedChanged"

        ''' <summary>
        ''' Handles RotateCap checkbox events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbRotateCapCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbRotateCap.CheckedChanged
            ' Locate the associated Pointer and set
            ' the RotateCapImage property accordingly

            Dim pointer As GaugePointer = GetCircularPointer(gcCircular6, "Scale1", "Needle")

            If pointer IsNot Nothing Then
                pointer.RotateCap = cbRotateCap.Checked
            End If
        End Sub

#End Region

#Region "SliderMaxPinValueChanged"

        ''' <summary>
        ''' Handles MaxPin Slider changes
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub SliderMaxPinValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles sliderMaxPin.ValueChanged
            gcCircular6.CircularScales("Scale1").MaxPin.EndOffset = CSng(sliderMaxPin.Value) / 1000
        End Sub

#End Region

#Region "CbHonorMinPinCheckedChanged"

        ''' <summary>
        ''' Handles HonorMinPin changes
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbHonorMinPinCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbHonorMinPin.CheckedChanged
            Dim scale As GaugeScale = gcCircular6.CircularScales("Scale1")

            If scale IsNot Nothing Then
                For Each pointer As GaugePointer In scale.Pointers
                    pointer.HonorMinPin = cbHonorMinPin.Checked
                Next pointer
            End If
        End Sub

#End Region

#Region "CbHonorMaxPinCheckedChanged"

        ''' <summary>
        ''' Handles HonorMaxPin changes
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbHonorMaxPinCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbHonorMaxPin.CheckedChanged
            Dim scale As GaugeScale = gcCircular6.CircularScales("Scale1")

            If scale IsNot Nothing Then
                For Each pointer As GaugePointer In scale.Pointers
                    pointer.HonorMaxPin = cbHonorMaxPin.Checked
                Next pointer
            End If
        End Sub

#End Region

#End Region

#End Region

#Region "Linear samples"

#Region "gcLinear4"

#Region "CbOrderBarsCheckedChanged"

        ''' <summary>
        ''' Handles OrderBars checkbox events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbOrderBarsCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbUnderTickmarks.CheckedChanged
            ' Locate the associated scale from the gauge's
            ' LinearScales list

            Dim scale As GaugeLinearScale = gcLinear4.LinearScales("Scale1")

            If scale IsNot Nothing Then
                ' Set the UnderTickMarks property accordingly for Bar1 and Bar3

                scale.Pointers("Bar1").UnderTickMarks = cbUnderTickmarks.Checked
                scale.Pointers("Bar3").UnderTickMarks = cbUnderTickmarks.Checked
            End If
        End Sub

#End Region

#End Region

#Region "gcLinear5"

#Region "RbBulbCheckedChanged"

        ''' <summary>
        ''' Handles Bulb RadioButton events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub RbBulbCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbBulb.CheckedChanged
            If rbBulb.Checked = True Then
                ' Locate and set the associated BulbStyle

                Dim pointer As GaugePointer = GetLinearPointer(gcLinear5, "Scale1", "Thermo")

                If pointer IsNot Nothing Then
                    pointer.BulbStyle = BulbStyle.Bulb
                End If
            End If
        End Sub

#End Region

#Region "RbFlaskCheckedChanged"

        ''' <summary>
        ''' Handles Flask RadioButton events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub RbFlaskCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbFlask.CheckedChanged
            If rbFlask.Checked = True Then
                ' Locate and set the associated BulbStyle

                Dim pointer As GaugePointer = GetLinearPointer(gcLinear5, "Scale1", "Thermo")

                If pointer IsNot Nothing Then
                    pointer.BulbStyle = BulbStyle.Flask
                End If
            End If
        End Sub

#End Region

#Region "CbSetSnapCheckedChanged"

        ''' <summary>
        ''' Handles SetSnap checkbox events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbSetSnapCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbSetSnap.CheckedChanged
            ' Locate and set the associated BulbStyle

            Dim pointer As GaugePointer = GetLinearPointer(gcLinear5, "Scale1", "Thermo")

            If pointer IsNot Nothing Then
                pointer.SnapInterval = CDbl(IIf(cbSetSnap.Checked, 2, 0))
            End If
        End Sub

#End Region

#End Region

#Region "gcLinear6"

#Region "ColorPickerButton1SelectedColorChanged"

        ''' <summary>
        ''' Handles ColorPicker FillColor.Color1 change events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub ColorPickerButton1SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton1.SelectedColorChanged
            ' Locate the associated scale
            ' Pointer, and set its FillColor.Color1 accordingly

            Dim pointer As GaugePointer = GetLinearPointer(gcLinear6, "Scale1", "Thermo")

            If pointer IsNot Nothing Then
                pointer.FillColor.Color1 = colorPickerButton1.SelectedColor
            End If
        End Sub

#End Region

#Region "ColorPickerButton2SelectedColorChanged"

        ''' <summary>
        ''' Handles ColorPicker FillColor.Color2 change events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub ColorPickerButton2SelectedColorChanged(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton2.SelectedColorChanged
            ' Locate the associated scale
            ' Pointer, and set its FillColor.Color2 accordingly

            Dim pointer As GaugePointer = GetLinearPointer(gcLinear6, "Scale1", "Thermo")

            If pointer IsNot Nothing Then
                pointer.FillColor.Color2 = colorPickerButton2.SelectedColor
            End If
        End Sub

#End Region

#Region "CbFillModeSelectedIndexChanged"

        ''' <summary>
        ''' Handles FillMode combobox changes
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbFillModeSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbFillMode.SelectedIndexChanged
            ' Locate the associated scale
            ' Pointer, and set its FillColor.Color2 accordingly

            Dim pointer As GaugePointer = GetLinearPointer(gcLinear6, "Scale1", "Thermo")

            If pointer IsNot Nothing Then
                pointer.FillColor.GradientFillType = CType(cbFillMode.SelectedIndex, GradientFillType)
            End If

            cbSliderAngle.Enabled = (cbFillMode.SelectedIndex = 1)
        End Sub

#End Region

#Region "CbSliderAngleValueChanged"

        ''' <summary>
        ''' Handles SliderAngle checkbox changes
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbSliderAngleValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbSliderAngle.ValueChanged
            ' Locate the associated scale
            ' Pointer, and set its FillColor.GradientAngle accordingly

            Dim pointer As GaugePointer = GetLinearPointer(gcLinear6, "Scale1", "Thermo")

            If pointer IsNot Nothing Then
                pointer.FillColor.GradientAngle = cbSliderAngle.Value
            End If

            cbSliderAngle.Text = "Angle (" & cbSliderAngle.Value.ToString() & ")"
        End Sub

#End Region

#End Region

#Region "gcLinear7"

#Region "GcLinear7PointerChanged"

        ''' <summary>
        ''' Handles keeping the gcLinear7 bar value in sync
        ''' with the marker value
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcLinear7PointerChanged(ByVal sender As Object, ByVal e As PointerChangedEventArgs) Handles gcLinear7.PointerChanged
            Dim scale As GaugeLinearScale = gcLinear7.LinearScales("Scale1")

            If scale IsNot Nothing Then
                Dim bar As GaugePointer = scale.Pointers("Bar")
                Dim marker As GaugePointer = scale.Pointers("Marker")

                If bar IsNot Nothing AndAlso marker IsNot Nothing Then
                    bar.Value = marker.Value
                End If
            End If
        End Sub

#End Region

#End Region

#Region "gcLinear8"

#Region "gcLinear8PreRenderScalePointer"

        ''' <summary>
        ''' Handles PreRenderScalePointer events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcLinear8PreRenderScalePointer(ByVal sender As Object, ByVal e As PreRenderScalePointerEventArgs) Handles gcLinear8.PreRenderScalePointer
            ' There are only bar pointers defined in this gauge, so we are
            ' just going to fill every pointer with a LinearGradient going
            ' from ForestGreen to Lime to Yellow to Orange to Red.

            Dim path As GraphicsPath = e.Pointer.GetPointerPath()

            If path IsNot Nothing Then
                Dim r As Rectangle = e.Pointer.Scale.Bounds

                Using br As New LinearGradientBrush(r, Color.White, Color.White, -90)
                    Dim cb As New ColorBlend(_Colors.Length)
                    cb.Colors = _Colors
                    cb.Positions = _Positions

                    br.InterpolationColors = cb

                    e.Graphics.FillPath(br, path)
                End Using

                ' Tell the system to cancel its rendering, since
                ' we just rendered the contents of the pointer

                e.Cancel = True
            End If
        End Sub

#End Region

#End Region

#End Region

#Region "Event samples"

#Region "gcPointerChange"

#Region "GcPointerChangePointerChanged"

        ''' <summary>
        ''' Handles the gauge's PointerChanged events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcPointerChangePointerChanged(ByVal sender As Object, ByVal e As PointerChangedEventArgs) Handles gcPointerChange.PointerChanged
            ' Locate the "Planned" GaugeItem, and update its text
            ' to reflect the pointer change

            Dim item As GaugeText = TryCast(gcPointerChange.GaugeItems("Planned"), GaugeText)

            If item IsNot Nothing Then
                item.Text = String.Format("(Planned {0:C0})", e.Pointer.Value * 1000)
            End If

            e.Pointer.FillColor.Color1 = CType(IIf(e.Pointer.Value >= 65, Color.Lime, Color.Yellow), Color)
        End Sub

#End Region

#Region "GcPointerChangePointerChanging"

        ''' <summary>
        ''' Handles the gauge's PointerChanging event
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcPointerChangePointerChanging(ByVal sender As Object, ByVal e As PointerChangingEventArgs) Handles gcPointerChange.PointerChanging
            ' Constrain the pointer to not fall below the 30 mark

            If e.NewValue < 30 Then
                e.NewValue = 30
            End If
        End Sub

#End Region

#End Region

#Region "gcEnterLeave"

#Region "Scale event processing"

#Region "GcEnterLeaveScaleEnter"

        ''' <summary>
        ''' Handles the gauge's ScaleEnter events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcEnterLeaveScaleEnter(ByVal sender As Object, ByVal e As ScaleEnterEventArgs) Handles gcEnterLeave.ScaleEnter
            ' Display the event, if the user wants to see them

            If cbShowScaleEvents.Checked = True Then
                rtb1.SelectionColor = Color.Red
                rtb1.AppendText(e.Pointer.Name & " Entered Scale '" & e.Scale.Name & "'" & vbLf)
                rtb1.ScrollToCaret()
            End If
        End Sub

#End Region

#Region "GcEnterLeaveScaleLeave"

        ''' <summary>
        ''' Handles the gauge's ScaleLeave events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcEnterLeaveScaleLeave(ByVal sender As Object, ByVal e As ScaleLeaveEventArgs) Handles gcEnterLeave.ScaleLeave
            ' Display the event, if the user wants to see them

            If cbShowScaleEvents.Checked = True Then
                rtb1.SelectionColor = Color.DarkRed
                rtb1.AppendText(e.Pointer.Name & " Left Scale '" & e.Scale.Name & "'" & vbLf)
            End If
        End Sub

#End Region

#End Region

#Region "Range event processing"

#Region "GcEnterLeaveRangeEnter"

        ''' <summary>
        ''' Handles the gauge's RangeEnter events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcEnterLeaveRangeEnter(ByVal sender As Object, ByVal e As RangeEnterEventArgs) Handles gcEnterLeave.RangeEnter
            ' Display the event, if the user wants to see them

            If cbShowRangeEvents.Checked = True Then
                rtb1.SelectionColor = Color.Green
                rtb1.AppendText(e.Pointer.Name & " Entered '" & e.Range.Name & "'" & vbLf)
            End If
        End Sub

#End Region

#Region "GcEnterLeaveRangeLeave"

        ''' <summary>
        ''' Handles the gauge's RangeLeave events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcEnterLeaveRangeLeave(ByVal sender As Object, ByVal e As RangeLeaveEventArgs) Handles gcEnterLeave.RangeLeave
            ' Display the event, if the user wants to see them

            If cbShowRangeEvents.Checked = True Then
                rtb1.SelectionColor = Color.DarkGreen
                rtb1.AppendText(e.Pointer.Name & " Left '" & e.Range.Name & "'" & vbLf)
            End If
        End Sub

#End Region

#End Region

#Region "Section event processing"

#Region "GcEnterLeaveSectionEnter"

        ''' <summary>
        ''' Handles the gauge's SectionEnter events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcEnterLeaveSectionEnter(ByVal sender As Object, ByVal e As SectionEnterEventArgs) Handles gcEnterLeave.SectionEnter
            ' Display the event, if the user wants to see them

            If cbShowSectionEvents.Checked = True Then
                rtb1.SelectionColor = Color.Blue
                rtb1.AppendText(e.Pointer.Name & " Entered '" & e.Section.Name & "'" & vbLf)
            End If
        End Sub

#End Region

#Region "GcEnterLeaveSectionLeave"

        ''' <summary>
        ''' Handles the gauge's SectionLeave events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcEnterLeaveSectionLeave(ByVal sender As Object, ByVal e As SectionLeaveEventArgs) Handles gcEnterLeave.SectionLeave
            ' Display the event, if the user wants to see them

            If cbShowSectionEvents.Checked = True Then
                rtb1.SelectionColor = Color.DarkBlue
                rtb1.AppendText(e.Pointer.Name & " Left '" & e.Section.Name & "'" & vbLf)
            End If
        End Sub

#End Region

#End Region

#Region "Button click processing"

#Region "BtnClearClick"

        ''' <summary>
        ''' Clears the rtb contents
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BtnClearClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
            rtb1.Clear()
        End Sub

#End Region

#Region "BtnPlus30Click"

        ''' <summary>
        ''' Handles BtnPlus30 click events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BtnPlus30Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPlus30.Click
            ' Locate the associated scale, and add 30 to
            ' every Pointer defined for it

            Dim scale As GaugeScale = gcEnterLeave.CircularScales("Scale1")

            If scale IsNot Nothing Then
                For i As Integer = 0 To scale.Pointers.Count - 1
                    scale.Pointers(i).Value += 30
                Next i
            End If
        End Sub

#End Region

#Region "BtnMinus20Click"

        ''' <summary>
        ''' Handles BtnMinus20 click events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BtnMinus20Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMinus20.Click
            ' Locate the associated scale, and subtract 20 from
            ' every Pointer defined for it

            Dim scale As GaugeScale = gcEnterLeave.CircularScales("Scale1")

            If scale IsNot Nothing Then
                For i As Integer = 0 To scale.Pointers.Count - 1
                    scale.Pointers(i).Value -= 20
                Next i
            End If
        End Sub

#End Region

#Region "BtnMinClick"

        ''' <summary>
        ''' Handles BtnMin click events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BtnMinClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnMin.Click
            ' Locate the associated scale, and set the Value
            ' of every defined Pointer to the scale's minimum

            Dim scale As GaugeScale = gcEnterLeave.CircularScales("Scale1")

            If scale IsNot Nothing Then
                For i As Integer = 0 To scale.Pointers.Count - 1
                    scale.Pointers(i).Value = scale.MinValue
                Next i
            End If
        End Sub

#End Region

#Region "BtnMaxClick"

        ''' <summary>
        ''' Handles BtnMax click events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BtnMaxClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnMax.Click
            ' Locate the associated scale, and set the Value
            ' of every defined Pointer to the scale's maximum

            Dim scale As GaugeScale = gcEnterLeave.CircularScales("Scale1")

            If scale IsNot Nothing Then
                For i As Integer = 0 To scale.Pointers.Count - 1
                    scale.Pointers(i).Value = scale.MaxValue
                Next i
            End If
        End Sub

#End Region

#Region "BtnAutoClick"

        ''' <summary>
        ''' Handles BtnAuto click events.
        ''' 
        ''' This routine either enables or disables the automatic update
        ''' of the associated scale's pointers to randomly changing values.
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BtnAutoClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnAuto.Click
            ' If we need to enable the process, then allocate
            ' and initialize our Timer to handle the udates

            If _Timer1 Is Nothing Then
                _Timer1 = New Timer()
                AddHandler _Timer1.Tick, AddressOf RandomTimer_Tick1

                _Timer1.Interval = 250
                _Timer1.Start()

                btnAuto.Text = "Stop"
            Else
                _Timer1.Stop()
                RemoveHandler _Timer1.Tick, AddressOf RandomTimer_Tick1
                _Timer1.Dispose()
                _Timer1 = Nothing

                btnAuto.Text = "Auto"
            End If
        End Sub

#End Region

#End Region

#Region "SliderDampenValueChanged"

        ''' <summary>
        ''' Handles SliderDampen change events
        ''' 
        ''' A Pointer's DampeningSweepTime determines how long it takes
        ''' (in seconds) for the pointer to "sweep" across the entire range
        ''' of the scale.  The dampening effect helps give the gauge a more
        ''' realistic operation for the simulated material being monitored
        ''' by the gauge (air, water, oil, tar, etc).
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub SliderDampenValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles sliderDampen1.ValueChanged
            ' Locate the scale for the associated gauge, and set
            ' every defined Pointer's DampeningSweepTime to the set value.

            Dim scale As GaugeScale = gcEnterLeave.CircularScales("Scale1")

            If scale IsNot Nothing Then
                For i As Integer = 0 To scale.Pointers.Count - 1
                    scale.Pointers(i).DampeningSweepTime = sliderDampen1.Value
                Next i
            End If

            sliderDampen1.Text = sliderDampen1.Value.ToString()
        End Sub

#End Region

#Region "RandomTimer_Tick1"

        ''' <summary>
        ''' Handles timer ticks, used to update the associated
        ''' scale's pointers with new, random, pointer values
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub RandomTimer_Tick1(ByVal sender As Object, ByVal e As EventArgs)
            Dim scale As GaugeScale = gcEnterLeave.CircularScales("Scale1")

            If scale IsNot Nothing Then
                For i As Integer = 0 To scale.Pointers.Count - 1
                    ' Get a new random value for the pointer

                    Dim n As Integer = _Rand.Next(-1000, 1000)

                    Dim value As Double = scale.Pointers(i).Value + n / 100

                    ' Make sure we keep it in the scale range

                    If value < scale.MinValue Then
                        value = scale.MinValue

                    ElseIf value > scale.MaxValue Then
                        value = scale.MaxValue
                    End If

                    scale.Pointers(i).Value = value
                Next i
            End If
        End Sub

#End Region

#Region "GcEnterLeavePointerValueChanged"

        ''' <summary>
        ''' Handles gcEnterLeave PointerValueChanged events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcEnterLeavePointerValueChanged(ByVal sender As Object, ByVal e As PointerChangedEventArgs) Handles gcEnterLeave.PointerValueChanged
            If e.Pointer.Name.Equals("DarkRed Needle") = True Then
                Dim ni As NumericIndicator = TryCast(gcEnterLeave.GaugeItems("NumericIndicator1"), NumericIndicator)

                If ni IsNot Nothing Then
                    ni.Value = e.NewValue
                End If
            ElseIf e.Pointer.Name.Equals("Yellow Marker") = True Then
                Dim si As StateIndicator = TryCast(gcEnterLeave.GaugeItems("StateIndicator1"), StateIndicator)

                If si IsNot Nothing Then
                    si.Value = e.NewValue
                End If
            End If
        End Sub

#End Region

#End Region

#Region "gcHitTesting"

#Region "GcHitTestingMouseMove"

        ''' <summary>
        ''' Handles MouseMove events for the associated gauge
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcHitTestingMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gcHitTesting.MouseMove
            ' Get the item located at the given point

            Dim item As GaugeItem = gcHitTesting.GetGaugeItemFromPoint(e.Location)

            If item IsNot _LastItem Then
                ' There is an item at the given point, so inform the user
                ' whether they are entering or leaving the item

                If _LastItem IsNot Nothing Then
                    rtb2.AppendText("Leave: " & _LastItem.Name & vbLf)
                End If

                If item IsNot Nothing Then
                    rtb2.AppendText("Enter: " & item.Name & vbLf)
                End If

                _LastItem = item
            End If
        End Sub

#End Region

#Region "GcHitTestingMouseClick"

        ''' <summary>
        ''' Handles MouseClick events for the associated gauge
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcHitTestingMouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gcHitTesting.MouseClick
            ' Get the item located at the given point

            Dim item As GaugeItem = gcHitTesting.GetGaugeItemFromPoint(e.Location)

            If item IsNot Nothing Then
                ' Just for grins, if they clicked on the HeadSet item, then
                ' rotate the image by 30 degrees each time

                Dim gi As GaugeImage = TryCast(item, GaugeImage)

                If gi IsNot Nothing AndAlso gi.Name.Equals("HeadSet") Then
                    gi.Angle += 30
                End If
            End If
        End Sub

#End Region

#Region "BtnRtb2ClearClick"

        ''' <summary>
        ''' Clear the associated RichTextBox
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BtnRtb2ClearClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnRtb2Clear.Click
            rtb2.Clear()
        End Sub

#End Region

#End Region

#Region "gcUserRendering"

#Region "Render event processing"

#Region "GcUserRenderingPostRenderScalePointer"

        ''' <summary>
        ''' Handles PostRenderScalePointer events for the associated gauge.
        ''' 
        ''' PostRender events occur after the system has already rendered
        ''' the item (in this case, a scale pointer).  All we are going to
        ''' do is to draw on top of what the system has drawn, so post rendering
        ''' is what we want.  If we wanted to draw the item completely ourselves
        ''' then we would use the associated PreRender event.
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcUserRenderingPostRenderScalePointer(ByVal sender As Object, ByVal e As PostRenderScalePointerEventArgs)
            Dim path As GraphicsPath = e.Pointer.GetPointerPath()

            If path IsNot Nothing Then
                If e.Pointer.Name.Equals("Bar") Then
                    RenderBar(e, path)

                ElseIf e.Pointer.Name.Equals("Marker") Then
                    RenderMarker(e, path)

                ElseIf e.Pointer.Name.Equals("Needle") Then
                    RenderNeedle(e, path)
                End If
            End If
        End Sub

#Region "RenderBar"

        ''' <summary>
        ''' Handles the rendering of our bar pointers
        ''' </summary>
        ''' <param name="e"></param>
        ''' <param name="path">Barr's GraphicsPath</param>
        Private Sub RenderBar(ByVal e As PostRenderScalePointerEventArgs, ByVal path As GraphicsPath)
            ' If the user wants us to render this pointer, then do so
            ' by just filling the area with a hatched brush (simple, yet effective)

            If cbBar.Checked = True Then
                Using br As New HatchBrush(HatchStyle.OutlinedDiamond, Color.Transparent)
                    e.Graphics.FillPath(br, path)
                End Using
            End If
        End Sub

#End Region

#Region "RenderMarker"

        ''' <summary>
        ''' Handles the rendering of our bar pointers
        ''' </summary>
        ''' <param name="e"></param>
        ''' <param name="path">Barr's GraphicsPath</param>
        Private Sub RenderMarker(ByVal e As PostRenderScalePointerEventArgs, ByVal path As GraphicsPath)
            ' If the user wants us to render this pointer, then do so
            ' by just filling the area with a hatched brush (simple, yet effective)

            If cbMarker.Checked = True Then
                Using br As New HatchBrush(HatchStyle.SmallCheckerBoard, Color.Transparent)
                    e.Graphics.FillPath(br, path)
                End Using
            End If
        End Sub

#End Region

#Region "RenderNeedle"

        ''' <summary>
        ''' Handles the rendering of our Needle pointers
        ''' </summary>
        ''' <param name="e"></param>
        ''' <param name="path">Needle's GraphicsPath</param>
        Private Sub RenderNeedle(ByVal e As PostRenderScalePointerEventArgs, ByVal path As GraphicsPath)
            ' Check to see if the user wants us to render this pointer

            If cbNeedle.Checked = True Then
                ' Fill in the needle area with a simple hatched brush

                Using br As New HatchBrush(HatchStyle.Trellis, Color.Transparent)
                    e.Graphics.FillPath(br, path)
                End Using

                Dim r As Rectangle = e.Pointer.CapBounds

                r.Inflate(10, 10)

                If r.IsEmpty = False Then
                    ' Create our own unique cap, and draw it

                    Dim n As Integer = CInt(Fix(e.Pointer.Value / 10)) + 3

                    Using p2 As GraphicsPath = GetStarPath(r, n)
                        Dim pt As New Point(r.X + r.Width \ 2, r.Y + r.Height \ 2)

                        Dim matrix_Renamed As New Matrix()
                        matrix_Renamed.RotateAt((e.Pointer.IntervalAngle + 90) Mod 360, pt)

                        p2.Transform(matrix_Renamed)

                        e.Graphics.FillPath(Brushes.Cyan, p2)
                        e.Graphics.DrawPath(Pens.DimGray, p2)

                        Using sf As New StringFormat()
                            sf.Alignment = StringAlignment.Center
                            sf.LineAlignment = StringAlignment.Center

                            e.Graphics.DrawString((CInt(Fix(e.Pointer.Value))).ToString(), Font, Brushes.Black, r, sf)
                        End Using
                    End Using
                End If
            End If
        End Sub

#End Region

#Region "GetStarPath"

        ''' <summary>
        ''' Creates a Star path
        ''' </summary>
        ''' <param name="r">Bounding rectangle</param>
        ''' <param name="points">Number of points in the star</param>
        ''' <returns></returns>
        Private Function GetStarPath(ByVal r As Rectangle, ByVal points As Integer) As GraphicsPath
            Dim path As New GraphicsPath()

            Dim pts(2 * points - 1) As PointF

            Dim rx1 As Double = r.Width \ 2
            Dim ry1 As Double = r.Height \ 2

            If rx1 < 2 Then
                rx1 = 2
            End If

            If ry1 < 2 Then
                ry1 = 2
            End If

            Dim rx2 As Double = rx1 / 2
            Dim ry2 As Double = ry1 / 2

            Dim cx As Double = r.X + rx1
            Dim cy As Double = r.Y + ry1

            Dim theta As Double = Math.PI / 180 * 90
            Dim dtheta As Double = Math.PI / points

            For i As Integer = 0 To 2 * points - 1 Step 2
                pts(i) = New PointF(CSng(cx + rx1 * Math.Cos(theta)), CSng(cy + ry1 * Math.Sin(theta)))

                theta += dtheta

                pts(i + 1) = New PointF(CSng(cx + rx2 * Math.Cos(theta)), CSng(cy + ry2 * Math.Sin(theta)))

                theta += dtheta
            Next i

            path.AddPolygon(pts)

            path.CloseAllFigures()

            Return (path)
        End Function

#End Region

#End Region

#Region "GcUserRenderingPostRenderScaleRange"

        Private Sub GcUserRenderingPostRenderScaleRange(ByVal sender As Object, ByVal e As PostRenderScaleRangeEventArgs)
            Dim path As GraphicsPath = e.Range.GetRangePath()

            If path IsNot Nothing Then
                Using br As New HatchBrush(HatchStyle.LargeConfetti, Color.Transparent)
                    e.Graphics.FillPath(br, path)
                End Using
            End If
        End Sub

#End Region

#Region "GcUserRenderingPostRenderScaleSection"

        Private Sub GcUserRenderingPostRenderScaleSection(ByVal sender As Object, ByVal e As PostRenderScaleSectionEventArgs)
            Dim path As GraphicsPath = e.Section.GetSectionPath()

            If path IsNot Nothing Then
                Using br As New HatchBrush(HatchStyle.SmallCheckerBoard, Color.Transparent)
                    e.Graphics.FillPath(br, path)
                End Using
            End If
        End Sub

#End Region

#Region "GcUserRenderingPreRenderGaugeContent"

        Private Sub GcUserRenderingPreRenderGaugeContent(ByVal sender As Object, ByVal e As RenderGaugeContentEventArgs)
            Using br As New LinearGradientBrush(e.Bounds, Color.White, Color.White, -90)
                Dim cb As New ColorBlend(_Colors.Length)
                cb.Colors = _Colors
                cb.Positions = _Positions

                br.InterpolationColors = cb

                e.Graphics.FillRectangle(br, e.Bounds)
            End Using
        End Sub

#End Region

#Region "gcUserRenderingPreRenderFrame"

        ''' <summary>
        ''' Handles PreRenderFrame events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcUserRenderingPreRenderFrame(ByVal sender As Object, ByVal e As PreRenderFrameEventArgs)
            Dim g As Graphics = e.Graphics
            Dim frame As GaugeFrame = gcUserRendering.Frame

            Dim r As Rectangle = e.Bounds

            Dim n As Integer = Math.Min(r.Width, r.Height)

            Dim outer As Integer = CInt(IIf(frame.OuterBevel < 0.5F, CInt(Fix(n * frame.OuterBevel)), n \ 2))

            Dim inner As Integer = CInt(IIf(frame.InnerBevel < 0.5F, CInt(Fix(n * frame.InnerBevel)), n \ 2))

            ' Get the frame path

            Using path As GraphicsPath = GetFramePath(e, outer, inner)
                ' Just for grins, lets rotate the gauge frame to match the
                ' current, default scale needle pointer

                Dim pointer As GaugePointer = GetCircularPointer(gcUserRendering, "Scale1", "Needle")

                If pointer IsNot Nothing Then
                    Dim matrix_Renamed As New Matrix()

                    Dim center As New Point(r.X + r.Width \ 2, r.Y + r.Height \ 2)

                    matrix_Renamed.RotateAt(pointer.IntervalAngle, center)
                    path.Transform(matrix_Renamed)
                End If

                ' Let's put a slight shadow on the frame

                Dim myMatrix As New Matrix()
                myMatrix.Translate(2, 3)
                path.Transform(myMatrix)

                Using br As Brush = New SolidBrush(frame.FrameColor.BorderColor)
                    g.FillPath(br, path)
                End Using

                myMatrix.Reset()
                myMatrix.Translate(-2, -3)
                path.Transform(myMatrix)

                ' Fill in the outer frame bevel and draw the frame border

                Using br As Brush = frame.FrameColor.GetBrush(r, 45)
                    g.FillPath(br, path)
                End Using

                Using pen_Renamed As New Pen(frame.FrameColor.BorderColor)
                    g.DrawPath(pen_Renamed, path)
                End Using

                ' Fill in the inner bevel area

                r.Inflate(-outer, -outer)

                Using br As Brush = frame.FrameColor.GetBrush(r, 45 + 180)
                    g.FillEllipse(br, r)
                End Using

                r.Inflate(-inner, -inner)

                ' Fill in the default background area

                If cbBackground.Checked = False Then
                    Using br As Brush = frame.BackColor.GetBrush(r, 45)
                        g.FillEllipse(br, r)
                    End Using
                End If
            End Using

            ' Tell the system to not do its default rendering

            e.Cancel = True
        End Sub

#End Region

#Region "GetFramePath"

        ''' <summary>
        ''' Gets the new frame path
        ''' </summary>
        ''' <param name="e"></param>
        ''' <param name="outer"></param>
        ''' <param name="inner"></param>
        ''' <returns></returns>
        Private Function GetFramePath(ByVal e As PreRenderFrameEventArgs, ByVal outer As Integer, ByVal inner As Integer) As GraphicsPath
            Dim path As New GraphicsPath()

            Dim rad1 As Integer = e.Bounds.Width \ 2
            Dim rad2 As Integer = rad1 - outer + inner \ 2

            Dim center As New Point(e.Bounds.X + rad1, e.Bounds.Y + rad1)

            For i As Integer = 0 To 59
                Dim m As Integer = i * 6

                If (i Mod 2) = 0 Then
                    Dim pt1 As Point = GetPoint(rad1, m + 1, center)
                    Dim pt2 As Point = GetPoint(rad1, m + 5, center)

                    path.AddLine(pt1, pt2)
                Else
                    Dim pt1 As Point = GetPoint(rad2, m, center)
                    Dim pt2 As Point = GetPoint(rad2, m + 6, center)

                    path.AddLine(pt1, pt2)

                End If
            Next i

            path.CloseAllFigures()

            Return (path)
        End Function

#End Region

#Region "GetPoint"

        ''' <summary>
        ''' Calculates a Point based upon a given data
        ''' </summary>
        ''' <param name="radius">Circle radius</param>
        ''' <param name="angle">Angle</param>
        ''' <param name="center">Center of the circle</param>
        ''' <returns></returns>
        Friend Function GetPoint(ByVal radius As Integer, ByVal angle As Single, ByVal center As Point) As Point
            Dim pt As New Point()

            If angle < 0 Then
                angle += 360
            End If

            angle = angle Mod 360

            Dim radians As Double = (angle Mod 90) * Math.PI / 180

            If angle < 90 Then
                pt.X = CInt(Fix(Math.Cos(radians) * radius))
                pt.Y = CInt(Fix(Math.Sin(radians) * radius))
            ElseIf angle < 180 Then
                pt.X = -CInt(Fix(Math.Sin(radians) * radius))
                pt.Y = CInt(Fix(Math.Cos(radians) * radius))
            ElseIf angle < 270 Then
                pt.X = -CInt(Fix(Math.Cos(radians) * radius))
                pt.Y = -CInt(Fix(Math.Sin(radians) * radius))
            Else
                pt.X = CInt(Fix(Math.Sin(radians) * radius))
                pt.Y = -CInt(Fix(Math.Cos(radians) * radius))
            End If

            pt.X += center.X
            pt.Y += center.Y

            Return (pt)
        End Function

#End Region

#Region "GcUserRenderingGetPointerPath"

        ''' <summary>
        ''' Provides the gauge with user defined
        ''' Pointer paths
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcUserRenderingGetPointerPath(ByVal sender As Object, ByVal e As GetPointerPathEventArgs)
            If e.Pointer.Name.Equals("Needle") = True Then
                GetNeedlePath(e)

            ElseIf e.Pointer.Name.Equals("Marker") = True Then
                GetMarkerPath(e)
            End If
        End Sub

#Region "GetMarkerPath"

        ''' <summary>
        ''' Gets our user defined Marker path
        ''' </summary>
        ''' <param name="e"></param>
        Private Sub GetMarkerPath(ByVal e As GetPointerPathEventArgs)
            If cbMarker.Checked = True Then
                Dim path As New GraphicsPath()

                path.AddEllipse(e.Bounds)

                e.Path = path
            End If
        End Sub

#End Region

#Region "GetNeedlePath"

        ''' <summary>
        ''' Gets our user defined Needle path
        ''' </summary>
        ''' <param name="e"></param>
        Private Sub GetNeedlePath(ByVal e As GetPointerPathEventArgs)
            If cbNeedle.Checked = True Then
                Dim path As New GraphicsPath()

                Dim r As Rectangle = e.Bounds

                Dim x1 As Integer = r.X + r.Width \ 2
                Dim y1 As Integer = r.Y + r.Height \ 2
                Dim y2 As Integer = r.Y + r.Height \ 5

                Dim pts() As Point = {New Point(x1, r.Y), New Point(x1 + 2, y2), New Point(r.Right, y1), New Point(r.Right, r.Bottom), New Point(x1, r.Bottom - r.Width \ 2), New Point(r.X, r.Bottom), New Point(r.X, y1), New Point(x1 - 2, y2)}

                path.AddClosedCurve(pts)

                path.CloseAllFigures()

                e.Path = path
            End If
        End Sub

#End Region

#End Region

#End Region

#Region "Checkbox processing"

#Region "CbFrameCheckedChanged"

        ''' <summary>
        ''' Handles Frame checkbox changed events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbFrameCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbFrame.CheckedChanged
            ' Hook (or unhook) the event depending upon whether the
            ' user wants us to render the area or not

            If cbFrame.Checked = True Then
                AddHandler gcUserRendering.Frame.PreRenderFrame, AddressOf GcUserRenderingPreRenderFrame
            Else
                RemoveHandler gcUserRendering.Frame.PreRenderFrame, AddressOf GcUserRenderingPreRenderFrame
            End If

            gcUserRendering.Refresh()
        End Sub

#End Region

#Region "CbBackgroundCheckedChanged"

        ''' <summary>
        ''' Handles Background checkbox changed events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbBackgroundCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbBackground.CheckedChanged
            ' Hook (or unhook) the event depending upon whether the
            ' user wants us to render the area or not

            If cbBackground.Checked = True Then
                AddHandler gcUserRendering.PreRenderGaugeContent, AddressOf GcUserRenderingPreRenderGaugeContent
            Else
                RemoveHandler gcUserRendering.PreRenderGaugeContent, AddressOf GcUserRenderingPreRenderGaugeContent
            End If

            gcUserRendering.Refresh()
        End Sub

#End Region

#Region "CbRangeCheckedChanged"

        ''' <summary>
        ''' Handles Range checkbox change events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbRangeCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbRange.CheckedChanged
            ' Hook (or unhook) the event depending upon whether the
            ' user wants us to render the area or not

            If cbRange.Checked = True Then
                AddHandler gcUserRendering.PostRenderScaleRange, AddressOf GcUserRenderingPostRenderScaleRange
            Else
                RemoveHandler gcUserRendering.PostRenderScaleRange, AddressOf GcUserRenderingPostRenderScaleRange
            End If

            gcUserRendering.Refresh()
        End Sub

#End Region

#Region "CbSectionCheckedChanged"

        ''' <summary>
        ''' Handles Section checkbox changed events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbSectionCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbSection.CheckedChanged
            ' Hook (or unhook) the event depending upon whether the
            ' user wants us to render the area or not

            If cbSection.Checked = True Then
                AddHandler gcUserRendering.PostRenderScaleSection, AddressOf GcUserRenderingPostRenderScaleSection
            Else
                RemoveHandler gcUserRendering.PostRenderScaleSection, AddressOf GcUserRenderingPostRenderScaleSection
            End If

            gcUserRendering.Refresh()
        End Sub

#End Region

#Region "CbBarCheckedChanged"

        ''' <summary>
        ''' Handles Bar checked changed events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbBarCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbBar.CheckedChanged
            ' Hook (or unhook) the event depending upon whether the
            ' user wants us to render the area or not

            If cbBar.Checked = True Then
                EnableRenderPointerEvent(True)
            Else
                DisableRenderPointerEvent(True)
            End If
        End Sub

#End Region

#Region "CbNeedleCheckedChanged"

        ''' <summary>
        ''' Handles Needle checked change events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbNeedleCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbNeedle.CheckedChanged
            ' Hook (or unhook) the event depending upon whether the
            ' user wants us to render the area or not

            Dim pointer As GaugePointer = gcUserRendering.CircularScales("Scale1").Pointers("Needle")

            If pointer IsNot Nothing Then
                If cbNeedle.Checked = True Then
                    pointer.CapStyle = NeedlePointerCapStyle.None
                    AddHandler gcUserRendering.GetPointerPath, AddressOf GcUserRenderingGetPointerPath

                    EnableRenderPointerEvent(True)
                Else
                    pointer.CapStyle = NeedlePointerCapStyle.Style1
                    RemoveHandler gcUserRendering.GetPointerPath, AddressOf GcUserRenderingGetPointerPath

                    DisableRenderPointerEvent(True)
                End If
            End If
        End Sub

#End Region

#Region "CbMarkerCheckedChanged"

        ''' <summary>
        ''' Handles Marker checked change events
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbMarkerCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbMarker.CheckedChanged
            ' Hook (or unhook) the event depending upon whether the
            ' user wants us to render the area or not

            Dim pointer As GaugePointer = gcUserRendering.CircularScales("Scale1").Pointers("Marker")

            If pointer IsNot Nothing Then
                If cbMarker.Checked = True Then
                    EnableRenderPointerEvent(False)
                    EnableGetPointerPathEvent(True)
                Else
                    DisableRenderPointerEvent(False)
                    DisableGetPointerPathEvent(True)
                End If
            End If
        End Sub

#End Region

#Region "EnableRenderPointerEvent"

        ''' <summary>
        ''' Enables PostRenderScalePointer event processing
        ''' </summary>
        Private Sub EnableRenderPointerEvent(ByVal refresh As Boolean)
            _RenderPointerEventCount += 1

            If _RenderPointerEventCount = 1 Then
                AddHandler gcUserRendering.PostRenderScalePointer, AddressOf GcUserRenderingPostRenderScalePointer
            End If

            ' Refresh the control so our rendering can be performed

            If refresh = True Then
                gcUserRendering.Refresh()
            End If
        End Sub

#End Region

#Region "DisableRenderPointerEvent"

        ''' <summary>
        ''' Disables PostRenderScalePointer event processing
        ''' </summary>
        Private Sub DisableRenderPointerEvent(ByVal refresh As Boolean)
            _RenderPointerEventCount -= 1

            If _RenderPointerEventCount = 0 Then
                RemoveHandler gcUserRendering.PostRenderScalePointer, AddressOf GcUserRenderingPostRenderScalePointer
            End If

            ' Refresh the control so our rendering can be performed

            If refresh = True Then
                gcUserRendering.Refresh()
            End If
        End Sub

#End Region

#Region "EnableGetPointerPathEvent"

        ''' <summary>
        ''' Enables EnableGetPointerPath event processing
        ''' </summary>
        Private Sub EnableGetPointerPathEvent(ByVal refresh As Boolean)
            _GetPointerPathEventCount += 1

            If _GetPointerPathEventCount = 1 Then
                AddHandler gcUserRendering.GetPointerPath, AddressOf GcUserRenderingGetPointerPath
            End If

            ' Refresh the control so our rendering can be performed

            If refresh = True Then
                gcUserRendering.Refresh()
            End If
        End Sub

#End Region

#Region "DisableGetPointerPathEvent"

        ''' <summary>
        ''' Disables DisableGetPointerPath event processing
        ''' </summary>
        Private Sub DisableGetPointerPathEvent(ByVal refresh As Boolean)
            _GetPointerPathEventCount -= 1

            If _GetPointerPathEventCount = 0 Then
                RemoveHandler gcUserRendering.GetPointerPath, AddressOf GcUserRenderingGetPointerPath
            End If

            ' Refresh the control so our rendering can be performed

            If refresh = True Then
                gcUserRendering.Refresh()
            End If
        End Sub

#End Region

#End Region

#End Region

#Region "gcScaleLimits"

#Region "CbSetLimitsCheckedChanged"

        ''' <summary>
        ''' Handles Min/MaxLimit changes for gcScaleLimits
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbSetLimitsCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbSetLimits.CheckedChanged
            Dim scale As GaugeCircularScale = gcScaleLimits.CircularScales("Scale1")

            If scale IsNot Nothing Then
                If cbSetLimits.Checked = True Then
                    ' Stop updates from happening so we get everything
                    ' updated in one draw cycle

                    gcScaleLimits.BeginUpdate()

                    ' The range of values on the screen is still 50.  But we are
                    ' now going to set a new set of limits, so that the control can
                    ' scroll from -150 to 100, displaying 50 units on the screen
                    ' at a time.

                    scale.MinLimit = -150
                    scale.MaxLimit = 100

                    ' All done, so let the control update its display

                    gcScaleLimits.EndUpdate()

                    ' We could have set this value inside the above
                    ' begin/end update, but by doing it outside we get to
                    ' see the control scroll (should help the user see what's
                    ' going on better)

                    scale.Pointers(0).Value = -30
                Else
                    ' Stop updates from happening so we get everything
                    ' updated in one draw cycle

                    gcScaleLimits.BeginUpdate()

                    ' Tell the system there are no limits.

                    scale.MinLimit = Double.NaN
                    scale.MaxLimit = Double.NaN

                    ' Reset our display value range back to what it was
                    ' originally (it may have changed if the user scrolled the control)

                    scale.MinValue = 0
                    scale.MaxValue = 50

                    ' All done, so let the control update its display, and then
                    ' set our pointer back to its original position

                    gcScaleLimits.EndUpdate()

                    scale.Pointers(0).Value = 30
                End If
            End If
        End Sub

#End Region

#Region "Button processing"

#Region "BtnPlus20Click"

        ''' <summary>
        ''' Handles adding 20 to the gcScaleLimits pointer value
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BtnPlus20Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPlus20.Click
            Dim pointer As GaugePointer = GetCircularPointer(gcScaleLimits, "Scale1", "Needle")

            If pointer IsNot Nothing Then
                pointer.Value += 20
            End If
        End Sub

#End Region

#Region "BtnMinus10Click"

        ''' <summary>
        ''' Handles subtracting 10 from gcScaleLimits pointer value
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BtnMinus10Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMinus10.Click
            Dim pointer As GaugePointer = GetCircularPointer(gcScaleLimits, "Scale1", "Needle")

            If pointer IsNot Nothing Then
                pointer.Value -= 10
            End If
        End Sub

#End Region

#Region "BtnMin2Click"

        ''' <summary>
        ''' Handles setting gcScaleLimits pointer to the min value
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BtnMin2Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMin2.Click
            Dim pointer As GaugePointer = GetCircularPointer(gcScaleLimits, "Scale1", "Needle")

            If pointer IsNot Nothing Then
                pointer.Value = pointer.Scale.MinValue
            End If
        End Sub

#End Region

#Region "BtnMax2Click"

        ''' <summary>
        ''' Handles setting gcScaleLimits pointer value to the max
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BtnMax2Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMax2.Click
            Dim pointer As GaugePointer = GetCircularPointer(gcScaleLimits, "Scale1", "Needle")

            If pointer IsNot Nothing Then
                pointer.Value = pointer.Scale.MaxValue
            End If
        End Sub

#End Region

#Region "BtnAuto2Click"

        ''' <summary>
        ''' Handles the starting and stopping of automatic
        ''' gcScaleLimits pointer value changes
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub BtnAuto2Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAuto2.Click
            ' If we need to enable the process, then allocate
            ' and initialize our Timer to handle the udates

            If _Timer2 Is Nothing Then
                _Timer2 = New Timer()
                AddHandler _Timer2.Tick, AddressOf RandomTimer_Tick2

                _Timer2.Interval = 250
                _Timer2.Start()

                btnAuto2.Text = "Stop"
            Else
                _Timer2.Stop()
                RemoveHandler _Timer2.Tick, AddressOf RandomTimer_Tick2
                _Timer2.Dispose()
                _Timer2 = Nothing

                btnAuto2.Text = "Auto"
            End If
        End Sub

#End Region

#Region "RandomTimer_Tick2"

        ''' <summary>
        ''' Handles timer ticks, used to update the associated
        ''' scale's pointers with new, random, pointer values
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub RandomTimer_Tick2(ByVal sender As Object, ByVal e As EventArgs)
            Dim pointer As GaugePointer = GetCircularPointer(gcScaleLimits, "Scale1", "Needle")

            If pointer IsNot Nothing Then
                ' Get a new random value for the pointer

                Dim value As Double = pointer.Value + _Rand.Next(-10, 10)

                ' Make sure we keep it in the scale range

                Dim n As Double = CDbl(IIf(pointer.Scale.MinLimit.Equals(Double.NaN), pointer.Scale.MinValue, pointer.Scale.MinLimit))

                If value < n Then
                    value = n
                Else
                    n = CDbl(IIf(pointer.Scale.MaxLimit.Equals(Double.NaN), pointer.Scale.MaxValue, pointer.Scale.MaxLimit))

                    If value > n Then
                        value = n
                    End If
                End If

                pointer.Value = value
            End If
        End Sub

#End Region

#End Region

#Region "CbSliderDampen2ValueChanged"

        ''' <summary>
        ''' Handles setting gcScaleLimits pointer dampening value 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub CbSliderDampen2ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbSliderDampen2.ValueChanged
            Dim pointer As GaugePointer = GetCircularPointer(gcScaleLimits, "Scale1", "Needle")

            If pointer IsNot Nothing Then
                pointer.DampeningSweepTime = cbSliderDampen2.Value
            End If

            cbSliderDampen2.Text = cbSliderDampen2.Value.ToString()
        End Sub

#End Region

#End Region

#End Region

#Region "gcMixedScale"

#Region "GcMixedScalePointerChanged"

        ''' <summary>
        ''' Handles Pointer changes for the gcMixedScale control
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GcMixedScalePointerChanged(ByVal sender As Object, ByVal e As PointerChangedEventArgs) Handles gcMixedScale.PointerChanged
            If e.Pointer.Name.Equals("MainMarker") = True Then
                Dim o As Integer = Math.Min(CInt(Fix(e.OldValue / 10)), 2)
                Dim n As Integer = Math.Min(CInt(Fix(e.NewValue / 10)), 2)

                Dim oScale As GaugeCircularScale = gcMixedScale.CircularScales(o)
                Dim nScale As GaugeCircularScale = gcMixedScale.CircularScales(n)

                If oScale IsNot Nothing AndAlso nScale IsNot Nothing Then
                    gcMixedScale.BeginUpdate()

                    ' If we need to change scales, then hide the
                    ' old marker and show the new one

                    If o <> n Then
                        oScale.Pointers(0).Visible = False
                        nScale.Pointers(0).Visible = True
                    End If

                    nScale.Pointers(0).Value = e.Pointer.Value

                    ' Just for grins, move the red marker
                    ' the opposite direction from the moved marker

                    Dim xScale As GaugeLinearScale = gcMixedScale.LinearScales("Scale2")

                    If xScale IsNot Nothing Then
                        xScale.Pointers(0).Value = 30 - e.NewValue

                        ' Move the vertical scale marker to show the
                        ' change in height of the yellow star marker

                        Dim yScale As GaugeLinearScale = gcMixedScale.LinearScales("Scale3")

                        If yScale IsNot Nothing Then
                            ' Simply use the IntervalPoint for the star marker

                            Dim pt As Point = nScale.Pointers(0).IntervalPoint
                            Dim dy As Double = (xScale.Bounds.Y + xScale.Bounds.Height \ 2) - pt.Y

                            ' The IntervalPoint is to the top left of the marker, so
                            ' simply adjust the offset by 1/2 the height of the marker

                            Dim h As Double = (nScale.Pointers(0).Length * nScale.Bounds.Height \ 2) / 2
                            dy += (CDbl(IIf(dy > 0, -h, h))) / 2

                            yScale.Pointers(0).Value = ((yScale.MaxValue - yScale.MinValue) * dy) / yScale.Bounds.Height
                        End If
                    End If

                    gcMixedScale.EndUpdate()
                End If
            End If
        End Sub

#End Region

#End Region

#Region "GetCircularPointer"

        ''' <summary>
        ''' Locates the given scale and pointer from the
        ''' the given gauge's CircularScales list
        ''' </summary>
        ''' <param name="gauge">Gauge</param>
        ''' <param name="sname">Scale name</param>
        ''' <param name="pname">Pointer name</param>
        ''' <returns>Located Pointer, or null</returns>
        Private Function GetCircularPointer(ByVal gauge As GaugeControl, ByVal sname As String, ByVal pname As String) As GaugePointer
            Dim scale As GaugeScale = gauge.CircularScales(sname)

            If scale IsNot Nothing Then
                Return scale.Pointers(pname)
            End If
            Return Nothing
        End Function

#End Region

#Region "GetLinearPointer"

        ''' <summary>
        ''' Locates the given scale and pointer from the
        ''' the given gauge's LinearScales list
        ''' </summary>
        ''' <param name="gauge">Gauge</param>
        ''' <param name="sname">Scale name</param>
        ''' <param name="pname">Pointer name</param>
        ''' <returns>Located Pointer, or null</returns>
        Private Function GetLinearPointer(ByVal gauge As GaugeControl, ByVal sname As String, ByVal pname As String) As GaugePointer
            Dim scale As GaugeScale = gauge.LinearScales(sname)

            If scale IsNot Nothing Then
                Return scale.Pointers(pname)
            End If
            Return Nothing
        End Function

#End Region

#Region "GaugeControlGetDisplayTemplateText"

        ''' <summary>
        ''' Handles the GetDisplayTemplateText event for
        ''' the associated gauge
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub GaugeControlGetDisplayTemplateText(ByVal sender As Object, ByVal e As GetDisplayTemplateTextEventArgs) Handles gcLinear5.GetDisplayTemplateText, gcLinear6.GetDisplayTemplateText, gcLinear2.GetDisplayTemplateText
            Dim pointer As GaugePointer = TryCast(e.GaugeItem, GaugePointer)

            If pointer IsNot Nothing Then
                ' If the GaugeItem is a Pointer, then we have 2 simple user
                ' defined templates that we have defined

                Select Case e.DisplayTemplate
                    Case "CtoF" ' Celsius to Fahrenheit conversion

                        Dim n As Double = pointer.Value * 9 \ 5 + 32

                        e.DisplayText = CStr(IIf(String.IsNullOrEmpty(e.DisplayFormat) = False, String.Format("{0:" & e.DisplayFormat & "}", n), (Math.Round(n, 2)).ToString()))

                    Case "OutOf" ' "n out of 100"

                        e.DisplayText = (CInt(Fix(pointer.Value * 100))).ToString() & " out of 100"
                End Select
            Else
                Dim strip As GaugeStrip = TryCast(e.GaugeItem, GaugeStrip)

                If strip IsNot Nothing Then
                    ' If the GaugeItem is a Range or a Section, then we have 2 simple user
                    ' defined templates that we have defined

                    Select Case e.DisplayTemplate
                        Case "MyStartValue" ' StartValue
                            e.DisplayText = (CInt(Fix(strip.StartValue * 100))).ToString()

                        Case "MyEndValue" ' EndValue
                            e.DisplayText = (CInt(Fix(strip.EndValue * 100))).ToString()
                    End Select
                End If
            End If
        End Sub

#End Region

        Private Sub linkLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles linkLabel1.Click
            System.Diagnostics.Process.Start("http://www.devcomponents.com/kb2/?p=989")
        End Sub

    End Class
End Namespace