using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage04
{
    internal class Stage4_09
    {

        static void Main(string[] args)
        {

            string[] inputs = Console.ReadLine().Split(' ');

            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);

            int[] Bucket = new int[n];

            for (int p = 0; p < n; p++)
            {

                Bucket[p] = p + 1;

            }

            for (int p = 0; p < m; p++)
            {

                inputs = Console.ReadLine().Split(' ');

                int i = int.Parse(inputs[0]);
                int j = int.Parse(inputs[1]);
                int size = j - i + 1;

                int[] temp = new int[size];

                for (int q = 0; q < size; q++)
                {

                    temp[q] = Bucket[i + q - 1];

                }

                Array.Reverse(temp);

                for (int q = 0; q < size; q++)
                {

                    Bucket[i + q - 1] = temp[q];

                }

            }

            foreach (int i in Bucket)
            {

                Console.Write("{0} ", i);

            }

        }

    }
}
