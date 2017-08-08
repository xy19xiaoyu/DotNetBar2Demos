using System.Drawing;
using System.Windows.Forms;

namespace SuperGridDemo
{
    public partial class ClipControl : UserControl
    {
        public ClipControl()
        {
            InitializeComponent();
        }

        #region Public properties

        #region Text

        /// <summary>
        /// Gets or sets the control text
        /// </summary>
        public override string Text
        {
            get { return (base.Text); }

            set
            {
                labelX1.Text = value;

                base.Text = value;
            }
        }

        #endregion

        #region Font

        /// <summary>
        /// Gets or sets the control font
        /// </summary>
        public override Font Font
        {
            get { return (base.Font); }

            set
            {
                labelX1.Font = value;

                base.Font = value;
            }
        }

        #endregion

        #region ForeColor

        /// <summary>
        /// Gets or sets the control fore color
        /// </summary>
        public override Color ForeColor
        {
            get { return (base.ForeColor); }

            set
            {
                labelX1.ForeColor = value;

                base.ForeColor = value;
            }
        }

        #endregion

        #endregion
    }
}
