using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage11 {
    internal class Stage11_04 {

        static void Main(string[] args) {

            long n = long.Parse(Console.ReadLine());

            long time = n * (n - 1) / 2;

            Console.WriteLine("{0}\n{1}", time, 2);

        }

    }
}
