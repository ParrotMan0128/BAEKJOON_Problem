using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage13 {
    internal class Stage13_04 {

        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++) {

                numbers[i] = int.Parse(Console.ReadLine());

            }

            Array.Sort(numbers);

            for (int i = 0; i < n; i++) {

                sb.AppendLine(numbers[i].ToString());

            }

            Console.Write(sb.ToString());

        }

    }
}
