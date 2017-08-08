namespace SuperGridDemo
{
    partial class DemoGridBasics4
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
            this.components = new System.ComponentModel.Container();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoGridBasics4));
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding1 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding2 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding3 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding4 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding5 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            this.richTextBox1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.cbxProgressBugs = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxGridLines = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cbxHLinePattern = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbxVLinePattern = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.superGridControl1 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColorRichTextBox = System.Drawing.Color.White;
            // 
            // 
            // 
            this.richTextBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBox1.Location = new System.Drawing.Point(4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(780, 113);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.TabStop = false;
            // 
            // cbxProgressBugs
            // 
            this.cbxProgressBugs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxProgressBugs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxProgressBugs.Location = new System.Drawing.Point(32, 576);
            this.cbxProgressBugs.Name = "cbxProgressBugs";
            this.cbxProgressBugs.Size = new System.Drawing.Size(133, 23);
            this.cbxProgressBugs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxProgressBugs.TabIndex = 7;
            this.cbxProgressBugs.Text = "Show Progress Bugs";
            this.cbxProgressBugs.CheckedChanged += new System.EventHandler(this.CbxProgressBugsCheckedChanged);
            // 
            // cbxGridLines
            // 
            this.cbxGridLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxGridLines.DisplayMember = "Text";
            this.cbxGridLines.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxGridLines.FormattingEnabled = true;
            this.cbxGridLines.ItemHeight = 14;
            this.cbxGridLines.Location = new System.Drawing.Point(344, 580);
            this.cbxGridLines.Name = "cbxGridLines";
            this.cbxGridLines.Size = new System.Drawing.Size(137, 20);
            this.cbxGridLines.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxGridLines.TabIndex = 8;
            this.cbxGridLines.SelectedIndexChanged += new System.EventHandler(this.CbxGridLinesSelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(266, 578);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(72, 23);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "Grid Lines:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(487, 577);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(121, 23);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "Horizontal Line Pattern:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cbxHLinePattern
            // 
            this.cbxHLinePattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxHLinePattern.DisplayMember = "Text";
            this.cbxHLinePattern.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxHLinePattern.FormattingEnabled = true;
            this.cbxHLinePattern.ItemHeight = 14;
            this.cbxHLinePattern.Location = new System.Drawing.Point(614, 579);
            this.cbxHLinePattern.Name = "cbxHLinePattern";
            this.cbxHLinePattern.Size = new System.Drawing.Size(137, 20);
            this.cbxHLinePattern.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxHLinePattern.TabIndex = 10;
            this.cbxHLinePattern.SelectedIndexChanged += new System.EventHandler(this.CbxHLinePatternSelectedIndexChanged);
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(487, 603);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(121, 23);
            this.labelX3.TabIndex = 13;
            this.labelX3.Text = "Vertical Line Pattern:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cbxVLinePattern
            // 
            this.cbxVLinePattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxVLinePattern.DisplayMember = "Text";
            this.cbxVLinePattern.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxVLinePattern.FormattingEnabled = true;
            this.cbxVLinePattern.ItemHeight = 14;
            this.cbxVLinePattern.Location = new System.Drawing.Point(614, 605);
            this.cbxVLinePattern.Name = "cbxVLinePattern";
            this.cbxVLinePattern.Size = new System.Drawing.Size(137, 20);
            this.cbxVLinePattern.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxVLinePattern.TabIndex = 12;
            this.cbxVLinePattern.SelectedIndexChanged += new System.EventHandler(this.CbxVLinePatternSelectedIndexChanged);
            // 
            // superGridControl1
            // 
            this.superGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.Location = new System.Drawing.Point(0, 123);
            this.superGridControl1.Name = "superGridControl1";
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridProgressBarXEditControl);
            gridColumn1.HeaderStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            gridColumn1.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gridColumn1.Name = "ProgressBar";
            gridColumn1.Width = 200;
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridSliderEditControl);
            gridColumn2.HeaderStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            gridColumn2.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.BottomCenter;
            padding1.Bottom = 10;
            padding1.Top = -10;
            gridColumn2.HeaderStyles.Default.ImagePadding = padding1;
            padding2.Top = 10;
            gridColumn2.HeaderStyles.Default.Margin = padding2;
            gridColumn2.Name = "Slider";
            gridColumn2.Width = 150;
            padding3.Bottom = 2;
            padding3.Left = 2;
            padding3.Right = 2;
            padding3.Top = 2;
            gridColumn3.CellStyles.Default.Margin = padding3;
            gridColumn3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridSwitchButtonEditControl);
            gridColumn3.HeaderStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            gridColumn3.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.TopCenter;
            padding4.Bottom = -6;
            padding4.Top = 10;
            gridColumn3.HeaderStyles.Default.ImagePadding = padding4;
            gridColumn3.Name = "SwitchButton";
            gridColumn3.Width = 150;
            gridColumn4.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            gridColumn4.HeaderStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            gridColumn4.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.BottomCenter;
            gridColumn4.Name = "CheckBoxX";
            gridColumn4.Width = 150;
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn1);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn2);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn3);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn4);
            this.superGridControl1.PrimaryGrid.DefaultRowHeight = 0;
            padding5.Bottom = 4;
            padding5.Left = 4;
            padding5.Right = 4;
            padding5.Top = 4;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.Margin = padding5;
            this.superGridControl1.PrimaryGrid.FilterExpr = null;
            this.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.superGridControl1.Size = new System.Drawing.Size(784, 439);
            this.superGridControl1.TabIndex = 0;
            this.superGridControl1.Text = "superGridControl1";
            this.superGridControl1.PostRenderCell += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridPostRenderCellEventArgs>(this.SuperGridControl1PostRenderCell);
            this.superGridControl1.GetRenderer += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridGetRendererEventArgs>(this.SuperGridControl1GetRenderer);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // DemoGridBasics4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 632);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.cbxVLinePattern);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cbxHLinePattern);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cbxGridLines);
            this.Controls.Add(this.cbxProgressBugs);
            this.Controls.Add(this.superGridControl1);
            this.Controls.Add(this.richTextBox1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "DemoGridBasics4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperGrid Demo - ProgressBar, Slider, SwitchButton, and CheckBox Control Types";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBox1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxProgressBugs;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxGridLines;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxHLinePattern;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbxVLinePattern;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}