using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharpN2
{
    class Colaborador
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public override string ToString()
        {
            return Nome + ", $"
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AumentarSalario(double aumento)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * aumento / 100.0);
        }

        /*
         * 
         * Colaborador Richard;
            Richard = new Colaborador();

            Console.Write("Digite o nome do Colaborador: ");
            Richard.Nome = Console.ReadLine();

            Console.Write("Digito o Salario Bruto: ");
            Richard.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o Imposto: ");
            Richard.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(Richard + ", Salario Liquido");

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double Aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Richard.AumentarSalario(Aumento);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + Richard + ", Salario Liquido");

        */
    }
}
