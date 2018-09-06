using System;

namespace Algoritmo.IO.Exercicio03
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Digite uma temperatura em Fahrenheit: ");
            var fahrenheit = Convert.ToInt32(Console.ReadLine());

            double celcius = (5 / 9) * (fahrenheit - 32);
            Console.Clear();

            Console.Write($"A temperatura em Celsios é {celcius}");
            Console.ReadKey();
        }
    }
}
