using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage03
{
    internal class Stage3_04
    {

        static void Main(string[] args)
        {

            int totalPrice = int.Parse(Console.ReadLine());
            int totalType = int.Parse(Console.ReadLine());

            string[] inputs;
            int price, count;
            int sum = 0;

            for (int i = 0; i < totalType; i++)
            {

                inputs = Console.ReadLine().Split(' ');
                price = int.Parse(inputs[0]);
                count = int.Parse(inputs[1]);

                sum += price * count;

            }

            if (totalPrice == sum)
            {

                Console.WriteLine("Yes");

            }
            else
            {

                Console.WriteLine("No");

            }

        }

    }
}
