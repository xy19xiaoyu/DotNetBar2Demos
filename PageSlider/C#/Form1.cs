using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;

namespace PageSlider
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            PageSliderPage page = new PageSliderPage();
            pageSlider1.Controls.Add(page);
            LabelX label = new LabelX();
            label.Height = 32;
            label.Text = "Another page slider page...";
            label.Dock = DockStyle.Top;
            page.Controls.Add(label);
            // Select it
            pageSlider1.SelectedPage = page;
        }
    }
}