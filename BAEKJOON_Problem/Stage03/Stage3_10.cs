using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage03
{
    internal class Stage3_10
    {

        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());

            for (int i = a; i > 0; i--)
            {

                for (int j = 1; j <= a; j++)
                {

                    if (j < i) { Console.Write(" "); }
                    else { Console.Write("*"); }

                }

                Console.Write("\n");


            }

        }

    }
}
