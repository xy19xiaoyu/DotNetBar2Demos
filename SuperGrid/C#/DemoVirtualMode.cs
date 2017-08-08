using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace SuperGridDemo
{
    public partial class DemoVirtualMode : Office2007Form
    {
        public DemoVirtualMode()
        {
            InitializeComponent();

            // Set the sample description text
            
            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoVirtualMode.rtf");
        }

        #region SuperGridControl1LoadVirtualRow

        /// <summary>
        /// This routine is called by the grid when it needs a
        /// given virtual row to be loaded.  All of the row cells
        /// have been allocated prior to this call.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1LoadVirtualRow(object sender, GridVirtualRowEventArgs e)
        {
            GridRow row = e.GridRow;
            GridPanel panel = e.GridPanel;

            int index = row.Index;

            // We'll pretend, for this example, to do sorting by just
            // reversing the index when ask to sort descending

            if (panel.SortColumns.Count > 0)
            {
                GridColumn column = panel.SortColumns[0];

                if (column.SortDirection == SortDirection.Descending)
                    index = panel.VirtualRowCount - row.Index - 1;
            }

            // For this demo sample, we will save and restore any
            // user changed data. So, before initializing a new default
            // row, look to see if we have it tucked away already.

            Dictionary<int, string> vdata = panel.Tag as Dictionary<int, string>;

            if (vdata != null)
            {
                string value;

                if (vdata.TryGetValue(index, out value) == true)
                {
                    string[] s = value.Split(';');

                    for (int i = 0; i < panel.Columns.Count; i++)
                        row.Cells[i].Value = s[i];

                    row.RowDirty = true;

                    return;
                }
            }

            // Fill the cell data in with some nonsense data

            for (int i = 0; i < panel.Columns.Count; i++)
            {
                row.Cells[i].Value =
                    String.Format("Row {0}, Cell {1}", index, i);
            }
        }

        #endregion

        #region SuperGridControl1StoreVirtualRow

        /// <summary>
        /// This routine is called by the grid whenever a user has
        /// modified the row contents (ie made the row "Dirty").
        /// 
        /// In this example we will save the changed data in our local
        /// store so that it can be retrieved later, if need be.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1StoreVirtualRow(object sender, GridVirtualRowEventArgs e)
        {
            GridRow row = e.GridRow;
            GridPanel panel = e.GridPanel;

            int index = e.Index;

            Dictionary<int, string> vdata = e.GridPanel.Tag as Dictionary<int, string>;

            if (vdata == null)
            {
                vdata = new Dictionary<int, string>();

                panel.Tag = vdata;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < panel.Columns.Count; i++)
            {
                sb.Append(row.Cells[i].Value);
                sb.Append(";");
            }

            sb.Length--;

            vdata[index] = sb.ToString();
        }

        #endregion

        #region BtnLoadRowsClick

        /// <summary>
        /// Handles user requests to load the grid with 2,000,000 rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLoadRowsClick(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.VirtualRowCount = 2000000;

            superGridControl1.Focus();
        }

        #endregion

        #region BtnClearRowsClick

        /// <summary>
        /// Handles user requests to clear, or remove, all virtual rows.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClearRowsClick(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.VirtualRowCount = 0;

            superGridControl1.Focus();
        }

        #endregion

        #region CbxAltRowStyleCheckedChanged

        /// <summary>
        /// Handles user requests to display the data using
        /// the AlternateRowStyle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxAltRowStyleCheckedChanged(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.UseAlternateRowStyle = CbxAltRowStyle.Checked;

            superGridControl1.Focus();
        }

        #endregion

        #region CbxAltColStyleCheckedChanged

        /// <summary>
        /// Handles user requests to display the data using
        /// the AlternateColumnStyle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxAltColStyleCheckedChanged(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.UseAlternateColumnStyle = CbxAltColStyle.Checked;

            superGridControl1.Focus();
        }

        #endregion
    }
}