using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace LibrarySystemManagement.NewFolder1
{
    public partial class RoundedPanel : Panel
    {
        private int boderRadius = 30;
        private int borderWidth = 1;
        private float gradientAngle = 90F;
        private Color TopColor = Color.DodgerBlue;
        private Color BottomColor = Color.CadetBlue;


        public RoundedPanel()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(350, 200);
        }

        public RoundedPanel(float gradientAngle, Color topColor, Color bottomColor)
        {
            this.GradientAngle = gradientAngle;
            TopColor = topColor;
            BottomColor = bottomColor;
        }

        public int BorderRadius
        {
            get { return boderRadius; }
            set
            {
                boderRadius = value;
                this.Invalidate();
            }
        }

        public int BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                this.Invalidate();
            }
        }

        public float GradientAngle
        {
            get => gradientAngle; set
            {
                gradientAngle = value;
                this.Invalidate();
            }
        }
        public Color TopColor1
        {
            get => TopColor; set
            {
                TopColor = value;
                this.Invalidate();
            }
        }
        public Color BottomColor1
        {
            get => BottomColor; set
            {
                BottomColor = value;
                this.Invalidate();
            }
        }
        private GraphicsPath GetArtanPath(RectangleF rectangle, float radius)
        {
            int diameter = (int)radius * 2;
            Size size = new Size(diameter, diameter);
            RectangleF arc = new RectangleF(rectangle.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(rectangle);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = rectangle.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = rectangle.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = rectangle.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }


        //Overriden Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Gradient
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF innerRectangleF = new RectangleF(borderWidth, borderWidth,
                this.Width - borderWidth * 2, this.Height - borderWidth * 2);

            if (boderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetArtanPath(rectangleF, boderRadius))
                using (GraphicsPath innerGraphicsPath = GetArtanPath(innerRectangleF, boderRadius))
                using (SolidBrush brush = new SolidBrush(Color.Black))
                {
                    this.Region = new Region(graphicsPath);
                    e.Graphics.FillPath(brush, graphicsPath);
                    brush.Color = Color.White;
                    e.Graphics.FillPath(brush, innerGraphicsPath);
                }
            }
            else this.Region = new Region(rectangleF);
        }

    }
}
