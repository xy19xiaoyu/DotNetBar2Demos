using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace PanelEx
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevComponents.DotNetBar.PanelEx panelEx1;
		private DevComponents.DotNetBar.PanelEx panelEx2;
		private DevComponents.DotNetBar.PanelEx panelEx3;
		private DevComponents.DotNetBar.PanelEx panelEx4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private DevComponents.DotNetBar.PanelEx panelEx5;
		private DevComponents.DotNetBar.PanelEx panelEx6;
		private DevComponents.DotNetBar.PanelEx panelEx7;
		private DevComponents.DotNetBar.PanelEx panelEx8;
		private DevComponents.DotNetBar.PanelEx panelEx9;
		private System.Windows.Forms.Label label5;
		private DevComponents.DotNetBar.PanelEx panelEx10;
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
			this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
			this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
			this.panelEx10 = new DevComponents.DotNetBar.PanelEx();
			this.panelEx9 = new DevComponents.DotNetBar.PanelEx();
			this.label5 = new System.Windows.Forms.Label();
			this.panelEx8 = new DevComponents.DotNetBar.PanelEx();
			this.panelEx7 = new DevComponents.DotNetBar.PanelEx();
			this.panelEx6 = new DevComponents.DotNetBar.PanelEx();
			this.panelEx5 = new DevComponents.DotNetBar.PanelEx();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
			this.panelEx1.SuspendLayout();
			this.panelEx3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelEx1
			// 
			this.panelEx1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.panelEx2});
			this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelEx1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new System.Drawing.Size(544, 32);
			this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.Style.MarginLeft = 4;
			this.panelEx1.TabIndex = 0;
			this.panelEx1.Text = "PanelEx Sample Project";
			// 
			// panelEx2
			// 
			this.panelEx2.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.panelEx2.Location = new System.Drawing.Point(520, 8);
			this.panelEx2.Name = "panelEx2";
			this.panelEx2.Size = new System.Drawing.Size(16, 16);
			this.panelEx2.Style.BackgroundImage = ((System.Drawing.Bitmap)(resources.GetObject("panelEx2.Style.BackgroundImage")));
			this.panelEx2.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Center;
			this.panelEx2.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx2.StyleMouseDown.BackgroundImage = ((System.Drawing.Bitmap)(resources.GetObject("panelEx2.StyleMouseDown.BackgroundImage")));
			this.panelEx2.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx2.TabIndex = 2;
			// 
			// panelEx3
			// 
			this.panelEx3.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.panelEx10,
																				   this.panelEx9,
																				   this.label5,
																				   this.panelEx8,
																				   this.panelEx7,
																				   this.panelEx6,
																				   this.panelEx5,
																				   this.label4,
																				   this.label3,
																				   this.label2,
																				   this.label1,
																				   this.panelEx4});
			this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelEx3.Location = new System.Drawing.Point(0, 32);
			this.panelEx3.Name = "panelEx3";
			this.panelEx3.Size = new System.Drawing.Size(544, 246);
			this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx3.Style.GradientAngle = 90;
			this.panelEx3.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx3.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx3.TabIndex = 1;
			// 
			// panelEx10
			// 
			this.panelEx10.AutoScroll = true;
			this.panelEx10.AutoScrollMinSize = new System.Drawing.Size(0, 457);
			this.panelEx10.Location = new System.Drawing.Point(288, 16);
			this.panelEx10.Name = "panelEx10";
			this.panelEx10.Size = new System.Drawing.Size(248, 152);
			this.panelEx10.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx10.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.panelEx10.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.panelEx10.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx10.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.panelEx10.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.panelEx10.Style.GradientAngle = 90;
			this.panelEx10.TabIndex = 11;
			this.panelEx10.Text = @"PanelEx control fully supports DevComponents <a href=""textMarkupLink""><b>text-markup</b></a>. You can use PanelEx as:<br/><br/>
<p>
- Extremely powerful <font color=""Navy""><b>Label</b></font> control<br/>
- Help panel with <font color=""Navy""><b>automatic scrolling</b></font> support<br/>
- Documentation presentation control<br/>
</p>
<p>
Here is longer text that demonstrates automatic PanelEx scrolling support:
</p>
<p>
Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Sed pharetra dolor quis tortor. Donec quis purus at ante tempor gravida. Mauris velit lacus, viverra sit amet, aliquet sit amet, malesuada sed, metus. Morbi blandit. Etiam fermentum sapien et nunc. Vivamus et nisl. Phasellus eget elit. Nulla ac urna. Fusce elementum. Phasellus est mi, adipiscing ac, tristique ac, lobortis nec, neque. Cras quis quam. Nam aliquam lectus sed augue. Suspendisse potenti. Praesent eget dui. Aliquam egestas eros et arcu.
</p>
<p> 
In hac habitasse platea dictumst. Donec tellus. Morbi urna sapien, dictum vel, fringilla eu, scelerisque ullamcorper, tortor. Curabitur nec purus. Aliquam elit mi, suscipit quis, elementum vitae, volutpat in, ante. Duis non magna ut nibh tincidunt dignissim. In risus nulla, fringilla posuere, egestas vitae, elementum at, eros. Integer id mi venenatis tellus ornare facilisis. Fusce convallis viverra ante. Aenean metus. 
</p>";
			this.panelEx10.MarkupLinkClick += new DevComponents.DotNetBar.MarkupLinkClickEventHandler(this.panelEx10_MarkupLinkClick);
			// 
			// panelEx9
			// 
			this.panelEx9.Location = new System.Drawing.Point(176, 144);
			this.panelEx9.Name = "panelEx9";
			this.panelEx9.Size = new System.Drawing.Size(104, 24);
			this.panelEx9.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx9.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelEx9.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelEx9.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx9.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx9.Style.CornerDiameter = 5;
			this.panelEx9.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
			this.panelEx9.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx9.Style.GradientAngle = 90;
			this.panelEx9.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx9.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx9.TabIndex = 10;
			this.panelEx9.Text = "Panel Style";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(16, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(144, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "Rounded Panel";
			// 
			// panelEx8
			// 
			this.panelEx8.Location = new System.Drawing.Point(176, 111);
			this.panelEx8.Name = "panelEx8";
			this.panelEx8.Size = new System.Drawing.Size(104, 24);
			this.panelEx8.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx8.Style.BackColor1.Color = System.Drawing.Color.Linen;
			this.panelEx8.Style.BackColor2.Color = System.Drawing.Color.DarkOrange;
			this.panelEx8.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
			this.panelEx8.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx8.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.panelEx8.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.panelEx8.Style.GradientAngle = 90;
			this.panelEx8.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx8.StyleMouseDown.BackColor1.Color = System.Drawing.Color.OrangeRed;
			this.panelEx8.StyleMouseDown.BackColor2.Color = System.Drawing.Color.Linen;
			this.panelEx8.StyleMouseDown.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
			this.panelEx8.StyleMouseDown.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
			this.panelEx8.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx8.StyleMouseOver.BackColor1.Color = System.Drawing.Color.NavajoWhite;
			this.panelEx8.StyleMouseOver.BackColor2.Color = System.Drawing.Color.IndianRed;
			this.panelEx8.StyleMouseOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panelEx8.TabIndex = 8;
			this.panelEx8.Text = "Panel Style";
			// 
			// panelEx7
			// 
			this.panelEx7.Location = new System.Drawing.Point(176, 80);
			this.panelEx7.Name = "panelEx7";
			this.panelEx7.Size = new System.Drawing.Size(104, 24);
			this.panelEx7.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx7.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.panelEx7.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.panelEx7.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
			this.panelEx7.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.panelEx7.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.panelEx7.Style.GradientAngle = 90;
			this.panelEx7.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx7.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx7.TabIndex = 7;
			this.panelEx7.Text = "Label Style";
			// 
			// panelEx6
			// 
			this.panelEx6.Location = new System.Drawing.Point(176, 48);
			this.panelEx6.Name = "panelEx6";
			this.panelEx6.Size = new System.Drawing.Size(104, 24);
			this.panelEx6.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.panelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.panelEx6.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
			this.panelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.panelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.panelEx6.Style.GradientAngle = 90;
			this.panelEx6.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx6.StyleMouseDown.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
			this.panelEx6.StyleMouseDown.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
			this.panelEx6.StyleMouseDown.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
			this.panelEx6.StyleMouseDown.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
			this.panelEx6.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx6.StyleMouseOver.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground;
			this.panelEx6.StyleMouseOver.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground2;
			this.panelEx6.StyleMouseOver.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder;
			this.panelEx6.StyleMouseOver.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
			this.panelEx6.TabIndex = 6;
			this.panelEx6.Text = "Button Style";
			// 
			// panelEx5
			// 
			this.panelEx5.Location = new System.Drawing.Point(176, 16);
			this.panelEx5.Name = "panelEx5";
			this.panelEx5.Size = new System.Drawing.Size(104, 24);
			this.panelEx5.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx5.Style.GradientAngle = 90;
			this.panelEx5.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx5.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx5.TabIndex = 5;
			this.panelEx5.Text = "Panel Style";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(168, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "PanelEx with manually set style:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "PanelEx with \"Label\" style:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "PanelEx with \"Button\" style:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "PanelEx with \"Panel\" style:";
			// 
			// panelEx4
			// 
			this.panelEx4.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.panelEx4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panelEx4.Location = new System.Drawing.Point(456, 216);
			this.panelEx4.Name = "panelEx4";
			this.panelEx4.Size = new System.Drawing.Size(80, 24);
			this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
			this.panelEx4.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile;
			this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
			this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.panelEx4.Style.GradientAngle = 90;
			this.panelEx4.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx4.StyleMouseDown.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
			this.panelEx4.StyleMouseDown.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
			this.panelEx4.StyleMouseDown.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
			this.panelEx4.StyleMouseDown.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
			this.panelEx4.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx4.StyleMouseOver.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground;
			this.panelEx4.StyleMouseOver.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBackground2;
			this.panelEx4.StyleMouseOver.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotBorder;
			this.panelEx4.StyleMouseOver.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
			this.panelEx4.TabIndex = 0;
			this.panelEx4.Text = "Close";
			this.panelEx4.Click += new System.EventHandler(this.panelEx4_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(544, 278);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panelEx3,
																		  this.panelEx1});
			this.MinimumSize = new System.Drawing.Size(224, 272);
			this.Name = "Form1";
			this.Text = "PanelEx Sample Project";
			this.panelEx1.ResumeLayout(false);
			this.panelEx3.ResumeLayout(false);
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

		private void panelEx4_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void panelEx10_MarkupLinkClick(object sender, DevComponents.DotNetBar.MarkupLinkClickEventArgs e)
		{
			DevComponents.DotNetBar.MessageBoxEx.Show("You can use the hyperlink support to add actionable content to your text.", "PanelEx Demo");
		}
	}
}
