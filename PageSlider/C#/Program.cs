using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PageSlider
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevComponents.DotNetBar.StyleManager.Style = DevComponents.DotNetBar.eStyle.Metro;
            Application.Run(new Form1());
        }
    }
}