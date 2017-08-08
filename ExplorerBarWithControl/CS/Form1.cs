using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.DotNetBar;

namespace ExplorerBarWithControl
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevComponents.DotNetBar.ExplorerBar explorerBar1;
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
			this.explorerBar1 = new DevComponents.DotNetBar.ExplorerBar();
			((System.ComponentModel.ISupportInitialize)(this.explorerBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// explorerBar1
			// 
			this.explorerBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
			this.explorerBar1.BackColor = System.Drawing.SystemColors.Control;
			// 
			// explorerBar1.BackStyle
			// 
			this.explorerBar1.BackStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(123)), ((System.Byte)(162)), ((System.Byte)(231)));
			this.explorerBar1.BackStyle.BackColor2 = System.Drawing.Color.FromArgb(((System.Byte)(99)), ((System.Byte)(117)), ((System.Byte)(214)));
			this.explorerBar1.BackStyle.BackColorGradientAngle = 90;
			this.explorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.explorerBar1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.explorerBar1.GroupImages = null;
			this.explorerBar1.Images = null;
			this.explorerBar1.Name = "explorerBar1";
			this.explorerBar1.Size = new System.Drawing.Size(240, 366);
			this.explorerBar1.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors;
			this.explorerBar1.TabIndex = 0;
			this.explorerBar1.TabStop = false;
			this.explorerBar1.Text = "explorerBar1";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(240, 366);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.explorerBar1});
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.explorerBar1)).EndInit();
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			ExplorerBarGroupItem group=new ExplorerBarGroupItem("group1","Search");
			group.SetDefaultAppearance();
			explorerBar1.Groups.Add(group);

			LabelItem label=new LabelItem("searchLabel","Search by any or all of the criteria below.");
			label.Stretch=true;
			label.WordWrap=true;
			label.Font=new Font(explorerBar1.Font,FontStyle.Bold);
			group.SubItems.Add(label);

			label=new LabelItem("searchLabel1","All or part of the file name:");
			label.Stretch=true;
			label.WordWrap=true;
			group.SubItems.Add(label);

			// Hosting Text Box on Explorer Bar
			TextBoxItem textItem=new TextBoxItem("txtFileName");
			textItem.Stretch=true;
			group.SubItems.Add(textItem);

			// Hosting Label on Explorer Bar
			label=new LabelItem("searchLabel2","Look in:");
			label.Stretch=true;
			label.WordWrap=true;
			group.SubItems.Add(label);

			// Hosting Combo Box on Explorer Bar
			ComboBoxItem combo=new ComboBoxItem("cboLookIn");
			combo.Stretch=true;
			DevComponents.Editors.ComboItem cboItem=new DevComponents.Editors.ComboItem();
			cboItem.Text="My Computer";
			combo.Items.Add(cboItem);
			combo.SelectedIndex=0;
			group.SubItems.Add(combo);

			group.Expanded=true;

			group=new ExplorerBarGroupItem("group2","When was it modified?");
			group.SetDefaultAppearance();
			explorerBar1.Groups.Add(group);
			
			// Hosting any .NET controls on Explorer Bar in this case RadioButton
			// Don't remember Option
			ControlContainerItem cont=new ControlContainerItem("chk1","Don't Remember");
			RadioButton option=new RadioButton();
			option.Name="chkDontRemember";
			option.Text="Don't Remember";
			option.Font=new Font(explorerBar1.Font,FontStyle.Bold);
			option.Checked=true;
			option.BackColor=Color.Transparent;
			cont.Control=option;
			group.SubItems.Add(cont);

			// Within last week
			cont=new ControlContainerItem("chk1","Within last week");
			option=new RadioButton();
			option.Name="chkLastweek";
			option.Text="Within last week";
			option.BackColor=Color.Transparent;
			cont.Control=option;
			group.SubItems.Add(cont);

			// Past month
			cont=new ControlContainerItem("chk1","Past month");
			option=new RadioButton();
			option.Name="chkLastMonth";
			option.Text="Past month";
			option.BackColor=Color.Transparent;
			cont.Control=option;
			group.SubItems.Add(cont);

			// Within the past year
			cont=new ControlContainerItem("chk1","Within the past year");
			option=new RadioButton();
			option.Name="chkLastYear";
			option.Text="Within the past year";
			option.BackColor=Color.Transparent;
			cont.Control=option;
			group.SubItems.Add(cont);

			group=new ExplorerBarGroupItem("group3","Additional Options");
			group.SetDefaultAppearance();
			explorerBar1.Groups.Add(group);
			group.Expanded=true;

			// Other Search Options
			ButtonItem btn=new ButtonItem("bSearchOptions","Other search options");
			btn.HotFontUnderline=true;
			btn.HotTrackingStyle=eHotTrackingStyle.None;
			btn.Image=new Bitmap(this.GetType(),"Options.png");
			btn.ImagePosition=eImagePosition.Left;
			btn.ButtonStyle=eButtonStyle.ImageAndText;
			btn.Cursor=Cursors.Hand;
			group.SubItems.Add(btn);

			// Change Preferences
			btn=new ButtonItem("bPreferences","Change Preferences");
			btn.HotFontUnderline=true;
			btn.HotTrackingStyle=eHotTrackingStyle.None;
			btn.Image=new Bitmap(this.GetType(),"Preferences.png");
			btn.ImagePosition=eImagePosition.Left;
			btn.ButtonStyle=eButtonStyle.ImageAndText;
			btn.Cursor=Cursors.Hand;
			group.SubItems.Add(btn);
			
			// Applies all layout changes and refreshes display
			explorerBar1.RecalcLayout();
		}
	}
}
