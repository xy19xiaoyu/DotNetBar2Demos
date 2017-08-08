using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;

namespace ItemPanel
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevComponents.DotNetBar.PanelEx panelEx1;
		private DevComponents.DotNetBar.ButtonX buttonX1;
		private DevComponents.DotNetBar.ButtonX buttonX2;
		private DevComponents.DotNetBar.ItemPanel itemPanel2;
		private DevComponents.DotNetBar.ButtonItem buttonItem1;
		private DevComponents.DotNetBar.LabelItem labelItem1;
		private DevComponents.DotNetBar.ButtonItem buttonItem12;
		private DevComponents.DotNetBar.LabelItem labelItem2;
		private DevComponents.DotNetBar.LabelItem labelItem3;
		private DevComponents.DotNetBar.LabelItem labelItem4;
		private DevComponents.DotNetBar.LabelItem labelItem5;
		private DevComponents.DotNetBar.ButtonItem buttonItem13;
		private DevComponents.DotNetBar.ButtonItem buttonItem14;
		private DevComponents.DotNetBar.ButtonItem buttonItem15;
		private DevComponents.DotNetBar.ButtonItem buttonItem16;
		private DevComponents.DotNetBar.ButtonItem buttonItem17;
		private DevComponents.DotNetBar.ButtonItem buttonItem18;
		private DevComponents.DotNetBar.ButtonItem buttonItem19;
		private DevComponents.DotNetBar.ButtonItem buttonItem20;
		private DevComponents.DotNetBar.ButtonItem buttonItem21;
		private DevComponents.DotNetBar.ButtonItem buttonItem22;
		private DevComponents.DotNetBar.ButtonItem buttonItem23;
		private DevComponents.DotNetBar.ButtonItem buttonItem9;
		private DevComponents.DotNetBar.ButtonItem buttonItem10;
		private DevComponents.DotNetBar.ButtonItem buttonItem11;
		private DevComponents.DotNetBar.ButtonItem buttonItem24;
		private DevComponents.DotNetBar.ButtonItem buttonItem25;
		private DevComponents.DotNetBar.ButtonItem buttonItem26;
		private DevComponents.DotNetBar.ButtonItem buttonItem27;
		private DevComponents.DotNetBar.ButtonItem buttonItem28;
		private DevComponents.DotNetBar.ButtonItem buttonItem29;
		private DevComponents.DotNetBar.ButtonItem buttonItem30;
		private DevComponents.DotNetBar.ButtonItem buttonItem31;
		private DevComponents.DotNetBar.ButtonItem buttonItem32;
		private DevComponents.DotNetBar.ButtonItem buttonItem33;
		private DevComponents.DotNetBar.ButtonItem columnSelector;
		private DevComponents.DotNetBar.ButtonItem lineSelector;
		private DevComponents.DotNetBar.ButtonItem pieSelector;
		private DevComponents.DotNetBar.ButtonItem barSelector;
		private DevComponents.DotNetBar.ButtonItem areaSelector;
		private DevComponents.DotNetBar.ButtonItem xySelector;
		private DevComponents.DotNetBar.ButtonItem stockSelector;
		private DevComponents.DotNetBar.ItemContainer columnContainer;
		private DevComponents.DotNetBar.ItemContainer lineContainer;
		private DevComponents.DotNetBar.ItemContainer pieContainer;
		private DevComponents.DotNetBar.ItemContainer barContainer;
		private DevComponents.DotNetBar.ItemContainer areaContainer;
		private DevComponents.DotNetBar.ItemPanel chartTypes;
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
			this.chartTypes = new DevComponents.DotNetBar.ItemPanel();
			this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
			this.columnSelector = new DevComponents.DotNetBar.ButtonItem();
			this.lineSelector = new DevComponents.DotNetBar.ButtonItem();
			this.pieSelector = new DevComponents.DotNetBar.ButtonItem();
			this.barSelector = new DevComponents.DotNetBar.ButtonItem();
			this.areaSelector = new DevComponents.DotNetBar.ButtonItem();
			this.xySelector = new DevComponents.DotNetBar.ButtonItem();
			this.stockSelector = new DevComponents.DotNetBar.ButtonItem();
			this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
			this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
			this.itemPanel2 = new DevComponents.DotNetBar.ItemPanel();
			this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
			this.columnContainer = new DevComponents.DotNetBar.ItemContainer();
			this.buttonItem12 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem13 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem14 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem15 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem16 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem17 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem18 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem19 = new DevComponents.DotNetBar.ButtonItem();
			this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
			this.lineContainer = new DevComponents.DotNetBar.ItemContainer();
			this.buttonItem20 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem21 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem22 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem23 = new DevComponents.DotNetBar.ButtonItem();
			this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
			this.pieContainer = new DevComponents.DotNetBar.ItemContainer();
			this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem10 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem11 = new DevComponents.DotNetBar.ButtonItem();
			this.labelItem4 = new DevComponents.DotNetBar.LabelItem();
			this.barContainer = new DevComponents.DotNetBar.ItemContainer();
			this.buttonItem24 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem25 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem26 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem27 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem28 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem29 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem30 = new DevComponents.DotNetBar.ButtonItem();
			this.labelItem5 = new DevComponents.DotNetBar.LabelItem();
			this.areaContainer = new DevComponents.DotNetBar.ItemContainer();
			this.buttonItem31 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem32 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem33 = new DevComponents.DotNetBar.ButtonItem();
			this.SuspendLayout();
			// 
			// panelEx1
			// 
			this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
			this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelEx1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panelEx1.Location = new System.Drawing.Point(0, 0);
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new System.Drawing.Size(562, 32);
			this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(95)), ((System.Byte)(136)), ((System.Byte)(215)));
			this.panelEx1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((System.Byte)(67)), ((System.Byte)(108)), ((System.Byte)(191)));
			this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.Style.MarginLeft = 8;
			this.panelEx1.TabIndex = 0;
			this.panelEx1.Text = "Choose a Chart Type";
			// 
			// chartTypes
			// 
			this.chartTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			// 
			// chartTypes.BackgroundStyle
			// 
			this.chartTypes.BackgroundStyle.BackColor = System.Drawing.Color.White;
			this.chartTypes.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.chartTypes.BackgroundStyle.BorderBottomWidth = 1;
			this.chartTypes.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(157)), ((System.Byte)(185)));
			this.chartTypes.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.chartTypes.BackgroundStyle.BorderLeftWidth = 1;
			this.chartTypes.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.chartTypes.BackgroundStyle.BorderRightWidth = 1;
			this.chartTypes.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.chartTypes.BackgroundStyle.BorderTopWidth = 1;
			this.chartTypes.BackgroundStyle.PaddingBottom = 1;
			this.chartTypes.BackgroundStyle.PaddingLeft = 1;
			this.chartTypes.BackgroundStyle.PaddingRight = 1;
			this.chartTypes.BackgroundStyle.PaddingTop = 1;
			this.chartTypes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chartTypes.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																					  this.buttonItem1,
																					  this.columnSelector,
																					  this.lineSelector,
																					  this.pieSelector,
																					  this.barSelector,
																					  this.areaSelector,
																					  this.xySelector,
																					  this.stockSelector});
			this.chartTypes.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.chartTypes.Location = new System.Drawing.Point(6, 36);
			this.chartTypes.Name = "chartTypes";
			this.chartTypes.Size = new System.Drawing.Size(152, 262);
			this.chartTypes.TabIndex = 1;
			this.chartTypes.Text = "itemPanel1";
			// 
			// buttonItem1
			// 
			this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
			this.buttonItem1.Name = "buttonItem1";
			this.buttonItem1.OptionGroup = "charts";
			this.buttonItem1.Text = "Templates";
			// 
			// columnSelector
			// 
			this.columnSelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.columnSelector.Checked = true;
			this.columnSelector.Image = ((System.Drawing.Image)(resources.GetObject("columnSelector.Image")));
			this.columnSelector.Name = "columnSelector";
			this.columnSelector.OptionGroup = "charts";
			this.columnSelector.Text = "Column";
			this.columnSelector.Click += new System.EventHandler(this.columnSelector_Click);
			// 
			// lineSelector
			// 
			this.lineSelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.lineSelector.Image = ((System.Drawing.Image)(resources.GetObject("lineSelector.Image")));
			this.lineSelector.Name = "lineSelector";
			this.lineSelector.OptionGroup = "charts";
			this.lineSelector.Text = "Line";
			this.lineSelector.Click += new System.EventHandler(this.lineSelector_Click);
			// 
			// pieSelector
			// 
			this.pieSelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.pieSelector.Image = ((System.Drawing.Image)(resources.GetObject("pieSelector.Image")));
			this.pieSelector.Name = "pieSelector";
			this.pieSelector.OptionGroup = "charts";
			this.pieSelector.Text = "Pie";
			this.pieSelector.Click += new System.EventHandler(this.pieSelector_Click);
			// 
			// barSelector
			// 
			this.barSelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.barSelector.Image = ((System.Drawing.Image)(resources.GetObject("barSelector.Image")));
			this.barSelector.Name = "barSelector";
			this.barSelector.OptionGroup = "charts";
			this.barSelector.Text = "Bar";
			this.barSelector.Click += new System.EventHandler(this.barSelector_Click);
			// 
			// areaSelector
			// 
			this.areaSelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.areaSelector.Image = ((System.Drawing.Image)(resources.GetObject("areaSelector.Image")));
			this.areaSelector.Name = "areaSelector";
			this.areaSelector.OptionGroup = "charts";
			this.areaSelector.Text = "Area";
			this.areaSelector.Click += new System.EventHandler(this.areaSelector_Click);
			// 
			// xySelector
			// 
			this.xySelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.xySelector.Image = ((System.Drawing.Image)(resources.GetObject("xySelector.Image")));
			this.xySelector.Name = "xySelector";
			this.xySelector.OptionGroup = "charts";
			this.xySelector.Text = "X Y (Scatter)";
			// 
			// stockSelector
			// 
			this.stockSelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.stockSelector.Image = ((System.Drawing.Image)(resources.GetObject("stockSelector.Image")));
			this.stockSelector.Name = "stockSelector";
			this.stockSelector.OptionGroup = "charts";
			this.stockSelector.Text = "Stock";
			// 
			// buttonX1
			// 
			this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonX1.ColorScheme.DockSiteBackColorGradientAngle = 0;
			this.buttonX1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonX1.Location = new System.Drawing.Point(404, 304);
			this.buttonX1.Name = "buttonX1";
			this.buttonX1.Size = new System.Drawing.Size(72, 24);
			this.buttonX1.TabIndex = 2;
			this.buttonX1.Text = "OK";
			this.buttonX1.ThemeAware = true;
			this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
			// 
			// buttonX2
			// 
			this.buttonX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonX2.ColorScheme.DockSiteBackColorGradientAngle = 0;
			this.buttonX2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonX2.Location = new System.Drawing.Point(482, 304);
			this.buttonX2.Name = "buttonX2";
			this.buttonX2.Size = new System.Drawing.Size(72, 24);
			this.buttonX2.TabIndex = 3;
			this.buttonX2.Text = "Cancel";
			this.buttonX2.ThemeAware = true;
			this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
			// 
			// itemPanel2
			// 
			this.itemPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.itemPanel2.AutoScroll = true;
			this.itemPanel2.AutoScrollMinSize = new System.Drawing.Size(369, 493);
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
			this.itemPanel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.itemPanel2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																					  this.labelItem1,
																					  this.columnContainer,
																					  this.labelItem2,
																					  this.lineContainer,
																					  this.labelItem3,
																					  this.pieContainer,
																					  this.labelItem4,
																					  this.barContainer,
																					  this.labelItem5,
																					  this.areaContainer});
			this.itemPanel2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.itemPanel2.Location = new System.Drawing.Point(168, 36);
			this.itemPanel2.Name = "itemPanel2";
			this.itemPanel2.Size = new System.Drawing.Size(386, 262);
			this.itemPanel2.TabIndex = 4;
			this.itemPanel2.Text = "itemPanel2";
			this.itemPanel2.ItemClick += new System.EventHandler(this.itemPanel2_ItemClick);
			// 
			// labelItem1
			// 
			this.labelItem1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(235)), ((System.Byte)(235)), ((System.Byte)(235)));
			this.labelItem1.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
			this.labelItem1.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.labelItem1.Name = "labelItem1";
			this.labelItem1.PaddingBottom = 1;
			this.labelItem1.PaddingLeft = 1;
			this.labelItem1.PaddingRight = 1;
			this.labelItem1.PaddingTop = 1;
			this.labelItem1.SingleLineColor = System.Drawing.Color.FromArgb(((System.Byte)(197)), ((System.Byte)(197)), ((System.Byte)(197)));
			this.labelItem1.Text = "<b>Column</b>";
			// 
			// columnContainer
			// 
			this.columnContainer.MinimumSize = new System.Drawing.Size(0, 0);
			this.columnContainer.MultiLine = true;
			this.columnContainer.Name = "columnContainer";
			this.columnContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																							  this.buttonItem12,
																							  this.buttonItem13,
																							  this.buttonItem14,
																							  this.buttonItem15,
																							  this.buttonItem16,
																							  this.buttonItem17,
																							  this.buttonItem18,
																							  this.buttonItem19});
			// 
			// buttonItem12
			// 
			this.buttonItem12.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem12.Image")));
			this.buttonItem12.Name = "buttonItem12";
			this.buttonItem12.OptionGroup = "chart";
			this.buttonItem12.Text = "Clustered Column";
			this.buttonItem12.Tooltip = "Clustered Column";
			// 
			// buttonItem13
			// 
			this.buttonItem13.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem13.Image")));
			this.buttonItem13.Name = "buttonItem13";
			this.buttonItem13.OptionGroup = "chart";
			this.buttonItem13.Text = "Stacked Column";
			this.buttonItem13.Tooltip = "Stacked Column";
			// 
			// buttonItem14
			// 
			this.buttonItem14.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem14.Image")));
			this.buttonItem14.Name = "buttonItem14";
			this.buttonItem14.OptionGroup = "chart";
			this.buttonItem14.Text = "100% Stacked Column";
			this.buttonItem14.Tooltip = "100% Stacked Column";
			// 
			// buttonItem15
			// 
			this.buttonItem15.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem15.Image")));
			this.buttonItem15.Name = "buttonItem15";
			this.buttonItem15.OptionGroup = "chart";
			this.buttonItem15.Text = "Clustered Column";
			this.buttonItem15.Tooltip = "Clustered Column";
			// 
			// buttonItem16
			// 
			this.buttonItem16.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem16.Image")));
			this.buttonItem16.Name = "buttonItem16";
			this.buttonItem16.OptionGroup = "chart";
			this.buttonItem16.Text = "Stacked Column";
			this.buttonItem16.Tooltip = "Stacked Column";
			// 
			// buttonItem17
			// 
			this.buttonItem17.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem17.Image")));
			this.buttonItem17.Name = "buttonItem17";
			this.buttonItem17.OptionGroup = "chart";
			this.buttonItem17.Text = "100% Stacked Column";
			this.buttonItem17.Tooltip = "100% Stacked Column";
			// 
			// buttonItem18
			// 
			this.buttonItem18.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem18.Image")));
			this.buttonItem18.Name = "buttonItem18";
			this.buttonItem18.OptionGroup = "chart";
			this.buttonItem18.Text = "Clustered Column";
			this.buttonItem18.Tooltip = "Clustered Column";
			// 
			// buttonItem19
			// 
			this.buttonItem19.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem19.Image")));
			this.buttonItem19.Name = "buttonItem19";
			this.buttonItem19.OptionGroup = "chart";
			this.buttonItem19.Text = "Stacked Column";
			this.buttonItem19.Tooltip = "Stacked Column";
			// 
			// labelItem2
			// 
			this.labelItem2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(235)), ((System.Byte)(235)), ((System.Byte)(235)));
			this.labelItem2.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
			this.labelItem2.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.labelItem2.Name = "labelItem2";
			this.labelItem2.PaddingBottom = 1;
			this.labelItem2.PaddingLeft = 1;
			this.labelItem2.PaddingRight = 1;
			this.labelItem2.PaddingTop = 1;
			this.labelItem2.SingleLineColor = System.Drawing.Color.FromArgb(((System.Byte)(197)), ((System.Byte)(197)), ((System.Byte)(197)));
			this.labelItem2.Text = "<b>Line</b>";
			// 
			// lineContainer
			// 
			this.lineContainer.MinimumSize = new System.Drawing.Size(0, 0);
			this.lineContainer.MultiLine = true;
			this.lineContainer.Name = "lineContainer";
			this.lineContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																							this.buttonItem20,
																							this.buttonItem21,
																							this.buttonItem22,
																							this.buttonItem23});
			// 
			// buttonItem20
			// 
			this.buttonItem20.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem20.Image")));
			this.buttonItem20.Name = "buttonItem20";
			this.buttonItem20.OptionGroup = "chart";
			this.buttonItem20.Text = "Line";
			this.buttonItem20.Tooltip = "Line";
			// 
			// buttonItem21
			// 
			this.buttonItem21.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem21.Image")));
			this.buttonItem21.Name = "buttonItem21";
			this.buttonItem21.OptionGroup = "chart";
			this.buttonItem21.Text = "Stacked Line";
			this.buttonItem21.Tooltip = "Stacked Line";
			// 
			// buttonItem22
			// 
			this.buttonItem22.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem22.Image")));
			this.buttonItem22.Name = "buttonItem22";
			this.buttonItem22.OptionGroup = "chart";
			this.buttonItem22.Text = "100% Stacked Line";
			this.buttonItem22.Tooltip = "100% Stacked Line";
			// 
			// buttonItem23
			// 
			this.buttonItem23.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem23.Image")));
			this.buttonItem23.Name = "buttonItem23";
			this.buttonItem23.OptionGroup = "chart";
			this.buttonItem23.Text = "Line With Markers";
			this.buttonItem23.Tooltip = "Line With Markers";
			// 
			// labelItem3
			// 
			this.labelItem3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(235)), ((System.Byte)(235)), ((System.Byte)(235)));
			this.labelItem3.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
			this.labelItem3.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.labelItem3.Name = "labelItem3";
			this.labelItem3.PaddingBottom = 1;
			this.labelItem3.PaddingLeft = 1;
			this.labelItem3.PaddingRight = 1;
			this.labelItem3.PaddingTop = 1;
			this.labelItem3.SingleLineColor = System.Drawing.Color.FromArgb(((System.Byte)(197)), ((System.Byte)(197)), ((System.Byte)(197)));
			this.labelItem3.Text = "<b>Pie</b>";
			// 
			// pieContainer
			// 
			this.pieContainer.MinimumSize = new System.Drawing.Size(0, 0);
			this.pieContainer.MultiLine = true;
			this.pieContainer.Name = "pieContainer";
			this.pieContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																						   this.buttonItem9,
																						   this.buttonItem10,
																						   this.buttonItem11});
			// 
			// buttonItem9
			// 
			this.buttonItem9.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem9.Image")));
			this.buttonItem9.Name = "buttonItem9";
			this.buttonItem9.OptionGroup = "chart";
			this.buttonItem9.Text = "Pie";
			this.buttonItem9.Tooltip = "Pie";
			// 
			// buttonItem10
			// 
			this.buttonItem10.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem10.Image")));
			this.buttonItem10.Name = "buttonItem10";
			this.buttonItem10.OptionGroup = "chart";
			this.buttonItem10.Text = "Pie";
			this.buttonItem10.Tooltip = "Pie";
			// 
			// buttonItem11
			// 
			this.buttonItem11.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem11.Image")));
			this.buttonItem11.Name = "buttonItem11";
			this.buttonItem11.OptionGroup = "chart";
			this.buttonItem11.Text = "Pie";
			this.buttonItem11.Tooltip = "Pie";
			// 
			// labelItem4
			// 
			this.labelItem4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(235)), ((System.Byte)(235)), ((System.Byte)(235)));
			this.labelItem4.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
			this.labelItem4.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.labelItem4.Name = "labelItem4";
			this.labelItem4.PaddingBottom = 1;
			this.labelItem4.PaddingLeft = 1;
			this.labelItem4.PaddingRight = 1;
			this.labelItem4.PaddingTop = 1;
			this.labelItem4.SingleLineColor = System.Drawing.Color.FromArgb(((System.Byte)(197)), ((System.Byte)(197)), ((System.Byte)(197)));
			this.labelItem4.Text = "<b>Bar</b>";
			// 
			// barContainer
			// 
			this.barContainer.MinimumSize = new System.Drawing.Size(0, 0);
			this.barContainer.MultiLine = true;
			this.barContainer.Name = "barContainer";
			this.barContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																						   this.buttonItem24,
																						   this.buttonItem25,
																						   this.buttonItem26,
																						   this.buttonItem27,
																						   this.buttonItem28,
																						   this.buttonItem29,
																						   this.buttonItem30});
			// 
			// buttonItem24
			// 
			this.buttonItem24.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem24.Image")));
			this.buttonItem24.Name = "buttonItem24";
			this.buttonItem24.OptionGroup = "chart";
			this.buttonItem24.Text = "Clustered Bar";
			this.buttonItem24.Tooltip = "Clustered Bar";
			// 
			// buttonItem25
			// 
			this.buttonItem25.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem25.Image")));
			this.buttonItem25.Name = "buttonItem25";
			this.buttonItem25.OptionGroup = "chart";
			this.buttonItem25.Text = "Stacked Bar";
			this.buttonItem25.Tooltip = "Stacked Bar";
			// 
			// buttonItem26
			// 
			this.buttonItem26.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem26.Image")));
			this.buttonItem26.Name = "buttonItem26";
			this.buttonItem26.OptionGroup = "chart";
			this.buttonItem26.Text = "100% Stacked Bar";
			this.buttonItem26.Tooltip = "100% Stacked Bar";
			// 
			// buttonItem27
			// 
			this.buttonItem27.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem27.Image")));
			this.buttonItem27.Name = "buttonItem27";
			this.buttonItem27.OptionGroup = "chart";
			this.buttonItem27.Text = "Clustered Bar";
			this.buttonItem27.Tooltip = "Clustered Bar";
			// 
			// buttonItem28
			// 
			this.buttonItem28.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem28.Image")));
			this.buttonItem28.Name = "buttonItem28";
			this.buttonItem28.OptionGroup = "chart";
			this.buttonItem28.Text = "Stacked Bar";
			this.buttonItem28.Tooltip = "Stacked Bar";
			// 
			// buttonItem29
			// 
			this.buttonItem29.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem29.Image")));
			this.buttonItem29.Name = "buttonItem29";
			this.buttonItem29.OptionGroup = "chart";
			this.buttonItem29.Text = "100% Stacked Bar";
			this.buttonItem29.Tooltip = "100% Stacked Bar";
			// 
			// buttonItem30
			// 
			this.buttonItem30.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem30.Image")));
			this.buttonItem30.Name = "buttonItem30";
			this.buttonItem30.OptionGroup = "chart";
			this.buttonItem30.Text = "Clustered Bar";
			this.buttonItem30.Tooltip = "Clustered Bar";
			// 
			// labelItem5
			// 
			this.labelItem5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(235)), ((System.Byte)(235)), ((System.Byte)(235)));
			this.labelItem5.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
			this.labelItem5.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.labelItem5.Name = "labelItem5";
			this.labelItem5.PaddingBottom = 1;
			this.labelItem5.PaddingLeft = 1;
			this.labelItem5.PaddingRight = 1;
			this.labelItem5.PaddingTop = 1;
			this.labelItem5.SingleLineColor = System.Drawing.Color.FromArgb(((System.Byte)(197)), ((System.Byte)(197)), ((System.Byte)(197)));
			this.labelItem5.Text = "<b>Area</b>";
			// 
			// areaContainer
			// 
			this.areaContainer.MinimumSize = new System.Drawing.Size(0, 0);
			this.areaContainer.MultiLine = true;
			this.areaContainer.Name = "areaContainer";
			this.areaContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																							this.buttonItem31,
																							this.buttonItem32,
																							this.buttonItem33});
			// 
			// buttonItem31
			// 
			this.buttonItem31.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem31.Image")));
			this.buttonItem31.Name = "buttonItem31";
			this.buttonItem31.OptionGroup = "chart";
			this.buttonItem31.Text = "Area";
			this.buttonItem31.Tooltip = "Area";
			// 
			// buttonItem32
			// 
			this.buttonItem32.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem32.Image")));
			this.buttonItem32.Name = "buttonItem32";
			this.buttonItem32.OptionGroup = "chart";
			this.buttonItem32.Text = "Stacked Area";
			this.buttonItem32.Tooltip = "Stacked Area";
			// 
			// buttonItem33
			// 
			this.buttonItem33.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem33.Image")));
			this.buttonItem33.Name = "buttonItem33";
			this.buttonItem33.OptionGroup = "chart";
			this.buttonItem33.Text = "100% Stacked Area";
			this.buttonItem33.Tooltip = "100% Stacked Area";
			// 
			// Form1
			// 
			this.AcceptButton = this.buttonX1;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.buttonX2;
			this.ClientSize = new System.Drawing.Size(562, 332);
			this.Controls.Add(this.itemPanel2);
			this.Controls.Add(this.buttonX2);
			this.Controls.Add(this.buttonX1);
			this.Controls.Add(this.chartTypes);
			this.Controls.Add(this.panelEx1);
			this.MinimumSize = new System.Drawing.Size(234, 132);
			this.Name = "Form1";
			this.Text = "Create Chart";
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

		private void buttonX1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void buttonX2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void columnSelector_Click(object sender, System.EventArgs e)
		{
			itemPanel2.EnsureVisible(columnContainer);
		}
		
		private void areaSelector_Click(object sender, System.EventArgs e)
		{
			itemPanel2.EnsureVisible(areaContainer);
		}

		private void lineSelector_Click(object sender, System.EventArgs e)
		{
			itemPanel2.EnsureVisible(lineContainer);
		}

		private void pieSelector_Click(object sender, System.EventArgs e)
		{
			itemPanel2.EnsureVisible(pieContainer);
		}

		private void barSelector_Click(object sender, System.EventArgs e)
		{
			itemPanel2.EnsureVisible(barContainer);
		}

		private void itemPanel2_ItemClick(object sender, System.EventArgs e)
		{
			if(sender is ButtonItem)
			{
				// Since chart selector buttons are in separate containers the ButtonItem.OptionGroup setting will not unselect
				// the button from another container so we need to do it here
				ButtonItem button = GetCheckedButton(itemPanel2.Items, sender as ButtonItem);
				if(button!=null)
					button.Checked = false;
			}
		}
		
		private ButtonItem GetCheckedButton(SubItemsCollection parentCollection, ButtonItem exclude)
		{
			foreach(BaseItem item in parentCollection)
			{
				if(item is ButtonItem && item!=exclude && ((ButtonItem)item).Checked)
					return item as ButtonItem;
				else if(item.IsContainer)
				{
					ButtonItem button = GetCheckedButton(item.SubItems, exclude);
					if(button!=null)
						return button;
				}
			}
			
			return null;
		}
	}
}
