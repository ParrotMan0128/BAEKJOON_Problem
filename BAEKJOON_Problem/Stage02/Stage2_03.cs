using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage02
{
    internal class Stage2_03
    {

        static void Main(string[] args)
        {

            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0)
            {

                Console.WriteLine(1);

            }
            else if (year % 400 == 0)
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
