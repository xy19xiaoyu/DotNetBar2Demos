using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Data;

namespace MindMapping
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		internal DevComponents.Tree.TreeGX TreeGX1;
		internal DevComponents.Tree.Node Node1;
		internal DevComponents.Tree.Node Node2;
		internal DevComponents.Tree.Node Node8;
		internal DevComponents.Tree.ElementStyle ElementStyle3;
		internal DevComponents.Tree.Node Node9;
		internal DevComponents.Tree.Node Node10;
		internal DevComponents.Tree.Node Node11;
		internal DevComponents.Tree.Node Node3;
		internal DevComponents.Tree.Node Node12;
		internal DevComponents.Tree.ElementStyle ElementStyle2;
		internal DevComponents.Tree.Node Node13;
		internal DevComponents.Tree.Node Node4;
		internal DevComponents.Tree.Node Node14;
		internal DevComponents.Tree.ElementStyle ElementStyle4;
		internal DevComponents.Tree.Node Node15;
		internal DevComponents.Tree.Node Node16;
		internal DevComponents.Tree.Node Node17;
		internal DevComponents.Tree.Node Node18;
		internal DevComponents.Tree.Node Node5;
		internal DevComponents.Tree.Node Node19;
		internal DevComponents.Tree.ElementStyle ElementStyle5;
		internal DevComponents.Tree.Node Node20;
		internal DevComponents.Tree.Node Node6;
		internal DevComponents.Tree.Node Node21;
		internal DevComponents.Tree.ElementStyle ElementStyle6;
		internal DevComponents.Tree.Node Node22;
		internal DevComponents.Tree.Node Node23;
		internal DevComponents.Tree.Node Node7;
		internal DevComponents.Tree.Node Node24;
		internal DevComponents.Tree.ElementStyle ElementStyle7;
		internal DevComponents.Tree.Node Node25;
		internal DevComponents.Tree.Node Node26;
		internal DevComponents.Tree.NodeConnector NodeConnector2;
		internal DevComponents.Tree.ElementStyle ElementStyle1;
		internal DevComponents.Tree.NodeConnector NodeConnector1;
		internal DevComponents.Tree.NodeConnector NodeConnector3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelZoom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Button buttonPrint;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
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
			this.TreeGX1 = new DevComponents.Tree.TreeGX();
			this.Node1 = new DevComponents.Tree.Node();
			this.Node2 = new DevComponents.Tree.Node();
			this.Node8 = new DevComponents.Tree.Node();
			this.ElementStyle3 = new DevComponents.Tree.ElementStyle();
			this.Node9 = new DevComponents.Tree.Node();
			this.Node10 = new DevComponents.Tree.Node();
			this.Node11 = new DevComponents.Tree.Node();
			this.Node3 = new DevComponents.Tree.Node();
			this.Node12 = new DevComponents.Tree.Node();
			this.ElementStyle2 = new DevComponents.Tree.ElementStyle();
			this.Node13 = new DevComponents.Tree.Node();
			this.Node4 = new DevComponents.Tree.Node();
			this.Node14 = new DevComponents.Tree.Node();
			this.ElementStyle4 = new DevComponents.Tree.ElementStyle();
			this.Node15 = new DevComponents.Tree.Node();
			this.Node16 = new DevComponents.Tree.Node();
			this.Node17 = new DevComponents.Tree.Node();
			this.Node18 = new DevComponents.Tree.Node();
			this.Node5 = new DevComponents.Tree.Node();
			this.Node19 = new DevComponents.Tree.Node();
			this.ElementStyle5 = new DevComponents.Tree.ElementStyle();
			this.Node20 = new DevComponents.Tree.Node();
			this.Node6 = new DevComponents.Tree.Node();
			this.Node21 = new DevComponents.Tree.Node();
			this.ElementStyle6 = new DevComponents.Tree.ElementStyle();
			this.Node22 = new DevComponents.Tree.Node();
			this.Node23 = new DevComponents.Tree.Node();
			this.Node7 = new DevComponents.Tree.Node();
			this.Node24 = new DevComponents.Tree.Node();
			this.ElementStyle7 = new DevComponents.Tree.ElementStyle();
			this.Node25 = new DevComponents.Tree.Node();
			this.Node26 = new DevComponents.Tree.Node();
			this.NodeConnector2 = new DevComponents.Tree.NodeConnector();
			this.ElementStyle1 = new DevComponents.Tree.ElementStyle();
			this.NodeConnector1 = new DevComponents.Tree.NodeConnector();
			this.NodeConnector3 = new DevComponents.Tree.NodeConnector();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.labelZoom = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.button1 = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.TreeGX1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// TreeGX1
			// 
			this.TreeGX1.AllowDrop = true;
			this.TreeGX1.AutoScrollMinSize = new System.Drawing.Size(552, 354);
			// 
			// TreeGX1.BackgroundStyle
			// 
			this.TreeGX1.BackgroundStyle.BackColor = System.Drawing.Color.Azure;
			this.TreeGX1.BackgroundStyle.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.TreeGX1.BackgroundStyle.BackColorGradientAngle = 90;
			this.TreeGX1.CellEdit = true;
			this.TreeGX1.CommandBackColorGradientAngle = 90;
			this.TreeGX1.CommandMouseOverBackColor2SchemePart = DevComponents.Tree.eColorSchemePart.ItemHotBackground2;
			this.TreeGX1.CommandMouseOverBackColorGradientAngle = 90;
			this.TreeGX1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TreeGX1.ExpandLineColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder;
			this.TreeGX1.Location = new System.Drawing.Point(0, 32);
			this.TreeGX1.Name = "TreeGX1";
			this.TreeGX1.Nodes.AddRange(new DevComponents.Tree.Node[] {
																		  this.Node1});
			this.TreeGX1.NodesConnector = this.NodeConnector2;
			this.TreeGX1.NodeStyle = this.ElementStyle1;
			this.TreeGX1.NodeVerticalSpacing = 16;
			this.TreeGX1.PathSeparator = ";";
			this.TreeGX1.RootConnector = this.NodeConnector1;
			this.TreeGX1.SelectedPathConnector = this.NodeConnector3;
			this.TreeGX1.Size = new System.Drawing.Size(520, 382);
			this.TreeGX1.Styles.Add(this.ElementStyle1);
			this.TreeGX1.Styles.Add(this.ElementStyle3);
			this.TreeGX1.Styles.Add(this.ElementStyle2);
			this.TreeGX1.Styles.Add(this.ElementStyle4);
			this.TreeGX1.Styles.Add(this.ElementStyle5);
			this.TreeGX1.Styles.Add(this.ElementStyle6);
			this.TreeGX1.Styles.Add(this.ElementStyle7);
			this.TreeGX1.SuspendPaint = false;
			this.TreeGX1.TabIndex = 1;
			this.TreeGX1.Text = "TreeGX1";
			// 
			// Node1
			// 
			this.Node1.Expanded = true;
			this.Node1.Name = "Node1";
			this.Node1.Nodes.AddRange(new DevComponents.Tree.Node[] {
																		this.Node2,
																		this.Node3,
																		this.Node4,
																		this.Node5,
																		this.Node6,
																		this.Node7});
			this.Node1.Text = "<b><font size=\"+4\">Six Hats</font></b>";
			// 
			// Node2
			// 
			this.Node2.Expanded = true;
			this.Node2.Name = "Node2";
			this.Node2.Nodes.AddRange(new DevComponents.Tree.Node[] {
																		this.Node8,
																		this.Node9,
																		this.Node10,
																		this.Node11});
			this.Node2.Style = this.ElementStyle3;
			this.Node2.Text = "Blue";
			// 
			// Node8
			// 
			this.Node8.Expanded = true;
			this.Node8.Name = "Node8";
			this.Node8.Style = this.ElementStyle3;
			this.Node8.Text = "Agenda";
			// 
			// ElementStyle3
			// 
			this.ElementStyle3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(221)), ((System.Byte)(230)), ((System.Byte)(247)));
			this.ElementStyle3.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(138)), ((System.Byte)(168)), ((System.Byte)(228)));
			this.ElementStyle3.BackColorGradientAngle = 90;
			this.ElementStyle3.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle3.BorderBottomWidth = 1;
			this.ElementStyle3.BorderColor = System.Drawing.Color.DarkGray;
			this.ElementStyle3.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle3.BorderLeftWidth = 1;
			this.ElementStyle3.BorderRight = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle3.BorderRightWidth = 1;
			this.ElementStyle3.BorderTop = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle3.BorderTopWidth = 1;
			this.ElementStyle3.CornerDiameter = 4;
			this.ElementStyle3.CornerType = DevComponents.Tree.eCornerType.Rounded;
			this.ElementStyle3.Description = "Blue";
			this.ElementStyle3.Name = "ElementStyle3";
			this.ElementStyle3.PaddingBottom = 3;
			this.ElementStyle3.PaddingLeft = 3;
			this.ElementStyle3.PaddingRight = 3;
			this.ElementStyle3.PaddingTop = 3;
			this.ElementStyle3.TextColor = System.Drawing.Color.Black;
			// 
			// Node9
			// 
			this.Node9.Expanded = true;
			this.Node9.Name = "Node9";
			this.Node9.Style = this.ElementStyle3;
			this.Node9.Text = "Decision";
			// 
			// Node10
			// 
			this.Node10.Expanded = true;
			this.Node10.Name = "Node10";
			this.Node10.Style = this.ElementStyle3;
			this.Node10.Text = "Global";
			// 
			// Node11
			// 
			this.Node11.Expanded = true;
			this.Node11.Name = "Node11";
			this.Node11.Style = this.ElementStyle3;
			this.Node11.Text = "Overview";
			// 
			// Node3
			// 
			this.Node3.Expanded = true;
			this.Node3.Name = "Node3";
			this.Node3.Nodes.AddRange(new DevComponents.Tree.Node[] {
																		this.Node12,
																		this.Node13});
			this.Node3.Style = this.ElementStyle2;
			this.Node3.Text = "Black";
			// 
			// Node12
			// 
			this.Node12.Expanded = true;
			this.Node12.Name = "Node12";
			this.Node12.Style = this.ElementStyle2;
			this.Node12.Text = "Critic";
			// 
			// ElementStyle2
			// 
			this.ElementStyle2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(77)), ((System.Byte)(108)), ((System.Byte)(152)));
			this.ElementStyle2.BackColor2 = System.Drawing.Color.Navy;
			this.ElementStyle2.BackColorGradientAngle = 90;
			this.ElementStyle2.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle2.BorderBottomWidth = 1;
			this.ElementStyle2.BorderColor = System.Drawing.Color.Navy;
			this.ElementStyle2.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle2.BorderLeftWidth = 1;
			this.ElementStyle2.BorderRight = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle2.BorderRightWidth = 1;
			this.ElementStyle2.BorderTop = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle2.BorderTopWidth = 1;
			this.ElementStyle2.CornerDiameter = 4;
			this.ElementStyle2.CornerType = DevComponents.Tree.eCornerType.Rounded;
			this.ElementStyle2.Description = "BlueNight";
			this.ElementStyle2.Name = "ElementStyle2";
			this.ElementStyle2.PaddingBottom = 3;
			this.ElementStyle2.PaddingLeft = 3;
			this.ElementStyle2.PaddingRight = 3;
			this.ElementStyle2.PaddingTop = 3;
			this.ElementStyle2.TextColor = System.Drawing.Color.White;
			// 
			// Node13
			// 
			this.Node13.Expanded = true;
			this.Node13.Name = "Node13";
			this.Node13.Style = this.ElementStyle2;
			this.Node13.Text = "Analyst";
			// 
			// Node4
			// 
			this.Node4.Expanded = true;
			this.Node4.Name = "Node4";
			this.Node4.Nodes.AddRange(new DevComponents.Tree.Node[] {
																		this.Node14,
																		this.Node15,
																		this.Node16,
																		this.Node18});
			this.Node4.Style = this.ElementStyle4;
			this.Node4.Text = "<font color=\"maroon\" size=\"+2\"><b>Red</b></font>";
			// 
			// Node14
			// 
			this.Node14.Expanded = true;
			this.Node14.Name = "Node14";
			this.Node14.Style = this.ElementStyle4;
			this.Node14.Text = "Emotions";
			// 
			// ElementStyle4
			// 
			this.ElementStyle4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(249)), ((System.Byte)(225)), ((System.Byte)(226)));
			this.ElementStyle4.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(238)), ((System.Byte)(149)), ((System.Byte)(151)));
			this.ElementStyle4.BackColorGradientAngle = 90;
			this.ElementStyle4.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle4.BorderBottomWidth = 1;
			this.ElementStyle4.BorderColor = System.Drawing.Color.DarkGray;
			this.ElementStyle4.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle4.BorderLeftWidth = 1;
			this.ElementStyle4.BorderRight = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle4.BorderRightWidth = 1;
			this.ElementStyle4.BorderTop = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle4.BorderTopWidth = 1;
			this.ElementStyle4.CornerDiameter = 4;
			this.ElementStyle4.CornerType = DevComponents.Tree.eCornerType.Rounded;
			this.ElementStyle4.Description = "Red";
			this.ElementStyle4.Name = "ElementStyle4";
			this.ElementStyle4.PaddingBottom = 3;
			this.ElementStyle4.PaddingLeft = 3;
			this.ElementStyle4.PaddingRight = 3;
			this.ElementStyle4.PaddingTop = 3;
			this.ElementStyle4.TextColor = System.Drawing.Color.Black;
			// 
			// Node15
			// 
			this.Node15.Expanded = true;
			this.Node15.Name = "Node15";
			this.Node15.Style = this.ElementStyle4;
			this.Node15.Text = "Hunches";
			// 
			// Node16
			// 
			this.Node16.Expanded = true;
			this.Node16.Name = "Node16";
			this.Node16.Nodes.AddRange(new DevComponents.Tree.Node[] {
																		 this.Node17});
			this.Node16.Style = this.ElementStyle4;
			this.Node16.Text = "Feelings";
			// 
			// Node17
			// 
			this.Node17.Expanded = true;
			this.Node17.Name = "Node17";
			this.Node17.Style = this.ElementStyle4;
			this.Node17.Text = "Gut";
			// 
			// Node18
			// 
			this.Node18.Expanded = true;
			this.Node18.Name = "Node18";
			this.Node18.Style = this.ElementStyle4;
			this.Node18.Text = "Instincts";
			// 
			// Node5
			// 
			this.Node5.Expanded = true;
			this.Node5.Name = "Node5";
			this.Node5.Nodes.AddRange(new DevComponents.Tree.Node[] {
																		this.Node19,
																		this.Node20});
			this.Node5.Style = this.ElementStyle5;
			this.Node5.Text = "<div align=\"center\">Yellow<br/><a href=\"http://www.treegx.com\" name=\"TreeGXHomePa" +
				"ge\">Path</a></div>";
			this.Node5.MarkupLinkClick += new DevComponents.Tree.MarkupLinkClickEventHandler(this.Node5_MarkupLinkClick);
			// 
			// Node19
			// 
			this.Node19.Expanded = true;
			this.Node19.Name = "Node19";
			this.Node19.Style = this.ElementStyle5;
			this.Node19.Text = "Logical";
			// 
			// ElementStyle5
			// 
			this.ElementStyle5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(244)), ((System.Byte)(213)));
			this.ElementStyle5.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(216)), ((System.Byte)(105)));
			this.ElementStyle5.BackColorGradientAngle = 90;
			this.ElementStyle5.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle5.BorderBottomWidth = 1;
			this.ElementStyle5.BorderColor = System.Drawing.Color.DarkGray;
			this.ElementStyle5.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle5.BorderLeftWidth = 1;
			this.ElementStyle5.BorderRight = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle5.BorderRightWidth = 1;
			this.ElementStyle5.BorderTop = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle5.BorderTopWidth = 1;
			this.ElementStyle5.CornerDiameter = 4;
			this.ElementStyle5.CornerType = DevComponents.Tree.eCornerType.Rounded;
			this.ElementStyle5.Description = "Yellow";
			this.ElementStyle5.Name = "ElementStyle5";
			this.ElementStyle5.PaddingBottom = 3;
			this.ElementStyle5.PaddingLeft = 3;
			this.ElementStyle5.PaddingRight = 3;
			this.ElementStyle5.PaddingTop = 3;
			this.ElementStyle5.TextColor = System.Drawing.Color.Black;
			// 
			// Node20
			// 
			this.Node20.Expanded = true;
			this.Node20.Name = "Node20";
			this.Node20.Style = this.ElementStyle5;
			this.Node20.Text = "Positive";
			// 
			// Node6
			// 
			this.Node6.Expanded = true;
			this.Node6.Name = "Node6";
			this.Node6.Nodes.AddRange(new DevComponents.Tree.Node[] {
																		this.Node21,
																		this.Node22,
																		this.Node23});
			this.Node6.Style = this.ElementStyle6;
			this.Node6.Text = "Green";
			// 
			// Node21
			// 
			this.Node21.Expanded = true;
			this.Node21.Name = "Node21";
			this.Node21.Style = this.ElementStyle6;
			this.Node21.Text = "Creative";
			// 
			// ElementStyle6
			// 
			this.ElementStyle6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(234)), ((System.Byte)(240)), ((System.Byte)(226)));
			this.ElementStyle6.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(183)), ((System.Byte)(201)), ((System.Byte)(151)));
			this.ElementStyle6.BackColorGradientAngle = 90;
			this.ElementStyle6.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle6.BorderBottomWidth = 1;
			this.ElementStyle6.BorderColor = System.Drawing.Color.DarkGray;
			this.ElementStyle6.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle6.BorderLeftWidth = 1;
			this.ElementStyle6.BorderRight = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle6.BorderRightWidth = 1;
			this.ElementStyle6.BorderTop = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle6.BorderTopWidth = 1;
			this.ElementStyle6.CornerDiameter = 4;
			this.ElementStyle6.CornerType = DevComponents.Tree.eCornerType.Rounded;
			this.ElementStyle6.Description = "Green";
			this.ElementStyle6.Name = "ElementStyle6";
			this.ElementStyle6.PaddingBottom = 3;
			this.ElementStyle6.PaddingLeft = 3;
			this.ElementStyle6.PaddingRight = 3;
			this.ElementStyle6.PaddingTop = 3;
			this.ElementStyle6.TextColor = System.Drawing.Color.Black;
			// 
			// Node22
			// 
			this.Node22.Expanded = true;
			this.Node22.Name = "Node22";
			this.Node22.Style = this.ElementStyle6;
			this.Node22.Text = "Growth";
			// 
			// Node23
			// 
			this.Node23.Expanded = true;
			this.Node23.Name = "Node23";
			this.Node23.Style = this.ElementStyle6;
			this.Node23.Text = "Ideas";
			// 
			// Node7
			// 
			this.Node7.Expanded = true;
			this.Node7.Name = "Node7";
			this.Node7.Nodes.AddRange(new DevComponents.Tree.Node[] {
																		this.Node24,
																		this.Node25,
																		this.Node26});
			this.Node7.Style = this.ElementStyle7;
			this.Node7.Text = "White";
			// 
			// Node24
			// 
			this.Node24.Expanded = true;
			this.Node24.Name = "Node24";
			this.Node24.Style = this.ElementStyle7;
			this.Node24.Text = "Facts";
			// 
			// ElementStyle7
			// 
			this.ElementStyle7.Description = "White";
			this.ElementStyle7.Name = "ElementStyle7";
			this.ElementStyle7.TextColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			// 
			// Node25
			// 
			this.Node25.Expanded = true;
			this.Node25.Name = "Node25";
			this.Node25.Style = this.ElementStyle7;
			this.Node25.Text = "Data";
			// 
			// Node26
			// 
			this.Node26.Expanded = true;
			this.Node26.Name = "Node26";
			this.Node26.Style = this.ElementStyle7;
			this.Node26.Text = "Figures";
			// 
			// NodeConnector2
			// 
			this.NodeConnector2.LineWidth = 5;
			// 
			// ElementStyle1
			// 
			this.ElementStyle1.BackColor2SchemePart = DevComponents.Tree.eColorSchemePart.BarBackground2;
			this.ElementStyle1.BackColorGradientAngle = 90;
			this.ElementStyle1.BackColorSchemePart = DevComponents.Tree.eColorSchemePart.BarBackground;
			this.ElementStyle1.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle1.BorderBottomWidth = 1;
			this.ElementStyle1.BorderColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder;
			this.ElementStyle1.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle1.BorderLeftWidth = 1;
			this.ElementStyle1.BorderRight = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle1.BorderRightWidth = 1;
			this.ElementStyle1.BorderTop = DevComponents.Tree.eStyleBorderType.Solid;
			this.ElementStyle1.BorderTopWidth = 1;
			this.ElementStyle1.CornerDiameter = 4;
			this.ElementStyle1.CornerType = DevComponents.Tree.eCornerType.Rounded;
			this.ElementStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ElementStyle1.Name = "ElementStyle1";
			this.ElementStyle1.PaddingBottom = 3;
			this.ElementStyle1.PaddingLeft = 3;
			this.ElementStyle1.PaddingRight = 3;
			this.ElementStyle1.PaddingTop = 3;
			this.ElementStyle1.TextColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			// 
			// NodeConnector1
			// 
			this.NodeConnector1.LineWidth = 5;
			// 
			// NodeConnector3
			// 
			this.NodeConnector3.LineColor = System.Drawing.Color.Goldenrod;
			this.NodeConnector3.LineWidth = 5;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.buttonPrint);
			this.panel1.Controls.Add(this.labelZoom);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.trackBar1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(520, 32);
			this.panel1.TabIndex = 2;
			// 
			// buttonPrint
			// 
			this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonPrint.Location = new System.Drawing.Point(8, 4);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(56, 22);
			this.buttonPrint.TabIndex = 3;
			this.buttonPrint.Text = "Print";
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// labelZoom
			// 
			this.labelZoom.Location = new System.Drawing.Point(178, 8);
			this.labelZoom.Name = "labelZoom";
			this.labelZoom.Size = new System.Drawing.Size(37, 15);
			this.labelZoom.TabIndex = 2;
			this.labelZoom.Text = "100%";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(143, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Zoom: ";
			// 
			// trackBar1
			// 
			this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.trackBar1.AutoSize = false;
			this.trackBar1.LargeChange = 50;
			this.trackBar1.Location = new System.Drawing.Point(216, 4);
			this.trackBar1.Maximum = 400;
			this.trackBar1.Minimum = 20;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(300, 24);
			this.trackBar1.SmallChange = 10;
			this.trackBar1.TabIndex = 0;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBar1.Value = 100;
			this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Document = this.printDocument1;
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Location = new System.Drawing.Point(98, 106);
			this.printPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
			this.printPreviewDialog1.UseAntiAlias = true;
			this.printPreviewDialog1.Visible = false;
			// 
			// printDocument1
			// 
			this.printDocument1.OriginAtMargins = true;
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(70, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(69, 22);
			this.button1.TabIndex = 4;
			this.button1.Text = "Save Image";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "png";
			this.saveFileDialog1.Filter = "PNG Files | *.png";
			this.saveFileDialog1.Title = "Save TreeGX control content to image";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(520, 414);
			this.Controls.Add(this.TreeGX1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Six Thinking Hats";
			((System.ComponentModel.ISupportInitialize)(this.TreeGX1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.DoEvents();
			Application.Run(new Form1());
		}

		private void trackBar1_ValueChanged(object sender, System.EventArgs e)
		{
			TreeGX1.Zoom=(float)trackBar1.Value/100;
			labelZoom.Text=trackBar1.Value.ToString()+"%";
		}

		private void buttonPrint_Click(object sender, System.EventArgs e)
		{
			printPreviewDialog1.Bounds = this.Bounds;
			printPreviewDialog1.ShowDialog();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			// Center tree on the page
			Point p =
				new Point((e.PageBounds.Width - TreeGX1.TreeSize.Width) / 2, (e.PageBounds.Height - TreeGX1.TreeSize.Height) / 2);
			if(p.X>0 && p.Y>0)
			{
				e.Graphics.TranslateTransform(p.X, p.Y, MatrixOrder.Append);
			}
			
			// Perform actual rendering
			TreeGX1.PaintTo(e.Graphics, false, e.PageBounds);
		}

		private void Node5_MarkupLinkClick(object sender, DevComponents.Tree.MarkupLinkClickEventArgs e)
		{
			System.Diagnostics.Trace.WriteLine("MarkupLinkClick event. Link name: " + e.Name +" : href=" + e.HRef);
			if(e.HRef.StartsWith("http://"))
				System.Diagnostics.Process.Start(e.HRef);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				using(Bitmap bmp = new Bitmap(TreeGX1.TreeSize.Width, TreeGX1.TreeSize.Height))
				{
					using(Graphics g = Graphics.FromImage(bmp))
					{
						// Perform actual rendering
						TreeGX1.PaintTo(g, true, Rectangle.Empty);
					}

					bmp.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
				}
			}
		}
	}
}
