using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        private GraphicsDrawer _drawer;
        private List<PointF> _poligonDots;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _poligonDots = new List<PointF>();
            _drawer = new GraphicsDrawer(ViewPictureBox.CreateGraphics());
            _drawer.AddPolygon(new List<PointF>()
            {
                new PointF(100, 100),
                new PointF(200, 100),
                new PointF(250, 175),
                new PointF(100, 100)
            });
        }

        private void CreatePolygon_Click(object sender, EventArgs e)
        {
            _drawer.AddPolygon(_poligonDots);
        }

        private void AddLineButton_Click(object sender, EventArgs e)
        {
            _drawer.AddLine(
                new Segment(
                    new PointF(float.Parse(X0LineTextBox.Text), float.Parse(Y0LineTextBox.Text)),
                    new PointF(float.Parse(X1LineTextBox.Text), float.Parse(Y1LineTextBox.Text))
                ));
        }

        private void CutOffButton_Click(object sender, EventArgs e)
        {
            _drawer.CutOff();
        }

        private void AddPolygonDotButton_Click(object sender, EventArgs e)
        {
            _poligonDots.Add(new PointF(float.Parse(XPolygonTextBox.Text), float.Parse(YPolygonTextBox.Text)));
        }

        private void SimplePolygonButton_Click(object sender, EventArgs e)
        {
            _drawer.AddPolygon(new List<PointF>()
            {
                new PointF(100, 100),
                new PointF(300, 100),
                new PointF(400, 275),
                new PointF(400, 375),
                new PointF(300, 475),
                new PointF(100, 475),
                new PointF(50, 400),
                new PointF(50, 275),
                new PointF(100, 100)
            });
        }
    }
}
