using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace SuperGridDemo
{
    public partial class Form1 : Office2007Form
    {
        public Form1()
        {
            InitializeComponent();

            InitializeGrid();

            ShellServices.LoadRtbText(rtb,
                "SuperGridDemo.Resources.Welcome.rtf");
        }

        #region InitializeGrid

        /// <summary>
        /// Initializes our base SuperGrid
        /// </summary>
        private void InitializeGrid()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            InitRowTags(panel);

            panel.SetGroup(panel.Columns[0], SortDirection.None);

            panel.ShowGroupExpand = false;
            panel.ShowGroupUnderline = false;

            superGridControl1.ColumnGrouped += SuperGridControl1ColumnGrouped;

            superGridControl1.ArrangeGrid();

            panel.ExpandAll();
        }

        #region InitRowTags

        /// <summary>
        /// Initialize each row Tag to the demo
        /// application to run when executed
        /// </summary>
        /// <param name="panel"></param>
        private void InitRowTags(GridPanel panel)
        {
            panel.Rows[0].Tag = typeof(DemoGridArchitecture);

            panel.Rows[1].Tag = typeof(DemoGridBasics0);
            panel.Rows[2].Tag = typeof(DemoGridBasics1);
            panel.Rows[3].Tag = typeof(DemoGridBasics2);
            panel.Rows[4].Tag = typeof(DemoGridBasics3);
            panel.Rows[5].Tag = typeof(DemoGridBasics4);
            panel.Rows[6].Tag = typeof(DemoGridBasics5);

            panel.Rows[7].Tag = typeof(DemoGridBinding);
            panel.Rows[8].Tag = typeof(DemoMasterDetail);
            panel.Rows[9].Tag = typeof(DemoNested);
            panel.Rows[10].Tag = typeof(DemoVirtualMode);

            panel.Rows[11].Tag = typeof(DemoBasicFiltering);
            panel.Rows[12].Tag = typeof(DemoExtendedFiltering);

            panel.Rows[13].Tag = typeof(DemoFileExplorer);
            panel.Rows[14].Tag = typeof(DemoSpreadsheet);
            panel.Rows[15].Tag = typeof(DemoUserEdit);
            panel.Rows[16].Tag = typeof(DemoDragDrop);
        }

        #endregion

        #endregion

        #region SuperGridControl1ColumnGrouped

        /// <summary>
        /// This routine is called when the column grouping
        /// is completed. This gives us the opportunity to set
        /// (or reset) any grid property that we need to pertaining
        /// to the newly established group rows.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1ColumnGrouped(object sender, GridColumnGroupedEventArgs e)
        {
            string s = e.GridGroup.Text;

            switch (s)
            {
                case "0":
                    e.GridGroup.Text = "Architecture";
                    break;

                case "1":
                    e.GridGroup.Text = "Edit and Render Controls";
                    break;

                case "2":
                    e.GridGroup.Text = "Data";
                    break;

                case "3":
                    e.GridGroup.Text = "Filtering";
                    break;

                case "4":
                    e.GridGroup.Text = "Samples";
                    break;
            }
        }

        #endregion

        #region SuperGridControl1MouseDoubleClick

        /// <summary>
        /// Called when an item is double clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControl1MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LaunchDemoItem();
        }

        #endregion

        #region SuperGridControl1KeyDown

        /// <summary>
        /// Called on key down to catch the enter key
        /// so we can launch the demo apps via the keyboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControl1KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                LaunchDemoItem();
        }

        #endregion

        #region LaunchDemoItem

        /// <summary>
        /// Performs the launching / execution of 
        /// the individual demo sample apps
        /// </summary>
        private void LaunchDemoItem()
        {
            GridRow row = superGridControl1.PrimaryGrid.ActiveRow as GridRow;

            if (row != null)
            {
                Type type = row.Tag as Type;

                if (type != null)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    Office2007Form form = (Office2007Form)Activator.CreateInstance(type);

                    if (type != typeof(DemoBasicFiltering) && type != typeof(DemoExtendedFiltering))
                        form.Icon = Icon;

                    form.Show(this);
                    form.Activate();
                }
            }
        }

        #endregion

        #region BtnCloseClick

        /// <summary>
        /// Closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}