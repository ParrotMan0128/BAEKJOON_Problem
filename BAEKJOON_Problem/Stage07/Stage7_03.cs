using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage07
{
    internal class Stage7_03
    {

        static void Main(string[] args)
        {

            char[][] inputs = new char[5][];
            int MaxLength = 0;

            for(int i = 0; i < 5; i++)
            {

                inputs[i] = Console.ReadLine().ToArray();
                if (inputs[i].Length > MaxLength) { MaxLength = inputs[i].Length; }

            }

            for(int i = 0; i < MaxLength; i++)
            {

                for(int j = 0; j < 5; j++)
                {


                    if (inputs[j].Length <= i)
                    {

                        continue;

                    }

                    Console.Write(inputs[j][i]);

                }

            }

        }

    }
}
