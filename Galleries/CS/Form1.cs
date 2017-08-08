using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;

namespace DropDownGalleries
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevComponents.DotNetBar.RibbonControl ribbonControl1;
		private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
		private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
		private DevComponents.DotNetBar.RibbonBar ribbonBar1;
		private DevComponents.DotNetBar.ButtonItem buttonItem1;
		private DevComponents.DotNetBar.LabelItem labelItem1;
		private DevComponents.DotNetBar.ItemContainer itemContainer1;
		private DevComponents.DotNetBar.ButtonItem buttonItem2;
		private DevComponents.DotNetBar.ButtonItem buttonItem3;
		private DevComponents.DotNetBar.ButtonItem buttonItem4;
		private DevComponents.DotNetBar.ButtonItem buttonItem5;
		private DevComponents.DotNetBar.LabelItem labelItem2;
		private DevComponents.DotNetBar.ItemContainer itemContainer2;
		private DevComponents.DotNetBar.ButtonItem buttonItem6;
		private DevComponents.DotNetBar.ButtonItem buttonItem7;
		private DevComponents.DotNetBar.ButtonItem buttonItem8;
		private DevComponents.DotNetBar.ButtonItem buttonItem9;
		private DevComponents.DotNetBar.LabelItem labelItem3;
		private DevComponents.DotNetBar.ItemContainer itemContainer3;
		private DevComponents.DotNetBar.ButtonItem buttonItem10;
		private DevComponents.DotNetBar.ButtonItem buttonItem11;
		private DevComponents.DotNetBar.LabelItem labelItem4;
		private DevComponents.DotNetBar.ItemContainer itemContainer4;
		private DevComponents.DotNetBar.ButtonItem buttonItem12;
		private DevComponents.DotNetBar.ButtonItem buttonItem13;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private DevComponents.DotNetBar.GalleryContainer galleryContainer1;
		private DevComponents.DotNetBar.ButtonItem buttonItem14;
		private DevComponents.DotNetBar.ButtonItem buttonItem15;
		private DevComponents.DotNetBar.ButtonItem buttonItem16;
		private DevComponents.DotNetBar.ButtonItem buttonItem17;
		private DevComponents.DotNetBar.GalleryGroup galleryGroupStock;
		private DevComponents.DotNetBar.ButtonItem buttonItem18;
		private DevComponents.DotNetBar.ButtonItem buttonItem19;
		private DevComponents.DotNetBar.ButtonItem buttonItem20;
		private DevComponents.DotNetBar.ButtonItem buttonItem21;
		private DevComponents.DotNetBar.GalleryGroup galleryGroupSurface;
		private DevComponents.DotNetBar.ButtonItem buttonItem22;
		private DevComponents.DotNetBar.ButtonItem buttonItem23;
		private DevComponents.DotNetBar.GalleryGroup galleryGroupDoughnut;
		private DevComponents.DotNetBar.ButtonItem buttonItem24;
		private DevComponents.DotNetBar.ButtonItem buttonItem25;
		private DevComponents.DotNetBar.GalleryGroup galleryGroupBubble;
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
			this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
			this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
			this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
			this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
			this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
			this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
			this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
			this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
			this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
			this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
			this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
			this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
			this.buttonItem10 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem11 = new DevComponents.DotNetBar.ButtonItem();
			this.labelItem4 = new DevComponents.DotNetBar.LabelItem();
			this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
			this.buttonItem12 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem13 = new DevComponents.DotNetBar.ButtonItem();
			this.galleryContainer1 = new DevComponents.DotNetBar.GalleryContainer();
			this.galleryGroupStock = new DevComponents.DotNetBar.GalleryGroup();
			this.galleryGroupSurface = new DevComponents.DotNetBar.GalleryGroup();
			this.galleryGroupDoughnut = new DevComponents.DotNetBar.GalleryGroup();
			this.buttonItem14 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem15 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem16 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem17 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem18 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem19 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem20 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem21 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem22 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem23 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem24 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem25 = new DevComponents.DotNetBar.ButtonItem();
			this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.galleryGroupBubble = new DevComponents.DotNetBar.GalleryGroup();
			this.ribbonControl1.SuspendLayout();
			this.ribbonPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			// 
			// ribbonControl1.BackgroundStyle
			// 
			this.ribbonControl1.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(191)), ((System.Byte)(219)), ((System.Byte)(255)));
			this.ribbonControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.ribbonPanel1});
			this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.ribbonControl1.DockPadding.Bottom = 2;
			this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																						  this.ribbonTabItem1});
			this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Size = new System.Drawing.Size(464, 120);
			this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.ribbonControl1.TabGroupHeight = 14;
			this.ribbonControl1.TabIndex = 0;
			// 
			// ribbonPanel1
			// 
			this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.ribbonPanel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.ribbonBar1});
			this.ribbonPanel1.DefaultLayout = true;
			this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ribbonPanel1.DockPadding.Bottom = 3;
			this.ribbonPanel1.DockPadding.Left = 3;
			this.ribbonPanel1.DockPadding.Right = 3;
			this.ribbonPanel1.Location = new System.Drawing.Point(0, 25);
			this.ribbonPanel1.Name = "ribbonPanel1";
			this.ribbonPanel1.Size = new System.Drawing.Size(464, 93);
			// 
			// ribbonPanel1.Style
			// 
			this.ribbonPanel1.Style.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(222)), ((System.Byte)(232)), ((System.Byte)(245)));
			this.ribbonPanel1.Style.BackColorBlend.AddRange(new DevComponents.DotNetBar.BackgroundColorBlend[] {
																												   new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((System.Byte)(222)), ((System.Byte)(232)), ((System.Byte)(245))), 0F),
																												   new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((System.Byte)(209)), ((System.Byte)(223)), ((System.Byte)(240))), 15F),
																												   new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((System.Byte)(199)), ((System.Byte)(216)), ((System.Byte)(237))), 15F),
																												   new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((System.Byte)(231)), ((System.Byte)(242)), ((System.Byte)(255))), 1F)});
			this.ribbonPanel1.Style.BackColorGradientAngle = 90;
			this.ribbonPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
			this.ribbonPanel1.Style.BorderBottomWidth = 1;
			this.ribbonPanel1.Style.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(141)), ((System.Byte)(178)), ((System.Byte)(227)));
			this.ribbonPanel1.Style.BorderColor2 = System.Drawing.Color.FromArgb(((System.Byte)(136)), ((System.Byte)(161)), ((System.Byte)(194)));
			this.ribbonPanel1.Style.BorderColorLight = System.Drawing.Color.FromArgb(((System.Byte)(231)), ((System.Byte)(239)), ((System.Byte)(248)));
			this.ribbonPanel1.Style.BorderColorLight2 = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(249)), ((System.Byte)(255)));
			this.ribbonPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
			this.ribbonPanel1.Style.BorderLeftWidth = 1;
			this.ribbonPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
			this.ribbonPanel1.Style.BorderRightWidth = 1;
			this.ribbonPanel1.Style.BorderTopWidth = 1;
			this.ribbonPanel1.Style.CornerDiameter = 3;
			this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
			this.ribbonPanel1.Style.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonPanel1.Style.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonPanel1.TabIndex = 1;
			// 
			// ribbonBar1
			// 
			this.ribbonBar1.AutoOverflowEnabled = true;
			this.ribbonBar1.BackColor = System.Drawing.Color.Transparent;
			// 
			// ribbonBar1.BackgroundMouseOverStyle
			// 
			this.ribbonBar1.BackgroundMouseOverStyle.BackColorBlend.AddRange(new DevComponents.DotNetBar.BackgroundColorBlend[] {
																																	new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((System.Byte)(230)), ((System.Byte)(241)), ((System.Byte)(255))), 0F),
																																	new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((System.Byte)(233)), ((System.Byte)(241)), ((System.Byte)(253))), 15F),
																																	new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((System.Byte)(222)), ((System.Byte)(236)), ((System.Byte)(253))), 15F),
																																	new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((System.Byte)(222)), ((System.Byte)(234)), ((System.Byte)(250))), 1F)});
			this.ribbonBar1.BackgroundMouseOverStyle.BackColorGradientAngle = 90;
			this.ribbonBar1.BackgroundMouseOverStyle.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(173)), ((System.Byte)(199)), ((System.Byte)(224)));
			this.ribbonBar1.BackgroundMouseOverStyle.BorderColor2 = System.Drawing.Color.FromArgb(((System.Byte)(126)), ((System.Byte)(173)), ((System.Byte)(211)));
			this.ribbonBar1.BackgroundMouseOverStyle.BorderColorLight = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			// 
			// ribbonBar1.BackgroundStyle
			// 
			this.ribbonBar1.BackgroundStyle.BackColorBlend.AddRange(new DevComponents.DotNetBar.BackgroundColorBlend[] {
																														   new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((System.Byte)(222)), ((System.Byte)(232)), ((System.Byte)(245))), 0F),
																														   new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((System.Byte)(209)), ((System.Byte)(223)), ((System.Byte)(240))), 15F),
																														   new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((System.Byte)(199)), ((System.Byte)(216)), ((System.Byte)(237))), 15F),
																														   new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.FromArgb(((System.Byte)(231)), ((System.Byte)(242)), ((System.Byte)(255))), 1F)});
			this.ribbonBar1.BackgroundStyle.BackColorGradientAngle = 90;
			this.ribbonBar1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
			this.ribbonBar1.BackgroundStyle.BorderBottomWidth = 1;
			this.ribbonBar1.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(198)), ((System.Byte)(210)), ((System.Byte)(223)));
			this.ribbonBar1.BackgroundStyle.BorderColor2 = System.Drawing.Color.FromArgb(((System.Byte)(159)), ((System.Byte)(193)), ((System.Byte)(219)));
			this.ribbonBar1.BackgroundStyle.BorderColorLight = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(244)), ((System.Byte)(250)));
			this.ribbonBar1.BackgroundStyle.BorderColorLight2 = System.Drawing.Color.FromArgb(((System.Byte)(243)), ((System.Byte)(249)), ((System.Byte)(255)));
			this.ribbonBar1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
			this.ribbonBar1.BackgroundStyle.BorderLeftWidth = 1;
			this.ribbonBar1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
			this.ribbonBar1.BackgroundStyle.BorderRightWidth = 1;
			this.ribbonBar1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
			this.ribbonBar1.BackgroundStyle.BorderTopWidth = 1;
			this.ribbonBar1.BackgroundStyle.CornerDiameter = 3;
			this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
			this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																					  this.buttonItem1,
																					  this.galleryContainer1});
			this.ribbonBar1.Location = new System.Drawing.Point(4, 0);
			this.ribbonBar1.Name = "ribbonBar1";
			this.ribbonBar1.Size = new System.Drawing.Size(308, 88);
			this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.ribbonBar1.TabIndex = 1;
			this.ribbonBar1.Text = "Drop-Down Galleries";
			// 
			// ribbonBar1.TitleStyle
			// 
			this.ribbonBar1.TitleStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(194)), ((System.Byte)(217)), ((System.Byte)(241)));
			this.ribbonBar1.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(217)), ((System.Byte)(240)));
			this.ribbonBar1.TitleStyle.BackColorGradientAngle = 90;
			this.ribbonBar1.TitleStyle.PaddingBottom = 1;
			this.ribbonBar1.TitleStyle.PaddingTop = 1;
			this.ribbonBar1.TitleStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.ribbonBar1.TitleStyle.TextColor = System.Drawing.Color.FromArgb(((System.Byte)(62)), ((System.Byte)(106)), ((System.Byte)(170)));
			// 
			// ribbonBar1.TitleStyleMouseOver
			// 
			this.ribbonBar1.TitleStyleMouseOver.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(200)), ((System.Byte)(224)), ((System.Byte)(255)));
			this.ribbonBar1.TitleStyleMouseOver.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(214)), ((System.Byte)(237)), ((System.Byte)(255)));
			this.ribbonBar1.TitleStyleMouseOver.BackColorGradientAngle = 90;
			this.ribbonBar1.TitleStyleMouseOver.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.ribbonBar1.TitleStyleMouseOver.TextColor = System.Drawing.Color.FromArgb(((System.Byte)(62)), ((System.Byte)(106)), ((System.Byte)(170)));
			this.ribbonBar1.MouseEnter += new System.EventHandler(this.ribbonBar1_MouseEnter);
			this.ribbonBar1.MouseLeave += new System.EventHandler(this.ribbonBar1_MouseLeave);
			// 
			// buttonItem1
			// 
			this.buttonItem1.AutoExpandOnClick = true;
			this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.buttonItem1.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem1.Image")));
			this.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.buttonItem1.Name = "buttonItem1";
			this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																						  this.labelItem1,
																						  this.itemContainer1,
																						  this.labelItem2,
																						  this.itemContainer2,
																						  this.labelItem3,
																						  this.itemContainer3,
																						  this.labelItem4,
																						  this.itemContainer4});
			this.buttonItem1.Text = "Chart";
			// 
			// labelItem1
			// 
			this.labelItem1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(217)), ((System.Byte)(228)), ((System.Byte)(236)));
			this.labelItem1.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
			this.labelItem1.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.labelItem1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(15)), ((System.Byte)(99)));
			this.labelItem1.Name = "labelItem1";
			this.labelItem1.PaddingBottom = 1;
			this.labelItem1.PaddingTop = 1;
			this.labelItem1.SingleLineColor = System.Drawing.Color.DarkGray;
			this.labelItem1.Text = "Stock";
			// 
			// itemContainer1
			// 
			this.itemContainer1.MinimumSize = new System.Drawing.Size(0, 0);
			this.itemContainer1.Name = "itemContainer1";
			this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																							 this.buttonItem2,
																							 this.buttonItem3,
																							 this.buttonItem4,
																							 this.buttonItem5});
			// 
			// buttonItem2
			// 
			this.buttonItem2.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem2.Image")));
			this.buttonItem2.Name = "buttonItem2";
			this.buttonItem2.Text = "Stock-Line";
			// 
			// buttonItem3
			// 
			this.buttonItem3.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem3.Image")));
			this.buttonItem3.Name = "buttonItem3";
			this.buttonItem3.Text = "Stock Line 2";
			// 
			// buttonItem4
			// 
			this.buttonItem4.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem4.Image")));
			this.buttonItem4.Name = "buttonItem4";
			this.buttonItem4.Text = "Stock Line 3";
			// 
			// buttonItem5
			// 
			this.buttonItem5.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem5.Image")));
			this.buttonItem5.Name = "buttonItem5";
			this.buttonItem5.Text = "Stock Line 4";
			// 
			// labelItem2
			// 
			this.labelItem2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(217)), ((System.Byte)(228)), ((System.Byte)(236)));
			this.labelItem2.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
			this.labelItem2.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.labelItem2.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(15)), ((System.Byte)(99)));
			this.labelItem2.Name = "labelItem2";
			this.labelItem2.PaddingBottom = 1;
			this.labelItem2.PaddingTop = 1;
			this.labelItem2.SingleLineColor = System.Drawing.Color.DarkGray;
			this.labelItem2.Text = "Surface";
			// 
			// itemContainer2
			// 
			this.itemContainer2.MinimumSize = new System.Drawing.Size(0, 0);
			this.itemContainer2.Name = "itemContainer2";
			this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																							 this.buttonItem6,
																							 this.buttonItem7,
																							 this.buttonItem8,
																							 this.buttonItem9});
			// 
			// buttonItem6
			// 
			this.buttonItem6.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem6.Image")));
			this.buttonItem6.Name = "buttonItem6";
			this.buttonItem6.Text = "Surface Graph 1";
			// 
			// buttonItem7
			// 
			this.buttonItem7.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem7.Image")));
			this.buttonItem7.Name = "buttonItem7";
			this.buttonItem7.Text = "Surface Graph 2";
			// 
			// buttonItem8
			// 
			this.buttonItem8.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem8.Image")));
			this.buttonItem8.Name = "buttonItem8";
			this.buttonItem8.Text = "Surface Graph 3";
			// 
			// buttonItem9
			// 
			this.buttonItem9.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem9.Image")));
			this.buttonItem9.Name = "buttonItem9";
			this.buttonItem9.Text = "Surface Graph 4";
			// 
			// labelItem3
			// 
			this.labelItem3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(217)), ((System.Byte)(228)), ((System.Byte)(236)));
			this.labelItem3.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
			this.labelItem3.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.labelItem3.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(15)), ((System.Byte)(99)));
			this.labelItem3.Name = "labelItem3";
			this.labelItem3.PaddingBottom = 1;
			this.labelItem3.PaddingTop = 1;
			this.labelItem3.SingleLineColor = System.Drawing.Color.DarkGray;
			this.labelItem3.Text = "Doughnut";
			// 
			// itemContainer3
			// 
			this.itemContainer3.MinimumSize = new System.Drawing.Size(0, 0);
			this.itemContainer3.Name = "itemContainer3";
			this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																							 this.buttonItem10,
																							 this.buttonItem11});
			// 
			// buttonItem10
			// 
			this.buttonItem10.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem10.Image")));
			this.buttonItem10.Name = "buttonItem10";
			this.buttonItem10.Text = "Doughnut Graph 1";
			// 
			// buttonItem11
			// 
			this.buttonItem11.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem11.Image")));
			this.buttonItem11.Name = "buttonItem11";
			this.buttonItem11.Text = "Doughnut Graph 2";
			// 
			// labelItem4
			// 
			this.labelItem4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(217)), ((System.Byte)(228)), ((System.Byte)(236)));
			this.labelItem4.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
			this.labelItem4.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.labelItem4.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(15)), ((System.Byte)(99)));
			this.labelItem4.Name = "labelItem4";
			this.labelItem4.PaddingBottom = 1;
			this.labelItem4.PaddingTop = 1;
			this.labelItem4.SingleLineColor = System.Drawing.Color.DarkGray;
			this.labelItem4.Text = "Bubble";
			// 
			// itemContainer4
			// 
			this.itemContainer4.MinimumSize = new System.Drawing.Size(0, 0);
			this.itemContainer4.Name = "itemContainer4";
			this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																							 this.buttonItem12,
																							 this.buttonItem13});
			// 
			// buttonItem12
			// 
			this.buttonItem12.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem12.Image")));
			this.buttonItem12.Name = "buttonItem12";
			this.buttonItem12.Text = "Bubble Graph 1";
			// 
			// buttonItem13
			// 
			this.buttonItem13.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem13.Image")));
			this.buttonItem13.Name = "buttonItem13";
			this.buttonItem13.Text = "Bubble Graph 2";
			// 
			// galleryContainer1
			// 
			// 
			// galleryContainer1.BackgroundStyle
			// 
			this.galleryContainer1.BackgroundStyle.Class = "RibbonGalleryContainer";
			this.galleryContainer1.GalleryGroups.AddRange(new DevComponents.DotNetBar.GalleryGroup[] {
																										 this.galleryGroupStock,
																										 this.galleryGroupSurface,
																										 this.galleryGroupDoughnut,
																										 this.galleryGroupBubble});
			this.galleryContainer1.MinimumSize = new System.Drawing.Size(58, 58);
			this.galleryContainer1.Name = "galleryContainer1";
			this.galleryContainer1.StretchGallery = true;
			this.galleryContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																								this.buttonItem14,
																								this.buttonItem15,
																								this.buttonItem16,
																								this.buttonItem17,
																								this.buttonItem18,
																								this.buttonItem19,
																								this.buttonItem20,
																								this.buttonItem21,
																								this.buttonItem22,
																								this.buttonItem23,
																								this.buttonItem24,
																								this.buttonItem25});
			// 
			// galleryGroupStock
			// 
			this.galleryGroupStock.Name = "galleryGroupStock";
			this.galleryGroupStock.Text = "<b>Stock</b>";
			// 
			// galleryGroupSurface
			// 
			this.galleryGroupSurface.DisplayOrder = 1;
			this.galleryGroupSurface.Name = "galleryGroupSurface";
			this.galleryGroupSurface.Text = "<b>Surface</b>";
			// 
			// galleryGroupDoughnut
			// 
			this.galleryGroupDoughnut.DisplayOrder = 2;
			this.galleryGroupDoughnut.Name = "galleryGroupDoughnut";
			this.galleryGroupDoughnut.Text = "<b>Doughnut</b>";
			// 
			// buttonItem14
			// 
			this.galleryContainer1.SetGalleryGroup(this.buttonItem14, this.galleryGroupStock);
			this.buttonItem14.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem14.Image")));
			this.buttonItem14.Name = "buttonItem14";
			this.buttonItem14.Text = "buttonItem14";
			// 
			// buttonItem15
			// 
			this.galleryContainer1.SetGalleryGroup(this.buttonItem15, this.galleryGroupStock);
			this.buttonItem15.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem15.Image")));
			this.buttonItem15.Name = "buttonItem15";
			this.buttonItem15.Text = "buttonItem15";
			// 
			// buttonItem16
			// 
			this.galleryContainer1.SetGalleryGroup(this.buttonItem16, this.galleryGroupStock);
			this.buttonItem16.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem16.Image")));
			this.buttonItem16.Name = "buttonItem16";
			this.buttonItem16.Text = "buttonItem16";
			// 
			// buttonItem17
			// 
			this.galleryContainer1.SetGalleryGroup(this.buttonItem17, this.galleryGroupStock);
			this.buttonItem17.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem17.Image")));
			this.buttonItem17.Name = "buttonItem17";
			this.buttonItem17.Text = "buttonItem17";
			// 
			// buttonItem18
			// 
			this.galleryContainer1.SetGalleryGroup(this.buttonItem18, this.galleryGroupSurface);
			this.buttonItem18.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem18.Image")));
			this.buttonItem18.Name = "buttonItem18";
			this.buttonItem18.Text = "buttonItem18";
			// 
			// buttonItem19
			// 
			this.galleryContainer1.SetGalleryGroup(this.buttonItem19, this.galleryGroupSurface);
			this.buttonItem19.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem19.Image")));
			this.buttonItem19.Name = "buttonItem19";
			this.buttonItem19.Text = "buttonItem19";
			// 
			// buttonItem20
			// 
			this.galleryContainer1.SetGalleryGroup(this.buttonItem20, this.galleryGroupSurface);
			this.buttonItem20.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem20.Image")));
			this.buttonItem20.Name = "buttonItem20";
			this.buttonItem20.Text = "buttonItem20";
			// 
			// buttonItem21
			// 
			this.galleryContainer1.SetGalleryGroup(this.buttonItem21, this.galleryGroupSurface);
			this.buttonItem21.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem21.Image")));
			this.buttonItem21.Name = "buttonItem21";
			this.buttonItem21.Text = "buttonItem21";
			// 
			// buttonItem22
			// 
			this.galleryContainer1.SetGalleryGroup(this.buttonItem22, this.galleryGroupDoughnut);
			this.buttonItem22.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem22.Image")));
			this.buttonItem22.Name = "buttonItem22";
			this.buttonItem22.Text = "buttonItem22";
			// 
			// buttonItem23
			// 
			this.galleryContainer1.SetGalleryGroup(this.buttonItem23, this.galleryGroupDoughnut);
			this.buttonItem23.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem23.Image")));
			this.buttonItem23.Name = "buttonItem23";
			this.buttonItem23.Text = "buttonItem23";
			// 
			// buttonItem24
			// 
			this.galleryContainer1.SetGalleryGroup(this.buttonItem24, this.galleryGroupBubble);
			this.buttonItem24.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem24.Image")));
			this.buttonItem24.Name = "buttonItem24";
			this.buttonItem24.Text = "buttonItem24";
			// 
			// buttonItem25
			// 
			this.galleryContainer1.SetGalleryGroup(this.buttonItem25, this.galleryGroupBubble);
			this.buttonItem25.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem25.Image")));
			this.buttonItem25.Name = "buttonItem25";
			this.buttonItem25.Text = "buttonItem25";
			// 
			// ribbonTabItem1
			// 
			this.ribbonTabItem1.Checked = true;
			this.ribbonTabItem1.Name = "ribbonTabItem1";
			this.ribbonTabItem1.Panel = this.ribbonPanel1;
			this.ribbonTabItem1.Text = "Insert";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Location = new System.Drawing.Point(272, 152);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(176, 152);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.label1.Location = new System.Drawing.Point(272, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Preview";
			// 
			// galleryGroupBubble
			// 
			this.galleryGroupBubble.DisplayOrder = 3;
			this.galleryGroupBubble.Name = "galleryGroupBubble";
			this.galleryGroupBubble.Text = "<b>Bubble</b>";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(464, 318);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.pictureBox1,
																		  this.ribbonControl1});
			this.Name = "Form1";
			this.Text = "Form1";
			this.ribbonControl1.ResumeLayout(false);
			this.ribbonPanel1.ResumeLayout(false);
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

		private void ribbonBar1_MouseEnter(object sender, System.EventArgs e)
		{
			BaseItem item = sender as BaseItem;
			if(item==null)
			{
				ResetPreview();
				return;
			}
			
			if(item.IsOnMenu && item is ButtonItem)
			{
				ButtonItem button=item as ButtonItem;
				pictureBox1.Image = button.Image;
			}

		}

		private void ribbonBar1_MouseLeave(object sender, System.EventArgs e)
		{
			ResetPreview();
		}

		private void ResetPreview()
		{
			pictureBox1.Image=null;
		}
	}
}
