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
    public partial class Form1 : MetroForm
    {
        private VirtualKeyboardColorTable _ColorTableDefault = new VirtualKeyboardColorTable();
        private VirtualKeyboardColorTable _ColorTableCustom;


        public Form1()
        {
            InitializeComponent();

            _ColorTableCustom = new VirtualKeyboardColorTable();
            _ColorTableCustom.BackgroundColor = Color.Gray;
            _ColorTableCustom.DarkKeysColor = Color.Black;
            _ColorTableCustom.KeysColor = Color.Black;
            _ColorTableCustom.LightKeysColor = Color.Black;
            _ColorTableCustom.PressedKeysColor = Color.Red;
            _ColorTableCustom.TextColor = Color.White;
            _ColorTableCustom.DownKeysColor = Color.IndianRed;
            _ColorTableCustom.DownTextColor = Color.Black;
            _ColorTableCustom.TopBarTextColor = Color.Black;
            _ColorTableCustom.ToggleTextColor = Color.DarkRed;

            touchKeyboard1.ColorTable = _ColorTableDefault;

            Disposed += new EventHandler(Form1_Disposed);
        }


        void Form1_Disposed(object sender, EventArgs e)
        {
            _ColorTableDefault.Dispose();
            _ColorTableCustom.Dispose();
        }

        #region Menu handlers

        private void KeyboardAttachedToFormClick(object sender, EventArgs e)
        {
            new Form2().Show();
        }


        private void testVirtualKeyboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }


        private void testKeyboardLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }


        private void testCodeBehindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }


        private void testRendererToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }

        #endregion

        private void colorTable1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            touchKeyboard1.ColorTable = _ColorTableDefault;
        }


        private void colorTable2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            touchKeyboard1.ColorTable = _ColorTableCustom;
        }


        
    }
}
