using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage13 {
    internal class Stage13_01 {

        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++) {

                numbers[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < n; i++) {

                for (int j = 0; j < n - 1; j++) {

                    if (numbers[j] > numbers[j + 1]) {

                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;

                    }

                }

            }

            for (int i = 0; i < n; i++) {

                Console.WriteLine(numbers[i]);

            }
        }
    }
}
