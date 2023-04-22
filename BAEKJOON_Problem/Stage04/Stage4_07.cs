using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage04
{
    internal class Stage4_07
    {

        static void Main(string[] args)
        {

            bool[] students = Enumerable.Repeat(false, 30).ToArray();
            int input;

            for (int i = 0; i < 28; i++)
            {

                input = int.Parse(Console.ReadLine());
                students[input - 1] = true;

            }

            for (int i = 0; i < 30; i++)
            {

                if (students[i] == false)
                {

                    Console.WriteLine(i + 1);

                }

            }

        }

    }
}
