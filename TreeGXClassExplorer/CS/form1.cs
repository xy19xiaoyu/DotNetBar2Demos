using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ClassExplorer
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
		private DevComponents.Tree.ElementStyle nodeStyle;
		private DevComponents.Tree.ElementStyle styleClass;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelZoom;
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
			this.nodeConnector2 = new DevComponents.Tree.NodeConnector();
			this.nodeStyle = new DevComponents.Tree.ElementStyle();
			this.nodeConnector1 = new DevComponents.Tree.NodeConnector();
			this.styleClass = new DevComponents.Tree.ElementStyle();
			this.panel1 = new System.Windows.Forms.Panel();
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
			this.treeGX1.AutoScrollMinSize = new System.Drawing.Size(44, 22);
			// 
			// treeGX1.BackgroundStyle
			// 
			this.treeGX1.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.treeGX1.BackgroundStyle.BackColorGradientAngle = 90;
			this.treeGX1.CommandBackColorGradientAngle = 90;
			this.treeGX1.CommandMouseOverBackColor2SchemePart = DevComponents.Tree.eColorSchemePart.ItemHotBackground2;
			this.treeGX1.CommandMouseOverBackColorGradientAngle = 90;
			this.treeGX1.DiagramLayoutFlow = DevComponents.Tree.eDiagramFlow.TopToBottom;
			this.treeGX1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeGX1.ExpandLineColorSchemePart = DevComponents.Tree.eColorSchemePart.BarDockedBorder;
			this.treeGX1.Location = new System.Drawing.Point(0, 32);
			this.treeGX1.Name = "treeGX1";
			this.treeGX1.Nodes.AddRange(new DevComponents.Tree.Node[] {
																		  this.node1});
			this.treeGX1.NodesConnector = this.nodeConnector2;
			this.treeGX1.NodeStyle = this.nodeStyle;
			this.treeGX1.NodeVerticalSpacing = 8;
			this.treeGX1.PathSeparator = ";";
			this.treeGX1.RootConnector = this.nodeConnector1;
			this.treeGX1.Size = new System.Drawing.Size(457, 341);
			this.treeGX1.Styles.Add(this.nodeStyle);
			this.treeGX1.Styles.Add(this.styleClass);
			this.treeGX1.SuspendPaint = false;
			this.treeGX1.TabIndex = 0;
			this.treeGX1.Text = "treeGX1";
			// 
			// node1
			// 
			this.node1.CellPartLayout = DevComponents.Tree.eCellPartLayout.Default;
			this.node1.Expanded = true;
			this.node1.Name = "node1";
			this.node1.Text = "node1";
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
			this.nodeStyle.PaddingBottom = 4;
			this.nodeStyle.PaddingLeft = 4;
			this.nodeStyle.PaddingRight = 4;
			this.nodeStyle.PaddingTop = 4;
			this.nodeStyle.TextColor = System.Drawing.SystemColors.ControlText;
			// 
			// nodeConnector1
			// 
			this.nodeConnector1.LineWidth = 5;
			// 
			// styleClass
			// 
			this.styleClass.BackColor2SchemePart = DevComponents.Tree.eColorSchemePart.ItemHotBackground2;
			this.styleClass.BackColorGradientAngle = 90;
			this.styleClass.BackColorSchemePart = DevComponents.Tree.eColorSchemePart.ItemHotBackground;
			this.styleClass.BorderBottom = DevComponents.Tree.eStyleBorderType.Solid;
			this.styleClass.BorderBottomWidth = 1;
			this.styleClass.BorderColorSchemePart = DevComponents.Tree.eColorSchemePart.ItemHotBorder;
			this.styleClass.BorderLeft = DevComponents.Tree.eStyleBorderType.Solid;
			this.styleClass.BorderLeftWidth = 1;
			this.styleClass.BorderRight = DevComponents.Tree.eStyleBorderType.Solid;
			this.styleClass.BorderRightWidth = 1;
			this.styleClass.BorderTop = DevComponents.Tree.eStyleBorderType.Solid;
			this.styleClass.BorderTopWidth = 1;
			this.styleClass.CornerDiameter = 4;
			this.styleClass.CornerType = DevComponents.Tree.eCornerType.Rounded;
			this.styleClass.Name = "styleClass";
			this.styleClass.PaddingBottom = 4;
			this.styleClass.PaddingLeft = 4;
			this.styleClass.PaddingRight = 4;
			this.styleClass.PaddingTop = 4;
			this.styleClass.TextColorSchemePart = DevComponents.Tree.eColorSchemePart.ItemHotText;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.labelZoom);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.trackBar1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(457, 32);
			this.panel1.TabIndex = 1;
			// 
			// labelZoom
			// 
			this.labelZoom.Location = new System.Drawing.Point(178, 8);
			this.labelZoom.Name = "labelZoom";
			this.labelZoom.Size = new System.Drawing.Size(37, 15);
			this.labelZoom.TabIndex = 2;
			this.labelZoom.Text = "100%";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(143, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Zoom: ";
			// 
			// trackBar1
			// 
			this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.trackBar1.AutoSize = false;
			this.trackBar1.LargeChange = 50;
			this.trackBar1.Location = new System.Drawing.Point(216, 4);
			this.trackBar1.Maximum = 400;
			this.trackBar1.Minimum = 20;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(237, 24);
			this.trackBar1.SmallChange = 10;
			this.trackBar1.TabIndex = 0;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBar1.Value = 100;
			this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(457, 373);
			this.Controls.Add(this.treeGX1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
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
			LoadMainClass(typeof(DevComponents.Tree.TreeGX));
		}

		#region Type Loader
		private Hashtable m_EnumeratedTypes=null;
		private void LoadMainClass(Type rootType)
		{
			m_EnumeratedTypes=new Hashtable();
			treeGX1.BeginUpdate();
			treeGX1.Nodes.Clear();
			try
			{
				DevComponents.Tree.Node node=new DevComponents.Tree.Node();
				node.Text=GetTypeName(rootType);
				node.Expanded=true;
				node.Image=new Bitmap(typeof(Form1),"Component2.png");
				m_EnumeratedTypes.Add(GetTypeName(rootType),"");
				treeGX1.Nodes.Add(node);
				Type[] usedClasses=GetUsedClasses(rootType);
				LoadClasses(usedClasses,node);
			}
			finally
			{
				treeGX1.EndUpdate();
			}
			m_EnumeratedTypes.Clear();
		}

		private string GetTypeName(Type type)
		{
			return type.Name;
		}

		private void LoadClasses(Type[] classes, DevComponents.Tree.Node parentNode)
		{
			if(classes.Length==0)
				return;

			// Load Classes first
			foreach(Type t in classes)
			{
				if(t.IsClass)
				{
					DevComponents.Tree.Node node=new DevComponents.Tree.Node();
					node.Text=GetTypeName(t);
					if(t==typeof(DevComponents.Tree.Node))
					{
						node.Image=new Bitmap(typeof(Form1),"Component2.png");
						node.CheckBoxVisible=true;
					}
					node.Style=styleClass;
					parentNode.Nodes.Add(node);
					Type[] usedClasses=GetUsedClasses(t);
					LoadClasses(usedClasses,node);
				}
			}

			foreach(Type t in classes)
			{
				if(!t.IsClass)
				{
					DevComponents.Tree.Node node=new DevComponents.Tree.Node();
					node.Text=GetTypeName(t);
					parentNode.Nodes.Add(node);
					Type[] usedClasses=GetUsedClasses(t);
					LoadClasses(usedClasses,node);
				}
			}
		}

		private Type[] GetUsedClasses(Type rootType)
		{
			System.Reflection.PropertyInfo[] properties=rootType.GetProperties();
			ArrayList usedClasses=new ArrayList();
			foreach(System.Reflection.PropertyInfo prop in properties)
			{
				if(prop.PropertyType.Namespace.IndexOf("DevComponents")>=0 && !m_EnumeratedTypes.ContainsKey(GetTypeName(prop.PropertyType)))
				{
					usedClasses.Add(prop.PropertyType);
					m_EnumeratedTypes.Add(GetTypeName(prop.PropertyType),"");
				}
			}
			return (Type[])usedClasses.ToArray(typeof(Type));
		}
		#endregion

		private void trackBar1_ValueChanged(object sender, System.EventArgs e)
		{
			treeGX1.Zoom=(float)trackBar1.Value/100;
			labelZoom.Text=trackBar1.Value.ToString()+"%";
		}
	}
}
