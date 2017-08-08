using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace RibbonMerge
{
	/// <summary>
	/// Summary description for ChildForm1.
	/// </summary>
	public class ChildForm1 : DevComponents.DotNetBar.Office2007Form
	{
		private DevComponents.DotNetBar.RibbonBarMergeContainer ribbonBarMergeContainer1;
		private DevComponents.DotNetBar.RibbonBar ribbonBar1;
		private DevComponents.DotNetBar.CheckBoxItem checkBoxItem1;
		private DevComponents.DotNetBar.CheckBoxItem checkBoxItem2;
		private DevComponents.DotNetBar.CheckBoxItem checkBoxItem3;
		private DevComponents.DotNetBar.PanelEx panelEx1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ChildForm1()
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
			this.ribbonBarMergeContainer1 = new DevComponents.DotNetBar.RibbonBarMergeContainer();
			this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
			this.checkBoxItem1 = new DevComponents.DotNetBar.CheckBoxItem();
			this.checkBoxItem2 = new DevComponents.DotNetBar.CheckBoxItem();
			this.checkBoxItem3 = new DevComponents.DotNetBar.CheckBoxItem();
			this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
			this.ribbonBarMergeContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ribbonBarMergeContainer1
			// 
			this.ribbonBarMergeContainer1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.ribbonBarMergeContainer1.Controls.AddRange(new System.Windows.Forms.Control[] {
																								   this.ribbonBar1});
			this.ribbonBarMergeContainer1.Location = new System.Drawing.Point(8, 40);
			this.ribbonBarMergeContainer1.Name = "ribbonBarMergeContainer1";
			this.ribbonBarMergeContainer1.RibbonTabText = "MDI Child Tab 1";
			this.ribbonBarMergeContainer1.Size = new System.Drawing.Size(368, 88);
			this.ribbonBarMergeContainer1.TabIndex = 0;
			this.ribbonBarMergeContainer1.Visible = false;
			// 
			// ribbonBar1
			// 
			this.ribbonBar1.AutoOverflowEnabled = true;
			this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
			this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																					  this.checkBoxItem1,
																					  this.checkBoxItem2,
																					  this.checkBoxItem3});
			this.ribbonBar1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.ribbonBar1.Name = "ribbonBar1";
			this.ribbonBar1.Size = new System.Drawing.Size(144, 88);
			this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.ribbonBar1.TabIndex = 0;
			this.ribbonBar1.Text = "ribbonBar1";
			// 
			// checkBoxItem1
			// 
			this.checkBoxItem1.Name = "checkBoxItem1";
			this.checkBoxItem1.Text = "checkBoxItem1";
			// 
			// checkBoxItem2
			// 
			this.checkBoxItem2.Name = "checkBoxItem2";
			this.checkBoxItem2.Text = "checkBoxItem2";
			// 
			// checkBoxItem3
			// 
			this.checkBoxItem3.Name = "checkBoxItem3";
			this.checkBoxItem3.Text = "checkBoxItem3";
			// 
			// panelEx1
			// 
			this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
			this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new System.Drawing.Size(400, 32);
			this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.TabIndex = 1;
			this.panelEx1.Text = "This is MDI Child Form 1";
			// 
			// ChildForm1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(194)), ((System.Byte)(217)), ((System.Byte)(247)));
			this.ClientSize = new System.Drawing.Size(400, 286);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panelEx1,
																		  this.ribbonBarMergeContainer1});
			this.Name = "ChildForm1";
			this.Text = "ChildForm1";
			this.ribbonBarMergeContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	}
}
