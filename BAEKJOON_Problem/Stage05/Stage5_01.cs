using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage05
{
    internal class Stage5_01
    {

        static void Main(string[] args)
        {

            char[] input = Console.ReadLine().ToArray();
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine(input[index - 1]);

        }

    }
}
