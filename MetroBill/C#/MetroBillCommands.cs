using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar;

namespace MetroBill
{
    /// <summary>
    /// Represents all application commands.
    /// </summary>
    public class MetroBillCommands
    {
        private DocumentCommands _ClientCommands = new DocumentCommands();
        /// <summary>
        /// Gets the client related commands.
        /// </summary>
        public DocumentCommands ClientCommands
        {
            get { return _ClientCommands; }
            set { _ClientCommands = value; }
        }

        private DocumentCommands _InvoiceCommands = new DocumentCommands();
        /// <summary>
        /// Gets document related commands.
        /// </summary>
        public DocumentCommands InvoiceCommands
        {
            get { return _InvoiceCommands; }
            set { _InvoiceCommands = value; }
        }

        private Command _SlideStartControl;
        /// <summary>
        /// Toggles start control visibility.
        /// </summary>
        public Command ToggleStartControl
        {
            get { return _SlideStartControl; }
            set { _SlideStartControl = value; }
        }

        private Command _ChangeMetroTheme;
        /// <summary>
        /// Changes the Metro theme.
        /// </summary>
        public Command ChangeMetroTheme
        {
            get { return _ChangeMetroTheme; }
            set { _ChangeMetroTheme = value; }
        }

        private Command _GettingStartedCommand;
        public Command GettingStartedCommand
        {
            get { return _GettingStartedCommand; }
            set { _GettingStartedCommand = value; }
        }

        private Command _NotImplemented;
        /// <summary>
        /// Not implemented command.
        /// </summary>
        public Command NotImplemented
        {
            get { return _NotImplemented; }
            set { _NotImplemented = value; }
        }

        private Command _DevComponents;
        /// <summary>
        /// Open DotNetBar web-site.
        /// </summary>
        public Command DevComponents
        {
            get { return _DevComponents; }
            set { _DevComponents = value; }
        }
    }

    public class DocumentCommands
    {
        private Command _New;
        public Command New
        {
            get { return _New; }
            set { _New = value; }
        }

        private Command _Save;
        public Command Save
        {
            get { return _Save; }
            set { _Save = value; }
        }

        private Command _Cancel;
        public Command Cancel
        {
            get { return _Cancel; }
            set { _Cancel = value; }
        }
    }
}
