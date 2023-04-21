using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage03
{
    internal class Stage3_09
    {

        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {

                for (int j = 0; j <= i; j++)
                {

                    Console.Write("*");

                }

                Console.Write("\n");

            }

        }

    }
}
