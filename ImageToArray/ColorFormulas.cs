using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace ImageToArray
{
    /// <remarks>
    /// https://blog.genreof.com/post/comparing-colors-using-delta-e-in-c
    /// </remarks>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class ColorFormulas
    {
        private double X { get; set; }
        private double Y { get; set; }
        private double Z { get; set; }
        private double CieL { get; set; }
        private double CieA { get; set; }
        private double CieB { get; set; }

        public static double Distance(Color color1, Color color2)
        {
            var a = new ColorFormulas(color1.R, color1.G, color1.B);
            var b = new ColorFormulas(color2.R, color2.G, color2.B);

            return a.CompareTo(b);
        }

        private ColorFormulas(int R, int G, int B)
        {
            RGBtoLAB(R, G, B);
        }

        private void RGBtoLAB(int R, int G, int B)
        {
            RGBtoXYZ(R, G, B);
            XYZtoLAB();
        }

        private void RGBtoXYZ(int RVal, int GVal, int BVal)
        {
            var R = Convert.ToDouble(RVal) / 255.0;       //R from 0 to 255
            var G = Convert.ToDouble(GVal) / 255.0;       //G from 0 to 255
            var B = Convert.ToDouble(BVal) / 255.0;       //B from 0 to 255

            if (R > 0.04045)
            {
                R = Math.Pow(((R + 0.055) / 1.055), 2.4);
            }
            else
            {
                R = R / 12.92;
            }
            if (G > 0.04045)
            {
                G = Math.Pow(((G + 0.055) / 1.055), 2.4);
            }
            else
            {
                G = G / 12.92;
            }
            if (B > 0.04045)
            {
                B = Math.Pow(((B + 0.055) / 1.055), 2.4);
            }
            else
            {
                B = B / 12.92;
            }

            R = R * 100;
            G = G * 100;
            B = B * 100;

            //Observer. = 2°, Illuminant = D65
            X = R * 0.4124 + G * 0.3576 + B * 0.1805;
            Y = R * 0.2126 + G * 0.7152 + B * 0.0722;
            Z = R * 0.0193 + G * 0.1192 + B * 0.9505;
        }

        private void XYZtoLAB()
        {
            // based upon the XYZ - CIE-L*ab formula at easyrgb.com (http://www.easyrgb.com/index.php?X=MATH&H=07#text7)
            var ref_X = 95.047;
            var ref_Y = 100.000;
            var ref_Z = 108.883;

            var var_X = X / ref_X;         // Observer= 2°, Illuminant= D65
            var var_Y = Y / ref_Y;
            var var_Z = Z / ref_Z;

            if (var_X > 0.008856)
            {
                var_X = Math.Pow(var_X, (1 / 3.0));
            }
            else
            {
                var_X = (7.787 * var_X) + (16 / 116.0);
            }
            if (var_Y > 0.008856)
            {
                var_Y = Math.Pow(var_Y, (1 / 3.0));
            }
            else
            {
                var_Y = (7.787 * var_Y) + (16 / 116.0);
            }
            if (var_Z > 0.008856)
            {
                var_Z = Math.Pow(var_Z, (1 / 3.0));
            }
            else
            {
                var_Z = (7.787 * var_Z) + (16 / 116.0);
            }

            CieL = (116 * var_Y) - 16;
            CieA = 500 * (var_X - var_Y);
            CieB = 200 * (var_Y - var_Z);
        }

        public int CompareTo(ColorFormulas oComparisionColor)
        {
            // Based upon the Delta-E (1976) formula at easyrgb.com (http://www.easyrgb.com/index.php?X=DELT&H=03#text3)
            var deltaE = Math.Sqrt(Math.Pow((CieL - oComparisionColor.CieL), 2) + Math.Pow((CieA - oComparisionColor.CieA), 2) + Math.Pow((CieB - oComparisionColor.CieB), 2));
            return Convert.ToInt16(Math.Round(deltaE));
        }
    }
}