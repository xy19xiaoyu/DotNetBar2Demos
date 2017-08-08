using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar.Controls;

namespace SlidePanel
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            slidePanel1.IsOpen = false;
        }

        private void ChangeSlideSide(eSlideSide side)
        {
            slidePanel1.SlideSide = side;
            buttonLeft.Checked = (side == eSlideSide.Left);
            buttonTop.Checked = (side == eSlideSide.Top);
            buttonRight.Checked = (side == eSlideSide.Right);
            buttonBottom.Checked = (side == eSlideSide.Bottom);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            ChangeSlideSide(eSlideSide.Right);
        }

        private void buttonTop_Click(object sender, EventArgs e)
        {
            ChangeSlideSide(eSlideSide.Top);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            ChangeSlideSide(eSlideSide.Left);
        }

        private void buttonBottom_Click(object sender, EventArgs e)
        {
            ChangeSlideSide(eSlideSide.Bottom);
        }


    }
}