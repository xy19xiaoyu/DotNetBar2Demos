using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar.Schedule;
using DevComponents.DotNetBar;
using DevComponents.Schedule.Model;

namespace ScheduleTestProject
{
    public partial class Form1 : Office2007Form
    {
        #region Private variables

        private bool _UserStyleSet;

        #endregion

        public Form1()
        {
            InitializeComponent();

            // Set our Calendar Model

            calendarView1.CalendarModel = new CalendarModel();

            // And add some sample appointments

            AddSampleAppointments();
            AddHolidaySchedule();

            // Hook onto the following events so we can be receive
            // appointment StartTime and Reminder notifications

            calendarView1.AppointmentReminder += AppointmentReminder;
            calendarView1.AppointmentStartTimeReached += AppointmentStartTimeReached;

            // Uncomment out the following lines of code it you want to
            // see appointment move and resize events as they are processed

            //calendarView1.CalendarModel.AppointmentAdded += new AppointmentEventHandler(ModelAppointmentAdded);
            //calendarView1.CalendarModel.AppointmentRemoved += new AppointmentEventHandler(ModelAppointmentRemoved);
            //calendarView1.AppointmentViewChanged += new EventHandler<AppointmentViewChangedEventArgs>(AppointmentViewChanged);
        }

        #region Handled events

        /// <summary>
        /// Event sent when an appointment is added to the Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ModelAppointmentAdded(object sender, AppointmentEventArgs e)
        {
            Console.WriteLine(@"{0} New Appointment Added. Appointment Subject: {1}",
                DateTime.Now, e.Appointment.Subject);
        }

        /// <summary>
        /// Event sent when an appointment is removed from the Model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ModelAppointmentRemoved(object sender, AppointmentEventArgs e)
        {
            Console.WriteLine(@"{0} Appointment Removed. Appointment Subject: {1}",
                DateTime.Now, e.Appointment.Subject);
        }

        /// <summary>
        /// Event sent when an appointment is either moved or resized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AppointmentViewChanged(object sender, AppointmentViewChangedEventArgs e)
        {
            AppointmentView view = e.CalendarItem as AppointmentView;

            if (view != null)
            {
                string sOperation = (e.eViewOperation == eViewOperation.AppointmentMove)
                    ? "Moved" : "Resized";

                Console.WriteLine(@"{0} Appointment {1}. Appointment Subject: {2}",
                    DateTime.Now, sOperation, view.Appointment.Subject);
            }
        }

        /// <summary>
        /// Event sent when an appointment reminder is reached
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AppointmentReminder(object sender, ReminderEventArgs e)
        {
            string s = string.Format(
                "Appointment Reminder reached for Appointment: '{0}'",
                e.Reminder.Appointment.Subject);
            
            MessageBox.Show(s);
        }

        /// <summary>
        /// Event sent when an appointment StartTime is reached
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AppointmentStartTimeReached(object sender, AppointmentEventArgs e)
        {
            string s = string.Format(
                "Appointment StartTime Reached for Appointment: '{0}'",
                e.Appointment.Subject);

            MessageBox.Show(s);
        }

        #endregion

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

            // Set recurrence type to Daily

            appointment.Recurrence = new AppointmentRecurrence();

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

        #region AddHolidaySchedule

        /// <summary>
        /// Adds our Holiday schedule, starting January 1, 2010
        /// and continuing for the next 10 years
        /// </summary>
        private void AddHolidaySchedule()
        {
            AddHoliday("New Years Day", 1, 1);
            AddHoliday("Martin Luther King Jr Day", 1, eRelativeDayInMonth.Third, DayOfWeek.Monday);
            AddHoliday("Groundhog Day", 2, 2);
            AddHoliday("Valentines Day", 2, 14);
            AddHoliday("Presidents Day", 2, eRelativeDayInMonth.Third, DayOfWeek.Monday);
            AddHoliday("St. Patricks Day", 3, 17);
            AddHoliday("April Fools Day", 4, 1);
            AddHoliday("Earth Day", 4, 22);
            AddHoliday("Cinco de Mayo", 5, 5);
            AddHoliday("Mothers Day", 5, eRelativeDayInMonth.Second, DayOfWeek.Saturday);
            AddHoliday("Memorial Day", 5, eRelativeDayInMonth.Last, DayOfWeek.Monday);
            AddHoliday("Flag Day", 6, 14);
            AddHoliday("Fathers Day", 6, eRelativeDayInMonth.Third, DayOfWeek.Sunday);
            AddHoliday("Independence Day", 7, 4);
            AddHoliday("Labor Day", 9, eRelativeDayInMonth.First, DayOfWeek.Monday);
            AddHoliday("Columbus Day", 10, eRelativeDayInMonth.Second, DayOfWeek.Monday);
            AddHoliday("Halloween", 10, 31);
            AddHoliday("Veterans Day", 11, 11);
            AddHoliday("Thanksgiving", 11, eRelativeDayInMonth.Fourth, DayOfWeek.Thursday);
            AddHoliday("Christmas", 12, 25);
            AddHoliday("New Years Eve", 12, 31);

            // Add Easter

            AddEaster();
        }

        #region AddHoliday

        /// <summary>
        /// Adds the given "Absolute" Holiday to the calendar
        /// </summary>
        /// <param name="title">Holiday title</param>
        /// <param name="month">Month</param>
        /// <param name="day">Day</param>
        private void AddHoliday(string title, int month, int day)
        {
            Appointment appointment =
                NewHoliday(title, new DateTime(2010, month, day));

            appointment.Recurrence.Yearly.RepeatOnMonth = month;
            appointment.Recurrence.Yearly.RepeatOnDayOfMonth = day;

            // Add appointment to the model

            calendarView1.CalendarModel.Appointments.Add(appointment);
        }

        /// <summary>
        /// Adds the given "Relative" Holiday to the calendar
        /// </summary>
        /// <param name="title">Holiday title</param>
        /// <param name="month">Month</param>
        /// <param name="dim">Day in Month</param>
        /// <param name="dow">Day of Week</param>
        private void AddHoliday(string title, int month, eRelativeDayInMonth dim, DayOfWeek dow)
        {
            Appointment appointment =
                NewHoliday(title, RelativeDate(month, dim, dow));

            appointment.Recurrence.Yearly.RepeatOnMonth = month;
            appointment.Recurrence.Yearly.RelativeDayOfWeek = dow;
            appointment.Recurrence.Yearly.RepeatOnRelativeDayInMonth = dim;
            appointment.Recurrence.Yearly.RepeatOnDayOfMonth = 0;

            // Add appointment to the model

            calendarView1.CalendarModel.Appointments.Add(appointment);
        }

        #endregion

        #region RelativeDate

        /// <summary>
        /// Calculates the date from the given
        /// relative day in the month and day of the week
        /// </summary>
        /// <param name="month">Month</param>
        /// <param name="dim">Day in Month</param>
        /// <param name="dow">Day of Week</param>
        /// <returns>Date</returns>
        private DateTime RelativeDate(int month, eRelativeDayInMonth dim, DayOfWeek dow)
        {
            DateTime date = new DateTime(2010, month, 1);

            while (date.DayOfWeek != dow)
                date = date.AddDays(1);

            switch (dim)
            {
                case eRelativeDayInMonth.First:
                    return (date);

                case eRelativeDayInMonth.Second:
                    return (date.AddDays(7));

                case eRelativeDayInMonth.Third:
                    return (date.AddDays(14));

                case eRelativeDayInMonth.Fourth:
                    return (date.AddDays(21));
            }

            return (date);
        }

        #endregion

        #region NewHoliday

        /// <summary>
        /// Allocates a new Holiday appointment
        /// </summary>
        /// <param name="title">Holiday title</param>
        /// <param name="startTime">Start time</param>
        /// <returns>Allocated appointment</returns>
        private Appointment NewHoliday(string title, DateTime startTime)
        {
            // Allocate a new Appointment

            Appointment appointment = new Appointment();

            appointment.Subject = title;
            appointment.CategoryColor = Appointment.CategoryRed;
            appointment.TimeMarkedAs = Appointment.TimerMarkerFree;
            appointment.Locked = true;

            appointment.StartTime = startTime;
            appointment.EndTime = startTime.AddDays(1);

            // Allocate a new AppointmentRecurrence

            appointment.Recurrence = new AppointmentRecurrence();

            appointment.Recurrence.RecurrenceType = eRecurrencePatternType.Yearly;
            appointment.Recurrence.RangeLimitType = eRecurrenceRangeLimitType.RangeEndDate;
            appointment.Recurrence.RangeEndDate = DateTime.Today.AddYears(10);

            return (appointment);
        }

        #endregion

        #region AddEaster

        /// <summary>
        /// Add Easter appointments for the next 10 years
        /// </summary>
        private void AddEaster()
        {
            // Add 10 years worth of dates

            for (int i = 2010; i < 2020; i++)
            {
                DateTime date = EasterDate(i);

                // Add Easter

                Appointment appointment = new Appointment();

                appointment.StartTime = date;
                appointment.EndTime = appointment.StartTime.AddDays(1);

                appointment.Subject = "Easter";
                appointment.OwnerKey = "Fred";
                appointment.CategoryColor = Appointment.CategoryRed;
                appointment.TimeMarkedAs = Appointment.TimerMarkerFree;
                appointment.Locked = true;

                calendarView1.CalendarModel.Appointments.Add(appointment);

                // Add Good Friday

                appointment = new Appointment();

                appointment.StartTime = date.AddDays(-2);
                appointment.EndTime = appointment.StartTime.AddDays(1);

                appointment.Subject = "Good Friday";
                appointment.OwnerKey = "Fred";
                appointment.CategoryColor = Appointment.CategoryRed;
                appointment.TimeMarkedAs = Appointment.TimerMarkerFree;
                appointment.Locked = true;

                calendarView1.CalendarModel.Appointments.Add(appointment);
            }
        }

        #region EasterDate

        /// <summary>
        /// Gets the Date for Easter for the given year
        /// </summary>
        /// <param name="year">Year</param>
        /// <returns>Easter date</returns>
        private DateTime EasterDate(int year)
        {
            int g = year % 19;
            int c = year / 100;
            int h = (c - c / 4 - (8 * c + 13) / 25 + 19 * g + 15) % 30;
            int i = h - h / 28 * (1 - h / 28 * (29 / (h + 1)) * ((21 - g) / 11));

            int day = i - ((year + year / 4 + i + 2 - c + c / 4) % 7) + 28;
            int month = 3;

            if (day > 31)
            {
                month++;

                day -= 31;
            }

            return (new DateTime(year, month, day));
        }

        #endregion

        #endregion

        #endregion

        #region View change

        /// <summary>
        /// Day view selection
        /// </summary>
        /// <param name="sender">PopupItem</param>
        /// <param name="e">EventArgs</param>
        private void BtnDayClick(object sender, EventArgs e)
        {
            calendarView1.SelectedView = eCalendarView.Day;
        }

        /// <summary>
        /// Week view selection
        /// </summary>
        /// <param name="sender">PopupItem</param>
        /// <param name="e">EventArgs</param>
        private void BtnWeekClick(object sender, EventArgs e)
        {
            calendarView1.SelectedView = eCalendarView.Week;
        }

        /// <summary>
        /// Month view selection
        /// </summary>
        /// <param name="sender">PopupItem</param>
        /// <param name="e">EventArgs</param>
        private void BtnMonthClick(object sender, EventArgs e)
        {
            calendarView1.SelectedView = eCalendarView.Month;
        }

        /// <summary>
        /// Year view selection
        /// </summary>
        /// <param name="sender">PopupItem</param>
        /// <param name="e">EventArgs</param>
        private void BtnYearClick(object sender, EventArgs e)
        {
            calendarView1.SelectedView = eCalendarView.Year;
        }

        /// <summary>
        /// TimeLine view selection
        /// </summary>
        /// <param name="sender">PopupItem</param>
        /// <param name="e">EventArgs</param>
        private void BtnTimeLineClick(object sender, EventArgs e)
        {
            calendarView1.SelectedView = eCalendarView.TimeLine;
        }

        #endregion

        #region CalendarView1ItemDoubleClick

        /// <summary>
        /// Handles Appointment View double clicks
        /// </summary>
        /// <param name="sender">AppointmentView</param>
        /// <param name="e">MouseEventArgs</param>
        private void CalendarView1ItemDoubleClick(object sender, MouseEventArgs e)
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

        #region CalendarView1MouseUp

        /// <summary>
        /// Handles CalendarView MouseUp events
        /// </summary>
        /// <param name="sender">Varied sender</param>
        /// <param name="e">MouseEventArgs</param>
        private void CalendarView1MouseUp(object sender, MouseEventArgs e)
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
            }
        }

        #region BaseViewMouseUp

        /// <summary>
        /// Handles Day, Week, Month, Year, and TimeLine View MouseUp events
        /// </summary>
        /// <param name="sender">BaseView</param>
        /// <param name="e">MouseEventArgs</param>
        private void BaseViewMouseUp(object sender, MouseEventArgs e)
        {
            BaseView view = sender as BaseView;

            if (view != null)
            {
                eViewArea area = view.GetViewAreaFromPoint(e.Location);

                switch (area)
                {
                    case eViewArea.InContent:
                        InContentMouseUp(view, e);
                        break;

                    case eViewArea.InDayOfWeekHeader:
                        InDayOfWeekHeaderMouseUp(view);
                        break;

                    case eViewArea.InMonthHeader:
                        InMonthHeaderMouseUp(view);
                        break;

                    case eViewArea.InSideBarPanel:
                        InSideBarMouseUp(view);
                        break;

                    case eViewArea.InCondensedView:
                        InCondensedViewMouseUp();
                        break;
                }
            }
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

            for (int i = InContentContextMenu.SubItems.Count - 1; i > 0; i--)
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

        #region MiAddClick

        /// <summary>
        /// Handles BaseView "Add Appointment" 
        /// ContextMenu selections
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void MiAddClick(object sender, EventArgs e)
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

        #region InDayOfWeekHeaderMouseUp

        /// <summary>
        /// Handles BaseView InDayOfWeekHeader MouseUp events.
        /// </summary>
        /// <param name="view">BaseView</param>
        private void InDayOfWeekHeaderMouseUp(BaseView view)
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

        #region MiCalendarColorClick

        /// <summary>
        /// Handles selection of a ContextMenu color item
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void MiCalendarColorClick(object sender, EventArgs e)
        {
            ButtonItem mi = sender as ButtonItem;

            if (mi != null)
            {
                BaseView view = mi.Parent.Tag as BaseView;

                if (view != null)
                    view.CalendarColor = (eCalendarColor)Enum.Parse(typeof(eCalendarColor), mi.Text);
            }
        }

        #endregion

        #region SideBar show/hide

        /// <summary>
        /// Handles ContextMenu "Show" for the SideBar panel
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void MiShowSideBarClick(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
            {
                MonthView view = bi.Parent.Tag as MonthView;

                if (view != null)
                    view.IsSideBarVisible = true;
            }
        }

        /// <summary>
        /// Handles ContextMenu "Hide" for the SideBar panel
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void MiHideSideBarClick(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
            {
                MonthView view = bi.Parent.Tag as MonthView;

                if (view != null)
                    view.IsSideBarVisible = false;
            }
        }


        #endregion

        #endregion

        #region InMonthHeaderMouseUp

        /// <summary>
        /// Handles BaseView InMonthHeader MouseUp events.
        /// </summary>
        /// <param name="view">BaseView</param>
        private void InMonthHeaderMouseUp(BaseView view)
        {
            if (view is YearView)
            {
                // The View is a Year view, so let the user
                // hide or show the Gridlines

                InMonthHeaderHideGridLinesContextItem.Visible = calendarView1.YearViewShowGridLines;
                InMonthHeaderShowGridLinesContextItem.Visible = !calendarView1.YearViewShowGridLines;
            }

            InMonthHeaderContextMenu.Tag = view;

            ShowContextMenu(InMonthHeaderContextMenu);
        }

        #region Gridlines show/hide

        /// <summary>
        /// Handles ContextMenu "Show GridLines" for the Year View
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void MiShowGridLinesClick(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
            {
                YearView view = bi.Parent.Tag as YearView;

                if (view != null)
                    calendarView1.YearViewShowGridLines = true;
            }
        }

        /// <summary>
        /// Handles ContextMenu "Hide GridLines" for the Year View
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void MiHideGridLinesClick(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
            {
                YearView view = bi.Parent.Tag as YearView;

                if (view != null)
                    calendarView1.YearViewShowGridLines = false;
            }
        }

        #endregion

        #region miCycleHighlight_Click

        /// <summary>
        /// Handles ContextMenu "Cycle Highlight" for the Year View.  This
        /// routine cycles through all the possible Day Link Highlight values
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void MiCycleHighlightClick(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
            {
                YearView view = bi.Parent.Tag as YearView;

                if (view != null)
                {
                    if (calendarView1.YearViewAppointmentLinkStyle == eYearViewLinkStyle.None)
                    {
                        if (_UserStyleSet == false)
                        {
                            _UserStyleSet = true;

                            calendarView1.YearViewDrawDayBackground += YearViewDrawDayBackground;

                            calendarView1.Refresh();
                        }
                        else
                        {
                            _UserStyleSet = false;

                            calendarView1.YearViewDrawDayBackground -= YearViewDrawDayBackground;

                            NextLinkStyle();
                        }
                    }
                    else
                    {
                        NextLinkStyle();
                    }
                }
            }
        }

        #endregion

        #region NextLinkStyle

        /// <summary>
        /// Sets the next available Link style
        /// </summary>
        private void NextLinkStyle()
        {
            eYearViewLinkStyle linkStyle = calendarView1.YearViewAppointmentLinkStyle;

            linkStyle++;

            if (linkStyle > eYearViewLinkStyle.Style5)
                linkStyle = eYearViewLinkStyle.None;

            calendarView1.YearViewAppointmentLinkStyle = linkStyle;
        }

        #endregion

        #region YearViewDrawDayBackground

        /// <summary>
        /// Draws the YearView day background
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void YearViewDrawDayBackground(object sender, YearViewDrawDayBackgroundEventArgs e)
        {
            if ((e.YearMonth.DayIsSelected(e.Date.Day) == false) &&
                (e.YearMonth.DayHasAppointments(e.Date.Day) == true))
            {
                Color color;

                switch (e.Date.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                    case DayOfWeek.Wednesday:
                    case DayOfWeek.Friday:
                        color = Color.Yellow;
                        break;

                    case DayOfWeek.Tuesday:
                    case DayOfWeek.Thursday:
                        color = Color.Coral;
                        break;

                    default:
                        color = Color.LightGreen;
                        break;
                }

                using (Brush br = new SolidBrush(color))
                    e.Graphics.FillRectangle(br, e.Bounds);

                e.Cancel = true;
            }
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

            if (view != null)
            {
                view.IsSelected = true;

                // Let the user delete the appointment

                AppDeleteContextItem.Enabled = (view.Appointment.IsRecurringInstance == false);
                AppointmentContextMenu.Tag = view;
            }

            ShowContextMenu(AppointmentContextMenu);
        }

        #region miDelete_Click

        /// <summary>
        /// Handles BaseView "Delete Appointment" 
        /// ContextMenu selections
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void MiDeleteClick(object sender, EventArgs e)
        {
            ButtonItem mi = sender as ButtonItem;

            if (mi != null)
            {
                AppointmentView view = mi.Parent.Tag as AppointmentView;

                if (view != null)
                    calendarView1.CalendarModel.Appointments.Remove(view.Appointment);
            }
        }

        #endregion

        #region Color item code

        void CategoryColor_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
            {
                AppointmentView view = bi.Parent.Tag as AppointmentView;

                if (view != null)
                    view.Appointment.CategoryColor = bi.Text;
            }
        }

        #endregion

        #region Marker item code
        void TimeMarker_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
            {
                AppointmentView view = bi.Parent.Tag as AppointmentView;

                if (view != null)
                {
                    view.Appointment.TimeMarkedAs =
                        bi.Text.Equals("Default") ? null : bi.Text;
                }
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
        void MiShrinkClick(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
            {
                AllDayPanel panel = bi.Parent.Tag as AllDayPanel;

                if (calendarView1.FixedAllDayPanelHeight == -1)
                {
                    if (panel != null)
                        calendarView1.FixedAllDayPanelHeight = panel.PanelHeight - 20;
                }
                else
                {
                    calendarView1.FixedAllDayPanelHeight =
                        Math.Max(20, calendarView1.FixedAllDayPanelHeight - 20);
                }
            }
        }

        /// <summary>
        /// Handles "Grow" ContextMenu selections
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void MiGrowClick(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
            {
                AllDayPanel panel = bi.Parent.Tag as AllDayPanel;

                if (calendarView1.FixedAllDayPanelHeight == -1)
                {
                    if (panel != null)
                        calendarView1.FixedAllDayPanelHeight = panel.PanelHeight + 20;
                }

                else
                {
                    calendarView1.FixedAllDayPanelHeight =
                        Math.Min(500, calendarView1.FixedAllDayPanelHeight + 20);
                }
            }
        }

        /// <summary>
        /// Handles "Reset" ContextMenu selections
        /// </summary>
        /// <param name="sender">MenuItem</param>
        /// <param name="e">EventArgs</param>
        void MiResetClick(object sender, EventArgs e)
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
        void MiTimeDurationClick(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
            {
                int duration;

                if (int.TryParse(bi.Text, out duration) == true)
                    calendarView1.TimeSlotDuration = duration;
            }
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
        private void BtnPeriodMinutesCheckedChanged(object sender, EventArgs e)
        {
            if (btnPeriodMinutes.Checked == true)
                calendarView1.TimeLinePeriod = eTimeLinePeriod.Minutes;
        }

        /// <summary>
        /// Handles PeriodHeaderContextMenu "Hours" selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPeriodHoursCheckedChanged(object sender, EventArgs e)
        {
            if (btnPeriodHours.Checked == true)
                calendarView1.TimeLinePeriod = eTimeLinePeriod.Hours;
        }

        /// <summary>
        /// Handles PeriodHeaderContextMenu "Days" selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPeriodDaysCheckedChanged(object sender, EventArgs e)
        {
            if (btnPeriodDays.Checked == true)
                calendarView1.TimeLinePeriod = eTimeLinePeriod.Days;
        }

        /// <summary>
        /// Handles PeriodHeaderContextMenu "Years" selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPeriodYearsCheckedChanged(object sender, EventArgs e)
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

        #region bi_IntervalClick

        /// <summary>
        /// Handles Interval time selections
        /// </summary>
        /// <param name="sender">ButtonItem</param>
        /// <param name="e">EventArgs</param>
        private void BiIntervalClick(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
            {
                int n;

                if (int.TryParse(bi.Text, out n) == true)
                    calendarView1.TimeLineInterval = n;
            }
        }

        #endregion

        #endregion

        #region btnIntervalHeaderShow_Click

        /// <summary>
        /// Handles IntervalHeaderContextMenu "Show Header" selections
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIntervalHeaderShowClick(object sender, EventArgs e)
        {
            calendarView1.TimeLineShowPeriodHeader = true;
        }

        #endregion

        #endregion

        #endregion

        #region ShowContextMenu

        /// <summary>
        /// Shows the given ContextMenu
        /// </summary>
        /// <param name="cm">ContextMenu to show</param>
        private void ShowContextMenu(ButtonItem cm)
        {
            Point pt = MousePosition;
            cm.Popup(pt);
        }

        #endregion

        #endregion

        #region CalendarView1SelectedViewChanged

        /// <summary>
        /// Processes CalendarView SelectedViewChanged events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalendarView1SelectedViewChanged(object sender, SelectedViewEventArgs e)
        {
            switch (e.NewValue)
            {
                case eCalendarView.Day:
                    btnDay.Checked = true;
                    break;

                case eCalendarView.Week:
                    btnWeek.Checked = true;
                    break;

                case eCalendarView.Month:
                    btnMonth.Checked = true;
                    break;

                case eCalendarView.Year:
                    btnYear.Checked = true;
                    break;

                case eCalendarView.TimeLine:
                    btnTimeLine.Checked = true;
                    break;
            }
        }

        #endregion

        #region CondensedViewContextMenu support

        /// <summary>
        /// Handles "AllResources" selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCondensedViewAllClick(object sender, EventArgs e)
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
        private void BtnCondensedViewSelectedClick(object sender, EventArgs e)
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
        private void BtnCondensedViewHiddenClick(object sender, EventArgs e)
        {
            // Hidden - This selection disables all Condensed
            // views from being displayed

            calendarView1.TimeLineCondensedViewVisibility
                = eCondensedViewVisibility.Hidden;
        }

        #endregion

        #region Color Scheme Selection

        /// <summary>
        /// Selects the Office2007Blue color scheme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Office2007Blue_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2007Blue;
        }

        /// <summary>
        /// Selects the Office2007Silver color scheme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Office2007Silver_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2007Silver;
        }

        /// <summary>
        /// Selects the Office2007Black color scheme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Office2007Black_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2007Black;
        }

        /// <summary>
        /// Selects the Office2007VistaGlass color scheme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Office2007VistaGlass_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2007VistaGlass;
        }

        /// <summary>
        /// Selects the Office2010Blue color scheme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Office2010Blue_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2010Blue;
        }

        /// <summary>
        /// Selects the Office2010Silver color scheme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Office2010Silver_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2010Silver;
        }

        /// <summary>
        /// Selects the Windows7Blue color scheme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Windows7Blue_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Windows7Blue;
        }

        #endregion

        #region BtnTodayClick

        /// <summary>
        /// Sets the calendar view display to today's date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTodayClick(object sender, EventArgs e)
        {
            calendarView1.ShowDate(DateTime.Today);
        }

        #endregion

        #region BtnNewAppointmentClick

        /// <summary>
        /// Adds a new appointment to the calendar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNewAppointmentClick(object sender, EventArgs e)
        {
            // Create new appointment and add it to the model
            // Appointment will show up in the view automatically

            DateTime startDate = DateTime.Today.AddDays(3).AddHours(5);
            DateTime endDate = startDate.AddHours(2.5);

            if (calendarView1.DateSelectionStart.HasValue &&
                calendarView1.DateSelectionEnd.HasValue)
            {
                startDate = calendarView1.DateSelectionStart.Value;
                endDate = calendarView1.DateSelectionEnd.Value;
            }

            Appointment ap = AddNewAppointment(startDate, endDate);

            // Make sure the appointment is visible

            calendarView1.EnsureVisible(ap);
        }

        #endregion

        #region BtnNewAllDayClick

        /// <summary>
        /// Adds a new All Day event to the calendar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNewAllDayClick(object sender, EventArgs e)
        {
            // All day or multi-day appointments simply have longer duration

            Appointment appointment = new Appointment();

            appointment.Subject = "All Day Event Appointment";
            appointment.StartTime = DateTime.Today;
            appointment.EndTime = appointment.StartTime.AddDays(1);
            appointment.CategoryColor = Appointment.CategoryYellow;

            // Add appointment to the model and
            // make sure it is visible

            calendarView1.CalendarModel.Appointments.Add(appointment);
            calendarView1.EnsureVisible(appointment);
        }

        #endregion

        #region BtnNewMultiDayClick

        /// <summary>
        /// Adds a new Multi-Day event to the calendar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNewMultiDayClick(object sender, EventArgs e)
        {
            // Multi-day appointment

            Appointment appointment = new Appointment();

            appointment.Subject = "Multiple Days Appointment";
            appointment.StartTime = DateTime.Today;
            appointment.EndTime = appointment.StartTime.AddDays(2.5);

            // Add appointment to the model and
            // make sure it is visible

            calendarView1.CalendarModel.Appointments.Add(appointment);
            calendarView1.EnsureVisible(appointment);
        }

        #endregion

        #region BtnNewRecurringClick

        /// <summary>
        /// Adds a new recurring appointment to the calendar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNewRecurringClick(object sender, EventArgs e)
        {
            // Multi-day appointment

            Appointment appointment = new Appointment();

            appointment.Subject = "Recurring Appointment every 3rd week day";
            appointment.StartTime = DateTime.Today.AddHours(9);
            appointment.EndTime = appointment.StartTime.AddHours(1);
            appointment.Recurrence = new AppointmentRecurrence();
            appointment.TimeMarkedAs = Appointment.TimerMarkerOutOfOffice;
            appointment.CategoryColor = Appointment.CategoryOrange;

            // Set recurrence type to weekly
            appointment.Recurrence.RecurrenceType = eRecurrencePatternType.Daily;

            // Recurrence properties are changed then on respective object Daily, Weekly, Monthly, Yearly
            appointment.Recurrence.Daily.RepeatOnDaysOfWeek = eDailyRecurrenceRepeat.All;

            // Repeate every 3 days
            appointment.Recurrence.Daily.RepeatInterval = 3;

            // End recurrence 30 days from today
            appointment.Recurrence.RangeEndDate = DateTime.Today.AddDays(30);

            // Add appointment to the model and
            // make sure it is visible

            calendarView1.CalendarModel.Appointments.Add(appointment);
            calendarView1.EnsureVisible(appointment);
        }

        #endregion

        #region BtnNewReminderClick

        /// <summary>
        /// Adds a new appointment with a reminder in 2 minutes
        /// </summary>
        /// <param name="sender">btnNewReminder</param>
        /// <param name="e">EventArgs</param>
        private void BtnNewReminderClick(object sender, EventArgs e)
        {
            // Create new appointment with reminder in 2 minutes

            Appointment appointment = new Appointment();

            appointment.Subject = "Appointment with reminder";
            appointment.StartTime = DateTime.Now.AddHours(2);
            appointment.EndTime = appointment.StartTime.AddMinutes(30);

            appointment.CategoryColor = Appointment.CategoryRed;
            appointment.TimeMarkedAs = Appointment.TimerMarkerTentative;

            // Create new reminder and add it to Reminders collection
            appointment.Reminders.Add(new Reminder(DateTime.Now.AddMinutes(2)));

            // Add appointment to the model
            calendarView1.CalendarModel.Appointments.Add(appointment);

            // Make appointment visible in current view
            calendarView1.EnsureVisible(appointment);
        }

        #endregion

        #region BtnNewStartReachedClick

        /// <summary>
        /// Adds a new appointment with Start Notification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNewStartReachedClick(object sender, EventArgs e)
        {
            // Create new appointment with start time notification

            Appointment appointment = new Appointment();

            appointment.Subject = "Appointment with StartTimeReached Notification";
            appointment.StartTime = DateTime.Now.AddMinutes(2);
            appointment.EndTime = appointment.StartTime.AddHours(3);

            appointment.CategoryColor = Appointment.CategoryPurple;
            appointment.TimeMarkedAs = Appointment.TimerMarkerTentative;

            // Set our StartTimeAction to enable event notification
            appointment.StartTimeAction = eStartTimeAction.StartTimeReachedEvent;

            // Add appointment to the model
            calendarView1.CalendarModel.Appointments.Add(appointment);

            // Make appointment visible in current view
            calendarView1.EnsureVisible(appointment);
        }

        #endregion

        #region LabelItem1MarkupLinkClick

        private void LabelItem1MarkupLinkClick(object sender, MarkupLinkClickEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.devcomponents.com/kb/questions.php?questionid=122&vs");
        }

        #endregion

    }
}