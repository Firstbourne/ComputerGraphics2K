using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class BorderHighlighting_X : MatrixFilter
    {
        public BorderHighlighting_X()
        {
            kernel = new float[3, 3]
            {
                { 3, 0, -3 },
                { 10, 0, -10 },
                { 3, 0, -3 }
            };
        }
    }
}
