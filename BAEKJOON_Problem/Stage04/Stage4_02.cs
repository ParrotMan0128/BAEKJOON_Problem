using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage04
{
    internal class Stage4_02
    {

        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();

            string[] inputs;

            int n, x;

            inputs = Console.ReadLine().Split(' ');

            n = int.Parse(inputs[0]);
            x = int.Parse(inputs[1]);

            inputs = Console.ReadLine().Split(' ');

            foreach (string i in inputs)
            {

                if (x > int.Parse(i))
                {

                    sb.Append(i + " ");

                }

            }

            Console.WriteLine(sb.ToString());

        }

    }
}
