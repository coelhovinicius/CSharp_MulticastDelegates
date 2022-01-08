/* MULTICAST DELEGATES */

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using Aula222_MulticastDelegates.Services;

namespace Aula222_MulticastDelegates
{
    class Program
    {
        delegate void BinaryNumericOperation(double n1, double n2); // Declaracao do Delegate

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationServices.ShowSum; // Referencia para a funcao "ShowSum"
            op += CalculationServices.ShowMax; // Referencia para mais uma funcao - "ShowMax"

            op.Invoke(a, b);
            //op(a,b); // Sintaxe alternativa
        }
    }
}
