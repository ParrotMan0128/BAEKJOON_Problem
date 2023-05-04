using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage10
{
    internal class Stage10_02
    {

        static void Main(string[] args)
        {

            string[] inputs = Console.ReadLine().Split(' ');

            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            int w = int.Parse(inputs[2]);
            int h = int.Parse(inputs[3]);

            int xDistance = x <= (w - x) ? x : (w - x);
            int yDistance = y <= (h - y) ? y : (h - y);
            int distance = xDistance <= yDistance ? xDistance : yDistance;

            Console.WriteLine(distance);


        }

    }
}
