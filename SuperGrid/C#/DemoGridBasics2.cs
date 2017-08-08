using System;
using System.Drawing;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace SuperGridDemo
{
    public partial class DemoGridBasics2 : Office2007Form
    {
        #region Private variables

        private Random _Rand = new Random();

        #endregion

        public DemoGridBasics2()
        {
            InitializeComponent();

            // Initialize the grid, SortLevel
            // ComboBox, and the sample description text.

            InitializeGrid();
            InitSortLevelComboBox();

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoBasics2.rtf");
        }

        #region InitSortLevelComboBox

        /// <summary>
        /// Handles the initialization
        /// of the SortLevel ComboBox
        /// </summary>
        private void InitSortLevelComboBox()
        {
            foreach (string s in Enum.GetNames(typeof(SortLevel)))
                comboBoxEx1.Items.Add(s);

            comboBoxEx1.SelectedIndex = 1;
        }

        #endregion

        #region InitializeGrid

        /// <summary>
        /// Handles the default grid initialization
        /// </summary>
        private void InitializeGrid()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            // In this example we have two different Editor
            // and Render controls for the "NumericUpDown" column

            GridColumn column = panel.Columns["NumericUpDown"];

            // Set the min and max range for the EditControl

            GridNumericUpDownEditControl nc =
                (GridNumericUpDownEditControl)column.EditControl;

            nc.Minimum = -10000;
            nc.Maximum = 10000;
            nc.DecimalPlaces = 3;

            // Set the column's RenderType to be a GridDoubleInputEditControl
            // so that we can set a specialized display format for it

            column.RenderType = typeof(GridDoubleInputEditControl);

            GridDoubleInputEditControl rc =
                (GridDoubleInputEditControl)column.RenderControl;

            rc.DisplayFormat = "#,###.###;(#,###.###);**Zero**";

            // Now lets add 100 rows for the user to play around with

            for (int i = 0; i < 100; i++)
            {
                GridRow row = GetNewRow();

                // Add a few random nested sub-rows, and then finally
                // add the newly created row to the grid panel

                AddRandomSubRows(row);

                panel.Rows.Add(row);
            }
        }

        #endregion

        #region AddRandomSubRows

        /// <summary>
        /// Adds a random number of nested rows to
        /// the given row.
        /// </summary>
        /// <param name="row">Row to add rows to</param>
        private void AddRandomSubRows(GridRow row)
        {
            int count = _Rand.Next(1, 7);

            for (int i = 0; i < count; i++)
                row.Rows.Add(GetNewRow());
        }

        #endregion

        #region GetNewRow

        /// <summary>
        /// Create a new GridRow for our grid
        /// </summary>
        /// <returns></returns>
        private GridRow GetNewRow()
        {
            DateTime time1 = GetRandomDate();
            DateTime time2 = GetRandomDate();

            int inum = GetRandomInteger(500);

            double dnum = GetRandomDouble();
            decimal decn = GetRandomDecimal();

            return (new GridRow(time1, time2, decn, inum, dnum));
        }

        #region GetRandomDate

        private DateTime GetRandomDate()
        {
            return (DateTime.Now.AddDays(GetRandomDouble()));
        }

        #endregion

        #region GetRandomInteger

        private int GetRandomInteger(int max)
        {
            return (_Rand.Next(1, max));
        }

        #endregion

        #region GetRandomDouble

        private double GetRandomDouble()
        {
            return (_Rand.NextDouble() * 500);
        }

        #endregion

        #region GetRandomDecimal

        private decimal GetRandomDecimal()
        {
            decimal decn = (decimal)(_Rand.NextDouble() * 5000);

            if (_Rand.Next() % 2 == 0)
                decn = -decn;

            return (decn);
        }

        #endregion

        #endregion

        #region CbxTreeButtonsCheckedChanged

        /// <summary>
        /// Handles the TreeButton check changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxTreeButtonsCheckedChanged(object sender, EventArgs e)
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            if (cbxTreeButtons.Checked == true)
            {
                // Change the expand and collapse images to little red bugs

                panel.ExpandImage = ShellServices.LoadBitmap("SuperGridDemo.Resources.BugUp.png");
                panel.CollapseImage = ShellServices.LoadBitmap("SuperGridDemo.Resources.BugRight.png");
            }
            else
            {
                // Reset the expand and collapse images

                Image image = panel.ExpandImage;
                if (image != null)
                {
                    panel.ExpandImage = null;
                    image.Dispose();
                }

                image = panel.CollapseImage;
                if (image != null)
                {
                    panel.CollapseImage = null;
                    image.Dispose();
                }
            }
        }

        #endregion

        #region CbxHeaderImagesCheckedChanged

        /// <summary>
        /// Handle user requests to either show
        /// or hide all images in the columnheader
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxHeaderImagesCheckedChanged(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.ColumnHeader.ShowHeaderImages = cbxHeaderImages.Checked;
        }

        #endregion

        #region CbxAltRowStyleCheckedChanged

        /// <summary>
        /// Handles user requests to use (or not)
        /// the currently defined AlternateRowStyle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxAltRowStyleCheckedChanged(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.UseAlternateRowStyle = cbxAltRowStyle.Checked;
        }

        #endregion

        #region CbxAltColStyleCheckedChanged

        /// <summary>
        /// Handles user requests to use (or not)
        /// the currently defined AlternateColumnStyle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxAltColStyleCheckedChanged(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.UseAlternateColumnStyle = cbxAltColStyle.Checked;
        }

        #endregion

        #region BtnExpandAllClick

        /// <summary>
        /// Expands all rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExpandAllClick(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.ExpandAll();
        }

        #endregion

        #region BtnCollapseAllClick

        /// <summary>
        /// Collapses all rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCollapseAllClick(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.CollapseAll();
        }

        #endregion

        #region ComboBoxEx1SelectedIndexChanged

        /// <summary>
        /// Handles SortLevel changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxEx1SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEx1.SelectedIndex >= 0)
            {
                superGridControl1.PrimaryGrid.SortLevel =
                    (SortLevel) Enum.Parse(typeof (SortLevel), (string) comboBoxEx1.SelectedItem);
            }
        }

        #endregion
    }
}