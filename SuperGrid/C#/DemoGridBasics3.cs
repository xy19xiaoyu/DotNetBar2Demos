using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace SuperGridDemo
{
    public partial class DemoGridBasics3 : Office2007Form
    {
        public DemoGridBasics3()
        {
            InitializeComponent();

            // Initialize the grid, Size
            // ComboBox, and the sample description text.

            InitializeGrid();
            InitSizeComboBox();

            ShellServices.LoadRtbText(richTextBox1,
            "SuperGridDemo.Resources.DemoBasics3.rtf");
        }

        #region InitializeGrid

        /// <summary>
        /// Initializes the default grid
        /// </summary>
        private void InitializeGrid()
        {
            GridPanel panel = superGridControl1.PrimaryGrid;

            // Set the ImageEdit column EditorType to our EditControl type
            // so that we can send it the ImageList and SizeMode to use

            GridColumn column = panel.Columns["ImageEdit"];
            column.EditorType = typeof(MyGridImageEditControl);
            column.EditorParams = new object[] { imageList1, ImageSizeMode.Zoom };

            // Set the LabelX column EditorType to our EditControl type
            // so that we can handle the link reference mouse clicks

            column = panel.Columns["LabelX"];
            column.EditorType = typeof(MyGridLabelXEditControl);
        }

        #endregion

        #region InitSizeComboBox

        /// <summary>
        /// Initializes the Size ComboBox
        /// </summary>
        private void InitSizeComboBox()
        {
            foreach (string s in Enum.GetNames(typeof(ImageSizeMode)))
                cbxSizeMode.Items.Add(s);

            cbxSizeMode.SelectedIndex = 3;
        }

        #endregion

        #region MyGridImageEditControl

        /// <summary>
        /// GridImageEditControl with the ability
        /// to pass in a default ImageList and ImageBoxSizeMode
        /// </summary>
        private class MyGridImageEditControl : GridImageEditControl
        {
            public MyGridImageEditControl(
                ImageList imageList, ImageSizeMode sizeMode)
            {
                ImageList = imageList;
                ImageSizeMode = sizeMode;
            }
        }

        #endregion

        #region MyGridLabelXEditControl

        /// <summary>
        /// GridLabelXEditControl with the ability to handle
        /// reference link clicks
        /// </summary>
        private class MyGridLabelXEditControl : GridLabelXEditControl
        {
            public MyGridLabelXEditControl()
            {
                MarkupLinkClick += MyGridLabelXEditControlMarkupLinkClick;
            }

            #region MyGridLabelXEditControlMarkupLinkClick

            void MyGridLabelXEditControlMarkupLinkClick(
                object sender, MarkupLinkClickEventArgs e)
            {
                ProcessStartInfo sInfo = new ProcessStartInfo(e.HRef);
                Process.Start(sInfo);
            }

            #endregion
        }

        #endregion

        #region SuperGridControl1CompareElements

        /// <summary>
        /// Routine used to compare two IP addresses
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControl1CompareElements(
            object sender, GridCompareElementsEventArgs e)
        {
            GridCell cellA = e.ElementA as GridCell;

            if (cellA != null && cellA.ColumnIndex == 0)
            {
                e.Cancel = true;

                GridCell cellB = (GridCell)e.ElementB;

                string valueA = GetIpValue(cellA.Value as string);
                string valueB = GetIpValue(cellB.Value as string);

                e.Result = String.Compare(valueA, valueB);
            }
        }

        #region GetIpValue

        /// <summary>
        /// Creates a simple string comparable
        /// representation of an IP Address
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private string GetIpValue(string t)
        {
            StringBuilder sb = new StringBuilder();

            if (t != null)
            {
                string[] svalues = t.Split('.');

                if (svalues.Length == 4)
                {
                    for (int i = 0; i < svalues.Length; i++)
                        sb.Append(svalues[i].Trim().PadLeft(3, '0'));
                }
            }

            return (sb.ToString());
        }

        #endregion

        #endregion

        #region CbxSizeModeSelectedIndexChanged

        /// <summary>
        /// Handles ImageEditSizeMode changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxSizeModeSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSizeMode.SelectedIndex >= 0)
            {
                GridPanel panel = superGridControl1.PrimaryGrid;
                GridColumn column = panel.Columns["ImageEdit"];

                ImageSizeMode sizeMode = (ImageSizeMode)Enum.Parse(
                    typeof(ImageSizeMode), (string)cbxSizeMode.SelectedItem);

                SetNewSizeMode(column.EditControl as GridImageEditControl, sizeMode);
                SetNewSizeMode(column.RenderControl as GridImageEditControl, sizeMode);

                column.InvalidateRender();
            }
        }

        #region SetNewSizeMode

        /// <summary>
        /// Sets a new size mode for the given GridImageEditControl
        /// </summary>
        /// <param name="ic"></param>
        /// <param name="sizeMode"></param>
        private void SetNewSizeMode(
            GridImageEditControl ic, ImageSizeMode sizeMode)
        {
            if (ic != null)
                ic.ImageSizeMode = sizeMode;
        }

        #endregion

        #endregion

        #region CbxIpCompareCheckedChanged

        /// <summary>
        /// Handles user requests to use (or not) the application
        /// defined IPAddress comparator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxIpCompareCheckedChanged(object sender, EventArgs e)
        {
            if (cbxIpCompare.Checked == true)
                superGridControl1.CompareElements += SuperGridControl1CompareElements;
            else
                superGridControl1.CompareElements -= SuperGridControl1CompareElements;
        }

        #endregion
    }
}