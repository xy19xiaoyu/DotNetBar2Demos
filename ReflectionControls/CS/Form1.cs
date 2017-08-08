using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ReflectionControls
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : DevComponents.DotNetBar.Office2007Form
	{
		private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
		private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage2;
		private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
		private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel2;
		private DevComponents.DotNetBar.LabelX labelX1;
		private DevComponents.DotNetBar.LabelX labelX2;
		private DevComponents.DotNetBar.ButtonX buttonX1;
		private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel3;
		private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage3;
		private DevComponents.DotNetBar.LabelX labelX3;
		private DevComponents.DotNetBar.LabelX labelX4;
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
			this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
			this.reflectionImage2 = new DevComponents.DotNetBar.Controls.ReflectionImage();
			this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
			this.reflectionLabel2 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
			this.labelX1 = new DevComponents.DotNetBar.LabelX();
			this.labelX2 = new DevComponents.DotNetBar.LabelX();
			this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
			this.reflectionLabel3 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
			this.reflectionImage3 = new DevComponents.DotNetBar.Controls.ReflectionImage();
			this.labelX3 = new DevComponents.DotNetBar.LabelX();
			this.labelX4 = new DevComponents.DotNetBar.LabelX();
			this.SuspendLayout();
			// 
			// reflectionImage1
			// 
			// 
			// reflectionImage1.BackgroundStyle
			// 
			this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.reflectionImage1.Image = ((System.Drawing.Bitmap)(resources.GetObject("reflectionImage1.Image")));
			this.reflectionImage1.Location = new System.Drawing.Point(16, 32);
			this.reflectionImage1.Name = "reflectionImage1";
			this.reflectionImage1.Size = new System.Drawing.Size(88, 104);
			this.reflectionImage1.TabIndex = 0;
			// 
			// reflectionImage2
			// 
			// 
			// reflectionImage2.BackgroundStyle
			// 
			this.reflectionImage2.BackgroundStyle.BackColor = System.Drawing.Color.White;
			this.reflectionImage2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.reflectionImage2.BackgroundStyle.BorderBottomWidth = 3;
			this.reflectionImage2.BackgroundStyle.BorderColor = System.Drawing.Color.Chocolate;
			this.reflectionImage2.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.reflectionImage2.BackgroundStyle.BorderLeftWidth = 3;
			this.reflectionImage2.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.reflectionImage2.BackgroundStyle.BorderRightWidth = 3;
			this.reflectionImage2.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.reflectionImage2.BackgroundStyle.BorderTopWidth = 3;
			this.reflectionImage2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
			this.reflectionImage2.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.reflectionImage2.Image = ((System.Drawing.Bitmap)(resources.GetObject("reflectionImage2.Image")));
			this.reflectionImage2.Location = new System.Drawing.Point(112, 32);
			this.reflectionImage2.Name = "reflectionImage2";
			this.reflectionImage2.Size = new System.Drawing.Size(88, 104);
			this.reflectionImage2.TabIndex = 2;
			// 
			// reflectionLabel1
			// 
			this.reflectionLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.reflectionLabel1.Location = new System.Drawing.Point(240, 32);
			this.reflectionLabel1.Name = "reflectionLabel1";
			this.reflectionLabel1.Size = new System.Drawing.Size(232, 56);
			this.reflectionLabel1.TabIndex = 3;
			this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Dev</i><font color=\"#B02B2C\">Components</font></font></b>";
			// 
			// reflectionLabel2
			// 
			// 
			// reflectionLabel2.BackgroundStyle
			// 
			this.reflectionLabel2.BackgroundStyle.BackColor = System.Drawing.Color.White;
			this.reflectionLabel2.BackgroundStyle.BackColor2 = System.Drawing.Color.WhiteSmoke;
			this.reflectionLabel2.BackgroundStyle.BackColorGradientAngle = 90;
			this.reflectionLabel2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.reflectionLabel2.BackgroundStyle.BorderBottomWidth = 3;
			this.reflectionLabel2.BackgroundStyle.BorderColor = System.Drawing.Color.Maroon;
			this.reflectionLabel2.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.reflectionLabel2.BackgroundStyle.BorderLeftWidth = 3;
			this.reflectionLabel2.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.reflectionLabel2.BackgroundStyle.BorderRightWidth = 3;
			this.reflectionLabel2.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.reflectionLabel2.BackgroundStyle.BorderTopWidth = 3;
			this.reflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
			this.reflectionLabel2.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.reflectionLabel2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.reflectionLabel2.Location = new System.Drawing.Point(232, 96);
			this.reflectionLabel2.Name = "reflectionLabel2";
			this.reflectionLabel2.Size = new System.Drawing.Size(296, 64);
			this.reflectionLabel2.TabIndex = 5;
			this.reflectionLabel2.Text = "<i>Dev</i><font color=\"#B02B2C\">Components</font>";
			// 
			// labelX1
			// 
			this.labelX1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelX1.Location = new System.Drawing.Point(240, 8);
			this.labelX1.Name = "labelX1";
			this.labelX1.Size = new System.Drawing.Size(264, 16);
			this.labelX1.TabIndex = 6;
			this.labelX1.Text = "Reflection Label Control with <a href=\"tm\">text-markup</a> support:";
			this.labelX1.MarkupLinkClick += new DevComponents.DotNetBar.MarkupLinkClickEventHandler(this.labelX1_MarkupLinkClick);
			// 
			// labelX2
			// 
			this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelX2.Location = new System.Drawing.Point(16, 8);
			this.labelX2.Name = "labelX2";
			this.labelX2.Size = new System.Drawing.Size(192, 16);
			this.labelX2.TabIndex = 7;
			this.labelX2.Text = "Reflection Image Control:";
			// 
			// buttonX1
			// 
			this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
			this.buttonX1.Location = new System.Drawing.Point(440, 256);
			this.buttonX1.Name = "buttonX1";
			this.buttonX1.Size = new System.Drawing.Size(88, 24);
			this.buttonX1.TabIndex = 8;
			this.buttonX1.Text = "&Close";
			this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
			// 
			// reflectionLabel3
			// 
			this.reflectionLabel3.Enabled = false;
			this.reflectionLabel3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.reflectionLabel3.Location = new System.Drawing.Point(240, 192);
			this.reflectionLabel3.Name = "reflectionLabel3";
			this.reflectionLabel3.Size = new System.Drawing.Size(232, 56);
			this.reflectionLabel3.TabIndex = 9;
			this.reflectionLabel3.Text = "<b><font size=\"+6\"><i>Dev</i><font color=\"#B02B2C\">Components</font></font></b>";
			// 
			// reflectionImage3
			// 
			// 
			// reflectionImage3.BackgroundStyle
			// 
			this.reflectionImage3.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
			this.reflectionImage3.Enabled = false;
			this.reflectionImage3.Image = ((System.Drawing.Bitmap)(resources.GetObject("reflectionImage3.Image")));
			this.reflectionImage3.Location = new System.Drawing.Point(16, 176);
			this.reflectionImage3.Name = "reflectionImage3";
			this.reflectionImage3.Size = new System.Drawing.Size(88, 104);
			this.reflectionImage3.TabIndex = 10;
			// 
			// labelX3
			// 
			this.labelX3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelX3.Location = new System.Drawing.Point(16, 152);
			this.labelX3.Name = "labelX3";
			this.labelX3.Size = new System.Drawing.Size(192, 16);
			this.labelX3.TabIndex = 11;
			this.labelX3.Text = "Disabled state:";
			// 
			// labelX4
			// 
			this.labelX4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelX4.Location = new System.Drawing.Point(240, 168);
			this.labelX4.Name = "labelX4";
			this.labelX4.Size = new System.Drawing.Size(192, 16);
			this.labelX4.TabIndex = 12;
			this.labelX4.Text = "Disabled state:";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(194)), ((System.Byte)(217)), ((System.Byte)(247)));
			this.ClientSize = new System.Drawing.Size(538, 288);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.labelX4,
																		  this.labelX3,
																		  this.reflectionImage3,
																		  this.reflectionLabel3,
																		  this.buttonX1,
																		  this.labelX2,
																		  this.labelX1,
																		  this.reflectionLabel2,
																		  this.reflectionLabel1,
																		  this.reflectionImage2,
																		  this.reflectionImage1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "DotNetBar Reflection Controls Demonstration";
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

		private void labelX1_MarkupLinkClick(object sender, DevComponents.DotNetBar.MarkupLinkClickEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.devcomponents.com/kb/questions.php?questionid=5");
		}

		private void buttonX1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
