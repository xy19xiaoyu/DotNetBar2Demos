using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Schedule;
using DevComponents.DotNetBar;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.Schedule.Model;
using System.Diagnostics;

namespace ScheduleTestProject
{
    public class ButtonCustomItem : CustomCalendarItem
    {
        #region Constants

        private const int _Radius = 20;         // Corner radius
        private const int _ResizeArea = 5;      // Resize area size

        #endregion

        #region Private variables

        private ButtonItem _Button;             // Added Button
        private CalendarView _CalendarView;     // Associated CalendarView

        private bool _BoundsChanged;            // Item was moved flag

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public ButtonCustomItem()
            : this(null)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="CalendarView">Associated CalendarView</param>
        public ButtonCustomItem(CalendarView CalendarView)
        {
            _CalendarView = CalendarView;

            // Lets add a simple Buttons to our item

            _Button = new ButtonItem();

            _Button.Text = "Goto CalendarItem";
            _Button.ColorTable = eButtonColor.BlueOrb;
            _Button.AutoExpandOnClick = false;
            _Button.Displayed = true;

            // Add a subItem placeholder so that the user has visual indication
            // that there are items present - though we will not actually load
            // the items until the "PopupOpen" event activation is fired

            _Button.SubItems.Add(new ButtonItem("", ""));

            SubItems.Add(_Button);

            // Hook onto our required events

            HookEvents(true);
        }

        #region Public properties

        #region Bounds

        /// <summary>
        /// Item Bounding rectangle
        /// </summary>
        public override Rectangle Bounds
        {
            get { return (base.Bounds); }

            set
            {
                if (Bounds.Equals(value) == false)
                {
                    base.Bounds = value;

                    // Keep our SubItems in-sync with the new
                    // item Bounds

                    UpdateSubBounds();

                    // Flag the fact that the item's bounds changed
                    // so that we don't present the SubItem popup
                    // on Bounds change

                    _BoundsChanged = true;
                }
            }
        }

        /// <summary>
        /// Updates our SubItem bounds
        /// </summary>
        private void UpdateSubBounds()
        {
            for (int i = 0; i < SubItems.Count; i++)
                SubItems[i].Bounds = Bounds;
        }

        #endregion

        #region Tooltip

        /// <summary>
        /// Gets or sets the control tooltip
        /// 
        /// We are overriding this property so that we can
        /// automatically keep our included Button's tooltip
        /// in-sync with our custom calendar item
        /// </summary>
        public override string Tooltip
        {
            get { return (base.Tooltip); }

            set
            {
                if (base.Tooltip.Equals(value) == false)
                {
                    base.Tooltip = value;

                    _Button.Tooltip = value;
                }
            }
        }

        #endregion

        #endregion

        #region HookEvents

        /// <summary>
        /// Hooks or unhooks system events
        /// </summary>
        /// <param name="hook">true to hook, false to unhook</param>
        private void HookEvents(bool hook)
        {
            if (hook == true)
            {
                _Button.PopupOpen += new DotNetBarManager.PopupOpenEventHandler(Button_PopupOpen);

                _Button.MouseDown += new MouseEventHandler(Button_MouseDown);
                _Button.MouseUp += new MouseEventHandler(Button_MouseUp);
            }
            else
            {
                _Button.PopupOpen -= new DotNetBarManager.PopupOpenEventHandler(Button_PopupOpen);

                _Button.MouseDown -= new MouseEventHandler(Button_MouseDown);
                _Button.MouseUp -= new MouseEventHandler(Button_MouseUp);
            }
        }

        #endregion

        #region Event processing

        #region Button_PopupOpen

        /// <summary>
        /// Processes Button PopupOpen events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Button_PopupOpen(object sender, PopupOpenEventArgs e)
        {
            // If the user has moved the item on the calendar, then
            // don't permit the associated popup to be displayed

            if (_BoundsChanged == false)
            {
                // Reload the popup with the current list
                // of Appointments and CustomItems

                if (_CalendarView != null)
                {
                    _Button.SubItems.Clear();

                    AddAppointments();
                    AddCustomItems();
                }
            }
        }

        #region AddAppointments

        /// <summary>
        /// Adds CalendarView Appointments to our list
        /// </summary>
        private void AddAppointments()
        {
            // Get the current list of Appointments

            AppointmentCollection apc =
                _CalendarView.CalendarModel.Appointments;

            // Loop through each appointment

            bool itemsAdded = false;

            for (int i = 0; i < apc.Count; i++)
            {
                // Check to see if the given appointment
                // is a valid one for this Owner

                if (_CalendarView.SelectedOwner == "" ||
                    apc[i].OwnerKey.Equals(_CalendarView.SelectedOwner))
                {
                    ButtonItem bi = new ButtonItem();

                    // If we haven't already done so, add a heading

                    if (itemsAdded == false)
                    {
                        itemsAdded = true;

                        bi.Text = "Appointments";
                        bi.ColorTable = eButtonColor.BlueOrb;
                        bi.Displayed = true;

                        _Button.SubItems.Add(bi);

                        bi = new ButtonItem();
                    }

                    // Add the appointment to the list

                    string s = String.Format(
                        "{0}<div padding=\"8,0,0,0\"><font Color=\"darkred\" size=\"-2\">{1}</font></div>",
                        apc[i].Subject, apc[i].StartTime);

                    bi.Text = s;
                    bi.BeginGroup = true;

                    bi.ColorTable = eButtonColor.Orange;
                    bi.Displayed = true;
                    bi.Tag = apc[i];

                    bi.Click += new EventHandler(App_Click);

                    _Button.SubItems.Add(bi);
                }
            }
        }

        #endregion

        #region AddCustomItems

        /// <summary>
        /// Adds CalendarView CustomItems to our list
        /// </summary>
        private void AddCustomItems()
        {
            // Get the current list of CustomItems

            CustomCalendarItemCollection cic = _CalendarView.CustomItems;

            // Loop through each appointment

            bool itemAdded = false;

            for (int i = 0; i < cic.Count; i++)
            {
                // Check to see if the given item
                // is a valid one for this Owner

                if (_CalendarView.SelectedOwner == "" ||
                    cic[i].OwnerKey.Equals(_CalendarView.SelectedOwner))
                {
                    ButtonItem bi = new ButtonItem();

                    // If we haven't already done so, add a heading

                    if (itemAdded == false)
                    {
                        itemAdded = true;

                        bi.Displayed = true;
                        bi.Text = "CustomItems";
                        bi.ColorTable = eButtonColor.BlueOrb;

                        _Button.SubItems.Add(bi);

                        bi = new ButtonItem();
                    }

                    // Add the item to the list

                    string s = String.Format(
                        "{0}<div padding=\"8,0,0,0\"><font Color=\"darkred\" size=\"-2\">{1}</font></div>",
                        cic[i].Text, cic[i].StartTime);

                    bi.Text = s;
                    bi.BeginGroup = true;

                    bi.Displayed = true;
                    bi.ColorTable = eButtonColor.Orange;
                    bi.Tag = cic[i];

                    bi.Click += new EventHandler(User_Click);

                    _Button.SubItems.Add(bi);
                }
            }
        }

        #endregion

        #endregion

        #region Button_MouseUp

        /// <summary>
        /// Processes Button MouseUp events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Button_MouseUp(object sender, MouseEventArgs e)
        {
            // If the left button is presses and the user hasn't moved
            // the item, then present the associated subItem popup

            if (e.Button == MouseButtons.Left && _BoundsChanged == false)
            {
                Control c = (Control)_CalendarView.GetContainerControl();

                if (c != null)
                {
                    Point pt = new
                        Point(_Button.Bounds.Left, _Button.Bounds.Bottom);

                    _Button.Popup(c.PointToScreen(pt));
                }
            }
        }

        #endregion

        #region Button_MouseDown

        /// <summary>
        /// Processes Button MouseDown events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Button_MouseDown(object sender, MouseEventArgs e)
        {
            // Clear our _BoundsChanged state flag

            _BoundsChanged = (_Button.PopupControl != null);
        }

        #endregion

        #endregion

        #region App_Click / User_Click

        /// <summary>
        /// Processes SubItem Appointment selection
        /// </summary>
        /// <param name="sender">ButtonItem</param>
        /// <param name="e">EventArgs</param>
        void App_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
            {
                Appointment app = bi.Tag as Appointment;

                // Move this item to the selected appointment StartTime

                if (app != null)
                    MoveItem(app.StartTime);
            }

            _Button.ClosePopup();
        }

        /// <summary>
        /// Processes SubItem CustomItem selection
        /// </summary>
        /// <param name="sender">ButtonItem</param>
        /// <param name="e">EventArgs</param>
        void User_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
            {
                CustomCalendarItem item = bi.Tag as CustomCalendarItem;

                // If the user selected a non-ButtonCustomItem, then
                // move this item to the selected appointment StartTime.
                //
                // If they selected another ButtonCustomItem then just
                // ensure it is visible

                if (item != null)
                {
                    if (item is ButtonCustomItem == false)
                        MoveItem(item.StartTime);
                    else
                        _CalendarView.EnsureVisible(item);
                }
            }

            _Button.ClosePopup();
        }

        /// <summary>
        /// Moves the given item to the specified startTime
        /// </summary>
        /// <param name="startTime">StartTime to move the item to</param>
        private void MoveItem(DateTime startTime)
        {
            TimeSpan ts = EndTime - StartTime;
            DateTime endTime = startTime.Add(ts);

            // Don't let our item cross day boundaries

            if (startTime.Day != endTime.Day)
            {
                startTime = startTime.Date;
                endTime = startTime.Add(ts);
            }

            _CalendarView.CustomItems.BeginUpdate();

            StartTime = startTime;
            EndTime = endTime;

            _CalendarView.CustomItems.EndUpdate();

            _CalendarView.EnsureVisible(this);
        }

        #endregion

        #region RecalcSize

        /// <summary>
        /// Recalculates the size of the item
        /// </summary>
        public override void RecalcSize()
        {
            base.RecalcSize();

            for (int i = 0; i < this.SubItems.Count; i++)
            {
                this.SubItems[i].WidthInternal = WidthInternal;
                this.SubItems[i].HeightInternal = HeightInternal;

                this.SubItems[i].RecalcSize();

                SubItems[i].Bounds = Bounds;
            }
        }

        #endregion

        #region Paint processing

        /// <summary>
        /// Initiates the Painting of the item
        /// </summary>
        /// <param name="e"></param>
        public override void Paint(ItemPaintArgs e)
        {
            Graphics g = e.Graphics;

            // Lets have it draw as best it can

            CompositingQuality comp = g.CompositingQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;

            DrawBorder(e);
            DrawContent(e);

            // Set our CompostingQuality back

            g.CompositingQuality = comp;
        }

        #region DrawBorder

        /// <summary>
        /// Draws the item border
        /// </summary>
        /// <param name="e">ItemPaintArgs</param>
        private void DrawBorder(ItemPaintArgs e)
        {
            Graphics g = e.Graphics;

            using (GraphicsPath path = GetItemPath(g, 0))
            {
                g.DrawPath(Pens.Black, path);
            }
        }

        #endregion

        #region DrawContent

        /// <summary>
        /// Draws the content area of the item
        /// </summary>
        /// <param name="g"></param>
        /// <param name="scheme"></param>
        private void DrawContent(ItemPaintArgs e)
        {
            Graphics g = e.Graphics;

            // Grab a path slightly inset from the border

            using (GraphicsPath gPath = GetItemPath(g, -1))
            {
                // Set up a new clip region for the item

                Region rgnSave = g.Clip;

                using (Region rgn = new Region(rgnSave.GetRegionData()))
                {
                    rgn.Intersect(gPath);
                    g.Clip = rgn;

                    // Now let all our added SubItems draw themselves

                    for (int i = 0; i < this.SubItems.Count; i++)
                    {
                        if (SubItems[i].Displayed == true)
                            SubItems[i].Paint(e);
                    }
                }

                // Restore our original clip region

                g.Clip = rgnSave;

                // Draw a contrast border around the item

                g.DrawPath(Pens.White, gPath);
            }
        }

        #endregion

        #region GetItemPath

        /// <summary>
        /// Gets a path defining the item
        /// </summary>
        /// <param name="g">Graphics</param>
        /// <param name="delta">Inset amount</param>
        /// <returns></returns>
        private GraphicsPath GetItemPath(Graphics g, int inset)
        {
            GraphicsPath path = new GraphicsPath();

            Rectangle r = Bounds;
            r.Inflate(inset, inset);

            Rectangle ar = new
                Rectangle(r.Right - _Radius, r.Bottom - _Radius, _Radius, _Radius);

            path.AddArc(ar, 0, 90);

            ar.X = r.X;
            path.AddArc(ar, 90, 90);

            ar.Y = r.Y;
            path.AddArc(ar, 180, 90);

            ar.X = r.Right - _Radius;
            path.AddArc(ar, 270, 90);

            path.CloseAllFigures();

            return (path);
        }

        #endregion

        #endregion

        #region Mouse support

        #region MouseMove

        /// <summary>
        /// Process MouseMove events
        /// </summary>
        /// <param name="objArg"></param>
        public override void InternalMouseMove(MouseEventArgs objArg)
        {
            // Tell the system what area the mouse
            // just passed over

            this.HitArea = GetHitArea(objArg);

            // And pass the event on

            base.InternalMouseMove(objArg);
        }

        #region GetHitArea

        /// <summary>
        /// Gets the 'HitArea' for the item
        /// </summary>
        /// <param name="objArg"></param>
        /// <returns>eHitArea (move, resize, etc)</returns>
        private eHitArea GetHitArea(MouseEventArgs objArg)
        {
            // WeekDayView item

            WeekDayView wv = this.Parent as WeekDayView;

            if (wv != null)
                return (GetWeekDayHitArea(objArg));

            // MonthView item

            MonthView mv = this.Parent as MonthView;

            if (mv != null)
                return (GetMonthHitArea(mv, objArg));

            // TimeLineView item

            TimeLineView tv = this.Parent as TimeLineView;

            if (tv != null)
                return (GetTimeLineHitArea(objArg));

            // Nowhere we recognize

            return (eHitArea.None);
        }

        #region GetWeekDayHitArea

        /// <summary>
        /// Gets the HitArea for WeekDayView items
        /// </summary>
        /// <param name="objArg"></param>
        /// <returns>eHitArea</returns>
        private eHitArea GetWeekDayHitArea(MouseEventArgs objArg)
        {
            // See if we are in the top resize area

            if (objArg.Location.Y < Bounds.Y + _ResizeArea)
                return (eHitArea.TopResize);

            // See if we are in the bottom resize area

            if (objArg.Location.Y > Bounds.Bottom - _ResizeArea)
                return (eHitArea.BottomResize);

            // Don't permit move when over the expand arrow

            if (_Button.IsMouseOverExpand == true)
                return (eHitArea.None);

            // By default we are in the move area

            return (eHitArea.Move);
        }

        #endregion

        #region GetMonthHitArea

        /// <summary>
        /// Gets the HitArea for MonthView items
        /// </summary>
        /// <param name="mv"></param>
        /// <param name="objArg"></param>
        /// <returns>eHitArea</returns>
        private eHitArea GetMonthHitArea(MonthView mv, MouseEventArgs objArg)
        {
            // Get what week this item is in, so we can
            // determine whether the item extends into either
            // the next or previous weeks

            MonthWeek monthWeek = mv.GetItemWeek(this);

            DateTime start = monthWeek.FirstDayOfWeek;
            DateTime end = start.AddDays(7);

            // See if we are in the left resize area

            if (StartTime >= start && objArg.Location.X < Bounds.X + _ResizeArea)
                return (eHitArea.LeftResize);

            // See if we are in the right resize area

            if (EndTime <= end && objArg.Location.X > Bounds.Right - _ResizeArea)
                return (eHitArea.RightResize);

            // By default we are in the move area

            return (eHitArea.Move);
        }

        #endregion

        #region GetTimeLineHitArea

        /// <summary>
        /// Gets the HitArea for TimeLineView items
        /// </summary>
        /// <param name="objArg"></param>
        /// <returns>eHitArea</returns>
        private eHitArea GetTimeLineHitArea(MouseEventArgs objArg)
        {
            // See if we are in the left resize area

            if (objArg.Location.X < Bounds.X + _ResizeArea)
                return (eHitArea.LeftResize);

            // See if we are in the right resize area

            if (objArg.Location.X > Bounds.Right - _ResizeArea)
                return (eHitArea.RightResize);

            // By default we are in the move area

            return (eHitArea.Move);
        }

        #endregion

        #endregion

        #endregion

        #endregion

        #region Copy Object

        /// <summary>
        /// Returns copy of the item.
        /// 
        /// This routine is called to propagate the item
        /// within each view (both in the same view as well as
        /// across multiple views in multi-user displays)
        /// </summary>
        public override BaseItem Copy()
        {
            ButtonCustomItem objCopy = new ButtonCustomItem();
            CopyToItem(objCopy);

            return (objCopy);
        }

        /// <summary>
        /// Copies the CustomCalendarItem specific properties
        /// to new instance of the item
        /// </summary>
        /// <param name="copy">New CustomCalendarItem instance</param>
        protected override void CopyToItem(BaseItem copy)
        {
            ButtonCustomItem objCopy = copy as ButtonCustomItem;
            base.CopyToItem(objCopy);

            objCopy._CalendarView = _CalendarView;
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes of the item
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            HookEvents(false);

            base.Dispose(disposing);
        }

        #endregion
    }
}
