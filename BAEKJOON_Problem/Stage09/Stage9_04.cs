using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage09
{
    internal class Stage9_04
    {
        static void Main(string[] args)
        {

            int count = 0;

            int n = int.Parse(Console.ReadLine());

            string[] inputs = Console.ReadLine().Split(' ');

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {

                numbers[i] = int.Parse(inputs[i]);

            }

            foreach (int i in numbers)
            {

                bool isPrime = true;

                if (i > 1)
                {

                    for (int j = 2; j < i; j++)
                    {

                        if (i % j == 0)
                        {

                            isPrime = false;

                        }

                    }

                    if (isPrime)
                    {

                        count++;

                    }

                }

            }

            Console.WriteLine(count);

        }
    }
}
