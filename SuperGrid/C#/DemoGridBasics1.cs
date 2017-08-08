using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace SuperGridDemo
{
    public partial class DemoGridBasics1 : Office2007Form
    {
        public DemoGridBasics1()
        {
            InitializeComponent();

            // Initialize the grid and set the sample description text

            InitializeGrid();

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoBasics1.rtf");
        }

        #region InitializeGrid

        /// <summary>
        /// Initializes the default state of the grid
        /// </summary>
        private void InitializeGrid()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            string[] orderArray = { "Asterids", "Eudicots", "Rosids" };

            // Set the ComboBoxEx column EditorType to our FragrantComboBox
            // and set the EditorParams to our created orderArray.
            //
            // The EditorParams property holds the parameters that will be
            // sent to the like defined EditorControl constructor when the
            // grid creates the EditControl.  The EditorParams can be any
            // array of objects, but must match in type and order to the
            // associated constructor.

            panel.Columns["ComboBoxEx"].EditorType = typeof(FragrantComboBox);
            panel.Columns["ComboBoxEx"].EditorParams = new object[] { orderArray };

            // Set the ButtonX column EditorType to our FlowerButton
            // and set the EditorParams to our created flowerImageList.

            panel.Columns["ButtonX"].EditorType = typeof(FlowerButton);
            panel.Columns["ButtonX"].EditorParams = new object[] { flowerImageList };

            // Enable the Clear button on the TextBoxDropDown edit control

            GridTextBoxDropDownEditControl ddc =
                panel.Columns["TextBoxDropDown"].EditControl as GridTextBoxDropDownEditControl;

            if (ddc != null)
            {
                ddc.ButtonClear.Visible = true;
                ddc.ButtonClearClick += DdcButtonClearClick;
            }

            // Set the Mask on the MaskedTextBox edit control

            GridMaskedTextBoxEditControl mtb =
                panel.Columns["MaskedTextBox"].EditControl as GridMaskedTextBoxEditControl;

            if (mtb != null)
                mtb.Mask = ">LL->L-000";

            // Now lets change the DirtyMarkerBackground on every
            // other row - just to demonstrate the operation

            for (int i = 0; i < panel.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    GridRow row = (GridRow) panel.Rows[i];

                    row.RowStyles.Default.RowHeaderStyle.DirtyMarkerBackground =
                        new Background(Color.Crimson, Color.Gainsboro, BackFillType.VerticalCenter);
                }
            }
        }

        #endregion

        #region DdcButtonClearClick

        /// <summary>
        /// Handles Clear button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DdcButtonClearClick(object sender, CancelEventArgs e)
        {
            GridTextBoxDropDownEditControl ddc =
                sender as GridTextBoxDropDownEditControl;

            if (ddc != null)
            {
                // Just set the text to an "unknown" value and
                // tell the control that we handled it

                ddc.Text = "(unknown)";

                e.Cancel = true;
            }
        }

        #endregion
    }

    #region FragrantComboBox

    internal class FragrantComboBox : GridComboBoxExEditControl
    {
        public FragrantComboBox(IEnumerable orderArray)
        {
            DataSource = orderArray;
        }
    }

    #endregion

    #region FlowerButton

    internal class FlowerButton : GridButtonXEditControl
    {
        #region Private variables

        private ImageList _FlowerImageList;

        #endregion

        public FlowerButton(ImageList flowerImageList)
        {
            _FlowerImageList = flowerImageList;

            Click += FlowerButtonClick;
        }

        #region FlowerButtonClick

        void FlowerButtonClick(object sender, EventArgs e)
        {
            string s = EditorCell.Value as string;

            if (s != null)
            {
                FlowerForm form = new FlowerForm();

                form.Text = s;
                form.pictureBox1.Image = _FlowerImageList.Images[s];
                form.ShowDialog();  
            }
        }

        #endregion
    }

    #endregion
}