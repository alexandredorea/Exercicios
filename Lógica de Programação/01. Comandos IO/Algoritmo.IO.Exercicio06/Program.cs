using System;

namespace Algoritmo.IO.Exercicio06
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Informe o nome do aluno: ");
            var nome = Console.ReadLine();
            Console.Clear();

            Console.Write("Informe a nota da primeira unidade: ");
            var nota1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Informe a nota da segunda unidade: ");
            var nota2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Informe a nota da terceira unidade: "); Console.Write("");
            var nota3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Informe a nota da quarta unidade: ");
            var nota4 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            var media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.Write($"O aluno {nome}, teve média de {media}");
        }
    }
}
