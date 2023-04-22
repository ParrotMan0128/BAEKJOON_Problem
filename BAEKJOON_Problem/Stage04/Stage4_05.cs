using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage04
{
    internal class Stage4_05
    {

        static void Main(string[] args)
        {

            string[] inputs = Console.ReadLine().Split(' ');

            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);

            int[] Bucket = Enumerable.Repeat(0, n).ToArray();

            int i, j, k;

            for (int p = 0; p < m; p++)
            {

                inputs = Console.ReadLine().Split(' ');

                i = int.Parse(inputs[0]);
                j = int.Parse(inputs[1]);
                k = int.Parse(inputs[2]);

                for (int q = i - 1; q < j; q++)
                {

                    Bucket[q] = k;

                }

            }

            foreach (int p in Bucket)
            {

                Console.Write("{0} ", p);

            }

        }

    }
}
