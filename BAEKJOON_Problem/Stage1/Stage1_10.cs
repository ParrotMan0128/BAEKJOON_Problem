using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage1
{
    internal class Stage1_10
    {

        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int digit_h = b / 100;
            int digit_t = (b % 100) / 10;
            int digit_o = b % 100 % 10;

            Console.WriteLine(a * digit_o);
            Console.WriteLine(a * digit_t);
            Console.WriteLine(a * digit_h);
            Console.WriteLine(a * b);

        }
    }
}
