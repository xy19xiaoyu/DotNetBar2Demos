using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace PropertyGrid
{
    public partial class FormCustomToolbarButtons : DevComponents.DotNetBar.Office2007Form
    {
        public FormCustomToolbarButtons()
        {
            InitializeComponent();
        }

        private void FormCustomToolbarButtons_Load(object sender, EventArgs e)
        {
            // Create new button item
            ButtonItem button = new ButtonItem("helpPanel", "Help Panel");
            button.ButtonStyle = eButtonStyle.TextOnlyAlways;
            button.OptionGroup = "helpPanel"; // This will automatically manage the Check property so only one button in group is checked
            button.OptionGroupChanging += new OptionGroupChangingEventHandler(ButtonOptionGroupChanging);
            // This is how to access the Property Grid toolbar and add new button to it
            advPropertyGrid1.Toolbar.Items.Add(button);

            // Create second button
            button = new ButtonItem("helpTooltip", "SuperTooltip Help");
            button.ButtonStyle = eButtonStyle.TextOnlyAlways;
            button.OptionGroup = "helpPanel";
            button.Checked = true; // This is default value
            button.OptionGroupChanging += new OptionGroupChangingEventHandler(ButtonOptionGroupChanging);
            advPropertyGrid1.Toolbar.Items.Add(button);

            // Apply layout changes so items become visible
            advPropertyGrid1.Toolbar.RecalcLayout();

            // Set object to display properties for
            advPropertyGrid1.SelectedObject = buttonX1;
        }

        private void ButtonOptionGroupChanging(object sender, OptionGroupChangingEventArgs e)
        {
            if (e.NewChecked.Name == "helpPanel")
                advPropertyGrid1.HelpType = ePropertyGridHelpType.Panel;
            else
                advPropertyGrid1.HelpType = ePropertyGridHelpType.SuperTooltip;
        }
    }
}