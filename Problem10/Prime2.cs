using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problem07
{
    class Prime2:Prime
    {
        public double sum = 0;
        public int num = 0;
        public int prim = 2;
        Prime ob = new Prime();

        public double total()
        {
            while(prim<2000000)
            {
                num++;
                if (ob.isPrime(num))
              {
                    prim = num;
                    if (prim<2000000)
                    sum += num;
                        
                }
            } 
            
            return sum;  
        }
        
    }
}
