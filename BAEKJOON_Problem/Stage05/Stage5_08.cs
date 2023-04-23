using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage05
{
    internal class Stage5_08
    {

        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string[] splittedInput = input.Split(' ');

            int result = 0;

            for (int i = 0; i < splittedInput.Length; i++)
            {

                if (splittedInput[i] != "")
                {

                    result++;

                }

            }

            Console.WriteLine(result);

        }
    }
}
