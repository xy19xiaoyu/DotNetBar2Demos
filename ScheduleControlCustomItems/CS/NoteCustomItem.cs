using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Schedule;
using DevComponents.DotNetBar;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace ScheduleTestProject
{
    public class NoteCustomItem : CustomCalendarItem
    {
        #region Constants

        private const int _Radius = 10;         // Corner radius
        private const int _ResizeArea = 5;      // Resize area size

        #endregion

        #region Private variables

        private Image _Image;       // Image

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public NoteCustomItem(string Note)
        {
            Text = Note;

            HookEvents(true);
        }

        public NoteCustomItem()
            : this("")
        {
        }

        #region Public properties

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

        #region EndTime

        /// <summary>
        /// Gets and sets the item EndTime
        /// </summary>
        public override DateTime EndTime
        {
            get { return base.EndTime; }

            set
            {
                // As an added touch, always keep our EndTime equal
                // to our StartTime so the Schedule Control won't
                // allocate appointment space for it

                base.EndTime = StartTime;
            }
        }

        #endregion

        #region Image

        /// <summary>
        /// Gets and sets the item Image
        /// </summary>
        public Image Image
        {
            get { return (_Image); }

            set
            {
                _Image = value;

                this.Refresh();
            }
        }

        #endregion

        #endregion

        #region HookEvents

        /// <summary>
        /// Hooks or unhooks our events.
        /// 
        /// In order to keep all displayed items "in-sync", it is necessary
        /// to propagate data to and from the BaseCalendarItem.  This is
        /// accomplished via hooking those members you are interested in, at
        /// both the item (HookEvents) and BaseCalendarItem (HookBaseEvents)
        /// level.
        /// </summary>
        /// <param name="hook">true to hook, false to unhook</param>
        private void HookEvents(bool hook)
        {
            // In the NoteCustomItem case, we want to make sure the Text
            // is kept in sync across all created item versions

            if (hook == true)
                TextChanged += new EventHandler(ItemTextChanged);
            else
                TextChanged -= new EventHandler(ItemTextChanged);
        }

        #endregion

        #region HookBaseEvents

        /// <summary>
        /// Hooks or unhooks our BaseCalendarItem events.
        /// 
        /// In order to keep all displayed items "in-sync", it is necessary
        /// to propagate data to and from the BaseCalendarItem.  This is
        /// accomplished via hooking those members you are interested in, at
        /// both the item (HookEvents) and BaseCalendarItem (HookBaseEvents)
        /// level.
        /// </summary>
        /// <param name="hook">true to hook, false to unhook</param>
        private void HookBaseEvents(bool hook)
        {
            NoteCustomItem nci = BaseCalendarItem as NoteCustomItem;

            if (nci != null)
            {
                if (hook == true)
                {
                    nci.TextChanged +=
                        new EventHandler(BaseCalendarItem_TextChanged);
                }
                else
                {
                    nci.TextChanged -=
                        new EventHandler(BaseCalendarItem_TextChanged);
                }
            }
        }

        #endregion

        #region Event procesing

        /// <summary>
        /// Handles TextChanged events for the specific item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ItemTextChanged(object sender, EventArgs e)
        {
            NoteCustomItem nci = BaseCalendarItem as NoteCustomItem;

            // Propagate the event to all other potential versions
            // via the BaseCalendarItem

            if (nci != null)
                nci.Text = Text;
        }

        /// <summary>
        /// Handles TextChange events for the BaseCalendarItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BaseCalendarItem_TextChanged(object sender, EventArgs e)
        {
            NoteCustomItem nci = BaseCalendarItem as NoteCustomItem;

            if (nci != null)
            {
                Text = nci.Text;

                Refresh();
            }
        }

        #endregion

        #region RecalcSize

        /// <summary>
        /// Calculates the Bounding size for the item
        /// </summary>
        public override void RecalcSize()
        {
            base.RecalcSize();

            // Instead of taking the preferred size given to us
            // let's tell the Calendar that we want something different

            this.WidthInternal = 300;
            this.HeightInternal = 100;
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

            // Draw the border and content area

            DrawBorder(g);
            DrawContent(g);

            // Set our CompostingQuality back

            g.CompositingQuality = comp;
        }

        #region DrawBorder

        /// <summary>
        /// Draws the item border
        /// </summary>
        /// <param name="g"></param>
        private void DrawBorder(Graphics g)
        {
            using (GraphicsPath path = GetItemPath(g, 0))
            {
                g.FillPath(IsSelected ? Brushes.Black : Brushes.White, path);
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
        private void DrawContent(Graphics g)
        {
            // Grab a path slightly inset from the border

            using (GraphicsPath path = GetItemPath(g, -3))
            {
                // Set up a new clip region for the item

                Region rgnSave = g.Clip;

                using (Region rgn = new Region(rgnSave.GetRegionData()))
                {
                    rgn.Intersect(path);
                    g.Clip = rgn;

                    g.FillPath(Brushes.White, path);

                    RectangleF rf = Bounds;

                    using (StringFormat sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;

                        if (_Image != null)
                        {
                            g.DrawImage(_Image,
                                Bounds.X + (Bounds.Width - _Image.Width) / 2, Bounds.Y + 6);

                            rf.Y += _Image.Height / 2;
                            rf.Height -= _Image.Height / 2;
                        }

                        g.DrawString(Text, SystemFonts.DefaultFont, Brushes.Black, rf, sf);
                    }
                }

                // Restore our original clip region

                g.Clip = rgnSave;

                if (IsSelected == true)
                    g.DrawPath(Pens.Black, path);
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

            r.Width--;
            r.Height--;

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
            // By default we are in the move area

            if (Locked == false)
                return (eHitArea.Move);

            return (eHitArea.None);
        }

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
            NoteCustomItem objCopy = new NoteCustomItem();
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
            NoteCustomItem objCopy = copy as NoteCustomItem;
            base.CopyToItem(objCopy);

            // All private data that you want to carried
            // forward, needs to be propagated here

            objCopy._Image = this._Image;
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

            base.Dispose(disposing);
        }

        #endregion
    }
}
