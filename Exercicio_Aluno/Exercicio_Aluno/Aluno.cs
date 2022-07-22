using System;
using System.Globalization;

namespace Exercicio_Aluno
{
    class Aluno
    {
        public string Nome;
        public double Media;
        public double Nota1, Nota2, Nota3;

        public void MediaFinal()
        {
            Media = Nota1 + Nota2 + Nota3;

            if(Media >= 60.0)
            {
                Console.WriteLine("APROVADO: ");
            }
            else
            {
                Console.WriteLine("REPROVADO: ");
            }
        }
        public override string ToString()
        {
            return "Nome do aluno: " + Nome + ", Média: " + Media.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}