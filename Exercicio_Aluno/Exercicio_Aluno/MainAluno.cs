using System;
using System.Globalization;

namespace Exercicio_Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno A = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            A.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno nos trimestres: ");
            A.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A.MediaFinal();

            Console.WriteLine(A);
        }
    }
}
