﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON_Problem.Stage11 {
    internal class Stage11_06 {

        static void Main(string[] args) {

            long n = long.Parse(Console.ReadLine());

            long times = n * (n - 1) * (n - 2) / 6;

            Console.WriteLine("{0}\n{1}", times, 3);

        }

    }
}
