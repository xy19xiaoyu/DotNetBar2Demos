using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;

namespace DockingFromCode
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
			this.dotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
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
			this.barBottomDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.barBottomDockSite.Location = new System.Drawing.Point(0, 334);
			this.barBottomDockSite.Name = "barBottomDockSite";
			this.barBottomDockSite.Size = new System.Drawing.Size(408, 0);
			this.barBottomDockSite.TabIndex = 3;
			this.barBottomDockSite.TabStop = false;
			// 
			// barLeftDockSite
			// 
			this.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left;
			this.barLeftDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.barLeftDockSite.Name = "barLeftDockSite";
			this.barLeftDockSite.Size = new System.Drawing.Size(0, 334);
			this.barLeftDockSite.TabIndex = 0;
			this.barLeftDockSite.TabStop = false;
			// 
			// barRightDockSite
			// 
			this.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right;
			this.barRightDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.barRightDockSite.Location = new System.Drawing.Point(408, 0);
			this.barRightDockSite.Name = "barRightDockSite";
			this.barRightDockSite.Size = new System.Drawing.Size(0, 334);
			this.barRightDockSite.TabIndex = 1;
			this.barRightDockSite.TabStop = false;
			// 
			// barTopDockSite
			// 
			this.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top;
			this.barTopDockSite.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.barTopDockSite.Name = "barTopDockSite";
			this.barTopDockSite.Size = new System.Drawing.Size(408, 0);
			this.barTopDockSite.TabIndex = 2;
			this.barTopDockSite.TabStop = false;
			// 
			// dockSite1
			// 
			this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
			this.dockSite1.Name = "dockSite1";
			this.dockSite1.Size = new System.Drawing.Size(0, 334);
			this.dockSite1.TabIndex = 4;
			this.dockSite1.TabStop = false;
			// 
			// dockSite2
			// 
			this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
			this.dockSite2.Location = new System.Drawing.Point(408, 0);
			this.dockSite2.Name = "dockSite2";
			this.dockSite2.Size = new System.Drawing.Size(0, 334);
			this.dockSite2.TabIndex = 5;
			this.dockSite2.TabStop = false;
			// 
			// dockSite3
			// 
			this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
			this.dockSite3.Name = "dockSite3";
			this.dockSite3.Size = new System.Drawing.Size(408, 0);
			this.dockSite3.TabIndex = 6;
			this.dockSite3.TabStop = false;
			// 
			// dockSite4
			// 
			this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dockSite4.Location = new System.Drawing.Point(0, 334);
			this.dockSite4.Name = "dockSite4";
			this.dockSite4.Size = new System.Drawing.Size(408, 0);
			this.dockSite4.TabIndex = 7;
			this.dockSite4.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(408, 334);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
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
			dotNetBarManager1.DockTabChange+=new DotNetBarManager.DockTabChangeEventHandler(this.DockTabChanged);
			CreateBottomBarAutoHide();
			CreateLeftDockedBars();
		}

		private void DockTabChanged(object sender, DockTabChangeEventArgs e)
		{
			// Sync caption of the bar with the currently selected dock tab
			Bar bar=sender as Bar;
			if(bar==null || e.NewTab==null)
				return;
			bar.Text=e.NewTab.Text;
		}

		private void CreateBottomBarAutoHide()
		{
			Bar bar=new Bar("Bottom Bar in auto-hide state");
			bar.Name="bottomBar";
			bar.LayoutType=eLayoutType.DockContainer;  // Dock Container Layout needed for dockable windows
			bar.Stretch=true; // Dockable windows stretch to fill container
			bar.AutoHideAnimationTime=0; // Some controls do not support animation so turn it off
			bar.GrabHandleStyle=eGrabHandleStyle.Caption; // Dockable Windows have captions
			dotNetBarManager1.Bars.Add(bar); // DotNetBar needs to be aware of the bar so it can manage it's docking etc.
			
			// Create hosted controls
			DockContainerItem dockItem=new DockContainerItem("bottomDockItem1","First dock item");
			bar.Items.Add(dockItem);
			// Create control that we want to host on dockable window
			UserControl1 dockedControl=new UserControl1();
			dockedControl.label1.Text=bar.Name+" - "+dockItem.Text;
			dockedControl.BackColor=Color.Azure;
			dockItem.Control=dockedControl; // Specify that control is hosted on the dock container
			dockItem.Height=128; // Specify the height of the dockable container and at the same time control

			// Create second dock container and add it to the bar
			dockItem=new DockContainerItem("bottomDockItem2","Second dock item");
			bar.Items.Add(dockItem);
			dockedControl=new UserControl1();
			dockedControl.label1.Text=bar.Name+" - "+dockItem.Text;
			dockedControl.BackColor=Color.Aquamarine;
			dockItem.Control=dockedControl; // Specify that control is hosted on the dock container
			
			// Dock bar to bottom dock site
			dotNetBarManager1.BottomDockSite.GetDocumentUIManager().Dock(bar);
			dockItem.Height=128; // Specify the height of the dockable container and at the same time control

			bar.RecalcLayout(); // Apply all changes...
			bar.AutoHide=true; // Place bar in auto-hide mode. Bar needs to be docked before it can be places in auto-hide mode
		}

		private void CreateLeftDockedBars()
		{
			// Dock first two bars side by side and dock third bar next to them...
			Bar bar=new Bar("Bar1");
			bar.Name="leftBar1";
			bar.LayoutType=eLayoutType.DockContainer;  // Dock Container Layout needed for dockable windows
			bar.Stretch=true; // Dockable windows stretch to fill container
			bar.AutoHideAnimationTime=0; // Some controls do not support animation so turn it off
			bar.GrabHandleStyle=eGrabHandleStyle.Caption; // Dockable Windows have captions
			bar.CanHide=true;
			// Create DockContainerItem for the bar. The item should be added before the bar is docked.
			DockContainerItem dockItem=new DockContainerItem("leftDockItem1","Top Left Dock Container");
			bar.Items.Add(dockItem);
			// Create control that is hosted on dock container
			UserControl1 dockedControl=new UserControl1();
			dockedControl.label1.Text=bar.Name+" - "+dockItem.Text;
			dockedControl.BackColor=Color.Khaki;
			dockItem.Control=dockedControl; // Specify that control is hosted on the dock container
			dotNetBarManager1.Bars.Add(bar); // DotNetBar needs to be aware of the bar so it can manage it's docking etc.
			dotNetBarManager1.LeftDockSite.GetDocumentUIManager().Dock(bar); //Performs actual docking of the Bar to the specified dock site
			dockItem.Width=128; // Specify Width of dock container item after it is docked
		
			// Create second bar and dock it below the first bar but still on the same line
			Bar bar2=new Bar("Bar2");
			bar2.Name="leftBar2";
			bar2.LayoutType=eLayoutType.DockContainer;  // Dock Container Layout needed for dockable windows
			bar2.AutoHideAnimationTime=0; // Some controls do not support animation so turn it off
			bar2.Stretch=true; // Dockable windows stretch to fill container
			bar2.CanHide=true;
			bar2.GrabHandleStyle=eGrabHandleStyle.Caption; // Dockable Windows have captions
			// Add new Dock Container to the bar, should be done before adding the bar so size can be calculated properly
			dockItem=new DockContainerItem("leftDockItem2","Bottom Left Dock Container");
			bar2.Items.Add(dockItem);
			// Create control that is hosted on dock container
			dockedControl=new UserControl1();
			dockedControl.label1.Text=bar.Name+" - "+dockItem.Text;
			dockedControl.BackColor=Color.Lavender;
			dockItem.Control=dockedControl; // Specify that control is hosted on the dock container
			dotNetBarManager1.Bars.Add(bar2); // DotNetBar needs to be aware of the bar so it can manage it's docking etc.
			dotNetBarManager1.LeftDockSite.GetDocumentUIManager().Dock(bar, bar2, eDockSide.Bottom); // Dock new bar2 below the bar that we created previously
			
			// Create third bar that is docked next to the first and second
			// i.e. on the line 1
			bar=new Bar("Bar3");
			bar.Name="leftBar3";
			bar.LayoutType=eLayoutType.DockContainer;  // Dock Container Layout needed for dockable windows
			bar.AutoHideAnimationTime=0; // Some controls do not support animation so turn it off
			bar.Stretch=true; // Dockable windows stretch to fill container
			bar.CanHide=true;
			bar.GrabHandleStyle=eGrabHandleStyle.Caption; // Dockable Windows have captions
			dockItem=new DockContainerItem("leftDockItem3","Left Dock Container line 1");
			bar.Items.Add(dockItem);
			// Create control that is hosted on dock container
			dockedControl=new UserControl1();
			dockedControl.label1.Text=bar.Name+" - "+dockItem.Text;
			dockedControl.BackColor=Color.LemonChiffon;
			dockItem.Control=dockedControl; // Specify that control is hosted on the dock container
			dotNetBarManager1.Bars.Add(bar); // DotNetBar needs to be aware of the bar so it can manage it's docking etc.
			dotNetBarManager1.LeftDockSite.GetDocumentUIManager().Dock(bar);

			// Setting the width of the dock site will also scale the bars docked inside,
			// however the size should be large enough to accomodate all bars including the constraints like MinimumSize etc.
			dotNetBarManager1.LeftDockSite.Width = 150;
		}
	}
}
