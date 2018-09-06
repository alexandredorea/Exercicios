using System;

namespace Algoritmo.IO.Exercicio01
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Digite um nome: ");
            var nome = Console.ReadLine();

            Console.Clear();

            Console.Write($"O nome que digitou foi: {nome}");
            Console.ReadKey();
        }
    }
}
