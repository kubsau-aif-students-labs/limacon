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
        public Form1()
        {
            InitializeComponent();
        }

        void drawCurve(Graphics graphics, int a, int b)
        {
            Pen blackPen = new Pen(Color.Black);
            double x;
            double y;
            double bACosI;
            int offset = 225;
            int scale = 1;
            double twoPi = Math.PI * 2;
            List<Point> points = new List<Point>();
            for (double i = 0; i < twoPi; i += 0.001)
            {
                bACosI = b + a * Math.Cos(i);
                x = bACosI * Math.Cos(i);
                y = bACosI * Math.Sin(i);
                points.Add(new Point((int)y * scale + offset, (int)x * scale + offset));
            }
            graphics.DrawCurve(blackPen, points.ToArray());
            double r = b - a * Math.Cos(1.6180339887);
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
