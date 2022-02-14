using System.Globalization;

namespace EXERCICIO_CONTA_BANCARIA
{
     class ContaBancaria
    {
        public int NumConta { get;private set; }
        public string TitularConta { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numConta, string titularConta)
        {
            NumConta = numConta;
            TitularConta = titularConta;    
        }

        public ContaBancaria(int numConta, string titularConta,double saldo) : this (numConta,titularConta)
        {
           Saldo = saldo;   
        }

        public override string ToString()
        {
            return $"Conta: {NumConta}, Titular: {TitularConta}, Saldo: ${Saldo.ToString("F2",CultureInfo.InvariantCulture)}."; 
        }

        public void Deposito (double deposito)
        {
            Saldo = deposito + Saldo;
        }

        public void Saque (double saque)
        {
            Saldo = Saldo - (saque + 5.00);
        }
    }
}
