using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace ControlHosting
{
	/// <summary>
	/// Summary description for EmployeeCard.
	/// </summary>
	public class EmployeeCard : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.LinkLabel labelName;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.Label labelBlog;
		
		private bool m_Expanded=false;
		private int m_ExpandedHeight=0;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public EmployeeCard()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			
			m_ExpandedHeight=this.Height;
			this.Height = labelTitle.Height;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(EmployeeCard));
			this.labelName = new System.Windows.Forms.LinkLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelPhone = new System.Windows.Forms.Label();
			this.labelBlog = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelName
			// 
			this.labelName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelName.Location = new System.Drawing.Point(0, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(176, 18);
			this.labelName.TabIndex = 0;
			this.labelName.TabStop = true;
			this.labelName.Text = "linkLabel1";
			this.labelName.Click += new System.EventHandler(this.labelName_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-8, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 64);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// labelTitle
			// 
			this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.labelTitle.Location = new System.Drawing.Point(56, 32);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(120, 16);
			this.labelTitle.TabIndex = 2;
			this.labelTitle.Text = "Title";
			// 
			// labelPhone
			// 
			this.labelPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.labelPhone.Location = new System.Drawing.Point(56, 48);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(120, 16);
			this.labelPhone.TabIndex = 3;
			this.labelPhone.Text = "Phone Nr";
			// 
			// labelBlog
			// 
			this.labelBlog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.labelBlog.Location = new System.Drawing.Point(56, 64);
			this.labelBlog.Name = "labelBlog";
			this.labelBlog.Size = new System.Drawing.Size(120, 16);
			this.labelBlog.TabIndex = 4;
			this.labelBlog.Text = "Blog";
			// 
			// EmployeeCard
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.labelBlog);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelName);
			this.Name = "EmployeeCard";
			this.Size = new System.Drawing.Size(176, 88);
			this.ResumeLayout(false);

		}
		#endregion

		private void labelName_Click(object sender, System.EventArgs e)
		{
			this.Expanded = !this.Expanded;
		}

		public string EmployeeName
		{
			get { return labelName.Text; }
			set { labelName.Text = value; }
		}
		
		public string EmployeeTitle
		{
			get { return labelTitle.Text; }
			set { labelTitle.Text = value; }
		}

		public string EmployeePhone
		{
			get { return labelPhone.Text; }
			set { labelPhone.Text = value; 
			}
		}

		public string EmployeeBlog
		{
			get { return labelBlog.Text; }
			set { labelBlog.Text = value; }
		}
		
		public bool Expanded
		{
			get
			{
				return m_Expanded;
			}
			set
			{
				m_Expanded = value;
				Size size=this.Size;
				if(this.Parent is DevComponents.Tree.TreeGX)
					size = ((DevComponents.Tree.TreeGX) this.Parent).GetLayoutRectangle(this.Bounds).Size;
				
				if(m_Expanded)
					size.Height=m_ExpandedHeight;
				else
					size.Height = labelTitle.Height;
				this.Size = size;
			}
		}
	}
}
