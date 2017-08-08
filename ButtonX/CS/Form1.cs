using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ButtonX
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX buttonX7;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.ButtonItem buttonItem6;
        private DevComponents.DotNetBar.ButtonItem buttonItem7;
        private DevComponents.DotNetBar.ButtonItem buttonItem8;
        private DevComponents.DotNetBar.ButtonItem buttonItem9;
        private DevComponents.DotNetBar.ButtonX buttonX8;
        private DevComponents.DotNetBar.ButtonItem buttonItem10;
        private DevComponents.DotNetBar.ButtonItem buttonItem11;
        private DevComponents.DotNetBar.ButtonItem buttonItem12;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX buttonX9;
        private DevComponents.DotNetBar.ButtonX buttonX10;
        private DevComponents.DotNetBar.ButtonX buttonX11;
        private DevComponents.DotNetBar.ButtonX buttonX12;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX13;

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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonX7 = new DevComponents.DotNetBar.ButtonX();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonX8 = new DevComponents.DotNetBar.ButtonX();
            this.buttonItem10 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem11 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem12 = new DevComponents.DotNetBar.ButtonItem();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonX9 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX10 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX11 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX12 = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX13 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.Location = new System.Drawing.Point(511, 265);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(86, 26);
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "Close";
            this.buttonX1.ThemeAware = true;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Office 2007 Style";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Location = new System.Drawing.Point(19, 46);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(77, 29);
            this.buttonX2.TabIndex = 2;
            this.buttonX2.Text = "Blue";
            this.buttonX2.Tooltip = "Built-in Tooltip with the <font color=\"Red\">mini</font>-<font color=\"DarkOrange\">" +
    "markup</font> enabled.\r\n<div align=\"center\">Multiple lines are easy with mini-ma" +
    "rkup</div>";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(103, 46);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(77, 29);
            this.buttonX3.TabIndex = 3;
            this.buttonX3.Text = "Orange";
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(187, 46);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(77, 29);
            this.buttonX4.TabIndex = 4;
            this.buttonX4.Text = "Magenta";
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.AutoExpandOnClick = true;
            this.buttonX5.Location = new System.Drawing.Point(19, 88);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(126, 32);
            this.buttonX5.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem2,
            this.buttonItem3});
            this.buttonX5.TabIndex = 5;
            this.buttonX5.Text = "Drop down menu";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "Sample Menu Item 1";
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "Sample Menu Item 2";
            // 
            // buttonItem3
            // 
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Text = "<b><font color=\"Orange\">Menu</font></b> item with<br/><b>mini-markup</b>";
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Image = ((System.Drawing.Image)(resources.GetObject("buttonX6.Image")));
            this.buttonX6.Location = new System.Drawing.Point(20, 129);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(140, 42);
            this.buttonX6.TabIndex = 6;
            this.buttonX6.Text = "<div align=\"center\"><b>Mini</b>-<u><font color=\"DarkOrange\">markup</font></u> <fo" +
    "nt color=\"Red\">on</font> the <font color=\"Green\">button</font></div>";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(287, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Office 2003 Style";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonX7
            // 
            this.buttonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.buttonX7.Image = ((System.Drawing.Image)(resources.GetObject("buttonX7.Image")));
            this.buttonX7.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX7.Location = new System.Drawing.Point(310, 42);
            this.buttonX7.Name = "buttonX7";
            this.buttonX7.Size = new System.Drawing.Size(114, 38);
            this.buttonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.buttonX7.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem4,
            this.buttonItem5,
            this.buttonItem6});
            this.buttonX7.TabIndex = 8;
            this.buttonX7.Text = "ButtonX";
            // 
            // buttonItem4
            // 
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.Text = "buttonItem4";
            // 
            // buttonItem5
            // 
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.Text = "buttonItem5";
            // 
            // buttonItem6
            // 
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.Text = "buttonItem6";
            // 
            // buttonItem7
            // 
            this.buttonItem7.Name = "buttonItem7";
            this.buttonItem7.Text = "buttonItem4";
            // 
            // buttonItem8
            // 
            this.buttonItem8.Name = "buttonItem8";
            this.buttonItem8.Text = "buttonItem5";
            // 
            // buttonItem9
            // 
            this.buttonItem9.Name = "buttonItem9";
            this.buttonItem9.Text = "buttonItem6";
            // 
            // buttonX8
            // 
            this.buttonX8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX8.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.buttonX8.Image = ((System.Drawing.Image)(resources.GetObject("buttonX8.Image")));
            this.buttonX8.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX8.Location = new System.Drawing.Point(331, 174);
            this.buttonX8.Name = "buttonX8";
            this.buttonX8.Size = new System.Drawing.Size(93, 59);
            this.buttonX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.buttonX8.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem10,
            this.buttonItem11,
            this.buttonItem12});
            this.buttonX8.TabIndex = 10;
            this.buttonX8.Text = "ButtonX";
            // 
            // buttonItem10
            // 
            this.buttonItem10.Name = "buttonItem10";
            this.buttonItem10.Text = "buttonItem4";
            // 
            // buttonItem11
            // 
            this.buttonItem11.Name = "buttonItem11";
            this.buttonItem11.Text = "buttonItem5";
            // 
            // buttonItem12
            // 
            this.buttonItem12.Name = "buttonItem12";
            this.buttonItem12.Text = "buttonItem6";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(308, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "VS.NET 2005 Style";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonX9
            // 
            this.buttonX9.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX9.CustomColorName = "MyColorName";
            this.buttonX9.Location = new System.Drawing.Point(22, 188);
            this.buttonX9.Name = "buttonX9";
            this.buttonX9.Size = new System.Drawing.Size(153, 46);
            this.buttonX9.TabIndex = 11;
            this.buttonX9.Text = "Custom Colors see CustomColorName";
            // 
            // buttonX10
            // 
            this.buttonX10.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX10.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonX10.Location = new System.Drawing.Point(156, 90);
            this.buttonX10.Name = "buttonX10";
            this.buttonX10.Size = new System.Drawing.Size(109, 30);
            this.buttonX10.TabIndex = 12;
            this.buttonX10.Text = "Office 2007";
            // 
            // buttonX11
            // 
            this.buttonX11.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX11.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX11.FocusCuesEnabled = false;
            this.buttonX11.Location = new System.Drawing.Point(175, 129);
            this.buttonX11.Name = "buttonX11";
            this.buttonX11.Size = new System.Drawing.Size(91, 42);
            this.buttonX11.TabIndex = 13;
            this.buttonX11.Text = "Blue Orb";
            // 
            // buttonX12
            // 
            this.buttonX12.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX12.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX12.FocusCuesEnabled = false;
            this.buttonX12.Image = ((System.Drawing.Image)(resources.GetObject("buttonX12.Image")));
            this.buttonX12.Location = new System.Drawing.Point(197, 190);
            this.buttonX12.Name = "buttonX12";
            this.buttonX12.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.buttonX12.Size = new System.Drawing.Size(48, 43);
            this.buttonX12.TabIndex = 14;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(471, 88);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 15;
            this.labelX1.Text = "labelX1";
            // 
            // buttonX13
            // 
            this.buttonX13.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX13.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX13.Image = ((System.Drawing.Image)(resources.GetObject("buttonX13.Image")));
            this.buttonX13.Location = new System.Drawing.Point(496, 27);
            this.buttonX13.Name = "buttonX13";
            this.buttonX13.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.buttonX13.Size = new System.Drawing.Size(50, 48);
            this.buttonX13.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX13.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(607, 298);
            this.Controls.Add(this.buttonX13);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.buttonX12);
            this.Controls.Add(this.buttonX11);
            this.Controls.Add(this.buttonX10);
            this.Controls.Add(this.buttonX9);
            this.Controls.Add(this.buttonX8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonX7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonX6);
            this.Controls.Add(this.buttonX5);
            this.Controls.Add(this.buttonX4);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        private void buttonX1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Create custom color scheme for the button and register it globaly
            DevComponents.DotNetBar.Rendering.Office2007ButtonItemColorTable table = new DevComponents.DotNetBar.Rendering.Office2007ButtonItemColorTable();
            table.Name = "MyColorName"; // This is the color table name that we assigned to the CustomColorName property in designer

            // Define standard colors when mouse is not over the button
            table.Default = new DevComponents.DotNetBar.Rendering.Office2007ButtonItemStateColorTable();
            table.Default.OuterBorder.Start = System.Drawing.Color.DarkRed;
            table.Default.OuterBorder.End = System.Drawing.Color.Black;
            table.Default.TopBackground.Start = System.Drawing.Color.WhiteSmoke;
            table.Default.TopBackground.End = System.Drawing.Color.Salmon;
            table.Default.BottomBackground.Start = System.Drawing.Color.Salmon;
            table.Default.BottomBackground.End = System.Drawing.Color.DarkSalmon;
            table.Default.BottomBackgroundHighlight.Start = System.Drawing.Color.Yellow;
            table.Default.BottomBackgroundHighlight.End = System.Drawing.Color.Transparent;
            table.Default.Text = System.Drawing.Color.Maroon;

            // Define colors when mouse is over the button
            table.MouseOver = new DevComponents.DotNetBar.Rendering.Office2007ButtonItemStateColorTable();
            table.MouseOver.OuterBorder.Start = System.Drawing.Color.Maroon;
            table.MouseOver.OuterBorder.End = System.Drawing.Color.Black;
            table.MouseOver.TopBackground.Start = System.Drawing.Color.LightYellow;
            table.MouseOver.TopBackground.End = System.Drawing.Color.Orange;
            table.MouseOver.BottomBackground.Start = System.Drawing.Color.Orange;
            table.MouseOver.BottomBackground.End = System.Drawing.Color.OrangeRed;
            table.MouseOver.BottomBackgroundHighlight.Start = System.Drawing.Color.LightYellow;
            table.MouseOver.BottomBackgroundHighlight.End = System.Drawing.Color.Transparent;
            table.MouseOver.Text = System.Drawing.Color.Maroon;

            // Define colors when mouse is pressed
            table.Pressed = new DevComponents.DotNetBar.Rendering.Office2007ButtonItemStateColorTable();
            table.Pressed.OuterBorder.Start = System.Drawing.Color.Maroon;
            table.Pressed.OuterBorder.End = System.Drawing.Color.Black;
            table.Pressed.TopBackground.Start = System.Drawing.Color.Yellow;
            table.Pressed.TopBackground.End = System.Drawing.Color.OrangeRed;
            table.Pressed.BottomBackground.Start = System.Drawing.Color.OrangeRed;
            table.Pressed.BottomBackground.End = System.Drawing.Color.DarkOrange;
            table.Pressed.BottomBackgroundHighlight.Start = System.Drawing.Color.Yellow;
            table.Pressed.BottomBackgroundHighlight.End = System.Drawing.Color.Transparent;
            table.Pressed.Text = System.Drawing.Color.Maroon;

            if (DevComponents.DotNetBar.Rendering.GlobalManager.Renderer is DevComponents.DotNetBar.Rendering.Office2007Renderer)
            {
                DevComponents.DotNetBar.Rendering.Office2007Renderer r = DevComponents.DotNetBar.Rendering.GlobalManager.Renderer as DevComponents.DotNetBar.Rendering.Office2007Renderer;
                r.ColorTable.ButtonItemColors.Add(table);
            }

            // Start button Pulse
            buttonX6.Pulse(11);
        }
    }
}
