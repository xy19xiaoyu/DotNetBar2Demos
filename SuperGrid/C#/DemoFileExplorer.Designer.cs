namespace SuperGridDemo
{
    partial class DemoFileExplorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevComponents.DotNetBar.SuperGrid.Style.Background background1 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Background background2 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding1 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Background background3 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding2 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding3 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding4 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding5 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Background background4 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Background background5 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Background background6 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Background background7 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Background background8 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding6 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding7 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Background background9 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            this.richTextBox1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.CbxGroupItems = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.superGridControl2 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.superGridControl1 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.richTextBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBox1.Location = new System.Drawing.Point(4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(780, 113);
            this.richTextBox1.TabIndex = 4;
            // 
            // CbxGroupItems
            // 
            this.CbxGroupItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.CbxGroupItems.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CbxGroupItems.Location = new System.Drawing.Point(624, 531);
            this.CbxGroupItems.Name = "CbxGroupItems";
            this.CbxGroupItems.Size = new System.Drawing.Size(147, 23);
            this.CbxGroupItems.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxGroupItems.TabIndex = 9;
            this.CbxGroupItems.Text = "Group Items by Type";
            this.CbxGroupItems.CheckedChanged += new System.EventHandler(this.CbxGroupItemsCheckedChanged);
            // 
            // superGridControl2
            // 
            this.superGridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            background1.Color1 = System.Drawing.Color.White;
            this.superGridControl2.DefaultVisualStyles.GridPanelStyle.Background = background1;
            background2.Color1 = System.Drawing.Color.White;
            this.superGridControl2.DefaultVisualStyles.GroupHeaderStyles.Default.Background = background2;
            this.superGridControl2.DefaultVisualStyles.GroupHeaderStyles.Default.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            padding1.Left = 20;
            this.superGridControl2.DefaultVisualStyles.GroupHeaderStyles.Default.Padding = padding1;
            background3.Color1 = System.Drawing.Color.White;
            this.superGridControl2.DefaultVisualStyles.GroupHeaderStyles.MouseOver.Background = background3;
            this.superGridControl2.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl2.Location = new System.Drawing.Point(274, 123);
            this.superGridControl2.Name = "superGridControl2";
            this.superGridControl2.PrimaryGrid.ColumnHeader.SortImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            gridColumn1.CellHighlightMode = DevComponents.DotNetBar.SuperGrid.Style.CellHighlightMode.Content;
            gridColumn1.CellStyles.Default.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridColumn1.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.Multiple;
            gridColumn1.Name = "Name";
            gridColumn1.Width = 200;
            gridColumn2.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            padding2.Left = 2;
            padding2.Right = 2;
            gridColumn2.CellStyles.Default.Margin = padding2;
            gridColumn2.CellStyles.Default.TextColor = System.Drawing.Color.Gray;
            gridColumn2.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.Multiple;
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            gridColumn2.Name = "Size";
            padding3.Left = 2;
            padding3.Right = 2;
            gridColumn3.CellStyles.Default.Margin = padding3;
            gridColumn3.CellStyles.Default.TextColor = System.Drawing.Color.Gray;
            gridColumn3.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.Multiple;
            gridColumn3.Name = "Type";
            gridColumn4.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            padding4.Left = 2;
            padding4.Right = 2;
            gridColumn4.CellStyles.Default.Margin = padding4;
            gridColumn4.CellStyles.Default.TextColor = System.Drawing.Color.Gray;
            gridColumn4.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.Multiple;
            gridColumn4.Name = "Date Created";
            gridColumn5.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            padding5.Left = 2;
            padding5.Right = 2;
            gridColumn5.CellStyles.Default.Margin = padding5;
            gridColumn5.CellStyles.Default.TextColor = System.Drawing.Color.Gray;
            gridColumn5.ColumnSortMode = DevComponents.DotNetBar.SuperGrid.ColumnSortMode.Multiple;
            gridColumn5.Name = "Date Modified";
            this.superGridControl2.PrimaryGrid.Columns.Add(gridColumn1);
            this.superGridControl2.PrimaryGrid.Columns.Add(gridColumn2);
            this.superGridControl2.PrimaryGrid.Columns.Add(gridColumn3);
            this.superGridControl2.PrimaryGrid.Columns.Add(gridColumn4);
            this.superGridControl2.PrimaryGrid.Columns.Add(gridColumn5);
            background4.Color1 = System.Drawing.Color.AliceBlue;
            background4.Color2 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.superGridControl2.PrimaryGrid.DefaultVisualStyles.CellStyles.MouseOver.Background = background4;
            background5.Color1 = System.Drawing.Color.WhiteSmoke;
            this.superGridControl2.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.Background = background5;
            this.superGridControl2.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superGridControl2.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.TextColor = System.Drawing.Color.DimGray;
            background6.Color1 = System.Drawing.Color.White;
            this.superGridControl2.PrimaryGrid.DefaultVisualStyles.GroupHeaderStyles.Default.Background = background6;
            background7.Color1 = System.Drawing.Color.White;
            this.superGridControl2.PrimaryGrid.DefaultVisualStyles.GroupHeaderStyles.MouseOver.Background = background7;
            this.superGridControl2.PrimaryGrid.FilterExpr = null;
            this.superGridControl2.PrimaryGrid.GridLines = DevComponents.DotNetBar.SuperGrid.GridLines.None;
            this.superGridControl2.PrimaryGrid.ImmediateResize = true;
            this.superGridControl2.PrimaryGrid.IndentGroups = false;
            this.superGridControl2.PrimaryGrid.InitialActiveRow = DevComponents.DotNetBar.SuperGrid.RelativeRow.None;
            this.superGridControl2.PrimaryGrid.InitialSelection = DevComponents.DotNetBar.SuperGrid.RelativeSelection.None;
            this.superGridControl2.PrimaryGrid.PrimaryColumnIndex = 2;
            this.superGridControl2.PrimaryGrid.ShowGroupExpand = false;
            this.superGridControl2.PrimaryGrid.ShowRowHeaders = false;
            this.superGridControl2.PrimaryGrid.SortLevel = ((DevComponents.DotNetBar.SuperGrid.SortLevel)((DevComponents.DotNetBar.SuperGrid.SortLevel.Root | DevComponents.DotNetBar.SuperGrid.SortLevel.Expanded)));
            this.superGridControl2.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.superGridControl2.Size = new System.Drawing.Size(510, 398);
            this.superGridControl2.TabIndex = 6;
            this.superGridControl2.Text = "superGridControl2";
            this.superGridControl2.BeginEdit += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridEditEventArgs>(this.SuperGridControl2BeginEdit);
            this.superGridControl2.RowsGrouped += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridEventArgs>(this.SuperGridControl2RowsGrouped);
            this.superGridControl2.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.SuperGridControl2CellDoubleClick);
            this.superGridControl2.GetCellFormattedValue += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridGetCellFormattedValueEventArgs>(this.SuperGridControl2GetCellFormattedValue);
            // 
            // superGridControl1
            // 
            this.superGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            background8.Color1 = System.Drawing.Color.White;
            this.superGridControl1.DefaultVisualStyles.GridPanelStyle.Background = background8;
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.Location = new System.Drawing.Point(0, 123);
            this.superGridControl1.Name = "superGridControl1";
            this.superGridControl1.PrimaryGrid.ColumnHeader.Visible = false;
            gridColumn6.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn6.CellHighlightMode = DevComponents.DotNetBar.SuperGrid.Style.CellHighlightMode.Content;
            padding6.Right = 4;
            gridColumn6.CellStyles.Default.ImagePadding = padding6;
            padding7.Bottom = 1;
            padding7.Top = 1;
            gridColumn6.CellStyles.Default.Margin = padding7;
            background9.BackFillType = DevComponents.DotNetBar.SuperGrid.Style.BackFillType.VerticalCenter;
            background9.Color1 = System.Drawing.Color.AliceBlue;
            background9.Color2 = System.Drawing.SystemColors.GradientInactiveCaption;
            gridColumn6.CellStyles.MouseOver.Background = background9;
            gridColumn6.Name = "Column1";
            gridColumn6.ReadOnly = true;
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn6);
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.TreeLineColor = System.Drawing.Color.Gray;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.TreeLinePattern = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.Dot;
            this.superGridControl1.PrimaryGrid.FilterExpr = null;
            this.superGridControl1.PrimaryGrid.RowDoubleClickBehavior = DevComponents.DotNetBar.SuperGrid.RowDoubleClickBehavior.ExpandCollapse;
            this.superGridControl1.PrimaryGrid.ShowColumnHeader = false;
            this.superGridControl1.PrimaryGrid.ShowRowHeaders = false;
            this.superGridControl1.PrimaryGrid.ShowTreeButtons = true;
            this.superGridControl1.PrimaryGrid.ShowTreeLines = true;
            this.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.superGridControl1.Size = new System.Drawing.Size(268, 434);
            this.superGridControl1.TabIndex = 5;
            this.superGridControl1.Text = "superGridControl1";
            this.superGridControl1.BeforeExpand += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridBeforeExpandEventArgs>(this.SuperGridControl1BeforeExpand);
            this.superGridControl1.SelectionChanged += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridEventArgs>(this.SuperGridControl1SelectionChanged);
            // 
            // DemoFileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.CbxGroupItems);
            this.Controls.Add(this.superGridControl2);
            this.Controls.Add(this.superGridControl1);
            this.Controls.Add(this.richTextBox1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "DemoFileExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperGrid Demo - Sample File Explorer";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBox1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl2;
        private DevComponents.DotNetBar.Controls.CheckBoxX CbxGroupItems;
    }
}