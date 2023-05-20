using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage11 {
    internal class Stage11_07 {

        static void Main(string[] args) {

            string[] inputs = Console.ReadLine().Split(' ');

            int a1 = int.Parse(inputs[0]);
            int a0 = int.Parse(inputs[1]);

            int c = int.Parse(Console.ReadLine());

            int n0 = int.Parse(Console.ReadLine());

            if (a1 * n0 + a0 <= c * n0 && a1 <= c) {

                Console.WriteLine(1);

            } else {

                Console.WriteLine(0);

            }

        }

    }
}
