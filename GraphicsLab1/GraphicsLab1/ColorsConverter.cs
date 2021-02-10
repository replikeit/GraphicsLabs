using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLab1
{
    static class ColorsConverter
    {
        public static (double, double, double) XYZtoLAB(double x, double y, double z)
        {
            Func<double, double> F = (double val)=>
            {
                if (val >= 0.008856) return Math.Pow(val, 1 / 3f);
                return 7.787 * val + 16 / 116f;
            };

            double L = 116 * F(y / 100f) - 16;
            double a = 500 * (F(x / 95.047) - F(y / 100f));
            double b = 200 * (F(y / 100f) - F(z / 108.883));
            return (L, a, b);
        }

        public static (double, double, double) LABtoXYZ(double l, double a, double b)
        {
            Func<double, double> F = (double val) =>
            {
                if (val >= 0.008856) return Math.Pow(val, 3f);
                return (val - 16 / 116f) / 7.787;
            };

            double y = F((l + 16)/116) * 95.047;
            double x = F(a / 500 + (l + 16) / 116) * 100;
            double z = F((l + 16)/116 - b/200) * 108.883;
            return (x, y, z);
        }

        public static (int, int, int) XYZtoRGB(double x, double y, double z)
        {
            Func<double, double> F = (double val)=>
            {
                if (val >= 0.0031308) return 1.055 * Math.Pow(val, 1 / 2.4) - 0.055;
                return 12.92 * val;
            };

            x /= 100;
            y /= 100;
            z /= 100;

            int r = (int)Math.Round(F(3.2406 * x - 1.5372 * y - 0.4986 * z) * 255);
            int g = (int)Math.Round(F(-0.9689 * x + 1.8758 * y + 0.0415 * z) * 255);
            int b = (int)Math.Round(F(0.0557 * x - 0.2040 * y + 1.0570 * z) * 255);
            return (r, g, b);
        }

        private static double Max(params double[] rgb) => rgb.Max();
        private static double Min(params double[] rgb) => rgb.Min();

        public static (int, double, double) RGBtoHLS(int r, int g, int b)
        {
            double rd = r / 255f, gd = g / 255f, bd = b / 255f;
            double max = Max(rd, gd, bd);
            double min = Min(rd, gd, bd);

            int h = 0;
            double l = (max + min) / 2f, s = 0;

            if (min != max)
            {
                if (rd == max && gd >= bd)
                    h = (int) Math.Round(60 * (gd - bd) / (max - min));
                else if (rd == max && gd < bd)
                    h = (int)Math.Round(60 * (gd - bd) / (max - min)) + 360;
                else if (gd == max)
                    h = (int)Math.Round(60 * (bd - rd) / (max - min)) + 120;
                else if(bd == max)
                    h = (int)Math.Round(60 * (rd - gd) / (max - min)) + 240;

                s = (max - min)/(1 - Math.Abs(1 - max + min));
            }
            return (h, l * 100, s * 100);
        }

        public static (double, double, double) RGBtoXYZ(int r, int g, int b)
        {
            Func<double, double> F = (double val) =>
            {
                if (val >= 0.004045) return Math.Pow((val + 0.055) / 1.055, 2.4);
                return val / 12.92;
            };

            double rd = r / 255f, gd = g / 255f, bd = b / 255f;

            double x = (F(0.412453 * rd + 0.357580 * gd + 0.180423 * bd) * 100);
            double y = (F(0.212671 * rd + 0.715160 * gd + 0.072169 * bd) * 100);
            double z = (F(0.019334 * rd + 0.119193 * gd + 0.950227 * bd) * 100);
            return (x, y, z);
        }

        public static bool RoundingRGB(ref int r, ref int g, ref int b)
        {
            bool isRounded = false;

            if (r > 255 || r < 0 ||
                g > 255 || g < 0 ||
                b > 255 || b < 0)
            {
                isRounded = true;

                if (r > 255) r = 255;
                else if (r < 0) r = 0;

                if (g > 255) g = 255;
                else if (g < 0) g = 0;

                if (b > 255) b = 255;
                else if (b < 0) b = 0;
            }

            return isRounded;
        }

        public static (int, int, int) HLStoRGB(int h, double l, double s)
        {
            s /= 100;
            l /= 100;

            double c = (1 - Math.Abs(2 * l - 1)) * s;
            double x = c * (1 - Math.Abs((h / 60f) % 2 - 1));
            double m = l - c / 2f;

            double r = 0, g = 0, b = 0;

            if (h < 60)
            {
                r = c;
                g = x;
                b = 0;
            }
            else if (h < 120)
            {
                r = x;
                g = c;
                b = 0;
            }
            else if (h < 180)
            {
                r = 0;
                g = c;
                b = x;
            }
            else if (h < 240)
            {
                r = 0;
                g = x;
                b = c;
            }
            else if (h < 300)
            {
                r = x;
                g = 0;
                b = c;
            }
            else if (h < 360)
            {
                r = c;
                g = 0;
                b = x;
            }

            return ((int)Math.Round((r + m) * 255), (int)Math.Round((g + m) * 255), (int)Math.Round((b + m) * 255));
        }
    }
}
