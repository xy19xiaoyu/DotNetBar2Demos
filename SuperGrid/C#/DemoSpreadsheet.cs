using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace SuperGridDemo
{
    public partial class DemoSpreadsheet : Office2007Form
    {
        public DemoSpreadsheet()
        {
            InitializeComponent();

            // Initialize the grid, color pickers, 
            // and set the sample description text

            InitializeGrid();
            InitColorPickers();

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoSpreadsheet.rtf");
        }

        #region InitializeGrid

        /// <summary>
        /// Initializes the default grid
        /// </summary>
        private void InitializeGrid()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            panel.NullString = null;
            panel.AllowEmptyCellSelection = true;
            panel.ShowRowGridIndex = true;
            panel.ColumnHeaderClickBehavior = ColumnHeaderClickBehavior.Select;

            panel.DefaultVisualStyles.
                CellStyles.Empty.Background = new Background(Color.White);

            // Add a column for each letter of the alphabet

            for (int i = 0; i < 26; i++)
            {
                GridColumn col = new 
                    GridColumn(((char)(65 + i)).ToString());

                col.Width = 60;

                panel.Columns.Add(col);
            }

            // Add 1000 rows for the user to play with.
            // No cells are added at this point.

            for (int i = 0; i < 1000; i++)
                panel.Rows.Add(new GridRow());

            superGridControl1.SelectionChanged += SuperGridControl1SelectionChanged;

            superGridControl1.BeginEdit += SuperGridControl1BeginEdit;
            superGridControl1.EndEdit += SuperGridControl1EndEdit;
        }

        #endregion

        #region InitColorPickers

        /// <summary>
        /// Initializes the default colors for the CPs
        /// </summary>
        private void InitColorPickers()
        {
            CpBackground.SelectedColor = Color.Red;
            CpText.SelectedColor = Color.Black;
        }

        #endregion

        #region Cell edit routines

        #region SuperGridControl1BeginEdit

        /// <summary>
        /// This routine is called when an edit is about to begin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1BeginEdit(object sender, GridEditEventArgs e)
        {
            // Hook the TextChanged event so that we can reflect the
            // pre-cell contents in the toolbar textbox.

            GridTextBoxXEditControl tbx =
                e.EditControl as GridTextBoxXEditControl;

            if (tbx != null)
                tbx.TextChanged += TbxTextChanged;
        }

        #endregion

        #region SuperGridControl1EndEdit

        /// <summary>
        /// This routine is called when a cell edit is about to end.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1EndEdit(object sender, GridEditEventArgs e)
        {
            // Unhook the TextChanged listener.

            GridTextBoxXEditControl tbx =
                e.EditControl as GridTextBoxXEditControl;

            if (tbx != null)
                tbx.TextChanged -= TbxTextChanged;
        }

        #endregion

        #region TbxTextChanged

        /// <summary>
        /// Called when the edit text changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TbxTextChanged(object sender, EventArgs e)
        {
            // Reflect the change in the toolbar textbox

            GridTextBoxXEditControl tbx =
                sender as GridTextBoxXEditControl;

            if (tbx != null)
                TbxCellText.Text = tbx.Text;
        }

        #endregion

        #endregion

        #region SuperGridControl1SelectionChanged

        /// <summary>
        /// Handles grid selection changes by updating the
        /// toolbar textbox if all selected cells have the
        /// same content value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1SelectionChanged(object sender, GridEventArgs e)
        {
            GridPanel panel = superGridControl1.PrimaryGrid;
            SelectedElementCollection items = panel.GetSelectedElements();
            List<GridCell> cells = items.GetCells();

            string s = null;

            if (cells.Count > 0)
            {
                foreach (GridCell cell in cells)
                {
                    if (ValuesMatch(ref s, (string)cell.Value) == false)
                        break;
                }
            }

            TbxCellText.Text = s ?? "";
        }

        #region ValuesMatch

        private bool ValuesMatch(ref string s, string t)
        {
            if (s == null || s.Equals(t) == true)
            {
                s = t;

                return (true);
            }
            
            s = "";

            return (false);
        }

        #endregion

        #endregion

        #region SuperGridControl1DoubleClick

        /// <summary>
        /// Handles double clicking a grid cell, by launching
        /// a cell edit session.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControl1DoubleClick(object sender, EventArgs e)
        {
            Point pt = superGridControl1.PointToClient(MousePosition);

            GridCell cell = superGridControl1.GetElementAt(pt) as GridCell;

            if (cell != null)
                LaunchEdit(cell, true);
        }

        #region LaunchEdit

        /// <summary>
        /// Launches a GridTextBoxXEditControl edit session.
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="beginEdit"></param>
        private void LaunchEdit(GridCell cell, bool beginEdit)
        {
            if (cell != null)
            {
                if (cell.IsEmptyCell == true)
                    cell = AllocateCell(cell);

                cell.CellStyles.Default.TextColor = CpText.SelectedColor;

                if (beginEdit == true)
                    cell.BeginEdit(true);
            }
        }

        #endregion

        #endregion

        #region SuperGridControl1KeyDown

        /// <summary>
        /// Handles edit launching when the user selects a
        /// and just starts typing.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControl1KeyDown(object sender, KeyEventArgs e)
        {
            if (superGridControl1.ActiveEditor == null)
            {
                GridCell cell = superGridControl1.ActiveElement as GridCell;

                if (cell != null)
                {
                    if (e.KeyData == Keys.F2)
                    {
                        LaunchEdit(cell, false);
                    }
                    else
                    {
                        char c = (char) e.KeyData;

                        if ((Char.IsControl(c) == false))
                            LaunchEdit(cell, false);
                    }
                }
            }
        }

        #endregion

        #region CpBackgroundClick

        /// <summary>
        /// Handles user requests to fill the selected cells with
        /// the currently set color picker background color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CpBackgroundClick(object sender, EventArgs e)
        {
            if (CpBackground.SelectedColor.IsEmpty == false)
            {
                GridPanel panel = superGridControl1.PrimaryGrid;
                SelectedElementCollection items = panel.GetSelectedElements();
                List<GridCell> cells = items.GetCells();

                // The AllocateCells routine allocates all the cells needed
                // to be able to satisfy the user's request.
                //
                // Special care should be taken to understand that the List of cells
                // returned in the call to items.GetCells is only useful for the
                // determination of row and column details, and is not valid for any
                // type of modification.
                //
                // After cell allocation has taken place, the grid rows now contain
                // newly created cells - and it is those cells that need to be referenced
                // in any future cell operation.

                AllocateCells(cells);

                Background background = new
                    Background(CpBackground.SelectedColor);

                foreach (GridCell cell in cells)
                {
                    // Make sure we use any newly allocated cell, and not
                    // a potentially Empty cell retrieved in the selection list

                    GridCell ncell = cell.GridRow.Cells[cell.ColumnIndex];

                    ncell.CellStyles.Default.Background = background;
                }

                // Clear all user selections so that the
                // background change is more apparent to the user.

                panel.ClearAll();
            }
        }

        #endregion

        #region CpTextClick

        /// <summary>
        /// Handles text color change requests
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CpTextClick(object sender, EventArgs e)
        {
            if (CpText.SelectedColor.IsEmpty == false)
            {
                GridPanel panel = superGridControl1.PrimaryGrid;

                Color color = CpText.SelectedColor;

                foreach (GridColumn col in panel.SelectedColumns)
                    col.CellStyles.Default.TextColor = color;

                foreach (GridRow row in panel.SelectedRows)
                    row.CellStyles.Default.TextColor = color;

                foreach (GridCell cell in panel.SelectedCells)
                {
                    if (cell.IsEmptyCell == false)
                        cell.CellStyles.Default.TextColor = color;
                }
            }
        }

        #endregion

        #region TbxCellTextKeyDown

        /// <summary>
        /// Handles the text update of all selected cells, when
        /// the user is entering txt in the toolbar textbox
        /// and hits the enter key.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxCellTextKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                GridPanel panel = superGridControl1.PrimaryGrid;
                SelectedElementCollection items = panel.GetSelectedElements();
                List<GridCell> cells = items.GetCells();

                // See above comments about the difference in accessibility
                // between Empty cells and newly allocated ones.

                AllocateCells(cells);

                string s = TbxCellText.Text;

                foreach (GridCell cell in cells)
                {
                    GridCell ncell = cell.GridRow.Cells[cell.ColumnIndex];

                    ncell.Value = s;
                    ncell.GridRow.RowDirty = true;
                }
            }
        }

        #endregion

        #region BtnFontClick

        /// <summary>
        /// Handles user requests to change each 
        /// selected cells font
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFontClick(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            fd.ShowColor = true;
            fd.ShowEffects = true;

            DialogResult result = fd.ShowDialog();

            if (result == DialogResult.OK)
            {
                GridPanel panel = superGridControl1.PrimaryGrid;
                SelectedElementCollection items = panel.GetSelectedElements();
                List<GridCell> cells = items.GetCells();

                foreach (GridCell cell in cells)
                {
                    if (cell.IsEmptyCell == false)
                    {
                        cell.GridRow.Cells[cell.ColumnIndex].
                            CellStyles.Default.Font = fd.Font;
                    }
                }
            }
        }

        #endregion

        #region BtnEraseBackgroundClick

        /// <summary>
        /// Handles user requests to erase the background
        /// of each selected cell.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEraseBackgroundClick(object sender, EventArgs e)
        {
            EraseBackground();
        }

        #region EraseBackground

        private void EraseBackground()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            foreach (GridColumn col in panel.SelectedColumns)
                col.CellStyles.Default.Background = null;

            foreach (GridRow row in panel.SelectedRows)
                row.CellStyles.Default.Background = null;

            foreach (GridCell cell in panel.SelectedCells)
            {
                if (cell.IsEmptyCell == false)
                    cell.CellStyles.Default.Background = null;
            }

            panel.ClearAll();
        }

        #endregion

        #endregion

        #region BtnEraseTextClick

        /// <summary>
        /// Handles user requests to erase the cell value
        /// in each selected cell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEraseTextClick(object sender, EventArgs e)
        {
            EraseText();
        }

        #region EraseText

        private void EraseText()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;
            SelectedElementCollection items = panel.GetSelectedElements();
            List<GridCell> cells = items.GetCells();

            foreach (GridCell cell in cells)
            {
                if (cell.IsEmptyCell == false)
                {
                    cell.CellStyles.Default.Font = null;
                    cell.CellStyles.Default.TextColor = Color.Empty;

                    cell.Value = null;
                }
            }
        }

        #endregion

        #endregion

        #region BtnShowEmptyCellsClick

        /// <summary>
        /// Handles user requests to show (or not) all Empty
        /// cells in their default style color, so that Empty
        /// and non-Empty cells can be visibly seen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowEmptyCellsClick(object sender, EventArgs e)
        {
            if (btnShowEmptyCells.Checked == true)
            {
                superGridControl1.PrimaryGrid.DefaultVisualStyles.
                    CellStyles.Empty.Background = null;
            }
            else
            {
                superGridControl1.PrimaryGrid.DefaultVisualStyles.
                    CellStyles.Empty.Background = new Background(Color.White);
            }
        }

        #endregion

        #region Text alignment

        #region BtnLeftAlignClick

        private void BtnLeftAlignClick(object sender, EventArgs e)
        {
            AlignItems(Alignment.MiddleLeft);
        }

        #endregion

        #region BtnMiddleAlignClick

        private void BtnMiddleAlignClick(object sender, EventArgs e)
        {
            AlignItems(Alignment.MiddleCenter);
        }

        #endregion

        #region BtnRightAlignClick

        private void BtnRightAlignClick(object sender, EventArgs e)
        {
            AlignItems(Alignment.MiddleRight);
        }

        #endregion

        #region AlignItems

        private void AlignItems(Alignment alignment)
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            foreach (GridColumn col in panel.SelectedColumns)
                col.CellStyles.Default.Alignment = alignment;

            foreach (GridRow row in panel.SelectedRows)
                row.CellStyles.Default.Alignment = alignment;

            foreach (GridCell cell in panel.SelectedCells)
            {
                if (cell.IsEmptyCell == false)
                    cell.CellStyles.Default.Alignment = alignment;
            }
        }

        #endregion

        #endregion

        #region Support routines

        #region AllocateCells

        /// <summary>
        /// Allocates all non-Empty cells
        /// </summary>
        /// <param name="cells"></param>
        private void AllocateCells(IEnumerable<GridCell> cells)
        {
            foreach (GridCell cell in cells)
            {
                if (cell.IsEmptyCell == true)
                    AllocateCell(cell);
            }
        }

        #endregion

        #region AllocateCell

        /// <summary>
        /// Allocates all the cells in a row that are necessary
        /// to eventually allocate the cell at the given ColumnIndex.
        /// </summary>
        /// <param name="cell"></param>
        /// <returns></returns>
        private GridCell AllocateCell(GridCell cell)
        {
            GridRow row = cell.GridRow;

            for (int i = row.Cells.Count; i <= cell.ColumnIndex; i++)
            {
                GridCell newCell = new GridCell();

                row.Cells.Add(newCell);
            }

            return (cell.GridRow.Cells[cell.ColumnIndex]);
        }

        #endregion

        #endregion

        #region SuperGridControl1MouseClick

        private void SuperGridControl1MouseClick(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Right) == MouseButtons.Right)
            {
                GridElement item = superGridControl1.GetElementAt(e.Location);

                if (item is GridCell)
                    ShowContextMenu(cmContext);
            }
        }

        #region ShowContextMenu

        /// <summary>
        /// Shows the given ContextMenu
        /// </summary>
        /// <param name="cm">ContextMenu to show</param>
        private void ShowContextMenu(ButtonItem cm)
        {
            cm.Popup(MousePosition);
        }

        #endregion

        #endregion

        #region CmiClearClick

        private void CmiClearClick(object sender, EventArgs e)
        {
            EraseText();
            EraseBackground();
        }

        #endregion

        #region CmiLeftAlignClick

        private void CmiLeftAlignClick(object sender, EventArgs e)
        {
            AlignItems(Alignment.MiddleLeft);
        }

        #endregion

        #region CmiCenterAlignClick

        private void CmiCenterAlignClick(object sender, EventArgs e)
        {
            AlignItems(Alignment.MiddleCenter);
        }

        #endregion

        #region CmiRightAlignClick

        private void CmiRightAlignClick(object sender, EventArgs e)
        {
            AlignItems(Alignment.MiddleRight);
        }

        #endregion
    }
}