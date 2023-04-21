using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage1
{
    internal class Stage1_06
    {
        static void Main(string[] args)
        {

            string[] inputs;
            int a, b;

            inputs = Console.ReadLine().Split(' ');
            a = int.Parse(inputs[0]);
            b = int.Parse(inputs[1]);

            Console.WriteLine("{0}", a + b);
            Console.WriteLine("{0}", a - b);
            Console.WriteLine("{0}", a * b);
            Console.WriteLine("{0}", a / b);
            Console.WriteLine("{0}", a % b);

        }

    }
}
