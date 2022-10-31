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
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }


        //Overriden Methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Gradient
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush gradientBrush = new LinearGradientBrush(this.ClientRectangle, this.TopColor,
                this.BottomColor, this.gradientAngle);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(gradientBrush, ClientRectangle);


            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            if (boderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetArtanPath(rectangleF, boderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);
                }
            }
            else this.Region = new Region(rectangleF);
        }

    }
}
