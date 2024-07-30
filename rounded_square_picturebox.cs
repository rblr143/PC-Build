using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls
{
    public class RoundedCornerPictureBox : PictureBox
    {
        private int _cornerRadius = 20;
        private Color _borderColor = Color.FromArgb(211, 251, 216); // #d3fbd8
        private int _borderWidth = 2;

        // Property to get or set the corner radius
        public int CornerRadius
        {
            get { return _cornerRadius; }
            set
            {
                _cornerRadius = value;
                this.Invalidate(); // Redraw the control when the radius changes
            }
        }

        // Property to get or set the border color
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate(); // Redraw the control when the color changes
            }
        }

        // Property to get or set the border width
        public int BorderWidth
        {
            get { return _borderWidth; }
            set
            {
                _borderWidth = value;
                this.Invalidate(); // Redraw the control when the width changes
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            // Set up a GraphicsPath to define the rounded rectangle region
            GraphicsPath path = new GraphicsPath();
            int arcSize = _cornerRadius * 2;
            path.AddArc(0, 0, arcSize, arcSize, 180, 90);
            path.AddArc(this.Width - arcSize, 0, arcSize, arcSize, 270, 90);
            path.AddArc(this.Width - arcSize, this.Height - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(0, this.Height - arcSize, arcSize, arcSize, 90, 90);
            path.CloseFigure();

            // Clip the region to the rounded rectangle path
            this.Region = new Region(path);

            // Ensure smooth edges for the rounded corners
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw the image within the rounded region
            if (this.Image != null)
            {
                pe.Graphics.SetClip(path);
                pe.Graphics.DrawImage(this.Image, new Rectangle(0, 0, this.Width, this.Height));
            }

            // Draw the border around the rounded rectangle
            using (Pen pen = new Pen(_borderColor, _borderWidth))
            {
                // Adjust the path to account for the border width
                pe.Graphics.DrawPath(pen, path);
            }
        }
    }
}