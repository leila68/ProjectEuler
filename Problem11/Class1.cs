using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem11
{
    class Class1
    {



        public void read(string num)
        {
            string digits = num;
            int vertical = 1;
            int horizantal = 1; 
            int diagonal = 1;
            int diagonalN = 1;
            int max1 = 1, max2 = 1, max3 = 1, max4 = 1;

            int[][] array = digits.Replace("\r", "").Split('\n').Select(n => n.Split(' ').Select(m => Int32.Parse(m)).ToArray()).ToArray(); //turning input into 2d int array

            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 17; j++)

                {
                    horizantal = array[i][j] * array[i][j + 1] * array[i][j + 2] * array[i][j + 3];

                    if (horizantal > max1)
                    {
                        max1 = horizantal;
                    }
                }

            for (int i = 0; i < 17; i++)
                for (int j = 0; j < 20; j++)

                {
                    vertical = array[i][j] * array[i + 1][j] * array[i + 2][j] * array[i + 3][j];
                    if (vertical > max2)
                    {
                        max2 = vertical;
                    }
                }


            for (int i = 0; i < 17; i++)
                for (int j = 0; j < 17; j++)

                {
                    diagonal = array[i][j] * array[i + 1][j + 1] * array[i + 2][j + 2] * array[i + 3][j + 3];
                 
                    if (diagonal > max3)
                        {
                            max3 = diagonal;
                        }
                 // Console.WriteLine("{0}{1}{2}{3}", array[i][j] , array[i + 1][j + 1] , array[i + 2][j + 2] , array[i + 3][j + 3]);
                }
            for (int i = 0; i <17 ; i++)
                for (int j = 19; j >2; j--)

                {
                    diagonalN = array[i][j] * array[i + 1][j - 1] * array[i + 2][j - 2] * array[i + 3][j - 3];
                    if (diagonalN > max4)
                    {
                        max4 = diagonalN;
                    }
                    // Console.WriteLine("{0}{1}{2}{3}", array[i][j] , array[i + 1][j + 1] , array[i + 2][j + 2] , array[i + 3][j + 3]);
                }

            Console.WriteLine("{0},{1},{2},{3}",max1,max2,max3,max4);
        }
    }
}
