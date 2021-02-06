using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problem6
{
    class sum
    {
        int sub;
        public int sumsquare()
        {
            int sum1=0;
            int sum2=0;
            
            for (int i=0; i<=100; i++)
            {
                sum1 = i * i + sum1;
                sum2 = i + sum2;
            }

            sub = (sum2 * sum2) - sum1;
            return sub;
        }
        public void print()
        {
            Console.WriteLine("the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum is:{0}",sub);
        }
    }
}
