using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace SuperGridDemo
{
    public partial class DemoExtendedFiltering : Office2007Form
    {
        #region Private variables

        private ButtonItem _VowelButtonItem;
        private ButtonItem _ConsonantButtonItem;

        private bool _FilterIndexOk;

        #endregion

        public DemoExtendedFiltering()
        {
            InitializeComponent();

            // Initialize base form controls and the grid
            // and then set the sample description text

            InitControls();
            InitializeGrid();

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoExtendedFiltering.rtf");
        }

        #region InitControls

        /// <summary>
        /// Initializes form level controls
        /// </summary>
        private void InitControls()
        {
            cbFilterAlignment.Items.AddRange(Enum.GetNames(typeof(Alignment)));
            cbFilterAlignment.SelectedIndex = 3;

            cbFilterImageVisibility.Items.AddRange(Enum.GetNames(typeof(ImageVisibility)));
            cbFilterImageVisibility.SelectedIndex = 0;

            cbMatchType.Items.AddRange(Enum.GetNames(typeof(FilterMatchType)));
            cbMatchType.SelectedIndex = 0;

            cbFilterLevel.Items.AddRange(Enum.GetNames(typeof(FilterLevel)));
            cbFilterLevel.SelectedIndex = 1;
        }

        #endregion

        #region InitializeGrid

        /// <summary>
        /// Initializes the grid
        /// </summary>
        private void InitializeGrid()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            panel.Columns["LastName"].EditorType = typeof(MyComboBox);
            panel.Columns["Citizen"].EditorType = typeof(MyCheckBox);

            // Add rows for the user to filter

            AddRows();

            // Hook onto a few of the filtering events
            // to demonstrate their use and simple application

            superGridControl1.FilterBeginEdit += SuperGridControl1FilterBeginEdit;
            superGridControl1.FilterLoadItems += SuperGridControl1FilterLoadItems;
            superGridControl1.FilterEditValueChanged += SuperGridControl1FilterEditValueChanged;

            superGridControl1.FilterPopupOpening += SuperGridControl1FilterPopupOpening;
            superGridControl1.FilterPopupClosing += SuperGridControl1FilterPopupClosing;

            superGridControl1.PreRenderFilterPopupGripBar += PreRenderFilterPopupGripBar;
            superGridControl1.FilterPopupValueChanged += SuperGridControl1FilterPopupValueChanged;

            superGridControl1.FilterUserFunction += SuperGridControl1FilterUserFunction;
            superGridControl1.FilterPopupLoaded += SuperGridControl1FilterPopupLoaded;
        }

        #endregion

        #region FilterPopup support

        #region SuperGridControl1FilterPopupOpening

        /// <summary>
        /// This routine is called when the ColumnHeader filter
        /// image has been clicked. The user has the opportunity to
        /// redefine the popup Control, as well as completely cancel
        /// the operation if needed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1FilterPopupOpening(
            object sender, GridFilterPopupOpeningEventArgs e)
        {
            // Set the grip size a little larger so we
            // can display some text in there later.

            e.FilterPopup.GripSize = new Size(14, 30);

            switch (e.GridColumn.Name)
            {
                    // If the user has checked the "UseAgeSlider"
                    // checkbox, then create a Slider and tell the
                    // SuperGrid to use it as the popup control.

                case "Age":
                    if (cbxUseAgeSlider.Checked == true)
                    {
                        e.FilterPopup.Control = GetNewSlider(e.GridColumn);

                        // Set the grip size a little larger so we
                        // can display some text in there later.

                        e.FilterPopup.GripSize = new Size(14, 60);
                    }
                    break;

                case "HireDate":
                    // Set the grip size a little larger so we
                    // can display some text in there later.
                    
                    e.FilterPopup.GripSize = new Size(14, 60);
                    break;

                    // When the user initially clicks on the "Index" column,
                    // we present the user with an OKCancel dialog. If OK, the
                    // operation continues - if Canceled, then the operation is
                    // canceled and no filtering is permitted.

                case "Index":
                    e.Cancel = GetIndexMonitorResult();
                    break;
            }
        }

        #region GetNewSlider

        /// <summary>
        /// Creates a new Slider Control to use for the
        /// "Age" column (when "UseAgeSlider" is checked).
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        private Slider GetNewSlider(GridColumn column)
        {
            Slider slider = new Slider();

            slider.Tag = column;

            // Setting the MinimumSize will keep the user from
            // being able to resize the FilterPopup too small
 
            slider.Size = new Size(150, 25);
            slider.MinimumSize = new Size(100, 25);

            slider.FocusCuesEnabled = false;
            slider.LabelWidth = 30;
            slider.Text = "0";

            // We want to be informed when the user
            // changes the slider value.

            slider.ValueChanged += SliderValueChanged;

            return (slider);
        }

        #region SliderValueChanged

        void SliderValueChanged(object sender, EventArgs e)
        {
            Slider slider = sender as Slider;

            if (slider != null)
            {
                slider.Text = slider.Value.ToString();

                GridColumn column = slider.Tag as GridColumn;

                if (column != null)
                {
                    if (slider.Value <= 0)
                    {
                        column.FilterExpr = null;
                        column.FilterDisplayValue = "All ages";
                    }
                    else
                    {
                        column.FilterExpr = (column.Name + " is between " +
                            (slider.Value - 10) + ", " + (slider.Value + 10));

                        column.FilterDisplayValue = ">= " +
                            (slider.Value - 10) + " and <= " + (slider.Value + 10);
                    }
                }
            }
        }

        #endregion

        #endregion

        #endregion

        #region SuperGridControl1FilterPopupClosing

        /// <summary>
        /// This routine is called when the FilterPopup is
        /// being closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1FilterPopupClosing(object sender, GridFilterPopupClosingEventArgs e)
        {
            // If an "Age" Popup is being closed, and we have
            // redefined the popup Control to be a Slider, then
            // unhook the ValueChanged event and dispose of it.

            if (e.GridColumn.Name.Equals("Age"))
            {
                Slider slider = e.FilterPopup.Control as Slider;

                if (slider != null)
                {
                    slider.ValueChanged -= SliderValueChanged;

                    slider.Dispose();
                }
            }
        }

        #endregion

        #region SuperGridControl1FilterPopupLoaded

        /// <summary>
        /// This routine is called after the SuperGrid has
        /// loaded the FilterPopup with the default filter
        /// items. The user can delete or add items as needed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1FilterPopupLoaded(object sender, GridFilterPopupLoadedEventArgs e)
        {
            // Let's modify the items contained in the "FirstName" popup

            if (e.GridColumn.Name.Equals("FirstName"))
            {
                // The SuperGrid uses an ItemPanel as its underlying
                // Popup Control.

                ItemPanel itemPanel = e.FilterPopup.Control as ItemPanel;

                if (itemPanel != null)
                {
                    // Let's add 2 items to the list - one to filter out all
                    // words that do not begin with a vowel, and another that
                    // filters out all words that do not start with a consonant.
                    
                    itemPanel.Items.Add(GetVowelItem(e.GridColumn));
                    itemPanel.Items.Add(GetConsonantItem(e.GridColumn));
                }
            }
        }

        #region GetVowelItem

        /// <summary>
        /// This routine creates a "Vowel" item to add to
        /// the popup ItemPanel Control.
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        private BaseItem GetVowelItem(GridColumn column)
        {
            if (_VowelButtonItem == null)
            {
                _VowelButtonItem = new ButtonItem("Vowels", "Vowels");
                _VowelButtonItem.Click += VowelItemClick;

                _VowelButtonItem.Tooltip = "Shows all names starting with a vowel";

                _VowelButtonItem.BeginGroup = true;
            }

            _VowelButtonItem.Tag = column;

            return (_VowelButtonItem);
        }

        #region VowelItemClick

        void VowelItemClick(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
            {
                GridColumn column = bi.Tag as GridColumn;

                if (column != null)
                {
                    column.FilterExpr = "IndexOf(Substring(, 0, 1),\"AEIOUY\") >= 0";
                    column.FilterDisplayValue = "Vowels";
                }
            }
        }

        #endregion

        #endregion

        #region GetConsonantItem

        /// <summary>
        /// This routine creates a "Conosonant" item to add to
        /// the popup ItemPanel Control.
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        private BaseItem GetConsonantItem(GridColumn column)
        {
            if (_ConsonantButtonItem == null)
            {
                _ConsonantButtonItem = new ButtonItem("Consonants", "Consonants");
                _ConsonantButtonItem.Click += ConsonantItemClick;

                _ConsonantButtonItem.Tooltip = "Shows all names starting with a consonant";
            }

            _ConsonantButtonItem.Tag = column;

            return (_ConsonantButtonItem);
        }

        #region ConsonantItemClick

        void ConsonantItemClick(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
            {
                GridColumn column = bi.Tag as GridColumn;

                if (column != null)
                {
                    column.FilterExpr = "Length([]) > 0 && IndexOf(Substring(, 0, 1),\"AEIOUY\") < 0";
                    column.FilterDisplayValue = "Consonants";

                    column.ShowPanelFilterExpr = Tbool.True;
                }
            }
        }

        #endregion

        #endregion

        #endregion

        #region PreRenderFilterPopupGripBar

        /// <summary>
        /// This routine is called to give the user the ability
        /// to utilize and render the "GripBar" area as they see fit.
        /// The GripHandle, as well as the entire GripBar, can be
        /// completely redefined and rendered at this point.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PreRenderFilterPopupGripBar(object sender, GridPreRenderFilterPopupGripBarEventArgs e)
        {
            RectangleF r = e.Bounds;

            // Let's make the GripBar area LightSlateGray by default,
            // and then render the current FilterDisplayValue to the
            // GripBar (with some extra text for good measure if the
            // column happens to be the "Age" column).

            e.Graphics.FillRectangle(Brushes.LightSlateGray, r);

            using (StringFormat sf = new StringFormat())
            {
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;

                string s = e.GridColumn.FilterDisplayValue as string;

                if (string.IsNullOrEmpty(s) == true)
                    s = "<null>";

                if (e.GridColumn.Name.Equals("Age"))
                {
                    if (cbxUseAgeSlider.Checked == true)
                        s = "Age range expression:\n" + s;
                }
                else
                {
                    r.Width -= e.FilterPopup.GripSize.Width;
                }

                e.Graphics.DrawString(s,
                    SystemFonts.CaptionFont, Brushes.White, r, sf);
            }
        }

        #endregion

        #region SuperGridControl1FilterPopupValueChanged

        /// <summary>
        /// This routine is called when the user selects an
        /// item from the ItemPanel FilterPopup.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1FilterPopupValueChanged(
            object sender, GridFilterPopupValueChangedEventArgs e)
        {
            // If the user has selected the "Custom" entry for the
            // "FirstName" column - and the current Filter Expression
            // is null, let's initialize a default expresion for them.

            if (e.FilterItemType == FilterItemType.Custom)
            {
                if (e.GridColumn.Name.Equals("FirstName"))
                {
                    // There are 3 'filter' items that control the
                    // filtering interaction and display of each column.
                    //
                    // The FilterExpr is the parsed expression string that
                    // defines the filter criteria.
                    //
                    // The FilterValue is the value used by the FilterPanel
                    // edit control when editing.
                    // 
                    // And the FilterDisplayValue is what is displayed in the
                    // FilterPanel when not editing.

                    if (e.GridColumn.FilterExpr == null)
                    {
                        e.FilterValue = null;
                        e.FilterDisplayValue = "Between \"J\" and \"M\"";

                        e.FilterExpr = "substring(" +
                            e.GridColumn.Name + ", 0, 1) " + e.FilterDisplayValue;
                    }
                }
            }
        }

        #endregion

        #endregion

        #region FilterPanel support

        #region SuperGridControl1FilterBeginEdit

        /// <summary>
        /// This routine is called when the user clicks in
        /// a GridFilter cell and a FilterPanel edit is
        /// about to begin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1FilterBeginEdit(
            object sender, GridFilterBeginEditEventArgs e)
        {
            // The e.GridColumn will be null if the user has clicked
            // in the GridFilter RowHeader area - thus launching an edit
            // of the row level filter (Custom filter dialog will be
            // launched by default).

            if (e.GridColumn != null)
            {
                // If it is for the "Index" column, then do some
                // non-sensical user validation for demonstration.

                if (e.GridColumn.Name.Equals("Index"))
                    e.Cancel = GetIndexMonitorResult();
            }
        }

        #endregion

        #region SuperGridControl1FilterLoadItems

        /// <summary>
        /// This routine is called before the system has loaded its
        /// default FilterPanel items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1FilterLoadItems(
            object sender, GridFilterLoadItemsEventArgs e)
        {
            // If the FilterPopup is for the "LastName" column then
            // let's add some 'range' items to the top of the list.

            if (e.GridColumn.Name.Equals("LastName"))
            {
                e.ComboBox.Items.Add(new MyItem("\"A\" to \"E\""));
                e.ComboBox.Items.Add(new MyItem("\"F\" to \"J\""));
                e.ComboBox.Items.Add(new MyItem("\"K\" to \"O\""));
                e.ComboBox.Items.Add(new MyItem("\"P\" to \"T\""));
                e.ComboBox.Items.Add(new MyItem("\"U\" to \"Z\""));
            }
        }

        #endregion

        #region SuperGridControl1FilterEditValueChanged

        /// <summary>
        /// This routine is called when the user has changed
        /// the FilterPanel edit value (TextBox, ComboBox, or CheckBox).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1FilterEditValueChanged(
            object sender, GridFilterEditValueChangedEventArgs e)
        {
            if (e.GridColumn.Name.Equals("Age"))
                AgeEditValueChanged(e);

            else if (e.GridColumn.Name.Equals("LastName"))
                LastNameEditValueChanged(e);
        }

        #region AgeEditValueChanged

        /// <summary>
        /// This routine handles "Age" related edit changes.
        /// </summary>
        /// <param name="e"></param>
        private void AgeEditValueChanged(GridFilterEditValueChangedEventArgs e)
        {
            string s = e.NewValue as string;

            if (s != null)
            {
                // Let's permit the user to type in things like
                // "20-25,27,31-40" as a valid edit filter.

                Regex reg = new Regex("((?<age>\\d+(?!-)\\b)|(?<range>\\d+-\\d+))\\s*,*\\s*");
                MatchCollection mc = reg.Matches(s);

                if (mc.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (Match ma in mc)
                    {
                        Group gp = ma.Groups["age"];

                        sb.Append(e.GridColumn.Name);

                        if (gp != null && string.IsNullOrEmpty(gp.Value) == false)
                            sb.Append(" is like \"" + gp.Value + "\" or ");

                        gp = ma.Groups["range"];

                        if (gp != null && string.IsNullOrEmpty(gp.Value) == false)
                        {
                            string[] t = gp.Value.Split('-');

                            sb.Append(" is between " + t[0] + " and " + t[1] + " or ");
                        }
                    }

                    sb.Length -= 4;

                    // Override the default parsed SuperGrid Filter Expression
                    // with our new range enabled expression.

                    e.NewExpr = sb.ToString();
                    e.NewDisplayValue = s;
                }
            }
        }

        #endregion

        #region LastNameEditValueChanged

        /// <summary>
        /// This routine handles "LastName" related edit changes.
        /// </summary>
        /// <param name="e"></param>
        private void LastNameEditValueChanged(GridFilterEditValueChangedEventArgs e)
        {
            ComboBoxEx cb = e.FilterPanel.Control as ComboBoxEx;

            if (cb != null)
            {
                // We only want to handle selections for our
                // items, so make sure it is one of our items.

                MyItem item = cb.SelectedItem as MyItem;

                if (item != null)
                {
                    string s = ((string)e.NewValue).Replace("to", "and");

                    e.NewExpr = "LastName between " + s;
                }
            }
        }

        #endregion

        #endregion

        #region MyItem

        /// <summary>
        /// Simple class def for items added to
        /// the FilterPanel dropDown.
        /// </summary>
        private class MyItem
        {
            public string Item;

            public MyItem(string item)
            {
                Item = item;
            }

            public override string ToString()
            {
                return (Item);
            }
        }

        #endregion

        #endregion

        #region GetIndexMonitorResult

        /// <summary>
        /// Routine presents a modal OKCancel dialog
        /// to the user.
        /// </summary>
        /// <returns>true to cancel</returns>
        private bool GetIndexMonitorResult()
        {
            // If it is the first time the user has selected the
            // "Index" FilterPopup or FilterPanel, then present them
            // with the "Monitoring" dialog.

            if (_FilterIndexOk == false)
            {
                DialogResult result = MessageBoxEx.Show(
                    "Operation will be logged. Do you want to continue?",
                    "Monitored operation", MessageBoxButtons.OKCancel);

                _FilterIndexOk = (result == DialogResult.OK);
            }

            return (_FilterIndexOk == false);
        }

        #endregion

        #region SuperGridControl1FilterUserFunction

        /// <summary>
        /// This routine shows how to add user defined
        /// functions that can be accessed via the expression
        /// evaluator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SuperGridControl1FilterUserFunction(
            object sender, GridFilterUserFunctionEventArgs e)
        {
            // The first argument is the name of the user defined
            // function.  In this case we are being presented with
            // the "Sqrt" (square root) function.

            if (e.Args[0].Equals("sqrt"))
            {
                if (e.Args.Length != 2)
                    throw new Exception("Sqrt: Invalid arg count");

                // Arguments 1 through e.Args.Length - 1 are the
                // actual user supplied arguments to the function.

                object o = e.Args[1];

                // If the argument is null or empty, then
                // just set the result as 0 for the square root.

                if (o is EmptyFilterOp || o == null || o == DBNull.Value)
                    e.Result = 0;
                else
                    e.Result = Math.Sqrt(Convert.ToDouble(o));

                // Let the grid know we handled the function

                e.Handled = true;
            }
        }

        #endregion

        #region BtnResetPanelFilterClick

        /// <summary>
        /// Handles user request to reset the panel's
        /// row level filter
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
        /// Handles user's request to
        /// reset every column level filter.
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

        #region AddRows

        /// <summary>
        /// Routine to add a random set of rows to the grid.
        /// </summary>
        private void AddRows()
        {
            Random rand = new Random();

            superGridControl1.BeginUpdate();

            GridPanel panel = superGridControl1.PrimaryGrid;

            // Add 500 root rows for the user to filter.

            for (int i = 0; i < 500; i++)
            {
                GridRow row = GetNewRow(i);

                panel.Rows.Add(row);

                // Add a random number of sub-rows (2 to 7).

                int m = rand.Next(2, 7);

                for (int j = 0; j < m; j++)
                    row.Rows.Add(GetNewRow(rand.Next(0, 500)));
            }

            superGridControl1.EndUpdate();
        }

        #region GetNewRow

        /// <summary>
        /// Create a new random Employee row
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        private GridRow GetNewRow(int count)
        {
            MyEmployee emp = MyEmployee.GetNewEmployee();

            object firstName = (emp.Age % 7 == 0 ? (object)DBNull.Value : emp.FirstName);
            object age = (emp.Age % 5 == 0 ? null : (object)emp.Age);
            object citizen = (emp.Age % 3 == 0 ? null : (object)emp.Citizen);
            object hireDate = (emp.Age % 6 == 0 ? null : (object)emp.HireDate);

            object[] ob1 = new object[]
                { count, emp.LastName, firstName, age, hireDate, citizen };

            if (count % 100 == 50)
            {
                int n = count % 6 + 1;

                object[] ob2 = new object[n];

                for (int j = 0; j < n; j++)
                    ob2[j] = ob1[j];

                return (new GridRow(ob2));
            }
            
            return (new GridRow(ob1));
        }

        #endregion

        #endregion

        #region CbxShowPanelExprCheckedChanged

        /// <summary>
        /// Routine handles checkbox changes for displaying
        /// the actual filter expression, or the "Custom" defined
        /// string, in the FilterPanel cell (when not editing).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxShowPanelExprCheckedChanged(object sender, EventArgs e)
        {
            superGridControl1.PrimaryGrid.Filter.ShowPanelFilterExpr =
                cbxShowPanelExpr.Checked;
        }

        #endregion

        #region CbxUseAgeSliderCheckedChanged

        /// <summary>
        /// Handles checkbox changes for using a user defined
        /// Slider control for the "Age" column FilterPopup.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxUseAgeSliderCheckedChanged(object sender, EventArgs e)
        {
            // The column's FilterPopupSize tracks user size changes
            // to the associated FilterPopup.  When we change the popup's
            // underlying Control, we want to reset this so the popup will
            // be more correctly sized for the changed control.

            GridColumn column = superGridControl1.PrimaryGrid.Columns["Age"];

            if (column != null)
                column.FilterPopupSize = Size.Empty;
        }

        #endregion

        #region CbFilterAlignmentSelectedIndexChanged

        /// <summary>
        /// Handles user comboBox selections to change the
        /// alignment of the ColumnHeader Filter Image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbFilterAlignmentSelectedIndexChanged(object sender, EventArgs e)
        {
            Alignment align = (Alignment)Enum.Parse(typeof(Alignment),
                (string)cbFilterAlignment.SelectedItem);

            superGridControl1.PrimaryGrid.ColumnHeader.FilterImageAlignment = align;
        }

        #endregion

        #region CbFilterImageVisibilitySelectedIndexChanged

        /// <summary>
        /// Handles user comboBox selections to change the
        /// visibility of the ColumnHeader filter image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbFilterImageVisibilitySelectedIndexChanged(object sender, EventArgs e)
        {
            ImageVisibility vis = (ImageVisibility)Enum.Parse(typeof(ImageVisibility),
                (string)cbFilterImageVisibility.SelectedItem);

            superGridControl1.PrimaryGrid.ColumnHeader.FilterImageVisibility = vis;
        }

        #endregion

        #region CbMatchTypeSelectedIndexChanged

        /// <summary>
        /// Handles user comboBox selections to change the
        /// default filtering Match Type.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CbMatchTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            FilterMatchType fms = (FilterMatchType)Enum.Parse(
                typeof(FilterMatchType), cbMatchType.Text);

            superGridControl1.PrimaryGrid.FilterMatchType = fms;
        }

        #endregion

        #region CbFilterLevelSelectedIndexChanged

        /// <summary>
        /// Handles FilterLevel changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbFilterLevelSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterLevel.SelectedIndex >= 0)
            {
                superGridControl1.PrimaryGrid.FilterLevel =
                    (FilterLevel)Enum.Parse(typeof(FilterLevel), (string)cbFilterLevel.SelectedItem);
            }
        }

        #endregion
    }
}