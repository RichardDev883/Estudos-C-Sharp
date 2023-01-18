using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharpN2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com o número da conta: ");
            int numeroDaConta= int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o Titular da conta: ");
            string donoDaConta = Console.ReadLine();

            Console.WriteLine("Haverá Depósito Inicial (s/n)?");
            char  depositoInicial = char.Parse(Console.ReadLine());
            
            
            if (depositoInicial == 's')
            {
                Console.WriteLine("Digite o Depósito Inicial: ");
                double saldo = double.Parse(Console.ReadLine());

                ContaNoBanco contaNoBanco = new ContaNoBanco(numeroDaConta, donoDaConta, saldo);

                Console.WriteLine("Numero da Conta: " + numeroDaConta);
                Console.WriteLine("Titular da Conta: " + donoDaConta);
                Console.WriteLine("Saldo Total R$ " + saldo);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Entre com um valor para depósito adicional: ");

                double deposito = double.Parse(Console.ReadLine());
                contaNoBanco.Deposito(deposito);

                Console.WriteLine("Dados da Conta Atualizado: ");
                Console.WriteLine("Numero da Conta: " + numeroDaConta);
                Console.WriteLine("Titular da Conta: " + donoDaConta);
                Console.WriteLine("Saldo Total R$ " + contaNoBanco.Saldo);
            }
            else
            {
                ContaNoBanco contaNoBanco = new ContaNoBanco(numeroDaConta, donoDaConta);

                Console.WriteLine("Numero da Conta: " + numeroDaConta);
                Console.WriteLine("Titular da Conta: " + donoDaConta);
                Console.WriteLine("Saldo Total: R$ " + contaNoBanco.Saldo);

                Console.WriteLine("Entre com um valor para depósito adicional: ");

                double deposito = double.Parse(Console.ReadLine());
                contaNoBanco.Deposito(deposito);

                Console.WriteLine("Dados da Conta Atualizado: ");
                Console.WriteLine("Numero da Conta: " + numeroDaConta);
                Console.WriteLine("Titular da Conta: " + donoDaConta);
                Console.WriteLine("Saldo Total " + contaNoBanco.Saldo);

            }


        }
    }
}
    