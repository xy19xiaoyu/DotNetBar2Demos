using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SuperGridDemo
{
    public partial class VcrControl : UserControl
    {
        #region Events

        #region FirstClick

        /// <summary>
        /// Occurs when the 'First' button has been clicked
        /// </summary>
        [Description("Occurs when a cell has been clicked.")]
        public event EventHandler<EventArgs> FirstClick;

        #endregion

        #region PreviousClick

        /// <summary>
        /// Occurs when the 'Previous' button has been clicked
        /// </summary>
        [Description("Occurs when the 'Previous' button has been clicked.")]
        public event EventHandler<EventArgs> PreviousClick;

        #endregion

        #region NextClick

        /// <summary>
        /// Occurs when the 'Next' button has been clicked
        /// </summary>
        [Description("Occurs when the 'Next' button has been clicked.")]
        public event EventHandler<EventArgs> NextClick;

        #endregion

        #region LastClick

        /// <summary>
        /// Occurs when the 'Last' button has been clicked
        /// </summary>
        [Description("Occurs when the 'Last' button has been clicked.")]
        public event EventHandler<EventArgs> LastClick;

        #endregion

        #endregion

        public VcrControl()
        {
            InitializeComponent();
        }

        #region Public properties

        public Label Label
        {
            get { return (label); }
        }

        public Button FirstButton
        {
            get { return (btnFirst); }
        }

        public Button PreviousButton
        {
            get { return (btnPrevious); }
        }

        public Button NextButton
        {
            get { return (btnNext); }
        }

        public Button LastButton
        {
            get { return (btnLast); }
        }

        #endregion

        #region Button events

        private void BtnFirstClick(object sender, EventArgs e)
        {
            if (FirstClick != null)
                FirstClick(this, EventArgs.Empty);
        }

        private void BtnPreviousClick(object sender, EventArgs e)
        {
            if (PreviousClick != null)
                PreviousClick(this, EventArgs.Empty);
        }

        private void BtnNextClick(object sender, EventArgs e)
        {
            if (NextClick != null)
                NextClick(this, EventArgs.Empty);
        }

        private void BtnLastClick(object sender, EventArgs e)
        {
            if (LastClick != null)
                LastClick(this, EventArgs.Empty);
        }

        #endregion
    }
}
