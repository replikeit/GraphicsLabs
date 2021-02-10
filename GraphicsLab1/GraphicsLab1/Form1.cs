using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GraphicsLab1
{
    public partial class Form1 : Form
    {
        private double _x = 95.047/255;
        private double _y = 100f/255;
        private double _z = 108.883/255;

        private double _l = 100 / 255f;
        public Form1()
        {
            InitializeComponent();
            RefreshColor();
        }

        #region ScrollEvents

        private void XYZ_Scroll(object sender, EventArgs e)
        {
            TrackBar tb = (TrackBar)sender;
            switch (tb.Tag.ToString())
            {
                case "x":
                    XCountLabel.Text = (tb.Value * _x).ToString("0.#########");
                    break;
                case "y":
                    YCountLabel.Text = (tb.Value * _y).ToString("0.#########");
                    break;
                case "z":
                    ZCountLabel.Text = (tb.Value * _z).ToString("0.#########");
                    break;
            }

            RefreshLab();
            RefreshHls();
            RefreshColor();
        }

        private void LAB_Scroll(object sender, EventArgs e)
        {
            TrackBar tb = (TrackBar)sender;
            switch (tb.Tag.ToString())
            {
                case "l":
                    LCountLabel.Text = (tb.Value * _l).ToString("0.#########");
                    break;
                case "a":
                    ACountLabel.Text = (tb.Value - 128).ToString("0.#########");
                    break;
                case "b":
                    BCountLabel.Text = (tb.Value - 128).ToString("0.#########");
                    break;
            }
            RefreshXYZ1();
            RefreshHls();
            RefreshColor();
        }

        private void HLS_Scroll(object sender, EventArgs e)
        {
            TrackBar tb = (TrackBar)sender;
            switch (tb.Tag.ToString())
            {
                case "h":
                    HueCountLabel.Text = tb.Value.ToString();
                    break;
                case "l":
                    LightCountLabel.Text = (_l * tb.Value).ToString("0.#########");
                    break;
                case "s":
                    StaturationCountLabel.Text = (_l * tb.Value).ToString("0.#########");
                    break;
            }

            RefreshXYZ2();
            RefreshLab();
            RefreshColor();
        }

        #endregion

        #region Refreshers

        private void RefreshHls()
        {
            var rgb = ColorsConverter.XYZtoRGB(double.Parse(XCountLabel.Text), double.Parse(YCountLabel.Text),
                double.Parse(ZCountLabel.Text));
            ColorsConverter.RoundingRGB(ref rgb.Item1, ref rgb.Item2, ref rgb.Item3);
            var hls = ColorsConverter.RGBtoHLS(rgb.Item1, rgb.Item2, rgb.Item3);

            HueCountLabel.Text = hls.Item1.ToString("0.#########");
            LightCountLabel.Text = hls.Item2.ToString("0.#########");
            StaturationCountLabel.Text = hls.Item3.ToString("0.#########");

            HueTrack.Value = hls.Item1;
            LightTrack.Value = (int)(hls.Item2 * 255 / 100);
            SaturationTrack.Value = (int)(hls.Item3 * 255 / 100);
        }
        private void RefreshXYZ2()
        {
            var rgb = ColorsConverter.HLStoRGB(int.Parse(HueCountLabel.Text), 
                double.Parse(LightCountLabel.Text), 
                double.Parse(StaturationCountLabel.Text));
            var xyz = ColorsConverter.RGBtoXYZ(rgb.Item1, rgb.Item2, rgb.Item3);

            XCountLabel.Text = xyz.Item1.ToString("0.#########");
            YCountLabel.Text = xyz.Item2.ToString("0.#########");
            ZCountLabel.Text = xyz.Item3.ToString("0.#########");

            if (xyz.Item1 < 0) XTrack.Value = 0;
            else if (xyz.Item1 > 95.047) XTrack.Value = 255;
            else XTrack.Value = (int)(xyz.Item1 * 255 / 95.047);

            if (xyz.Item2 < 0) YTrack.Value = 0;
            else if (xyz.Item2 > 100) YTrack.Value = 255;
            else YTrack.Value = (int)(xyz.Item2 * 255 / 100);

            if (xyz.Item3 < 0) ZTrack.Value = 0;
            else if (xyz.Item3 > 108.883) ZTrack.Value = 255;
            else ZTrack.Value = (int)(xyz.Item3 * 255 / 108.883);
        }

        private void RefreshColor()
        {
            var rgb = ColorsConverter.XYZtoRGB(double.Parse(XCountLabel.Text), 
                double.Parse(YCountLabel.Text), 
                double.Parse(ZCountLabel.Text));
            if (ColorsConverter.RoundingRGB(ref rgb.Item1, ref rgb.Item2, ref rgb.Item3))
                ColorInfoLabel.Text = $"Цвет округлен({rgb.Item1}, {rgb.Item2}, {rgb.Item3})";
            else
                ColorInfoLabel.Text = $"Нормальный цвет({rgb.Item1}, {rgb.Item2}, {rgb.Item3})";
            ColorPanel.BackColor = Color.FromArgb(rgb.Item1, rgb.Item2, rgb.Item3);
        }

        private void RefreshLab()
        {
            var lab = ColorsConverter.XYZtoLAB(double.Parse(XCountLabel.Text), double.Parse(YCountLabel.Text),
                double.Parse(ZCountLabel.Text));
            LCountLabel.Text = lab.Item1.ToString("0.#########");
            ACountLabel.Text = lab.Item2.ToString("0.#########");
            BCountLabel.Text = lab.Item3.ToString("0.#########");

            LTrack.Value = (int)(lab.Item1 * 255 / 100);

            if (lab.Item2 < -128) ATrack.Value = 0;
            else if (lab.Item2 > 128) ATrack.Value = 256;
            else ATrack.Value = (int)Math.Round(lab.Item2) + 128;

            if (lab.Item3 < -128) BTrack.Value = 0;
            else if (lab.Item3 > 128) BTrack.Value = 256;
            else BTrack.Value = (int)Math.Round(lab.Item3) + 128;
        }

        private void RefreshXYZ1()
        {
            var xyz = ColorsConverter.LABtoXYZ(double.Parse(LCountLabel.Text), double.Parse(ACountLabel.Text),
                double.Parse(BCountLabel.Text));
            XCountLabel.Text = xyz.Item1.ToString("0.#########");
            YCountLabel.Text = xyz.Item2.ToString("0.#########");
            ZCountLabel.Text = xyz.Item3.ToString("0.#########");

            if (xyz.Item1 < 0) XTrack.Value = 0;
            else if (xyz.Item1 > 95.047) XTrack.Value = 255;
            else XTrack.Value = (int)(xyz.Item1 * 255 / 95.047);

            if (xyz.Item2 < 0) YTrack.Value = 0;
            else if (xyz.Item2 > 100) YTrack.Value = 255;
            else YTrack.Value = (int)(xyz.Item2 * 255 / 100);

            if (xyz.Item3 < 0) ZTrack.Value = 0;
            else if (xyz.Item3 > 108.883) ZTrack.Value = 255;
            else ZTrack.Value = (int)(xyz.Item3 * 255 / 108.883);
        }

        #endregion


    }
}
