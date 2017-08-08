using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;

namespace Popup
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button cmdPopupMenu;
		private System.Windows.Forms.Button cmdPopupBar;
		private System.Windows.Forms.Button cmdClose;
		private DevComponents.DotNetBar.Controls.ComboBoxEx cboStyle;
		private DevComponents.Editors.ComboItem comboItem1;
		private DevComponents.Editors.ComboItem comboItem2;
		private System.ComponentModel.IContainer components;
		private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
		private DevComponents.DotNetBar.ButtonItem bRichPopup;
		private DevComponents.DotNetBar.ButtonItem bCut;
		private DevComponents.DotNetBar.ButtonItem bCopy;
		private DevComponents.DotNetBar.ButtonItem bPaste;
		private DevComponents.DotNetBar.ButtonItem bDelete;
		private DevComponents.DotNetBar.ButtonItem bSelectAll;
		private DevComponents.DotNetBar.DotNetBarManager dotNetBarManager1;
		private DevComponents.DotNetBar.DockSite dockSite1;
		private DevComponents.DotNetBar.DockSite dockSite2;
		private DevComponents.DotNetBar.DockSite dockSite3;
		private DevComponents.DotNetBar.DockSite dockSite4;
		private DevComponents.DotNetBar.DockSite dockSite5;
		private DevComponents.DotNetBar.DockSite dockSite6;
		private DevComponents.DotNetBar.DockSite dockSite7;
		private DevComponents.DotNetBar.DockSite dockSite8;

		private DevComponents.DotNetBar.ButtonItem m_PopupFromCode=null;

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
			this.cmdPopupBar = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.cmdPopupMenu = new System.Windows.Forms.Button();
			this.comboItem2 = new DevComponents.Editors.ComboItem();
			this.comboItem1 = new DevComponents.Editors.ComboItem();
			this.cboStyle = new DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.cmdClose = new System.Windows.Forms.Button();
			this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
			this.bRichPopup = new DevComponents.DotNetBar.ButtonItem();
			this.bCut = new DevComponents.DotNetBar.ButtonItem();
			this.bCopy = new DevComponents.DotNetBar.ButtonItem();
			this.bPaste = new DevComponents.DotNetBar.ButtonItem();
			this.bDelete = new DevComponents.DotNetBar.ButtonItem();
			this.bSelectAll = new DevComponents.DotNetBar.ButtonItem();
			this.dotNetBarManager1 = new DevComponents.DotNetBar.DotNetBarManager(this.components);
			this.dockSite1 = new DevComponents.DotNetBar.DockSite();
			this.dockSite2 = new DevComponents.DotNetBar.DockSite();
			this.dockSite3 = new DevComponents.DotNetBar.DockSite();
			this.dockSite4 = new DevComponents.DotNetBar.DockSite();
			this.dockSite5 = new DevComponents.DotNetBar.DockSite();
			this.dockSite6 = new DevComponents.DotNetBar.DockSite();
			this.dockSite7 = new DevComponents.DotNetBar.DockSite();
			this.dockSite8 = new DevComponents.DotNetBar.DockSite();
			((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdPopupBar
			// 
			this.cmdPopupBar.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.cmdPopupBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdPopupBar.Location = new System.Drawing.Point(296, 66);
			this.cmdPopupBar.Name = "cmdPopupBar";
			this.cmdPopupBar.Size = new System.Drawing.Size(88, 24);
			this.cmdPopupBar.TabIndex = 5;
			this.cmdPopupBar.Text = "Popup Bar";
			this.cmdPopupBar.Click += new System.EventHandler(this.PopupBar);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.contextMenuBar1.SetContextMenuEx(this.richTextBox1, this.bRichPopup);
			this.richTextBox1.Location = new System.Drawing.Point(8, 8);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(280, 208);
			this.richTextBox1.TabIndex = 4;
			this.richTextBox1.Text = "Right-click in this edit box to show context menu";
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 15);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Silver;
			// 
			// cmdPopupMenu
			// 
			this.cmdPopupMenu.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.cmdPopupMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdPopupMenu.Location = new System.Drawing.Point(296, 34);
			this.cmdPopupMenu.Name = "cmdPopupMenu";
			this.cmdPopupMenu.Size = new System.Drawing.Size(88, 24);
			this.cmdPopupMenu.TabIndex = 5;
			this.cmdPopupMenu.Text = "Popup Menu";
			this.cmdPopupMenu.Click += new System.EventHandler(this.PopupMenu);
			// 
			// comboItem2
			// 
			this.comboItem2.Text = "VS.NET 2005";
			this.comboItem2.TextLineAlignment = System.Drawing.StringAlignment.Center;
			// 
			// comboItem1
			// 
			this.comboItem1.Text = "Office2003";
			this.comboItem1.TextLineAlignment = System.Drawing.StringAlignment.Center;
			// 
			// cboStyle
			// 
			this.cboStyle.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.cboStyle.DisableInternalDrawing = false;
			this.cboStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboStyle.DropDownWidth = 84;
			this.cboStyle.Images = null;
			this.cboStyle.Items.AddRange(new object[] {
														  this.comboItem1,
														  this.comboItem2});
			this.cboStyle.Location = new System.Drawing.Point(299, 8);
			this.cboStyle.Name = "cboStyle";
			this.cboStyle.Size = new System.Drawing.Size(84, 21);
			this.cboStyle.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
			this.cboStyle.TabIndex = 6;
			// 
			// cmdClose
			// 
			this.cmdClose.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdClose.Location = new System.Drawing.Point(296, 192);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(88, 24);
			this.cmdClose.TabIndex = 5;
			this.cmdClose.Text = "&Close";
			this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
			// 
			// contextMenuBar1
			// 
			this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																						   this.bRichPopup});
			this.contextMenuBar1.Location = new System.Drawing.Point(288, 104);
			this.contextMenuBar1.Name = "contextMenuBar1";
			this.contextMenuBar1.Size = new System.Drawing.Size(104, 25);
			this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
			this.contextMenuBar1.TabIndex = 11;
			this.contextMenuBar1.TabStop = false;
			// 
			// bRichPopup
			// 
			this.bRichPopup.AutoExpandOnClick = true;
			this.bRichPopup.GlobalName = "bRichPopup";
			this.bRichPopup.Name = "bRichPopup";
			this.bRichPopup.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
			this.bRichPopup.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																						 this.bCut,
																						 this.bCopy,
																						 this.bPaste,
																						 this.bDelete,
																						 this.bSelectAll});
			this.bRichPopup.Text = "Rich Edit Popup";
			// 
			// bCut
			// 
			this.bCut.GlobalName = "bCut";
			this.bCut.ImageIndex = 0;
			this.bCut.Name = "bCut";
			this.bCut.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
			this.bCut.Text = "Cu&t";
			// 
			// bCopy
			// 
			this.bCopy.GlobalName = "bCopy";
			this.bCopy.ImageIndex = 1;
			this.bCopy.Name = "bCopy";
			this.bCopy.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
			this.bCopy.Text = "&Copy";
			// 
			// bPaste
			// 
			this.bPaste.GlobalName = "bPaste";
			this.bPaste.ImageIndex = 2;
			this.bPaste.Name = "bPaste";
			this.bPaste.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
			this.bPaste.Text = "&Paste";
			// 
			// bDelete
			// 
			this.bDelete.GlobalName = "bDelete";
			this.bDelete.Name = "bDelete";
			this.bDelete.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
			this.bDelete.Text = "&Delete";
			// 
			// bSelectAll
			// 
			this.bSelectAll.BeginGroup = true;
			this.bSelectAll.GlobalName = "bSelectAll";
			this.bSelectAll.Name = "bSelectAll";
			this.bSelectAll.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.SystemDefault;
			this.bSelectAll.Text = "Select &All";
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
			// dockSite1
			// 
			this.dockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite1.Dock = System.Windows.Forms.DockStyle.Left;
			this.dockSite1.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.dockSite1.Name = "dockSite1";
			this.dockSite1.Size = new System.Drawing.Size(0, 225);
			this.dockSite1.TabIndex = 12;
			this.dockSite1.TabStop = false;
			// 
			// dockSite2
			// 
			this.dockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite2.Dock = System.Windows.Forms.DockStyle.Right;
			this.dockSite2.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.dockSite2.Location = new System.Drawing.Point(392, 0);
			this.dockSite2.Name = "dockSite2";
			this.dockSite2.Size = new System.Drawing.Size(0, 225);
			this.dockSite2.TabIndex = 13;
			this.dockSite2.TabStop = false;
			// 
			// dockSite3
			// 
			this.dockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite3.Dock = System.Windows.Forms.DockStyle.Top;
			this.dockSite3.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.dockSite3.Name = "dockSite3";
			this.dockSite3.Size = new System.Drawing.Size(392, 0);
			this.dockSite3.TabIndex = 14;
			this.dockSite3.TabStop = false;
			// 
			// dockSite4
			// 
			this.dockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dockSite4.DocumentDockContainer = new DevComponents.DotNetBar.DocumentDockContainer();
			this.dockSite4.Location = new System.Drawing.Point(0, 225);
			this.dockSite4.Name = "dockSite4";
			this.dockSite4.Size = new System.Drawing.Size(392, 0);
			this.dockSite4.TabIndex = 15;
			this.dockSite4.TabStop = false;
			// 
			// dockSite5
			// 
			this.dockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite5.Dock = System.Windows.Forms.DockStyle.Left;
			this.dockSite5.Name = "dockSite5";
			this.dockSite5.Size = new System.Drawing.Size(0, 225);
			this.dockSite5.TabIndex = 16;
			this.dockSite5.TabStop = false;
			// 
			// dockSite6
			// 
			this.dockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite6.Dock = System.Windows.Forms.DockStyle.Right;
			this.dockSite6.Location = new System.Drawing.Point(392, 0);
			this.dockSite6.Name = "dockSite6";
			this.dockSite6.Size = new System.Drawing.Size(0, 225);
			this.dockSite6.TabIndex = 17;
			this.dockSite6.TabStop = false;
			// 
			// dockSite7
			// 
			this.dockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite7.Dock = System.Windows.Forms.DockStyle.Top;
			this.dockSite7.Name = "dockSite7";
			this.dockSite7.Size = new System.Drawing.Size(392, 0);
			this.dockSite7.TabIndex = 18;
			this.dockSite7.TabStop = false;
			// 
			// dockSite8
			// 
			this.dockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			this.dockSite8.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dockSite8.Location = new System.Drawing.Point(0, 225);
			this.dockSite8.Name = "dockSite8";
			this.dockSite8.Size = new System.Drawing.Size(392, 0);
			this.dockSite8.TabIndex = 19;
			this.dockSite8.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(392, 225);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.contextMenuBar1,
																		  this.cboStyle,
																		  this.cmdClose,
																		  this.cmdPopupBar,
																		  this.cmdPopupMenu,
																		  this.richTextBox1,
																		  this.dockSite1,
																		  this.dockSite2,
																		  this.dockSite3,
																		  this.dockSite4,
																		  this.dockSite5,
																		  this.dockSite6,
																		  this.dockSite7,
																		  this.dockSite8});
			this.Name = "Form1";
			this.Text = "DotNetBar Popup Sample";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
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

		private void cmdClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			cboStyle.SelectedIndex=0;
		}

		private void PopupMenu(object sender, System.EventArgs e)
		{
			if(m_PopupFromCode==null)
				CreatePopupMenu();
			
			// Apply style
			DevComponents.DotNetBar.eDotNetBarStyle style=DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
			if(((DevComponents.Editors.ComboItem)cboStyle.SelectedItem).Text!="Office2003")
				style=DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
			m_PopupFromCode.Style=style;
			
			// MUST ALWAYS register popup with DotNetBar Manager if popup does not belong to ContextMenus collection
			dotNetBarManager1.RegisterPopup(m_PopupFromCode);

			// Place the menu just below the button
			Control ctrl=sender as Control;
			Point p=this.PointToScreen(new Point(ctrl.Left,ctrl.Bottom));
			m_PopupFromCode.PopupMenu(p);
		}

		private void PopupBar(object sender, System.EventArgs e)
		{
			if(m_PopupFromCode==null)
				CreatePopupMenu();
			
			// Apply style
			DevComponents.DotNetBar.eDotNetBarStyle style=DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
			if(((DevComponents.Editors.ComboItem)cboStyle.SelectedItem).Text!="Office2003")
				style=DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
			m_PopupFromCode.Style=style;

			// MUST register with the DotNetBar manager if popup does not belong to ContextMenus collection
			dotNetBarManager1.RegisterPopup(m_PopupFromCode);

			// Set the pop-up width, not required but this is how you would change the popup bar width
			// Popup bar height is calculated based on its inital width and nubmer of sub-items
			m_PopupFromCode.PopupWidth=200;

			// Place the menu just below the button
			Control ctrl=sender as Control;
			Point p=this.PointToScreen(new Point(ctrl.Left,ctrl.Bottom));

			m_PopupFromCode.PopupBar(p);
		}

		private void CreatePopupMenu()
		{
			DevComponents.DotNetBar.ButtonItem item;

            m_PopupFromCode=new DevComponents.DotNetBar.ButtonItem();

            // Create items
            item=new DevComponents.DotNetBar.ButtonItem("bCut");
			item.Text="Cu&t";
			// To remember: cannot use the ImageIndex for items that we create from code
			item.Image=imageList1.Images[0];
			m_PopupFromCode.SubItems.Add(item);

			item=new DevComponents.DotNetBar.ButtonItem("bCopy");
			item.Text="&Copy";
			item.Image=imageList1.Images[1];
			m_PopupFromCode.SubItems.Add(item);

			item=new DevComponents.DotNetBar.ButtonItem("bPaste");
			item.Text="&Paste";
			item.Image=imageList1.Images[2];
			m_PopupFromCode.SubItems.Add(item);

			item=new DevComponents.DotNetBar.ButtonItem("bOpenFile");
			item.Text="&Open File";
			item.Enabled=false;
			item.BeginGroup=true;
			m_PopupFromCode.SubItems.Add(item);

			item=new DevComponents.DotNetBar.ButtonItem("bInsertBreakpoint");
			item.Text="Insert B&reakpoint";
			item.BeginGroup=true;
			m_PopupFromCode.SubItems.Add(item);

			item=new DevComponents.DotNetBar.ButtonItem("bNewBreakpoint");
			item.Text="New &Breakpoint...";
			m_PopupFromCode.SubItems.Add(item);

			item=new DevComponents.DotNetBar.ButtonItem("bRunToCursor");
			item.Text="&Run To Cursor";
			item.BeginGroup=true;
			m_PopupFromCode.SubItems.Add(item);

			item=new DevComponents.DotNetBar.ButtonItem("bAddTask");
			item.Text="Add Task List S&hortcut";
			item.BeginGroup=true;
			m_PopupFromCode.SubItems.Add(item);

			// Setup side-bar, make sure that image that is used fits, or exceeds the height
			// Side-bar will be displayed only for popup menus
			DevComponents.DotNetBar.SideBarImage si=new DevComponents.DotNetBar.SideBarImage();
			si.Picture=new Bitmap(typeof(Popup.Form1),"devco.jpg");
			// If image exceeds the size of the popup menu this specifies the image alignment
			si.Alignment=DevComponents.DotNetBar.eAlignment.Bottom;
			// If there is no image specified gradient can be used
			si.GradientColor1=Color.Orange;
			si.GradientColor2=Color.Black;
			m_PopupFromCode.PopUpSideBar=si;
		}

		private void BarItemClick(object sender, EventArgs e)
		{
			DevComponents.DotNetBar.BaseItem item=sender as DevComponents.DotNetBar.BaseItem;
			MessageBox.Show("Item '"+item.Text+"' clicked.");
		}

		private void dotNetBarManager1_PopupShowing(object sender, System.EventArgs e)
		{
			BaseItem popupParent=sender as BaseItem;
			if(popupParent==null)
				return;
			// Disable Select All
			popupParent.SubItems["bPaste"].Enabled=false;
		}
	}
}
