using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage10 {
    internal class Stage10_08 {

        static void Main(string[] args) {

            string[] inputs = Console.ReadLine().Split(' ');

            int sideA = int.Parse(inputs[0]);
            int sideB = int.Parse(inputs[1]);
            int sideC = int.Parse(inputs[2]);

            int perimeter;

            if (sideA >= sideB + sideC) {

                sideA = sideB + sideC - 1;

            } else if (sideB >= sideC + sideA) {

                sideB = sideC + sideA - 1;

            } else if (sideC >= sideA + sideB) {

                sideC = sideA + sideB - 1;

            }

            perimeter = sideA + sideB + sideC;

            Console.WriteLine(perimeter);

        }

    }
}
