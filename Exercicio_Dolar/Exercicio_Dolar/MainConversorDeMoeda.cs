using System;
using System.Globalization;

namespace Exercicio_Dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a cotação do Dolar: ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dolares você vai comprar: ");
            double val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double c = ConversorDeMoeda.Conversor(cot, val);

            Console.WriteLine("Valor a ser pago em reais: " + c.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
