using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace TaskDialogTester
{
    public partial class Form1 : Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxIcon.Items.AddRange(Enum.GetNames(typeof(eTaskDialogIcon)));
            comboBoxIcon.SelectedIndex = 1;

            comboBoxColor.Items.AddRange(Enum.GetNames(typeof(eTaskDialogBackgroundColor)));
            comboBoxColor.SelectedIndex = 0;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            TaskDialogInfo info = CreateTaskDialogInfo();

            eTaskDialogResult result = TaskDialog.Show(info);
            Log("{0} Task-dialog closed with result: {1}", DateTime.Now, result);
        }
        private TaskDialogInfo CreateTaskDialogInfo()
        {
            TaskDialogInfo info = new TaskDialogInfo(textBoxTitle.Text, (eTaskDialogIcon)Enum.Parse(typeof(eTaskDialogIcon), comboBoxIcon.Text),
                textBoxHeader.Text, textBoxContent.Text, GetTaskDialogButtons(),
                (eTaskDialogBackgroundColor)Enum.Parse(typeof(eTaskDialogBackgroundColor), comboBoxColor.Text),
                GetRadioButtons(), GetCommandButtons(), GetCheckBoxCommand(), textBoxFooter.Text, GetFooterImage());
            return info;
        }
        private Image GetFooterImage()
        {
            if (checkBoxFooterImage.Checked)
                return global::TaskDialogTester.Properties.Resources.About;
            return null;
        }
        private Command GetCheckBoxCommand()
        {
            if (checkBoxVisible.Checked)
                return commandCheckBox;
            return null;
        }
        private Command[] GetCommandButtons()
        {
            if (checkBoxTaskButtons.Checked)
            {
                return new Command[] { commandButton1, commandButton2 };
            }

            return null;
        }
        private Command[] GetRadioButtons()
        {
            if (checkBoxTaskRadio.Checked)
            {
                return new Command[] { commandRadio1, commandRadio2 };
            }
            return null;
        }
        private eTaskDialogButton GetTaskDialogButtons()
        {
            eTaskDialogButton button = eTaskDialogButton.Ok;
            
            if (checkBoxCancel.Checked)
                button |= eTaskDialogButton.Cancel;
            if (checkBoxYes.Checked)
                button |= eTaskDialogButton.Yes;
            if (checkBoxNo.Checked)
                button |= eTaskDialogButton.No;
            if (checkBoxRetry.Checked)
                button |= eTaskDialogButton.Retry;
            if (checkBoxClose.Checked)
                button |= eTaskDialogButton.Close;

            if (!checkBoxOk.Checked && button != eTaskDialogButton.Ok)
                button = button & ~(button & eTaskDialogButton.Ok);

            return button;
        }

        private void commandCheckBox_Executed(object sender, EventArgs e)
        {
            Log("{0} Task-Dialog Check-box has been clicked. Checked={1}", DateTime.Now, commandCheckBox.Checked);
        }

        private void commandRadio1_Executed(object sender, EventArgs e)
        {
            Log("{0} Task-Dialog Radio 1 has been clicked. Checked={1}", DateTime.Now, commandRadio1.Checked);
        }

        private void commandRadio2_Executed(object sender, EventArgs e)
        {
            Log("{0} Task-Dialog Radio 2 has been clicked. Checked={1}", DateTime.Now, commandRadio2.Checked);
        }

        private void commandButton1_Executed(object sender, EventArgs e)
        {
            Log("{0} Task button has been clicked", DateTime.Now);
        }

        private void commandButton2_Executed(object sender, EventArgs e)
        {
            Log("{0} Task button 2 has been clicked", DateTime.Now);
            TaskDialog.Close(eTaskDialogResult.Custom1);
        }

        private void labelX3_MarkupLinkClick(object sender, MarkupLinkClickEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.devcomponents.com/kb/questions.php?questionid=5");
        }
        private void Log(string text, params object[] args)
        {
            textBoxLog.AppendText(string.Format(text, args) + Environment.NewLine);
            textBoxLog.ScrollToCaret();
        }
    }
}