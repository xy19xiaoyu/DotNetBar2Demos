using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Media;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace SuperGridDemo
{
    public partial class DemoGridBinding : Office2007Form
    {
        #region Private variables

        private BindingManagerBase _Bm;

        #endregion

        public DemoGridBinding()
        {
            InitializeComponent();

            // Initialize the grid, selected comboBox
            // Data Source, and the sample description text.

            InitializeGrid();

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoGridBinding.rtf");
        }

        #region InitializeGrid

        /// <summary>
        /// Initializes our default sample environment
        /// </summary>
        private void InitializeGrid()
        {
            // None - is the default

            cboDataSource.SelectedIndex = 4;

            // Hook onto a few of the SuperGrid events in order to
            // have our UI reflect the current state of the grid

            superGridControl1.RowDeleted += SuperGridControl1RowDeleted;
            superGridControl1.RowRestored += SuperGridControl1RowRestored;
            superGridControl1.RowsPurged += SuperGridControl1RowsPurged;

            // When new rows are added via the grid, let's
            // see that they have something imaginative in them

            superGridControl1.RowSetDefaultValues += SuperGridControl1RowSetDefaultValues;
        }

        #endregion

        #region Internal properties

        /// <summary>
        /// Gets and sets the BindingManager we use in this
        /// sampe to traverse through the set data collection
        /// </summary>
        internal BindingManagerBase Bm
        {
            get { return (_Bm); }

            set
            {
                if (_Bm != null)
                    _Bm.PositionChanged -= BmPositionChanged;

                _Bm = value;

                if (_Bm != null)
                    _Bm.PositionChanged += BmPositionChanged;
            }
        }

        #endregion

        #region SuperGridControl1RowsPurged

        /// <summary>
        /// This event is sent when deleted rows have been purged.
        /// We will use it to disable the "purge" button after a
        /// purge has been performed by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1RowsPurged(object sender, GridRowEventArgs e)
        {
            btnPurge.Enabled = false;
        }

        #endregion

        #region SuperGridControl1RowRestored

        /// <summary>
        /// This event is sent when user deleted rows are
        /// restored or 'undeleted'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1RowRestored(object sender, GridRowRestoredEventArgs e)
        {
            btnPurge.Enabled = (superGridControl1.PrimaryGrid.DeletedRowCount > 0);
        }

        #endregion

        #region SuperGridControl1RowDeleted

        /// <summary>
        /// This event is sent after
        /// rows have been deleted by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1RowDeleted(object sender, GridRowDeletedEventArgs e)
        {
            btnPurge.Enabled = (superGridControl1.PrimaryGrid.DeletedRowCount > 0);
        }

        #endregion

        #region SuperGridControl1RowSetDefaultValues

        /// <summary>
        /// This event is sent when a new row is added.  It gives
        /// our application the opportunity to establish a new
        /// set of default values for the added row.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1RowSetDefaultValues(
            object sender, GridRowSetDefaultValuesEventArgs e)
        {
            if (e.GridRow.Cells.Count == 0)
            {
                e.GridRow.Cells.Add(new GridCell("John*"));
                e.GridRow.Cells.Add(new GridCell("Doe"));
                e.GridRow.Cells.Add(new GridCell(20));
                e.GridRow.Cells.Add(new GridCell(20001));
                e.GridRow.Cells.Add(new GridCell(DateTime.Now));
            }
            else
            {
                e.GridRow.Cells[0].Value = "John*";
                e.GridRow.Cells[1].Value = "Doe";
                e.GridRow.Cells[2].Value = 20;
                e.GridRow.Cells[3].Value = 20001;
                e.GridRow.Cells[4].Value = DateTime.Now;
            }
        }

        #endregion

        #region CboDataSourceSelectedIndexChanged

        /// <summary>
        /// Handles user comboBox selection of a new data source.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CboDataSourceSelectedIndexChanged(object sender, EventArgs e)
        {
            object dataSource = null;
            string dataMember = null;
            object context = null;

            switch (cboDataSource.SelectedIndex)
            {
                    // IList
                case 0:
                    List<Employee> list = new List<Employee>();

                    for (int i = 0; i < 50; i++)
                        list.Add(Employee.GetNewEmployee());

                    dataSource = list;
                    context = dataSource;
                    break;

                    // IListSource
                case 1:
                    IListSource listSource = new EmployeeListSource();
                    dataSource = listSource;
                    context = listSource.GetList();
                    break;

                    // IBindingList
                case 2:
                    BindingList<Employee> bindingList = new BindingList<Employee>();

                    for (int i = 0; i < 50; i++)
                        bindingList.Add(Employee.GetNewEmployee());

                    dataSource = bindingList;
                    context = dataSource;
                    break;

                    // DataSet
                case 3:
                    dataSource = GetEmployeeDataSet();
                    dataMember = "Employees";
                    context = ((DataSet)dataSource).Tables["Employees"];
                    break;
            }

            // Set the SuperGrid DataSource and DataMember, and
            // set our BindingManager for later data traversal

            superGridControl1.PrimaryGrid.DataSource = dataSource;
            superGridControl1.PrimaryGrid.DataMember = dataMember;

            Bm = (dataSource != null)
                ? superGridControl1.BindingContext[context] : null;

            // Make sure our UI reflects the current state of affairs

            btnInsertRow.Enabled =
            btnDeleteRow.Enabled =
            btnDetach.Enabled = (cboDataSource.SelectedIndex < 4);

            btnPurge.Enabled = false;

            UpdateVcr();
            UpdateBindings(context);
        }

        #endregion

        #region UpdateBindings

        /// <summary>
        /// Establishes our data bindings for the form
        /// level controls in our sample app
        /// </summary>
        /// <param name="context"></param>
        private void UpdateBindings(object context)
        {
            txbFirstName.DataBindings.Clear();
            txbLastName.DataBindings.Clear();
            tbxAge.DataBindings.Clear();
            tbxEmployeeId.DataBindings.Clear();
            txbHireDate.DataBindings.Clear();

            if (context != null)
            {
                txbFirstName.DataBindings.Add(new Binding("Text", context, "FirstName"));
                txbLastName.DataBindings.Add(new Binding("Text", context, "LastName"));
                tbxAge.DataBindings.Add(new Binding("Text", context, "Age"));
                tbxEmployeeId.DataBindings.Add(new Binding("Text", context, "Id"));
                txbHireDate.DataBindings.Add(new Binding("Text", context, "HireDate"));
            }
            else
            {
                txbFirstName.Text = "";
                txbLastName.Text = "";
                tbxAge.Text = "";
                tbxEmployeeId.Text = "";
                txbHireDate.Text = "";
            }
        }

        #endregion

        #region GetEmployeeDataSet

        /// <summary>
        /// Creates our Employee DataSet
        /// </summary>
        /// <returns></returns>
        private DataSet GetEmployeeDataSet()
        {
            DataTable table = new DataTable("Employees");

            DataColumn col = new DataColumn();
            col.ColumnName = "FirstName";
            col.DataType = Type.GetType("System.String");
            table.Columns.Add(col);

            col = new DataColumn();
            col.ColumnName = "LastName";
            col.DataType = Type.GetType("System.String");
            table.Columns.Add(col);

            col = new DataColumn();
            col.ColumnName = "Age";
            col.DataType = Type.GetType("System.Int32");
            table.Columns.Add(col);

            col = new DataColumn();
            col.ColumnName = "Id";
            col.DataType = Type.GetType("System.Int32");
            table.Columns.Add(col);

            col = new DataColumn();
            col.ColumnName= "HireDate";
            col.DataType = Type.GetType("System.DateTime");
            table.Columns.Add(col);
            
            DataSet ds = new DataSet("MyDataSet");
            ds.Tables.Add(table);

            table.BeginLoadData();

            // Add 50 rows to fiddle with

            for (int i = 0; i < 50; i++)
            {
                DataRow row = table.NewRow();

                Employee emp = Employee.GetNewEmployee();

                row[0] = emp.FirstName;
                row[1] = emp.LastName;
                row[2] = emp.Age;
                row[3] = emp.Id;
                row[4] = emp.HireDate;

                table.Rows.Add(row);

                row.AcceptChanges();
            }

            table.EndLoadData();

            return (ds);
        }

        #endregion

        #region BtnPurgeClick

        /// <summary>
        /// Handles user requests to purge grid deleted records
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPurgeClick(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.PurgeDeletedRows();

            if (Bm.Count > 0)
                btnDeleteRow.Enabled = true;

            btnPurge.Enabled = false;

            UpdateVcr();
        }

        #endregion

        #region BtnDetachClick

        /// <summary>
        /// Detaches the grid from the current set data source,
        /// enabling the grid operate on unbound data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDetachClick(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.DetachDataSource(true);

            btnDetach.Enabled = false;
        }

        #endregion

        #region Vcr Control support

        #region BmPositionChanged

        /// <summary>
        /// Updates out VCR control when the user
        /// moves position in the data collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BmPositionChanged(object sender, EventArgs e)
        {
            UpdateVcr();
        }

        #endregion

        #region VcrFirstClick

        /// <summary>
        /// Handles VCR "first record" clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VcrFirstClick(object sender, EventArgs e)
        {
            if (_Bm != null)
                _Bm.Position = 0;

            UpdateVcr();
        }

        #endregion

        #region VcrPreviousClick

        /// <summary>
        /// Handles user "previous record" clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VcrPreviousClick(object sender, EventArgs e)
        {
            if (_Bm != null)
                _Bm.Position--;

            UpdateVcr();
        }

        #endregion

        #region VcrNextClick

        /// <summary>
        /// Handles user "Next record" clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VcrNextClick(object sender, EventArgs e)
        {
            if (_Bm != null)
                _Bm.Position++;

            UpdateVcr();
        }

        #endregion

        #region VcrLastClick

        /// <summary>
        /// Handles user "Last record" clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VcrLastClick(object sender, EventArgs e)
        {
            if (_Bm != null)
                _Bm.Position = _Bm.Count;

            UpdateVcr();
        }

        #endregion

        #region UpdateVcr

        /// <summary>
        /// Updates our VCR states
        /// </summary>
        private void UpdateVcr()
        {
            if (_Bm == null || _Bm.Count <= 1)
            {
                vcr1.FirstButton.Enabled = false;
                vcr1.PreviousButton.Enabled = false;
                vcr1.NextButton.Enabled = false;
                vcr1.LastButton.Enabled = false;

                vcr1.Label.Text = (_Bm == null || _Bm.Count == 0)
                    ? "No records" : "Only Record";
            }
            else
            {
                if (_Bm.Position == 0)
                {
                    vcr1.FirstButton.Enabled =
                    vcr1.PreviousButton.Enabled = false;

                    vcr1.LastButton.Enabled =
                    vcr1.NextButton.Enabled = (_Bm.Count > 1);

                    vcr1.Label.Text = "First of " + _Bm.Count + " records";
                }
                else if (_Bm.Position == _Bm.Count - 1)
                {
                    vcr1.LastButton.Enabled = false;
                    vcr1.NextButton.Enabled = false;

                    vcr1.FirstButton.Enabled =
                    vcr1.PreviousButton.Enabled = (_Bm.Count > 1);

                    vcr1.Label.Text = "Last of " + _Bm.Count + " records";
                }
                else
                {
                    vcr1.FirstButton.Enabled = true;
                    vcr1.PreviousButton.Enabled = true;
                    vcr1.NextButton.Enabled = true;
                    vcr1.LastButton.Enabled = true;

                    vcr1.Label.Text = "Record " + (_Bm.Position + 1) + " of " + _Bm.Count;
                }
            }
        }

        #endregion

        #endregion

        #region BtnDeleteRowClick

        /// <summary>
        /// Deletes the current positioned row.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeleteRowClick(object sender, EventArgs e)
        {
            if (Bm != null)
            {
                if (Bm.Position >= 0)
                {
                    Bm.RemoveAt(Bm.Position);

                    if (Bm.Count == 0)
                        btnDeleteRow.Enabled = false;

                    // For those interfaces that don't support automatic
                    // notification, lets refresh the display ourselves

                    if (cboDataSource.SelectedIndex == 0 ||
                        cboDataSource.SelectedIndex == 1)
                    {
                        superGridControl1.PrimaryGrid.InvalidateLayout();
                    }

                    UpdateVcr();
                }
            }
        }

        #endregion

        #region BtnInsertRowClick

        /// <summary>
        /// Handles user requests to insert
        /// a new row at the current position.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInsertRowClick(object sender, EventArgs e)
        {
            if (Bm != null)
            {
                int index = Math.Max(0, Bm.Position);

                switch (cboDataSource.SelectedIndex)
                {
                    case 0:
                    case 2:
                        IList ilist = superGridControl1.PrimaryGrid.DataSource as IList;

                        if (ilist != null)
                        {
                            Employee emp = Employee.GetNewEmployee();
                            emp.FirstName += "*";

                            ilist.Insert(index, emp);

                            superGridControl1.PrimaryGrid.InvalidateLayout();
                        }
                        break;

                    case 1:
                        IListSource ilistSource =
                            superGridControl1.PrimaryGrid.DataSource as IListSource;

                        if (ilistSource != null)
                        {
                            Employee emp = Employee.GetNewEmployee();
                            emp.FirstName += "*";

                            ilistSource.GetList().Insert(index, emp);
                        }
                        break;

                    case 3:
                        DataSet dataSet =
                            superGridControl1.PrimaryGrid.DataSource as DataSet;

                        if (dataSet != null)
                        {
                            DataTable table = dataSet.Tables
                                [superGridControl1.PrimaryGrid.DataMember];

                            DataRow row = table.NewRow();

                            Employee emp = Employee.GetNewEmployee();
                            row[0] = emp.FirstName + "*";
                            row[1] = emp.LastName;
                            row[2] = emp.Age;
                            row[3] = emp.Id;
                            row[4] = emp.HireDate;

                            table.Rows.InsertAt(row, index);

                            row.AcceptChanges();
                        }
                        break;
                }

                if (Bm.Count > 0)
                    btnDeleteRow.Enabled = true;

                UpdateVcr();
            }
        }

        #endregion

        #region TbxNumericKeyPress

        /// <summary>
        /// Used to limit our 'age' and 'EmployeeId' TextBox
        /// input to numeric data only (only decimals, non-negative, etc)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxNumericKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;

            if (e.Handled == true)
                SystemSounds.Beep.Play();
        }

        #endregion
    }

    #region Employee

    /// <summary>
    /// Simple Employee class definition
    /// </summary>
    public class Employee : INotifyPropertyChanged
    {
        #region Private variables

        private string _FirstName;
        private string _LastName;
        private int _Age;
        private int _Id;
        private DateTime _HireDate;

        static Random _Rand = new Random();

        static string[] FirstNames = new string[] { 
            "Isabella", "Sophia", "Emma", "Olivia", "Ava", "Emily", "Abigail", "Madison",
            "Chloe", "Mia", "Addison", "Elizabeth", "Ella", "Natalie", "Samantha", "Alexis",
            "Lily", "Grace", "Hailey", "Alyssa", "Lillian", "Hannah", "Avery", "Leah",
            "Nevaeh", "Sofia", "Ashley", "Anna", "Brianna", "Sarah", "Zoe", "Victoria",
            "Gabriella", "Brooklyn", "Kaylee", "Taylor", "Layla", "Allison", "Evelyn",
            "Riley", "Amelia", "Khloe"};

        static string[] LastNames = new string[] { 
            "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "García",
            "Rodríguez", "Wilson", "Martínez", "Anderson", "Taylor", "Thomas", "Hernández",
            "Moore", "Martin", "Jackson", "Thompson", "White", "López", "Lee", "González",
            "Harris", "Clark", "Lewis", "Robinson", "Walker", "Pérez", "Hall", "Young"};

        #endregion

        public Employee()
        {
        }

        public Employee(string firstName, string lastName,
            int age, int id, DateTime hireDate)
        {
            _FirstName = firstName;
            _LastName = lastName;
            _Age = age;
            _Id = id;
            _HireDate = hireDate;
        }

        #region GetNewEmployee

        /// <summary>
        /// Gets a new, random employee
        /// </summary>
        /// <returns></returns>
        public static Employee GetNewEmployee()
        {
            string fname = FirstNames[_Rand.Next(FirstNames.Length)];
            string lname = LastNames[_Rand.Next(LastNames.Length)];

            int age = _Rand.Next(18, 70);
            int id = _Rand.Next(10000, 12000);

            DateTime hireDate = DateTime.Now.AddMonths(-_Rand.Next(12, 240));

            return (new Employee(fname, lname, age, id, hireDate));
        }

        #endregion

        #region Public properties

        public string FirstName
        {
            get { return (_FirstName); }

            set
            {
                _FirstName = value;

                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return (_LastName); }

            set
            {
                _LastName = value;

                OnPropertyChanged("LastName");
            }
        }

        public int Age
        {
            get { return (_Age); }

            set
            {
                _Age = value;

                OnPropertyChanged("Age");
            }
        }

        public int Id
        {
            get { return (_Id); }

            set
            {
                _Id = value;

                OnPropertyChanged("Id");
            }
        }

        public DateTime HireDate
        {
            get { return (_HireDate); }

            set
            {
                _HireDate = value;

                OnPropertyChanged("HireDate");
            }
        }

        #endregion

        #region INotifyPropertyChanged Members

        /// <summary>
        /// Occurs when property value has changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(property));
        }

        /// <summary>
        /// Raises the PropertyChanged event.
        /// </summary>
        /// <param name="e">Event arguments</param>
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler eh = PropertyChanged;

            if (eh != null)
                eh(this, e);
        }

        #endregion
    }

    #endregion

    #region EmployeeListSource

    /// <summary>
    /// Our IListSource employee class
    /// </summary>
    public class EmployeeListSource : IListSource
    {
        #region Private variables

        private BindingList<Employee> _Ble;

        #endregion

        public EmployeeListSource()
        {
            _Ble = new BindingList<Employee>();

            for (int i = 0; i < 50; i++)
                _Ble.Add(Employee.GetNewEmployee());
        }

        #region IListSource Members

        bool IListSource.ContainsListCollection
        {
            get { return (false); }
        }

        IList IListSource.GetList()
        {
            return (_Ble);
        }

        #endregion
    }

    #endregion
}      