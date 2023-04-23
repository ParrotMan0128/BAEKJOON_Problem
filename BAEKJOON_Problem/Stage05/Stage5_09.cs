using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage05
{
    internal class Stage5_09
    {

        static void Main(string[] args)
        {

            string[] inputs = Console.ReadLine().Split(' ');

            int a = int.Parse(Reverse(inputs[0]));
            int b = int.Parse(Reverse(inputs[1]));

            Console.WriteLine(Math.Max(a, b));

        }

        static string Reverse(string value)
        {

            char[] chars = value.ToCharArray();

            char temp = chars[0];
            chars[0] = chars[2];
            chars[2] = temp;

            string newString = new string(chars);

            return newString;

        }

    }
}
