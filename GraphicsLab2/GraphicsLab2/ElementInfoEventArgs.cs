using System;
using System.Drawing.Imaging;

namespace GraphicsLab2
{
    public class ElementInfoEventArgs : EventArgs
    {
        public string FileName { get; }
        public int SizeX { get; }
        public int SizeY { get; }
        public float Resolution { get; }
        public PixelFormat Depth { get; }
        public string ImageСompression { get; }

        public ElementInfoEventArgs(string fileName, int sizeX, int sizeY, float resolution, PixelFormat depth, string imageСompression)
        {
            FileName = fileName;
            SizeX = sizeX;
            SizeY = sizeY;
            Resolution = resolution;
            Depth = depth;
            ImageСompression = imageСompression;
        }
    }
}