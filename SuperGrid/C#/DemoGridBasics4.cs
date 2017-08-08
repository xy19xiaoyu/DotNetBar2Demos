using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace SuperGridDemo
{
    public partial class DemoGridBasics4 : Office2007Form
    {
        #region Private variables

        private Random _Rand = new Random();
        private bool _ShowProgressBugs;

        #endregion

        public DemoGridBasics4()
        {
            InitializeComponent();

            // Initialize the grid, GridLines
            // ComboBox, and the sample description text.

            InitializeGrid();
            InitGridLinesComboBox();

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoBasics4.rtf");
        }

        #region InitializeGrid

        /// <summary>
        /// Initializes the default grid
        /// </summary>
        private void InitializeGrid()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            // Set both the Slider and SwitchButton columns to
            // our own defined EditControls

            GridColumn column = panel.Columns["Slider"];
            column.EditorType = typeof(MyGridSliderEditControl);

            column = panel.Columns["SwitchButton"];
            column.EditorType = typeof(MyGridSwitchButtonEditControl);

            // Add 30 rows for the user to play around with

            for (int i = 0; i < 30; i++)
                AddNewRow(panel);
        }

        #region AddNewRow

        /// <summary>
        /// Adds a new row to the grid
        /// </summary>
        /// <param name="panel"></param>
        private void AddNewRow(GridPanel panel)
        {
            object[] o = new object[4];

            o[0] = _Rand.Next(0, 100);
            o[1] = _Rand.Next(0, 100);
            o[2] = (_Rand.Next(0, 100) % 2 == 0);
            o[3] = (_Rand.Next(0, 100) % 2 == 0);

            GridRow row = new GridRow(o);

            panel.Rows.Add(row);
        }

        #endregion

        #endregion

        #region InitGridLinesComboBox

        /// <summary>
        /// Initializes the GridLines ComboBox
        /// </summary>
        private void InitGridLinesComboBox()
        {
            foreach (string s in Enum.GetNames(typeof(GridLines)))
                cbxGridLines.Items.Add(s);

            cbxGridLines.SelectedIndex = 3;

            foreach (string s in Enum.GetNames(typeof(LinePattern)))
            {
                cbxHLinePattern.Items.Add(s);
                cbxVLinePattern.Items.Add(s);
            }

            cbxHLinePattern.SelectedIndex = 2;
            cbxVLinePattern.SelectedIndex = 2;
        }

        #endregion

        #region SuperGridControl1GetRenderer

        /// <summary>
        /// This routine is called to dynamically obtain the
        /// renderer control for the given cell.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1GetRenderer(object sender, GridGetRendererEventArgs e)
        {
            int columnIndex = e.GridCell.ColumnIndex;

            // Just as an example, lets have all CheckBox cells, whose
            // adjacent SwitchButton cell is 'true', to render as a textual
            // value, instead of the normal checkbox display.

            if (columnIndex == 3)
            {
                GridCell scell = e.GridCell.GridRow.Cells[2];

                e.RenderType = ((bool)scell.Value == true)
                    ? typeof(GridTextBoxXEditControl) : null;
            }
        }

        #endregion

        #region SuperGridControl1PostRenderCell

        /// <summary>
        /// This routine is called after each
        /// RenderPart has been rendered by the grid, in order
        /// to permit the application to render additional
        /// visuals to the cell part.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1PostRenderCell(
            object sender, GridPostRenderCellEventArgs e)
        {
            if (e.GridCell.ColumnIndex == 0)
            {
                if (_ShowProgressBugs == true)
                    RenderProgressBugs(e);
            }
            else if (e.GridCell.ColumnIndex == 1)
            {
                RenderSliderBackground(e);
            }
        }

        #region RenderSliderBackground

        /// <summary>
        /// Renders the slider background
        /// </summary>
        /// <param name="e"></param>
        private void RenderSliderBackground(GridPostRenderCellEventArgs e)
        {
            if ((e.RenderParts & RenderParts.Background) == RenderParts.Background)
            {
                // Render a Red gradient background for
                // the slider if the cell Value is > 75

                if ((int)e.GridCell.Value > 75)
                {
                    using (Brush br = new
                        LinearGradientBrush(e.Bounds, Color.Transparent, Color.Red, 0f))
                    {
                        e.Graphics.FillRectangle(br, e.Bounds);
                    }
                }
            }
        }

        #endregion

        #region RenderProgressBugs

        /// <summary>
        /// Renders ProgressBar bugs
        /// </summary>
        /// <param name="e"></param>
        private void RenderProgressBugs(GridPostRenderCellEventArgs e)
        {
            if ((e.RenderParts & RenderParts.Content) == RenderParts.Content)
            {
                GridProgressBarXEditControl pbx =
                    e.GridCell.GridColumn.EditControl as GridProgressBarXEditControl;

                if (pbx != null)
                {
                    using (Image image =
                        ShellServices.LoadBitmap("SuperGridDemo.Resources.BugRight.png"))
                    {
                        if (image != null)
                        {
                            Rectangle r = e.Bounds;
                            r.Inflate(-3, -3);

                            r.Y += ((e.Bounds.Height - image.Height) / 2) - 2;
                            r.Size = image.Size;

                            int value = (int)e.GridCell.Value;
                            int n = (int)(e.Bounds.Width * ((float)value / pbx.Maximum));
                            int count = n / image.Width;

                            for (int i = 0; i < count; i++)
                            {
                                e.Graphics.DrawImage(image, r);

                                r.X += image.Width;
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #endregion

        #region MyGridSwitchButtonEditControl

        /// <summary>
        /// GridSwitchButtonEditControl with the ability to catch when
        /// the switch changes (just another way to be notified when
        /// a cell value changes)
        /// </summary>
        private class MyGridSwitchButtonEditControl : GridSwitchButtonEditControl
        {
            public MyGridSwitchButtonEditControl()
            {
                // Lets have this one only stretch horizontally
                // and not vertically as well

                StretchBehavior = StretchBehavior.HorizontalOnly;

                ValueChanged += MyGridSwitchButtonEditControlValueChanged;
            }

            #region MyGridSwitchButtonEditControlValueChanged

            void MyGridSwitchButtonEditControlValueChanged(object sender, EventArgs e)
            {
                // Refresh the adjacent CheckBoxes
                // to reflect the new switch state

                GridCell cell = EditorCell;

                if (cell != null)
                    cell.GridRow.Cells[3].InvalidateRender();
            }

            #endregion
        }

        #endregion

        #region MyGridSliderEditControl

        /// <summary>
        /// GridSliderEditControl where we are enabling the slider
        /// label and setting the label to reflect the cell value
        /// </summary>
        private class MyGridSliderEditControl : GridSliderEditControl
        {
            public MyGridSliderEditControl()
            {
                LabelVisible = true;
            }

            #region InitializeContext

            /// <summary>
            /// Handles the setting of the slider text to 
            /// match the current cell value
            /// </summary>
            /// <param name="cell"></param>
            /// <param name="style"></param>
            public override void InitializeContext(
                GridCell cell, CellVisualStyle style)
            {
                base.InitializeContext(cell, style);

                Text = (((float)Value / Maximum) * 100).ToString();
            }

            #endregion
        }

        #endregion

        #region CbxProgressBugsCheckedChanged

        /// <summary>
        /// Handles user requests to show
        /// (or not) bugs over the ProgressBar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxProgressBugsCheckedChanged(object sender, EventArgs e)
        {
            _ShowProgressBugs = cbxProgressBugs.Checked;

            // Refresh the column to reflect the change

            superGridControl1.PrimaryGrid.Columns[0].InvalidateRender();
        }

        #endregion

        #region CbxGridLinesSelectedIndexChanged

        /// <summary>
        /// Handles user changes in the GridLines display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxGridLinesSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxGridLines.SelectedIndex >= 0)
            {
                superGridControl1.PrimaryGrid.GridLines =
                    (GridLines)Enum.Parse(typeof(GridLines), (string)cbxGridLines.SelectedItem);
            }
        }

        #endregion

        #region CbxHLinePatternSelectedIndexChanged

        /// <summary>
        /// Handles user changes in the Horizontal LinePatter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxHLinePatternSelectedIndexChanged(object sender, EventArgs e)
        {
            superGridControl1.DefaultVisualStyles.GridPanelStyle.HorizontalLinePattern =
                (LinePattern)Enum.Parse(typeof(LinePattern), (string)cbxHLinePattern.SelectedItem);
        }

        #endregion

        #region CbxVLinePatternSelectedIndexChanged

        /// <summary>
        /// Handles user changes in the Vertical LinePatter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxVLinePatternSelectedIndexChanged(object sender, EventArgs e)
        {
            superGridControl1.DefaultVisualStyles.GridPanelStyle.VerticalLinePattern =
                (LinePattern)Enum.Parse(typeof(LinePattern), (string)cbxVLinePattern.SelectedItem);
        }

        #endregion
    }
}