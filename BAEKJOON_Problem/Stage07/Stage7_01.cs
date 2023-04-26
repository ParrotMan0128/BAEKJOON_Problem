using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage07
{
    internal class Stage7_01
    {

        static void Main(string[] args)
        {

            var inputs = Console.ReadLine().Split(' ');

            var n = int.Parse(inputs[0]);
            var m = int.Parse(inputs[1]);

            var procession = new int[n, m];

            for (int i = 0; i < n; i++)
            {

                inputs = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++)
                {

                    procession[i, j] = int.Parse(inputs[j]);

                }

            }

            for (int i = 0; i < n; i++)
            {

                inputs = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++)
                {

                    procession[i, j] += int.Parse(inputs[j]);

                }

            }

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {

                    Console.Write("{0} ", procession[i, j]);

                }

                Console.Write("\n");

            }


        }

    }
}
