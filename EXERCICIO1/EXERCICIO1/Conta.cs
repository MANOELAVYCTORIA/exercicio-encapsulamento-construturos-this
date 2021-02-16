using System;
using System.Globalization;
using System.Text;

namespace EXERCICIO1
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;

        }

        public Conta(int numero, string titular, double depositoinicial) : this(numero, titular)
        {
            Deposito(depositoinicial);
        }

        public void Deposito(double quantia){

            Saldo += quantia;
            }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.0;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular +
                ", saldo: $ " + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
