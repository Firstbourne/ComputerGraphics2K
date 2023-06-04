using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class GrayWorld : Filters
    {
        private float Rsum = 0, Gsum = 0, Bsum = 0, avg = 0;
        public GrayWorld(Bitmap sourceImage)
        {
           
            int n = sourceImage.Width * sourceImage.Height;
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color color = sourceImage.GetPixel(i, j);
                    Rsum += color.R;
                    Gsum += color.G;
                    Bsum += color.B;
                }
            }
            Rsum /= n;
            Gsum /= n;
            Bsum /= n;
            avg = (Rsum + Gsum + Bsum) / 3;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            return Color.FromArgb(Clamp((int)(sourceColor.R * (avg / Rsum)), 0, 255), Clamp((int)(sourceColor.G * (avg / Gsum)), 0, 255), Clamp((int)(sourceColor.B * (avg / Bsum)), 0, 255));
            //return Color.FromArgb(sourceColor.R * (avg / Rsum), sourceColor.G * (avg / Gsum),sourceColor.B * (avg / Bsum));
        }
    }
}
