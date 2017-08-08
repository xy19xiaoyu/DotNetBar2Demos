using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace SuperGridDemo
{
    [ToolboxItem(false)]
    public class GridClipEditControl : ClipControl, IGridCellEditControl
    {
        #region Private variables

        private GridCell _Cell;
        private EditorPanel _EditorPanel;
        private Bitmap _EditorCellBitmap;

        private bool _ValueChanged;
        private bool _SuspendUpdate;

        private StretchBehavior _StretchBehavior = StretchBehavior.HorizontalOnly;

        #endregion

        ///<summary>
        /// GridClipEditControl
        ///</summary>
        public GridClipEditControl()
        {
            btnPlay.AutoCheckOnClick = false;
            btnPlay.AutoExpandOnClick = false;

            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            btnPlay.ColorTable = eButtonColor.OrangeWithBackground;
            btnPlay.Style = eDotNetBarStyle.StyleManagerControlled;

            labelX1.DoubleClick += ContentDoubleClick;

            btnPlay.Click += BtnPlayClick;
            btnStop.Click += BtnStopClick;
        }

        #region BtnPlayClick

        /// <summary>
        /// Called routine when the
        /// user clicks the 'Play Clip' button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void BtnPlayClick(object sender, EventArgs e)
        {
        }

        #endregion

        #region BtnStopClick

        /// <summary>
        /// Called routine when the
        /// user clicks the 'Stop Clip' button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void BtnStopClick(object sender, EventArgs e)
        {
        }

        #endregion

        #region ContentDoubleClick

        /// <summary>
        /// Called routine when the
        /// user double-clicks the control content.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void ContentDoubleClick(object sender, EventArgs e)
        {
        }

        #endregion

        #region OnPaintBackground

        /// <summary>
        /// Handles background painting.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Perform default cell background painting

            _Cell.PaintEditorBackground(e, this);
        }

        #endregion

        #region GetValue

        /// <summary>
        /// Gets the control 'value'
        /// from the supplied cell value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public virtual string GetValue(object value)
        {
            GridPanel panel = _Cell.GridPanel;

            if (value == null ||
                (panel.NullValue == NullValue.DBNull && value == DBNull.Value))
            {
                return ("");
            }

            if (_Cell.IsValueExpression == true)
                value = _Cell.GetExpValue((string)value);

            return (Convert.ToString(value));
        }

        #endregion

        #region SetValue

        /// <summary>
        /// Sets the control value from the cell value.
        /// </summary>
        /// <param name="s"></param>
        private void SetValue(string s)
        {
            Text = s;
        }

        #endregion

        #region IGridCellEditControl Members

        #region Public properties

        #region CanInterrupt

        /// <summary>
        /// Gets whether the Grid can automatically interrupt the current
        /// NonModal cell edit operation when the mouse leaves the cell.
        /// 
        /// This is utilized in cases, such as the ButtonX editor, where
        /// multilevel controls may be involved.  In the ButtonX case this
        /// specifically enables the mouse to to leave the main cell window
        /// and not be interrupted by the grid until the current operation
        /// is complete by the editor itself.
        /// </summary>
        public bool CanInterrupt
        {
            get { return (true); }
        }

        #endregion

        #region CellEditMode

        /// <summary>
        /// Gets the cell editor activation mode. There are three modes
        /// available for choice, and their usage depends upon the desired
        /// editor presentation, as well as how well the given underlying
        /// control interacts with the grid control.
        /// </summary>
        public CellEditMode CellEditMode
        {
            // NonModal – Edit operation will be performed as a nonNodal,
            // windowed edit automatically invoked upon entry to the cell.
            // The ButtonEx and BubbleBar editors are examples of this.

            get { return (CellEditMode.NonModal); }
        }

        #endregion

        #region EditorCell

        /// <summary>
        /// Gets or sets the editor's current associated grid cell.
        /// </summary>
        public GridCell EditorCell
        {
            get { return (_Cell); }
            set { _Cell = value; }
        }

        #endregion

        #region EditorCellBitmap

        ///<summary>
        /// Gets or sets the editor's associated cell bitmap (internal use only).
        ///</summary>
        public Bitmap EditorCellBitmap
        {
            get { return (_EditorCellBitmap); }

            set
            {
                if (_EditorCellBitmap != null)
                    _EditorCellBitmap.Dispose();

                _EditorCellBitmap = value;
            }
        }

        #endregion

        #region EditorFormattedValue

        ///<summary>
        /// Gets the formatted editor value.
        ///</summary>
        public virtual string EditorFormattedValue
        {
            get { return (Text); }
        }

        #endregion

        #region EditorPanel

        /// <summary>
        /// Gets or sets the editor's associated cell panel (internal use only).
        /// </summary>
        public EditorPanel EditorPanel
        {
            get { return (_EditorPanel); }
            set { _EditorPanel = value; }
        }

        #endregion

        #region EditorValue

        /// <summary>
        /// Gets or sets the editor's value.
        /// </summary>
        public virtual object EditorValue
        {
            get { return (Text); }
            set { SetValue(GetValue(value)); }
        }

        #endregion

        #region EditorValueChanged

        /// <summary>
        /// Gets or sets whether the editor value has changed.
        /// </summary>
        public virtual bool EditorValueChanged
        {
            get { return (_ValueChanged); }

            set
            {
                if (_ValueChanged != value)
                {
                    _ValueChanged = value;

                    // If the value is being marked as changed, then mark
                    // the editor session as 'dirty' as a feedback to the
                    // user of the intentional (or unintentional) change.

                    if (value == true)
                        _Cell.SetEditorDirty(this);
                }
            }
        }

        #endregion

        #region EditorValueType

        ///<summary>
        /// Gets the editor's default value data type.
        ///</summary>
        public virtual Type EditorValueType
        {
            get { return (typeof(string)); }
        }

        #endregion

        #region StretchBehavior

        /// <summary>
        /// Gets the editor's desired 'stretch' behavior.
        /// 
        /// The StretchBehavior defines whether the editor wants to
        /// automatically have it's size stretched to fill the given cell.
        /// 
        /// Editors, such as ButtonX, want to fill the cell horizontally
        /// and vertically, whereas other editors, such as the Slider,
        /// may only want to stretch horizontally (or potentially not at all). 
        /// </summary>
        public virtual StretchBehavior StretchBehavior
        {
            get { return (_StretchBehavior); }
            set { _StretchBehavior = value; }
        }

        #endregion

        #region SuspendUpdate

        /// <summary>
        /// Gets or sets whether updates to the grid
        /// state are (or should be) suspended.
        /// </summary>
        public bool SuspendUpdate
        {
            get { return (_SuspendUpdate); }
            set { _SuspendUpdate = value; }
        }

        #endregion

        #region ValueChangeBehavior

        /// <summary>
        /// Gets the behavior needed when a value changes in the editor.
        /// 
        /// For instance, CheckBoxEx Value changes require only the cell
        /// to be redisplayed with the new state, whereas editors such as
        /// the TextBoxX editor, may result in a new layout when the text changes.
        /// </summary>
        public virtual ValueChangeBehavior ValueChangeBehavior
        {
            get { return (ValueChangeBehavior.InvalidateLayout); }
        }

        #endregion

        #endregion

        #region InitializeContext

        ///<summary>
        /// Called to inform the editor it needs
        /// to initialize the its context environment.
        ///</summary>
        ///<param name="cell">Associated Cell</param>
        ///<param name="style">Effective cell style</param>
        public virtual void InitializeContext(GridCell cell, CellVisualStyle style)
        {
            _Cell = cell;

            SetValue(GetValue(_Cell.Value));

            Enabled = (_Cell.ReadOnly == false);

            Font = style.Font;
            ForeColor = style.TextColor;

            _ValueChanged = false;
        }

        #endregion

        #region GetProposedSize

        ///<summary>
        /// Called to retrieve the editors proposed size for the given
        /// cell, using the provided effective style and size constraint.
        ///</summary>
        ///<param name="g">Graphics object</param>
        ///<param name="cell">Associated Cell</param>
        ///<param name="style">Effective style</param>
        ///<param name="constraintSize">Constraining size</param>
        ///<returns>Proposed Size</returns>
        public virtual Size GetProposedSize(Graphics g,
            GridCell cell, CellVisualStyle style, Size constraintSize)
        {
            return (Size);
        }

        #endregion

        #region Edit support

        #region BeginEdit

        /// <summary>
        /// Called when a Modal cell edit is about to be initiated.
        /// </summary>
        /// <param name="selectAll">Signifies whether to select all
        /// editable content upon invocation.</param>
        /// <returns>The editor can cancel the edit
        /// operation by returning 'true' from this call</returns>
        public virtual bool BeginEdit(bool selectAll)
        {
            return (false);
        }

        #endregion

        #region EndEdit

        /// <summary>
        /// Called when the edit operation is about to end.
        /// </summary>
        /// <returns>The editor can cancel the end operation
        /// by returning 'true' from this call.</returns>
        public virtual bool EndEdit()
        {
            return (false);
        }

        #endregion

        #region CancelEdit

        /// <summary>
        /// Called when the edit operation is being cancelled.
        /// </summary>
        /// <returns>The editor can cancel the cancel operation
        /// by returning 'true' from this call.</returns>
        public virtual bool CancelEdit()
        {
            return (false);
        }

        #endregion

        #endregion

        #region CellRender

        /// <summary>
        /// Called to initiate the actual rendering of the editor
        /// value into the grid cell.  In most cases this can be (and is)
        /// handled by a simple call to EditorCell.CellRender(this, graphics).
        /// 
        /// If additional rendering is required by the editor, then the editor
        /// can completely render the cell contents itself (and never even call
        /// Editor.CellRender) or optionally perform additional rendering before
        /// or after the default cell rendering.
        /// </summary>
        /// <param name="g"></param>
        public virtual void CellRender(Graphics g)
        {
            _Cell.CellRender(this, g);
        }

        #endregion

        #region Keyboard support

        #region CellKeyDown

        ///<summary>
        /// Called when a KeyDown occurs and the CellEditMode is
        /// InPlace (otherwise the key event is automatically
        /// directed straight to the editor control).
        ///</summary>
        public virtual void CellKeyDown(KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                default:
                    OnKeyDown(e);
                    break;
            }
        }

        #endregion

        #region WantsInputKey

        /// <summary>
        /// Called to determine if the editor
        /// wants to process and handle the given key.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="gridWantsKey"></param>
        /// <returns></returns>
        public virtual bool WantsInputKey(Keys key, bool gridWantsKey)
        {
            return (gridWantsKey == false);
        }

        #endregion

        #endregion

        #region Mouse support

        #region OnCellMouseMove

        ///<summary>
        /// OnCellMouseMove
        ///</summary>
        ///<param name="e"></param>
        public virtual void OnCellMouseMove(MouseEventArgs e)
        {
            OnMouseMove(e);
        }

        #endregion

        #region OnCellMouseEnter

        ///<summary>
        /// OnCellMouseEnter
        ///</summary>
        ///<param name="e"></param>
        public virtual void OnCellMouseEnter(EventArgs e)
        {
            OnMouseEnter(e);
        }

        #endregion

        #region OnCellMouseLeave

        ///<summary>
        /// OnCellMouseLeave
        ///</summary>
        ///<param name="e"></param>
        public virtual void OnCellMouseLeave(EventArgs e)
        {
            Refresh();
        }

        #endregion

        #region OnCellMouseUp

        ///<summary>
        /// OnCellMouseUp
        ///</summary>
        ///<param name="e"></param>
        public virtual void OnCellMouseUp(MouseEventArgs e)
        {
            OnMouseUp(e);
        }

        #endregion

        #region OnCellMouseDown

        ///<summary>
        /// OnCellMouseDown
        ///</summary>
        ///<param name="e"></param>
        public virtual void OnCellMouseDown(MouseEventArgs e)
        {
            OnMouseDown(e);
        }

        #endregion

        #endregion

        #endregion
    }
}
