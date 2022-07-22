using System;

namespace Loja
{
    class Venda
    {
        private string _produto;
        public double Valor { get; private set; }   //prop + Tab + Tab
        public int Quantidade { get; private set; }
        
        //private double _valor;
        //private int _quantidade;

        /*
        public string GetProduto()
        {
            return _produto;
        }

        public void SetProduto(string produto)
        {
            _produto = produto;
        }
        */

        public string Produto
        {
            get
            {
                return _produto;
            }
            set
            {
                if(value == null && value.Length > 1)
                _produto = value;
            }
        }

        public Venda(string produto, double valor, int quantidade)
        {
            _produto = produto;
            Valor = valor;
            Quantidade = quantidade;
        }
        public double QuantidadeDesconto()
        {
            double total = Valor * Quantidade;
            if(total >= 100)
            {
                total = total - (total * 0.10);
                Console.WriteLine("Desconto aplicado!");
            }
            return total;
        }
    }
}
