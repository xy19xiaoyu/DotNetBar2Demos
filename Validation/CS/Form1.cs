using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Validation
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007Form
    {
        // Want to see how everything is done in code? Explore InitializeComponent(); method.
        // All that is done on the form you can find there.

        public Form1()
        {
            InitializeComponent();
        }
         
        private void buttonX2_Click(object sender, EventArgs e)
        {
            superValidator1.Enabled = false;
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://www.devcomponents.com/kb/questions.php?questionid=118");
        }
    }
}