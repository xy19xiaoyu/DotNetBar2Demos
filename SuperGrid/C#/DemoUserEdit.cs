using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace SuperGridDemo
{
    public partial class DemoUserEdit : Office2007Form
    {
        #region Private variables

        private Random _Rand = new Random();

        static Color[] _colors;

        static string[] _Clips = { 
                "Bad Feeling", "Hump", "Looking For",
                "Oz", "Terminator", "The Ritz"};

        #endregion

        public DemoUserEdit()
        {
            InitializeComponent();

            // Initialize the grid, ComboBoxes,
            // Audio Clip, etc, and set the sample description text.

            InitializeGrid();

            ShellServices.LoadRtbText(richTextBox1,
                "SuperGridDemo.Resources.DemoUserEdit.rtf");
        }

        #region InitializeGrid

        /// <summary>
        /// Initializes the default grid
        /// </summary>
        private void InitializeGrid()
        {
            int itemHeight = imageList1.Images[0].Height;

            GridPanel panel = superGridControl1.PrimaryGrid;

            panel.DefaultRowHeight = itemHeight + 8;
            panel.ColumnHeader.Tag = 0;

            // Set the Color, Image, Audio, Process, and FilePath
            // column Edit types our own defined controls

            GridColumn column = panel.Columns["Color Combo"];
            column.EditorType = typeof(GridColorCombo);
            column.EditorParams = new object[] { itemHeight };

            column = panel.Columns["Image Combo"];
            column.EditorType = typeof(GridImageCombo);
            column.EditorParams = new object[] { imageList1, itemHeight };

            column = panel.Columns["Audio Clip"];
            column.EditorType = typeof(MyGridClipEditControl);

            column = panel.Columns["Process State"];
            column.EditorType = typeof(GridStateEditControl);

            column = panel.Columns["File Path"];
            column.EditorType = typeof(GridFilePathEditControl);
            
            // Add 30 rows for the user to play around with

            string[] files = GetInitialFiles(30);

            KnownColor[] values = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            _colors = new Color[values.Length];

            for (int i=0; i<values.Length; i++)
                _colors[i] = Color.FromKnownColor(values[i]);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 30; i++)
            {
                GridRow row = new
                    GridRow(_colors[i % _colors.Length].Name,
                            imageList1.Images.Keys[i % imageList1.Images.Count],
                            _Clips[i % _Clips.Length], GetNewState(sb), files[i]);

                panel.Rows.Add(row);
            }
        }

        #region GetInitialFiles

        /// <summary>
        /// Gets a list of files from the user's system
        /// to initially load into the grid
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        private string[] GetInitialFiles(int count)
        {
            int n = 0;
            string[] files = new string[count];

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Fixed)
                {
                    string[] temp = Directory.GetDirectories(drive.Name);

                    foreach (string dir in temp)
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);

                        if (((di.Attributes & FileAttributes.Hidden) == 0) &&
                            (di.Attributes & FileAttributes.System) == 0)
                        {
                            n = GetFiles(files, dir, n);

                            if (n >= count)
                                break;
                        }
                    }
                    if (n >= count)
                        break;
                }
            }

            for (int i = n; i < count; i++ )
                files[i] = "";

            return (files);
        }

        #region GetFiles

        /// <summary>
        /// Gets a set of files from the users system
        /// to display in the grid
        /// </summary>
        /// <param name="files"></param>
        /// <param name="dir"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private int GetFiles(string[] files, string dir, int n)
        {
            int count = files.Length;

            try
            {
                string[] temp = Directory.GetFiles(dir);

                foreach (string file in temp)
                {
                    FileInfo fi = new FileInfo(file);

                    if ((fi.Attributes & (FileAttributes.Directory |
                        FileAttributes.Hidden | FileAttributes.System)) == 0)
                    {
                        files[n++] = file;

                        if (n >= count)
                            break;
                    }
                }
            }
            catch
            {
            }

            return (n);
        }

        #endregion

        #endregion

        #region GetNewState

        private string GetNewState(StringBuilder sb)
        {
            int n = _Rand.Next(2, 7);

            sb.Length = 0;

            for (int i = 0; i < n; i++)
            {
                sb.Append(_Rand.Next(0, 5));
                sb.Append(",");
            }

            sb.Length--;

            return (sb.ToString());
        }

        #endregion

        #endregion

        #region GridColorCombo

        public class GridColorCombo : GridComboBoxExEditControl
        {
            public GridColorCombo(int itemHeight)
            {
                DisableInternalDrawing = true;
                DropDownStyle = ComboBoxStyle.DropDownList;
                ItemHeight = itemHeight;

                foreach (Color color in _colors)
                    Items.Add(color.Name);

                DrawItem += GridColorComboDrawItem;
            }

            #region CellRender

            public override void CellRender(Graphics g)
            {
                Rectangle r = EditorCell.Bounds;
                r.Height--;
                r.Width--;

                RenderItem(g, r, Color.FromName(Text));
            }

            #endregion

            #region GetProposedSize

            public override Size GetProposedSize(
                Graphics g, GridCell cell, CellVisualStyle style, Size constraintSize)
            {
                Size size = base.GetProposedSize(g, cell, style, constraintSize);

                size.Width += 40;

                return (size);
            }

            #endregion

            #region GridColorComboDrawItem

            void GridColorComboDrawItem(object sender, DrawItemEventArgs e)
            {
                if (e.Index >= 0)
                {
                    e.DrawBackground();

                    RenderItem(e.Graphics, e.Bounds,
                        Color.FromName(_colors[e.Index % _colors.Length].Name));
                }
            }

            #endregion

            #region RenderItem

            private void RenderItem(Graphics g, Rectangle bounds, Color color)
            {
                using (Brush br = new SolidBrush(color))
                {
                    bounds.Width--;
                    bounds.Height--;

                    Rectangle r = bounds;
                    r.Width = 30;
                    r.Inflate(-2, -2);

                    g.FillRectangle(br, r);
                    g.DrawRectangle(Pens.Black, r);

                    r = bounds;
                    r.X += 30;
                    r.Width -= 30;

                    using (StringFormat sf = new StringFormat())
                    {
                        sf.LineAlignment = StringAlignment.Center;

                        g.DrawString(color.Name, Font, Brushes.Black, r, sf);
                    }
                }
            }

            #endregion
        }

        #endregion

        #region GridImageCombo

        public class GridImageCombo : GridComboBoxExEditControl
        {
            private ImageList _ImageList;

            public GridImageCombo(ImageList imageList, int itemHeight)
            {
                _ImageList = imageList;

                DisableInternalDrawing = true;
                DropDownStyle = ComboBoxStyle.DropDownList;
                ItemHeight = itemHeight;

                for (int i = 0; i < imageList.Images.Count; i++)
                    Items.Add(imageList.Images.Keys[i]);

                DrawItem += GridImageComboDrawItem;
            }

            #region CellRender

            public override void CellRender(Graphics g)
            {
                Rectangle r = EditorCell.Bounds;
                r.X += 4;
                r.Width -= 4;

                RenderItem(g, r, Text);
            }

            #endregion

            #region GridImageComboDrawItem

            void GridImageComboDrawItem(object sender, DrawItemEventArgs e)
            {
                if (e.Index >= 0)
                {
                    e.DrawBackground();

                    RenderItem(e.Graphics, e.Bounds,
                        _ImageList.Images.Keys[e.Index]);
                }
            }

            #endregion

            #region RenderItem

            private void RenderItem(Graphics g, Rectangle bounds, string key)
            {
                Image image = _ImageList.Images[key];

                if (image != null)
                {
                    Rectangle r = bounds;
                    r.Size = image.Size;
                    r.X += 2;
                    r.Y += (bounds.Height - r.Height) / 2;

                    g.DrawImageUnscaled(image, r);

                    r = bounds;
                    r.X += image.Width + 2;
                    r.Width -= image.Width + 2;

                    using (StringFormat sf = new StringFormat())
                    {
                        sf.LineAlignment = StringAlignment.Center;

                        g.DrawString(key, Font, Brushes.Black, r, sf);
                    }
                }
            }

            #endregion
        }

        #endregion

        #region MyGridClipEditControl

        public class MyGridClipEditControl : GridClipEditControl
        {
            #region Private variables

            private SoundPlayer _Sp;

            #endregion

            #region ContentDoubleClick

            /// <summary>
            /// Handles user double-clicks
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            protected override void ContentDoubleClick(object sender, EventArgs e)
            {
                // Launch a comboBox
                // to let the user change audio clips.

                LaunchCombo(null);

                base.ContentDoubleClick(sender, e);
            }

            #endregion

            #region BtnPlayClick

            /// <summary>
            /// Handles user "play clip" button clicks
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            protected override void BtnPlayClick(object sender, EventArgs e)
            {
                // Play the audio clip

                if (EditorCell.Value != null)
                {
                    using (Stream stream = (Stream)
                        ShellServices.GetResource("SuperGridDemo.Resources." + EditorCell.Value + ".wav"))
                    {
                        if (stream != null)
                        {
                            if (_Sp == null)
                                _Sp = new SoundPlayer();

                            _Sp.Stream = stream;
                            _Sp.Play();
                        }
                    }
                }

                base.BtnPlayClick(sender, e);
            }

            #endregion

            #region BtnStopClick

            /// <summary>
            /// Handles user "Stop clip" button clicks
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            protected override void BtnStopClick(object sender, EventArgs e)
            {
                // Stop the audio clip

                _Sp.Stop();

                base.BtnStopClick(sender, e);
            }

            #endregion

            #region OnKeyDown

            /// <summary>
            /// Handles user key presses
            /// </summary>
            /// <param name="e"></param>
            protected override void OnKeyDown(KeyEventArgs e)
            {
                // Launch a comboBox
                // to let the user change audio clips.
                
                LaunchCombo(e);

                base.OnKeyDown(e);
            }

            #endregion

            #region LaunchCombo

            /// <summary>
            /// Launches a "clip" comboBox to let the user select the
            /// cell clip.  It does this by temporarily setting the
            /// appropriate cell-level EditorType - and resets it when
            /// editing is complete.
            /// </summary>
            /// <param name="e"></param>
            private void LaunchCombo(KeyEventArgs e)
            {
                // Set a new cell-level EditorType, and initialize
                // the combo dropdown with the available audio clips

                EditorCell.EditorType = typeof(MyGridComboBoxExEditControl);

                GridComboBoxExEditControl cb =
                    EditorCell.EditControl as GridComboBoxExEditControl;

                if (cb != null)
                {
                    cb.DisableInternalDrawing = true;
                    cb.DropDownStyle = ComboBoxStyle.DropDownList;

                    foreach (string clip in _Clips)
                        cb.Items.Add(clip);

                    cb.DrawItem += GridClipControlDrawItem;
                }

                // Deactivate the current active editor, and initiate
                // an edit session on the newly set modal combo editor.

                EditorCell.SuperGrid.DeactivateNonModalEditor();
                EditorCell.BeginEdit(true, e);
            }

            #endregion

            #region CellRender

            /// <summary>
            /// Handles our user drawn rendering of the cell.
            /// </summary>
            /// <param name="g"></param>
            public override void CellRender(Graphics g)
            {
                // Nudge our text over a little so it more closely
                // aligns with the ComboBox text (when active)

                Rectangle r = EditorCell.Bounds;
                r.X += 4;
                r.Width -= 4;

                // Render the item

                RenderItem(g, r, Text);
            }

            #endregion

            #region GridClipControlDrawItem

            /// <summary>
            /// Handles ComboBox item draw requests
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void GridClipControlDrawItem(object sender, DrawItemEventArgs e)
            {
                if (e.Index >= 0)
                {
                    e.DrawBackground();

                    ComboBoxEx cbx = sender as ComboBoxEx;

                    if (cbx != null)
                        RenderItem(e.Graphics, e.Bounds, _Clips[e.Index % _Clips.Length]);
                }
            }

            #endregion

            #region RenderItem

            /// <summary>
            /// Renders the given item
            /// </summary>
            /// <param name="g"></param>
            /// <param name="bounds"></param>
            /// <param name="text"></param>
            private void RenderItem(Graphics g, Rectangle bounds, string text)
            {
                CellVisualStyle style = EditorCell.GetEffectiveStyle();

                using (StringFormat sf = new StringFormat())
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;

                    sf.LineAlignment = StringAlignment.Center;

                    using (Brush br = new SolidBrush(style.TextColor))
                        g.DrawString(text, style.Font, br, bounds, sf);
                }
            }

            #endregion
        }

        #endregion

        #region MyGridComboBoxExEditControl

        /// <summary>
        /// My special GridComboBoxExEditControl that does nothing more
        /// than receive notification when the combo edit session has
        /// completed, so that it can reset the cell-level EditorType
        /// back to its default null state.
        /// </summary>
        public class MyGridComboBoxExEditControl : GridComboBoxExEditControl
        {
            #region CancelEdit

            /// <summary>
            /// Handles used edit cancels
            /// </summary>
            /// <returns></returns>
            public override bool CancelEdit()
            {
                ResetEdit();

                return (base.CancelEdit());
            }

            #endregion

            #region EndEdit

            /// <summary>
            /// Handles user end edits
            /// </summary>
            /// <returns></returns>
            public override bool EndEdit()
            {
                ResetEdit();

                return (base.EndEdit());
            }

            #endregion

            #region ResetEdit

            /// <summary>
            /// Reset the cell-level EditorType back to
            /// its null state (column setting will then be used)
            /// </summary>
            private void ResetEdit()
            {
                EditorCell.EditorType = null;
            }

            #endregion
        }

        #endregion

        #region SuperGridControl1ColumnHeaderClick

        /// <summary>
        /// This routine shows a simple example of processing
        /// the MouseClick in the style defined header image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControl1ColumnHeaderClick(
            object sender, GridColumnHeaderClickEventArgs e)
        {
            GridColumnHeader header = e.GridPanel.ColumnHeader;
            Rectangle r = header.GetImageBounds(e.GridColumn);

            Point pt = MousePosition;
            pt = e.GridColumn.SuperGrid.PointToClient(pt);

            // If the user clicked in the header image, then instead
            // of sorting the column, let's redefine every cell in the
            // column to contain a visible state pattern.

            if (r.Contains(pt) == true)
            {
                int k = (int) header.Tag;
                header.Tag = ++k;

                for (int i = 0; i < e.GridPanel.Rows.Count; i++)
                {
                    GridRow row = e.GridPanel.Rows[i] as GridRow;

                    if (row != null)
                    {
                        int n = (k + i) % 8;

                        if ((k + i) % 16 >= 8)
                            n = 8 - n;

                        row.Cells[3].Value = "0,1,2,3,4,3,2,1,0".Substring(n << 1);
                    }
                }

                e.Cancel = true;
            }
        }

        #endregion

        #region SuperGridControl1MouseMove

        /// <summary>
        /// Gives column 3 (Process State) some extra feedback 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuperGridControl1MouseMove(object sender, MouseEventArgs e)
        {
            SuperGridControl sg = sender as SuperGridControl;

            if (sg != null)
            {
                GridColumnHeader header =
                    sg.GetElementAt(e.Location) as GridColumnHeader;

                if (header != null)
                {
                    Point pt = header.SuperGrid.PointToClient(MousePosition);
                    GridColumn column = header.GetHitColumn(pt);

                    if (column != null && column.ColumnIndex == 3)
                    {
                        Rectangle r = header.GetImageBounds(column);

                        if (r.Contains(pt) == true)
                        {
                            if (column.HeaderStyles.MouseOver.ImageIndex < 0)
                                column.HeaderStyles.MouseOver.ImageIndex = 7;
                        }
                        else
                        {
                            if (column.HeaderStyles.MouseOver.ImageIndex >= 0)
                                column.HeaderStyles.MouseOver.ImageIndex = -1;
                        }
                    }
                }
            }
        }

        #endregion
    }
}