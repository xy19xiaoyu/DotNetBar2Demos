using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace TestVirtualKeyboard
{
    public partial class StartForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void metroTileItem1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog(this);
        }

        private void metroTileItem2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog(this);
        }

        private void metroTileItem3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog(this);
        }

        private void metroTileItem4_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog(this);
        }

        private void metroTileItem5_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.ShowDialog(this);
        }
    }
}