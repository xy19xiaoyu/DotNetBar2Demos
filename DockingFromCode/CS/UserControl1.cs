using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DockingFromCode
{
	/// <summary>
	/// Summary description for UserControl1.
	/// </summary>
	public class UserControl1 : System.Windows.Forms.UserControl
	{
		internal System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public UserControl1()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 150);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button1.Location = new System.Drawing.Point(0, 127);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Which Bar I am on?";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// UserControl1
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.label1});
			this.Name = "UserControl1";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			Bar bar=this.Parent as Bar;
			if(bar==null)
			{
				MessageBox.Show("Control is not on the bar");
			}
			else
			{
				// If reference to DotNetBarManager is needed this is how to get it
				DotNetBarManager manager=bar.Owner as DotNetBarManager;
				DockContainerItem dockItem=null;
				if(bar.SelectedDockTab<0) // There is only one DockContainerItem on the bar
					dockItem=bar.Items[0] as DockContainerItem;
				else
					dockItem=bar.Items[bar.SelectedDockTab] as DockContainerItem;

				MessageBox.Show("Control is on the bar: "+bar.Name +" ("+bar.Text+") and on DockContainerItem: "+dockItem.Name+" ("+dockItem.Text+")");
			}
		}
	}
}
