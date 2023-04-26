using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage07
{
    internal class Stage7_02
    {

        static void Main(string[] args)
        {

            var Numbers = new int[9, 9];
            var index = new int[] { 0, 0 };
            var Max = int.MinValue;

            for (int i = 0; i < 9; i++)
            {

                var inputs = Console.ReadLine().Split(' ');

                for (int j = 0; j < 9; j++)
                {

                    Numbers[i, j] = int.Parse(inputs[j]);

                    if (Numbers[i, j] > Max)
                    {

                        Max = Numbers[i, j];
                        index[0] = i + 1;
                        index[1] = j + 1;

                    }

                }

            }

            Console.WriteLine("{0}", Max);
            Console.WriteLine("{0} {1}", index[0], index[1]);

        }

    }
}
