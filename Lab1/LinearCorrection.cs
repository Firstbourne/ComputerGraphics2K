using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class LinearCorrection : Filters
    {
        private byte Rmin = 255 , Rmax = 0, Gmin = 255, Gmax = 0, Bmin = 255 , Bmax = 0;
        public LinearCorrection(Bitmap sourceImage)
        {
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    if (sourceImage.GetPixel(i,j).R > Rmax) Rmax = sourceImage.GetPixel(i,j).R;
                    if (sourceImage.GetPixel(i,j).G > Gmax) Gmax = sourceImage.GetPixel(i,j).G;
                    if (sourceImage.GetPixel(i,j).B > Bmax) Bmax = sourceImage.GetPixel(i,j).B;
                    if (sourceImage.GetPixel(i,j).R < Rmin) Rmin = sourceImage.GetPixel(i,j).R;
                    if (sourceImage.GetPixel(i,j).G < Gmin) Gmin = sourceImage.GetPixel(i,j).G;
                    if (sourceImage.GetPixel(i,j).B < Bmin) Bmin = sourceImage.GetPixel(i,j).B;
                }
            }
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            return Color.FromArgb(Clamp((int)((sourceColor.R - Rmin) * ((float)(255 - 0) / (float)(Rmax - Rmin))), 0, 255), Clamp((int)((sourceColor.G - Gmin) * ((float)(255 - 0) / (float)(Gmax - Gmin))), 0, 255), Clamp((int)((sourceColor.B - Bmin) * ((float)(255 - 0) / (float)(Bmax - Bmin))), 0, 255));
        }
    }
}
