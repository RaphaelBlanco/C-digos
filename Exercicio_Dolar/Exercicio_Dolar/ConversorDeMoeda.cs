using System;

namespace Exercicio_Dolar
{
    class ConversorDeMoeda
    {
        public static double iof = 0.06;
        public static double Conversor(double Cotação, double Valor)
        {
            double res = Cotação * Valor;
            return res + res * iof;
        }
    }
}
