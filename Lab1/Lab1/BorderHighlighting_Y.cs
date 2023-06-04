using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class BorderHighlighting_Y : MatrixFilter
    {
        public BorderHighlighting_Y()
        {
            kernel = new float[3, 3]
            {
                { 3, 10, 3 },
                { 0, 0, 0 },
                { -3, -10, -3 }
            };
        }
    }
}
