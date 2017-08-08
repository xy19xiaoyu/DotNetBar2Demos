using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ControlHosting
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
		private DevComponents.Tree.ElementStyle nodeStyle;
		private DevComponents.Tree.Node node2;
		private DevComponents.Tree.Node node3;
		private DevComponents.Tree.Node node4;
		private DevComponents.Tree.Node node8;
		private DevComponents.Tree.Node node5;
		private DevComponents.Tree.Node node6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox comboLayout;
		private System.Windows.Forms.ComboBox comboLayoutType;
		private DevComponents.Tree.Node node7;
		private DevComponents.Tree.Node node9;
		private ControlHosting.EmployeeCard employeeCard1;
		private ControlHosting.EmployeeCard employeeCard2;
		private ControlHosting.EmployeeCard employeeCard3;
		private ControlHosting.EmployeeCard employeeCard4;
		private System.Windows.Forms.Label labelZoom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar trackBar1;
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
			this.treeGX1 = new DevComponents.Tree.TreeGX();
			this.node1 = new DevComponents.Tree.Node();
			this.node2 = new DevComponents.Tree.Node();
			this.node4 = new DevComponents.Tree.Node();
			this.employeeCard1 = new ControlHosting.EmployeeCard();
			this.node8 = new DevComponents.Tree.Node();
			this.employeeCard2 = new ControlHosting.EmployeeCard();
			this.node3 = new DevComponents.Tree.Node();
			this.node5 = new DevComponents.Tree.Node();
			this.employeeCard3 = new ControlHosting.EmployeeCard();
			this.node6 = new DevComponents.Tree.Node();
			this.employeeCard4 = new ControlHosting.EmployeeCard();
			this.node7 = new DevComponents.Tree.Node();
			this.node9 = new DevComponents.Tree.Node();
			this.nodeConnector2 = new DevComponents.Tree.NodeConnector();
			this.nodeStyle = new DevComponents.Tree.ElementStyle();
			this.nodeConnector1 = new DevComponents.Tree.NodeConnector();
			this.panel1 = new System.Windows.Forms.Panel();
			this.comboLayoutType = new System.Windows.Forms.ComboBox();
			this.comboLayout = new System.Windows.Forms.ComboBox();
			this.labelZoom = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.treeGX1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// treeGX1
			// 
			this.treeGX1.AllowDrop = true;
			this.treeGX1.AutoScrollMinSize = new System.Drawing.Size(660, 364);
			this.treeGX1.BackColor = System.Drawing.Color.White;
			// 
			// treeGX1.BackgroundStyle
			// 
			this.treeGX1.BackgroundStyle.BorderTop = DevComponents.Tree.eStyleBorderType.Dash;
			this.treeGX1.BackgroundStyle.BorderTopColor = System.Drawing.Color.CornflowerBlue;
			this.treeGX1.BackgroundStyle.BorderTopWidth = 1;
			this.treeGX1.CommandBackColorGradientAngle = 90;
			this.treeGX1.CommandMouseOverBackColor2SchemePart = DevComponents.Tree.eColorSchemePart.ItemHotBackground2;
			this.treeGX1.CommandMouseOverBackColorGradientAngle = 90;
			this.treeGX1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeGX1.ExpandLineColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder;
			this.treeGX1.Location = new System.Drawing.Point(0, 33);
			this.treeGX1.Name = "treeGX1";
			this.treeGX1.Nodes.AddRange(new DevComponents.Tree.Node[] {
																		  this.node1});
			this.treeGX1.NodesConnector = this.nodeConnector2;
			this.treeGX1.NodeStyle = this.nodeStyle;
			this.treeGX1.PathSeparator = ";";
			this.treeGX1.RootConnector = this.nodeConnector1;
			this.treeGX1.Size = new System.Drawing.Size(701, 309);
			this.treeGX1.Styles.Add(this.nodeStyle);
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
																		this.node2,
																		this.node3,
																		this.node7,
																		this.node9});
			this.node1.Text = "ACME Corp.";
			// 
			// node2
			// 
			this.node2.CellPartLayout = DevComponents.Tree.eCellPartLayout.Vertical;
			this.node2.Image = ((System.Drawing.Image)(resources.GetObject("node2.Image")));
			this.node2.ImageAlignment = DevComponents.Tree.eCellPartAlignment.CenterBottom;
			this.node2.Name = "node2";
			this.node2.Nodes.AddRange(new DevComponents.Tree.Node[] {
																		this.node4});
			this.node2.Text = "Financial";
			// 
			// node4
			// 
			this.node4.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default;
			this.node4.Expanded = true;
			this.node4.HostedControl = this.employeeCard1;
			this.node4.Name = "node4";
			this.node4.Nodes.AddRange(new DevComponents.Tree.Node[] {
																		this.node8});
			this.node4.Text = "EmployeeCard";
			// 
			// employeeCard1
			// 
			this.employeeCard1.BackColor = System.Drawing.Color.White;
			this.employeeCard1.EmployeeBlog = "Blog";
			this.employeeCard1.EmployeeName = "Click To Expand";
			this.employeeCard1.EmployeePhone = "Phone Nr";
			this.employeeCard1.EmployeeTitle = "Title";
			this.employeeCard1.Expanded = false;
			this.employeeCard1.Location = new System.Drawing.Point(339, 85);
			this.employeeCard1.Name = "employeeCard1";
			this.employeeCard1.Size = new System.Drawing.Size(139, 18);
			this.employeeCard1.TabIndex = 4;
			// 
			// node8
			// 
			this.node8.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default;
			this.node8.Expanded = true;
			this.node8.HostedControl = this.employeeCard2;
			this.node8.Name = "node8";
			this.node8.Text = "EmployeeCard";
			// 
			// employeeCard2
			// 
			this.employeeCard2.BackColor = System.Drawing.Color.White;
			this.employeeCard2.EmployeeBlog = "Blog";
			this.employeeCard2.EmployeeName = "Click To Expand";
			this.employeeCard2.EmployeePhone = "Phone Nr";
			this.employeeCard2.EmployeeTitle = "Title";
			this.employeeCard2.Expanded = true;
			this.employeeCard2.Location = new System.Drawing.Point(522, 50);
			this.employeeCard2.Name = "employeeCard2";
			this.employeeCard2.Size = new System.Drawing.Size(152, 88);
			this.employeeCard2.TabIndex = 4;
			// 
			// node3
			// 
			this.node3.CellPartLayout = DevComponents.Tree.eCellPartLayout.Vertical;
			this.node3.Image = ((System.Drawing.Image)(resources.GetObject("node3.Image")));
			this.node3.ImageAlignment = DevComponents.Tree.eCellPartAlignment.FarTop;
			this.node3.Name = "node3";
			this.node3.Nodes.AddRange(new DevComponents.Tree.Node[] {
																		this.node5,
																		this.node6});
			this.node3.Text = "Executive";
			// 
			// node5
			// 
			this.node5.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default;
			this.node5.Expanded = true;
			this.node5.HostedControl = this.employeeCard3;
			this.node5.Name = "node5";
			this.node5.Text = "EmployeeCard";
			// 
			// employeeCard3
			// 
			this.employeeCard3.BackColor = System.Drawing.Color.White;
			this.employeeCard3.EmployeeBlog = "Blog";
			this.employeeCard3.EmployeeName = "Click To Expand";
			this.employeeCard3.EmployeePhone = "Phone Nr";
			this.employeeCard3.EmployeeTitle = "Title";
			this.employeeCard3.Expanded = false;
			this.employeeCard3.Location = new System.Drawing.Point(429, 153);
			this.employeeCard3.Name = "employeeCard3";
			this.employeeCard3.Size = new System.Drawing.Size(142, 16);
			this.employeeCard3.TabIndex = 4;
			// 
			// node6
			// 
			this.node6.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default;
			this.node6.Expanded = true;
			this.node6.HostedControl = this.employeeCard4;
			this.node6.Name = "node6";
			this.node6.Text = "employeeCard3";
			// 
			// employeeCard4
			// 
			this.employeeCard4.BackColor = System.Drawing.Color.White;
			this.employeeCard4.EmployeeBlog = "Blog";
			this.employeeCard4.EmployeeName = "Click To Expand";
			this.employeeCard4.EmployeePhone = "Phone Nr";
			this.employeeCard4.EmployeeTitle = "Title";
			this.employeeCard4.Expanded = false;
			this.employeeCard4.Location = new System.Drawing.Point(429, 213);
			this.employeeCard4.Name = "employeeCard4";
			this.employeeCard4.Size = new System.Drawing.Size(159, 16);
			this.employeeCard4.TabIndex = 4;
			// 
			// node7
			// 
			this.node7.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default;
			this.node7.Expanded = true;
			this.node7.Image = ((System.Drawing.Image)(resources.GetObject("node7.Image")));
			this.node7.ImageAlignment = DevComponents.Tree.eCellPartAlignment.FarCenter;
			this.node7.Name = "node7";
			this.node7.Text = "Human Resources";
			// 
			// node9
			// 
			this.node9.CellPartLayout = DevComponents.Tree.eCellPartLayout.Vertical;
			this.node9.Expanded = true;
			this.node9.Image = ((System.Drawing.Image)(resources.GetObject("node9.Image")));
			this.node9.ImageAlignment = DevComponents.Tree.eCellPartAlignment.CenterTop;
			this.node9.Name = "node9";
			this.node9.Text = "Marketing";
			// 
			// nodeConnector2
			// 
			this.nodeConnector2.LineWidth = 5;
			// 
			// nodeStyle
			// 
			this.nodeStyle.BackColor2SchemePart = DevComponents.Tree.eColorSchemePart.BarBackground2;
			this.nodeStyle.BackColorGradientAngle = 90;
			this.nodeStyle.BackColorSchemePart = DevComponents.Tree.eColorSchemePart.BarBackground;
			this.nodeStyle.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid;
			this.nodeStyle.BorderBottomWidth = 1;
			this.nodeStyle.BorderColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder;
			this.nodeStyle.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid;
			this.nodeStyle.BorderLeftWidth = 1;
			this.nodeStyle.BorderRight = DevComponents.Tree.eStyleBorderType.Solid;
			this.nodeStyle.BorderRightWidth = 1;
			this.nodeStyle.BorderTop = DevComponents.Tree.eStyleBorderType.Solid;
			this.nodeStyle.BorderTopWidth = 1;
			this.nodeStyle.CornerDiameter = 4;
			this.nodeStyle.CornerType = DevComponents.Tree.eCornerType.Rounded;
			this.nodeStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.nodeStyle.Name = "nodeStyle";
			this.nodeStyle.PaddingBottom = 5;
			this.nodeStyle.PaddingLeft = 5;
			this.nodeStyle.PaddingRight = 5;
			this.nodeStyle.PaddingTop = 5;
			this.nodeStyle.TextColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(128)));
			// 
			// nodeConnector1
			// 
			this.nodeConnector1.LineWidth = 5;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.labelZoom);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.trackBar1);
			this.panel1.Controls.Add(this.comboLayoutType);
			this.panel1.Controls.Add(this.comboLayout);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(701, 33);
			this.panel1.TabIndex = 0;
			// 
			// comboLayoutType
			// 
			this.comboLayoutType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboLayoutType.Location = new System.Drawing.Point(192, 6);
			this.comboLayoutType.Name = "comboLayoutType";
			this.comboLayoutType.Size = new System.Drawing.Size(176, 21);
			this.comboLayoutType.TabIndex = 3;
			this.comboLayoutType.SelectedIndexChanged += new System.EventHandler(this.comboLayoutType_SelectedIndexChanged);
			// 
			// comboLayout
			// 
			this.comboLayout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboLayout.Location = new System.Drawing.Point(5, 6);
			this.comboLayout.Name = "comboLayout";
			this.comboLayout.Size = new System.Drawing.Size(176, 21);
			this.comboLayout.TabIndex = 2;
			this.comboLayout.SelectedIndexChanged += new System.EventHandler(this.comboLayout_SelectedIndexChanged);
			// 
			// labelZoom
			// 
			this.labelZoom.Location = new System.Drawing.Point(423, 9);
			this.labelZoom.Name = "labelZoom";
			this.labelZoom.Size = new System.Drawing.Size(37, 15);
			this.labelZoom.TabIndex = 6;
			this.labelZoom.Text = "100%";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(388, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Zoom: ";
			// 
			// trackBar1
			// 
			this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.trackBar1.AutoSize = false;
			this.trackBar1.LargeChange = 50;
			this.trackBar1.Location = new System.Drawing.Point(461, 5);
			this.trackBar1.Maximum = 400;
			this.trackBar1.Minimum = 20;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(237, 24);
			this.trackBar1.SmallChange = 10;
			this.trackBar1.TabIndex = 4;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBar1.Value = 100;
			this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(701, 342);
			this.Controls.Add(this.treeGX1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Control Hosting Demonstration";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.treeGX1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.DoEvents();
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// Assign predefined color styles
			node9.Style=DevComponents.Tree.NodeStyles.Purple;
			node7.Style=DevComponents.Tree.NodeStyles.Orange;
			node2.Style=DevComponents.Tree.NodeStyles.Green;
			node3.Style=DevComponents.Tree.NodeStyles.SilverMist;
			
			comboLayout.Items.AddRange(Enum.GetNames(typeof(DevComponents.Tree.eNodeLayout)));
			comboLayout.SelectedItem="Map";
		}

		private void comboLayout_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			comboLayoutType.Items.Clear();

			if(comboLayout.SelectedItem==null)
			{
				return;
			}

			DevComponents.Tree.eNodeLayout layout=(DevComponents.Tree.eNodeLayout)Enum.Parse(typeof(DevComponents.Tree.eNodeLayout),comboLayout.SelectedItem.ToString());
			if(treeGX1.LayoutType!=layout)
			{
				treeGX1.LayoutType=layout;
				treeGX1.RecalcLayout();
			}
			
			if(layout==DevComponents.Tree.eNodeLayout.Map)
			{
				comboLayoutType.Items.AddRange(Enum.GetNames(typeof(DevComponents.Tree.eMapFlow)));
				comboLayoutType.SelectedItem=treeGX1.MapLayoutFlow.ToString();
			}
			else if(layout==DevComponents.Tree.eNodeLayout.Diagram)
			{
				comboLayoutType.Items.AddRange(Enum.GetNames(typeof(DevComponents.Tree.eDiagramFlow)));
				comboLayoutType.SelectedItem=treeGX1.DiagramLayoutFlow.ToString();
			}
		}

		private void comboLayoutType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(comboLayoutType.SelectedItem==null || comboLayout.SelectedItem==null)
			{
				return;
			}

			DevComponents.Tree.eNodeLayout layout=(DevComponents.Tree.eNodeLayout)Enum.Parse(typeof(DevComponents.Tree.eNodeLayout),comboLayout.SelectedItem.ToString());
			if(layout==DevComponents.Tree.eNodeLayout.Map)
			{
				DevComponents.Tree.eMapFlow mapFlow=(DevComponents.Tree.eMapFlow)Enum.Parse(typeof(DevComponents.Tree.eMapFlow),comboLayoutType.SelectedItem.ToString());
				if(treeGX1.MapLayoutFlow!=mapFlow)
				{
					treeGX1.MapLayoutFlow=mapFlow;
					treeGX1.RecalcLayout();
					treeGX1.Refresh();
				}
			}
			else if(layout==DevComponents.Tree.eNodeLayout.Diagram)
			{
				DevComponents.Tree.eDiagramFlow diagramFlow=(DevComponents.Tree.eDiagramFlow)Enum.Parse(typeof(DevComponents.Tree.eDiagramFlow),comboLayoutType.SelectedItem.ToString());
				if(treeGX1.DiagramLayoutFlow!=diagramFlow)
				{
					treeGX1.DiagramLayoutFlow=diagramFlow;
					treeGX1.RecalcLayout();
					treeGX1.Refresh();
				}
			}
		}

		private void trackBar1_ValueChanged(object sender, System.EventArgs e)
		{
			treeGX1.Zoom=(float)trackBar1.Value/100;
			labelZoom.Text=trackBar1.Value.ToString()+"%";
		}
	}
}
