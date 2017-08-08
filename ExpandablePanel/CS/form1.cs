using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;

namespace ExpandablePanel
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevComponents.DotNetBar.PanelEx panelEx1;
		private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
		private DevComponents.DotNetBar.ExpandablePanel expandablePanel2;
		private DevComponents.DotNetBar.ExpandablePanel expandablePanel3;
		private DevComponents.DotNetBar.ExpandablePanel expandablePanel4;
		private DevComponents.DotNetBar.ItemPanel itemPanel1;
		private DevComponents.DotNetBar.ButtonItem buttonItem1;
		private DevComponents.DotNetBar.ButtonItem buttonItem2;
		private DevComponents.DotNetBar.ButtonItem buttonItem3;
		private DevComponents.DotNetBar.ExpandablePanel expandablePanel5;
		private DevComponents.DotNetBar.ItemPanel itemPanel2;
		private DevComponents.DotNetBar.ButtonItem buttonItem4;
		private DevComponents.DotNetBar.ButtonItem buttonItem5;
		private DevComponents.DotNetBar.ButtonItem buttonItem6;
		private DevComponents.DotNetBar.ButtonItem buttonItem7;
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
			this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
			this.expandablePanel3 = new DevComponents.DotNetBar.ExpandablePanel();
			this.expandablePanel2 = new DevComponents.DotNetBar.ExpandablePanel();
			this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
			this.expandablePanel5 = new DevComponents.DotNetBar.ExpandablePanel();
			this.itemPanel2 = new DevComponents.DotNetBar.ItemPanel();
			this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
			this.expandablePanel4 = new DevComponents.DotNetBar.ExpandablePanel();
			this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
			this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
			this.panelEx1.SuspendLayout();
			this.expandablePanel1.SuspendLayout();
			this.expandablePanel5.SuspendLayout();
			this.expandablePanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelEx1
			// 
			this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
			this.panelEx1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.expandablePanel3,
																				   this.expandablePanel2,
																				   this.expandablePanel1});
			this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new System.Drawing.Size(536, 286);
			this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.panelEx1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
			this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.TabIndex = 0;
			// 
			// expandablePanel3
			// 
			this.expandablePanel3.ButtonImageCollapse = ((System.Drawing.Bitmap)(resources.GetObject("expandablePanel3.ButtonImageCollapse")));
			this.expandablePanel3.ButtonImageExpand = ((System.Drawing.Bitmap)(resources.GetObject("expandablePanel3.ButtonImageExpand")));
			this.expandablePanel3.CanvasColor = System.Drawing.SystemColors.Control;
			this.expandablePanel3.DockPadding.All = 3;
			this.expandablePanel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.expandablePanel3.Location = new System.Drawing.Point(352, 8);
			this.expandablePanel3.Name = "expandablePanel3";
			this.expandablePanel3.Size = new System.Drawing.Size(168, 264);
			this.expandablePanel3.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.expandablePanel3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuSide;
			this.expandablePanel3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuSide2;
			this.expandablePanel3.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
			this.expandablePanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.expandablePanel3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.expandablePanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
			this.expandablePanel3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandablePanel3.Style.GradientAngle = -90;
			this.expandablePanel3.Style.WordWrap = true;
			this.expandablePanel3.TabIndex = 2;
			this.expandablePanel3.Text = "ExpandablePanel with rounded border and custom style for title bar. Custom expand" +
				"/collapse button is used as well.";
			this.expandablePanel3.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
			this.expandablePanel3.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground;
			this.expandablePanel3.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground2;
			this.expandablePanel3.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.expandablePanel3.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder;
			this.expandablePanel3.TitleStyle.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
			this.expandablePanel3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
			this.expandablePanel3.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
			this.expandablePanel3.TitleStyle.GradientAngle = 90;
			this.expandablePanel3.TitleText = "Title Bar";
			// 
			// expandablePanel2
			// 
			this.expandablePanel2.ButtonImageCollapse = ((System.Drawing.Bitmap)(resources.GetObject("expandablePanel2.ButtonImageCollapse")));
			this.expandablePanel2.ButtonImageExpand = ((System.Drawing.Bitmap)(resources.GetObject("expandablePanel2.ButtonImageExpand")));
			this.expandablePanel2.CanvasColor = System.Drawing.SystemColors.Control;
			this.expandablePanel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.expandablePanel2.Location = new System.Drawing.Point(168, 8);
			this.expandablePanel2.Name = "expandablePanel2";
			this.expandablePanel2.Size = new System.Drawing.Size(168, 264);
			this.expandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.expandablePanel2.Style.BackColor1.Color = System.Drawing.Color.White;
			this.expandablePanel2.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
			this.expandablePanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.expandablePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.expandablePanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
			this.expandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandablePanel2.Style.GradientAngle = 90;
			this.expandablePanel2.Style.WordWrap = true;
			this.expandablePanel2.TabIndex = 1;
			this.expandablePanel2.Text = "ExpandablePanel with rounded border and custom style for title bar. Custom expand" +
				"/collapse button is used as well.";
			this.expandablePanel2.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
			this.expandablePanel2.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.expandablePanel2.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.expandablePanel2.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.expandablePanel2.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandablePanel2.TitleStyle.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
			this.expandablePanel2.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.expandablePanel2.TitleStyle.GradientAngle = 90;
			this.expandablePanel2.TitleText = "Title Bar";
			// 
			// expandablePanel1
			// 
			this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
			this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
			this.expandablePanel1.ColorScheme.DockSiteBackColorGradientAngle = 0;
			this.expandablePanel1.ColorScheme.ItemDesignTimeBorder = System.Drawing.Color.Black;
			this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.expandablePanel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.expandablePanel5,
																						   this.expandablePanel4});
			this.expandablePanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.expandablePanel1.Location = new System.Drawing.Point(8, 8);
			this.expandablePanel1.Name = "expandablePanel1";
			this.expandablePanel1.Size = new System.Drawing.Size(144, 264);
			this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.expandablePanel1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
			this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandablePanel1.Style.GradientAngle = 90;
			this.expandablePanel1.Style.WordWrap = true;
			this.expandablePanel1.TabIndex = 0;
			this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
			this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.expandablePanel1.TitleStyle.GradientAngle = 90;
			this.expandablePanel1.TitleStyle.MarginLeft = 6;
			this.expandablePanel1.TitleText = "Panel Styles";
			// 
			// expandablePanel5
			// 
			this.expandablePanel5.CanvasColor = System.Drawing.SystemColors.Control;
			this.expandablePanel5.ColorScheme.DockSiteBackColorGradientAngle = 0;
			this.expandablePanel5.ColorScheme.ItemDesignTimeBorder = System.Drawing.Color.Black;
			this.expandablePanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.expandablePanel5.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.itemPanel2});
			this.expandablePanel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.expandablePanel5.ExpandOnTitleClick = true;
			this.expandablePanel5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.expandablePanel5.Location = new System.Drawing.Point(0, 128);
			this.expandablePanel5.Name = "expandablePanel5";
			this.expandablePanel5.Size = new System.Drawing.Size(144, 136);
			this.expandablePanel5.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.expandablePanel5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.expandablePanel5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.expandablePanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.expandablePanel5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.expandablePanel5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandablePanel5.Style.GradientAngle = 90;
			this.expandablePanel5.TabIndex = 3;
			this.expandablePanel5.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.expandablePanel5.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.expandablePanel5.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
			this.expandablePanel5.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandablePanel5.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.expandablePanel5.TitleStyle.GradientAngle = 90;
			this.expandablePanel5.TitleStyle.MarginLeft = 12;
			this.expandablePanel5.TitleText = "Custom Schemes";
			// 
			// itemPanel2
			// 
			// 
			// itemPanel2.BackgroundStyle
			// 
			this.itemPanel2.BackgroundStyle.BackColor = System.Drawing.Color.White;
			this.itemPanel2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.itemPanel2.BackgroundStyle.BorderBottomWidth = 1;
			this.itemPanel2.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(157)), ((System.Byte)(185)));
			this.itemPanel2.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.itemPanel2.BackgroundStyle.BorderLeftWidth = 1;
			this.itemPanel2.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.itemPanel2.BackgroundStyle.BorderRightWidth = 1;
			this.itemPanel2.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.itemPanel2.BackgroundStyle.BorderTopWidth = 1;
			this.itemPanel2.BackgroundStyle.PaddingBottom = 1;
			this.itemPanel2.BackgroundStyle.PaddingLeft = 1;
			this.itemPanel2.BackgroundStyle.PaddingRight = 1;
			this.itemPanel2.BackgroundStyle.PaddingTop = 1;
			this.itemPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemPanel2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																					  this.buttonItem4,
																					  this.buttonItem5,
																					  this.buttonItem6,
																					  this.buttonItem7});
			this.itemPanel2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.itemPanel2.Location = new System.Drawing.Point(0, 26);
			this.itemPanel2.Name = "itemPanel2";
			this.itemPanel2.Size = new System.Drawing.Size(144, 110);
			this.itemPanel2.TabIndex = 3;
			this.itemPanel2.Text = "itemPanel2";
			// 
			// buttonItem4
			// 
			this.buttonItem4.Name = "buttonItem4";
			this.buttonItem4.Text = "Red";
			this.buttonItem4.Click += new System.EventHandler(this.buttonItem4_Click);
			// 
			// buttonItem5
			// 
			this.buttonItem5.Name = "buttonItem5";
			this.buttonItem5.Text = "Dark Blue";
			this.buttonItem5.Click += new System.EventHandler(this.buttonItem5_Click);
			// 
			// buttonItem6
			// 
			this.buttonItem6.Name = "buttonItem6";
			this.buttonItem6.Text = "Orange";
			this.buttonItem6.Click += new System.EventHandler(this.buttonItem6_Click);
			// 
			// buttonItem7
			// 
			this.buttonItem7.Name = "buttonItem7";
			this.buttonItem7.Text = "Green";
			this.buttonItem7.Click += new System.EventHandler(this.buttonItem7_Click);
			// 
			// expandablePanel4
			// 
			this.expandablePanel4.CanvasColor = System.Drawing.SystemColors.Control;
			this.expandablePanel4.ColorScheme.DockSiteBackColorGradientAngle = 0;
			this.expandablePanel4.ColorScheme.ItemDesignTimeBorder = System.Drawing.Color.Black;
			this.expandablePanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.expandablePanel4.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.itemPanel1});
			this.expandablePanel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.expandablePanel4.ExpandOnTitleClick = true;
			this.expandablePanel4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.expandablePanel4.Location = new System.Drawing.Point(0, 26);
			this.expandablePanel4.Name = "expandablePanel4";
			this.expandablePanel4.Size = new System.Drawing.Size(144, 102);
			this.expandablePanel4.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.expandablePanel4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.expandablePanel4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.expandablePanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.expandablePanel4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.expandablePanel4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandablePanel4.Style.GradientAngle = 90;
			this.expandablePanel4.TabIndex = 3;
			this.expandablePanel4.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.expandablePanel4.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.expandablePanel4.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
			this.expandablePanel4.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandablePanel4.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.expandablePanel4.TitleStyle.GradientAngle = 90;
			this.expandablePanel4.TitleStyle.MarginLeft = 12;
			this.expandablePanel4.TitleText = "Office 2007 Colors";
			// 
			// itemPanel1
			// 
			// 
			// itemPanel1.BackgroundStyle
			// 
			this.itemPanel1.BackgroundStyle.BackColor = System.Drawing.Color.White;
			this.itemPanel1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.itemPanel1.BackgroundStyle.BorderBottomWidth = 1;
			this.itemPanel1.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(157)), ((System.Byte)(185)));
			this.itemPanel1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.itemPanel1.BackgroundStyle.BorderLeftWidth = 1;
			this.itemPanel1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.itemPanel1.BackgroundStyle.BorderRightWidth = 1;
			this.itemPanel1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.itemPanel1.BackgroundStyle.BorderTopWidth = 1;
			this.itemPanel1.BackgroundStyle.PaddingBottom = 1;
			this.itemPanel1.BackgroundStyle.PaddingLeft = 1;
			this.itemPanel1.BackgroundStyle.PaddingRight = 1;
			this.itemPanel1.BackgroundStyle.PaddingTop = 1;
			this.itemPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																					  this.buttonItem1,
																					  this.buttonItem2,
																					  this.buttonItem3});
			this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.itemPanel1.Location = new System.Drawing.Point(0, 26);
			this.itemPanel1.Name = "itemPanel1";
			this.itemPanel1.Size = new System.Drawing.Size(144, 76);
			this.itemPanel1.TabIndex = 3;
			this.itemPanel1.Text = "itemPanel1";
			// 
			// buttonItem1
			// 
			this.buttonItem1.Name = "buttonItem1";
			this.buttonItem1.Text = "Black";
			this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
			// 
			// buttonItem2
			// 
			this.buttonItem2.Name = "buttonItem2";
			this.buttonItem2.Text = "Blue";
			this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
			// 
			// buttonItem3
			// 
			this.buttonItem3.Name = "buttonItem3";
			this.buttonItem3.Text = "Silver";
			this.buttonItem3.Click += new System.EventHandler(this.buttonItem3_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(536, 286);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panelEx1});
			this.Name = "Form1";
			this.Text = "Form1";
			this.panelEx1.ResumeLayout(false);
			this.expandablePanel1.ResumeLayout(false);
			this.expandablePanel5.ResumeLayout(false);
			this.expandablePanel4.ResumeLayout(false);
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

		private void buttonItem1_Click(object sender, System.EventArgs e)
		{
			RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black);
		}

		private void buttonItem2_Click(object sender, System.EventArgs e)
		{
			RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue);		
		}

		private void buttonItem3_Click(object sender, System.EventArgs e)
		{
			RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver);
		}

		private void buttonItem4_Click(object sender, System.EventArgs e)
		{
			RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black, Color.Red);
		}

		private void buttonItem5_Click(object sender, System.EventArgs e)
		{
			RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue, Color.Navy);
		}

		private void buttonItem6_Click(object sender, System.EventArgs e)
		{
			RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver, Color.Orange);
		}

		private void buttonItem7_Click(object sender, System.EventArgs e)
		{
			RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver, Color.Green);
		}
	}
}
