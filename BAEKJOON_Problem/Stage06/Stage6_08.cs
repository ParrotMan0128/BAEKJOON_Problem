using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage06
{
    internal class Stage6_08
    {

        static void Main(string[] args)
        {

            string word = Console.ReadLine();

            string[] alphabets = new string[8] { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {

                if (i + 1 >= word.Length) { break; }

                for (int j = 0; j < 9; j++)
                {

                    if ((word[i] + word[i + 1]).ToString() == alphabets[j])
                    {



                    }

                }

            }

        }

    }
}
