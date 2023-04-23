using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage06
{
    internal class Stage6_03
    {

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                for (int j = 1; j < n - i; j++)
                {

                    Console.Write(" ");

                }

                for (int j = 0; j < i * 2 + 1; j++)
                {

                    Console.Write("*");

                }

                Console.Write("\n");

            }

            for (int i = n - 1; i > 0; i--)
            {

                for (int j = 0; j < n - i; j++)
                {

                    Console.Write(" ");

                }

                for (int j = 0; j < i * 2 - 1; j++)
                {

                    Console.Write("*");

                }

                Console.Write("\n");

            }

        }

    }
}
