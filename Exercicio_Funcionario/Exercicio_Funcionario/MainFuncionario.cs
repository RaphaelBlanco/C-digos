using System;
using System.Globalization;

namespace Exercicio_Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Digite o nome do fucionario: ");
            f.Nome = Console.ReadLine();
            Console.Write("Digite o salario: ");
            f.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados: " + f);

            Console.WriteLine("Digite a porcentagem do aumento: ");
            double por = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(por);
            Console.WriteLine("Dados atualizados: " + f);
        }
    }
}
