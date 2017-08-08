using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CircularProgressControl
{
    public partial class Form1 : Office2007Form
    {
        public Form1()
        {
            InitializeComponent();

            ToggleEndlessProgress.Execute();

            circularProgressItem11.IsRunning = true;
            circularProgress1.IsRunning = true;
        }

        private void ToggleEndlessProgress_Executed(object sender, EventArgs e)
        {
            bool running = !ToggleEndlessProgress.Checked;
            ToggleEndlessProgress.Checked = !ToggleEndlessProgress.Checked;
            if (running)
                ToggleEndlessProgress.Text = "Stop";
            else
                ToggleEndlessProgress.Text = "Start";

            circularProgressItem1.IsRunning = running;
            circularProgressItem2.IsRunning = running;
            circularProgressItem3.IsRunning = running;
            circularProgressItem4.IsRunning = running;
            circularProgressItem5.IsRunning = running;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressItem6.Value += 2;
            circularProgressItem7.Value += 2;
            circularProgressItem8.Value += 2;
            circularProgressItem9.Value += 2;
            circularProgressItem10.Value += 2;

            if (circularProgressItem6.Value >= circularProgressItem6.Maximum)
                ProgressRun.Execute();
        }

        private void ProgressRun_Executed(object sender, EventArgs e)
        {
            bool running = !timer1.Enabled;
            
            if (running && circularProgressItem6.Value >= circularProgressItem6.Maximum)
            {
                circularProgressItem6.Value = 0;
                circularProgressItem7.Value = 0;
                circularProgressItem8.Value = 0;
                circularProgressItem9.Value = 0;
                circularProgressItem10.Value = 0;
            }

            timer1.Enabled = running;
            if (running)
                ProgressRun.Text = "Stop";
            else
                ProgressRun.Text = "Start";
            ProgressRun.Checked = !ProgressRun.Checked;
        }

        private void ProgressValueVisible_Executed(object sender, EventArgs e)
        {
            circularProgressItem6.ProgressTextVisible = ProgressValueVisible.Checked;
            circularProgressItem7.ProgressTextVisible = ProgressValueVisible.Checked;
            circularProgressItem8.ProgressTextVisible = ProgressValueVisible.Checked;
            circularProgressItem9.ProgressTextVisible = ProgressValueVisible.Checked;
            circularProgressItem10.ProgressTextVisible = ProgressValueVisible.Checked;
        }

        private void circularProgress1_Click(object sender, EventArgs e)
        {
            circularProgress1.IsRunning = !circularProgress1.IsRunning;
        }

    }
}