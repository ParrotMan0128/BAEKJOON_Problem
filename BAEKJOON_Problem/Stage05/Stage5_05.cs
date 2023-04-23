using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage05
{
    internal class Stage5_05
    {

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            string numbers = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {

                sum = sum + int.Parse(numbers[i].ToString());

            }

            Console.WriteLine(sum);

        }

    }
}
