using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class MoveFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            if (sourceImage.Width - 51 >= x) return sourceImage.GetPixel(x + 50, y);
            return Color.FromArgb(0,0,0);
        }
    }
}
