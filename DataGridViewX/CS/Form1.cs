using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Rendering;

namespace DataGridViewX
{
    public partial class Form1 : Office2007Form
    {
        #region Private variables

        private bool _MColorSelected;
        private eOffice2007ColorScheme _MBaseColorScheme = eOffice2007ColorScheme.Blue;
        private List<string> _ContactTypes;

        #endregion

        public Form1()
        {
            InitializeComponent();

            // Initialize our X1 and X2 DataGridViews

            X1_Initialize();
            X2_Initialize();
        }

        #region Form1_Load

        private void Form1_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the
            // 'customersDataSet.Customers' table. You can move, or remove it, as needed.

            customersTableAdapter.Fill(this.customersDataSet.Customers);

            LoadOrderData();
        }

        #region LoadOrderData

        /// <summary>
        /// Loads default Order data into the
        /// customersDataSet.Orders data table
        /// </summary>
        private void LoadOrderData()
        {
            Random r = new Random();
            DateTime date = DateTime.Now;
            StringBuilder sb = new StringBuilder();

            // Loop through the customersDataSet.Customers data table and
            // add an Order into the customersDataSet.Orders for each one

            for (int i = 0; i < customersDataSet.Customers.Count; i++)
            {
                customersDataSet.Orders.AddOrdersRow(
                    customersDataSet.Customers[i].CustomerID,
                    r.Next(1000, 9999).ToString(),
                    date.AddDays(-r.Next(2, 90)),
                    GetNewPart(sb, r),
                    (decimal) (r.NextDouble() * 100),
                    r.Next(1, 100),
                    r.Next(1, 100),
                    Math.Max(0, Math.Min(r.Next(-20, 140), 100)),
                    GetNewFeedback(r));
            }
        }

        #region GetNewPart

        /// <summary>
        /// Gets a new Part number for the order that
        /// conforms to the "DD-AAA-DDDDA" pattern
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        private string GetNewPart(StringBuilder sb, Random r)
        {
            sb.Length = 0;

            sb.Append(r.Next(10, 99));
            sb.Append((char)r.Next(0x41, 0x5b));
            sb.Append((char)r.Next(0x41, 0x5b));
            sb.Append((char)r.Next(0x41, 0x5b));
            sb.Append(r.Next(1000, 9999));
            sb.Append(r.Next(0, 2) == 0 ? "N" : "R");

            return (sb.ToString());
        }

        #endregion

        #region GetNewFeedback

        /// <summary>
        /// Gets a new order feedback value
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        private string GetNewFeedback(Random r)
        {
            int fb = r.Next(0, 4);

            return (fb == 0 ? "U" : fb == 1 ? "N" : "Y");
        }

        #endregion

        #endregion

        #endregion

        #region DataGridViewX1 support

        #region X1_Initialize

        /// <summary>
        /// Initialize our Data~GridViewX1 sample view
        /// </summary>
        private void X1_Initialize()
        {
            X1Contact_Initialize();
            X1Country_Initialize();
            X1Region_Initialize();
            X1PostalCode_Initialize();

            // Hook onto the CellContentClick so we can
            // demonstrate one way to process cell clicks

            dataGridViewX1.CellContentClick += DataGridViewX1_CellContentClick;
        }

        #endregion

        #region X1Contact_Initialize

        /// <summary>
        /// Initializes out X1 Contact environment
        /// </summary>
        private void X1Contact_Initialize()
        {
            DataGridViewButtonXColumn bcx =
                dataGridViewX1.Columns["Contact"] as DataGridViewButtonXColumn;

            if (bcx != null)
            {
                // Allocate our running list of
                // selected contact types

                _ContactTypes = new List<string>();
                _ContactTypes.Add("Owner");

                // We want to be able to specify our own button text
                // instead of using the bound data value for the text

                bcx.UseColumnTextForButtonValue = false;

                // Hook onto the following events so we can
                // demonstrate cell customization and click processing

                bcx.BeforeCellPaint += X1Contact_BeforeCellPaint;
                bcx.Click += X1Contact_ButtonClick;
            }
        }

        #region X1Contact_BeforeCellPaint

        /// <summary>
        /// Handles "Contact" BeforeCellPaint events
        /// </summary>
        /// <param name="sender">DataGridViewButtonXColumn</param>
        /// <param name="e">BeforeCellPaintEventArgs</param>
        void X1Contact_BeforeCellPaint(object sender, BeforeCellPaintEventArgs e)
        {
            DataGridViewButtonXColumn bcx = sender as DataGridViewButtonXColumn;

            if (bcx != null)
            {
                // If the cell text is in our _ContactTypes list, then
                // give our button a default background - otherwise not.

                bcx.ColorTable = _ContactTypes.Contains(bcx.Text) ?
                    eButtonColor.OrangeWithBackground : eButtonColor.Orange;
            }
        }

        #endregion

        #region X1Contact_ButtonClick

        /// <summary>
        /// Handles our "Contact" cell button clicks.
        /// 
        /// <remarks>
        /// Clicking on a "Contact" cell will result in the addition or removal of the
        /// cell text from our _ContactTypes list.  The _ContactTypes list is then used
        /// in the BeforeContactCellPaint routine to format the cell display.
        /// </remarks>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void X1Contact_ButtonClick(object sender, EventArgs e)
        {
            DataGridViewButtonXCell cell =
                dataGridViewX1.CurrentCell as DataGridViewButtonXCell;

            if (cell != null)
            {
                string s = Convert.ToString(cell.Value);

                // If the text was already in our list, then remove it.
                // If it wasn't, then add it.

                if (_ContactTypes.Contains(s))
                    _ContactTypes.Remove(s);
                else
                    _ContactTypes.Add(s);

                // Update the entire column so that each column cell
                // will be reformatted according to the new list values.

                dataGridViewX1.InvalidateColumn(cell.ColumnIndex);
            }
        }

        #endregion

        #endregion

        #region X1Country_Initialize

        /// <summary>
        /// Initializes our X1 Country environment
        /// </summary>
        private void X1Country_Initialize()
        {
            DataGridViewButtonXColumn bcx =
                dataGridViewX1.Columns["Country"] as DataGridViewButtonXColumn;

            if (bcx != null)
            {
                // We want to be able to specify our own button text
                // instead of using the bound data value for the text

                bcx.UseColumnTextForButtonValue = false;

                // Hook onto the BeforeCellPaint event so we can
                // demonstrate cell customization

                bcx.BeforeCellPaint += X1Country_BeforeCellPaint;
            }
        }

        #region X1Country_BeforeCellPaint

        /// <summary>
        /// Handles our "Country" BeforeCellPaint events
        /// </summary>
        /// <param name="sender">DataGridViewButtonXColumn</param>
        /// <param name="e">BeforeCellPaintEventArgs</param>
        void X1Country_BeforeCellPaint(object sender, BeforeCellPaintEventArgs e)
        {
            DataGridViewButtonXColumn bcx = sender as DataGridViewButtonXColumn;

            // Set the button flag image to correspond to country

            if (bcx != null)
                bcx.Image = imageList1.Images[bcx.Text];
        }

        #endregion

        #endregion

        #region X1Region_Initialize

        /// <summary>
        /// Initializes our X1 Region environment
        /// </summary>
        private void X1Region_Initialize()
        {
            DataGridViewButtonXColumn bcx =
                dataGridViewX1.Columns["Region"] as DataGridViewButtonXColumn;

            if (bcx != null)
            {
                // Create and add a couple of levels
                // of SubItems to our cell button

                X1Region_AddSubItems(bcx);

                // We want to be able to specify our own button text
                // instead of using the bound data value for the text

                bcx.UseColumnTextForButtonValue = false;

                // Hook onto the BeforeCellPaint event so we can
                // demonstrate cell customization

                bcx.BeforeCellPaint += X1Region_BeforeCellPaint;
            }
        }

        #region X1Region_AddSubItems

        /// <summary>
        /// Creates and adds a couple of SubItem buttons
        /// to the Region cell button
        /// </summary>
        /// <param name="bcx"></param>
        private void X1Region_AddSubItems(DataGridViewButtonXColumn bcx)
        {
            ButtonItem bi = new ButtonItem();
            bi.Text = "Display Region Map";
            bi.Click += X1Region_DefaultButtonClick;

            bcx.SubItems.Add(bi);

            bi = new ButtonItem();
            bi.Text = "Print...";
            bi.Image = imageList1.Images["Print"];

            bcx.SubItems.Add(bi);

            ButtonItem sbi = new ButtonItem();
            sbi.Text = "Region Contacts";
            sbi.Image = imageList1.Images["User"];
            sbi.Click += X1Region_DefaultButtonClick;

            bi.SubItems.Add(sbi);

            sbi = new ButtonItem();
            sbi.Text = "Region Statistics";
            sbi.Click += X1Region_DefaultButtonClick;

            bi.SubItems.Add(sbi);
        }

        #region X1Region_DefaultButtonClick

        /// <summary>
        /// Handles X2 "Region" SubItem button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void X1Region_DefaultButtonClick(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
                MessageBox.Show(bi.Text + " printed.");
        }

        #endregion

        #endregion

        #region X1Region_BeforeCellPaint

        /// <summary>
        /// Handles "Region" BeforeCellPaint events
        /// </summary>
        /// <param name="sender">DataGridViewButtonXColumn</param>
        /// <param name="e">BeforeCellPaintEventArgs</param>
        void X1Region_BeforeCellPaint(object sender, BeforeCellPaintEventArgs e)
        {
            DataGridViewButtonXColumn bcx = sender as DataGridViewButtonXColumn;

            if (bcx != null)
            {
                // If button text is null or empty, then set the text and
                // ColorTable to reflect that fact

                if (string.IsNullOrEmpty(bcx.Text) == true)
                {
                    bcx.Text = "<font color=\"FireBrick\">(Unknown)</font>";
                    bcx.ColorTable = eButtonColor.Magenta;
                }
                else
                {
                    bcx.ColorTable = eButtonColor.OrangeWithBackground;
                }
            }
        }

        #endregion

        #endregion

        #region X1PostalCode_Initialize

        /// <summary>
        /// Initializes our X1 PostalCode environment
        /// </summary>
        private void X1PostalCode_Initialize()
        {
            DataGridViewLabelXColumn bcx =
                dataGridViewX1.Columns["PostalCode"] as DataGridViewLabelXColumn;

            if (bcx != null)
            {
                // Hook onto the BeforeCellPaint event so we can
                // demonstrate cell customization

                bcx.BeforeCellPaint += X1PostalCode_BeforeCellPaint;
            }
        }

        #region X1PostalCode_BeforeCellPaint

        /// <summary>
        /// Handles "PostalCode" BeforeCellPaint events
        /// </summary>
        /// <param name="sender">DataGridViewButtonXColumn</param>
        /// <param name="e">BeforeCellPaintEventArgs</param>
        void X1PostalCode_BeforeCellPaint(object sender, BeforeCellPaintEventArgs e)
        {
            DataGridViewLabelXColumn bcx = sender as DataGridViewLabelXColumn;

            if (bcx != null)
            {
                // Set the label image

                if (string.IsNullOrEmpty(bcx.Text) == true)
                {
                    bcx.Image = imageList1.Images["SecHigh"];
                    bcx.Text = "<font color=\"red\">Postal Code not Specified</font>";
                }
                else if (bcx.Text.Contains(" "))
                    bcx.Image = imageList1.Images["SecMedium"];

                else
                    bcx.Image = imageList1.Images["SecLow"];
            }
        }

        #endregion

        #endregion

       #endregion

        #region DataGridViewX2 support

        #region X2_Initialize

        /// <summary>
        /// Initialize out DataGridViewX2 sample view.
        /// </summary>
        private void X2_Initialize()
        {
            X2Order_Initialize();
            X2Date_Initialize();
            X2Part_Initialize();
            X2Quality_Initialize();
            X2Progress_Initialize();
            X2Feedback_Initialize();
        }

        #endregion

        #region X2Order_Initialize

        /// <summary>
        /// Initializes our X2 "Order" environment
        /// </summary>
        private void X2Order_Initialize()
        {
            DataGridViewMaskedTextBoxAdvColumn oc =
                dataGridViewX2.Columns["Order"] as DataGridViewMaskedTextBoxAdvColumn;

            if (oc != null)
            {
                // Hook onto the following events so we can
                // demonstrate cell customization and click processing

                oc.BeforeCellPaint += X2Order_BeforeCellPaint;
                oc.ButtonClearClick += X2Order_ButtonClearClick;
                oc.ButtonCustomClick += X2Order_ButtonCustomClick;
            }
        }

        #region X2Order_BeforeCellPaint

        /// <summary>
        /// Handles "Order" BeforeCellPaint events
        /// </summary>
        /// <param name="sender">DataGridViewMaskedTextBoxAdvColumn</param>
        /// <param name="e">BeforeCellPaintEventArgs</param>
        void X2Order_BeforeCellPaint(object sender, BeforeCellPaintEventArgs e)
        {
            DataGridViewMaskedTextBoxAdvColumn oc =
                sender as DataGridViewMaskedTextBoxAdvColumn;

            if (oc != null)
            {
                string s = oc.Text.Substring(1);

                int value;

                if (int.TryParse(s, out value))
                {
                    if (value <= 3000)
                        oc.BackColor = Color.MistyRose;

                    else if (value >= 7000)
                        oc.BackColor = Color.PaleTurquoise;
                }
            }
        }

        #endregion

        #region X2Order_ButtonClearClick

        /// <summary>
        /// Handles X2 "Order" ButtonClear Clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void X2Order_ButtonClearClick(object sender, CancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to clear this Order Number?", "Clear Order Number",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                              MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.No)
                e.Cancel = true;
        }

        #endregion

        #region X2Order_ButtonCustomClick

        /// <summary>
        /// Handles X2 "Order" ButtonCustom clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void X2Order_ButtonCustomClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Assign new Order Number?", "New Order Number",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button1);

            if (dr == DialogResult.Yes)
            {
                DataGridViewMaskedTextBoxAdvCell cell =
                    dataGridViewX2.CurrentCell as DataGridViewMaskedTextBoxAdvCell;

                if (cell != null)
                {
                    DataGridViewMaskedTextBoxAdvEditingControl ec =
                        cell.DataGridView.EditingControl as DataGridViewMaskedTextBoxAdvEditingControl;

                    if (ec != null)
                    {
                        Random rand = new Random();

                        ec.Text = rand.Next(1, 9999).ToString();
                    }
                }
            }
        }

        #endregion

        #endregion

        #region X2Date_Initialize

        /// <summary>
        /// Initializes our X2 "Date" environment
        /// </summary>
        private void X2Date_Initialize()
        {
            DataGridViewDateTimeInputColumn oc =
                dataGridViewX2.Columns["Date"] as DataGridViewDateTimeInputColumn;

            if (oc != null)
            {
                // Hook onto the following events so we can
                // demonstrate cell click processing

                oc.ButtonClearClick += X2Date_ButtonClearClick;
                oc.ButtonCustomClick += X2Date_ButtonCustomClick;
            }
        }

        #region X2Date_ButtonClearClick

        /// <summary>
        /// Handles X2 "Date" ButtonClear Clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void X2Date_ButtonClearClick(object sender, CancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to clear this Date?", "Clear Date",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                              MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.No)
                e.Cancel = true;
        }

        #endregion

        #region X2Date_ButtonCustomClick

        /// <summary>
        /// Handles X2 "Date" ButtonCustom click events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void X2Date_ButtonCustomClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Set Date to today?", "Set Date",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button1);

            if (dr == DialogResult.Yes)
            {
                DataGridViewDateTimeInputCell cell =
                    dataGridViewX2.CurrentCell as DataGridViewDateTimeInputCell;

                if (cell != null)
                {
                    DataGridViewDateTimeInputEditingControl ec =
                        cell.DataGridView.EditingControl as DataGridViewDateTimeInputEditingControl;

                    if (ec != null)
                        ec.Text = DateTime.Today.ToString();
                }
            }
        }

        #endregion

        #endregion

        #region X2Part_Initialize

        /// <summary>
        /// Initializes our X2 "Part" environment
        /// </summary>
        private void X2Part_Initialize()
        {
            DataGridViewMaskedTextBoxAdvColumn oc =
                dataGridViewX2.Columns["Part"] as DataGridViewMaskedTextBoxAdvColumn;

            if (oc != null)
            {
                // Hook onto the following events so we can
                // demonstrate cell customization and click processing

                oc.BeforeCellPaint += X2Part_BeforeCellPaint;
                oc.ButtonCustomClick += X2Part_ButtonCustomClick;
                oc.ButtonDropDownClick += X2Part_ButtonDropDownClick;
            }
        }

        #region X2Part_BeforeCellPaint

        /// <summary>
        /// Handles X2 "Part" BeforeCellPaint events
        /// </summary>
        /// <param name="sender">DataGridViewMaskedTextBoxAdvColumn</param>
        /// <param name="e">BeforeCellPaintEventArgs</param>
        void X2Part_BeforeCellPaint(object sender, BeforeCellPaintEventArgs e)
        {
            DataGridViewMaskedTextBoxAdvColumn oc =
                sender as DataGridViewMaskedTextBoxAdvColumn;

            if (oc != null)
            {
                string s = oc.Text;

                if (s.EndsWith("N") == true)
                    oc.ForeColor = Color.Green;

                else if (s.EndsWith("X") == true)
                    oc.ForeColor = Color.Red;
            }
        }

        #endregion

        #region X2Part_ButtonCustomClick

        /// <summary>
        /// Handles X2 "Part" ButtonCustomClick events
        /// </summary>
        /// <param name="sender">DataGridViewMaskedTextBoxAdvCell</param>
        /// <param name="e">EventArgs</param>
        void X2Part_ButtonCustomClick(object sender, EventArgs e)
        {
            DataGridViewMaskedTextBoxAdvCell cell =
                dataGridViewX2.CurrentCell as DataGridViewMaskedTextBoxAdvCell;

            if (cell != null)
            {
                DataGridViewMaskedTextBoxAdvEditingControl ec =
                    cell.DataGridView.EditingControl as DataGridViewMaskedTextBoxAdvEditingControl;

                if (ec != null)
                {
                    string s = ec.Text;

                    if (s.Length > 0)
                    {
                        // Changed the ending text char and display some
                        // nonsense to the user for feedback

                        ec.Text = s.Substring(0, s.Length - 1) + "X";

                        MessageBox.Show("Inventory part " + s + " added to bug tracking database.",
                                        "Bug Track", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        #endregion

        #region X2Part_ButtonDropDownClick

        /// <summary>
        /// Handles X2 "Part" ButtonDropDown click events
        /// </summary>
        /// <param name="sender">DataGridViewMaskedTextBoxAdvCell</param>
        /// <param name="e">CancelEventArgs</param>
        void X2Part_ButtonDropDownClick(object sender, CancelEventArgs e)
        {
            DataGridViewMaskedTextBoxAdvCell cell =
                dataGridViewX2.CurrentCell as DataGridViewMaskedTextBoxAdvCell;

            if (cell != null)
            {
                DataGridViewMaskedTextBoxAdvEditingControl ec =
                    cell.DataGridView.EditingControl as DataGridViewMaskedTextBoxAdvEditingControl;

                if (ec != null)
                {
                    cbNewParts.Checked = ec.Text.EndsWith("N");
                    cbRefurbishedParts.Checked = ec.Text.EndsWith("R");
                }
            }
        }

        #endregion

        #endregion

        #region X2Quality_Initialize

        /// <summary>
        /// Initializes our X2 "Quality" environment
        /// </summary>
        private void X2Quality_Initialize()
        {
            DataGridViewSliderColumn sc =
                dataGridViewX2.Columns["Quality"] as DataGridViewSliderColumn;

            // Hook onto the BeforeCellPaint event so we can
            // demonstrate cell customization

            if (sc != null)
                sc.BeforeCellPaint += X2Quality_BeforeCellPaint;
        }

        #region X2Quality_BeforeCellPaint

        /// <summary>
        /// Handles X2 "Quality" BeforeCellPaint events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void X2Quality_BeforeCellPaint(object sender, BeforeCellPaintEventArgs e)
        {
            DataGridViewSliderColumn sc =
                sender as DataGridViewSliderColumn;

            if (sc != null)
            {
                sc.Text = Convert.ToString(sc.Value);
                sc.TextColor = (sc.Value <= 30) ? Color.Red : sc.Value >= 90 ? Color.Green : Color.Blue;
            }
        }

        #endregion

        #endregion

        #region X2Progress_Initialize

        /// <summary>
        /// Initializes our X2 "Progress" environment
        /// </summary>
        private void X2Progress_Initialize()
        {
            DataGridViewProgressBarXColumn pb =
                dataGridViewX2.Columns["Progress"] as DataGridViewProgressBarXColumn;

            // Hook onto the BeforeCellPaint event so we can
            // demonstrate cell customization

            if (pb != null)
                pb.BeforeCellPaint += X2Progress_BeforeCellPaint;
        }

        #region X2Progress_BeforeCellPaint

        /// <summary>
        /// Handles X2 "Progress" BeforeCellPaint events
        /// </summary>
        /// <param name="sender">DataGridViewProgressBarXColumn</param>
        /// <param name="e">BeforeCellPaintEventArgs</param>
        void X2Progress_BeforeCellPaint(object sender, BeforeCellPaintEventArgs e)
        {
            DataGridViewProgressBarXColumn pbc =
                sender as DataGridViewProgressBarXColumn;

            if (pbc != null)
            {
                switch (pbc.Value)
                {
                    case 0:
                        pbc.Text = "Not Started";
                        break;

                    case 100:
                        pbc.Text = "Completed";
                        pbc.ColorTable = eProgressBarItemColor.Normal;
                        break;

                    default:
                        pbc.Text = "";
                        pbc.ColorTable = eProgressBarItemColor.Paused;
                        break;
                }

                if (pbc.Value < 30)
                    pbc.ColorTable = eProgressBarItemColor.Error;
            }
        }

        #endregion

        #endregion

        #region X2Feedback_Initialize

        /// <summary>
        /// Initializes our X2 "Feedback" environment
        /// </summary>
        private void X2Feedback_Initialize()
        {
            DataGridViewCheckBoxXColumn cb =
                dataGridViewX2.Columns["Feedback"] as DataGridViewCheckBoxXColumn;

            // Hook onto the BeforeCellPaint event so we can
            // demonstrate cell customization

            if (cb != null)
                cb.BeforeCellPaint += X2Feedback_BeforeCellPaint;
        }

        #region X2Feedback_BeforeCellPaint

        /// <summary>
        /// Handles X2 "Feedback" BeforeCellPaint events
        /// </summary>
        /// <param name="sender">DataGridViewCheckBoxXColumn</param>
        /// <param name="e">BeforeCellPaintEventArgs</param>
        void X2Feedback_BeforeCellPaint(object sender, BeforeCellPaintEventArgs e)
        {
            DataGridViewCheckBoxXColumn sc =
                sender as DataGridViewCheckBoxXColumn;

            if (sc != null)
            {
                switch (sc.CheckState)
                {
                    case CheckState.Checked:
                        sc.Text = "Positive";
                        sc.TextColor = Color.Green;
                        break;

                    case CheckState.Unchecked:
                        sc.Text = "Negative";
                        sc.TextColor = Color.Red;
                        break;

                    default:
                        sc.Text = "----";
                        sc.TextColor = Color.DarkGray;
                        break;
                }
            }
        }

        #endregion

        #region cbNewParts_Click

        /// <summary>
        /// Handles X2 "Part" type change "N" events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbNewParts_Click(object sender, EventArgs e)
        {
            X2Part_UpdatePartType("N");
        }

        #endregion

        #region cbRefurbishedParts_Click

        /// <summary>
        /// Handles X2 "Part" type change "R" events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbRefurbishedParts_Click(object sender, EventArgs e)
        {
            X2Part_UpdatePartType("R");
        }

        #endregion

        #region X2Part_UpdatePartType

        /// <summary>
        /// Updates the X2 "Part" type from the users
        /// RadioButton selection
        /// </summary>
        /// <param name="t">Text to replace</param>
        private void X2Part_UpdatePartType(string t)
        {
            DataGridViewMaskedTextBoxAdvCell cell =
                dataGridViewX2.CurrentCell as DataGridViewMaskedTextBoxAdvCell;

            if (cell != null)
            {
                DataGridViewMaskedTextBoxAdvEditingControl ec =
                    cell.DataGridView.EditingControl as DataGridViewMaskedTextBoxAdvEditingControl;

                if (ec != null)
                {
                    string s = ec.Text;

                    if (s.EndsWith(t) == false)
                        ec.Text = s.Substring(0, s.Length - 1) + t;
                }
            }
        }

        #endregion

        #endregion

        #endregion

        #region DataGridViewX1_CellContentClick

        void DataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonXCell cell = dataGridViewX1.CurrentCell as DataGridViewButtonXCell;

            if (cell != null)
            {
                DataGridViewButtonXColumn bc =
                    dataGridViewX1.Columns[e.ColumnIndex] as DataGridViewButtonXColumn;

                if (bc != null)
                {
                    string s = Convert.ToString(cell.Value);

                    switch (bc.Name)
                    {
                        case "Country":
                            MessageBox.Show("What a great country " + s + " is!", "",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                        case "Region":
                            cell.Value = string.IsNullOrEmpty(s) ? "Global" : "";
                            break;
                    }
                }
            }
        }

        #endregion

        #region BtnBlue_Click

        /// <summary>
        /// Sets the ColorScheme to Blue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBlue_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2007Blue;
            lblChange.ForeColor = Color.Black;

            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(eOffice2007ColorScheme.Blue);
        }

        #endregion

        #region BtnBlack_Click

        /// <summary>
        /// Sets the ColorScheme to Black
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBlack_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2007Black;
            lblChange.ForeColor = Color.White;

            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(eOffice2007ColorScheme.Black);
        }

        #endregion

        #region BtnSilver_Click

        /// <summary>
        /// Sets the ColorScheme to Silver
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSilver_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2007Silver;
            lblChange.ForeColor = Color.Black;

            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(eOffice2007ColorScheme.Silver);
        }

        #endregion

        #region ColorPicker support

        #region ColorPickerDropDown1_ColorPreview

        /// <summary>
        /// Preview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorPickerDropDown1_ColorPreview(object sender, ColorPreviewEventArgs e)
        {
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(_MBaseColorScheme, e.Color);
        }

        #endregion

        #region ColorPickerDropDown1_ExpandChange

        /// <summary>
        /// ExpandChange
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorPickerDropDown1_ExpandChange(object sender, EventArgs e)
        {
            if (colorPickerDropDown1.Expanded)
            {
                // Remember the starting color scheme to apply
                // if no color is selected during live-preview

                _MColorSelected = false;
                _MBaseColorScheme = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.InitialColorScheme;
            }
            else
            {
                if (_MColorSelected == false)
                    RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(_MBaseColorScheme);
            }
        }

        #endregion

        #region ColorPickerDropDown1_SelectedColorChanged

        private void ColorPickerDropDown1_SelectedColorChanged(object sender, EventArgs e)
        {
            // Indicate that color was selected for buttonStyleCustom_ExpandChange method

            _MColorSelected = true;

            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(_MBaseColorScheme, colorPickerDropDown1.SelectedColor);
        }

        #endregion

        #endregion
    }
}