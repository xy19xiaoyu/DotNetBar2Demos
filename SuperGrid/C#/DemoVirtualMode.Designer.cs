namespace SuperGridDemo
{
    partial class DemoVirtualMode
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
            DevComponents.DotNetBar.SuperGrid.Style.Background background1 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Background background2 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoVirtualMode));
            this.richTextBox1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.CbxAltColStyle = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.CbxAltRowStyle = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.BtnClearRows = new DevComponents.DotNetBar.ButtonX();
            this.BtnLoadRows = new DevComponents.DotNetBar.ButtonX();
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
            this.richTextBox1.Size = new System.Drawing.Size(781, 117);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.TabStop = false;
            // 
            // CbxAltColStyle
            // 
            this.CbxAltColStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.CbxAltColStyle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CbxAltColStyle.Location = new System.Drawing.Point(195, 522);
            this.CbxAltColStyle.Name = "CbxAltColStyle";
            this.CbxAltColStyle.Size = new System.Drawing.Size(178, 23);
            this.CbxAltColStyle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxAltColStyle.TabIndex = 8;
            this.CbxAltColStyle.Text = "Use Alternating Column Style";
            this.CbxAltColStyle.CheckedChanged += new System.EventHandler(this.CbxAltColStyleCheckedChanged);
            // 
            // CbxAltRowStyle
            // 
            this.CbxAltRowStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.CbxAltRowStyle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CbxAltRowStyle.Location = new System.Drawing.Point(28, 522);
            this.CbxAltRowStyle.Name = "CbxAltRowStyle";
            this.CbxAltRowStyle.Size = new System.Drawing.Size(161, 23);
            this.CbxAltRowStyle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CbxAltRowStyle.TabIndex = 7;
            this.CbxAltRowStyle.Text = "Use Alternating Row Style";
            this.CbxAltRowStyle.CheckedChanged += new System.EventHandler(this.CbxAltRowStyleCheckedChanged);
            // 
            // BtnClearRows
            // 
            this.BtnClearRows.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnClearRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClearRows.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnClearRows.Location = new System.Drawing.Point(697, 522);
            this.BtnClearRows.Name = "BtnClearRows";
            this.BtnClearRows.Size = new System.Drawing.Size(75, 28);
            this.BtnClearRows.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnClearRows.TabIndex = 6;
            this.BtnClearRows.Text = "Clear Rows";
            this.BtnClearRows.Click += new System.EventHandler(this.BtnClearRowsClick);
            // 
            // BtnLoadRows
            // 
            this.BtnLoadRows.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnLoadRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoadRows.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnLoadRows.Location = new System.Drawing.Point(616, 522);
            this.BtnLoadRows.Name = "BtnLoadRows";
            this.BtnLoadRows.Size = new System.Drawing.Size(75, 28);
            this.BtnLoadRows.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnLoadRows.TabIndex = 5;
            this.BtnLoadRows.Text = "Load Rows";
            this.BtnLoadRows.Click += new System.EventHandler(this.BtnLoadRowsClick);
            // 
            // superGridControl1
            // 
            this.superGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.Location = new System.Drawing.Point(0, 127);
            this.superGridControl1.Name = "superGridControl1";
            this.superGridControl1.PrimaryGrid.AllowRowHeaderResize = true;
            this.superGridControl1.PrimaryGrid.AllowRowResize = true;
            this.superGridControl1.PrimaryGrid.CheckBoxes = true;
            this.superGridControl1.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn1.Name = "Column1";
            gridColumn1.Width = 150;
            gridColumn2.Name = "Column2";
            gridColumn2.Width = 150;
            gridColumn3.Name = "Column3";
            gridColumn3.Width = 150;
            gridColumn4.Name = "Column4";
            gridColumn4.Width = 150;
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn1);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn2);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn3);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn4);
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            background1.BackFillType = DevComponents.DotNetBar.SuperGrid.Style.BackFillType.ForwardDiagonal;
            background1.Color1 = System.Drawing.Color.Silver;
            background1.Color2 = System.Drawing.Color.White;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.Background = background1;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            background2.Color1 = System.Drawing.Color.LightSteelBlue;
            background2.Color2 = System.Drawing.Color.Azure;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.Background = background2;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.superGridControl1.PrimaryGrid.FilterExpr = null;
            this.superGridControl1.PrimaryGrid.FrozenRowCount = 5;
            this.superGridControl1.PrimaryGrid.Header.Text = "<div valign=\"middle\" align=\"center\">SuperGrid VirtualMode Sample Application</div" +
                ">";
            this.superGridControl1.PrimaryGrid.NoRowsText = "Click on the \"Load Rows\" button to add 2,000,000 rows!";
            this.superGridControl1.PrimaryGrid.RowHeaderWidth = 55;
            this.superGridControl1.PrimaryGrid.ShowRowGridIndex = true;
            this.superGridControl1.PrimaryGrid.ShowTreeButtons = true;
            this.superGridControl1.PrimaryGrid.ShowTreeLines = true;
            this.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.superGridControl1.PrimaryGrid.VirtualMode = true;
            this.superGridControl1.Size = new System.Drawing.Size(785, 377);
            this.superGridControl1.TabIndex = 0;
            this.superGridControl1.Text = "superGridControl1";
            this.superGridControl1.StoreVirtualRow += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridVirtualRowEventArgs>(this.SuperGridControl1StoreVirtualRow);
            this.superGridControl1.LoadVirtualRow += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridVirtualRowEventArgs>(this.SuperGridControl1LoadVirtualRow);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // DemoVirtualMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.CbxAltColStyle);
            this.Controls.Add(this.CbxAltRowStyle);
            this.Controls.Add(this.BtnClearRows);
            this.Controls.Add(this.BtnLoadRows);
            this.Controls.Add(this.superGridControl1);
            this.Controls.Add(this.richTextBox1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "DemoVirtualMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperGrid Demo - Virtual Mode Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBox1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
        private DevComponents.DotNetBar.ButtonX BtnLoadRows;
        private DevComponents.DotNetBar.ButtonX BtnClearRows;
        private DevComponents.DotNetBar.Controls.CheckBoxX CbxAltRowStyle;
        private DevComponents.DotNetBar.Controls.CheckBoxX CbxAltColStyle;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}