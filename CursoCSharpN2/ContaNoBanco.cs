using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharpN2
{
    class ContaNoBanco
    {
        public int NumeroDaConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaNoBanco(int numeroDaConta, string titular)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
            Saldo = 0.0;
        }

        public ContaNoBanco(int numeroDaConta, string titular, double depositoInicial) : this(numeroDaConta, titular)
        {
            Saldo += depositoInicial;
        }

        public void Deposito (double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo = (Saldo - saque) - 5.00;
        }

        public override string ToString()
        {
            return "Conta: " + NumeroDaConta + ", Titular: " + Titular + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
