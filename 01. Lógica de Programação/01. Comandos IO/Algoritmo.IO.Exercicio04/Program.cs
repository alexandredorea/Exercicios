using System;

namespace Algoritmo.IO.Exercicio04
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Informe a base do triângulo: ");
            var baseTriangulo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a altura do triângulo: ");
            var alturaTriangulo = Convert.ToInt32(Console.ReadLine());

            var areaTriangulo = baseTriangulo * alturaTriangulo / 2;
            Console.Clear();

            Console.Write($"A área calculada deste triângulo é: {areaTriangulo}");
        }
    }
}
