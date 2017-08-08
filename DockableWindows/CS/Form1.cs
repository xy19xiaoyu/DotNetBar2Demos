using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;

namespace DockableWindows
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevComponents.DotNetBar.DotNetBarManager dotNetBarManager1;
		private DevComponents.DotNetBar.DockSite barLeftDockSite;
		private DevComponents.DotNetBar.DockSite barRightDockSite;
		private DevComponents.DotNetBar.DockSite barTopDockSite;
		private DevComponents.DotNetBar.DockSite barBottomDockSite;
		private System.Windows.Forms.ImageList imageList1;
		private DevComponents.DotNetBar.DockSite dockSite1;
		private System.ComponentModel.IContainer components;
		private int m_DocumentCount=0;
		private DevComponents.DotNetBar.DockSite dockSite2;
		private DevComponents.DotNetBar.DockSite dockSite3;
		private DevComponents.DotNetBar.DockSite dockSite4;
		private DevComponents.DotNetBar.DockSite dockSite5;
		private DevComponents.DotNetBar.Bar mainmenu;
		private DevComponents.DotNetBar.ButtonItem item_67;
		private DevComponents.DotNetBar.ButtonItem item_78;
		private DevComponents.DotNetBar.ButtonItem item_89;
		private DevComponents.DotNetBar.ButtonItem item_100;
		private DevComponents.DotNetBar.ButtonItem item_111;
		private DevComponents.DotNetBar.ButtonItem item_122;
		private DevComponents.DotNetBar.ButtonItem item_133;
		private DevComponents.DotNetBar.ButtonItem item_144;
		private DevComponents.DotNetBar.ButtonItem item_155;
		private DevComponents.DotNetBar.ButtonItem item_166;
		private DevComponents.DotNetBar.ButtonItem item_167;
		private DevComponents.DotNetBar.ButtonItem item_237;
		private DevComponents.DotNetBar.ButtonItem item_248;
		private DevComponents.DotNetBar.ButtonItem item_259;
		private DevComponents.DotNetBar.ButtonItem item_270;
		private DevComponents.DotNetBar.ButtonItem item_281;
		private DevComponents.DotNetBar.ButtonItem item_292;
		private DevComponents.DotNetBar.ButtonItem item_303;
		private DevComponents.DotNetBar.Bar bar4;
		private DevComponents.DotNetBar.ButtonItem buttonNew;
		private DevComponents.DotNetBar.ButtonItem item_364;
		private DevComponents.DotNetBar.ButtonItem item_365;
		private DevComponents.DotNetBar.ButtonItem item_366;
		private DevComponents.DotNetBar.ButtonItem item_367;
		private DevComponents.DotNetBar.ButtonItem item_368;
		private DevComponents.DotNetBar.ButtonItem item_369;
		private DevComponents.DotNetBar.ButtonItem item_370;
		private DevComponents.DotNetBar.ButtonItem item_371;
		private DevComponents.DotNetBar.ButtonItem item_372;
		private DevComponents.DotNetBar.ButtonItem item_373;
		private DevComponents.DotNetBar.ButtonItem item_374;
		private DevComponents.DotNetBar.ComboBoxItem item_388;
		private DevComponents.DotNetBar.ButtonItem item_389;
		private DevComponents.DotNetBar.ComboBoxItem item_403;
		private DevComponents.DotNetBar.ButtonItem item_404;
		private DevComponents.DotNetBar.ButtonItem item_405;
		private DevComponents.DotNetBar.ButtonItem item_407;
		private DevComponents.DotNetBar.ButtonItem item_408;
		private DevComponents.DotNetBar.Bar bar2;
		private DevComponents.DotNetBar.DockContainerItem dTaskList;
		private DevComponents.DotNetBar.DockContainerItem dOutput;
		private DevComponents.DotNetBar.PanelDockContainer panelDockContainer1;
		private DevComponents.DotNetBar.PanelDockContainer panelDockContainer2;
		private DevComponents.DotNetBar.Bar barSolutionExplorer;
		private DevComponents.DotNetBar.DockContainerItem dSolutionExplorer;
		private DevComponents.DotNetBar.DockContainerItem dSolutionProperties;
		private DevComponents.DotNetBar.PanelDockContainer panelDockContainer3;
		private DevComponents.DotNetBar.PanelDockContainer panelDockContainer4;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.TreeView treeView1;
		private DevComponents.DotNetBar.Bar bar1;
		private DevComponents.DotNetBar.ButtonItem item_61;
		private DevComponents.DotNetBar.ButtonItem item_239;
		private DevComponents.DotNetBar.ButtonItem item_299;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private int m_UniqueBarCount=0;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.dotNetBarManager1 = new DevComponents.DotNetBar.DotNetBarManager(this.components);
			this.barBottomDockSite = new DevComponents.DotNetBar.DockSite();
			this.bar2 = new DevComponents.DotNetBar.Bar();
			this.panelDockContainer1 = new DevComponents.DotNetBar.PanelDockContainer();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.panelDockContainer2 = new DevComponents.DotNetBar.PanelDockContainer();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dTaskList = new DevComponents.DotNetBar.DockContainerItem();
			this.dOutput = new DevComponents.DotNetBar.DockContainerItem();
			this.dockSite1 = new DevComponents.DotNetBar.DockSite();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.barLeftDockSite = new DevComponents.DotNetBar.DockSite();
			this.barRightDockSite = new DevComponents.DotNetBar.DockSite();
			this.barSolutionExplorer = new DevComponents.DotNetBar.Bar();
			this.panelDockContainer3 = new DevComponents.DotNetBar.PanelDockContainer();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.bar1 = new DevComponents.DotNetBar.Bar();
			this.item_61 = new DevComponents.DotNetBar.ButtonItem();
			this.item_239 = new DevComponents.DotNetBar.ButtonItem();
			this.item_299 = new DevComponents.DotNetBar.ButtonItem();
			this.panelDockContainer4 = new DevComponents.DotNetBar.PanelDockContainer();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.dSolutionExplorer = new DevComponents.DotNetBar.DockContainerItem();
			this.dSolutionProperties = new DevComponents.DotNetBar.DockContainerItem();
			this.dockSite5 = new DevComponents.DotNetBar.DockSite();
			this.dockSite2 = new DevComponents.DotNetBar.DockSite();
			this.dockSite3 = new DevComponents.DotNetBar.DockSite();
			this.dockSite4 = new DevComponents.DotNetBar.DockSite();
			this.mainmenu = new DevComponents.DotNetBar.Bar();
			this.item_67 = new DevComponents.DotNetBar.ButtonItem();
			this.item_78 = new DevComponents.DotNetBar.ButtonItem();
			this.item_89 = new DevComponents.DotNetBar.ButtonItem();
			this.item_100 = new DevComponents.DotNetBar.ButtonItem();
			this.item_111 = new DevComponents.DotNetBar.ButtonItem();
			this.item_122 = new DevComponents.DotNetBar.ButtonItem();
			this.item_133 = new DevComponents.DotNetBar.ButtonItem();
			this.item_144 = new DevComponents.DotNetBar.ButtonItem();
			this.item_155 = new DevComponents.DotNetBar.ButtonItem();
			this.item_166 = new DevComponents.DotNetBar.ButtonItem();
			this.item_167 = new DevComponents.DotNetBar.ButtonItem();
			this.item_237 = new DevComponents.DotNetBar.ButtonItem();
			this.item_248 = new DevComponents.DotNetBar.ButtonItem();
			this.item_259 = new DevComponents.DotNetBar.ButtonItem();
			this.item_270 = new DevComponents.DotNetBar.ButtonItem();
			this.item_281 = new DevComponents.DotNetBar.ButtonItem();
			this.item_292 = new DevComponents.DotNetBar.ButtonItem();
			this.item_303 = new DevComponents.DotNetBar.ButtonItem();
			this.bar4 = new DevComponents.DotNetBar.Bar();
			this.buttonNew = new DevComponents.DotNetBar.ButtonItem();
			this.item_364 = new DevComponents.DotNetBar.ButtonItem();
			this.item_365 = new DevComponents.DotNetBar.ButtonItem();
			this.item_366 = new DevComponents.DotNetBar.ButtonItem();
			this.item_367 = new DevComponents.DotNetBar.ButtonItem();
			this.item_368 = new DevComponents.DotNetBar.ButtonItem();
			this.item_369 = new DevComponents.DotNetBar.ButtonItem();
			this.item_370 = new DevComponents.DotNetBar.ButtonItem();
			this.item_371 = new DevComponents.DotNetBar.ButtonItem();
			this.item_372 = new DevComponents.DotNetBar.ButtonItem();
			this.item_373 = new DevComponents.DotNetBar.ButtonItem();
			this.item_374 = new DevComponents.DotNetBar.ButtonItem();
			this.item_388 = new DevComponents.DotNetBar.ComboBoxItem();
			this.item_389 = new DevComponents.DotNetBar.ButtonItem();
			this.item_403 = new DevComponents.DotNetBar.ComboBoxItem();
			this.item_404 = new DevComponents.DotNetBar.ButtonItem();
			this.item_405 = new DevComponents.DotNetBar.ButtonItem();
			this.item_407 = new DevComponents.DotNetBar.ButtonItem();
			this.item_408 = new DevComponents.DotNetBar.ButtonItem();
			this.barTopDockSite = new DevComponents.DotNetBar.DockSite();
			this.barBottomDockSite.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
			this.bar2.SuspendLayout();
			this.panelDockContainer1.SuspendLayout();
			this.panelDockContainer2.SuspendLayout();
			this.barRightDockSite.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.barSolutionExplorer)).BeginInit();
			this.barSolutionExplorer.SuspendLayout();
			this.panelDockContainer3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
			this.panelDockContainer4.SuspendLayout();
			this.dockSite4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainmenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bar4)).BeginInit();
			this.SuspendLayout();
			// 
			// dotNetBarManager1
			// 
			this.dotNetBarManager1.BottomDockSite = this.barBottomDockSite;
			this.dotNetBarManager1.DefinitionName = "";
			this.dotNetBarManager1.FillDockSite = this.dockSite1;
			this.dotNetBarManager1.Images = this.imageList1;
			this.dotNetBarManager1.LeftDockSite = this.barLeftDockSite;
			this.dotNetBarManager1.ParentForm = this;
			this.dotNetBarManager1.RightDockSite = this.barRightDockSite;
			this.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
			this.dotNetBarManager1.ToolbarBottomDockSite = this.dockSite5;
			this.dotNetBarManager1.ToolbarLeftDockSite = this.dockSite2;
			this.dotNetBarManager1.ToolbarRightDockSite = this.dockSite3;
			this.dotNetBarManager1.ToolbarTopDockSite = this.dockSite4;
			this.dotNetBarManager1.TopDockSite = this.barTopDockSite;
			this.dotNetBarManager1.ItemClick += new System.EventHandler(this.dotNetBarManager1_ItemClick);
			// 
			// barBottomDockSite
			// 
			this.barBottomDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barBottomDockSite.Controls.AddRange(new System.Windows.Forms.Control[] {
																							this.bar2});
			this.barBottomDockSite.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barBottomDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
																																									 new DevComponents.DotNetBar.DocumentBarContainer(this.bar2, 776, 128)}, DevComponents.DotNetBar.eOrientation.Vertical);
			this.barBottomDockSite.Location = new System.Drawing.Point(0, 323);
			this.barBottomDockSite.Name = "barBottomDockSite";
			this.barBottomDockSite.Size = new System.Drawing.Size(776, 131);
			this.barBottomDockSite.TabIndex = 4;
			this.barBottomDockSite.TabStop = false;
			// 
			// bar2
			// 
			this.bar2.AccessibleDescription = "DotNetBar Bar (bar2)";
			this.bar2.AccessibleName = "DotNetBar Bar";
			this.bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.bar2.AutoHideAnimationTime = 0;
			this.bar2.AutoSyncBarCaption = true;
			this.bar2.CanDockTop = false;
			this.bar2.CloseSingleTab = true;
			this.bar2.Controls.AddRange(new System.Windows.Forms.Control[] {
																			   this.panelDockContainer1,
																			   this.panelDockContainer2});
			this.bar2.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
			this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																				this.dTaskList,
																				this.dOutput});
			this.bar2.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
			this.bar2.Location = new System.Drawing.Point(0, 3);
			this.bar2.Name = "bar2";
			this.bar2.SelectedDockTab = 0;
			this.bar2.Size = new System.Drawing.Size(776, 128);
			this.bar2.Stretch = true;
			this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
			this.bar2.TabIndex = 0;
			this.bar2.TabStop = false;
			this.bar2.Text = "Task List";
			// 
			// panelDockContainer1
			// 
			this.panelDockContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
			this.panelDockContainer1.Controls.AddRange(new System.Windows.Forms.Control[] {
																							  this.listView1});
			this.panelDockContainer1.Location = new System.Drawing.Point(3, 23);
			this.panelDockContainer1.Name = "panelDockContainer1";
			this.panelDockContainer1.Size = new System.Drawing.Size(770, 77);
			this.panelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.panelDockContainer1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.panelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.panelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.panelDockContainer1.Style.GradientAngle = 90;
			this.panelDockContainer1.TabIndex = 1;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader1,
																						this.columnHeader2,
																						this.columnHeader3,
																						this.columnHeader4});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(770, 77);
			this.listView1.TabIndex = 1;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "!";
			this.columnHeader1.Width = 18;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "";
			this.columnHeader2.Width = 18;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Description";
			this.columnHeader3.Width = 128;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "File";
			this.columnHeader4.Width = 256;
			// 
			// panelDockContainer2
			// 
			this.panelDockContainer2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
			this.panelDockContainer2.Controls.AddRange(new System.Windows.Forms.Control[] {
																							  this.textBox1});
			this.panelDockContainer2.Location = new System.Drawing.Point(3, 23);
			this.panelDockContainer2.Name = "panelDockContainer2";
			this.panelDockContainer2.Size = new System.Drawing.Size(770, 77);
			this.panelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.panelDockContainer2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.panelDockContainer2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.panelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.panelDockContainer2.Style.GradientAngle = 90;
			this.panelDockContainer2.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(770, 77);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// dTaskList
			// 
			this.dTaskList.Control = this.panelDockContainer1;
			this.dTaskList.GlobalItem = true;
			this.dTaskList.GlobalName = "dTaskList";
			this.dTaskList.Name = "dTaskList";
			this.dTaskList.Text = "Task List";
			// 
			// dOutput
			// 
			this.dOutput.Control = this.panelDockContainer2;
			this.dOutput.GlobalItem = true;
			this.dOutput.GlobalName = "dOutput";
			this.dOutput.Name = "dOutput";
			this.dOutput.Text = "Output";
			// 
			// dockSite1
			// 
			this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.dockSite1.Location = new System.Drawing.Point(0, 50);
			this.dockSite1.Name = "dockSite1";
			this.dockSite1.Size = new System.Drawing.Size(606, 273);
			this.dockSite1.TabIndex = 6;
			this.dockSite1.TabStop = false;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// barLeftDockSite
			// 
			this.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left;
			this.barLeftDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.barLeftDockSite.Location = new System.Drawing.Point(0, 50);
			this.barLeftDockSite.Name = "barLeftDockSite";
			this.barLeftDockSite.Size = new System.Drawing.Size(0, 273);
			this.barLeftDockSite.TabIndex = 1;
			this.barLeftDockSite.TabStop = false;
			// 
			// barRightDockSite
			// 
			this.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barRightDockSite.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.barSolutionExplorer});
			this.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right;
			this.barRightDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
																																									new DevComponents.DotNetBar.DocumentBarContainer(this.barSolutionExplorer, 167, 273)}, DevComponents.DotNetBar.eOrientation.Horizontal);
			this.barRightDockSite.Location = new System.Drawing.Point(606, 50);
			this.barRightDockSite.Name = "barRightDockSite";
			this.barRightDockSite.Size = new System.Drawing.Size(170, 273);
			this.barRightDockSite.TabIndex = 2;
			this.barRightDockSite.TabStop = false;
			// 
			// barSolutionExplorer
			// 
			this.barSolutionExplorer.AccessibleDescription = "DotNetBar Bar (barSolutionExplorer)";
			this.barSolutionExplorer.AccessibleName = "DotNetBar Bar";
			this.barSolutionExplorer.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.barSolutionExplorer.AutoHideAnimationTime = 0;
			this.barSolutionExplorer.AutoSyncBarCaption = true;
			this.barSolutionExplorer.CanDockTop = false;
			this.barSolutionExplorer.CanHide = true;
			this.barSolutionExplorer.CloseSingleTab = true;
			this.barSolutionExplorer.Controls.AddRange(new System.Windows.Forms.Control[] {
																							  this.panelDockContainer3,
																							  this.panelDockContainer4});
			this.barSolutionExplorer.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Caption;
			this.barSolutionExplorer.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																							   this.dSolutionExplorer,
																							   this.dSolutionProperties});
			this.barSolutionExplorer.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
			this.barSolutionExplorer.Location = new System.Drawing.Point(3, 0);
			this.barSolutionExplorer.Name = "barSolutionExplorer";
			this.barSolutionExplorer.SelectedDockTab = 0;
			this.barSolutionExplorer.Size = new System.Drawing.Size(167, 273);
			this.barSolutionExplorer.Stretch = true;
			this.barSolutionExplorer.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
			this.barSolutionExplorer.TabIndex = 0;
			this.barSolutionExplorer.TabStop = false;
			this.barSolutionExplorer.Text = "Solution Explorer";
			// 
			// panelDockContainer3
			// 
			this.panelDockContainer3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
			this.panelDockContainer3.Controls.AddRange(new System.Windows.Forms.Control[] {
																							  this.treeView1,
																							  this.bar1});
			this.panelDockContainer3.Location = new System.Drawing.Point(3, 23);
			this.panelDockContainer3.Name = "panelDockContainer3";
			this.panelDockContainer3.Size = new System.Drawing.Size(161, 222);
			this.panelDockContainer3.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelDockContainer3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.panelDockContainer3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.panelDockContainer3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.panelDockContainer3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.panelDockContainer3.Style.GradientAngle = 90;
			this.panelDockContainer3.TabIndex = 1;
			// 
			// treeView1
			// 
			this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.HotTracking = true;
			this.treeView1.ImageIndex = 7;
			this.treeView1.ImageList = this.imageList2;
			this.treeView1.Location = new System.Drawing.Point(0, 24);
			this.treeView1.Name = "treeView1";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
																				  new System.Windows.Forms.TreeNode("Solution", 3, 3, new System.Windows.Forms.TreeNode[] {
																																											  new System.Windows.Forms.TreeNode("Project", 4, 4, new System.Windows.Forms.TreeNode[] {
																																																																		 new System.Windows.Forms.TreeNode("File1.cs", 7, 7),
																																																																		 new System.Windows.Forms.TreeNode("File2.cs"),
																																																																		 new System.Windows.Forms.TreeNode("File3.cs")})})});
			this.treeView1.SelectedImageIndex = 7;
			this.treeView1.Size = new System.Drawing.Size(161, 198);
			this.treeView1.TabIndex = 12;
			// 
			// imageList2
			// 
			this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// bar1
			// 
			this.bar1.AccessibleDescription = "Solution Explorer Commands (bar1)";
			this.bar1.AccessibleName = "Solution Explorer Commands";
			this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
			this.bar1.Images = this.imageList2;
			this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																				this.item_61,
																				this.item_239,
																				this.item_299});
			this.bar1.Name = "bar1";
			this.bar1.Size = new System.Drawing.Size(161, 24);
			this.bar1.Stretch = true;
			this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
			this.bar1.TabIndex = 13;
			this.bar1.TabStop = false;
			this.bar1.Text = "Solution Explorer Commands";
			// 
			// item_61
			// 
			this.item_61.GlobalName = "item_61";
			this.item_61.ImageIndex = 0;
			this.item_61.ImagePaddingHorizontal = 8;
			this.item_61.Name = "item_61";
			this.item_61.Text = "&Refresh";
			this.item_61.Tooltip = "Refresh";
			// 
			// item_239
			// 
			this.item_239.BeginGroup = true;
			this.item_239.GlobalName = "item_239";
			this.item_239.ImageIndex = 1;
			this.item_239.ImagePaddingHorizontal = 8;
			this.item_239.Name = "item_239";
			this.item_239.Text = "Show All Files";
			this.item_239.Tooltip = "Show All Files";
			// 
			// item_299
			// 
			this.item_299.BeginGroup = true;
			this.item_299.GlobalName = "item_299";
			this.item_299.ImageIndex = 2;
			this.item_299.ImagePaddingHorizontal = 8;
			this.item_299.Name = "item_299";
			this.item_299.Text = "Properties";
			this.item_299.Tooltip = "Properties";
			// 
			// panelDockContainer4
			// 
			this.panelDockContainer4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
			this.panelDockContainer4.Controls.AddRange(new System.Windows.Forms.Control[] {
																							  this.propertyGrid1});
			this.panelDockContainer4.Location = new System.Drawing.Point(3, 23);
			this.panelDockContainer4.Name = "panelDockContainer4";
			this.panelDockContainer4.Size = new System.Drawing.Size(161, 222);
			this.panelDockContainer4.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelDockContainer4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.panelDockContainer4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.panelDockContainer4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.panelDockContainer4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.panelDockContainer4.Style.GradientAngle = 90;
			this.panelDockContainer4.TabIndex = 2;
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(161, 222);
			this.propertyGrid1.TabIndex = 0;
			this.propertyGrid1.Text = "propertyGrid1";
			this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// dSolutionExplorer
			// 
			this.dSolutionExplorer.Control = this.panelDockContainer3;
			this.dSolutionExplorer.GlobalItem = true;
			this.dSolutionExplorer.GlobalName = "dSolutionExplorer";
			this.dSolutionExplorer.ImageIndex = 0;
			this.dSolutionExplorer.Name = "dSolutionExplorer";
			this.dSolutionExplorer.Text = "Solution Explorer";
			// 
			// dSolutionProperties
			// 
			this.dSolutionProperties.Control = this.panelDockContainer4;
			this.dSolutionProperties.GlobalItem = true;
			this.dSolutionProperties.GlobalName = "dSolutionProperties";
			this.dSolutionProperties.ImageIndex = 1;
			this.dSolutionProperties.Name = "dSolutionProperties";
			this.dSolutionProperties.Text = "Properties";
			// 
			// dockSite5
			// 
			this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dockSite5.Location = new System.Drawing.Point(0, 454);
			this.dockSite5.Name = "dockSite5";
			this.dockSite5.Size = new System.Drawing.Size(776, 0);
			this.dockSite5.TabIndex = 11;
			this.dockSite5.TabStop = false;
			// 
			// dockSite2
			// 
			this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite2.Dock = System.Windows.Forms.DockStyle.Left;
			this.dockSite2.Location = new System.Drawing.Point(0, 50);
			this.dockSite2.Name = "dockSite2";
			this.dockSite2.Size = new System.Drawing.Size(0, 404);
			this.dockSite2.TabIndex = 8;
			this.dockSite2.TabStop = false;
			// 
			// dockSite3
			// 
			this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite3.Dock = System.Windows.Forms.DockStyle.Right;
			this.dockSite3.Location = new System.Drawing.Point(776, 50);
			this.dockSite3.Name = "dockSite3";
			this.dockSite3.Size = new System.Drawing.Size(0, 404);
			this.dockSite3.TabIndex = 9;
			this.dockSite3.TabStop = false;
			// 
			// dockSite4
			// 
			this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite4.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.mainmenu,
																					this.bar4});
			this.dockSite4.Dock = System.Windows.Forms.DockStyle.Top;
			this.dockSite4.Name = "dockSite4";
			this.dockSite4.Size = new System.Drawing.Size(776, 50);
			this.dockSite4.TabIndex = 10;
			this.dockSite4.TabStop = false;
			// 
			// mainmenu
			// 
			this.mainmenu.AccessibleDescription = "DotNetBar Bar (mainmenu)";
			this.mainmenu.AccessibleName = "DotNetBar Bar";
			this.mainmenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
			this.mainmenu.DockSide = DevComponents.DotNetBar.eDockSide.Top;
			this.mainmenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																					this.item_67,
																					this.item_167});
			this.mainmenu.LockDockPosition = true;
			this.mainmenu.MenuBar = true;
			this.mainmenu.Name = "mainmenu";
			this.mainmenu.Size = new System.Drawing.Size(776, 24);
			this.mainmenu.Stretch = true;
			this.mainmenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
			this.mainmenu.TabIndex = 0;
			this.mainmenu.TabStop = false;
			this.mainmenu.Text = "Main Menu";
			// 
			// item_67
			// 
			this.item_67.GlobalName = "item_67";
			this.item_67.ImagePaddingHorizontal = 8;
			this.item_67.Name = "item_67";
			this.item_67.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																					  this.item_78,
																					  this.item_89,
																					  this.item_100,
																					  this.item_111,
																					  this.item_122,
																					  this.item_133,
																					  this.item_144,
																					  this.item_155,
																					  this.item_166});
			this.item_67.Text = "&File";
			// 
			// item_78
			// 
			this.item_78.GlobalName = "item_78";
			this.item_78.ImagePaddingHorizontal = 8;
			this.item_78.Name = "item_78";
			this.item_78.Text = "&New";
			// 
			// item_89
			// 
			this.item_89.GlobalName = "item_89";
			this.item_89.ImageIndex = 10;
			this.item_89.ImagePaddingHorizontal = 8;
			this.item_89.Name = "item_89";
			this.item_89.Text = "&Open";
			// 
			// item_100
			// 
			this.item_100.GlobalName = "item_100";
			this.item_100.ImagePaddingHorizontal = 8;
			this.item_100.Name = "item_100";
			this.item_100.Text = "&Close";
			// 
			// item_111
			// 
			this.item_111.BeginGroup = true;
			this.item_111.GlobalName = "item_111";
			this.item_111.ImagePaddingHorizontal = 8;
			this.item_111.Name = "item_111";
			this.item_111.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlShiftA);
			this.item_111.Text = "Add Ne&w Item";
			// 
			// item_122
			// 
			this.item_122.GlobalName = "item_122";
			this.item_122.ImagePaddingHorizontal = 8;
			this.item_122.Name = "item_122";
			this.item_122.Text = "Add Existin&g Item";
			// 
			// item_133
			// 
			this.item_133.GlobalName = "item_133";
			this.item_133.ImagePaddingHorizontal = 8;
			this.item_133.Name = "item_133";
			this.item_133.Text = "A&dd Project";
			// 
			// item_144
			// 
			this.item_144.BeginGroup = true;
			this.item_144.GlobalName = "item_144";
			this.item_144.ImagePaddingHorizontal = 8;
			this.item_144.Name = "item_144";
			this.item_144.Text = "Open Solution";
			// 
			// item_155
			// 
			this.item_155.GlobalName = "item_155";
			this.item_155.ImagePaddingHorizontal = 8;
			this.item_155.Name = "item_155";
			this.item_155.Text = "Close Solution";
			// 
			// item_166
			// 
			this.item_166.BeginGroup = true;
			this.item_166.GlobalName = "item_166";
			this.item_166.ImagePaddingHorizontal = 8;
			this.item_166.Name = "item_166";
			this.item_166.Text = "&Exit";
			// 
			// item_167
			// 
			this.item_167.GlobalName = "item_167";
			this.item_167.ImagePaddingHorizontal = 8;
			this.item_167.Name = "item_167";
			this.item_167.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																					   this.item_237,
																					   this.item_248,
																					   this.item_259,
																					   this.item_270,
																					   this.item_281,
																					   this.item_292,
																					   this.item_303});
			this.item_167.Text = "&Edit";
			// 
			// item_237
			// 
			this.item_237.GlobalName = "item_237";
			this.item_237.ImagePaddingHorizontal = 8;
			this.item_237.Name = "item_237";
			this.item_237.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
			this.item_237.Text = "&Undo";
			// 
			// item_248
			// 
			this.item_248.GlobalName = "item_248";
			this.item_248.ImagePaddingHorizontal = 8;
			this.item_248.Name = "item_248";
			this.item_248.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
			this.item_248.Text = "&Redo";
			// 
			// item_259
			// 
			this.item_259.BeginGroup = true;
			this.item_259.GlobalName = "item_259";
			this.item_259.ImageIndex = 5;
			this.item_259.ImagePaddingHorizontal = 8;
			this.item_259.Name = "item_259";
			this.item_259.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
			this.item_259.Text = "Cut";
			// 
			// item_270
			// 
			this.item_270.GlobalName = "item_270";
			this.item_270.ImageIndex = 4;
			this.item_270.ImagePaddingHorizontal = 8;
			this.item_270.Name = "item_270";
			this.item_270.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
			this.item_270.Text = "Copy";
			// 
			// item_281
			// 
			this.item_281.GlobalName = "item_281";
			this.item_281.ImageIndex = 11;
			this.item_281.ImagePaddingHorizontal = 8;
			this.item_281.Name = "item_281";
			this.item_281.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
			this.item_281.Text = "Paste";
			// 
			// item_292
			// 
			this.item_292.GlobalName = "item_292";
			this.item_292.ImagePaddingHorizontal = 8;
			this.item_292.Name = "item_292";
			this.item_292.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
			this.item_292.Text = "Delete";
			// 
			// item_303
			// 
			this.item_303.GlobalName = "item_303";
			this.item_303.ImagePaddingHorizontal = 8;
			this.item_303.Name = "item_303";
			this.item_303.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
			this.item_303.Text = "Select All";
			// 
			// bar4
			// 
			this.bar4.AccessibleDescription = "DotNetBar Bar (bar4)";
			this.bar4.AccessibleName = "DotNetBar Bar";
			this.bar4.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.bar4.CanHide = true;
			this.bar4.DockLine = 1;
			this.bar4.DockSide = DevComponents.DotNetBar.eDockSide.Top;
			this.bar4.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.Office2003;
			this.bar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																				this.buttonNew,
																				this.item_364,
																				this.item_365,
																				this.item_366,
																				this.item_367,
																				this.item_368,
																				this.item_369,
																				this.item_370,
																				this.item_371,
																				this.item_372,
																				this.item_373,
																				this.item_374,
																				this.item_388,
																				this.item_389,
																				this.item_403,
																				this.item_404,
																				this.item_405,
																				this.item_407,
																				this.item_408});
			this.bar4.Location = new System.Drawing.Point(0, 25);
			this.bar4.Name = "bar4";
			this.bar4.Size = new System.Drawing.Size(640, 25);
			this.bar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
			this.bar4.TabIndex = 1;
			this.bar4.TabStop = false;
			this.bar4.Text = "Commands";
			// 
			// buttonNew
			// 
			this.buttonNew.GlobalName = "buttonNew";
			this.buttonNew.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonNew.Image")));
			this.buttonNew.ImagePaddingHorizontal = 8;
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Text = "New";
			// 
			// item_364
			// 
			this.item_364.GlobalName = "item_364";
			this.item_364.ImageIndex = 9;
			this.item_364.ImagePaddingHorizontal = 8;
			this.item_364.Name = "item_364";
			this.item_364.Text = "New Project";
			// 
			// item_365
			// 
			this.item_365.GlobalName = "item_365";
			this.item_365.ImageIndex = 2;
			this.item_365.ImagePaddingHorizontal = 8;
			this.item_365.Name = "item_365";
			this.item_365.Text = "Add To Project";
			// 
			// item_366
			// 
			this.item_366.GlobalName = "item_366";
			this.item_366.ImageIndex = 10;
			this.item_366.ImagePaddingHorizontal = 8;
			this.item_366.Name = "item_366";
			this.item_366.Text = "Open File";
			// 
			// item_367
			// 
			this.item_367.DisabledImage = ((System.Drawing.Bitmap)(resources.GetObject("item_367.DisabledImage")));
			this.item_367.Enabled = false;
			this.item_367.GlobalName = "item_367";
			this.item_367.ImageIndex = 12;
			this.item_367.ImagePaddingHorizontal = 8;
			this.item_367.Name = "item_367";
			this.item_367.Text = "Save";
			// 
			// item_368
			// 
			this.item_368.DisabledImage = ((System.Drawing.Bitmap)(resources.GetObject("item_368.DisabledImage")));
			this.item_368.Enabled = false;
			this.item_368.GlobalName = "item_368";
			this.item_368.ImageIndex = 13;
			this.item_368.ImagePaddingHorizontal = 8;
			this.item_368.Name = "item_368";
			this.item_368.Text = "Save All";
			// 
			// item_369
			// 
			this.item_369.BeginGroup = true;
			this.item_369.GlobalName = "item_369";
			this.item_369.ImageIndex = 5;
			this.item_369.ImagePaddingHorizontal = 8;
			this.item_369.Name = "item_369";
			this.item_369.Text = "Cut";
			// 
			// item_370
			// 
			this.item_370.GlobalName = "item_370";
			this.item_370.ImageIndex = 4;
			this.item_370.ImagePaddingHorizontal = 8;
			this.item_370.Name = "item_370";
			this.item_370.Text = "Copy";
			// 
			// item_371
			// 
			this.item_371.DisabledImage = ((System.Drawing.Bitmap)(resources.GetObject("item_371.DisabledImage")));
			this.item_371.Enabled = false;
			this.item_371.GlobalName = "item_371";
			this.item_371.ImageIndex = 11;
			this.item_371.ImagePaddingHorizontal = 8;
			this.item_371.Name = "item_371";
			this.item_371.Text = "Paste";
			// 
			// item_372
			// 
			this.item_372.BeginGroup = true;
			this.item_372.GlobalName = "item_372";
			this.item_372.ImageIndex = 7;
			this.item_372.ImagePaddingHorizontal = 8;
			this.item_372.Name = "item_372";
			this.item_372.Text = "Navigate Backwards";
			// 
			// item_373
			// 
			this.item_373.DisabledImage = ((System.Drawing.Bitmap)(resources.GetObject("item_373.DisabledImage")));
			this.item_373.Enabled = false;
			this.item_373.GlobalName = "item_373";
			this.item_373.ImageIndex = 8;
			this.item_373.ImagePaddingHorizontal = 8;
			this.item_373.Name = "item_373";
			this.item_373.Text = "Navigate Forwards";
			// 
			// item_374
			// 
			this.item_374.BeginGroup = true;
			this.item_374.GlobalName = "item_374";
			this.item_374.ImageIndex = 15;
			this.item_374.ImagePaddingHorizontal = 8;
			this.item_374.Name = "item_374";
			this.item_374.Text = "Run Project";
			// 
			// item_388
			// 
			this.item_388.ComboWidth = 72;
			this.item_388.GlobalName = "item_388";
			this.item_388.ItemHeight = 14;
			this.item_388.Name = "item_388";
			this.item_388.Text = "Run Mode";
			// 
			// item_389
			// 
			this.item_389.BeginGroup = true;
			this.item_389.GlobalName = "item_389";
			this.item_389.ImageIndex = 6;
			this.item_389.ImagePaddingHorizontal = 8;
			this.item_389.Name = "item_389";
			this.item_389.Text = "Find in Files";
			// 
			// item_403
			// 
			this.item_403.ComboWidth = 128;
			this.item_403.GlobalName = "item_403";
			this.item_403.ItemHeight = 14;
			this.item_403.Name = "item_403";
			this.item_403.Text = "Search Text";
			// 
			// item_404
			// 
			this.item_404.BeginGroup = true;
			this.item_404.GlobalName = "item_404";
			this.item_404.ImageIndex = 0;
			this.item_404.ImagePaddingHorizontal = 8;
			this.item_404.Name = "item_404";
			this.item_404.Text = "Project Explorer";
			// 
			// item_405
			// 
			this.item_405.GlobalName = "item_405";
			this.item_405.ImageIndex = 1;
			this.item_405.ImagePaddingHorizontal = 8;
			this.item_405.Name = "item_405";
			this.item_405.Text = "Project Properties";
			// 
			// item_407
			// 
			this.item_407.GlobalName = "item_407";
			this.item_407.ImageIndex = 16;
			this.item_407.ImagePaddingHorizontal = 8;
			this.item_407.Name = "item_407";
			this.item_407.Text = "Toolbox";
			// 
			// item_408
			// 
			this.item_408.GlobalName = "item_408";
			this.item_408.ImageIndex = 3;
			this.item_408.ImagePaddingHorizontal = 8;
			this.item_408.Name = "item_408";
			this.item_408.Text = "Class View";
			// 
			// barTopDockSite
			// 
			this.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top;
			this.barTopDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.barTopDockSite.Location = new System.Drawing.Point(0, 50);
			this.barTopDockSite.Name = "barTopDockSite";
			this.barTopDockSite.Size = new System.Drawing.Size(776, 0);
			this.barTopDockSite.TabIndex = 3;
			this.barTopDockSite.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(776, 454);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.dockSite1,
																		  this.barLeftDockSite,
																		  this.barRightDockSite,
																		  this.barTopDockSite,
																		  this.barBottomDockSite,
																		  this.dockSite2,
																		  this.dockSite3,
																		  this.dockSite4,
																		  this.dockSite5});
			this.IsMdiContainer = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.barBottomDockSite.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
			this.bar2.ResumeLayout(false);
			this.panelDockContainer1.ResumeLayout(false);
			this.panelDockContainer2.ResumeLayout(false);
			this.barRightDockSite.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.barSolutionExplorer)).EndInit();
			this.barSolutionExplorer.ResumeLayout(false);
			this.panelDockContainer3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
			this.panelDockContainer4.ResumeLayout(false);
			this.dockSite4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mainmenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bar4)).EndInit();
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
			// Create inital document bar
			Bar bar=BarUtilities.CreateDocumentBar();
			bar.Name="barDocuments";
			bar.DockTabClosing+=new DockTabClosingEventHandler(DocumentBar_DockTabClosing);
			dockSite1.GetDocumentUIManager().Dock(bar);
			CreateNewDocument();
		}

		private void CreateNewDocument()
		{
			// Create new DockContainerItem with the edit control and add it to the barDocuments
			m_DocumentCount++;
			DockContainerItem document=new DockContainerItem("docDock"+m_DocumentCount,"Document ["+m_DocumentCount+"]");
			// Create control to host inside of new document
			document.Control=CreateNewDocumentControl();
			Bar bar=GetFirstDocumentBar();
			bar.Items.Add(document);
			if(!bar.Visible)
				bar.Visible=true;
			bar.SelectedDockTab=bar.Items.IndexOf(document);
			bar.RecalcLayout();
		}

		private Bar GetFirstDocumentBar()
		{
			foreach(Bar b in dotNetBarManager1.Bars)
			{
				if(b.DockSide==eDockSide.Document && b.Visible)
					return b;
			}

			// If no documents bars found, create new one
			m_UniqueBarCount++;
			Bar bar=BarUtilities.CreateDocumentBar();
			bar.DockTabClosing+=new DockTabClosingEventHandler(DocumentBar_DockTabClosing);
			bar.Name="barDocuments"+m_UniqueBarCount.ToString();
			dockSite1.GetDocumentUIManager().Dock(bar);

			return bar;
		}

		private Control CreateNewDocumentControl()
		{
			TextBox txt=new TextBox();
			txt.Multiline=true;
			txt.ScrollBars=ScrollBars.Vertical;
			txt.AutoSize=false;
			return txt;
		}

		private void DocumentBar_DockTabClosing(object sender, DevComponents.DotNetBar.DockTabClosingEventArgs e)
		{
			// In this event you save any changes to the active document or cancel the closing...
			// e.DockContainerItem returns the reference to the item being closed
			// Set e.Cancel to true to cancel the closing
			// Set e.RemoveDockTab to true to automatically remove the closed tab from Bar.Items collection
			e.RemoveDockTab=true;

			if(((Bar)sender).Items.Count==1) // Remove bar if last item is closed...
				dotNetBarManager1.Bars.Remove((Bar)sender);
		}

		private void dotNetBarManager1_BarTearOff(object sender, System.EventArgs e)
		{
			Bar b=sender as Bar;
			b.DockTabClosing+=new DockTabClosingEventHandler(DocumentBar_DockTabClosing);
		}

		private void dotNetBarManager1_ItemClick(object sender, System.EventArgs e)
		{
			BaseItem item=sender as BaseItem;
			if(item==null) return;

			if(item.Name=="buttonNew")
			{
				CreateNewDocument();
			}
		}
	}
}
