using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage02
{
    internal class Stage2_06
    {

        static void Main(string[] args)
        {

            string[] time = Console.ReadLine().Split(' ');

            int hour = int.Parse(time[0]);
            int minute = int.Parse(time[1]);

            int ovenTime = int.Parse(Console.ReadLine());

            int total_minute = hour * 60 + minute;
            total_minute += ovenTime;

            if (total_minute >= 1440)
            {

                total_minute -= 1440;

            }

            hour = total_minute / 60;
            minute = total_minute % 60;

            Console.WriteLine("{0} {1}", hour, minute);

        }

    }
}
