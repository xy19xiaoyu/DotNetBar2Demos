using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;

namespace NavigationPane
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Office2007Form
	{
		private DevComponents.DotNetBar.NavigationPane navigationPane1;
		private DevComponents.DotNetBar.ButtonItem buttonItem1;
		private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel1;
		private DevComponents.DotNetBar.ButtonItem buttonItem2;
		private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel2;
		private DevComponents.DotNetBar.ButtonItem buttonItem3;
		private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel3;
		private DevComponents.DotNetBar.ButtonItem buttonItem4;
		private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel4;
		private DevComponents.DotNetBar.ButtonItem buttonItem5;
		private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel5;
		private System.Windows.Forms.TreeView treeView1;
		private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.ImageList imageList1;
		private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
		private System.Windows.Forms.TextBox textEvents;
        private StyleManager styleManager1;
        private Bar bar1;
        private ButtonItem buttonItem6;
        private CheckBoxItem checkBoxItem1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Deleted Items", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Drafts", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Inbox", 1, 1);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Outbox", 1, 1);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Sent Items", 1, 1);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Personal Folders", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.navigationPane1 = new DevComponents.DotNetBar.NavigationPane();
            this.navigationPanePanel1 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPanePanel2 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPanePanel3 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPanePanel5 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPanePanel4 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.textEvents = new System.Windows.Forms.TextBox();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.checkBoxItem1 = new DevComponents.DotNetBar.CheckBoxItem();
            this.navigationPane1.SuspendLayout();
            this.navigationPanePanel1.SuspendLayout();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.CanCollapse = true;
            this.navigationPane1.Controls.Add(this.navigationPanePanel1);
            this.navigationPane1.Controls.Add(this.navigationPanePanel2);
            this.navigationPane1.Controls.Add(this.navigationPanePanel3);
            this.navigationPane1.Controls.Add(this.navigationPanePanel5);
            this.navigationPane1.Controls.Add(this.navigationPanePanel4);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.ItemPaddingBottom = 2;
            this.navigationPane1.ItemPaddingTop = 2;
            this.navigationPane1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem2,
            this.buttonItem3,
            this.buttonItem4,
            this.buttonItem5});
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.NavigationBarHeight = 172;
            this.navigationPane1.Size = new System.Drawing.Size(184, 440);
            this.navigationPane1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationPane1.TabIndex = 0;
            // 
            // 
            // 
            this.navigationPane1.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.navigationPane1.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPane1.TitlePanel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPane1.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.TitlePanel.Name = "panelEx1";
            this.navigationPane1.TitlePanel.Size = new System.Drawing.Size(184, 24);
            this.navigationPane1.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPane1.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPane1.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.navigationPane1.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPane1.TitlePanel.Style.GradientAngle = 90;
            this.navigationPane1.TitlePanel.Style.MarginLeft = 4;
            this.navigationPane1.TitlePanel.TabIndex = 0;
            this.navigationPane1.TitlePanel.Text = "Mail";
            this.navigationPane1.ExpandedChanging += new DevComponents.DotNetBar.ExpandChangeEventHandler(this.navigationPane1_ExpandedChanging);
            this.navigationPane1.PanelChanging += new DevComponents.DotNetBar.PanelChangingEventHandler(this.navigationPane1_PanelChanging);
            this.navigationPane1.BeforePanelPopup += new DevComponents.DotNetBar.PanelPopupEventHandler(this.navigationPane1_BeforePanelPopup);
            this.navigationPane1.ExpandedChanged += new DevComponents.DotNetBar.ExpandChangeEventHandler(this.navigationPane1_ExpandedChanged);
            this.navigationPane1.ItemClick += new System.EventHandler(this.navigationPane1_ItemClick);
            // 
            // navigationPanePanel1
            // 
            this.navigationPanePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.navigationPanePanel1.Controls.Add(this.treeView1);
            this.navigationPanePanel1.Controls.Add(this.panelEx1);
            this.navigationPanePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel1.Location = new System.Drawing.Point(0, 24);
            this.navigationPanePanel1.Name = "navigationPanePanel1";
            this.navigationPanePanel1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.navigationPanePanel1.ParentItem = this.buttonItem1;
            this.navigationPanePanel1.Size = new System.Drawing.Size(184, 244);
            this.navigationPanePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navigationPanePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navigationPanePanel1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
            this.navigationPanePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.navigationPanePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navigationPanePanel1.Style.GradientAngle = 90;
            this.navigationPanePanel1.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel1.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(1, 21);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Deleted Items";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Drafts";
            treeNode3.ImageIndex = 1;
            treeNode3.Name = "";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Inbox";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "Outbox";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "";
            treeNode5.SelectedImageIndex = 1;
            treeNode5.Text = "Sent Items";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "";
            treeNode6.SelectedImageIndex = 0;
            treeNode6.Text = "Personal Folders";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView1.Scrollable = false;
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(182, 223);
            this.treeView1.Sorted = true;
            this.treeView1.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            // 
            // panelEx1
            // 
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(1, 1);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(182, 20);
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.Style.MarginLeft = 4;
            this.panelEx1.TabIndex = 2;
            this.panelEx1.Text = "Mail Folders";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Checked = true;
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.OptionGroup = "navBar";
            this.buttonItem1.SubItemsExpandWidth = 11;
            this.buttonItem1.Text = "Mail";
            this.buttonItem1.Tooltip = "Click to manage Mail";
            // 
            // navigationPanePanel2
            // 
            this.navigationPanePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.navigationPanePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel2.Location = new System.Drawing.Point(0, 0);
            this.navigationPanePanel2.Name = "navigationPanePanel2";
            this.navigationPanePanel2.ParentItem = this.buttonItem2;
            this.navigationPanePanel2.Size = new System.Drawing.Size(184, 268);
            this.navigationPanePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navigationPanePanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navigationPanePanel2.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
            this.navigationPanePanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.navigationPanePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navigationPanePanel2.Style.GradientAngle = 90;
            this.navigationPanePanel2.Style.WordWrap = true;
            this.navigationPanePanel2.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel2.StyleMouseDown.WordWrap = true;
            this.navigationPanePanel2.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel2.StyleMouseOver.WordWrap = true;
            this.navigationPanePanel2.TabIndex = 3;
            this.navigationPanePanel2.Text = "Drop your controls here and erase Text property";
            // 
            // buttonItem2
            // 
            this.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem2.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem2.Image")));
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.OptionGroup = "navBar";
            this.buttonItem2.SubItemsExpandWidth = 11;
            this.buttonItem2.Text = "Calendar";
            this.buttonItem2.Tooltip = "Click to view your Calendar";
            // 
            // navigationPanePanel3
            // 
            this.navigationPanePanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.navigationPanePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel3.Location = new System.Drawing.Point(0, 0);
            this.navigationPanePanel3.Name = "navigationPanePanel3";
            this.navigationPanePanel3.ParentItem = this.buttonItem3;
            this.navigationPanePanel3.Size = new System.Drawing.Size(184, 268);
            this.navigationPanePanel3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navigationPanePanel3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navigationPanePanel3.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
            this.navigationPanePanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.navigationPanePanel3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navigationPanePanel3.Style.GradientAngle = 90;
            this.navigationPanePanel3.Style.WordWrap = true;
            this.navigationPanePanel3.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel3.StyleMouseDown.WordWrap = true;
            this.navigationPanePanel3.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel3.StyleMouseOver.WordWrap = true;
            this.navigationPanePanel3.TabIndex = 4;
            this.navigationPanePanel3.Text = "Drop your controls here and erase Text property";
            // 
            // buttonItem3
            // 
            this.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem3.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem3.Image")));
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.OptionGroup = "navBar";
            this.buttonItem3.SubItemsExpandWidth = 11;
            this.buttonItem3.Text = "Contacts";
            this.buttonItem3.Tooltip = "Click to view your Contacts";
            // 
            // navigationPanePanel5
            // 
            this.navigationPanePanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.navigationPanePanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel5.Location = new System.Drawing.Point(0, 0);
            this.navigationPanePanel5.Name = "navigationPanePanel5";
            this.navigationPanePanel5.ParentItem = this.buttonItem5;
            this.navigationPanePanel5.Size = new System.Drawing.Size(184, 268);
            this.navigationPanePanel5.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navigationPanePanel5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navigationPanePanel5.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
            this.navigationPanePanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.navigationPanePanel5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navigationPanePanel5.Style.GradientAngle = 90;
            this.navigationPanePanel5.Style.WordWrap = true;
            this.navigationPanePanel5.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel5.StyleMouseDown.WordWrap = true;
            this.navigationPanePanel5.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel5.StyleMouseOver.WordWrap = true;
            this.navigationPanePanel5.TabIndex = 6;
            this.navigationPanePanel5.Text = "Drop your controls here and erase Text property";
            // 
            // buttonItem5
            // 
            this.buttonItem5.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem5.Image")));
            this.buttonItem5.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.OptionGroup = "navBar";
            this.buttonItem5.SubItemsExpandWidth = 11;
            this.buttonItem5.Text = "Notes";
            // 
            // navigationPanePanel4
            // 
            this.navigationPanePanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.navigationPanePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel4.Location = new System.Drawing.Point(0, 0);
            this.navigationPanePanel4.Name = "navigationPanePanel4";
            this.navigationPanePanel4.ParentItem = this.buttonItem4;
            this.navigationPanePanel4.Size = new System.Drawing.Size(184, 268);
            this.navigationPanePanel4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navigationPanePanel4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navigationPanePanel4.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
            this.navigationPanePanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.navigationPanePanel4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navigationPanePanel4.Style.GradientAngle = 90;
            this.navigationPanePanel4.Style.WordWrap = true;
            this.navigationPanePanel4.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel4.StyleMouseDown.WordWrap = true;
            this.navigationPanePanel4.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel4.StyleMouseOver.WordWrap = true;
            this.navigationPanePanel4.TabIndex = 5;
            this.navigationPanePanel4.Text = "Drop your controls here and erase Text property";
            // 
            // buttonItem4
            // 
            this.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem4.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem4.Image")));
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.OptionGroup = "navBar";
            this.buttonItem4.SubItemsExpandWidth = 11;
            this.buttonItem4.Text = "Tasks";
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel1.Controls.Add(this.textEvents);
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.expandablePanel1.Location = new System.Drawing.Point(184, 243);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(379, 197);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.expandablePanel1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 2;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Navigation Pane Events";
            // 
            // textEvents
            // 
            this.textEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEvents.Location = new System.Drawing.Point(0, 26);
            this.textEvents.Multiline = true;
            this.textEvents.Name = "textEvents";
            this.textEvents.Size = new System.Drawing.Size(379, 171);
            this.textEvents.TabIndex = 1;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem6,
            this.checkBoxItem1});
            this.bar1.Location = new System.Drawing.Point(184, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(379, 25);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 3;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // buttonItem6
            // 
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.Text = "Toggle State";
            this.buttonItem6.Click += new System.EventHandler(this.buttonItem6_Click);
            // 
            // checkBoxItem1
            // 
            this.checkBoxItem1.Checked = true;
            this.checkBoxItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxItem1.Name = "checkBoxItem1";
            this.checkBoxItem1.Text = "Allow Collapse";
            this.checkBoxItem1.CheckedChanged += new DevComponents.DotNetBar.CheckBoxChangeEventHandler(this.checkBoxItem1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(563, 440);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.navigationPane1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "Form1";
            this.Text = "DotNetBar Navigation Pane Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Closed += new System.EventHandler(this.Form1_Closed);
            this.navigationPane1.ResumeLayout(false);
            this.navigationPanePanel1.ResumeLayout(false);
            this.expandablePanel1.ResumeLayout(false);
            this.expandablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// Load user layout file if it exists
			if(Environment.UserName!="")
			{
				if(System.IO.File.Exists(Environment.UserName +".xml"))
				{
					navigationPane1.LoadLayout(Environment.UserName +".xml");
				}
			}

			treeView1.ExpandAll();
		}

		private void Form1_Closed(object sender, System.EventArgs e)
		{
			// Save Navigation Pane Layout 
			if(Environment.UserName!="")
			{
                try
                {
                    navigationPane1.SaveLayout(Environment.UserName + ".xml");
                }
                catch (UnauthorizedAccessException)
                {
                    // Ignore the access exceptions...
                }
			}
		}

		private void navigationPane1_BeforePanelPopup(object sender, DevComponents.DotNetBar.PanelPopupEventArgs e)
		{
			textEvents.Text+=DateTime.Now.ToString()+" - BeforePanelPopup\r\n";
		}

		private void navigationPane1_PanelChanging(object sender, DevComponents.DotNetBar.PanelChangingEventArgs e)
		{
			textEvents.Text+=DateTime.Now.ToString()+" - PanelChanging\r\n";
		}

		private void navigationPane1_ItemClick(object sender, System.EventArgs e)
		{
			textEvents.Text+=DateTime.Now.ToString()+" - ItemClick\r\n";
		}

		private void navigationPane1_ExpandedChanging(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
		{
			textEvents.Text+=DateTime.Now.ToString()+" - ExpandedChanging\r\n";
		}

		private void navigationPane1_ExpandedChanged(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
		{
			textEvents.Text+=DateTime.Now.ToString()+" - ExpandedChanged\r\n";
		}

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            navigationPane1.Expanded = !navigationPane1.Expanded;
        }

        private void checkBoxItem1_CheckedChanged(object sender, CheckBoxChangeEventArgs e)
        {
            navigationPane1.CanCollapse = checkBoxItem1.Checked;
        }
	}
}
