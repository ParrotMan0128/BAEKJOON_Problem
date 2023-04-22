using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage04
{
    internal class Stage4_08
    {

        static void Main(string[] args)
        {

            int[] inputs = new int[10];
            int result = 0;

            for (int i = 0; i < 10; i++)
            {

                inputs[i] = int.Parse(Console.ReadLine());
                inputs[i] = inputs[i] % 42;

            }

            for (int i = 0; i < 10; i++)
            {

                int count = 0;

                for (int j = i + 1; j < 10; j++)
                {

                    if (inputs[i] == inputs[j]) { count++; }

                }

                if (count == 0)
                {

                    result++;

                }
            }

            Console.WriteLine(result);

        }
    }
}
