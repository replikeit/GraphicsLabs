using System;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Diagnostics;
using Emgu.CV.Util;
using System.Windows.Forms;
using System.Drawing;

namespace GraphicsLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UploadPictureButton_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog() { Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;" };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                PathTextBox.Text = fileDialog.FileName;
                var img = new Bitmap(fileDialog.FileName);
                SrcPictureBox.Image = new Bitmap(img, new Size(SrcPictureBox.Width, SrcPictureBox.Height));
            }

            OtsuMethodButton.Enabled = true;
            TriangleButton.Enabled = true;
            NegativeButton.Enabled = true;
            ContrastButton.Enabled = true;
            GaussianMethodButton.Enabled = true;
        }

        private void GaussianMethodButton_Click(object sender, EventArgs e)
        {
            MethodNameLabel.Text = "Adaptive TH";

            Image<Gray, byte> imgSrc = new Bitmap(SrcPictureBox.Image).ToImage<Gray, byte>();
            var imgDest = imgSrc.Clone();
            CvInvoke.AdaptiveThreshold(imgDest, imgSrc, 255, AdaptiveThresholdType.GaussianC, ThresholdType.Binary, 25, 0);
            DestPictureBox.Image = imgSrc.ToBitmap();
        }

        private void NegativeButton_Click(object sender, EventArgs e)
        {
            MethodNameLabel.Text = "Negative";

            DestPictureBox.Image = new Bitmap(SrcPictureBox.Image).ToImage<Bgr, byte>().Not().ToBitmap();
        }

        private void ContrastButton_Click(object sender, EventArgs e)
        {
            MethodNameLabel.Text = "Contrast";

            var imgSrc = new Bitmap(SrcPictureBox.Image);
            double minBrigness = double.MaxValue, maxBrigness = 0;
            for (int i = 0; i < imgSrc.Width; i++)
            {
                for (int j = 0; j < imgSrc.Height; j++)
                {
                    var brig = imgSrc.GetPixel(i, j).GetBrightness() * 255;
                    if (brig > maxBrigness) maxBrigness = brig;
                    if (brig < minBrigness) minBrigness = brig;
                }
            }

            for (int i = 0; i < imgSrc.Width; i++)
            {
                for (int j = 0; j < imgSrc.Height; j++)
                {
                    var pixel = imgSrc.GetPixel(i, j);
                    var brig = (int)(pixel.GetBrightness() * 255);
                    var newBrig = (int)((brig - minBrigness ) / (maxBrigness - minBrigness) * 255);
                    
                    int value = newBrig - brig;

                    int newR = Clamp(pixel.R + value, 0, 255);
                    int newG = Clamp(pixel.G + value, 0, 255);
                    int newB = Clamp(pixel.B + value, 0, 255);

                    imgSrc.SetPixel(i, j, Color.FromArgb(newR, newG, newB));

                }

                DestPictureBox.Image = imgSrc;
            }

            int Clamp(int val, int min, int max)
            {
                return val < min ? min : val > max ? max : val;
            }
        }

        private void TriangleButton_Click(object sender, EventArgs e)
        {
            MethodNameLabel.Text = "Triangle";

            Image<Gray, byte> imgSrc = new Bitmap(SrcPictureBox.Image).ToImage<Gray, byte>();
            var imgDest = imgSrc.Clone();
            CvInvoke.Threshold(imgDest, imgSrc, 0, 255, ThresholdType.Triangle);
            DestPictureBox.Image = imgSrc.ToBitmap();
        }

        private void OtsuMethodButton_Click(object sender, EventArgs e)
        {
            MethodNameLabel.Text = "Otsu";

            Image<Gray, byte> imgSrc = new Bitmap(SrcPictureBox.Image).ToImage<Gray, byte>();
            var imgDest = imgSrc.Clone();
            CvInvoke.Threshold(imgDest, imgSrc, 0, 255, ThresholdType.Otsu);
            DestPictureBox.Image = imgSrc.ToBitmap();
        }
    }
}
