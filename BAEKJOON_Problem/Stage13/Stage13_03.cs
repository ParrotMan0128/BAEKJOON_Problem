using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage13 {
    internal class Stage13_03 {

        static void Main(string[] args) {

            string[] inputs = Console.ReadLine().Split(' ');
            int n = int.Parse(inputs[0]);
            int k = int.Parse(inputs[1]);

            inputs = Console.ReadLine().Split(' ');

            int[] scores = new int[n];

            for (int i = 0; i < n; i++) {

                scores[i] = int.Parse(inputs[i]);

            }

            Array.Sort(scores);

            Console.WriteLine(scores[n - k]);

        }

    }
}
