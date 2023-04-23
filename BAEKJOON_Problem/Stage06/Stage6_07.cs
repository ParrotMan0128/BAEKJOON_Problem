using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage06
{
    internal class Stage6_07
    {

        static void Main(string[] args)
        {

            int testCase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {

                string[] input = Console.ReadLine().Split(' ');

                int studentCount = int.Parse(input[0]);

                int sum = 0;
                int aboveAvg = 0;

                for (int j = 1; j <= studentCount; j++)
                {

                    sum += int.Parse(input[j]);

                }

                double avg = sum / studentCount;

                for (int j = 1; j <= studentCount; j++)
                {

                    if (double.Parse(input[j]) > avg)
                    {

                        aboveAvg++;

                    }

                }

                Console.WriteLine("{0:0.000}%", (double)aboveAvg / studentCount * 100);

            }

        }

    }
}
