using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage02
{
    internal class Stage2_01
    {
        static void Main(string[] args)
        {

            string[] inputs = Console.ReadLine().Split(' ');

            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);

            if (a > b)
            {

                Console.WriteLine(">");

            }
            else if (a < b)
            {

                Console.WriteLine("<");

            }
            else
            {

                Console.WriteLine("==");

            }

        }

    }
}
