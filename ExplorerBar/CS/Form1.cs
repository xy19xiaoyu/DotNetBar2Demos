using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ExplorerBar
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevComponents.DotNetBar.ExplorerBar explorerBar1;
		private DevComponents.DotNetBar.ExplorerBarGroupItem explorerBarGroupItem1;
		private DevComponents.DotNetBar.ButtonItem bToday;
		private DevComponents.DotNetBar.ButtonItem bInbox;
		private DevComponents.DotNetBar.ButtonItem bCalendar;
		private System.Windows.Forms.ImageList imagesGroup;
		private System.Windows.Forms.ImageList imagesItems;
		private DevComponents.DotNetBar.ButtonItem bContacts;
		private DevComponents.DotNetBar.ButtonItem bTasks;
		private DevComponents.DotNetBar.ExplorerBarGroupItem explorerBarGroupItem2;
		private System.Windows.Forms.Splitter splitter1;
		private DevComponents.DotNetBar.ButtonItem bNewMessage;
		private DevComponents.DotNetBar.ButtonItem bNewAppointment;
		private DevComponents.DotNetBar.ButtonItem bNewMeeting;
		private DevComponents.DotNetBar.ButtonItem bNewNote;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
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
			this.explorerBar1 = new DevComponents.DotNetBar.ExplorerBar();
			this.imagesGroup = new System.Windows.Forms.ImageList(this.components);
			this.explorerBarGroupItem1 = new DevComponents.DotNetBar.ExplorerBarGroupItem();
			this.bToday = new DevComponents.DotNetBar.ButtonItem();
			this.bInbox = new DevComponents.DotNetBar.ButtonItem();
			this.bCalendar = new DevComponents.DotNetBar.ButtonItem();
			this.bContacts = new DevComponents.DotNetBar.ButtonItem();
			this.bTasks = new DevComponents.DotNetBar.ButtonItem();
			this.explorerBarGroupItem2 = new DevComponents.DotNetBar.ExplorerBarGroupItem();
			this.bNewMessage = new DevComponents.DotNetBar.ButtonItem();
			this.bNewAppointment = new DevComponents.DotNetBar.ButtonItem();
			this.bNewMeeting = new DevComponents.DotNetBar.ButtonItem();
			this.bNewNote = new DevComponents.DotNetBar.ButtonItem();
			this.imagesItems = new System.Windows.Forms.ImageList(this.components);
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.explorerBar1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// explorerBar1
			// 
			this.explorerBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.explorerBar1.BackColor = System.Drawing.SystemColors.Control;
			// 
			// explorerBar1.BackStyle
			// 
			this.explorerBar1.BackStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground2;
			this.explorerBar1.BackStyle.BackColorGradientAngle = 90;
			this.explorerBar1.BackStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground;
			this.explorerBar1.Dock = System.Windows.Forms.DockStyle.Left;
			this.explorerBar1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.explorerBar1.GroupImages = this.imagesGroup;
			this.explorerBar1.Groups.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																						 this.explorerBarGroupItem1,
																						 this.explorerBarGroupItem2});
			this.explorerBar1.Images = this.imagesItems;
			this.explorerBar1.Name = "explorerBar1";
			this.explorerBar1.Size = new System.Drawing.Size(168, 320);
			this.explorerBar1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors;
			this.explorerBar1.TabIndex = 0;
			this.explorerBar1.TabStop = false;
			this.explorerBar1.Text = "explorerBar1";
			this.explorerBar1.ThemeAware = true;
			this.explorerBar1.ItemClick += new System.EventHandler(this.explorerBar1_ItemClick);
			// 
			// imagesGroup
			// 
			this.imagesGroup.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imagesGroup.ImageSize = new System.Drawing.Size(24, 24);
			this.imagesGroup.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesGroup.ImageStream")));
			this.imagesGroup.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// explorerBarGroupItem1
			// 
			// 
			// explorerBarGroupItem1.BackStyle
			// 
			this.explorerBarGroupItem1.BackStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(243)), ((System.Byte)(255)));
			this.explorerBarGroupItem1.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.explorerBarGroupItem1.BackStyle.BorderBottomWidth = 1;
			this.explorerBarGroupItem1.BackStyle.BorderColor = System.Drawing.Color.White;
			this.explorerBarGroupItem1.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.explorerBarGroupItem1.BackStyle.BorderLeftWidth = 1;
			this.explorerBarGroupItem1.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.explorerBarGroupItem1.BackStyle.BorderRightWidth = 1;
			this.explorerBarGroupItem1.Cursor = System.Windows.Forms.Cursors.Default;
			this.explorerBarGroupItem1.Expanded = true;
			this.explorerBarGroupItem1.Image = ((System.Drawing.Bitmap)(resources.GetObject("explorerBarGroupItem1.Image")));
			this.explorerBarGroupItem1.Name = "explorerBarGroupItem1";
			this.explorerBarGroupItem1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors;
			this.explorerBarGroupItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																									this.bToday,
																									this.bInbox,
																									this.bCalendar,
																									this.bContacts,
																									this.bTasks});
			this.explorerBarGroupItem1.Text = "Shortcuts";
			// 
			// explorerBarGroupItem1.TitleHotStyle
			// 
			this.explorerBarGroupItem1.TitleHotStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(73)), ((System.Byte)(181)));
			this.explorerBarGroupItem1.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(41)), ((System.Byte)(93)), ((System.Byte)(206)));
			this.explorerBarGroupItem1.TitleHotStyle.CornerDiameter = 3;
			this.explorerBarGroupItem1.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
			this.explorerBarGroupItem1.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
			this.explorerBarGroupItem1.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(((System.Byte)(66)), ((System.Byte)(142)), ((System.Byte)(255)));
			// 
			// explorerBarGroupItem1.TitleStyle
			// 
			this.explorerBarGroupItem1.TitleStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(73)), ((System.Byte)(181)));
			this.explorerBarGroupItem1.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(41)), ((System.Byte)(93)), ((System.Byte)(206)));
			this.explorerBarGroupItem1.TitleStyle.CornerDiameter = 3;
			this.explorerBarGroupItem1.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
			this.explorerBarGroupItem1.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
			this.explorerBarGroupItem1.TitleStyle.TextColor = System.Drawing.Color.White;
			this.explorerBarGroupItem1.XPSpecialGroup = true;
			// 
			// bToday
			// 
			this.bToday.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bToday.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bToday.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(33)), ((System.Byte)(93)), ((System.Byte)(198)));
			this.bToday.HotFontUnderline = true;
			this.bToday.HotForeColor = System.Drawing.Color.FromArgb(((System.Byte)(66)), ((System.Byte)(142)), ((System.Byte)(255)));
			this.bToday.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
			this.bToday.ImageIndex = 0;
			this.bToday.Name = "bToday";
			this.bToday.Text = "Today";
			// 
			// bInbox
			// 
			this.bInbox.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bInbox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bInbox.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(33)), ((System.Byte)(93)), ((System.Byte)(198)));
			this.bInbox.HotFontUnderline = true;
			this.bInbox.HotForeColor = System.Drawing.Color.FromArgb(((System.Byte)(66)), ((System.Byte)(142)), ((System.Byte)(255)));
			this.bInbox.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
			this.bInbox.ImageIndex = 1;
			this.bInbox.Name = "bInbox";
			this.bInbox.Text = "Inbox";
			// 
			// bCalendar
			// 
			this.bCalendar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bCalendar.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(33)), ((System.Byte)(93)), ((System.Byte)(198)));
			this.bCalendar.HotFontUnderline = true;
			this.bCalendar.HotForeColor = System.Drawing.Color.FromArgb(((System.Byte)(66)), ((System.Byte)(142)), ((System.Byte)(255)));
			this.bCalendar.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
			this.bCalendar.ImageIndex = 2;
			this.bCalendar.Name = "bCalendar";
			this.bCalendar.Text = "Calendar";
			// 
			// bContacts
			// 
			this.bContacts.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bContacts.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bContacts.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(33)), ((System.Byte)(93)), ((System.Byte)(198)));
			this.bContacts.HotFontUnderline = true;
			this.bContacts.HotForeColor = System.Drawing.Color.FromArgb(((System.Byte)(66)), ((System.Byte)(142)), ((System.Byte)(255)));
			this.bContacts.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
			this.bContacts.ImageIndex = 3;
			this.bContacts.Name = "bContacts";
			this.bContacts.Text = "Contacts";
			// 
			// bTasks
			// 
			this.bTasks.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bTasks.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bTasks.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(33)), ((System.Byte)(93)), ((System.Byte)(198)));
			this.bTasks.HotFontUnderline = true;
			this.bTasks.HotForeColor = System.Drawing.Color.FromArgb(((System.Byte)(66)), ((System.Byte)(142)), ((System.Byte)(255)));
			this.bTasks.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
			this.bTasks.ImageIndex = 4;
			this.bTasks.Name = "bTasks";
			this.bTasks.Text = "Tasks";
			// 
			// explorerBarGroupItem2
			// 
			// 
			// explorerBarGroupItem2.BackStyle
			// 
			this.explorerBarGroupItem2.BackStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(214)), ((System.Byte)(223)), ((System.Byte)(247)));
			this.explorerBarGroupItem2.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.explorerBarGroupItem2.BackStyle.BorderBottomWidth = 1;
			this.explorerBarGroupItem2.BackStyle.BorderColor = System.Drawing.Color.White;
			this.explorerBarGroupItem2.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.explorerBarGroupItem2.BackStyle.BorderLeftWidth = 1;
			this.explorerBarGroupItem2.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.explorerBarGroupItem2.BackStyle.BorderRightWidth = 1;
			this.explorerBarGroupItem2.Cursor = System.Windows.Forms.Cursors.Default;
			this.explorerBarGroupItem2.Expanded = true;
			this.explorerBarGroupItem2.Name = "explorerBarGroupItem2";
			this.explorerBarGroupItem2.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors;
			this.explorerBarGroupItem2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																									this.bNewMessage,
																									this.bNewAppointment,
																									this.bNewMeeting,
																									this.bNewNote});
			this.explorerBarGroupItem2.Text = "Tasks";
			// 
			// explorerBarGroupItem2.TitleHotStyle
			// 
			this.explorerBarGroupItem2.TitleHotStyle.BackColor = System.Drawing.Color.White;
			this.explorerBarGroupItem2.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(199)), ((System.Byte)(211)), ((System.Byte)(247)));
			this.explorerBarGroupItem2.TitleHotStyle.CornerDiameter = 3;
			this.explorerBarGroupItem2.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
			this.explorerBarGroupItem2.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
			this.explorerBarGroupItem2.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(((System.Byte)(66)), ((System.Byte)(142)), ((System.Byte)(255)));
			// 
			// explorerBarGroupItem2.TitleStyle
			// 
			this.explorerBarGroupItem2.TitleStyle.BackColor = System.Drawing.Color.White;
			this.explorerBarGroupItem2.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(199)), ((System.Byte)(211)), ((System.Byte)(247)));
			this.explorerBarGroupItem2.TitleStyle.CornerDiameter = 3;
			this.explorerBarGroupItem2.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
			this.explorerBarGroupItem2.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
			this.explorerBarGroupItem2.TitleStyle.TextColor = System.Drawing.Color.FromArgb(((System.Byte)(33)), ((System.Byte)(93)), ((System.Byte)(198)));
			// 
			// bNewMessage
			// 
			this.bNewMessage.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bNewMessage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bNewMessage.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(33)), ((System.Byte)(93)), ((System.Byte)(198)));
			this.bNewMessage.HotFontUnderline = true;
			this.bNewMessage.HotForeColor = System.Drawing.Color.FromArgb(((System.Byte)(66)), ((System.Byte)(142)), ((System.Byte)(255)));
			this.bNewMessage.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
			this.bNewMessage.ImageIndex = 6;
			this.bNewMessage.Name = "bNewMessage";
			this.bNewMessage.Text = "New Mail Message";
			// 
			// bNewAppointment
			// 
			this.bNewAppointment.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bNewAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bNewAppointment.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(33)), ((System.Byte)(93)), ((System.Byte)(198)));
			this.bNewAppointment.HotFontUnderline = true;
			this.bNewAppointment.HotForeColor = System.Drawing.Color.FromArgb(((System.Byte)(66)), ((System.Byte)(142)), ((System.Byte)(255)));
			this.bNewAppointment.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
			this.bNewAppointment.ImageIndex = 5;
			this.bNewAppointment.Name = "bNewAppointment";
			this.bNewAppointment.Text = "New Appointment";
			// 
			// bNewMeeting
			// 
			this.bNewMeeting.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bNewMeeting.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bNewMeeting.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(33)), ((System.Byte)(93)), ((System.Byte)(198)));
			this.bNewMeeting.HotFontUnderline = true;
			this.bNewMeeting.HotForeColor = System.Drawing.Color.FromArgb(((System.Byte)(66)), ((System.Byte)(142)), ((System.Byte)(255)));
			this.bNewMeeting.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
			this.bNewMeeting.ImageIndex = 7;
			this.bNewMeeting.Name = "bNewMeeting";
			this.bNewMeeting.Text = "New Meeting Request";
			// 
			// bNewNote
			// 
			this.bNewNote.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.bNewNote.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bNewNote.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(33)), ((System.Byte)(93)), ((System.Byte)(198)));
			this.bNewNote.HotFontUnderline = true;
			this.bNewNote.HotForeColor = System.Drawing.Color.FromArgb(((System.Byte)(66)), ((System.Byte)(142)), ((System.Byte)(255)));
			this.bNewNote.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
			this.bNewNote.ImageIndex = 8;
			this.bNewNote.Name = "bNewNote";
			this.bNewNote.Text = "New Note";
			// 
			// imagesItems
			// 
			this.imagesItems.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imagesItems.ImageSize = new System.Drawing.Size(16, 16);
			this.imagesItems.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesItems.ImageStream")));
			this.imagesItems.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// splitter1
			// 
			this.splitter1.BackColor = System.Drawing.Color.RoyalBlue;
			this.splitter1.Location = new System.Drawing.Point(168, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 320);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			this.splitter1.MouseEnter += new System.EventHandler(this.splitter1_MouseEnter);
			this.splitter1.MouseLeave += new System.EventHandler(this.splitter1_MouseLeave);
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Location = new System.Drawing.Point(0, 32);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(303, 288);
			this.propertyGrid1.TabIndex = 2;
			this.propertyGrid1.Text = "propertyGrid1";
			this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.propertyGrid1,
																				 this.label1});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(171, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(303, 320);
			this.panel1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(303, 32);
			this.label1.TabIndex = 3;
			this.label1.Text = "Click on Explorer Bar item to view its properties";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(474, 320);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.splitter1,
																		  this.explorerBar1});
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.explorerBar1)).EndInit();
			this.panel1.ResumeLayout(false);
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

		private void splitter1_MouseEnter(object sender, System.EventArgs e)
		{
			splitter1.BackColor=Color.MidnightBlue;
		}

		private void splitter1_MouseLeave(object sender, System.EventArgs e)
		{
            splitter1.BackColor=Color.RoyalBlue;		
		}

		private void explorerBar1_ItemClick(object sender, System.EventArgs e)
		{
			if(sender is DevComponents.DotNetBar.BaseItem)
				propertyGrid1.SelectedObject=sender;
			else
                propertyGrid1.SelectedObject=null;				
		}

		private void propertyGrid1_PropertyValueChanged(object s, System.Windows.Forms.PropertyValueChangedEventArgs e)
		{
			explorerBar1.RecalcLayout();
		}
	}
}
