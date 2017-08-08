using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;

namespace MenuFromCode
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevComponents.DotNetBar.DotNetBarManager dotNetBarManager1;
		private DevComponents.DotNetBar.DockSite dockSite1;
		private DevComponents.DotNetBar.DockSite dockSite2;
		private DevComponents.DotNetBar.DockSite dockSite3;
		private DevComponents.DotNetBar.DockSite dockSite4;
		private DevComponents.DotNetBar.DockSite dockSite5;
		private DevComponents.DotNetBar.DockSite dockSite6;
		private DevComponents.DotNetBar.DockSite dockSite7;
		private DevComponents.DotNetBar.DockSite dockSite8;
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
			this.dockSite4 = new DevComponents.DotNetBar.DockSite();
			this.dockSite1 = new DevComponents.DotNetBar.DockSite();
			this.dockSite2 = new DevComponents.DotNetBar.DockSite();
			this.dockSite3 = new DevComponents.DotNetBar.DockSite();
			this.dockSite5 = new DevComponents.DotNetBar.DockSite();
			this.dockSite6 = new DevComponents.DotNetBar.DockSite();
			this.dockSite7 = new DevComponents.DotNetBar.DockSite();
			this.dockSite8 = new DevComponents.DotNetBar.DockSite();
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
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY);
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
			this.dotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
			this.dotNetBarManager1.BottomDockSite = this.dockSite4;
			this.dotNetBarManager1.DefinitionName = "";
			this.dotNetBarManager1.EnableFullSizeDock = false;
			this.dotNetBarManager1.LeftDockSite = this.dockSite1;
			this.dotNetBarManager1.ParentForm = this;
			this.dotNetBarManager1.RightDockSite = this.dockSite2;
			this.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
			this.dotNetBarManager1.ToolbarBottomDockSite = this.dockSite8;
			this.dotNetBarManager1.ToolbarLeftDockSite = this.dockSite5;
			this.dotNetBarManager1.ToolbarRightDockSite = this.dockSite6;
			this.dotNetBarManager1.ToolbarTopDockSite = this.dockSite7;
			this.dotNetBarManager1.TopDockSite = this.dockSite3;
			// 
			// dockSite4
			// 
			this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dockSite4.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.dockSite4.Location = new System.Drawing.Point(0, 193);
			this.dockSite4.Name = "dockSite4";
			this.dockSite4.Size = new System.Drawing.Size(347, 0);
			this.dockSite4.TabIndex = 3;
			this.dockSite4.TabStop = false;
			// 
			// dockSite1
			// 
			this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
			this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.dockSite1.Name = "dockSite1";
			this.dockSite1.Size = new System.Drawing.Size(0, 193);
			this.dockSite1.TabIndex = 0;
			this.dockSite1.TabStop = false;
			// 
			// dockSite2
			// 
			this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
			this.dockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.dockSite2.Location = new System.Drawing.Point(347, 0);
			this.dockSite2.Name = "dockSite2";
			this.dockSite2.Size = new System.Drawing.Size(0, 193);
			this.dockSite2.TabIndex = 1;
			this.dockSite2.TabStop = false;
			// 
			// dockSite3
			// 
			this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
			this.dockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.dockSite3.Name = "dockSite3";
			this.dockSite3.Size = new System.Drawing.Size(347, 0);
			this.dockSite3.TabIndex = 2;
			this.dockSite3.TabStop = false;
			// 
			// dockSite5
			// 
			this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
			this.dockSite5.Name = "dockSite5";
			this.dockSite5.Size = new System.Drawing.Size(0, 193);
			this.dockSite5.TabIndex = 4;
			this.dockSite5.TabStop = false;
			// 
			// dockSite6
			// 
			this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
			this.dockSite6.Location = new System.Drawing.Point(347, 0);
			this.dockSite6.Name = "dockSite6";
			this.dockSite6.Size = new System.Drawing.Size(0, 193);
			this.dockSite6.TabIndex = 5;
			this.dockSite6.TabStop = false;
			// 
			// dockSite7
			// 
			this.dockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite7.Dock = System.Windows.Forms.DockStyle.Top;
			this.dockSite7.Name = "dockSite7";
			this.dockSite7.Size = new System.Drawing.Size(347, 0);
			this.dockSite7.TabIndex = 6;
			this.dockSite7.TabStop = false;
			// 
			// dockSite8
			// 
			this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dockSite8.Location = new System.Drawing.Point(0, 193);
			this.dockSite8.Name = "dockSite8";
			this.dockSite8.Size = new System.Drawing.Size(347, 0);
			this.dockSite8.TabIndex = 7;
			this.dockSite8.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(347, 193);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.dockSite1,
																		  this.dockSite2,
																		  this.dockSite3,
																		  this.dockSite4,
																		  this.dockSite5,
																		  this.dockSite6,
																		  this.dockSite7,
																		  this.dockSite8});
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
			CreateMenu();
		}

		private void CreateMenu()
		{
			Bar bar=new Bar("Menu Bar");
			bar.MenuBar=true;
			bar.Stretch=true;
			bar.Style=eDotNetBarStyle.Office2003;
			dotNetBarManager1.Bars.Add(bar);
			bar.DockSide=eDockSide.Top;
			
			ButtonItem menu, submenu;
			menu=new ButtonItem("bFile","&File");
			bar.Items.Add(menu);
			submenu=new ButtonItem("bOpen","&Open");
			menu.SubItems.Add(submenu);
			submenu=new ButtonItem("bClose","&Close");
			menu.SubItems.Add(submenu);
			submenu=new ButtonItem("bExit","&Exit");
			submenu.BeginGroup=true;
			menu.SubItems.Add(submenu);

            menu=new ButtonItem("bEdit","&Edit");
			bar.Items.Add(menu);
			submenu=new ButtonItem("bCut","&Cut");
			menu.SubItems.Add(submenu);
			submenu=new ButtonItem("bCopy","&Copy");
			menu.SubItems.Add(submenu);
			submenu=new ButtonItem("bPaste","&Paste");
			menu.SubItems.Add(submenu);
			submenu=new ButtonItem("bClear","&Clear");
			submenu.BeginGroup=true;
			menu.SubItems.Add(submenu);

			bar.RecalcLayout();
		}
	}
}
