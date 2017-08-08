namespace SuperGridDemo
{
    partial class DemoGridBasics0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoGridBasics0));
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.Style.Background background1 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding1 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding2 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Background background2 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Background background3 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding3 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding4 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Background background4 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding5 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding6 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Background background5 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding7 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding8 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Background background6 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            this.richTextBox1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxHeader = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxFooter = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxCaption = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxTitle = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnPurgeRows = new DevComponents.DotNetBar.ButtonX();
            this.cbxGridIndex = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxRowHeaders = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnShowDeleted = new DevComponents.DotNetBar.ButtonX();
            this.btnHideDeleted = new DevComponents.DotNetBar.ButtonX();
            this.cbxAutoDelete = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.superGridControl1 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.groupBox1.SuspendLayout();
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
            this.richTextBox1.Size = new System.Drawing.Size(780, 119);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.cbxHeader);
            this.groupBox1.Controls.Add(this.cbxFooter);
            this.groupBox1.Controls.Add(this.cbxCaption);
            this.groupBox1.Controls.Add(this.cbxTitle);
            this.groupBox1.Location = new System.Drawing.Point(12, 537);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 57);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show";
            // 
            // cbxHeader
            // 
            this.cbxHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.cbxHeader.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxHeader.Location = new System.Drawing.Point(147, 19);
            this.cbxHeader.Name = "cbxHeader";
            this.cbxHeader.Size = new System.Drawing.Size(61, 23);
            this.cbxHeader.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxHeader.TabIndex = 10;
            this.cbxHeader.Text = "Header";
            this.cbxHeader.CheckedChanged += new System.EventHandler(this.CbxHeaderCheckedChanged);
            // 
            // cbxFooter
            // 
            this.cbxFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.cbxFooter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxFooter.Location = new System.Drawing.Point(216, 19);
            this.cbxFooter.Name = "cbxFooter";
            this.cbxFooter.Size = new System.Drawing.Size(58, 23);
            this.cbxFooter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxFooter.TabIndex = 11;
            this.cbxFooter.Text = "Footer";
            this.cbxFooter.CheckedChanged += new System.EventHandler(this.CbxFooterCheckedChanged);
            // 
            // cbxCaption
            // 
            this.cbxCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.cbxCaption.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxCaption.Checked = true;
            this.cbxCaption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxCaption.CheckValue = "Y";
            this.cbxCaption.Location = new System.Drawing.Point(15, 19);
            this.cbxCaption.Name = "cbxCaption";
            this.cbxCaption.Size = new System.Drawing.Size(64, 23);
            this.cbxCaption.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxCaption.TabIndex = 8;
            this.cbxCaption.Text = "Caption";
            this.cbxCaption.CheckedChanged += new System.EventHandler(this.CbxCaptionCheckedChanged);
            // 
            // cbxTitle
            // 
            this.cbxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.cbxTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxTitle.Location = new System.Drawing.Point(86, 19);
            this.cbxTitle.Name = "cbxTitle";
            this.cbxTitle.Size = new System.Drawing.Size(48, 23);
            this.cbxTitle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxTitle.TabIndex = 9;
            this.cbxTitle.Text = "Title";
            this.cbxTitle.CheckedChanged += new System.EventHandler(this.CbxTitleCheckedChanged);
            // 
            // btnPurgeRows
            // 
            this.btnPurgeRows.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPurgeRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPurgeRows.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPurgeRows.Location = new System.Drawing.Point(548, 569);
            this.btnPurgeRows.Name = "btnPurgeRows";
            this.btnPurgeRows.Size = new System.Drawing.Size(109, 26);
            this.btnPurgeRows.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPurgeRows.TabIndex = 15;
            this.btnPurgeRows.Text = "Purge Deleted Rows";
            this.btnPurgeRows.Click += new System.EventHandler(this.BtnPurgeRowsClick);
            // 
            // cbxGridIndex
            // 
            this.cbxGridIndex.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.cbxGridIndex.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxGridIndex.Checked = true;
            this.cbxGridIndex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxGridIndex.CheckValue = "Y";
            this.cbxGridIndex.Location = new System.Drawing.Point(344, 568);
            this.cbxGridIndex.Name = "cbxGridIndex";
            this.cbxGridIndex.Size = new System.Drawing.Size(148, 23);
            this.cbxGridIndex.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxGridIndex.TabIndex = 14;
            this.cbxGridIndex.Text = "Show Row Grid Indexes";
            this.cbxGridIndex.CheckedChanged += new System.EventHandler(this.CbxGridIndexCheckedChanged);
            // 
            // cbxRowHeaders
            // 
            this.cbxRowHeaders.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.cbxRowHeaders.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxRowHeaders.Checked = true;
            this.cbxRowHeaders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxRowHeaders.CheckValue = "Y";
            this.cbxRowHeaders.Location = new System.Drawing.Point(344, 543);
            this.cbxRowHeaders.Name = "cbxRowHeaders";
            this.cbxRowHeaders.Size = new System.Drawing.Size(148, 23);
            this.cbxRowHeaders.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxRowHeaders.TabIndex = 13;
            this.cbxRowHeaders.Text = "Show Row Headers";
            this.cbxRowHeaders.CheckedChanged += new System.EventHandler(this.CbxRowHeadersCheckedChanged);
            // 
            // btnShowDeleted
            // 
            this.btnShowDeleted.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowDeleted.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnShowDeleted.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowDeleted.Location = new System.Drawing.Point(663, 569);
            this.btnShowDeleted.Name = "btnShowDeleted";
            this.btnShowDeleted.Size = new System.Drawing.Size(109, 26);
            this.btnShowDeleted.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShowDeleted.TabIndex = 7;
            this.btnShowDeleted.Text = "Show Deleted Rows";
            this.btnShowDeleted.Click += new System.EventHandler(this.BtnShowDelRowsClick);
            // 
            // btnHideDeleted
            // 
            this.btnHideDeleted.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHideDeleted.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHideDeleted.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHideDeleted.Location = new System.Drawing.Point(663, 540);
            this.btnHideDeleted.Name = "btnHideDeleted";
            this.btnHideDeleted.Size = new System.Drawing.Size(109, 26);
            this.btnHideDeleted.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHideDeleted.TabIndex = 6;
            this.btnHideDeleted.Text = "Hide Deleted Rows";
            this.btnHideDeleted.Click += new System.EventHandler(this.BtnHideDelRowsClick);
            // 
            // cbxAutoDelete
            // 
            this.cbxAutoDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.cbxAutoDelete.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxAutoDelete.Checked = true;
            this.cbxAutoDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoDelete.CheckValue = "Y";
            this.cbxAutoDelete.Location = new System.Drawing.Point(509, 540);
            this.cbxAutoDelete.Name = "cbxAutoDelete";
            this.cbxAutoDelete.Size = new System.Drawing.Size(148, 23);
            this.cbxAutoDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxAutoDelete.TabIndex = 5;
            this.cbxAutoDelete.Text = "Auto Hide Deleted Rows";
            this.cbxAutoDelete.CheckedChanged += new System.EventHandler(this.CbxAutoDeleteCheckedChanged);
            // 
            // superGridControl1
            // 
            this.superGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.superGridControl1.DefaultVisualStyles.FooterStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.Location = new System.Drawing.Point(0, 123);
            this.superGridControl1.Name = "superGridControl1";
            this.superGridControl1.PrimaryGrid.AllowRowDelete = true;
            this.superGridControl1.PrimaryGrid.AllowRowHeaderResize = true;
            this.superGridControl1.PrimaryGrid.AllowRowInsert = true;
            this.superGridControl1.PrimaryGrid.AllowRowResize = true;
            this.superGridControl1.PrimaryGrid.Caption.Text = "(Caption)<div align=\"vcenter\">Wolf Power and Machine Works Inc.</div>";
            gridColumn1.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gridColumn1.DefaultNewRowCellValue = "Machine Name";
            gridColumn1.Name = "Machine";
            gridColumn2.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gridColumn2.DefaultNewRowCellValue = "false";
            gridColumn2.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            gridColumn2.Name = "Dual Voltage";
            gridColumn3.DefaultNewRowCellValue = "false";
            gridColumn3.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridSwitchButtonEditControl);
            gridColumn3.Name = "Power State";
            gridColumn4.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            gridColumn4.Name = "Last Maintance";
            gridColumn4.Width = 140;
            gridColumn5.DefaultNewRowCellValue = "Start";
            gridColumn5.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridButtonXEditControl);
            gridColumn5.MarkRowDirtyOnCellValueChange = false;
            gridColumn5.Name = "Start/Stop";
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn1);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn2);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn3);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn4);
            this.superGridControl1.PrimaryGrid.Columns.Add(gridColumn5);
            this.superGridControl1.PrimaryGrid.DefaultRowHeight = 30;
            background1.Color1 = System.Drawing.Color.AliceBlue;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Background = background1;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            padding1.Right = 6;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.ImagePadding = padding1;
            padding2.Bottom = 6;
            padding2.Left = 6;
            padding2.Right = 6;
            padding2.Top = 6;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.Default.Margin = padding2;
            background2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CaptionStyles.SelectedMouseOver.Background = background2;
            background3.Color1 = System.Drawing.Color.Lavender;
            background3.Color2 = System.Drawing.Color.DarkSlateGray;
            background3.GradientAngle = 45;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderRowStyles.Default.RowHeader.Background = background3;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderRowStyles.Default.RowHeader.BorderHighlightColor = System.Drawing.Color.White;
            padding3.Bottom = 4;
            padding3.Left = 4;
            padding3.Right = 4;
            padding3.Top = 4;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.ColumnHeaderStyles.Default.Margin = padding3;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.ImageAlignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.TopLeft;
            padding4.Bottom = 4;
            padding4.Left = 4;
            padding4.Right = 4;
            padding4.Top = 4;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.FooterStyles.Default.Margin = padding4;
            background4.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.FooterStyles.SelectedMouseOver.Background = background4;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.ImageOverlay = DevComponents.DotNetBar.SuperGrid.Style.ImageOverlay.None;
            padding5.Right = 4;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.ImagePadding = padding5;
            padding6.Bottom = 4;
            padding6.Left = 4;
            padding6.Right = 4;
            padding6.Top = 4;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.Default.Margin = padding6;
            background5.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.HeaderStyles.SelectedMouseOver.Background = background5;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.AllowWrap = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            padding7.Right = 6;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.ImagePadding = padding7;
            padding8.Bottom = 4;
            padding8.Left = 4;
            padding8.Right = 4;
            padding8.Top = 4;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.Margin = padding8;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.Default.TextColor = System.Drawing.Color.Navy;
            background6.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.TitleStyles.SelectedMouseOver.Background = background6;
            this.superGridControl1.PrimaryGrid.FilterExpr = null;
            this.superGridControl1.PrimaryGrid.Footer.Text = "(Footer)<div align=\"vcenter\">Check with your Supervisor if you have <b>ANY</b> qu" +
                "estions.</div>";
            this.superGridControl1.PrimaryGrid.Footer.Visible = false;
            this.superGridControl1.PrimaryGrid.Header.Text = "(Header) <div align=\"vcenter\">Make sure operator is a <b><font color=\"#ED1C24\">SA" +
                "FE DISTANCE</font> </b>away from the machine power panel before starting machine" +
                ".</div>";
            this.superGridControl1.PrimaryGrid.Header.Visible = false;
            this.superGridControl1.PrimaryGrid.ImmediateResize = true;
            this.superGridControl1.PrimaryGrid.RowDragBehavior = DevComponents.DotNetBar.SuperGrid.RowDragBehavior.Move;
            this.superGridControl1.PrimaryGrid.ShowInsertRow = true;
            this.superGridControl1.PrimaryGrid.ShowRowGridIndex = true;
            this.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.superGridControl1.PrimaryGrid.Title.Text = "(Title)<div align=\"vcenter\">Check operators manual for suggested maintanance inte" +
                "rvals</div>";
            this.superGridControl1.PrimaryGrid.Title.Visible = false;
            this.superGridControl1.PrimaryGrid.UseAlternateRowStyle = true;
            this.superGridControl1.Size = new System.Drawing.Size(784, 408);
            this.superGridControl1.TabIndex = 4;
            this.superGridControl1.Text = "superGridControl1";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // DemoGridBasics0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 603);
            this.Controls.Add(this.btnPurgeRows);
            this.Controls.Add(this.cbxGridIndex);
            this.Controls.Add(this.cbxRowHeaders);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShowDeleted);
            this.Controls.Add(this.btnHideDeleted);
            this.Controls.Add(this.cbxAutoDelete);
            this.Controls.Add(this.superGridControl1);
            this.Controls.Add(this.richTextBox1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "DemoGridBasics0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperGrid Demo - Basic Components";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBox1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxAutoDelete;
        private DevComponents.DotNetBar.ButtonX btnHideDeleted;
        private DevComponents.DotNetBar.ButtonX btnShowDeleted;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxCaption;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxTitle;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxHeader;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxFooter;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxRowHeaders;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxGridIndex;
        private DevComponents.DotNetBar.ButtonX btnPurgeRows;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}