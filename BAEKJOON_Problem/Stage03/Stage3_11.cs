using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage03
{
    internal class Stage3_11
    {

        static void Main(string[] args)
        {

            string[] inputs;
            int a, b;

            while (true)
            {

                inputs = Console.ReadLine().Split(' ');

                a = int.Parse(inputs[0]);
                b = int.Parse(inputs[1]);

                if (a == 0 && b == 0)
                {

                    break;

                }

                Console.WriteLine("{0}", a + b);

            }

        }

    }
}
