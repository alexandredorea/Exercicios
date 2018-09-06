using System;

namespace Algoritmo.IO.Exercicio09
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Informe o nome do automóvel: ");
            var nomeAutomovel = Console.ReadLine();

            Console.Write("Informe o preço de fábrica do automóvel: ");
            var valorFabrica = Convert.ToInt32(Console.ReadLine());

            var valorImpostos = valorFabrica * 0.45;
            var percentualRevendedor = valorFabrica * 0.28;
            var valorTotal = valorFabrica + valorImpostos + percentualRevendedor;

            Console.Clear();

            Console.Write($"O automóvel {nomeAutomovel}, sai a preço final de R$ {valorTotal}. ");
        }
    }
}
