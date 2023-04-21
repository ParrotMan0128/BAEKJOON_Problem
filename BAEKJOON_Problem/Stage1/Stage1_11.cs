using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage1
{
    internal class Stage1_11
    {

        static void Main(string[] args)
        {

            string[] inputString = Console.ReadLine().Split(' ');
            long[] input = new long[inputString.Length];

            for (int i = 0; i < inputString.Length; i++)
            {

                input[i] = long.Parse(inputString[i]);

            }

            long sum = input[0] + input[1] + input[2];

            Console.WriteLine(sum);

        }

    }
}
