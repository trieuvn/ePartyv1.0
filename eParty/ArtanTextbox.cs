using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace eParty
{
    class ArtanTextbox: TextBox
    {
        private int borderSize = 0;
        private int borderRadius = 50;
        private Color borderColor = Color.DodgerBlue;

        [Category("Appearance")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value >= 0 ? value : 0; // Prevent negative values
                Invalidate();
            }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = (value >= 0 && value <= Height) ? value : Height;
                Invalidate();
            }
        }

        [Category("Appearance")]
        public Color BackgroundColor
        {
            get => BackColor;
            set => BackColor = value;
        }

        [Category("Appearance")]
        public Color TextColor
        {
            get => ForeColor;
            set => ForeColor = value;
        }

        public ArtanTextbox()
        {
            Size = new Size(200, 100);
            BorderStyle = BorderStyle.None; // Replace FlatAppearance approach
            BackColor = Color.DodgerBlue;
            ForeColor = Color.White;
            Resize += Button_Resize;
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > Height)
                borderRadius = Height;
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2f;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Width - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Width - diameter, rect.Height - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Height - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, Width - 1, Height - 1);
            RectangleF rectBorder = RectangleF.Inflate(rectSurface, -0.5f, -0.5f);

            if (borderRadius > 1)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1))
                using (Pen penSurface = new Pen(Parent?.BackColor ?? BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    // Set region and draw surface
                    Region = new Region(pathSurface);
                    e.Graphics.DrawPath(penSurface, pathSurface);

                    // Draw border if size is specified
                    if (borderSize >= 1)
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (Parent != null)
                Parent.BackColorChanged += Container_BackColorChanged;
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (DesignMode)
                Invalidate();
        }

        // Properly dispose resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && Parent != null)
            {
                Parent.BackColorChanged -= Container_BackColorChanged;
            }
            base.Dispose(disposing);
        }
    }
}

