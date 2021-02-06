using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problem9
{
    class triplet
    {
        int a,b,c;
        int result = 3;
        public void abc()
        {
            for (int i = 1; i < 1000; i++)
                for (int j = i+1; j < 1000; j++)
                    for (int k = i+2; k < 1000; k++)
                    {
                        if ((i*i) + (j*j)  == k*k)
                        {
                            if (i+j+k==1000)
                            {
                                Console.WriteLine("{0} {1} {2}", i, j, k);
                                Console.WriteLine(i * j * k);
                            }
                            break;
                        }
                            
                        
                    }
        }
    }
}
