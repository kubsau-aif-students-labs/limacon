using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pascals_snail
{
    public partial class Form1 : Form
    {
        public int offset = 225;

        public Form1()
        {
            InitializeComponent();
        }

        void drawCurve(Graphics graphics, int a, int b)
        {
            Pen greenPen = new Pen(Color.Green);
            double x;
            double y;
            double bACosI;
            double twoPi = Math.PI * 2;
            List<Point> points = new List<Point>();
            for (double i = 0; i < twoPi; i += 0.001)
            {
                bACosI = b + a * Math.Cos(i);
                x = bACosI * Math.Cos(i);
                y = bACosI * Math.Sin(i);
                points.Add(new Point((int)y + offset, (int)x + offset));
            }
            drawAxis(graphics);
            graphics.DrawCurve(greenPen, points.ToArray());
        }

        void drawAxis(Graphics graphics)
        {
            Pen blackPen = new Pen(Color.Black);
            graphics.DrawLine(blackPen, 20, offset, offset * 2 - 20, offset);
            graphics.DrawLine(blackPen, offset, 20, offset, offset * 2 - 20);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            drawCurve(e.Graphics, (int)aSpinBox.Value, (int)bSpinBox.Value);
        }

        private void repaint(object sender, EventArgs e)
        {
            canvas.Invalidate();
        }
    }
}
