using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PropertyGrid
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            FormPropertyAppearance form = new FormPropertyAppearance();
            form.Show();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            FormPropertyValuesTranslationMethod1 form = new FormPropertyValuesTranslationMethod1();
            form.Show();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            FormPropertyValuesTranslationMethod2 form = new FormPropertyValuesTranslationMethod2();
            form.Show();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            FormCustomToolbarButtons form = new FormCustomToolbarButtons();
            form.Show();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            FormCategoryStyling form = new FormCategoryStyling();
            form.Show();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            FormPropertyValueEditors editors = new FormPropertyValueEditors();
            editors.Show();
        }
    }
}