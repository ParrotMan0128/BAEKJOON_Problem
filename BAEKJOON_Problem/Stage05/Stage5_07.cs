using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage05
{
    internal class Stage5_07
    {

        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();

            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {

                string[] input = Console.ReadLine().Split(' ');
                int loopTime = int.Parse(input[0]);
                string s = input[1];

                sb.Clear();

                for (int j = 0; j < s.Length; j++)
                {

                    for (int k = 0; k < loopTime; k++)
                    {

                        sb.Append(s[j]);

                    }

                }

                Console.WriteLine(sb);

            }

        }
    }
}
