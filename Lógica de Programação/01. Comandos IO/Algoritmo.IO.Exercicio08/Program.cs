using System;

namespace Algoritmo.IO.Exercicio08
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Informe o nome do cliente: ");
            var nome = Console.ReadLine();

            Console.Write("Informe a qualidade de cachorros-quente: ");
            var qtdCachorro = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a qualidade de Hambúrguer");
            var qtdHamburguer = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a qualidade de Cheeseburger");
            var qtdCheeseburger = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a qualidade de Refrigenrante");
            var qtdRefrigerante = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a qualidade de Batata frita");
            var qtdBatataFritas = Convert.ToInt32(Console.ReadLine());

            var total = (qtdCachorro * 1.00) + (qtdHamburguer * 2.0) + (qtdCheeseburger * 2.5) + (qtdRefrigerante * 2.0) + (qtdBatataFritas * 1.0);
            Console.Clear();

            Console.Write($"{nome}, tem um total a pagar de R$ {total}");
        }
    }
}
