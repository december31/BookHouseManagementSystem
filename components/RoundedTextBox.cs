using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystemManagement.NewFolder1
{
    public partial class RoundedTextBox : UserControl
    {
        public RoundedTextBox()
        {
            InitializeComponent();
        }
        private Color boderColor = Color.MediumBlue;
        private int boderSize = 2;
        private bool underlinedStyle = false;
        

        public Color BoderColor
        {
            get => boderColor;
            set
            {
                boderColor = value;
                this.Invalidate();
            }
        }
        public int BoderSize
        {
            get => boderSize;
            set { boderSize = value; this.Invalidate(); }
        }
        public bool UnderlinedStyle { get => underlinedStyle; set { underlinedStyle = value; this.Invalidate(); } }
        //overriden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;

            //draw boder
            using (Pen penBorder = new Pen(boderColor, boderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (underlinedStyle)
                {
                    graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                }
                else
                {
                    graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
    }
}
