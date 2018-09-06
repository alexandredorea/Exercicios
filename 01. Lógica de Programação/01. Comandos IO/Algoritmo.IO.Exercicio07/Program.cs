using System;

namespace Algoritmo.IO.Exercicio07
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Informe as horas: ");
            var hora = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Informe os minutos: ");
            var minuto = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Informe os segundos: ");
            var segundo = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            var valorCalculado = (hora * 3600) + (minuto * 60) + segundo;
            Console.Write($"A hora informada {hora}:{minuto}:{segundo}, tem um total de {valorCalculado} segundos.");
            Console.ReadKey();
        }
    }
}
