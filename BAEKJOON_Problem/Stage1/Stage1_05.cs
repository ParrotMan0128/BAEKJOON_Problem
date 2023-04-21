using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage1
{
    internal class Stage1_05
    {
        static void Main(string[] args)
        {

            string[] inputs;
            double sum;

            inputs = Console.ReadLine().Split(' ');
            sum = double.Parse(inputs[0]) / double.Parse(inputs[1]);

            Console.WriteLine("{0}", sum);

        }

    }
}
