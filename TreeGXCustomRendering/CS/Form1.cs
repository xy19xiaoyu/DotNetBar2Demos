using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevComponents.Tree;

namespace CustomRendering
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DevComponents.Tree.TreeGX treeGX1;
		private DevComponents.Tree.Node node1;
		private DevComponents.Tree.NodeConnector nodeConnector1;
		private DevComponents.Tree.NodeConnector nodeConnector2;
		private DevComponents.Tree.ElementStyle elementStyle1;
		private DevComponents.Tree.Node node3;
		private DevComponents.Tree.Node nodeCustomRender;
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
			this.treeGX1 = new DevComponents.Tree.TreeGX();
			this.node1 = new DevComponents.Tree.Node();
			this.nodeConnector1 = new DevComponents.Tree.NodeConnector();
			this.nodeConnector2 = new DevComponents.Tree.NodeConnector();
			this.elementStyle1 = new DevComponents.Tree.ElementStyle();
			this.nodeCustomRender = new DevComponents.Tree.Node();
			this.node3 = new DevComponents.Tree.Node();
			((System.ComponentModel.ISupportInitialize)(this.treeGX1)).BeginInit();
			this.SuspendLayout();
			// 
			// treeGX1
			// 
			this.treeGX1.AllowDrop = true;
			this.treeGX1.AutoScrollMinSize = new System.Drawing.Size(44, 22);
			// 
			// treeGX1.BackgroundStyle
			// 
			this.treeGX1.BackgroundStyle.BackColor2SchemePart = DevComponents.Tree.eColorSchemePart.BarBackground2;
			this.treeGX1.BackgroundStyle.BackColorGradientAngle = 90;
			this.treeGX1.BackgroundStyle.BackColorSchemePart = DevComponents.Tree.eColorSchemePart.BarBackground;
			this.treeGX1.CommandBackColorGradientAngle = 90;
			this.treeGX1.CommandMouseOverBackColor2SchemePart = DevComponents.Tree.eColorSchemePart.ItemHotBackground2;
			this.treeGX1.CommandMouseOverBackColorGradientAngle = 90;
			this.treeGX1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeGX1.ExpandLineColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder;
			this.treeGX1.Location = new System.Drawing.Point(0, 0);
			this.treeGX1.Name = "treeGX1";
			this.treeGX1.Nodes.AddRange(new DevComponents.Tree.Node[] {
																		  this.node1});
			this.treeGX1.NodesConnector = this.nodeConnector2;
			this.treeGX1.NodeStyle = this.elementStyle1;
			this.treeGX1.PathSeparator = ";";
			this.treeGX1.RootConnector = this.nodeConnector1;
			this.treeGX1.Size = new System.Drawing.Size(328, 222);
			this.treeGX1.Styles.Add(this.elementStyle1);
			this.treeGX1.SuspendPaint = false;
			this.treeGX1.TabIndex = 0;
			this.treeGX1.Text = "treeGX1";
			// 
			// node1
			// 
			this.node1.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default;
			this.node1.Expanded = true;
			this.node1.Name = "node1";
			this.node1.Nodes.AddRange(new DevComponents.Tree.Node[] {
																		this.nodeCustomRender,
																		this.node3});
			this.node1.Text = "node1";
			// 
			// nodeConnector1
			// 
			this.nodeConnector1.LineWidth = 5;
			// 
			// nodeConnector2
			// 
			this.nodeConnector2.LineWidth = 5;
			// 
			// elementStyle1
			// 
			this.elementStyle1.BackColor2SchemePart = DevComponents.Tree.eColorSchemePart.BarBackground2;
			this.elementStyle1.BackColorGradientAngle = 90;
			this.elementStyle1.BackColorSchemePart = DevComponents.Tree.eColorSchemePart.BarBackground;
			this.elementStyle1.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid;
			this.elementStyle1.BorderBottomWidth = 1;
			this.elementStyle1.BorderColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder;
			this.elementStyle1.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid;
			this.elementStyle1.BorderLeftWidth = 1;
			this.elementStyle1.BorderRight = DevComponents.Tree.eStyleBorderType.Solid;
			this.elementStyle1.BorderRightWidth = 1;
			this.elementStyle1.BorderTop = DevComponents.Tree.eStyleBorderType.Solid;
			this.elementStyle1.BorderTopWidth = 1;
			this.elementStyle1.CornerDiameter = 4;
			this.elementStyle1.CornerType = DevComponents.Tree.eCornerType.Rounded;
			this.elementStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.elementStyle1.Name = "elementStyle1";
			this.elementStyle1.PaddingBottom = 3;
			this.elementStyle1.PaddingLeft = 3;
			this.elementStyle1.PaddingRight = 3;
			this.elementStyle1.PaddingTop = 3;
			this.elementStyle1.TextColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			// 
			// nodeCustomRender
			// 
			this.nodeCustomRender.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default;
			this.nodeCustomRender.Expanded = true;
			this.nodeCustomRender.Name = "nodeCustomRender";
			this.nodeCustomRender.Text = "Custom Rendered Node";
			// 
			// node3
			// 
			this.node3.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default;
			this.node3.Expanded = true;
			this.node3.Name = "node3";
			this.node3.Text = "node3";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(328, 222);
			this.Controls.Add(this.treeGX1);
			this.Name = "Form1";
			this.Text = "Custom Redering";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.treeGX1)).EndInit();
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
			// Indicate that custom rendering will be used for this node
			nodeCustomRender.RenderMode = eNodeRenderMode.Custom;
			// Assign renderer, renderers can be reused i.e. assigned to more than one node
			RedNodeRenderer renderer=new RedNodeRenderer();
			nodeCustomRender.NodeRenderer = renderer;
		}
	}
}
