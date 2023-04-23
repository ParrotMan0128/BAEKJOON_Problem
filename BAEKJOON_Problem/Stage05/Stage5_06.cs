using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage05
{
    internal class Stage5_06
    {

        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();

            string s = Console.ReadLine();

            for (char i = 'a'; i <= 'z'; i++)
            {

                if (s.Contains(Convert.ToChar(i)))
                {

                    sb.Append(s.IndexOf(Convert.ToChar(i)) + " ");

                }
                else
                {

                    sb.Append("-1 ");

                }

            }

            Console.WriteLine(sb.ToString());

        }

    }

}
