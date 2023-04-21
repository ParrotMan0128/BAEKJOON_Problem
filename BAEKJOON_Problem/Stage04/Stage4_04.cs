using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage04
{
    internal class Stage4_04
    {

        static void Main(string[] args)
        {

            int index = 0;
            int input;
            int largest = 0;

            for (int i = 1; i <= 9; i++)
            {

                input = int.Parse(Console.ReadLine());

                if (input > largest)
                {

                    index = i;
                    largest = input;

                }

            }

            Console.WriteLine(largest);
            Console.WriteLine(index);

        }

    }
}
