using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;

namespace ImageToArray
{
    public class Converter
    {
        private Color[][] _pixelArt;
        private Collection<Color> _colors;

        public Converter()
        {
            GeneratePixelArt(@"C:\Users\LSC\source\repos\ImageToArray\input\9.png", 11, 40);
        }

        private void GeneratePixelArt(string fileName, int tileSize, int tolerance = 20, int whiteTolerance = 10)
        {
            var bitmap = (Bitmap)Image.FromFile(fileName);
            var xTiles = (bitmap.Size.Width / tileSize) + 1;
            var yTiles = (bitmap.Size.Height / tileSize) + 1;

            _pixelArt = new Color[xTiles][];
            _colors = new Collection<Color>();

            for (var x = 0; x < xTiles; x++)
            {
                for (var y = 0; y < yTiles; y++)
                {
                    Console.WriteLine($"{x * yTiles + y} / {xTiles * yTiles}");

                    var pixel = bitmap.GetPixel(Math.Min(x * tileSize, bitmap.Size.Width - 1), Math.Min(y * tileSize, bitmap.Size.Height - 1));
                    var nearest = ColorPalette.FindNearest(pixel);

                    foreach (var color in _colors)
                    {
                        if (color.Distance(nearest) < tolerance)
                        {
                            nearest = color;
                            break;
                        }
                    }

                    if (nearest == Color.White || nearest.Distance(Color.White) < whiteTolerance)
                    {
                        nearest = Color.Transparent;
                    }
                    else
                    {
                        _colors.Add(nearest);
                    }

                    if (_pixelArt[x] == null) _pixelArt[x] = new Color[yTiles];
                    _pixelArt[x][y] = nearest;
                }
            }

            DebugOutput(_pixelArt);
        }

        #region hidethis

        public static Converter Start()
        {
            return new Converter();
        }

        private void DebugOutput(Color[][] pixelArt, int tileSize = 16)
        {
            var xTiles = pixelArt.Length;
            var yTiles = pixelArt[0].Length;
            var bmp = new Bitmap(xTiles * tileSize, yTiles * tileSize);
            var gfx = Graphics.FromImage(bmp);
            var output = "{" + Environment.NewLine;
            gfx.CompositingMode = CompositingMode.SourceCopy;

            for (var x = 0; x < xTiles; x++)
            {
                for (var y = 0; y < yTiles; y++)
                {
                    output += $"new ColoredPoint({x},{y},{pixelArt[x][y].ToArgb()}),{Environment.NewLine}";

                    var brush = new SolidBrush(pixelArt[x][y]);
                    gfx.FillRectangle(brush,
                        (x * tileSize) - tileSize, (y * tileSize) - tileSize,
                        tileSize, tileSize);
                }
            }

            output += "}";

            var fnBase = $@"C:\Users\LSC\source\repos\ImageToArray\output\{DateTime.Now:yyMMddHHmmssss}";
            bmp.Save($"{fnBase}.png", ImageFormat.Png);
            System.IO.File.WriteAllText($"{fnBase}.txt", output, Encoding.ASCII);
            Process.Start($"{fnBase}.txt");

        }

        #endregion
    }
}