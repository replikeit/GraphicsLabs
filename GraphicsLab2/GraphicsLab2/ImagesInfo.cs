using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Mime;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Encoder = System.Text.Encoder;

namespace GraphicsLab2
{
    public class ImagesInfo
    {
        private string[] _filesNames;

        private static Dictionary<int, string> _comDict = new Dictionary<int, string>()
        {
            {-1, "-"},
            {1, "No compression"},
            {2, "CCITT Huffman"},
            {3, "CCITT Group 3"},
            {4, "CCITT Group 4"},
            {5, "LZW"},
            {6, "Old style JPEG"},
            {7, "New style JPEG"},
            {8, "Flate"}
        };
        public event EventHandler<ElementInfoEventArgs> OnGetInfo; 
        
        public ImagesInfo(string path) => _filesNames = Directory.GetFiles(path);

        public void GetFilesByRange(int a, int b)
        {
            if (a < 1 || b > _filesNames.Length) 
                throw new ArgumentException("Параметры выходят за границы размера!");

            for (int i = a - 1; i < b; i++)
            {
                using var fs = new FileStream(_filesNames[i], FileMode.Open, FileAccess.Read);
                using var img = Image.FromStream(fs, true, true);
              
                int compressionTagIndex = Array.IndexOf(img.PropertyIdList, 0x103);
                int com = -1;

                if (compressionTagIndex != -1)
                {
                    PropertyItem compressionTag = img.PropertyItems[compressionTagIndex];
                    com = BitConverter.ToInt16(compressionTag.Value, 0);
                }
                OnGetInfo?.Invoke(this, new ElementInfoEventArgs(
                    Path.GetFileName(_filesNames[i]),
                    img.Size.Width,
                    img.Size.Height,
                    img.HorizontalResolution,
                    img.PixelFormat,
                    _comDict[com]));
            }
        }
        
        public void GetFilesByName(string name)
        {
            string item = _filesNames.FirstOrDefault(x => x.Contains(name));
            if (item != null) return;
            var img = Bitmap.FromFile(item);
            int compressionTagIndex = Array.IndexOf(img.PropertyIdList, 0x103);
            int com = -1;

            if (compressionTagIndex != -1)
            {
                PropertyItem compressionTag = img.PropertyItems[compressionTagIndex];
                com = BitConverter.ToInt16(compressionTag.Value, 0);
            }
            OnGetInfo?.Invoke(this, new ElementInfoEventArgs(
                Path.GetFileName(item),
                img.Size.Width,
                img.Size.Height,
                img.HorizontalResolution,
                img.PixelFormat,
                img.PixelFormat.ToString()));
        }
    }
}