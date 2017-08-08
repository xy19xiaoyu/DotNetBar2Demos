using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;

namespace Menu
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevComponents.DotNetBar.DotNetBarManager dotNetBarManager1;
		private DevComponents.DotNetBar.DockSite barTopDockSite;
		private DevComponents.DotNetBar.DockSite barBottomDockSite;
		private DevComponents.DotNetBar.DockSite barLeftDockSite;
		private DevComponents.DotNetBar.DockSite barRightDockSite;
		private System.Windows.Forms.MdiClient mdiClient1;
		private DevComponents.DotNetBar.DockSite dockSite1;
		private DevComponents.DotNetBar.DockSite dockSite2;
		private DevComponents.DotNetBar.DockSite dockSite3;
		private DevComponents.DotNetBar.DockSite dockSite4;
		private DevComponents.DotNetBar.Bar mainmenu;
		private DevComponents.DotNetBar.ButtonItem item_50;
		private DevComponents.DotNetBar.ButtonItem mNew;
		private DevComponents.DotNetBar.ButtonItem mTextFile;
		private DevComponents.DotNetBar.ButtonItem mXMLDocument;
		private DevComponents.DotNetBar.ButtonItem mHTMLDocument;
		private DevComponents.DotNetBar.ButtonItem mOpen;
		private DevComponents.DotNetBar.ButtonItem mExit;
		private DevComponents.DotNetBar.ButtonItem item_55;
		private DevComponents.DotNetBar.ButtonItem mAbout;
		private DevComponents.DotNetBar.ButtonItem mSwitch;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.dotNetBarManager1 = new DevComponents.DotNetBar.DotNetBarManager(this.components);
			this.barBottomDockSite = new DevComponents.DotNetBar.DockSite();
			this.barLeftDockSite = new DevComponents.DotNetBar.DockSite();
			this.barRightDockSite = new DevComponents.DotNetBar.DockSite();
			this.barTopDockSite = new DevComponents.DotNetBar.DockSite();
			this.mdiClient1 = new System.Windows.Forms.MdiClient();
			this.dockSite1 = new DevComponents.DotNetBar.DockSite();
			this.dockSite2 = new DevComponents.DotNetBar.DockSite();
			this.dockSite3 = new DevComponents.DotNetBar.DockSite();
			this.dockSite4 = new DevComponents.DotNetBar.DockSite();
			this.mainmenu = new DevComponents.DotNetBar.Bar();
			this.item_50 = new DevComponents.DotNetBar.ButtonItem();
			this.mNew = new DevComponents.DotNetBar.ButtonItem();
			this.mTextFile = new DevComponents.DotNetBar.ButtonItem();
			this.mXMLDocument = new DevComponents.DotNetBar.ButtonItem();
			this.mHTMLDocument = new DevComponents.DotNetBar.ButtonItem();
			this.mOpen = new DevComponents.DotNetBar.ButtonItem();
			this.mExit = new DevComponents.DotNetBar.ButtonItem();
			this.item_55 = new DevComponents.DotNetBar.ButtonItem();
			this.mAbout = new DevComponents.DotNetBar.ButtonItem();
			this.mSwitch = new DevComponents.DotNetBar.ButtonItem();
			this.dockSite3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainmenu)).BeginInit();
			this.SuspendLayout();
			// 
			// dotNetBarManager1
			// 
			this.dotNetBarManager1.BottomDockSite = this.barBottomDockSite;
			this.dotNetBarManager1.DefinitionName = "";
			this.dotNetBarManager1.LeftDockSite = this.barLeftDockSite;
			this.dotNetBarManager1.ParentForm = this;
			this.dotNetBarManager1.RightDockSite = this.barRightDockSite;
			this.dotNetBarManager1.ShowCustomizeContextMenu = false;
			this.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
			this.dotNetBarManager1.ToolbarBottomDockSite = this.dockSite4;
			this.dotNetBarManager1.ToolbarLeftDockSite = this.dockSite1;
			this.dotNetBarManager1.ToolbarRightDockSite = this.dockSite2;
			this.dotNetBarManager1.ToolbarTopDockSite = this.dockSite3;
			this.dotNetBarManager1.TopDockSite = this.barTopDockSite;
			this.dotNetBarManager1.ItemClick += new System.EventHandler(this.OnItemClick);
			// 
			// barBottomDockSite
			// 
			this.barBottomDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barBottomDockSite.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barBottomDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.barBottomDockSite.Location = new System.Drawing.Point(0, 273);
			this.barBottomDockSite.Name = "barBottomDockSite";
			this.barBottomDockSite.Size = new System.Drawing.Size(406, 0);
			this.barBottomDockSite.TabIndex = 2;
			this.barBottomDockSite.TabStop = false;
			// 
			// barLeftDockSite
			// 
			this.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left;
			this.barLeftDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.barLeftDockSite.Location = new System.Drawing.Point(0, 25);
			this.barLeftDockSite.Name = "barLeftDockSite";
			this.barLeftDockSite.Size = new System.Drawing.Size(0, 248);
			this.barLeftDockSite.TabIndex = 3;
			this.barLeftDockSite.TabStop = false;
			// 
			// barRightDockSite
			// 
			this.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right;
			this.barRightDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.barRightDockSite.Location = new System.Drawing.Point(406, 25);
			this.barRightDockSite.Name = "barRightDockSite";
			this.barRightDockSite.Size = new System.Drawing.Size(0, 248);
			this.barRightDockSite.TabIndex = 4;
			this.barRightDockSite.TabStop = false;
			// 
			// barTopDockSite
			// 
			this.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top;
			this.barTopDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.barTopDockSite.Location = new System.Drawing.Point(0, 25);
			this.barTopDockSite.Name = "barTopDockSite";
			this.barTopDockSite.Size = new System.Drawing.Size(406, 0);
			this.barTopDockSite.TabIndex = 1;
			this.barTopDockSite.TabStop = false;
			// 
			// mdiClient1
			// 
			this.mdiClient1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mdiClient1.Location = new System.Drawing.Point(0, 25);
			this.mdiClient1.Name = "mdiClient1";
			this.mdiClient1.TabIndex = 5;
			// 
			// dockSite1
			// 
			this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
			this.dockSite1.Location = new System.Drawing.Point(0, 25);
			this.dockSite1.Name = "dockSite1";
			this.dockSite1.Size = new System.Drawing.Size(0, 248);
			this.dockSite1.TabIndex = 6;
			this.dockSite1.TabStop = false;
			// 
			// dockSite2
			// 
			this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
			this.dockSite2.Location = new System.Drawing.Point(406, 25);
			this.dockSite2.Name = "dockSite2";
			this.dockSite2.Size = new System.Drawing.Size(0, 248);
			this.dockSite2.TabIndex = 7;
			this.dockSite2.TabStop = false;
			// 
			// dockSite3
			// 
			this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite3.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.mainmenu});
			this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
			this.dockSite3.Name = "dockSite3";
			this.dockSite3.Size = new System.Drawing.Size(406, 25);
			this.dockSite3.TabIndex = 8;
			this.dockSite3.TabStop = false;
			// 
			// dockSite4
			// 
			this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dockSite4.Location = new System.Drawing.Point(0, 273);
			this.dockSite4.Name = "dockSite4";
			this.dockSite4.Size = new System.Drawing.Size(406, 0);
			this.dockSite4.TabIndex = 9;
			this.dockSite4.TabStop = false;
			// 
			// mainmenu
			// 
			this.mainmenu.AccessibleDescription = "Main Menu (mainmenu)";
			this.mainmenu.AccessibleName = "Main Menu";
			this.mainmenu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
			this.mainmenu.DockSide = DevComponents.DotNetBar.eDockSide.Top;
			this.mainmenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																					this.item_50,
																					this.item_55,
																					this.mSwitch});
			this.mainmenu.MenuBar = true;
			this.mainmenu.Name = "mainmenu";
			this.mainmenu.Size = new System.Drawing.Size(406, 24);
			this.mainmenu.Stretch = true;
			this.mainmenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
			this.mainmenu.TabIndex = 0;
			this.mainmenu.TabStop = false;
			this.mainmenu.Text = "Main Menu";
			// 
			// item_50
			// 
			this.item_50.GlobalName = "item_50";
			this.item_50.Name = "item_50";
			this.item_50.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
			this.item_50.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																					  this.mNew,
																					  this.mOpen,
																					  this.mExit});
			this.item_50.Text = "&File";
			// 
			// mNew
			// 
			this.mNew.GlobalName = "mNew";
			this.mNew.Image = ((System.Drawing.Bitmap)(resources.GetObject("mNew.Image")));
			this.mNew.Name = "mNew";
			this.mNew.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
			this.mNew.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
			this.mNew.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																				   this.mTextFile,
																				   this.mXMLDocument,
																				   this.mHTMLDocument});
			this.mNew.Text = "&New";
			// 
			// mTextFile
			// 
			this.mTextFile.GlobalName = "mTextFile";
			this.mTextFile.Name = "mTextFile";
			this.mTextFile.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
			this.mTextFile.Text = "&Text File";
			// 
			// mXMLDocument
			// 
			this.mXMLDocument.GlobalName = "mXMLDocument";
			this.mXMLDocument.Name = "mXMLDocument";
			this.mXMLDocument.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
			this.mXMLDocument.Text = "&XML Document";
			// 
			// mHTMLDocument
			// 
			this.mHTMLDocument.GlobalName = "mHTMLDocument";
			this.mHTMLDocument.Name = "mHTMLDocument";
			this.mHTMLDocument.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
			this.mHTMLDocument.Text = "&HTML Document";
			// 
			// mOpen
			// 
			this.mOpen.GlobalName = "mOpen";
			this.mOpen.Image = ((System.Drawing.Bitmap)(resources.GetObject("mOpen.Image")));
			this.mOpen.Name = "mOpen";
			this.mOpen.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
			this.mOpen.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlO);
			this.mOpen.Text = "&Open";
			// 
			// mExit
			// 
			this.mExit.BeginGroup = true;
			this.mExit.GlobalName = "mExit";
			this.mExit.Name = "mExit";
			this.mExit.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
			this.mExit.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX);
			this.mExit.Text = "&Exit";
			// 
			// item_55
			// 
			this.item_55.GlobalName = "item_55";
			this.item_55.Name = "item_55";
			this.item_55.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
			this.item_55.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																					  this.mAbout});
			this.item_55.Text = "&Help";
			// 
			// mAbout
			// 
			this.mAbout.GlobalName = "mAbout";
			this.mAbout.Name = "mAbout";
			this.mAbout.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
			this.mAbout.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
			this.mAbout.Text = "&About";
			// 
			// mSwitch
			// 
			this.mSwitch.GlobalName = "mSwitch";
			this.mSwitch.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
			this.mSwitch.Name = "mSwitch";
			this.mSwitch.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
			this.mSwitch.ShowSubItems = false;
			this.mSwitch.Text = "Switch Style";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(406, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.barTopDockSite,
																		  this.barBottomDockSite,
																		  this.barLeftDockSite,
																		  this.barRightDockSite,
																		  this.dockSite1,
																		  this.dockSite2,
																		  this.dockSite3,
																		  this.dockSite4,
																		  this.mdiClient1});
			this.IsMdiContainer = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.dockSite3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mainmenu)).EndInit();
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

		private void OnItemClick(object sender, EventArgs e)
		{
			BaseItem item=sender as BaseItem;
			if(item.Name=="mExit")
				this.Close();
			else if(item.Name=="mOpen" || item.Name=="mTextFile" || item.Name=="mXMLDocument" || item.Name=="mHTMLDocument")
				MessageBox.Show("Item "+item.Name+" Clicked.");
			else if(item.Name=="mAbout")
				MessageBox.Show("DevComponents DotNetBar Framework component");
			else if(item.Name=="mSwitch")
			{
				foreach(DevComponents.DotNetBar.Bar bar in dotNetBarManager1.Bars)
				{
					if(bar.Style==eDotNetBarStyle.Office2003)
						bar.Style=eDotNetBarStyle.VS2005;
					else
						bar.Style=eDotNetBarStyle.Office2003;
				}
			}
		}
	}
}
