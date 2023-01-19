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
            ContaNoBanco conta;

            Console.Write("Entre com o número da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o Titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Deseja realizar depósito inicial? (S/N): ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaNoBanco(numeroDaConta, titular, depositoInicial);
            }
            else
            {
                conta = new ContaNoBanco(numeroDaConta, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Deseja realizar um Depósito Adicional? (S/N): ");
            resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Digite o Valor: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta.Deposito(deposito);
                Console.WriteLine();
                Console.WriteLine("Dados da Conta Atualizados Após Depósito Adicional: ");
                Console.WriteLine(conta);
            }
            else
            {
                Console.WriteLine("Dados da conta inalterados: " + conta);
            }

            Console.Write("Deseja realizar um saque? (S/N): ");
            resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Digite o Valor para Saque: ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saque(saque);
                Console.WriteLine();
                Console.WriteLine("Dados da Conta Após o Saque: ");
                Console.WriteLine(conta);
            }
            else
            {
                Console.WriteLine("Programa finalizado.");
            }
   
        }
    }
}
    