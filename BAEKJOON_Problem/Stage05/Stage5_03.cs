using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage05
{
    internal class Stage5_03
    {

        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {

                char[] input = Console.ReadLine().ToArray();

                Console.WriteLine(input[0].ToString() + input[input.Length - 1].ToString());

            }

        }

    }
}
