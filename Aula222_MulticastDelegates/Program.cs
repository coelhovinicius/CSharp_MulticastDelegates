/* MULTICAST DELEGATES */

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using System.Globalization;
using Aula222_MulticastDelegates.Services;

namespace Aula222_MulticastDelegates
{
    class Program
    {
        delegate void BinaryNumericOperation(double n1, double n2); // Declaracao do Delegate como void

        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite outro numero: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double a = 10;
            //double b = 12;

            BinaryNumericOperation op = CalculationServices.ShowSum; // Referencia para a funcao "ShowSum" - Delegate "op"
            op += CalculationServices.ShowMax; // Referencia para mais uma funcao - "ShowMax" (referencia para 2 funcoes)

            op.Invoke(a, b); /* Invoca e executa as funcoes e parametros declarados em "op" com void, recebendo os 
                              * argumentos "a" e "b" */
            //op(a,b); // Sintaxe alternativa
        }
    }
}
