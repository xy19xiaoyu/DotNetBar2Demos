using System;
using System.Text;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace SuperGridDemo
{
    public partial class DemoGridBasics0 : Office2007Form
    {
        #region Private variables

        private Random _Rand = new Random();

        #endregion

        public DemoGridBasics0()
        {
            InitializeComponent();

            // Initialize the grid and set the sample description text

            InitializeGrid();

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoBasics0.rtf");
        }

        #region InitializeGrid

        /// <summary>
        /// initializes the grid
        /// </summary>
        private void InitializeGrid()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            // Set the "Start/Stop" column editor type to our
            // own defined MyGridButtonXEditControl.

            GridColumn column = panel.Columns["Start/Stop"];
            column.EditorType = typeof(MyGridButtonXEditControl);

            // Add 30 rows for the user to play around with

            for (int i = 0; i < 30; i++)
                panel.Rows.Add(GetNewRow());

            // Tell the SuperGrid that we want to be informed when any cell
            // Value changes, and when a new row needs its default values set.

            superGridControl1.CellValueChanged += SuperGridControl1CellValueChanged;
            superGridControl1.RowSetDefaultValues += SuperGridControl1RowSetDefaultValues;
        }

        #endregion

        #region SuperGridControl1RowSetDefaultValues

        /// <summary>
        /// This routine is called to let the application set default
        /// cell values for the given row.
        /// 
        /// This routine will be called with 2 possible contexts - 
        /// new row initialization and new row activation.
        /// 
        /// New rows added by the user selecting a row and pressing the
        /// "ins" key, will result in this routine being called with a
        /// e.NewRowContext equal to NewRowContext.RowInit.
        /// 
        /// When a new InsertRow (the row at the very bottom of the grid) is
        /// created, this routine will be called to permit the application to
        /// initialize it to a set of default values. The e.GridRow.IsInsertRow
        /// can be tested to see which if the InsertRow is the row being set.
        /// 
        /// When the user activate the InsertRow, this routine will also be
        /// called to let the application set - or reset - the values again.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1RowSetDefaultValues(
            object sender, GridRowSetDefaultValuesEventArgs e)
        {
            // We only want to initialize new rows upon their creation,
            // not each time they are activated (only applicable to the InsertRow).

            if (e.NewRowContext == NewRowContext.RowInit)
            {
                GridRow row = e.GridRow;

                row.Cells[0].Value = GetMachineName();
                row.Cells[1].Value = false;
                row.Cells[2].Value = false;
                row.Cells[3].Value = DateTime.Now;

                row.Cells[4].Value = "Start";
                row.Cells[4].Visible = false;
            }
        }

        #endregion

        #region SuperGridControl1CellValueChanged

        /// <summary>
        /// This routine is called whenever a grid cell value changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1CellValueChanged(
            object sender, GridCellValueChangedEventArgs e)
        {
            GridCell cell = e.GridCell;

            // If the cell changing value is in the "Power State" column
            // then adjust the row "Start/Stop" cell appropriately

            if (cell.GridColumn.Name.Equals("Power State") == true)
            {
                GridRow row = cell.GridRow;

                // Hide the cell if the switch button is off
                // and reset the cell's value back to the "Start" state

                row.Cells["Start/Stop"].Visible = (bool)e.NewValue;
                row.Cells["Start/Stop"].Value = (bool)e.NewValue ? "Start" : "Hidden";
            }
        }

        #endregion

        #region GetNewRow

        /// <summary>
        /// Creates a new GridRow
        /// </summary>
        /// <returns></returns>
        private GridRow GetNewRow()
        {
            // GridRows can be created with varying parameters set
            // to the GridRow constructor. In this case we are
            // sending a variable list of parameters.

            string machine = GetMachineName();
            bool dualVoltage = _Rand.Next() % 2 == 0;
            bool powerConnected = _Rand.Next() % 2 == 0;
            DateTime date = DateTime.Now.AddDays(-_Rand.NextDouble() * 1000);

            GridRow row = new GridRow(
                machine,
                dualVoltage,
                powerConnected,
                date,
                powerConnected ? "Start" : "Hidden");

            // If the "power is not connected" then set the
            // "Start/Stop" cell to be hidden by default

            if (powerConnected == false)
                row.Cells[4].Visible = false;

            return (row);
        }

        #endregion

        #region GetMachineName

        /// <summary>
        /// Creates and returns a dummy Machine name
        /// </summary>
        /// <returns>Machine name</returns>
        private string GetMachineName()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 3; i++)
            {
                int n = _Rand.Next(2, 4);

                for (int j = 0; j < n; j++)
                {
                    sb.Append(
                        (char)(65 + _Rand.Next(0, 26)));
                }

                sb.Append('-');
            }

            sb.Length--;

            return (sb.ToString());
        }

        #endregion

        #region MyGridButtonXEditControl

        /// <summary>
        /// GridButtonXEditControl Class that controls the
        /// ButtonX color initialization and user button clicks.
        /// </summary>
        private class MyGridButtonXEditControl : GridButtonXEditControl
        {
            /// <summary>
            /// Constructor
            /// </summary>
            public MyGridButtonXEditControl()
            {
                // We want to be notified when the user clicks the button
                // so that we can change the underlying cell value to reflect
                // the mouse click.

                Click += MyGridButtonXEditControlClick;
            }

            #region InitializeContext

            /// <summary>
            /// Initializes the color table for the button
            /// </summary>
            /// <param name="cell"></param>
            /// <param name="style"></param>
            public override void
                InitializeContext(GridCell cell, CellVisualStyle style)
            {
                base.InitializeContext(cell, style);

                bool running = Text.Equals("Stop") == false;

                ColorTable = (running == true)
                    ? eButtonColor.OrangeWithBackground
                    : eButtonColor.BlueOrb;
            }

            #endregion

            #region MyGridButtonXEditControlClick

            /// <summary>
            /// Handles user clicks of the button
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void MyGridButtonXEditControlClick(object sender, EventArgs e)
            {
                bool running = (EditorCell.Value != null &&
                    EditorCell.Value.Equals("Start"));

                EditorCell.Value = (running == true) ? "Stop" : "Start";
            }

            #endregion
        }

        #endregion

        #region CbxAutoDeleteCheckedChanged

        /// <summary>
        /// Handles user change of whether the grid should
        /// auto-hide deleted rows.  The default is true.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxAutoDeleteCheckedChanged(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.AutoHideDeletedRows = cbxAutoDelete.Checked;
        }

        #endregion

        #region BtnHideDelRowsClick

        /// <summary>
        /// Hides all deleted rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHideDelRowsClick(object sender, EventArgs e)
        {
            // You can use the following call to determine
            // what the currently "Active" grid is. In our case
            // this will always be equal to our PrimaryGrid.

            GridPanel panel = superGridControl1.ActiveGrid;

            superGridControl1.BeginUpdate();

            foreach (GridContainer row in panel.FlatDeletedRows)
                row.Visible = false;

            superGridControl1.EndUpdate();
        }

        #endregion

        #region BtnShowDelRowsClick

        /// <summary>
        /// Shows all currently deleted rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowDelRowsClick(object sender, EventArgs e)
        {
            GridPanel panel = superGridControl1.ActiveGrid;

            superGridControl1.BeginUpdate();

            foreach (GridContainer row in panel.FlatDeletedRows)
                row.Visible = true;

            superGridControl1.EndUpdate();
        }

        #endregion

        #region CbxCaptionCheckedChanged

        /// <summary>
        /// Shows or hides the grid Caption
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxCaptionCheckedChanged(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.Caption.Visible = cbxCaption.Checked;
        }

        #endregion

        #region CbxTitleCheckedChanged

        /// <summary>
        /// Shows or hides the grid Title
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxTitleCheckedChanged(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.Title.Visible = cbxTitle.Checked;
        }

        #endregion

        #region CbxHeaderCheckedChanged

        /// <summary>
        /// Shows or hides the grid header
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxHeaderCheckedChanged(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.Header.Visible = cbxHeader.Checked;
        }

        #endregion

        #region CbxFooterCheckedChanged

        /// <summary>
        /// Shows or hides the grid Footer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxFooterCheckedChanged(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.Footer.Visible = cbxFooter.Checked;
        }

        #endregion

        #region CbxRowHeadersCheckedChanged

        /// <summary>
        /// Shows or hides the RowHeaders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxRowHeadersCheckedChanged(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.ShowRowHeaders = cbxRowHeaders.Checked;
        }

        #endregion

        #region CbxGridIndexCheckedChanged

        /// <summary>
        /// Enables or disables the showing of the row
        /// GridIndex in each row header
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxGridIndexCheckedChanged(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.ShowRowGridIndex = cbxGridIndex.Checked;
        }

        #endregion

        #region BtnPurgeRowsClick

        /// <summary>
        /// Purges all currently deleted rows.
        /// 
        /// When rows are deleted, they are marked as deleted and
        /// potentially hidden. To actually irreversibly remove deleted
        /// rows from the grid, they must be purged.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPurgeRowsClick(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.PurgeDeletedRows();
        }

        #endregion
    }
}