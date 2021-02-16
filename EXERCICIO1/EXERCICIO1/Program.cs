using System;
using System.Globalization;
namespace EXERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (S/N): ");
            char resp = char.Parse(Console.ReadLine());
            
            if (resp == 's')
            {
                Console.WriteLine("Entre o valor de deposito inicial: ");
                double depositoinicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new Conta(numero, titular, depositoinicial);

            }
            else
            {
                conta = new Conta(numero, titular);
            }


            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados; ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Saque(valor);
            Console.WriteLine("Dados da conta atualizados; ");
            Console.WriteLine(conta);
        }
    }
}
