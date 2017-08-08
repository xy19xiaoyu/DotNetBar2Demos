using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MicroCharts
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
            //DevComponents.DotNetBar.BarUtilities.UseTextRenderer = true;
            Application.Run(new Form1());
        }
    }
}