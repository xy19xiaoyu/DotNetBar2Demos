using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;
using DevComponents.Instrumentation;

namespace SuperGridDemo
{
    public partial class DemoGridBasics5 : Office2007Form
    {
        #region Private variables

        private Random _Rand = new Random();

        #endregion

        public DemoGridBasics5()
        {
            InitializeComponent();

            // Initialize the grid
            // and the sample description text

            InitializeGrid();

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoBasics5.rtf");
        }

        #region SuperGridControl1CellDoubleClick

        /// <summary>
        /// Handles double clicks in grid cells
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {
            // If the user double clicked in a MicroChart cell in 
            // the second column, then change the editor on the fly
            // so that they can textually edit the chart points.
            //
            // When the edit is over, the edit type for the column will
            // be set back to normal in the MyGridTextBoxXEditControl EndEdit
            // routine (we could have accomplished this same thing by hooking
            // onto the SuperGridControl.EndEdit event as well).

            if (e.GridCell.ColumnIndex == 1)
                e.GridCell.EditorType = typeof(MyGridTextBoxXEditControl);
        }

        #endregion

        #region InitializeGrid

        /// <summary>
        /// Initializes the default grid
        /// </summary>
        private void InitializeGrid()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            // Use MyGridBubbleBarEditControl so that we can easily
            // give the BubbleBar EditorControl our small and large
            // ImageLists.

            GridColumn column = panel.Columns["BubbleBar"];
            column.EditorType = typeof(MyGridBubbleBarEditControl);
            column.EditorParams = new object[] { imageList1, imageList2 };

            // Set the MicroChart1's RenderControl to have a Gray LineColor

            column = panel.Columns["MicroChart1"];
            GridMicroChartEditControl mc = (GridMicroChartEditControl)column.RenderControl;
            mc.LineChartStyle.LineColor = Color.Gray;

            // Set the MicroChart2's EditorType to MyGridMicroChartEditControl,
            // which just simply sets the ChartType to a Bar.

            column = panel.Columns["MicroChart2"];
            column.EditorType = typeof(MyGridMicroChartEditControl);

            // Add a new Column - a Gauge Control column

            column = new GridColumn("Gauge");

            column.Width = 300;
            column.EditorType = typeof(MyGridGaugeEditControl);

            panel.Columns.Add(column);

            // Add 30 rows for the user to play with

            for (int i = 0; i < 30; i++)
                AddNewRow(panel);

            // Hook onto the cell double-click event so that we can set the
            // cell editor type to a TextBoxX control and permit the user to
            // edit the chart points.

            superGridControl1.CellDoubleClick += SuperGridControl1CellDoubleClick;
        }

        #endregion

        #region AddNewRow

        /// <summary>
        /// Adds a new row to out grid
        /// </summary>
        /// <param name="panel"></param>
        private void AddNewRow(GridPanel panel)
        {
            object[] o = new object[4];

            o[0] = GetChartPoints(2, 6);
            o[1] = GetChartPoints(6, 10);

            int n = _Rand.Next(0, 3);
            double d = _Rand.NextDouble() * 20;

            o[2] = n;
            o[3] = d * ((n % 2 == 0) ? 1 : -1);

            GridRow row = new GridRow(o);

            panel.Rows.Add(row);

            row.Cells["BubbleBar"].CellStyles.Default.Image =
                imageList2.Images[n];
        }

        #region GetChartPoints

        private object GetChartPoints(int min, int max)
        {
            StringBuilder sb = new StringBuilder();

            int n = _Rand.Next(min, max);

            for (int i = 0; i < n; i++)
            {
                sb.Append(_Rand.Next(-50, 50));
                sb.Append(' ');
            }

            return (sb.ToString());
        }

        #endregion

        #endregion

        #region MyGridBubbleBarEditControl

        /// <summary>
        /// GridBubbleBarEditControl with the ability to set the
        /// small amd large ImageLists.  It also handles user image
        /// selection.
        /// </summary>
        private class MyGridBubbleBarEditControl : GridBubbleBarEditControl
        {
            public MyGridBubbleBarEditControl(
                ImageList imageListSmall, ImageList imageListLarge)
            {
                SetupBubbleTab(imageListSmall, imageListLarge);

                ButtonClick += MyGridBubbleBarEditControlButtonClick;
            }

            #region MyGridBubbleBarEditControlButtonClick

            void MyGridBubbleBarEditControlButtonClick(
                object sender, ClickEventArgs e)
            {
                BubbleButton bb = (BubbleButton)sender;

                // Set the cell image to match the selected bubble image

                EditorCell.CellStyles.Default.Image = ImagesLarge.Images[bb.ImageIndex];
            }

            #endregion

            #region SetupBubbleTab

            /// <summary>
            /// Creates the default BubbleTab for the control
            /// </summary>
            /// <param name="imageListSmall"></param>
            /// <param name="imageListLarge"></param>
            private void SetupBubbleTab(
                ImageList imageListSmall, ImageList imageListLarge)
            {
                Images = imageListSmall;
                ImagesLarge = imageListLarge;

                ImageSizeNormal = new Size(32, 32);
                ImageSizeLarge = new Size(64, 64);

                BubbleBarTab tab = new BubbleBarTab();
                Tabs.Add(tab);

                for (int i = 0; i < imageListSmall.Images.Count; i++)
                {
                    BubbleButton bb = new BubbleButton();
                    tab.Buttons.Add(bb);

                    bb.ImageIndex = i;
                    bb.ImageIndexLarge = i;
                }
            }

            #endregion
        }

        #endregion

        #region MyGridMicroChartEditControl

        /// <summary>
        /// GridMicroChartEditControl that
        /// simply sets the ChartType to a Bar
        /// </summary>
        private class MyGridMicroChartEditControl : GridMicroChartEditControl
        {
            public MyGridMicroChartEditControl()
            {
                ChartType = eMicroChartType.Bar;
            }
        }

        #endregion

        #region MyGridTextBoxXEditControl

        /// <summary>
        /// GridTextBoxXEditControl that
        /// simply resets the cell edit control back
        /// to a MicroChart when the cell edit is complete
        /// </summary>
        private class MyGridTextBoxXEditControl : GridTextBoxXEditControl
        {
            public override bool EndEdit()
            {
                EditorCell.EditorType = typeof(MyGridMicroChartEditControl);

                return (base.EndEdit());
            }
        }

        #endregion

        #region MyGridGaugeEditControl

        /// <summary>
        /// GridGaugeEditControl that handles the creation
        /// and initialization of our grid's gauge cell control
        /// </summary>
        private class MyGridGaugeEditControl : GridGaugeEditControl
        {
            public MyGridGaugeEditControl()
            {
                InitGauge();

                PointerValueChanged += MyGridGaugeEditControlPointerChanged;
            }

            #region InitGauge

            /// <summary>
            /// Initializes our gauge
            /// </summary>
            private void InitGauge()
            {
                Frame.Style = GaugeFrameStyle.None;

                GaugeLinearScale scale = new GaugeLinearScale();
                scale.Width = .3f;
                scale.Size = new SizeF(.7f, .81f);
                scale.Location = new PointF(.6f, .5f);
                scale.BorderColor = Color.DimGray;
                scale.BorderWidth = 1;
                scale.MinValue = -20;
                scale.MaxValue = 20;

                scale.MinPin.Visible = false;
                scale.MaxPin.Visible = false;

                scale.Labels.Layout.Font = new Font("Arial", 10);
                scale.Labels.Layout.AutoSize = false;

                scale.MajorTickMarks.Layout.Width = .2f;
                scale.MajorTickMarks.Layout.Length = .2f;
                scale.MajorTickMarks.Layout.Style = GaugeMarkerStyle.Circle;
                scale.MajorTickMarks.Layout.FillColor = new GradientFillColor(Color.White);
                scale.MajorTickMarks.Layout.FillColor.BorderColor = Color.DimGray;
                scale.MajorTickMarks.Layout.FillColor.BorderWidth = 1;

                GaugeText text = new GaugeText();

                text.AutoSize = false;
                text.Location = new PointF(.12f, .5f);
                text.TextAlignment = TextAlignment.MiddleRight;

                GaugeItems.Add(text);

                LinearScales.Add(scale);

                GaugeSection section = new GaugeSection(scale);
                section.Width = .8f;
                section.FillColor = new GradientFillColor(Color.Red, Color.Green);

                scale.Sections.Add(section);

                GaugePointer pointer = new GaugePointer(scale);
                pointer.Name = "Pointer1";
                pointer.Style = PointerStyle.Marker;
                pointer.MarkerStyle = GaugeMarkerStyle.Triangle;
                pointer.Placement = DisplayPlacement.Far;
                pointer.ScaleOffset = .03f;
                pointer.Width = .3f;
                pointer.Length = .3f;

                pointer.Origin = PointerOrigin.Custom;
                pointer.OriginInterval = 0;

                pointer.AllowUserChange = true;
                pointer.ChangeCursor = Cursors.Hand;

                pointer.FillColor = new GradientFillColor(Color.Yellow);
                pointer.FillColor.BorderColor = Color.DimGray;
                pointer.FillColor.BorderWidth = 1;

                scale.Pointers.Add(pointer);
            }

            #endregion

            #region MyGridGaugeEditControlPointerChanged

            /// <summary>
            /// Handles gauge pointer changes
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void MyGridGaugeEditControlPointerChanged(
                object sender, PointerChangedEventArgs e)
            {
                // Update the gauge text to reflect the new pointer value

                UpdateText(e.NewValue);
            }

            #endregion

            #region UpdateText

            /// <summary>
            /// Updates the GaugeText items with the current
            /// cell Value
            /// </summary>
            private void UpdateText(double value)
            {
                if (EditorCell != null)
                {
                    GaugeText text = GaugeItems[0] as GaugeText;

                    if (text != null)
                    {
                        text.Text = value.ToString();

                        text.ForeColor = value > 0 ? Color.Green : Color.Crimson;
                    }
                }
            }

            #endregion
        }

        #endregion

        #region CbxAddMicroBorderCheckedChanged

        /// <summary>
        /// Handles user MicroBorderChecked changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxAddMicroBorderCheckedChanged(object sender, EventArgs e)
        {
            if (cbxAddMicroBorder.Checked == true)
                superGridControl1.CellValueChanged += SuperGridControl1CellValueChanged;
            else
                superGridControl1.CellValueChanged -= SuperGridControl1CellValueChanged;

            UpdateMicroCellBorders();
        }

        #region UpdateMicroCellBorders

        /// <summary>
        /// Updates all MicroChart cells to reflect border changes
        /// </summary>
        private void UpdateMicroCellBorders()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            foreach (GridRow row in panel.Rows)
            {
                GridCell cell = row.Cells[0];
                UpdateMicroChartBorder(cell, NeedsChartBorder(cell.Value));

                cell = row.Cells[1];
                UpdateMicroChartBorder(cell, NeedsChartBorder(cell.Value));
            }
        }

        #endregion

        #endregion

        #region SuperGridControl1CellValueChanged

        /// <summary>
        /// Handles cell value changes in order to reflect MicroChart
        /// borders that are based upon the MicroChart values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1CellValueChanged(
            object sender, GridCellValueChangedEventArgs e)
        {
            GridCell cell = e.GridCell;

            if (cell.ColumnIndex <= 1)
            {
                bool needsBorder = NeedsChartBorder(e.NewValue);
                bool hasBorder = NeedsChartBorder(e.OldValue);

                if (needsBorder != hasBorder)
                    UpdateMicroChartBorder(cell, needsBorder);
            }
        }

        #endregion

        #region NeedsChartBorder

        /// <summary>
        /// Determines if the given value should 
        /// have a border around it.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool NeedsChartBorder(object value)
        {
            if (cbxAddMicroBorder.Checked == true)
            {
                string s = value as string;

                if (s != null)
                {
                    int n = GetChartPointCount(s);

                    return (n < 4 || n > 8);
                }
            }

            return (false);
        }

        #endregion

        #region UpdateMicroChartBorder

        /// <summary>
        /// Updates the MicroChart cell border
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="needsBorder"></param>
        private void UpdateMicroChartBorder(
            GridCell cell, bool needsBorder)
        {
            if (needsBorder == true)
            {
                cell.CellStyles.Default.BorderThickness = new Thickness(1);
                cell.CellStyles.Default.BorderPattern = new BorderPattern(LinePattern.Dot);

                cell.CellStyles.MouseOver.BorderColor = new BorderColor(Color.Red);
                cell.CellStyles.MouseOver.BorderPattern = new BorderPattern(LinePattern.Solid);

                cell.CellStyles.SelectedMouseOver.BorderColor = new BorderColor(Color.Red);
                cell.CellStyles.SelectedMouseOver.BorderPattern = new BorderPattern(LinePattern.Solid);

                cell.CellStyles.Default.Margin = new
                    DevComponents.DotNetBar.SuperGrid.Style.Padding(6);
            }
            else
            {
                cell.CellStyles.Default.BorderThickness = null;
                cell.CellStyles.Default.Margin = null;
            }
        }

        #endregion

        #region GetChartPointCount

        /// <summary>
        /// Gets the number of defined chart points
        /// in the given string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private int GetChartPointCount(string s)
        {
            if (string.IsNullOrEmpty(s) == false)
            {
                string[] ss = s.Split(' ');

                return (ss.Length);
            }

            return (0);
        }

        #endregion
    }
}