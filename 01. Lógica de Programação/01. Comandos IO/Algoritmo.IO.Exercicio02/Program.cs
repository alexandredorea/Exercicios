using System;

namespace Algoritmo.IO.Exercicio02
{
    internal class Program
    {
        private static void Main()
        {

            Console.Write("Digite um número inteiro e positivo: ");
            var inteiroPositivo = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write($"{inteiroPositivo * 2}");
            Console.ReadKey();
        }
    }
}
