using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;

namespace Controls
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : DevComponents.DotNetBar.Office2007Form
	{
		private DevComponents.DotNetBar.Bar bar1;
		private DevComponents.DotNetBar.ButtonItem buttonBlackScheme;
		private DevComponents.DotNetBar.ButtonItem buttonSilverScheme;
		private DevComponents.DotNetBar.ButtonItem buttonBlueScheme;
		private DevComponents.DotNetBar.ColorPickerDropDown colorPickerCustomScheme;
		private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
		private DevComponents.DotNetBar.ButtonX buttonX1;
		private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
		private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
		private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
		private DevComponents.DotNetBar.Controls.TextBoxX textBoxX4;
		private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
		private DevComponents.DotNetBar.Controls.TextBoxX textBoxX5;
		
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
			this.bar1 = new DevComponents.DotNetBar.Bar();
			this.buttonBlackScheme = new DevComponents.DotNetBar.ButtonItem();
			this.buttonSilverScheme = new DevComponents.DotNetBar.ButtonItem();
			this.buttonBlueScheme = new DevComponents.DotNetBar.ButtonItem();
			this.colorPickerCustomScheme = new DevComponents.DotNetBar.ColorPickerDropDown();
			this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
			this.textBoxX5 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
			this.textBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
			((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
			this.groupPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bar1
			// 
			this.bar1.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
			this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
			this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																				this.buttonBlackScheme,
																				this.buttonSilverScheme,
																				this.buttonBlueScheme,
																				this.colorPickerCustomScheme});
			this.bar1.Name = "bar1";
			this.bar1.RoundCorners = false;
			this.bar1.Size = new System.Drawing.Size(338, 25);
			this.bar1.Stretch = true;
			this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.bar1.TabIndex = 0;
			this.bar1.TabStop = false;
			this.bar1.Text = "bar1";
			// 
			// buttonBlackScheme
			// 
			this.buttonBlackScheme.Name = "buttonBlackScheme";
			this.buttonBlackScheme.Text = "Black";
			this.buttonBlackScheme.Click += new System.EventHandler(this.buttonBlackScheme_Click);
			// 
			// buttonSilverScheme
			// 
			this.buttonSilverScheme.Name = "buttonSilverScheme";
			this.buttonSilverScheme.Text = "Silver";
			this.buttonSilverScheme.Click += new System.EventHandler(this.buttonSilverScheme_Click);
			// 
			// buttonBlueScheme
			// 
			this.buttonBlueScheme.Name = "buttonBlueScheme";
			this.buttonBlueScheme.Text = "Blue";
			this.buttonBlueScheme.Click += new System.EventHandler(this.buttonBlueScheme_Click);
			// 
			// colorPickerCustomScheme
			// 
			this.colorPickerCustomScheme.AutoExpandOnClick = true;
			this.colorPickerCustomScheme.Image = ((System.Drawing.Bitmap)(resources.GetObject("colorPickerCustomScheme.Image")));
			this.colorPickerCustomScheme.Name = "colorPickerCustomScheme";
			this.colorPickerCustomScheme.Text = "Custom";
			this.colorPickerCustomScheme.SelectedColorChanged += new System.EventHandler(this.colorPickerCustomScheme_SelectedColorChanged);
			this.colorPickerCustomScheme.ExpandChange += new System.EventHandler(this.colorPickerCustomScheme_ExpandChange);
			this.colorPickerCustomScheme.ColorPreview += new DevComponents.DotNetBar.ColorPreviewEventHandler(this.colorPickerCustomScheme_ColorPreview);
			// 
			// groupPanel1
			// 
			this.groupPanel1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.groupPanel1.AutoScroll = true;
			this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
			this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.groupPanel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.textBoxX5,
																					  this.comboBoxEx1,
																					  this.textBoxX4,
																					  this.textBoxX3,
																					  this.textBoxX2,
																					  this.textBoxX1});
			this.groupPanel1.Location = new System.Drawing.Point(8, 40);
			this.groupPanel1.Name = "groupPanel1";
			this.groupPanel1.Size = new System.Drawing.Size(322, 199);
			// 
			// groupPanel1.Style
			// 
			this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.groupPanel1.Style.BackColorGradientAngle = 90;
			this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel1.Style.BorderBottomWidth = 1;
			this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel1.Style.BorderLeftWidth = 1;
			this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel1.Style.BorderRightWidth = 1;
			this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.groupPanel1.Style.BorderTopWidth = 1;
			this.groupPanel1.Style.CornerDiameter = 4;
			this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
			this.groupPanel1.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
			this.groupPanel1.TabIndex = 1;
			this.groupPanel1.Text = "Customer Data";
			// 
			// textBoxX5
			// 
			this.textBoxX5.AutoSize = false;
			// 
			// textBoxX5.Border
			// 
			this.textBoxX5.Border.Class = "TextBoxBorder";
			this.textBoxX5.Location = new System.Drawing.Point(16, 168);
			this.textBoxX5.Multiline = true;
			this.textBoxX5.Name = "textBoxX5";
			this.textBoxX5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxX5.Size = new System.Drawing.Size(264, 104);
			this.textBoxX5.TabIndex = 5;
			// 
			// comboBoxEx1
			// 
			this.comboBoxEx1.DisplayMember = "Text";
			this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.comboBoxEx1.Location = new System.Drawing.Point(16, 104);
			this.comboBoxEx1.Name = "comboBoxEx1";
			this.comboBoxEx1.Size = new System.Drawing.Size(264, 21);
			this.comboBoxEx1.TabIndex = 4;
			this.comboBoxEx1.WatermarkText = "Choose State";
			// 
			// textBoxX4
			// 
			this.textBoxX4.AutoSize = false;
			// 
			// textBoxX4.Border
			// 
			this.textBoxX4.Border.Class = "TextBoxBorder";
			this.textBoxX4.Location = new System.Drawing.Point(16, 136);
			this.textBoxX4.Name = "textBoxX4";
			this.textBoxX4.Size = new System.Drawing.Size(264, 20);
			this.textBoxX4.TabIndex = 3;
			this.textBoxX4.WatermarkText = "Post code";
			// 
			// textBoxX3
			// 
			this.textBoxX3.AutoSize = false;
			// 
			// textBoxX3.Border
			// 
			this.textBoxX3.Border.Class = "TextBoxBorder";
			this.textBoxX3.Location = new System.Drawing.Point(16, 72);
			this.textBoxX3.Name = "textBoxX3";
			this.textBoxX3.Size = new System.Drawing.Size(264, 20);
			this.textBoxX3.TabIndex = 2;
			this.textBoxX3.WatermarkText = "Address";
			// 
			// textBoxX2
			// 
			this.textBoxX2.AutoSize = false;
			// 
			// textBoxX2.Border
			// 
			this.textBoxX2.Border.Class = "TextBoxBorder";
			this.textBoxX2.Location = new System.Drawing.Point(16, 40);
			this.textBoxX2.Name = "textBoxX2";
			this.textBoxX2.Size = new System.Drawing.Size(264, 20);
			this.textBoxX2.TabIndex = 1;
			this.textBoxX2.WatermarkText = "Last Name";
			// 
			// textBoxX1
			// 
			this.textBoxX1.AutoSize = false;
			// 
			// textBoxX1.Border
			// 
			this.textBoxX1.Border.Class = "TextBoxBorder";
			this.textBoxX1.Location = new System.Drawing.Point(16, 8);
			this.textBoxX1.Name = "textBoxX1";
			this.textBoxX1.Size = new System.Drawing.Size(264, 20);
			this.textBoxX1.TabIndex = 0;
			this.textBoxX1.WatermarkText = "First Name";
			// 
			// buttonX1
			// 
			this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonX1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.buttonX1.ColorScheme.DockSiteBackColorGradientAngle = 0;
			this.buttonX1.Location = new System.Drawing.Point(258, 247);
			this.buttonX1.Name = "buttonX1";
			this.buttonX1.Size = new System.Drawing.Size(72, 24);
			this.buttonX1.TabIndex = 2;
			this.buttonX1.Text = "Close";
			this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(194)), ((System.Byte)(217)), ((System.Byte)(247)));
			this.ClientSize = new System.Drawing.Size(338, 277);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.buttonX1,
																		  this.groupPanel1,
																		  this.bar1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Drop-in replacement controls";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
			this.groupPanel1.ResumeLayout(false);
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
			if(MessageBoxEx.Show("Close this form?", "Controls Sample",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
				this.Close();
		}

		private void buttonBlackScheme_Click(object sender, System.EventArgs e)
		{
			RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, eOffice2007ColorScheme.Black);
		}

		private void buttonSilverScheme_Click(object sender, System.EventArgs e)
		{
			RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, eOffice2007ColorScheme.Silver);
		}

		private void buttonBlueScheme_Click(object sender, System.EventArgs e)
		{
			RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, eOffice2007ColorScheme.Blue);
		}

		private bool m_ColorSelected = false;
		private eOffice2007ColorScheme m_BaseColorScheme = eOffice2007ColorScheme.Blue;

		private void colorPickerCustomScheme_ColorPreview(object sender, DevComponents.DotNetBar.ColorPreviewEventArgs e)
		{
			RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, m_BaseColorScheme, e.Color);
		}

		private void colorPickerCustomScheme_ExpandChange(object sender, System.EventArgs e)
		{
			if (colorPickerCustomScheme.Expanded)
			{
				// Remember the starting color scheme to apply if no color is selected during live-preview
				m_ColorSelected = false;
				m_BaseColorScheme = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.InitialColorScheme;
			}
			else
			{
				if (!m_ColorSelected)
				{
					RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, m_BaseColorScheme);
				}
			}
		}

		private void colorPickerCustomScheme_SelectedColorChanged(object sender, System.EventArgs e)
		{
			m_ColorSelected = true; // Indicate that color was selected for buttonStyleCustom_ExpandChange method
			RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, m_BaseColorScheme, colorPickerCustomScheme.SelectedColor);
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			comboBoxEx1.Items.AddRange(new string[]
				{	"Alabama",
					"Alaska",
					"Arizona",
					"Arkansas",
					"California",
					"Colorado",
					"Connecticut",
					"Delaware",
					"Florida",
					"Georgia",
					"Hawaii",
					"Idaho",
					"Illinois",
					"Indiana",
					"Iowa",
					"Kansas",
					"Kentucky",
					"Louisiana",
					"Maine",
					"Maryland",
					"Massachusetts",
					"Michigan",
					"Minnesota",
					"Mississippi",
					"Missouri",
					"Montana",
					"Nebraska",
					"Nevada",
					"New Hampshire",
					"New Jersey",
					"New Mexico",
					"New York",
					"North Carolina",
					"North Dakota",
					"Ohio",
					"Oklahoma",
					"Oregon",
					"Pennsylvania",
					"Rhode Island",
					"South Carolina",
					"South Dakota",
					"Tennessee",
					"Texas",
					"Utah",
					"Vermont",
					"Virginia",
					"Washington",
					"West Virginia",
					"Wisconsin",
					"Wyoming"
				});
		}
	}
}
