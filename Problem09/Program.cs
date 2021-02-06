using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problem9
{
    class Program
    {
        public static int Pythagorean(ref int a,ref int b)
        {
            int w = 0;
            
            for (int i = 1; i < 1000; i++)
            {
                for (int j = 1; j < 1000; j++)
                {
                    for (int k = 0; k < 1000; k++)
                    { 
                      if(i+j+k==1000)  
                        {
                            if (i < j && j < k)
                            {
                                if ((i * i) + (j * j) == (k * k))
                                {
                                    w = i;
                                    a = j;
                                    b = k;
                                }
                            }
                        }
                    }
                }
            }
        
         return w;
        }
        static void Main(string[] args)
        {
            int x=0,y=0;
            int num1 = Pythagorean(ref  x, ref  y);
            Console.WriteLine(num1);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("abc={0}",num1*x*y);

            Console.WriteLine("*******************************************");
            triplet obj1 = new triplet();
            obj1.abc();

            Console.ReadKey();
        }
    }
}
