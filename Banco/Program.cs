using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o numero da Conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Conta c = new Conta(nome, numeroConta);

            Console.WriteLine("Gostaria de realizar seu primeiro deposito? (s/n)");
            string resposta = Console.ReadLine();
            if (resposta == "s")
            {
                Console.WriteLine("Digite o valor do deposito R$");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c.Deposito(resposta, saldo);
            }
            Console.WriteLine(c);

            Console.WriteLine("Realizar um saque? (s/n)");
            string respostaSaque = Console.ReadLine();
            if (respostaSaque == "s")
            {
                Console.WriteLine("Digite o valor do saque R$");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c.Saque(respostaSaque, saque);
            }
            Console.WriteLine(c);
        }
    }
}
