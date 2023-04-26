using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace BAEKJOON_Problem.Stage08
{
    internal class Stage8_01
    {

        static void Main(string[] args)
        {

            var inputs = Console.ReadLine().Split(' ');

            var N = inputs[0];
            var B = int.Parse(inputs[1]);

            var Length = N.Length - 1;

            var result = 0;

            for (var i = 0; i <= Length; i++)
            {

                var Num = (int)Math.Pow(B, Length - i);
                result += N[i] >= '0' && N[i] <= '9' ? (N[i] - '0') * Num : (N[i] - 55) * Num;

            }

            Console.WriteLine(result);

        }

    }
}
