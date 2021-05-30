using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Polygon : List<PointF>
    {
        public Polygon()
            : base()
        { }

        public Polygon(int capacity)
            : base(capacity)
        { }

        public Polygon(IEnumerable<PointF> collection)
            : base(collection)
        { }

        public bool IsConvex
        {
            get
            {
                if (Count >= 3)
                {
                    for (int a = Count - 2, b = Count - 1, c = 0; c < Count; a = b, b = c, ++c)
                    {
                        if (!new Segment(this[a], this[b]).OnLeft(this[c]))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }

        public IEnumerable<Segment> Edges
        {
            get
            {
                if (Count >= 2)
                {
                    for (int a = Count - 1, b = 0; b < Count; a = b, ++b)
                    {
                        yield return new Segment(this[a], this[b]);
                    }
                }
            }
        }

        private bool CyrusBeckClip(ref Segment subject)
        {
            var subjDir = subject.Direction;
            var tA = 0.0f;
            var tB = 1.0f;
            foreach (var edge in Edges)
            {
                switch (Math.Sign(edge.Normal.Dot(subjDir)))
                {
                    case -1:
                        {
                            var t = subject.IntersectionParameter(edge);
                            if (t > tA)
                            {
                                tA = t;
                            }
                            break;
                        }
                    case +1:
                        {
                            var t = subject.IntersectionParameter(edge);
                            if (t < tB)
                            {
                                tB = t;
                            }
                            break;
                        }
                    case 0:
                        {
                            if (!edge.OnLeft(subject.A))
                            {
                                return false;
                            }
                            break;
                        }
                }
            }
            if (tA > tB)
            {
                return false;
            }
            subject = subject.Morph(tA, tB);
            return true;
        }

        public List<Segment> CyrusBeckClip(List<Segment> subjects)
        {
            if (!IsConvex)
            {
                Reverse();
                if (!IsConvex)
                {
                    throw new InvalidOperationException("Clip polygon must be convex.");
                }
            }

            var clippedSubjects = new List<Segment>();
            foreach (var subject in subjects)
            {
                var clippedSubject = subject;
                if (CyrusBeckClip(ref clippedSubject))
                {
                    clippedSubjects.Add(clippedSubject);
                }
            }
            return clippedSubjects;
        }
    }
}
