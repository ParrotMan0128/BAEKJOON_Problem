using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage04
{
    internal class Stage4_03
    {

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split(' ');

            int smallest = int.Parse(inputs[0]);
            int largest = int.Parse(inputs[0]);

            for (int i = 1; i < n; i++)
            {

                smallest = Math.Min(smallest, int.Parse(inputs[i]));
                largest = Math.Max(largest, int.Parse(inputs[i]));

            }

            Console.WriteLine("{0} {1}", smallest, largest);

        }

    }
}
