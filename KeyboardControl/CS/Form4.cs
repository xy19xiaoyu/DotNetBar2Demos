using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Keyboard;
using DevComponents.DotNetBar.Metro;

namespace TestVirtualKeyboard
{
    public partial class Form4 : MetroForm
    {
        KeyboardControl virtualKeyboard;

        public Form4()
        {
            InitializeComponent();

            virtualKeyboard = new KeyboardControl();
            virtualKeyboard.Location = new Point(10, 200);
            virtualKeyboard.Visible = false;
            virtualKeyboard.Text = "Touch Keyboard";

            this.Controls.Add(virtualKeyboard);
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            virtualKeyboard.AttachTo(button1);
            virtualKeyboard.AttachTo(checkBox1);
            virtualKeyboard.AttachTo(comboBox1);
            virtualKeyboard.AttachTo(listBox1);
            virtualKeyboard.AttachTo(textBox1);
        }

        private void btnDetach_Click(object sender, EventArgs e)
        {
            virtualKeyboard.DetachFrom(button1);
            virtualKeyboard.DetachFrom(checkBox1);
            virtualKeyboard.DetachFrom(comboBox1);
            virtualKeyboard.DetachFrom(listBox1);
            virtualKeyboard.DetachFrom(textBox1);
        }

    }
}
