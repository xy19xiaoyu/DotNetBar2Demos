using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SuperTooltip
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TreeView treeView1;
		private DevComponents.DotNetBar.Bar bar1;
		private DevComponents.DotNetBar.ButtonItem buttonItem1;
		private DevComponents.DotNetBar.ButtonItem buttonItem2;
		private DevComponents.DotNetBar.SuperTooltip superTooltip1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer tooltipDisplayDelay;
		private DevComponents.DotNetBar.PanelEx panelEx1;
		private DevComponents.DotNetBar.SuperTooltip superTooltipWithLink;
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.bar1 = new DevComponents.DotNetBar.Bar();
			this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
			this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
			this.label2 = new System.Windows.Forms.Label();
			this.tooltipDisplayDelay = new System.Windows.Forms.Timer(this.components);
			this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
			this.superTooltipWithLink = new DevComponents.DotNetBar.SuperTooltip();
			((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
			this.panelEx1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(152, 20);
			this.superTooltipWithLink.SetSuperTooltip(this.textBox1, new DevComponents.DotNetBar.SuperTooltipInfo("Text Box Tooltip Header", "<a href=\"TextBoxMoreInfo\">Press F1 key to get more information</a>", "Super Tooltips can have multiple lines of text.\r\n\r\nTo better explain functionalit" +
				"y certain command provides.", null, ((System.Drawing.Bitmap)(resources.GetObject("textBox1.SuperTooltip"))), DevComponents.DotNetBar.eTooltipColor.Gray));
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Place mouse cursor here";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Works with any .NET Control";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 56);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 40);
			this.superTooltip1.SetSuperTooltip(this.button1, new DevComponents.DotNetBar.SuperTooltipInfo("Preview dialog box before opening", "", "Screenshot of your dialog box can be used as body image to preview dialog box so " +
				"user can see what is behind the button without clicking it.", ((System.Drawing.Bitmap)(resources.GetObject("button1.SuperTooltip"))), null, DevComponents.DotNetBar.eTooltipColor.Office2003));
			this.button1.TabIndex = 2;
			this.button1.Text = "Place mouse cursor here";
			// 
			// treeView1
			// 
			this.treeView1.ImageIndex = -1;
			this.treeView1.Location = new System.Drawing.Point(72, 144);
			this.treeView1.Name = "treeView1";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
																				  new System.Windows.Forms.TreeNode("Root Node 1", new System.Windows.Forms.TreeNode[] {
																																										   new System.Windows.Forms.TreeNode("Child Node 1"),
																																										   new System.Windows.Forms.TreeNode("Child Node 2")}),
																				  new System.Windows.Forms.TreeNode("Another Sample root node", new System.Windows.Forms.TreeNode[] {
																																														new System.Windows.Forms.TreeNode("Node4"),
																																														new System.Windows.Forms.TreeNode("Node5")})});
			this.treeView1.SelectedImageIndex = -1;
			this.treeView1.Size = new System.Drawing.Size(320, 128);
			this.treeView1.TabIndex = 3;
			this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
			this.treeView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseMove);
			this.treeView1.MouseLeave += new System.EventHandler(this.treeView1_MouseLeave);
			// 
			// bar1
			// 
			this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
			this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
																				this.buttonItem1,
																				this.buttonItem2});
			this.bar1.Location = new System.Drawing.Point(192, 24);
			this.bar1.Name = "bar1";
			this.bar1.Size = new System.Drawing.Size(184, 25);
			this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
			this.bar1.TabIndex = 4;
			this.bar1.TabStop = false;
			this.bar1.Text = "bar1";
			// 
			// buttonItem1
			// 
			this.buttonItem1.Name = "buttonItem1";
			this.superTooltip1.SetSuperTooltip(this.buttonItem1, new DevComponents.DotNetBar.SuperTooltipInfo("Super Tooltips for DotNetBar items", "", "Standard DotNetBar items can have Super Tooltips assigned as well.\r\n\r\n- RibbonBar" +
				" Control\r\n- Stand-alone Bar control\r\n- Side-bar Control\r\n- Explorer-Bar Control\r" +
				"\n- PanelEx Control\r\n- NavigationPane Control", null, null, DevComponents.DotNetBar.eTooltipColor.Magenta, true, false, new System.Drawing.Size(0, 0)));
			this.buttonItem1.Text = "Open";
			// 
			// buttonItem2
			// 
			this.buttonItem2.Name = "buttonItem2";
			this.superTooltip1.SetSuperTooltip(this.buttonItem2, new DevComponents.DotNetBar.SuperTooltipInfo("18 predefined color schemes", "", "18 predefined colors are available for Super Tooltips.\r\n\r\nDefault Gray color is s" +
				"ame as color scheme used in Office 12", null, null, DevComponents.DotNetBar.eTooltipColor.Teal, true, false, new System.Drawing.Size(0, 0)));
			this.buttonItem2.Text = "Print";
			// 
			// superTooltip1
			// 
			this.superTooltip1.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(72, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(312, 32);
			this.label2.TabIndex = 5;
			this.label2.Text = "Super Tooltip extensibility interface allows you to provide tooltips for any type" +
				" of object even nodes";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tooltipDisplayDelay
			// 
			this.tooltipDisplayDelay.Interval = 1000;
			this.tooltipDisplayDelay.Tick += new System.EventHandler(this.tooltipDisplayDelay_Tick);
			// 
			// panelEx1
			// 
			this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
			this.panelEx1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.treeView1,
																				   this.label2,
																				   this.bar1,
																				   this.button1,
																				   this.label1,
																				   this.textBox1});
			this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelEx1.Name = "panelEx1";
			this.panelEx1.Size = new System.Drawing.Size(464, 286);
			this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.panelEx1.Style.BackColor1.Color = System.Drawing.SystemColors.ControlLightLight;
			this.panelEx1.Style.BackColor2.Color = System.Drawing.SystemColors.Control;
			this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.panelEx1.Style.GradientAngle = 90;
			this.panelEx1.TabIndex = 6;
			// 
			// superTooltipWithLink
			// 
			this.superTooltipWithLink.AntiAlias = false;
			this.superTooltipWithLink.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.superTooltipWithLink.DelayTooltipHideDuration = 1000;
			this.superTooltipWithLink.PositionBelowControl = false;
			this.superTooltipWithLink.MarkupLinkClick += new DevComponents.DotNetBar.MarkupLinkClickEventHandler(this.superTooltipWithLink_MarkupLinkClick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(464, 286);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panelEx1});
			this.Name = "Form1";
			this.Text = "Super Tooltip Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
			this.panelEx1.ResumeLayout(false);
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
			// Load SuperTooltip information for each node...
			TreeNode node=treeView1.Nodes[0];
			while(node!=null)
			{
				// Creates wrapper to provide SuperTooltip control access to the node object
				NodeSuperTooltipProvider sp=new NodeSuperTooltipProvider(node);
				node.Tag=sp;
				// Assign the wrapper to SuperTooltip control together with information
				// about what to display on Super Tooltip for this node.
				superTooltip1.SetSuperTooltip(sp,
					new DevComponents.DotNetBar.SuperTooltipInfo("Header text for "+node.Text,"",
					"Additional body text for this node. \n\r"+node.Text,
					null,null,DevComponents.DotNetBar.eTooltipColor.Lemon));
				
				// Must expand node to get to the child nodes via NextVisibleNode
				node.Expand();
				node=node.NextVisibleNode;
			}
		}

		private TreeNode m_LastMouseOverNode=null;
		private void treeView1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			TreeNode nodeAt=treeView1.GetNodeAt(e.X,e.Y);
			if(nodeAt!=m_LastMouseOverNode)
			{
				HideNodeTooltip();
				if(nodeAt!=null)
				{
					m_LastMouseOverNode=nodeAt;
					// Delayed display
					tooltipDisplayDelay.Start();
				}
			}
		}

		private void ShowNodeTooltip(TreeNode node)
		{
			if(node==null)
				return;

			NodeSuperTooltipProvider sp=node.Tag as NodeSuperTooltipProvider;
			sp.Show();
			m_LastMouseOverNode=node;
		}

		private void treeView1_MouseLeave(object sender, System.EventArgs e)
		{
			// Hide tooltip when mouse leaves tree control
			HideNodeTooltip();
			tooltipDisplayDelay.Stop();
		}

		private void HideNodeTooltip()
		{
			if(m_LastMouseOverNode!=null)
			{
				NodeSuperTooltipProvider sp=m_LastMouseOverNode.Tag as NodeSuperTooltipProvider;
				sp.Hide();
				m_LastMouseOverNode=null;
			}
		}

		private void tooltipDisplayDelay_Tick(object sender, System.EventArgs e)
		{
			tooltipDisplayDelay.Stop();
			if(m_LastMouseOverNode!=null)
				ShowNodeTooltip(m_LastMouseOverNode);
		}

		private void treeView1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// Hide tooltip if any is visible...
			HideNodeTooltip();
		}

		private void superTooltipWithLink_MarkupLinkClick(object sender, DevComponents.DotNetBar.MarkupLinkClickEventArgs e)
		{
			MessageBox.Show("Markup Link Clicked. href = " + e.HRef);
		}
	}
}
