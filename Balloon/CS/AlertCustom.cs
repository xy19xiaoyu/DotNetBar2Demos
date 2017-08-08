using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Balloon
{
	/// <summary>
	/// Summary description for AlertCustom.
	/// </summary>
	public class AlertCustom : DevComponents.DotNetBar.Balloon
	{
		private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
		private DevComponents.DotNetBar.Bar bar1;
		private DevComponents.DotNetBar.ButtonItem buttonItem1;
		private DevComponents.DotNetBar.ButtonItem buttonItem2;
		private DevComponents.DotNetBar.ButtonItem buttonItem3;
		private DevComponents.DotNetBar.LabelX labelX1;
		private DevComponents.DotNetBar.LabelX labelX2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AlertCustom()
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
				if(components != null)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AlertCustom));
			this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
			this.bar1 = new DevComponents.DotNetBar.Bar();
			this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
			this.labelX1 = new DevComponents.DotNetBar.LabelX();
			this.labelX2 = new DevComponents.DotNetBar.LabelX();
			((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
			this.SuspendLayout();
			// 
			// reflectionImage1
			// 
			this.reflectionImage1.BackColor = System.Drawing.Color.Transparent;
			this.reflectionImage1.Image = ((System.Drawing.Bitmap)(resources.GetObject("reflectionImage1.Image")));
			this.reflectionImage1.Location = new System.Drawing.Point(8, 8);
			this.reflectionImage1.Name = "reflectionImage1";
			this.reflectionImage1.Size = new System.Drawing.Size(64, 100);
			this.reflectionImage1.TabIndex = 0;
			// 
			// bar1
			// 
			this.bar1.BackColor = System.Drawing.Color.Transparent;
			this.bar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																				this.buttonItem1,
																				this.buttonItem2,
																				this.buttonItem3});
			this.bar1.Location = new System.Drawing.Point(0, 111);
			this.bar1.Name = "bar1";
			this.bar1.Size = new System.Drawing.Size(280, 25);
			this.bar1.Stretch = true;
			this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.bar1.TabIndex = 1;
			this.bar1.TabStop = false;
			this.bar1.Text = "bar1";
			// 
			// buttonItem1
			// 
			this.buttonItem1.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem1.Image")));
			this.buttonItem1.ImagePaddingHorizontal = 8;
			this.buttonItem1.Name = "buttonItem1";
			this.buttonItem1.Text = "buttonItem1";
			// 
			// buttonItem2
			// 
			this.buttonItem2.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonItem2.Image")));
			this.buttonItem2.ImagePaddingHorizontal = 8;
			this.buttonItem2.Name = "buttonItem2";
			this.buttonItem2.Text = "buttonItem2";
			// 
			// buttonItem3
			// 
			this.buttonItem3.ImagePaddingHorizontal = 8;
			this.buttonItem3.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
			this.buttonItem3.Name = "buttonItem3";
			this.buttonItem3.Text = "Options...";
			// 
			// labelX1
			// 
			this.labelX1.BackColor = System.Drawing.Color.Transparent;
			this.labelX1.Location = new System.Drawing.Point(88, 32);
			this.labelX1.Name = "labelX1";
			this.labelX1.Size = new System.Drawing.Size(184, 16);
			this.labelX1.TabIndex = 2;
			this.labelX1.Text = "<b>Create great looking custom alerts</b>";
			// 
			// labelX2
			// 
			this.labelX2.BackColor = System.Drawing.Color.Transparent;
			this.labelX2.Location = new System.Drawing.Point(88, 56);
			this.labelX2.Name = "labelX2";
			this.labelX2.Size = new System.Drawing.Size(184, 40);
			this.labelX2.TabIndex = 3;
			this.labelX2.Text = "Using Balloon and other controls included with DotNetBar you can create great loo" +
				"king custom alerts.";
			this.labelX2.TextLineAlignment = System.Drawing.StringAlignment.Near;
			this.labelX2.WordWrap = true;
			// 
			// AlertCustom
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
			this.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(175)), ((System.Byte)(210)), ((System.Byte)(255)));
			this.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(101)), ((System.Byte)(147)), ((System.Byte)(207)));
			this.CaptionFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.ClientSize = new System.Drawing.Size(280, 136);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.labelX2,
																		  this.labelX1,
																		  this.bar1,
																		  this.reflectionImage1});
			this.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(8)), ((System.Byte)(55)), ((System.Byte)(114)));
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "AlertCustom";
			this.Style = DevComponents.DotNetBar.eBallonStyle.Office2007Alert;
			((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.devcomponents.com");
		}
	}
}
