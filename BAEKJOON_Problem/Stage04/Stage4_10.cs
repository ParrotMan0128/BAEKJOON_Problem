using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage04
{
    internal class Stage4_10
    {

        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int largest;

            double sum = 0;

            string[] inputs = Console.ReadLine().Split(' ');
            int[] scoresInt = new int[n];
            double[] scoresDouble = new double[n];

            for (int i = 0; i < n; i++)
            {

                scoresInt[i] = int.Parse(inputs[i]);

            }

            largest = scoresInt[0];

            for (int i = 1; i < n; i++)
            {

                largest = Math.Max(largest, scoresInt[i]);

            }

            for (int i = 0; i < n; i++)
            {

                scoresDouble[i] = scoresInt[i] / (double)largest * 100;

                sum += scoresDouble[i];

            }

            Console.WriteLine("{0}", sum / n);

        }

    }
}
