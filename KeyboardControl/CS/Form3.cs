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
    public partial class Form3 : MetroForm
    {
        public Form3()
        {
            InitializeComponent();

            virtualKeyboard1.Keyboard = CreateNumericKeyboard();

            virtualKeyboard1.Invalidate();
        }

        private Keyboard CreateNumericKeyboard()
        {
            Keyboard keyboard = new Keyboard();

            LinearKeyboardLayout klNumLockOn = new LinearKeyboardLayout();

            klNumLockOn.AddKey("NumLock", info: null, style: KeyStyle.Pressed, layout: 1);
            klNumLockOn.AddKey("/", "{DIVIDE}");
            klNumLockOn.AddKey("*", "{MULTIPLY}");
            klNumLockOn.AddKey("-", "{SUBTRACT}");
            klNumLockOn.AddLine();

            klNumLockOn.AddKey("7");
            klNumLockOn.AddKey("8");
            klNumLockOn.AddKey("9");
            klNumLockOn.AddKey("+", "{ADD}", height: 21);
            klNumLockOn.AddLine();

            klNumLockOn.AddKey("4");
            klNumLockOn.AddKey("5");
            klNumLockOn.AddKey("6");
            klNumLockOn.AddLine();

            klNumLockOn.AddKey("1");
            klNumLockOn.AddKey("2");
            klNumLockOn.AddKey("3");
            klNumLockOn.AddKey("Enter", "{ENTER}", height: 21);
            klNumLockOn.AddLine();

            klNumLockOn.AddKey("0", width: 21);
            klNumLockOn.AddKey(".");


            LinearKeyboardLayout klNumLockOff = new LinearKeyboardLayout();

            klNumLockOff.AddKey("NumLock", style: KeyStyle.Normal, layout: 0);
            klNumLockOff.AddKey("/", "{DIVIDE}");
            klNumLockOff.AddKey("*", "{MULTIPLY}");
            klNumLockOff.AddKey("-", "{SUBTRACT}");
            klNumLockOff.AddLine();
            
            klNumLockOff.AddKey("Home", "{HOME}");
            klNumLockOff.AddKey("Up", "{UP}");
            klNumLockOff.AddKey("PgUp", "{PGUP}");
            klNumLockOff.AddKey("+", "{ADD}", height: 21);
            klNumLockOff.AddLine();
            
            klNumLockOff.AddKey("Left", "{LEFT}");
            klNumLockOff.AddKey("");
            klNumLockOff.AddKey("Right", "{RIGHT}");
            klNumLockOff.AddLine();
            
            klNumLockOff.AddKey("End", "{END}");
            klNumLockOff.AddKey("Down", "{DOWN}");
            klNumLockOff.AddKey("PgDn", "{PGDN}");
            klNumLockOff.AddKey("Enter", "{ENTER}", height: 21);
            klNumLockOff.AddLine();
            
            klNumLockOff.AddKey("Ins", "{INSERT}", width: 21);
            klNumLockOff.AddKey(".");


            keyboard.Layouts.Add(klNumLockOn);
            keyboard.Layouts.Add(klNumLockOff);

            return keyboard;
        }
    }
}
