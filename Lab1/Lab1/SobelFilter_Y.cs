using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class SobelFilter_Y : MatrixFilter
    {
        public SobelFilter_Y()
        {
            kernel = new float[3, 3]
            {
                {-1, -2, -1 },
                { 0,  0,  0 },
                { 1,  2,  1 }
            };
        }
    }
}
