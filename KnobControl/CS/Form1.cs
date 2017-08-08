using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevComponents.Instrumentation;

namespace KnobControlSample
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // Initialize our default label text

            lbl100.Text = ks100.Value.ToString();
            lbl200.Text = ks200.Value.ToString();
            lbl300.Text = ks300.Value.ToString();
            lbl400.Text = ks400.Value.ToString();
        }

        #region PreRenderTickLabel

        /// <summary>
        /// Render a plum colored circle at pre-render tick label time
        /// </summary>
        /// <param name="sender">KnobControl</param>
        /// <param name="e">PreRenderEventArgs</param>
        private void PreRenderTickLabel(object sender, PreRenderEventArgs e)
        {
            KnobControl kc = sender as KnobControl;

            if (kc != null)
            {
                // Locate where the current "value label" is located,
                // and then render our circle accordingly

                Point pt = GetLabelPoint(kc, e);

                e.Graphics.FillEllipse(Brushes.Plum,
                    new Rectangle(pt.X, pt.Y, 20, 20));
            }
        }

        #endregion

        #region PostRenderKnobIndicator1

        /// <summary>
        /// Render the Value onto the control at post-render indicator time
        /// </summary>
        /// <param name="sender">KnobControl</param>
        /// <param name="e">PostRenderEventArgs</param>
        private void PostRenderKnobIndicator1(object sender, PostRenderEventArgs e)
        {
            KnobControl kc = sender as KnobControl;

            if (kc != null)
            {
                // Draw the knob Value (with an offset shadow)
                // on top of the KnobIndicator

                using (Font font = new Font("Arial", 30, FontStyle.Regular))
                {
                    using (StringFormat strFormat = new StringFormat(StringFormatFlags.NoClip))
                    {
                        strFormat.Alignment = StringAlignment.Center;

                        string s = kc.Value.ToString();

                        if (s.EndsWith(".0"))
                            s = s.Substring(0, s.Length - 2);

                        RectangleF r = GetTextRect(e.Bounds, font);

                        r.Offset(2, 2);
                        e.Graphics.DrawString(s, font, Brushes.Black, r, strFormat);

                        r.Offset(-2, -2);
                        e.Graphics.DrawString(s, font, Brushes.White, r, strFormat);
                    }
                }
            }
        }

        #endregion

        #region PostRenderKnobIndicator2

        /// <summary>
        /// Render the control Value at post-render indicator time
        /// </summary>
        /// <param name="sender">KnobControl</param>
        /// <param name="e">PostRenderEventArgs</param>
        private void PostRenderKnobIndicator2(object sender, PostRenderEventArgs e)
        {
            KnobControl kc = sender as KnobControl;

            if (kc != null)
            {
                // Draw the knob Value on top of the KnobIndicator

                using (Font font = new Font("Arial", 16, FontStyle.Regular))
                {
                    using (StringFormat strFormat = new StringFormat(StringFormatFlags.NoClip))
                    {
                        strFormat.Alignment = StringAlignment.Center;

                        RectangleF r = GetTextRect(e.Bounds, font);

                        e.Graphics.DrawString(kc.Value.ToString(), font, Brushes.Black, r, strFormat);
                    }
                }
            }
        }

        #endregion

        #region RenderFocusRect

        /// <summary>
        /// Renders a hilight focus rect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RenderFocusRect(object sender, RenderFocusRectEventArgs e)
        {
            KnobControl kc = sender as KnobControl;

            if (kc != null)
            {
                Color c = Color.FromArgb(80, Color.Yellow);

                using (LinearGradientBrush lbr = new LinearGradientBrush(e.Bounds, Color.White, c, 45f))
                    e.Graphics.FillEllipse(lbr, e.Bounds);
            }
        }

        #endregion

        #region GetLabelPoint

        /// <summary>
        /// Returns tick label point
        /// </summary>
        /// <returns>Upper left tick label rect of the control</returns>
        private Point GetLabelPoint(KnobControl kc, PreRenderEventArgs e)
        {
            decimal count = kc.MaxValue - kc.MinValue;

            double rad = GetRadians(
                (float)((kc.SweepAngle * kc.Value) / count + kc.StartAngle));

            int x = e.Bounds.X + e.Bounds.Width / 2;
            int dx = e.Bounds.Width / 2;

            Point pt = new Point();

            pt.X = (int)(Math.Cos(rad) * dx + x - 10);
            pt.Y = (int)(Math.Sin(rad) * dx + x - 10);

            return (pt);
        }

        #region GetRadians

        /// <summary>
        /// Converts degrees to radians
        /// </summary>
        /// <param name="theta">degrees</param>
        /// <returns>radians</returns>
        public double GetRadians(float theta)
        {
            return (theta * Math.PI / 180);
        }

        #endregion

        #endregion

        #region GetTextRect

        /// <summary>
        /// Calculates the inner knob text bounding rectangle
        /// </summary>
        /// <param name="bounds">Knob bounding rectangle</param>
        /// <param name="font">Text font</param>
        /// <returns>Text bounding rectangle</returns>
        private RectangleF GetTextRect(Rectangle bounds, Font font)
        {
            int width = bounds.Width;
            float dy = font.Height;

            return (new RectangleF(bounds.X,
                bounds.Y + (width - dy) / 2, bounds.Width, dy));
        }

        #endregion

        #region ks100 range support

        #region Ks100Enter

        /// <summary>
        /// ks100_Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ks100Enter(object sender, EventArgs e)
        {
            UpdateLabel(sender, lbl100);
        }

        #endregion

        #region Ks100ValueChanged

        /// <summary>
        /// ks100_ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ks100ValueChanged(object sender, ValueChangedEventArgs e)
        {
            UpdateLabel(sender, lbl100);
        }

        #endregion

        #endregion

        #region ks200 range support

        #region Ks200Enter

        /// <summary>
        /// ks200_Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ks200Enter(object sender, EventArgs e)
        {
            UpdateLabel(sender, lbl200);
        }

        #endregion

        #region Ks200ValueChanged

        /// <summary>
        /// Ks200ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ks200ValueChanged(object sender, ValueChangedEventArgs e)
        {
            UpdateLabel(sender, lbl200);
        }

        #endregion

        #endregion

        #region ks300 range support

        #region Ks300Enter

        /// <summary>
        /// Ks300Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ks300Enter(object sender, EventArgs e)
        {
            UpdateLabel(sender, lbl300);
        }

        #endregion

        #region Ks300ValueChanged

        /// <summary>
        /// Ks300ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ks300ValueChanged(object sender, ValueChangedEventArgs e)
        {
            UpdateLabel(sender, lbl300);
        }

        #endregion

        #region Ks301ValueChanged

        /// <summary>
        /// Ks301ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ks301ValueChanged(object sender, ValueChangedEventArgs e)
        {
            UpdateLabel(sender, lbl300);

            if (ks301.Value >= 3000 && ks301.Value <= 4000)
                ks301.KnobColor.MidZoneIndicatorColor.Start = Color.Magenta;
            else
                ks301.KnobColor.MidZoneIndicatorColor.Start = Color.MediumOrchid;
        }

        #endregion

        #region Ks302ValueChanged

        /// <summary>
        /// Ks302ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ks302ValueChanged(object sender, ValueChangedEventArgs e)
        {
            UpdateLabel(sender, lbl300);

            // Set our Min and Max zone percentages so that they
            // follow the current knob value setting

            decimal count = ks302.MaxValue - ks302.MinValue;

            if (count > 0)
            {
                int pct = (int)((ks302.Value / count) * 100);

                ks302.SuspendLayout();

                ks302.MinZonePercentage = pct;
                ks302.MaxZonePercentage = 100 - pct;

                ks302.ResumeLayout();
            }
        }

        #endregion

        #endregion

        #region ks400 range support

        #region Ks400Enter

        /// <summary>
        /// Ks400Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ks400Enter(object sender, EventArgs e)
        {
            UpdateLabel(sender, lbl400);
        }

        #endregion

        #region Ks400ValueChanged

        /// <summary>
        /// Ks400ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ks400ValueChanged(object sender, ValueChangedEventArgs e)
        {
            UpdateLabel(sender, lbl400);
        }

        #endregion

        #region Ks403ValueChanged

        /// <summary>
        /// Ks403ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ks403ValueChanged(object sender, ValueChangedEventArgs e)
        {
            UpdateLabel(sender, lbl400);

            Color c = ks403.KnobColor.KnobFaceColor.End;

            decimal d = ks403.MaxValue - ks403.MinValue;
            decimal x = ks403.Value / d;

            ks403.KnobColor.KnobIndicatorColor.End = ControlPaint.Light(c, (float)x);
        }

        #endregion

        #endregion

        #region UpdateLabel

        /// <summary>
        /// UpdateLabel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="label"></param>
        private void UpdateLabel(object sender, Label label)
        {
            KnobControl kc = sender as KnobControl;

            if (kc != null)
                label.Text = kc.Value.ToString();
        }

        #endregion
    }
}