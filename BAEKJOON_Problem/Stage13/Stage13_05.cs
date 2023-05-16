using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage13
{
    internal class Stage13_05
    {

        static void Main(string[] args)
        {

            const int MAX_NUM = 10001;

            int n = int.Parse(Console.ReadLine());
            int[] freq = new int[MAX_NUM];

            for (int i = 0; i < n; i++)
            {

                freq[int.Parse(Console.ReadLine())]++;

            }

            using (var print = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {

                for (int i = 0; i < MAX_NUM; i++)
                {

                    if (freq[i] == 0) { continue; }

                    for (int j = 0; j < freq[i]; j++)
                    {

                        print.WriteLine(i);

                    }

                }

            }
        }
    }
}
