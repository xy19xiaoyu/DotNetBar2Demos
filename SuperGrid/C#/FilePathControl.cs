using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SuperGridDemo
{
    public partial class FilePathControl : UserControl
    {
        #region Events

        #region FilePathChanged

        /// <summary>
        /// Occurs when the FilePath has Changed
        /// </summary>
        [Description("Occurs when the FilePath has Changed.")]
        public event EventHandler<FilePathChangedEventArgs> FilePathChanged;
    
        #endregion

        #endregion

        public FilePathControl()
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
                if ((Text != null && Text.Equals(value) == false) ||
                    (Text == null && Text != value))
                {
                    string oldValue = Text;

                    tbxFilePath.Text = (value == null)
                        ? "" : Path.GetFileNameWithoutExtension(value);

                    OnFilePathChanged(oldValue, value);
                }

                base.Text = value;
            }
        }

        #region OnFilePathChanged

        /// <summary>
        /// Handles listener notification that the
        /// file path has changed
        /// </summary>
        /// <param name="oldPath"></param>
        /// <param name="newPath"></param>
        private void OnFilePathChanged(string oldPath, string newPath)
        {
            if (FilePathChanged != null)
            {
                FilePathChanged(this, new
                    FilePathChangedEventArgs(oldPath, newPath));
            }
        }

        #endregion

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
                tbxFilePath.Font = value;

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
                tbxFilePath.ForeColor = value;

                base.ForeColor = value;
            }
        }

        #endregion

        #region BtnDialogClick

        /// <summary>
        /// Handles click event to initiate the OpenFile dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDialogClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
                Text = ofd.FileName;
        }

        #endregion

        #region TbxFilePathTextChanged

        /// <summary>
        /// Handles the change events in the
        /// TextBox portion of the control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxFilePathTextChanged(object sender, EventArgs e)
        {
            if (tbxFilePath.Focused == true)
                Text = tbxFilePath.Text;
        }

        #endregion

        #endregion
    }

    #region FilePathChangedEventArgs

    /// <summary>
    /// FilePathChangedEventArgs
    /// </summary>
    public class FilePathChangedEventArgs : EventArgs
    {
        #region Private variables

        private string _OldFilePath;
        private string _NewFilePath;

        #endregion

        ///<summary>
        /// GridAfterCheckEventArgs
        ///</summary>
        ///<param name="oldFilePath"></param>
        ///<param name="newFilePath"></param>
        public FilePathChangedEventArgs(string oldFilePath, string newFilePath)
        {
            _OldFilePath = oldFilePath;
            _NewFilePath = newFilePath;
        }

        #region Public properties

        /// <summary>
        /// Gets the new file path
        /// </summary>
        public string NewFilePath
        {
            get { return (_NewFilePath); }
        }

        /// <summary>
        /// Gets the old file path
        /// </summary>
        public string OldFilePath
        {
            get { return (_OldFilePath); }
        }

        #endregion
    }

    #endregion

}
