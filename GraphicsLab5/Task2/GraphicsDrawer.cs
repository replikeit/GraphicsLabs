using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class GraphicsDrawer
    {
        private Graphics _g;
        private Polygon _curPolygon;
        private List<Segment> _lines;

        public GraphicsDrawer(Graphics g)
        {
            _g = g;
        }

        public void AddPolygon(ICollection<PointF> parties)
        {
            _g.Clear(Color.White);
            _lines = new List<Segment>();
            _curPolygon = new Polygon(parties);
            _g.DrawPolygon(new Pen(Color.Red), _curPolygon.ToArray());
        }

        public void AddLine(Segment line)
        {
            _lines.Add(line);
            _g.DrawLine(new Pen(Color.Blue), line.A.X, line.A.Y, line.B.X, line.B.Y);
        }

        public void CutOff()
        {

            var cutOffLines = _curPolygon.CyrusBeckClip(_lines);

            _g.Clear(Color.White);
            foreach (var line in cutOffLines)
            {
                _g.DrawLine(new Pen(Color.Blue), line.A.X, line.A.Y, line.B.X, line.B.Y);   
            }

            _g.DrawPolygon(new Pen(Color.Red), _curPolygon.ToArray());
        }
    }
}
