using System;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace SuperGridDemo
{
    public partial class DemoNested : Office2007Form
    {
        #region Private variables

        private Random _Rand = new Random();

        #endregion

        public DemoNested()
        {
            InitializeComponent();

            // Initialize the grid
            // and set the sample description text

            InitializeGrid();

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoNested.rtf");
        }

        #region InitializeGrid

        /// <summary>
        /// Initializes the default grid
        /// </summary>
        private void InitializeGrid()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            InitPanel(panel);
        }

        #endregion

        #region InitPanel

        /// <summary>
        /// Initializes the given panel
        /// </summary>
        /// <param name="panel"></param>
        private void InitPanel(GridPanel panel)
        {
            panel.CheckBoxes = true;
            panel.ShowCheckBox = false;
            panel.ShowTreeButtons = true;
            panel.ShowTreeLines = true;
            panel.ShowRowGridIndex = true;

            panel.RowHeaderWidth = 40;
            panel.DefaultRowHeight = 0;
            panel.ColumnHeader.RowHeight = 30;

            panel.DefaultVisualStyles.CellStyles.Default.Alignment = Alignment.MiddleCenter;
            panel.DefaultVisualStyles.ColumnHeaderStyles.Default.Alignment = Alignment.MiddleCenter;

            AddPanelData(panel);
        }

        #region AddPanelData

        private void AddPanelData(GridPanel panel)
        {
            int l = _Rand.Next(5, 8);

            for (int i = 0; i < l; i++)
            {
                GridColumn col = new GridColumn("Column " + (i + 1));

                col.Width = 130;
                col.InfoImageAlignment = Alignment.MiddleLeft;
                col.EditorType = typeof(GridDoubleInputEditControl);

                panel.Columns.Add(col);
            }

            int m = _Rand.Next(3, 20);

            for (int i = 0; i < m; i++)
            {
                GridRow row = new GridRow();

                if (i % 5 == 0)
                {
                    row.CellStyles.Default.BorderThickness = new Thickness(1);
                    row.CellStyles.Default.Margin = new DevComponents.DotNetBar.SuperGrid.Style.Padding(4);
                }

                int t = 100;
                int n = _Rand.Next(2, l);

                for (int j = 0; j < n; j++)
                {
                    int k = (j == n - 1) ? t : _Rand.Next(0, t);

                    row.Cells.Add(new GridCell((double)k));

                    t -= k;
                }

                panel.Rows.Add(row);
            }
        }

        #endregion

        #endregion

        #region SuperGridControl1AfterCheck

        /// <summary>
        /// Handles row CheckBox checked changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControl1AfterCheck(
            object sender, GridAfterCheckEventArgs e)
        {
            GridRow crow = e.Item as GridRow;

            // If the check state is going from unchecked to
            // checked, then add anew sub panel under the the
            // row that was checked.

            if (crow != null && crow.Checked == true)
            {
                GridPanel panel = new GridPanel();

                InitPanel(panel);

                crow.Rows.Add(panel);

                // Since we are always adding the row to the end
                // of the list, lets make sure it is visible on the screen

                panel.EnsureVisible(true);
            }
        }

        #endregion

        #region SuperGridControl1RowValidating

        /// <summary>
        /// Handles row level validation.  For this example, the
        /// cell data for the row must exactly equal 100.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControl1RowValidating(
            object sender, GridRowValidatingEventArgs e)
        {
            GridRow row = e.GridRow;

            double total = 0;

            foreach (GridCell cell in row.Cells)
            {
                if (cell.Value != null)
                    total += (double) cell.Value;
            }

            if (total != 100)
            {
                row.InfoText = "All cell Values must add up to exactly 100 (currently " +
                    total + "). Double-click on this icon to auto-correct.";

                e.Cancel = true;
            }
        }

        #endregion

        #region SuperGridControl1CellValidating

        /// <summary>
        /// Handles cell level validation.  For this example the
        /// cell must be between 0 and 100, inclusive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControl1CellValidating(
            object sender, GridCellValidatingEventArgs e)
        {
            double value = (double) e.Value;

            if (value < 0 || value > 100)
            {
                e.GridCell.InfoText = "Cell Value must be between 0 and 100, inclusive";
                e.Cancel = true;
            }
        }

        #endregion

        #region SuperGridControl1CellValidated

        /// <summary>
        /// Resets the cell level InfoText after successful
        /// cell validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControl1CellValidated(
            object sender, GridCellValidatedEventArgs e)
        {
            e.GridCell.InfoText = null;
        }

        #endregion

        #region SuperGridControl1RowValidated

        /// <summary>
        /// Resets the row level InfoText after a successful
        /// row level validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControl1RowValidated(
            object sender, GridRowValidatedEventArgs e)
        {
            e.GridRow.InfoText = null;
        }

        #endregion

        #region SuperGridControl1CancelEdit

        /// <summary>
        /// Resets the cell level InfoText upon
        /// user cancel of the edit operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControl1CancelEdit(
            object sender, GridEditEventArgs e)
        {
            e.GridCell.InfoText = null;
        }

        #endregion

        #region SuperGridControl1RowInfoDoubleClick

        /// <summary>
        /// Handle row level InfoImage double-clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControl1RowInfoDoubleClick(
            object sender, GridRowDoubleClickEventArgs e)
        {
            GridRow row = e.GridRow as GridRow;

            if (row != null)
            {
                // Just simply change every cell to have the average
                // value needed to total 100

                int avg = 100 / row.Cells.Count;
                int step = 100 % row.Cells.Count;

                for (int i = 0; i < row.Cells.Count; i++)
                    row.Cells[i].Value = (double)(avg + (i < step ? 1 : 0));

                row.InfoText = null;
            }
        }

        #endregion
    }
}