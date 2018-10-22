﻿using System.Collections.ObjectModel;
using System.Drawing;

namespace ImageToArray
{
    internal static class ColorPalette
    {
        private static class Colors
        {
            public static readonly ReadOnlyCollection<Color> Web;

            static Colors()
            {
                Web = new ReadOnlyCollection<Color>(new[]
                {
                ColorTranslator.FromHtml("#000000"),
                ColorTranslator.FromHtml("#000033"),
                ColorTranslator.FromHtml("#000066"),
                ColorTranslator.FromHtml("#000099"),
                ColorTranslator.FromHtml("#0000CC"),
                ColorTranslator.FromHtml("#0000FF"),
                ColorTranslator.FromHtml("#003300"),
                ColorTranslator.FromHtml("#003333"),
                ColorTranslator.FromHtml("#003366"),
                ColorTranslator.FromHtml("#003399"),
                ColorTranslator.FromHtml("#0033CC"),
                ColorTranslator.FromHtml("#0033FF"),
                ColorTranslator.FromHtml("#006600"),
                ColorTranslator.FromHtml("#006633"),
                ColorTranslator.FromHtml("#006666"),
                ColorTranslator.FromHtml("#006699"),
                ColorTranslator.FromHtml("#0066CC"),
                ColorTranslator.FromHtml("#0066FF"),
                ColorTranslator.FromHtml("#009900"),
                ColorTranslator.FromHtml("#009933"),
                ColorTranslator.FromHtml("#009966"),
                ColorTranslator.FromHtml("#009999"),
                ColorTranslator.FromHtml("#0099CC"),
                ColorTranslator.FromHtml("#0099FF"),
                ColorTranslator.FromHtml("#00CC00"),
                ColorTranslator.FromHtml("#00CC33"),
                ColorTranslator.FromHtml("#00CC66"),
                ColorTranslator.FromHtml("#00CC99"),
                ColorTranslator.FromHtml("#00CCCC"),
                ColorTranslator.FromHtml("#00CCFF"),
                ColorTranslator.FromHtml("#00FF00"),
                ColorTranslator.FromHtml("#00FF33"),
                ColorTranslator.FromHtml("#00FF66"),
                ColorTranslator.FromHtml("#00FF99"),
                ColorTranslator.FromHtml("#00FFCC"),
                ColorTranslator.FromHtml("#00FFFF"),
                ColorTranslator.FromHtml("#330000"),
                ColorTranslator.FromHtml("#330033"),
                ColorTranslator.FromHtml("#330066"),
                ColorTranslator.FromHtml("#330099"),
                ColorTranslator.FromHtml("#3300CC"),
                ColorTranslator.FromHtml("#3300FF"),
                ColorTranslator.FromHtml("#333300"),
                ColorTranslator.FromHtml("#333333"),
                ColorTranslator.FromHtml("#333366"),
                ColorTranslator.FromHtml("#333399"),
                ColorTranslator.FromHtml("#3333CC"),
                ColorTranslator.FromHtml("#3333FF"),
                ColorTranslator.FromHtml("#336600"),
                ColorTranslator.FromHtml("#336633"),
                ColorTranslator.FromHtml("#336666"),
                ColorTranslator.FromHtml("#336699"),
                ColorTranslator.FromHtml("#3366CC"),
                ColorTranslator.FromHtml("#3366FF"),
                ColorTranslator.FromHtml("#339900"),
                ColorTranslator.FromHtml("#339933"),
                ColorTranslator.FromHtml("#339966"),
                ColorTranslator.FromHtml("#339999"),
                ColorTranslator.FromHtml("#3399CC"),
                ColorTranslator.FromHtml("#3399FF"),
                ColorTranslator.FromHtml("#33CC00"),
                ColorTranslator.FromHtml("#33CC33"),
                ColorTranslator.FromHtml("#33CC66"),
                ColorTranslator.FromHtml("#33CC99"),
                ColorTranslator.FromHtml("#33CCCC"),
                ColorTranslator.FromHtml("#33CCFF"),
                ColorTranslator.FromHtml("#33FF00"),
                ColorTranslator.FromHtml("#33FF33"),
                ColorTranslator.FromHtml("#33FF66"),
                ColorTranslator.FromHtml("#33FF99"),
                ColorTranslator.FromHtml("#33FFCC"),
                ColorTranslator.FromHtml("#33FFFF"),
                ColorTranslator.FromHtml("#660000"),
                ColorTranslator.FromHtml("#660033"),
                ColorTranslator.FromHtml("#660066"),
                ColorTranslator.FromHtml("#660099"),
                ColorTranslator.FromHtml("#6600CC"),
                ColorTranslator.FromHtml("#6600FF"),
                ColorTranslator.FromHtml("#663300"),
                ColorTranslator.FromHtml("#663333"),
                ColorTranslator.FromHtml("#663366"),
                ColorTranslator.FromHtml("#663399"),
                ColorTranslator.FromHtml("#6633CC"),
                ColorTranslator.FromHtml("#6633FF"),
                ColorTranslator.FromHtml("#666600"),
                ColorTranslator.FromHtml("#666633"),
                ColorTranslator.FromHtml("#666666"),
                ColorTranslator.FromHtml("#666699"),
                ColorTranslator.FromHtml("#6666CC"),
                ColorTranslator.FromHtml("#6666FF"),
                ColorTranslator.FromHtml("#669900"),
                ColorTranslator.FromHtml("#669933"),
                ColorTranslator.FromHtml("#669966"),
                ColorTranslator.FromHtml("#669999"),
                ColorTranslator.FromHtml("#6699CC"),
                ColorTranslator.FromHtml("#6699FF"),
                ColorTranslator.FromHtml("#66CC00"),
                ColorTranslator.FromHtml("#66CC33"),
                ColorTranslator.FromHtml("#66CC66"),
                ColorTranslator.FromHtml("#66CC99"),
                ColorTranslator.FromHtml("#66CCCC"),
                ColorTranslator.FromHtml("#66CCFF"),
                ColorTranslator.FromHtml("#66FF00"),
                ColorTranslator.FromHtml("#66FF33"),
                ColorTranslator.FromHtml("#66FF66"),
                ColorTranslator.FromHtml("#66FF99"),
                ColorTranslator.FromHtml("#66FFCC"),
                ColorTranslator.FromHtml("#66FFFF"),
                ColorTranslator.FromHtml("#990000"),
                ColorTranslator.FromHtml("#990033"),
                ColorTranslator.FromHtml("#990066"),
                ColorTranslator.FromHtml("#990099"),
                ColorTranslator.FromHtml("#9900CC"),
                ColorTranslator.FromHtml("#9900FF"),
                ColorTranslator.FromHtml("#993300"),
                ColorTranslator.FromHtml("#993333"),
                ColorTranslator.FromHtml("#993366"),
                ColorTranslator.FromHtml("#993399"),
                ColorTranslator.FromHtml("#9933CC"),
                ColorTranslator.FromHtml("#9933FF"),
                ColorTranslator.FromHtml("#996600"),
                ColorTranslator.FromHtml("#996633"),
                ColorTranslator.FromHtml("#996666"),
                ColorTranslator.FromHtml("#996699"),
                ColorTranslator.FromHtml("#9966CC"),
                ColorTranslator.FromHtml("#9966FF"),
                ColorTranslator.FromHtml("#999900"),
                ColorTranslator.FromHtml("#999933"),
                ColorTranslator.FromHtml("#999966"),
                ColorTranslator.FromHtml("#999999"),
                ColorTranslator.FromHtml("#9999CC"),
                ColorTranslator.FromHtml("#9999FF"),
                ColorTranslator.FromHtml("#99CC00"),
                ColorTranslator.FromHtml("#99CC33"),
                ColorTranslator.FromHtml("#99CC66"),
                ColorTranslator.FromHtml("#99CC99"),
                ColorTranslator.FromHtml("#99CCCC"),
                ColorTranslator.FromHtml("#99CCFF"),
                ColorTranslator.FromHtml("#99FF00"),
                ColorTranslator.FromHtml("#99FF33"),
                ColorTranslator.FromHtml("#99FF66"),
                ColorTranslator.FromHtml("#99FF99"),
                ColorTranslator.FromHtml("#99FFCC"),
                ColorTranslator.FromHtml("#99FFFF"),
                ColorTranslator.FromHtml("#CC0000"),
                ColorTranslator.FromHtml("#CC0033"),
                ColorTranslator.FromHtml("#CC0066"),
                ColorTranslator.FromHtml("#CC0099"),
                ColorTranslator.FromHtml("#CC00CC"),
                ColorTranslator.FromHtml("#CC00FF"),
                ColorTranslator.FromHtml("#CC3300"),
                ColorTranslator.FromHtml("#CC3333"),
                ColorTranslator.FromHtml("#CC3366"),
                ColorTranslator.FromHtml("#CC3399"),
                ColorTranslator.FromHtml("#CC33CC"),
                ColorTranslator.FromHtml("#CC33FF"),
                ColorTranslator.FromHtml("#CC6600"),
                ColorTranslator.FromHtml("#CC6633"),
                ColorTranslator.FromHtml("#CC6666"),
                ColorTranslator.FromHtml("#CC6699"),
                ColorTranslator.FromHtml("#CC66CC"),
                ColorTranslator.FromHtml("#CC66FF"),
                ColorTranslator.FromHtml("#CC9900"),
                ColorTranslator.FromHtml("#CC9933"),
                ColorTranslator.FromHtml("#CC9966"),
                ColorTranslator.FromHtml("#CC9999"),
                ColorTranslator.FromHtml("#CC99CC"),
                ColorTranslator.FromHtml("#CC99FF"),
                ColorTranslator.FromHtml("#CCCC00"),
                ColorTranslator.FromHtml("#CCCC33"),
                ColorTranslator.FromHtml("#CCCC66"),
                ColorTranslator.FromHtml("#CCCC99"),
                ColorTranslator.FromHtml("#CCCCCC"),
                ColorTranslator.FromHtml("#CCCCFF"),
                ColorTranslator.FromHtml("#CCFF00"),
                ColorTranslator.FromHtml("#CCFF33"),
                ColorTranslator.FromHtml("#CCFF66"),
                ColorTranslator.FromHtml("#CCFF99"),
                ColorTranslator.FromHtml("#CCFFCC"),
                ColorTranslator.FromHtml("#CCFFFF"),
                ColorTranslator.FromHtml("#FF0000"),
                ColorTranslator.FromHtml("#FF0033"),
                ColorTranslator.FromHtml("#FF0066"),
                ColorTranslator.FromHtml("#FF0099"),
                ColorTranslator.FromHtml("#FF00CC"),
                ColorTranslator.FromHtml("#FF00FF"),
                ColorTranslator.FromHtml("#FF3300"),
                ColorTranslator.FromHtml("#FF3333"),
                ColorTranslator.FromHtml("#FF3366"),
                ColorTranslator.FromHtml("#FF3399"),
                ColorTranslator.FromHtml("#FF33CC"),
                ColorTranslator.FromHtml("#FF33FF"),
                ColorTranslator.FromHtml("#FF6600"),
                ColorTranslator.FromHtml("#FF6633"),
                ColorTranslator.FromHtml("#FF6666"),
                ColorTranslator.FromHtml("#FF6699"),
                ColorTranslator.FromHtml("#FF66CC"),
                ColorTranslator.FromHtml("#FF66FF"),
                ColorTranslator.FromHtml("#FF9900"),
                ColorTranslator.FromHtml("#FF9933"),
                ColorTranslator.FromHtml("#FF9966"),
                ColorTranslator.FromHtml("#FF9999"),
                ColorTranslator.FromHtml("#FF99CC"),
                ColorTranslator.FromHtml("#FF99FF"),
                ColorTranslator.FromHtml("#FFCC00"),
                ColorTranslator.FromHtml("#FFCC33"),
                ColorTranslator.FromHtml("#FFCC66"),
                ColorTranslator.FromHtml("#FFCC99"),
                ColorTranslator.FromHtml("#FFCCCC"),
                ColorTranslator.FromHtml("#FFCCFF"),
                ColorTranslator.FromHtml("#FFFF00"),
                ColorTranslator.FromHtml("#FFFF33"),
                ColorTranslator.FromHtml("#FFFF66"),
                ColorTranslator.FromHtml("#FFFF99"),
                ColorTranslator.FromHtml("#FFFFCC"),
                ColorTranslator.FromHtml("#FFFFFF")
            });
            }
        }

        public static Color FindNearest(Color color)
        {
            if (color == Color.Transparent) return color;

            var nearest = Color.Transparent;
            var lowest = double.MaxValue;

            foreach (var c in Colors.Web)
            {
                var distance = c.Distance(color);
                if (distance < lowest)
                {
                    lowest = distance;
                    nearest = c;
                }
            }

            return nearest;
        }
    }
}