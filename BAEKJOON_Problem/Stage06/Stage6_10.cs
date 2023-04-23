using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage06
{
    internal class Stage6_10
    {

        static void Main(string[] args)
        {

            string[] inputs;
            double Credit = 0;
            string GradePoint;

            double CreditSum = 0;
            double GradePointSum = 0;

            for (int i = 0; i < 20; i++)
            {

                inputs = Console.ReadLine().Split(' ');
                Credit = double.Parse(inputs[1]);
                GradePoint = inputs[2];

                if (GradePoint != "P")
                {

                    CreditSum += Credit;

                }

                if (GradePoint == "A+")
                {

                    GradePointSum += 4.5 * Credit;

                }
                else if (GradePoint == "A0")
                {

                    GradePointSum += 4.0 * Credit;

                }
                else if (GradePoint == "B+")
                {

                    GradePointSum += 3.5 * Credit;

                }
                else if (GradePoint == "B0")
                {

                    GradePointSum += 3.0 * Credit;

                }
                else if (GradePoint == "C+")
                {

                    GradePointSum += 2.5 * Credit;

                }
                else if (GradePoint == "C0")
                {

                    GradePointSum += 2.0 * Credit;

                }
                else if (GradePoint == "D+")
                {

                    GradePointSum += 1.5 * Credit;

                }
                else if (GradePoint == "D0")
                {

                    GradePointSum += 1.0 * Credit;

                }
                else if (GradePoint == "F")
                {

                    GradePointSum += 0 * Credit;

                }

            }

            Console.WriteLine(GradePointSum / CreditSum);

        }
    }
}
