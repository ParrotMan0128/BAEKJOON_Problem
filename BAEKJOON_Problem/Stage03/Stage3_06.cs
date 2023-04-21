using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage03
{
    internal class Stage3_06
    {

        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();

            int testCase = int.Parse(Console.ReadLine());

            string[] inputs;
            int a, b;

            for (int i = 0; i < testCase; i++)
            {

                inputs = Console.ReadLine().Split(' ');
                a = int.Parse(inputs[0]);
                b = int.Parse(inputs[1]);

                sb.AppendLine((a + b).ToString());

            }

            Console.WriteLine(sb.ToString());

        }

    }
}
