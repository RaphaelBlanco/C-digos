
namespace Banco
{
    class Conta
    {
        private string _cliente;
        public double Saldo { get; private set; }
        public int NumeroConta { get; private set; }

        public string Cliente
        {
            get
            {
                return _cliente;
            }
            set
            {
                if (value != null && value.Length > 1)
                    _cliente = value;
            }
        }

        public Conta(string cliente, int numeroConta)
        {
            _cliente = cliente;
            NumeroConta = numeroConta;
        }

        public void Deposito(string deposito, double saldo)
        {
            if (deposito == "s")
            {
                Saldo = Saldo + saldo;
            }
        }

        public void Saque(string deposito, double saque)
        {
            if (deposito == "s")
            {
                Saldo = Saldo - saque - 5.00;
            }
        }

        public override string ToString()
        {
            return "Nome do cliente: " + _cliente + ", numero da conta: " + NumeroConta + ", saldo R$" + Saldo.ToString("f2");
        }
    }
}
