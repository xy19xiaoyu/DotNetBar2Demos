using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DocumentDocking
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
		private DevComponents.DotNetBar.DockSite dockSite1;
		private DevComponents.DotNetBar.Bar bar1;
		private DevComponents.DotNetBar.DockContainerItem dockContainerItem1;
		private DevComponents.DotNetBar.PanelDockContainer panelDockContainer1;
		private DevComponents.DotNetBar.DockContainerItem dockContainerItem2;
		private DevComponents.DotNetBar.PanelDockContainer panelDockContainer2;
		private DevComponents.DotNetBar.DockContainerItem dockContainerItem3;
		private DevComponents.DotNetBar.PanelDockContainer panelDockContainer3;
		private DevComponents.DotNetBar.DockContainerItem dockContainerItem4;
		private DevComponents.DotNetBar.PanelDockContainer panelDockContainer4;
		private DevComponents.DotNetBar.Bar bar2;
		private DevComponents.DotNetBar.Bar bar3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private DevComponents.DotNetBar.Bar bar4;
		private DevComponents.DotNetBar.ButtonItem buttonItem1;
		private DevComponents.DotNetBar.ButtonItem buttonItem2;
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
			this.dotNetBarManager1 = new DevComponents.DotNetBar.DotNetBarManager(this.components);
			this.barBottomDockSite = new DevComponents.DotNetBar.DockSite();
			this.dockSite1 = new DevComponents.DotNetBar.DockSite();
			this.bar1 = new DevComponents.DotNetBar.Bar();
			this.panelDockContainer3 = new DevComponents.DotNetBar.PanelDockContainer();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.panelDockContainer1 = new DevComponents.DotNetBar.PanelDockContainer();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dockContainerItem1 = new DevComponents.DotNetBar.DockContainerItem();
			this.dockContainerItem3 = new DevComponents.DotNetBar.DockContainerItem();
			this.bar2 = new DevComponents.DotNetBar.Bar();
			this.panelDockContainer4 = new DevComponents.DotNetBar.PanelDockContainer();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.dockContainerItem4 = new DevComponents.DotNetBar.DockContainerItem();
			this.bar3 = new DevComponents.DotNetBar.Bar();
			this.panelDockContainer2 = new DevComponents.DotNetBar.PanelDockContainer();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.dockContainerItem2 = new DevComponents.DotNetBar.DockContainerItem();
			this.barLeftDockSite = new DevComponents.DotNetBar.DockSite();
			this.barRightDockSite = new DevComponents.DotNetBar.DockSite();
			this.barTopDockSite = new DevComponents.DotNetBar.DockSite();
			this.bar4 = new DevComponents.DotNetBar.Bar();
			this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
			this.dockSite1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
			this.bar1.SuspendLayout();
			this.panelDockContainer3.SuspendLayout();
			this.panelDockContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bar2)).BeginInit();
			this.bar2.SuspendLayout();
			this.panelDockContainer4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bar3)).BeginInit();
			this.bar3.SuspendLayout();
			this.panelDockContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bar4)).BeginInit();
			this.SuspendLayout();
			// 
			// dotNetBarManager1
			// 
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV);
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
			this.dotNetBarManager1.BottomDockSite = this.barBottomDockSite;
			this.dotNetBarManager1.DefinitionName = "";
			this.dotNetBarManager1.FillDockSite = this.dockSite1;
			this.dotNetBarManager1.LeftDockSite = this.barLeftDockSite;
			this.dotNetBarManager1.ParentForm = this;
			this.dotNetBarManager1.RightDockSite = this.barRightDockSite;
			this.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
			this.dotNetBarManager1.ThemeAware = false;
			this.dotNetBarManager1.TopDockSite = this.barTopDockSite;
			this.dotNetBarManager1.DockTabClosing += new DevComponents.DotNetBar.DockTabClosingEventHandler(this.OnDocumentClosing);
			// 
			// barBottomDockSite
			// 
			this.barBottomDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barBottomDockSite.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barBottomDockSite.Location = new System.Drawing.Point(0, 430);
			this.barBottomDockSite.Name = "barBottomDockSite";
			this.barBottomDockSite.NeedsLayout = false;
			this.barBottomDockSite.Size = new System.Drawing.Size(720, 0);
			this.barBottomDockSite.TabIndex = 3;
			this.barBottomDockSite.TabStop = false;
			// 
			// dockSite1
			// 
			this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.bar1,
																					this.bar2,
																					this.bar3});
			this.dockSite1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
																																							 new DevComponents.DotNetBar.DocumentBarContainer(this.bar1, 358, 405),
																																							 new DevComponents.DotNetBar.DocumentDockContainer(new DevComponents.DotNetBar.DocumentBaseContainer[] {
																																																																	   new DevComponents.DotNetBar.DocumentBarContainer(this.bar2, 357, 217),
																																																																	   new DevComponents.DotNetBar.DocumentBarContainer(this.bar3, 357, 185)}, DevComponents.DotNetBar.eOrientation.Vertical)}, DevComponents.DotNetBar.eOrientation.Horizontal);
			this.dockSite1.Location = new System.Drawing.Point(0, 25);
			this.dockSite1.Name = "dockSite1";
			this.dockSite1.NeedsLayout = false;
			this.dockSite1.Size = new System.Drawing.Size(720, 405);
			this.dockSite1.TabIndex = 4;
			this.dockSite1.TabStop = false;
			// 
			// bar1
			// 
			this.bar1.AccessibleDescription = "DotNetBar Bar (bar1)";
			this.bar1.AccessibleName = "DotNetBar Bar";
			this.bar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.bar1.AlwaysDisplayDockTab = true;
			this.bar1.CanCustomize = false;
			this.bar1.CanDockBottom = false;
			this.bar1.CanDockDocument = true;
			this.bar1.CanDockLeft = false;
			this.bar1.CanDockRight = false;
			this.bar1.CanDockTop = false;
			this.bar1.CanHide = true;
			this.bar1.CanUndock = false;
			this.bar1.Controls.AddRange(new System.Windows.Forms.Control[] {
																			   this.panelDockContainer3,
																			   this.panelDockContainer1});
			this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
			this.bar1.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
			this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																				this.dockContainerItem1,
																				this.dockContainerItem3});
			this.bar1.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
			this.bar1.Name = "bar1";
			this.bar1.SelectedDockTab = 0;
			this.bar1.Stretch = true;
			this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
			this.bar1.TabIndex = 0;
			this.bar1.TabStop = false;
			// 
			// panelDockContainer3
			// 
			this.panelDockContainer3.Controls.AddRange(new System.Windows.Forms.Control[] {
																							  this.textBox4});
			this.panelDockContainer3.Location = new System.Drawing.Point(2, 2);
			this.panelDockContainer3.Name = "panelDockContainer3";
			this.panelDockContainer3.Size = new System.Drawing.Size(0, 0);
			this.panelDockContainer3.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelDockContainer3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.panelDockContainer3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.panelDockContainer3.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
			this.panelDockContainer3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.panelDockContainer3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.panelDockContainer3.Style.GradientAngle = 90;
			this.panelDockContainer3.TabIndex = 3;
			// 
			// textBox4
			// 
			this.textBox4.AutoSize = false;
			this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(0, 0);
			this.textBox4.TabIndex = 1;
			this.textBox4.Text = "Document 3";
			// 
			// panelDockContainer1
			// 
			this.panelDockContainer1.Controls.AddRange(new System.Windows.Forms.Control[] {
																							  this.textBox1});
			this.panelDockContainer1.Location = new System.Drawing.Point(3, 28);
			this.panelDockContainer1.Name = "panelDockContainer1";
			this.panelDockContainer1.Size = new System.Drawing.Size(354, 374);
			this.panelDockContainer1.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelDockContainer1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.panelDockContainer1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.panelDockContainer1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
			this.panelDockContainer1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.panelDockContainer1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.panelDockContainer1.Style.GradientAngle = 90;
			this.panelDockContainer1.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.AutoSize = false;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(354, 374);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Document 1, Drag & Drop tabs to change docking layout";
			// 
			// dockContainerItem1
			// 
			this.dockContainerItem1.Control = this.panelDockContainer1;
			this.dockContainerItem1.Height = 378;
			this.dockContainerItem1.Name = "dockContainerItem1";
			this.dockContainerItem1.Text = "Document 1";
			this.dockContainerItem1.Width = 358;
			// 
			// dockContainerItem3
			// 
			this.dockContainerItem3.Control = this.panelDockContainer3;
			this.dockContainerItem3.Height = 378;
			this.dockContainerItem3.Name = "dockContainerItem3";
			this.dockContainerItem3.Text = "Document 3";
			this.dockContainerItem3.Width = 358;
			// 
			// bar2
			// 
			this.bar2.AccessibleDescription = "DotNetBar Bar (bar2)";
			this.bar2.AccessibleName = "DotNetBar Bar";
			this.bar2.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.bar2.AlwaysDisplayDockTab = true;
			this.bar2.CanCustomize = false;
			this.bar2.CanDockBottom = false;
			this.bar2.CanDockDocument = true;
			this.bar2.CanDockLeft = false;
			this.bar2.CanDockRight = false;
			this.bar2.CanDockTop = false;
			this.bar2.CanUndock = false;
			this.bar2.Controls.AddRange(new System.Windows.Forms.Control[] {
																			   this.panelDockContainer4});
			this.bar2.DockSide = DevComponents.DotNetBar.eDockSide.Document;
			this.bar2.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
			this.bar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																				this.dockContainerItem4});
			this.bar2.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
			this.bar2.Location = new System.Drawing.Point(363, 0);
			this.bar2.Name = "bar2";
			this.bar2.SelectedDockTab = 0;
			this.bar2.Stretch = true;
			this.bar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
			this.bar2.TabIndex = 1;
			this.bar2.TabStop = false;
			// 
			// panelDockContainer4
			// 
			this.panelDockContainer4.Controls.AddRange(new System.Windows.Forms.Control[] {
																							  this.textBox2});
			this.panelDockContainer4.Location = new System.Drawing.Point(3, 28);
			this.panelDockContainer4.Name = "panelDockContainer4";
			this.panelDockContainer4.Size = new System.Drawing.Size(351, 186);
			this.panelDockContainer4.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelDockContainer4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.panelDockContainer4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.panelDockContainer4.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
			this.panelDockContainer4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.panelDockContainer4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.panelDockContainer4.Style.GradientAngle = 90;
			this.panelDockContainer4.TabIndex = 4;
			// 
			// textBox2
			// 
			this.textBox2.AutoSize = false;
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(351, 186);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "Document 4";
			// 
			// dockContainerItem4
			// 
			this.dockContainerItem4.Control = this.panelDockContainer4;
			this.dockContainerItem4.Height = 190;
			this.dockContainerItem4.Name = "dockContainerItem4";
			this.dockContainerItem4.Text = "Document 4";
			this.dockContainerItem4.Width = 355;
			// 
			// bar3
			// 
			this.bar3.AccessibleDescription = "DotNetBar Bar (bar3)";
			this.bar3.AccessibleName = "DotNetBar Bar";
			this.bar3.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.bar3.AlwaysDisplayDockTab = true;
			this.bar3.CanCustomize = false;
			this.bar3.CanDockBottom = false;
			this.bar3.CanDockDocument = true;
			this.bar3.CanDockLeft = false;
			this.bar3.CanDockRight = false;
			this.bar3.CanDockTop = false;
			this.bar3.CanHide = true;
			this.bar3.CanUndock = false;
			this.bar3.Controls.AddRange(new System.Windows.Forms.Control[] {
																			   this.panelDockContainer2});
			this.bar3.DockSide = DevComponents.DotNetBar.eDockSide.Document;
			this.bar3.DockTabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
			this.bar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																				this.dockContainerItem2});
			this.bar3.LayoutType = DevComponents.DotNetBar.eLayoutType.DockContainer;
			this.bar3.Location = new System.Drawing.Point(363, 220);
			this.bar3.Name = "bar3";
			this.bar3.SelectedDockTab = 0;
			this.bar3.Stretch = true;
			this.bar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
			this.bar3.TabIndex = 2;
			this.bar3.TabStop = false;
			// 
			// panelDockContainer2
			// 
			this.panelDockContainer2.Controls.AddRange(new System.Windows.Forms.Control[] {
																							  this.textBox3});
			this.panelDockContainer2.Location = new System.Drawing.Point(3, 28);
			this.panelDockContainer2.Name = "panelDockContainer2";
			this.panelDockContainer2.Size = new System.Drawing.Size(351, 154);
			this.panelDockContainer2.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelDockContainer2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.panelDockContainer2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.panelDockContainer2.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
			this.panelDockContainer2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.panelDockContainer2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.panelDockContainer2.Style.GradientAngle = 90;
			this.panelDockContainer2.TabIndex = 2;
			// 
			// textBox3
			// 
			this.textBox3.AutoSize = false;
			this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(351, 154);
			this.textBox3.TabIndex = 1;
			this.textBox3.Text = "Document 2";
			// 
			// dockContainerItem2
			// 
			this.dockContainerItem2.Control = this.panelDockContainer2;
			this.dockContainerItem2.Height = 158;
			this.dockContainerItem2.Name = "dockContainerItem2";
			this.dockContainerItem2.Text = "Document 2";
			this.dockContainerItem2.Width = 355;
			// 
			// barLeftDockSite
			// 
			this.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left;
			this.barLeftDockSite.Location = new System.Drawing.Point(0, 25);
			this.barLeftDockSite.Name = "barLeftDockSite";
			this.barLeftDockSite.NeedsLayout = false;
			this.barLeftDockSite.Size = new System.Drawing.Size(0, 405);
			this.barLeftDockSite.TabIndex = 0;
			this.barLeftDockSite.TabStop = false;
			// 
			// barRightDockSite
			// 
			this.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right;
			this.barRightDockSite.Location = new System.Drawing.Point(720, 25);
			this.barRightDockSite.Name = "barRightDockSite";
			this.barRightDockSite.NeedsLayout = false;
			this.barRightDockSite.Size = new System.Drawing.Size(0, 405);
			this.barRightDockSite.TabIndex = 1;
			this.barRightDockSite.TabStop = false;
			// 
			// barTopDockSite
			// 
			this.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top;
			this.barTopDockSite.Location = new System.Drawing.Point(0, 25);
			this.barTopDockSite.Name = "barTopDockSite";
			this.barTopDockSite.NeedsLayout = false;
			this.barTopDockSite.Size = new System.Drawing.Size(720, 0);
			this.barTopDockSite.TabIndex = 2;
			this.barTopDockSite.TabStop = false;
			// 
			// bar4
			// 
			this.bar4.Dock = System.Windows.Forms.DockStyle.Top;
			this.bar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																				this.buttonItem1,
																				this.buttonItem2});
			this.bar4.Name = "bar4";
			this.bar4.Size = new System.Drawing.Size(720, 25);
			this.bar4.Stretch = true;
			this.bar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
			this.bar4.TabIndex = 2;
			this.bar4.TabStop = false;
			this.bar4.Text = "bar4";
			// 
			// buttonItem1
			// 
			this.buttonItem1.Name = "buttonItem1";
			this.buttonItem1.Text = "New Document";
			this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
			// 
			// buttonItem2
			// 
			this.buttonItem2.Name = "buttonItem2";
			this.buttonItem2.Text = "Show All Tabs";
			this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(720, 430);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.dockSite1,
																		  this.barLeftDockSite,
																		  this.barRightDockSite,
																		  this.barTopDockSite,
																		  this.barBottomDockSite,
																		  this.bar4});
			this.Name = "Form1";
			this.Text = "Show Case of Document Docking";
			this.dockSite1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
			this.bar1.ResumeLayout(false);
			this.panelDockContainer3.ResumeLayout(false);
			this.panelDockContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bar2)).EndInit();
			this.bar2.ResumeLayout(false);
			this.panelDockContainer4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bar3)).EndInit();
			this.bar3.ResumeLayout(false);
			this.panelDockContainer2.ResumeLayout(false);
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

		private void OnDocumentClosing(object sender, DevComponents.DotNetBar.DockTabClosingEventArgs e)
		{
			// In this event you save any changes to the active document or cancel the closing...
			// e.DockContainerItem returns the reference to the item being closed
			// Set e.Cancel to true to cancel the closing
			// Set e.RemoveDockTab to true to automatically remove the closed tab from Bar.Items collection, otherwise tab will just be hidden

			DialogResult r=MessageBox.Show("Document '"+e.DockContainerItem.Text+" is about to close. Close it?","Document Docking",MessageBoxButtons.YesNo);
			if(r==DialogResult.No)
				e.Cancel=true;
		}

		private void buttonItem1_Click(object sender, System.EventArgs e)
		{
			// Create new document and add it to existing bar
			DevComponents.DotNetBar.DockContainerItem dockItem=new DevComponents.DotNetBar.DockContainerItem();
			dockItem.Text="Custom Document";

			// Add control to it
			TextBox t=new TextBox();
			t.AutoSize=false;
			t.Multiline=true;
			t.Text=dockItem.Text;
			
			// PanelDockContainer will be used to host any controls. It provides automatic focus management so focused
			// document tab appears bold
			DevComponents.DotNetBar.PanelDockContainer panel = new DevComponents.DotNetBar.PanelDockContainer();
			t.Dock = DockStyle.Fill;
            panel.Controls.Add(t);

			dockItem.Control=panel;

			bar1.Items.Add(dockItem);
			if(!bar1.Visible)
				bar1.Visible=true;
			else
				bar1.RecalcLayout();
		}

		private void buttonItem2_Click(object sender, System.EventArgs e)
		{
			// Optimize display by disabling layout for all dock sites
			dotNetBarManager1.SuspendLayout=true;
			try
			{
				foreach(DevComponents.DotNetBar.Bar bar in dotNetBarManager1.Bars)
				{
					if(bar.DockSide==DevComponents.DotNetBar.eDockSide.Document)
					{
						foreach(DevComponents.DotNetBar.DockContainerItem dock in bar.Items)
							dock.Visible=true;
					}
					if(!bar.Visible)
						bar.Visible=true;
				}
			}
			finally
			{
				dotNetBarManager1.SuspendLayout=false;
			}
		}
	}
}
