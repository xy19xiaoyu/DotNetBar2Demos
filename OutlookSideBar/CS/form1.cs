using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;

namespace OutlookSideBar
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Office2007Form
	{
		private DevComponents.DotNetBar.SideBar sideBar1;
		private System.Windows.Forms.Panel panel1;
		private DevComponents.DotNetBar.SideBarPanelItem sideBarPanelItem1;
		private DevComponents.DotNetBar.ButtonItem bInbox;
		private DevComponents.DotNetBar.ButtonItem bCalendar;
		private System.Windows.Forms.ImageList imagesSmall;
		private System.Windows.Forms.ImageList imagesMedium;
		private DevComponents.DotNetBar.ButtonItem bContacts;
		private DevComponents.DotNetBar.ButtonItem bTasks;
		private DevComponents.DotNetBar.ButtonItem bNotes;
		private DevComponents.DotNetBar.ButtonItem bDeletedItems;
		private System.Windows.Forms.Label label1;
		private DevComponents.DotNetBar.Controls.TextBoxX textBox1;
		private DevComponents.DotNetBar.SideBarPanelItem sideBarPanelItem2;
		private DevComponents.DotNetBar.ButtonItem bDrafts;
		private DevComponents.DotNetBar.ButtonItem bOutbox;
		private DevComponents.DotNetBar.ButtonItem bSentItems;
		private DevComponents.DotNetBar.ButtonItem bJournal;
		private DevComponents.DotNetBar.ButtonItem bUpdate;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label label2;

		// We need to track "hot" item so we know which item to remove if user decides to do so
		private ButtonItem m_HotItem=null;
		private System.Windows.Forms.CheckBox checkBox1;
		private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
		private DevComponents.DotNetBar.ButtonItem bContextMenu;
		private DevComponents.DotNetBar.ButtonItem bLargeIcons;
		private DevComponents.DotNetBar.ButtonItem bSmallIcons;
		private DevComponents.DotNetBar.ButtonItem bRemoveItem;
		private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;

		// Tracks the drag&drop when started internally...
		private bool m_InternalDragDrop=false;

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
			this.sideBar1 = new DevComponents.DotNetBar.SideBar();
			this.sideBarPanelItem1 = new DevComponents.DotNetBar.SideBarPanelItem();
			this.bInbox = new DevComponents.DotNetBar.ButtonItem();
			this.bCalendar = new DevComponents.DotNetBar.ButtonItem();
			this.bContacts = new DevComponents.DotNetBar.ButtonItem();
			this.bTasks = new DevComponents.DotNetBar.ButtonItem();
			this.bNotes = new DevComponents.DotNetBar.ButtonItem();
			this.bDeletedItems = new DevComponents.DotNetBar.ButtonItem();
			this.imagesSmall = new System.Windows.Forms.ImageList(this.components);
			this.imagesMedium = new System.Windows.Forms.ImageList(this.components);
			this.sideBarPanelItem2 = new DevComponents.DotNetBar.SideBarPanelItem();
			this.bDrafts = new DevComponents.DotNetBar.ButtonItem();
			this.bOutbox = new DevComponents.DotNetBar.ButtonItem();
			this.bSentItems = new DevComponents.DotNetBar.ButtonItem();
			this.bJournal = new DevComponents.DotNetBar.ButtonItem();
			this.bUpdate = new DevComponents.DotNetBar.ButtonItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.textBox1 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
			this.bContextMenu = new DevComponents.DotNetBar.ButtonItem();
			this.bLargeIcons = new DevComponents.DotNetBar.ButtonItem();
			this.bSmallIcons = new DevComponents.DotNetBar.ButtonItem();
			this.bRemoveItem = new DevComponents.DotNetBar.ButtonItem();
			this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// sideBar1
			// 
			this.sideBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.sideBar1.AllowDrop = true;
			this.sideBar1.AllowExternalDrop = true;
			this.sideBar1.BorderStyle = DevComponents.DotNetBar.eBorderType.None;
			this.contextMenuBar1.SetContextMenuEx(this.sideBar1, this.bContextMenu);
			this.sideBar1.Dock = System.Windows.Forms.DockStyle.Left;
			this.sideBar1.ExpandedPanel = this.sideBarPanelItem1;
			this.sideBar1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.sideBar1.Images = this.imagesSmall;
			this.sideBar1.ImagesMedium = this.imagesMedium;
			this.sideBar1.Name = "sideBar1";
			this.sideBar1.Panels.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																					 this.sideBarPanelItem1,
																					 this.sideBarPanelItem2});
			this.sideBar1.Size = new System.Drawing.Size(112, 254);
			this.sideBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.sideBar1.TabIndex = 0;
			this.sideBar1.TabStop = false;
			this.sideBar1.UseNativeDragDrop = true;
			this.sideBar1.ItemClick += new System.EventHandler(this.sideBar1_ItemClick);
			this.sideBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sideBar1_MouseDown);
			// 
			// sideBarPanelItem1
			// 
			this.sideBarPanelItem1.FontBold = true;
			this.sideBarPanelItem1.ItemImageSize = DevComponents.DotNetBar.eBarImageSize.Medium;
			this.sideBarPanelItem1.Name = "sideBarPanelItem1";
			this.sideBarPanelItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																								this.bInbox,
																								this.bCalendar,
																								this.bContacts,
																								this.bTasks,
																								this.bNotes,
																								this.bDeletedItems});
			this.sideBarPanelItem1.Text = "SideBar Panel";
			// 
			// bInbox
			// 
			this.bInbox.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bInbox.ImageIndex = 0;
			this.bInbox.ImagePaddingHorizontal = 8;
			this.bInbox.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.bInbox.Name = "bInbox";
			this.bInbox.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.bInbox.Text = "Inbox";
			this.bInbox.Tooltip = "Opens your Inbox";
			// 
			// bCalendar
			// 
			this.bCalendar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bCalendar.ImageIndex = 1;
			this.bCalendar.ImagePaddingHorizontal = 8;
			this.bCalendar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.bCalendar.Name = "bCalendar";
			this.bCalendar.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.bCalendar.Text = "Calendar";
			this.bCalendar.Tooltip = "Shows your Calendar";
			// 
			// bContacts
			// 
			this.bContacts.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bContacts.ImageIndex = 2;
			this.bContacts.ImagePaddingHorizontal = 8;
			this.bContacts.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.bContacts.Name = "bContacts";
			this.bContacts.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.bContacts.Text = "Contacts";
			this.bContacts.Tooltip = "Opens your Contacts";
			// 
			// bTasks
			// 
			this.bTasks.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bTasks.ImageIndex = 3;
			this.bTasks.ImagePaddingHorizontal = 8;
			this.bTasks.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.bTasks.Name = "bTasks";
			this.bTasks.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.bTasks.Text = "Tasks";
			this.bTasks.Tooltip = "Shows your Tasks";
			// 
			// bNotes
			// 
			this.bNotes.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bNotes.ImageIndex = 4;
			this.bNotes.ImagePaddingHorizontal = 8;
			this.bNotes.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.bNotes.Name = "bNotes";
			this.bNotes.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.bNotes.Text = "Notes";
			this.bNotes.Tooltip = "Shows your Notes";
			// 
			// bDeletedItems
			// 
			this.bDeletedItems.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bDeletedItems.ImageIndex = 5;
			this.bDeletedItems.ImagePaddingHorizontal = 8;
			this.bDeletedItems.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.bDeletedItems.Name = "bDeletedItems";
			this.bDeletedItems.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.bDeletedItems.Text = "Deleted Items";
			this.bDeletedItems.Tooltip = "Shows Deleted Items";
			// 
			// imagesSmall
			// 
			this.imagesSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imagesSmall.ImageSize = new System.Drawing.Size(16, 16);
			this.imagesSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesSmall.ImageStream")));
			this.imagesSmall.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imagesMedium
			// 
			this.imagesMedium.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imagesMedium.ImageSize = new System.Drawing.Size(32, 32);
			this.imagesMedium.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesMedium.ImageStream")));
			this.imagesMedium.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// sideBarPanelItem2
			// 
			this.sideBarPanelItem2.FontBold = true;
			this.sideBarPanelItem2.Name = "sideBarPanelItem2";
			this.sideBarPanelItem2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																								this.bDrafts,
																								this.bOutbox,
																								this.bSentItems,
																								this.bJournal,
																								this.bUpdate});
			this.sideBarPanelItem2.Text = "My Shortcuts";
			// 
			// bDrafts
			// 
			this.bDrafts.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bDrafts.ImageIndex = 6;
			this.bDrafts.ImagePaddingHorizontal = 8;
			this.bDrafts.Name = "bDrafts";
			this.bDrafts.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.bDrafts.Text = "Drafts";
			this.bDrafts.Tooltip = "Shows Document Drafts ";
			// 
			// bOutbox
			// 
			this.bOutbox.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bOutbox.ImageIndex = 7;
			this.bOutbox.ImagePaddingHorizontal = 8;
			this.bOutbox.Name = "bOutbox";
			this.bOutbox.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.bOutbox.Text = "Outbox";
			this.bOutbox.Tooltip = "Open Outbox Folder";
			// 
			// bSentItems
			// 
			this.bSentItems.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bSentItems.ImageIndex = 8;
			this.bSentItems.ImagePaddingHorizontal = 8;
			this.bSentItems.Name = "bSentItems";
			this.bSentItems.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.bSentItems.Text = "Sent Items";
			this.bSentItems.Tooltip = "Open Sent Items Folder";
			// 
			// bJournal
			// 
			this.bJournal.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bJournal.ImageIndex = 9;
			this.bJournal.ImagePaddingHorizontal = 8;
			this.bJournal.Name = "bJournal";
			this.bJournal.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.bJournal.Text = "Journal";
			this.bJournal.Tooltip = "Open the Journal";
			// 
			// bUpdate
			// 
			this.bUpdate.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bUpdate.ImageIndex = 10;
			this.bUpdate.ImagePaddingHorizontal = 8;
			this.bUpdate.Name = "bUpdate";
			this.bUpdate.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.bUpdate.Text = "Update";
			this.bUpdate.Tooltip = "Download software update...";
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label2,
																				 this.listView1,
																				 this.textBox1,
																				 this.label1,
																				 this.checkBox1,
																				 this.contextMenuBar1});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(112, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(265, 254);
			this.panel1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(72, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(176, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "You can drag && drop items from and to the ListView";
			// 
			// listView1
			// 
			this.listView1.AllowDrop = true;
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView1.HideSelection = false;
			this.listView1.LabelEdit = true;
			this.listView1.LargeImageList = this.imagesMedium;
			this.listView1.Location = new System.Drawing.Point(72, 96);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(176, 112);
			this.listView1.SmallImageList = this.imagesSmall;
			this.listView1.TabIndex = 3;
			this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
			this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
			this.listView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseMove);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.textBox1.AutoSize = false;
			// 
			// textBox1.Border
			// 
			this.textBox1.Border.Class = "TextBoxBorder";
			this.textBox1.Location = new System.Drawing.Point(12, 30);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(235, 20);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "Item Clicked:";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(8, 224);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(128, 24);
			this.checkBox1.TabIndex = 8;
			this.checkBox1.Text = "Multi-Column Layout";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// contextMenuBar1
			// 
			this.contextMenuBar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
			this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																						   this.bContextMenu});
			this.contextMenuBar1.Location = new System.Drawing.Point(136, 224);
			this.contextMenuBar1.Name = "contextMenuBar1";
			this.contextMenuBar1.Size = new System.Drawing.Size(96, 25);
			this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.contextMenuBar1.TabIndex = 12;
			this.contextMenuBar1.TabStop = false;
			this.contextMenuBar1.PopupOpen += new DevComponents.DotNetBar.DotNetBarManager.PopupOpenEventHandler(this.contextMenuBar1_PopupOpen);
			// 
			// bContextMenu
			// 
			this.bContextMenu.AutoExpandOnClick = true;
			this.bContextMenu.GlobalName = "bContextMenu";
			this.bContextMenu.ImagePaddingHorizontal = 8;
			this.bContextMenu.Name = "bContextMenu";
			this.bContextMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																						   this.bLargeIcons,
																						   this.bSmallIcons,
																						   this.bRemoveItem});
			this.bContextMenu.Text = "bContextMenu";
			// 
			// bLargeIcons
			// 
			this.bLargeIcons.GlobalName = "bLargeIcons";
			this.bLargeIcons.Image = ((System.Drawing.Bitmap)(resources.GetObject("bLargeIcons.Image")));
			this.bLargeIcons.ImagePaddingHorizontal = 8;
			this.bLargeIcons.Name = "bLargeIcons";
			this.bLargeIcons.Text = "Large Icons";
			this.bLargeIcons.Click += new System.EventHandler(this.bLargeIcons_Click);
			// 
			// bSmallIcons
			// 
			this.bSmallIcons.GlobalName = "bSmallIcons";
			this.bSmallIcons.Image = ((System.Drawing.Bitmap)(resources.GetObject("bSmallIcons.Image")));
			this.bSmallIcons.ImagePaddingHorizontal = 8;
			this.bSmallIcons.Name = "bSmallIcons";
			this.bSmallIcons.Text = "Small Icons";
			this.bSmallIcons.Click += new System.EventHandler(this.bSmallIcons_Click);
			// 
			// bRemoveItem
			// 
			this.bRemoveItem.GlobalName = "bRemoveItem";
			this.bRemoveItem.ImagePaddingHorizontal = 8;
			this.bRemoveItem.Name = "bRemoveItem";
			this.bRemoveItem.Text = "Remove Item";
			this.bRemoveItem.Click += new System.EventHandler(this.bRemoveItem_Click);
			// 
			// expandableSplitter1
			// 
			this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(101)), ((System.Byte)(147)), ((System.Byte)(207)));
			this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.expandableSplitter1.ExpandableControl = this.sideBar1;
			this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((System.Byte)(101)), ((System.Byte)(147)), ((System.Byte)(207)));
			this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
			this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((System.Byte)(252)), ((System.Byte)(151)), ((System.Byte)(61)));
			this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(184)), ((System.Byte)(94)));
			this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
			this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
			this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((System.Byte)(101)), ((System.Byte)(147)), ((System.Byte)(207)));
			this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((System.Byte)(101)), ((System.Byte)(147)), ((System.Byte)(207)));
			this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
			this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.expandableSplitter1.Location = new System.Drawing.Point(112, 0);
			this.expandableSplitter1.Name = "expandableSplitter1";
			this.expandableSplitter1.Size = new System.Drawing.Size(8, 254);
			this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
			this.expandableSplitter1.TabIndex = 14;
			this.expandableSplitter1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(194)), ((System.Byte)(217)), ((System.Byte)(247)));
			this.ClientSize = new System.Drawing.Size(377, 254);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.expandableSplitter1,
																		  this.panel1,
																		  this.sideBar1});
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
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

		private void sideBar1_ItemClick(object sender, System.EventArgs e)
		{
			BaseItem item=sender as BaseItem;
			if(item==null)
				return;

			textBox1.Text=item.Text+" ("+item.Name+")";
		}

		private void sideBar1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button==MouseButtons.Right && sender is ButtonItem)
				m_HotItem=sender as ButtonItem;
			else
				m_HotItem=null;
		}

		private void listView1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if(m_InternalDragDrop)
				return;
			if(e.Data.GetData(typeof(ButtonItem))==null)
				e.Effect=DragDropEffects.None;
			else
				e.Effect=DragDropEffects.Move;
		}

		private void listView1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if(m_InternalDragDrop)
				return;
			ButtonItem item=e.Data.GetData(typeof(ButtonItem)) as ButtonItem;
			if(item==null)
				return;
			listView1.Items.Add(item.Text,item.ImageIndex);
			item.Parent.SubItems.Remove(item);
		}

		private void listView1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button==MouseButtons.Left && (Math.Abs(e.X)>=4 || Math.Abs(e.Y)>=4))
			{
				if(listView1.SelectedItems.Count==1)
				{
					ButtonItem item=new ButtonItem("dragitem",listView1.SelectedItems[0].Text);
					item.ImageIndex=listView1.SelectedItems[0].ImageIndex;
					item.ButtonStyle=eButtonStyle.ImageAndText;
					item.ImagePosition=eImagePosition.Top;
					m_InternalDragDrop=true;
					if(listView1.DoDragDrop(item,DragDropEffects.All)==DragDropEffects.Move)
					{
						listView1.Items.Remove(listView1.SelectedItems[0]);
					}
					m_InternalDragDrop=false;
				}
			}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			foreach(SideBarPanelItem panel in sideBar1.Panels)
				panel.LayoutType=(checkBox1.Checked?eSideBarLayoutType.MultiColumn:eSideBarLayoutType.Default);
			sideBar1.RecalcLayout();
		}

		private void bLargeIcons_Click(object sender, System.EventArgs e)
		{
			if(sideBar1.ExpandedPanel!=null)
				sideBar1.ExpandedPanel.ItemImageSize=eBarImageSize.Medium;
		}

		private void bSmallIcons_Click(object sender, System.EventArgs e)
		{
			if(sideBar1.ExpandedPanel!=null)
				sideBar1.ExpandedPanel.ItemImageSize=eBarImageSize.Default;
		}

		private void bRemoveItem_Click(object sender, System.EventArgs e)
		{
			if(m_HotItem!=null)
			{
				if(MessageBox.Show("Are you sure you want to remove '" + m_HotItem.Text + "'?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					m_HotItem.Parent.SubItems.Remove(m_HotItem);
				}
			}
		}

		private void contextMenuBar1_PopupOpen(object sender, DevComponents.DotNetBar.PopupOpenEventArgs e)
		{
			if(sideBar1.ExpandedPanel!=null)
			{
				if(sideBar1.ExpandedPanel.ItemImageSize==eBarImageSize.Default)
				{
					bSmallIcons.Checked=true;
					bLargeIcons.Checked=false;
				}
				else
				{
					bSmallIcons.Checked=false;
					bLargeIcons.Checked=true;
				}
			}
			if(m_HotItem==null)
				bRemoveItem.Enabled=false;
			else
				bRemoveItem.Enabled=true;
		}
	}
}
