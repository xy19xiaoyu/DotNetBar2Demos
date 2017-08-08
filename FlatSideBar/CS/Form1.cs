using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FlatSideBar
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevComponents.DotNetBar.SideBar sideBar1;
		private DevComponents.DotNetBar.SideBarPanelItem sideBarPanelItem1;
		private DevComponents.DotNetBar.SideBarPanelItem sideBarPanelItem2;
		private DevComponents.DotNetBar.ButtonItem buttonItem1;
		private DevComponents.DotNetBar.ButtonItem buttonItem2;
		private DevComponents.DotNetBar.ButtonItem buttonItem3;
		private DevComponents.DotNetBar.ButtonItem buttonItem4;
		private DevComponents.DotNetBar.ButtonItem buttonItem5;
		private DevComponents.DotNetBar.ButtonItem buttonItem6;
		private DevComponents.DotNetBar.ButtonItem buttonItem7;
		private DevComponents.DotNetBar.ButtonItem buttonItem8;
		private DevComponents.DotNetBar.ButtonItem buttonItem9;
		private DevComponents.DotNetBar.ButtonItem buttonItem10;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label2;
		private DevComponents.DotNetBar.ButtonItem buttonItem11;
		private DevComponents.DotNetBar.ButtonItem buttonItem12;
		private DevComponents.DotNetBar.ButtonItem buttonItem13;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.sideBar1 = new DevComponents.DotNetBar.SideBar();
			this.sideBarPanelItem1 = new DevComponents.DotNetBar.SideBarPanelItem();
			this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem10 = new DevComponents.DotNetBar.ButtonItem();
			this.sideBarPanelItem2 = new DevComponents.DotNetBar.SideBarPanelItem();
			this.buttonItem11 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem12 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem13 = new DevComponents.DotNetBar.ButtonItem();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// sideBar1
			// 
			this.sideBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.sideBar1.Appearance = DevComponents.DotNetBar.eSideBarAppearance.Flat;
			this.sideBar1.BorderStyle = DevComponents.DotNetBar.eBorderType.None;
			this.sideBar1.ColorScheme.DockSiteBackColorGradientAngle = 0;
			this.sideBar1.ColorScheme.ItemCheckedBackground = System.Drawing.Color.Empty;
			this.sideBar1.ColorScheme.ItemCheckedBorder = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			this.sideBar1.ColorScheme.ItemCheckedText = System.Drawing.Color.Black;
			this.sideBar1.ColorScheme.ItemExpandedBackground = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(142)), ((System.Byte)(75)));
			this.sideBar1.ColorScheme.ItemExpandedBackground2 = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(207)), ((System.Byte)(139)));
			this.sideBar1.ColorScheme.ItemExpandedShadow = System.Drawing.Color.Empty;
			this.sideBar1.ColorScheme.ItemExpandedText = System.Drawing.Color.Black;
			this.sideBar1.ColorScheme.ItemHotBackground = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(244)), ((System.Byte)(204)));
			this.sideBar1.ColorScheme.ItemHotBackground2 = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(209)), ((System.Byte)(147)));
			this.sideBar1.ColorScheme.ItemHotBorder = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			this.sideBar1.ColorScheme.ItemHotText = System.Drawing.Color.Black;
			this.sideBar1.ColorScheme.ItemPressedBackground = System.Drawing.Color.FromArgb(((System.Byte)(254)), ((System.Byte)(142)), ((System.Byte)(75)));
			this.sideBar1.ColorScheme.ItemPressedBackground2 = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(207)), ((System.Byte)(139)));
			this.sideBar1.ColorScheme.ItemPressedBorder = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			this.sideBar1.ColorScheme.ItemPressedText = System.Drawing.Color.Black;
			this.sideBar1.ColorScheme.ItemText = System.Drawing.Color.Black;
			this.sideBar1.ColorScheme.MenuBackground = System.Drawing.Color.FromArgb(((System.Byte)(232)), ((System.Byte)(232)), ((System.Byte)(232)));
			this.sideBar1.ColorScheme.MenuBackground2 = System.Drawing.Color.White;
			this.sideBar1.ColorScheme.MenuBorder = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			this.sideBar1.ColorScheme.MenuSide = System.Drawing.Color.FromArgb(((System.Byte)(94)), ((System.Byte)(137)), ((System.Byte)(207)));
			this.sideBar1.ExpandedPanel = this.sideBarPanelItem1;
			this.sideBar1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.sideBar1.Location = new System.Drawing.Point(8, 48);
			this.sideBar1.Name = "sideBar1";
			this.sideBar1.Panels.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																					 this.sideBarPanelItem1,
																					 this.sideBarPanelItem2});
			this.sideBar1.Size = new System.Drawing.Size(176, 216);
			this.sideBar1.TabIndex = 0;
			this.sideBar1.TabStop = false;
			this.sideBar1.ItemClick += new System.EventHandler(this.sideBar1_ItemClick);
			// 
			// sideBarPanelItem1
			// 
			this.sideBarPanelItem1.BackgroundStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(232)), ((System.Byte)(232)), ((System.Byte)(232)));
			this.sideBarPanelItem1.BackgroundStyle.BackColor2.Color = System.Drawing.Color.White;
			this.sideBarPanelItem1.BackgroundStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.sideBarPanelItem1.BackgroundStyle.BorderColor.Color = System.Drawing.Color.FromArgb(((System.Byte)(59)), ((System.Byte)(97)), ((System.Byte)(156)));
			this.sideBarPanelItem1.HeaderHotStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(133)), ((System.Byte)(171)), ((System.Byte)(228)));
			this.sideBarPanelItem1.HeaderHotStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((System.Byte)(221)), ((System.Byte)(236)), ((System.Byte)(254)));
			this.sideBarPanelItem1.HeaderHotStyle.GradientAngle = 90;
			this.sideBarPanelItem1.HeaderSideHotStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(133)), ((System.Byte)(171)), ((System.Byte)(228)));
			this.sideBarPanelItem1.HeaderSideHotStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((System.Byte)(221)), ((System.Byte)(236)), ((System.Byte)(254)));
			this.sideBarPanelItem1.HeaderSideHotStyle.GradientAngle = 90;
			this.sideBarPanelItem1.HeaderSideStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(200)), ((System.Byte)(220)), ((System.Byte)(248)));
			this.sideBarPanelItem1.HeaderSideStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((System.Byte)(94)), ((System.Byte)(137)), ((System.Byte)(207)));
			this.sideBarPanelItem1.HeaderSideStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.sideBarPanelItem1.HeaderSideStyle.BorderColor.Color = System.Drawing.Color.FromArgb(((System.Byte)(59)), ((System.Byte)(97)), ((System.Byte)(156)));
			this.sideBarPanelItem1.HeaderSideStyle.BorderSide = ((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Top) 
				| DevComponents.DotNetBar.eBorderSide.Bottom);
			this.sideBarPanelItem1.HeaderSideStyle.GradientAngle = 90;
			this.sideBarPanelItem1.HeaderStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(221)), ((System.Byte)(236)), ((System.Byte)(254)));
			this.sideBarPanelItem1.HeaderStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((System.Byte)(133)), ((System.Byte)(171)), ((System.Byte)(228)));
			this.sideBarPanelItem1.HeaderStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.sideBarPanelItem1.HeaderStyle.BorderColor.Color = System.Drawing.Color.FromArgb(((System.Byte)(59)), ((System.Byte)(97)), ((System.Byte)(156)));
			this.sideBarPanelItem1.HeaderStyle.BorderSide = ((DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Top) 
				| DevComponents.DotNetBar.eBorderSide.Bottom);
			this.sideBarPanelItem1.HeaderStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.sideBarPanelItem1.HeaderStyle.ForeColor.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(51)), ((System.Byte)(102)));
			this.sideBarPanelItem1.HeaderStyle.GradientAngle = 90;
			this.sideBarPanelItem1.Icon = ((System.Drawing.Icon)(resources.GetObject("sideBarPanelItem1.Icon")));
			this.sideBarPanelItem1.Name = "sideBarPanelItem1";
			this.sideBarPanelItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																								this.buttonItem1,
																								this.buttonItem2,
																								this.buttonItem3,
																								this.buttonItem4,
																								this.buttonItem5,
																								this.buttonItem6,
																								this.buttonItem7});
			this.sideBarPanelItem1.Text = "Mail (Favorite Folders)";
			// 
			// buttonItem1
			// 
			this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.buttonItem1.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem1.Icon")));
			this.buttonItem1.Name = "buttonItem1";
			this.buttonItem1.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.buttonItem1.Text = "Inbox";
			// 
			// buttonItem2
			// 
			this.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.buttonItem2.FontItalic = true;
			this.buttonItem2.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem2.Icon")));
			this.buttonItem2.Name = "buttonItem2";
			this.buttonItem2.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.buttonItem2.Text = "Unread Mail";
			// 
			// buttonItem3
			// 
			this.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.buttonItem3.FontItalic = true;
			this.buttonItem3.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem3.Icon")));
			this.buttonItem3.Name = "buttonItem3";
			this.buttonItem3.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.buttonItem3.Text = "For Follow Up";
			// 
			// buttonItem4
			// 
			this.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.buttonItem4.FontBold = true;
			this.buttonItem4.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem4.Icon")));
			this.buttonItem4.Name = "buttonItem4";
			this.buttonItem4.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.buttonItem4.Text = "Sent Items";
			// 
			// buttonItem5
			// 
			this.buttonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.buttonItem5.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem5.Icon")));
			this.buttonItem5.Name = "buttonItem5";
			this.buttonItem5.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.buttonItem5.Text = "Drafts";
			// 
			// buttonItem6
			// 
			this.buttonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.buttonItem6.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem6.Icon")));
			this.buttonItem6.Name = "buttonItem6";
			this.buttonItem6.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.buttonItem6.Text = "Home";
			// 
			// buttonItem7
			// 
			this.buttonItem7.BeginGroup = true;
			this.buttonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.buttonItem7.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem7.Icon")));
			this.buttonItem7.Name = "buttonItem7";
			this.buttonItem7.PopupSide = DevComponents.DotNetBar.ePopupSide.Right;
			this.buttonItem7.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																						  this.buttonItem8,
																						  this.buttonItem9,
																						  this.buttonItem10});
			this.buttonItem7.Text = "Actions";
			// 
			// buttonItem8
			// 
			this.buttonItem8.Name = "buttonItem8";
			this.buttonItem8.Text = "New Message";
			// 
			// buttonItem9
			// 
			this.buttonItem9.Name = "buttonItem9";
			this.buttonItem9.Text = "Junk Mail Settings";
			// 
			// buttonItem10
			// 
			this.buttonItem10.BeginGroup = true;
			this.buttonItem10.Name = "buttonItem10";
			this.buttonItem10.Text = "Mail Accounts";
			// 
			// sideBarPanelItem2
			// 
			this.sideBarPanelItem2.BackgroundStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(232)), ((System.Byte)(232)), ((System.Byte)(232)));
			this.sideBarPanelItem2.BackgroundStyle.BackColor2.Color = System.Drawing.Color.White;
			this.sideBarPanelItem2.BackgroundStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.sideBarPanelItem2.BackgroundStyle.BorderColor.Color = System.Drawing.Color.FromArgb(((System.Byte)(59)), ((System.Byte)(97)), ((System.Byte)(156)));
			this.sideBarPanelItem2.HeaderHotStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(133)), ((System.Byte)(171)), ((System.Byte)(228)));
			this.sideBarPanelItem2.HeaderHotStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((System.Byte)(221)), ((System.Byte)(236)), ((System.Byte)(254)));
			this.sideBarPanelItem2.HeaderHotStyle.GradientAngle = 90;
			this.sideBarPanelItem2.HeaderSideHotStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(133)), ((System.Byte)(171)), ((System.Byte)(228)));
			this.sideBarPanelItem2.HeaderSideHotStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((System.Byte)(221)), ((System.Byte)(236)), ((System.Byte)(254)));
			this.sideBarPanelItem2.HeaderSideHotStyle.GradientAngle = 90;
			this.sideBarPanelItem2.HeaderSideStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(200)), ((System.Byte)(220)), ((System.Byte)(248)));
			this.sideBarPanelItem2.HeaderSideStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((System.Byte)(94)), ((System.Byte)(137)), ((System.Byte)(207)));
			this.sideBarPanelItem2.HeaderSideStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.sideBarPanelItem2.HeaderSideStyle.BorderColor.Color = System.Drawing.Color.FromArgb(((System.Byte)(59)), ((System.Byte)(97)), ((System.Byte)(156)));
			this.sideBarPanelItem2.HeaderSideStyle.BorderSide = ((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Top) 
				| DevComponents.DotNetBar.eBorderSide.Bottom);
			this.sideBarPanelItem2.HeaderSideStyle.GradientAngle = 90;
			this.sideBarPanelItem2.HeaderStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(221)), ((System.Byte)(236)), ((System.Byte)(254)));
			this.sideBarPanelItem2.HeaderStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((System.Byte)(133)), ((System.Byte)(171)), ((System.Byte)(228)));
			this.sideBarPanelItem2.HeaderStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.sideBarPanelItem2.HeaderStyle.BorderColor.Color = System.Drawing.Color.FromArgb(((System.Byte)(59)), ((System.Byte)(97)), ((System.Byte)(156)));
			this.sideBarPanelItem2.HeaderStyle.BorderSide = ((DevComponents.DotNetBar.eBorderSide.Right | DevComponents.DotNetBar.eBorderSide.Top) 
				| DevComponents.DotNetBar.eBorderSide.Bottom);
			this.sideBarPanelItem2.HeaderStyle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.sideBarPanelItem2.HeaderStyle.ForeColor.Color = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(51)), ((System.Byte)(102)));
			this.sideBarPanelItem2.HeaderStyle.GradientAngle = 90;
			this.sideBarPanelItem2.Icon = ((System.Drawing.Icon)(resources.GetObject("sideBarPanelItem2.Icon")));
			this.sideBarPanelItem2.Name = "sideBarPanelItem2";
			this.sideBarPanelItem2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																								this.buttonItem11,
																								this.buttonItem12,
																								this.buttonItem13});
			this.sideBarPanelItem2.Text = "Notes";
			// 
			// buttonItem11
			// 
			this.buttonItem11.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.buttonItem11.Name = "buttonItem11";
			this.buttonItem11.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.buttonItem11.Text = "New Note";
			// 
			// buttonItem12
			// 
			this.buttonItem12.BeginGroup = true;
			this.buttonItem12.Name = "buttonItem12";
			this.buttonItem12.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.buttonItem12.Text = "Display All Notes";
			// 
			// buttonItem13
			// 
			this.buttonItem13.Name = "buttonItem13";
			this.buttonItem13.PopupSide = DevComponents.DotNetBar.ePopupSide.Left;
			this.buttonItem13.Text = "Display Most Recent";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "SideBar Color Scheme:";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(8, 24);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(176, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(192, 56);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.richTextBox1.Size = new System.Drawing.Size(248, 208);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(192, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Click Event Log:";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(448, 270);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label2,
																		  this.richTextBox1,
																		  this.comboBox1,
																		  this.label1,
																		  this.sideBar1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
			foreach(string s in Enum.GetNames(typeof(DevComponents.DotNetBar.eSideBarColorScheme)))
			{
				comboBox1.Items.Add(s);
			}
			comboBox1.SelectedIndex=0;
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			DevComponents.DotNetBar.eSideBarColorScheme scheme;
			if(comboBox1.SelectedIndex<0)
				return;
			string sSel=comboBox1.SelectedItem.ToString();
			scheme=(DevComponents.DotNetBar.eSideBarColorScheme)Enum.Parse(typeof(DevComponents.DotNetBar.eSideBarColorScheme),sSel,false);
			sideBar1.PredefinedColorScheme=scheme;
		}

		private void sideBar1_ItemClick(object sender, System.EventArgs e)
		{
			DevComponents.DotNetBar.BaseItem item=sender as DevComponents.DotNetBar.BaseItem;
			richTextBox1.Text="ItemClick: "+ item.Text+" ("+item.Name+")\n"+richTextBox1.Text;
		}
	}
}
