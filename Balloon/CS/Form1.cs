using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;

namespace Balloon
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private AlertCustom m_AlertOnLoad=null;
		private System.Windows.Forms.Timer timer1;
		private DevComponents.DotNetBar.BalloonTip balloonTipFocus;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private DevComponents.DotNetBar.BalloonTip balloonTipHover;
		private System.Windows.Forms.Button button2;
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
			this.balloonTipFocus = new DevComponents.DotNetBar.BalloonTip();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.balloonTipHover = new DevComponents.DotNetBar.BalloonTip();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// balloonTipFocus
			// 
			this.balloonTipFocus.AutoCloseTimeOut = 3;
			this.balloonTipFocus.CaptionImage = ((System.Drawing.Bitmap)(resources.GetObject("balloonTipFocus.CaptionImage")));
			this.balloonTipFocus.Enabled = false;
			this.balloonTipFocus.ShowBalloonOnFocus = true;
			// 
			// textBox1
			// 
			this.balloonTipFocus.SetBalloonCaption(this.textBox1, "Balloon Information displayed on focus");
			this.balloonTipFocus.SetBalloonText(this.textBox1, "Enter first name of contact person, required.");
			this.textBox1.Location = new System.Drawing.Point(16, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(176, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.balloonTipFocus.SetBalloonCaption(this.textBox2, "Balloon Information displayed on focus");
			this.balloonTipFocus.SetBalloonText(this.textBox2, "Enter last name of contact person, required.");
			this.textBox2.Location = new System.Drawing.Point(16, 88);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(176, 20);
			this.textBox2.TabIndex = 5;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.balloonTipFocus.SetBalloonCaption(this.textBox3, "Balloon Information displayed on focus");
			this.balloonTipFocus.SetBalloonText(this.textBox3, "Enter email address of contact person, required.");
			this.textBox3.Location = new System.Drawing.Point(16, 136);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(176, 20);
			this.textBox3.TabIndex = 7;
			this.textBox3.Text = "";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// groupBox1
			// 
			this.balloonTipHover.SetBalloonCaption(this.groupBox1, "Custom Positioned Balloon Information");
			this.balloonTipHover.SetBalloonText(this.groupBox1, "All controls in this group will display the Balloon tip once they gain input focu" +
				"s. Simply tab through the controls or set the focus using the mouse to display m" +
				"ore information about control that has focus.");
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.button1,
																					this.textBox3,
																					this.label3,
																					this.textBox2,
																					this.label2,
																					this.textBox1,
																					this.label1});
			this.groupBox1.Location = new System.Drawing.Point(32, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(208, 208);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Balloon Tip Test Area";
			// 
			// button1
			// 
			this.balloonTipHover.SetBalloonCaption(this.button1, "Balloon information displayed on mouse hover");
			this.balloonTipHover.SetBalloonText(this.button1, "Click to save the data entered on this page.");
			this.button1.Location = new System.Drawing.Point(16, 168);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 24);
			this.button1.TabIndex = 8;
			this.button1.Text = "Save";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "E-Mail Address:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Last Name:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "First Name:";
			// 
			// balloonTipHover
			// 
			this.balloonTipHover.AutoCloseTimeOut = 4;
			this.balloonTipHover.CaptionImage = ((System.Drawing.Bitmap)(resources.GetObject("balloonTipHover.CaptionImage")));
			this.balloonTipHover.Enabled = false;
			this.balloonTipHover.ShowCloseButton = false;
			this.balloonTipHover.BalloonDisplaying += new System.EventHandler(this.balloonTipHover_BalloonDisplaying);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(32, 224);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 32);
			this.button2.TabIndex = 5;
			this.button2.Text = "Enable Balloons";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(272, 270);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button2,
																		  this.groupBox1});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Balloon and BalloonTip Sample";
			this.groupBox1.ResumeLayout(false);
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

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			timer1.Stop();
			timer1.Enabled=false;
			ShowLoadAlert();
		}

		private void ShowLoadAlert()
		{
			m_AlertOnLoad=new AlertCustom();
			Rectangle r=Screen.GetWorkingArea(this);
			m_AlertOnLoad.Location=new Point(r.Right-m_AlertOnLoad.Width,r.Bottom-m_AlertOnLoad.Height);
			m_AlertOnLoad.AutoClose=true;
			m_AlertOnLoad.AutoCloseTimeOut=15;
			m_AlertOnLoad.AlertAnimation=eAlertAnimation.BottomToTop;
			m_AlertOnLoad.AlertAnimationDuration=300;
			m_AlertOnLoad.Show(false);
		}

		private void balloonTipHover_BalloonDisplaying(object sender, System.EventArgs e)
		{
			// BalloonTriggerControl property returns control that invoked balloon
			if(balloonTipHover.BalloonTriggerControl==groupBox1)
			{
				// BalloonControl is already prepared Balloon control that is just about to be displayed
				// Setting BalloonControl to null will cancel balloon display
				Point p=Control.MousePosition;
				// Adjust cursor position so cursor is below tip
				p.Offset(-balloonTipHover.BalloonControl.TipOffset,balloonTipHover.BalloonControl.TipLength+4);
				balloonTipHover.BalloonControl.Location=p;
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			balloonTipFocus.Enabled=true;
			balloonTipHover.Enabled=true;
			
			DevComponents.DotNetBar.Balloon b=new DevComponents.DotNetBar.Balloon();
			b.Style=eBallonStyle.Alert;
			b.CaptionImage=balloonTipFocus.CaptionImage.Clone() as Image;
			b.CaptionText="Balloon Status Information";
			b.Text="Balloons are now enabled for Balloon Tip Test area. Hover mouse over the area and set the focus to any control.";
			b.AlertAnimation=eAlertAnimation.TopToBottom;
			b.AutoResize();
			b.AutoClose=true;
			b.AutoCloseTimeOut=4;
			b.Owner=this;
			b.Show(button2,false);
		}
	}
}
