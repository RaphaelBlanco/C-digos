using System;
using System.Globalization;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            
            Console.Write("Digite o Valor da compra: ");
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Console.Write("Digite a quantidade: ");
            int quant = int.Parse(Console.ReadLine());
            
            Venda v = new Venda(nome, valor, quant);

            Console.WriteLine("Valor Total da compra R$" + v.QuantidadeDesconto().ToString("f2", CultureInfo.InvariantCulture) + " Produto: " + v.Produto);
        }
    }
}
