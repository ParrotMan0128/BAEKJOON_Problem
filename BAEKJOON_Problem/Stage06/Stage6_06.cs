using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage06
{
    internal class Stage6_06
    {

        static void Main(string[] args)
        {

            string word = Console.ReadLine();
            word = word.ToLower();

            int[] count = Enumerable.Repeat(0, 26).ToArray();
            int max;
            int maxIndex = 0;
            bool duplication = false;

            for (int i = 0; i < word.Length; i++)
            {

                count[word[i] - 97]++;

            }

            max = count[0];

            for (int i = 1; i < 26; i++)
            {

                if (max < count[i])
                {

                    duplication = false;
                    maxIndex = i;
                    max = count[i];

                }
                else if (max == count[i])
                {

                    duplication = true;

                }

            }

            if (duplication == false)
            {

                Console.WriteLine((char)(maxIndex + 65));

            }
            else
            {

                Console.WriteLine("?");

            }


        }
    }
}
