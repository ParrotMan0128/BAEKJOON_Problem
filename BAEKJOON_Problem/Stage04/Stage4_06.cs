using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage04
{
    internal class Stage4_06
    {

        static void Main(string[] args)
        {

            string[] inputs = Console.ReadLine().Split(' ');

            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);

            int[] Bucket = new int[n];

            int i, j, temp;

            for (int p = 1; p <= n; p++)
            {

                Bucket[p - 1] = p;

            }

            for (int p = 0; p < m; p++)
            {

                inputs = Console.ReadLine().Split(' ');

                i = int.Parse(inputs[0]);
                j = int.Parse(inputs[1]);

                temp = Bucket[i - 1];
                Bucket[i - 1] = Bucket[j - 1];
                Bucket[j - 1] = temp;

            }

            foreach (int p in Bucket)
            {

                Console.Write("{0} ", p);

            }

        }

    }
}
