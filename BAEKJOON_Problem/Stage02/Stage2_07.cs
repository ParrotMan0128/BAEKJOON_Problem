using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage02
{
    internal class Stage2_07
    {

        static void Main(string[] args)
        {

            string[] dices = Console.ReadLine().Split(' ');

            int dice1 = int.Parse(dices[0]);
            int dice2 = int.Parse(dices[1]);
            int dice3 = int.Parse(dices[2]);

            int price = 0;

            if (dice1 == dice2 && dice2 == dice3)
            {

                price = 10000 + 1000 * dice1;

            }
            else if (dice1 == dice2 && dice2 != dice3)
            {

                price = 1000 + 100 * dice1;

            }
            else if (dice1 != dice2 && dice2 == dice3)
            {

                price = 1000 + 100 * dice2;

            }
            else if (dice1 == dice3 && dice2 != dice3)
            {

                price = 1000 + 100 * dice1;

            }
            else
            {

                int largest = Math.Max(dice1, dice2);
                largest = Math.Max(largest, dice3);

                price = 100 * largest;

            }

            Console.WriteLine(price);

        }

    }
}
