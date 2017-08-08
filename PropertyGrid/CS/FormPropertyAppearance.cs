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
    public partial class FormPropertyAppearance : DevComponents.DotNetBar.Office2007Form
    {
        public FormPropertyAppearance()
        {
            InitializeComponent();
        }

        private PropertySettings _AntiAliasPropertySetting = null;
        private void FormPropertyAppearance_Load(object sender, EventArgs e)
        {
            // Customize AntiAlias property appearance
            _AntiAliasPropertySetting = new PropertySettings("AntiAlias"); // Specifies that this setting is attached to AntiAlias property
            _AntiAliasPropertySetting.Description = "This is custom description, help text, for the AntiAlias property";
            _AntiAliasPropertySetting.DisplayName = "AntiAliasCustomName"; // Change property name that is displayed in property grid
            // Create new visual style for property
            ElementStyle style = new ElementStyle();
            style.BackColor = Color.WhiteSmoke;
            style.BackColor2 = Color.LightGoldenrodYellow;
            style.BackColorGradientAngle = 90;
            style.TextColor = Color.Brown;
            _AntiAliasPropertySetting.Style = style;

            // Adds property setting to the grid
            advPropertyGrid1.PropertySettings.Add(_AntiAliasPropertySetting);

            // Set object to display properties for
            advPropertyGrid1.SelectedObject = buttonX1;
        }
    }
}