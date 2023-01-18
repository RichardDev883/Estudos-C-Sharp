using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpN2
{
    class ContaNoBanco
    {
        public int NumeroDaConta { get; private set; }
        public string DonoDaConta { get; set; }
        public char DepositoInicial { get; set; }
        public double Saldo { get; private set; }

       public ContaNoBanco()
        {

        }

        public ContaNoBanco(int numeroDaConta, string donaDaConta)
        {
            NumeroDaConta = numeroDaConta;
            DonoDaConta = donaDaConta;
            Saldo = 0.0;
        }

        public ContaNoBanco(int numeroDaConta, string donoDaConta, double saldo) : this(numeroDaConta, donoDaConta)
        {
            Saldo = saldo;
        }

        public double Deposito (double deposito)
        {
            return Saldo += deposito;
        }

    }
}
