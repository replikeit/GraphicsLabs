using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static void PutPixel(Graphics g, Color col, int x, int y, int alpha)
        {
            g.FillRectangle(new SolidBrush(Color.FromArgb(alpha, col)), x, y, 1, 1);
        }

        public static void StepLine(Graphics g, Color clr, int x1, int y1, int x2, int y2)
        {
            g.Clear(Color.White);
            int deltaX = Math.Abs(x1 - x2);
            int deltaY = Math.Abs(y1 - y2);

            int length = Math.Max(deltaX, deltaY);

            if (length == 0)
            {
                PutPixel(g, clr, x1, y1, 255);
                return;
            }

            double dX = (double)(x2 - x1) / length;
            double dY = (double)(y2 - y1) / length;

            double x = x1, y = y1;
            while(x + dX < x2 && y + dY < y2)
            {
                x += dX;
                y += dY;
                PutPixel(g, clr, (int)Math.Round(x), (int)Math.Round(y), 255);
            }
        }

        public static void BresenhamCircle(Graphics g, Color clr, int _x, int _y, int radius)
        {
            g.Clear(Color.White);
            int x = 0, y = radius, gap = 0, delta = (2 - 2 * radius);
            while (y >= 0)
            {
                PutPixel(g, clr, _x + x, _y + y, 255);
                PutPixel(g, clr, _x + x, _y - y, 255);
                PutPixel(g, clr, _x - x, _y - y, 255);
                PutPixel(g, clr, _x - x, _y + y, 255);
                gap = 2 * (delta + y) - 1;
                if (delta < 0 && gap <= 0)
                {
                    x++;
                    delta += 2 * x + 1;
                    continue;
                }
                if (delta > 0 && gap > 0)
                {
                    y--;
                    delta -= 2 * y + 1;
                    continue;
                }
                x++;
                delta += 2 * (x - y);
                y--;
            }
        }

        void LineDDA(Graphics g, Color clr, int x1, int y1, int x2, int y2)
        {
            g.Clear(Color.White);
            int deltaX = Math.Abs(x1 - x2);
            int deltaY = Math.Abs(y1 - y2);

            int length = Math.Max(deltaX, deltaY);

            if (length == 0)
            {
                PutPixel(g, clr, x1, y1, 255);
                return;
            }

            double dX = (double)(x2 - x1) / length;
            double dY = (double)(y2 - y1) / length;

            double x = x1;
            double y = y1;

            for (int i = 0; i < length; i++)
            {
                x += dX;
                y += dY;
                PutPixel(g, clr, (int)Math.Round(x), (int)Math.Round(y), 255);
            }
        }

        static public void BresenhamLine(Graphics g, Color clr, int x0, int y0,
                                                                 int x1, int y1)
        {
            g.Clear(Color.White);
            int dx = (x1 > x0) ? (x1 - x0) : (x0 - x1);
            int dy = (y1 > y0) ? (y1 - y0) : (y0 - y1);
            int sx = (x1 >= x0) ? (1) : (-1);
            int sy = (y1 >= y0) ? (1) : (-1);

            if (dy < dx)
            {
                int d = (dy << 1) - dx;
                int d1 = dy << 1;
                int d2 = (dy - dx) << 1;
                PutPixel(g, clr, x0, y0, 255);
                int x = x0 + sx;
                int y = y0;
                for (int i = 1; i <= dx; i++)
                {
                    if (d > 0)
                    {
                        d += d2;
                        y += sy;
                    }
                    else
                        d += d1;
                    PutPixel(g, clr, x, y, 255);
                    x += sx;
                }
            }
            else
            {
                int d = (dx << 1) - dy;
                int d1 = dx << 1;
                int d2 = (dx - dy) << 1;
                PutPixel(g, clr, x0, y0, 255);
                int x = x0;
                int y = y0 + sy;
                for (int i = 1; i <= dy; i++)
                {
                    if (d > 0)
                    {
                        d += d2;
                        x += sx;
                    }
                    else
                        d += d1;
                    PutPixel(g, clr, x, y, 255);
                    y += sy;
                }
            }
        }

        private void BresenhamMethodButton_Click(object sender, EventArgs e)
        {
            BresenhamLine(LinePicture.CreateGraphics(), Color.Red,
                int.Parse(X0TextBox.Text), int.Parse(Y0TextBox.Text), 
                int.Parse(X1TextBox.Text), int.Parse(Y1TextBox.Text));

        }

        private void BresenhamCircleButton_Click(object sender, EventArgs e)
        {
            BresenhamCircle(LinePicture.CreateGraphics(), Color.Red,
                int.Parse(X0TextBox.Text), int.Parse(Y0TextBox.Text),
                int.Parse(RadiusTextBox.Text));
        }

        private void DDAMethodButton_Click(object sender, EventArgs e)
        {
            LineDDA(LinePicture.CreateGraphics(), Color.Red,
                int.Parse(X0TextBox.Text), int.Parse(Y0TextBox.Text),
                int.Parse(X1TextBox.Text), int.Parse(Y1TextBox.Text));
        }

        private void StepMethodButton_Click(object sender, EventArgs e)
        {
            StepLine(LinePicture.CreateGraphics(), Color.Red,
               int.Parse(X0TextBox.Text), int.Parse(Y0TextBox.Text),
               int.Parse(X1TextBox.Text), int.Parse(Y1TextBox.Text));
        }
    }
}
