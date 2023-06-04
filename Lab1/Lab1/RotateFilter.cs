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
        private float angle = 60;
        GraphicsUnit unit = new GraphicsUnit();
        public RotateFilter(Bitmap image)
        {
            Xcenter = image.Width / 2;
            Ycenter = image.Height / 2;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int distX = x - Xcenter;
            int distY = y - Ycenter;
            double cosAngle = Math.Cos(angle);
            double sinAngle = Math.Sin(angle);

            if ((distX * cosAngle) - (distY * sinAngle) + Xcenter > sourceImage.GetBounds(ref unit).Left &&
                (distX * cosAngle) - (distY * sinAngle) + Xcenter < sourceImage.Width &&
                (distX * sinAngle) + (distY * cosAngle) + Ycenter > sourceImage.GetBounds(ref unit).Top &&
                (distX * sinAngle) + (distY * cosAngle) + Ycenter < sourceImage.Height)
                return sourceImage.GetPixel(
                    (int)(distX * cosAngle) - (int)(distY * sinAngle) + Xcenter,
                    (int)(distX * sinAngle) + (int)(distY * cosAngle) + Ycenter
                    );
            return Color.Empty;
        }
    }
}