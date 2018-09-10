using System;

namespace Algoritmo.Selecao.Exercicio06
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Informe uma idade: ");
            var idade = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (idade == 0)
                Console.Write("Eu sou um bebê");
            else if (idade == 1 && idade == 5)
                Console.Write("Eu sou uma criança");
            else if (idade == 6 && idade == 10)
                Console.Write("Eu sou um garotinho");
            else if (idade == 11 && idade == 15)
                Console.Write("Eu sou um pré-adolescente");
            else if (idade == 16 && idade == 25)
                Console.Write("Eu sou jovem");
            else if (idade == 26 && idade == 45)
                Console.Write("Eu sou adulto");
            else if (idade == 46 && idade == 60)
                Console.Write("Eu sou adulto idoso");
            else if (idade == 61 && idade == 120)
                Console.Write("Eu já estou velho");
            else if (idade > 120)
                Console.Write("Eu já morri");

            Console.ReadKey();
        }
    }
}
