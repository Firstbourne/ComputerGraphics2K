using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class SobelFilter_X : MatrixFilter
    {
        public SobelFilter_X()
        {
            kernel = new float[3, 3] 
            {
                {-1, 0, 1 },
                {-2, 0, 2 },
                {-1, 0, 1 }
            };
        }
    }
}
