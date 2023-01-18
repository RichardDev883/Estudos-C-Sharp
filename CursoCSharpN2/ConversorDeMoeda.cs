using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharpN2
{
    class ConversorDeMoeda
    {

        public static double Iof = 6.0;

        public static double Conversao( double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + (total * 0.06);

            /*
             * Console.WriteLine("Cotação do dolar a atual: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dolares voce vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.Conversao(quantia, cotacao);

            Console.WriteLine("Valor a ser pago em reais = R$" + result.ToString("F2", CultureInfo.InvariantCulture));
            */
        }
    }
}
