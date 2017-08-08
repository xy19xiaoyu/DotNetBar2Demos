using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using DevComponents.DotNetBar.Keyboard;
using DevComponents.DotNetBar.Metro;

namespace TestVirtualKeyboard
{
    public partial class Form5 : MetroForm
    {
        public Form5()
        {
            InitializeComponent();
            // Assign Custom Renderer we created below
            touchKeyboard1.Renderer = new ThreeDRenderer();
        }

        private void defaultRendererToolStripMenuItem_Click(object sender, EventArgs e)
        {
            touchKeyboard1.Renderer = null; // Setting Renderer to null will use a default renderer.
        }

        private void dRendererToolStripMenuItem_Click(object sender, EventArgs e)
        {
            touchKeyboard1.Renderer = new ThreeDRenderer();
        }
    }


    // Using a custom renderer means to extend the Renderer class. Extending the Renderer class means to implement four methods:
    // - DrawBackground
    // - DrawKey
    // - DrawTopBar
    // - DrawCloseButton
    // If you need to allocate resources that are used for each keys (for example a Brush or a Pen), you should override the BeginFrame function
    // end allocate it there and override the EndFrame function and deallocate the resource there. BeginFrame and EndFrame are called once at
    // the beginning / end of each frame. Each call to the DrawXXX methods in the Renderer class happen between a call to BeginFrame and a call to
    // EndFrame.

    public class ThreeDRenderer : Renderer
    {
        private Font _Font = new Font("Segoe UI", 10, FontStyle.Bold);
        private StringFormat _Format;
        /// <summary>
        /// Initializes a new instance of the ThreeDRenderer class.
        /// </summary>
        public ThreeDRenderer()
        {
            _Format = (StringFormat)StringFormat.GenericDefault.Clone();
            _Format.LineAlignment = StringAlignment.Center;
            _Format.Alignment = StringAlignment.Center;
        }
        public override void DrawBackground(BackgroundRendererEventArgs args)
        {
            //
            using (TextureBrush brush = new TextureBrush(global::TestVirtualKeyboard.Properties.Resources.Fiber))
            {
                brush.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
                args.Graphics.FillRectangle(brush, args.Bounds);
            }
        }

        public override void DrawKey(KeyRendererEventArgs args)
        {
            Rectangle keyBounds = args.Bounds;
            args.Graphics.FillRectangle(ColorTable.KeysBrush, keyBounds);

            if (args.IsDown || args.Key.Style == KeyStyle.Pressed || args.Key.Style == KeyStyle.Toggled)
            {
                Draw3DBorder(args.Graphics, keyBounds, ColorTable.DarkKeysBrush, ColorTable.LightKeysBrush);
                keyBounds.Offset(1, 1);
                if (args.Key.Style == KeyStyle.Toggled)
                    args.Graphics.DrawString(args.Key.Caption, _Font, ColorTable.ToggleTextBrush, keyBounds, _Format);
                else
                    args.Graphics.DrawString(args.Key.Caption, _Font, ColorTable.TextBrush, keyBounds, _Format);
            }
            else
            {
                Draw3DBorder(args.Graphics, keyBounds, ColorTable.LightKeysBrush, ColorTable.DarkKeysBrush);
                args.Graphics.DrawString(args.Key.Caption, _Font, ColorTable.TextBrush, keyBounds, _Format);
            }
        }

        public override void DrawTopBar(TopBarRendererEventArgs args)
        {
            args.Graphics.DrawString(args.Text, _Font, ColorTable.TopBarTextBrush, args.Bounds);
        }

        public override void DrawCloseButton(CloseButtonRendererEventArgs args)
        {
            if (args.IsDown)
                Draw3DBorder(args.Graphics, args.Bounds, ColorTable.DarkKeysBrush, ColorTable.LightKeysBrush);
            else
                Draw3DBorder(args.Graphics, args.Bounds, ColorTable.LightKeysBrush, ColorTable.DarkKeysBrush);

            Rectangle rect = args.Bounds;
            rect.Inflate(-5, -5);

            using (Pen p = new Pen(ColorTable.TextBrush, 2))
            {
                args.Graphics.DrawLine(p, rect.Left, rect.Top, rect.Right, rect.Bottom);
                args.Graphics.DrawLine(p, rect.Left, rect.Bottom, rect.Right, rect.Top);
            }

        }

        private static void Draw3DBorder(Graphics g, Rectangle bounds, Brush light, Brush dark)
        {
            int borderSize = 1;
            g.FillRectangle(light, new Rectangle(bounds.Left, bounds.Top, bounds.Width, borderSize));
            g.FillRectangle(light, new Rectangle(bounds.Left, bounds.Top, borderSize, bounds.Height));
            g.FillRectangle(dark, new Rectangle(bounds.Left, bounds.Bottom - borderSize, bounds.Width, borderSize));
            g.FillRectangle(dark, new Rectangle(bounds.Right - borderSize, bounds.Top, borderSize, bounds.Height));
        }
    }
}
