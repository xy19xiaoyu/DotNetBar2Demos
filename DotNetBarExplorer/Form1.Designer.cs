namespace DotNetBarExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.buyButton = new DevComponents.DotNetBar.ButtonItem();
            this.buyDotNetBarCommand = new DevComponents.DotNetBar.Command(this.components);
            this.moviesButton = new DevComponents.DotNetBar.ButtonItem();
            this.tutorialsCommand = new DevComponents.DotNetBar.Command(this.components);
            this.kbButton = new DevComponents.DotNetBar.ButtonItem();
            this.kbCommand = new DevComponents.DotNetBar.Command(this.components);
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.testimonialsCommand = new DevComponents.DotNetBar.Command(this.components);
            this.devcoButton = new DevComponents.DotNetBar.ButtonItem();
            this.devcoCommand = new DevComponents.DotNetBar.Command(this.components);
            this.versionLabel = new DevComponents.DotNetBar.LabelItem();
            this.metroShell1 = new DevComponents.DotNetBar.Metro.MetroShell();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.pageTitleLabel = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.page1Command = new DevComponents.DotNetBar.Command(this.components);
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.page2Command = new DevComponents.DotNetBar.Command(this.components);
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.page3Command = new DevComponents.DotNetBar.Command(this.components);
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.page4Command = new DevComponents.DotNetBar.Command(this.components);
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.page5Command = new DevComponents.DotNetBar.Command(this.components);
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.page6Command = new DevComponents.DotNetBar.Command(this.components);
            this.runCommand = new DevComponents.DotNetBar.Command(this.components);
            this.pageSlider1 = new DevComponents.DotNetBar.Controls.PageSlider();
            this.pageSliderPage1 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.page11 = new DotNetBarExplorer.Page1();
            this.pageSliderPage2 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.page21 = new DotNetBarExplorer.Page2();
            this.pageSliderPage3 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.page31 = new DotNetBarExplorer.Page3();
            this.pageSliderPage4 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.page41 = new DotNetBarExplorer.Page4();
            this.pageSliderPage5 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.page51 = new DotNetBarExplorer.Page5();
            this.pageSliderPage6 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.page61 = new DotNetBarExplorer.Page6();
            this.pageSlider1.SuspendLayout();
            this.pageSliderPage1.SuspendLayout();
            this.pageSliderPage2.SuspendLayout();
            this.pageSliderPage3.SuspendLayout();
            this.pageSliderPage4.SuspendLayout();
            this.pageSliderPage5.SuspendLayout();
            this.pageSliderPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStatusBar1
            // 
            this.metroStatusBar1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.FadeEffect = false;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.ForeColor = System.Drawing.Color.Black;
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buyButton,
            this.moviesButton,
            this.kbButton,
            this.buttonItem1,
            this.devcoButton,
            this.versionLabel});
            this.metroStatusBar1.ItemSpacing = 8;
            this.metroStatusBar1.Location = new System.Drawing.Point(0, 453);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.ResizeHandleVisible = false;
            this.metroStatusBar1.Size = new System.Drawing.Size(791, 22);
            this.metroStatusBar1.TabIndex = 0;
            // 
            // buyButton
            // 
            this.buyButton.Command = this.buyDotNetBarCommand;
            this.buyButton.Name = "buyButton";
            this.buyButton.Text = "Buy DotNetBar";
            // 
            // buyDotNetBarCommand
            // 
            this.buyDotNetBarCommand.Name = "buyDotNetBarCommand";
            this.buyDotNetBarCommand.Executed += new System.EventHandler(this.buyDotNetBarCommand_Executed);
            // 
            // moviesButton
            // 
            this.moviesButton.Command = this.tutorialsCommand;
            this.moviesButton.Name = "moviesButton";
            this.moviesButton.Text = "Movie Tutorials";
            // 
            // tutorialsCommand
            // 
            this.tutorialsCommand.Name = "tutorialsCommand";
            this.tutorialsCommand.Executed += new System.EventHandler(this.tutorialsCommand_Executed);
            // 
            // kbButton
            // 
            this.kbButton.Command = this.kbCommand;
            this.kbButton.Name = "kbButton";
            this.kbButton.Text = "Knowledge Base";
            // 
            // kbCommand
            // 
            this.kbCommand.Name = "kbCommand";
            this.kbCommand.Executed += new System.EventHandler(this.kbCommand_Executed);
            // 
            // buttonItem1
            // 
            this.buttonItem1.Command = this.testimonialsCommand;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "Testimonials";
            // 
            // testimonialsCommand
            // 
            this.testimonialsCommand.Name = "testimonialsCommand";
            this.testimonialsCommand.Executed += new System.EventHandler(this.testimonialsCommand_Executed);
            // 
            // devcoButton
            // 
            this.devcoButton.Command = this.devcoCommand;
            this.devcoButton.Name = "devcoButton";
            this.devcoButton.Text = "DevComponents.com";
            // 
            // devcoCommand
            // 
            this.devcoCommand.Name = "devcoCommand";
            this.devcoCommand.Executed += new System.EventHandler(this.devcoCommand_Executed);
            // 
            // versionLabel
            // 
            this.versionLabel.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Text = "Version: 10.0.0.0";
            // 
            // metroShell1
            // 
            this.metroShell1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroShell1.CaptionVisible = true;
            this.metroShell1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroShell1.ForeColor = System.Drawing.Color.Black;
            this.metroShell1.HelpButtonText = "Open Samples Source Code Folder";
            this.metroShell1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.metroShell1.Location = new System.Drawing.Point(0, 1);
            this.metroShell1.Name = "metroShell1";
            this.metroShell1.SettingsButtonVisible = false;
            this.metroShell1.Size = new System.Drawing.Size(791, 41);
            this.metroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.metroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.metroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.metroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.metroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.metroShell1.SystemText.QatDialogAddButton = "&Add >>";
            this.metroShell1.SystemText.QatDialogCancelButton = "Cancel";
            this.metroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.metroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.metroShell1.SystemText.QatDialogOkButton = "OK";
            this.metroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatDialogRemoveButton = "&Remove";
            this.metroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.metroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.metroShell1.TabIndex = 1;
            this.metroShell1.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroShell1.HelpButtonClick += new System.EventHandler(this.metroShell1_HelpButtonClick);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // pageTitleLabel
            // 
            this.pageTitleLabel.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.pageTitleLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pageTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.pageTitleLabel.Location = new System.Drawing.Point(0, 42);
            this.pageTitleLabel.Name = "pageTitleLabel";
            this.pageTitleLabel.PaddingLeft = 16;
            this.pageTitleLabel.Size = new System.Drawing.Size(791, 33);
            this.pageTitleLabel.TabIndex = 2;
            this.pageTitleLabel.Text = "Metro and Ribbon Controls";
            this.pageTitleLabel.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Command = this.page1Command;
            this.buttonX1.CommandParameter = "";
            this.buttonX1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(246, 402);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(50, 35);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "1";
            // 
            // page1Command
            // 
            this.page1Command.Name = "page1Command";
            this.page1Command.Executed += new System.EventHandler(this.page1Command_Executed);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Command = this.page2Command;
            this.buttonX2.CommandParameter = "";
            this.buttonX2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX2.Location = new System.Drawing.Point(302, 402);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(50, 35);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 4;
            this.buttonX2.Text = "2";
            // 
            // page2Command
            // 
            this.page2Command.Name = "page2Command";
            this.page2Command.Executed += new System.EventHandler(this.page2Command_Executed);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Command = this.page3Command;
            this.buttonX3.CommandParameter = "";
            this.buttonX3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX3.Location = new System.Drawing.Point(358, 402);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(50, 35);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 5;
            this.buttonX3.Text = "3";
            // 
            // page3Command
            // 
            this.page3Command.Name = "page3Command";
            this.page3Command.Executed += new System.EventHandler(this.page3Command_Executed);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Command = this.page4Command;
            this.buttonX4.CommandParameter = "";
            this.buttonX4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX4.Location = new System.Drawing.Point(414, 402);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(50, 35);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 6;
            this.buttonX4.Text = "4";
            // 
            // page4Command
            // 
            this.page4Command.Name = "page4Command";
            this.page4Command.Executed += new System.EventHandler(this.page4Command_Executed);
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX5.Command = this.page5Command;
            this.buttonX5.CommandParameter = "";
            this.buttonX5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX5.Location = new System.Drawing.Point(470, 402);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(50, 35);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.TabIndex = 7;
            this.buttonX5.Text = "5";
            // 
            // page5Command
            // 
            this.page5Command.Name = "page5Command";
            this.page5Command.Executed += new System.EventHandler(this.page5Command_Executed);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(116, 414);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(124, 14);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Choose Samples Page:";
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Command = this.page6Command;
            this.buttonX6.CommandParameter = "";
            this.buttonX6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX6.Location = new System.Drawing.Point(526, 402);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(50, 35);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.TabIndex = 10;
            this.buttonX6.Text = "6";
            // 
            // page6Command
            // 
            this.page6Command.Name = "page6Command";
            this.page6Command.Executed += new System.EventHandler(this.page6Command_Executed);
            // 
            // runCommand
            // 
            this.runCommand.Name = "runCommand";
            this.runCommand.Executed += new System.EventHandler(this.runCommand_Executed);
            // 
            // pageSlider1
            // 
            this.pageSlider1.AnimationTime = 250;
            this.pageSlider1.BackColor = System.Drawing.Color.White;
            this.pageSlider1.Controls.Add(this.pageSliderPage1);
            this.pageSlider1.Controls.Add(this.pageSliderPage2);
            this.pageSlider1.Controls.Add(this.pageSliderPage3);
            this.pageSlider1.Controls.Add(this.pageSliderPage4);
            this.pageSlider1.Controls.Add(this.pageSliderPage5);
            this.pageSlider1.Controls.Add(this.pageSliderPage6);
            this.pageSlider1.ForeColor = System.Drawing.Color.Black;
            this.pageSlider1.IndicatorVisible = false;
            this.pageSlider1.Location = new System.Drawing.Point(43, 81);
            this.pageSlider1.Name = "pageSlider1";
            this.pageSlider1.SelectedPage = this.pageSliderPage1;
            this.pageSlider1.Size = new System.Drawing.Size(681, 314);
            this.pageSlider1.TabIndex = 11;
            this.pageSlider1.Text = "pageSlider1";
            this.pageSlider1.SelectedPageChanged += new System.EventHandler(this.pageSlider1_SelectedPageChanged);
            // 
            // pageSliderPage1
            // 
            this.pageSliderPage1.BackColor = System.Drawing.Color.White;
            this.pageSliderPage1.Controls.Add(this.page11);
            this.pageSliderPage1.ForeColor = System.Drawing.Color.Black;
            this.pageSliderPage1.Location = new System.Drawing.Point(4, 4);
            this.pageSliderPage1.Name = "pageSliderPage1";
            this.pageSliderPage1.Size = new System.Drawing.Size(575, 306);
            this.pageSliderPage1.TabIndex = 3;
            // 
            // page11
            // 
            this.page11.BackColor = System.Drawing.Color.White;
            this.page11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page11.ForeColor = System.Drawing.Color.Black;
            this.page11.Location = new System.Drawing.Point(0, 0);
            this.page11.Name = "page11";
            this.page11.RunSampleCommand = null;
            this.page11.Size = new System.Drawing.Size(575, 306);
            this.page11.SlideOutButtonVisible = false;
            this.page11.TabIndex = 0;
            this.page11.Tag = "Metro and Ribbon Controls";
            this.page11.UsesBlockingAnimation = false;
            // 
            // pageSliderPage2
            // 
            this.pageSliderPage2.BackColor = System.Drawing.Color.White;
            this.pageSliderPage2.Controls.Add(this.page21);
            this.pageSliderPage2.ForeColor = System.Drawing.Color.Black;
            this.pageSliderPage2.Location = new System.Drawing.Point(627, 4);
            this.pageSliderPage2.Name = "pageSliderPage2";
            this.pageSliderPage2.Size = new System.Drawing.Size(575, 306);
            this.pageSliderPage2.TabIndex = 4;
            // 
            // page21
            // 
            this.page21.BackColor = System.Drawing.Color.White;
            this.page21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page21.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page21.ForeColor = System.Drawing.Color.Black;
            this.page21.Location = new System.Drawing.Point(0, 0);
            this.page21.Name = "page21";
            this.page21.RunSampleCommand = null;
            this.page21.Size = new System.Drawing.Size(575, 306);
            this.page21.TabIndex = 0;
            this.page21.UsesBlockingAnimation = false;
            // 
            // pageSliderPage3
            // 
            this.pageSliderPage3.BackColor = System.Drawing.Color.White;
            this.pageSliderPage3.Controls.Add(this.page31);
            this.pageSliderPage3.ForeColor = System.Drawing.Color.Black;
            this.pageSliderPage3.Location = new System.Drawing.Point(1250, 4);
            this.pageSliderPage3.Name = "pageSliderPage3";
            this.pageSliderPage3.Size = new System.Drawing.Size(575, 306);
            this.pageSliderPage3.TabIndex = 5;
            // 
            // page31
            // 
            this.page31.BackColor = System.Drawing.Color.White;
            this.page31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page31.ForeColor = System.Drawing.Color.Black;
            this.page31.Location = new System.Drawing.Point(0, 0);
            this.page31.Name = "page31";
            this.page31.RunSampleCommand = null;
            this.page31.Size = new System.Drawing.Size(575, 306);
            this.page31.TabIndex = 0;
            this.page31.UsesBlockingAnimation = false;
            // 
            // pageSliderPage4
            // 
            this.pageSliderPage4.BackColor = System.Drawing.Color.White;
            this.pageSliderPage4.Controls.Add(this.page41);
            this.pageSliderPage4.ForeColor = System.Drawing.Color.Black;
            this.pageSliderPage4.Location = new System.Drawing.Point(1873, 4);
            this.pageSliderPage4.Name = "pageSliderPage4";
            this.pageSliderPage4.Size = new System.Drawing.Size(575, 306);
            this.pageSliderPage4.TabIndex = 6;
            // 
            // page41
            // 
            this.page41.BackColor = System.Drawing.Color.White;
            this.page41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page41.ForeColor = System.Drawing.Color.Black;
            this.page41.Location = new System.Drawing.Point(0, 0);
            this.page41.Name = "page41";
            this.page41.RunSampleCommand = null;
            this.page41.Size = new System.Drawing.Size(575, 306);
            this.page41.TabIndex = 0;
            this.page41.UsesBlockingAnimation = false;
            // 
            // pageSliderPage5
            // 
            this.pageSliderPage5.BackColor = System.Drawing.Color.White;
            this.pageSliderPage5.Controls.Add(this.page51);
            this.pageSliderPage5.ForeColor = System.Drawing.Color.Black;
            this.pageSliderPage5.Location = new System.Drawing.Point(2496, 4);
            this.pageSliderPage5.Name = "pageSliderPage5";
            this.pageSliderPage5.Size = new System.Drawing.Size(575, 306);
            this.pageSliderPage5.TabIndex = 7;
            // 
            // page51
            // 
            this.page51.BackColor = System.Drawing.Color.White;
            this.page51.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page51.ForeColor = System.Drawing.Color.Black;
            this.page51.Location = new System.Drawing.Point(0, 0);
            this.page51.Name = "page51";
            this.page51.RunSampleCommand = null;
            this.page51.Size = new System.Drawing.Size(575, 306);
            this.page51.TabIndex = 0;
            this.page51.UsesBlockingAnimation = false;
            // 
            // pageSliderPage6
            // 
            this.pageSliderPage6.BackColor = System.Drawing.Color.White;
            this.pageSliderPage6.Controls.Add(this.page61);
            this.pageSliderPage6.ForeColor = System.Drawing.Color.Black;
            this.pageSliderPage6.Location = new System.Drawing.Point(3119, 4);
            this.pageSliderPage6.Name = "pageSliderPage6";
            this.pageSliderPage6.Size = new System.Drawing.Size(575, 306);
            this.pageSliderPage6.TabIndex = 8;
            // 
            // page61
            // 
            this.page61.BackColor = System.Drawing.Color.White;
            this.page61.ForeColor = System.Drawing.Color.Black;
            this.page61.Location = new System.Drawing.Point(0, 0);
            this.page61.Name = "page61";
            this.page61.RunSampleCommand = null;
            this.page61.Size = new System.Drawing.Size(578, 307);
            this.page61.TabIndex = 0;
            this.page61.UsesBlockingAnimation = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 476);
            this.Controls.Add(this.pageSlider1);
            this.Controls.Add(this.buttonX6);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.buttonX5);
            this.Controls.Add(this.buttonX4);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.pageTitleLabel);
            this.Controls.Add(this.metroShell1);
            this.Controls.Add(this.metroStatusBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "DotNetBar for WinForms Samples Explorer";
            this.pageSlider1.ResumeLayout(false);
            this.pageSliderPage1.ResumeLayout(false);
            this.pageSliderPage2.ResumeLayout(false);
            this.pageSliderPage3.ResumeLayout(false);
            this.pageSliderPage4.ResumeLayout(false);
            this.pageSliderPage5.ResumeLayout(false);
            this.pageSliderPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.ButtonItem buyButton;
        private DevComponents.DotNetBar.ButtonItem moviesButton;
        private DevComponents.DotNetBar.ButtonItem kbButton;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem devcoButton;
        private DevComponents.DotNetBar.LabelItem versionLabel;
        private DevComponents.DotNetBar.Metro.MetroShell metroShell1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.LabelX pageTitleLabel;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Command page1Command;
        private DevComponents.DotNetBar.Command page2Command;
        private DevComponents.DotNetBar.Command page3Command;
        private DevComponents.DotNetBar.Command page4Command;
        private DevComponents.DotNetBar.Command page5Command;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.Command page6Command;
        private DevComponents.DotNetBar.Command buyDotNetBarCommand;
        private DevComponents.DotNetBar.Command tutorialsCommand;
        private DevComponents.DotNetBar.Command kbCommand;
        private DevComponents.DotNetBar.Command testimonialsCommand;
        private DevComponents.DotNetBar.Command devcoCommand;
        private DevComponents.DotNetBar.Command runCommand;
        private DevComponents.DotNetBar.Controls.PageSlider pageSlider1;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage1;
        private Page1 page11;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage2;
        private Page2 page21;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage3;
        private Page3 page31;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage4;
        private Page4 page41;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage5;
        private Page5 page51;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage6;
        private Page6 page61;
    }
}

