using System;
using System.Globalization;

namespace Exercicio_Funcionario
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario + (Salario * (porcentagem / 100.0));
        }
        public override string ToString()
        {
            return base.ToString() + Nome + ", R$" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
