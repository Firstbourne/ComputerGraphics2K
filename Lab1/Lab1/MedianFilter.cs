using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class MedianFilter : MatrixFilter
    {
        public MedianFilter(int size)
        {
            float[,] kernel = new float[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    kernel[i, j] = 1;
                }
            }
            this.kernel = kernel;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            List<int> rValues = new List<int>();
            List<int> gValues = new List<int>();
            List<int> bValues = new List<int>();

            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;

            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(y + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    rValues.Add(neighborColor.R);
                    gValues.Add(neighborColor.G);
                    bValues.Add(neighborColor.B);
                }
            }

            int medianR = GetMedian(rValues);
            int medianG = GetMedian(gValues);
            int medianB = GetMedian(bValues);

            return Color.FromArgb(medianR, medianG, medianB);
        }

        private int GetMedian(List<int> values)
        {
            values.Sort();
            int count = values.Count;
            int median = count % 2 == 0 ? (values[count / 2 - 1] + values[count / 2]) / 2 : values[count / 2];
            return median;
        }
    }
}
