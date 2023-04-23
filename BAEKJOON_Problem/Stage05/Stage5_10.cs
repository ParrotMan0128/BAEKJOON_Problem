using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage05
{
    internal class Stage5_10
    {

        static void Main(string[] args)
        {

            string[] alphabets = { "", "", "", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };
            char[] input = Console.ReadLine().ToArray();

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {

                for (int j = 3; j < alphabets.Length; j++)
                {

                    if (alphabets[j].Contains(input[i]))
                    {

                        sum += j;

                    }

                }

            }

            Console.WriteLine(sum);

        }
    }
}
