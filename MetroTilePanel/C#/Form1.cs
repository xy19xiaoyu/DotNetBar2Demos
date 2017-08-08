using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;

namespace MetroTilePanel
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            StyleManager.MetroColorGeneratorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(ColorScheme.GetColor("0E6D38"), ColorScheme.GetColor("0E6D38"));
            InitializeComponent();
        }
    }
}