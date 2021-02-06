using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace problem12
{
    class triangleNumber
    {
        public void triangle()
        {
         
           // int[] num = new int[50];
            int j = 2;
           
            int count = 1;
            int sum = 1;

            while(count<500)
            {
                sum = sum + j;
                j++;
                if (sum >1000)
                {
                    count = divisor(sum);
                }
               
            }
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }


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
            if (n == 3)
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

        public int divisor1(int num)// inefficient
        {
            int n = num;
            int i = 1;
            int count = 1;
            do
            {
                if (n % i == 0)
                {                    
                        count++;                   
                }
                i++;
            } while (i<n);
            return count;
        }

        public int divisor(int num)
        {
            int n = num;
            int sqr = (int)Math.Sqrt(n);
            int count = 0;

            for (int i=1; i<=sqr; i++)
            {
                if (n % i == 0)
                {
                    if (sqr * sqr == i)
                        count++;
                   else count += 2;
                }
               

            }
            return count;
        }

        public int primeDivisor(long num)
        {
            long n = num;
            int count = 2;
            int p = 1;
            int max = 1;

            do
            {
                p++;
                if (isPrime(p) == true)
                {
                    while (num % p == 0 )
                    {
                        num = num / p;
                        count++;
                        if (p > max)
                            max = p;
                    }
                }
             
            } while (num>1);

            //return count;
            return p;
        }
    }
}
