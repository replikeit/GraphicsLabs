using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public struct Segment
    {
        public readonly PointF A, B;

        public Segment(PointF a, PointF b)
        {
            A = a;
            B = b;
        }

        public bool OnLeft(PointF p)
        {
            var ab = new PointF(B.X - A.X, B.Y - A.Y);
            var ap = new PointF(p.X - A.X, p.Y - A.Y);
            return ab.Cross(ap) >= 0;
        }

        public PointF Normal
        {
            get
            {
                return new PointF(B.Y - A.Y, A.X - B.X);
            }
        }

        public PointF Direction
        {
            get
            {
                return new PointF(B.X - A.X, B.Y - A.Y);
            }
        }

        public float IntersectionParameter(Segment that)
        {
            var segment = this;
            var edge = that;

            var segmentToEdge = edge.A.Sub(segment.A);
            var segmentDir = segment.Direction;
            var edgeDir = edge.Direction;

            var t = edgeDir.Cross(segmentToEdge) / edgeDir.Cross(segmentDir);

            if (float.IsNaN(t))
            {
                t = 0;
            }

            return t;
        }

        public Segment Morph(float tA, float tB)
        {
            var d = Direction;
            return new Segment(A.Add(d.Mul(tA)), A.Add(d.Mul(tB)));
        }
    }
}
