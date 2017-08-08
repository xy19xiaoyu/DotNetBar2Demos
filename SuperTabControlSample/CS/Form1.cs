using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Events;
using DevComponents.DotNetBar.Rendering;

namespace SuperTabControlDemo2
{
    public partial class Form1 : Form
    {
        #region Private constants

        private const int Radius = 6;

        #endregion

        #region Private variables

        private bool _ModifyTabMenu;
        private int _UserTabCount = 1;

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            // Initialize our components and associated data

            InitializeComponent();
            InitializeData();

            // Hook onto our control events

            HookEvents(true);
        }

        #region InitializeData

        /// <summary>
        /// Initializes our interface control data
        /// </summary>
        private void InitializeData()
        {
            // Tab Alignment

            string[] names = Enum.GetNames(typeof(eSuperTabStyle));

            cbxTabStyle.Items.AddRange(names);
            cbxTabStyle.SelectedIndex = 4;

            names = Enum.GetNames(typeof(eTabStripAlignment));

            cbxTabAlignment.Items.AddRange(names);
            cbxTabAlignment.SelectedIndex = 2;

            // Text Alignment

            names = Enum.GetNames(typeof(eItemAlignment));

            cbxTextAlignment.Items.AddRange(names);
            cbxTextAlignment.SelectedIndex = 0;

            cbxBaseItemAlignment.Items.AddRange(names);
            cbxBaseItemAlignment.SelectedIndex = 0;

            // Line Alignment

            names = Enum.GetNames(typeof(eSuperTabLayoutType));

            cbxLineAlignment.Items.AddRange(names);
            cbxLineAlignment.SelectedIndex = 0;

            // Image Alignment

            cbImagePos.Items.AddRange(
                Enum.GetNames(typeof(ImageAlignment)));

            cbImagePos.SelectedIndex = 9;

            cbDefImagePos.Items.AddRange(
                Enum.GetNames(typeof(ImageAlignment)));

            cbDefImagePos.SelectedIndex = 9;
        }

        #endregion

        #region HookEvents

        /// <summary>
        /// Hooks our system control events
        /// </summary>
        /// <param name="hook"></param>
        private void HookEvents(bool hook)
        {
            if (hook == true)
                superTabControl1.ControlBox.MenuBox.PopupOpen += MenuBox_PopupOpen;
            else
                superTabControl1.ControlBox.MenuBox.PopupOpen -= MenuBox_PopupOpen;
        }

        #endregion

        #region Tab Style

        #region cbxStyle_SelectedIndexChanged

        /// <summary>
        /// Handles TabStyle selection changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] values = (int[])Enum.GetValues(typeof(eSuperTabStyle));

            superTabControl1.TabStyle =
                (eSuperTabStyle)(values[cbxTabStyle.SelectedIndex]);
        }

        #endregion

        #region ContextMenu support

        /// <summary>
        /// Handles TabStyle tab mouseUp events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stiTabStyle_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Set the appropriate style as "Checked"

                cmiOffice2007.Checked = superTabControl1.TabStyle == eSuperTabStyle.Office2007;
                cmiBackstageBlue.Checked = superTabControl1.TabStyle == eSuperTabStyle.Office2010BackstageBlue;
                cmiOneNote2007.Checked = superTabControl1.TabStyle == eSuperTabStyle.OneNote2007;
                cmiVs2008Dock.Checked = superTabControl1.TabStyle == eSuperTabStyle.VisualStudio2008Dock;
                cmiVs2008Document.Checked = superTabControl1.TabStyle == eSuperTabStyle.VisualStudio2008Document;
                cmiWinMediaPlayer12.Checked = superTabControl1.TabStyle == eSuperTabStyle.WinMediaPlayer12;

                // Show the ContextMenu

                ShowContextMenu(cmTabStyle);
            }
        }

        #region cmiOffice2007_Click

        /// <summary>
        /// Handles Office2007 style selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiOffice2007_Click(object sender, EventArgs e)
        {
            cbxTabStyle.SelectedIndex = (int)eSuperTabStyle.Office2007;
        }

        #endregion

        #region cmiBackstageBlue_Click

        /// <summary>
        /// Handles BackstageBlue selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiBackstageBlue_Click(object sender, EventArgs e)
        {
            cbxTabStyle.SelectedIndex = (int)eSuperTabStyle.Office2010BackstageBlue;
        }

        #endregion

        #region cmiOneNote2007_Click

        /// <summary>
        /// Handles OneNote2007 selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiOneNote2007_Click(object sender, EventArgs e)
        {
            cbxTabStyle.SelectedIndex = (int)eSuperTabStyle.OneNote2007;
        }

        #endregion

        #region Vs2008Dock_Click

        /// <summary>
        /// Handles VisualStudio2008Dock selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Vs2008Dock_Click(object sender, EventArgs e)
        {
            cbxTabStyle.SelectedIndex = (int)eSuperTabStyle.VisualStudio2008Dock;
        }

        #endregion

        #region Vs2008Document_Click

        /// <summary>
        /// Handles VisualStudio2008Document style selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Vs2008Document_Click(object sender, EventArgs e)
        {
            cbxTabStyle.SelectedIndex = (int)eSuperTabStyle.VisualStudio2008Document;
        }

        #endregion

        #region WinMediaPlayer12_Click

        /// <summary>
        /// Handles WinMediaPlayer12 selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinMediaPlayer12_Click(object sender, EventArgs e)
        {
            cbxTabStyle.SelectedIndex = (int)eSuperTabStyle.WinMediaPlayer12;
        }

        #endregion

        #endregion

        #endregion

        #region Tab Alignment

        #region cbxTabAlignment_SelectedIndexChanged

        /// <summary>
        /// Handles Tab Alignment changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxTabAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] values = (int[])Enum.GetValues(typeof(eSuperTabStyle));

            superTabControl1.TabAlignment =
                (eTabStripAlignment)(values[cbxTabAlignment.SelectedIndex]);
        }

        #endregion

        #region cbxLineAlignment_SelectedIndexChanged

        /// <summary>
        /// Handles Line Alignment changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxLineAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] values = (int[])Enum.GetValues(typeof(eSuperTabLayoutType));

            superTabControl1.TabLayoutType =
                (eSuperTabLayoutType)(values[cbxLineAlignment.SelectedIndex]);
        }

        #endregion

        #region ContextMenu support

        private void stiTabAlignment_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Set our ContextMenu "check" states

                cmiTop.Checked = superTabControl1.TabAlignment == eTabStripAlignment.Top;
                cmiLeft.Checked = superTabControl1.TabAlignment == eTabStripAlignment.Left;
                cmiBottom.Checked = superTabControl1.TabAlignment == eTabStripAlignment.Bottom;
                cmiRight.Checked = superTabControl1.TabAlignment == eTabStripAlignment.Right;

                cmiSingleLine.Checked = superTabControl1.TabLayoutType == eSuperTabLayoutType.SingleLine;
                cmiSingleLineFit.Checked = superTabControl1.TabLayoutType == eSuperTabLayoutType.SingleLineFit;
                cmiMultiLine.Checked = superTabControl1.TabLayoutType == eSuperTabLayoutType.MultiLine;
                cmiMultiLineFit.Checked = superTabControl1.TabLayoutType == eSuperTabLayoutType.MultiLineFit;

                // Show the ContextMenu

                ShowContextMenu(cmTabAlignment);
            }
        }

        #region cmiLeft_Click

        /// <summary>
        /// Handles Left-Alignment selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiLeft_Click(object sender, EventArgs e)
        {
            cbxTabAlignment.SelectedIndex = (int)eTabStripAlignment.Left;
        }

        #endregion

        #region cmiRight_Click

        /// <summary>
        /// Handles Right-Alignment selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiRight_Click(object sender, EventArgs e)
        {
            cbxTabAlignment.SelectedIndex = (int)eTabStripAlignment.Right;
        }

        #endregion

        #region cmiTop_Click

        /// <summary>
        /// Handles Top-alignment selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiTop_Click(object sender, EventArgs e)
        {
            cbxTabAlignment.SelectedIndex = (int)eTabStripAlignment.Top;
        }

        #endregion

        #region cmiBottom_Click

        /// <summary>
        /// Handles Bottom-alignment selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiBottom_Click(object sender, EventArgs e)
        {
            cbxTabAlignment.SelectedIndex = (int)eTabStripAlignment.Bottom;
        }

        #endregion

        #region cmiSingleLine_Click

        /// <summary>
        /// Handles SingleLine selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiSingleLine_Click(object sender, EventArgs e)
        {
            cbxLineAlignment.SelectedIndex = (int)eSuperTabLayoutType.SingleLine;
        }

        #endregion

        #region cmiSingleLineFit_Click

        /// <summary>
        /// Handles SingleLineFit selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiSingleLineFit_Click(object sender, EventArgs e)
        {
            cbxLineAlignment.SelectedIndex = (int)eSuperTabLayoutType.SingleLineFit;
        }

        #endregion

        #region cmiMultiLine_Click

        /// <summary>
        /// Handles MultiLine selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiMultiLine_Click(object sender, EventArgs e)
        {
            cbxLineAlignment.SelectedIndex = (int)eSuperTabLayoutType.MultiLine;
        }

        #endregion

        #region cmiMultiLineFit_Click

        /// <summary>
        /// Handles MultiLineFit selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiMultiLineFit_Click(object sender, EventArgs e)
        {
            cbxLineAlignment.SelectedIndex = (int)eSuperTabLayoutType.MultiLineFit;
        }

        #endregion

        #endregion

        #endregion

        #region Tab Size

        #region iiWidth_ValueChanged

        /// <summary>
        /// Handles FixedTabSize width changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iiWidth_ValueChanged(object sender, EventArgs e)
        {
            superTabControl1.FixedTabSize = new
                Size(iiWidth.Value, superTabControl1.FixedTabSize.Height);
        }

        #endregion

        #region iiHeight_ValueChanged

        /// <summary>
        /// Handles FixedTabSize height changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iiHeight_ValueChanged(object sender, EventArgs e)
        {
            superTabControl1.FixedTabSize = new
                Size(superTabControl1.FixedTabSize.Width, iiHeight.Value);
        }

        #endregion

        #region iiHorizontalSpace_ValueChanged

        /// <summary>
        /// Handles HorizontalSpace changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iiHorizontalSpace_ValueChanged(object sender, EventArgs e)
        {
            superTabControl1.TabHorizontalSpacing = iiHorizontalSpace.Value;
        }

        #endregion

        #region iiVerticalSpace_ValueChanged

        /// <summary>
        /// Handles VerticalSpace changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iiVerticalSpace_ValueChanged(object sender, EventArgs e)
        {
            superTabControl1.TabVerticalSpacing = iiVerticalSpace.Value;
        }

        #endregion

        #region btxResetSize_Click

        /// <summary>
        /// Initiates the reset of the FixedTabSize
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btxResetSize_Click(object sender, EventArgs e)
        {
            ResetSize();
        }

        /// <summary>
        /// Resets the FixedTabSize
        /// </summary>
        private void ResetSize()
        {
            superTabControl1.FixedTabSize = Size.Empty;

            iiWidth.Value = 0;
            iiHeight.Value = 0;
        }

        #endregion

        #region btxResetSpacing_Click

        /// <summary>
        /// Initiates the reset of the tab spacing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btxResetSpacing_Click(object sender, EventArgs e)
        {
            ResetSpacing();
        }

        /// <summary>
        /// Resets the tab spacing
        /// </summary>
        private void ResetSpacing()
        {
            superTabControl1.TabHorizontalSpacing = 5;
            superTabControl1.TabVerticalSpacing = 4;

            iiHorizontalSpace.Value = 5;
            iiVerticalSpace.Value = 4;
        }

        #endregion

        #region ContextMenu support

        #region stiTabSize_MouseUp

        /// <summary>
        /// Handles TabSize tab mouseUp events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stiTabSize_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                ShowContextMenu(cmTabSize);
        }

        #endregion

        #region cniResetSize_Click

        /// <summary>
        /// Initiates a FixedTabSize reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cniResetSize_Click(object sender, EventArgs e)
        {
            ResetSize();
        }

        #endregion

        #region cmiResetSpacing_Click

        /// <summary>
        /// Initiates a tab spacing reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiResetSpacing_Click(object sender, EventArgs e)
        {
            ResetSpacing();
        }

        #endregion

        #endregion

        #endregion

        #region Text Alignment

        #region cbxTextAlignment_SelectedIndexChanged

        /// <summary>
        /// Handles TextAlignment changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxTextAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] values = (int[])Enum.GetValues(typeof(eItemAlignment));

            superTabControl1.TextAlignment =
                (eItemAlignment)(values[cbxTextAlignment.SelectedIndex]);
        }

        #endregion

        #region cbxHorizontal_CheckedChanged

        /// <summary>
        /// Handles Horizontal text changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxHorizontal_CheckedChanged(object sender, EventArgs e)
        {
            superTabControl1.HorizontalText = cbxHorizontal.Checked;
        }

        #endregion

        #region cbxDisplayOnlySelectedText_CheckedChanged

        /// <summary>
        /// Handles DisplayOnlySelectedText changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxDisplayOnlySelectedText_CheckedChanged(object sender, EventArgs e)
        {
            superTabControl1.DisplaySelectedTextOnly = cbxDisplayOnlySelectedText.Checked;
        }

        #endregion

        #region cbxRotateText_CheckedChanged

        /// <summary>
        /// Handles Rotate text changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxRotateText_CheckedChanged(object sender, EventArgs e)
        {
            superTabControl1.RotateVerticalText = cbxRotateText.Checked;
        }

        #endregion

        #region ContextMenu support

        #region stiTextAlignment_MouseUp

        /// <summary>
        /// Handles TextAlignment tab mouseUp events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stiTextAlignment_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmiTextNear.Checked = superTabControl1.TextAlignment == eItemAlignment.Near;
                cmiTextCenter.Checked = superTabControl1.TextAlignment == eItemAlignment.Center;
                cmiTextFar.Checked = superTabControl1.TextAlignment == eItemAlignment.Far;

                cmiHorizText.Checked = superTabControl1.HorizontalText;
                cmiOnlySelText.Checked = superTabControl1.DisplaySelectedTextOnly;

                ShowContextMenu(cmTextAlignment);
            }
        }

        #endregion

        #region cmiTextNear_Click

        /// <summary>
        /// Handles TextNear selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiTextNear_Click(object sender, EventArgs e)
        {
            cbxTextAlignment.SelectedIndex = (int)eItemAlignment.Near;
        }

        #endregion

        #region cmiTextCenter_Click

        /// <summary>
        /// Handles TextCenter selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiTextCenter_Click(object sender, EventArgs e)
        {
            cbxTextAlignment.SelectedIndex = (int)eItemAlignment.Center;
        }

        #endregion

        #region cmiTextFar_Click

        /// <summary>
        /// Handles TextFar selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiTextFar_Click(object sender, EventArgs e)
        {
            cbxTextAlignment.SelectedIndex = (int)eItemAlignment.Far;
        }

        #endregion

        #region cmiHorizText_Click

        /// <summary>
        /// Handles Horizontal text selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiHorizText_Click(object sender, EventArgs e)
        {
            cbxHorizontal.Checked = !cbxHorizontal.Checked;
        }

        #endregion

        #region cmiOnlySelText_Click

        /// <summary>
        /// Handles DisplayOnlySelectedText selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiOnlySelText_Click(object sender, EventArgs e)
        {
            cbxDisplayOnlySelectedText.Checked = !cbxDisplayOnlySelectedText.Checked;
        }

        #endregion

        #endregion

        #endregion

        #region Color

        #region cbColorDefault_CheckedChanged

        /// <summary>
        /// Handles default color selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbColorDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (cbColorDefault.Checked == true)
            {
                superTabControl1.TabStrip.BeginUpdate();

                // Loop through each tab, whose color we may have changed,
                // resetting its color setting back to the default

                for (int i = 0; i < superTabControl1.Tabs.Count; i++)
                {
                    SuperTabItem tab = superTabControl1.Tabs[i] as SuperTabItem;

                    if (tab != null)
                        ResetAllTabColors(tab);
                }

                superTabControl1.ResetTabStripColor();

                superTabControl1.TabStrip.EndUpdate();
            }
        }

        #endregion

        #region cbColor1_CheckedChanged

        /// <summary>
        /// Sets the colors of our tabs to a predefined
        /// set of unique, individual colors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbColor1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbColor1.Checked == true)
            {
                superTabControl1.TabStrip.BeginUpdate();

                int[] values = (int[]) Enum.GetValues(typeof (eTabItemColor));

                // Loop through each tab, setting its PredefinedColor
                // scheme in a Round Robin fashion

                for (int i = 0; i < superTabControl1.Tabs.Count; i++)
                {
                    SuperTabItem tab = superTabControl1.Tabs[i] as SuperTabItem;

                    if (tab != null)
                    {
                        tab.ResetTabColor();
                        tab.PredefinedColor = (eTabItemColor) (i % (values.Length - 1)) + 1;

                        SuperTabControlPanel panel = stiTabStyle.AttachedControl as SuperTabControlPanel;

                        if (panel != null)
                            panel.ResetPanelColor();
                    }
                }

                // Reset our TabStrip color back to default

                superTabControl1.ResetTabStripColor();

                superTabControl1.TabStrip.EndUpdate();
            }
        }

        #endregion

        #region cbColor2_CheckedChanged

        /// <summary>
        /// Sets the colors of our "TabStyle" tab to a concocted
        /// set of unique, individual colors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbColor2CheckedChanged(object sender, EventArgs e)
        {
            if (cbColor2.Checked == true)
            {
                superTabControl1.TabStrip.BeginUpdate();

                // Start by resetting our TabStyle tab colors to the default

                ResetAllTabColors(stiTabStyle);

                // Allocate a new SuperTabColorTable and initialize it
                // to suit our color needs. These values will be used for
                // the coloring of the TabStrip portion of the control

                SuperTabColorTable ct = new SuperTabColorTable();

                ct.Background = new SuperTabLinearGradientColorTable(Color.LightGreen, Color.DarkGreen);
                ct.ControlBoxDefault.Image = Color.White;

                superTabControl1.TabStripColor = ct;

                // Allocate a new SuperTabItemColorTable and initialize it to
                // suit our needs.  These values will be used for the tab (and panel)
                // portion of the control

                SuperTabItemColorTable stc = new SuperTabItemColorTable();

                // The SuperTabItemColorTable contains 4 SuperTabColorStates entries.
                // These entries correspond to the TabAlignment settings:
                // 
                // Default - Colors set for this scheme will be used, by default, for the other three
                //           alignment settings, unless they are each individually configured and set.
                //
                // Left - Color settings for the Left tab alignment.
                // Bottom - Color settings for the Bottom tab alignment.
                // Right - Color settings for the Right tab alignment.
                //
                // Each of the aboveSuperTabColorStates entries contains 4 SuperTabItemStateColorTable
                // entries.  These correspond to the 4 following possible tab display states:
                //
                // Normal - Non-Selected, non-MouseOver state
                // MouseOver - Non-Selected, MouseOver state
                // Selected - Selected, non-MouseOver
                // SelectedMouseOver - Selected, MouseOver
                //
                // Each one of these color tables can be defined to control the display colors
                // for each state. 
                //
                // Colors definitions are applied in the following order:
                //
                // Default, built-in color definitions.
                // Predefined color usage.

                stc.Default.Normal.Background = new SuperTabLinearGradientColorTable(
                    new Color[] {Color.Yellow, Color.Orange, Color.DarkRed},
                    new float[] {0, .6f, 1});

                stc.Default.Normal.InnerBorder = Color.White;
                stc.Default.Normal.OuterBorder = Color.Black;

                stc.Default.Selected = stc.Default.Normal;

                stc.Default.SelectedMouseOver.Background = new SuperTabLinearGradientColorTable(
                    new Color[] {Color.White, Color.Orange, Color.Red},
                    new float[] {0, .6f, 1});

                stc.Default.SelectedMouseOver.InnerBorder = Color.White;
                stc.Default.SelectedMouseOver.OuterBorder = Color.Black;

                stc.Default.MouseOver = stc.Default.SelectedMouseOver;

                stiTabStyle.TabColor = stc;

                SuperTabControlPanel panel = stiTabStyle.AttachedControl as SuperTabControlPanel;

                if (panel != null)
                {
                    SuperTabPanelColorTable pct = new SuperTabPanelColorTable();

                    pct.Default.Background = stc.Default.Selected.Background;
                    pct.Default.InnerBorder = stc.Default.Selected.InnerBorder;
                    pct.Default.OuterBorder = stc.Default.Selected.OuterBorder;

                    panel.PanelColor = pct;
                }

                superTabControl1.TabStrip.EndUpdate();
            }
        }

        #endregion

        #region ResetAllTabColors

        /// <summary>
        /// Resets the entire control color definitions
        /// back to the default
        /// </summary>
        /// <param name="tab"></param>
        private void ResetAllTabColors(SuperTabItem tab)
        {
            superTabControl1.ResetTabStripColor();

            tab.ResetTabColor();
            tab.PredefinedColor = eTabItemColor.Default;

            SuperTabControlPanel panel = stiTabStyle.AttachedControl as SuperTabControlPanel;

            if (panel != null)
                panel.ResetPanelColor();
        }

        #endregion

        #region ContextMenu support

        #region stiColor_MouseUp

        /// <summary>
        /// Handles Color tab mouseUp events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stiColor_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmiColorDefault.Checked = cbColorDefault.Checked;
                cmiColor1.Checked = cbColor1.Checked;
                cmiColor2.Checked = cbColor2.Checked;

                ShowContextMenu(cmColor);
            }
        }

        #endregion

        #region cmiColorDefault_Click

        /// <summary>
        /// Handles Default Color selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiColorDefault_Click(object sender, EventArgs e)
        {
            cbColorDefault.Checked = !cbColorDefault.Checked;
        }

        #endregion

        #region cmiColor1_Click

        /// <summary>
        /// Handles Color1 selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiColor1_Click(object sender, EventArgs e)
        {
            cbColor1.Checked = !cbColor1.Checked;
        }

        #endregion

        #region cmiColor2_Click

        /// <summary>
        /// Handles Color2 selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiColor2_Click(object sender, EventArgs e)
        {
            cbColor2.Checked = !cbColor2.Checked;
        }

        #endregion

        #endregion

        #endregion

        #region BaseItems

        #region btxAddBaseItems_Click

        #region btxAddBaseItems_Click

        /// <summary>
        /// handles AddBaseItem selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btxAddBaseItems_Click(object sender, EventArgs e)
        {
            AddBaseItems();
        }

        #endregion

        #region AddBaseItems

        /// <summary>
        /// Initiates the addition of sample BaseItem entries
        /// </summary>
        private void AddBaseItems()
        {
            AddPrintButton();
            AddItalicizeCheckbox();
            AddColorPicker();
        }

        #endregion

        #region AddColorPicker

        #region AddColorPicker

        /// <summary>
        /// Adds a ColorPickerDropdown BaseItem object
        /// to the Tabs list
        /// </summary>
        private void AddColorPicker()
        {
            ColorPickerDropDown cp = new ColorPickerDropDown();

            cp.EnableMarkup = true;
            cp.Text = "Text Color";
            cp.Stretch = cbxStretch.Checked;
            cp.Click += CpClick;

            superTabControl1.Tabs.Insert(0, cp);
        }

        #endregion

        #region CpClick

        /// <summary>
        /// Handles ColorPickerDropdown selections
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CpClick(object sender, EventArgs e)
        {
            ColorPickerDropDown cp = sender as ColorPickerDropDown;

            if (cp != null)
            {
                // Set the Text color for our currently selected tab

                SuperTabItem tab = superTabControl1.SelectedTab;

                if (tab != null)
                {
                    tab.TabColor.Default.Normal.Text = cp.SelectedColor;
                    tab.TabColor.Default.Selected.Text = cp.SelectedColor;
                    tab.TabColor.Default.SelectedMouseOver.Text = cp.SelectedColor;
                    tab.TabColor.Default.MouseOver.Text = cp.SelectedColor;
                }
            }
        }

        #endregion

        #endregion

        #region AddItalicizeCheckbox

        #region AddItalicizeCheckbox

        /// <summary>
        /// Adds a CheckBox BaseItem to our Tabs list
        /// </summary>
        private void AddItalicizeCheckbox()
        {
            CheckBoxItem cbi = new CheckBoxItem();

            cbi.Text = "Italicize ";
            cbi.CheckedChanged += CbiCheckedChanged;
            cbi.Stretch = cbxStretch.Checked;
            cbi.Click += CbiClick;

            superTabControl1.Tabs.Add(cbi);
        }

        #endregion

        #region CbiClick

        /// <summary>
        /// Handles CheckBox item selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CbiClick(object sender, EventArgs e)
        {
            MessageBox.Show("Italicize Clicked!");
        }

        #endregion

        #region CbiCheckedChanged

        /// <summary>
        /// Handles "Italicize" checkBox change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CbiCheckedChanged(object sender, EventArgs e)
        {
            CheckBoxItem cbi = sender as CheckBoxItem;

            if (cbi != null)
            {
                if (cbi.Checked == true)
                {
                    // Set our current TabFont and SelectedTabFont to reflect the Italics

                    superTabControl1.TabFont = new Font(SystemFonts.CaptionFont, FontStyle.Italic);
                    superTabControl1.SelectedTabFont = new Font(SystemFonts.CaptionFont, FontStyle.Italic | FontStyle.Bold);
                }
                else
                {
                    // Reset our tab fonts back to the system defaults

                    superTabControl1.TabFont = null;
                    superTabControl1.SelectedTabFont = null;
                }
            }
        }

        #endregion

        #endregion

        #region AddPrintButton

        #region AddPrintButton

        /// <summary>
        /// Adds a ButtonItem BaseItem to our Tabs list
        /// </summary>
        private void AddPrintButton()
        {
            ButtonItem bi = new ButtonItem();

            bi.Text = "Print";
            bi.ButtonStyle = eButtonStyle.ImageAndText;
            bi.Stretch = cbxStretch.Checked;
            bi.ImageIndex = 1;
            bi.Click += Print_Click;

            ButtonItem bi2 = new ButtonItem();

            bi2.Text = "Local Printer";
            bi2.ButtonStyle = eButtonStyle.ImageAndText;
            bi2.Click += Print_Click;

            bi.SubItems.Add(bi2);

            bi2 = new ButtonItem();

            bi2.Text = "Remote Printer";
            bi2.ButtonStyle = eButtonStyle.ImageAndText;
            bi2.Click += Print_Click;

            bi.SubItems.Add(bi2);

            superTabControl1.Tabs.Add(bi);
        }

        #endregion

        #region Print_Click

        /// <summary>
        /// Handles ButtonItem Click selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Print_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
            {
                EventSourceArgs esa = e as EventSourceArgs;

                // Check to see if the event was generated via the mouse, or
                // was generated via a ControlBox.MenuBox.TabMenu selection
                // when the RaiseClickOnSelection property is set

                if (esa != null && esa.Source == eEventSource.Code)
                    MessageBox.Show(bi.Text + " selected via MenuBox!");
                else
                    MessageBox.Show(bi.Text + " selected!");
            }
        }

        #endregion

        #endregion

        #endregion

        #region btxDelBaseItems_Click

        #region btxDelBaseItems_Click

        /// <summary>
        /// Handles DelBaseItems selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btxDelBaseItems_Click(object sender, EventArgs e)
        {
            DelBaseItems();
        }

        #endregion

        #region DelBaseItems

        /// <summary>
        /// Deletes all BaseItems from the Tabs list
        /// </summary>
        private void DelBaseItems()
        {
            // Loop through each Tabs entry, removing every BaseItem
            // occurrence we find

            for (int i = superTabControl1.Tabs.Count - 1; i >= 0; i--)
            {
                if ((superTabControl1.Tabs[i] is SuperTabItem) == false)
                    superTabControl1.Tabs.RemoveAt(i);
            }
        }

        #endregion

        #endregion

        #region cbxBaseItemAlignment_SelectedIndexChanged

        /// <summary>
        /// Handles BaseItem Alignment selection.
        /// 
        /// When BaseItems are added to the Tabs list, they can be
        /// aligned Near, Center, or Far.  Near is default.  This
        /// setting has no effect when Stretch is set to true.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxBaseItemAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] values = (int[])Enum.GetValues(typeof(eItemAlignment));
            eItemAlignment eia = (eItemAlignment)(values[cbxBaseItemAlignment.SelectedIndex]);

            for (int i = 0; i < superTabControl1.Tabs.Count; i++)
            {
                if ((superTabControl1.Tabs[i] is SuperTabItem) == false)
                    superTabControl1.Tabs[i].ItemAlignment = eia;
            }
        }

        #endregion

        #region cbxStretch_CheckedChanged

        /// <summary>
        /// Handles Stretch selection.
        /// 
        /// This setting causes the underlying BaseItem object to be
        /// stretched (either vertically or horizontally) to fill the allotted
        /// control tab space.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxStretch_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < superTabControl1.Tabs.Count; i++)
            {
                if ((superTabControl1.Tabs[i] is SuperTabItem) == false)
                    superTabControl1.Tabs[i].Stretch = cbxStretch.Checked;
            }
        }

        #endregion

        #region ContextMenu support

        #region stiBaseItems_MouseUp

        /// <summary>
        /// Handles BaseItems mouseUp events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stiBaseItems_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Set our Checked states

                cmiStretch.Checked = cbxStretch.Checked;

                cmiBaseItemsNear.Checked = cbxBaseItemAlignment.SelectedIndex == (int) eItemAlignment.Near;
                cmiBaseItemsCenter.Checked = cbxBaseItemAlignment.SelectedIndex == (int) eItemAlignment.Center;
                cmiBaseItemsFar.Checked = cbxBaseItemAlignment.SelectedIndex == (int) eItemAlignment.Far;

                // Set our DelBaseItems Checked state

                bool delState = false;

                for (int i = 0; i < superTabControl1.Tabs.Count; i++)
                {
                    if (superTabControl1.Tabs[i] is SuperTabItem == false)
                    {
                        delState = true;
                        break;
                    }
                }

                cmiDelBaseItems.Enabled = delState;

                // Show our ContextMenu

                ShowContextMenu(cmBaseItems);
            }
        }

        #endregion

        #region cmiAddBaseItems_Click

        /// <summary>
        /// Handles AddBaseItems selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiAddBaseItems_Click(object sender, EventArgs e)
        {
            AddBaseItems();
        }

        #endregion

        #region cmiDelBaseItems_Click

        /// <summary>
        /// Handles DelBaseItems selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiDelBaseItems_Click(object sender, EventArgs e)
        {
            DelBaseItems();
        }

        #endregion

        #region cmiStretch_Click

        /// <summary>
        /// Handles Stretch selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiStretch_Click(object sender, EventArgs e)
        {
            cbxStretch.Checked = !cbxStretch.Checked;
        }

        #endregion

        #region cmiBaseItemsNear_Click

        /// <summary>
        /// Handles Near selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiBaseItemsNear_Click(object sender, EventArgs e)
        {
            cbxBaseItemAlignment.SelectedIndex = (int)eItemAlignment.Near;
        }

        #endregion

        #region cmiBaseItemsCenter_Click

        /// <summary>
        /// Handles Center selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiBaseItemsCenter_Click(object sender, EventArgs e)
        {
            cbxBaseItemAlignment.SelectedIndex = (int)eItemAlignment.Center;
        }

        #endregion

        #region cmiBaseItemsFar_Click

        /// <summary>
        /// Handles Far selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiBaseItemsFar_Click(object sender, EventArgs e)
        {
            cbxBaseItemAlignment.SelectedIndex = (int)eItemAlignment.Far;
        }

        #endregion

        #endregion

        #endregion

        #region ControlBox Visibility

        #region cbxControlBoxVisible_CheckedChanged

        /// <summary>
        /// Handles ControlBoxVisible selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxControlBoxVisible_CheckedChanged(object sender, EventArgs e)
        {
            superTabControl1.ControlBox.Visible = cbxControlBoxVisible.Checked;
        }

        #endregion

        #region cbxCloseBoxVisible_CheckedChanged

        /// <summary>
        /// Handles CloseBoxVisible selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxCloseBoxVisible_CheckedChanged(object sender, EventArgs e)
        {
            superTabControl1.ControlBox.CloseBox.Visible = cbxCloseBoxVisible.Checked;
            cbxCloseBoxVisible2.Checked = cbxCloseBoxVisible.Checked;
        }

        #endregion

        #region cbxMenuBoxVisible_CheckedChanged

        /// <summary>
        /// Handles MenuBoxVisible selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxMenuBoxVisible_CheckedChanged(object sender, EventArgs e)
        {
            superTabControl1.ControlBox.MenuBox.Visible = cbxMenuBoxVisible.Checked;
        }

        #endregion

        #region cbxAutoHide_CheckedChanged

        /// <summary>
        /// Handles AutoHide selection.
        /// 
        /// This property controls whether the system will automatically
        /// hide the ControlBox.MenuBox when it is not needed (ie. when all
        /// the tabs concurrently are visible in the TabStrip).
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxAutoHide_CheckedChanged(object sender, EventArgs e)
        {
            superTabControl1.ControlBox.MenuBox.AutoHide = cbxAutoHide.Checked;

            cbxMenuBoxVisible.Checked = superTabControl1.ControlBox.MenuBox.Visible;
        }

        #endregion

        #region cbxShowTabsOnly_CheckedChanged

        /// <summary>
        /// Handles ShowTabsOnly selection.
        /// 
        /// The ShowTabsOnly property set to true, will cause only
        /// SuperTabItems to be included in the MenuBox.TabMenu.  Setting
        /// it to false will cause all Tab entries to be included.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxShowTabsOnly_CheckedChanged(object sender, EventArgs e)
        {
            superTabControl1.ControlBox.MenuBox.ShowTabsOnly = cbxShowTabsOnly.Checked;
        }

        #endregion

        #region cbxShowImages_CheckedChanged

        /// <summary>
        /// Handles ShowImages selection.
        /// 
        /// Setting the ShowImages property to true will cause all
        /// SuperTabItem entries images to be displayed in the
        /// MenuBox.TabMenu.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxShowImages_CheckedChanged(object sender, EventArgs e)
        {
            superTabControl1.ControlBox.MenuBox.ShowImages = cbxShowImages.Checked;
        }

        #endregion

        #region cbxRaiseClick_CheckedChanged

        /// <summary>
        /// Handles RaiseClick selection.
        /// 
        /// Setting the RaiseClickOnSelection to true will cause the
        /// MenuBox.TabMenu to Raise a Click event when an item is selected.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxRaiseClick_CheckedChanged(object sender, EventArgs e)
        {
            superTabControl1.ControlBox.MenuBox.RaiseClickOnSelection = cbxRaiseClick.Checked;
        }

        #endregion

        #region ContextMenu support

        #region stiCbVisibility_MouseUp

        /// <summary>
        /// Handles ControlBoxVisibility mouseUp events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stiCbVisibility_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmiControlBoxVis.Checked = cbxControlBoxVisible.Checked;
                cmiCloseBoxVis.Checked = cbxCloseBoxVisible.Checked;
                cmiMenuBoxVis.Checked = cbxMenuBoxVisible.Checked;
                cmiAutoHide.Checked = cbxAutoHide.Checked;
                cmiShowTabsOnly.Checked = cbxShowTabsOnly.Checked;
                cmiShowImages.Checked = cbxShowImages.Checked;
                cmiRaiseClick.Checked = cbxRaiseClick.Checked;

                ShowContextMenu(cmControlBoxVis);
            }
        }

        #endregion

        #region cmiControlBoxVis_Click

        /// <summary>
        /// Handles ControlBoxVis selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiControlBoxVis_Click(object sender, EventArgs e)
        {
            cbxControlBoxVisible.Checked = !cbxControlBoxVisible.Checked;
        }

        #endregion

        #region cmiCloseBoxVis_Click

        /// <summary>
        /// Handles CloseBoxVis selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiCloseBoxVis_Click(object sender, EventArgs e)
        {
            cbxCloseBoxVisible.Checked = !cbxCloseBoxVisible.Checked;
        }

        #endregion

        #region cmiMenuBoxVis_Click

        /// <summary>
        /// Handles MenuBoxVis selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiMenuBoxVis_Click(object sender, EventArgs e)
        {
            cbxMenuBoxVisible.Checked = !cbxMenuBoxVisible.Checked;
        }

        #endregion

        #region cmiAutoHide_Click

        /// <summary>
        ///  Handles AutoHide selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiAutoHide_Click(object sender, EventArgs e)
        {
            cbxAutoHide.Checked = !cbxAutoHide.Checked;
        }

        #endregion

        #region cmiShowTabsOnly_Click

        /// <summary>
        /// Handles ShowTabsOnly selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiShowTabsOnly_Click(object sender, EventArgs e)
        {
            cbxShowTabsOnly.Checked = !cbxShowTabsOnly.Checked;
        }

        #endregion

        #region cmiShowImages_Click

        /// <summary>
        /// Handles ShowImages selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiShowImages_Click(object sender, EventArgs e)
        {
            cbxShowImages.Checked = !cbxShowImages.Checked;
        }

        #endregion

        #region cmiRaiseClick_Click

        /// <summary>
        /// Handles RaiseClick selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiRaiseClick_Click(object sender, EventArgs e)
        {
            cbxRaiseClick.Checked = !cbxRaiseClick.Checked;
        }

        #endregion

        #endregion

        #endregion

        #region ControlBox Customization

        #region btxAddBoxItems_Click

        #region btxAddBoxItems_Click

        /// <summary>
        /// Initiates the addition of sample ControlBox items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btxAddBoxItems_Click(object sender, EventArgs e)
        {
            AddBoxItems();
        }

        #endregion

        #region AddBoxItems

        /// <summary>
        /// Adds sample items to the ControlBox
        /// </summary>
        private void AddBoxItems()
        {
            ButtonItem bi = new ButtonItem();

            bi.ImageIndex = 2;
            bi.Text = "Help";
            bi.ButtonStyle = eButtonStyle.ImageAndText;
            bi.Click += Help_Click;

            ButtonItem sbi = new ButtonItem();
            sbi.Text = "Contact HelpDesk";
            sbi.AutoCollapseOnClick = true;
            sbi.Click += Help_Click;

            bi.SubItems.Add(sbi);

            sbi = new ButtonItem();
            sbi.Text = "Contact DevComponents";
            sbi.AutoCollapseOnClick = true;
            sbi.Click += Help_Click;

            bi.SubItems.Add(sbi);

            superTabControl1.ControlBox.SubItems.Add(bi);
        }

        #endregion

        #region Help_Click

        /// <summary>
        /// Handles ControlBox sample item selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Help_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
                MessageBox.Show("\"" + bi.Text + "\"" + " selected!");
        }

        #endregion

        #endregion

        #region btxDelBoxItems_Click

        #region btxDelBoxItems_Click

        /// <summary>
        /// Initiates the deletion of any added sample
        /// ControlBox items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btxDelBoxItems_Click(object sender, EventArgs e)
        {
            DelBoxItems();
        }

        #endregion

        #region DelBoxItems

        /// <summary>
        /// Deletes any previously added ControlBox sample items
        /// </summary>
        private void DelBoxItems()
        {
            superTabControl1.ControlBox.RemoveUserItems();
        }

        #endregion

        #endregion

        #region MenuBox_TabMenuOpen

        /// <summary>
        /// Handles MenuBox_PopupOpen events.
        /// 
        /// This event is sent just before the ControlBoxMenuBox.TabMenu is
        /// opened and displayed.  The user has the ability to add, delete, or
        /// even cancel the operation.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MenuBox_PopupOpen(object sender, PopupOpenEventArgs e)
        {
            // If the user has said they want us to modify the TabMenu,
            // just add a couple of items to the list to let them
            // add or delete new user tabs

            if (_ModifyTabMenu == true)
            {
                PopupItem pi = sender as PopupItem;

                if (pi != null)
                {
                    ButtonItem bi = new ButtonItem();
                    bi.Text = "Add User Tab";
                    bi.BeginGroup = true;
                    bi.Click += AddUserTab_Click;

                    pi.SubItems.Insert(0, bi);

                    bi = new ButtonItem();
                    bi.Text = "Delete User Tab";
                    bi.Tag = superTabControl1.SelectedTab;
                    bi.Click += DelUserTab_Click;

                    pi.SubItems.Insert(1, bi);

                    // Enable the added Delete entry if the currently selected
                    // tab is one they have previously added

                    if (superTabControl1.SelectedTab == null ||
                        superTabControl1.SelectedTab.Text.StartsWith("New Tab") == false)
                    {
                        bi.Enabled = false;
                    }

                    if (pi.SubItems.Count > 2)
                        pi.SubItems[2].BeginGroup = true;
                }
            }
        }

        #region DelUserTab_Click

        void DelUserTab_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;

            if (bi != null)
            {
                SuperTabItem tab = bi.Tag as SuperTabItem;

                if (tab != null && tab.Text.StartsWith("New Tab") == true)
                    tab.Close();
            }
        }

        #endregion

        #region AddUserTab_Click

        void AddUserTab_Click(object sender, EventArgs e)
        {
            AddNewUserTab();
        }

        #region AddNewUserTab

        private void AddNewUserTab()
        {
            SuperTabItem tab = superTabControl1.CreateTab("New Tab " + _UserTabCount, 0);
            tab.Tag = _UserTabCount++;

            if (cbxAddTabImages.Checked == true)
                tab.ImageIndex = 12;

            LabelX lbx = new LabelX();
            lbx.Text = "This space intentionally left blank.";
            lbx.TextAlignment = StringAlignment.Center;
            lbx.TextLineAlignment = StringAlignment.Center;
            lbx.BackColor = Color.Transparent;

            tab.AttachedControl.Controls.Add(lbx);
            lbx.Dock = DockStyle.Fill;

            UpdateDelUserButton();
        }

        #endregion

        #endregion

        #region UpdateDelUserButton

        private void UpdateDelUserButton()
        {
            btxDelUserTab.SubItems.Clear();

            for (int i = 0; i < superTabControl1.Tabs.Count; i++)
            {
                SuperTabItem tab = superTabControl1.Tabs[i] as SuperTabItem;

                if (tab != null)
                {
                    if (tab.Text.StartsWith("New Tab") == true)
                    {
                        ButtonItem bi = new ButtonItem();
                        bi.Tag = tab;
                        bi.Text = tab.Text;
                        bi.Click += DelUserTab_Click;

                        btxDelUserTab.SubItems.Add(bi);
                    }
                }
            }

            btxDelUserTab.Enabled = (btxDelUserTab.SubItems.Count > 0);

            btxDelUserTab.RecalcLayout();
        }

        #endregion

        #endregion

        #region cbxModifyTabMenu_CheckedChanged

        /// <summary>
        /// Handles ModifyTabMenu selections
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxModifyTabMenu_CheckedChanged(object sender, EventArgs e)
        {
            _ModifyTabMenu = cbxModifyTabMenu.Checked;
        }

        #endregion

        #region ContextMenu support

        #region stiCbCustom_MouseUp

        /// <summary>
        /// Handles ControlBoxCustomization mouseUp events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stiCbCustom_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmiModifyTabMenu.Checked = cbxModifyTabMenu.Checked;

                ShowContextMenu(cmCbCustom);
            }
        }

        #endregion

        #region cmiAddCbItems_Click

        /// <summary>
        /// Handles AddControlBoxItems selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiAddCbItems_Click(object sender, EventArgs e)
        {
            AddBoxItems();
        }

        #endregion

        #region cmiDelCbItems_Click

        /// <summary>
        /// Handles DelControlBoxItems selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiDelCbItems_Click(object sender, EventArgs e)
        {
            DelBoxItems();
        }

        #endregion

        #region cmiModifyTabMenu_Click

        /// <summary>
        /// Handles ModifyTabMenu selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiModifyTabMenu_Click(object sender, EventArgs e)
        {
            cbxModifyTabMenu.Checked = !cbxModifyTabMenu.Checked;
        }

        #endregion

        #endregion

        #endregion

        #region CloseBox Visibility

        #region cbxCloseBoxVisible2_CheckedChanged

        /// <summary>
        /// Handles CloseBoxVisible selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxCloseBoxVisible2_CheckedChanged(object sender, EventArgs e)
        {
            cbxCloseBoxVisible.Checked = cbxCloseBoxVisible2.Checked;
        }

        #endregion

        #region cbxTabCloseVisible_CheckedChanged

        /// <summary>
        /// Handles TabCloseVisible selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxTabCloseVisible_CheckedChanged(object sender, EventArgs e)
        {
            superTabControl1.CloseButtonOnTabsVisible = cbxTabCloseVisible.Checked;
        }

        #endregion

        #region cbxTabCloseAlwaysDisplayed_CheckedChanged

        /// <summary>
        /// Handles TabCloseAlwaysDisplayed selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxTabCloseAlwaysDisplayed_CheckedChanged(object sender, EventArgs e)
        {
            superTabControl1.CloseButtonOnTabsAlwaysDisplayed = cbxTabCloseAlwaysDisplayed.Checked;
        }

        #endregion

        #region cbxTabCloseLeft_CheckedChanged

        /// <summary>
        /// Handles TabCloseLeft selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxTabCloseLeft_CheckedChanged(object sender, EventArgs e)
        {
            superTabControl1.CloseButtonPosition = eTabCloseButtonPosition.Left;
        }

        #endregion

        #region cbxTabCloseRight_CheckedChanged

        /// <summary>
        /// Handles TabCloseRight selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxTabCloseRight_CheckedChanged(object sender, EventArgs e)
        {
            superTabControl1.CloseButtonPosition = eTabCloseButtonPosition.Right;
        }

        #endregion

        #region ContextMenu support

        #region stiCloseVisibility_MouseUp

        /// <summary>
        /// Handles CloseVisibility mouseUp events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stiCloseVisibility_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmiControlBoxCloseVis.Checked = cbxCloseBoxVisible2.Checked;
                cmiTabCloseVisible.Checked = cbxTabCloseVisible.Checked;
                cmiTabCloseAlwaysDisplayed.Checked = cbxTabCloseAlwaysDisplayed.Checked;
                cmiTabCloseLeft.Checked = cbxTabCloseLeft.Checked;
                cmiTabCloseRight.Checked = cbxTabCloseRight.Checked;

                ShowContextMenu(cmCloseBoxVis);
            }
        }

        #endregion

        #region cmiControlBoxCloseVis_Click

        /// <summary>
        /// Handles ControlBoxCloseVis selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiControlBoxCloseVis_Click(object sender, EventArgs e)
        {
            cbxCloseBoxVisible2.Checked = !cbxCloseBoxVisible2.Checked;
        }

        #endregion

        #region cmiTabCloseVisible_Click

        /// <summary>
        /// Handles TabCloseVisible selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiTabCloseVisible_Click(object sender, EventArgs e)
        {
            cbxTabCloseVisible.Checked = !cbxTabCloseVisible.Checked;
        }

        #endregion

        #region cmiTabCloseAlwaysVisible_Click

        /// <summary>
        /// Handles TabCloseAlwaysDisplayed selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiTabCloseAlwaysDisplayed_Click(object sender, EventArgs e)
        {
            cbxTabCloseAlwaysDisplayed.Checked = !cbxTabCloseAlwaysDisplayed.Checked;
        }

        #endregion

        #region cmiTabCloseLeft_Click

        /// <summary>
        /// Handles TabCloseLeft selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiTabCloseLeft_Click(object sender, EventArgs e)
        {
            cbxTabCloseLeft.Checked = !cbxTabCloseLeft.Checked;
        }


        #endregion

        #region cmiTabCloseRight_Click

        /// <summary>
        /// Handles TabCloseRight selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiTabCloseRight_Click(object sender, EventArgs e)
        {
            cbxTabCloseRight.Checked = !cbxTabCloseRight.Checked;
        }

        #endregion

        #endregion

        #endregion

        #region User Tab Customization

        #region cbxUserDefined_CheckedChanged

        #region cbxUserDefined_CheckedChanged

        /// <summary>
        /// Handles UserDefined selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxUserDefined_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxUserDefined.Checked == true)
                EnableUserDraw();
            else
                DisableUserDraw();
        }

        #endregion

        #region EnableUserDraw

        /// <summary>
        /// Enables call-outs for user defined tab definition
        /// </summary>
        private void EnableUserDraw()
        {
            superTabControl1.MeasureTabItem += MeasureTabItem;
            superTabControl1.PreRenderTabItem += PreRenderTabItem;
            superTabControl1.PostRenderTabItem += PostRenderTabItem;
            superTabControl1.GetTabItemPath += GetTabItemPath;
            superTabControl1.GetTabItemContentRectangle += GetTabItemContentRectangle;

            // We are changing how the control is laid out, so force
            // a recalc of the control to reflect our changes

            superTabControl1.RecalcLayout();
        }

        #region MeasureTabItem

        /// <summary>
        /// Handles the MeasureTabItem event.
        /// 
        /// The e.Size parameter is set to the size the system has
        /// calculated for the item.  You can add to or subtract from this
        /// sized value (or replace it all together) - it all depends upon
        /// how you choose to layout your tab item.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MeasureTabItem(object sender, SuperTabMeasureTabItemEventArgs e)
        {
            Size size = e.Size;

            // Our user defined TabItemPath will have a half-circle bump
            // on it, so add extra to the width and/or height to allow for it

            if (e.Tab.TabAlignment == eTabStripAlignment.Left ||
                e.Tab.TabAlignment == eTabStripAlignment.Right)
            {
                size.Width += 15;
            }
            else
            {
                size.Height += 15;
            }

            // Return the new size to the system

            e.Size = size;
        }

        #endregion

        #region PreRenderTabItem

        /// <summary>
        /// Handles the PreRenderTabItem event.
        /// 
        /// This event gives you the opportunity to totally replace all
        /// tab drawing by the system - if you return e.Cancel = true.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PreRenderTabItem(object sender, SuperTabPreRenderTabItemEventArgs e)
        {
            // Here just for documentation purposes
        }

        #endregion

        #region PostRenderTabItem

        /// <summary>
        /// Handles PostRenderTabItem events.
        /// 
        /// This event lets you handle any rendering to the tab after the system
        /// has completed all of its rendering.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PostRenderTabItem(object sender, SuperTabPostRenderTabItemEventArgs e)
        {
            // Here just for demonstration purposes

            if (e.Tab.Text.StartsWith("New Tab"))
            {
                int n = (int)(e.Tab.Tag);

                if (n % 2 == 0)
                {
                    using (GraphicsPath path = e.Tab.GetTabItemPath())
                    {
                        Color color1 = Color.FromArgb(30, Color.AliceBlue);
                        Color color2 = Color.FromArgb(30, Color.Blue);

                        using (Brush br = new HatchBrush(HatchStyle.LightUpwardDiagonal, color1, color2))
                            e.Graphics.FillPath(br, path);
                    }
                }
            }
        }

        #endregion

        #region GetTabItemPath

        #region GetTabItemPath

        /// <summary>
        /// Handles the GetTabItemPath event.
        /// 
        /// This event gives you the ability to define your own user
        /// tab layout.  Your layout is used in conjunction with the 
        /// TabStyle you have chosen.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GetTabItemPath(object sender, SuperTabGetTabItemPathEventArgs e)
        {
            // Determine what Tab alignment we need to
            // provide an item path for

            switch (e.Tab.TabAlignment)
            {
                case eTabStripAlignment.Top:
                    GetTopItemPath(e);
                    break;

                case eTabStripAlignment.Left:
                    GetLeftItemPath(e);
                    break;

                case eTabStripAlignment.Bottom:
                    GetBottomItemPath(e);
                    break;

                default:
                    GetRightItemPath(e);
                    break;
            }
        }

        #endregion

        #region GetTopItemPath

        /// <summary>
        /// Gets out Top Alignment tab path
        /// </summary>
        /// <param name="e"></param>
        private void GetTopItemPath(SuperTabGetTabItemPathEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();

            // The ContentRectangle is the rectangle that defines the bounds of
            // the "content" of the tab (encompassing the the image, text, and closeBox)

            Rectangle t = e.Tab.ContentRectangle;
            Rectangle r = e.Tab.DisplayRectangle;

            r.Width -= 1;
            r.Height -= 1;

            t.Width -= 1;
            t.Height -= 1;

            // If the tab is the selected tab, we need to allow for
            // the 2 pixel wide TabStrip border

            if (e.Tab.IsSelected == true)
                r.Height += 2;

            // We are defining a tab that has a knobby on the top, and for the
            // VisualStudio2008Document style tabs, we want it on the opposite side

            if (e.Tab.TabStyle == eSuperTabStyle.VisualStudio2008Document)
            {
                path.AddLine(r.Right, r.Bottom, r.Right, r.Top + Radius);
                path.AddArc(new Rectangle(r.Right - Radius * 2, r.Top, Radius * 2, Radius * 2), 0, -180);
                path.AddLine(r.Right - Radius * 2, r.Top + Radius * 2, t.X, r.Top + Radius * 2);
                path.AddLine(t.X, r.Top + Radius * 2, t.X, r.Top + r.Height / 2);
                path.AddLine(t.X, r.Top + r.Height / 2, r.X, r.Bottom);
            }
            else
            {
                path.AddLine(r.X, r.Bottom, r.X, r.Top + Radius);
                path.AddArc(new Rectangle(r.X, r.Top, Radius * 2, Radius * 2), 180, 180);
                path.AddLine(r.X + Radius * 2, r.Top + Radius * 2, t.Right, r.Top + Radius * 2);
                path.AddLine(t.Right, r.Top + Radius * 2, t.Right, r.Top + r.Height / 2);
                path.AddLine(t.Right, r.Top + r.Height / 2, r.Right, r.Bottom);
            }

            // Return the path to the system

            e.Path = path;
        }

        #endregion

        #region GetLeftItemPath

        /// <summary>
        /// Get the Left Tab alignment path
        /// </summary>
        /// <param name="e"></param>
        private void GetLeftItemPath(SuperTabGetTabItemPathEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();

            // The ContentRectangle is the rectangle that defines the bounds of
            // the "content" of the tab (encompassing the the image, text, and closeBox)

            Rectangle t = e.Tab.ContentRectangle;
            Rectangle r = e.Tab.DisplayRectangle;

            r.Width -= 1;
            r.Height -= 1;

            t.Width -= 1;
            t.Height -= 1;

            // If the tab is the selected tab, we need to allow for
            // the 2 pixel wide TabStrip border

            if (e.Tab.IsSelected == true)
                r.Width += 2;

            // We are defining a tab that has a knobby on the top, and for the
            // VisualStudio2008Document style tabs, we want it on the opposite side

            if (e.Tab.TabStyle == eSuperTabStyle.VisualStudio2008Document)
            {
                path.AddLine(r.Right, r.Bottom, r.X + Radius, r.Bottom);
                path.AddArc(new Rectangle(r.X, r.Bottom - Radius * 2, Radius * 2, Radius * 2), 90, 180);
                path.AddLine(r.X + Radius * 2, r.Bottom - Radius * 2, r.X + Radius * 2, t.Top + 2);
                path.AddLine(r.X + Radius * 2, t.Top + 2, r.X + r.Width / 2, t.Top + 2);
                path.AddLine(r.X + r.Width / 2, t.Top + 2, r.Right, r.Top);
            }
            else
            {
                path.AddLine(r.Right, r.Top, r.X + Radius, r.Top);
                path.AddArc(new Rectangle(r.X, r.Y, Radius * 2, Radius * 2), 270, -180);
                path.AddLine(r.X + Radius * 2, r.Top + Radius * 2, r.X + Radius * 2, t.Bottom);
                path.AddLine(r.X + Radius * 2, t.Bottom, r.X + r.Width / 2, t.Bottom);
                path.AddLine(r.X + r.Width / 2, t.Bottom, r.Right, r.Bottom);
            }

            // Return the path to the system

            e.Path = path;
        }

        #endregion

        #region GetBottomItemPath

        /// <summary>
        /// Gets the Bottom tab alignment path
        /// </summary>
        /// <param name="e"></param>
        private void GetBottomItemPath(SuperTabGetTabItemPathEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();

            // The ContentRectangle is the rectangle that defines the bounds of
            // the "content" of the tab (encompassing the the image, text, and closeBox)

            Rectangle t = e.Tab.ContentRectangle;
            Rectangle r = e.Tab.DisplayRectangle;

            r.Width -= 1;
            r.Height -= 1;

            t.Width -= 1;
            t.Height -= 1;

            // If the tab is the selected tab, we need to allow for
            // the 2 pixel wide TabStrip border

            if (e.Tab.IsSelected == true)
            {
                r.Y -= 2;
                r.Height += 2;
            }

            // We are defining a tab that has a knobby on the top, and for the
            // VisualStudio2008Document style tabs, we want it on the opposite side

            if (e.Tab.TabStyle == eSuperTabStyle.VisualStudio2008Document)
            {
                path.AddLine(r.Right, r.Top, r.Right, r.Bottom - Radius);
                path.AddArc(new Rectangle(r.Right - Radius * 2, r.Bottom - Radius * 2, Radius * 2, Radius * 2), 0, 180);
                path.AddLine(r.Right - Radius * 2, r.Bottom - Radius * 2, t.X, r.Bottom - Radius * 2);
                path.AddLine(t.X, r.Bottom - Radius * 2, t.X, r.Top + r.Height / 2);
                path.AddLine(t.X, r.Top + r.Height / 2, r.X, r.Top);
            }
            else
            {
                path.AddLine(r.X, r.Top, r.X, r.Bottom - Radius);
                path.AddArc(new Rectangle(r.X, r.Bottom - Radius * 2, Radius * 2, Radius * 2), 180, -180);
                path.AddLine(r.X + Radius * 2, r.Bottom - Radius * 2, t.Right, r.Bottom - Radius * 2);
                path.AddLine(t.Right, r.Bottom - Radius * 2, t.Right, r.Top + r.Height / 2);
                path.AddLine(t.Right, r.Top + r.Height / 2, r.Right, r.Top);
            }

            // Return the path to the system

            e.Path = path;
        }

        #endregion

        #region GetRightItemPath

        /// <summary>
        /// Get the Right Tab alignment path
        /// </summary>
        /// <param name="e"></param>
        private void GetRightItemPath(SuperTabGetTabItemPathEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();

            // The ContentRectangle is the rectangle that defines the bounds of
            // the "content" of the tab (encompassing the the image, text, and closeBox)

            Rectangle t = e.Tab.ContentRectangle;
            Rectangle r = e.Tab.DisplayRectangle;

            r.Width -= 1;
            r.Height -= 1;

            t.Width -= 1;
            t.Height -= 1;

            // If the tab is the selected tab, we need to allow for
            // the 2 pixel wide TabStrip border

            if (e.Tab.IsSelected == true)
            {
                r.X -= 2;
                r.Width += 2;
            }

            // We are defining a tab that has a knobby on the top, and for the
            // VisualStudio2008Document style tabs, we want it on the opposite side
            
            if (e.Tab.TabStyle == eSuperTabStyle.VisualStudio2008Document)
            {
                path.AddLine(r.X, r.Bottom, r.Right - Radius, r.Bottom);
                path.AddArc(new Rectangle(r.Right - Radius * 2, r.Bottom - Radius * 2, Radius * 2, Radius * 2), 90, -180);
                path.AddLine(r.Right - Radius * 2, r.Bottom - Radius * 2, r.Right - Radius * 2, t.Top + 2);
                path.AddLine(r.Right - Radius * 2, t.Top + 2, r.X + r.Width / 2, t.Top + 2);
                path.AddLine(r.X + r.Width / 2, t.Top + 2, r.X, r.Top);
            }
            else
            {
                path.AddLine(r.X, r.Top, r.Right - Radius, r.Top);
                path.AddArc(new Rectangle(r.Right - Radius * 2, r.Y, Radius * 2, Radius * 2), 270, 180);
                path.AddLine(r.Right - Radius * 2, r.Top + Radius * 2, r.Right - Radius * 2, t.Bottom);
                path.AddLine(r.Right - Radius * 2, t.Bottom, r.X + r.Width / 2, t.Bottom);
                path.AddLine(r.X + r.Width / 2, t.Bottom, r.X, r.Bottom);
            }

            // Return the path to the system

            e.Path = path;
        }

        #endregion

        #endregion

        #region GetTabItemContentRectangle

        /// <summary>
        /// Handles the GetTabItemContentRectangle event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GetTabItemContentRectangle(object sender, SuperTabGetTabItemContentRectangleEventArgs e)
        {
            // The ContentRectangle is the rectangle that defines the bounds of
            // the "content" of the tab (encompassing the the image, text, and closeBox).
            // If your tab is non-rectangularly shaped, you may not want the
            // ContentRectangle to be aligned with the DisplayRectangle.

            Rectangle r = e.ContentRectangle;

            // Offset our ContentRectangle to allow for the bump
            // we added to our tab paths

            switch (e.Tab.TabAlignment)
            {
                case eTabStripAlignment.Top:
                    r.Y += 10;
                    r.Height -= 10;
                    break;

                case eTabStripAlignment.Left:
                    r.X += 15;
                    r.Width -= 15;
                    break;

                case eTabStripAlignment.Bottom:
                    r.Height -= 15;
                    break;

                case eTabStripAlignment.Right:
                    r.Width -= 15;
                    break;
            }

            // Return the ContentRectangle to the system

            e.ContentRectangle = r;
        }

        #endregion

        #endregion

        #region DisableUserDraw

        /// <summary>
        /// Disables call-outs for user defined tab definition
        /// </summary>
        private void DisableUserDraw()
        {
            // Unhook our control events

            superTabControl1.MeasureTabItem -= MeasureTabItem;
            superTabControl1.PreRenderTabItem -= PreRenderTabItem;
            superTabControl1.PostRenderTabItem -= PostRenderTabItem;
            superTabControl1.GetTabItemPath -= GetTabItemPath;
            superTabControl1.GetTabItemContentRectangle -= GetTabItemContentRectangle;

            // Cause a layout recalculation to reflect the changes we just made

            superTabControl1.RecalcLayout();
        }

        #endregion

        #endregion

        #region cbxUserCloseBounds_CheckedChanged

        /// <summary>
        /// Handles UserCloseBounds selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxUserCloseBounds_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxUserCloseBounds.Checked == true)
                superTabControl1.GetTabCloseBounds += GetTabCloseBounds;
            else
                superTabControl1.GetTabCloseBounds -= GetTabCloseBounds;

            superTabControl1.RecalcLayout();
        }

        #region GetTabCloseBounds

        /// <summary>
        /// Handles GetTabCloseBounds event.
        /// 
        /// This events permits the user to provide an alternate bounding
        /// rectangle for the tab CloseBox.  It is initially set to the
        /// system calculated bounds.
        /// 
        /// Though we are only providing the CloseBounds, the same principle
        /// applies if you want/need to specify the Image or Text bounds.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetTabCloseBounds(object sender, SuperTabGetTabCloseBoundsEventArgs e)
        {
            // Let's put the closeBox at the top of the ContentRectangle
            // just for sample demo purposes

            Rectangle r = e.Bounds;
            r.X += 2;
            r.Y = e.Tab.ContentRectangle.Y + 4;

            // Return the new bounds to the system

            e.Bounds = r;
        }

        #endregion

        #endregion

        #region cbxPaintBackground_CheckedChanged

        /// <summary>
        /// Handles PaintBackground selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxPaintBackground_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPaintBackground.Checked == true)
                superTabControl1.TabStripPaintBackground += TabStripPaintBackground;
            else
                superTabControl1.TabStripPaintBackground -= TabStripPaintBackground;

            superTabControl1.TabStrip.Refresh();
        }

        #region TabStripPaintBackground

        /// <summary>
        /// Handles TabStripPaintBackground events.
        /// 
        /// This event permits the user to paint the TabStrip background area. 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TabStripPaintBackground(object sender, SuperTabStripPaintBackgroundEventArgs e)
        {
            Rectangle r = superTabControl1.TabStrip.DisplayRectangle;

            // Text, or anything could be painted here, but some care might need be taken
            // to determine available TabStrip display space (as the TabStrip area can
            // be overlaid by currently defined visible tabs.

            if (superTabControl1.TabStyle != eSuperTabStyle.Office2010BackstageBlue)
            {
                // As an example, let's just paint stripes on the TabStrip

                using (Pen pen = new Pen(e.ColorTable.OuterBorder))
                {
                    for (int i = r.Top + 2; i < r.Bottom; i += 2)
                        e.Graphics.DrawLine(pen, r.Left, i, r.Right, i);
                }
            }
        }

        #endregion

        #endregion

        #region cbxAddTabImages_CheckedChanged

        /// <summary>
        /// Handles AddTabImages selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxAddTabImages_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAddTabImages.Checked == true)
            {
                stiTabStyle.ImageIndex = 3;
                stiTabAlignment.ImageIndex = 4;
                stiTabSize.ImageIndex = 5;
                stiTextAlignment.ImageIndex = 6;
                stiColor.ImageIndex = 7;
                stiBaseItems.ImageIndex = 8;
                stiCbVisibility.ImageIndex = 9;
                stiCloseVisibility.ImageIndex = 9;
                stiCbCustom.ImageIndex = 10;
                stiUserTab.ImageIndex = 11;

                SetAllUserTabsImage(12);
            }
            else
            {
                stiTabStyle.ImageIndex = -1;
                stiTabAlignment.ImageIndex = -1;
                stiTabSize.ImageIndex = -1;
                stiTextAlignment.ImageIndex = -1;
                stiColor.ImageIndex = -1;
                stiBaseItems.ImageIndex = -1;
                stiCbVisibility.ImageIndex = -1;
                stiCloseVisibility.ImageIndex = -1;
                stiCbCustom.ImageIndex = -1;
                stiUserTab.ImageIndex = -1;

                SetAllUserTabsImage(-1);
            }
        }

        /// <summary>
        /// Sets user tabs imageIndex
        /// </summary>
        /// <param name="index"></param>
        private void SetAllUserTabsImage(int index)
        {
            for (int i = 0; i < superTabControl1.Tabs.Count; i++)
            {
                SuperTabItem tab = superTabControl1.Tabs[i] as SuperTabItem;

                if (tab != null)
                {
                    if (tab.Text.StartsWith("New Tab"))
                        tab.ImageIndex = index;
                }
            }
        }

        #endregion

        #region CbDefImagePosSelectedIndexChanged

        private void CbDefImagePosSelectedIndexChanged(object sender, EventArgs e)
        {
            superTabControl1.ImageAlignment =
               (ImageAlignment)Enum.Parse(typeof(ImageAlignment), cbDefImagePos.Text);
        }

        #endregion

        #region CbImagePosSelectedIndexChanged

        private void CbImagePosSelectedIndexChanged(object sender, EventArgs e)
        {
            SuperTabItem tab = superTabControl1.SelectedTab;

            if (tab != null)
            {
                tab.ImageAlignment =
                    (ImageAlignment)Enum.Parse(typeof(ImageAlignment), cbImagePos.Text);
            }
        }

        #endregion

        #region btxAddUserTab_Click

        /// <summary>
        /// Initiates the addition of a new User tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btxAddUserTab_Click(object sender, EventArgs e)
        {
            AddNewUserTab();
        }

        #endregion

        #region btxSort_Click

        #region btxSort_Click

        /// <summary>
        /// Handles SortTabs selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btxSort_Click(object sender, EventArgs e)
        {
            SortTabs();
        }

        #endregion

        #region SortTabs

        /// <summary>
        /// Sorts the tab according to their item Text
        /// </summary>
        private void SortTabs()
        {
            string[] keys = new string[superTabControl1.Tabs.Count];
            BaseItem[] items = new BaseItem[superTabControl1.Tabs.Count];

            for (int i = 0; i < superTabControl1.Tabs.Count; i++)
            {
                items[i] = superTabControl1.Tabs[i];
                keys[i] = superTabControl1.Tabs[i].PlainText;
            }

            Array.Sort(keys, items);

            for (int i = 0; i < superTabControl1.Tabs.Count; i++)
                superTabControl1.Tabs[i] = items[i];

            superTabControl1.RecalcLayout();
        }

        #endregion

        #endregion

        #region btxShuffle_Click

        #region btxShuffle_Click

        /// <summary>
        /// Handles Shuffle tabs selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btxShuffle_Click(object sender, EventArgs e)
        {
            ShuffleTabs();
        }

        #endregion

        #region ShuffleTabs

        /// <summary>
        /// Randomly shuffles the tabs
        /// </summary>
        private void ShuffleTabs()
        {
            string[] keys = new string[superTabControl1.Tabs.Count];
            BaseItem[] items = new BaseItem[superTabControl1.Tabs.Count];

            Random rnd = new Random();

            for (int i = 0; i < superTabControl1.Tabs.Count; i++)
            {
                items[i] = superTabControl1.Tabs[i];
                keys[i] = rnd.Next().ToString();
            }

            Array.Sort(keys, items);

            for (int i = 0; i < superTabControl1.Tabs.Count; i++)
                superTabControl1.Tabs[i] = items[i];

            superTabControl1.RecalcLayout();
        }

        #endregion

        #endregion

        #region ContextMenu support

        #region stiUserTab_MouseUp

        /// <summary>
        /// Handles UserTab MouseUp events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stiUserTab_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Set our Checked states

                cmiUserDrawn.Checked = cbxUserDefined.Checked;
                cmiUserCloseBounds.Checked = cbxUserCloseBounds.Checked;
                cmiUserPaintBackground.Checked = cbxPaintBackground.Checked;
                cmiAddTabImages.Checked = cbxAddTabImages.Checked;

                // Show our ContextMenu

                ShowContextMenu(cmUserTab);
            }
        }

        #endregion

        #region cmiUserDefined_Click

        /// <summary>
        /// Handles UserDefined selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiUserDefined_Click(object sender, EventArgs e)
        {
            cbxUserDefined.Checked = !cbxUserDefined.Checked;
        }

        #endregion

        #region cmiUserCloseBounds_Click

        /// <summary>
        /// Handles UserCloseBounds selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiUserCloseBounds_Click(object sender, EventArgs e)
        {
            cbxUserCloseBounds.Checked = !cbxUserCloseBounds.Checked;
        }

        #endregion

        #region cmiUserPaintBackground_Click

        /// <summary>
        /// Handles UserPaintBackground selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiUserPaintBackground_Click(object sender, EventArgs e)
        {
            cbxPaintBackground.Checked = !cbxPaintBackground.Checked;
        }

        #endregion

        #region cmiAddTabImages_Click

        /// <summary>
        /// Handles AddTabImages selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiAddTabImages_Click(object sender, EventArgs e)
        {
            cbxAddTabImages.Checked = !cbxAddTabImages.Checked;
        }

        #endregion

        #region cmiAddUserTab_Click

        /// <summary>
        /// Handles AddUserTab selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiAddUserTab_Click(object sender, EventArgs e)
        {
            AddNewUserTab();
        }

        #endregion

        #region cmiSortTabs_Click

        /// <summary>
        /// Handles SortTabs selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiSortTabs_Click(object sender, EventArgs e)
        {
            SortTabs();
        }

        #endregion

        #region cmiShuffleTabs_Click

        /// <summary>
        /// Handles ShuffleTabs selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmiShuffleTabs_Click(object sender, EventArgs e)
        {
            ShuffleTabs();
        }

        #endregion

        #endregion

        #endregion

        #region SuperTabControl

        #region superTabControl1_TabItemClose

        /// <summary>
        /// Handles TabItemClose events.
        /// 
        /// This event is sent before a tab is actually closed. This event gives
        /// you the chance to selectively cancel the close operation.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void superTabControl1_TabItemClose(object sender, SuperTabStripTabItemCloseEventArgs e)
        {
            SuperTabItem tab = e.Tab as SuperTabItem;

            // In our sample app, only let the user close tabs they have added

            if (tab == null || tab.Text.StartsWith("New Tab") == false)
            {
                MessageBox.Show("This app selectively let's you close only 'Newly Added Tabs'");

                e.Cancel = true;
            }
        }

        #endregion

        #region superTabControl1_TabRemoved

        /// <summary>
        /// Handles TabRemoved events.
        /// 
        /// This event is sent after a tab has been closed.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void superTabControl1_TabRemoved(object sender, SuperTabStripTabRemovedEventArgs e)
        {
            UpdateDelUserButton();
        }

        #endregion

        #region superTabControl1_TabMoved

        /// <summary>
        /// Handles TabMoved events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void superTabControl1_TabMoved(object sender, SuperTabStripTabMovedEventArgs e)
        {
            if (e.Tab.Text.StartsWith("New Tab") == true)
                MessageBox.Show("User Tab Moved!");
        }

        #endregion

        #region superTabControl1_TabStripMouseUp

        /// <summary>
        /// Handles TabStrip MouseUp events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void superTabControl1_TabStripMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Set our Checked state

                cmiPaintBackground.Checked = cbxPaintBackground.Checked;

                // Show the context menu for the TabStrip

                ShowContextMenu(cmTabStrip);
            }
        }

        #endregion

        #endregion

        #region ShowContextMenu

        /// <summary>
        /// Shows the given ContextMenu
        /// </summary>
        /// <param name="cm">ContextMenu to show</param>
        private void ShowContextMenu(ButtonItem cm)
        {
            cm.Popup(MousePosition);
        }

        #endregion

    }
}