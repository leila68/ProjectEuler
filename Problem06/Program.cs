using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problem6
{
    class Program
    {
        public static int SumSquareDifference()

        {
            int sum = 0;
            int sum2 = 0;
            int result = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum = sum + i;
            
            }

            sum = sum * sum;
            for (int j = 1; j <= 100; j++)
            {
                sum2 = (j * j) + sum2;
            }

            result = sum - sum2;
            return result;
        
        }
        static void Main(string[] args)
        {
            int result = SumSquareDifference();
            Console.WriteLine(result);

            sum obj1 = new sum();
            obj1.sumsquare();
            obj1.print();

            Console.ReadKey();

        }
    }
}
