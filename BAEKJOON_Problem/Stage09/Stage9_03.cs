using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage09
{
    internal class Stage9_03
    {

        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();

            while (true)
            {

                int input = int.Parse(Console.ReadLine());
                int sum = 0;

                sb.Clear();

                sb.Append(input.ToString() + " = ");

                if (input == - 1)
                {

                    break;

                }

                for (int i = 1; i < input; i++)
                {

                    if (input % i == 0)
                    {

                        sum += i;
                        sb.Append(i.ToString() + " + ");

                    }

                }

                sb.Remove(sb.Length - 2, 2);

                if (input == sum)
                {

                    Console.WriteLine(sb.ToString());

                } else
                {

                    Console.WriteLine("{0} is NOT perfect.", input);

                }

            }

        }

    }
}
