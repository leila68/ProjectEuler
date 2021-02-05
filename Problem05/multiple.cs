using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smallest_multiple
{
    class multiple
    {
        int m=10;
        int count;
        public int finding()
        {
            do
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (m % i == 0)
                    {
                        count++;
                    }
                    else
                        break;
                }

                if (count != 20)
                {
                    count = 0;
                    m++;
                }

            } while (count < 20);


         return m;
        }
        public void print()
        {
            Console.WriteLine("the smallest number that can be divided by each of the numbers from 1 to 20 without any remainder is:{0}",m);
        }
    }
}
