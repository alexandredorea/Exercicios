using System;

namespace Algoritmo.Selecao.Exercicio07
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Informe o volume inicial de um frasco de veneno: ");
            var volumeInicial = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a vazão da bomba: ");
            var vazaoBomba = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o tempo: ");
            var tempo = Convert.ToInt32(Console.ReadLine());

            var volumeFinal = 0;
            Console.Clear();

            if (vazaoBomba * tempo > volumeInicial)
                Console.Write("Não é possível");
            else
            {
                volumeFinal = volumeInicial - (vazaoBomba * tempo);
                Console.WriteLine($"O volume de veneno restante no frasco após o uso da bomba durante este tempo foi de {volumeFinal}.");
            }
        }
    }
}
