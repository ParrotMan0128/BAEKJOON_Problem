using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage09
{
    internal class Stage9_06
    {

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            while (n > 1)
            {

                for (int i = 2; i <= n; i++)
                {

                    if (n % i == 0)
                    {

                        Console.WriteLine(i);
                        n /= i;
                        break;

                    }
                }

            }
        }

    }
}
