using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problem07
{
    class Program
    {

        static void Main(string[] args)
        {

            Prime obj1 = new Prime();
            Prime2 obj2 = new Prime2();
            double s = obj2.total();
            
            int numPrim=0;
            int num=0;

            do
            {
                num++;
                if (obj1.isPrime(num))
                {
                    numPrim++;
                }
                
            } while (numPrim < 10001);

            Console.WriteLine("10001st prime is:{0}", num);
            Console.WriteLine(s);

           

            Console.ReadKey();
        }
    }
}
