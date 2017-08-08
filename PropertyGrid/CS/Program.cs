using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PropertyGrid
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
            DevComponents.DotNetBar.BarUtilities.UseTextRenderer = true;
            Application.Run(new Form1());
        }
    }
}