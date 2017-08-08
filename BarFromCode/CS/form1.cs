using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;

namespace BarFromCode
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevComponents.DotNetBar.DotNetBarManager m_DotNetBar;
		private DevComponents.DotNetBar.DockSite barLeftDockSite;
		private DevComponents.DotNetBar.DockSite barRightDockSite;
		private DevComponents.DotNetBar.DockSite barTopDockSite;
		private DevComponents.DotNetBar.DockSite barBottomDockSite;
		private System.Windows.Forms.ImageList imageList1;
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

			// Create Toolbar
			CreateBar();
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
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.m_DotNetBar = new DevComponents.DotNetBar.DotNetBarManager(this.components);
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
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// m_DotNetBar
			// 
			this.m_DotNetBar.BottomDockSite = this.barBottomDockSite;
			this.m_DotNetBar.DefinitionName = "";
			this.m_DotNetBar.Images = this.imageList1;
			this.m_DotNetBar.LeftDockSite = this.barLeftDockSite;
			this.m_DotNetBar.ParentForm = this;
			this.m_DotNetBar.RightDockSite = this.barRightDockSite;
			this.m_DotNetBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
			this.m_DotNetBar.ToolbarBottomDockSite = this.dockSite4;
			this.m_DotNetBar.ToolbarLeftDockSite = this.dockSite1;
			this.m_DotNetBar.ToolbarRightDockSite = this.dockSite2;
			this.m_DotNetBar.ToolbarTopDockSite = this.dockSite3;
			this.m_DotNetBar.TopDockSite = this.barTopDockSite;
			this.m_DotNetBar.ItemClick += new System.EventHandler(this.BarItemClick);
			// 
			// barBottomDockSite
			// 
			this.barBottomDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barBottomDockSite.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barBottomDockSite.Location = new System.Drawing.Point(0, 207);
			this.barBottomDockSite.Name = "barBottomDockSite";
			this.barBottomDockSite.Size = new System.Drawing.Size(351, 0);
			this.barBottomDockSite.TabIndex = 3;
			this.barBottomDockSite.TabStop = false;
			// 
			// barLeftDockSite
			// 
			this.barLeftDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barLeftDockSite.Dock = System.Windows.Forms.DockStyle.Left;
			this.barLeftDockSite.Name = "barLeftDockSite";
			this.barLeftDockSite.Size = new System.Drawing.Size(0, 207);
			this.barLeftDockSite.TabIndex = 0;
			this.barLeftDockSite.TabStop = false;
			// 
			// barRightDockSite
			// 
			this.barRightDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barRightDockSite.Dock = System.Windows.Forms.DockStyle.Right;
			this.barRightDockSite.Location = new System.Drawing.Point(351, 0);
			this.barRightDockSite.Name = "barRightDockSite";
			this.barRightDockSite.Size = new System.Drawing.Size(0, 207);
			this.barRightDockSite.TabIndex = 1;
			this.barRightDockSite.TabStop = false;
			// 
			// barTopDockSite
			// 
			this.barTopDockSite.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.barTopDockSite.Dock = System.Windows.Forms.DockStyle.Top;
			this.barTopDockSite.Name = "barTopDockSite";
			this.barTopDockSite.Size = new System.Drawing.Size(351, 0);
			this.barTopDockSite.TabIndex = 2;
			this.barTopDockSite.TabStop = false;
			// 
			// dockSite1
			// 
			this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
			this.dockSite1.Name = "dockSite1";
			this.dockSite1.Size = new System.Drawing.Size(0, 207);
			this.dockSite1.TabIndex = 4;
			this.dockSite1.TabStop = false;
			// 
			// dockSite2
			// 
			this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
			this.dockSite2.Location = new System.Drawing.Point(351, 0);
			this.dockSite2.Name = "dockSite2";
			this.dockSite2.Size = new System.Drawing.Size(0, 207);
			this.dockSite2.TabIndex = 5;
			this.dockSite2.TabStop = false;
			// 
			// dockSite3
			// 
			this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
			this.dockSite3.Name = "dockSite3";
			this.dockSite3.Size = new System.Drawing.Size(351, 0);
			this.dockSite3.TabIndex = 6;
			this.dockSite3.TabStop = false;
			// 
			// dockSite4
			// 
			this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dockSite4.Location = new System.Drawing.Point(0, 207);
			this.dockSite4.Name = "dockSite4";
			this.dockSite4.Size = new System.Drawing.Size(351, 0);
			this.dockSite4.TabIndex = 7;
			this.dockSite4.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(351, 207);
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

		private void CreateBar()
		{
			// Create a new Bar
			Bar bar=new Bar("Standard");
			bar.CanHide=true;
			bar.Style=eDotNetBarStyle.Office2003;
			bar.GrabHandleStyle=eGrabHandleStyle.StripeFlat;
			bar.WrapItemsDock=true;
			bar.WrapItemsFloat=false;

			// Add Items to it
			ButtonItem item, fileItem;
			// New
			item=new ButtonItem("bNew");	
			item.ImageIndex=0;
			item.Text="&New";
			item.Shortcuts.Add(eShortcut.CtrlN);
			item.Category="Standard";
			bar.Items.Add(item);	
			m_DotNetBar.Items.Add(item.Copy());		// This will create Category Entry

			// Open
			item=new ButtonItem("bOpen");
			item.ImageIndex=1;
			item.Text="&Open";
			item.Shortcuts.Add(eShortcut.CtrlO);
			item.Category="Standard";
			bar.Items.Add(item);
			m_DotNetBar.Items.Add(item.Copy());
			// Add Sub items to the Open, something like recently used files...
			fileItem=new ButtonItem("file1");
			fileItem.Text="&1. File1.txt";
			item.SubItems.Add(fileItem);
			fileItem=new ButtonItem("file2");
			fileItem.Text="&2. File2.txt";
			item.SubItems.Add(fileItem);
			fileItem=new ButtonItem("file3");
			fileItem.Text="&3. File3.txt";
			item.SubItems.Add(fileItem);
			fileItem=new ButtonItem("file4");
			fileItem.Text="&4. File4.txt";
			item.SubItems.Add(fileItem);
			fileItem=new ButtonItem("file5");
			fileItem.Text="&5. File5.txt";
			item.SubItems.Add(fileItem);

			// Close
			item=new ButtonItem("bClose");
			item.ImageIndex=2;
			item.Text="&Close";
			item.Shortcuts.Add(eShortcut.CtrlX);
			item.Category="Standard";
			bar.Items.Add(item);
			m_DotNetBar.Items.Add(item.Copy());

			// Save
			item=new ButtonItem("bSave");
			item.ImageIndex=3;
			item.Text="&Save";
			item.Shortcuts.Add(eShortcut.CtrlS);
			item.Category="Standard";
			bar.Items.Add(item);
			m_DotNetBar.Items.Add(item.Copy());

			// Print Preview
			item=new ButtonItem("bPrintPreview");
			item.ImageIndex=6;
			item.Text="Print Pre&view";
			item.Category="Standard";
			item.BeginGroup=true;
			bar.Items.Add(item);
			m_DotNetBar.Items.Add(item.Copy());

			// Print
			item=new ButtonItem("bPrint");
			item.ImageIndex=5;
			item.Text="&Print";
			item.Category="Standard";
			item.Shortcuts.Add(eShortcut.CtrlP);
			bar.Items.Add(item);
			m_DotNetBar.Items.Add(item.Copy());

			// E-Mail
			item=new ButtonItem("bEmail");
			item.ImageIndex=4;
			item.Text="&Email";
			item.Category="Standard";
			item.BeginGroup=true;
			bar.Items.Add(item);
			m_DotNetBar.Items.Add(item.Copy());

			// Customize Item
			CustomizeItem citem=new CustomizeItem();
			bar.Items.Add(citem);

			// Since we will be using ImageList bar have to be added to the DotNetBar Manager
			m_DotNetBar.Bars.Add(bar);

			bar.DockSide=eDockSide.Top;
		}

		private void BarItemClick(object sender, EventArgs e)
		{
			BaseItem item=sender as BaseItem;
			if(item==null || item.Name=="" || item.SystemItem)
				return;
			MessageBox.Show("Item '"+item.Name+"' clicked");
		}
	}
}
