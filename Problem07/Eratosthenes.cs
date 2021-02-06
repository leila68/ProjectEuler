using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problem07
{
    class Eratosthenes
    {

        public bool isPrime(int num)
        {
            int n = num;
            double s = Math.Sqrt(n);
             if (n <= 1)
                 {
                   return false;
                 }
            if (n == 2)
               {
                  return true;
               }

            if (n % 2 == 0)
                {
                    return false;
                }
            if (n  == 3)
            {
                return true;
            }

            for (int i = 3; i <= s; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
