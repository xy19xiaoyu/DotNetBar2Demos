using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace DotNetBarExplorer
{
    public partial class Form1 : MetroAppForm
    {
        private Command[] _Commands = new Command[6];
        public Form1()
        {
            InitializeComponent();

            Type t = typeof(MetroAppForm);
            versionLabel.Text = "Version: " + t.Assembly.GetName().Version.ToString();

            // Add commands into array for easier manipulation of checked state
            _Commands[0] = page1Command;
            _Commands[1] = page2Command;
            _Commands[2] = page3Command;
            _Commands[3] = page4Command;
            _Commands[4] = page5Command;
            _Commands[5] = page6Command;

            // Attach commands that run sample executables
            page11.RunSampleCommand = runCommand;
            page21.RunSampleCommand = runCommand;
            page31.RunSampleCommand = runCommand;
            page41.RunSampleCommand = runCommand;
            page51.RunSampleCommand = runCommand;
            page61.RunSampleCommand = runCommand;
        }

        
        private int _CurrentPage = 0;
        
        private void page1Command_Executed(object sender, EventArgs e)
        {
            pageSlider1.SelectedPageIndex = 0;
        }

        private void page2Command_Executed(object sender, EventArgs e)
        {
            pageSlider1.SelectedPageIndex = 1;
        }

        private void page3Command_Executed(object sender, EventArgs e)
        {
            pageSlider1.SelectedPageIndex = 2;
        }

        private void page4Command_Executed(object sender, EventArgs e)
        {
            pageSlider1.SelectedPageIndex = 3;
        }

        private void page5Command_Executed(object sender, EventArgs e)
        {
            pageSlider1.SelectedPageIndex = 4;
        }

        private void page6Command_Executed(object sender, EventArgs e)
        {
            pageSlider1.SelectedPageIndex = 5;
        }

        private void metroShell1_HelpButtonClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.GetType().Assembly.Location.Substring(0, this.GetType().Assembly.Location.Length - 21));
        }

        private void buyDotNetBarCommand_Executed(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.devcomponents.com/dotnetbar/order.aspx");
        }

        private void tutorialsCommand_Executed(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.devcomponents.com/dotnetbar/movies.aspx");
        }

        private void kbCommand_Executed(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.devcomponents.com/kb2/");
        }

        private void testimonialsCommand_Executed(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.devcomponents.com/comments.aspx");
        }

        private void devcoCommand_Executed(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.devcomponents.com/");
        }

        private void runCommand_Executed(object sender, EventArgs e)
        {
            ICommandSource source = sender as ICommandSource;
            if (source != null && source.CommandParameter != null)
            {
                string folder = this.GetType().Assembly.Location.Substring(0, this.GetType().Assembly.Location.LastIndexOf('\\') + 1);
                System.Diagnostics.Process.Start(folder + source.CommandParameter);
            }

        }

        private void pageSlider1_SelectedPageChanged(object sender, EventArgs e)
        {
            PageSliderPage selectedPage = pageSlider1.SelectedPage;
            pageTitleLabel.Text = selectedPage.Controls[0].Text; // First and only control is our page panel with tiles
            _CurrentPage = pageSlider1.SelectedPageIndex;
            // Update command checked state
            for (int i = 0; i < _Commands.Length; i++)
            {
                _Commands[i].Checked = (i == _CurrentPage);
            } 
        }
    }

    public interface IRunSample
    {
        Command RunSampleCommand { get; set; }
    }
}