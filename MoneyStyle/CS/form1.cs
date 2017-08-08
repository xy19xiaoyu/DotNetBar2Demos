using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;

namespace MoneyStyle
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
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private DevComponents.DotNetBar.DockSite dockSite1;
		private DevComponents.DotNetBar.DockSite dockSite2;
		private DevComponents.DotNetBar.DockSite dockSite3;
		private DevComponents.DotNetBar.DockSite dockSite4;
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
			this.barLeftDockSite = new DevComponents.DotNetBar.DockSite();
			this.barRightDockSite = new DevComponents.DotNetBar.DockSite();
			this.barTopDockSite = new DevComponents.DotNetBar.DockSite();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.dockSite1 = new DevComponents.DotNetBar.DockSite();
			this.dockSite2 = new DevComponents.DotNetBar.DockSite();
			this.dockSite3 = new DevComponents.DotNetBar.DockSite();
			this.dockSite4 = new DevComponents.DotNetBar.DockSite();
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
			this.dotNetBarManager1.LeftDockSite = this.barLeftDockSite;
			this.dotNetBarManager1.ParentForm = this;
			this.dotNetBarManager1.RightDockSite = this.barRightDockSite;
			this.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
			this.dotNetBarManager1.ToolbarBottomDockSite = this.dockSite4;
			this.dotNetBarManager1.ToolbarLeftDockSite = this.dockSite1;
			this.dotNetBarManager1.ToolbarRightDockSite = this.dockSite2;
			this.dotNetBarManager1.ToolbarTopDockSite = this.dockSite3;
			this.dotNetBarManager1.TopDockSite = this.barTopDockSite;
			// 
			// barBottomDockSite
			// 
			this.barBottomDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barBottomDockSite.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barBottomDockSite.Location = new System.Drawing.Point(0, 266);
			this.barBottomDockSite.Name = "barBottomDockSite";
			this.barBottomDockSite.Size = new System.Drawing.Size(528, 0);
			this.barBottomDockSite.TabIndex = 3;
			this.barBottomDockSite.TabStop = false;
			// 
			// barLeftDockSite
			// 
			this.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left;
			this.barLeftDockSite.Name = "barLeftDockSite";
			this.barLeftDockSite.Size = new System.Drawing.Size(0, 266);
			this.barLeftDockSite.TabIndex = 0;
			this.barLeftDockSite.TabStop = false;
			// 
			// barRightDockSite
			// 
			this.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right;
			this.barRightDockSite.Location = new System.Drawing.Point(528, 0);
			this.barRightDockSite.Name = "barRightDockSite";
			this.barRightDockSite.Size = new System.Drawing.Size(0, 266);
			this.barRightDockSite.TabIndex = 1;
			this.barRightDockSite.TabStop = false;
			// 
			// barTopDockSite
			// 
			this.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top;
			this.barTopDockSite.Name = "barTopDockSite";
			this.barTopDockSite.Size = new System.Drawing.Size(528, 0);
			this.barTopDockSite.TabIndex = 2;
			this.barTopDockSite.TabStop = false;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader1});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(528, 266);
			this.listView1.TabIndex = 4;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Width = 523;
			// 
			// dockSite1
			// 
			this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
			this.dockSite1.Name = "dockSite1";
			this.dockSite1.Size = new System.Drawing.Size(0, 266);
			this.dockSite1.TabIndex = 5;
			this.dockSite1.TabStop = false;
			// 
			// dockSite2
			// 
			this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
			this.dockSite2.Location = new System.Drawing.Point(528, 0);
			this.dockSite2.Name = "dockSite2";
			this.dockSite2.Size = new System.Drawing.Size(0, 266);
			this.dockSite2.TabIndex = 6;
			this.dockSite2.TabStop = false;
			// 
			// dockSite3
			// 
			this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
			this.dockSite3.Name = "dockSite3";
			this.dockSite3.Size = new System.Drawing.Size(528, 0);
			this.dockSite3.TabIndex = 7;
			this.dockSite3.TabStop = false;
			// 
			// dockSite4
			// 
			this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dockSite4.Location = new System.Drawing.Point(0, 266);
			this.dockSite4.Name = "dockSite4";
			this.dockSite4.Size = new System.Drawing.Size(528, 0);
			this.dockSite4.TabIndex = 8;
			this.dockSite4.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(528, 266);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.listView1,
																		  this.barLeftDockSite,
																		  this.barRightDockSite,
																		  this.barTopDockSite,
																		  this.barBottomDockSite,
																		  this.dockSite1,
																		  this.dockSite2,
																		  this.dockSite3,
																		  this.dockSite4});
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
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
			CreateToolbar();
		}

		private void CreateToolbar()
		{
			// Suspend layout to optimize for addition of multiple toolbars...
			this.dotNetBarManager1.SuspendLayout=true;

			// This style does not need menu shadows...
			this.dotNetBarManager1.MenuDropShadow = DevComponents.DotNetBar.eMenuDropShadow.Hide;
			// Add general click handler...
			this.dotNetBarManager1.ItemClick+=new EventHandler(this.ItemClick);

			Bar bar;

			// Menu Bar
			bar=new Bar("Menu");
			bar.Stretch=true;
			bar.MenuBar=true;
			// It is important that styles match otherwise style will be set on 
			// bar when it is added to DotNetBarManager.Bars collection
			bar.Style=dotNetBarManager1.Style; 
			SetMenuColorScheme(bar.ColorScheme);

			ButtonItem menu, menuItem;
			
			// File
			menu=new ButtonItem("mFile","&File");
			bar.Items.Add(menu);
			// New
			menuItem=new ButtonItem("mNew","New");
			menu.SubItems.Add(menuItem);
			// Open
			menuItem=new ButtonItem("mOpen","&Open");
			menuItem.Shortcuts.Add(eShortcut.CtrlO);
			menu.SubItems.Add(menuItem);
			// Password manager
			menuItem=new ButtonItem("mPasswordManager","Password Manager");
			menuItem.BeginGroup=true;
			menu.SubItems.Add(menuItem);
			// Backup
			menuItem=new ButtonItem("mBackup","&Back Up...");
			menuItem.BeginGroup=true;
			menu.SubItems.Add(menuItem);
			// Restore
			menuItem=new ButtonItem("mRestore","&Restore...");
			menu.SubItems.Add(menuItem);
			// Archive
			menuItem=new ButtonItem("mArchive","&Archive...");
			menu.SubItems.Add(menuItem);
			// Exit
			menuItem=new ButtonItem("mExit","E&xit");
			menuItem.BeginGroup=true;
			menu.SubItems.Add(menuItem);

			// Edit
			menu=new ButtonItem("mEdit","&Edit");
			bar.Items.Add(menu);
			// New
			menuItem=new ButtonItem("mUndo","Undo");
			menuItem.Shortcuts.Add(eShortcut.CtrlZ);
			menu.SubItems.Add(menuItem);
			// Cut
			menuItem=new ButtonItem("mCut","Cut");
			menuItem.Shortcuts.Add(eShortcut.CtrlX);
			menuItem.BeginGroup=true;
			menu.SubItems.Add(menuItem);
			// Copy
			menuItem=new ButtonItem("mCopy","Copy");
			menuItem.Shortcuts.Add(eShortcut.CtrlC);
			menu.SubItems.Add(menuItem);
			// Paste
			menuItem=new ButtonItem("mPaste","Paste");
			menuItem.Shortcuts.Add(eShortcut.CtrlV);
			menu.SubItems.Add(menuItem);

			// Must add bar to the bars collection so DotNetBarManager is aware of it
			dotNetBarManager1.Bars.Add(bar);
			// After manager is aware of the bar, we can dock it on appropriate side
			bar.DockSide=eDockSide.Top;


			// Standard Toolbar
			bar=new Bar("Standard");
			// It is important that styles match otherwise style will be set on 
			// bar when it is added to DotNetBarManager.Bars collection
			bar.Style=dotNetBarManager1.Style; 
			bar.Name="barStandard";
			bar.Stretch=true;
			bar.EqualButtonSize=true;
			bar.DisplayMoreItemsOnMenu=true;
			bar.BackgroundImage=new Bitmap(this.GetType(),"background.png");
			bar.BackgroundImagePosition=eBackgroundImagePosition.Tile;
			SetToolbarColorScheme(bar.ColorScheme);

			// Must add bar to the bars collection so DotNetBarManager is aware of it
			dotNetBarManager1.Bars.Add(bar);
			// Set the inital docking line
			bar.DockLine=1;
			// After manager is aware of the bar, we can dock it on appropriate side
			bar.DockSide=eDockSide.Top;

			// Account List
			bar.Items.Add(CreateToolbarButton("bAccountList","Account List","AccountList.png","AccountListHot.png"));
			// Portofolio
			bar.Items.Add(CreateToolbarButton("bPortofolio","Portofolio","Portofolio.png","PortofolioHot.png"));
			// Bills and Deposits
			bar.Items.Add(CreateToolbarButton("bBills","Bills && Deposits","BillsAndDeposits.png","BillsAndDepositsHot.png"));
			// Reports
			bar.Items.Add(CreateToolbarButton("bReports","Reports","Reports.png","ReportsHot.png"));
			// Cash Flow
			bar.Items.Add(CreateToolbarButton("bCashFlow","Cash Flow","CashFlow.png","CashFlowHot.png"));
			// Budget
			bar.Items.Add(CreateToolbarButton("bBudget","Budget","Budget.png","BudgetHot.png"));

			// Bottom bar...
			// Standard Toolbar
			bar=new Bar("BottomBar");
			// It is important that styles match otherwise style will be set on 
			// bar when it is added to DotNetBarManager.Bars collection
			bar.Style=dotNetBarManager1.Style; 
			bar.Name="barBottom";
			bar.Stretch=true;
			bar.EqualButtonSize=true;
			bar.DisplayMoreItemsOnMenu=true;
			bar.BackgroundImage=new Bitmap(this.GetType(),"background.png");
			bar.BackgroundImagePosition=eBackgroundImagePosition.Tile;
			SetToolbarColorScheme(bar.ColorScheme);

			// Must add bar to the bars collection so DotNetBarManager is aware of it
			dotNetBarManager1.Bars.Add(bar);
			// After manager is aware of the bar, we can dock it on appropriate side
			bar.DockSide=eDockSide.Bottom;

			LabelItem label=new LabelItem("lStatus","Online");
			label.PaddingTop=2;
			label.PaddingBottom=2;
			label.Width=64;
			label.TextAlignment=StringAlignment.Center;
			label.ForeColor=Color.FromArgb(247,222,156);
			bar.Items.Add(label);

			ButtonItem button=new ButtonItem("bInternetUpdates","Internet Updates...");
			button.BeginGroup=true;
			button.HotTrackingStyle=eHotTrackingStyle.None;
			button.Cursor=Cursors.Hand;
			button.Click+=new EventHandler(this.InternetUpdates);
			bar.Items.Add(button);

			// Resume layout
			this.dotNetBarManager1.SuspendLayout=false;
		}

		private void SetToolbarColorScheme(ColorScheme scheme)
		{
			// Setup toolbar custom color scheme...
			scheme.ItemText=Color.White;
			scheme.ItemHotText=Color.FromArgb(247,222,156);
			scheme.ItemPressedText=Color.FromArgb(247,222,156);
			// This portion of color scheme changes is used only for overflow items
			// i.e. if they cannot fit on toolbar they are displayed on menu
			scheme.ItemHotBackground=Color.FromArgb(80,80,80);
			scheme.ItemHotBackground2=Color.Empty;
			scheme.ItemHotBorder=Color.FromArgb(80,80,80);
			scheme.ItemPressedBackground=Color.FromArgb(91,91,91);
			scheme.ItemPressedBackground2=Color.Empty;
			scheme.ItemPressedBorder=Color.FromArgb(91,91,91);
			scheme.ItemExpandedText=Color.FromArgb(247,222,156);
			scheme.ItemExpandedBackground=Color.FromArgb(91,91,91);
			scheme.ItemExpandedBackground2=Color.Empty;
			scheme.ItemExpandedShadow=Color.Empty;
			scheme.MenuBackground=Color.FromArgb(91,91,91);
			scheme.MenuBackground2=Color.Empty;
			scheme.MenuBarBackground=Color.FromArgb(91,91,91);
			scheme.MenuBarBackground2=Color.Empty;
			scheme.MenuBorder=Color.Black;
			scheme.MenuSide=Color.FromArgb(91,91,91);
			scheme.MenuSide2=Color.Empty;
		}

		private void SetMenuColorScheme(ColorScheme scheme)
		{
			// Setup custom menu color scheme
			scheme.BarBackground=Color.FromArgb(91,91,91);
			scheme.BarBackground2=Color.Empty;
			scheme.MenuBackground=Color.FromArgb(91,91,91);
			scheme.MenuBackground2=Color.Empty;
			scheme.MenuBarBackground=Color.FromArgb(91,91,91);
			scheme.MenuBarBackground2=Color.Empty;
			scheme.MenuBorder=Color.Black;
			scheme.MenuSide=Color.FromArgb(91,91,91);
			scheme.MenuSide2=Color.Empty;
			scheme.ItemBackground=Color.FromArgb(91,91,91);
			scheme.ItemBackground2=Color.Empty;
			scheme.ItemText=Color.White;
			scheme.ItemHotBackground=Color.FromArgb(80,80,80);
			scheme.ItemHotBackground2=Color.Empty;
			scheme.ItemHotBorder=Color.FromArgb(80,80,80);
			scheme.ItemHotText=Color.FromArgb(247,222,156);
			scheme.ItemPressedText=Color.FromArgb(247,222,156);
			scheme.ItemPressedBackground=Color.FromArgb(91,91,91);
			scheme.ItemPressedBackground2=Color.Empty;
			scheme.ItemPressedBorder=Color.FromArgb(91,91,91);
			scheme.ItemExpandedText=Color.FromArgb(247,222,156);
			scheme.ItemExpandedBackground=Color.FromArgb(91,91,91);
			scheme.ItemExpandedBackground2=Color.Empty;
			scheme.ItemExpandedShadow=Color.Empty;
			scheme.ItemExpandedBorder=Color.Black;
		}

		private ButtonItem CreateToolbarButton(string name, string text, string imageName, string hotImageName)
		{
			ButtonItem button=new ButtonItem(name,text);
			button.Image=new Bitmap(this.GetType(),imageName);
			button.HoverImage=new Bitmap(this.GetType(),hotImageName);
			button.PressedImage=button.HoverImage;
			button.HotTrackingStyle=eHotTrackingStyle.None;
			button.ButtonStyle=eButtonStyle.ImageAndText;
			button.ImagePosition=eImagePosition.Top;
			button.Cursor=Cursors.Hand;
			return button;
		}

		private void InternetUpdates(object sender, EventArgs e)
		{
			listView1.Items.Insert(0,"Internet Updates Item Click Handler");
		}

		private void ItemClick(object sender, EventArgs e)
		{
			BaseItem item=sender as BaseItem;
			listView1.Items.Insert(0,item.Text+" Global Click Handler");
		}
	}
}
