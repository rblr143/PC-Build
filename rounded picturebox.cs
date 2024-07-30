using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pc_build
{
    public class rounded_picturebox:PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            // Create a GraphicsPath object
            GraphicsPath path = new GraphicsPath();

            // Set the clipping region to a circle
            path.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(path);

            // Call the base class OnPaint
            base.OnPaint(pe);

            // Ensure the image is drawn within the circular region
            if (this.Image != null)
            {
                pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pe.Graphics.SetClip(path);
                pe.Graphics.DrawImage(this.Image, new Rectangle(0, 0, this.Width, this.Height));
            }
        }
    }

    public class MainForm : Form
    {
        public MainForm()
        {
            // Set up the form
            this.Text = "Rounded PictureBox Example";
            this.Size = new Size(400, 400);

            // Create an instance of the RoundedPictureBox
            rounded_picturebox roundedPictureBox = new rounded_picturebox
            {
                Width = 200,
                Height = 200,
                Location = new Point(100, 100),
                Image = Image.FromFile("your_image_path.jpg"), // Set the path to your image
                SizeMode = PictureBoxSizeMode.StretchImage // Adjust as necessary
            };

            // Add the RoundedPictureBox to the form
            this.Controls.Add(roundedPictureBox);
        }
    }
}
