namespace PageSlider
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
            this.pageSlider1 = new DevComponents.DotNetBar.Controls.PageSlider();
            this.pageSliderPage1 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pageSliderPage2 = new DevComponents.DotNetBar.Controls.PageSliderPage();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.pageSlider1.SuspendLayout();
            this.pageSliderPage1.SuspendLayout();
            this.pageSliderPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageSlider1
            // 
            this.pageSlider1.AnimationTime = 250;
            this.pageSlider1.Controls.Add(this.pageSliderPage1);
            this.pageSlider1.Controls.Add(this.pageSliderPage2);
            this.pageSlider1.Location = new System.Drawing.Point(72, 58);
            this.pageSlider1.Name = "pageSlider1";
            this.pageSlider1.SelectedPage = this.pageSliderPage1;
            this.pageSlider1.Size = new System.Drawing.Size(459, 307);
            this.pageSlider1.TabIndex = 0;
            this.pageSlider1.Text = "pageSlider1";
            // 
            // pageSliderPage1
            // 
            this.pageSliderPage1.Controls.Add(this.buttonX1);
            this.pageSliderPage1.Controls.Add(this.labelX3);
            this.pageSliderPage1.Controls.Add(this.labelX1);
            this.pageSliderPage1.Location = new System.Drawing.Point(4, 8);
            this.pageSliderPage1.Name = "pageSliderPage1";
            this.pageSliderPage1.Size = new System.Drawing.Size(353, 295);
            this.pageSliderPage1.TabIndex = 3;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(3, 176);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(108, 47);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 2;
            this.buttonX1.Text = "Click to create new page";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(3, 58);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(239, 91);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Each Page Slider page is standard panel which can host any control you choose.\r\n\r" +
                "\nPage Slider also support Touch and inertial scrolling so its great choice for t" +
                "ouch based apps.";
            this.labelX3.WordWrap = true;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(0, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(353, 52);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "First Page Slider Page";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pageSliderPage2
            // 
            this.pageSliderPage2.Controls.Add(this.labelX2);
            this.pageSliderPage2.Location = new System.Drawing.Point(405, 8);
            this.pageSliderPage2.Name = "pageSliderPage2";
            this.pageSliderPage2.Size = new System.Drawing.Size(353, 295);
            this.pageSliderPage2.TabIndex = 4;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(0, 0);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(353, 52);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Second Page Slider Page";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 377);
            this.Controls.Add(this.pageSlider1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Page Slider Demo";
            this.pageSlider1.ResumeLayout(false);
            this.pageSliderPage1.ResumeLayout(false);
            this.pageSliderPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.PageSlider pageSlider1;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.PageSliderPage pageSliderPage2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}

