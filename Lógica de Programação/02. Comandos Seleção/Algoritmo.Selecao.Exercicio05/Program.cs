using System;

namespace Algoritmo.Selecao.Exercicio05
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Informe o tamanho do primeiro lado do triângulo: ");
	        var ladoX = Convert.ToInt32(Console.ReadLine());
			Console.Clear();

	        Console.Write("Informe o tamanho do segundo lado do triângulo: ");
	        var ladoY = Convert.ToInt32(Console.ReadLine());
	        Console.Clear();

			Console.Write("Informe o tamanho do terceiro lado do triângulo: ");
	        var ladoZ = Convert.ToInt32(Console.ReadLine());
	        Console.Clear();

			if (ladoX > (ladoY + ladoZ) || ladoY > (ladoX + ladoZ) || ladoZ > (ladoY + ladoX))
				Console.WriteLine("Não é um triângulo");
	        else
	        {
		        if (ladoX == ladoY && ladoX == ladoZ)
			        Console.WriteLine("Este é um triângulo equilatero"); 
				else if (ladoX != ladoY && ladoX != ladoZ && ladoY != ladoZ)
			        Console.WriteLine("Este é um triângulo escaleno");
				else 
			        Console.WriteLine("Este é um triângulo isósceles");
			}

	        Console.ReadKey();
        }
    }
}
