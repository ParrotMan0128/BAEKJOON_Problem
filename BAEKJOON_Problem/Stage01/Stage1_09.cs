using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage01
{
    internal class Stage1_09
    {

        static void Main(String[] args)
        {

            string[] inputs = Console.ReadLine().Split(' ');
            int a, b, c;

            a = int.Parse(inputs[0]);
            b = int.Parse(inputs[1]);
            c = int.Parse(inputs[2]);

            Console.WriteLine((a + b) % c);
            Console.WriteLine(((a % c) + (b % c)) % c);
            Console.WriteLine((a * b) % c);
            Console.WriteLine((a % c) * (b % c) % c);

        }

    }
}
