using System.Drawing;

namespace ImageToArray
{
    public static class ColorExtensions
    {
        /*/// <remarks>
        ///     https://stackoverflow.com/a/40950076/3450580 <p />
        ///     https://www.compuphase.com/cmetric.htm
        /// </remarks>
        public static double Distance(this Color color1, Color color2)
        {
            var rmean = (color1.R + (long) color2.R) / 2;
            var r = color1.R - (long) color2.R;
            var g = color1.G - (long) color2.G;
            var b = color1.B - (long) color2.B;
            return Math.Sqrt((((512 + rmean) * r * r) >> 8) + 4 * g * g + (((767 - rmean) * b * b) >> 8));
        }*/

        public static double Distance(this Color color1, Color color2)
        {
            return ColorFormulas.Distance(color1, color2);
        }
    }
}