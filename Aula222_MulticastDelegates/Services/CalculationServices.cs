﻿/* >>> CLASSE CALCULATIONSERVICES - SERVICE <<< */
using System;

namespace Aula222_MulticastDelegates.Services
{
    class CalculationServices
    {
        public static void ShowMax(double x, double y)
        {
            double max = (x > y) ? x : y;
            Console.WriteLine(max);
        }

        public static void ShowSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine(sum);
        }
    }
}
