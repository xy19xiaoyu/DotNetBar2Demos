namespace SuperGridDemo
{
    partial class FilePathControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilePathControl));
            this.btnDialog = new DevComponents.DotNetBar.ButtonX();
            this.tbxFilePath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // btnDialog
            // 
            this.btnDialog.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDialog.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDialog.Image = ((System.Drawing.Image)(resources.GetObject("btnDialog.Image")));
            this.btnDialog.Location = new System.Drawing.Point(142, 5);
            this.btnDialog.Name = "btnDialog";
            this.btnDialog.Size = new System.Drawing.Size(16, 15);
            this.btnDialog.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDialog.TabIndex = 3;
            this.btnDialog.Tooltip = "Click to launch OpenFileDialog";
            this.btnDialog.Click += new System.EventHandler(this.BtnDialogClick);
            // 
            // tbxFilePath
            // 
            this.tbxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbxFilePath.Border.Class = "TextBoxBorder";
            this.tbxFilePath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxFilePath.Location = new System.Drawing.Point(0, 1);
            this.tbxFilePath.Name = "tbxFilePath";
            this.tbxFilePath.Size = new System.Drawing.Size(139, 20);
            this.tbxFilePath.TabIndex = 4;
            this.tbxFilePath.TextChanged += new System.EventHandler(this.TbxFilePathTextChanged);
            // 
            // FilePathControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbxFilePath);
            this.Controls.Add(this.btnDialog);
            this.Name = "FilePathControl";
            this.Size = new System.Drawing.Size(163, 23);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal DevComponents.DotNetBar.ButtonX btnDialog;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxFilePath;

    }
}
