/* >>> CLASSE CALCULATIONSERVICES - SERVICE <<< */
using System;

namespace Aula222_MulticastDelegates.Services
{
    class CalculationServices
    {
        public static void ShowMax(double x, double y) // Void, pois sera solicitada em Multicast
        {
            double max = (x > y) ? x : y;
            Console.WriteLine("Maior numero: " + max);
        }

        public static void ShowSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine("Soma: " + sum);
        }
    }
}
