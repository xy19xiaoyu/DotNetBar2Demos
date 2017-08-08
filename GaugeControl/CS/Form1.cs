using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevComponents.Instrumentation;

namespace GaugeControl_Sample
{
    public partial class Form1 : Form
    {
        #region Private variables

        private Timer _Timer1;
        private Timer _Timer2;

        private Random _Rand;

        private GaugeItem _LastItem;

        private int _RenderPointerEventCount;
        private int _GetPointerPathEventCount;

        private Color[] _Colors = { Color.ForestGreen, Color.Lime, Color.Yellow, Color.Orange, Color.Red };
        private float[] _Positions = { 0f, .25f, .3f, .6f, 1f };

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            _Rand = new Random();

            sliderDampen1.Value = 15;
            colorPickerButton1.SelectedColor = Color.Red;
            cbFillMode.SelectedIndex = 0;
        }

        #region Indicator Elements

        /// <summary>
        /// Handles PreRenderIndicatorDigit events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GaugeControl2PreRenderIndicatorDigit(
            object sender, PreRenderIndicatorDigitEventArgs e)
        {
            // Just for element identification purposes, turn on
            // the Colon on digit 2 so the user can see it better.

            if (e.Indicator.Name.Equals("Digital71") == true)
            {
                if (e.Index == 2)
                    e.Digit.ColonPointsOn = true;
            }
        }

        #endregion

        #region Circular samples

        #region gcCircular1

        #region CbShowTooltipsCheckedChanged

        /// <summary>
        /// Handles ShowTooltips checkbox events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbShowTooltipsCheckedChanged(object sender, EventArgs e)
        {
            // Enabling of tooltips is handled at the
            // gauge level, so set it accordingly

            gcCircular1.ShowToolTips = cbShowTooltips.Checked;
        }

        #endregion

        #region SliderScaleAngleValueChanged

        /// <summary>
        /// Handles gcCircular1 StartAngle changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SliderScaleAngleValueChanged(object sender, EventArgs e)
        {
            gcCircular1.CircularScales["Scale1"].StartAngle = sliderScaleAngle.Value;
        }

        #endregion

        #region GcCircular1PointerChanged

        /// <summary>
        /// Handles gCircular1 PointerChanged events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GcCircular1PointerChanged(object sender, PointerChangedEventArgs e)
        {
            NumericIndicator ind =
                gcCircular1.GaugeItems["NumericIndicator1"] as NumericIndicator;

            if (ind != null)
                ind.Value = e.NewValue;
        }

        #endregion

        #endregion

        #region gcCircular2

        #region CbCAddGlassEffectCheckedChanged

        /// <summary>
        /// Handles AddGlassEffect checkbox change events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbCAddGlassEffectCheckedChanged(object sender, EventArgs e)
        {
            gcCircular2.Frame.AddGlassEffect = cbCAddGlassEffect.Checked;
        }

        #endregion

        #region CbCReverse1Click

        /// <summary>
        /// Handles Reverse1 checkbox change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbCReverse1Click(object sender, EventArgs e)
        {
            // Locate the scale to reverse in our the gauges
            // CircularScales list, and reverse it

            GaugeScale scale = gcCircular2.CircularScales["Scale1"];

            if (scale != null)
                scale.Reversed = cbReverse1.Checked;
        }

        #endregion

        #region CbCReverse2Click

        /// <summary>
        /// Handles Reverse1 checkbox change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbCReverse2Click(object sender, EventArgs e)
        {
            // Locate the scale to reverse in our the gauges
            // CircularScales list, and reverse it

            GaugeScale scale = gcCircular2.CircularScales["Scale2"];

            if (scale != null)
                scale.Reversed = cbReverse2.Checked;
        }

        #endregion

        #region GcCircular2PointerChanged

        /// <summary>
        /// Handles gcCircular2 PointerChanged events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GcCircular2PointerChanged(object sender, PointerChangedEventArgs e)
        {
            StateIndicator ind =
                gcCircular2.GaugeItems["StateIndicator1"] as StateIndicator;

            if (ind != null)
                ind.Value = e.NewValue;
        }

        #endregion

        #endregion

        #region gcCircular4

        #region CbCAutoOrientLabelsCheckedChanged

        /// <summary>
        /// Handles AutoOrientLabels checkbox events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbCAutoOrientLabelsCheckedChanged(object sender, EventArgs e)
        {
            // Locate the associated scale in the gauges
            // CircularScales list, and set the AutoOrientLabel accordingly

            GaugeScale scale = gcCircular4.CircularScales["Large Scale"];

            if (scale != null)
                scale.Labels.Layout.AutoOrientLabel = cbCAutoOrientLabels.Checked;
        }

        #endregion

        #region CbCRotateLabelsCheckedChanged

        /// <summary>
        /// Handles RotateLabels checkbox events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbCRotateLabelsCheckedChanged(object sender, EventArgs e)
        {
            // Locate the associated scale from the gauges
            // CircularScales list, and set accordingly

            GaugeCircularScale scale = gcCircular4.CircularScales["Large Scale"];

            if (scale != null)
            {
                scale.Labels.Layout.RotateLabel = cbCRotateLabels.Checked;

                // AutoOrientLabels is not used when
                // the labels are not permitted to rotate

                cbCAutoOrientLabels.Enabled = cbCRotateLabels.Checked;
            }
        }

        #endregion

        #region SliderCAngleValueChanged

        /// <summary>
        /// Handles Angle slider value changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SliderCAngleValueChanged(object sender, EventArgs e)
        {
            // Locate the associated scale from the gauges
            // CircularScales list, and set accordingly.

            GaugeCircularScale scale = gcCircular4.CircularScales["Large Scale"];

            if (scale != null)
                scale.Labels.Layout.Angle = sliderCAngle.Value;
        }

        #endregion

        #region GcCircular4PointerChanged

        /// <summary>
        /// Handles PointerChanged events for the gauge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GcCircular4PointerChanged(object sender, PointerChangedEventArgs e)
        {
            // Keep the alternate scale pointer insync (opposite value, for grins) with
            // the pointer that was just changed.

            // A couple notes about the SetPointerValue routine:
            //
            // 1 - This routine looks for the provided pointer Name first from any
            // defined CircularScales, then any defined LinearScales. Since pointer Names
            // are not constrained to be unique across scales, if you use this call you
            // should make sure you choose a unique name for the pointer in question.
            //
            // 2 - The last parameter to the call tells the system whether the visual
            // update should be dampened.  Since we are interactively adjusting one of
            // the pointers, we want the feedback of the second pointer to match, therefore
            // we want no dampening - ie. immediate feedback.

            gcCircular4.SetPointerValue(
                e.Pointer.Name.Equals("LargeNeedle") ? "SmallNeedle" : "LargeNeedle",
                100 - e.Pointer.Value, false);
        }

        #endregion

        #endregion

        #region gcCircular5

        #region RbNoneCheckedChanged

        /// <summary>
        /// Handles RbNoneChecked changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbNoneCheckedChanged(object sender, EventArgs e)
        {
            if (rbNone.Checked == true)
            {
                gcCircular5.Frame.Style = GaugeFrameStyle.None;

                sliderArc.Enabled = false;
            }
        }

        #endregion

        #region RbCircularCheckedChanged

        /// <summary>
        /// Handles RbCircularChecked changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbCircularCheckedChanged(object sender, EventArgs e)
        {
            if (rbCircular.Checked == true)
            {
                gcCircular5.Frame.Style = GaugeFrameStyle.Circular;

                sliderArc.Enabled = false;
            }
        }

        #endregion

        #region RbRectCheckedChanged

        /// <summary>
        /// Handles RbRectChecked changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbRectCheckedChanged(object sender, EventArgs e)
        {
            if (rbRect.Checked == true)
            {
                gcCircular5.Frame.Style = GaugeFrameStyle.Rectangular;

                sliderArc.Enabled = false;
            }
        }

        #endregion

        #region RbRoundRectCheckedChanged

        /// <summary>
        /// Handles RbRoundRectChecked changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbRoundRectCheckedChanged(object sender, EventArgs e)
        {
            if (rbRoundRect.Checked == true)
            {
                gcCircular5.Frame.Style = GaugeFrameStyle.RoundedRectangular;

                sliderArc.Enabled = true;
            }
        }

        #endregion

        #region SliderArcValueChanged

        /// <summary>
        /// Handles SliderArc value changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SliderArcValueChanged(object sender, EventArgs e)
        {
            gcCircular5.Frame.RoundRectangleArc = (float)sliderArc.Value / 100;
        }

        #endregion

        #endregion

        #region gcCircular6

        #region CbRotateCapCheckedChanged

        /// <summary>
        /// Handles RotateCap checkbox events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbRotateCapCheckedChanged(object sender, EventArgs e)
        {
            // Locate the associated Pointer and set
            // the RotateCapImage property accordingly

            GaugePointer pointer = GetCircularPointer(gcCircular6, "Scale1", "Needle");

            if (pointer != null)
                pointer.RotateCap = cbRotateCap.Checked;
        }

        #endregion

        #region SliderMaxPinValueChanged

        /// <summary>
        /// Handles MaxPin Slider changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SliderMaxPinValueChanged(object sender, EventArgs e)
        {
            gcCircular6.CircularScales["Scale1"].MaxPin.EndOffset =
                (float)sliderMaxPin.Value / 1000;
        }

        #endregion

        #region CbHonorMinPinCheckedChanged

        /// <summary>
        /// Handles HonorMinPin changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbHonorMinPinCheckedChanged(object sender, EventArgs e)
        {
            GaugeScale scale = gcCircular6.CircularScales["Scale1"];

            if (scale != null)
            {
                foreach (GaugePointer pointer in scale.Pointers)
                    pointer.HonorMinPin = cbHonorMinPin.Checked;
            }
        }

        #endregion

        #region CbHonorMaxPinCheckedChanged

        /// <summary>
        /// Handles HonorMaxPin changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbHonorMaxPinCheckedChanged(object sender, EventArgs e)
        {
            GaugeScale scale = gcCircular6.CircularScales["Scale1"];

            if (scale != null)
            {
                foreach (GaugePointer pointer in scale.Pointers)
                    pointer.HonorMaxPin = cbHonorMaxPin.Checked;
            }
        }

        #endregion

        #endregion

        #endregion

        #region Linear samples

        #region gcLinear4

        #region CbOrderBarsCheckedChanged

        /// <summary>
        /// Handles OrderBars checkbox events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbOrderBarsCheckedChanged(object sender, EventArgs e)
        {
            // Locate the associated scale from the gauge's
            // LinearScales list

            GaugeLinearScale scale = gcLinear4.LinearScales["Scale1"];

            if (scale != null)
            {
                // Set the UnderTickMarks property accordingly for Bar1 and Bar3

                scale.Pointers["Bar1"].UnderTickMarks = cbUnderTickmarks.Checked;
                scale.Pointers["Bar3"].UnderTickMarks = cbUnderTickmarks.Checked;
            }
        }

        #endregion

        #endregion

        #region gcLinear5

        #region RbBulbCheckedChanged

        /// <summary>
        /// Handles Bulb RadioButton events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbBulbCheckedChanged(object sender, EventArgs e)
        {
            if (rbBulb.Checked == true)
            {
                // Locate and set the associated BulbStyle

                GaugePointer pointer = GetLinearPointer(gcLinear5, "Scale1", "Thermo");

                if (pointer != null)
                    pointer.BulbStyle = BulbStyle.Bulb;
            }
        }

        #endregion

        #region RbFlaskCheckedChanged

        /// <summary>
        /// Handles Flask RadioButton events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbFlaskCheckedChanged(object sender, EventArgs e)
        {
            if (rbFlask.Checked == true)
            {
                // Locate and set the associated BulbStyle

                GaugePointer pointer = GetLinearPointer(gcLinear5, "Scale1", "Thermo");

                if (pointer != null)
                    pointer.BulbStyle = BulbStyle.Flask;
            }
        }

        #endregion

        #region CbSetSnapCheckedChanged

        /// <summary>
        /// Handles SetSnap checkbox events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbSetSnapCheckedChanged(object sender, EventArgs e)
        {
            // Locate and set the associated BulbStyle

            GaugePointer pointer = GetLinearPointer(gcLinear5, "Scale1", "Thermo");

            if (pointer != null)
                pointer.SnapInterval = cbSetSnap.Checked ? 2 : 0;
        }

        #endregion

        #endregion

        #region gcLinear6

        #region ColorPickerButton1SelectedColorChanged

        /// <summary>
        /// Handles ColorPicker FillColor.Color1 change events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorPickerButton1SelectedColorChanged(object sender, EventArgs e)
        {
            // Locate the associated scale
            // Pointer, and set its FillColor.Color1 accordingly

            GaugePointer pointer = GetLinearPointer(gcLinear6, "Scale1", "Thermo");

            if (pointer != null)
                pointer.FillColor.Color1 = colorPickerButton1.SelectedColor;
        }

        #endregion

        #region ColorPickerButton2SelectedColorChanged

        /// <summary>
        /// Handles ColorPicker FillColor.Color2 change events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorPickerButton2SelectedColorChanged(object sender, EventArgs e)
        {
            // Locate the associated scale
            // Pointer, and set its FillColor.Color2 accordingly

            GaugePointer pointer = GetLinearPointer(gcLinear6, "Scale1", "Thermo");

            if (pointer != null)
                pointer.FillColor.Color2 = colorPickerButton2.SelectedColor;
        }

        #endregion

        #region CbFillModeSelectedIndexChanged

        /// <summary>
        /// Handles FillMode combobox changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbFillModeSelectedIndexChanged(object sender, EventArgs e)
        {
            // Locate the associated scale
            // Pointer, and set its FillColor.Color2 accordingly

            GaugePointer pointer = GetLinearPointer(gcLinear6, "Scale1", "Thermo");

            if (pointer != null)
                pointer.FillColor.GradientFillType = (GradientFillType) cbFillMode.SelectedIndex;

            cbSliderAngle.Enabled = (cbFillMode.SelectedIndex == 1);
        }

        #endregion

        #region CbSliderAngleValueChanged

        /// <summary>
        /// Handles SliderAngle checkbox changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbSliderAngleValueChanged(object sender, EventArgs e)
        {
            // Locate the associated scale
            // Pointer, and set its FillColor.GradientAngle accordingly

            GaugePointer pointer = GetLinearPointer(gcLinear6, "Scale1", "Thermo");

            if (pointer != null)
                pointer.FillColor.GradientAngle = cbSliderAngle.Value;

            cbSliderAngle.Text = @"Angle (" + cbSliderAngle.Value.ToString() + @")";
        }

        #endregion

        #endregion

        #region gcLinear7

        #region GcLinear7PointerChanged

        /// <summary>
        /// Handles keeping the gcLinear7 bar value in sync
        /// with the marker value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GcLinear7PointerChanged(object sender, PointerChangedEventArgs e)
        {
            GaugeLinearScale scale = gcLinear7.LinearScales["Scale1"];

            if (scale != null)
            {
                GaugePointer bar = scale.Pointers["Bar"];
                GaugePointer marker = scale.Pointers["Marker"];

                if (bar != null && marker != null)
                    bar.Value = marker.Value;
            }
        }

        #endregion

        #endregion

        #region gcLinear8

        #region gcLinear8PreRenderScalePointer

        /// <summary>
        /// Handles PreRenderScalePointer events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GcLinear8PreRenderScalePointer(object sender, PreRenderScalePointerEventArgs e)
        {
            // There are only bar pointers defined in this gauge, so we are
            // just going to fill every pointer with a LinearGradient going
            // from ForestGreen to Lime to Yellow to Orange to Red.

            GraphicsPath path = e.Pointer.GetPointerPath();

            if (path != null)
            {
                Rectangle r = e.Pointer.Scale.Bounds;

                using (LinearGradientBrush br =
                    new LinearGradientBrush(r, Color.White, Color.White, -90))
                {
                    ColorBlend cb = new ColorBlend(_Colors.Length);
                    cb.Colors = _Colors;
                    cb.Positions = _Positions;

                    br.InterpolationColors = cb;

                    e.Graphics.FillPath(br, path);
                }

                // Tell the system to cancel its rendering, since
                // we just rendered the contents of the pointer

                e.Cancel = true;
            }
        }

        #endregion

        #endregion

        #endregion

        #region Event samples

        #region gcPointerChange

        #region GcPointerChangePointerChanged

        /// <summary>
        /// Handles the gauge's PointerChanged events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GcPointerChangePointerChanged(object sender, PointerChangedEventArgs e)
        {
            // Locate the "Planned" GaugeItem, and update its text
            // to reflect the pointer change

            GaugeText item = gcPointerChange.GaugeItems["Planned"] as GaugeText;

            if (item != null)
                item.Text = String.Format("(Planned {0:C0})", e.Pointer.Value * 1000);

            e.Pointer.FillColor.Color1 = (e.Pointer.Value >= 65) ? Color.Lime : Color.Yellow;
        }

        #endregion

        #region GcPointerChangePointerChanging

        /// <summary>
        /// Handles the gauge's PointerChanging event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GcPointerChangePointerChanging(object sender, PointerChangingEventArgs e)
        {
            // Constrain the pointer to not fall below the 30 mark

            if (e.NewValue < 30)
                e.NewValue = 30;
        }

        #endregion

        #endregion

        #region gcEnterLeave

        #region Scale event processing

        #region GcEnterLeaveScaleEnter

        /// <summary>
        /// Handles the gauge's ScaleEnter events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GcEnterLeaveScaleEnter(object sender, ScaleEnterEventArgs e)
        {
            // Display the event, if the user wants to see them

            if (cbShowScaleEvents.Checked == true)
            {
                rtb1.SelectionColor = Color.Red;
                rtb1.AppendText(e.Pointer.Name + " Entered Scale '" + e.Scale.Name + "'\n");
                rtb1.ScrollToCaret();
            }
        }

        #endregion

        #region GcEnterLeaveScaleLeave

        /// <summary>
        /// Handles the gauge's ScaleLeave events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GcEnterLeaveScaleLeave(object sender, ScaleLeaveEventArgs e)
        {
            // Display the event, if the user wants to see them

            if (cbShowScaleEvents.Checked == true)
            {
                rtb1.SelectionColor = Color.DarkRed;
                rtb1.AppendText(e.Pointer.Name + " Left Scale '" + e.Scale.Name + "'\n");
            }
        }

        #endregion

        #endregion

        #region Range event processing

        #region GcEnterLeaveRangeEnter

        /// <summary>
        /// Handles the gauge's RangeEnter events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GcEnterLeaveRangeEnter(object sender, RangeEnterEventArgs e)
        {
            // Display the event, if the user wants to see them

            if (cbShowRangeEvents.Checked == true)
            {
                rtb1.SelectionColor = Color.Green;
                rtb1.AppendText(e.Pointer.Name + " Entered '" + e.Range.Name + "'\n");
            }
        }

        #endregion

        #region GcEnterLeaveRangeLeave

        /// <summary>
        /// Handles the gauge's RangeLeave events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GcEnterLeaveRangeLeave(object sender, RangeLeaveEventArgs e)
        {
            // Display the event, if the user wants to see them

            if (cbShowRangeEvents.Checked == true)
            {
                rtb1.SelectionColor = Color.DarkGreen;
                rtb1.AppendText(e.Pointer.Name + " Left '" + e.Range.Name + "'\n");
            }
        }

        #endregion

        #endregion

        #region Section event processing

        #region GcEnterLeaveSectionEnter

        /// <summary>
        /// Handles the gauge's SectionEnter events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GcEnterLeaveSectionEnter(object sender, SectionEnterEventArgs e)
        {
            // Display the event, if the user wants to see them

            if (cbShowSectionEvents.Checked == true)
            {
                rtb1.SelectionColor = Color.Blue;
                rtb1.AppendText(e.Pointer.Name + " Entered '" + e.Section.Name + "'\n");
            }
        }

        #endregion

        #region GcEnterLeaveSectionLeave

        /// <summary>
        /// Handles the gauge's SectionLeave events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GcEnterLeaveSectionLeave(object sender, SectionLeaveEventArgs e)
        {
            // Display the event, if the user wants to see them

            if (cbShowSectionEvents.Checked == true)
            {
                rtb1.SelectionColor = Color.DarkBlue;
                rtb1.AppendText(e.Pointer.Name + " Left '" + e.Section.Name + "'\n");
            }
        }

        #endregion

        #endregion

        #region Button click processing

        #region BtnClearClick

        /// <summary>
        /// Clears the rtb contents
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClearClick(object sender, EventArgs e)
        {
            rtb1.Clear();
        }

        #endregion

        #region BtnPlus30Click

        /// <summary>
        /// Handles BtnPlus30 click events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlus30Click(object sender, EventArgs e)
        {
            // Locate the associated scale, and add 30 to
            // every Pointer defined for it

            GaugeScale scale = gcEnterLeave.CircularScales["Scale1"];

            if (scale != null)
            {
                for (int i = 0; i < scale.Pointers.Count; i++)
                    scale.Pointers[i].Value += 30;
            }
        }

        #endregion

        #region BtnMinus20Click

        /// <summary>
        /// Handles BtnMinus20 click events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMinus20Click(object sender, EventArgs e)
        {
            // Locate the associated scale, and subtract 20 from
            // every Pointer defined for it

            GaugeScale scale = gcEnterLeave.CircularScales["Scale1"];

            if (scale != null)
            {
                for (int i = 0; i < scale.Pointers.Count; i++)
                    scale.Pointers[i].Value -= 20;
            }
        }

        #endregion

        #region BtnMinClick

        /// <summary>
        /// Handles BtnMin click events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMinClick(object sender, EventArgs e)
        {
            // Locate the associated scale, and set the Value
            // of every defined Pointer to the scale's minimum

            GaugeScale scale = gcEnterLeave.CircularScales["Scale1"];

            if (scale != null)
            {
                for (int i = 0; i < scale.Pointers.Count; i++)
                    scale.Pointers[i].Value = scale.MinValue;
            }
        }

        #endregion

        #region BtnMaxClick

        /// <summary>
        /// Handles BtnMax click events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMaxClick(object sender, EventArgs e)
        {
            // Locate the associated scale, and set the Value
            // of every defined Pointer to the scale's maximum

            GaugeScale scale = gcEnterLeave.CircularScales["Scale1"];

            if (scale != null)
            {
                for (int i = 0; i < scale.Pointers.Count; i++)
                    scale.Pointers[i].Value = scale.MaxValue;
            }
        }

        #endregion

        #region BtnAutoClick

        /// <summary>
        /// Handles BtnAuto click events.
        /// 
        /// This routine either enables or disables the automatic update
        /// of the associated scale's pointers to randomly changing values.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAutoClick(object sender, EventArgs e)
        {
            // If we need to enable the process, then allocate
            // and initialize our Timer to handle the udates

            if (_Timer1 == null)
            {
                _Timer1 = new Timer();
                _Timer1.Tick += RandomTimer_Tick1;

                _Timer1.Interval = 250;
                _Timer1.Start();

                btnAuto.Text = @"Stop";
            }
            else
            {
                _Timer1.Stop();
                _Timer1.Tick -= RandomTimer_Tick1;
                _Timer1.Dispose();
                _Timer1 = null;

                btnAuto.Text = @"Auto";
            }
        }

        #endregion

        #endregion

        #region SliderDampenValueChanged

        /// <summary>
        /// Handles SliderDampen change events
        /// 
        /// A Pointer's DampeningSweepTime determines how long it takes
        /// (in seconds) for the pointer to "sweep" across the entire range
        /// of the scale.  The dampening effect helps give the gauge a more
        /// realistic operation for the simulated material being monitored
        /// by the gauge (air, water, oil, tar, etc).
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SliderDampenValueChanged(object sender, EventArgs e)
        {
            // Locate the scale for the associated gauge, and set
            // every defined Pointer's DampeningSweepTime to the set value.

            GaugeScale scale = gcEnterLeave.CircularScales["Scale1"];

            if (scale != null)
            {
                for (int i = 0; i < scale.Pointers.Count; i++)
                    scale.Pointers[i].DampeningSweepTime = sliderDampen1.Value;
            }

            sliderDampen1.Text = sliderDampen1.Value.ToString();
        }

        #endregion

        #region RandomTimer_Tick1

        /// <summary>
        /// Handles timer ticks, used to update the associated
        /// scale's pointers with new, random, pointer values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void RandomTimer_Tick1(object sender, EventArgs e)
        {
            GaugeScale scale = gcEnterLeave.CircularScales["Scale1"];

            if (scale != null)
            {
                for (int i = 0; i < scale.Pointers.Count; i++)
                {
                    // Get a new random value for the pointer

                    double n = _Rand.Next(-1000, 1000);

                    double value = scale.Pointers[i].Value + n / 100;

                    // Make sure we keep it in the scale range

                    if (value < scale.MinValue)
                        value = scale.MinValue;

                    else if (value > scale.MaxValue)
                        value = scale.MaxValue;

                    scale.Pointers[i].Value = value;
                }
            }
        }

        #endregion

        #region GcEnterLeavePointerValueChanged

        /// <summary>
        /// Handles gcEnterLeave PointerValueChanged events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GcEnterLeavePointerValueChanged(object sender, PointerChangedEventArgs e)
        {
            if (e.Pointer.Name.Equals("DarkRed Needle") == true)
            {
                NumericIndicator ni =
                    gcEnterLeave.GaugeItems["NumericIndicator1"] as NumericIndicator;

                if (ni != null)
                    ni.Value = e.NewValue;
            }
            else if (e.Pointer.Name.Equals("Yellow Marker") == true)
            {
                StateIndicator si =
                    gcEnterLeave.GaugeItems["StateIndicator1"] as StateIndicator;

                if (si != null)
                    si.Value = e.NewValue;
            }
        }

        #endregion

        #endregion

        #region gcHitTesting

        #region GcHitTestingMouseMove

        /// <summary>
        /// Handles MouseMove events for the associated gauge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GcHitTestingMouseMove(object sender, MouseEventArgs e)
        {
            // Get the item located at the given point

            GaugeItem item = gcHitTesting.GetGaugeItemFromPoint(e.Location);

            if (item != _LastItem)
            {
                // There is an item at the given point, so inform the user
                // whether they are entering or leaving the item

                if (_LastItem != null)
                    rtb2.AppendText("Leave: " + _LastItem.Name + "\n");

                if (item != null)
                    rtb2.AppendText("Enter: " + item.Name + "\n");

                _LastItem = item;
            }
        }

        #endregion

        #region GcHitTestingMouseClick

        /// <summary>
        /// Handles MouseClick events for the associated gauge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GcHitTestingMouseClick(object sender, MouseEventArgs e)
        {
            // Get the item located at the given point

            GaugeItem item = gcHitTesting.GetGaugeItemFromPoint(e.Location);

            if (item != null)
            {
                // Just for grins, if they clicked on the HeadSet item, then
                // rotate the image by 30 degrees each time

                GaugeImage gi = item as GaugeImage;

                if (gi != null && gi.Name.Equals("HeadSet"))
                    gi.Angle += 30;
            }
        }

        #endregion

        #region BtnRtb2ClearClick

        /// <summary>
        /// Clear the associated RichTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRtb2ClearClick(object sender, EventArgs e)
        {
            rtb2.Clear();
        }

        #endregion

        #endregion

        #region gcUserRendering

        #region Render event processing

        #region GcUserRenderingPostRenderScalePointer

        /// <summary>
        /// Handles PostRenderScalePointer events for the associated gauge.
        /// 
        /// PostRender events occur after the system has already rendered
        /// the item (in this case, a scale pointer).  All we are going to
        /// do is to draw on top of what the system has drawn, so post rendering
        /// is what we want.  If we wanted to draw the item completely ourselves
        /// then we would use the associated PreRender event.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GcUserRenderingPostRenderScalePointer(
            object sender, PostRenderScalePointerEventArgs e)
        {
            GraphicsPath path = e.Pointer.GetPointerPath();

            if (path != null)
            {
                if (e.Pointer.Name.Equals("Bar"))
                    RenderBar(e, path);

                else if (e.Pointer.Name.Equals("Marker"))
                    RenderMarker(e, path);

                else if (e.Pointer.Name.Equals("Needle"))
                    RenderNeedle(e, path);
            }
        }

        #region RenderBar

        /// <summary>
        /// Handles the rendering of our bar pointers
        /// </summary>
        /// <param name="e"></param>
        /// <param name="path">Barr's GraphicsPath</param>
        private void RenderBar(PostRenderScalePointerEventArgs e, GraphicsPath path)
        {
            // If the user wants us to render this pointer, then do so
            // by just filling the area with a hatched brush (simple, yet effective)

            if (cbBar.Checked == true)
            {
                using (HatchBrush br = new HatchBrush(HatchStyle.OutlinedDiamond, Color.Transparent))
                    e.Graphics.FillPath(br, path);
            }
        }

        #endregion

        #region RenderMarker

        /// <summary>
        /// Handles the rendering of our bar pointers
        /// </summary>
        /// <param name="e"></param>
        /// <param name="path">Barr's GraphicsPath</param>
        private void RenderMarker(PostRenderScalePointerEventArgs e, GraphicsPath path)
        {
            // If the user wants us to render this pointer, then do so
            // by just filling the area with a hatched brush (simple, yet effective)

            if (cbMarker.Checked == true)
            {
                using (HatchBrush br = new HatchBrush(HatchStyle.SmallCheckerBoard, Color.Transparent))
                    e.Graphics.FillPath(br, path);
            }
        }

        #endregion

        #region RenderNeedle

        /// <summary>
        /// Handles the rendering of our Needle pointers
        /// </summary>
        /// <param name="e"></param>
        /// <param name="path">Needle's GraphicsPath</param>
        private void RenderNeedle(PostRenderScalePointerEventArgs e, GraphicsPath path)
        {
            // Check to see if the user wants us to render this pointer

            if (cbNeedle.Checked == true)
            {
                // Fill in the needle area with a simple hatched brush

                using (HatchBrush br = new HatchBrush(HatchStyle.Trellis, Color.Transparent))
                    e.Graphics.FillPath(br, path);

                Rectangle r = e.Pointer.CapBounds;

                r.Inflate(10, 10);

                if (r.IsEmpty == false)
                {
                    // Create our own unique cap, and draw it

                    int n = (int)(e.Pointer.Value / 10) + 3;

                    using (GraphicsPath p2 = GetStarPath(r, n))
                    {
                        Point pt = new Point(r.X + r.Width / 2, r.Y + r.Height / 2);

                        Matrix matrix = new Matrix();
                        matrix.RotateAt((e.Pointer.IntervalAngle + 90) % 360, pt);

                        p2.Transform(matrix);

                        e.Graphics.FillPath(Brushes.Cyan, p2);
                        e.Graphics.DrawPath(Pens.DimGray, p2);

                        using (StringFormat sf = new StringFormat())
                        {
                            sf.Alignment = StringAlignment.Center;
                            sf.LineAlignment = StringAlignment.Center;

                            e.Graphics.DrawString(((int)e.Pointer.Value).ToString(), Font, Brushes.Black, r, sf);
                        }
                    }
                }
            }
        }

        #endregion

        #region GetStarPath

        /// <summary>
        /// Creates a Star path
        /// </summary>
        /// <param name="r">Bounding rectangle</param>
        /// <param name="points">Number of points in the star</param>
        /// <returns></returns>
        private GraphicsPath GetStarPath(Rectangle r, int points)
        {
            GraphicsPath path = new GraphicsPath();

            PointF[] pts = new PointF[2 * points];

            double rx1 = r.Width / 2;
            double ry1 = r.Height / 2;

            if (rx1 < 2)
                rx1 = 2;

            if (ry1 < 2)
                ry1 = 2;

            double rx2 = rx1 / 2;
            double ry2 = ry1 / 2;

            double cx = r.X + rx1;
            double cy = r.Y + ry1;

            double theta = Math.PI / 180 * 90;
            double dtheta = Math.PI / points;

            for (int i = 0; i < 2 * points; i += 2)
            {
                pts[i] = new PointF(
                    (float)(cx + rx1 * Math.Cos(theta)),
                    (float)(cy + ry1 * Math.Sin(theta)));

                theta += dtheta;

                pts[i + 1] = new PointF(
                    (float)(cx + rx2 * Math.Cos(theta)),
                    (float)(cy + ry2 * Math.Sin(theta)));

                theta += dtheta;
            }

            path.AddPolygon(pts);

            path.CloseAllFigures();

            return (path);
        }

        #endregion

        #endregion

        #region GcUserRenderingPostRenderScaleRange

        private void GcUserRenderingPostRenderScaleRange(
            object sender, PostRenderScaleRangeEventArgs e)
        {
            GraphicsPath path = e.Range.GetRangePath();

            if (path != null)
            {
                using (HatchBrush br =
                    new HatchBrush(HatchStyle.LargeConfetti, Color.Transparent))
                {
                    e.Graphics.FillPath(br, path);
                }
            }
        }

        #endregion

        #region GcUserRenderingPostRenderScaleSection

        private void GcUserRenderingPostRenderScaleSection(
            object sender, PostRenderScaleSectionEventArgs e)
        {
            GraphicsPath path = e.Section.GetSectionPath();

            if (path != null)
            {
                using (HatchBrush br =
                    new HatchBrush(HatchStyle.SmallCheckerBoard, Color.Transparent))
                {
                    e.Graphics.FillPath(br, path);
                }
            }
        }

        #endregion

        #region GcUserRenderingPreRenderGaugeContent

        private void GcUserRenderingPreRenderGaugeContent(
            object sender, RenderGaugeContentEventArgs e)
        {
            using (LinearGradientBrush br =
                new LinearGradientBrush(e.Bounds, Color.White, Color.White, -90))
            {
                ColorBlend cb = new ColorBlend(_Colors.Length);
                cb.Colors = _Colors;
                cb.Positions = _Positions;

                br.InterpolationColors = cb;

                e.Graphics.FillRectangle(br, e.Bounds);
            }
        }

        #endregion

        #region gcUserRenderingPreRenderFrame

        /// <summary>
        /// Handles PreRenderFrame events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GcUserRenderingPreRenderFrame(object sender, PreRenderFrameEventArgs e)
        {
            Graphics g = e.Graphics;
            GaugeFrame frame = gcUserRendering.Frame;

            Rectangle r = e.Bounds;

            int n = Math.Min(r.Width, r.Height);

            int outer = (frame.OuterBevel < .5f) ?
                (int)(n * frame.OuterBevel) : n / 2;

            int inner = (frame.InnerBevel < .5f) ?
                (int)(n * frame.InnerBevel) : n / 2;

            // Get the frame path

            using (GraphicsPath path = GetFramePath(e, outer, inner))
            {
                // Just for grins, lets rotate the gauge frame to match the
                // current, default scale needle pointer

                GaugePointer pointer = GetCircularPointer(gcUserRendering, "Scale1", "Needle");

                if (pointer != null)
                {
                    Matrix matrix = new Matrix();

                    Point center = new Point(r.X + r.Width / 2, r.Y + r.Height / 2);

                    matrix.RotateAt(pointer.IntervalAngle, center);
                    path.Transform(matrix);
                }

                // Let's put a slight shadow on the frame

                Matrix myMatrix = new Matrix();
                myMatrix.Translate(2, 3);
                path.Transform(myMatrix);

                using (Brush br = new SolidBrush(frame.FrameColor.BorderColor))
                    g.FillPath(br, path);

                myMatrix.Reset();
                myMatrix.Translate(-2, -3);
                path.Transform(myMatrix);

                // Fill in the outer frame bevel and draw the frame border

                using (Brush br = frame.FrameColor.GetBrush(r, 45))
                    g.FillPath(br, path);

                using (Pen pen = new Pen(frame.FrameColor.BorderColor))
                    g.DrawPath(pen, path);

                // Fill in the inner bevel area

                r.Inflate(-outer, -outer);

                using (Brush br = frame.FrameColor.GetBrush(r, 45 + 180))
                    g.FillEllipse(br, r);

                r.Inflate(-inner, -inner);

                // Fill in the default background area

                if (cbBackground.Checked == false)
                {
                    using (Brush br = frame.BackColor.GetBrush(r, 45))
                        g.FillEllipse(br, r);
                }
            }

            // Tell the system to not do its default rendering

            e.Cancel = true;
        }

        #endregion

        #region GetFramePath

        /// <summary>
        /// Gets the new frame path
        /// </summary>
        /// <param name="e"></param>
        /// <param name="outer"></param>
        /// <param name="inner"></param>
        /// <returns></returns>
        private GraphicsPath GetFramePath(
            PreRenderFrameEventArgs e, int outer, int inner)
        {
            GraphicsPath path = new GraphicsPath();

            int rad1 = e.Bounds.Width / 2;
            int rad2 = rad1 - outer + inner / 2;

            Point center = new Point(e.Bounds.X + rad1, e.Bounds.Y + rad1);

            for (int i = 0; i < 60; i++)
            {
                int m = i * 6;

                if ((i % 2) == 0)
                {
                    Point pt1 = GetPoint(rad1, m + 1, center);
                    Point pt2 = GetPoint(rad1, m + 5, center);

                    path.AddLine(pt1, pt2);
                }
                else
                {
                    Point pt1 = GetPoint(rad2, m, center);
                    Point pt2 = GetPoint(rad2, m + 6, center);

                    path.AddLine(pt1, pt2);

                }
            }

            path.CloseAllFigures();

            return (path);
        }

        #endregion

        #region GetPoint

        /// <summary>
        /// Calculates a Point based upon a given data
        /// </summary>
        /// <param name="radius">Circle radius</param>
        /// <param name="angle">Angle</param>
        /// <param name="center">Center of the circle</param>
        /// <returns></returns>
        internal Point GetPoint(int radius, float angle, Point center)
        {
            Point pt = new Point();

            if (angle < 0)
                angle += 360;

            angle = angle % 360;

            double radians = (angle % 90) * Math.PI / 180;

            if (angle < 90)
            {
                pt.X = (int)(Math.Cos(radians) * radius);
                pt.Y = (int)(Math.Sin(radians) * radius);
            }
            else if (angle < 180)
            {
                pt.X = -(int)(Math.Sin(radians) * radius);
                pt.Y = (int)(Math.Cos(radians) * radius);
            }
            else if (angle < 270)
            {
                pt.X = -(int)(Math.Cos(radians) * radius);
                pt.Y = -(int)(Math.Sin(radians) * radius);
            }
            else
            {
                pt.X = (int)(Math.Sin(radians) * radius);
                pt.Y = -(int)(Math.Cos(radians) * radius);
            }

            pt.X += center.X;
            pt.Y += center.Y;

            return (pt);
        }

        #endregion

        #region GcUserRenderingGetPointerPath

        /// <summary>
        /// Provides the gauge with user defined
        /// Pointer paths
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GcUserRenderingGetPointerPath(object sender, GetPointerPathEventArgs e)
        {
            if (e.Pointer.Name.Equals("Needle") == true)
                GetNeedlePath(e);

            else if (e.Pointer.Name.Equals("Marker") == true)
                GetMarkerPath(e);
        }

        #region GetMarkerPath

        /// <summary>
        /// Gets our user defined Marker path
        /// </summary>
        /// <param name="e"></param>
        private void GetMarkerPath(GetPointerPathEventArgs e)
        {
            if (cbMarker.Checked == true)
            {
                GraphicsPath path = new GraphicsPath();

                path.AddEllipse(e.Bounds);

                e.Path = path;
            }
        }

        #endregion

        #region GetNeedlePath

        /// <summary>
        /// Gets our user defined Needle path
        /// </summary>
        /// <param name="e"></param>
        private void GetNeedlePath(GetPointerPathEventArgs e)
        {
            if (cbNeedle.Checked == true)
            {
                GraphicsPath path = new GraphicsPath();

                Rectangle r = e.Bounds;

                int x1 = r.X + r.Width/2;
                int y1 = r.Y + r.Height/2;
                int y2 = r.Y + r.Height/5;

                Point[] pts =
                {
                    new Point(x1, r.Y),
                    new Point(x1 + 2, y2),
                    new Point(r.Right, y1),
                    new Point(r.Right, r.Bottom),
                    new Point(x1, r.Bottom - r.Width/2),
                    new Point(r.X, r.Bottom),
                    new Point(r.X, y1),
                    new Point(x1 - 2, y2),
                };

                path.AddClosedCurve(pts);

                path.CloseAllFigures();

                e.Path = path;
            }
        }

        #endregion

        #endregion

        #endregion

        #region Checkbox processing

        #region CbFrameCheckedChanged

        /// <summary>
        /// Handles Frame checkbox changed events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbFrameCheckedChanged(object sender, EventArgs e)
        {
            // Hook (or unhook) the event depending upon whether the
            // user wants us to render the area or not

            if (cbFrame.Checked == true)
                gcUserRendering.Frame.PreRenderFrame += GcUserRenderingPreRenderFrame;
            else
                gcUserRendering.Frame.PreRenderFrame -= GcUserRenderingPreRenderFrame;

            gcUserRendering.Refresh();
        }

        #endregion

        #region CbBackgroundCheckedChanged

        /// <summary>
        /// Handles Background checkbox changed events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbBackgroundCheckedChanged(object sender, EventArgs e)
        {
            // Hook (or unhook) the event depending upon whether the
            // user wants us to render the area or not

            if (cbBackground.Checked == true)
                gcUserRendering.PreRenderGaugeContent += GcUserRenderingPreRenderGaugeContent;
            else
                gcUserRendering.PreRenderGaugeContent -= GcUserRenderingPreRenderGaugeContent;

            gcUserRendering.Refresh();
        }

        #endregion

        #region CbRangeCheckedChanged

        /// <summary>
        /// Handles Range checkbox change events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbRangeCheckedChanged(object sender, EventArgs e)
        {
            // Hook (or unhook) the event depending upon whether the
            // user wants us to render the area or not

            if (cbRange.Checked == true)
                gcUserRendering.PostRenderScaleRange += GcUserRenderingPostRenderScaleRange;
            else
                gcUserRendering.PostRenderScaleRange -= GcUserRenderingPostRenderScaleRange;

            gcUserRendering.Refresh();
        }

        #endregion

        #region CbSectionCheckedChanged

        /// <summary>
        /// Handles Section checkbox changed events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbSectionCheckedChanged(object sender, EventArgs e)
        {
            // Hook (or unhook) the event depending upon whether the
            // user wants us to render the area or not

            if (cbSection.Checked == true)
                gcUserRendering.PostRenderScaleSection += GcUserRenderingPostRenderScaleSection;
            else
                gcUserRendering.PostRenderScaleSection -= GcUserRenderingPostRenderScaleSection;

            gcUserRendering.Refresh();
        }

        #endregion

        #region CbBarCheckedChanged

        /// <summary>
        /// Handles Bar checked changed events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbBarCheckedChanged(object sender, EventArgs e)
        {
            // Hook (or unhook) the event depending upon whether the
            // user wants us to render the area or not

            if (cbBar.Checked == true)
                EnableRenderPointerEvent(true);
            else
                DisableRenderPointerEvent(true);
        }

        #endregion

        #region CbNeedleCheckedChanged

        /// <summary>
        /// Handles Needle checked change events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbNeedleCheckedChanged(object sender, EventArgs e)
        {
            // Hook (or unhook) the event depending upon whether the
            // user wants us to render the area or not

            GaugePointer pointer =
                gcUserRendering.CircularScales["Scale1"].Pointers["Needle"];

            if (pointer != null)
            {
                if (cbNeedle.Checked == true)
                {
                    pointer.CapStyle = NeedlePointerCapStyle.None;
                    gcUserRendering.GetPointerPath += GcUserRenderingGetPointerPath;

                    EnableRenderPointerEvent(true);
                }
                else
                {
                    pointer.CapStyle = NeedlePointerCapStyle.Style1;
                    gcUserRendering.GetPointerPath -= GcUserRenderingGetPointerPath;

                    DisableRenderPointerEvent(true);
                }
            }
        }

        #endregion

        #region CbMarkerCheckedChanged

        /// <summary>
        /// Handles Marker checked change events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbMarkerCheckedChanged(object sender, EventArgs e)
        {
            // Hook (or unhook) the event depending upon whether the
            // user wants us to render the area or not

            GaugePointer pointer =
                gcUserRendering.CircularScales["Scale1"].Pointers["Marker"];

            if (pointer != null)
            {
                if (cbMarker.Checked == true)
                {
                    EnableRenderPointerEvent(false);
                    EnableGetPointerPathEvent(true);
                }
                else
                {
                    DisableRenderPointerEvent(false);
                    DisableGetPointerPathEvent(true);
                }
            }
        }

        #endregion

        #region EnableRenderPointerEvent

        /// <summary>
        /// Enables PostRenderScalePointer event processing
        /// </summary>
        private void EnableRenderPointerEvent(bool refresh)
        {
            _RenderPointerEventCount++;

            if (_RenderPointerEventCount == 1)
                gcUserRendering.PostRenderScalePointer += GcUserRenderingPostRenderScalePointer;

            // Refresh the control so our rendering can be performed

            if (refresh == true)
                gcUserRendering.Refresh();
        }

        #endregion

        #region DisableRenderPointerEvent

        /// <summary>
        /// Disables PostRenderScalePointer event processing
        /// </summary>
        private void DisableRenderPointerEvent(bool refresh)
        {
            _RenderPointerEventCount--;

            if (_RenderPointerEventCount == 0)
                gcUserRendering.PostRenderScalePointer -= GcUserRenderingPostRenderScalePointer;

            // Refresh the control so our rendering can be performed

            if (refresh == true)
                gcUserRendering.Refresh();
        }

        #endregion

        #region EnableGetPointerPathEvent

        /// <summary>
        /// Enables EnableGetPointerPath event processing
        /// </summary>
        private void EnableGetPointerPathEvent(bool refresh)
        {
            _GetPointerPathEventCount++;

            if (_GetPointerPathEventCount == 1)
                gcUserRendering.GetPointerPath += GcUserRenderingGetPointerPath;

            // Refresh the control so our rendering can be performed

            if (refresh == true)
                gcUserRendering.Refresh();
        }

        #endregion

        #region DisableGetPointerPathEvent

        /// <summary>
        /// Disables DisableGetPointerPath event processing
        /// </summary>
        private void DisableGetPointerPathEvent(bool refresh)
        {
            _GetPointerPathEventCount--;

            if (_GetPointerPathEventCount == 0)
                gcUserRendering.GetPointerPath -= GcUserRenderingGetPointerPath;

            // Refresh the control so our rendering can be performed

            if (refresh == true)
                gcUserRendering.Refresh();
        }

        #endregion

        #endregion

        #region GcUserRenderingPointerChanged

        /// <summary>
        /// Handles gcUserRendering PointerChanged events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GcUserRenderingPointerChanged(object sender, PointerChangedEventArgs e)
        {
            NumericIndicator ind =
                gcUserRendering.GaugeItems["NumericIndicator1"] as NumericIndicator;

            if (ind != null)
                ind.Value = e.NewValue;
        }

        #endregion

        #endregion

        #region gcScaleLimits

        #region CbSetLimitsCheckedChanged

        /// <summary>
        /// Handles Min/MaxLimit changes for gcScaleLimits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbSetLimitsCheckedChanged(object sender, EventArgs e)
        {
            GaugeCircularScale scale = gcScaleLimits.CircularScales["Scale1"];

            if (scale != null)
            {
                if (cbSetLimits.Checked == true)
                {
                    // Stop updates from happening so we get everything
                    // updated in one draw cycle

                    gcScaleLimits.BeginUpdate();

                    // The range of values on the screen is still 50.  But we are
                    // now going to set a new set of limits, so that the control can
                    // scroll from -150 to 100, displaying 50 units on the screen
                    // at a time.

                    scale.MinLimit = -150;
                    scale.MaxLimit = 100;

                    // All done, so let the control update its display

                    gcScaleLimits.EndUpdate();

                    // We could have set this value inside the above
                    // begin/end update, but by doing it outside we get to
                    // see the control scroll (should help the user see what's
                    // going on better)

                    scale.Pointers[0].Value = -30;
                }
                else
                {
                    // Stop updates from happening so we get everything
                    // updated in one draw cycle

                    gcScaleLimits.BeginUpdate();

                    // Tell the system there are no limits.

                    scale.MinLimit = double.NaN;
                    scale.MaxLimit = double.NaN;

                    // Reset our display value range back to what it was
                    // originally (it may have changed if the user scrolled the control)

                    scale.MinValue = 0;
                    scale.MaxValue = 50;

                    // All done, so let the control update its display, and then
                    // set our pointer back to its original position

                    gcScaleLimits.EndUpdate();

                    scale.Pointers[0].Value = 30;
                }
            }
        }

        #endregion

        #region Button processing

        #region BtnPlus20Click

        /// <summary>
        /// Handles adding 20 to the gcScaleLimits pointer value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlus20Click(object sender, EventArgs e)
        {
            GaugePointer pointer = GetCircularPointer(gcScaleLimits, "Scale1", "Needle");

            if (pointer != null)
                pointer.Value += 20;
        }

        #endregion

        #region BtnMinus10Click

        /// <summary>
        /// Handles subtracting 10 from gcScaleLimits pointer value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMinus10Click(object sender, EventArgs e)
        {
            GaugePointer pointer = GetCircularPointer(gcScaleLimits, "Scale1", "Needle");

            if (pointer != null)
                pointer.Value -= 10;
        }

        #endregion

        #region BtnMin2Click

        /// <summary>
        /// Handles setting gcScaleLimits pointer to the min value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMin2Click(object sender, EventArgs e)
        {
            GaugePointer pointer = GetCircularPointer(gcScaleLimits, "Scale1", "Needle");

            if (pointer != null)
                pointer.Value = pointer.Scale.MinValue;
        }

        #endregion

        #region BtnMax2Click

        /// <summary>
        /// Handles setting gcScaleLimits pointer value to the max
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMax2Click(object sender, EventArgs e)
        {
            GaugePointer pointer = GetCircularPointer(gcScaleLimits, "Scale1", "Needle");

            if (pointer != null)
                pointer.Value = pointer.Scale.MaxValue;
        }

        #endregion

        #region BtnAuto2Click

        /// <summary>
        /// Handles the starting and stopping of automatic
        /// gcScaleLimits pointer value changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAuto2Click(object sender, EventArgs e)
        {
            // If we need to enable the process, then allocate
            // and initialize our Timer to handle the udates

            if (_Timer2 == null)
            {
                _Timer2 = new Timer();
                _Timer2.Tick += RandomTimer_Tick2;

                _Timer2.Interval = 250;
                _Timer2.Start();

                btnAuto2.Text = @"Stop";
            }
            else
            {
                _Timer2.Stop();
                _Timer2.Tick -= RandomTimer_Tick2;
                _Timer2.Dispose();
                _Timer2 = null;

                btnAuto2.Text = @"Auto";
            }
        }

        #endregion

        #region RandomTimer_Tick2

        /// <summary>
        /// Handles timer ticks, used to update the associated
        /// scale's pointers with new, random, pointer values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void RandomTimer_Tick2(object sender, EventArgs e)
        {
            GaugePointer pointer = GetCircularPointer(gcScaleLimits, "Scale1", "Needle");

            if (pointer != null)
            {
                // Get a new random value for the pointer

                double value = pointer.Value + _Rand.Next(-10, 10);

                // Make sure we keep it in the scale range

                double n = pointer.Scale.MinLimit.Equals(double.NaN)
                    ? pointer.Scale.MinValue
                    : pointer.Scale.MinLimit;

                if (value < n)
                {
                    value = n;
                }
                else
                {
                    n = pointer.Scale.MaxLimit.Equals(double.NaN)
                            ? pointer.Scale.MaxValue
                            : pointer.Scale.MaxLimit;

                    if (value > n)
                        value = n;
                }

                pointer.Value = value;
            }
        }

        #endregion

        #endregion

        #region CbSliderDampen2ValueChanged

        /// <summary>
        /// Handles setting gcScaleLimits pointer dampening value 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbSliderDampen2ValueChanged(object sender, EventArgs e)
        {
            GaugePointer pointer = GetCircularPointer(gcScaleLimits, "Scale1", "Needle");

            if (pointer != null)
                pointer.DampeningSweepTime = cbSliderDampen2.Value;

            cbSliderDampen2.Text = cbSliderDampen2.Value.ToString();
        }

        #endregion

        #endregion 

        #endregion

        #region gcMixedScale

        #region GcMixedScalePointerChanged

        /// <summary>
        /// Handles Pointer changes for the gcMixedScale control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GcMixedScalePointerChanged(object sender, PointerChangedEventArgs e)
        {
            if (e.Pointer.Name.Equals("MainMarker") == true)
            {
                int o = Math.Min((int)(e.OldValue / 10), 2);
                int n = Math.Min((int)(e.NewValue / 10), 2);

                GaugeCircularScale oScale = gcMixedScale.CircularScales[o];
                GaugeCircularScale nScale = gcMixedScale.CircularScales[n];

                if (oScale != null && nScale != null)
                {
                    gcMixedScale.BeginUpdate();

                    // If we need to change scales, then hide the
                    // old marker and show the new one

                    if (o != n)
                    {
                        oScale.Pointers[0].Visible = false;
                        nScale.Pointers[0].Visible = true;
                    }

                    nScale.Pointers[0].Value = e.Pointer.Value;

                    // Just for grins, move the red marker
                    // the opposite direction from the moved marker

                    GaugeLinearScale xScale = gcMixedScale.LinearScales["Scale2"];

                    if (xScale != null)
                    {
                        xScale.Pointers[0].Value = 30 - e.NewValue;

                        // Move the vertical scale marker to show the
                        // change in height of the yellow star marker

                        GaugeLinearScale yScale = gcMixedScale.LinearScales["Scale3"];

                        if (yScale != null)
                        {
                            // Simply use the IntervalPoint for the star marker

                            Point pt = nScale.Pointers[0].IntervalPoint;
                            double dy = (xScale.Bounds.Y + xScale.Bounds.Height / 2) - pt.Y;

                            // The IntervalPoint is to the top left of the marker, so
                            // simply adjust the offset by 1/2 the height of the marker

                            double h = (nScale.Pointers[0].Length * nScale.Bounds.Height / 2) / 2;
                            dy += ((dy > 0) ? -h : h) / 2;

                            yScale.Pointers[0].Value = ((yScale.MaxValue - yScale.MinValue) * dy) / yScale.Bounds.Height;
                        }
                    }

                    gcMixedScale.EndUpdate();
                }
            }
        }

        #endregion

        #endregion

        #region GetCircularPointer

        /// <summary>
        /// Locates the given scale and pointer from the
        /// the given gauge's CircularScales list
        /// </summary>
        /// <param name="gauge">Gauge</param>
        /// <param name="sname">Scale name</param>
        /// <param name="pname">Pointer name</param>
        /// <returns>Located Pointer, or null</returns>
        private GaugePointer GetCircularPointer(
            GaugeControl gauge, string sname, string pname)
        {
            GaugeScale scale = gauge.CircularScales[sname];

            return (scale != null ? scale.Pointers[pname] : null);
        }

        #endregion

        #region GetLinearPointer

        /// <summary>
        /// Locates the given scale and pointer from the
        /// the given gauge's LinearScales list
        /// </summary>
        /// <param name="gauge">Gauge</param>
        /// <param name="sname">Scale name</param>
        /// <param name="pname">Pointer name</param>
        /// <returns>Located Pointer, or null</returns>
        private GaugePointer GetLinearPointer(
            GaugeControl gauge, string sname, string pname)
        {
            GaugeScale scale = gauge.LinearScales[sname];

            return (scale != null ? scale.Pointers[pname] : null);
        }

        #endregion

        #region GaugeControlGetDisplayTemplateText

        /// <summary>
        /// Handles the GetDisplayTemplateText event for
        /// the associated gauge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GaugeControlGetDisplayTemplateText(
            object sender, GetDisplayTemplateTextEventArgs e)
        {
            GaugePointer pointer = e.GaugeItem as GaugePointer;

            if (pointer != null)
            {
                // If the GaugeItem is a Pointer, then we have 2 simple user
                // defined templates that we have defined
                
                switch (e.DisplayTemplate)
                {
                    case "CtoF":    // Celsius to Fahrenheit conversion

                        double n = pointer.Value * 9 / 5 + 32;

                        e.DisplayText = String.IsNullOrEmpty(e.DisplayFormat) == false
                            ? String.Format("{0:" + e.DisplayFormat + "}", n)
                            : (Math.Round(n, 2)).ToString();
                        break;

                    case "OutOf":   // "n out of 100"

                        e.DisplayText = ((int)(pointer.Value * 100)).ToString() + " out of 100";
                        break;
                }
            }
            else
            {
                GaugeStrip strip = e.GaugeItem as GaugeStrip;

                if (strip != null)
                {
                    // If the GaugeItem is a Range or a Section, then we have 2 simple user
                    // defined templates that we have defined
                    
                    switch (e.DisplayTemplate)
                    {
                        case "MyStartValue":    // StartValue
                            e.DisplayText = ((int)(strip.StartValue * 100)).ToString();
                            break;

                        case "MyEndValue":      // EndValue
                            e.DisplayText = ((int)(strip.EndValue * 100)).ToString();
                            break;
                    }
                }
            }
        }

        #endregion

        #region LinkLabel1Click

        private void LinkLabel1Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.devcomponents.com/kb2/?p=989");
        }

        #endregion
    }
}