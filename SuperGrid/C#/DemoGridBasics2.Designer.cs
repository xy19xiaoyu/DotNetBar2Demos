namespace SuperGridDemo
{
    partial class DemoGridBasics2
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
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding1 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoGridBasics2));
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding2 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding3 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Background background1 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.BackColorBlend backColorBlend1 = new DevComponents.DotNetBar.SuperGrid.Style.BackColorBlend();
            DevComponents.DotNetBar.SuperGrid.Style.BorderPattern borderPattern1 = new DevComponents.DotNetBar.SuperGrid.Style.BorderPattern();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding4 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding5 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            this.richTextBox1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.cbxAltRowStyle = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxAltColStyle = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxTreeButtons = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxHeaderImages = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnExpandAll = new DevComponents.DotNetBar.ButtonX();
            this.btnCollapseAll = new DevComponents.DotNetBar.ButtonX();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
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
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.TabStop = false;
            // 
            // cbxAltRowStyle
            // 
            this.cbxAltRowStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxAltRowStyle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxAltRowStyle.Location = new System.Drawing.Point(193, 555);
            this.cbxAltRowStyle.Name = "cbxAltRowStyle";
            this.cbxAltRowStyle.Size = new System.Drawing.Size(160, 23);
            this.cbxAltRowStyle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxAltRowStyle.TabIndex = 3;
            this.cbxAltRowStyle.Text = "Use Alternate Row Style";
            this.cbxAltRowStyle.CheckedChanged += new System.EventHandler(this.CbxAltRowStyleCheckedChanged);
            // 
            // cbxAltColStyle
            // 
            this.cbxAltColStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxAltColStyle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxAltColStyle.Location = new System.Drawing.Point(193, 583);
            this.cbxAltColStyle.Name = "cbxAltColStyle";
            this.cbxAltColStyle.Size = new System.Drawing.Size(160, 23);
            this.cbxAltColStyle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxAltColStyle.TabIndex = 4;
            this.cbxAltColStyle.Text = "Use Alternate Column Style";
            this.cbxAltColStyle.CheckedChanged += new System.EventHandler(this.CbxAltColStyleCheckedChanged);
            // 
            // cbxTreeButtons
            // 
            this.cbxTreeButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxTreeButtons.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxTreeButtons.Location = new System.Drawing.Point(14, 555);
            this.cbxTreeButtons.Name = "cbxTreeButtons";
            this.cbxTreeButtons.Size = new System.Drawing.Size(173, 23);
            this.cbxTreeButtons.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxTreeButtons.TabIndex = 1;
            this.cbxTreeButtons.Text = "Set Tree Buttons";
            this.cbxTreeButtons.CheckedChanged += new System.EventHandler(this.CbxTreeButtonsCheckedChanged);
            // 
            // cbxHeaderImages
            // 
            this.cbxHeaderImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxHeaderImages.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxHeaderImages.Location = new System.Drawing.Point(14, 583);
            this.cbxHeaderImages.Name = "cbxHeaderImages";
            this.cbxHeaderImages.Size = new System.Drawing.Size(173, 23);
            this.cbxHeaderImages.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxHeaderImages.TabIndex = 2;
            this.cbxHeaderImages.Text = "Show Column Header Images";
            this.cbxHeaderImages.CheckedChanged += new System.EventHandler(this.CbxHeaderImagesCheckedChanged);
            // 
            // btnExpandAll
            // 
            this.btnExpandAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExpandAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExpandAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExpandAll.Location = new System.Drawing.Point(620, 561);
            this.btnExpandAll.Name = "btnExpandAll";
            this.btnExpandAll.Size = new System.Drawing.Size(152, 20);
            this.btnExpandAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExpandAll.TabIndex = 7;
            this.btnExpandAll.Text = "Expand All Rows";
            this.btnExpandAll.Click += new System.EventHandler(this.BtnExpandAllClick);
            // 
            // btnCollapseAll
            // 
            this.btnCollapseAll.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCollapseAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCollapseAll.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCollapseAll.Location = new System.Drawing.Point(620, 587);
            this.btnCollapseAll.Name = "btnCollapseAll";
            this.btnCollapseAll.Size = new System.Drawing.Size(152, 20);
            this.btnCollapseAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCollapseAll.TabIndex = 8;
            this.btnCollapseAll.Text = "Collapse All Rows";
            this.btnCollapseAll.Click += new System.EventHandler(this.BtnCollapseAllClick);
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Location = new System.Drawing.Point(414, 584);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(106, 20);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 6;
            this.comboBoxEx1.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEx1SelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(414, 562);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(96, 19);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Sort Level";
            // 
            // superGridControl1
            // 
            this.superGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            padding1.Bottom = 2;
            padding1.Left = 2;
            padding1.Right = 2;
            padding1.Top = 2;
            this.superGridControl1.DefaultVisualStyles.CellStyles.Default.Margin = padding1;
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.Location = new System.Drawing.Point(0, 123);
            this.superGridControl1.Name = "superGridControl1";
            this.superGridControl1.PrimaryGrid.Caption.Text = "Numeric related Input Cell Editors";
            this.superGridControl1.PrimaryGrid.ColumnHeader.ShowHeaderImages = false;
            gridColumn1.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn1.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft;
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn1.FillWeight = 140;
            gridColumn1.HeaderStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            gridColumn1.Name = "DateTimeInput";
            gridColumn2.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn2.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimePickerEditControl);
            gridColumn2.FillWeight = 170;
            gridColumn2.HeaderStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            gridColumn2.Name = "DateTimePicker";
            gridColumn3.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn3.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            gridColumn3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridNumericUpDownEditControl);
            gridColumn3.FillWeight = 130;
            gridColumn3.HeaderStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            gridColumn3.Name = "NumericUpDown";
            gridColumn4.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn4.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl);
            gridColumn4.HeaderStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            gridColumn4.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.BottomCenter;
            padding2.Bottom = 8;
            padding2.Left = 4;
            padding2.Right = 4;
            padding2.Top = 4;
            gridColumn4.HeaderStyles.Default.ImagePadding = padding2;
            gridColumn4.Name = "IntegerInput";
            gridColumn5.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn5.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight;
            gridColumn5.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl);
            gridColumn5.HeaderStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            padding3.Bottom = 8;
            padding3.Left = 4;
            padding3.Right = 4;
            padding3.Top = 4;
            gridColumn5.HeaderStyles.Default.ImagePadding = padding3;
            gridColumn5.Name = "DoubleInput";
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn1);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn2);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn3);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn4);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn5);
            this.superGridControl1.PrimaryGrid.DefaultRowHeight = 30;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.False;
            backColorBlend1.Colors = new System.Drawing.Color[] {
        System.Drawing.Color.SkyBlue,
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.Aqua};
            background1.BackColorBlend = backColorBlend1;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Background = background1;
            borderPattern1.Bottom = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.DashDotDot;
            borderPattern1.Left = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.DashDotDot;
            borderPattern1.Right = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.DashDotDot;
            borderPattern1.Top = DevComponents.DotNetBar.SuperGrid.Style.LinePattern.DashDotDot;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.BorderPattern = borderPattern1;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            padding4.Bottom = 6;
            padding4.Left = 6;
            padding4.Right = 6;
            padding4.Top = 6;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Margin = padding4;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.TextColor = System.Drawing.Color.White;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.BottomCenter;
            padding5.Bottom = 4;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.ImagePadding = padding5;
            this.superGridControl1.PrimaryGrid.FilterExpr = null;
            this.superGridControl1.PrimaryGrid.RowHeaderWidth = 50;
            this.superGridControl1.PrimaryGrid.ShowRowGridIndex = true;
            this.superGridControl1.PrimaryGrid.ShowTreeButtons = true;
            this.superGridControl1.PrimaryGrid.ShowTreeLines = true;
            this.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.superGridControl1.Size = new System.Drawing.Size(784, 422);
            this.superGridControl1.TabIndex = 0;
            this.superGridControl1.Text = "superGridControl1";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // DemoGridBasics2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 621);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.comboBoxEx1);
            this.Controls.Add(this.btnCollapseAll);
            this.Controls.Add(this.btnExpandAll);
            this.Controls.Add(this.cbxHeaderImages);
            this.Controls.Add(this.cbxTreeButtons);
            this.Controls.Add(this.cbxAltColStyle);
            this.Controls.Add(this.cbxAltRowStyle);
            this.Controls.Add(this.superGridControl1);
            this.Controls.Add(this.richTextBox1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "DemoGridBasics2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperGrid Demo - Numeric Related Control Types";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBox1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxAltRowStyle;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxAltColStyle;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxTreeButtons;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxHeaderImages;
        private DevComponents.DotNetBar.ButtonX btnExpandAll;
        private DevComponents.DotNetBar.ButtonX btnCollapseAll;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}