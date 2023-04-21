using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage03
{
    internal class Stage3_01
    {

        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {

                Console.WriteLine("{0} * {1} = {2}", a, i, a * i);

            }

        }

    }
}
