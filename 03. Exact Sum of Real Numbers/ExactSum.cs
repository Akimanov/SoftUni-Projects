﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Exact_Sum_of_Real_Numbers
{
    class ExactSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0m;
            for (int i = 0; i < n; i++)
            {
              sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);

        }
    }
}
