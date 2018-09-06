using System;

namespace Algoritmo.Selecao.Exercicio02
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Informe um número qualquer: ");

            var numero = Convert.ToInt32(Console.ReadLine());
            var restoDivisao = numero % 2;

            Console.Clear();

            if (restoDivisao == 0)
                Console.Write($"O número {numero} é par");
            else
                Console.Write($"O número {numero} é ímpar");

            Console.ReadKey();
        }
    }
}
