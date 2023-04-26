using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage09
{
    internal class Stage9_02
    {

        static void Main(string[] args)
        {

            string[] inputs = Console.ReadLine().Split(' ');

            int n = int.Parse(inputs[0]);
            int k = int.Parse(inputs[1]);

            int count = 0;
            int factor = 0;

            for (int i = 1; i <= n; i++)
            {

                if (n % i == 0)
                {

                    count++;

                    if (count == k)
                    {

                        factor = i;
                        break;

                    }

                }

            }

            Console.WriteLine(factor);
            
        }

    }
}
