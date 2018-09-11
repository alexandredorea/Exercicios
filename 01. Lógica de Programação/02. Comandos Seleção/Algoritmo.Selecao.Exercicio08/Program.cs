using System;
using System.Globalization;

namespace Algoritmo.Selecao.Exercicio08
{
	internal class Program
	{
		private static void Main()
		{
			Console.Write("Informe a primeira nota: ");
			var nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Clear();

			Console.Write("Informe a segunda nota: ");
			var nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Clear();

			Console.Write("Informe a terceira nota: ");
			var nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			Console.Clear();

			var soma = (nota1 + nota2 + nota3);
			Console.Write(soma.ToString("F", CultureInfo.InvariantCulture));

			if (soma < 60.00)
				Console.Write("Dependência");

			Console.ReadKey();
		}
	}
}
