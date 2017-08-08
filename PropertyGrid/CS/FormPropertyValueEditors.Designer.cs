namespace PropertyGrid
{
    partial class FormPropertyValueEditors
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
            this.advPropertyGrid1 = new DevComponents.DotNetBar.AdvPropertyGrid();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // advPropertyGrid1
            // 
            this.advPropertyGrid1.GridLinesColor = System.Drawing.Color.WhiteSmoke;
            this.advPropertyGrid1.HelpType = DevComponents.DotNetBar.ePropertyGridHelpType.Panel;
            this.advPropertyGrid1.Location = new System.Drawing.Point(12, 50);
            this.advPropertyGrid1.Name = "advPropertyGrid1";
            this.advPropertyGrid1.Size = new System.Drawing.Size(376, 358);
            this.advPropertyGrid1.TabIndex = 0;
            this.advPropertyGrid1.Text = "advPropertyGrid1";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(376, 43);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "AdvPropertyGrid includes pre-defined property value editor, like multi-choice, da" +
                "te-time etc. You can also define your own. See code inside of this form for an e" +
                "xample.";
            this.labelX1.WordWrap = true;
            // 
            // FormPropertyValueEditors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.advPropertyGrid1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPropertyValueEditors";
            this.Text = "Property Value Editors";
            this.Load += new System.EventHandler(this.FormPropertyValueEditors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.AdvPropertyGrid advPropertyGrid1;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}