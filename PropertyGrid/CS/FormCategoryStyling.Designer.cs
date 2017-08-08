namespace PropertyGrid
{
    partial class FormCategoryStyling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoryStyling));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.advPropertyGrid1 = new DevComponents.DotNetBar.AdvPropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(277, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(244, 271);
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "This sample shows how to assign custom style to Category nodes displayed in prope" +
                "rty grid. See Form Load event for details.";
            this.labelX1.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.labelX1.WordWrap = true;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(277, 299);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(121, 28);
            this.buttonX1.TabIndex = 7;
            this.buttonX1.Text = "Property Button";
            // 
            // advPropertyGrid1
            // 
            this.advPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Left;
            this.advPropertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.advPropertyGrid1.Name = "advPropertyGrid1";
            this.advPropertyGrid1.Size = new System.Drawing.Size(271, 327);
            this.advPropertyGrid1.TabIndex = 6;
            this.advPropertyGrid1.Text = "advPropertyGrid1";
            // 
            // FormCategoryStyling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 327);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.advPropertyGrid1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCategoryStyling";
            this.Text = "Custom Category Style";
            this.Load += new System.EventHandler(this.FormCategoryStyling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.AdvPropertyGrid advPropertyGrid1;
    }
}