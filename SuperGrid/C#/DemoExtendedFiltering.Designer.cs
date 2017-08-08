using DevComponents.DotNetBar.Controls;

namespace SuperGridDemo
{
    partial class DemoExtendedFiltering
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoExtendedFiltering));
            this.richTextBox1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cbFilterLevel = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbFilterImageVisibility = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbxUseAgeSlider = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxShowPanelExpr = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbFilterAlignment = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbMatchType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnResetColumnFilters = new DevComponents.DotNetBar.ButtonX();
            this.btnResetPanelFilter = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.superGridControl1 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
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
            this.richTextBox1.TabIndex = 2;
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(566, 528);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(94, 19);
            this.labelX4.TabIndex = 18;
            this.labelX4.Text = "Filter Match Type:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(309, 502);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(120, 19);
            this.labelX3.TabIndex = 17;
            this.labelX3.Text = "Filter Image Visibility:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(309, 528);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(120, 19);
            this.labelX1.TabIndex = 16;
            this.labelX1.Text = "Filter Image Alignment:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(590, 502);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(70, 19);
            this.labelX2.TabIndex = 14;
            this.labelX2.Text = "Filter Level:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cbFilterLevel
            // 
            this.cbFilterLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFilterLevel.DisplayMember = "Text";
            this.cbFilterLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterLevel.FormattingEnabled = true;
            this.cbFilterLevel.ItemHeight = 14;
            this.cbFilterLevel.Location = new System.Drawing.Point(666, 501);
            this.cbFilterLevel.Name = "cbFilterLevel";
            this.cbFilterLevel.Size = new System.Drawing.Size(106, 20);
            this.cbFilterLevel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbFilterLevel.TabIndex = 15;
            this.cbFilterLevel.SelectedIndexChanged += new System.EventHandler(this.CbFilterLevelSelectedIndexChanged);
            // 
            // cbFilterImageVisibility
            // 
            this.cbFilterImageVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFilterImageVisibility.DisplayMember = "Text";
            this.cbFilterImageVisibility.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterImageVisibility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterImageVisibility.FormattingEnabled = true;
            this.cbFilterImageVisibility.ItemHeight = 14;
            this.cbFilterImageVisibility.Location = new System.Drawing.Point(435, 501);
            this.cbFilterImageVisibility.Name = "cbFilterImageVisibility";
            this.cbFilterImageVisibility.Size = new System.Drawing.Size(106, 20);
            this.cbFilterImageVisibility.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbFilterImageVisibility.TabIndex = 13;
            this.cbFilterImageVisibility.SelectedIndexChanged += new System.EventHandler(this.CbFilterImageVisibilitySelectedIndexChanged);
            // 
            // cbxUseAgeSlider
            // 
            this.cbxUseAgeSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxUseAgeSlider.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxUseAgeSlider.Location = new System.Drawing.Point(151, 526);
            this.cbxUseAgeSlider.Name = "cbxUseAgeSlider";
            this.cbxUseAgeSlider.Size = new System.Drawing.Size(152, 23);
            this.cbxUseAgeSlider.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxUseAgeSlider.TabIndex = 12;
            this.cbxUseAgeSlider.Text = "Use Slider for Age Filter";
            this.cbxUseAgeSlider.CheckedChanged += new System.EventHandler(this.CbxUseAgeSliderCheckedChanged);
            // 
            // cbxShowPanelExpr
            // 
            this.cbxShowPanelExpr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.cbxShowPanelExpr.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxShowPanelExpr.Location = new System.Drawing.Point(151, 500);
            this.cbxShowPanelExpr.Name = "cbxShowPanelExpr";
            this.cbxShowPanelExpr.Size = new System.Drawing.Size(152, 23);
            this.cbxShowPanelExpr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxShowPanelExpr.TabIndex = 11;
            this.cbxShowPanelExpr.Text = "Show Filter Expression";
            this.cbxShowPanelExpr.CheckedChanged += new System.EventHandler(this.CbxShowPanelExprCheckedChanged);
            // 
            // cbFilterAlignment
            // 
            this.cbFilterAlignment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFilterAlignment.DisplayMember = "Text";
            this.cbFilterAlignment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterAlignment.FormattingEnabled = true;
            this.cbFilterAlignment.ItemHeight = 14;
            this.cbFilterAlignment.Location = new System.Drawing.Point(435, 527);
            this.cbFilterAlignment.Name = "cbFilterAlignment";
            this.cbFilterAlignment.Size = new System.Drawing.Size(106, 20);
            this.cbFilterAlignment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbFilterAlignment.TabIndex = 10;
            this.cbFilterAlignment.SelectedIndexChanged += new System.EventHandler(this.CbFilterAlignmentSelectedIndexChanged);
            // 
            // cbMatchType
            // 
            this.cbMatchType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMatchType.DisplayMember = "Text";
            this.cbMatchType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMatchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMatchType.FormattingEnabled = true;
            this.cbMatchType.ItemHeight = 14;
            this.cbMatchType.Location = new System.Drawing.Point(666, 527);
            this.cbMatchType.Name = "cbMatchType";
            this.cbMatchType.Size = new System.Drawing.Size(106, 20);
            this.cbMatchType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMatchType.TabIndex = 7;
            this.cbMatchType.SelectedIndexChanged += new System.EventHandler(this.CbMatchTypeSelectedIndexChanged);
            // 
            // btnResetColumnFilters
            // 
            this.btnResetColumnFilters.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnResetColumnFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetColumnFilters.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnResetColumnFilters.Location = new System.Drawing.Point(18, 527);
            this.btnResetColumnFilters.Name = "btnResetColumnFilters";
            this.btnResetColumnFilters.Size = new System.Drawing.Size(113, 23);
            this.btnResetColumnFilters.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnResetColumnFilters.TabIndex = 5;
            this.btnResetColumnFilters.Text = "Reset column filters";
            this.btnResetColumnFilters.Click += new System.EventHandler(this.BtnResetColumnFiltersClick);
            // 
            // btnResetPanelFilter
            // 
            this.btnResetPanelFilter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnResetPanelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetPanelFilter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnResetPanelFilter.Location = new System.Drawing.Point(18, 498);
            this.btnResetPanelFilter.Name = "btnResetPanelFilter";
            this.btnResetPanelFilter.Size = new System.Drawing.Size(113, 23);
            this.btnResetPanelFilter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnResetPanelFilter.TabIndex = 4;
            this.btnResetPanelFilter.Text = "Reset panel filter";
            this.btnResetPanelFilter.Click += new System.EventHandler(this.BtnResetPanelFilterClick);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // superGridControl1
            // 
            this.superGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.superGridControl1.BackColor = System.Drawing.Color.White;
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.FilterUseExtendedCustomDialog = true;
            this.superGridControl1.ForeColor = System.Drawing.Color.Black;
            this.superGridControl1.Location = new System.Drawing.Point(0, 123);
            this.superGridControl1.Name = "superGridControl1";
            this.superGridControl1.PrimaryGrid.AllowRowHeaderResize = true;
            this.superGridControl1.PrimaryGrid.AllowRowResize = true;
            this.superGridControl1.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn1.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft;
            gridColumn1.Name = "Index";
            gridColumn2.Name = "LastName";
            gridColumn3.Name = "FirstName";
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridIntegerInputEditControl);
            gridColumn4.Name = "Age";
            gridColumn5.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimePickerEditControl);
            gridColumn5.Name = "HireDate";
            gridColumn6.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            gridColumn6.Name = "Citizen";
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn1);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn2);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn3);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn4);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn5);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn6);
            this.superGridControl1.PrimaryGrid.DefaultRowHeight = 24;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.superGridControl1.PrimaryGrid.EnableColumnFiltering = true;
            this.superGridControl1.PrimaryGrid.EnableFiltering = true;
            this.superGridControl1.PrimaryGrid.EnableRowFiltering = true;
            this.superGridControl1.PrimaryGrid.Filter.Visible = true;
            this.superGridControl1.PrimaryGrid.NullString = "<<null>>";
            this.superGridControl1.PrimaryGrid.RowHeaderWidth = 45;
            this.superGridControl1.PrimaryGrid.ShowRowGridIndex = true;
            this.superGridControl1.PrimaryGrid.ShowTreeButtons = true;
            this.superGridControl1.PrimaryGrid.ShowTreeLines = true;
            this.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.superGridControl1.Size = new System.Drawing.Size(784, 363);
            this.superGridControl1.TabIndex = 0;
            this.superGridControl1.Text = "superGridControl1";
            // 
            // DemoExtendedFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cbFilterLevel);
            this.Controls.Add(this.cbFilterImageVisibility);
            this.Controls.Add(this.cbxUseAgeSlider);
            this.Controls.Add(this.cbxShowPanelExpr);
            this.Controls.Add(this.cbFilterAlignment);
            this.Controls.Add(this.cbMatchType);
            this.Controls.Add(this.btnResetColumnFilters);
            this.Controls.Add(this.btnResetPanelFilter);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.superGridControl1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(565, 315);
            this.Name = "DemoExtendedFiltering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperGrid Demo - Extended Data Filtering";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBox1;
        private DevComponents.DotNetBar.ButtonX btnResetPanelFilter;
        private DevComponents.DotNetBar.ButtonX btnResetColumnFilters;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMatchType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterAlignment;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxShowPanelExpr;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxUseAgeSlider;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterImageVisibility;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFilterLevel;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}