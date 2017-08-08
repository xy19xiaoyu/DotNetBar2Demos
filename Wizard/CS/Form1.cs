using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Wizard
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : DevComponents.DotNetBar.Office2007Form
	{
		internal DevComponents.DotNetBar.Wizard Wizard1;
		internal DevComponents.DotNetBar.WizardPage WizardWelcomePage;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal DevComponents.DotNetBar.WizardPage WizardProcessingPage;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.ProgressBar ProgressBar1;
		internal DevComponents.DotNetBar.WizardPage WizardExePathChoicePage;
		internal System.Windows.Forms.RadioButton optionExecutionPath2;
		internal System.Windows.Forms.RadioButton optionExecutionPath1;
		internal System.Windows.Forms.Label Label5;
		internal DevComponents.DotNetBar.WizardPage WizardFinish1Page;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label6;
		internal DevComponents.DotNetBar.WizardPage WizardSimpleValidationPage;
		internal System.Windows.Forms.CheckBox CheckPageSwitch;
		internal DevComponents.DotNetBar.WizardPage WizardPage2;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Timer Timer1;
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
			this.Wizard1 = new DevComponents.DotNetBar.Wizard();
			this.WizardWelcomePage = new DevComponents.DotNetBar.WizardPage();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.WizardProcessingPage = new DevComponents.DotNetBar.WizardPage();
			this.Label4 = new System.Windows.Forms.Label();
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.WizardExePathChoicePage = new DevComponents.DotNetBar.WizardPage();
			this.optionExecutionPath2 = new System.Windows.Forms.RadioButton();
			this.optionExecutionPath1 = new System.Windows.Forms.RadioButton();
			this.Label5 = new System.Windows.Forms.Label();
			this.WizardFinish1Page = new DevComponents.DotNetBar.WizardPage();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.WizardSimpleValidationPage = new DevComponents.DotNetBar.WizardPage();
			this.CheckPageSwitch = new System.Windows.Forms.CheckBox();
			this.WizardPage2 = new DevComponents.DotNetBar.WizardPage();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Wizard1.SuspendLayout();
			this.WizardWelcomePage.SuspendLayout();
			this.WizardProcessingPage.SuspendLayout();
			this.WizardExePathChoicePage.SuspendLayout();
			this.WizardFinish1Page.SuspendLayout();
			this.WizardSimpleValidationPage.SuspendLayout();
			this.WizardPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// Wizard1
			// 
			this.Wizard1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(205)), ((System.Byte)(229)), ((System.Byte)(253)));
			this.Wizard1.BackgroundImage = ((System.Drawing.Bitmap)(resources.GetObject("Wizard1.BackgroundImage")));
			this.Wizard1.ButtonStyle = DevComponents.DotNetBar.eWizardStyle.Office2007;
			this.Wizard1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Wizard1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Wizard1.FinishButtonTabIndex = 3;
			this.Wizard1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			// 
			// Wizard1.FooterStyle
			// 
			this.Wizard1.FooterStyle.BackColor = System.Drawing.Color.Transparent;
			this.Wizard1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(15)), ((System.Byte)(57)), ((System.Byte)(129)));
			this.Wizard1.HeaderImageSize = new System.Drawing.Size(48, 48);
			// 
			// Wizard1.HeaderStyle
			// 
			this.Wizard1.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(191)), ((System.Byte)(215)), ((System.Byte)(243)));
			this.Wizard1.HeaderStyle.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(219)), ((System.Byte)(241)), ((System.Byte)(254)));
			this.Wizard1.HeaderStyle.BackColorGradientAngle = 90;
			this.Wizard1.HeaderStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
			this.Wizard1.HeaderStyle.BorderBottomColor = System.Drawing.Color.FromArgb(((System.Byte)(121)), ((System.Byte)(157)), ((System.Byte)(182)));
			this.Wizard1.HeaderStyle.BorderBottomWidth = 1;
			this.Wizard1.Name = "Wizard1";
			this.Wizard1.Size = new System.Drawing.Size(534, 366);
			this.Wizard1.TabIndex = 1;
			this.Wizard1.WizardPages.AddRange(new DevComponents.DotNetBar.WizardPage[] {
																						   this.WizardWelcomePage,
																						   this.WizardProcessingPage,
																						   this.WizardExePathChoicePage,
																						   this.WizardFinish1Page,
																						   this.WizardSimpleValidationPage,
																						   this.WizardPage2});
			this.Wizard1.CancelButtonClick += new System.ComponentModel.CancelEventHandler(this.Wizard1_CancelButtonClick);
			this.Wizard1.FinishButtonClick += new System.ComponentModel.CancelEventHandler(this.Wizard1_FinishButtonClick);
			this.Wizard1.WizardPageChanging += new DevComponents.DotNetBar.WizardCancelPageChangeEventHandler(this.Wizard1_WizardPageChanging);
			// 
			// WizardWelcomePage
			// 
			this.WizardWelcomePage.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.WizardWelcomePage.AntiAlias = false;
			this.WizardWelcomePage.BackColor = System.Drawing.Color.Transparent;
			this.WizardWelcomePage.Controls.AddRange(new System.Windows.Forms.Control[] {
																							this.Label1,
																							this.Label2,
																							this.Label3});
			this.WizardWelcomePage.InteriorPage = false;
			this.WizardWelcomePage.Name = "WizardWelcomePage";
			this.WizardWelcomePage.Size = new System.Drawing.Size(534, 320);
			this.WizardWelcomePage.TabIndex = 7;
			// 
			// Label1
			// 
			this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("Tahoma", 16F);
			this.Label1.Location = new System.Drawing.Point(210, 18);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(310, 66);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Welcome to the Wizard Control Sample Project";
			// 
			// Label2
			// 
			this.Label2.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label2.Location = new System.Drawing.Point(210, 100);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(309, 188);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "This Welcome page was created automatically using Create Welcome Page command in " +
				"design-time from Wizard control context menu or designer verbs. You can customiz" +
				"e its appearance using the Style property on the WizardPage object.";
			// 
			// Label3
			// 
			this.Label3.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label3.Location = new System.Drawing.Point(210, 297);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(120, 13);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "To continue, click Next.";
			// 
			// WizardProcessingPage
			// 
			this.WizardProcessingPage.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.WizardProcessingPage.AntiAlias = false;
			this.WizardProcessingPage.BackButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
			this.WizardProcessingPage.BackColor = System.Drawing.Color.Transparent;
			this.WizardProcessingPage.CancelButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
			this.WizardProcessingPage.Controls.AddRange(new System.Windows.Forms.Control[] {
																							   this.Label4,
																							   this.ProgressBar1});
			this.WizardProcessingPage.Location = new System.Drawing.Point(7, 72);
			this.WizardProcessingPage.Name = "WizardProcessingPage";
			this.WizardProcessingPage.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
			this.WizardProcessingPage.PageDescription = "This page does some processing first and displays progress bar while it is doing " +
				"the work";
			this.WizardProcessingPage.PageTitle = "Processing Wizard Page ";
			this.WizardProcessingPage.Size = new System.Drawing.Size(520, 236);
			this.WizardProcessingPage.TabIndex = 8;
			this.WizardProcessingPage.AfterPageDisplayed += new DevComponents.DotNetBar.WizardPageChangeEventHandler(this.WizardProcessingPage_AfterPageDisplayed);
			// 
			// Label4
			// 
			this.Label4.Location = new System.Drawing.Point(64, 127);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(384, 16);
			this.Label4.TabIndex = 1;
			this.Label4.Text = "Please wait...";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ProgressBar1
			// 
			this.ProgressBar1.Location = new System.Drawing.Point(64, 95);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new System.Drawing.Size(392, 24);
			this.ProgressBar1.TabIndex = 0;
			// 
			// WizardExePathChoicePage
			// 
			this.WizardExePathChoicePage.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.WizardExePathChoicePage.AntiAlias = false;
			this.WizardExePathChoicePage.BackColor = System.Drawing.Color.Transparent;
			this.WizardExePathChoicePage.Controls.AddRange(new System.Windows.Forms.Control[] {
																								  this.optionExecutionPath2,
																								  this.optionExecutionPath1,
																								  this.Label5});
			this.WizardExePathChoicePage.Location = new System.Drawing.Point(7, 72);
			this.WizardExePathChoicePage.Name = "WizardExePathChoicePage";
			this.WizardExePathChoicePage.PageDescription = "Setup custom execution path for the Wizard";
			this.WizardExePathChoicePage.PageTitle = "Custom Execution Path";
			this.WizardExePathChoicePage.Size = new System.Drawing.Size(520, 236);
			this.WizardExePathChoicePage.TabIndex = 9;
			// 
			// optionExecutionPath2
			// 
			this.optionExecutionPath2.Location = new System.Drawing.Point(56, 107);
			this.optionExecutionPath2.Name = "optionExecutionPath2";
			this.optionExecutionPath2.Size = new System.Drawing.Size(400, 24);
			this.optionExecutionPath2.TabIndex = 2;
			this.optionExecutionPath2.Text = "Execution Path 2, has one more step and different finish page";
			// 
			// optionExecutionPath1
			// 
			this.optionExecutionPath1.Checked = true;
			this.optionExecutionPath1.Location = new System.Drawing.Point(56, 72);
			this.optionExecutionPath1.Name = "optionExecutionPath1";
			this.optionExecutionPath1.Size = new System.Drawing.Size(408, 24);
			this.optionExecutionPath1.TabIndex = 1;
			this.optionExecutionPath1.TabStop = true;
			this.optionExecutionPath1.Text = "Execution Path 1, ends up with the finish page after you click Next";
			// 
			// Label5
			// 
			this.Label5.Location = new System.Drawing.Point(32, 32);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(456, 32);
			this.Label5.TabIndex = 0;
			this.Label5.Text = "You can have multiple wizard execution paths by manually switching page in Wizard" +
				"PageChanging event";
			// 
			// WizardFinish1Page
			// 
			this.WizardFinish1Page.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.WizardFinish1Page.AntiAlias = false;
			this.WizardFinish1Page.BackColor = System.Drawing.Color.Transparent;
			this.WizardFinish1Page.Controls.AddRange(new System.Windows.Forms.Control[] {
																							this.Label7,
																							this.Label6});
			this.WizardFinish1Page.FinishButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.True;
			this.WizardFinish1Page.InteriorPage = false;
			this.WizardFinish1Page.Name = "WizardFinish1Page";
			this.WizardFinish1Page.Size = new System.Drawing.Size(534, 320);
			this.WizardFinish1Page.TabIndex = 10;
			// 
			// Label7
			// 
			this.Label7.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.Label7.BackColor = System.Drawing.Color.Transparent;
			this.Label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label7.Location = new System.Drawing.Point(216, 294);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(152, 13);
			this.Label7.TabIndex = 3;
			this.Label7.Text = "To close Wizard, click Finish.";
			// 
			// Label6
			// 
			this.Label6.BackColor = System.Drawing.Color.Transparent;
			this.Label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label6.Location = new System.Drawing.Point(16, 24);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(504, 32);
			this.Label6.TabIndex = 0;
			this.Label6.Text = "This is Wizard Finish Page, execution Path #1";
			// 
			// WizardSimpleValidationPage
			// 
			this.WizardSimpleValidationPage.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.WizardSimpleValidationPage.AntiAlias = false;
			this.WizardSimpleValidationPage.BackColor = System.Drawing.Color.Transparent;
			this.WizardSimpleValidationPage.Controls.AddRange(new System.Windows.Forms.Control[] {
																									 this.CheckPageSwitch});
			this.WizardSimpleValidationPage.Location = new System.Drawing.Point(7, 72);
			this.WizardSimpleValidationPage.Name = "WizardSimpleValidationPage";
			this.WizardSimpleValidationPage.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
			this.WizardSimpleValidationPage.PageDescription = "Using just one line of code the execution path of Wizard can be changed and multi" +
				"ple paths created";
			this.WizardSimpleValidationPage.PageTitle = "Execution Path #2";
			this.WizardSimpleValidationPage.Size = new System.Drawing.Size(520, 236);
			this.WizardSimpleValidationPage.TabIndex = 11;
			// 
			// CheckPageSwitch
			// 
			this.CheckPageSwitch.Location = new System.Drawing.Point(56, 96);
			this.CheckPageSwitch.Name = "CheckPageSwitch";
			this.CheckPageSwitch.Size = new System.Drawing.Size(408, 16);
			this.CheckPageSwitch.TabIndex = 0;
			this.CheckPageSwitch.Text = "Click this check box to enable switching to next page";
			this.CheckPageSwitch.CheckedChanged += new System.EventHandler(this.CheckPageSwitch_CheckedChanged);
			// 
			// WizardPage2
			// 
			this.WizardPage2.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.WizardPage2.AntiAlias = false;
			this.WizardPage2.BackColor = System.Drawing.Color.Transparent;
			this.WizardPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.Label8,
																					  this.Label9});
			this.WizardPage2.InteriorPage = false;
			this.WizardPage2.Name = "WizardPage2";
			this.WizardPage2.Size = new System.Drawing.Size(534, 320);
			this.WizardPage2.TabIndex = 12;
			// 
			// Label8
			// 
			this.Label8.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.Label8.BackColor = System.Drawing.Color.Transparent;
			this.Label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label8.Location = new System.Drawing.Point(216, 289);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(216, 13);
			this.Label8.TabIndex = 5;
			this.Label8.Text = "To close Wizard, click Finish.";
			// 
			// Label9
			// 
			this.Label9.BackColor = System.Drawing.Color.Transparent;
			this.Label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label9.Location = new System.Drawing.Point(16, 19);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(504, 32);
			this.Label9.TabIndex = 4;
			this.Label9.Text = "This is Wizard Finish Page, execution Path #2";
			// 
			// Timer1
			// 
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(194)), ((System.Byte)(217)), ((System.Byte)(247)));
			this.ClientSize = new System.Drawing.Size(534, 366);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.Wizard1});
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Sample Wizard";
			this.Wizard1.ResumeLayout(false);
			this.WizardWelcomePage.ResumeLayout(false);
			this.WizardProcessingPage.ResumeLayout(false);
			this.WizardExePathChoicePage.ResumeLayout(false);
			this.WizardFinish1Page.ResumeLayout(false);
			this.WizardSimpleValidationPage.ResumeLayout(false);
			this.WizardPage2.ResumeLayout(false);
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

		private void Wizard1_CancelButtonClick(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(DevComponents.DotNetBar.MessageBoxEx.Show("Close Wizard?","Wizard", MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.Yes)
				this.Close();
		}

		private void Wizard1_FinishButtonClick(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// Execute finish code for the wizard... We will just close the form
			this.Close();
		}

		private void Timer1_Tick(object sender, System.EventArgs e)
		{
			ProgressBar1.Value = ProgressBar1.Value + 5;
			if(ProgressBar1.Value >= 100)
			{
				// Disable timer
				Timer1.Enabled = false;
				
				// Allow user to click to next step
				WizardProcessingPage.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.Auto;
				WizardProcessingPage.BackButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.Auto;
				WizardProcessingPage.FinishButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.Auto;
				WizardProcessingPage.CancelButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.Auto;

				Label4.Text = "Processing complete. Click Next to continue...";

				ProgressBar1.Value = 0;
			}
		}

		private void WizardProcessingPage_AfterPageDisplayed(object sender, DevComponents.DotNetBar.WizardPageChangeEventArgs e)
		{
			// Do not process anything if user is just stepping back
			if(e.PageChangeSource == DevComponents.DotNetBar.eWizardPageChangeSource.NextButton)
			{
				Label4.Text = "Please Wait...";
				Timer1.Enabled = true;
			}
		}

		private void Wizard1_WizardPageChanging(object sender, DevComponents.DotNetBar.WizardCancelPageChangeEventArgs e)
		{
			// Using this event the flow of the Wizard can be changed...

			// It is imporant to check which page was active so this is applied only after Next button is clicked on that page
			if(e.OldPage == WizardExePathChoicePage && e.PageChangeSource == DevComponents.DotNetBar.eWizardPageChangeSource.NextButton)
			{
				if(optionExecutionPath2.Checked)
				{
					// You can simply set the NewPage property to the next page you wish
					// to display and that way change Wizard execution path...
					e.NewPage = WizardSimpleValidationPage;
				}
            }
		}

		private void CheckPageSwitch_CheckedChanged(object sender, System.EventArgs e)
		{
			if(CheckPageSwitch.Checked)
				WizardSimpleValidationPage.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.Auto;
			else
				WizardSimpleValidationPage.NextButtonEnabled = DevComponents.DotNetBar.eWizardButtonState.False;
		}
	}
}
