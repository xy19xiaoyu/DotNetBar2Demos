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
    public partial class FormCategoryStyling : Office2007Form
    {
        public FormCategoryStyling()
        {
            InitializeComponent();
        }

        private void FormCategoryStyling_Load(object sender, EventArgs e)
        {
            // Create new Category style and assign it to Property Grid Appearance object
            ElementStyle style = new ElementStyle();
            style.BackColor = Color.WhiteSmoke;
            style.BackColor2 = Color.Silver;
            style.TextColor = Color.Olive;
            style.BackColorGradientAngle = 90;
            advPropertyGrid1.Appearance.CategoryStyle = style;

            // Set object to display properties for
            advPropertyGrid1.SelectedObject = buttonX1;
        }
    }
}