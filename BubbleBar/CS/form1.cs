using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BubbleBar
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevComponents.DotNetBar.BubbleBar bubbleBar1;
		private DevComponents.DotNetBar.BubbleBarTab bubbleBarTab1;
		private DevComponents.DotNetBar.BubbleButton bubbleButton1;
		private DevComponents.DotNetBar.BubbleBarTab bubbleBarTab2;
		private DevComponents.DotNetBar.BubbleButton bubbleButton2;
		private DevComponents.DotNetBar.BubbleButton bubbleButton3;
		private DevComponents.DotNetBar.BubbleButton bubbleButton4;
		private DevComponents.DotNetBar.BubbleButton bubbleButton5;
		private DevComponents.DotNetBar.BubbleButton bubbleButton6;
		private DevComponents.DotNetBar.BubbleButton bubbleButton7;
		private DevComponents.DotNetBar.BubbleButton bubbleButton8;
		private DevComponents.DotNetBar.BubbleButton bubbleButton9;
		private DevComponents.DotNetBar.BubbleButton bubbleButton10;
		private DevComponents.DotNetBar.BubbleButton bubbleButton11;
		private DevComponents.DotNetBar.BubbleButton bubbleButton12;
		private DevComponents.DotNetBar.BubbleButton bubbleButton13;
		private DevComponents.DotNetBar.BubbleButton bubbleButton14;
		private DevComponents.DotNetBar.BubbleButton bubbleButton15;
		private DevComponents.DotNetBar.BubbleButton bubbleButton16;
		private DevComponents.DotNetBar.BubbleButton bubbleButton17;
		private DevComponents.DotNetBar.BubbleButton bubbleButton18;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private DevComponents.DotNetBar.PanelEx panelEx1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
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
			this.bubbleBar1 = new DevComponents.DotNetBar.BubbleBar();
			this.bubbleBarTab1 = new DevComponents.DotNetBar.BubbleBarTab(this.components);
			this.bubbleButton4 = new DevComponents.DotNetBar.BubbleButton();
			this.bubbleButton3 = new DevComponents.DotNetBar.BubbleButton();
			this.bubbleButton1 = new DevComponents.DotNetBar.BubbleButton();
			this.bubbleButton2 = new DevComponents.DotNetBar.BubbleButton();
			this.bubbleButton5 = new DevComponents.DotNetBar.BubbleButton();
			this.bubbleButton6 = new DevComponents.DotNetBar.BubbleButton();
			this.bubbleButton10 = new DevComponents.DotNetBar.BubbleButton();
			this.bubbleButton8 = new DevComponents.DotNetBar.BubbleButton();
			this.bubbleButton9 = new DevComponents.DotNetBar.BubbleButton();
			this.bubbleButton7 = new DevComponents.DotNetBar.BubbleButton();
			this.bubbleBarTab2 = new DevComponents.DotNetBar.BubbleBarTab(this.components);
			this.bubbleButton11 = new DevComponents.DotNetBar.BubbleButton();
			this.bubbleButton12 = new DevComponents.DotNetBar.BubbleButton();
			this.bubbleButton13 = new DevComponents.DotNetBar.BubbleButton();
			this.bubbleButton14 = new DevComponents.DotNetBar.BubbleButton();
			this.bubbleButton15 = new DevComponents.DotNetBar.BubbleButton();
			this.bubbleButton16 = new DevComponents.DotNetBar.BubbleButton();
			this.bubbleButton17 = new DevComponents.DotNetBar.BubbleButton();
			this.bubbleButton18 = new DevComponents.DotNetBar.BubbleButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).BeginInit();
			this.panelEx1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// bubbleBar1
			// 
			this.bubbleBar1.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
			this.bubbleBar1.AntiAlias = true;
			this.bubbleBar1.BackColor = System.Drawing.Color.Transparent;
			// 
			// bubbleBar1.ButtonBackAreaStyle
			// 
			this.bubbleBar1.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(66)), ((System.Byte)(105)), ((System.Byte)(105)), ((System.Byte)(105)));
			this.bubbleBar1.ButtonBackAreaStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Tile;
			this.bubbleBar1.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.bubbleBar1.ButtonBackAreaStyle.BorderBottomWidth = 1;
			this.bubbleBar1.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(245)), ((System.Byte)(245)), ((System.Byte)(245)));
			this.bubbleBar1.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.bubbleBar1.ButtonBackAreaStyle.BorderLeftWidth = 1;
			this.bubbleBar1.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.bubbleBar1.ButtonBackAreaStyle.BorderRightWidth = 1;
			this.bubbleBar1.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.bubbleBar1.ButtonBackAreaStyle.BorderTopWidth = 1;
			this.bubbleBar1.ButtonBackAreaStyle.PaddingBottom = 3;
			this.bubbleBar1.ButtonBackAreaStyle.PaddingLeft = 3;
			this.bubbleBar1.ButtonBackAreaStyle.PaddingRight = 3;
			this.bubbleBar1.ButtonBackAreaStyle.PaddingTop = 3;
			this.bubbleBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bubbleBar1.ImageSizeLarge = new System.Drawing.Size(64, 64);
			this.bubbleBar1.ImageSizeNormal = new System.Drawing.Size(32, 32);
			this.bubbleBar1.Location = new System.Drawing.Point(0, 220);
			this.bubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight;
			this.bubbleBar1.Name = "bubbleBar1";
			this.bubbleBar1.SelectedTab = this.bubbleBarTab1;
			this.bubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black;
			this.bubbleBar1.Size = new System.Drawing.Size(488, 58);
			this.bubbleBar1.TabIndex = 0;
			this.bubbleBar1.Tabs.Add(this.bubbleBarTab1);
			this.bubbleBar1.Tabs.Add(this.bubbleBarTab2);
			this.bubbleBar1.Text = "bubbleBar1";
			this.bubbleBar1.TooltipFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			// 
			// bubbleBarTab1
			// 
			this.bubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(221)), ((System.Byte)(230)), ((System.Byte)(247)));
			this.bubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(138)), ((System.Byte)(168)), ((System.Byte)(228)));
			this.bubbleBarTab1.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
																							   this.bubbleButton4,
																							   this.bubbleButton3,
																							   this.bubbleButton1,
																							   this.bubbleButton2,
																							   this.bubbleButton5,
																							   this.bubbleButton6,
																							   this.bubbleButton10,
																							   this.bubbleButton8,
																							   this.bubbleButton9,
																							   this.bubbleButton7});
			this.bubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(((System.Byte)(190)), ((System.Byte)(105)), ((System.Byte)(105)), ((System.Byte)(105)));
			this.bubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.bubbleBarTab1.Name = "bubbleBarTab1";
			this.bubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
			this.bubbleBarTab1.Text = "Main";
			this.bubbleBarTab1.TextColor = System.Drawing.Color.Black;
			// 
			// bubbleButton4
			// 
			this.bubbleButton4.Image = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton4.Image")));
			this.bubbleButton4.ImageLarge = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton4.ImageLarge")));
			this.bubbleButton4.Name = "bubbleButton4";
			this.bubbleButton4.TooltipText = "Create New File";
			this.bubbleButton4.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_Click);
			// 
			// bubbleButton3
			// 
			this.bubbleButton3.Image = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton3.Image")));
			this.bubbleButton3.ImageLarge = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton3.ImageLarge")));
			this.bubbleButton3.Name = "bubbleButton3";
			this.bubbleButton3.TooltipText = "Send E-mail";
			this.bubbleButton3.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_Click);
			// 
			// bubbleButton1
			// 
			this.bubbleButton1.Image = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton1.Image")));
			this.bubbleButton1.ImageLarge = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton1.ImageLarge")));
			this.bubbleButton1.Name = "bubbleButton1";
			this.bubbleButton1.TooltipText = "Account List";
			this.bubbleButton1.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_Click);
			// 
			// bubbleButton2
			// 
			this.bubbleButton2.Image = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton2.Image")));
			this.bubbleButton2.ImageLarge = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton2.ImageLarge")));
			this.bubbleButton2.Name = "bubbleButton2";
			this.bubbleButton2.TooltipText = "Search";
			this.bubbleButton2.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_Click);
			// 
			// bubbleButton5
			// 
			this.bubbleButton5.Enabled = false;
			this.bubbleButton5.Image = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton5.Image")));
			this.bubbleButton5.ImageLarge = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton5.ImageLarge")));
			this.bubbleButton5.Name = "bubbleButton5";
			this.bubbleButton5.TooltipText = "Notes (This button is disabled)";
			this.bubbleButton5.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_Click);
			// 
			// bubbleButton6
			// 
			this.bubbleButton6.Image = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton6.Image")));
			this.bubbleButton6.ImageLarge = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton6.ImageLarge")));
			this.bubbleButton6.Name = "bubbleButton6";
			this.bubbleButton6.TooltipText = "Write CD";
			this.bubbleButton6.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_Click);
			// 
			// bubbleButton10
			// 
			this.bubbleButton10.Image = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton10.Image")));
			this.bubbleButton10.ImageLarge = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton10.ImageLarge")));
			this.bubbleButton10.Name = "bubbleButton10";
			this.bubbleButton10.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_Click);
			// 
			// bubbleButton8
			// 
			this.bubbleButton8.Image = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton8.Image")));
			this.bubbleButton8.ImageLarge = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton8.ImageLarge")));
			this.bubbleButton8.Name = "bubbleButton8";
			this.bubbleButton8.TooltipText = "System Users";
			this.bubbleButton8.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_Click);
			// 
			// bubbleButton9
			// 
			this.bubbleButton9.Image = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton9.Image")));
			this.bubbleButton9.ImageLarge = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton9.ImageLarge")));
			this.bubbleButton9.Name = "bubbleButton9";
			this.bubbleButton9.TooltipText = "Exit";
			this.bubbleButton9.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_Click);
			// 
			// bubbleButton7
			// 
			this.bubbleButton7.Image = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton7.Image")));
			this.bubbleButton7.ImageLarge = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton7.ImageLarge")));
			this.bubbleButton7.Name = "bubbleButton7";
			this.bubbleButton7.TooltipText = "Help";
			this.bubbleButton7.Click += new DevComponents.DotNetBar.ClickEventHandler(this.bubbleButton_Click);
			// 
			// bubbleBarTab2
			// 
			this.bubbleBarTab2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(249)), ((System.Byte)(225)), ((System.Byte)(226)));
			this.bubbleBarTab2.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(238)), ((System.Byte)(149)), ((System.Byte)(151)));
			this.bubbleBarTab2.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
																							   this.bubbleButton11,
																							   this.bubbleButton12,
																							   this.bubbleButton13,
																							   this.bubbleButton14,
																							   this.bubbleButton15,
																							   this.bubbleButton16,
																							   this.bubbleButton17,
																							   this.bubbleButton18});
			this.bubbleBarTab2.DarkBorderColor = System.Drawing.Color.FromArgb(((System.Byte)(190)), ((System.Byte)(105)), ((System.Byte)(105)), ((System.Byte)(105)));
			this.bubbleBarTab2.LightBorderColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.bubbleBarTab2.Name = "bubbleBarTab2";
			this.bubbleBarTab2.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Red;
			this.bubbleBarTab2.Text = "Notes";
			this.bubbleBarTab2.TextColor = System.Drawing.Color.Black;
			// 
			// bubbleButton11
			// 
			this.bubbleButton11.Image = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton11.Image")));
			this.bubbleButton11.Name = "bubbleButton11";
			// 
			// bubbleButton12
			// 
			this.bubbleButton12.Image = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton12.Image")));
			this.bubbleButton12.Name = "bubbleButton12";
			// 
			// bubbleButton13
			// 
			this.bubbleButton13.Image = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton13.Image")));
			this.bubbleButton13.Name = "bubbleButton13";
			// 
			// bubbleButton14
			// 
			this.bubbleButton14.Image = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton14.Image")));
			this.bubbleButton14.Name = "bubbleButton14";
			// 
			// bubbleButton15
			// 
			this.bubbleButton15.Image = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton15.Image")));
			this.bubbleButton15.Name = "bubbleButton15";
			// 
			// bubbleButton16
			// 
			this.bubbleButton16.Image = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton16.Image")));
			this.bubbleButton16.Name = "bubbleButton16";
			// 
			// bubbleButton17
			// 
			this.bubbleButton17.Image = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton17.Image")));
			this.bubbleButton17.Name = "bubbleButton17";
			// 
			// bubbleButton18
			// 
			this.bubbleButton18.Image = ((System.Drawing.Bitmap)(resources.GetObject("bubbleButton18.Image")));
			this.bubbleButton18.Name = "bubbleButton18";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "BubbleBar in action...";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Last click event:";
			// 
			// panelEx1
			// 
			this.panelEx1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.numericUpDown2,
																				   this.numericUpDown1,
																				   this.label4,
																				   this.label3,
																				   this.checkBox2,
																				   this.textBox1,
																				   this.checkBox1,
																				   this.label1,
																				   this.bubbleBar1,
																				   this.label2});
			this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new System.Drawing.Size(488, 278);
			this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.panelEx1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
			this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.TabIndex = 4;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(336, 64);
			this.numericUpDown2.Maximum = new System.Decimal(new int[] {
																		   128,
																		   0,
																		   0,
																		   0});
			this.numericUpDown2.Minimum = new System.Decimal(new int[] {
																		   33,
																		   0,
																		   0,
																		   0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(48, 20);
			this.numericUpDown2.TabIndex = 10;
			this.numericUpDown2.Value = new System.Decimal(new int[] {
																		 64,
																		 0,
																		 0,
																		 0});
			this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(336, 40);
			this.numericUpDown1.Maximum = new System.Decimal(new int[] {
																		   32,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Minimum = new System.Decimal(new int[] {
																		   16,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
			this.numericUpDown1.TabIndex = 9;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																		 32,
																		 0,
																		 0,
																		 0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(232, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Large Image Size:";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(232, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "Normal Image Size:";
			// 
			// checkBox2
			// 
			this.checkBox2.BackColor = System.Drawing.Color.Transparent;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(8, 64);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(160, 16);
			this.checkBox2.TabIndex = 6;
			this.checkBox2.Text = "Stretch button background";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.textBox1.Location = new System.Drawing.Point(112, 192);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(264, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "";
			// 
			// checkBox1
			// 
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(8, 40);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(128, 24);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Enable Animation";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(488, 278);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panelEx1});
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).EndInit();
			this.panelEx1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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

		private void bubbleButton_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
		{
			DevComponents.DotNetBar.BubbleButton button=sender as DevComponents.DotNetBar.BubbleButton;
			textBox1.Text=button.Name+", "+button.TooltipText;
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox1.Checked)
				bubbleBar1.AnimationTime=120;
			else
				bubbleBar1.AnimationTime=0;
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox2.Checked)
				bubbleBar1.ButtonBackgroundStretch=true;
			else
                bubbleBar1.ButtonBackgroundStretch=false;
			// Apply UI changes and refresh
			bubbleBar1.RecalcLayout();
			bubbleBar1.Refresh();
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			// It is best that images assigned to the control always match this size for best appearance
			bubbleBar1.ImageSizeNormal=new Size((int)numericUpDown1.Value,(int)numericUpDown1.Value);
			bubbleBar1.RecalcLayout();
			bubbleBar1.Refresh();
		}

		private void numericUpDown2_ValueChanged(object sender, System.EventArgs e)
		{
			// It is best that images assigned to the control always match this size for best appearance
			bubbleBar1.ImageSizeLarge=new Size((int)numericUpDown2.Value,(int)numericUpDown2.Value);
			bubbleBar1.RecalcLayout();
			bubbleBar1.Refresh();
		}
	}
}
