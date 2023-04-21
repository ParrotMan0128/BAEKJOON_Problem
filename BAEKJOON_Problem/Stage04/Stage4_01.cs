using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage04
{
    internal class Stage4_01
    {

        static void Main(string[] args)
        {

            int arrayCount = int.Parse(Console.ReadLine());
            string[] array = Console.ReadLine().Split(' ');

            int searchNumber = int.Parse(Console.ReadLine());

            int count = 0;

            int[] newArray = new int[arrayCount];

            for (int i = 0; i < arrayCount; i++)
            {

                newArray[i] = int.Parse(array[i]);

            }

            foreach (int i in newArray)
            {

                if (i == searchNumber) { count++; }
            }

            Console.WriteLine(count);

        }

    }
}
