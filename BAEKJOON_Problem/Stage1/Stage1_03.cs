using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage1
{
    internal class Stage1_03
    {
        static void Main(string[] args)
        {

            string[] inputs;
            int sum;

            inputs = Console.ReadLine().Split(' ');
            sum = int.Parse(inputs[0]) - int.Parse(inputs[1]);

            Console.WriteLine("{0}", sum);

        }

    }
}
