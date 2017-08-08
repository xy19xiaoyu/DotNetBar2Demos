using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;

namespace TabControl
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevComponents.DotNetBar.TabControl tabControl1;
		private DevComponents.DotNetBar.TabItem tabItem1;
		private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
		private DevComponents.DotNetBar.TabItem tabItem2;
		private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
		private DevComponents.DotNetBar.TabItem tabItem3;
		private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
		private DevComponents.DotNetBar.PanelEx panelEx1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private DevComponents.DotNetBar.PanelEx panelEx2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.RichTextBox richTextBox3;
		private DevComponents.DotNetBar.PanelEx panelEx3;
		private System.Windows.Forms.Label label2;
		private DevComponents.DotNetBar.PanelEx panelEx4;
		private System.Windows.Forms.RichTextBox richTextBox4;
		private System.Windows.Forms.RichTextBox richTextBox5;
		private DevComponents.DotNetBar.PanelEx panelEx5;
		private System.Windows.Forms.Label label3;
		private DevComponents.DotNetBar.PanelEx panelEx6;
		private System.Windows.Forms.RichTextBox richTextBox6;
		private DevComponents.DotNetBar.ItemPanel itemPanel1;
		private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
		private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			tabControl1.TabStrip.MouseDown+=new MouseEventHandler(this.tabControl1_MouseDown);
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
			this.tabControl1 = new DevComponents.DotNetBar.TabControl();
			this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
			this.label1 = new System.Windows.Forms.Label();
			this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
			this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
			this.richTextBox5 = new System.Windows.Forms.RichTextBox();
			this.panelEx5 = new DevComponents.DotNetBar.PanelEx();
			this.label3 = new System.Windows.Forms.Label();
			this.panelEx6 = new DevComponents.DotNetBar.PanelEx();
			this.richTextBox6 = new System.Windows.Forms.RichTextBox();
			this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
			this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
			this.label2 = new System.Windows.Forms.Label();
			this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
			this.richTextBox4 = new System.Windows.Forms.RichTextBox();
			this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
			this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
			this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
			this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
			((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabControlPanel1.SuspendLayout();
			this.panelEx1.SuspendLayout();
			this.panelEx2.SuspendLayout();
			this.tabControlPanel3.SuspendLayout();
			this.panelEx5.SuspendLayout();
			this.panelEx6.SuspendLayout();
			this.tabControlPanel2.SuspendLayout();
			this.panelEx3.SuspendLayout();
			this.panelEx4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.CanReorderTabs = true;
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabControlPanel1,
																					  this.tabControlPanel3,
																					  this.tabControlPanel2});
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(128, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.tabControl1.SelectedTabIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(368, 286);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
			this.tabControl1.Tabs.Add(this.tabItem1);
			this.tabControl1.Tabs.Add(this.tabItem2);
			this.tabControl1.Tabs.Add(this.tabItem3);
			// 
			// tabControlPanel1
			// 
			this.tabControlPanel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.richTextBox1,
																						   this.panelEx1});
			this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlPanel1.DockPadding.All = 1;
			this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
			this.tabControlPanel1.Name = "tabControlPanel1";
			this.tabControlPanel1.Size = new System.Drawing.Size(368, 260);
			this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(142)), ((System.Byte)(179)), ((System.Byte)(231)));
			this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(237)), ((System.Byte)(254)));
			this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((System.Byte)(59)), ((System.Byte)(97)), ((System.Byte)(156)));
			this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
				| DevComponents.DotNetBar.eBorderSide.Bottom);
			this.tabControlPanel1.Style.GradientAngle = 90;
			this.tabControlPanel1.TabIndex = 1;
			this.tabControlPanel1.TabItem = this.tabItem1;
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(1, 56);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(366, 203);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "OneNote style on new tab control has 16 predefined  color styles for tabs includi" +
				"ng default style that is based on system colors. This sample project is 100% con" +
				"structed using DotNetBar design-time interface. Right-click tabs to change their" +
				" color.";
			this.richTextBox1.ZoomFactor = 1.199854F;
			// 
			// panelEx1
			// 
			this.panelEx1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.label1,
																				   this.panelEx2});
			this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelEx1.Location = new System.Drawing.Point(1, 1);
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new System.Drawing.Size(366, 55);
			this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(221)), ((System.Byte)(230)), ((System.Byte)(247)));
			this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gray;
			this.label1.Location = new System.Drawing.Point(8, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 14);
			this.label1.TabIndex = 1;
			this.label1.Text = "Title";
			// 
			// panelEx2
			// 
			this.panelEx2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.richTextBox2});
			this.panelEx2.DockPadding.All = 6;
			this.panelEx2.Location = new System.Drawing.Point(8, 8);
			this.panelEx2.Name = "panelEx2";
			this.panelEx2.Size = new System.Drawing.Size(192, 32);
			this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.White;
			this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx2.Style.BorderColor.Color = System.Drawing.Color.Gray;
			this.panelEx2.Style.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.panelEx2.Style.CornerDiameter = 5;
			this.panelEx2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
			this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx2.Style.GradientAngle = 90;
			this.panelEx2.TabIndex = 0;
			this.panelEx2.Text = "panelEx2";
			// 
			// richTextBox2
			// 
			this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.richTextBox2.Location = new System.Drawing.Point(6, 6);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.richTextBox2.Size = new System.Drawing.Size(180, 20);
			this.richTextBox2.TabIndex = 0;
			this.richTextBox2.Text = "DotNetBar";
			// 
			// tabItem1
			// 
			this.tabItem1.AttachedControl = this.tabControlPanel1;
			this.tabItem1.Name = "tabItem1";
			this.tabItem1.Text = "&General";
			// 
			// tabControlPanel3
			// 
			this.tabControlPanel3.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.richTextBox5,
																						   this.panelEx5});
			this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlPanel3.DockPadding.All = 1;
			this.tabControlPanel3.Location = new System.Drawing.Point(0, 26);
			this.tabControlPanel3.Name = "tabControlPanel3";
			this.tabControlPanel3.Size = new System.Drawing.Size(368, 260);
			this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(232)), ((System.Byte)(248)), ((System.Byte)(224)));
			this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((System.Byte)(173)), ((System.Byte)(231)), ((System.Byte)(146)));
			this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((System.Byte)(59)), ((System.Byte)(97)), ((System.Byte)(156)));
			this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
				| DevComponents.DotNetBar.eBorderSide.Bottom);
			this.tabControlPanel3.Style.GradientAngle = -90;
			this.tabControlPanel3.TabIndex = 3;
			this.tabControlPanel3.TabItem = this.tabItem3;
			// 
			// richTextBox5
			// 
			this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.richTextBox5.Location = new System.Drawing.Point(1, 56);
			this.richTextBox5.Name = "richTextBox5";
			this.richTextBox5.Size = new System.Drawing.Size(366, 203);
			this.richTextBox5.TabIndex = 3;
			this.richTextBox5.Text = "TabStrip control implements all styling capabilities of Tab control including One" +
				"Note style. Take a look at modified Notepad sample for an example of TabStrip co" +
				"ntrol using OneNote style for MDI child for navigation.";
			this.richTextBox5.ZoomFactor = 1.199854F;
			// 
			// panelEx5
			// 
			this.panelEx5.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.label3,
																				   this.panelEx6});
			this.panelEx5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelEx5.Location = new System.Drawing.Point(1, 1);
			this.panelEx5.Name = "panelEx5";
			this.panelEx5.Size = new System.Drawing.Size(366, 55);
			this.panelEx5.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx5.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(232)), ((System.Byte)(248)), ((System.Byte)(224)));
			this.panelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx5.Style.GradientAngle = 90;
			this.panelEx5.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Gray;
			this.label3.Location = new System.Drawing.Point(8, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 14);
			this.label3.TabIndex = 1;
			this.label3.Text = "Title";
			// 
			// panelEx6
			// 
			this.panelEx6.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.richTextBox6});
			this.panelEx6.DockPadding.All = 1;
			this.panelEx6.Location = new System.Drawing.Point(8, 8);
			this.panelEx6.Name = "panelEx6";
			this.panelEx6.Size = new System.Drawing.Size(192, 32);
			this.panelEx6.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx6.Style.BackColor1.Color = System.Drawing.Color.White;
			this.panelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx6.Style.BorderColor.Color = System.Drawing.Color.Gray;
			this.panelEx6.Style.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.panelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx6.Style.GradientAngle = 90;
			this.panelEx6.TabIndex = 0;
			this.panelEx6.Text = "panelEx2";
			// 
			// richTextBox6
			// 
			this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.richTextBox6.Location = new System.Drawing.Point(1, 1);
			this.richTextBox6.Name = "richTextBox6";
			this.richTextBox6.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.richTextBox6.Size = new System.Drawing.Size(190, 30);
			this.richTextBox6.TabIndex = 0;
			this.richTextBox6.Text = "TabStrip Control";
			// 
			// tabItem3
			// 
			this.tabItem3.AttachedControl = this.tabControlPanel3;
			this.tabItem3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(232)), ((System.Byte)(248)), ((System.Byte)(224)));
			this.tabItem3.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(173)), ((System.Byte)(231)), ((System.Byte)(146)));
			this.tabItem3.Name = "tabItem3";
			this.tabItem3.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Apple;
			this.tabItem3.Text = "Project &B";
			// 
			// tabControlPanel2
			// 
			this.tabControlPanel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.richTextBox3,
																						   this.panelEx3});
			this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlPanel2.DockPadding.All = 1;
			this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
			this.tabControlPanel2.Name = "tabControlPanel2";
			this.tabControlPanel2.Size = new System.Drawing.Size(368, 260);
			this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(244)), ((System.Byte)(213)));
			this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(216)), ((System.Byte)(105)));
			this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((System.Byte)(59)), ((System.Byte)(97)), ((System.Byte)(156)));
			this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
				| DevComponents.DotNetBar.eBorderSide.Bottom);
			this.tabControlPanel2.Style.GradientAngle = -90;
			this.tabControlPanel2.TabIndex = 2;
			this.tabControlPanel2.TabItem = this.tabItem2;
			// 
			// richTextBox3
			// 
			this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.richTextBox3.Location = new System.Drawing.Point(1, 56);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(366, 203);
			this.richTextBox3.TabIndex = 3;
			this.richTextBox3.Text = "The style power in tab panels comes directly from PanelEx control. PanelEx contro" +
				"l is a multi-functional container control with powerful visual control.";
			this.richTextBox3.ZoomFactor = 1.199854F;
			// 
			// panelEx3
			// 
			this.panelEx3.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.label2,
																				   this.panelEx4});
			this.panelEx3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelEx3.Location = new System.Drawing.Point(1, 1);
			this.panelEx3.Name = "panelEx3";
			this.panelEx3.Size = new System.Drawing.Size(366, 55);
			this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(244)), ((System.Byte)(213)));
			this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx3.Style.GradientAngle = 90;
			this.panelEx3.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Gray;
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 14);
			this.label2.TabIndex = 1;
			this.label2.Text = "Title";
			// 
			// panelEx4
			// 
			this.panelEx4.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.richTextBox4});
			this.panelEx4.DockPadding.All = 1;
			this.panelEx4.Location = new System.Drawing.Point(8, 8);
			this.panelEx4.Name = "panelEx4";
			this.panelEx4.Size = new System.Drawing.Size(192, 32);
			this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx4.Style.BackColor1.Color = System.Drawing.Color.White;
			this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx4.Style.BorderColor.Color = System.Drawing.Color.Gray;
			this.panelEx4.Style.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx4.Style.GradientAngle = 90;
			this.panelEx4.TabIndex = 0;
			this.panelEx4.Text = "panelEx2";
			// 
			// richTextBox4
			// 
			this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.richTextBox4.Location = new System.Drawing.Point(1, 1);
			this.richTextBox4.Name = "richTextBox4";
			this.richTextBox4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.richTextBox4.Size = new System.Drawing.Size(190, 30);
			this.richTextBox4.TabIndex = 0;
			this.richTextBox4.Text = "PanelEx Control";
			// 
			// tabItem2
			// 
			this.tabItem2.AttachedControl = this.tabControlPanel2;
			this.tabItem2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(244)), ((System.Byte)(213)));
			this.tabItem2.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(216)), ((System.Byte)(105)));
			this.tabItem2.Name = "tabItem2";
			this.tabItem2.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Yellow;
			this.tabItem2.Text = "Project &A";
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
			this.itemPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.itemPanel1.Name = "itemPanel1";
			this.itemPanel1.Size = new System.Drawing.Size(120, 286);
			this.itemPanel1.TabIndex = 5;
			this.itemPanel1.Text = "itemPanel1";
			this.itemPanel1.ItemClick += new System.EventHandler(this.itemPanel1_ItemClick);
			// 
			// expandableSplitter1
			// 
			this.expandableSplitter1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
			this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(101)), ((System.Byte)(147)), ((System.Byte)(207)));
			this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.expandableSplitter1.ExpandableControl = this.itemPanel1;
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
			this.expandableSplitter1.Location = new System.Drawing.Point(120, 0);
			this.expandableSplitter1.Name = "expandableSplitter1";
			this.expandableSplitter1.Size = new System.Drawing.Size(8, 286);
			this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
			this.expandableSplitter1.TabIndex = 6;
			this.expandableSplitter1.TabStop = false;
			// 
			// contextMenuBar1
			// 
			this.contextMenuBar1.Location = new System.Drawing.Point(56, 240);
			this.contextMenuBar1.Name = "contextMenuBar1";
			this.contextMenuBar1.Size = new System.Drawing.Size(75, 25);
			this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
			this.contextMenuBar1.TabIndex = 7;
			this.contextMenuBar1.TabStop = false;
			this.contextMenuBar1.Text = "contextMenuBar1";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(496, 286);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.contextMenuBar1,
																		  this.tabControl1,
																		  this.expandableSplitter1,
																		  this.itemPanel1});
			this.MinimumSize = new System.Drawing.Size(360, 250);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabControlPanel1.ResumeLayout(false);
			this.panelEx1.ResumeLayout(false);
			this.panelEx2.ResumeLayout(false);
			this.tabControlPanel3.ResumeLayout(false);
			this.panelEx5.ResumeLayout(false);
			this.panelEx6.ResumeLayout(false);
			this.tabControlPanel2.ResumeLayout(false);
			this.panelEx3.ResumeLayout(false);
			this.panelEx4.ResumeLayout(false);
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

		private TabItem m_TabMouseDown=null;
		private void tabControl1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button!=MouseButtons.Right)
				return;

			// Convert to screen based coordinates for context menu
			Point p=new Point(e.X,e.Y);
			Point pScreen=tabControl1.PointToScreen(p);
			TabItem tab=tabControl1.TabStrip.HitTest(p.X,p.Y);
			if(tab!=null)
			{
				m_TabMouseDown=tab;
				CreateContextMenu();

				ButtonItem item=contextMenuBar1.Items["tabColors"] as ButtonItem;
				item.Popup(pScreen);
			}
		}

		private void CreateContextMenu()
		{
			if(contextMenuBar1.Items.Contains("tabColors"))
				return;

			ButtonItem item=new ButtonItem("tabColors","Tab Colors Context menu");
			item.Style=eDotNetBarStyle.Office2003;
			contextMenuBar1.Items.Add(item);

			// Create one menu item for each entry in eTabItemColor
			string[] names=Enum.GetNames(typeof(eTabItemColor));
			foreach(string s in names)
			{
				ButtonItem menuItem=new ButtonItem(s,s);
				// Construct the image for the menu item
				TabItem tabTemp=new TabItem();
				tabTemp.PredefinedColor=(eTabItemColor)Enum.Parse(typeof(eTabItemColor),s);
				Bitmap bmp=new Bitmap(16,16,System.Drawing.Imaging.PixelFormat.Format24bppRgb);
				Graphics g=Graphics.FromImage(bmp);
				try
				{
					g.Clear(SystemColors.Control);
					Rectangle r=new Rectangle(1,1,14,14);
					using(System.Drawing.Drawing2D.LinearGradientBrush brush=new System.Drawing.Drawing2D.LinearGradientBrush(r,tabTemp.BackColor,tabTemp.BackColor2,tabTemp.BackColorGradientAngle))
						g.FillRectangle(brush,r);
					using(Pen pen=new Pen(Color.DarkGray,1))
						g.DrawRectangle(pen,r);
				}
				finally
				{
					g.Dispose();
				}
				bmp.MakeTransparent(SystemColors.Control);
				menuItem.Image=bmp;
				menuItem.Click+=new EventHandler(this.ChangeTabColor);
				item.SubItems.Add(menuItem);
			}
		}

		private void ChangeTabColor(object sender, EventArgs e)
		{
			if(m_TabMouseDown!=null)
			{
				m_TabMouseDown.PredefinedColor=(eTabItemColor)Enum.Parse(typeof(eTabItemColor),((BaseItem)sender).Text);
			}
		}

		private void SetTabStyle(eTabStripStyle style)
		{
			tabControl1.Style=style;
			foreach(TabItem tab in tabControl1.Tabs)
				tab.PredefinedColor=eTabItemColor.Default;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// Load all tab control styles into the ItemPanel
			string[] tabStyles = Enum.GetNames(typeof(eTabStripStyle));

			itemPanel1.BeginUpdate();
			foreach(string style in tabStyles)
			{
				ButtonItem button = new ButtonItem(style, style);
				button.OptionGroup = "TabStyle"; // This provides automatic Checked property management.
				itemPanel1.Items.Add(button);
				if(style == tabControl1.Style.ToString())
					button.Checked = true;
			}
			itemPanel1.EndUpdate();
		}

		private void itemPanel1_ItemClick(object sender, System.EventArgs e)
		{
			ButtonItem button = sender as ButtonItem;
			if(button==null)
				return;

			eTabStripStyle style = (eTabStripStyle)Enum.Parse(typeof(eTabStripStyle), button.Name);
			SetTabStyle(style);
			itemPanel1.RecalcLayout();
		}
	}
}
