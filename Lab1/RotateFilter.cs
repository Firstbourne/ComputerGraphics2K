using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class RotateFilter : Filters
    {
        private int Xcenter, Ycenter;
        private float angle = 30;
        GraphicsUnit unit = new GraphicsUnit();
        public RotateFilter(Bitmap image)
        {
            Xcenter = image.Width / 2;
            Ycenter = image.Height / 2;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
           if ((x-Xcenter - 1)*Math.Cos(angle) > sourceImage.GetBounds(ref unit).Left || (x - Xcenter - 1) * Math.Cos(angle) < sourceImage.Width || y - Ycenter > sourceImage.GetBounds(ref unit).Top || y - Ycenter < sourceImage.Height) return sourceImage.GetPixel((int)((x - Xcenter) * Math.Cos(angle)) - (int)((y - Ycenter) * Math.Sin(angle) + Xcenter), (int)((x - Xcenter) * Math.Sin(angle)) + (int)((y - Ycenter) * Math.Cos(angle) + Ycenter));
            return Color.Empty;
        }
    }
}
