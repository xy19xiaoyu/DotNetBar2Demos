using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;

namespace DotNetBarExplorer
{
    public partial class Page2 : SlidePanel, IRunSample
    {
        public Page2()
        {
            InitializeComponent();
        }

        private Command _RunSampleCommand;
        /// <summary>
        /// Gets or sets the command that is used 
        /// </summary>
        public Command RunSampleCommand
        {
            get { return _RunSampleCommand; }
            set
            {
                if (value != _RunSampleCommand)
                {
                    Command oldValue = _RunSampleCommand;
                    _RunSampleCommand = value;
                    OnRunSampleCommandChanged(oldValue, value);
                }
            }
        }
        /// <summary>
        /// Called when RunSampleCommand property has changed.
        /// </summary>
        /// <param name="oldValue">Old property value</param>
        /// <param name="newValue">New property value</param>
        protected virtual void OnRunSampleCommandChanged(Command oldValue, Command newValue)
        {
            foreach (BaseItem item in itemPanel1.Items)
            {
                item.Command = newValue;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
            }
        }
    }
}
