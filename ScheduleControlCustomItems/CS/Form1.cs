using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar.Schedule;
using DevComponents.DotNetBar;
using DevComponents.Schedule.Model;
using DevComponents.DotNetBar.Rendering;

namespace ScheduleTestProject
{
    public partial class Form1 : Office2007Form
    {
        #region Private variables

        private int _CustomUserId = 1;
        private int _ColorCycle;

        #region _MyAppColorTable

        private ColorDef[] _MyAppColorTable = new ColorDef[]
        {
            new ColorDef(0x4B71A2),                         // DefaultBorder

            new ColorDef(new int[] {0x00cccc, 0x006B6B},    // DefaultBackground
                         new float[] {0f, 1f}, 90f),

            new ColorDef(0x28518E),                         // BlueBorder

            new ColorDef(new int[] {0x00aaFF, 0x0047B2},    // BlueBackground
                         new float[] {0f, 1f}, 90f),

            new ColorDef(0x2C6524),                         // GreenBorder

            new ColorDef(new int[] {0x00ff00, 0x007d00},    // GreenBackground
                         new float[] {0f, 1f}, 90f),

            new ColorDef(0x8B3E0A),                         // OrangeBorder

            new ColorDef(new int[] {0xFFB200, 0xB26B00},    // OrangeBackground
                         new float[] {0f, 1f}, 90f),

            new ColorDef(0x3E2771),                         // PurpleBorder

            new ColorDef(new int[] {0xEABFFE, 0x660099},    // PurpleBackground
                         new float[] {0f, 1f}, 90f),

            new ColorDef(0x86171C),                         // RedBorder

            new ColorDef(new int[] {0xFFb0b0, 0xcc0000},    // RedBackground
                         new float[] {0f, 1f}, 90f),

            new ColorDef(0x7C7814),                         // YellowBorder

            new ColorDef(new int[] {0xFFFF00, 0xB2B300},    // YellowBackground
                         new float[] {0f, 1f}, 90f),

            new ColorDef(-1),                               // BusyTimeMarker
            new ColorDef(0xFFFFFF),                         // FreeTimeMarker
            new ColorDef(0x000000)                          // OutOfOfficeTimeMarker
        };

        #endregion

        #endregion

        public Form1()
        {
            InitializeComponent();

            // Set our Calendar Model

            calendarView1.CalendarModel = new CalendarModel();

            // And add some sample appointments

            AddSampleAppointments();
        }

        #region AddSampleAppointments

        /// <summary>
        /// Adds some example appointments to the Calendar Model
        /// </summary>
        private void AddSampleAppointments()
        {
            // Recurring appointment

            Appointment appointment = new Appointment();

            appointment.Subject = "Recurring Appointment every 3rd week day";
            appointment.Description = "Custom description for this appointment";
            appointment.Tooltip = "This is a Custom tooltip for this appointment";
            appointment.CategoryColor = Appointment.CategoryOrange;

            appointment.StartTime = DateTime.Today.AddHours(11.25);
            appointment.EndTime = appointment.StartTime.AddHours(1);

            appointment.Recurrence = new AppointmentRecurrence();

            // Set recurrence type to weekly

            appointment.Recurrence.RecurrenceType = eRecurrencePatternType.Daily;
            appointment.Recurrence.Daily.RepeatOnDaysOfWeek = eDailyRecurrenceRepeat.All;
            appointment.Recurrence.Daily.RepeatInterval = 10;
            appointment.Recurrence.RangeLimitType = eRecurrenceRangeLimitType.RangeEndDate;
            appointment.Recurrence.RangeEndDate = DateTime.Today.AddDays(120);

            // Add appointment to the model

            calendarView1.CalendarModel.Appointments.Add(appointment);

            DateTime date = DateTime.Today.AddHours(8);

            // Multi-day appointment #1

            AddAppointment("#1 Multiple days Appointment",
                date, date.AddDays(4),
                Appointment.CategoryBlue, Appointment.TimerMarkerDefault);

            // Multi-day appointment #2

            AddAppointment("#2 Multiple days Appointment",
                date.AddDays(2), date.AddDays(14.5),
                Appointment.CategoryGreen, Appointment.TimerMarkerDefault);

            // Create some new appointments and add them to the model

            Appointment ap = AddAppointment("Busy Appointment",
                date, date.AddMinutes(180),
                Appointment.CategoryYellow, Appointment.TimerMarkerBusy);

            // Make sure this appointment is visible

            calendarView1.EnsureVisible(ap);

            AddAppointment("Out Of Office Appointment",
                date.AddHours(1), date.AddHours(2),
                Appointment.CategoryBlue, Appointment.TimerMarkerOutOfOffice);

            date = date.AddDays(1);

            AddAppointment("Free Appointment",
                date.AddHours(2), date.AddMinutes(170),
                Appointment.CategoryRed, Appointment.TimerMarkerFree);

            AddAppointment("Tentative Appointment",
                date.AddHours(4), date.AddHours(6),
                Appointment.CategoryDefault, Appointment.TimerMarkerTentative);

            date = date.AddDays(1);

            AddAppointment("Default Appointment",
                date.AddHours(1.5), date.AddHours(4.25),
                Appointment.CategoryPurple, Appointment.TimerMarkerDefault);
        }

        #region AddAppointment

        /// <summary>
        /// Adds the specified appointment to the model
        /// </summary>
        /// <param name="s">Appointment subject</param>
        /// <param name="startTime">Appointment start time</param>
        /// <param name="endTime">Appointment end time</param>
        /// <param name="color">Appointment color</param>
        /// <param name="marker">Appointment marker</param>
        private Appointment AddAppointment(string s,
            DateTime startTime, DateTime endTime, string color, string marker)
        {
            Appointment appointment = new Appointment();

            appointment.StartTime = startTime;
            appointment.EndTime = endTime;

            appointment.Subject = s;
            appointment.Description = "Custom description for this appointment";
            appointment.CategoryColor = color;
            appointment.TimeMarkedAs = marker;

            appointment.Tooltip = "This is a Custom tooltip for this appointment";

            calendarView1.CalendarModel.Appointments.Add(appointment);

            return (appointment);
        }

        #endregion

        #endregion

        #region View change

        /// <summary>
        /// Day view selection
        /// </summary>
        /// <param name="sender">PopupItem</param>
        /// <param name="e">EventArgs</param>
        private void btnDay_Click(object sender, EventArgs e)
        {
            calendarView1.SelectedView = eCalendarView.Day;
        }

        /// <summary>
        /// Week view selection
        /// </summary>
        /// <param name="sender">PopupItem</param>
        /// <param name="e">EventArgs</param>
        private void btnWeek_Click(object sender, EventArgs e)
        {
            calendarView1.SelectedView = eCalendarView.Week;
        }

        /// <summary>
        /// Month view selection
        /// </summary>
        /// <param name="sender">PopupItem</param>
        /// <param name="e">EventArgs</param>
        private void btnMonth_Click(object sender, EventArgs e)
        {
            calendarView1.SelectedView = eCalendarView.Month;
        }

        /// <summary>
        /// TimeLine view selection
        /// </summary>
        /// <param name="sender">PopupItem</param>
        /// <param name="e">EventArgs</param>
        private void btnTimeLine_Click(object sender, EventArgs e)
        {
            calendarView1.SelectedView = eCalendarView.TimeLine;
        }

        #endregion

        #region CalendarView1_ItemDoubleClick

        /// <summary>
        /// Handles Appointment View double clicks
        /// </summary>
        /// <param name="sender">AppointmentView</param>
        /// <param name="e">MouseEventArgs</param>
        private void CalendarView1_ItemDoubleClick(object sender, MouseEventArgs e)
        {
            AppointmentView item = sender as AppointmentView;

            if (item != null)
            {
                Appointment ap = item.Appointment;

                string s = string.Format(
                    "Subject: {0}\nDescription: {1}\nToolTip: {2}\n\n" +
                    "StartTime: {3}\nEndTime: {4}\n\n" +
                    "CategoryColor: {5}\nTimeMarkedAs: {6}",
                    ap.Subject, ap.Description, ap.Tooltip,
                    ap.StartTime, ap.EndTime,
                    String.IsNullOrEmpty(ap.CategoryColor) ? "Default" : ap.CategoryColor,
                    String.IsNullOrEmpty(ap.TimeMarkedAs) ? "Default" : ap.TimeMarkedAs);

                MessageBox.Show(s);
            }
        }

        #endregion

        #region CalendarView1_MouseUp

        /// <summary>
        /// Handles CalendarView MouseUp events
        /// </summary>
        /// <param name="sender">Varied sender</param>
        /// <param name="e">MouseEventArgs</param>
        private void CalendarView1_MouseUp(object sender, MouseEventArgs e)
        {
            // Process Right MouseUp event in order to
            // present view specific ContextMenu

            if (e.Button == MouseButtons.Right)
            {
                // Main Calendar View hit

                if (sender is BaseView)
                    BaseViewMouseUp(sender, e);

                // AppointmentView hit

                else if (sender is AppointmentView)
                    AppointmentViewMouseUp(sender);

                // AllDayPanel hit

                else if (sender is AllDayPanel)
                    AllDayPanelMouseUp(sender);

                // TimeRulerPanel

                else if (sender is TimeRulerPanel)
                    TimeRulerPanelMouseUp();

                // TimeLineHeaderPanel

                else if (sender is TimeLineHeaderPanel)
                    TimeLineHeaderPanelMouseUp(sender, e);

                // CustomCalendarItem

                else if (sender is CustomCalendarItem)
                    CustomCalendarItemMouseUp(sender);

                else if (sender is BaseItem)
                {
                    BaseItem bi = sender as BaseItem;

                    if (bi.Parent is CustomCalendarItem)
                        CustomCalendarItemMouseUp(bi.Parent);
                }
            }
        }

        #region BaseViewMouseUp

        /// <summary>
        /// Handles Day, Week, and Month View MouseUp events
        /// </summary>
        /// <param name="sender">BaseView</param>
        /// <param name="e">MouseEventArgs</param>
        private void BaseViewMouseUp(object sender, MouseEventArgs e)
        {
            BaseView view = sender as BaseView;
            eViewArea area = view.GetViewAreaFromPoint(e.Location);

            if (area == eViewArea.InContent)
                InContentMouseUp(view, e);

            else if (area == eViewArea.InDayOfWeekHeader)
                InHeaderMouseUp(view);

            else if (area == eViewArea.InSideBarPanel)
                InSideBarMouseUp(view);

            else if (area == eViewArea.InCondensedView)
                InCondensedViewMouseUp();
        }

        #region InContentMouseUp

        /// <summary>
        /// Handles BaseView InContent MouseUp events
        /// </summary>
        /// <param name="view">BaseView</param>
        /// <param name="e">MouseEventArgs</param>
        private void InContentMouseUp(BaseView view, MouseEventArgs e)
        {
            // Get the DateSelection start and end
            // from the current mouse location

            DateTime startDate, endDate;

            if (calendarView1.GetDateSelectionFromPoint(
                e.Location, out startDate, out endDate) == true)
            {
                // If this date already falls outside the currently
                // selected range (DateSelectionStart and DateSelectionEnd)
                // then select the new range

                if (IsDateSelected(startDate, endDate) == false)
                {
                    calendarView1.DateSelectionStart = startDate;
                    calendarView1.DateSelectionEnd = endDate;
                }
            }

            // Remove any previously added view specific items

            for (int i = InContentContextMenu.SubItems.Count - 1; i > 3; i--)
                InContentContextMenu.SubItems.RemoveAt(i);

            // If this is a TimeLine view, then add a couple
            // of extra items

            if (view is TimeLineView)
            {
                ButtonItem bi = new ButtonItem();

                // Page Navigator

                bi.Text = (calendarView1.TimeLineShowPageNavigation == true)
                    ? "Hide Page Navigator" : "Show Page Navigator";

                bi.BeginGroup = true;

                bi.Click += BiPageNavigatorClick;

                InContentContextMenu.SubItems.Add(bi);

                // Condensed Visibility

                if (calendarView1.TimeLineCondensedViewVisibility ==
                    eCondensedViewVisibility.Hidden)
                {
                    bi = new ButtonItem("", "Show Condensed View");
                    bi.Click += BiCondensedClick;

                    InContentContextMenu.SubItems.Add(bi);
                }
            }

            ShowContextMenu(InContentContextMenu);
        }

        #region BiCondensedClick

        /// <summary>
        /// Handles InContentContextMenu Condensed selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BiCondensedClick(object sender, EventArgs e)
        {
            calendarView1.TimeLineCondensedViewVisibility =
                eCondensedViewVisibility.AllResources;
        }

        #endregion

        #region BiPageNavigatorClick

        /// <summary>
        /// Handles InContentContextMenu PageNavigator selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BiPageNavigatorClick(object sender, EventArgs e)
        {
            calendarView1.TimeLineShowPageNavigation =
                (calendarView1.TimeLineShowPageNavigation == false);
        }

        #endregion

        #region IsDateSelected

        /// <summary>
        /// Determines if the given date range is within the currently selected
        /// CalendarView selection range (DateSelectionStart to DateSelectionEnd)
        /// </summary>
        /// <param name="startDate">Start date range</param>
        /// <param name="endDate">End date range</param>
        /// <returns>True if selected</returns>
        private bool IsDateSelected(DateTime startDate, DateTime endDate)
        {
            if (calendarView1.DateSelectionStart.HasValue && calendarView1.DateSelectionEnd.HasValue)
            {
                if (calendarView1.DateSelectionStart.Value <= startDate &&
                    calendarView1.DateSelectionEnd.Value >= endDate)
                    return (true);
            }

            return (false);
        }

        #endregion

        #region miAdd_Click

        /// <summary>
        /// Handles BaseView "Add Appointment" 
        /// ContextMenu selections
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void miAdd_Click(object sender, EventArgs e)
        {
            DateTime startDate = calendarView1.DateSelectionStart.GetValueOrDefault();
            DateTime endDate = calendarView1.DateSelectionEnd.GetValueOrDefault();

            AddNewAppointment(startDate, endDate);
        }

        /// <summary>
        /// Adds a new appointment at the user selected time
        /// </summary>
        private Appointment AddNewAppointment(DateTime startDate, DateTime endDate)
        {
            // Create new appointment and add it to the model
            // Appointment will show up in the view automatically

            Appointment appointment = new Appointment();

            appointment.StartTime = startDate;
            appointment.EndTime = endDate;

            appointment.Subject = "New " +
                appointment.CategoryColor + " appointment!";

            appointment.Description = "This is a new appointment";
            appointment.Tooltip = "This is a Custom tooltip for this new appointment";

            // Add appointment to the model

            calendarView1.CalendarModel.Appointments.Add(appointment);

            return (appointment);
        }

        #endregion

        #endregion

        #region InHeaderMouseUp

        /// <summary>
        /// Handles BaseView InHeader MouseUp events.
        /// </summary>
        /// <param name="view">BaseView</param>
        private void InHeaderMouseUp(BaseView view)
        {
            if (view is MonthView)
            {
                MonthView mv = view as MonthView;

                // The View is a month view, so let the user
                // hide or show the SideBar panel

                if (mv.IsSideBarVisible == true)
                {
                    InHeaderHideSideBarContextItem.Visible = true;
                    InHeaderShowSideBarContextItem.Visible = false;
                }
                else
                {
                    InHeaderHideSideBarContextItem.Visible = false;
                    InHeaderShowSideBarContextItem.Visible = true;
                }
            }
            else
            {
                InHeaderHideSideBarContextItem.Visible = false;
                InHeaderShowSideBarContextItem.Visible = false;
            }

            InHeaderContextMenu.Tag = view;

            ShowContextMenu(InHeaderContextMenu);
        }

        #region miCalendarColor_Click

        /// <summary>
        /// Handles selection of a ContextMenu color item
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void miCalendarColor_Click(object sender, EventArgs e)
        {
            ButtonItem mi = sender as ButtonItem;
            BaseView view = mi.Parent.Tag as BaseView;

            if (view != null)
                view.CalendarColor = (eCalendarColor)Enum.Parse(typeof(eCalendarColor), mi.Text);
        }

        #endregion

        #region SideBar show/hide

        /// <summary>
        /// Handles ContextMenu "Show" for the SideBar panel
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void miShowSideBar_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;
            MonthView view = bi.Parent.Tag as MonthView;

            if (view != null)
                view.IsSideBarVisible = true;
        }

        /// <summary>
        /// Handles ContextMenu "Hide" for the SideBar panel
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void miHideSideBar_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;
            MonthView view = bi.Parent.Tag as MonthView;

            if (view != null)
                view.IsSideBarVisible = false;
        }


        #endregion

        #endregion

        #region InSideBarMouseUp

        /// <summary>
        /// Handles SideBar MouseUp events
        /// </summary>
        /// <param name="view">BaseView</param>
        private void InSideBarMouseUp(BaseView view)
        {
            InSideBarContextMenu.Tag = view;

            ShowContextMenu(InSideBarContextMenu);
        }

        #endregion

        #region InCondensedViewMouseUp

        /// <summary>
        /// Handles Mouse Up events in the CondensedView
        /// area of the control
        /// </summary>
        private void InCondensedViewMouseUp()
        {
            ShowContextMenu(CondensedViewContextMenu);
        }

        #endregion

        #endregion

        #region AppointmentViewMouseUp

        /// <summary>
        /// Handles AppointmentView MouseUp events
        /// </summary>
        /// <param name="sender">AppointmentView</param>
        private void AppointmentViewMouseUp(object sender)
        {
            AppointmentView view = sender as AppointmentView;

            // Select the appointment
            view.IsSelected = true;

            // Let the user delete the appointment
            AppDeleteContextItem.Enabled = (view.Appointment.IsRecurringInstance == false);
            AppointmentContextMenu.Tag = view;

            ShowContextMenu(AppointmentContextMenu);
        }

        #region miDelete_Click

        /// <summary>
        /// Handles BaseView "Delete Appointment" 
        /// ContextMenu selections
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void miDelete_Click(object sender, EventArgs e)
        {
            ButtonItem mi = sender as ButtonItem;
            AppointmentView view = mi.Parent.Tag as AppointmentView;

            if (view != null)
                calendarView1.CalendarModel.Appointments.Remove(view.Appointment);
        }

        #endregion

        #region Color item code

        void CategoryColor_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;
            AppointmentView view = bi.Parent.Tag as AppointmentView;

            if (view != null)
                view.Appointment.CategoryColor = bi.Text;
        }

        #endregion

        #region Marker item code

        void TimeMarker_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;
            AppointmentView view = bi.Parent.Tag as AppointmentView;

            if (view != null)
            {
                view.Appointment.TimeMarkedAs =
                    bi.Text.Equals("Default") ? null : bi.Text;
            }
        }

        #endregion

        #endregion

        #region AllDayPanelMouseUp

        /// <summary>
        /// Handles AllDayPanel MouseUp events
        /// </summary>
        /// <param name="sender">AllDayPanel</param>
        private void AllDayPanelMouseUp(object sender)
        {
            // Let the user Shrink and expand the panel
            // by 20 each time

            AllDayShrinkContextItem.Enabled = calendarView1.FixedAllDayPanelHeight == -1 ||
                calendarView1.FixedAllDayPanelHeight > 20;

            AllDayGrowContextItem.Enabled = calendarView1.FixedAllDayPanelHeight < 200;
            AllDayReset.Enabled = calendarView1.FixedAllDayPanelHeight != -1;
            AllDayPanelContextMenu.Tag = sender;

            ShowContextMenu(AllDayPanelContextMenu);
        }

        /// <summary>
        /// Handles "Shrink" ContextMenu selections
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void miShrink_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;
            AllDayPanel panel = bi.Parent.Tag as AllDayPanel;

            if (calendarView1.FixedAllDayPanelHeight == -1)
                calendarView1.FixedAllDayPanelHeight = panel.PanelHeight - 20;

            else
            {
                calendarView1.FixedAllDayPanelHeight =
                    Math.Max(20, calendarView1.FixedAllDayPanelHeight - 20);
            }
        }

        /// <summary>
        /// Handles "Grow" ContextMenu selections
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void miGrow_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;
            AllDayPanel panel = bi.Parent.Tag as AllDayPanel;

            if (calendarView1.FixedAllDayPanelHeight == -1)
                calendarView1.FixedAllDayPanelHeight = panel.PanelHeight + 20;

            else
            {
                calendarView1.FixedAllDayPanelHeight =
                    Math.Min(500, calendarView1.FixedAllDayPanelHeight + 20);
            }
        }

        /// <summary>
        /// Handles "Reset" ContextMenu selections
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void miReset_Click(object sender, EventArgs e)
        {
            calendarView1.FixedAllDayPanelHeight = -1;
        }

        #endregion

        #region TimeRulerPanelMouseUp

        /// <summary>
        /// Handles TimeRulerPanel MouseUp events
        /// </summary>
        private void TimeRulerPanelMouseUp()
        {
            ShowContextMenu(TimeRulerPanelContextMenu);
        }

        /// <summary>
        /// Handles "TimeSlotDuration" ContextMenu selections
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void miTimeDuration_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            int duration;

            if (int.TryParse(bi.Text, out duration) == true)
                calendarView1.TimeSlotDuration = duration;
        }

        #endregion

        #region TimeLineHeaderPanelMouseUp

        /// <summary>
        /// Handles Mouse Up events in the TimeLineHeaderPanel.
        /// 
        /// (The TimeLineHeaderPanel is the area at the top of the
        /// TimeLineView that holds the Period and Interval Headers.)
        /// </summary>
        /// <param name="sender">TimeLineHeaderPanel</param>
        /// <param name="e">MouseEventArgs</param>
        private void TimeLineHeaderPanelMouseUp(object sender, MouseEventArgs e)
        {
            TimeLineHeaderPanel tp = sender as TimeLineHeaderPanel;

            if (tp != null)
            {
                eViewArea area = tp.GetViewAreaFromPoint(e.Location);

                if (area == eViewArea.InPeriodHeader)
                    InPeriodHeaderMouseUp();

                else if (area == eViewArea.InIntervalHeader)
                    InIntervalHeaderMouseUp();
            }
        }

        #region InPeriodHeaderMouseUp

        /// <summary>
        /// Handles MouseUp events in the Period Header
        /// </summary>
        private void InPeriodHeaderMouseUp()
        {
            ShowContextMenu(PeriodHeaderContextMenu);
        }

        #endregion

        #region InPeriodHeaderHide_Click

        /// <summary>
        /// Handles Period Header "Hide" menu selections
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InPeriodHeaderHide_Click(object sender, EventArgs e)
        {
            calendarView1.TimeLineShowPeriodHeader = false;
        }

        #endregion

        #region PeriodHeaderContextMenu Period change

        /// <summary>
        /// Handles PeriodHeaderContextMenu "Minute" selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPeriodMinutes_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPeriodMinutes.Checked == true)
                calendarView1.TimeLinePeriod = eTimeLinePeriod.Minutes;
        }

        /// <summary>
        /// Handles PeriodHeaderContextMenu "Hours" selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPeriodHours_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPeriodHours.Checked == true)
                calendarView1.TimeLinePeriod = eTimeLinePeriod.Hours;
        }

        /// <summary>
        /// Handles PeriodHeaderContextMenu "Days" selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPeriodDays_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPeriodDays.Checked == true)
                calendarView1.TimeLinePeriod = eTimeLinePeriod.Days;
        }

        /// <summary>
        /// Handles PeriodHeaderContextMenu "Years" selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPeriodYears_CheckedChanged(object sender, EventArgs e)
        {
            if (btnPeriodYears.Checked == true)
                calendarView1.TimeLinePeriod = eTimeLinePeriod.Years;
        }

        #endregion

        #region InIntervalHeaderMouseUp

        /// <summary>
        /// Handles MouseUp events in the IntervalHeader
        /// </summary>
        private void InIntervalHeaderMouseUp()
        {
            // Get rid of any previously added non-essential items

            for (int i = IntervalHeaderContextMenu.SubItems.Count - 1; i > 2; i--)
                IntervalHeaderContextMenu.SubItems.RemoveAt(i);

            // If the Period Header is not visible, present the user
            // with the items to be able to re-show it

            lblPeriodHeader2.Visible =
                (calendarView1.TimeLineShowPeriodHeader == false);

            btnIntervalHeaderShow.Visible =
                (calendarView1.TimeLineShowPeriodHeader == false);

            // Add some Interval time selection options
            // for the current selected Interval Period

            switch (calendarView1.TimeLinePeriod)
            {
                case eTimeLinePeriod.Minutes:
                    AddIntervalMinutes();
                    break;

                case eTimeLinePeriod.Hours:
                    AddIntervalHours();
                    break;

                case eTimeLinePeriod.Days:
                    AddIntervalDays();
                    break;

                case eTimeLinePeriod.Years:
                    AddIntervalYears();
                    break;
            }

            ShowContextMenu(IntervalHeaderContextMenu);
        }

        #region Interval time support

        #region AddIntervalMinutes

        /// <summary>
        /// Adds Interval "Minute" items
        /// </summary>
        private void AddIntervalMinutes()
        {
            for (int i = 1; i <= 60; i++)
            {
                if (60 % i == 0)
                    AddIntervalItem(i);
            }
        }

        #endregion

        #region AddIntervalHours

        /// <summary>
        /// Adds Interval "Hour" items
        /// </summary>
        private void AddIntervalHours()
        {
            for (int i = 1; i <= 24; i++)
            {
                if (24 % i == 0)
                    AddIntervalItem(i);
            }
        }

        #endregion

        #region AddIntervalDays

        /// <summary>
        /// Adds Interval "Day" items
        /// </summary>
        private void AddIntervalDays()
        {
            for (int i = 1; i <= 10; i++)
                AddIntervalItem(i);

            for (int i = 30; i < 200; i += 30)
                AddIntervalItem(i);

            AddIntervalItem(365);
        }

        #endregion

        #region AddIntervalYears

        /// <summary>
        /// Adds Interval "Year" items
        /// </summary>
        private void AddIntervalYears()
        {
            for (int i = 1; i <= 10; i++)
                AddIntervalItem(i);
        }

        #endregion

        #region AddIntervalItem

        /// <summary>
        /// Adds individual Interval items
        /// </summary>
        /// <param name="i">Item to add</param>
        private void AddIntervalItem(int i)
        {
            ButtonItem bi = new ButtonItem("", i.ToString());

            bi.Click += BiIntervalClick;

            if (calendarView1.TimeLineInterval == i)
                bi.Checked = true;

            IntervalHeaderContextMenu.SubItems.Add(bi);
        }

        #endregion

        #region BiIntervalClick

        /// <summary>
        /// Handles Interval time selections
        /// </summary>
        /// <param name="sender">ButtonItem</param>
        /// <param name="e">EventArgs</param>
        private void BiIntervalClick(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            int n;

            if (int.TryParse(bi.Text, out n) == true)
                calendarView1.TimeLineInterval = n;
        }

        #endregion

        #endregion

        #region btnIntervalHeaderShow_Click

        /// <summary>
        /// Handles IntervalHeaderContextMenu "Show Header" selections
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIntervalHeaderShow_Click(object sender, EventArgs e)
        {
            calendarView1.TimeLineShowPeriodHeader = true;
        }
        #endregion

        #endregion

        #endregion

        #region CustomCalendarItemMouseUp

        /// <summary>
        /// Handles CustomUserItem MouseUp events
        /// </summary>
        /// <param name="sender">CustomCalendarItem</param>
        private void CustomCalendarItemMouseUp(object sender)
        {
            CustomCalendarItem item = sender as CustomCalendarItem;

            // Select the item
            item.IsSelected = true;

            // Let the user delete the appointment
            CustomItemContextMenu.Tag = item;

            ShowContextMenu(CustomItemContextMenu);
        }

        #region miItemDelete_Click

        /// <summary>
        /// Handles Deletion of CustomCalendarItem
        /// ContextMenu selections
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void miItemDelete_Click(object sender, EventArgs e)
        {
            ButtonItem mi = sender as ButtonItem;
            CustomCalendarItem item = mi.Parent.Tag as CustomCalendarItem;

            if (item != null)
                calendarView1.CustomItems.Remove(item);
        }

        #endregion

        #endregion

        #region ShowContextMenu

        /// <summary>
        /// Shows the given ContextMenu
        /// </summary>
        /// <param name="cm">ContextMenu to show</param>
        private void ShowContextMenu(ButtonItem cm)
        {
            cm.Popup(MousePosition);
        }

        #endregion

        #endregion

        #region CondensedViewContextMenu support

        /// <summary>
        /// Handles "AllResources" selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCondensedViewAll_Click(object sender, EventArgs e)
        {
            // AllResources - This selection enables Condensed
            // views to be displayed in every visible TimeLine
            // when Multiuser TimeLine views are displayed

            calendarView1.TimeLineCondensedViewVisibility
                = eCondensedViewVisibility.AllResources;
        }

        /// <summary>
        /// Handles "SelectedResource" selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCondensedViewSelected_Click(object sender, EventArgs e)
        {
            // SelectedResource - This selection enables Condensed
            // views to be displayed only in the currently selected
            // TimeLine view when Multiuser TimeLine views are displayed

            calendarView1.TimeLineCondensedViewVisibility
                = eCondensedViewVisibility.SelectedResource;
        }

        /// <summary>
        /// Handles "Hidden" selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCondensedViewHidden_Click(object sender, EventArgs e)
        {
            // Hidden - This selection disables all Condensed
            // views from being displayed

            calendarView1.TimeLineCondensedViewVisibility
                = eCondensedViewVisibility.Hidden;
        }

        #endregion

        #region btnToday_Click

        /// <summary>
        /// Sets the calendar view display to today's date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToday_Click(object sender, EventArgs e)
        {
            calendarView1.ShowDate(DateTime.Today);
        }

        #endregion

        #region btnNewAppointment_Click

        /// <summary>
        /// Adds a new appointment to the calendar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            // Get dates to add appointment to

            DateTime startDate, endDate;
            GetAddDates(out startDate, out endDate);

            // Create new appointment and add it to the model
            // Appointment will show up in the view automatically

            Appointment ap = AddNewAppointment(startDate, endDate);

            // Make sure the appointment is visible

            calendarView1.EnsureVisible(ap);
        }

        #endregion

        #region btnNewGlossyItem_Click

        /// <summary>
        /// Adds a new GlossyCustomItem to the calendar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewGlossyItem_Click(object sender, EventArgs e)
        {
            // Get dates to add item to

            DateTime startDate, endDate;
            GetAddDates(out startDate, out endDate);

            // Create new GlossyCustomItem and add it to the model.
            // Item will show up in the view automatically

            GlossyCustomItem item = new GlossyCustomItem();

            item.StartTime = startDate;
            item.EndTime = endDate;

            item.Text = "Custom GlossyItem - ID #" + _CustomUserId++;
            item.Tooltip = "User defined GlossyCustomItem!";

            calendarView1.CustomItems.Add(item);

            // Make sure it is visible

            calendarView1.EnsureVisible(item);
        }

        #endregion

        #region btnNewNoteItem_Click

        /// <summary>
        /// Adds a new NoteCustomItem to the calendar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewNoteItem_Click(object sender, EventArgs e)
        {
            // Get dates to add item to

            DateTime startDate, endDate;
            GetAddDates(out startDate, out endDate);

            // Create new NoteCustomItem and add it to the model.
            // Item will show up in the view automatically

            const string s = "This is an example of a CustomCalendarItem. " +
                             "It's sole purpose is to display this text on the Calendar.";

            NoteCustomItem item = new NoteCustomItem(s);

            item.StartTime = startDate;
            item.EndTime = endDate;

            item.Tooltip = "User defined Custom NoteItem - ID #" + _CustomUserId++;

            item.Image = this.imageList1.Images[0];

            calendarView1.CustomItems.Add(item);

            // Make sure the item is visible

            calendarView1.EnsureVisible(item);
        }

        #endregion

        #region btnNewButtonItem_Click

        /// <summary>
        /// Adds a new CustomItem #3 to the calendar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewButtonItem_Click(object sender, EventArgs e)
        {
            // Get dates to add item to

            DateTime startDate, endDate;
            GetAddDates(out startDate, out endDate);

            // Create new ButtonCustomItem and add it to the model.
            // Item will show up in the view automatically

            ButtonCustomItem item = new ButtonCustomItem(calendarView1);

            item.StartTime = startDate;
            item.EndTime = endDate;

            item.Text = "Custom ButtonItem - ID #" + _CustomUserId++;
            item.Tooltip = "User defined ButtonCustomItem!";

            calendarView1.CustomItems.Add(item);

            // Make sure the item is visible

            calendarView1.EnsureVisible(item);
        }

        #endregion

        #region GetAddDates

        /// <summary>
        /// Gets start and end addition dates
        /// </summary>
        /// <param name="startDate">[out]start date</param>
        /// <param name="endDate">[out]end date</param>
        private void GetAddDates(out DateTime startDate, out DateTime endDate)
        {
            if (calendarView1.DateSelectionStart.HasValue &&
                calendarView1.DateSelectionEnd.HasValue)
            {
                startDate = calendarView1.DateSelectionStart.Value;
                endDate = calendarView1.DateSelectionEnd.Value;
            }
            else
            {
                startDate = DateTime.Today.AddDays(3).AddHours(5);
                endDate = startDate.AddHours(2.5);
            }
        }

        #endregion

        #region labelItem1_MarkupLinkClick
        private void labelItem1_MarkupLinkClick(object sender, MarkupLinkClickEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.devcomponents.com/kb/questions.php?questionid=122&vs");
        }
        #endregion

        #region InContentAddGlossyItem_Click

        /// <summary>
        /// Adds a GlossyCustomItem to the calendar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InContentAddGlossyItem_Click(object sender, EventArgs e)
        {
            DateTime startDate = calendarView1.DateSelectionStart.GetValueOrDefault();
            DateTime endDate = calendarView1.DateSelectionEnd.GetValueOrDefault();

            GlossyCustomItem item = new GlossyCustomItem();

            item.StartTime = startDate;
            item.EndTime = endDate;

            item.Text = "Custom GlossyItem - ID #" + _CustomUserId++;
            item.Tooltip = "User defined " + item.Text;

            calendarView1.CustomItems.Add(item);
        }

        #endregion

        #region InContentAddNoteItem_Click

        /// <summary>
        /// Adds a NoteCustomItem to the calendar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InContentAddNoteItem_Click(object sender, EventArgs e)
        {
            DateTime startDate = calendarView1.DateSelectionStart.GetValueOrDefault();
            DateTime endDate = calendarView1.DateSelectionEnd.GetValueOrDefault();

            const string s = "This is an example of a CustomCalendarItem. " +
                             "It's sole purpose is to display this text on the Calendar.";

            NoteCustomItem item = new NoteCustomItem(s);

            item.StartTime = startDate;
            item.EndTime = endDate;

            item.Tooltip = "User defined Custom NoteItem - ID #" + _CustomUserId++;

            item.Image = this.imageList1.Images[0];

            calendarView1.CustomItems.Add(item);
        }

        #endregion

        #region InContentAddButtonItem_Click

        /// <summary>
        /// Adds a ButtonCustomItem to the calendar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InContentAddButtonItem_Click(object sender, EventArgs e)
        {
            DateTime startDate = calendarView1.DateSelectionStart.GetValueOrDefault();
            DateTime endDate = calendarView1.DateSelectionEnd.GetValueOrDefault();

            ButtonCustomItem item = new ButtonCustomItem(calendarView1);

            item.StartTime = startDate;
            item.EndTime = endDate;

            item.Text = "Custom ButtonItem - ID #" + _CustomUserId++;
            item.Tooltip = "User defined " + item.Text;

            calendarView1.CustomItems.Add(item);
        }

        #endregion

        #region SetAppColors1_Click

        /// <summary>
        /// Processes "Set Appointment Color #1" request.
        /// 
        /// This routine changes the Appointment colors by
        /// replacing the global AppointmentColor table
        /// with my local AppointmentColor table.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetAppColors1_Click(object sender, EventArgs e)
        {
            if (GlobalManager.Renderer is Office2007Renderer)
            {
                Office2007ColorTable ct =
                    ((Office2007Renderer)GlobalManager.Renderer).ColorTable;

                ct.CalendarView.AppointmentColors = _MyAppColorTable;

                calendarView1.Refresh();
            }
        }

        #endregion

        #region SetAppColors2_Click

        /// <summary>
        /// Processes "Set Appointment Color #2" request.
        /// 
        /// Though the effect is basically the same as done via
        /// setting the entire Appointment color table (as in SetAppColors1_Click),
        /// this routine does so by setting each Appointment color individually.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetAppColors2_Click(object sender, EventArgs e)
        {
            Office2007Renderer renderer = GlobalManager.Renderer as Office2007Renderer;

            if (renderer != null)
            {
                ColorDef[] ct = new ColorDef[Enum.GetValues(typeof(eAppointmentPart)).Length];

                ct[(int)eAppointmentPart.DefaultBorder] = new ColorDef(Color.Black);

                ct[(int)eAppointmentPart.DefaultBackground] = new ColorDef(
                    new Color[] { Color.White, Color.LightGray, Color.Gainsboro, Color.Black },
                    new float[] { 0f, .3f, .6f, 1f }, 45);

                ct[(int)eAppointmentPart.BlueBorder] = new ColorDef(Color.MidnightBlue);

                ct[(int)eAppointmentPart.BlueBackground] = new ColorDef(
                    new Color[] { Color.White, Color.LightBlue, Color.SkyBlue, Color.MidnightBlue },
                    new float[] { 0f, .3f, .6f, 1f }, 45);

                ct[(int)eAppointmentPart.OrangeBorder] = new ColorDef(Color.OrangeRed);

                ct[(int)eAppointmentPart.OrangeBackground] = new ColorDef(
                    new Color[] { Color.White, Color.DarkOrange, Color.Orange, Color.OrangeRed },
                    new float[] { 0f, .3f, .6f, 1f }, 45);

                ct[(int)eAppointmentPart.PurpleBorder] = new ColorDef(Color.Indigo);

                ct[(int)eAppointmentPart.PurpleBackground] = new ColorDef(
                    new Color[] { Color.White, Color.BlueViolet, Color.MediumPurple, Color.Indigo },
                    new float[] { 0f, .6f, .65f, 1f }, 45);

                ct[(int)eAppointmentPart.RedBorder] = new ColorDef(Color.Maroon);

                ct[(int)eAppointmentPart.RedBackground] = new ColorDef(
                    new Color[] { Color.White, Color.LightPink, Color.MistyRose, Color.Maroon },
                    new float[] { 0f, .3f, .6f, 1f }, 45);

                ct[(int)eAppointmentPart.GreenBorder] = new ColorDef(Color.DarkGreen);

                ct[(int)eAppointmentPart.GreenBackground] = new ColorDef(
                    new Color[] { Color.White, Color.LightGreen, Color.Chartreuse, Color.DarkGreen },
                    new float[] { 0f, .3f, .6f, 1f }, 45);

                ct[(int)eAppointmentPart.YellowBorder] = new ColorDef(Color.Black);

                ct[(int)eAppointmentPart.YellowBackground] = new ColorDef(
                    new Color[] { Color.White, Color.LightYellow, Color.LightGoldenrodYellow, Color.Yellow },
                    new float[] { 0f, .1f, .4f, 1f }, 45);

                ct[(int)eAppointmentPart.BusyTimeMarker] = new ColorDef(Color.Yellow);
                ct[(int)eAppointmentPart.FreeTimeMarker] = new ColorDef(-1);
                ct[(int)eAppointmentPart.OutOfOfficeTimeMarker] = new ColorDef(Color.White);

                renderer.ColorTable.CalendarView.AppointmentColors = ct;

                calendarView1.Refresh();
            }
        }

        #endregion

        #region SetCategoryColors_Click

        /// <summary>
        /// Processes "Set Appointment CategoryColors" request.
        /// 
        /// This routine establishes a set of user defined CategoryColors.
        /// User defined CategoryColors can be used in place of (or in addition to)
        /// the built-in Appointment.CategoryColor values.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetCategoryColors_Click(object sender, EventArgs e)
        {
            // If we haven't defined any CategoryColors, do so now

            if (calendarView1.CategoryColors.Count == 0)
            {
                // Create a new AppointmentCategoryColor and add
                // it to the CalendarView.CategoryColors

                ColorDef cdef = new ColorDef(
                    new int[] {0xFF7800, 0xE05600, 0xB53700},
                    new float[] {0f, .5f, 1f});

                AppointmentCategoryColor acc = new AppointmentCategoryColor(
                    "MyOrangeColor", Color.White, Color.DarkRed, cdef);

                calendarView1.CategoryColors.Add(acc);

                // Create a new AppointmentCategoryColor and use it to
                // redefine the current Appointment.CategoryYellow color set
                
                acc = new AppointmentCategoryColor(
                    "Yellow", Color.Black, Color.DarkGreen, new ColorDef(Color.Yellow, Color.YellowGreen));

                calendarView1.CategoryColors.Add(acc);

                // Go through our current appointments and set all CategoryOrange
                // appointments to use our newly defined MyOrangeColor CategoryColor

                for (int i = 0; i < calendarView1.CalendarModel.Appointments.Count; i++)
                {
                    if (calendarView1.CalendarModel.Appointments[i].CategoryColor == Appointment.CategoryOrange)
                        calendarView1.CalendarModel.Appointments[i].CategoryColor = "MyOrangeColor";
                }
            }
        }

        #endregion

        #region ResetAppColors_Click

        /// <summary>
        /// Resets the Appointment colors back to the Blue default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetAppColors_Click(object sender, EventArgs e)
        {
            // Get Office2007Renderer

            Office2007Renderer renderer = GlobalManager.Renderer as Office2007Renderer;

            if (renderer != null)
            {
                // Get Office2007ColorTable

                Office2007ColorTable ct =
                    new Office2007ColorTable(eOffice2007ColorScheme.Blue);

                renderer.ColorTable.CalendarView.AppointmentColors =
                    ct.CalendarView.AppointmentColors;

                calendarView1.Refresh();
            }

            // Go through our current appointments are reset all MyOrangeColor CategoryColor
            // settings back to their previous CategoryOrange settings

            for (int i = 0; i < calendarView1.CalendarModel.Appointments.Count; i++)
            {
                if (calendarView1.CalendarModel.Appointments[i].CategoryColor == "MyOrangeColor")
                    calendarView1.CalendarModel.Appointments[i].CategoryColor = Appointment.CategoryOrange;
            }

            // Clear our CategoryColors

            calendarView1.CategoryColors.Clear();
        }

        #endregion

        #region CycleViewColors_Click

        /// <summary>
        /// Sets the current View colors by cycling through a new
        /// RGB combination each time this routine is called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CycleViewColors_Click(object sender, EventArgs e)
        {
            if (GlobalManager.Renderer is Office2007Renderer)
            {
                Office2007ColorTable ct = ((Office2007Renderer)GlobalManager.Renderer).ColorTable;

                foreach (int val in Enum.GetValues(typeof(eCalendarWeekDayPart)))
                    SetNewScheme(ct.CalendarView.WeekDayViewColors[val].Colors);
                
                foreach (int val in Enum.GetValues(typeof(eCalendarMonthPart)))
                    SetNewScheme(ct.CalendarView.MonthViewColors[val].Colors);

                foreach (int val in Enum.GetValues(typeof(eTimeRulerPart)))
                    SetNewScheme(ct.CalendarView.TimeRulerColors[val].Colors);

                calendarView1.Refresh();

                _ColorCycle++;
            }
        }

        /// <summary>
        /// Sets new colors for the given color table
        /// </summary>
        /// <param name="colors">Color Table</param>
        private void SetNewScheme(Color[] colors)
        {
            // Loop through each color in the table

            for (int i = 0; i < colors.Length; i++)
                colors[i] = GetNewColor(colors[i]);
        }

        /// <summary>
        /// Gets a new RGB cycle color
        /// </summary>
        /// <param name="color">Current color</param>
        /// <returns>New cycled color</returns>
        private Color GetNewColor(Color color)
        {
            if ((_ColorCycle & 1) == 0)
                return (Color.FromArgb(color.R, color.B, color.G));

            return (Color.FromArgb(color.G, color.R, color.B));
        }

        #endregion

        #region ResetViewColors_Click

        /// <summary>
        /// Reset the View colors back to the Blue default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetViewColors_Click(object sender, EventArgs e)
        {
            // Get Office2007Renderer

            Office2007Renderer renderer = GlobalManager.Renderer as Office2007Renderer;

            if (renderer != null)
            {
                // Get Office2007ColorTable

                Office2007ColorTable ct = new Office2007ColorTable(eOffice2007ColorScheme.Blue);

                renderer.ColorTable.CalendarView.WeekDayViewColors =
                    ct.CalendarView.WeekDayViewColors;

                renderer.ColorTable.CalendarView.MonthViewColors =
                    ct.CalendarView.MonthViewColors;

                renderer.ColorTable.CalendarView.TimeRulerColors =
                    ct.CalendarView.TimeRulerColors;

                calendarView1.Refresh();
            }
        }

        #endregion

    }
}