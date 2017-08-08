using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;
using SuperTabControlDemo.Properties;

namespace SuperTabControlDemo
{
    public partial class Form1 : Form
    {
        #region Private variables

        private int _NewTabId = 3;

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // Add a ControlBox item that will permit the user to add
            // new tabs to the Office2007 style TabControl

            AddNewControlBoxItem();
        }

        #region AddNewControlBoxItem

        #region AddNewControlBoxItem

        /// <summary>
        /// Adds the "New" ControlBox item
        /// </summary>
        private void AddNewControlBoxItem()
        {
            // Create a new button and add it to the ControlBox

            AddControlBoxColorTable();

            ButtonItem bi = new ButtonItem();

            bi.Image = Resources.Plus_Sign;
            bi.CustomColorName = "ControlBoxColorTable";
            bi.Click += AddTabClick;

            stcOffice2007.ControlBox.SubItems.Add(bi);
        }

        #endregion

        #region AddControlBoxColorTable

        /// <summary>
        /// Adds the ControlBox color scheme table to the system
        /// </summary>
        private void AddControlBoxColorTable()
        {
            if (GlobalManager.Renderer is Office2007Renderer)
            {
                // Create custom color scheme for the button and register it globally

                Office2007ButtonItemColorTable table = new Office2007ButtonItemColorTable();

                table.Name = "ControlBoxColorTable";

                // Define standard colors when mouse is not over the button

                table.Default = new Office2007ButtonItemStateColorTable();

                // Define colors when mouse is over the button

                Color outer = Color.FromArgb(0xFF, 0xBD, 0x69);
                Color back = Color.FromArgb(0xFF, 0xE7, 0xA2);

                table.MouseOver = new Office2007ButtonItemStateColorTable();
                table.MouseOver.OuterBorder.Start = outer;
                table.MouseOver.OuterBorder.End = outer;
                table.MouseOver.TopBackground.Start = back;
                table.MouseOver.TopBackground.End = back;
                table.MouseOver.BottomBackground.Start = back;
                table.MouseOver.BottomBackground.End = back;

                // Define colors when mouse is pressed

                back = Color.FromArgb(0xFB, 0x8C, 0x3C);

                table.Pressed = new Office2007ButtonItemStateColorTable();
                table.Pressed.OuterBorder.Start = outer;
                table.Pressed.OuterBorder.End = outer;
                table.Pressed.TopBackground.Start = back;
                table.Pressed.TopBackground.End = back;
                table.Pressed.BottomBackground.Start = back;
                table.Pressed.BottomBackground.End = back;

                Office2007Renderer r =
                    GlobalManager.Renderer as Office2007Renderer;

                r.ColorTable.ButtonItemColors.Add(table);
            }
        }

        #endregion

        #region AddTabClick

        /// <summary>
        /// Handles "Add Tab" ControlBox selections
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddTabClick(object sender, System.EventArgs e)
        {
            string s = "New Tab " + _NewTabId++;

            SuperTabItem tab = stcOffice2007.CreateTab(s);

            tab.ImageIndex = 2;

            LabelX lab = new LabelX();
            lab.Text = "New tab created in code.";
            lab.TextAlignment = StringAlignment.Center;
            lab.BackColor = Color.Transparent;
            lab.Dock = DockStyle.Fill;

            tab.AttachedControl.Controls.Add(lab);
        }

        #endregion

        #endregion
    }
}