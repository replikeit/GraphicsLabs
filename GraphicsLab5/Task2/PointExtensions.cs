using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    public static class PointExtensions
    {
        public static PointF Add(this PointF a, PointF b)
        {
            return new PointF(a.X + b.X, a.Y + b.Y);
        }

        public static PointF Sub(this PointF a, PointF b)
        {
            return new PointF(a.X - b.X, a.Y - b.Y);
        }

        public static PointF Mul(this PointF a, float b)
        {
            return new PointF(a.X * b, a.Y * b);
        }

        public static float Dot(this PointF a, PointF b)
        {
            return a.X * b.X + a.Y * b.Y;
        }

        public static float Cross(this PointF a, PointF b)
        {
            return a.X * b.Y - a.Y * b.X;
        }
    }
}
