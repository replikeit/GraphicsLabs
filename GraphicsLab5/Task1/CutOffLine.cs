using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class CutOffLine
    {
        private Graphics _g;
        private Rectangle _curRect;
        private List<(int X0, int Y0, int X1, int Y1)> _lines;
        public CutOffLine(Graphics g)
        {
            _g = g;
        }

        public void AddRectangle(int x0, int y0, int x1, int y1)
        {
            _g.Clear(Color.White);
            _lines = new List<(int X0, int Y0, int X1, int Y1)>();

            _curRect = new Rectangle(x0, y0, x1 - x0, y1 - y0);
            _g.DrawRectangle(new Pen(Color.Red), _curRect);
        }

        public void AddLine(int x0, int y0, int x1, int y1)
        {
            _lines.Add((x0, y0, x1, y1));
            _g.DrawLine(new Pen(Color.Blue), x0, y0, x1, y1);
        }

        public void MiddlePointCutOff()
        {
            foreach (var line in _lines)
            {
                DoCutOff(line.X0, line.Y0, line.X1, line.Y1);
            }
            
        }

        private (int Min, int Max) MinMax(int x1, int x2) => x1 <= x2 ? (x1, x2) : (x2, x1);

        private void DoCutOff(int x0, int y0, int x1, int y1)
        {
            if (IsInRectangle(x0, y0, x1, y1))
                return;

            if (Math.Abs(x0 - x1) < 2 && Math.Abs(y0 - y1) < 2)
            {
                _g.DrawLine(new Pen(Color.White, 1), x0, y0, x1, y1);
                return;
            }

            if (!IsIntersect(x0, y0, x1, y1))
            {
                _g.DrawLine(new Pen(Color.White, 3), x0, y0, x1, y1);
                return;
            }

            int midX = Math.Abs((x1 + x0) / 2);
            int midY = Math.Abs((y1 + y0) / 2);

            DoCutOff(midX, midY, x1, y1);
            DoCutOff(x0, y0, midX, midY);
        }

        private bool IsInRectangle(int x0, int y0, int x1, int y1)
        {
            var tmpX = MinMax(x0, x1);
            var tmpY = MinMax(y0, y1);

            return (tmpX.Min > _curRect.Left && tmpX.Max < _curRect.Right &&
                    tmpY.Min > _curRect.Top && tmpY.Max < _curRect.Bottom);
        }

        private bool IsIntersect(int x0, int y0, int x1, int y1)
        {

            var tmpX = MinMax(x0, x1);
            var tmpY = MinMax(y0, y1);

            if (tmpX.Max < _curRect.Left || tmpY.Min > _curRect.Right ||
                tmpY.Max < _curRect.Top || tmpY.Min > _curRect.Bottom)
                return false;
            
            double k = (double)(y1 - y0)/(x1 - x0);
            double b = y0 - k * x0;

            double yLeft = k * _curRect.Left + b;
            double yRight = k * _curRect.Right + b;

            if ((_curRect.Bottom > yLeft && _curRect.Bottom > yRight) &&
                (_curRect.Top < yLeft && _curRect.Top < yRight))
                return false;

            return true;
        }
    }
}
