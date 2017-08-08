namespace TestVirtualKeyboard
{
    partial class Form3
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
            DevComponents.DotNetBar.Keyboard.VirtualKeyboardColorTable virtualKeyboardColorTable2 = new DevComponents.DotNetBar.Keyboard.VirtualKeyboardColorTable();
            DevComponents.DotNetBar.Keyboard.FlatStyleRenderer flatStyleRenderer2 = new DevComponents.DotNetBar.Keyboard.FlatStyleRenderer();
            this.virtualKeyboard1 = new DevComponents.DotNetBar.Keyboard.KeyboardControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // virtualKeyboard1
            // 
            this.virtualKeyboard1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            virtualKeyboardColorTable2.BackgroundColor = System.Drawing.Color.Black;
            virtualKeyboardColorTable2.DarkKeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            virtualKeyboardColorTable2.DownKeysColor = System.Drawing.Color.White;
            virtualKeyboardColorTable2.DownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            virtualKeyboardColorTable2.KeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            virtualKeyboardColorTable2.LightKeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            virtualKeyboardColorTable2.PressedKeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(161)))), ((int)(((byte)(81)))));
            virtualKeyboardColorTable2.TextColor = System.Drawing.Color.White;
            virtualKeyboardColorTable2.ToggleTextColor = System.Drawing.Color.Green;
            virtualKeyboardColorTable2.TopBarTextColor = System.Drawing.Color.White;
            this.virtualKeyboard1.ColorTable = virtualKeyboardColorTable2;
            this.virtualKeyboard1.Location = new System.Drawing.Point(13, 39);
            this.virtualKeyboard1.Name = "virtualKeyboard1";
            flatStyleRenderer2.ColorTable = virtualKeyboardColorTable2;
            flatStyleRenderer2.ForceAntiAlias = false;
            this.virtualKeyboard1.Renderer = flatStyleRenderer2;
            this.virtualKeyboard1.Size = new System.Drawing.Size(237, 296);
            this.virtualKeyboard1.TabIndex = 0;
            this.virtualKeyboard1.Text = "virtualKeyboard1";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 347);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.virtualKeyboard1);
            this.Name = "Form3";
            this.Text = "Form3 - Test Keyboard Layout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Keyboard.KeyboardControl virtualKeyboard1;
        private System.Windows.Forms.TextBox textBox1;
    }
}