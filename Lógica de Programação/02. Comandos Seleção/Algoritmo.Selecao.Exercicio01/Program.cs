using System;

namespace Algoritmo.Selecao.Exercicio01
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Informe o primeiro número: ");
            var primeiroNumero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            var segundoNumero = Convert.ToInt32(Console.ReadLine());

            if (primeiroNumero > segundoNumero)
                Console.WriteLine($"{primeiroNumero} > {segundoNumero}");
            else
                Console.WriteLine($"{segundoNumero} > {primeiroNumero}");
        }
    }
}
