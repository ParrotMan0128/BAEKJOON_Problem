using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage10 {
    internal class Stage10_07 {

        static void Main(string[] args) {

            while (true) {

                string[] inputs = Console.ReadLine().Split(' ');

                int sideA = int.Parse(inputs[0]);
                int sideB = int.Parse(inputs[1]);
                int sideC = int.Parse(inputs[2]);

                if (sideA == 0 && sideB == 0 && sideC == 0) {

                    break;

                }

                if (sideA >= sideB + sideC || sideB >= sideA + sideC || sideC >= sideB + sideA) {

                    Console.WriteLine("Invalid");

                } else if (sideA == sideB && sideB == sideC) {

                    Console.WriteLine("Equilateral");

                } else if (sideA == sideB || sideB == sideC || sideC == sideA) {

                    Console.WriteLine("Isosceles");

                } else if (sideA != sideB && sideB != sideC) {

                    Console.WriteLine("Scalene");

                }

            }

        }

    }
}
