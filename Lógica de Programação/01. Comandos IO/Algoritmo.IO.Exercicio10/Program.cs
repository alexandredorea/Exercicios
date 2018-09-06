using System;

namespace Algoritmo.IO.Exercicio10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Informe o nome do funcionário: ");
            var nome = Console.ReadLine();

            Console.Write("Informe a quantidade de horas trabalhadas: ");
            var horas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe a quantidade de dependentes: ");
            var dependentes = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            var salario = horas * 12;
            var beneficios = dependentes * 40;
            var inss = salario * 0.09;
            var irrf = salario * 0.07;
            var salarioLiquido = (salario + beneficios) - (inss + irrf);

            Console.WriteLine($"O funcionário {nome}");
            Console.WriteLine("");
            Console.WriteLine("Possui de proventos: ");
            Console.WriteLine($"Salário: R$ {salario}");
            Console.WriteLine($"Valor por beneficiário: R$ {beneficios}");
            Console.WriteLine("");
            Console.WriteLine("Possui de descontos: ");
            Console.WriteLine($"INSS: R$ {inss}");
            Console.WriteLine($"IRRF: R$ {irrf}");
            Console.WriteLine("");
            Console.WriteLine($"Salário liquido: R$ {salarioLiquido}");
        }
    }
}
