using Serilog;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Wacton.Unicolour;
namespace Blibrary.Shared.Extensions
{
    /// <summary>
    /// <inheritdoc cref="Wacton.Unicolour"/>
    /// 
    /// Unicolour is a C# library used for working with colors. These extension methods impliment project specific functionality on top of the Unicolour Library.
    /// </summary>
    public static class UnicolorExtensions
    {
        public static Unicolour GetInverse(this Unicolour color)
        {
            var hex = color.Hex;
            hex = hex.Replace("#", "");
            if (hex.Length == 3) hex += hex;
            if (hex.Length < 6)
            {
                Log.Warning("hex respresentation of color, {color}, is not enough digits", color.Hex);
                return color;
            }
            string r = hex[0..2];
            string g = hex[2..4];
            string b = hex[4..];
            int red = Convert.ToInt32(r, 16);
            int green = Convert.ToInt32(g, 16);
            int blue = Convert.ToInt32(b, 16);
            if (red == 0) red = 1;
            if (green == 0) green = 1;
            if (blue == 0) blue = 1;
            green = 255 - green;
            red = 255 - red;
            blue = 255 - blue;
            color = new Unicolour(ColourSpace.Rgb255, (red, green, blue));
            return color;
        }

        public static Unicolour GetCompliment(this Unicolour color)
        {
            var h = (color.Hsl.H + 180) % 360;
            var l = color.Hsl.L;
            var s = color.Hsl.S;
            if ((color.Hsl.S < 0.2))
            {
                s = 0;
                if (l < 0.5)
                {
                    l = 1;
                }
                else
                {
                    l = 0;
                }
            }

            Unicolour inverseColor = new(ColourSpace.Hsl, (h, s, l));

            // deal with grey ranged colors
            if (color.Contrast(inverseColor) < 2.5)
            {
                inverseColor = new("#ffffff");
                if (color.Contrast(inverseColor) < 2.5)
                {
                    inverseColor = new("#000000");
                }
            }

            return inverseColor;
        }
    }
}
