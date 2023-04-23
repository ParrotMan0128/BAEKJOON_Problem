using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage06
{
    internal class Stage6_02
    {

        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();

            int[] correct = { 1, 1, 2, 2, 2, 8 };
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            for (int i = 0; i < 6; i++)
            {

                sb.Append(correct[i] - inputs[i] + " ");

            }

            Console.WriteLine(sb.ToString());

        }
    }
}
