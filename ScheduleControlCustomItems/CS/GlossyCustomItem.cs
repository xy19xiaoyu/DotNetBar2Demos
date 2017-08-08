using System;
using DevComponents.DotNetBar.Schedule;
using DevComponents.DotNetBar;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace ScheduleTestProject
{
    public class GlossyCustomItem : CustomCalendarItem
    {
        #region Constants

        private const int Radius = 20;         // Corner radius
        private const int ResizeArea = 5;      // Resize area size
        
        #endregion

        #region Private class definitions

        /// <summary>
        /// Local Item Color scheme
        /// </summary>
        private class ItemColorScheme
        {
            public Brush BackBrush;
            public Color BackColor;
            public Color BackLitColor1;
            public Color BackLitColor2;

            public ItemColorScheme(Brush backBrush, Color backColor,
                Color backLitColor1, Color backLitColor2)
            {
                this.BackBrush = backBrush;
                this.BackColor = backColor;
                this.BackLitColor1 = backLitColor1;
                this.BackLitColor2 = backLitColor2;
            }
        }

        #endregion

        #region Private variables

        private CheckBoxItem _CheckBox;     // CheckBox contained in our item

        // Define a couple of color schemes for our item

        private ItemColorScheme[] _MyColors = { 
            new ItemColorScheme(Brushes.MidnightBlue, Color.MidnightBlue, Color.DodgerBlue, Color.RoyalBlue),
            new ItemColorScheme(Brushes.Maroon, Color.Maroon, Color.IndianRed, Color.Maroon)};

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public GlossyCustomItem()
        {
            // Lets add a simple CheckBox to our item

            _CheckBox = new CheckBoxItem();

            _CheckBox.Text = "Color";
            _CheckBox.TextColor = Color.White;

            SubItems.Add(_CheckBox);

            // Hook our events

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

                    // Update our SubItem bounds

                    UpdateSubBounds();
                }
            }
        }

        /// <summary>
        /// Updates our SubItem (CheckBox) bounds
        /// </summary>
        private void UpdateSubBounds()
        {
            // Loop through each SubItem, centering
            // the item inside our CustomCalendarItem

            for (int i = 0; i < SubItems.Count; i++)
                CenterItem(SubItems[i]);
        }

        #endregion

        #region BaseCalendarItem

        /// <summary>
        /// Base CalendarItem
        /// 
        /// This property holds the base CalendarItem from which
        /// each displayed CustomItem (of this type) is based.
        /// 
        /// In order to keep all displayed items "in-sync", it is necessary
        /// to propagate data to and from the base CalendarItem.  This is
        /// accomplished via hooking those members you are interested in, at
        /// both the item (HookEvents) and BaseCalendarItem (HookBaseEvents)
        /// level.
        /// 
        /// </summary>
        public override CustomCalendarItem BaseCalendarItem
        {
            get { return (base.BaseCalendarItem); }

            set
            {
                if (base.BaseCalendarItem != value)
                {
                    // Release the event hooks for the old Base

                    if (base.BaseCalendarItem != null)
                        HookBaseEvents(false);

                    // Set the new Base and hook the new events

                    base.BaseCalendarItem = value;

                    if (value != null)
                        HookBaseEvents(true);
                }
            }
        }

        #endregion

        #region CheckBox

        /// <summary>
        /// Gets the CheckBox item
        /// </summary>
        public CheckBoxItem CheckBox
        {
            get { return (_CheckBox); }
        }

        #endregion

        #endregion

        #region HookEvents

        /// <summary>
        /// Hooks or unhooks our item events
        /// </summary>
        /// <param name="hook">true to hook, false to unhook</param>
        private void HookEvents(bool hook)
        {
            // Hook onto all events that we are interested in
            // propagating through the BaseCalendarItem to other
            // like duplicated items

            if (hook == true)
                _CheckBox.CheckedChanged += CheckedChanged;
            else
                _CheckBox.CheckedChanged -= CheckedChanged;
        }

        #endregion

        #region HookBaseEvents

        /// <summary>
        /// Hooks or unhooks our BaseCalendarItem events
        /// </summary>
        /// <param name="hook">true to hook, false to unhook</param>
        private void HookBaseEvents(bool hook)
        {
            GlossyCustomItem gci = BaseCalendarItem as GlossyCustomItem;

            if (gci != null)
            {
                // Hook onto all base events that we are interested in
                // propagating back through the BaseCalendarItem to other
                // like items

                if (hook == true)
                    gci.CheckBox.CheckedChanged += BaseCheckedChanged;
                else
                    gci.CheckBox.CheckedChanged -= BaseCheckedChanged;
            }
        }

        #endregion

        #region Event processing

        /// <summary>
        /// Handles CheckBox CheckChange events for non-base items
        /// 
        /// This routine handles item CheckBox.Checked changes. This routine
        /// then propagates the change to the BaseCalendarItem.  All
        /// associated items should have hooked onto the BaseCalendarItem so
        /// that they will be notified of the change (via BaseCheckedChanged).
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CheckedChanged(object sender, CheckBoxChangeEventArgs e)
        {
            GlossyCustomItem myView = (GlossyCustomItem)BaseCalendarItem;

            // Propagate the change

            if (myView != null)
                myView.CheckBox.Checked = _CheckBox.Checked;
        }

        /// <summary>
        /// Handles CheckBox CheckChange events for base items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BaseCheckedChanged(object sender, CheckBoxChangeEventArgs e)
        {
            GlossyCustomItem myView = (GlossyCustomItem)BaseCalendarItem;

            if (myView != null)
            {
                // Update our state and refresh our control

                _CheckBox.Checked = myView.CheckBox.Checked;

                Refresh();
            }
        }

        #endregion

        #region RecalcSize

        /// <summary>
        /// Recalculates the size of the item.  We also make
        /// sure we initiate the recalc of any SubItems we have added
        /// </summary>
        public override void RecalcSize()
        {
            base.RecalcSize();

            for (int i = 0; i < this.SubItems.Count; i++)
            {
                this.SubItems[i].WidthInternal = WidthInternal / 2;
                this.SubItems[i].HeightInternal = HeightInternal / 2;

                this.SubItems[i].RecalcSize();

                CenterItem(SubItems[i]);

                this.SubItems[i].Displayed = true;
            }
        }

        /// <summary>
        /// Centers the item per our bounding rectangle
        /// </summary>
        /// <param name="item"></param>
        private void CenterItem(BaseItem item)
        {
            int x = (Bounds.Width - item.Bounds.Width) / 2;
            int y = (Bounds.Height - item.Bounds.Height) / 2;

            item.Bounds = new Rectangle
                (Bounds.X + x, Bounds.Y + y, item.Bounds.Width, item.Bounds.Height);
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

            // The color scheme used is based on whether
            // the CheckBox is checked or not

            int scheme = _CheckBox.Checked ? 0 : 1;

            // Draw the border and content area

            DrawBorder(e, scheme);
            DrawContent(e, scheme);

            // Set our CompostingQuality back

            g.CompositingQuality = comp;
        }

        #region DrawBorder

        /// <summary>
        /// Draws the item border
        /// </summary>
        /// <param name="e"></param>
        /// <param name="scheme"></param>
        private void DrawBorder(ItemPaintArgs e, int scheme)
        {
            Graphics g = e.Graphics;

            using (GraphicsPath path = GetItemPath(g, 0))
            {
                g.FillPath(_MyColors[scheme].BackBrush, path);
                g.DrawPath(Pens.Black, path);
            }
        }

        #endregion

        #region DrawContent

        /// <summary>
        /// Draws the content area of the item
        /// </summary>
        /// <param name="e"></param>
        /// <param name="scheme"></param>
        private void DrawContent(ItemPaintArgs e, int scheme)
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

                    // Draw the top half of the item

                    Rectangle r = Bounds;
                    r.Height = r.Height / 2;

                    using (LinearGradientBrush lbr = new
                        LinearGradientBrush(r, Color.LightGray, _MyColors[scheme].BackColor, 90f))
                    {
                        r.Height -= 1;
                        g.FillRectangle(lbr, r);
                    }

                    // Draw the bottom back-lit area

                    r.Y = r.Bottom;
                    r.Height = Bounds.Height;

                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddEllipse(r);

                        using (PathGradientBrush pbr = new PathGradientBrush(path))
                        {
                            pbr.CenterPoint = new
                                PointF(r.X + r.Width / 2, r.Y + r.Height / 2);

                            // If it is selected, make it a little more lit

                            pbr.CenterColor = (IsSelected ?
                                _MyColors[scheme].BackLitColor1 : _MyColors[scheme].BackLitColor2);

                            pbr.SurroundColors = new Color[] { _MyColors[scheme].BackColor };

                            g.FillEllipse(pbr, r);
                        }
                    }

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
        /// <param name="inset"></param>
        /// <returns></returns>
        private GraphicsPath GetItemPath(Graphics g, int inset)
        {
            GraphicsPath path = new GraphicsPath();

            Rectangle r = Bounds;
            r.Inflate(inset, inset);

            Rectangle ar = new
                Rectangle(r.Right - Radius, r.Bottom - Radius, Radius, Radius);

            path.AddArc(ar, 0, 90);

            ar.X = r.X;
            path.AddArc(ar, 90, 90);

            ar.Y = r.Y;
            path.AddArc(ar, 180, 90);

            ar.X = r.Right - Radius;
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

            if (objArg.Location.Y < Bounds.Y + ResizeArea)
                return (eHitArea.TopResize);

            // See if we are in the bottom resize area

            if (objArg.Location.Y > Bounds.Bottom - ResizeArea)
                return (eHitArea.BottomResize);

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

            if (StartTime >= start && objArg.Location.X < Bounds.X + ResizeArea)
                return (eHitArea.LeftResize);

            // See if we are in the right resize area

            if (EndTime <= end && objArg.Location.X > Bounds.Right - ResizeArea)
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

            if (objArg.Location.X < Bounds.X + ResizeArea)
                return (eHitArea.LeftResize);

            // See if we are in the right resize area

            if (objArg.Location.X > Bounds.Right - ResizeArea)
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
            GlossyCustomItem objCopy = new GlossyCustomItem();
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
            GlossyCustomItem objCopy = copy as GlossyCustomItem;

            if (objCopy != null)
            {
                objCopy.HookEvents(false);
                objCopy.SubItems.Clear();

                base.CopyToItem(objCopy);

                objCopy._CheckBox = (CheckBoxItem)objCopy.SubItems[0];
                objCopy.HookEvents(true);

                objCopy.CheckBox.Checked = _CheckBox.Checked;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes of the item
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            // Unhook our call-outs
            // and dispose of the item

            HookEvents(false);
            HookBaseEvents(false);

            base.Dispose(disposing);
        }

        #endregion
    }
}
