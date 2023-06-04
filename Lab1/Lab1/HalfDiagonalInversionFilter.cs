using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class HalfDiagonalInversionFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
          if (x >= (y * sourceImage.Width/sourceImage.Height))
            {
                return Color.FromArgb(
                    255 - sourceImage.GetPixel(x, y).R, 
                    255 - sourceImage.GetPixel(x, y).G, 
                    255 - sourceImage.GetPixel(x, y).B);
            }
            return sourceImage.GetPixel(x, y);
        }
    }
}
