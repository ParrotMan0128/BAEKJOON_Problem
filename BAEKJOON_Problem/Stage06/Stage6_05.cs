using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage06
{
    internal class Stage6_05
    {


        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            char[] charInput = input.ToArray();
            Array.Reverse(charInput);

            string Reversed = new string(charInput);

            if (input == Reversed)
            {

                Console.WriteLine(1);

            }
            else
            {

                Console.WriteLine(0);

            }

        }

    }
}
