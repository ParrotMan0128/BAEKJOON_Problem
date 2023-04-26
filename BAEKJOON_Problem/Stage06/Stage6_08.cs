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
            int crNum = 0;

            for (int i = 0; i < word.Length - 1; i++)
            {

                if (i < word.Length - 2)
                {

                    if (word[i].ToString() + word[i + 1].ToString() + word[i + 2].ToString() == alphabets[2])
                    {

                        count++;
                        crNum += 3;

                    }

                }

                for (int j = 0; j < 8; j++)
                {

                    if (word[i].ToString() + word[i + 1].ToString() == alphabets[j])
                    {

                        if (i > 0 && j == 7)
                        {

                            if (word[i - 1].ToString() != "d")
                            {
                                count++;
                                crNum += 2;

                            }

                        }
                        else
                        {

                            count++;
                            crNum += 2;

                        }

                    }

                }

            }

            Console.WriteLine(word.Length - crNum + count);

        }

    }
}
