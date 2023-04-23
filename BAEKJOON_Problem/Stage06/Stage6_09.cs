using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage06
{
    internal class Stage6_09
    {

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            bool[] check;

            int count = 0;

            for (int i = 0; i < n; i++)
            {

                char[] s = Console.ReadLine().ToArray();
                check = Enumerable.Repeat(false, 26).ToArray();

                check[s[0] - 97] = true;

                for (int j = 0; j < s.Length - 1; j++)
                {

                    if (s[j] == s[j + 1])
                    {

                        continue;

                    }
                    else if (s[j] != s[j + 1] && check[s[j + 1] - 97] == false)
                    {

                        check[s[j + 1] - 97] = true;

                    }
                    else
                    {

                        count++;
                        break;

                    }

                }

            }

            Console.WriteLine(n - count);

        }

    }
}
