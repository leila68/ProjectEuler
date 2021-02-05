using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace palindrom
{
    class Palindrom
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new String(charArray);
        }
        public void palin()
        {
            int mal;
            int max = 10000;
            string str1;
            string str2;

            for (int i = 999; i >= 100; i--)
                for (int j = i; j >= 100; j--)
                {
                    mal = i * j;
                    str1 = mal.ToString();
                    str2 = Reverse(str1);
                    if (str1 == str2)
                    {
                        if (mal > max)
                        {
                            max = mal;

                        }

                    }

                }
            Console.WriteLine(max);
        }
    }
}
