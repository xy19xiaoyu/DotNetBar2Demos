using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;
using DevComponents.Instrumentation;

namespace SuperGridDemo
{
    public partial class DemoStyling : Office2007Form
    {
        #region Private variables

        private Random _Rand = new Random();

        private object[] _Gems = new object[]
            {"Amethyst", "Diamond", "Emerald", "Garnet",
             "Opal", "Ruby", "Sapphire", "Zircon" };

        private object[] _Jewelry = new object[]
            {"Ring", "Broach", "Necklace", "Pendant" };

        private object[] _Ocassion = new object[]
            { "Anniversary", "Birthday", "Wedding", "Other" };

        #endregion

        public DemoStyling()
        {
            InitializeComponent();

            this.EnableGlass = false;

            InitializeGrid();

            InitializeToolbarThemes();
        }

        #region InitializeToolbarThemes
        private void InitializeToolbarThemes()
        {
            bar1.Items.Clear();
            string[] styles = Enum.GetNames(typeof(eStyle));
            for (int i = 0; i < styles.Length; i++)
            {
                ButtonItem button = new ButtonItem(styles[i], styles[i]);
                button.Click += ChangeActiveStyle;
                bar1.Items.Add(button);
            }
        }
        private void ChangeActiveStyle(object sender, EventArgs e)
        {
            ButtonItem button = (ButtonItem)sender;
            StyleManager.Style = (eStyle)Enum.Parse(typeof(eStyle), button.Name);
        }
        #endregion

        #region InitializeGrid

        private void InitializeGrid()
        {
            InitializeCombo();

            AddRootRows();

            AddSubPanel1();
            AddSubPanel2();
            AddSubPanel3();
        }

        #endregion

        #region InitializeCombo

        private void InitializeCombo()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            GridComboBoxExEditControl cbx =
                panel.Columns["ComboBoxEx"].EditControl as GridComboBoxExEditControl;

            if (cbx != null)
                cbx.Items.AddRange(_Gems);
        }

        #endregion

        #region AddRootRows

        private void AddRootRows()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            foreach (GridRow row in panel.Rows)
            {
                object[] data = GetRootRowData();

                for (int i = 0; i < data.Length; i++)
                    row.Cells[i].Value = data[i];
            }
        }

        #region GetRootRowData

        private object[] GetRootRowData()
        {
            object[] data = new object[5];

            int n = _Rand.Next(_Gems.Length);

            data[0] = _Gems[n];
            data[1] = n % 2;
            data[2] = _Jewelry[_Rand.Next(_Jewelry.Length)];
            data[3] = DateTime.Now.AddDays(_Rand.Next(90) * 3);
            data[4] = DateTime.Now.AddDays(_Rand.Next(90) * -3);

            return (data);
        }

        #endregion

        #endregion

        #region AddSubPanel1

        private void AddSubPanel1()
        {
            GridPanel panel = superGridControl1.FindGridPanel("GridPanel1", true);

            if (panel != null)
            {
                GridMaskedTextBoxEditControl mtb =
                    panel.Columns["MaskedTextBox"].EditControl as GridMaskedTextBoxEditControl;

                if (mtb != null)
                    mtb.Mask = "(000)-000-0000";

                foreach (GridRow row in panel.Rows)
                {
                    object[] data = GetGridPanel1RowData();

                    for (int i = 0; i < data.Length; i++)
                        row.Cells[i].Value = data[i];
                }
            }
        }

        #region GetGridPanel1RowData

        private object[] GetGridPanel1RowData()
        {
            StringBuilder sb = new StringBuilder();

            object[] data = new object[5];

            data[0] = _Rand.NextDouble() * 1000;
            data[1] = _Rand.Next(-500, 500);
            data[2] = GetIpAddress(sb);
            data[3] = GetMaskedData(sb);
            data[4] = Math.Round(_Rand.NextDouble() * 100, 2);

            return (data);
        }

        #endregion

        #region GetMaskedData

        private object GetMaskedData(StringBuilder sb)
        {
            sb.Length = 0;

            sb.AppendFormat("({0:000})-{1:000}-{2:0000}",
                _Rand.Next(200, 900), _Rand.Next(0, 1000), _Rand.Next(1000, 10000));

            return (sb.ToString());
        }

        #endregion

        #region GetIpAddress

        private object GetIpAddress(StringBuilder sb)
        {
            sb.Length = 0;

            sb.Append(_Rand.Next(0, 255));
            sb.Append('.');
            sb.Append(_Rand.Next(0, 255));
            sb.Append('.');
            sb.Append(_Rand.Next(0, 255));
            sb.Append('.');
            sb.Append(_Rand.Next(0, 255));

            return (sb.ToString());
        }

        #endregion

        #endregion

        #region AddSubPanel2

        private void AddSubPanel2()
        {
            GridPanel panel = superGridControl1.FindGridPanel("GridPanel2", true);

            if (panel != null)
            {
                GridTextBoxDropDownEditControl ddc =
                    panel.Columns["TextBoxDropDown"].EditControl as GridTextBoxDropDownEditControl;

                if (ddc != null)
                {
                    ddc.ButtonClear.Visible = true;
                    ddc.ButtonClearClick += DdcButtonClearClick;
                }

                GridColumn col = panel.Columns["Slider"];
                col.EditorType = typeof(MyGridSliderEditControl);

                foreach (GridRow row in panel.Rows)
                {
                    object[] data = GetGridPanel2RowData();

                    for (int i = 0; i < data.Length; i++)
                        row.Cells[i].Value = data[i];
                }

                for (int i = 0; i < 10; i++)
                {
                    panel.Rows.Add(
                        new GridRow(GetGridPanel2RowData()));
                }

                col = panel.Columns["TextBoxDropDown"];
                col.DisplayIndex = 0;

                panel.SetGroup(col);
            }
        }

        #region GetGridPanel2RowData

        private object[] GetGridPanel2RowData()
        {
            StringBuilder sb = new StringBuilder();

            object[] data = new object[6];

            data[0] = _Rand.Next(101);
            data[1] = _Rand.Next(6);
            data[2] = _Rand.Next(101);
            data[3] = _Rand.Next(100) % 2;
            data[4] = GetJewelry(sb);
            data[5] = _Ocassion[_Rand.Next(_Ocassion.Length)];

            return (data);
        }

        #endregion

        #region GetJewelry

        private object GetJewelry(StringBuilder sb)
        {
            sb.Length = 0;

            sb.Append(_Gems[_Rand.Next(_Gems.Length)]);
            sb.Append(' ');
            sb.Append(_Jewelry[_Rand.Next(_Jewelry.Length)]);

            return (sb.ToString());
        }

        #endregion

        #region DdcButtonClearClick

        /// <summary>
        /// Handles Clear button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DdcButtonClearClick(object sender, CancelEventArgs e)
        {
            GridTextBoxDropDownEditControl ddc =
                sender as GridTextBoxDropDownEditControl;

            if (ddc != null)
            {
                // Just set the text to an "unknown" value and
                // tell the control that we handled it

                ddc.Text = "(unknown)";

                e.Cancel = true;
            }
        }

        #endregion

        #endregion

        #region AddSubPanel3

        private void AddSubPanel3()
        {
            GridPanel panel = superGridControl1.FindGridPanel("GridPanel3", true);

            if (panel != null)
            {
                GridColumn col = panel.Columns["Image"];
                col.EditorType = typeof(MyGridImageEditControl);
                col.EditorParams = new object[] { imageList2, ImageSizeMode.CenterImage };

                col = new GridColumn("Gauge");
                col.Width = 300;
                col.EditorType = typeof(MyGridGaugeEditControl);

                panel.Columns.Add(col);

                col = new GridColumn("BubbleBar");
                col.Width = 200;
                col.EditorType = typeof(MyGridBubbleBarEditControl);
                col.EditorParams = new object[] { imageList1, imageList2 };

                panel.Columns.Add(col);

                foreach (GridRow row in panel.Rows)
                {
                    object[] data = GetGridPanel3RowData();

                    for (int i = 0; i < data.Length; i++)
                    {
                        if (i < row.Cells.Count)
                            row.Cells[i].Value = data[i];
                        else
                            row.Cells.Add(new GridCell(data[i]));
                    }

                    col.CellStyles.Default.ImageAlignment = Alignment.TopCenter;

                    col.CellStyles.Default.Image =
                        imageList2.Images[(int)data[3]];
                }
            }
        }

        #region GetGridPanel3RowData

        private object[] GetGridPanel3RowData()
        {
            StringBuilder sb = new StringBuilder();

            object[] data = new object[5];

            data[0] = GetJewelry(sb);
            data[1] = _Rand.Next(imageList2.Images.Count); // imageList2.Images[_Rand.Next(imageList2.Images.Count)];
            data[2] = GetChartPoints(sb, 2, 6);

            int n = _Rand.Next(0, 3);
            double d = _Rand.NextDouble() * 20;

            data[3] = n;
            data[4] = d * ((n % 2 == 0) ? 1 : -1);

            return (data);
        }

        #endregion

        #region GetChartPoints

        private object GetChartPoints(StringBuilder sb, int min, int max)
        {
            sb.Length = 0;

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

                scale.Size = new SizeF(.7f, .51f);
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

            #region OnValueChanged

            protected override void 
                OnValueChanged(object sender, PointerChangedEventArgs e)
            {
                base.OnValueChanged(sender, e);

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

            protected override void  OnValueChanged(EventArgs e)
            {
 	             base.OnValueChanged(e);

                Text = (((float)Value / Maximum) * 100).ToString();
            }
        }

        #endregion

        #region MyGridImageEditControl

        /// <summary>
        /// GridImageEditControl with the ability
        /// to pass in a default ImageList and ImageBoxSizeMode
        /// </summary>
        private class MyGridImageEditControl : GridImageEditControl
        {
            public MyGridImageEditControl(
                ImageList imageList, ImageSizeMode sizeMode)
            {
                ImageList = imageList;
                ImageSizeMode = sizeMode;
            }
        }

        #endregion

    }
}