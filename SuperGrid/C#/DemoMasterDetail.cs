using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Reflection;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace SuperGridDemo
{
    public partial class DemoMasterDetail : Office2007Form
    {
        #region Private properties

        private DataSet _DataSet;

        #endregion

        public DemoMasterDetail()
        {
            InitializeComponent();

            // Initialize the grid, bind to our grid data
            // and set the sample description text

            InitializeGrid();
            BindCustomerData();

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoMasterDetail.rtf");
        }

        #region InitializeGrid

        /// <summary>
        /// Initializes the default grid
        /// </summary>
        private void InitializeGrid()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            panel.Name = "Customers";
            panel.ShowToolTips = true;

            panel.MinRowHeight = 20;
            panel.AutoGenerateColumns = true;

            panel.SelectionGranularity = SelectionGranularity.Cell;

            superGridControl1.CellValueChanged += SuperGridControl1CellValueChanged;
            superGridControl1.GetCellStyle += SuperGridControl1GetCellStyle;
            superGridControl1.DataBindingComplete += SuperGridControl1DataBindingComplete;
        }

        #endregion

        #region BindCustomerData

        /// <summary>
        /// Binds our data to the grid
        /// </summary>
        private void BindCustomerData()
        {
            string location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Resources";

            if (location != null)
            {
                _DataSet = new DataSet();

                string path = Path.Combine(location, "nwind.mdb");

                using (OleDbConnection cn =
                    new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
                        + path + ";User Id=admin;Password=;"))
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Customers;", cn);
                    adapter.Fill(_DataSet, "Customers");

                    new OleDbDataAdapter("SELECT * FROM Orders;", cn).Fill(_DataSet, "Orders");
                    new OleDbDataAdapter("SELECT * FROM [Order Details];", cn).Fill(_DataSet, "Order Details");

                    _DataSet.Relations.Add("1", _DataSet.Tables["Customers"].Columns["CustomerID"],
                                           _DataSet.Tables["Orders"].Columns["CustomerID"], false);

                    _DataSet.Relations.Add("2", _DataSet.Tables["Orders"].Columns["OrderID"],
                                           _DataSet.Tables["Order Details"].Columns["OrderID"], false);
                }

                superGridControl1.PrimaryGrid.DataSource = _DataSet;
                superGridControl1.PrimaryGrid.DataMember = "Customers";
            }
        }

        #endregion

        #region SuperGridControl1CellValueChanged

        /// <summary>
        /// Handles cell value change events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1CellValueChanged(object sender, GridCellValueChangedEventArgs e)
        {
            GridPanel panel = e.GridPanel;

            // If a cell value in the "Order Details" panel has changed
            // then update its footer to reflect the change

            if (panel.Name.Equals("Order Details") == true)
                UpdateDetailsFooter(panel);
        }

        #endregion

        #region SuperGridControl1GetCellStyle

        /// <summary>
        /// This routine is called to retrieve application provided
        /// cell style information. The style being presented in this
        /// call is the Effective Style (style used after applying
        /// all base styles).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1GetCellStyle(object sender, GridGetCellStyleEventArgs e)
        {
            GridPanel panel = e.GridPanel;

            if (panel.Name.Equals("Customers") == true)
            {
                if (e.GridCell.GridColumn.Name.Equals("ContactTitle") == true)
                {
                    if (((string)e.GridCell.Value).Equals("Owner") == true)
                        e.Style.TextColor = Color.Red;
                }
            }
        }

        #endregion

        #region SuperGridControl1DataBindingComplete

        /// <summary>
        /// This routine is called after each bindable data portion has
        /// been completed. This callout lets you customize the display
        /// or visibility of the data however the application needs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1DataBindingComplete(
            object sender, GridDataBindingCompleteEventArgs e)
        {
            GridPanel panel = e.GridPanel;

            switch (panel.DataMember)
            {
                case "Customers":
                    CustomizeCustomerPanel(panel);
                    break;

                case "Orders":
                    CustomizeOrdersPanel(panel);
                    break;

                case "Order Details":
                    CustomizeDetailsPanel(panel);
                    break;
            }
        }

        #region CustomizeCustomerPanel

        /// <summary>
        /// Customizes the CustomerPanel
        /// </summary>
        /// <param name="panel"></param>
        private void CustomizeCustomerPanel(GridPanel panel)
        {
            panel.FrozenColumnCount = 1;
            panel.ColumnHeader.RowHeight = 30;

            panel.Columns["Region"].NullString = "<no locale>";

            panel.Columns[0].CellStyles.Default.Background =
                new Background(Color.AliceBlue);

            foreach (GridColumn column in panel.Columns)
                column.ColumnSortMode = ColumnSortMode.Multiple;
        }

        #endregion

        #region CustomizeOrdersPanel

        /// <summary>
        /// Customizes the OrdersPanel
        /// </summary>
        /// <param name="panel"></param>
        private void CustomizeOrdersPanel(GridPanel panel)
        {
            panel.ShowRowGridIndex = true;
            panel.ShowRowDirtyMarker = true;
            panel.ColumnHeader.RowHeight = 30;

            panel.Columns[0].CellStyles.Default.Background =
                new Background(Color.Beige);

            panel.Caption = new GridCaption();

            panel.Caption.Text = String.Format("Orders ({0}) for customer <font color=\"Maroon\"><i>\"{1}</i>\"</font>",
                panel.Rows.Count, ((GridRow)panel.Parent)["CompanyName"].Value);

            panel.DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft;
        }

        #endregion

        #region CustomizeDetailsPanel

        /// <summary>
        /// Customizes the DetailsPanel
        /// </summary>
        /// <param name="panel"></param>
        private void CustomizeDetailsPanel(GridPanel panel)
        {
            panel.ColumnHeader.RowHeight = 30;

            panel.Columns[0].CellStyles.Default.Background =
                new Background(Color.LavenderBlush);

            panel.Columns["OrderID"].CellStyles.Default.Alignment = Alignment.MiddleLeft;

            panel.DefaultVisualStyles.CaptionStyles.Default.Alignment = Alignment.MiddleLeft;
            panel.DefaultVisualStyles.CellStyles.Default.Alignment = Alignment.MiddleRight;

            UpdateDetailsFooter(panel);
        }

        #endregion

        #region UpdateDetailsFooter

        /// <summary>
        /// Updates the Details Footer
        /// </summary>
        /// <param name="panel"></param>
        private void UpdateDetailsFooter(GridPanel panel)
        {
            if (panel.Footer == null)
                panel.Footer = new GridFooter();

            decimal total = 0;

            foreach (GridRow row in panel.Rows)
            {
                decimal unitPrice = (decimal)(row["UnitPrice"].Value ?? 0);
                float discount = (float)(row["Discount"].Value ?? 0);
                short quantity = (short)(row["Quantity"].Value ?? 0);

                total += (unitPrice - (decimal)discount) * quantity;
            }

            panel.Footer.Text = String.Format(
                "Total sales <font color=\"Green\"><i>{0:C}</i></font>",
                total);
        }

        #endregion

        #endregion
    }
}