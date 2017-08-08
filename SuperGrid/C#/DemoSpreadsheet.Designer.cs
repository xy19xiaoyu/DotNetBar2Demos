namespace SuperGridDemo
{
    partial class DemoSpreadsheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoSpreadsheet));
            DevComponents.DotNetBar.SuperGrid.Style.Padding padding1 = new DevComponents.DotNetBar.SuperGrid.Style.Padding();
            DevComponents.DotNetBar.SuperGrid.Style.Background background1 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Background background2 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            DevComponents.DotNetBar.SuperGrid.Style.Background background3 = new DevComponents.DotNetBar.SuperGrid.Style.Background();
            this.richTextBox1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnFont = new DevComponents.DotNetBar.ButtonItem();
            this.CpText = new DevComponents.DotNetBar.ColorPickerDropDown();
            this.BtnEraseText = new DevComponents.DotNetBar.ButtonItem();
            this.BtnLeftAlign = new DevComponents.DotNetBar.ButtonItem();
            this.BtnMiddleAlign = new DevComponents.DotNetBar.ButtonItem();
            this.BtnRightAlign = new DevComponents.DotNetBar.ButtonItem();
            this.CpBackground = new DevComponents.DotNetBar.ColorPickerDropDown();
            this.BtnEraseBackground = new DevComponents.DotNetBar.ButtonItem();
            this.TbxCellText = new DevComponents.DotNetBar.TextBoxItem();
            this.btnShowEmptyCells = new DevComponents.DotNetBar.ButtonItem();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.superGridControl1 = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.cmContext = new DevComponents.DotNetBar.ButtonItem();
            this.cmiClear = new DevComponents.DotNetBar.ButtonItem();
            this.cmiLeftAlign = new DevComponents.DotNetBar.ButtonItem();
            this.cmiCenterAlign = new DevComponents.DotNetBar.ButtonItem();
            this.cmiRightAlign = new DevComponents.DotNetBar.ButtonItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColorRichTextBox = System.Drawing.Color.White;
            // 
            // 
            // 
            this.richTextBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBox1.Location = new System.Drawing.Point(4, 387);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(780, 181);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.TabStop = false;
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.CanUndock = false;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar1.Images = this.imageList1;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BtnFont,
            this.CpText,
            this.BtnEraseText,
            this.BtnLeftAlign,
            this.BtnMiddleAlign,
            this.BtnRightAlign,
            this.CpBackground,
            this.BtnEraseBackground,
            this.TbxCellText,
            this.btnShowEmptyCells});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(784, 24);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.bar1.TabIndex = 6;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "LeftAlign");
            this.imageList1.Images.SetKeyName(1, "CenterAlign");
            this.imageList1.Images.SetKeyName(2, "RightAlign");
            this.imageList1.Images.SetKeyName(3, "Eraser");
            // 
            // BtnFont
            // 
            this.BtnFont.BeginGroup = true;
            this.BtnFont.Image = ((System.Drawing.Image)(resources.GetObject("BtnFont.Image")));
            this.BtnFont.Name = "BtnFont";
            this.BtnFont.Text = "Font";
            this.BtnFont.Click += new System.EventHandler(this.BtnFontClick);
            // 
            // CpText
            // 
            this.CpText.BeginGroup = true;
            this.CpText.Image = ((System.Drawing.Image)(resources.GetObject("CpText.Image")));
            this.CpText.Name = "CpText";
            this.CpText.SelectedColorImageRectangle = new System.Drawing.Rectangle(0, 13, 16, 4);
            this.CpText.Click += new System.EventHandler(this.CpTextClick);
            // 
            // BtnEraseText
            // 
            this.BtnEraseText.Image = ((System.Drawing.Image)(resources.GetObject("BtnEraseText.Image")));
            this.BtnEraseText.Name = "BtnEraseText";
            this.BtnEraseText.Text = "buttonItem2";
            this.BtnEraseText.Click += new System.EventHandler(this.BtnEraseTextClick);
            // 
            // BtnLeftAlign
            // 
            this.BtnLeftAlign.BeginGroup = true;
            this.BtnLeftAlign.ImageIndex = 0;
            this.BtnLeftAlign.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Default;
            this.BtnLeftAlign.Name = "BtnLeftAlign";
            this.BtnLeftAlign.Text = "buttonItem1";
            this.BtnLeftAlign.Click += new System.EventHandler(this.BtnLeftAlignClick);
            // 
            // BtnMiddleAlign
            // 
            this.BtnMiddleAlign.ImageIndex = 1;
            this.BtnMiddleAlign.Name = "BtnMiddleAlign";
            this.BtnMiddleAlign.Text = "buttonItem2";
            this.BtnMiddleAlign.Click += new System.EventHandler(this.BtnMiddleAlignClick);
            // 
            // BtnRightAlign
            // 
            this.BtnRightAlign.ImageIndex = 2;
            this.BtnRightAlign.Name = "BtnRightAlign";
            this.BtnRightAlign.Text = "buttonItem3";
            this.BtnRightAlign.Click += new System.EventHandler(this.BtnRightAlignClick);
            // 
            // CpBackground
            // 
            this.CpBackground.BeginGroup = true;
            this.CpBackground.Image = ((System.Drawing.Image)(resources.GetObject("CpBackground.Image")));
            this.CpBackground.Name = "CpBackground";
            this.CpBackground.SelectedColorImageRectangle = new System.Drawing.Rectangle(0, 13, 16, 4);
            this.CpBackground.Click += new System.EventHandler(this.CpBackgroundClick);
            // 
            // BtnEraseBackground
            // 
            this.BtnEraseBackground.ImageIndex = 3;
            this.BtnEraseBackground.Name = "BtnEraseBackground";
            this.BtnEraseBackground.Text = "buttonItem2";
            this.BtnEraseBackground.Click += new System.EventHandler(this.BtnEraseBackgroundClick);
            // 
            // TbxCellText
            // 
            this.TbxCellText.BeginGroup = true;
            this.TbxCellText.Name = "TbxCellText";
            this.TbxCellText.Stretch = true;
            this.TbxCellText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbxCellText.WatermarkColor = System.Drawing.SystemColors.GrayText;
            this.TbxCellText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxCellTextKeyDown);
            // 
            // btnShowEmptyCells
            // 
            this.btnShowEmptyCells.AutoCheckOnClick = true;
            this.btnShowEmptyCells.BeginGroup = true;
            this.btnShowEmptyCells.Image = ((System.Drawing.Image)(resources.GetObject("btnShowEmptyCells.Image")));
            this.btnShowEmptyCells.Name = "btnShowEmptyCells";
            this.btnShowEmptyCells.Text = "buttonItem1";
            this.btnShowEmptyCells.Click += new System.EventHandler(this.BtnShowEmptyCellsClick);
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // superGridControl1
            // 
            this.superGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.superGridControl1.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.superGridControl1.Location = new System.Drawing.Point(0, 24);
            this.superGridControl1.Name = "superGridControl1";
            this.superGridControl1.PrimaryGrid.AllowRowResize = true;
            padding1.Bottom = 1;
            padding1.Left = 1;
            padding1.Right = 1;
            padding1.Top = 1;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Margin = padding1;
            background1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.MouseOver.Background = background1;
            background2.Color1 = System.Drawing.SystemColors.Highlight;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.Selected.Background = background2;
            background3.Color1 = System.Drawing.SystemColors.GradientActiveCaption;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.CellStyles.SelectedMouseOver.Background = background3;
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.superGridControl1.PrimaryGrid.DefaultVisualStyles.GridPanelStyle.VerticalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.superGridControl1.PrimaryGrid.EnableCellExpressions = true;
            this.superGridControl1.PrimaryGrid.FilterExpr = null;
            this.superGridControl1.PrimaryGrid.RowHeaderWidth = 40;
            this.superGridControl1.PrimaryGrid.Title.RowHeaderVisibility = DevComponents.DotNetBar.SuperGrid.RowHeaderVisibility.PanelControlled;
            this.superGridControl1.Size = new System.Drawing.Size(784, 357);
            this.superGridControl1.TabIndex = 0;
            this.superGridControl1.Text = "superGridControl1";
            this.superGridControl1.DoubleClick += new System.EventHandler(this.SuperGridControl1DoubleClick);
            this.superGridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SuperGridControl1MouseClick);
            this.superGridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SuperGridControl1KeyDown);
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.AntiAlias = true;
            this.contextMenuBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuBar1.Images = this.imageList1;
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cmContext});
            this.contextMenuBar1.Location = new System.Drawing.Point(159, 512);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(213, 25);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabIndex = 7;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // cmContext
            // 
            this.cmContext.AutoExpandOnClick = true;
            this.cmContext.Name = "cmContext";
            this.cmContext.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.cmiClear,
            this.cmiLeftAlign,
            this.cmiCenterAlign,
            this.cmiRightAlign});
            this.cmContext.Text = "Context";
            // 
            // cmiClear
            // 
            this.cmiClear.ImageIndex = 3;
            this.cmiClear.Name = "cmiClear";
            this.cmiClear.Text = "Clear";
            this.cmiClear.Click += new System.EventHandler(this.CmiClearClick);
            // 
            // cmiLeftAlign
            // 
            this.cmiLeftAlign.BeginGroup = true;
            this.cmiLeftAlign.ImageIndex = 0;
            this.cmiLeftAlign.Name = "cmiLeftAlign";
            this.cmiLeftAlign.Text = "Left Align";
            this.cmiLeftAlign.Click += new System.EventHandler(this.CmiLeftAlignClick);
            // 
            // cmiCenterAlign
            // 
            this.cmiCenterAlign.ImageIndex = 1;
            this.cmiCenterAlign.Name = "cmiCenterAlign";
            this.cmiCenterAlign.Text = "Center Align";
            this.cmiCenterAlign.Click += new System.EventHandler(this.CmiCenterAlignClick);
            // 
            // cmiRightAlign
            // 
            this.cmiRightAlign.ImageIndex = 2;
            this.cmiRightAlign.Name = "cmiRightAlign";
            this.cmiRightAlign.Text = "Right Align";
            this.cmiRightAlign.Click += new System.EventHandler(this.CmiRightAlignClick);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // DemoSpreadsheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 568);
            this.Controls.Add(this.contextMenuBar1);
            this.Controls.Add(this.superGridControl1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bar1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "DemoSpreadsheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperGrid Demo - Simple Spreadsheet Sample";
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBox1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl superGridControl1;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem BtnFont;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.ColorPickerDropDown CpText;
        private DevComponents.DotNetBar.ColorPickerDropDown CpBackground;
        private DevComponents.DotNetBar.ButtonItem BtnEraseBackground;
        private DevComponents.DotNetBar.TextBoxItem TbxCellText;
        private DevComponents.DotNetBar.ButtonItem BtnEraseText;
        private DevComponents.DotNetBar.ButtonItem BtnLeftAlign;
        private DevComponents.DotNetBar.ButtonItem BtnMiddleAlign;
        private DevComponents.DotNetBar.ButtonItem BtnRightAlign;
        private DevComponents.DotNetBar.ButtonItem btnShowEmptyCells;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem cmContext;
        private DevComponents.DotNetBar.ButtonItem cmiClear;
        private DevComponents.DotNetBar.ButtonItem cmiLeftAlign;
        private DevComponents.DotNetBar.ButtonItem cmiCenterAlign;
        private DevComponents.DotNetBar.ButtonItem cmiRightAlign;
        private System.Windows.Forms.ImageList imageList1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}