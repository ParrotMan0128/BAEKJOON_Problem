using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage09
{
    internal class Stage9_05
    {

        static void Main(string[] args)
        {

            int sum = 0;
            int min = 0;

            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            bool minExist = false;

            for (int i = m; i <= n; i++)
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

                        sum += i;

                        if (!minExist)
                        {

                            minExist = true;
                            min = i;

                        }
                    }

                }

            }

            if (minExist)
            {

                Console.WriteLine(sum);
                Console.WriteLine(min);

            }
            else
            {

                Console.WriteLine(-1);

            }


        }

    }
}
