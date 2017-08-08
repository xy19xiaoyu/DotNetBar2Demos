using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace SuperGridDemo
{
    public partial class DemoFileExplorer : Office2007Form
    {
        #region Private variables

        private int _SizeIndex;

        #endregion

        public DemoFileExplorer()
        {
            InitializeComponent();

            // Initialize our grid and
            // set the sample description text

            InitializeGrid();

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoFileExplorer.rtf");
        }

        #region InitializeGrid

        private void InitializeGrid()
        {
            // Save the index of the "Size" column for later use
            // and populate our grid with the system drives

            _SizeIndex = superGridControl2.PrimaryGrid.Columns["Size"].ColumnIndex;

            PopulateDriveRows();
        }

        #endregion

        #region SuperGridControl1

        #region PopulateDriveRows

        /// <summary>
        /// Populates the grid with the current
        /// discoverable system drives
        /// </summary>
        private void PopulateDriveRows()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Fixed)
                {
                    // Allocate a new GridRow for the drive, with the
                    // first cell allocated and set to the drive name.

                    GridRow drow = new GridRow(drive.Name);

                    // Let the height auto-size

                    drow.RowHeight = 0;

                    // The RowsUnresolved property is a convenient mechanism
                    // to tell the grid that the row may have nested rows, but
                    // that fact has not yet been determined.
                    // 
                    // Later, when the user clicks on the row's expand button, the
                    // application then can then resolve the row state by doing 2 things:
                    //
                    // 1 - Clear the RowsUnresolved property (as, whether there are nested
                    //     rows or not) it is now resolved.
                    //
                    // 2 - Determine whether there are in fact any nested rows or
                    //     not and load them into the grid if there are.

                    drow.RowsUnresolved = true;

                    // Save the root directory path for use later if
                    // the user clicks on the expand button

                    drow.Tag = drive.RootDirectory.FullName;

                    // Set the cell image to the drive icon

                    drow.Cells[0].CellStyles.Default.Image =
                        ShellServices.GetFileImage(drive.Name, true, false);

                    // Add the row to the panel

                    panel.Rows.Add(drow);
                }
            }
        }

        #endregion

        #region PopulateDirectoryRows

        /// <summary>
        /// Populates the grid container 
        /// with the contents of a given directory.
        /// </summary>
        /// <param name="path">Directory path</param>
        /// <param name="row">Container to add the entries into</param>
        private void PopulateDirectoryRows(string path, GridContainer row)
        {
            string[] directories = new string[] { };

            try
            {
                // Get the directory entries

                directories = Directory.GetDirectories(path);
            }
            catch
            {
            }

            // Add each non-hidden, non-system directories into the container

            if (directories.Length > 100)
                Cursor = Cursors.AppStarting;

            foreach (string directory in directories)
            {
                DirectoryInfo info = new DirectoryInfo(directory);

                if ((info.Attributes & (FileAttributes.Hidden | FileAttributes.System)) == 0)
                {
                    // Allocate a new GridRow for the directory entry, with
                    // the first cell allocated and set to the directory name

                    GridRow frow = new GridRow(info.Name);

                    // Let it's row height auto-size

                    frow.RowHeight = 0;

                    // Tell the grid that the row might have nested rows
                    // under it, which we will determine if / when the user
                    // clicks on the row's expand button

                    frow.RowsUnresolved = true;

                    // Set the Tag value to the directory, so we can use it later
                    // to resolve and potentially load any discovered entries

                    frow.Tag = directory;

                    // Set the cell image to the directory icon

                    frow.Cells[0].CellStyles.Default.Image =
                        ShellServices.GetFileImage(directory, false, false);

                    // Add the row to the container

                    row.Rows.Add(frow);
                }
            }
        }

        #endregion

        #region PopulateDirectoryFiles

        /// <summary>
        /// Populates the given container with files from
        /// the given directory path.
        /// </summary>
        /// <param name="path">Directory path</param>
        /// <param name="row">Container to add files into</param>
        private void PopulateDirectoryFiles(string path, GridContainer row)
        {
            string[] files = new string[] { };

            try
            {
                // Get the directory files

                files = Directory.GetFiles(path);
            }
            catch
            {
            }

            // Add each non-hidden, non-system file
            // into the container

            if (files.Length > 100)
                Cursor = Cursors.AppStarting;

            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);

                if ((info.Attributes & (FileAttributes.Hidden | FileAttributes.System)) == 0)
                {
                    // Allocate a GridRow, with the first cell contents
                    // being allocated and set to the file's name

                    GridRow frow = new GridRow(info.Name);

                    // Let the row height auto-size

                    frow.RowHeight = 0;

                    // Save the file path for future use

                    frow.Tag = file;

                    // Set the cell image to the file icon

                    frow.Cells[0].CellStyles.Default.Image =
                        ShellServices.GetFileImage(file, false, false);

                    // Add the file to the container

                    row.Rows.Add(frow);
                }
            }
        }

        #endregion

        #region SuperGridControl1SelectionChanged

        /// <summary>
        /// This function will be called after
        /// every selection change in the grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">GridEventArgs</param>
        void SuperGridControl1SelectionChanged(object sender, GridEventArgs e)
        {
            GridPanel panel1 = superGridControl1.PrimaryGrid;
            GridPanel panel2 = superGridControl2.PrimaryGrid;

            superGridControl1.Update();

            // Clear all the rows in the right-hand grid.

            panel2.Rows.Clear();

            // Populate the right-hand grid with the selected files
            // from the left-hand grid.  At the same time, sum up the 
            // total size of the selected files.

            int count = 0;
            long size = 0;

            foreach (GridCell cell in panel1.SelectedCells)
            {
                string path = (string)cell.GridRow.Tag;

                FileInfo info = new FileInfo(path);

                if ((info.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                    size += PopulateDirectoryInfo(path, panel2, ref count);

                if (count % 20 == 0)
                    superGridControl2.Update();
            }

            // Set the right-hand grid's footer to a string
            // showing the total size of all the selected files.

            string s = string.Empty;

            if (count > 0)
            {
                s = String.Format("{0:N0} file{1}, Size: {2:N0} KB",
                      count, (count == 1 ? "" : "s"), Math.Ceiling((double)size / 1024));
            }

            panel2.Footer.Text = s;
        }

        #endregion

        #region SuperGridControl1BeforeExpand

        /// <summary>
        /// This routine is called when a user clicks on a row's
        /// expand button - but before the row is actually expanded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControl1BeforeExpand(
            object sender, GridBeforeExpandEventArgs e)
        {
            // If we have previously set that the row's nested
            // rows have not been discovered yet, do so now.

            if (e.GridContainer.RowsUnresolved == true)
            {
                // We don't want to expand every unresolved
                // row when the user performed an "ExpandAll" call.

                if (e.ExpandSource != ExpandSource.ExpandAll)
                {
                    // Mark the unresolved status as resolved

                    e.GridContainer.RowsUnresolved = false;

                    // And use the directory path we save earlier
                    // to populate the container with any discovered
                    // directories and Files.

                    string path = (string)e.GridContainer.Tag;

                    PopulateDirectoryRows(path, e.GridContainer);
                    PopulateDirectoryFiles(path, e.GridContainer);

                    Cursor = Cursors.Default;
                }
                else
                {
                    // Cancelling the operation here will keep this row from
                    // being expanded during an ExpandAll operation

                    e.Cancel = true;
                }
            }
        }

        #endregion

        #endregion

        #region SuperGridControl2

        #region SuperGridControl2BeginEdit

        /// <summary>
        /// This routine is called when the user attempts to edit
        /// a given cell. We are using this as an illustration of one way
        /// to prevent edits while yet keeping all other behavior and
        /// functionality the same. Edits could be canceled for any
        /// programmatic reason through this mechanism.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControl2BeginEdit(object sender, GridEditEventArgs e)
        {
            e.Cancel = true;
        }

        #endregion

        #region SuperGridControl2GetCellFormattedValue

        /// <summary>
        /// This routine is called to get the formatted value
        /// of the cell.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl2GetCellFormattedValue(
            object sender, GridGetCellFormattedValueEventArgs e)
        {
            // If the grid is asking for the formatted value of a cell
            // in the "Size" column, then format an appropriate display.

            if (e.GridCell.ColumnIndex == _SizeIndex)
            {
                long size = (long)e.GridCell.Value;

                e.FormattedValue = (size >= 1024)
                    ? Math.Ceiling((double)size / 1024) + " KB"
                    : size.ToString();
            }
        }

        #endregion

        #region SuperGridControl2RowsGrouped

        /// <summary>
        /// This routine is called after the grid has finished
        /// grouping rows together (when grouping is enabled).
        /// 
        /// Handling this event gives us the ability to perform
        /// styling - or any other panel, row, column, or cell (etc)
        /// level action needed on the grouped data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl2RowsGrouped(object sender, GridEventArgs e)
        {
            // Grouped rows are, by default, non-expanded. So now that the
            // grouping is complete we can tell the grid to go ahead and
            // expand all the created, expandable rows.

            e.GridPanel.ExpandAll();
        }

        #endregion

        #region PopulateDirectoryInfo

        /// <summary>
        /// This routine populates the right-hand grid with
        /// files discovered from the given directory path.
        /// </summary>
        /// <param name="path">Directory path</param>
        /// <param name="row">Container row</param>
        /// <param name="count">Count of files added</param>
        /// <returns>The total size of all files added</returns>
        private long PopulateDirectoryInfo(
            string path, GridContainer row, ref int count)
        {
            string[] files = new string[] { };

            try
            {
                // Get the directory files

                files = Directory.GetFiles(path);
            }
            catch
            {
            }

            // Add each discovered, non-hidden, non-system files
            // into the given container

            long totalSize = 0;

            if (files.Length > 100)
                Cursor = Cursors.AppStarting;

            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);

                if ((info.Attributes & (FileAttributes.Hidden | FileAttributes.System)) == 0)
                {
                    // Create an array of
                    // cell values to create the new row with.

                    long size = info.Length;

                    object[] s = new object[5];
                    s[0] = info.Name;
                    s[1] = size;
                    s[2] = ShellServices.GetFileType(file);
                    s[3] = info.CreationTime.ToShortDateString();
                    s[4] = info.LastAccessTime.ToShortDateString();

                    // Allocate a new row, giving it an array of objects
                    // to use in the creation of the row's Cells

                    GridRow frow = new GridRow(s);

                    // Let the rowheight auto-size and set the Tag value
                    // to the file path for future use.

                    frow.RowHeight = 0;
                    frow.Tag = file;

                    // Set the first cell's image to the file icon

                    frow.Cells[0].CellStyles.Default.Image =
                        ShellServices.GetFileImage(file, false, false);

                    // Add the row to the container, and
                    // update our running count and total size

                    row.Rows.Add(frow);

                    count++;
                    totalSize += size;
                }
            }

            Cursor = Cursors.Default;

            return (totalSize);
        }

        #endregion

        #region CbxGroupItemsCheckedChanged

        /// <summary>
        /// Handles the user request to either group
        /// or ungroup the grid rows - based upon the "Type" column
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxGroupItemsCheckedChanged(object sender, EventArgs e)
        {
            GridPanel panel = superGridControl2.PrimaryGrid;

            if (CbxGroupItems.Checked == true)
                panel.SetGroup(panel.Columns["Type"]);
            else
                panel.SetGroup();
        }

        #endregion

        #region SuperGridControl2CellDoubleClick

        /// <summary>
        /// Launches the associated program for the given file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControl2CellDoubleClick(
            object sender, GridCellDoubleClickEventArgs e)
        {
            string s = e.GridCell.GridRow.Tag as string;

            if (s != null)
                Process.Start(new ProcessStartInfo(s));
        }

        #endregion

        #endregion
    }
}