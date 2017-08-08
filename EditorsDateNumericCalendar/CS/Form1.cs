using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;
using System.Drawing.Drawing2D;
using DevComponents.Editors.DateTimeAdv;

namespace EditorsDateNumericCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customersDataSet.Customers);
            dateTimeInput1.Value = DateTime.Today;
            dateTimeInput2.Value = DateTime.Today;
            dateTimeInput3.Value = DateTime.Now;
            dateTimeInput4.Value = DateTime.Now;
            dateTimeInput5.Value = DateTime.Now;
            dateTimeInput6.Value = DateTime.Now;
            dateTimeInput7.Value = DateTime.Now;
            dateTimeInput8.Value = DateTime.Now;
            dateTimeInput9.Value = DateTime.Now;
        }

        #region DateTimeInput Code
        private void dateTimeInput3_ButtonCustomClick(object sender, EventArgs e)
        {
            MessageBoxEx.Show("Use custom buttons to show dialogs, provide customized value pickers etc.", "Date/Time Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dateTimeInput5_ButtonCustomClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Set value of control to NULL?", "Time Input", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                dateTimeInput5.ValueObject = null;
        }

        private void dateTimeInput11_MonthCalendar_PaintLabel(object sender, DevComponents.Editors.DateTimeAdv.DayPaintEventArgs e)
        {
            DevComponents.Editors.DateTimeAdv.DayLabel day = sender as DevComponents.Editors.DateTimeAdv.DayLabel;
            if (day == null || day.Date == DateTime.MinValue) return;

            // Cross all weekend days and disable selection for them...
            if ((day.Date.DayOfWeek == DayOfWeek.Saturday || day.Date.DayOfWeek == DayOfWeek.Sunday) && day.Date != DateTime.Today.AddDays(1))
            {
                day.Selectable = false; // Mark label as not selectable...
                day.TrackMouse = false; // Do not track mouse movement...
                e.PaintBackground();
                e.PaintText();
                Rectangle r = day.Bounds;
                r.Inflate(-2, -2);
                SmoothingMode sm = e.Graphics.SmoothingMode;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawLine(Pens.Red, r.X, r.Y, r.Right, r.Bottom);
                e.Graphics.DrawLine(Pens.Red, r.Right, r.Y, r.X, r.Bottom);
                e.Graphics.SmoothingMode = sm;
                // Ensure that no part is rendered internally by control...
                e.RenderParts = DevComponents.Editors.DateTimeAdv.eDayPaintParts.None;
            }
            // Mark tomorrows day...
            else if (day != null && day.Date == DateTime.Today.AddDays(1))
            {
                e.PaintBackground();
                e.PaintText();
                SmoothingMode sm = e.Graphics.SmoothingMode;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle r = day.Bounds;
                r.Width--;
                r.Height--;
                using(Pen pen = new Pen(Color.FromArgb(128, Color.Blue)))
                    e.Graphics.DrawEllipse(pen, r);
                e.Graphics.SmoothingMode = sm;
                // Ensure that no part is rendered internally by control...
                e.RenderParts = DevComponents.Editors.DateTimeAdv.eDayPaintParts.None;
            }
        }
        #endregion

        #region MonthCalendarAdv Code
        private void monthCalendarAdv2_MonthChanged(object sender, EventArgs e)
        {
            // You can use this event to add custom markers to the calendar for example mark appointments for days...
            // In this sample we'll just pick the day 8 days from today...
            DateTime date = DateTime.Today.AddDays(8);
            // DayLabel control is used to represents each date on calendar
            DayLabel day = monthCalendarAdv2.GetDay(date);
            if (day != null) // Null will be returned if date is not displayed on calendar
            {
                // Display image on the label...
                day.Image = global::EditorsDateNumericCalendar.Properties.Resources.Bell;
                day.ImageAlign = eLabelPartAlignment.MiddleRight;
                day.TextAlign = eLabelPartAlignment.MiddleLeft;
                day.Tooltip = "Click image to see appointments";
                // You can display the popup when day image is clicked with for example the appointment details...
                day.SubItems.Add(new ButtonItem("appointment1", "10:45 AM Call Dave to setup meeting"));
                day.SubItems.Add(new ButtonItem("appointment2", "12:05 PM Lunch with Kurt"));
            }
        }

        private void monthCalendarAdv2_PaintLabel(object sender, DayPaintEventArgs e)
        {
            // Cross Sundays and disable selection
            DayLabel day = sender as DayLabel;
            if (day != null && day.Date > DateTime.MinValue && day.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                day.Selectable = false; // Mark label as not selectable...
                day.TrackMouse = false; // Do not track mouse movement...
                e.PaintBackground();
                e.PaintText(Color.Gray);
                Rectangle r = day.Bounds;
                r.Inflate(-2, -2);
                SmoothingMode sm = e.Graphics.SmoothingMode;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.FromArgb(128, Color.Red)))
                {
                    e.Graphics.DrawLine(pen, r.X, r.Y, r.Right, r.Bottom);
                    e.Graphics.DrawLine(pen, r.Right, r.Y, r.X, r.Bottom);
                }
                e.Graphics.SmoothingMode = sm;
                // Ensure that no part is rendered internally by control...
                e.RenderParts = DevComponents.Editors.DateTimeAdv.eDayPaintParts.None;
            }
        }
        #endregion

        private void integerInput2_ButtonCustomClick(object sender, EventArgs e)
        {
            MessageBoxEx.Show("Execute custom action here...", "IntegerInput", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelX24_MarkupLinkClick(object sender, MarkupLinkClickEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.devcomponents.com/kb2/?p=876");
        }

    }
}