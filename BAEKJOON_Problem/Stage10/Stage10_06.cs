using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage10 {
    internal class Stage10_06 {

        static void Main(string[] args) {

            int angleA = int.Parse(Console.ReadLine());
            int angleB = int.Parse(Console.ReadLine());
            int angleC = int.Parse(Console.ReadLine());

            int angleSum = angleA + angleB + angleC;

            if (angleA == 60 && angleB == 60 && angleC == 60) {

                Console.WriteLine("Equilateral");

            } else if (angleSum == 180 && angleA == angleB || angleB == angleC || angleC == angleA) {

                Console.WriteLine("Isosceles");

            } else if (angleSum == 180 && angleA != angleB && angleB != angleC) {

                Console.WriteLine("Scalene");

            } else if (angleSum != 180) {

                Console.WriteLine("Error");

            }
        }
    }
}
