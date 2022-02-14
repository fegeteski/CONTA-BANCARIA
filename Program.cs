using System.Globalization;

namespace EXERCICIO_CONTA_BANCARIA
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria  conta;

            Console.Write("Entre com o número da conta: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("\nEntre com o nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("\nHavera deposito inicial (s/n): ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            { 
            Console.WriteLine("\nDigite o valor do deposito inicial: ");
            double depositoIni = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(num,titular,depositoIni);
            }
            else
            {
                conta = new ContaBancaria(num, titular);
            }

            Console.WriteLine($"\n Dados da Conta: \n {conta}");

            Console.Write("\nDeseja fazer alguma movimentação (s/n): ");

            char mov = char.Parse(Console.ReadLine());

            if ( mov == 's' || mov == 'S')
            {
                Console.Write("\nDigite (sac) para Sacar ou (dep) para Depositar:");
                string opcaoEscolida = Console.ReadLine();

                if (opcaoEscolida == "sac")
                {
                    Console.Write("\nEntre com valor para saque:");
                    double valorSac = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta.Saque(valorSac);
                    Console.WriteLine($"\n Dados da Conta Atualizado: \n {conta}");
                }

                else if (opcaoEscolida == "dep")
                {
                    Console.Write("\nEntre com valor para deposito:");
                    double valorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta.Deposito(valorDep);
                    Console.WriteLine($"\n Dados da Conta Atualizado: \n {conta}");
                }

                else
                {
                    Console.WriteLine("\nOperação invalida!");
                }
            }
            else
            {
                Console.WriteLine("\nObrigado por utilizar nosso sistema, tenha um bom dia!");
            }

        }
    }
}
