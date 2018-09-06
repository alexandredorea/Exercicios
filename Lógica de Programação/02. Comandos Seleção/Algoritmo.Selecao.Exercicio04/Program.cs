using System;

namespace Algoritmo.Selecao.Exercicio04
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Informe seu nome: ");
            var nome = Console.ReadLine();

            Console.Write("Informe a quantidade de dependentes: ");
            var quantidadeDependentes = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Informe a renda bruta anual: ");
            var rendaBruta = Convert.ToDouble(Console.ReadLine());

            var descontoDependentes = quantidadeDependentes * 600.00;
            var rendaLiquida = rendaBruta - descontoDependentes;

            Console.Clear();
            var imposto = 0.0;

            if (rendaLiquida > 10000 && rendaLiquida < 30000)
                imposto = rendaLiquida * 0.05;
            else if (rendaLiquida > 30000 && rendaLiquida < 60000)
                imposto = rendaLiquida * 0.10;
            else if (rendaLiquida > 60000)
                imposto = rendaLiquida * 0.15;

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Número de dependentes: {quantidadeDependentes}");
            Console.WriteLine($"Renda Bruta: {rendaBruta}");
            Console.WriteLine($"Renda Liquida: {rendaLiquida}");
            Console.WriteLine($"Imposto: {imposto}");

        }
    }
}
