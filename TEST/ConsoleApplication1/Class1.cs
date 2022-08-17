using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class1
    {
        public static float test2(float a, float b)
        {
            if (a < 0)
            {
                a = a * (-1);
            }
            if (b < 0)
            {
                b = b * (-1);
            }
            return (a * b) / 2;
        }

    }
}
