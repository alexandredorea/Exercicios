using System;

namespace Algoritmo.Selecao.Exercicio03
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Informe um número: ");
            var numero = Convert.ToDouble(Console.ReadLine());
            var raizQuadrada = Math.Sqrt(numero);

            Console.Clear();

            if (numero > 0)
            {
                Console.WriteLine("Número maior que zero.");
                Console.WriteLine($"A raiz quadra deste número é: {raizQuadrada}");
            }
            else if (numero < 0)
                Console.WriteLine("Não é possível calcular a raiz deste número.");
            else
                Console.WriteLine("Número nulo");

            Console.ReadKey();
        }
    }
}
