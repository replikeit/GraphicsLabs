using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        private CutOffLine _offSetLine;

        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            _offSetLine.AddRectangle(
                int.Parse(X0RectTextBox.Text),
                int.Parse(Y0RectTextBox.Text),
                int.Parse(X1RectTextBox.Text),
                int.Parse(Y1RectTextBox.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _offSetLine = new CutOffLine(ViewPictureBox.CreateGraphics());
        }

        private void AddLineButton_Click(object sender, EventArgs e)
        {
            _offSetLine.AddLine(
                int.Parse(X0LineTextBox.Text),
                int.Parse(Y0LineTextBox.Text),
                int.Parse(X1LineTextBox.Text),
                int.Parse(Y1LineTextBox.Text));
        }

        private void CutOffButton_Click(object sender, EventArgs e)
        {
            _offSetLine.MiddlePointCutOff();
        }
    }
}
