using System;
using System.ComponentModel;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace SuperGridDemo
{
    public partial class DemoBasicFiltering : Office2007Form
    {
        public DemoBasicFiltering()
        {
            InitializeComponent();

            // Initialize the grid
            // and set the sample description text

            InitializeGrid();

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoBasicFiltering.rtf");
        }

        #region InitializeGrid

        /// <summary>
        /// Initialize the grid
        /// </summary>
        private void InitializeGrid()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            panel.Columns["LastName"].EditorType = typeof(MyComboBox);
            panel.Columns["Citizen"].EditorType = typeof(MyCheckBox);

            // Add some initial rows for the user to filter

            AddRows();
        }

        #endregion

        #region AddRows

        /// <summary>
        /// Adds 1000 random data rows for the user to filter
        /// </summary>
        private void AddRows()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            superGridControl1.BeginUpdate();

            int count = panel.Rows.Count;

            for (int i = 0; i < 1000; i++)
            {
                MyEmployee emp = MyEmployee.GetNewEmployee();

                object firstName = (emp.Age % 7 == 0 ? (object)DBNull.Value : emp.FirstName);
                object age = (emp.Age % 5 == 0 ? null : (object)emp.Age);
                object citizen = (emp.Age % 3 == 0 ? null : (object)emp.Citizen);
                object hireDate = (emp.Age % 6 == 0 ? null : (object)emp.HireDate);

                object[] ob1 = new object[]
                {
                    count + i, emp.LastName, firstName,
                    age, hireDate, citizen
                };

                if (i < 12)
                {
                    int n = i % 6 + 1;

                    object[] ob2 = new object[n];

                    for (int j = 0; j < n; j++)
                        ob2[j] = ob1[j];

                    panel.Rows.Add(new GridRow(ob2));
                }
                else
                {
                    panel.Rows.Add(new GridRow(ob1));
                }
            }

            superGridControl1.EndUpdate();

            // We'll stop it at 10,000 - just for grins

            if (panel.Rows.Count >= 10000)
                btnAddRows.Enabled = false;
        }

        #endregion

        #region BtnAddRowsClick

        /// <summary>
        /// Handles user request to add another 1000 rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddRowsClick(object sender, EventArgs e)
        {
            AddRows();
        }

        #endregion

        #region BtnResetPanelFilterClick

        /// <summary>
        /// Handles user request to reset the
        /// row level panel filter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnResetPanelFilterClick(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.FilterExpr = null;
        }

        #endregion

        #region BtnResetColumnFiltersClick

        /// <summary>
        /// Handles user request to
        /// reset each column level filter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnResetColumnFiltersClick(object sender, EventArgs e)
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            foreach (GridColumn column in panel.Columns)
                column.FilterExpr = null;
        }

        #endregion
    }

    #region MyCombo

    /// <summary>
    /// Simple class definition to enable ThreeState
    /// </summary>
    public class MyCheckBox : GridCheckBoxXEditControl
    {
        public MyCheckBox()
        {
            ThreeState = true;
        }
    }

    #endregion

    #region MyCombo

    /// <summary>
    /// Simple class to create combo with
    /// every base employee name added by default
    /// </summary>
    public class MyComboBox : GridComboBoxExEditControl
    {
        public MyComboBox()
        {
            foreach (string name in MyEmployee.LastNames)
                Items.Add(name ?? "");
        }
    }

    #endregion

    #region MyEmployee

    /// <summary>
    /// Simple MyEmployee class definition
    /// </summary>
    public class MyEmployee : INotifyPropertyChanged
    {
        #region Private variables

        private string _FirstName;
        private string _LastName;
        private int _Age;
        private int _Id;
        private DateTime _HireDate;
        private bool _Citizen;

        static Random _Rand = new Random();

        public static string[] FirstNames = new string[] { null,
            "Isabella", "Sophia", "Emma", "Olivia", "Ava", "Emily", "Abigail", "Madison",
            "Chloe", "Mia", "Addison", "Elizabeth", "Ella", "Natalie", "Samantha", "Alexis",
            "Lily", "Grace", "Hailey", "Alyssa", "Lillian", "Hannah", "Avery", "Leah",
            "Nevaeh", "Sofia", "Ashley", "Anna", "Brianna", "Sarah", "Zoe", "Victoria",
            "Gabriella", "Brooklyn", "Kaylee", "Taylor", "Layla", "Allison", "Evelyn",
            "Riley", "Amelia", "Khloe"};

        public static string[] LastNames = new string[] { null,
            "Anderson", "Brown", "Clark", "Davis", "García", "González", "Hall", "Harris",
            "Hernández", "Jackson", "Johnson", "Jones", "Lee", "Lewis", "López", "Martin",
            "Martínez", "Miller", "Moore", "Pérez", "Robinson", "Rodríguez", "Smith",
            "Taylor", "Thomas", "Thompson", "Walker", "White", "Williams", "Wilson", "Young" };

        #endregion

        public MyEmployee(string firstName, string lastName,
            int age, int id, DateTime hireDate, bool citizen)
        {
            _FirstName = firstName;
            _LastName = lastName;
            _Age = age;
            _Id = id;
            _HireDate = hireDate;
            _Citizen = citizen;
        }

        #region GetNewEmployee

        /// <summary>
        /// Gets a new, random employee
        /// </summary>
        /// <returns></returns>
        public static MyEmployee GetNewEmployee()
        {
            string fname = FirstNames[_Rand.Next(FirstNames.Length)];
            string lname = LastNames[_Rand.Next(LastNames.Length)];

            int age = _Rand.Next(18, 70);
            int id = _Rand.Next(10000, 12000);

            DateTime hireDate = DateTime.Now.AddMonths(_Rand.Next(0, 12));
            hireDate = hireDate.AddYears(_Rand.Next(-20, 20));
            hireDate = hireDate.AddDays(_Rand.Next(0, 20));

            return (new MyEmployee(fname, lname, age, id, hireDate, (age + id) % 2 == 0));
        }

        #endregion

        #region Public properties

        #region FirstName

        public string FirstName
        {
            get { return (_FirstName); }

            set
            {
                _FirstName = value;

                OnPropertyChanged("FirstName");
            }
        }

        #endregion

        #region LastName

        public string LastName
        {
            get { return (_LastName); }

            set
            {
                _LastName = value;

                OnPropertyChanged("LastName");
            }
        }

        #endregion

        #region Age

        public int Age
        {
            get { return (_Age); }

            set
            {
                _Age = value;

                OnPropertyChanged("Age");
            }
        }

        #endregion

        #region Id

        public int Id
        {
            get { return (_Id); }

            set
            {
                _Id = value;

                OnPropertyChanged("Id");
            }
        }

        #endregion

        #region HireDate

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

        #region Citizen

        public bool Citizen
        {
            get { return (_Citizen); }

            set
            {
                _Citizen = value;

                OnPropertyChanged("Citizen");
            }
        }

        #endregion

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
}