using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage03
{
    internal class Stage3_02
    {

        static void Main(string[] args)
        {

            int testCase = int.Parse(Console.ReadLine());

            string[] inputs;
            int a, b;

            for (int i = 0; i < testCase; i++)
            {

                inputs = Console.ReadLine().Split(' ');
                a = int.Parse(inputs[0]);
                b = int.Parse(inputs[1]);

                Console.WriteLine(a + b);

            }

        }

    }
}
