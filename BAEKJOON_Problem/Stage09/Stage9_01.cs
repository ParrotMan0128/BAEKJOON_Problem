using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage09
{
    internal class Stage9_01
    {

        static void Main(string[] args)
        {

            int x, y;

            while (true)
            {

                string[] inputs = Console.ReadLine().Split(' ');

                x = int.Parse(inputs[0]);
                y = int.Parse(inputs[1]);

                if (x == 0 && y == 0)
                {

                    break;

                }

                if (y % x == 0)
                {

                    Console.WriteLine("factor");

                }
                else if (x % y == 0)
                {

                    Console.WriteLine("multiple");

                }
                else
                {

                    Console.WriteLine("neither");

                }


            }

        }

    }
}
