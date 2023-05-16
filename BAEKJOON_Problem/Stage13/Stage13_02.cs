using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage13 {
    internal class Stage13_02 {

        static void Main(string[] args) {

            int[] numbers = new int[5];
            int sum = 0;

            for (int i = 0; i < 5; i++) {

                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];

            }

            Array.Sort(numbers);

            Console.WriteLine(sum / 5);
            Console.WriteLine(numbers[2]);

        }
    }
}
