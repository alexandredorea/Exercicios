using System;

namespace Algoritmo.IO.Exercicio05
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Informe o valor do raio da circunferência: ");
            var raio = Convert.ToDouble(Console.ReadLine());

            var comprimento = 2 * Math.PI * raio;
            var area = Math.PI * Math.Pow(raio, 2);

            Console.Clear();
            Console.WriteLine($"O comprimento da circunferência é: {comprimento}");
            Console.WriteLine($"A área da circunferência é: {area}");
            Console.ReadKey();
        }
    }
}
