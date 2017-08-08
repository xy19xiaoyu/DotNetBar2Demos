using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace SuperGridDemo
{
    public partial class DemoDragDrop : Office2007Form
    {
        #region Private variables

        private SuperGridControl _SrcGrid;
        private GridElement _SrcElement;

        private GridRow _DragOverRow;
        private GridCell _DragOverCell;
        private GridColumn _DragOverColumn;

        private Point _MouseDownPoint;

        #endregion

        public DemoDragDrop()
        {
            InitializeComponent();

            // Initialize the grid and
            // set the sample description text

            InitializeGrid();
            InitializeListBox();
            InitializeTreeView();
            InitializeAdvTree();

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoDragDrop.rtf");

            superGridControl1.ItemDrag += SuperGridControlItemDrag;
        }

        #region Initialization support

        #region InitializeGrid

        /// <summary>
        /// Initializes the default grid
        /// </summary>
        private void InitializeGrid()
        {
            AddDefaultData(superGridControl1);
            AddDefaultData(superGridControl2);
        }

        #region AddDefaultData

        /// <summary>
        /// Adds default data to the supplied grid
        /// </summary>
        /// <param name="grid"></param>
        private void AddDefaultData(SuperGridControl grid)
        {
            GridPanel panel = grid.PrimaryGrid;

            for (int i = 0; i < 10; i++)
            {
                Employee emp = Employee.GetNewEmployee();

                GridRow row = new
                    GridRow(emp.LastName, emp.FirstName, emp.Age, emp.Id);

                panel.Rows.Add(row);
            }
        }

        #endregion

        #endregion

        #region InitializeListBox

        /// <summary>
        /// Initializes the ListBox with default data
        /// </summary>
        private void InitializeListBox()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 20; i++)
            {
                Employee emp = Employee.GetNewEmployee();

                sb.Length = 0;

                sb.AppendFormat("{0}, {1}, {2}, {3}",
                    emp.LastName, emp.FirstName, emp.Age, emp.Id);

                listBox1.Items.Add(sb.ToString());
            }
        }

        #endregion

        #region InitializeTreeView

        /// <summary>
        /// Initializes the TreeView with default data
        /// </summary>
        private void InitializeTreeView()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 20; i++)
            {
                Employee emp = Employee.GetNewEmployee();

                sb.Length = 0;

                sb.AppendFormat("{0}, {1}, {2}, {3}",
                    emp.LastName, emp.FirstName, emp.Age, emp.Id);

                string s = sb.ToString();

                int n = treeView1.Nodes.IndexOfKey(emp.LastName);

                if (n >= 0)
                    treeView1.Nodes[n].Nodes.Add(emp.LastName, s);
                else
                    treeView1.Nodes.Add(emp.LastName, s);
            }
        }

        #endregion

        #region InitializeAdvTree

        /// <summary>
        /// Initializes the AdvTree with default data
        /// </summary>
        private void InitializeAdvTree()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 20; i++)
            {
                Employee emp = Employee.GetNewEmployee();

                sb.Length = 0;

                sb.AppendFormat("{0}, {1}, {2}, {3}",
                    emp.LastName, emp.FirstName, emp.Age, emp.Id);

                Node node = new Node();
                node.Cells.Clear();

                node.Cells.Add(new Cell(emp.LastName));
                node.Cells.Add(new Cell(emp.FirstName));
                node.Cells.Add(new Cell(emp.Age.ToString()));
                node.Cells.Add(new Cell(emp.Id.ToString()));

                Node pnode = advTree1.FindNodeByText(emp.LastName);

                if (pnode != null)
                    pnode.Nodes.Add(node);
                else
                    advTree1.Nodes.Add(node);
            }
        }

        #endregion

        #endregion

        #region SuperGrid support

        #region SuperGridControlItemDrag

        /// <summary>
        /// Handles the initiation of SuperGrid
        /// Drag and Drop operations.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControlItemDrag(object sender, GridItemDragEventArgs e)
        {
            SuperGridControl sg = sender as SuperGridControl;

            if (sg != null)
            {
                // Get the collection of selected items

                SelectedElementCollection items = null;

                if (e.Item is GridCell)
                    items = sg.PrimaryGrid.GetSelectedCells();

                else if (e.Item is GridRow)
                    items = sg.PrimaryGrid.GetSelectedRows();

                else if (e.Item is GridColumn)
                    items = sg.PrimaryGrid.GetSelectedColumns();

                // If the user has selected items, then make the
                // data accessible, and start the drag operation.

                if (items != null && items.Count > 0)
                {
                    _SrcGrid = sg;
                    _SrcElement = e.Item as GridElement;

                    DataObject dob = new DataObject(items);

                    if (e.Item is GridRow)
                    {
                        Node[] nodes = new Node[items.Count];

                        for (int i=0; i<items.Count; i++)
                        {
                            GridRow row = (GridRow) items[i];

                            Node node = new Node();
                            node.Cells.Clear();

                            foreach (GridCell cell in row.Cells)
                            {
                                Cell acell = new Cell(cell.Value.ToString());

                                node.Cells.Add(acell);
                            }

                            nodes[i] = node;
                        }

                        dob.SetData(nodes);
                    }

                    // Initiate the drag operation

                    sg.DoDragDrop(dob, DragDropEffects.Copy | DragDropEffects.Move);

                    _SrcGrid = null;
                    _SrcElement = null;
                }

                ClearDragHighlight();
            }
        }

        #endregion

        #region SuperGridControlDragOver

        /// <summary>
        /// Handles SuperGrid DragOver events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControlDragOver(object sender, DragEventArgs e)
        {
            SuperGridControl sg = sender as SuperGridControl;

            if (sg != null)
            {
                ClearDragHighlight();

                e.Effect = DragDropEffects.None;

                Point clientPoint = sg.PointToClient(new Point(e.X, e.Y));
                GridElement item = sg.GetElementAt(clientPoint.X, clientPoint.Y);

                if (item is GridCell)
                {
                    if (_SrcElement is GridRow)
                    {
                        item = ((GridCell) item).GridRow;
                    }
                    else if (_SrcElement == null || _SrcElement is GridCell)
                    {
                        _DragOverCell = (GridCell)item;
                        _DragOverCell.CellStyles.Default.Background = new Background(Color.AliceBlue);

                        e.Effect = DragDropEffects.Copy | DragDropEffects.Move;
                    }
                }

                if (item is GridRow)
                {
                    if (_SrcElement == null || _SrcElement is GridRow)
                    {
                        _DragOverRow = (GridRow) item;
                        _DragOverRow.CellStyles.Default.Background = new Background(Color.AliceBlue);

                        e.Effect = DragDropEffects.Copy | DragDropEffects.Move;
                    }
                }
                else if (item is GridColumnHeader)
                {
                    if ( _SrcElement is GridColumn)
                    {
                        GridColumn doColumn = ((GridColumnHeader)item).GetHitColumn(clientPoint);

                        if (((GridColumn)_SrcElement).EditorType == doColumn.EditorType)
                        {
                            _DragOverColumn = doColumn;
                            _DragOverColumn.CellStyles.Default.Background = new Background(Color.AliceBlue);

                            e.Effect = DragDropEffects.Copy | DragDropEffects.Move;
                        }
                    }
                    else if (_SrcElement == null || _SrcElement is GridRow)
                    {
                        e.Effect = DragDropEffects.Copy | DragDropEffects.Move;
                    }
                }

                if (sg != _SrcGrid)
                {
                    e.Effect &= ~(DragDropEffects.Move);
                }
                else
                {
                    if ((e.KeyState & 8) != 8)
                        e.Effect &= ~(DragDropEffects.Copy);
                }
            }
        }

        #endregion

        #region SuperGridControlDragDrop

        /// <summary>
        /// Handles SuperGrid DragDrop events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControlDragDrop(object sender, DragEventArgs e)
        {
            SuperGridControl sg = sender as SuperGridControl;

            if (sg != null)
            {
                ClearStyles(sg);

                Point pt = sg.PointToClient(new Point(e.X, e.Y));
                GridElement item = sg.GetElementAt(pt.X, pt.Y);

                // If the data we are dropping is from a SuperGrid, then
                // be a little bit more discerning about how we drop it

                if (_SrcGrid != null)
                {
                    SelectedElementCollection items =
                        (SelectedElementCollection)e.Data.GetData(typeof(SelectedElementCollection));

                    if (item is GridCell)
                    {
                        if (_SrcElement is GridRow)
                            DropSgRow(e, ((GridCell) item).GridRow, items);
                        else
                            DropSgCell((GridCell) item, items);
                    }
                    else if (item is GridRow)
                        DropSgRow(e, (GridRow)item, items);

                    else if (item is GridColumnHeader)
                        DropSgColumnHeader((GridColumnHeader)item, items, pt);

                    else if (item is GridPanel)
                        DropSgPanel((GridPanel)item, items);
                }
                else
                {
                    if (item is GridCell)
                    {
                        if (_SrcElement is GridRow)
                            DropRow(e, ((GridCell) item).GridRow);
                        else
                            DropCell(e, (GridCell) item);
                    }
                    else if (item is GridRow)
                        DropRow(e, (GridRow)item);

                    else if (item is GridColumnHeader)
                        DropColumnHeader(e, (GridColumnHeader)item, pt);
                }

                ClearDragHighlight();
            }
        }

        #region ClearStyles

        private void ClearStyles(SuperGridControl sgrid)
        {
            GridPanel panel = sgrid.PrimaryGrid;

            foreach (GridRow row in panel.Rows)
            {
                foreach (GridCell cell in row.Cells)
                    cell.CellStyles.Default = null;
            }
        }

        #endregion

        #endregion

        #region SG_DragDrop

        #region DropSgCell

        /// <summary>
        /// Handles Dropping data on a GridCell
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="cells"></param>
        private void DropSgCell(GridCell cell, IEnumerable<GridElement> cells)
        {
            StringBuilder sb = new StringBuilder();

            foreach (GridCell droppedCell in cells)
            {
                if (droppedCell.Value != null)
                {
                    sb.Append(droppedCell.Value.ToString());
                    sb.Append(", ");
                }
            }

            if (sb.Length > 0)
                sb.Length -= 2;

            cell.Value = sb.ToString();
            cell.CellStyles.Default.TextColor = Color.Red;
        }

        #endregion

        #region DropSgRow

        /// <summary>
        /// Handles dropping row data on a SuperGrid
        /// </summary>
        /// <param name="e"></param>
        /// <param name="row"></param>
        /// <param name="rows"></param>
        private void DropSgRow(DragEventArgs e,
            GridRow row, IEnumerable<GridElement> rows)
        {
            if (e.Effect == DragDropEffects.Move)
            {
                if (row.IsSelected == false)
                    MoveSgRows(row, rows);
            }
            else
            {
                CopySgRows(row, rows);
            }
        }

        #endregion

        #region CopySgRows

        /// <summary>
        /// Handles copying GridRow data into a SuperGrid
        /// </summary>
        /// <param name="row"></param>
        /// <param name="rows"></param>
        private void CopySgRows(GridRow row, IEnumerable<GridElement> rows)
        {
            GridPanel panel = row.GridPanel;

            foreach (GridRow item in rows)
            {
                if (row == null)
                {
                    row = new GridRow();
                    panel.Rows.Add(row);
                }

                int n = Math.Min(item.Cells.Count, panel.Columns.Count);

                for (int i = 0; i < n; i++)
                {
                    GridCell cell = item.Cells[i];

                    string value = cell.Value.ToString();

                    if (i >= row.Cells.Count)
                    {
                        row.Cells.Add(new GridCell(value));
                    }
                    else
                    {
                        if (cell.Value != null)
                        {
                            row.Cells[i].Value = value;
                            row.Cells[i].CellStyles.Default.TextColor = Color.Red;
                        }
                    }
                }

                row = row.NextVisibleRow as GridRow;
            }
        }

        #endregion

        #region MoveSgRows

        /// <summary>
        /// Handles moving GridRows within the same SuperGrid
        /// </summary>
        /// <param name="row"></param>
        /// <param name="rows"></param>
        private void MoveSgRows(GridRow row, IEnumerable<GridElement> rows)
        {
            GridPanel panel = row.GridPanel;

            foreach (GridRow item in rows)
                panel.Rows.Remove(item);

            int n = row.RowIndex;

            foreach (GridRow item in rows)
            {
                panel.Rows.Insert(n, item);

                foreach (GridCell cell in item.Cells)
                    cell.CellStyles.Default.TextColor = Color.Red;
            }
        }

        #endregion

        #region DropSgColumnHeader

        /// <summary>
        /// Handles dropping data onto a ColumnHeader
        /// </summary>
        /// <param name="item"></param>
        /// <param name="items"></param>
        /// <param name="pt"></param>
        private void DropSgColumnHeader(GridColumnHeader item,
            IEnumerable<GridElement> items, Point pt)
        {
            GridColumn column = item.GetHitColumn(pt);

            if (column != null)
            {
                if (_SrcElement is GridColumn)
                    DropSgColumns(column, items);
                else
                    DropSgPanel(item.GridPanel, items);
            }
        }

        #region DropSgColumns

        private void DropSgColumns(GridColumn column, IEnumerable<GridElement> cols)
        {
            GridPanel panel1 = _SrcGrid.PrimaryGrid;
            GridPanel panel2 = column.GridPanel;

            if (panel1.Rows.Count > panel2.Rows.Count)
            {
                for (int i = panel2.Rows.Count; i < panel1.Rows.Count; i++)
                    panel2.Rows.Add(new GridRow("", "", ""));
            }

            foreach (GridColumn item in cols)
            {
                if (column == null || column.EditorType != item.EditorType)
                    break;

                int index1 = item.ColumnIndex;
                int index2 = column.ColumnIndex;

                for (int i = 0; i < panel1.Rows.Count; i++)
                {
                    GridRow row1 = (GridRow) panel1.Rows[i];
                    GridRow row2 = (GridRow) panel2.Rows[i];

                    GridCell cell = row1.Cells[index1];

                    object value = cell.Value;

                    if (index2 >= row2.Cells.Count)
                    {
                        for (int j = row2.Cells.Count; j < index2; j++)
                        {
                            cell = new GridCell("");
                            cell.CellStyles.Default.TextColor = Color.Red;

                            row2.Cells.Add(cell);
                        }

                        row2.Cells.Add(new GridCell());
                    }

                    row2.Cells[index2].Value = value;
                    row2.Cells[index2].CellStyles.Default.TextColor = Color.Red;
                }

                column = column.NextVisibleColumn;
            }
        }

        #endregion

        #endregion

        #region DropSgPanel

        /// <summary>
        /// Handles dropping data on a GridPanel
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="rows"></param>
        private void DropSgPanel(GridPanel panel, IEnumerable<GridElement> rows)
        {
            GridRow lastRow = null;

            foreach (GridRow item in rows)
            {
                GridRow row = new GridRow();

                for (int i = 0; i < item.Cells.Count; i++)
                {
                    GridCell cell = item.Cells[i];

                    cell = new GridCell(cell.Value);
                    cell.CellStyles.Default.TextColor = Color.Red;

                    row.Cells.Add(cell);
                }

                panel.Rows.Add(row);

                lastRow = row;
            }

            if (lastRow != null)
                lastRow.EnsureVisible();
        }

        #endregion

        #endregion

        #region NSG_DragDrop

        #region DropCell

        /// <summary>
        /// Handles dropping non-grid data on a grid cell
        /// </summary>
        /// <param name="e"></param>
        /// <param name="cell"></param>
        private void DropCell(DragEventArgs e, GridCell cell)
        {
            StringBuilder sb = new StringBuilder();

            if (e.Data.GetDataPresent(typeof(string)) == true)
            {
                string s = (string)e.Data.GetData(typeof(string));

                sb.Append(s);
            }
            else if (e.Data.GetDataPresent(typeof(TreeNode)) == true)
            {
                TreeNode tnode = (TreeNode)e.Data.GetData(typeof(TreeNode));

                sb.Append(tnode.Text);
            }
            else if (e.Data.GetDataPresent(typeof(Node)) == true)
            {
                Node node = (Node) e.Data.GetData(typeof (Node));

                foreach (Cell droppedCell in node.Cells)
                {
                    sb.Append(droppedCell.Text);
                    sb.Append(", ");
                }

                if (sb.Length > 0)
                    sb.Length -= 2;
            }
            else if (e.Data.GetDataPresent(typeof(Node[])) == true)
            {
                Node[] nodes = (Node[])e.Data.GetData(typeof(Node[]));

                foreach (Node node in nodes)
                {
                    foreach (Cell droppedCell in node.Cells)
                    {
                        sb.Append(droppedCell.Text);
                        sb.Append(", ");
                    }

                    if (sb.Length > 0)
                        sb.Length -= 2;
                }
            }

            cell.Value = sb.ToString();
            cell.CellStyles.Default.TextColor = Color.Red;
        }

        #endregion

        #region DropRow

        /// <summary>
        /// Handles dropping non-grid data on a grid row
        /// </summary>
        /// <param name="e"></param>
        /// <param name="row"></param>
        private void DropRow(DragEventArgs e, GridRow row)
        {
            GridPanel panel = row.GridPanel;

            if (e.Data.GetDataPresent(typeof(string)) == true)
            {
                string s = (string)e.Data.GetData(typeof(string));

                DropTextRow(row, s.Split(','));
            }
            else if (e.Data.GetDataPresent(typeof(TreeNode)) == true)
            {
                TreeNode tnode = (TreeNode)e.Data.GetData(typeof(TreeNode));

                DropTextRow(row, tnode.Text.Split(','));
            }
            else if (e.Data.GetDataPresent(typeof(Node)) == true)
            {
                Node node = (Node)e.Data.GetData(typeof(Node));

                DropNodeRow(row, node.Cells);
            }
            else if (e.Data.GetDataPresent(typeof(Node[])) == true)
            {
                Node[] nodes = (Node[])e.Data.GetData(typeof(Node[]));

                foreach (Node node in nodes)
                {
                    if (row == null)
                    {
                        row = new GridRow();

                        panel.Rows.Add(row);
                    }

                    DropNodeRow(row, node.Cells);

                    row = row.NextVisibleRow as GridRow;
                }
            }
        }

        #region DropNodeRow

        private void DropNodeRow(GridRow row, CellCollection cells)
        {
            string[] text = new string[cells.Count];

            for (int i = 0; i < cells.Count; i++)
                text[i] = cells[i].Text;

            DropTextRow(row, text);
        }

        #endregion

        #region DropTextRow

        private void DropTextRow(GridRow row, string[] s)
        {
            GridPanel panel = row.GridPanel;

            int n = Math.Min(s.Length, panel.Columns.Count);

            for (int i = 0; i < n; i++)
            {
                if (i >= row.Cells.Count)
                    row.Cells.Add(new GridCell());

                row.Cells[i].Value = s[i];
                row.Cells[i].CellStyles.Default.TextColor = Color.Red;
            }

            row.EnsureVisible(false);
        }

        #endregion

        #endregion

        #region DropColumnHeader

        /// <summary>
        /// Handles dropping non-grid data on a grid column header
        /// </summary>
        /// <param name="e"></param>
        /// <param name="header"></param>
        /// <param name="pt"></param>
        private void DropColumnHeader(
            DragEventArgs e, GridColumnHeader header, Point pt)
        {
            GridColumn column = header.GetHitColumn(pt);

            if (column != null)
            {
                GridPanel panel = column.GridPanel;

                GridRow row = new GridRow();
                panel.Rows.Add(row);

                if (e.Data.GetDataPresent(typeof(string)) == true)
                {
                    string s = (string)e.Data.GetData(typeof(string));

                    DropTextRow(row, s.Split(','));
                }
                else if (e.Data.GetDataPresent(typeof(TreeNode)) == true)
                {
                    TreeNode tnode = (TreeNode) e.Data.GetData(typeof (TreeNode));

                    DropTextRow(row, tnode.Text.Split(','));
                }
                else if (e.Data.GetDataPresent(typeof (Node)) == true)
                {
                    Node node = (Node) e.Data.GetData(typeof (Node));

                    DropNodeRow(row, node.Cells);
                }
                else if (e.Data.GetDataPresent(typeof (Node[])) == true)
                {
                    Node[] nodes = (Node[]) e.Data.GetData(typeof (Node[]));

                    foreach (Node node in nodes)
                    {
                        if (row == null)
                        {
                            row = new GridRow();

                            panel.Rows.Add(row);
                        }

                        DropNodeRow(row, node.Cells);

                        row = row.NextVisibleRow as GridRow;
                    }
                }
            }
        }

        #endregion

        #endregion

        #region SuperGridControlDragLeave

        /// <summary>
        /// Handles SuperGrid DragLeave events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControlDragLeave(object sender, EventArgs e)
        {
            // Make sure our highlights are cleared

            ClearDragHighlight();
        }

        #endregion

        #region ClearDragHighlight

        /// <summary>
        /// Clears all temporary grid highlights
        /// </summary>
        private void ClearDragHighlight()
        {
            if (_DragOverRow != null)
                _DragOverRow.CellStyles.Default.Background = null;

            if (_DragOverCell != null)
                _DragOverCell.CellStyles.Default.Background = null;

            if (_DragOverColumn != null)
                _DragOverColumn.CellStyles.Default.Background = null;
        }

        #endregion

        #endregion

        #region TreeView support

        #region TreeView1MouseDown

        /// <summary>
        /// Handles TreeView MouseDown events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeView1MouseDown(object sender, MouseEventArgs e)
        {
            TreeView tv = sender as TreeView;

            if (tv != null)
            {
                _MouseDownPoint = Point.Empty;

                if (e.Button == MouseButtons.Left)
                {
                    TreeNode node = tv.GetNodeAt(e.Location);

                    if (node.IsSelected == true)
                        _MouseDownPoint = e.Location;
                }
            }
        }

        #endregion

        #region TreeView1MouseMove

        /// <summary>
        /// Handles TreeView MouseMove events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeView1MouseMove(object sender, MouseEventArgs e)
        {
            TreeView tv = sender as TreeView;

            if (tv != null)
            {
                if (MouseButtons == MouseButtons.Left)
                {
                    if (_MouseDownPoint.IsEmpty == false)
                    {
                        if (DragStarted(_MouseDownPoint, e.Location) == true)
                        {
                            _MouseDownPoint = Point.Empty;

                            TreeNode node = tv.GetNodeAt(e.Location);

                            tv.DoDragDrop(node.Text, DragDropEffects.Copy);
                        }
                    }
                }
            }
        }

        #endregion

        #region TreeView1DragOver

        /// <summary>
        /// Handles TreeView DragOver events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeView1DragOver(object sender, DragEventArgs e)
        {
            TreeView tv = sender as TreeView;

            if (tv != null)
            {
                // Let's only accept drops from the SuperGrid

                if (_SrcElement != null)
                    e.Effect = DragDropEffects.Copy | DragDropEffects.Move;
            }
        }

        #endregion

        #region TreeView1DragDrop

        /// <summary>
        /// Handles SuperGrid drag drops
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeView1DragDrop(object sender, DragEventArgs e)
        {
            TreeView tv = sender as TreeView;

            if (tv != null)
            {
                ClearNodeStyles(tv);

                Point clientPoint = tv.PointToClient(new Point(e.X, e.Y));
                TreeNode node = tv.GetNodeAt(clientPoint.X, clientPoint.Y);

                if (e.Data.GetDataPresent(typeof(SelectedElementCollection)) == true)
                {
                    SelectedElementCollection rows =
                        (SelectedElementCollection) e.Data.GetData(typeof (SelectedElementCollection));

                    if (rows[0] is GridRow)
                    {
                        StringBuilder sb = new StringBuilder();

                        foreach (GridRow item in rows)
                        {
                            if (node == null)
                            {
                                node = new TreeNode();
                                tv.Nodes.Add(node);
                            }

                            sb.Length = 0;

                            for (int i = 0; i < item.Cells.Count; i++)
                            {
                                GridCell cell = item.Cells[i];

                                sb.Append(cell.Value);
                                sb.Append(", ");
                            }

                            sb.Length -= 2;

                            node.Text = sb.ToString();
                            node.ForeColor = Color.Red;

                            node = node.NextVisibleNode;
                        }
                    }
                }
            }
        }

        #region ClearStyles

        /// <summary>
        /// Clears all TreeNode highlights
        /// </summary>
        /// <param name="tv"></param>
        private void ClearNodeStyles(TreeView tv)
        {
            foreach (TreeNode node in tv.Nodes)
                node.ForeColor = Color.Black;
        }

        #endregion

        #endregion

        #endregion

        #region ListBox support

        #region ListBox1MouseDown

        /// <summary>
        /// Handles ListBox MouseDown events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox1MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                _MouseDownPoint = Point.Empty;

                if (e.Button == MouseButtons.Left)
                {
                    int index = lb.IndexFromPoint(e.Location);

                    if (index >= 0)
                    {
                        if (lb.SelectedItems.Contains(lb.Items[index]))
                            _MouseDownPoint = e.Location;
                    }
                }
            }
        }

        #endregion

        #region ListBox1MouseMove

        /// <summary>
        /// Handles ListBox MouseMove events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox1MouseMove(object sender, MouseEventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                if (MouseButtons == MouseButtons.Left)
                {
                    if (_MouseDownPoint.IsEmpty == false)
                    {
                        if (DragStarted(_MouseDownPoint, e.Location) == true)
                        {
                            _MouseDownPoint = Point.Empty;

                            int index = lb.IndexFromPoint(e.Location);

                            if (index >= 0)
                                lb.DoDragDrop(lb.SelectedItem.ToString(), DragDropEffects.Copy);
                        }
                    }
                }
            }
        }

        #endregion

        #region ListBox1DragOver

        /// <summary>
        /// Handles ListBox DragOver events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox1DragOver(object sender, DragEventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                // Let's only accept SuperGrid drag drop requests

                if (_SrcElement != null)
                    e.Effect = DragDropEffects.Copy | DragDropEffects.Move;
            }
        }

        #endregion

        #region ListBox1DragDrop

        /// <summary>
        /// Handles SuperGrid drag drop requests
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox1DragDrop(object sender, DragEventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (lb != null)
            {
                Point clientPoint = lb.PointToClient(new Point(e.X, e.Y));
                int index = lb.IndexFromPoint(clientPoint);

                if (index >= 0)
                {
                    if (e.Data.GetDataPresent(typeof (SelectedElementCollection)) == true)
                    {
                        SelectedElementCollection rows =
                            (SelectedElementCollection) e.Data.GetData(typeof (SelectedElementCollection));

                        if (rows[0] is GridRow)
                        {
                            StringBuilder sb = new StringBuilder();

                            foreach (GridRow item in rows)
                            {
                                if (index >= lb.Items.Count)
                                    lb.Items.Add("");

                                sb.Length = 0;

                                for (int i = 0; i < item.Cells.Count; i++)
                                {
                                    GridCell cell = item.Cells[i];

                                    sb.Append(cell.Value);
                                    sb.Append(", ");
                                }

                                sb.Length -= 2;

                                lb.Items[index++] = sb.ToString();
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #endregion

        #region DragStarted

        /// <summary>
        /// Determins when to initiate a Drag operation
        /// </summary>
        /// <param name="pt1"></param>
        /// <param name="pt2"></param>
        /// <returns></returns>
        private bool DragStarted(Point pt1, Point pt2)
        {
            Rectangle r = new Rectangle(pt1.X, pt1.Y, 0, 0);

            r.Inflate(SystemInformation.DragSize.Width,
                SystemInformation.DragSize.Height);

            return (r.Contains(pt2.X, pt2.Y) == false);
        }

        #endregion
    }
}