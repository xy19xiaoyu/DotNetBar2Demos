namespace SlidePanel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.slidePanel1 = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonTop = new DevComponents.DotNetBar.ButtonX();
            this.buttonBottom = new DevComponents.DotNetBar.ButtonX();
            this.buttonRight = new DevComponents.DotNetBar.ButtonX();
            this.buttonLeft = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.slidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // slidePanel1
            // 
            this.slidePanel1.Controls.Add(this.labelX4);
            this.slidePanel1.Controls.Add(this.buttonLeft);
            this.slidePanel1.Controls.Add(this.buttonRight);
            this.slidePanel1.Controls.Add(this.buttonBottom);
            this.slidePanel1.Controls.Add(this.buttonTop);
            this.slidePanel1.Controls.Add(this.labelX3);
            this.slidePanel1.Controls.Add(this.buttonX1);
            this.slidePanel1.Controls.Add(this.labelX2);
            this.slidePanel1.Controls.Add(this.labelX1);
            this.slidePanel1.Location = new System.Drawing.Point(12, 5);
            this.slidePanel1.Name = "slidePanel1";
            this.slidePanel1.Size = new System.Drawing.Size(448, 237);
            this.slidePanel1.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right;
            this.slidePanel1.TabIndex = 0;
            this.slidePanel1.Text = "slidePanel1";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(3, 128);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(348, 47);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Click button below to close panel. Then use the panel \"thumb\" on right side to dr" +
                "ag it out. You can drag the panel out or you can just click the thumb to open th" +
                "e panel.";
            this.labelX3.WordWrap = true;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(3, 187);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(107, 37);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 2;
            this.buttonX1.Text = "Click to Slide-Out";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(3, 56);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(348, 66);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = resources.GetString("labelX2.Text");
            this.labelX2.WordWrap = true;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(0, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(448, 50);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "SlidePanel Control";
            // 
            // buttonTop
            // 
            this.buttonTop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonTop.AutoCheckOnClick = true;
            this.buttonTop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonTop.Location = new System.Drawing.Point(394, 154);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(24, 24);
            this.buttonTop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonTop.TabIndex = 4;
            this.buttonTop.Click += new System.EventHandler(this.buttonTop_Click);
            // 
            // buttonBottom
            // 
            this.buttonBottom.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonBottom.AutoCheckOnClick = true;
            this.buttonBottom.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonBottom.Location = new System.Drawing.Point(394, 203);
            this.buttonBottom.Name = "buttonBottom";
            this.buttonBottom.Size = new System.Drawing.Size(24, 24);
            this.buttonBottom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonBottom.TabIndex = 5;
            this.buttonBottom.Click += new System.EventHandler(this.buttonBottom_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonRight.AutoCheckOnClick = true;
            this.buttonRight.Checked = true;
            this.buttonRight.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonRight.Location = new System.Drawing.Point(421, 179);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(24, 24);
            this.buttonRight.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonRight.TabIndex = 6;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonLeft.AutoCheckOnClick = true;
            this.buttonLeft.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonLeft.Location = new System.Drawing.Point(367, 179);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(24, 24);
            this.buttonLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonLeft.TabIndex = 7;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(302, 186);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(62, 17);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = "Slide side:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 254);
            this.Controls.Add(this.slidePanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SlidePanel Demo";
            this.slidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.SlidePanel slidePanel1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX buttonLeft;
        private DevComponents.DotNetBar.ButtonX buttonRight;
        private DevComponents.DotNetBar.ButtonX buttonBottom;
        private DevComponents.DotNetBar.ButtonX buttonTop;
    }
}

