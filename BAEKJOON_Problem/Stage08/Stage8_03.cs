using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage08 {
    internal class Stage8_03 {

        static void Main(string[] args) {

            int testCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCase; i++) {

                int change = int.Parse(Console.ReadLine());
                int quarter = change / 25;
                change %= 25;
                int dime = change / 10;
                change %= 10;
                int nickel = change / 5;
                change %= 5;
                int penny = change;

                Console.WriteLine("{0} {1} {2} {3}", quarter, dime, nickel, penny);
            }

        }


    }
}
