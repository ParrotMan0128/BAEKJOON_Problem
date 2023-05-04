using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage10
{
    internal class Stage10_03
    {

        static void Main(string[] args)
        {

            int[] xCoord = new int[3];
            int[] yCoord = new int[3];

            int newX = 0;
            int newY = 0;

            for (int i = 0; i < 3; i++)
            {

                string[] inputs = Console.ReadLine().Split(' ');
                xCoord[i] = int.Parse(inputs[0]);
                yCoord[i] = int.Parse(inputs[1]);

            }

            if (xCoord[0] == xCoord[1])
            {

                newX = xCoord[2];

            }
            else if (xCoord[0] == xCoord[2])
            {

                newX = xCoord[1];

            }
            else
            {

                newX = xCoord[0];

            }

            if (yCoord[0] == yCoord[1])
            {

                newY = yCoord[2];

            }
            else if (yCoord[0] == yCoord[2])
            {

                newY = yCoord[1];

            }
            else
            {

                newY = yCoord[0];

            }

            Console.WriteLine("{0} {1}", newX, newY);

        }

    }
}
