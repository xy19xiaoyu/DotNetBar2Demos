namespace CircularProgressControl
{
    partial class Form1
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
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.circularProgressItem6 = new DevComponents.DotNetBar.CircularProgressItem();
            this.circularProgressItem7 = new DevComponents.DotNetBar.CircularProgressItem();
            this.circularProgressItem8 = new DevComponents.DotNetBar.CircularProgressItem();
            this.circularProgressItem9 = new DevComponents.DotNetBar.CircularProgressItem();
            this.circularProgressItem10 = new DevComponents.DotNetBar.CircularProgressItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.ProgressRun = new DevComponents.DotNetBar.Command(this.components);
            this.checkBoxItem1 = new DevComponents.DotNetBar.CheckBoxItem();
            this.ProgressValueVisible = new DevComponents.DotNetBar.Command(this.components);
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.circularProgressItem1 = new DevComponents.DotNetBar.CircularProgressItem();
            this.circularProgressItem2 = new DevComponents.DotNetBar.CircularProgressItem();
            this.circularProgressItem3 = new DevComponents.DotNetBar.CircularProgressItem();
            this.circularProgressItem4 = new DevComponents.DotNetBar.CircularProgressItem();
            this.circularProgressItem5 = new DevComponents.DotNetBar.CircularProgressItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.ToggleEndlessProgress = new DevComponents.DotNetBar.Command(this.components);
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.circularProgressItem11 = new DevComponents.DotNetBar.CircularProgressItem();
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.Class = "";
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.Size = new System.Drawing.Size(561, 98);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar2);
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(561, 71);
            // 
            // 
            // 
            this.ribbonPanel1.Style.Class = "";
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.Class = "";
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.Class = "";
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.Class = "";
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.circularProgressItem6,
            this.circularProgressItem7,
            this.circularProgressItem8,
            this.circularProgressItem9,
            this.circularProgressItem10,
            this.itemContainer1});
            this.ribbonBar2.ItemSpacing = 6;
            this.ribbonBar2.Location = new System.Drawing.Point(232, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(326, 68);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 1;
            this.ribbonBar2.Text = "Percent";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.Class = "";
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.Class = "";
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // circularProgressItem6
            // 
            this.circularProgressItem6.Diameter = 48;
            this.circularProgressItem6.Name = "circularProgressItem6";
            this.circularProgressItem6.ProgressTextVisible = true;
            // 
            // circularProgressItem7
            // 
            this.circularProgressItem7.Diameter = 32;
            this.circularProgressItem7.Name = "circularProgressItem7";
            this.circularProgressItem7.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.circularProgressItem7.ProgressColor = System.Drawing.Color.SeaGreen;
            this.circularProgressItem7.ProgressTextVisible = true;
            // 
            // circularProgressItem8
            // 
            this.circularProgressItem8.Diameter = 32;
            this.circularProgressItem8.Name = "circularProgressItem8";
            this.circularProgressItem8.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.circularProgressItem8.ProgressColor = System.Drawing.Color.IndianRed;
            this.circularProgressItem8.ProgressTextVisible = true;
            // 
            // circularProgressItem9
            // 
            this.circularProgressItem9.Diameter = 32;
            this.circularProgressItem9.Name = "circularProgressItem9";
            this.circularProgressItem9.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Spoke;
            this.circularProgressItem9.ProgressColor = System.Drawing.Color.Turquoise;
            this.circularProgressItem9.ProgressTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.circularProgressItem9.ProgressTextFormat = "{0}";
            this.circularProgressItem9.ProgressTextVisible = true;
            // 
            // circularProgressItem10
            // 
            this.circularProgressItem10.Diameter = 32;
            this.circularProgressItem10.Name = "circularProgressItem10";
            this.circularProgressItem10.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Pie;
            this.circularProgressItem10.ProgressColor = System.Drawing.Color.Tan;
            this.circularProgressItem10.ProgressTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.circularProgressItem10.ProgressTextVisible = true;
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "";
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.ItemSpacing = 4;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2,
            this.checkBoxItem1});
            // 
            // buttonItem2
            // 
            this.buttonItem2.BeginGroup = true;
            this.buttonItem2.Checked = true;
            this.buttonItem2.Command = this.ProgressRun;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItemsExpandWidth = 14;
            this.buttonItem2.Text = "Stop";
            // 
            // ProgressRun
            // 
            this.ProgressRun.Checked = true;
            this.ProgressRun.Name = "ProgressRun";
            this.ProgressRun.Executed += new System.EventHandler(this.ProgressRun_Executed);
            // 
            // checkBoxItem1
            // 
            this.checkBoxItem1.Checked = true;
            this.checkBoxItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxItem1.Command = this.ProgressValueVisible;
            this.checkBoxItem1.Name = "checkBoxItem1";
            this.checkBoxItem1.Text = "Show value";
            // 
            // ProgressValueVisible
            // 
            this.ProgressValueVisible.Checked = true;
            this.ProgressValueVisible.Name = "ProgressValueVisible";
            this.ProgressValueVisible.Executed += new System.EventHandler(this.ProgressValueVisible_Executed);
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.Class = "";
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.Class = "";
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.circularProgressItem1,
            this.circularProgressItem2,
            this.circularProgressItem3,
            this.circularProgressItem4,
            this.circularProgressItem5,
            this.buttonItem1});
            this.ribbonBar1.ItemSpacing = 12;
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(229, 68);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "Endless";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.Class = "";
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.Class = "";
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // circularProgressItem1
            // 
            this.circularProgressItem1.Name = "circularProgressItem1";
            this.circularProgressItem1.PieBorderLight = System.Drawing.Color.Empty;
            this.circularProgressItem1.ProgressColor = System.Drawing.Color.DarkMagenta;
            this.circularProgressItem1.Text = "Line";
            this.circularProgressItem1.TextPosition = DevComponents.DotNetBar.eTextPosition.Bottom;
            this.circularProgressItem1.Value = 60;
            // 
            // circularProgressItem2
            // 
            this.circularProgressItem2.Name = "circularProgressItem2";
            this.circularProgressItem2.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.circularProgressItem2.ProgressColor = System.Drawing.Color.DarkGreen;
            this.circularProgressItem2.Text = "Dot";
            this.circularProgressItem2.TextPosition = DevComponents.DotNetBar.eTextPosition.Bottom;
            this.circularProgressItem2.Value = 80;
            // 
            // circularProgressItem3
            // 
            this.circularProgressItem3.Name = "circularProgressItem3";
            this.circularProgressItem3.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.circularProgressItem3.ProgressColor = System.Drawing.Color.SteelBlue;
            this.circularProgressItem3.Text = "Donut";
            this.circularProgressItem3.TextPosition = DevComponents.DotNetBar.eTextPosition.Bottom;
            this.circularProgressItem3.Value = 75;
            // 
            // circularProgressItem4
            // 
            this.circularProgressItem4.Name = "circularProgressItem4";
            this.circularProgressItem4.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Spoke;
            this.circularProgressItem4.Text = "Spoke";
            this.circularProgressItem4.TextPosition = DevComponents.DotNetBar.eTextPosition.Bottom;
            this.circularProgressItem4.Value = 45;
            // 
            // circularProgressItem5
            // 
            this.circularProgressItem5.Name = "circularProgressItem5";
            this.circularProgressItem5.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Pie;
            this.circularProgressItem5.ProgressColor = System.Drawing.Color.DarkOrange;
            this.circularProgressItem5.Text = "Pie";
            this.circularProgressItem5.TextPosition = DevComponents.DotNetBar.eTextPosition.Bottom;
            this.circularProgressItem5.Value = 90;
            // 
            // buttonItem1
            // 
            this.buttonItem1.BeginGroup = true;
            this.buttonItem1.Command = this.ToggleEndlessProgress;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 14;
            this.buttonItem1.Text = "Stop";
            // 
            // ToggleEndlessProgress
            // 
            this.ToggleEndlessProgress.Checked = false;
            this.ToggleEndlessProgress.Name = "ToggleEndlessProgress";
            this.ToggleEndlessProgress.Executed += new System.EventHandler(this.ToggleEndlessProgress_Executed);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "Circular Progresss";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.circularProgressItem11});
            this.bar1.Location = new System.Drawing.Point(0, 264);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(561, 23);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 1;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // labelItem1
            // 
            this.labelItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "Status bar circular progress indicator:";
            // 
            // circularProgressItem11
            // 
            this.circularProgressItem11.Diameter = 20;
            this.circularProgressItem11.Name = "circularProgressItem11";
            // 
            // circularProgress1
            // 
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.BackgroundImageAlpha = ((byte)(64));
            this.circularProgress1.BackgroundStyle.Class = "";
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circularProgress1.FocusCuesEnabled = false;
            this.circularProgress1.Location = new System.Drawing.Point(0, 98);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.circularProgress1.ProgressColor = System.Drawing.Color.YellowGreen;
            this.circularProgress1.Size = new System.Drawing.Size(561, 166);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 2;
            this.circularProgress1.Value = 100;
            this.circularProgress1.Click += new System.EventHandler(this.circularProgress1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 287);
            this.Controls.Add(this.circularProgress1);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.ribbonControl1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "Form1";
            this.Text = "Circular Progress Control Demo";
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.CircularProgressItem circularProgressItem1;
        private DevComponents.DotNetBar.CircularProgressItem circularProgressItem2;
        private DevComponents.DotNetBar.CircularProgressItem circularProgressItem3;
        private DevComponents.DotNetBar.CircularProgressItem circularProgressItem4;
        private DevComponents.DotNetBar.CircularProgressItem circularProgressItem5;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.Command ToggleEndlessProgress;
        private DevComponents.DotNetBar.CircularProgressItem circularProgressItem6;
        private DevComponents.DotNetBar.CircularProgressItem circularProgressItem7;
        private DevComponents.DotNetBar.CircularProgressItem circularProgressItem8;
        private DevComponents.DotNetBar.CircularProgressItem circularProgressItem9;
        private DevComponents.DotNetBar.CircularProgressItem circularProgressItem10;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.Command ProgressRun;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.CheckBoxItem checkBoxItem1;
        private DevComponents.DotNetBar.Command ProgressValueVisible;
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.CircularProgressItem circularProgressItem11;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
    }
}

