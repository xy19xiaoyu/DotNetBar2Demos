namespace PropertyGrid
{
    partial class FormPropertyValuesTranslationMethod1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPropertyValuesTranslationMethod1));
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
            this.labelX1.Location = new System.Drawing.Point(274, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(244, 271);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "This sample shows how to perform \"bulk\" property value mapping. It shows replacin" +
                "g of all boolean true, false values in property grid with Yes, No.";
            this.labelX1.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.labelX1.WordWrap = true;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(273, 291);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(121, 28);
            this.buttonX1.TabIndex = 4;
            this.buttonX1.Text = "Property Button";
            // 
            // advPropertyGrid1
            // 
            this.advPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Left;
            this.advPropertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.advPropertyGrid1.Name = "advPropertyGrid1";
            this.advPropertyGrid1.Size = new System.Drawing.Size(271, 321);
            this.advPropertyGrid1.TabIndex = 3;
            this.advPropertyGrid1.Text = "advPropertyGrid1";
            this.advPropertyGrid1.ConvertPropertyValueToString += new DevComponents.DotNetBar.ConvertValueEventHandler(this.advPropertyGrid1_ConvertPropertyValueToString);
            this.advPropertyGrid1.ConvertFromStringToPropertyValue += new DevComponents.DotNetBar.ConvertValueEventHandler(this.advPropertyGrid1_ConvertFromStringToPropertyValue);
            this.advPropertyGrid1.ProvidePropertyValueList += new DevComponents.DotNetBar.PropertyValueListEventHandler(this.advPropertyGrid1_ProvidePropertyValueList);
            // 
            // FormPropertyValuesTranslationMethod1
            // 
            this.ClientSize = new System.Drawing.Size(514, 321);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.advPropertyGrid1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPropertyValuesTranslationMethod1";
            this.Text = "Property Value Translation Bulk Method";
            this.Load += new System.EventHandler(this.FormPropertyValuesTranslationMethod1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advPropertyGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.AdvPropertyGrid advPropertyGrid1;
    }
}