using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpN2
{
    class Retangulo
    {
        public double Largura;
        public double Altura;


        public double CalcularArea()
        {

            return Largura * Altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double CalcularDiagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        /*
         Retangulo x;
            x = new Retangulo();

            Console.WriteLine("Digite a altura do triangulo: ");
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a largura do triangulo: ");
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Calculando area
            Console.WriteLine("A area do Retangulo é: " + x.CalcularArea().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine();

            //Calculando Perimetro
            Console.WriteLine("O Perimetro do Triangulo é: " + x.CalcularPerimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            // Calculando Diagonal
            Console.WriteLine("A Diagonal do Triangulo é: " + x.CalcularDiagonal().ToString("F2", CultureInfo.InvariantCulture));
        */
    }
}
