using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Class1
    {

        // 1.  1 + 2 + 3 + ... +1000
        public int ArithmeticProgression()
        {
            int sum = 0;
            for (int i = 1; i <= 1000; i++)
                sum += i;
            return sum;
        }

        //2. 1×2-2×3+3×4-4×5⋯+99×100
        public int ArithmeticProgressionVar()
        {
            int sum = 0;
            int factor = 1;
            for (int i = 1; i < 100; i++)
            {
                sum += i * factor * (i + 1);
                factor *= -1;
            }
            return sum;
        }

        // 3.
        public float FractionSum()
        {
            float numerator = 50;
            float sum = 0;
            for (float i = 2; i <= 20; i++)
            {
                sum += numerator / i;
                numerator -= 3;
            }
            return sum;
        }

    }
}
