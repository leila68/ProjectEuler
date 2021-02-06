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
            Eratosthenes obj2 = new Eratosthenes();
      

            int numPrim=0;
            int num=0;

            do
            {
                num++;
                if (obj2.isPrime(num))
                {
                    numPrim++;
                }
                
            } while (numPrim < 10001);

            

             Console.WriteLine("10001st prime is:{0}", num);
            Console.ReadKey();
        }
    }
}
