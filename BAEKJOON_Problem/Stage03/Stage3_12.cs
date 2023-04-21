using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage03
{
    internal class Stage3_12
    {

        static void Main(string[] args)
        {

            string input;
            string[] inputSplit;

            int a, b;

            while (true)
            {

                input = Console.ReadLine();

                if (input == null) { break; }

                inputSplit = input.Split(' ');

                a = int.Parse(inputSplit[0]);
                b = int.Parse(inputSplit[1]);

                Console.WriteLine(a + b);


            }


        }

    }
}
