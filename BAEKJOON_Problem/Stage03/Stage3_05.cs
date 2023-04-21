using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage03
{
    internal class Stage3_05
    {

        static void Main(string[] args)
        {

            int bytes = int.Parse(Console.ReadLine());
            int longCount = bytes / 4;

            for (int i = 0; i < longCount; i++)
            {

                Console.Write("long ");

            }

            Console.WriteLine("int");

        }

    }
}
